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
using System.Data.Common;

namespace Connection
{
    /// <summary>
    /// Description résumée de CHM_FAMILLE_ARTICLE
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class CHM_FAMILLE_ARTICLE : System.Web.Services.WebService
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
        public DataTable getListeFamilleArticle()
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT f.CODE_FAMILLE, f.REF_FAMILLE, f.DESIGNATION_FAMILLE, f.DESCRIPTION_FAMILLE FROM FAMILLE f";
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
        public RESULT_QUERY getNewRefFAMILLE()
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {
                cmd.CommandText = "SELECT isnull(max(CODE_FAMILLE),0)+1 FROM FAMILLE";
                decimal code = (decimal)cmd.ExecuteScalar();
                res.CODE = numberToString(3, Convert.ToInt32(code));
                res.OK = true;
                res.MESSAGE = string.Format("La nouvelle ref est : {0}", res.CODE);
                trans.Commit();
            }
            catch (Exception er)
            {
                trans.Rollback();
                res.MESSAGE = er.Message;
                res.OK = false;
            }
            return res;
        }

        [WebMethod]
        public DataTable loadFamilleArticle(decimal CODE_FAMILLE)
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT f.CODE_FAMILLE, f.REF_FAMILLE, f.DESIGNATION_FAMILLE, f.DESCRIPTION_FAMILLE, f.PARENT,f.TYPE case parent when '0' then 'Grande Famille' else (select c.DESIGNATION_FAMILLE  from FAMILLE c where f.PARENT=c.CODE_FAMILLE) end   as DESIGNATION_PARENT, case parent when '0' then '' else (select c.DESCRIPTION_FAMILLE  from FAMILLE c where f.PARENT=c.CODE_FAMILLE) end   as DESCRIPTION_PARENT FROM FAMILLE f WHERE (f.CODE_FAMILLE ='" + CODE_FAMILLE + "')";
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
        public RESULT_QUERY insertFAMILLE(string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT,string TYPE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "INSERT INTO FAMILLE(REF_FAMILLE, DESIGNATION_FAMILLE, DESCRIPTION_FAMILLE, PARENT, TYPE) VALUES (@REF_FAMILLE, @DESIGNATION_FAMILLE, @DESCRIPTION_FAMILLE, @PARENT,@TYPE)";
                cmd.Parameters.Add("@REF_FAMILLE", SqlDbType.NVarChar).Value = REF_FAMILLE;
                cmd.Parameters.Add("@DESIGNATION_FAMILLE", SqlDbType.NVarChar).Value = DESIGNATION_FAMILLE;
                cmd.Parameters.Add("@DESCRIPTION_FAMILLE", SqlDbType.NVarChar).Value = DESCRIPTION_FAMILLE;
                cmd.Parameters.Add("@PARENT", SqlDbType.Decimal).Value = PARENT;
                cmd.Parameters.Add("@TYPE", SqlDbType.Char).Value = TYPE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "select max(CODE_FAMILLE) from FAMILLE";
                decimal code = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "insert into categorie (lib_categ, description_categ, code_famille, ref_categ)";
                cmd.CommandText += "values('', '', '" + code + "', '001')";
                cmd.ExecuteNonQuery();

                trans.Commit();

                res.OK = true;
                res.CODE = code.ToString();
                res.MESSAGE = "La famille de produit est enregitrée avec succès.";
            }
            catch (Exception er)
            {
                trans.Rollback();
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
                
                return res;
            }

            return res;
        }

        [WebMethod]
        public RESULT_QUERY updateFamille(decimal CODE_FAMILLE, string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "UPDATE FAMILLE SET (REF_FAMILLE=@REF_FAMILLE, DESIGNATION_FAMILLE = @DESIGNATION_FAMILLE, DESCRIPTION_FAMILLE= @DESCRIPTION_FAMILLE, PARENT=@PARENT) WHERE( CODE_FAMILLE=@CODE_FAMILLE)";
                cmd.Parameters.Add("@REF_FAMILLE", SqlDbType.NVarChar).Value = REF_FAMILLE;
                cmd.Parameters.Add("@DESIGNATION_FAMILLE", SqlDbType.NVarChar).Value = DESIGNATION_FAMILLE;
                cmd.Parameters.Add("@DESCRIPTION_FAMILLE", SqlDbType.NVarChar).Value = DESCRIPTION_FAMILLE;
                cmd.Parameters.Add("@PARENT", SqlDbType.Decimal).Value = PARENT;
                cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                trans.Commit();

                res.OK = true;
                res.CODE = CODE_FAMILLE.ToString();
                res.MESSAGE = "La famille est modifiée avec succès.";

            }
            catch (Exception er)
            {
                trans.Rollback();
                res.CODE = "";
                res.MESSAGE = er.Message;
                res.OK = false;
                return res;
            }

            return res;
        }

        [WebMethod]
        public RESULT_QUERY deleteFamille(decimal CODE_FAMILLE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "Select * from famille where parent = @parent";
                cmd.Parameters.Add("@parent", SqlDbType.Decimal).Value = CODE_FAMILLE;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    throw new Exception("Impossible de supprimer cette famille d'articles!\nCette famille est mère d'autre famille.\nVeuillez tout d'abord supprimer les familles filles.");
                cmd.Parameters.Clear();

                cmd.CommandText = "Select * from article where CODE_FAMILLE = @CODE_FAMILLE";
                cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    throw new Exception("Impossible de supprimer cette famille d'articles!\nCette famille contient des articles.\nVeuillez tout d'abord supprimer les articles de cette famille.");
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM FAMILLE WHERE( CODE_FAMILLE=@CODE_FAMILLE)";
                cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                trans.Commit();
                res.OK = true;
                res.CODE = CODE_FAMILLE.ToString();
                res.MESSAGE = "La famille article est supprimée avec succès.";
            }
            catch (Exception er)
            {
                trans.Rollback();
                res.CODE = CODE_FAMILLE.ToString();
                res.MESSAGE = er.Message;
                res.OK = false;
                return res;
            }

            return res;
        }
    }
}
