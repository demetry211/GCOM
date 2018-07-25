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
    /// Description résumée de CHM_LIGNE_ARTICLE
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class CHM_LIGNE_ARTICLE : System.Web.Services.WebService
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
        public DataTable getListeLigneArticle()
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT * FROM LIGNE_PRODUIT INNER JOIN MARQUE ON LIGNE_PRODUIT.CODE_MARQUE=MARQUE.CODE_MARQUE";
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
        public RESULT_QUERY getNewRefLigneArticle()
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {
                cmd.CommandText = "SELECT isnull(max(CODE_LIGNE),0)+1 FROM LIGNE_PRODUIT";
                decimal code = (decimal)cmd.ExecuteScalar();
                res.CODE = numberToString(6, Convert.ToInt32(code));
                res.OK = true;
                res.MESSAGE =string.Format( "La nouvelle ref est : {0}", res.CODE);
            }
            catch (Exception er)
            {
                throw er;
            }
            return res;
        }

        [WebMethod]
        public DataTable loadLigneArticle(decimal CODE_LIGNE)
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT * FROM LIGNE_PRODUIT INNER JOIN MARQUE ON LIGNE_PRODUIT.CODE_MARQUE=MARQUE.CODE_MARQUE WHERE (LIGNE_PRODUIT.CODE_LIGNE ='" + CODE_LIGNE + "')";
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
        public RESULT_QUERY insertMarque(decimal CODE_MARQUE, string REF_LIGNE, string DESIGNATION_LIGNE, string DESCRIPTION_LIGNE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {
                cmd.CommandText = "INSERT INTO LIGNE_PRODUIT(CODE_MARQUE, REF_LIGNE, DESIGNATION_LIGNE, DESCRIPTION_LIGNE) VALUES (@CODE_MARQUE, @REF_LIGNE, @DESIGNATION_LIGNE, @DESCRIPTION_LIGNE)";
                cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_MARQUE;
                cmd.Parameters.Add("@REF_LIGNE", SqlDbType.NVarChar).Value = REF_LIGNE;
                cmd.Parameters.Add("@DESIGNATION_LIGNE", SqlDbType.NVarChar).Value = DESIGNATION_LIGNE;
                cmd.Parameters.Add("@DESCRIPTION_LIGNE", SqlDbType.NVarChar).Value = DESCRIPTION_LIGNE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "select max(CODE_LIGNE) from LIGNE_PRODUIT";
                decimal code = (decimal)cmd.ExecuteScalar();

                trans.Commit();

                res.OK = true;
                res.CODE = code.ToString();
                res.MESSAGE = "La ligne de produit est enregitrée avec succès.";
            }
            catch (Exception er)
            {
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
                return res;
            }

            return res;
        }

        [WebMethod]
        public RESULT_QUERY updateMarque(decimal CODE_LIGNE, decimal CODE_MARQUE, string DESIGNATION_LIGNE, string DESCRIPTION_LIGNE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {
                cmd.CommandText = "UPDATE LIGNE_PRODUIT SET (CODE_MARQUE=@CODE_MARQUE, DESIGNATION_LIGNE = @DESIGNATION_LIGNE, DESCRIPTION_LIGNE= @DESCRIPTION_LIGNE) WHERE( CODE_LIGNE=@CODE_LIGNE)";
                cmd.Parameters.Add("@CODE_LIGNE", SqlDbType.Decimal).Value = CODE_LIGNE;
                cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_MARQUE;
                cmd.Parameters.Add("@DESIGNATION_LIGNE", SqlDbType.NVarChar).Value = DESIGNATION_LIGNE;
                cmd.Parameters.Add("@DESCRIPTION_LIGNE", SqlDbType.NVarChar).Value = DESCRIPTION_LIGNE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                trans.Commit();

                res.OK = true;
                res.CODE = CODE_MARQUE.ToString();
                res.MESSAGE = "La ligne de produit est modifiée avec succès.";

            }
            catch (Exception er)
            {
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
                return res;
            }

            return res;
        }

        [WebMethod]
        public RESULT_QUERY deleteLigne(decimal CODE_LIGNE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {
                cmd.CommandText = "DELETE FROM LIGNE_PRODUIT WHERE( CODE_LIGNE=@CODE_LIGNE)";
                cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_LIGNE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                res.OK = true;
                res.CODE = CODE_LIGNE.ToString();
                res.MESSAGE = "La ligne produit est supprimée avec succès.";
            }
            catch (Exception er)
            {
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
                return res;
            }

            return res;
        }
    }
}
