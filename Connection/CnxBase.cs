/********************************
 *
 * Classe de gestion de la persistance
 * (c)2004 DORLAC S.T.
 * http://www.d4modelizer.com
 *
 * ******************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Xml;
using System.Configuration;

namespace Connection
{
	/// <summary>
	/// CnxBase 
	/// </summary>
    public class CnxBase
    {

        /// <summary>
        /// CnxBase
        /// </summary>
        //int a;
        public static SqlConnection myConn;
        public static SqlTransaction trans;
        public static string Groupe = "Admin";
        public string chemin_bd;

        public static string Serveur;
        public static string Db;
        public static string Usr;
        public static string Pwd;
        public static string login;
        public static string DBhotel;
        public static int fermer = 0;
        public static string Code_Role = "1";
        public static string Utilisateur = "";
        public static string societe = "";
        public static string Titre = "CHM.GCM";


        private string _cnxString;
        public string cnxString
        {
            get
            {
                return _cnxString;
            }
            set
            {
                _cnxString = value;
            }
        }

        public static CnxBase instance;

        public static CnxBase getInstance()
        {
            if (instance == null)
                instance = new CnxBase();
            return instance;
        }

        private CnxBase()
        {
            Charger_Configuration();
            cnxString = "user id=" + Usr + ";Password =" + Pwd + ";data source=" + Serveur + ";initial catalog=" + Db;
            //cnxString =@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + chemin_bd + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
            //cnxString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            //cnxString = @"data source=;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|GCMDB.mdf;User Instance=true";
            //cnxString = @"Server=.\SQLEXPRESS;Database=GCMDB;Trusted_Connection=True";
            CnxBase.myConn = new SqlConnection(cnxString);
            if(CnxBase.myConn.State==ConnectionState.Closed)
                CnxBase.myConn.Open();
        }

        public static int GetIDConnexion()
        {
            //RecordsetClass Rs = new RecordsetClass();
            //Rs.Open("Select @@SPID as ID",ConnexionSQL.Cn,CursorTypeEnum.adOpenStatic,LockTypeEnum.adLockReadOnly,0);
            string reqSQL = "Select @@SPID as ID";
            //Connexion.
            return Int32.Parse(Connexion.ExecuteReq_top(reqSQL));
        }

        #region Méthodes de gestion

        /// <summary>
        /// renvoie une connexion SqlConnection ouverte
        /// </summary>
        public SqlConnection OpenConnection()
        {
            try
            {
                Charger_Configuration();
                cnxString = "user id=" + Usr + ";Password =" + Pwd + ";data source=" + Serveur + ";initial catalog=" + Db;
                SqlConnection cn = new SqlConnection(cnxString);
                cn.Open();
                return cn;
            }
            catch (Exception myException)
            {
                throw (new Exception(myException.Message));
            }
        }

        /// <summary>
        /// ferme la connexion SqlConnection reçue
        /// </summary>
        public void CloseConnection(SqlConnection mySqlConnection)
        {
            try
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
            catch (Exception myException)
            {
                throw (new Exception(myException.Message));
            }
        }


        /// <summary>
        /// renvoie un DataSet selon la requête donnée
        /// </summary>
        public static DataTable GetDataTable(string strSQL)
        {

            try
            {

                SqlDataAdapter myDataAdapter = new SqlDataAdapter(strSQL, CnxBase.myConn);
                myDataAdapter.SelectCommand.Transaction = CnxBase.trans;
                DataSet myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet, "MySrcTable");

                return myDataSet.Tables["MySrcTable"];
            }
            catch (Exception myException)
            {
                throw (new Exception(myException.Message + " => " + strSQL));
            }
        }

        #endregion

        private void Charger_Configuration()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(System.AppDomain.CurrentDomain.BaseDirectory + "\\Config.xml");
            XmlNode child = doc.SelectSingleNode("/Configurations");
            foreach (System.Xml.XmlNode n in child)
                if (n.Attributes["id"].Value == "x")
                {
                    for (int i = 0; i < n.ChildNodes.Count; i++)

                        switch (n.ChildNodes[i].Name)
                        {
                            case "Serveur":
                                Serveur = n.ChildNodes[i].InnerText;
                                break;
                            case "Db":
                                Db = n.ChildNodes[i].InnerText;
                                break;
                            case "Usr":
                                Usr = n.ChildNodes[i].InnerText;
                                break;
                            case "Pwd":
                                Pwd = n.ChildNodes[i].InnerText;
                                break;
                            case "Login":
                                login = n.ChildNodes[i].InnerText;
                                break;
                            case "chemin_bd":
                                chemin_bd=n.ChildNodes[i].InnerText;
                                break;
                        }
                }
        }

        public static SqlDataReader Execute(String reqSQL, SqlConnection myconn)
        {
            SqlCommand myCommand = new SqlCommand(reqSQL, myconn);
            myCommand.Transaction = CnxBase.trans;
            return (myCommand.ExecuteReader());
        }


        public static void ExecuteReq(String reqSQL, SqlConnection myconn)
        {
            SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
            myCommand.Transaction = CnxBase.trans;
            myCommand.ExecuteNonQuery();
        }
        
        public static DateTime GetDate(SqlConnection myConnexion)
        {
            DateTime D = DateTime.Now;
            string reqSQL = "Select GetDate() As DateServer";
            try
            {
                DataTable dt = Connexion.list(reqSQL);
                D = Convert.ToDateTime(dt.Rows[0]["DateServer"].ToString());
            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.Message.ToString()));
            }
            return D;
        }
    }
}


