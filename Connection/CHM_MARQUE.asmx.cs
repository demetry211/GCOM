using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Connection
{
    /// <summary>
    /// Description résumée de CHM_MARQUE
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class CHM_MARQUE : System.Web.Services.WebService
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
        public DateTime getDateS()
        {
            return (DateTime.Now);
        }

        private string numberToString(int longueur, int nombre)
        {
            string n = nombre.ToString();

            while (n.Length < longueur)
            {
                n = "0" + n;
            }

            return n;
        }

        [WebMethod]
        public DataTable getListeMarque()
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT * FROM MARQUE";
            try
            {
                dt = CnxBase.GetDataTable(reqSql);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable loadMarque(decimal CODE_MARQUE)
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT * FROM MARQUE WHERE (CODE_MARQUE ='"+CODE_MARQUE+"')";
            try
            {
                dt = CnxBase.GetDataTable(reqSql);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public RESULT_QUERY insertMarque(string REF_MARQUE, string DESIGNATION_MARQUE, string DESCRIPTION_MARQUE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "INSERT INTO MARQUE(REF_MARQUE, DESIGNATION_MARQUE, DESCRIPTION_MARQUE) VALUES (@REF_MARQUE, @DESIGNATION_MARQUE, @DESCRIPTION_MARQUE)";
                cmd.Parameters.Add("@REF_MARQUE", SqlDbType.NVarChar).Value = REF_MARQUE;
                cmd.Parameters.Add("@DESIGNATION_MARQUE", SqlDbType.NVarChar).Value = DESIGNATION_MARQUE;
                cmd.Parameters.Add("@DESCRIPTION_MARQUE", SqlDbType.NVarChar).Value = DESCRIPTION_MARQUE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();  

                cmd.CommandText="select max(CODE_MARQUE) from MARQUE";
                decimal code = (decimal)cmd.ExecuteScalar();

                trans.Commit();

                res.OK = true;
                res.CODE = code.ToString();
                res.MESSAGE = "La marque est enregitrée avec succès.";
            }
            catch(Exception er)
            {
                trans.Rollback();
                res.CODE="";
                res.MESSAGE=er.Message;
                res.OK=false;
            }
            
            return res;
        }

        [WebMethod]
        public RESULT_QUERY updateMarque(decimal CODE_MARQUE, string DESIGNATION_MARQUE, string DESCRIPTION_MARQUE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "UPDATE MARQUE SET DESIGNATION_MARQUE = @DESIGNATION_MARQUE, DESCRIPTION_MARQUE= @DESCRIPTION_MARQUE WHERE( CODE_MARQUE=@CODE_MARQUE)";
                cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_MARQUE;
                cmd.Parameters.Add("@DESIGNATION_MARQUE", SqlDbType.NVarChar).Value = DESIGNATION_MARQUE;
                cmd.Parameters.Add("@DESCRIPTION_MARQUE", SqlDbType.NVarChar).Value = DESCRIPTION_MARQUE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                trans.Commit();

                res.OK = true;
                res.CODE = CODE_MARQUE.ToString();
                res.MESSAGE = "La marque est modifiée avec succès.";
                
            }
            catch (Exception er)
            {
                trans.Rollback();
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
            }

            return res;
        }

        [WebMethod]
        public RESULT_QUERY deleteMarque(decimal CODE_MARQUE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "DELETE FROM MARQUE WHERE( CODE_MARQUE=@CODE_MARQUE)";
                cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_MARQUE;
                
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                trans.Commit();
                res.OK = true;
                res.CODE = CODE_MARQUE.ToString();
                res.MESSAGE = "La marque est supprimée avec succès.";
            }
            catch (Exception er)
            {
                trans.Rollback();
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
            }

            return res;
        }
    }
}
