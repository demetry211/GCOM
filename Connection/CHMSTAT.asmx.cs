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
    /// Description résumée de CHMSTAT
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class CHMSTAT : System.Web.Services.WebService
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
        public DataTable SELECT_NB_ARTICLE_EN_RUPTURE_STOCK()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     COUNT(*) AS NB_ARTICLE  FROM         dbo.RUPTURE_STOCK AS V_RUPTURE_STOCK", CnxBase.myConn);
            
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_DETAIL_ARTICLE_EN_RUPTURE_STOCK()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     *  FROM         dbo.RUPTURE_STOCK AS V_RUPTURE_STOCK", CnxBase.myConn);

            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns.Add("CHECKED", typeof(bool), "False");
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_NB_FACTURE()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     count(*)  FROM         dbo.FACTURE ", CnxBase.myConn);

            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            
            return dt;
        }
    }
}
