using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data.SqlClient;
using System;

namespace Connection
{
    /// <summary>
    /// Description résumée de CHMGACCES
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class CHMGACCES : System.Web.Services.WebService
    {

        CnxBase cn = CnxBase.getInstance();
        [WebMethod]
        public void Connection()
        {
            cn.OpenConnection();
        }

        [WebMethod]
        public void close()
        {
            CnxBase.myConn.Close();
        }

        [WebMethod]
        public DateTime getDate()
        {
            return (DateTime.Now);
        }

        [WebMethod]
        public DataTable GetMENU()
        {

            string reqSQL = "select * from MENU";
            try
            {

                DataTable myResult = CnxBase.GetDataTable(reqSQL);
                return myResult;
            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }

        [WebMethod]
        public DataTable GetACCES_MENU()
        {

            string reqSQL = "select * from ACCES_MENU";
            try
            {

                DataTable myResult = CnxBase.GetDataTable(reqSQL);
                return myResult;
            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }

        [WebMethod]
        public DataTable GetGROUPE_USERS(decimal codeCurrentGroupeUser)
        {

            string reqSQL = string.Empty;
            if (codeCurrentGroupeUser != 1)
            {
                reqSQL="SELECT * FROM FONCTION_UTILISATEUR WHERE CODE_FONCTION_USER <> '1'";
            }
            else
            {
                reqSQL = "SELECT * FROM FONCTION_UTILISATEUR";
            }
            try
            {

                DataTable myResult = CnxBase.GetDataTable(reqSQL);
                return myResult;
            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }

        [WebMethod]
        public DataTable SELECT_FONCTION_USER()
        {
            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter("SELECT CODE_FONCTION_USER,LIB_FONCTION_USER FROM FONCTION_UTILISATEUR", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;

        }

        [WebMethod]
        public void ajouteMENU(DataTable dtMENU)
        {
            DataTable dt = GetMENU();
            DataTable dt_group_user = SELECT_FONCTION_USER();
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            CnxBase.trans = CnxBase.myConn.BeginTransaction();
            try
            {
                myCommand.Transaction = CnxBase.trans;
                foreach (DataRow dr in dtMENU.Rows)
                {
                    bool exit = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dr["CODE_MENU"].ToString() == dt.Rows[i]["CODE_MENU"].ToString())
                        {
                            exit = true;
                            break;
                        }
                    }
                    if (!exit)
                    {
                        myCommand.CommandText = "INSERT INTO MENU	(CODE_MENU, DESIGNATION_MENU, DESCRIPTION_MENU, MENU_PARENT)VALUES	(@CODE_MENU, @DESIGNATION_MENU, @DESCRIPTION_MENU, @MENU_PARENT)";
                        myCommand.Parameters.Add("@CODE_MENU", SqlDbType.NVarChar).Value = dr["CODE_MENU"].ToString();
                        myCommand.Parameters.Add("@DESIGNATION_MENU", SqlDbType.NVarChar).Value = dr["DESIGNATION_MENU"].ToString();
                        myCommand.Parameters.Add("@DESCRIPTION_MENU", SqlDbType.NVarChar).Value = dr["DESCRIPTION_MENU"].ToString();
                        myCommand.Parameters.Add("@MENU_PARENT", SqlDbType.NVarChar).Value = dr["MENU_PARENT"].ToString();
                        myCommand.ExecuteNonQuery();
                        myCommand.Parameters.Clear();
                        foreach (DataRow dr_group in dt_group_user.Rows)
                        {
                            myCommand.CommandText = "INSERT INTO ACCES_MENU	(MENU, CODE_GROUPE, VISIBLITE)VALUES	(@MENU, @CODE_GROUPE, @VISIBLITE)";
                            myCommand.Parameters.Add("@MENU", SqlDbType.NVarChar).Value = dr["CODE_MENU"].ToString();
                            myCommand.Parameters.Add("@CODE_GROUPE", SqlDbType.Decimal).Value = dr_group["CODE_FONCTION_USER"].ToString();
                            myCommand.Parameters.Add("@VISIBLITE", SqlDbType.Bit).Value = dr_group["LIB_FONCTION_USER"].ToString().ToLower() == "admin" ? 1 : 0;
                            myCommand.ExecuteNonQuery();
                            myCommand.Parameters.Clear();
                        }

                    }
                }
                CnxBase.trans.Commit();
            }
            catch (Exception er)
            {
                CnxBase.trans.Rollback();
                throw (new Exception(er.ToString() + myCommand.CommandText));
            }

        }

        [WebMethod]
        public void saveAccesGroupUser(string code_groupe, DataTable dt)
        {
            DataTable dt_acces_gu = GetACCES_MENU();
            

            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            CnxBase.trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = CnxBase.trans;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dt_acces_gu.DefaultView.RowFilter = "MENU like '" + dr["MENU"].ToString() + "' and CODE_GROUPE = '" + code_groupe + "'";
                    if (dt_acces_gu.DefaultView.ToTable().Rows.Count > 0)
                    {
                        myCommand.CommandText = "UPDATE  ACCES_MENU SET VISIBLITE=@VISIBLITE WHERE (	MENU LIKE @MENU ) AND( CODE_GROUPE=@CODE_GROUPE )";
                        myCommand.Parameters.Add("@MENU", SqlDbType.NVarChar).Value = dr["MENU"].ToString();
                        myCommand.Parameters.Add("@CODE_GROUPE", SqlDbType.Decimal).Value = Convert.ToDecimal(code_groupe);
                        myCommand.Parameters.Add("@VISIBLITE", SqlDbType.Bit).Value = dr["VISIBLITE"].ToString();
                    }
                    else
                    {
                        myCommand.CommandText = "INSERT into  ACCES_MENU (MENU,CODE_GROUPE,VISIBLITE ) VALUES (@MENU, @CODE_GROUPE, @VISIBLITE)";
                        myCommand.Parameters.Add("@MENU", SqlDbType.NVarChar).Value = dr["MENU"].ToString();
                        myCommand.Parameters.Add("@CODE_GROUPE", SqlDbType.Decimal).Value = Convert.ToDecimal(code_groupe);
                        myCommand.Parameters.Add("@VISIBLITE", SqlDbType.Bit).Value = dr["VISIBLITE"].ToString();
                    }
                        myCommand.ExecuteNonQuery();
                        myCommand.Parameters.Clear();
                    
                }
                CnxBase.trans.Commit();
            }
            catch (Exception myErr)
            {
                CnxBase.trans.Rollback();
                throw (new Exception(myErr.ToString() + myCommand.CommandText));
            }

        }

        [WebMethod]
        public void saveGroupUser(string designation, string description, decimal code_Privilège)
        {
            
            

            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            CnxBase.trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = CnxBase.trans;
            try
            {
                myCommand.CommandText = "select isnull(max(CODE_FONCTION_USER),1)+1 from FONCTION_UTILISATEUR";
                decimal code_fonction = (decimal)myCommand.ExecuteScalar();

                myCommand.CommandText = "INSERT INTO FONCTION_UTILISATEUR (CODE_FONCTION_USER ,LIB_FONCTION_USER ,DESC_FONCTION_USER ,CODE_PRIVILEGE) VALUES(@CODE_FONCTION_USER,@LIB_FONCTION_USER, @DESC_FONCTION_USER, @CODE_PRIVILEGE)";
                myCommand.Parameters.Add("@CODE_FONCTION_USER", SqlDbType.Decimal).Value = code_fonction;
                myCommand.Parameters.Add("@LIB_FONCTION_USER", SqlDbType.NVarChar).Value = designation;
                myCommand.Parameters.Add("@DESC_FONCTION_USER", SqlDbType.NVarChar).Value = description;
                myCommand.Parameters.Add("@CODE_PRIVILEGE", SqlDbType.Decimal).Value = code_Privilège;

                    myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                
                CnxBase.trans.Commit();
            }
            catch (Exception myErr)
            {
                CnxBase.trans.Rollback();
                throw (new Exception(myErr.ToString() + myCommand.CommandText));
            }

        }

        [WebMethod]
        public void updateGroupUser(decimal code_fonction, string designation, string description, decimal code_Privilège)
        {



            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            CnxBase.trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = CnxBase.trans;
            try
            {
                
                myCommand.CommandText = "update  FONCTION_UTILISATEUR set LIB_FONCTION_USER=@LIB_FONCTION_USER ,DESC_FONCTION_USER=@DESC_FONCTION_USER ,CODE_PRIVILEGE=@CODE_PRIVILEGE WHERE CODE_FONCTION_USER=@CODE_FONCTION_USER";
                myCommand.Parameters.Add("@CODE_FONCTION_USER", SqlDbType.Decimal).Value = code_fonction;
                myCommand.Parameters.Add("@LIB_FONCTION_USER", SqlDbType.NVarChar).Value = designation;
                myCommand.Parameters.Add("@DESC_FONCTION_USER", SqlDbType.NVarChar).Value = description;
                myCommand.Parameters.Add("@CODE_PRIVILEGE", SqlDbType.Decimal).Value = code_Privilège;

                myCommand.ExecuteNonQuery();
                myCommand.Parameters.Clear();

                CnxBase.trans.Commit();
            }
            catch (Exception myErr)
            {
                CnxBase.trans.Rollback();
                throw (new Exception(myErr.ToString() + myCommand.CommandText));
            }

        }

        [WebMethod]
        public DataTable LOAD_FONCTION_USER(decimal code_fonction)
        {

            string reqSQL = "SELECT * FROM FONCTION_UTILISATEUR WHERE CODE_FONCTION_USER='"+code_fonction+"'";
            try
            {

                DataTable myResult = CnxBase.GetDataTable(reqSQL);
                return myResult;
            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }
    }
}
