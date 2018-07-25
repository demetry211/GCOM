using System;
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
    /// Description résumée de ACHAT
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ACHAT : System.Web.Services.WebService
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
        public RESULT_QUERY enregistrerCommandeFournisseur(string CODE_COMMANDE_FOURNISSEUR, DateTime DATE_COMMANDE_FOURNISSEUR, decimal CODE_USER, bool PRIORITE_COMMANDE_FOURNISSEUR, DateTime DATE_EXPIRATION_COMMANDE_FOURNISSEUR, decimal CODE_MAG, decimal CODE_FOURNISSEUR, bool RECUE, string REMARQUE, DataTable dt_detail_commande)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {


                cmd.CommandText = "select NUM_CF from societe where code_societe='1'";
                decimal compteur = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "SELECT PREFIX1_CF from SOCIETE WHERE CODE_SOCIETE='1'";
                string prefix1 = (string)cmd.ExecuteScalar();

                cmd.CommandText = "SELECT PREFIX2_CF from SOCIETE WHERE CODE_SOCIETE='1'";
                string prefix2 = (string)cmd.ExecuteScalar();

                string code_commande = string.Format("{0}{1}{2}", prefix1, compteur, prefix2);

                cmd.CommandText = "INSERT INTO COMMANDE_FOURNISSEUR (CODE_COMMANDE_FOURNISSEUR, DATE_COMMANDE_FOURNISSEUR, CODE_USER, PRIORITE_COMMANDE_FOURNISSEUR, DATE_EXPIRATION_COMMANDE_FOURNISSEUR, CODE_MAG, CODE_FOURNISSEUR, REMARQUE, MOIS_CMDFR, ANNEE_CMDFR, ADRESSE_LIVRAISON, CONTACT, TEL_CONTACT) values(@CODE_COMMANDE_FOURNISSEUR, @DATE_COMMANDE_FOURNISSEUR, @CODE_USER, @PRIORITE_COMMANDE_FOURNISSEUR, @DATE_EXPIRATION_COMMANDE_FOURNISSEUR, @CODE_MAG, @CODE_FOURNISSEUR, @REMARQUE, @MOIS_CMDFR, @ANNEE_CMDFR, @ADRESSE_LIVRAISON, @CONTACT, @TEL_CONTACT)";
                cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = code_commande;
                cmd.Parameters.Add("@DATE_COMMANDE_FOURNISSEUR", SqlDbType.DateTime).Value = DATE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
                cmd.Parameters.Add("@PRIORITE_COMMANDE_FOURNISSEUR", SqlDbType.Bit).Value = PRIORITE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@DATE_EXPIRATION_COMMANDE_FOURNISSEUR", SqlDbType.DateTime).Value = DATE_EXPIRATION_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG;
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE_FOURNISSEUR;
                cmd.Parameters.Add("@REMARQUE", SqlDbType.NVarChar).Value = REMARQUE;
                cmd.Parameters.Add("@MOIS_CMDFR", SqlDbType.NVarChar).Value = REMARQUE;
                cmd.Parameters.Add("@ANNEE_CMDFR", SqlDbType.NVarChar).Value = REMARQUE;
                cmd.Parameters.Add("@ADRESSE_LIVRAISON", SqlDbType.NVarChar).Value = REMARQUE;
                cmd.Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = REMARQUE;
                cmd.Parameters.Add("@TEL_CONTACT", SqlDbType.NVarChar).Value = REMARQUE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_detail_commande.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_CMD_FR (CODE_COMMANDE_FOURNISSEUR, CODE_ARTICLE, QTE_LIGNE_COMMANDE, PRIX_ARTICLE) values(@CODE_COMMANDE_FOURNISSEUR, @CODE_ARTICLE, @QTE_LIGNE_COMMANDE, @PRIX_ARTICLE)";
                    cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = code_commande;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE_LIGNE_COMMANDE", SqlDbType.Decimal).Value = (decimal)dr["QTE_LIGNE_COMMANDE"];
                    cmd.Parameters.Add("@PRIX_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ARTICLE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                trans.Commit();
                res.CODE = code_commande;
                res.MESSAGE = "Commande fournisseur enregistrée avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
                trans.Rollback();
                throw er;
            }
            return res;
        }


        [WebMethod]
        public DataTable SELECT_ALL_CMDFR()
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT        COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.CODE_USER, ";
            reqSql += " COMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR,  ";
            reqSql += "   COMMANDE_FOURNISSEUR.ANNEE_CMDFR, COMMANDE_FOURNISSEUR.MOIS_CMDFR, FOURNISSEUR.REF_FOURNISSEUR, FOURNISSEUR.RS_FOURNISSEUR,  ";
            reqSql += "   SUM(LG_CMD_FR.QTE_LIGNE_COMMANDE * LG_CMD_FR.PRIX_HT_LGCMDFR) AS TOTAL_HT, SUM((LG_CMD_FR.QTE_LIGNE_COMMANDE * LG_CMD_FR.PRIX_HT_LGCMDFR)  ";
            reqSql += "   * (1 + LG_CMD_FR.TAUX_TVA_LGCMDFR)) AS TOTAL_TTC, UTILISATEUR.PRENOM_USER + ' ' + UTILISATEUR.NOM_USER AS NOM_UTILISATEUR ";
            reqSql += "FROM            COMMANDE_FOURNISSEUR INNER JOIN ";
            reqSql += "             FOURNISSEUR ON COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR = FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN ";
            reqSql += "    LG_CMD_FR ON COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR = LG_CMD_FR.CODE_COMMANDE_FOURNISSEUR INNER JOIN ";
            reqSql += "      UTILISATEUR ON COMMANDE_FOURNISSEUR.CODE_USER = UTILISATEUR. ";
            reqSql += "GROUP BY COMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.CODE_USER, ";
            reqSql += "         COMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR, COMMANDE_FOURNISSEUR.CODE_FOURNISSEUR,  ";
            reqSql += "         COMMANDE_FOURNISSEUR.ANNEE_CMDFR, COMMANDE_FOURNISSEUR.MOIS_CMDFR, FOURNISSEUR.REF_FOURNISSEUR, FOURNISSEUR.RS_FOURNISSEUR, UTILISATEUR.NOM_USER,  ";
            reqSql += "         UTILISATEUR.PRENOM_USER, UTILISATEUR.PRENOM_USER + ' ' + UTILISATEUR.NOM_USER";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn);
                //da.FillSchema(dt, SchemaType.Source);
                //da.Fill(dt);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        
    }
}
