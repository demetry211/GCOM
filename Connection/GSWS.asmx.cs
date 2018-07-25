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
    /// Description résumée de GSWS
    /// </summary>
    [WebService(Namespace = "http://192.168.1.213:10001/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class GSWS : System.Web.Services.WebService
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

        #region CHM_CLIENT Membres
        [WebMethod]
        public RESULT_QUERY DELETE_CLIENT(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;
                SqlCommand cmd = new SqlCommand("DELETE FROM CLIENT WHERE  (CODE_CLIENT= @CODE_CLIENT)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                res.MESSAGE = "Client supprimé avec succès.";
            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }
        [WebMethod]
        public RESULT_QUERY INSERT_CLIENT(string CODE, string REF, string RS, string ADRESSE, string CP, string VILLE, string PAYS, string TEL, string TEL2, string FAX, string EMAIL, bool EXO, string ATTEST_EXO, string CODE_DOUANE, string CODE_TVA, bool ETAT_CLIENT, bool COMPTE, decimal MAX_CREDIT, string RESP_CLIENT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                SqlTransaction trans = CnxBase.myConn.BeginTransaction();

                cmd.Transaction = trans;
                try
                {
                    cmd.CommandText = "SELECT     ISNULL(MAX(CODE_CLIENT), 0) + 1 FROM         CLIENT";
                    CODE = ((decimal)cmd.ExecuteScalar()).ToString();
                    res.CODE = CODE;

                    cmd.CommandText = "INSERT INTO CLIENT (CODE_CLIENT, REF_CLIENT, RS_CLIENT, ADRESSE_CLIENT, CP_CLIENT, VILLE_CLIENT, PAYS_CLIENT, TEL_CLIENT, TEL2_CLIENT, FAX_CLIENT, EMAIL_CLIENT, EXO_CLIENT, ATTEST_EXO_CLIENT, CODE_DOUANE_CLIENT, CODE_TVA_CLIENT, ETAT_CLIENT, MAX_CREDIT, RESP_CLIENT) VALUES     (@CODE_CLIENT, @REF_CLIENT, @RS_CLIENT, @ADRESSE_CLIENT, @CP_CLIENT, @VILLE_CLIENT, @PAYS_CLIENT, @TEL_CLIENT, @TEL2_CLIENT, @FAX_CLIENT, @EMAIL_CLIENT, @EXO_CLIENT, @ATTEST_EXO_CLIENT, @CODE_DOUANE_CLIENT, @CODE_TVA_CLIENT, @ETAT_CLIENT,  @MAX_CREDIT, @RESP_CLIENT)";
                    cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@REF_CLIENT", SqlDbType.NVarChar).Value = REF;
                    cmd.Parameters.Add("@RS_CLIENT", SqlDbType.NVarChar).Value = RS;
                    cmd.Parameters.Add("@ADRESSE_CLIENT", SqlDbType.NVarChar).Value = ADRESSE;
                    cmd.Parameters.Add("@CP_CLIENT", SqlDbType.NVarChar).Value = CP;
                    cmd.Parameters.Add("@VILLE_CLIENT", SqlDbType.NVarChar).Value = VILLE;
                    cmd.Parameters.Add("@PAYS_CLIENT", SqlDbType.NVarChar).Value = PAYS;
                    cmd.Parameters.Add("@TEL_CLIENT", SqlDbType.NVarChar).Value = TEL;
                    cmd.Parameters.Add("@TEL2_CLIENT", SqlDbType.NVarChar).Value = TEL2;
                    cmd.Parameters.Add("@FAX_CLIENT", SqlDbType.NVarChar).Value = FAX;
                    cmd.Parameters.Add("@EMAIL_CLIENT", SqlDbType.NVarChar).Value = EMAIL;
                    cmd.Parameters.Add("@EXO_CLIENT", SqlDbType.Bit).Value = EXO;
                    cmd.Parameters.Add("@ATTEST_EXO_CLIENT", SqlDbType.NVarChar).Value = ATTEST_EXO;
                    cmd.Parameters.Add("@CODE_DOUANE_CLIENT", SqlDbType.NVarChar).Value = CODE_DOUANE;
                    cmd.Parameters.Add("@CODE_TVA_CLIENT", SqlDbType.NVarChar).Value = CODE_TVA;
                    cmd.Parameters.Add("@ETAT_CLIENT", SqlDbType.Bit).Value = ETAT_CLIENT;
                    cmd.Parameters.Add("@RESP_CLIENT", SqlDbType.NVarChar).Value = RESP_CLIENT;
                    //cmd.Parameters.Add("@COMPTE", SqlDbType.Bit).Value = COMPTE;
                    cmd.Parameters.Add("@MAX_CREDIT", SqlDbType.Decimal).Value = MAX_CREDIT;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    cmd.CommandText = "SELECT ISNULL(MAX(CODE_COMPTE_CLIENT) , 0) + 1 FROM COMPTE_CLIENT";
                    decimal code_compte = (decimal)cmd.ExecuteScalar();
                    res.CODE = code_compte.ToString();

                    string num_compte = "CMP00" + code_compte.ToString() + getDateS().Year.ToString();

                    cmd.CommandText = "INSERT INTO COMPTE_CLIENT(CODE_COMPTE_CLIENT, NUM_COMPTE_CLIENT, TOTAl_CREDIT_CLT, TOTAL_PAYE_CLT, CODE_CLIENT) VALUES (@CODE_COMPTE_CLIENT, @NUM_COMPTE_CLIENT, @TOTAL_CREDIT_CLT, @TOTAL_PAYE_CLT, @CODE_CLIENT)";
                    cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = code_compte;
                    cmd.Parameters.Add("@NUM_COMPTE_CLIENT", SqlDbType.NVarChar).Value = num_compte;
                    cmd.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@TOTAL_PAYE_CLT", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "update client set compte='True' where code_client=@code_client";
                    cmd.Parameters.Add("@code_client", SqlDbType.Decimal).Value = CODE;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    trans.Commit();
                    res.MESSAGE = "Client ajouté avec succès.";
                }
                catch (Exception error)
                {
                    trans.Rollback();
                    res.OK = false;
                    res.MESSAGE = error.Message;
                }
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }
        [WebMethod]
        public System.Data.DataTable LOAD_CLIENT(string CODE)
        {
            SqlDataAdapter client_da = new SqlDataAdapter("SELECT * FROM CLIENT WHERE CODE_CLIENT= '" + CODE + "'", CnxBase.myConn);
            //client_da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
            DataTable client_dt = new DataTable();
            //client_da.FillSchema(client_dt, SchemaType.Source);
            //client_da.Fill(client_dt);
            client_dt = CnxBase.GetDataTable(client_da.SelectCommand.CommandText);
            return client_dt;
        }
        [WebMethod]
        public System.Data.DataTable SEARCH_CLIENT(string INDICE)
        {
            SqlDataAdapter client_da = new SqlDataAdapter("SELECT     * FROM CLIENT WHERE (RS_CLIENT like '%" + INDICE + "%') OR (ADRESSE_CLIENT like '%" + INDICE + "%') OR ( REF_CLIENT like '%" + INDICE + "%') OR ( EMAIL_CLIENT like '%" + INDICE + "%')", CnxBase.myConn);
            DataTable client_dt = new DataTable();
            //client_da.FillSchema(client_dt, SchemaType.Source);
            //client_da.Fill(client_dt);
            client_dt = CnxBase.GetDataTable(client_da.SelectCommand.CommandText);
            return client_dt;
        }
        [WebMethod]
        public System.Data.DataTable SELECT_ALL_CLIENTS()
        {
            DataTable client_dt = new DataTable();
            //SqlDataAdapter client_da = new SqlDataAdapter("SELECT * FROM CLIENT", CnxBase.myConn);
            try
            {
                using (SqlDataAdapter client_da = new SqlDataAdapter("SELECT * FROM CLIENT left outer join COMPTE_CLIENT on CLIENT.CODE_CLIENT=COMPTE_CLIENT.CODE_CLIENT", CnxBase.myConn))
                {

                    //client_da.FillSchema(client_dt, SchemaType.Source);
                    //client_da.Fill(client_dt);
                    client_dt = CnxBase.GetDataTable(client_da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return client_dt;
        }

        [WebMethod]
        public RESULT_QUERY UPDATE_CLIENT(string CODE, string REF, string RS, string ADRESSE, string CP, string VILLE, string PAYS, string TEL, string TEL2, string FAX, string EMAIL, bool EXO, string ATTEST_EXO, string CODE_DOUANE, string CODE_TVA, bool ETAT_CLIENT, decimal MAX_CREDIT, string RESP_CLIENT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;
                using (SqlCommand cmd = new SqlCommand("UPDATE    CLIENT SET               REF_CLIENT =@REF_CLIENT, RS_CLIENT =@RS_CLIENT, ADRESSE_CLIENT =@ADRESSE_CLIENT, CP_CLIENT =@CP_CLIENT , VILLE_CLIENT=@VILLE_CLIENT, PAYS_CLIENT=@PAYS_CLIENT, TEL_CLIENT =@TEL_CLIENT, TEL2_CLIENT =@TEL2_CLIENT, FAX_CLIENT =@FAX_CLIENT , EMAIL_CLIENT =@EMAIL_CLIENT,   EXO_CLIENT =@EXO_CLIENT, ATTEST_EXO_CLIENT =@ATTEST_EXO_CLIENT, CODE_DOUANE_CLIENT =@CODE_DOUANE_CLIENT, CODE_TVA_CLIENT =@CODE_TVA_CLIENT, ETAT_CLIENT =@ETAT_CLIENT, MAX_CREDIT=@MAX_CREDIT , RESP_CLIENT=@RESP_CLIENT WHERE  (CODE_CLIENT=@CODE_CLIENT)", CnxBase.myConn))
                {
                    cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@REF_CLIENT", SqlDbType.NVarChar).Value = REF;
                    cmd.Parameters.Add("@RS_CLIENT", SqlDbType.NVarChar).Value = RS;
                    cmd.Parameters.Add("@ADRESSE_CLIENT", SqlDbType.NVarChar).Value = ADRESSE;
                    cmd.Parameters.Add("@CP_CLIENT", SqlDbType.NVarChar).Value = CP;
                    cmd.Parameters.Add("@VILLE_CLIENT", SqlDbType.NVarChar).Value = VILLE;
                    cmd.Parameters.Add("@PAYS_CLIENT", SqlDbType.NVarChar).Value = PAYS;
                    cmd.Parameters.Add("@TEL_CLIENT", SqlDbType.NVarChar).Value = TEL;
                    cmd.Parameters.Add("@TEL2_CLIENT", SqlDbType.NVarChar).Value = TEL2;
                    cmd.Parameters.Add("@FAX_CLIENT", SqlDbType.NVarChar).Value = FAX;
                    cmd.Parameters.Add("@EMAIL_CLIENT", SqlDbType.NVarChar).Value = EMAIL;
                    cmd.Parameters.Add("@EXO_CLIENT", SqlDbType.Bit).Value = EXO;
                    cmd.Parameters.Add("@ATTEST_EXO_CLIENT", SqlDbType.NVarChar).Value = ATTEST_EXO;
                    cmd.Parameters.Add("@CODE_DOUANE_CLIENT", SqlDbType.NVarChar).Value = CODE_DOUANE;
                    cmd.Parameters.Add("@CODE_TVA_CLIENT", SqlDbType.NVarChar).Value = CODE_TVA;
                    cmd.Parameters.Add("@ETAT_CLIENT", SqlDbType.Bit).Value = ETAT_CLIENT;
                    cmd.Parameters.Add("@MAX_CREDIT", SqlDbType.Decimal).Value = MAX_CREDIT;
                    cmd.Parameters.Add("@RESP_CLIENT", SqlDbType.NVarChar).Value = RESP_CLIENT;
                    cmd.ExecuteNonQuery();
                }
                res.MESSAGE = "Client modifié avec succès.";

            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }



        [WebMethod]
        public string NEW_CODE(int nbCHIFRE)
        {
            try
            {

                using (SqlCommand cmd = new SqlCommand("SELECT     ISNULL(MAX(CODE_CLIENT), 0) + 1 FROM         CLIENT", CnxBase.myConn))
                {
                    decimal n = (decimal)cmd.ExecuteScalar();
                    string resnb = n.ToString();
                    if (nbCHIFRE > resnb.Length)
                    {
                        int rep = nbCHIFRE - resnb.Length;
                        for (int i = 0; i < rep; i++)
                        {
                            resnb = "0" + resnb;
                        }
                    }
                    return resnb;
                }
            }
            catch (Exception er)
            {
                throw er;
            }
        }




        [WebMethod]
        public DataTable SELECT_COMMANDE_CLIENT(string CODE)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE inner join client on commande.code_client=client.code_client WHERE CLIENT.CODE_CLIENT='" + CODE + "'", CnxBase.myConn))
            {
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            return dt;
        }


        [WebMethod]
        public void BLOQUER_CLIENT(string CODE_CLIENT)
        {
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE CLIENT SET ETAT_CLIENT=@ETAT_CLIENT WHERE (CODE_CLIENT=@CODE_CLIENT)";
                cmd.Parameters.Add("@ETAT_CLIENT", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                throw er;
            }
        }
        [WebMethod]
        public DataTable LOAD_COMPTE(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn))
            {

                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }


        [WebMethod]
        public void UPDATE_ETAT_COMPTE(string CODE_CLIENT)
        {

            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = CnxBase.trans;
            CnxBase.trans = CnxBase.myConn.BeginTransaction();
            try
            {
                cmd.CommandText = "UPDATE CLIENT SET COMPTE='True' WHERE (CODE_CLIENT=@CODE_CLIENT)";

                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.ExecuteNonQuery();
                CnxBase.trans.Commit();
            }
            catch (Exception er)
            {
                CnxBase.trans.Rollback();
                throw er;
            }
        }



        [WebMethod]
        public DataTable select_b_liv_client(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn))
                {

                    da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable select_facture(string CODE_CLIENT)
        {
            DataTable dt = new DataTable("MySrcTable");

            try
            {
                string reqsql = "SELECT        FACTURE.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.CODE_CLIENT, FACTURE.MONTANT_HT_FACTURE, FACTURE.MONTANT_TVA, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE, ";
                reqsql += " FACTURE.MONTANT_BASE, FACTURE.TIMBRE_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_LETTRE, FACTURE.ANNULATION_FACTURE, FACTURE.REGLER, FACTURE.CREDIT,  ";
                reqsql += "  FACTURE.MAGASIN, FACTURE.CODE_USER, FACTURE.PRENOM_USER, FACTURE.NOM_USER, FACTURE.REMARQUE, FACTURE.REMISE, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT,  ";
                reqsql += " UTILISATEUR.PRENOM_USER + ' ' + UTILISATEUR.NOM_USER AS NOM_UTILISATEUR ";
                reqsql += " FROM            FACTURE INNER JOIN ";
                reqsql += "     CLIENT ON FACTURE.CODE_CLIENT = CLIENT.CODE_CLIENT INNER JOIN ";
                reqsql += "   UTILISATEUR ON FACTURE.CODE_USER = UTILISATEUR.CODE_USER";
                reqsql += " WHERE CLIENT.CODE_CLIENT=@CODE_CLIENT";
                using (SqlDataAdapter da = new SqlDataAdapter(reqsql, CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {

                throw er;
            }


            return dt;
        }

        [WebMethod]
        public DataTable select_encoursVenteParClient(string CODE_CLIENT)
        {
            DataTable dt = new DataTable("MySrcTable");

            try
            {
                string reqsql = "select v_encours_vente.*, client.rs_client, client.ref_client, client.tel_client";
                reqsql += " from v_encours_vente inner join client on client.code_client=v_encours_vente.code_client";
                reqsql += " WHERE CLIENT.CODE_CLIENT=@CODE_CLIENT";
                using (SqlDataAdapter da = new SqlDataAdapter(reqsql, CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {

                throw er;
            }


            return dt;
        }

        [WebMethod]
        public DataTable select_encoursVente()
        {
            DataTable dt = new DataTable("MySrcTable");

            try
            {
                string reqsql = "select v_encours_vente.*, client.rs_client, client.ref_client, client.tel_client";
                reqsql += " from v_encours_vente inner join client on client.code_client=v_encours_vente.code_client";

                using (SqlDataAdapter da = new SqlDataAdapter(reqsql, CnxBase.myConn))
                {

                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {

                throw er;
            }


            return dt;
        }

        [WebMethod]
        public DCLIENT obtenirInstanceCLIENT(DCLIENT myCLIENT)
        {
            string reqSQL = "SELECT CODE_CLIENT, REF_CLIENT, RS_CLIENT, ADRESSE_CLIENT, CP_CLIENT, TEL_CLIENT, FAX_CLIENT, EMAIL_CLIENT, EXO_CLIENT, ATTEST_EXO_CLIENT, CODE_DOUANE_CLIENT, CODE_TVA_CLIENT, ETAT_CLIENT, COMPTE, VILLE_CLIENT, PAYS_CLIENT, MAX_CREDIT, TEL2_CLIENT		FROM CLIENT	WHERE (CODE_CLIENT=" + myCLIENT.CODE_CLIENT + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myCLIENT.CODE_CLIENT = (Decimal)myReader["CODE_CLIENT"];

                    myCLIENT.REF_CLIENT = (String)myReader["REF_CLIENT"];

                    myCLIENT.RS_CLIENT = (String)myReader["RS_CLIENT"];

                    myCLIENT.ADRESSE_CLIENT = (String)myReader["ADRESSE_CLIENT"];

                    myCLIENT.CP_CLIENT = (String)myReader["CP_CLIENT"];

                    myCLIENT.TEL_CLIENT = (String)myReader["TEL_CLIENT"];

                    myCLIENT.FAX_CLIENT = (String)myReader["FAX_CLIENT"];

                    myCLIENT.EMAIL_CLIENT = (String)myReader["EMAIL_CLIENT"];

                    myCLIENT.EXO_CLIENT = myReader["EXO_CLIENT"].ToString() == "True" ? 1 : 0;

                    myCLIENT.ATTEST_EXO_CLIENT = (String)myReader["ATTEST_EXO_CLIENT"];

                    myCLIENT.CODE_DOUANE_CLIENT = (String)myReader["CODE_DOUANE_CLIENT"];

                    myCLIENT.CODE_TVA_CLIENT = (String)myReader["CODE_TVA_CLIENT"];

                    myCLIENT.ETAT_CLIENT = myReader["ETAT_CLIENT"].ToString() == "True" ? 1 : 0;

                    myCLIENT.COMPTE = myReader["COMPTE"].ToString() == "True" ? 1 : 0;

                    myCLIENT.VILLE_CLIENT = (String)myReader["VILLE_CLIENT"];

                    myCLIENT.PAYS_CLIENT = (String)myReader["PAYS_CLIENT"];

                    myCLIENT.MAX_CREDIT = (Decimal)myReader["MAX_CREDIT"];

                    myCLIENT.TEL2_CLIENT = (String)myReader["TEL2_CLIENT"];


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myCLIENT;
        }
        #endregion

        #region CHM_COMPTE_CLIENT Membres
        [WebMethod]
        public RESULT_QUERY CREER_COMPTE_CLIENT(string CODE_CLIENT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            double credit = 0;
            SqlDataAdapter da = new SqlDataAdapter("SELECT CREDIT FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn);
            da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);



            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {





                cmd.CommandText = "SELECT ISNULL(MAX(CODE_COMPTE_CLIENT) , 0) + 1 FROM COMPTE_CLIENT";
                decimal code_compte = (decimal)cmd.ExecuteScalar();
                res.CODE = code_compte.ToString();

                string num_compte = "CMP00" + code_compte.ToString() + getDateS().Year.ToString();

                cmd.CommandText = "INSERT INTO COMPTE_CLIENT(CODE_COMPTE_CLIENT, NUM_COMPTE_CLIENT, TOTAl_CREDIT_CLT, TOTAL_PAYE_CLT, CODE_CLIENT) VALUES (@CODE_COMPTE_CLIENT, @NUM_COMPTE_CLIENT, @TOTAL_CREDIT_CLT, @TOTAL_PAYE_CLT, @CODE_CLIENT)";
                cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = code_compte;
                cmd.Parameters.Add("@NUM_COMPTE_CLIENT", SqlDbType.NVarChar).Value = num_compte;
                cmd.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = 0;
                cmd.Parameters.Add("@TOTAL_PAYE_CLT", SqlDbType.Decimal).Value = 0;
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "update client set compte='True' where code_client=@code_client";
                cmd.Parameters.Add("@code_client", SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Compte créer avec succès.";

            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand cmdcr = new SqlCommand("UPDATE COMPTE_CLIENT SET TOTAL_CREDIT_CLT=TOTAL_CREDIT_CLT+@TOTAL_CREDIT_CLT WHERE (CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT)", CnxBase.myConn))
                {
                    cmdcr.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["CREDIT"]);
                    cmdcr.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = res.CODE;
                    cmdcr.ExecuteNonQuery();
                    cmdcr.Parameters.Clear();
                }
            }
            return res;
        }
        [WebMethod]
        public DataTable SELECT_ALL_COMPTES_CLIENTS()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT", CnxBase.myConn))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }
        [WebMethod]
        public RESULT_QUERY UPDATE_COMPTE_CLIENT(string CODE_COMPTE_CLIENT, decimal TOTAL_PAYE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt;
            decimal credit = (decimal)0;
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {

                cmd.CommandText = "UPDATE COMPTE_CLIENT SET TOTAL_CREDIT_CLT=TOTAL_CREDIT_CLT-@TOTAL_CREDIT_CLT, TOTAL_PAYE_CLT=TOTAL_PAYE_CLT+@TOTAL_PAYE_CLT) WHERE (CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT)";
                cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                cmd.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = TOTAL_PAYE;
                cmd.Parameters.Add("@TOTAL_PAYE_CLT", SqlDbType.Decimal).Value = TOTAL_PAYE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Compte client modifié avec succès";
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }



        [WebMethod]
        public DataTable LOAD_COMPTE_CLIENT(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }
        [WebMethod]
        public DataTable SELECT_COMPTE_NON_REGLE()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CREDIT > 0", CnxBase.myConn))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }
        [WebMethod]
        public DataTable SELECT_REGLEMENTS(string CODE_COMPTE_CLIENT)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CnxBase.myConn))
            {
                da.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }



        [WebMethod]
        public void actualiser_compte(string CODE_CLIENT)
        {
            using (DataTable dt = new DataTable())
            {
                decimal credit = 0;
                SqlDataAdapter da = new SqlDataAdapter("SELECT CREDIT FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn);
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    credit += (decimal)dr["CREDIT"];
                }
                SqlCommand cmdc = new SqlCommand("SELECT CODE_COMPTE_CLIENT CLIENT FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn);
                cmdc.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                string CODE_COMPTE_CLIENT = cmdc.ExecuteScalar().ToString();
                decimal paye = 0;
                DataTable dtp = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter("SELECT MONTANT_REG_CLIENT FROM REGLEMENT_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CnxBase.myConn);
                dap.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                dap.FillSchema(dtp, SchemaType.Source);
                dap.Fill(dtp);
                foreach (DataRow dr in dtp.Rows)
                {
                    paye += (decimal)dr["MONTANT_REG_CLIENT"];
                }
                SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.Transaction = sqltrans;
                try
                {
                    cmd.CommandText = "UPDATE COMPTE_CLIENT SET TOTAL_CREDIT_CLT=@TOTAL_CREDIT_CLT, TOTAL_PAYE_CLT=@TOTAL_PAYE_CLT WHERE (CODE_CLIENT=@CODE_CLIENT)";
                    cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                    cmd.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = credit;
                    cmd.Parameters.Add("@TOTAL_PAYE_CLT", SqlDbType.Decimal).Value = paye;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    sqltrans.Commit();
                }
                catch (Exception er)
                {
                    throw er;
                }
            }
        }



        [WebMethod]
        public DataTable LOAD_COMPTE_PAR_CODE(string CODE_COMPTE_CLIENT)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CnxBase.myConn))
            {
                da.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        #endregion

        #region CHM_BON_LIVRAISON Membres
        [WebMethod]
        public DataTable LOAD_COMMANDE(string CODE_COMMANDE)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_COMMANDE like '" + CODE_COMMANDE + "'", CnxBase.myConn);
            //da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }
        [WebMethod]
        public DataTable LOAD_LG_BON_LIVRAISON(string CODE_COMMANDE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        [WebMethod]
        public DataTable Imprimer_BL(string CODE_BL)
        {
            DataTable dt = new DataTable();
            string reqSql = "SELECT     dbo.BON_DE_LIVRAISON.CODE_B_LIV, dbo.BON_DE_LIVRAISON.DATE_B_LIV, dbo.BON_DE_LIVRAISON.CODE_CLIENT, ";
            reqSql += "  dbo.BON_DE_LIVRAISON.CODE_USER, dbo.BON_DE_LIVRAISON.SOMME_B_LIV, dbo.BON_DE_LIVRAISON.FACTURED, ";
            reqSql += " dbo.BON_DE_LIVRAISON.PREPARED, dbo.BON_DE_LIVRAISON.LIVRE, dbo.LG_BON_LIVRAISON.CODE_ARTICLE, dbo.LG_BON_LIVRAISON.QTE_LIGNE_B_LIV, ";
            reqSql += " dbo.LG_BON_LIVRAISON.PRIX_HT_B_LIV, dbo.LG_BON_LIVRAISON.TVA_B_LIV, dbo.LG_BON_LIVRAISON.PRIX_TOTAL_HT, dbo.LG_BON_LIVRAISON.PRIX_U_TTC, ";
            reqSql += " dbo.LG_BON_LIVRAISON.PRIX_TOTAL_TTC, dbo.LG_BON_LIVRAISON.CODE_COMMANDE, dbo.ARTICLE.REF_ARTICLE, ";
            reqSql += " dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.UTILISATEUR.PRENOM_USER, dbo.UTILISATEUR.NOM_USER, dbo.SOCIETE.CODE_SOCIETE, dbo.SOCIETE.RS_SOCIETE, ";
            reqSql += " dbo.SOCIETE.ADRESSE_SOCIETE, dbo.SOCIETE.CP_SOCIETE, dbo.SOCIETE.TEL_SOCIETE, dbo.SOCIETE.FAX_SOCIETE, dbo.SOCIETE.EMAIL_SOCIETE, ";
            reqSql += " dbo.SOCIETE.SITE_WEB_SOCETE, dbo.SOCIETE.LOGO_SOCIETE, dbo.SOCIETE.CODE_TVA_SOCIETE, dbo.CLIENT.REF_CLIENT, dbo.CLIENT.RS_CLIENT, ";
            reqSql += " dbo.CLIENT.ADRESSE_CLIENT, dbo.CLIENT.CP_CLIENT, dbo.CLIENT.TEL_CLIENT, dbo.CLIENT.FAX_CLIENT, dbo.CLIENT.CODE_TVA_CLIENT, ";
            reqSql += " dbo.LG_BON_LIVRAISON.REMISE, dbo.CLIENT.VILLE_CLIENT, dbo.CLIENT.PAYS_CLIENT , dbo.BON_DE_LIVRAISON.CODE_MAG, dbo.MAGAZIN.NOM_MAG, dbo.LG_BON_LIVRAISON.TYPE_PIECE, dbo.LG_BON_LIVRAISON.UNITE, dbo.LG_BON_LIVRAISON.CODE_FACTURE";
            reqSql += " FROM        dbo.MAGAZIN INNER JOIN ";
            reqSql += " dbo.UTILISATEUR INNER JOIN ";
            reqSql += " dbo.LG_BON_LIVRAISON INNER JOIN";
            reqSql += " dbo.BON_DE_LIVRAISON ON dbo.LG_BON_LIVRAISON.CODE_B_LIV = dbo.BON_DE_LIVRAISON.CODE_B_LIV INNER JOIN";
            reqSql += " dbo.ARTICLE ON dbo.LG_BON_LIVRAISON.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE ON ";
            reqSql += " dbo.UTILISATEUR.CODE_USER = dbo.BON_DE_LIVRAISON.CODE_USER INNER JOIN";
            reqSql += " dbo.CLIENT ON dbo.BON_DE_LIVRAISON.CODE_CLIENT = dbo.CLIENT.CODE_CLIENT ON dbo.MAGAZIN.CODE_MAG = dbo.BON_DE_LIVRAISON.CODE_MAG CROSS JOIN";
            reqSql += " dbo.SOCIETE";
            reqSql += " WHERE BON_DE_LIVRAISON.CODE_B_LIV like '" + CODE_BL + "'";
            SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public RESULT_QUERY SAVE(DateTime DATE_B_LIV, string CODE_CLIENT, string CODE_COMMANDE, decimal CODE_MAG, string CODE_USER, DataTable dt_lg_b_liv, string[] PIECE_FI)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            res.MESSAGE = "!";
            try
            {
                cmd.CommandText = "SELECT     ISNULL(MAX(NUM_B_LIV),0) + 1 FROM         SOCIETE";
                decimal NUM_COMMANDE = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_B_LIV, '') FROM         SOCIETE";
                string PREFIX1_B_LIV = (string)cmd.ExecuteScalar();

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_B_LIV, '') FROM         SOCIETE";
                string PREFIX2_COMMANDE = (string)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_B_LIV = NUM_B_LIV +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_B_LIV = PREFIX1_B_LIV + numberToString(5, Convert.ToInt32(NUM_COMMANDE)) + PREFIX2_COMMANDE;



                decimal som = 0;
                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    som += (decimal)dr["PRIX_TOTAL_TTC"];

                }

                cmd.CommandText = "INSERT INTO BON_DE_LIVRAISON(CODE_B_LIV, DATE_B_LIV, CODE_CLIENT, CODE_COMMANDE, CODE_USER, SOMME_B_LIV,FACTURED, PREPARED, LIVRE, CODE_MAG, ANNULE) VALUES     (@CODE_B_LIV, @DATE_B_LIV, @CODE_CLIENT, @CODE_COMMANDE, @CODE_USER , @SOMME_B_LIV,@FACTURED, @PREPARED, @LIVRE, @CODE_MAG, @ANNULE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV; res.MESSAGE = "erreur code commande";
                cmd.Parameters.Add("@DATE_B_LIV", SqlDbType.DateTime).Value = DATE_B_LIV;
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "erreur insertion code user";
                cmd.Parameters.Add("@SOMME_B_LIV", SqlDbType.Decimal).Value = som;
                cmd.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "False";
                cmd.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "False";
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG;
                cmd.Parameters.Add("@ANNULE", SqlDbType.Bit).Value = "False";
                cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_BON_LIVRAISON( CODE_B_LIV, CODE_ARTICLE, QTE_LIGNE_B_LIV, PRIX_HT_B_LIV, REMISE, TVA_B_LIV, PRIX_TOTAL_HT, PRIX_U_TTC, PRIX_TOTAL_TTC, CODE_COMMANDE ) VALUES     (@CODE_B_LIV, @CODE_ARTICLE, @QTE_LIGNE_B_LIV, @PRIX_HT_B_LIV, @REMISE, @TVA_B_LIV, @PRIX_TOTAL_HT, @PRIX_U_TTC, @PRIX_TOTAL_TTC, @CODE_COMMANDE)";
                    cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE_LIGNE_B_LIV", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"];
                    cmd.Parameters.Add("@PRIX_HT_B_LIV", SqlDbType.Decimal).Value = dr["PRIX_HT_B_LIV"];
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = dr["REMISE"];
                    cmd.Parameters.Add("@TVA_B_LIV", SqlDbType.Decimal).Value = dr["TVA_B_LIV"];
                    cmd.Parameters.Add("@PRIX_TOTAL_HT", SqlDbType.Decimal).Value = (decimal)dr["PRIX_TOTAL_HT"];
                    cmd.Parameters.Add("@PRIX_U_TTC", SqlDbType.Decimal).Value = (decimal)dr["PRIX_U_TTC"];
                    cmd.Parameters.Add("@PRIX_TOTAL_TTC", SqlDbType.Decimal).Value = (decimal)dr["PRIX_TOTAL_TTC"];
                    cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = dr["CODE_COMMANDE"]; res.MESSAGE = "erreur insert ligne " + dr["CODE_ARTICLE"].ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                }
                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE=QTE_ARTICLE-@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"];

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK=QTTE_STOCK-@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_MAG=@CODE_MAG";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"];
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE LIGNE_COMMANDE SET QTE_LIVRE=QTE_LIVRE+@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_COMMANDE LIKE @CODE_COMMANDE";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"];
                    cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = dr["CODE_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE COMMANDE SET REGLEE=@REGLEE WHERE (CODE_COMMANDE=@CODE_COMMANDE)";
                    cmd.Parameters.Add("@REGLEE", SqlDbType.Bit).Value = "True";
                    cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = dr["CODE_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                cmd.CommandText = "update FICHE_INTERVENTION SET CODE_B_LIV=@CODE_B_LIV, TYPE_PIECE_REG=@TYPE_PIECE_REG WHERE NUM_FI=@NUM_FI";
                foreach (string s in PIECE_FI)
                {
                    cmd.Parameters.Add("@TYPE_PIECE_REG", SqlDbType.NVarChar).Value = "BL";
                    cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    cmd.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = s;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }





                sqltrans.Commit();

                res.MESSAGE = "Le bon de livraison est enregistré avec succès.";
                res.CODE = CODE_B_LIV;
                res.OK = true;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE += er.Message;
            }

            return res;
        }

        [WebMethod]
        public DataTable SELECT_DETAIL_COMMANDE_EN_ATTENTE_DISPONIBLE_PAR_CLIENT(decimal CODE_CLIENT, decimal CODE_MAG)
        {
            DataTable dt = new DataTable();
            try
            {
                string reqSQL = "";
                reqSQL += "SELECT     dbo.COMMANDE.CODE_COMMANDE, dbo.COMMANDE.DATE_COMMANDE, ISNULL(dbo.COMMANDE.DATE_EXPIRATION_COMMANDE, N'') ";
                reqSQL += " AS DATE_EXPIRATION_COMMANDE, dbo.ARTICLE.REF_ARTICLE, dbo.LIGNE_COMMANDE.CODE_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, ";
                reqSQL += " dbo.ARTICLE.MARQUE_ARTICLE, dbo.ARTICLE.CODE_BARRE_ARTICLE, dbo.STOCK.QTTE_STOCK, dbo.MAGAZIN.CODE_MAG, ";
                reqSQL += " dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE - dbo.LIGNE_COMMANDE.QTE_LIVRE AS QTE, dbo.COMMANDE.CODE_CLIENT ";
                reqSQL += ", dbo.ARTICLE.PRIX_HT_V_ARTICLE, dbo.TVA.TAUX_TVA as TVA_ARTICLE, dbo.ARTICLE.MAX_REMISE FROM         dbo.COMMANDE INNER JOIN ";
                reqSQL += " dbo.LIGNE_COMMANDE ON dbo.COMMANDE.CODE_COMMANDE = dbo.LIGNE_COMMANDE.CODE_COMMANDE INNER JOIN ";
                reqSQL += " dbo.ARTICLE ON dbo.LIGNE_COMMANDE.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE INNER JOIN ";
                reqSQL += " dbo.STOCK ON dbo.ARTICLE.CODE_ARTICLE = dbo.STOCK.CODE_ARTICLE AND ";
                reqSQL += " dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE - dbo.LIGNE_COMMANDE.QTE_LIVRE <= dbo.STOCK.QTTE_STOCK INNER JOIN ";
                reqSQL += " dbo.MAGAZIN ON dbo.STOCK.CODE_MAG = dbo.MAGAZIN.CODE_MAG ";
                reqSQL += " inner join TVA ON ARTICLE.CODE_TVA=TVA.CODE_TVA";
                reqSQL += " WHERE     (dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE > dbo.LIGNE_COMMANDE.QTE_LIVRE) AND (dbo.COMMANDE.CODE_CLIENT = '" + CODE_CLIENT + "') AND ";
                reqSQL += " (dbo.STOCK.CODE_MAG = '" + CODE_MAG + "')";
                dt = CnxBase.GetDataTable(reqSQL);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }



        [WebMethod]
        public RESULT_QUERY ANNULER_BL(string CODE_BL, string CODE_MAG)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSql = "SELECT CODE_ARTICLE, QTE_LIGNE_B_LIV, CODE_COMMANDE FROM LG_BON_LIVRAISON WHERE CODE_B_LIV like '" + CODE_BL + "'";

            DataTable dt = CnxBase.GetDataTable(reqSql);
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            res.MESSAGE = "!";
            try
            {


                cmd.CommandText = "UPDATE BON_DE_LIVRAISON SET ANNULE=@ANNULE WHERE CODE_B_LIV=@CODE_B_LIV"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_BL; res.MESSAGE = "erreur code commande";
                cmd.Parameters.Add("@ANNULE", SqlDbType.Bit).Value = "True";
                cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                cmd.Parameters.Clear();


                foreach (DataRow dr in dt.Rows)
                {
                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE=QTE_ARTICLE+@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK=QTTE_STOCK-@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_MAG=@CODE_MAG";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"];
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE LIGNE_COMMANDE SET QTE_LIVRE=QTE_LIVRE-@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_COMMANDE LIKE @CODE_COMMANDE";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"];
                    cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = dr["CODE_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }



                sqltrans.Commit();

                res.MESSAGE = "Le bon de livraison est annulé avec succès.";
                res.CODE = CODE_BL;
                res.OK = true;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }

            return res;
        }


        [WebMethod]
        public DataTable LOAD_SCHEMA_LG_BON_LIVRAISON()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LG_BON_LIVRAISON.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV, LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV, LG_BON_LIVRAISON.REMISE, LG_BON_LIVRAISON.PRIX_TOTAL_HT, LG_BON_LIVRAISON.PRIX_U_TTC, LG_BON_LIVRAISON.PRIX_TOTAL_TTC, LG_BON_LIVRAISON.CODE_COMMANDE, 0 AS QTTE_STOCK, 0 AS MAX_REMISE FROM         LG_BON_LIVRAISON INNER JOIN ARTICLE ON LG_BON_LIVRAISON.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE LG_BON_LIVRAISON.CODE_B_LIV='0'", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }


            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        [WebMethod]
        public DataTable[] PRINT(string CODE_B_LIV)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("", CnxBase.myConn))
                {
                    DataTable dt_societe = new DataTable();
                    da.SelectCommand.CommandText = "SELECT CODE_SOCIETE, RS_SOCIETE, DESCRIPTION_SOCIETE, ADRESSE_SOCIETE, CP_SOCIETE, TEL_SOCIETE, FAX_SOCIETE, EMAIL_SOCIETE, SITE_WEB_SOCETE, LOGO_SOCIETE, CODE_TVA_SOCIETE, RIB_SOCIETE, NUM_COMMANDE, PREFIX1_COMMANDE, PREFIX2_COMMANDE, PREFIX1_FACTURE, NUM_FACTURE, PREFIX1_FACTURE, PREFIXE2_FACTURE FROM dbo.SOCIETE";
                    da.Fill(dt_societe);
                    DataTable dt_b_liv = new DataTable();
                    da.SelectCommand.CommandText = "SELECT     BON_DE_LIVRAISON.CODE_B_LIV, BON_DE_LIVRAISON.DATE_B_LIV, BON_DE_LIVRAISON.CODE_CLIENT, BON_DE_LIVRAISON.CODE_COMMANDE, BON_DE_LIVRAISON.CODE_USER,  CLIENT.REF_CLIENT, CLIENT.RS_CLIENT, CLIENT.ADRESSE_CLIENT, CLIENT.CP_CLIENT FROM         BON_DE_LIVRAISON INNER JOIN CLIENT ON BON_DE_LIVRAISON.CODE_CLIENT = CLIENT.CODE_CLIENT WHERE (BON_DE_LIVRAISON.CODE_B_LIV = @CODE_B_LIV)";
                    da.SelectCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    da.Fill(dt_b_liv);
                    da.SelectCommand.Parameters.Clear();
                    DataTable dt_lg_b_liv = new DataTable();
                    da.SelectCommand.CommandText = "SELECT     LG_BON_LIVRAISON.CODE_B_LIV, LG_BON_LIVRAISON.CODE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV, LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, ARTICLE.PHOTO_ARTICLE FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LG_BON_LIVRAISON.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE     (LG_BON_LIVRAISON.CODE_B_LIV = @CODE_B_LIV)";
                    da.SelectCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    da.Fill(dt_lg_b_liv);
                    da.SelectCommand.Parameters.Clear();
                    DataTable[] tab = { dt_b_liv, dt_lg_b_liv, dt_societe };
                    return tab;
                }
            }
            catch (Exception er)
            {
                throw er;
            }
        }



        [WebMethod]
        public DataTable SELECT_B_LIV_FACTURE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE FACTURED='1'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "True";
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_B_LIV_LIVRE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE LIVRE='1'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "True";
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable SELECT_B_LIV_NON_FACTURE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE FACTURED='0'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "False";
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable SELECT_B_LIV_NON_LIVRE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE LIVRE='0'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "False";
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable SELECT_B_LIV_NON_PREPARE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE PREPARED='0'", CnxBase.myConn))
            {
                //da.SelectCommand.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "False";
                //da.FillSchema(dt, SchemaType.Source);
                //da.Fill(dt);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            return dt;
        }
        [WebMethod]
        public DataTable SELECT_B_LIV_PREPARE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE PREPARED='1'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "True";
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public void UPDATE_FACTURE(string CODE_B_LIV, bool param)
        {
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE BON_DE_LIVRAISON SET FACTURED=@FACTURED WHERE (CODE_B_LIV=@CODE_B_LIV)";
                cmd.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = param;
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                throw er;
            }
        }
        [WebMethod]
        public void UPDATE_LIVRE(string CODE_B_LIV)
        {
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE BON_DE_LIVRAISON SET LIVRE=@LIVRE WHERE (CODE_B_LIV=@CODE_B_LIV)";
                cmd.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                throw er;
            }
        }
        [WebMethod]
        public void UPDATE_PREPARE(string CODE_B_LIV)
        {
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE BON_DE_LIVRAISON SET PREPARED=@PREPARED WHERE (CODE_B_LIV=@CODE_B_LIV)";
                cmd.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "true";
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                throw er;
            }
        }




        [WebMethod]
        public DataTable SELECT_ALL_BON_LIVRAISON()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT *, PRENOM_USER+' '+NOM_USER as UTIL FROM BON_DE_LIVRAISON inner join magazin on BON_DE_LIVRAISON.CODE_MAG=MAGAZIN.CODE_MAG INNER JOIN UTILISATEUR ON UTILISATEUR.CODE_USER=BON_DE_LIVRAISON.CODE_USER inner join client on bon_de_livraison.code_client=client.code_client order by DATE_B_LIV desc", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable RECHERCHE(string param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE (CODE_B_LIV LIKE '%" + param + "%') OR (DATE_B_LIV LIKE '%" + param + "%') OR (CODE_COMMANDE LIKE '%" + param + "%') ", CnxBase.myConn);
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



        #endregion

        #region CHM_ARTICLE Membres

        [WebMethod]
        public DataTable rafrechirMAJPrix(DataTable dt_import, decimal code_user, decimal code_maj, string description)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Transaction = trans;
            try
            {

                cmd.CommandText = "delete from DETAIL_MAJ where CODE_MAJ_P=@CODE_MAJ_P";
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "update MAJ_PRIX set DESCRIPTION_MAJ=@DESCRIPTION_MAJ, USER_IMPORTATION=@USER_IMPORTATION, DATE_IMPORTATION=@DATE_IMPORTATION WHERE (CODE_MAJ_P=@CODE_MAJ_P)";
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;
                cmd.Parameters.Add("@DESCRIPTION_MAJ", SqlDbType.NVarChar).Value = description;
                cmd.Parameters.Add("@USER_IMPORTATION", SqlDbType.Decimal).Value = code_user;
                cmd.Parameters.Add("@DATE_IMPORTATION", SqlDbType.DateTime).Value = DateTime.Now;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                DataTable dtArt = new DataTable();
                foreach (DataRow dr in dt_import.Rows)
                {
                    dtArt.Rows.Clear();
                    cmd.CommandText = "select code_article,PRIX_HT_V_ARTICLE  from article where article.code_barre_article like @code_barre";
                    cmd.Parameters.Add("@code_barre", SqlDbType.NVarChar).Value = dr["F1"].ToString();
                    da.SelectCommand = cmd;
                    da.FillSchema(dtArt, SchemaType.Source);
                    da.Fill(dtArt);
                    //if(dtArt.Rows.Count>1)
                    //    throw new Exception(string.Format("Le code a barre {0} est trouvé dans plusieurs article,\non ne peut pas continuer.", dr["F1"]));
                    cmd.Parameters.Clear();


                    cmd.CommandText = "insert into DETAIL_MAJ(CODE_MAJ_P, CODE_ARTICLE, CODE_BARRE, ANCIEN_PV,NOUVEAU_PV,MAJ) VALUES(@CODE_MAJ_P, @CODE_ARTICLE, @CODE_BARRE, @ANCIEN_PV,@NOUVEAU_PV,@MAJ)";
                    cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dtArt.Rows.Count != 1 ? DBNull.Value : dtArt.Rows[0]["CODE_ARTICLE"];
                    cmd.Parameters.Add("@CODE_BARRE", SqlDbType.NVarChar).Value = dr["F1"].ToString();
                    cmd.Parameters.Add("@ANCIEN_PV", SqlDbType.Decimal).Value = dtArt.Rows.Count != 1 ? 0 : (decimal)dtArt.Rows[0]["PRIX_HT_V_ARTICLE"];
                    cmd.Parameters.Add("@NOUVEAU_PV", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["F2"].ToString().Trim().Replace('.', ','));
                    cmd.Parameters.Add("@MAJ", SqlDbType.Bit).Value = "False";

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                cmd.CommandText = "Select * from V_DETAIL_MAJ_PRIX where CODE_MAJ_P=@CODE_MAJ_P";
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;


                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);

                trans.Commit();
            }
            catch (Exception er)
            {
                trans.Rollback();
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable importMAJPrix(DataTable dt_import, string description, decimal code_user)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                decimal code_maj;
                cmd.CommandText = "SELECT isnull(MAX(CODE_MAJ_P),1)+1 from MAJ_PRIX";
                code_maj = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "Insert into MAJ_PRIX(CODE_MAJ_P,DESCRIPTION_MAJ, USER_IMPORTATION, DATE_IMPORTATION,VALIDEE, ANNULEE) VALUES(@CODE_MAJ_P,@DESCRIPTION_MAJ, @USER_IMPORTATION, @DATE_IMPORTATION,@VALIDEE, @ANNULEE)";
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;
                cmd.Parameters.Add("@DESCRIPTION_MAJ", SqlDbType.NVarChar).Value = description;
                cmd.Parameters.Add("@USER_IMPORTATION", SqlDbType.Decimal).Value = code_user;
                cmd.Parameters.Add("@DATE_IMPORTATION", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@VALIDEE", SqlDbType.Bit).Value = "False";
                cmd.Parameters.Add("@ANNULEE", SqlDbType.Bit).Value = "False";

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dtArt = new DataTable();
                foreach (DataRow dr in dt_import.Rows)
                {
                    dtArt.Rows.Clear();
                    cmd.CommandText = "select code_article,PRIX_HT_V_ARTICLE  from article where article.code_barre_article like @code_barre";
                    cmd.Parameters.Add("@code_barre", SqlDbType.NVarChar).Value = dr["F1"].ToString();
                    da.SelectCommand = cmd;
                    da.FillSchema(dtArt, SchemaType.Source);
                    da.Fill(dtArt);
                    //if(dtArt.Rows.Count>1)
                    //    throw new Exception(string.Format("Le code a barre {0} est trouvé dans plusieurs article,\non ne peut pas continuer.", dr["F1"]));
                    cmd.Parameters.Clear();


                    cmd.CommandText = "insert into DETAIL_MAJ(CODE_MAJ_P, CODE_ARTICLE, CODE_BARRE, ANCIEN_PV,NOUVEAU_PV,MAJ) VALUES(@CODE_MAJ_P, @CODE_ARTICLE, @CODE_BARRE, @ANCIEN_PV,@NOUVEAU_PV,@MAJ)";
                    cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dtArt.Rows.Count != 1 ? DBNull.Value : dtArt.Rows[0]["CODE_ARTICLE"];
                    cmd.Parameters.Add("@CODE_BARRE", SqlDbType.NVarChar).Value = dr["F1"].ToString();
                    cmd.Parameters.Add("@ANCIEN_PV", SqlDbType.Decimal).Value = dtArt.Rows.Count != 1 ? 0 : (decimal)dtArt.Rows[0]["PRIX_HT_V_ARTICLE"];
                    cmd.Parameters.Add("@NOUVEAU_PV", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["F2"]);
                    cmd.Parameters.Add("@MAJ", SqlDbType.Bit).Value = "False";

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                cmd.CommandText = "Select * from V_DETAIL_MAJ_PRIX where CODE_MAJ_P=@CODE_MAJ_P";
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_maj;

                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);

                trans.Commit();
            }
            catch (Exception er)
            {
                trans.Rollback();
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable loadMAJPrix(decimal code_MAJP)
        {
            string reqSql = "Select * from V_LISTE_MAJ_PRIX where CODE_MAJ_P='" + code_MAJP + "'";
            DataTable dt = new DataTable();
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
        public DataTable selectAllMAJPrix()
        {
            string reqSql = "Select * from V_LISTE_MAJ_PRIX ";
            DataTable dt = new DataTable();
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
        public DataTable loadDetailMAJPrix(decimal code_MAJP)
        {
            string reqSql = "Select * from V_DETAIL_MAJ_PRIX where CODE_MAJ_P='" + code_MAJP + "'";
            DataTable dt = new DataTable();
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
        public RESULT_QUERY validerMAJPrix(decimal code_MAJP, decimal code_user)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = "select * from V_DETAIL_MAJ_PRIX where CODE_MAJ_P=@CODE_MAJ_P";
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_MAJP;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    cmd.CommandText = "update     article set PRIX_HT_V_ARTICLE=@PRIX_HT_V_ARTICLE where CODE_BARRE_ARTICLE=@CODE_BARRE_ARTICLE";
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = dr["CODE_BARRE"].ToString();
                    cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["NOUVEAU_PV"];
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();

                    //cmd.CommandText = "update DETAIL_MAJ set(MAJ='True') where CODE_BARRE like @CODE_BARRE and CODE_MAJ_P=@CODE_MAJ_P";
                    //cmd.Parameters.Add("@CODE_BARRE", SqlDbType.NVarChar).Value = dr["CODE_BARRE"].ToString();
                    //cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_MAJP;
                    //cmd.ExecuteNonQuery();

                    //cmd.Parameters.Clear();
                }

                cmd.CommandText = "update MAJ_PRIX set VALIDEE='True' , date_validation=@date_validation, USER_VALIDATION=@USER_VALIDATION where CODE_MAJ_P=@CODE_MAJ_P";
                cmd.Parameters.Add("@date_validation", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@USER_VALIDATION", SqlDbType.Decimal).Value = code_user;
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_MAJP;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                trans.Commit();
                res.CODE = code_MAJP.ToString();
                res.MESSAGE = "La mise à jour est effectuée avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                trans.Rollback();
                throw er;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY annulerMAJPrix(decimal code_MAJP, decimal code_user, bool validee)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                if (validee)
                {
                    cmd.CommandText = "select * from V_DETAIL_MAJ_PRIX where CODE_MAJ_P=@CODE_MAJ_P";
                    cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_MAJP;
                    da.SelectCommand = cmd;
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                    cmd.Parameters.Clear();

                    foreach (DataRow dr in dt.Rows)
                    {
                        cmd.CommandText = "update     article set PRIX_HT_V_ARTICLE=@PRIX_HT_V_ARTICLE where CODE_BARRE_ARTICLE=@CODE_BARRE_ARTICLE";
                        cmd.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = dr["CODE_BARRE"].ToString();
                        cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["ANCIEN_PV"];
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();

                        cmd.CommandText = "update DETAIL_MAJ set(MAJ='True') where CODE_BARRE like @CODE_BARRE and CODE_MAJ_P=@CODE_MAJ_P";
                        cmd.Parameters.Add("@CODE_BARRE", SqlDbType.NVarChar).Value = dr["CODE_BARRE"].ToString();
                        cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_MAJP;
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                    }
                }
                cmd.CommandText = "update MAJ_PRIX set ANNULEE='True' , DATE_ANNULATION=@date_validation, USER_ANNULATION=@USER_VALIDATION where CODE_MAJ_P=@CODE_MAJ_P";
                cmd.Parameters.Add("@date_validation", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@USER_VALIDATION", SqlDbType.Decimal).Value = code_user;
                cmd.Parameters.Add("@CODE_MAJ_P", SqlDbType.Decimal).Value = code_MAJP;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                trans.Commit();
                res.CODE = code_MAJP.ToString();
                res.MESSAGE = "La mise à jour est annulée avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                trans.Rollback();
                throw er;
            }
            return res;
        }


        [WebMethod]
        public RESULT_QUERY DELETE_ARTICLE(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();

            cmd.Transaction = trans;
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();
            string reqSql = "SELECT   * FROM LG_BR_FR WHERE CODE_ARTICLE = '" + CODE + "'";
            try
            {
                dt = new DataTable("mySrcTable");

                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LIGNE_COMMANDE WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LG_TC WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LG_BON_LIVRAISON WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LG_CMD_FR WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LG_FI WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LG_FACT_FR WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }

                reqSql = "SELECT   * FROM LIGNE_FACTURE WHERE CODE_ARTICLE = '" + CODE + "'";
                dt = new DataTable("mySrcTable");
                cmd.CommandText = reqSql;
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    throw new Exception("Cet article est mouvementé, impossible de le supprimer");

                }


                res.CODE = CODE;
                reqSql = "DELETE FROM STOCK WHERE     (CODE_ARTICLE = @CODE_ARTICLE)";
                cmd.CommandText = reqSql;
                cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                reqSql = "DELETE FROM ARTICLE WHERE     (CODE_ARTICLE = @CODE_ARTICLE)";
                cmd.CommandText = reqSql;
                cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE;
                cmd.ExecuteNonQuery();



                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Article supprimé avec succès.";
            }
            catch (Exception er)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
                res.CODE = CODE;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY INSERT_ARTICLE(decimal CODE_MARQUE, decimal CODE_FAMILLE, decimal CODE_CATEG,
            string REF_ARTICLE, decimal CODE_FOURNISSEUR, string DESIGNATION_ARTICLE,
            string DESCRIPTION_ARTICLE, string CODE_BARRE_ARTICLE, decimal QTE_ARTICLE, decimal CODE_UNITE_ARTICLE,
            decimal QTE_MIN_ARTICLE, byte[] PHOTO_ARTICLE, decimal PRIX_HT_A_ARTICLE, decimal majoration, decimal PRIX_HT_V_ARTICLE,
             decimal CODE_TVA, bool ETAT_ARTICLE, decimal CODE_USER, string REF_FOURNISSEUR, decimal TVA_ACHAT, bool stockable)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            string reqSql = "SELECT   * FROM ARTICLE WHERE REF_ARTICLE LIKE '" + REF_ARTICLE + "'";

            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(reqSql);
            if (dt.Rows.Count > 0)
            {
                res.OK = false;
                res.MESSAGE = "Un article est déja enregistré avec la référence " + REF_ARTICLE + ".\nL'enregistrement est annulé.";
                res.CODE = string.Format("{0}", dt.Rows[0]["CODE_ARTICLE"]);
                return res;
            }
            SqlDataAdapter da;
            DataTable dtMag = new DataTable("dtMag");

            try
            {
                SqlTransaction sqlTrans = CnxBase.myConn.BeginTransaction();
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.Transaction = sqlTrans;

                try
                {



                    cmd.CommandText = "INSERT INTO ARTICLE(CODE_MARQUE, CODE_FAMILLE,  REF_ARTICLE, CODE_FOURNISSEUR,";
                    cmd.CommandText += "CODE_BARRE_ARTICLE,DESIGNATION_ARTICLE,DESCRIPTION_ARTICLE, QTE_ARTICLE, ";
                    cmd.CommandText += "CODE_UNITE ,UNITE_QTE_ARTICLE, QTE_MIN_ARTICLE, PHOTO_ARTICLE, PRIX_HT_A_ARTICLE, TAUX_MAJORATION, ";
                    cmd.CommandText += " PRIX_HT_V_ARTICLE, CODE_TVA, TVA_ACHAT,TVA_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, REF_FRN, stockable)";
                    cmd.CommandText += "VALUES ";
                    cmd.CommandText += "(@CODE_MARQUE, @CODE_FAMILLE, @REF_ARTICLE, @CODE_FOURNISSEUR,";
                    cmd.CommandText += "@CODE_BARRE_ARTICLE,@DESIGNATION_ARTICLE, @DESCRIPTION_ARTICLE, @QTE_ARTICLE, ";
                    cmd.CommandText += "@CODE_UNITE ,@UNITE_QTE_ARTICLE, @QTE_MIN_ARTICLE, @PHOTO_ARTICLE, @PRIX_HT_A_ARTICLE, @TAUX_MAJORATION, ";
                    cmd.CommandText += " @PRIX_HT_V_ARTICLE, @CODE_TVA, @TVA_ACHAT,@TVA_ARTICLE, @ETAT_ARTICLE, @CODE_CATEG, @CODE_MAG, @REF_FRN, @stockable) ";

                    cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_MARQUE;
                    cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;
                    cmd.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
                    cmd.Parameters.Add("@REF_FRN", SqlDbType.NVarChar).Value = REF_FOURNISSEUR;
                    cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE_FOURNISSEUR;
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE;
                    cmd.Parameters.Add("@DESIGNATION_ARTICLE", SqlDbType.NVarChar).Value = DESIGNATION_ARTICLE;
                    cmd.Parameters.Add("@DESCRIPTION_ARTICLE", SqlDbType.NVarChar).Value = DESCRIPTION_ARTICLE;
                    cmd.Parameters.Add("@QTE_ARTICLE", SqlDbType.Decimal).Value = QTE_ARTICLE;
                    cmd.Parameters.Add("@CODE_UNITE", SqlDbType.Decimal).Value = CODE_UNITE_ARTICLE;
                    cmd.Parameters.Add("@UNITE_QTE_ARTICLE", SqlDbType.NVarChar).Value = "";
                    cmd.Parameters.Add("@QTE_MIN_ARTICLE", SqlDbType.Decimal).Value = QTE_MIN_ARTICLE;
                    cmd.Parameters.Add("@PHOTO_ARTICLE", SqlDbType.Image).Value = (PHOTO_ARTICLE != null) ? PHOTO_ARTICLE : (object)DBNull.Value;
                    cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_A_ARTICLE;
                    cmd.Parameters.Add("@TAUX_MAJORATION", SqlDbType.Decimal).Value = majoration;
                    cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_V_ARTICLE;
                    cmd.Parameters.Add("@CODE_TVA", SqlDbType.Decimal).Value = CODE_TVA;
                    cmd.Parameters.Add("@TVA_ACHAT", SqlDbType.Decimal).Value = CODE_TVA;
                    cmd.Parameters.Add("@TVA_ARTICLE", SqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@ETAT_ARTICLE", SqlDbType.Bit).Value = ETAT_ARTICLE;
                    cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE_CATEG;
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = 1;
                    cmd.Parameters.Add("@STOCKABLE", SqlDbType.NVarChar).Value = stockable;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();





                    cmd.CommandText = "SELECT     ISNULL(MAX(CODE_ARTICLE), 1) FROM         ARTICLE";
                    decimal CODE_ARTICLE = (decimal)cmd.ExecuteScalar();

                    cmd.CommandText = "select * from magazin";
                    da = new SqlDataAdapter(cmd);
                    da.FillSchema(dtMag, SchemaType.Source);
                    da.Fill(dtMag);


                    cmd.CommandText = "INSERT INTO STOCK(CODE_MAG, CODE_ARTICLE, QTTE_STOCK) VALUES(@CODE_MAG, @CODE_ARTICLE, @QTTE_STOCK)";
                    foreach (DataRow dr in dtMag.Rows)
                    {
                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["CODE_MAG"]);
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE_ARTICLE;
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = 0;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    sqlTrans.Commit();
                    res.OK = true;
                    res.CODE = CODE_ARTICLE.ToString();
                    res.MESSAGE = "Article enregistré avec succès.";
                }
                catch (Exception er)
                {
                    sqlTrans.Rollback();
                    res.OK = false;
                    res.MESSAGE = er.Message;
                }
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;

        }

        [WebMethod]
        public DataTable LOAD_ARTICLE(string CODE)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM V_ARTICLE WHERE CODE_ARTICLE = '" + CODE + "'", CnxBase.myConn))
            {
                DataTable dt = new DataTable();
                try
                {


                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
                catch (Exception er)
                {
                    throw er;
                }
                return dt;
            }
        }

        [WebMethod]
        public DataTable LOAD_ARTICLE_BY_BARCODE(string BARCODE)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM V_ARTICLE WHERE CODE_BARRE_ARTICLE like '" + BARCODE + "'", CnxBase.myConn))
                {


                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

                }
            }
            catch (Exception er)
            {
                throw er;
            }

            return dt;
        }


        [WebMethod]
        public DataTable LOAD_ARTICLE_BY_REF(string REF_ARTICLE)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM V_ARTICLE WHERE REF_ARTICLE like '" + REF_ARTICLE + "'", CnxBase.myConn);

            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

            return dt;
        }


        [WebMethod]
        public DataTable SELECT_BY_BARCODE(string BARCODE)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM V_ARTICLE WHERE CODE_BARRE_ARTICLE like '" + BARCODE + "'", CnxBase.myConn);

            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

            return dt;
        }

        [WebMethod]
        public DataTable SELECT_BY_BARCODE_BY_MAGASIN(string BARCODE, string CODE_MAG)
        {

            string sqlCommandText = "SELECT    * FROM V_ARTICLE_POS ";
            sqlCommandText += " WHERE     (ETAT_ARTICLE = 'False') AND (CODE_MAG = '" + CODE_MAG + "') AND ((CODE_BARRE_ARTICLE like '" + BARCODE + "') OR (CODE_BARRE_ARTICLE_SOLDE like '" + BARCODE + "'))";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommandText, CnxBase.myConn);
            DataTable dt = new DataTable();

            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }


        [WebMethod]
        public DataTable SEARCH_ARTICLE(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (REF_ARTICLE LIKE '%" + param + "%') OR (DESIGNATION_ARTICLE LIKE '%" + param + "%') OR (MARQUE_ARTICLE LIKE '%" + param + "%') OR (CODE_BARRE_ARTICLE LIKE '%" + param + "%')", CnxBase.myConn);
            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_ARTICLE()
        {

            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     * FROM         V_ARTICLE", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                //dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;
            }
            catch (Exception er)
            {
                throw er;
            }

            return dt;
        }


        [WebMethod]
        public RESULT_QUERY UPDATE_ARTICLE(string CODE_ARTICLE, decimal CODE_MARQUE, decimal CODE_FAMILLE, decimal CODE_CATEG, decimal CODE_FOURNISSEUR,
            string REF_ARTICLE, string REF_FOURNISSEUR, string DESIGNATION_ARTICLE, string MARQUE_ARTICLE,
            string DESCRIPTION_ARTICLE, string CODE_BARRE_ARTICLE, decimal QTE_ARTICLE, decimal CODE_UNITE_ARTICLE,
            decimal QTE_MIN_ARTICLE, byte[] PHOTO_ARTICLE, decimal PRIX_HT_A_ARTICLE, decimal majoration, decimal PRIX_HT_V_ARTICLE,
            decimal CODE_TVA, bool ETAT_ARTICLE, decimal TVA_ACHAT, bool stockable)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CnxBase.myConn.BeginTransaction();
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.Transaction = sqlTrans;
                try
                {
                    res.CODE = CODE_ARTICLE;



                    cmd.CommandText = "UPDATE    ARTICLE SET CODE_MARQUE=@CODE_MARQUE,  CODE_FAMILLE=@CODE_FAMILLE,REF_ARTICLE=@REF_ARTICLE, REF_FRN=@REF_FOURNISSEUR,";
                    cmd.CommandText += "DESIGNATION_ARTICLE=@DESIGNATION_ARTICLE,DESCRIPTION_ARTICLE=@DESCRIPTION_ARTICLE, CODE_BARRE_ARTICLE=@CODE_BARRE_ARTICLE, QTE_ARTICLE=@QTE_ARTICLE, ";
                    cmd.CommandText += "CODE_UNITE=@CODE_UNITE , QTE_MIN_ARTICLE=@QTE_MIN_ARTICLE, PHOTO_ARTICLE=@PHOTO_ARTICLE, PRIX_HT_A_ARTICLE=@PRIX_HT_A_ARTICLE, TAUX_MAJORATION=@TAUX_MAJORATION, ";
                    cmd.CommandText += " PRIX_HT_V_ARTICLE=@PRIX_HT_V_ARTICLE, CODE_TVA=@CODE_TVA, TVA_ACHAT=@TVA_ACHAT,ETAT_ARTICLE=@ETAT_ARTICLE, CODE_CATEG=@CODE_CATEG, CODE_MAG=@CODE_MAG, CODE_FOURNISSEUR=@CODE_FOURNISSEUR, STOCKABLE=@STOCKABLE";


                    cmd.CommandText += " WHERE     (CODE_ARTICLE = @CODE_ARTICLE)";

                    //Paramètres
                    cmd.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = CODE_MARQUE;
                    cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;
                    cmd.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
                    cmd.Parameters.Add("@REF_FOURNISSEUR", SqlDbType.NVarChar).Value = REF_FOURNISSEUR;
                    cmd.Parameters.Add("@GENCODE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE;
                    cmd.Parameters.Add("@DESIGNATION_ARTICLE", SqlDbType.NVarChar).Value = DESIGNATION_ARTICLE;
                    cmd.Parameters.Add("@MARQUE_ARTICLE", SqlDbType.NVarChar).Value = MARQUE_ARTICLE;
                    cmd.Parameters.Add("@DESCRIPTION_ARTICLE", SqlDbType.NVarChar).Value = DESCRIPTION_ARTICLE;
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE;
                    cmd.Parameters.Add("@QTE_ARTICLE", SqlDbType.Decimal).Value = QTE_ARTICLE;
                    cmd.Parameters.Add("@CODE_UNITE", SqlDbType.Decimal).Value = CODE_UNITE_ARTICLE;
                    cmd.Parameters.Add("@QTE_MIN_ARTICLE", SqlDbType.Decimal).Value = QTE_MIN_ARTICLE;
                    cmd.Parameters.Add("@PHOTO_ARTICLE", SqlDbType.Image).Value = (PHOTO_ARTICLE != null) ? PHOTO_ARTICLE : (object)DBNull.Value;
                    cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_A_ARTICLE;
                    cmd.Parameters.Add("@TAUX_MAJORATION", SqlDbType.Decimal).Value = majoration;
                    cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_V_ARTICLE;
                    cmd.Parameters.Add("@CODE_TVA", SqlDbType.Decimal).Value = CODE_TVA;
                    cmd.Parameters.Add("@TVA_ACHAT", SqlDbType.Decimal).Value = TVA_ACHAT;
                    cmd.Parameters.Add("@ETAT_ARTICLE", SqlDbType.Bit).Value = ETAT_ARTICLE;
                    cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE_CATEG;
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = 1;
                    cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE_FOURNISSEUR;
                    cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = "";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE_ARTICLE;
                    cmd.Parameters.Add("@STOCKABLE", SqlDbType.Decimal).Value = stockable;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    cmd.Parameters.Clear();

                    sqlTrans.Commit();

                    res.MESSAGE = "Article modifié avec succès.";
                }
                catch (Exception er)
                {
                    sqlTrans.Rollback();
                    res.OK = false;
                    res.MESSAGE = er.Message;
                }
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }


        [WebMethod]
        public string NEW_CODE_ARTICLE(int nbCHIFRE)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT     ISNULL(MAX(CODE_ARTICLE), 0) + 1 FROM         ARTICLE", CnxBase.myConn))
            {
                decimal n = (decimal)cmd.ExecuteScalar();
                string resnb = n.ToString();
                if (nbCHIFRE > resnb.Length)
                {
                    int rep = nbCHIFRE - resnb.Length;
                    for (int i = 0; i < rep; i++)
                    {
                        resnb = "0" + resnb;
                    }
                }
                return resnb;
            }
        }


        [WebMethod]
        public DataTable SELECT_CATEGORIES()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT LIB_CATEG FROM CATEGORIE", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        [WebMethod]
        public DataTable SELECT_FOURNISSEURS()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT RS_FOURNISSEUR FROM FOURNISSEUR", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        [WebMethod]
        public DataTable SELECT_MAGAZINS()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT NOM_MAG, CODE_MAG FROM MAGAZIN", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SEARCH_ARTICLE_CATEG(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (LIB_CATEG '%" + param + "%') ", CnxBase.myConn);
            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }


        [WebMethod]
        public DataTable SEARCH_ARTICLE_FOURN(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (RS_FOURNISSEUR '%" + param + "%') ", CnxBase.myConn);
            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }


        [WebMethod]
        public DataTable SEARCH_ARTICLE_MAG(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (NOM_MAG LIKE '%" + param + "%') ", CnxBase.myConn);
            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }



        public void BLOQUER_ARTICLE(string CODE_ARTICLE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        [WebMethod]
        public DataTable IMPRIMER_CODE_BARRE_ARTICLE(string CODE_ARTICLE, bool solde)
        {
            string sqlCommandText = "";
            if (!solde)
                sqlCommandText = "select article.DESIGNATION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE, Article.PRIX_HT_V_ARTICLE,Societe.RS_SOCIETE from ARTICLE, SOCIETE WHERE     (CODE_ARTICLE LIKE'" + CODE_ARTICLE + "') ";
            else
                sqlCommandText = "select article.DESIGNATION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE_SOLDE, Article.PRIX_HT_V_ARTICLE, Article.PRIX_SOLDE,Societe.RS_SOCIETE from ARTICLE, SOCIETE WHERE     (CODE_ARTICLE LIKE'" + CODE_ARTICLE + "') ";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommandText, CnxBase.myConn);
            DataTable dt = new DataTable();
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ARTICLE_EN_STOCK_PAR_MAGASIN(decimal CODE_MAG)
        {
            string sqlCommandText = "SELECT     dbo.ARTICLE.CODE_ARTICLE, dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.PRIX_HT_A_ARTICLE, ";
            sqlCommandText += " dbo.ARTICLE.PRIX_HT_V_ARTICLE, dbo.TVA.TAUX_TVA as TVA_ARTICLE, dbo.ARTICLE.MAX_REMISE, dbo.STOCK.QTTE_STOCK, dbo.STOCK.CODE_MAG, dbo.MAGAZIN.NOM_MAG, dbo.UNITE.LIB_UNITE";
            sqlCommandText += " FROM         dbo.ARTICLE INNER JOIN";
            sqlCommandText += " dbo.STOCK ON dbo.ARTICLE.CODE_ARTICLE = dbo.STOCK.CODE_ARTICLE INNER JOIN";
            sqlCommandText += " dbo.MAGAZIN ON dbo.STOCK.CODE_MAG = dbo.MAGAZIN.CODE_MAG";
            sqlCommandText += " inner join dbo.TVA ON dbo.TVA.CODE_TVA = dbo.ARTICLE.CODE_TVA";
            sqlCommandText += " inner join dbo.UNITE ON dbo.UNITE.CODE_UNITE = dbo.ARTICLE.CODE_UNITE";
            sqlCommandText += " WHERE     (dbo.ARTICLE.ETAT_ARTICLE = 'False') AND (dbo.STOCK.CODE_MAG = '" + CODE_MAG + "')";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommandText, CnxBase.myConn);
            DataTable dt = new DataTable();

            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        #endregion

        #region CHM_COMMANDE Membres

        public DataTable LISTE_CLIENT()
        {
            throw new Exception("The method or operation is not implemented.");
        }
        [WebMethod]
        public DataTable LOAD_COMMANDE_CLIENT(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     COMMANDE.CODE_COMMANDE, COMMANDE.DATE_COMMANDE, COMMANDE.PRIORITE_COMMANDE, SUM(LIGNE_COMMANDE.PRIX_HT_COMMANDE) AS MONTANT_T_V_HT, 'FALSE' AS CHOIX FROM         COMMANDE INNER JOIN LIGNE_COMMANDE ON COMMANDE.CODE_COMMANDE = LIGNE_COMMANDE.CODE_COMMANDE WHERE     (COMMANDE.CODE_CLIENT = '" + CODE_CLIENT + "') GROUP BY COMMANDE.CODE_COMMANDE, COMMANDE.DATE_COMMANDE, COMMANDE.PRIORITE_COMMANDE", CnxBase.myConn);
            //da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns["CHOIX"].ReadOnly = false;

            return dt;
        }
        [WebMethod]
        public DataTable LOAD_LG_COMMANDE(string CODE_COMMANDE)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT   LIGNE_COMMANDE.CODE_COMMANDE,  LIGNE_COMMANDE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, LIGNE_COMMANDE.QTE_LIGNE_COMMANDE, LIGNE_COMMANDE.PRIX_HT_COMMANDE, 0 AS PRIX_HT_TOTAL, LIGNE_COMMANDE.TVA_COMMANDE, 0 AS PRIX_TTC_LG_COMMANDE, 0 AS PRIX_TTC_TOTAL, ARTICLE.UNITE_QTE_ARTICLE  FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LIGNE_COMMANDE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE CODE_COMMANDE like  '" + CODE_COMMANDE + "'", CnxBase.myConn);
            //da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            dt.Columns["PRIX_TTC_LG_COMMANDE"].ReadOnly = false;
            dt.Columns["PRIX_TTC_TOTAL"].ReadOnly = false;
            dt.Columns["PRIX_HT_TOTAL"].ReadOnly = false;

            return dt;
        }
        [WebMethod]
        public DataTable LOAD_LISTE_ARTICLE(string NOM_MAG)
        {
            DataTable dt = new DataTable();
            //SqlCommand cmd = new SqlCommand("SELECT CODE_MAG FROM MAGAZIN WHERE ( NOM_MAG LIKE '%" + NOM_MAG + "%')", CnxBase.myConn);

            //decimal CODE = (decimal)cmd.ExecuteScalar();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, DESCRIPTION_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PHOTO_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, UNITE_QTE_ARTICLE FROM         STOCK inner join article on stock.code_article=article.code_article WHERE     (ETAT_ARTICLE = 'false') AND (CODE_MAG = @CODE) ", CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@CODE", SqlDbType.Decimal).Value = Convert.ToDecimal(NOM_MAG);
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
                dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable LOAD_LISTE_CLIENT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_CLIENT, REF_CLIENT, RS_CLIENT FROM         CLIENT", CnxBase.myConn))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }
        [WebMethod]
        public DataTable LOAD_SCHEMA_LG_COMMANDE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_COMMANDE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, LIGNE_COMMANDE.QTE_LIGNE_COMMANDE, LIGNE_COMMANDE.PRIX_HT_COMMANDE, LIGNE_COMMANDE.TVA_COMMANDE FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LIGNE_COMMANDE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE where LIGNE_COMMANDE.CODE_COMMANDE like ''", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
                dt.Columns.Add("PRIX_TTC_LG_COMMANDE", typeof(decimal));
                dt.Columns.Add("PRIX_TTC_TOTAL", typeof(decimal));
                dt.Columns.Add("PRIX_HT_TOTAL", typeof(decimal));
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable[] PRINT_COMMANDE(string CODE_COMMANDE)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("", CnxBase.myConn))
            {
                DataTable dt_societe = new DataTable();
                da.SelectCommand.CommandText = "SELECT CODE_SOCIETE, RS_SOCIETE, DESCRIPTION_SOCIETE, ADRESSE_SOCIETE, CP_SOCIETE, TEL_SOCIETE, FAX_SOCIETE, EMAIL_SOCIETE, SITE_WEB_SOCETE, LOGO_SOCIETE, CODE_TVA_SOCIETE, RIB_SOCIETE, NUM_COMMANDE, PREFIX1_COMMANDE, PREFIX2_COMMANDE, PREFIX1_FACTURE, NUM_FACTURE, PREFIX1_FACTURE, PREFIXE2_FACTURE FROM dbo.SOCIETE";
                //da.Fill(dt_societe);
                dt_societe = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                DataTable dt_commande = new DataTable();
                da.SelectCommand.CommandText = "SELECT     COMMANDE.CODE_COMMANDE, COMMANDE.CODE_CLIENT, COMMANDE.DATE_COMMANDE, COMMANDE.PRIORITE_COMMANDE, COMMANDE.DATE_EXPIRATION_COMMANDE, COMMANDE.CODE_USER, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT, CLIENT.ADRESSE_CLIENT, CLIENT.CP_CLIENT FROM         COMMANDE INNER JOIN CLIENT ON COMMANDE.CODE_CLIENT = CLIENT.CODE_CLIENT WHERE COMMANDE.CODE_COMMANDE = '" + CODE_COMMANDE + "'";
                //da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                //da.Fill(dt_commande);
                dt_commande = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                //da.SelectCommand.Parameters.Clear();
                DataTable dt_lg_commande = new DataTable();
                da.SelectCommand.CommandText = "SELECT     LIGNE_COMMANDE.CODE_COMMANDE, LIGNE_COMMANDE.CODE_ARTICLE, LIGNE_COMMANDE.QTE_LIGNE_COMMANDE, LIGNE_COMMANDE.PRIX_HT_COMMANDE, LIGNE_COMMANDE.TVA_COMMANDE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, ARTICLE.PHOTO_ARTICLE FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LIGNE_COMMANDE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE     (LIGNE_COMMANDE.CODE_COMMANDE = '" + CODE_COMMANDE + "')";
                //da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                //da.Fill(dt_lg_commande);
                dt_lg_commande = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                da.SelectCommand.Parameters.Clear();
                DataTable[] tab = { dt_commande, dt_lg_commande, dt_societe };
                return tab;
            }
        }

        [WebMethod]
        public DataTable RECHERCHE_CLIENT(string REF_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_CLIENT, REF_CLIENT, RS_CLIENT FROM         CLIENT WHERE     (REF_CLIENT = @REF_CLIENT)", CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@REF_CLIENT", SqlDbType.NVarChar).Value = REF_CLIENT;
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable RECHERCHE_LISTE_ARTICLE(string param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_V_ARTICLE FROM         ARTICLE WHERE     (ETAT_ARTICLE = 'false')    AND (REF_ARTICLE LIKE '%" + param + "%' OR  DESIGNATION_ARTICLE LIKE '%" + param + "%' OR MARQUE_ARTICLE LIKE '%" + param + "%' OR  DESCRIPTION_ARTICLE  LIKE '%" + param + "%'  OR CODE_BARRE_ARTICLE LIKE '%" + param + "%') ", CnxBase.myConn);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable RECHERCHE_LISTE_CLIENT(string param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_CLIENT, REF_CLIENT, RS_CLIENT FROM         CLIENT WHERE REF_CLIENT LIKE '%" + param + "%' OR RS_CLIENT LIKE '%" + param + "%' ", CnxBase.myConn);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public RESULT_QUERY SAVE_COMMANDE_CLIENT(string CODE_CLIENT, DateTime DATE_COMMANDE, bool PRIORITE_COMMANDE, object DATE_EXPIRATION_COMMANDE, string CODE_USER, bool reglee, DataTable dt_lg_commande)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            res.MESSAGE = "!";
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_COMMANDE) + 1 FROM         SOCIETE";
                decimal NUM_COMMANDE = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_COMMANDE, '') FROM         SOCIETE";
                string PREFIX1_COMMANDE = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix1 cmd";

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_COMMANDE, '') FROM         SOCIETE";
                string PREFIX2_COMMANDE = (string)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_COMMANDE = NUM_COMMANDE +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_COMMANDE = PREFIX1_COMMANDE + NUM_COMMANDE.ToString() + PREFIX2_COMMANDE;

                res.CODE = CODE_COMMANDE;

                cmd.CommandText = "INSERT INTO COMMANDE(CODE_COMMANDE, CODE_CLIENT, DATE_COMMANDE, PRIORITE_COMMANDE, CODE_USER, DATE_EXPIRATION_COMMANDE, REGLEE) VALUES     (@CODE_COMMANDE,@CODE_CLIENT,@DATE_COMMANDE,@PRIORITE_COMMANDE,@CODE_USER,@DATE_EXPIRATION_COMMANDE, @REGLEE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE; res.MESSAGE = "erreur code commande";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT; res.MESSAGE = "erreur code client";
                cmd.Parameters.Add("@DATE_COMMANDE", SqlDbType.DateTime).Value = DATE_COMMANDE; res.MESSAGE = "erreur insertion date commande";
                cmd.Parameters.Add("@PRIORITE_COMMANDE", SqlDbType.Bit).Value = PRIORITE_COMMANDE; res.MESSAGE = "erreur priorite commande";
                cmd.Parameters.Add("@DATE_EXPIRATION_COMMANDE", SqlDbType.DateTime).Value = (DATE_EXPIRATION_COMMANDE != null) ? DATE_EXPIRATION_COMMANDE : (object)DBNull.Value; res.MESSAGE = "erreur insertion date expiration commande";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "erreur insertion code user";
                cmd.Parameters.Add("@REGLEE", SqlDbType.Bit).Value = "False";
                cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_lg_commande.Rows)
                {
                    cmd.CommandText = "INSERT INTO LIGNE_COMMANDE(CODE_ARTICLE, CODE_COMMANDE, QTE_LIGNE_COMMANDE, PRIX_HT_COMMANDE, TVA_COMMANDE, QTE_LIVRE) VALUES     (@CODE_ARTICLE,@CODE_COMMANDE,@QTE_LIGNE_COMMANDE,@PRIX_HT_COMMANDE,@TVA_COMMANDE,0)";
                    cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE_LIGNE_COMMANDE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_COMMANDE"];
                    cmd.Parameters.Add("@PRIX_HT_COMMANDE", SqlDbType.Decimal).Value = dr["PRIX_HT_COMMANDE"];
                    cmd.Parameters.Add("@TVA_COMMANDE", SqlDbType.Decimal).Value = dr["TVA_COMMANDE"];

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                sqltrans.Commit();

                res.MESSAGE = String.Format("Commande n°:{0} enregistrée avec succès.", CODE_COMMANDE);
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }

            return res;
        }



        [WebMethod]
        public DataTable LOAD_COMMANDE_CLIENT_PAR_CODE_COMMANDE(string code)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_COMMANDE=@CODE_COMMANDE", CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = code;
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {
            }
            return dt;

        }

        [WebMethod]
        public DataTable SELECT_ALL_COMMANDE_CLIENT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT *, PRENOM_USER+' '+NOM_USER AS [USER] FROM COMMANDE inner join client on client.code_client=commande.code_client inner join UTILISATEUR on commande.code_user=utilisateur.code_user order by date_commande desc", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }



        [WebMethod]
        public DataTable RECHERCHE_COMMANDES_CLIENT_PAR_RS(string client, DateTime date_saisie, DateTime date_expiration)
        {
            DataTable dt = new DataTable();
            try
            {

                if (client != "" && date_saisie == null && date_expiration == null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT CODE_CLIENT FROM CLIENT WHERE RS_CLIENT LIKE'%" + client + "%'", CnxBase.myConn);
                    string code_clt = cmd.ExecuteScalar().ToString();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_CLIENT='" + code_clt + "'", CnxBase.myConn);
                    //da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = code_clt;
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }




        [WebMethod]
        public void REGLE_COMMANDE(string code_commande)
        {

        }



        [WebMethod]
        public DataTable SELECT_COMMANDE_NON_REGLE_PAR_CLIENT(decimal code_client)
        {
            DataTable dt = new DataTable();
            try
            {
                string reqSql = string.Empty;
                reqSql += " SELECT   'CMD' AS TYPE_PIECE,  dbo.COMMANDE.CODE_COMMANDE, dbo.COMMANDE.DATE_COMMANDE, ISNULL(dbo.COMMANDE.DATE_EXPIRATION_COMMANDE, N'')  ";
                reqSql += " AS DATE_EXPIRATION_COMMANDE , 'False' AS CHECKED ";
                reqSql += " FROM dbo.COMMANDE LEFT OUTER JOIN   dbo.LIGNE_COMMANDE ON dbo.COMMANDE.CODE_COMMANDE = dbo.LIGNE_COMMANDE.CODE_COMMANDE ";
                reqSql += " WHERE   CODE_CLIENT='" + code_client + "' and    ";
                reqSql += " (dbo.LIGNE_COMMANDE.QTE_LIGNE_COMMANDE > dbo.LIGNE_COMMANDE.QTE_LIVRE) ";
                reqSql += " GROUP BY dbo.COMMANDE.CODE_COMMANDE, dbo.COMMANDE.DATE_COMMANDE, dbo.COMMANDE.DATE_EXPIRATION_COMMANDE ";

                reqSql += "  UNION ALL ";

                reqSql += " SELECT 'F.E' AS TYPE_PIECE, dbo.FICHE_INTERVENTION.NUM_FI, dbo.FICHE_INTERVENTION.DATE_FI, dbo.FICHE_INTERVENTION.DATE_CLOTURE, ";
                reqSql += " 'False' as CHECKED ";
                reqSql += " FROM dbo.FICHE_INTERVENTION inner join dbo.EQUIPEMENT on dbo.FICHE_INTERVENTION.CODE_VEHICULE=dbo.EQUIPEMENT.CODE_EQP ";
                reqSql += " where dbo.EQUIPEMENT.CODE_CLIENT='" + code_client + "' ";
                reqSql += " and dbo.FICHE_INTERVENTION.CLOTURE='True'  ";
                reqSql += " and isnull(dbo.FICHE_INTERVENTION.CODE_B_LIV, '')=''  ";

                SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn);

                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                dt.Columns["CHECKED"].ReadOnly = false;

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }





        #endregion

        #region CHM_FACTURE_CLIENT Membres
        [WebMethod]
        public void CANCEL_FACTURE_CLIENT(string CODE_FACTURE)
        {
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE FACTURE SET ANNULATION_FACTURE=@ANNULATION_FACTURE WHERE CODE_FACTURE=@CODE_FACTURE";
                cmd.Parameters.Add("@ANNULATION_FACTURE", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();

            }

        }

        [WebMethod]
        public RESULT_QUERY INSERT_FACTURE_CLIENT(DateTime DATE_FACTURE, string CODE_CLIENT, decimal MONTANT_HT_FACTURE, decimal MONTANT_TVA, decimal MONTANT_TTC, decimal TAUX_REMISE, decimal MONTANT_BASE, decimal TIMBRE_FACTURE, decimal MONTANT_TOTAL_FACTURE, string MONTANT_LETTRE_FACTURE, bool ANNULATION_FACTURE, string REGLER, decimal CREDIT, decimal CODE_MAG, decimal CODE_USER, string PRENOM_USER, string NOM_USER, string REMARQUE, DataTable dt_lg_facture, List<string> bl_facture)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_FACTURE) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_FACTURE = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_FACTURE, '') FROM         SOCIETE WHERE CODE_SOCIETE =1";
                string PREFIX1_FACTURE = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix1 cmd";

                cmd.CommandText = "SELECT     ISNULL(PREFIXE2_FACTURE, '') FROM         SOCIETE";
                string PREFIX2_FACTURE = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix2 cmd";

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_FACTURE = NUM_FACTURE +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_FACTURE = PREFIX1_FACTURE + numberToString(5, Convert.ToInt32(NUM_FACTURE)) + PREFIX2_FACTURE;
                res.MESSAGE = "erreur insertion prefix1 cmd";
                res.CODE = CODE_FACTURE;

                cmd.CommandText = "INSERT INTO FACTURE (CODE_FACTURE, DATE_FACTURE, CODE_CLIENT, MONTANT_HT_FACTURE, MONTANT_TVA, MONTANT_TTC, TAUX_REMISE, MONTANT_BASE, TIMBRE_FACTURE, MONTANT_TOTAL_FACTURE, MONTANT_LETTRE, ANNULATION_FACTURE, REGLER, CREDIT, MAGASIN, CODE_USER, PRENOM_USER, NOM_USER, REMARQUE) VALUES     (@CODE_FACTURE, @DATE_FACTURE, @CODE_CLIENT, @MONTANT_HT_FACTURE, @MONTANT_TVA, @MONTANT_TTC, @TAUX_REMISE, @MONTANT_BASE, @TIMBRE_FACTURE, @MONTANT_TOTAL_FACTURE, @MONTANT_LETTRE, @ANNULATION_FACTURE, @REGLER, @CREDIT, @MAGASIN, @CODE_USER, @PRENOM_USER, @NOM_USER, @REMARQUE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_FACTURE", SqlDbType.DateTime).Value = DATE_FACTURE; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_CLIENT); res.MESSAGE = "3";
                cmd.Parameters.Add("@MONTANT_HT_FACTURE", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_HT_FACTURE); res.MESSAGE = "4";
                cmd.Parameters.Add("@MONTANT_TVA", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TVA); res.MESSAGE = "5";
                cmd.Parameters.Add("@MONTANT_TTC", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TTC); res.MESSAGE = "6";
                cmd.Parameters.Add("@TAUX_REMISE", SqlDbType.Decimal).Value = Convert.ToDecimal(TAUX_REMISE); res.MESSAGE = "7";
                cmd.Parameters.Add("@MONTANT_BASE", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_BASE); res.MESSAGE = "8";
                cmd.Parameters.Add("@TIMBRE_FACTURE", SqlDbType.Decimal).Value = Convert.ToDecimal(TIMBRE_FACTURE); res.MESSAGE = "9";
                cmd.Parameters.Add("@MONTANT_TOTAL_FACTURE", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TOTAL_FACTURE); res.MESSAGE = "10";
                cmd.Parameters.Add("@MONTANT_LETTRE", SqlDbType.NVarChar).Value = MONTANT_LETTRE_FACTURE; res.MESSAGE = "11";
                cmd.Parameters.Add("@ANNULATION_FACTURE", SqlDbType.Bit).Value = ANNULATION_FACTURE; res.MESSAGE = "12";
                cmd.Parameters.Add("@REGLER", SqlDbType.NVarChar).Value = REGLER; res.MESSAGE = "13";
                cmd.Parameters.Add("@CREDIT", SqlDbType.Decimal).Value = Convert.ToDecimal(CREDIT); res.MESSAGE = "14";
                cmd.Parameters.Add("@MAGASIN", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_MAG); res.MESSAGE = "15";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_USER); res.MESSAGE = "16";
                cmd.Parameters.Add("@PRENOM_USER", SqlDbType.NVarChar).Value = PRENOM_USER; res.MESSAGE = "17";
                cmd.Parameters.Add("@NOM_USER", SqlDbType.NVarChar).Value = NOM_USER; res.MESSAGE = "18";
                cmd.Parameters.Add("@REMARQUE", SqlDbType.NVarChar).Value = REMARQUE; //res.MESSAGE = cmd.CommandText+"19";
                cmd.ExecuteNonQuery(); res.MESSAGE = "an error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_lg_facture.Rows)
                {
                    cmd.CommandText = "INSERT INTO LIGNE_FACTURE( CODE_FACTURE, CODE_ARTICLE, CODE_BL, TYPE_PIECE, QTE, TVA_ARTICLE, PRIX_HT_ARTICLE, PRIX_TOTAL_HT, PRIX_U_TTC, PRIX_TOTAL_TTC, REMISE, PRIX_FACTURE) VALUES     (@CODE_FACTURE, @CODE_ARTICLE, @CODE_BL, @TYPE_PIECE, @QTE, @TVA_ARTICLE, @PRIX_HT_ARTICLE, @PRIX_TOTAL_HT, @PRIX_U_TTC, @PRIX_TOTAL_TTC, @REMISE, @PRIX_FACTURE)";
                    cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_BL", SqlDbType.NVarChar).Value = dr["CODE_BL"]; res.MESSAGE = "20";
                    cmd.Parameters.Add("@TYPE_PIECE", SqlDbType.NVarChar).Value = dr["TYPE_PIECE"]; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE"]; res.MESSAGE = "23";
                    cmd.Parameters.Add("@TVA_ARTICLE", SqlDbType.Decimal).Value = dr["TVA_ARTICLE"]; res.MESSAGE = "24";
                    cmd.Parameters.Add("@PRIX_HT_ARTICLE", SqlDbType.Decimal).Value = dr["PRIX_HT_ARTICLE"]; res.MESSAGE = "25";
                    cmd.Parameters.Add("@PRIX_TOTAL_HT", SqlDbType.Decimal).Value = dr["PRIX_TOTAL_HT"]; res.MESSAGE = "26";
                    cmd.Parameters.Add("@PRIX_U_TTC", SqlDbType.Decimal).Value = dr["PRIX_U_TTC"]; res.MESSAGE = "27";
                    cmd.Parameters.Add("@PRIX_TOTAL_TTC", SqlDbType.Decimal).Value = dr["PRIX_TOTAL_TTC"]; res.MESSAGE = "28";
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = dr["REMISE"]; res.MESSAGE = "29";
                    cmd.Parameters.Add("@PRIX_FACTURE", SqlDbType.Decimal).Value = dr["PRIX_FACTURE"]; res.MESSAGE = "30";


                    cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                    cmd.Parameters.Clear();

                    if (dr["TYPE_PIECE"].ToString() == "BL")
                    {
                        cmd.CommandText = "UPDATE LG_BON_LIVRAISON SET CODE_FACTURE=@CODE_FACTURE WHERE CODE_B_LIV=@CODE_B_LIV AND CODE_ARTICLE=@CODE_ARTICLE";
                        cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "20";
                        cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = dr["CODE_BL"]; res.MESSAGE = "20";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                        cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE BON_DE_LIVRAISON SET FACTURED='True', CODE_FACTURE=@CODE_FACTURE where CODE_B_LIV like @CODE_B_LIV";
                        cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                        cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = dr["CODE_BL"];
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    if (dr["TYPE_PIECE"].ToString() == "TC")
                    {
                        cmd.CommandText = "UPDATE TICKET_CAISSE SET CODE_FACTURE=@CODE_FACTURE WHERE CODE_TC=@CODE_TC";
                        cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "20";
                        cmd.Parameters.Add("@CODE_TC", SqlDbType.NVarChar).Value = dr["CODE_BL"]; res.MESSAGE = "20";
                        cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                        cmd.Parameters.Clear();
                    }
                }

                for (int i = 0; i < bl_facture.Count; i++)
                {

                }


                sqltrans.Commit();

                res.MESSAGE = "Facture enregistrée avec succès.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE += "\n" + er.Message;


            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY INSERT_FACTURE_DIRECTE(DateTime DATE_FACTURE, string CODE_CLIENT, decimal MONTANT_HT_FACTURE, decimal MONTANT_TVA, decimal MONTANT_TTC, decimal REMISE, string MODE_REG, decimal MONTANT_RECU, decimal RESTE, decimal CODE_MAG, decimal CODE_USER, DataTable dt_lg_facture, DataTable dtReglement)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock where code_mag='" + CODE_MAG + "'", CnxBase.myConn);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_TC) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_TC = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur getting numTc";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_TC, '') FROM         SOCIETE WHERE CODE_SOCIETE =1";
                string PREFIX1_TC = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix1 tc";

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_TC, '') FROM         SOCIETE";
                string PREFIX2_TC = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix2 tc";

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_TC = NUM_TC +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_TC = PREFIX1_TC + numberToString(5, Convert.ToInt32(NUM_TC)) + PREFIX2_TC;
                res.MESSAGE = "erreur insertion prefix1 tc";
                res.CODE = CODE_TC;

                cmd.CommandText = "SELECT CODE_COMPTE_CLIENT FROm COMPTE_CLIENT WHERE (CODE_CLIENT = @CODE_CLIENT)";
                cmd.Parameters.Add("CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;

                decimal CodeCompteClient = (decimal)cmd.ExecuteScalar();
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO REGLEMENT_CLIENT(CODE_FACTURE, DATE_REG_CLT, MODE_REGLEMENT_CLT, MONTANT_REG_CLIENT,MONTANT_PIECE, RESTE, ";
                cmd.CommandText += " NUM_PIECE_CLIENT, BANQUE_CLIENT, OBSERVATION, CODE_COMPTE_CLIENT, TYPE_PIECE)";
                cmd.CommandText += " VALUES (@CODE_FACTURE, @DATE_REG_CLT, @MODE_REGLEMENT_CLT, @MONTANT_REG_CLIENT,@MONTANT_PIECE, @RESTE,";
                cmd.CommandText += " @NUM_PIECE_CLIENT, @BANQUE_CLIENT, @OBSERVATION, @CODE_COMPTE_CLIENT, @TYPE_PIECE)";

                foreach (DataRow dr in dtReglement.Rows)
                {
                    cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "erreur reg1 tc";
                    cmd.Parameters.Add("@DATE_REG_CLT", SqlDbType.DateTime).Value = DateTime.Now; res.MESSAGE = "erreur reg2 tc";
                    cmd.Parameters.Add("@MODE_REGLEMENT_CLT", SqlDbType.NVarChar).Value = dr["MODE_REGLEMENT_CLT"]; res.MESSAGE = "erreur reg3 tc" + MONTANT_RECU;
                    cmd.Parameters.Add("@MONTANT_REG_CLIENT", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["MONTANT_REG_CLIENT"]); res.MESSAGE = "erreur reg4 tc" + MONTANT_TTC;
                    cmd.Parameters.Add("@MONTANT_PIECE", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["MONTANT_PIECE"]); res.MESSAGE = "erreur reg5 tc" + RESTE;
                    cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["RESTE"]); res.MESSAGE = "erreur reg6 tc";
                    cmd.Parameters.Add("@NUM_PIECE_CLIENT", SqlDbType.NVarChar).Value = dr["NUM_PIECE_CLIENT"].ToString(); res.MESSAGE = "erreur reg7 tc";
                    cmd.Parameters.Add("@BANQUE_CLIENT", SqlDbType.NVarChar).Value = dr["BANQUE_CLIENT"].ToString(); res.MESSAGE = "erreur reg8 tc";
                    cmd.Parameters.Add("@OBSERVATION", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "erreur reg9 tc";
                    cmd.Parameters.Add("@TYPE_PIECE", SqlDbType.NVarChar).Value = "TC"; res.MESSAGE = "erreur reg9 tc";
                    cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CodeCompteClient; res.MESSAGE = "erreur reg10 tc" + CODE_TC;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                res.MESSAGE = "erreur CodeReg";
                cmd.CommandText = "SELECT MAX(CODE_REGLEMENT_CLIENT) FROM REGLEMENT_CLIENT";
                decimal CODE_REG = (decimal)cmd.ExecuteScalar();


                cmd.CommandText = "INSERT INTO TICKET_CAISSE (CODE_TC, DATE_TC, CODE_CAISSE, CODE_CLIENT, MONTANT_HT, REMISE, MONTANT_TVA, MONTANT_TTC ";
                cmd.CommandText += " , MONTANT_RECU, RESTE, MAGASIN, CODE_USER, CODE_REGLEMENT, CODE_FACTURE) VALUES";
                cmd.CommandText += " (@CODE_TC, @DATE_TC, @CODE_CAISSE, @CODE_CLIENT, @MONTANT_HT, @REMISE, @MONTANT_TVA, @MONTANT_TTC";
                cmd.CommandText += " , @MONTANT_RECU, @RESTE, @MAGASIN, @CODE_USER, @CODE_REGLEMENT, @CODE_FACTURE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_TC", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_TC", SqlDbType.DateTime).Value = DATE_FACTURE; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_CAISSE", SqlDbType.Decimal).Value = Convert.ToDecimal("1"); res.MESSAGE = "3";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_CLIENT); res.MESSAGE = "4";
                cmd.Parameters.Add("@MONTANT_HT", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_HT_FACTURE); res.MESSAGE = "5";
                cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = Convert.ToDecimal(REMISE); res.MESSAGE = "6";
                cmd.Parameters.Add("@MONTANT_TVA", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TVA); res.MESSAGE = "7";
                cmd.Parameters.Add("@MONTANT_TTC", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TTC); res.MESSAGE = "8";
                cmd.Parameters.Add("@MONTANT_RECU", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_RECU); res.MESSAGE = "9";
                cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = Convert.ToDecimal(RESTE); res.MESSAGE = "10";
                cmd.Parameters.Add("@MAGASIN", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_MAG); res.MESSAGE = "11";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_USER); res.MESSAGE = "12";
                cmd.Parameters.Add("@CODE_REGLEMENT", SqlDbType.Decimal).Value = CODE_REG; res.MESSAGE = "13";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = "";

                cmd.ExecuteNonQuery(); res.MESSAGE = "an error occured when executing request!!!!!";
                cmd.Parameters.Clear();
                DataTable article = new DataTable();




                foreach (DataRow dr in dt_lg_facture.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_TC (CODE_TC, CODE_ARTICLE, QTE, UNITE, PRIX_HT, TAUX_REMISE,";
                    cmd.CommandText += " TVA, PRIX_TTC) VALUES (@CODE_TC, @CODE_ARTICLE, @QTE, @UNITE, @PRIX_HT, @TAUX_REMISE,";
                    cmd.CommandText += " @TVA, @PRIX_TTC)";
                    cmd.Parameters.Add("@CODE_TC", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE"]; res.MESSAGE = "23";
                    cmd.Parameters.Add("@UNITE", SqlDbType.NVarChar).Value = dr["UNITE_QTE_ARTICLE"]; res.MESSAGE = "24";
                    cmd.Parameters.Add("@PRIX_HT", SqlDbType.Decimal).Value = (decimal)dr["PRIX_HT_ARTICLE"]; res.MESSAGE = "25";
                    cmd.Parameters.Add("@TAUX_REMISE", SqlDbType.Decimal).Value = dr["REMISE"]; res.MESSAGE = "26";
                    cmd.Parameters.Add("@TVA", SqlDbType.Decimal).Value = dr["TVA_ARTICLE"]; res.MESSAGE = "27";
                    cmd.Parameters.Add("@PRIX_TTC", SqlDbType.Decimal).Value = (decimal)dr["PRIX_U_TTC"]; res.MESSAGE = "28";


                    cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                    cmd.Parameters.Clear();

                    dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";

                    if (article.Rows.Count == 0)
                    {
                        Exception er = new Exception("Erreur lors de stockage de l'article.");
                        throw er;
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK- @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE"];
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE- @QTTE_LG_FACTURE WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                    cmd.Parameters.Add("@QTTE_LG_FACTURE", SqlDbType.Decimal).Value = (decimal)dr["QTE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                }


                sqltrans.Commit();

                res.MESSAGE = String.Format("Ticket de Caisse N°:{0} enregistrée avec succès.", CODE_TC);
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE += er.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY REGLER_FI_TC(DateTime DATE_FACTURE, decimal CODE_CLIENT, decimal MONTANT_HT_FACTURE, decimal MONTANT_TVA, decimal MONTANT_TTC, decimal REMISE, string MODE_REG, decimal MONTANT_RECU, decimal RESTE, decimal CODE_MAG, decimal CODE_USER, DataTable dt_lg_facture, string NUM_FI, DataTable dtReglement)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock where code_mag='" + CODE_MAG + "'", CnxBase.myConn);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_TC) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_TC = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur getting numTc";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_TC, '') FROM         SOCIETE WHERE CODE_SOCIETE =1";
                string PREFIX1_TC = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix1 tc";

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_TC, '') FROM         SOCIETE";
                string PREFIX2_TC = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix2 tc";

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_TC = NUM_TC +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_TC = PREFIX1_TC + NUM_TC.ToString() + PREFIX2_TC;
                res.MESSAGE = "erreur insertion prefix1 tc";
                res.CODE = CODE_TC;

                cmd.CommandText = "SELECT CODE_COMPTE_CLIENT FROm COMPTE_CLIENT WHERE (CODE_CLIENT = @CODE_CLIENT)";
                cmd.Parameters.Add("CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;

                decimal CodeCompteClient = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "INSERT INTO REGLEMENT_CLIENT(CODE_FACTURE, DATE_REG_CLT, MODE_REGLEMENT_CLT, MONTANT_REG_CLIENT,MONTANT_PIECE, RESTE, ";
                cmd.CommandText += " NUM_PIECE_CLIENT, BANQUE_CLIENT, OBSERVATION, CODE_COMPTE_CLIENT, TYPE_PIECE)";
                cmd.CommandText += " VALUES (@CODE_FACTURE, @DATE_REG_CLT, @MODE_REGLEMENT_CLT, @MONTANT_REG_CLIENT,@MONTANT_PIECE, @RESTE,";
                cmd.CommandText += " @NUM_PIECE_CLIENT, @BANQUE_CLIENT, @OBSERVATION, @CODE_COMPTE_CLIENT, @TYPE_PIECE)";

                foreach (DataRow dr in dtReglement.Rows)
                {
                    cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "erreur reg1 tc";
                    cmd.Parameters.Add("@DATE_REG_CLT", SqlDbType.DateTime).Value = DateTime.Now; res.MESSAGE = "erreur reg2 tc";
                    cmd.Parameters.Add("@MODE_REGLEMENT_CLT", SqlDbType.NVarChar).Value = dr["MODE_REGLEMENT_CLT"]; res.MESSAGE = "erreur reg3 tc" + MONTANT_RECU;
                    cmd.Parameters.Add("@MONTANT_REG_CLIENT", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["MONTANT_REG_CLIENT"]); res.MESSAGE = "erreur reg4 tc" + MONTANT_TTC;
                    cmd.Parameters.Add("@MONTANT_PIECE", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["MONTANT_PIECE"]); res.MESSAGE = "erreur reg5 tc" + RESTE;
                    cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["RESTE"]); res.MESSAGE = "erreur reg6 tc";
                    cmd.Parameters.Add("@NUM_PIECE_CLIENT", SqlDbType.NVarChar).Value = dr["NUM_PIECE_CLIENT"].ToString(); res.MESSAGE = "erreur reg7 tc";
                    cmd.Parameters.Add("@BANQUE_CLIENT", SqlDbType.NVarChar).Value = dr["BANQUE_CLIENT"].ToString(); res.MESSAGE = "erreur reg8 tc";
                    cmd.Parameters.Add("@OBSERVATION", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "erreur reg9 tc";
                    cmd.Parameters.Add("@TYPE_PIECE", SqlDbType.NVarChar).Value = "TC"; res.MESSAGE = "erreur reg9 tc";
                    cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CodeCompteClient; res.MESSAGE = "erreur reg10 tc" + CODE_TC;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                res.MESSAGE = "erreur CodeReg";
                cmd.CommandText = "SELECT MAX(CODE_REGLEMENT_CLIENT) FROM REGLEMENT_CLIENT";
                decimal CODE_REG = (decimal)cmd.ExecuteScalar();


                cmd.CommandText = "INSERT INTO TICKET_CAISSE (CODE_TC, DATE_TC, CODE_CAISSE, CODE_CLIENT, MONTANT_HT, REMISE, MONTANT_TVA, MONTANT_TTC ";
                cmd.CommandText += " , MONTANT_RECU, RESTE, MAGASIN, CODE_USER, CODE_REGLEMENT, CODE_FACTURE) VALUES";
                cmd.CommandText += " (@CODE_TC, @DATE_TC, @CODE_CAISSE, @CODE_CLIENT, @MONTANT_HT, @REMISE, @MONTANT_TVA, @MONTANT_TTC";
                cmd.CommandText += " , @MONTANT_RECU, @RESTE, @MAGASIN, @CODE_USER, @CODE_REGLEMENT, @CODE_FACTURE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_TC", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_TC", SqlDbType.DateTime).Value = DATE_FACTURE; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_CAISSE", SqlDbType.Decimal).Value = Convert.ToDecimal("1"); res.MESSAGE = "3";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_CLIENT); res.MESSAGE = "4";
                cmd.Parameters.Add("@MONTANT_HT", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_HT_FACTURE); res.MESSAGE = "5";
                cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = Convert.ToDecimal(REMISE); res.MESSAGE = "6";
                cmd.Parameters.Add("@MONTANT_TVA", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TVA); res.MESSAGE = "7";
                cmd.Parameters.Add("@MONTANT_TTC", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_TTC); res.MESSAGE = "8";
                cmd.Parameters.Add("@MONTANT_RECU", SqlDbType.Decimal).Value = Convert.ToDecimal(MONTANT_RECU); res.MESSAGE = "9";
                cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = Convert.ToDecimal(RESTE); res.MESSAGE = "10";
                cmd.Parameters.Add("@MAGASIN", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_MAG); res.MESSAGE = "11";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = Convert.ToDecimal(CODE_USER); res.MESSAGE = "12";
                cmd.Parameters.Add("@CODE_REGLEMENT", SqlDbType.Decimal).Value = CODE_REG; res.MESSAGE = "13";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = "";

                cmd.ExecuteNonQuery(); res.MESSAGE = "an error occured when executing request!!!!!";
                cmd.Parameters.Clear();
                DataTable article = new DataTable();




                foreach (DataRow dr in dt_lg_facture.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_TC (CODE_TC, CODE_ARTICLE, QTE, UNITE, PRIX_HT, TAUX_REMISE,";
                    cmd.CommandText += " TVA, PRIX_TTC) VALUES (@CODE_TC, @CODE_ARTICLE, @QTE, @UNITE, @PRIX_HT, @TAUX_REMISE,";
                    cmd.CommandText += " @TVA, @PRIX_TTC)";
                    cmd.Parameters.Add("@CODE_TC", SqlDbType.NVarChar).Value = CODE_TC; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_FI"]; res.MESSAGE = "23";
                    cmd.Parameters.Add("@UNITE", SqlDbType.NVarChar).Value = dr["LIB_UNITE"]; res.MESSAGE = "24";
                    cmd.Parameters.Add("@PRIX_HT", SqlDbType.Decimal).Value = dr["P_HT_FI"]; res.MESSAGE = "25";
                    cmd.Parameters.Add("@TAUX_REMISE", SqlDbType.Decimal).Value = dr["REMISE_FI"]; res.MESSAGE = "26";
                    cmd.Parameters.Add("@TVA", SqlDbType.Decimal).Value = dr["TVA_FI"]; res.MESSAGE = "27";
                    cmd.Parameters.Add("@PRIX_TTC", SqlDbType.Decimal).Value = (decimal)dr["P_HT_FI"] * (1 - (decimal)dr["REMISE_FI"] / 100) * (1 + (decimal)dr["TVA_FI"] / 100); res.MESSAGE = "28";


                    cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                    cmd.Parameters.Clear();

                    dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";

                    if (article.Rows.Count == 0)
                    {
                        Exception er = new Exception("Erreur lors de stockage de l'article.");
                        throw er;
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK- @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_FI"];
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE- @QTTE_LG_FACTURE WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                    cmd.Parameters.Add("@QTTE_LG_FACTURE", SqlDbType.Decimal).Value = (decimal)dr["QTE_FI"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                }


                cmd.CommandText = "UPDATE FICHE_INTERVENTION SET TYPE_PIECE_REG='TC', CODE_B_LIV=@CODE_PIECE_REG WHERE (NUM_FI=@NUM_FI)";
                cmd.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = NUM_FI;
                cmd.Parameters.Add("@CODE_PIECE_REG", SqlDbType.NVarChar).Value = CODE_TC;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                sqltrans.Commit();

                res.MESSAGE = String.Format("Ticket de Caisse N°:{0} enregistrée avec succès.", CODE_TC);
                res.OK = true;
                res.CODE = CODE_TC;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE += er.Message;
            }
            return res;
        }


        [WebMethod]
        public DataTable LOAD_B_LIV_CLIENT_NON_GENERE(string CODE_CLIENT)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_CLIENT='" + CODE_CLIENT + "' AND FACTURED='False'", CnxBase.myConn))
                {

                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {

            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_PIECE_NON_FACTURE_CLIENT(decimal CODE_CLIENT)
        {

            DataTable dt = new DataTable("MySrcTable");
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM V_PIECE_CLIENT_SANS_FACTURE WHERE CODE_CLIENT='" + CODE_CLIENT + "'", CnxBase.myConn))
                {

                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {

            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_TICKET_CAISSE_SANS_FACTURES_PERIODE(string dateDebut, string dateFin)
        {
            string reqSql = "SELECT     'TC' AS TYPE_PIECE, CODE_TC AS CODE_PIECE, DATE_TC AS DATE_PIECE, CODE_CLIENT, MONTANT_TTC AS MONTANT_PIECE, CASE WHEN (RESTE > 0) ";
            reqSql += " THEN 0 ELSE RESTE END AS RESTE_NP, CODE_FACTURE ";
            reqSql += " FROM         dbo.TICKET_CAISSE ";
            reqSql += " WHERE     CODE_FACTURE = ''";
            reqSql += " and convert(date,DATE_TC) between convert(date, '" + dateDebut + "') and convert(date, '" + dateFin + "')";

            DataTable dt = new DataTable("MySrcTable");
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn))
                {

                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {

            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_TICKET_CAISSE_SANS_FACTURES_PAR_DATE(string date)
        {
            string reqSql = "SELECT     'TC' AS TYPE_PIECE, CODE_TC AS CODE_PIECE, DATE_TC AS DATE_PIECE, CODE_CLIENT, MONTANT_TTC AS MONTANT_PIECE, CASE WHEN (RESTE > 0) ";
            reqSql += " THEN 0 ELSE RESTE END AS RESTE_NP, CODE_FACTURE ";
            reqSql += " FROM         dbo.TICKET_CAISSE ";
            reqSql += " WHERE     CODE_FACTURE = ''";
            reqSql += " and convert(date, DATE_TC) = convert(date, '" + date + "')";

            DataTable dt = new DataTable("MySrcTable");
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn))
                {

                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {

            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_B_LIV_FACTURE(string CODE_B_LIV)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON inner join MAGAZIN on BON_DE_LIVRAISON.CODE_MAG=MAGAZIN.CODE_MAG WHERE CODE_B_LIV='" + CODE_B_LIV + "'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {

            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_CLIENT_FACTURE(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENT WHERE CODE_CLIENT='" + CODE_CLIENT + "'", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {

            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_LG_B_LIV(string CODE_B_LIV)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LG_BON_LIVRAISON.CODE_B_LIV, LG_BON_LIVRAISON.CODE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV,                       LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV, LG_BON_LIVRAISON.PRIX_TOTAL_HT, LG_BON_LIVRAISON.PRIX_U_TTC,                       LG_BON_LIVRAISON.PRIX_TOTAL_TTC, LG_BON_LIVRAISON.REMISE, ARTICLE.CODE_ARTICLE , ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.DESCRIPTION_ARTICLE FROM         LG_BON_LIVRAISON INNER JOIN                      ARTICLE ON LG_BON_LIVRAISON.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE (LG_BON_LIVRAISON.CODE_B_LIV='" + CODE_B_LIV + "')", CnxBase.myConn))
                {
                    //da.SelectCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        public DataTable LOAD_REGLEMENT_FACTURE(string CODE_FACTURE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        [WebMethod]
        public DataTable SELECT_FACTURE_ANNULEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE ANNULATION_FACTURE=@ANNULATION_FACTURE", CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@ANNULATION_FACTURE", SqlDbType.Bit).Value = "True";
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {

            }
            return dt; ;
        }

        [WebMethod]
        public DataTable SELECT_FACTURE_NON_REGLEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (CREDIT=MONTANT_TOTAL_FACTURE)", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt; ;
        }

        [WebMethod]
        public DataTable SELECT_FACTURE_PARTIELLEMENT_REGLEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (CREDIT<MONTANT_TOTAL_FACTURE)", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {

            }
            return dt; ;
        }

        [WebMethod]
        public DataTable SELECT_FACTURE_REGLEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (CREDIT=0)", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {

            }
            return dt; ;
        }

        [WebMethod]
        public RESULT_QUERY UPDATE_ETAT_FACTURE(string CODE_FACTURE, decimal MONTANT_PAYE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string etat = "";
            decimal reste;
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {

                cmd.CommandText = "SELECT CREDIT FROM FACTURE WHERE CODE_FACTURE=@CODE_FACTURE";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                decimal CREDIT = (decimal)cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                if (MONTANT_PAYE < CREDIT)
                {
                    etat = "Partiellement reglée";
                    reste = CREDIT - MONTANT_PAYE;
                    res.CODE = reste.ToString();
                    res.MESSAGE = "Réglement enregistré avec succès : il reste" + reste.ToString();
                }
                if ((Convert.ToDecimal(MONTANT_PAYE)) >= CREDIT)
                {
                    etat = "Reglée";
                    reste = MONTANT_PAYE - CREDIT;
                    res.CODE = reste.ToString();
                    res.MESSAGE = "La facture est payée le reste est :\n" + reste.ToString();
                }

                cmd.CommandText = "UPDATE FACTURE SET REGLER=@REGLER, CREDIT=CREDIT-@MONTANT_PAYE WHERE (CODE_FACTURE=@CODE_FACTURE)";
                cmd.Parameters.Add("@REGLER", SqlDbType.NVarChar).Value = etat;
                cmd.Parameters.Add("@MONTANT_PAYE", SqlDbType.Decimal).Value = MONTANT_PAYE;
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();
                res.OK = true;

            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }



        [WebMethod]
        public DataTable LOAD_SCHEMA_LG_FACTURE()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     LG_BON_LIVRAISON.CODE_B_LIV, LG_BON_LIVRAISON.CODE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV,                      LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV, LG_BON_LIVRAISON.PRIX_TOTAL_HT, LG_BON_LIVRAISON.PRIX_U_TTC,                       LG_BON_LIVRAISON.PRIX_TOTAL_TTC,  ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM         ARTICLE INNER JOIN                     LG_BON_LIVRAISON ON ARTICLE.CODE_ARTICLE = LG_BON_LIVRAISON.CODE_ARTICLE", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

            return dt;
        }

        [WebMethod]
        public DataTable LOAD_SCHEMA_LG_FACTURE_DIRECTE()
        {
            DataTable dt = new DataTable();


            using (SqlDataAdapter da = new SqlDataAdapter("SELECT        LIGNE_FACTURE.TVA_ARTICLE, LIGNE_FACTURE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.UNITE_QTE_ARTICLE, LIGNE_FACTURE.QTE, LIGNE_FACTURE.PRIX_HT_ARTICLE,  LIGNE_FACTURE.PRIX_TOTAL_HT, LIGNE_FACTURE.PRIX_U_TTC, LIGNE_FACTURE.PRIX_TOTAL_TTC, LIGNE_FACTURE.REMISE, LIGNE_FACTURE.PRIX_FACTURE FROM LIGNE_FACTURE INNER JOIN ARTICLE ON LIGNE_FACTURE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE LIGNE_FACTURE.CODE_FACTURE like ''", CnxBase.myConn))
            {
                //da.SelectCommand.Transaction = CnxBase.trans;
                //da.FillSchema(dt, SchemaType.Source);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }

            return dt;
        }

        [WebMethod]
        public void FACTURATION_CLIENT(string CODE_FACTURE, string CODE_B_LIV, DateTime DATE_FACTURE)
        {
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "INSERT INTO FACTURATION(CODE_B_LIV, CODE_FACTURE, DATE_FACTURATION) VALUES(@CODE_B_LIV, @CODE_FACTURE, @DATE_FACTURATION)";
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                cmd.Parameters.Add("@DATE_FACTURATION", SqlDbType.DateTime).Value = DATE_FACTURE;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                throw er;
            }

        }

        [WebMethod]
        public DataTable LOAD_FACTURE_PAR_CLIENT(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CnxBase.myConn))
                {
                    da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                    //da.SelectCommand.ExecuteNonQuery();
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        [WebMethod]
        public DataTable SELECT_ALL_FACTURES()
        {
            DataTable dt = new DataTable();
            string reqsql = "SELECT        FACTURE.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.CODE_CLIENT, FACTURE.MONTANT_HT_FACTURE, FACTURE.MONTANT_TVA, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE, ";
            reqsql += " FACTURE.MONTANT_BASE, FACTURE.TIMBRE_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_LETTRE, FACTURE.ANNULATION_FACTURE, FACTURE.REGLER, FACTURE.CREDIT,  ";
            reqsql += "  FACTURE.MAGASIN, FACTURE.CODE_USER, FACTURE.PRENOM_USER, FACTURE.NOM_USER, FACTURE.REMARQUE, FACTURE.REMISE, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT,  ";
            reqsql += " UTILISATEUR.PRENOM_USER + ' ' + UTILISATEUR.NOM_USER AS NOM_UTILISATEUR ";
            reqsql += " FROM            FACTURE INNER JOIN ";
            reqsql += "     CLIENT ON FACTURE.CODE_CLIENT = CLIENT.CODE_CLIENT INNER JOIN ";
            reqsql += "   UTILISATEUR ON FACTURE.CODE_USER = UTILISATEUR.CODE_USER";
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(reqsql, CnxBase.myConn))
                {
                    //da.SelectCommand.Transaction = CnxBase.trans;
                    //da.SelectCommand.ExecuteNonQuery();
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }

            return dt;
        }



        [WebMethod]
        public DataTable LOAD_FACTURE_PAR_CODE(string CODE_FATCURE)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_FACTURE='" + CODE_FATCURE + "'", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_LIGNES_FACTURE(string CODE_FATCURE)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_FACTURE.CODE_FACTURE, LIGNE_FACTURE.REMISE, LIGNE_FACTURE.QTE, LIGNE_FACTURE.TVA_ARTICLE, LIGNE_FACTURE.PRIX_HT_ARTICLE, LIGNE_FACTURE.PRIX_TOTAL_HT, LIGNE_FACTURE.PRIX_U_TTC, LIGNE_FACTURE.PRIX_TOTAL_TTC, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.CODE_ARTICLE    FROM         LIGNE_FACTURE INNER JOIN                      ARTICLE ON LIGNE_FACTURE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE   WHERE CODE_FACTURE='" + CODE_FATCURE + "'", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }



        [WebMethod]
        public DataTable RECHERCHE_FACTURE(string param, string etat)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (REGLER LIKE'%" + etat + "%') AND ((CODE_FACTURE LIKE'%" + param + "%')OR(DATE_FACTURE LIKE'%" + param + "%') OR (CODE_CLIENT LIKE'%" + param + "%') OR (NOM_USER LIKE'%" + param + "%') OR (PRENOM_USER LIKE'%" + param + "%'))", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }



        [WebMethod]
        public DataTable LOAD_SCHEMA_LIGNE_B_LIV_FACTURE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON", CnxBase.myConn))
                {
                    da.SelectCommand.Transaction = CnxBase.trans;
                    da.FillSchema(dt, SchemaType.Source);
                }

            }
            catch (Exception)
            {
            }
            return dt;
        }

        [WebMethod]
        public DataTable ImprimerTICET_FACTURE_CLIENT(string CODE_FACTURE)
        {
            string commandText = "";
            commandText = "SELECT        FACTURE.DATE_FACTURE, FACTURE.CODE_CLIENT, FACTURE.MONTANT_HT_FACTURE, FACTURE.MONTANT_TVA, FACTURE.MONTANT_TTC, ";
            commandText += "FACTURE.TAUX_REMISE, FACTURE.MONTANT_BASE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.TIMBRE_FACTURE, FACTURE.MONTANT_LETTRE, ";
            commandText += "FACTURE.CODE_USER, FACTURE.MAGASIN, FACTURE.CODE_FACTURE, LIGNE_FACTURE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, LIGNE_FACTURE.QTE, ";
            commandText += "ARTICLE.REF_ARTICLE, LIGNE_FACTURE.PRIX_HT_ARTICLE, LIGNE_FACTURE.PRIX_TOTAL_HT, LIGNE_FACTURE.PRIX_U_TTC, ";
            commandText += "LIGNE_FACTURE.PRIX_TOTAL_TTC, LIGNE_FACTURE.REMISE, SOCIETE.RS_SOCIETE, SOCIETE.DESCRIPTION_SOCIETE, SOCIETE.ADRESSE_SOCIETE, ";
            commandText += "SOCIETE.CP_SOCIETE, SOCIETE.TEL_SOCIETE, SOCIETE.FAX_SOCIETE, SOCIETE.EMAIL_SOCIETE, SOCIETE.SITE_WEB_SOCETE, SOCIETE.LOGO_SOCIETE,";
            commandText += "SOCIETE.CODE_TVA_SOCIETE, FACTURE.REGLER, FACTURE.CREDIT, FACTURE.REMARQUE, UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER , ";
            commandText += "UTILISATEUR.PRENOM_USER+' '+UTILISATEUR.NOM_USER as USERNAME ";
            commandText += "FROM            FACTURE INNER JOIN ";
            commandText += "LIGNE_FACTURE ON FACTURE.CODE_FACTURE = LIGNE_FACTURE.CODE_FACTURE INNER JOIN ";
            commandText += "ARTICLE ON LIGNE_FACTURE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE INNER JOIN ";
            commandText += "UTILISATEUR ON FACTURE.CODE_USER = UTILISATEUR.CODE_USER INNER JOIN ";
            commandText += "SOCIETE ON UTILISATEUR.CODE_SOCIETE = SOCIETE.CODE_SOCIETE where FACTURE.CODE_FACTURE='" + CODE_FACTURE + "'";
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(commandText, CnxBase.myConn))
                {

                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable Imprimer_FACTURE_CLIENT(string CODE_FACTURE)
        {
            string commandText = "";
            commandText += " SELECT     dbo.FACTURE.CODE_FACTURE, dbo.FACTURE.DATE_FACTURE, dbo.FACTURE.CODE_CLIENT, dbo.FACTURE.MONTANT_HT_FACTURE, dbo.FACTURE.MONTANT_TVA, ";
            commandText += " dbo.FACTURE.MONTANT_TTC, dbo.FACTURE.TAUX_REMISE, dbo.FACTURE.MONTANT_BASE, dbo.FACTURE.TIMBRE_FACTURE, ";
            commandText += " dbo.FACTURE.MONTANT_TOTAL_FACTURE, dbo.FACTURE.MONTANT_LETTRE, dbo.FACTURE.ANNULATION_FACTURE, dbo.FACTURE.REGLER, dbo.FACTURE.CREDIT, ";
            commandText += " dbo.FACTURE.MAGASIN, dbo.FACTURE.CODE_USER, dbo.FACTURE.PRENOM_USER + ' ' + dbo.FACTURE.NOM_USER AS USERNAME , dbo.FACTURE.REMARQUE, dbo.CLIENT.REF_CLIENT, ";
            commandText += " dbo.CLIENT.RS_CLIENT, dbo.CLIENT.ADRESSE_CLIENT, dbo.CLIENT.CP_CLIENT, dbo.CLIENT.TEL_CLIENT, dbo.CLIENT.FAX_CLIENT, dbo.CLIENT.EMAIL_CLIENT, ";
            commandText += " dbo.CLIENT.EXO_CLIENT, dbo.CLIENT.CODE_TVA_CLIENT, dbo.CLIENT.COMPTE, dbo.LIGNE_FACTURE.CODE_ARTICLE, dbo.LIGNE_FACTURE.CODE_BL, dbo.LIGNE_FACTURE.TYPE_PIECE, dbo.LIGNE_FACTURE.QTE, ";
            commandText += " dbo.LIGNE_FACTURE.TVA_ARTICLE, dbo.LIGNE_FACTURE.PRIX_HT_ARTICLE, dbo.LIGNE_FACTURE.PRIX_TOTAL_HT, dbo.LIGNE_FACTURE.PRIX_U_TTC, ";
            commandText += " dbo.LIGNE_FACTURE.PRIX_TOTAL_TTC, dbo.LIGNE_FACTURE.REMISE, dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE, ";
            commandText += " dbo.ARTICLE.MARQUE_ARTICLE, dbo.ARTICLE.DESCRIPTION_ARTICLE, dbo.ARTICLE.UNITE_QTE_ARTICLE, dbo.CLIENT.VILLE_CLIENT, dbo.CLIENT.PAYS_CLIENT, ";
            commandText += " dbo.SOCIETE.RS_SOCIETE, dbo.SOCIETE.ADRESSE_SOCIETE, dbo.SOCIETE.DESCRIPTION_SOCIETE, dbo.SOCIETE.CP_SOCIETE, dbo.SOCIETE.TEL_SOCIETE, ";
            commandText += " dbo.SOCIETE.FAX_SOCIETE, dbo.SOCIETE.EMAIL_SOCIETE, dbo.SOCIETE.SITE_WEB_SOCETE, dbo.SOCIETE.LOGO_SOCIETE, dbo.SOCIETE.CODE_TVA_SOCIETE, ";
            commandText += "      dbo.SOCIETE.RIB_SOCIETE";
            commandText += " FROM         dbo.FACTURE INNER JOIN";
            commandText += " dbo.UTILISATEUR ON dbo.FACTURE.CODE_USER = dbo.UTILISATEUR.CODE_USER INNER JOIN";
            commandText += " dbo.CLIENT ON dbo.FACTURE.CODE_CLIENT = dbo.CLIENT.CODE_CLIENT INNER JOIN";
            commandText += " dbo.LIGNE_FACTURE ON dbo.FACTURE.CODE_FACTURE = dbo.LIGNE_FACTURE.CODE_FACTURE INNER JOIN";
            commandText += " dbo.ARTICLE ON dbo.LIGNE_FACTURE.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE CROSS JOIN";
            commandText += " dbo.SOCIETE";
            commandText += "    WHERE dbo.FACTURE.CODE_FACTURE like '" + CODE_FACTURE + "'";
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(commandText, CnxBase.myConn))
                {

                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_LISTE_VENTE_PAR_DATE(DateTime date_debut, DateTime date_fin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select article.code_article, designation_article, SUM(ligne_facture.qte) as qte, SUM(ligne_facture.qte*LIGNE_FACTURE.PRIX_U_TTC) as total from FACTURE inner join LIGNE_FACTURE on FACTURE.CODE_FACTURE=LIGNE_FACTURE.CODE_FACTURE inner join ARTICLE on ARTICLE.CODE_ARTICLE=LIGNE_FACTURE.CODE_ARTICLE where convert(nvarchar,FACTURE.DATE_FACTURE,103) between '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE ", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(DateTime date_debut, DateTime date_fin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select facture.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE* FACTURE.MONTANT_TTC/100 as REMISE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE-FACTURE.CREDIT as  REGLER, FACTURE.CREDIT , UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER as [USER], CLIENT.RS_CLIENT from FACTURE inner join UTILISATEUR on FACTURE.CODE_USER=UTILISATEUR.CODE_USER inner join CLIENT on FACTURE.CODE_CLIENT=CLIENT.CODE_CLIENT WHERE convert(nvarchar,FACTURE.DATE_FACTURE,103) BETWEEN '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' order by FACTURE.DATE_FACTURE", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal code_user)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select facture.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE* FACTURE.MONTANT_TTC/100 as REMISE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE-FACTURE.CREDIT as  REGLER, FACTURE.CREDIT , UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER as [USER], CLIENT.RS_CLIENT from FACTURE inner join UTILISATEUR on FACTURE.CODE_USER=UTILISATEUR.CODE_USER inner join CLIENT on FACTURE.CODE_CLIENT=CLIENT.CODE_CLIENT WHERE convert(nvarchar,FACTURE.DATE_FACTURE,103) BETWEEN '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' and FACTURE.CODE_USER='" + code_user + "' order by FACTURE.DATE_FACTURE", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal code_user)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select article.code_article, designation_article, SUM(ligne_facture.qte) as qte, SUM(ligne_facture.qte*LIGNE_FACTURE.PRIX_U_TTC) as [totalv] , UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER  as UTILISATEUR from FACTURE inner join LIGNE_FACTURE on FACTURE.CODE_FACTURE=LIGNE_FACTURE.CODE_FACTURE inner join ARTICLE on ARTICLE.CODE_ARTICLE=LIGNE_FACTURE.CODE_ARTICLE inner join UTILISATEUR on UTILISATEUR.CODE_USER=FACTURE.CODE_USER where FACTURE.CODE_USER='" + code_user + "' and convert(nvarchar,FACTURE.DATE_FACTURE,103) between  '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER, ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE ", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_GAIN_DETAIL(DateTime datedebut, DateTime datefin)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, SUM(LIGNE_FACTURE.QTE) as qtte,  SUM(LIGNE_FACTURE.QTE*LIGNE_FACTURE.PRIX_U_TTC) as total_v, SUM(LIGNE_FACTURE.QTE*ARTICLE.PRIX_HT_A_ARTICLE) as total_a, SUM(LIGNE_FACTURE.QTE*LIGNE_FACTURE.PRIX_U_TTC)- SUM(LIGNE_FACTURE.QTE*ARTICLE.PRIX_HT_A_ARTICLE) as total_g from LIGNE_FACTURE inner join ARTICLE on LIGNE_FACTURE.CODE_ARTICLE=ARTICLE.CODE_ARTICLE inner join FACTURE on FACTURE.CODE_FACTURE=LIGNE_FACTURE.CODE_FACTURE where convert(date, FACTURE.DATE_FACTURE) between CONVERT(date,'" + datedebut.ToShortDateString() + "') and CONVERT(date,'" + datefin.ToShortDateString() + "') group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE order by ARTICLE.CODE_ARTICLE", CnxBase.myConn))
                {
                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_qte_retour(DateTime datedebut, DateTime datefin)
        {
            DataTable dt_retour = new DataTable();

            try
            {
                using (SqlDataAdapter da_retour = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT) as qtte, SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT)- SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*ARTICLE.PRIX_HT_A_ARTICLE) as total_p  from LIGNE_BRETOUR_CLIENT inner join BON_RETOUR_CLIENT on LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT=BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT inner join ARTICLE on ARTICLE.CODE_ARTICLE=LIGNE_BRETOUR_CLIENT.CODE_ARTICLE where CONVERT(date, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT) between CONVERT(date,'" + datedebut.ToShortDateString() + "') and CONVERT(date,'" + datefin.ToShortDateString() + "') group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE order by ARTICLE.CODE_ARTICLE", CnxBase.myConn))
                {
                    //da_retour.FillSchema(dt_retour, SchemaType.Source);
                    //da_retour.Fill(dt_retour);
                    dt_retour = CnxBase.GetDataTable(da_retour.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt_retour;
        }

        #endregion

        #region CHM_FOURNISSEUR Membres
        [WebMethod]
        public string DELETE_FOURNISSEUR(string CODE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM FOURNISSEUR WHERE  (CODE_FOURNISSEUR= @CODE_FOURNISSEUR)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        [WebMethod]
        public string INSERT_FOURNISSEUR(string CODE, string REF, string RS, string ADRESSE, string TEL, string FAX, string EMAIL, string SITEWEB, string RIB, string CODE_TVA, decimal RETENUE_SOURCE)
        {
            try
            {

                using (SqlCommand cmd_code = new SqlCommand("SELECT     ISNULL(MAX(CODE_FOURNISSEUR), 0) + 1  FROM         FOURNISSEUR", CnxBase.myConn))
                {
                    CODE = ((decimal)cmd_code.ExecuteScalar()).ToString();
                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO FOURNISSEUR (CODE_FOURNISSEUR, REF_FOURNISSEUR, RS_FOURNISSEUR, ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR, FAX_FOURNISSEUR, EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR, RETENUE_SOURCE) VALUES     (@CODE_FOURNISSEUR, @REF_FOURNISSEUR, @RS_FOURNISSEUR, @ADRESSE_FOURNISSEUR, @TEL_FOURNISSEUR, @FAX_FOURNISSEUR, @EMAIL_FOURNISSEUR, @SITE_WEB_FOURNISSEUR, @RIB_FOURNISSEUR, @CODE_TVA_FOURNISSEUR, @RETENUE_SOURCE)", CnxBase.myConn))
                {
                    cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@REF_FOURNISSEUR", SqlDbType.NVarChar).Value = REF;
                    cmd.Parameters.Add("@RS_FOURNISSEUR", SqlDbType.NVarChar).Value = RS;
                    cmd.Parameters.Add("@ADRESSE_FOURNISSEUR", SqlDbType.NVarChar).Value = ADRESSE;
                    cmd.Parameters.Add("@TEL_FOURNISSEUR", SqlDbType.NVarChar).Value = TEL;
                    cmd.Parameters.Add("@FAX_FOURNISSEUR", SqlDbType.NVarChar).Value = FAX;
                    cmd.Parameters.Add("@EMAIL_FOURNISSEUR", SqlDbType.NVarChar).Value = EMAIL;
                    cmd.Parameters.Add("@SITE_WEB_FOURNISSEUR", SqlDbType.NVarChar).Value = SITEWEB;
                    cmd.Parameters.Add("@RIB_FOURNISSEUR", SqlDbType.NVarChar).Value = RIB;
                    cmd.Parameters.Add("@CODE_TVA_FOURNISSEUR", SqlDbType.NVarChar).Value = CODE_TVA;
                    cmd.Parameters.Add("@RETENUE_SOURCE", SqlDbType.Decimal).Value = RETENUE_SOURCE;
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        [WebMethod]
        public DataTable LOAD_FOURNISSEUR(string CODE)
        {
            DataTable FOURNISSEUR_dt = new DataTable();
            try
            {
                using (SqlDataAdapter FOURNISSEUR_da = new SqlDataAdapter("SELECT * FROM FOURNISSEUR WHERE CODE_FOURNISSEUR= '" + CODE + "'", CnxBase.myConn))
                {
                    FOURNISSEUR_dt = CnxBase.GetDataTable(FOURNISSEUR_da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return FOURNISSEUR_dt;
        }

        [WebMethod]
        public DataTable SEARCH_FOURNISSEUR(string INDICE)
        {
            SqlDataAdapter FOURNISSEUR_da = new SqlDataAdapter("SELECT     CODE_FOURNISSEUR, REF_FOURNISSEUR, RS_FOURNISSEUR, ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR, FAX_FOURNISSEUR, EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR FROM FOURNISSEUR WHERE (RS_FOURNISSEUR like '%" + INDICE + "%') OR (ADRESSE_FOURNISSEUR like '%" + INDICE + "%') OR ( REF_FOURNISSEUR like '%" + INDICE + "%') OR ( EMAIL_FOURNISSEUR like '%" + INDICE + "%')", CnxBase.myConn);
            DataTable FOURNISSEUR_dt = new DataTable();
            FOURNISSEUR_dt = CnxBase.GetDataTable(FOURNISSEUR_da.SelectCommand.CommandText);
            return FOURNISSEUR_dt;
        }

        [WebMethod]
        public string UPDATE_FOURNISSEUR(string CODE, string REF, string RS, string ADRESSE, string TEL, string FAX, string EMAIL, string SITEWEB, string RIB, string CODE_TVA, decimal RETENUE_SOURCE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE FOURNISSEUR SET  REF_FOURNISSEUR=@REF_FOURNISSEUR, RS_FOURNISSEUR=@RS_FOURNISSEUR, ADRESSE_FOURNISSEUR=@ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR=@TEL_FOURNISSEUR, FAX_FOURNISSEUR=@FAX_FOURNISSEUR, EMAIL_FOURNISSEUR=@EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR=@SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR=@RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR=@CODE_TVA_FOURNISSEUR, RETENUE_SOURCE=@RETENUE_SOURCE WHERE (CODE_FOURNISSEUR=@CODE_FOURNISSEUR)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@REF_FOURNISSEUR", SqlDbType.NVarChar).Value = REF;
                cmd.Parameters.Add("@RS_FOURNISSEUR", SqlDbType.NVarChar).Value = RS;
                cmd.Parameters.Add("@ADRESSE_FOURNISSEUR", SqlDbType.NVarChar).Value = ADRESSE;
                cmd.Parameters.Add("@TEL_FOURNISSEUR", SqlDbType.NVarChar).Value = TEL;
                cmd.Parameters.Add("@FAX_FOURNISSEUR", SqlDbType.NVarChar).Value = FAX;
                cmd.Parameters.Add("@EMAIL_FOURNISSEUR", SqlDbType.NVarChar).Value = EMAIL;
                cmd.Parameters.Add("@SITE_WEB_FOURNISSEUR", SqlDbType.NVarChar).Value = SITEWEB;
                cmd.Parameters.Add("@RIB_FOURNISSEUR", SqlDbType.NVarChar).Value = RIB;
                cmd.Parameters.Add("@CODE_TVA_FOURNISSEUR", SqlDbType.NVarChar).Value = CODE_TVA;
                cmd.Parameters.Add("@RETENUE_SOURCE", SqlDbType.Decimal).Value = RETENUE_SOURCE;
                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        [WebMethod]
        public DataTable SELECT_ALL_FOURNISSEURS()
        {
            SqlDataAdapter FOURNISSEUR_da = new SqlDataAdapter(" SELECT CODE_FOURNISSEUR, REF_FOURNISSEUR, RS_FOURNISSEUR, ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR, FAX_FOURNISSEUR, EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR FROM FOURNISSEUR", CnxBase.myConn);
            DataTable FOURNISSEUR_dt = new DataTable();
            FOURNISSEUR_dt = CnxBase.GetDataTable(FOURNISSEUR_da.SelectCommand.CommandText);
            return FOURNISSEUR_dt;
        }



        public string NEW_CODE_FOURNISSEUR(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region CHM_CMD_FOURNISSEUR
        [WebMethod]
        public RESULT_QUERY ajouteCOMMANDE_FOURNISSEUR(DCOMMANDE_FOURNISSEUR myCOMMANDE_FOURNISSEUR, DataTable dtDetails)
        {

            string reqSQL = "INSERT INTO COMMANDE_FOURNISSEUR	(CODE_COMMANDE_FOURNISSEUR, DATE_COMMANDE_FOURNISSEUR, CODE_USER, PRIORITE_COMMANDE_FOURNISSEUR, DATE_EXPIRATION_COMMANDE_FOURNISSEUR, CODE_FOURNISSEUR, ANNEE_CMDFR, MOIS_CMDFR, CODE_MAG, ADRESSE_LIVRAISON, CONTACT, TEL_CONTACT, REMARQUE)VALUES	('" + myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR + "', '" + myCOMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR + "', " + myCOMMANDE_FOURNISSEUR.CODE_USER + ", " + myCOMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR + ", '" + myCOMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR + "', " + myCOMMANDE_FOURNISSEUR.CODE_FOURNISSEUR + ", " + myCOMMANDE_FOURNISSEUR.ANNEE_CMDFR + ", " + myCOMMANDE_FOURNISSEUR.MOIS_CMDFR + ", " + myCOMMANDE_FOURNISSEUR.CODE_MAG + ", '" + myCOMMANDE_FOURNISSEUR.ADRESSE_LIVRAISON + "', '" + myCOMMANDE_FOURNISSEUR.CONTACT + "', '" + myCOMMANDE_FOURNISSEUR.TEL_CONTACT + "', '" + myCOMMANDE_FOURNISSEUR.REMARQUE + "')";

            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            RESULT_QUERY res = new RESULT_QUERY();

            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_CF) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_CF = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_CF, '') FROM         SOCIETE WHERE CODE_SOCIETE =1";
                string PREFIX1_CF = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix1 cmd";

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_CF, '') FROM         SOCIETE WHERE CODE_SOCIETE =1";
                string PREFIXE2_CF = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix2 cmd";

                myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR = string.Format("{0}{1}{2}", PREFIX1_CF, numberToString(5, Convert.ToInt32(NUM_CF)), PREFIXE2_CF);

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_CF = NUM_CF +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO COMMANDE_FOURNISSEUR	(CODE_COMMANDE_FOURNISSEUR, DATE_COMMANDE_FOURNISSEUR, CODE_USER, PRIORITE_COMMANDE_FOURNISSEUR, DATE_EXPIRATION_COMMANDE_FOURNISSEUR, CODE_FOURNISSEUR, ANNEE_CMDFR, MOIS_CMDFR, CODE_MAG, ADRESSE_LIVRAISON, CONTACT, TEL_CONTACT, REMARQUE) VALUES	(@CODE_COMMANDE_FOURNISSEUR, @DATE_COMMANDE_FOURNISSEUR, @CODE_USER, @PRIORITE_COMMANDE_FOURNISSEUR, @DATE_EXPIRATION_COMMANDE_FOURNISSEUR, @CODE_FOURNISSEUR, @ANNEE_CMDFR, @MOIS_CMDFR, @CODE_MAG, @ADRESSE_LIVRAISON, @CONTACT, @TEL_CONTACT, @REMARQUE)";

                cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@DATE_COMMANDE_FOURNISSEUR", SqlDbType.DateTime).Value = myCOMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = myCOMMANDE_FOURNISSEUR.CODE_USER;
                cmd.Parameters.Add("@PRIORITE_COMMANDE_FOURNISSEUR", SqlDbType.Bit).Value = myCOMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@DATE_EXPIRATION_COMMANDE_FOURNISSEUR", SqlDbType.DateTime).Value = myCOMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = myCOMMANDE_FOURNISSEUR.CODE_FOURNISSEUR;
                cmd.Parameters.Add("@ANNEE_CMDFR", SqlDbType.Int).Value = myCOMMANDE_FOURNISSEUR.ANNEE_CMDFR;
                cmd.Parameters.Add("@MOIS_CMDFR", SqlDbType.Int).Value = myCOMMANDE_FOURNISSEUR.MOIS_CMDFR;
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = myCOMMANDE_FOURNISSEUR.CODE_MAG;
                cmd.Parameters.Add("@ADRESSE_LIVRAISON", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.ADRESSE_LIVRAISON;
                cmd.Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CONTACT;
                cmd.Parameters.Add("@TEL_CONTACT", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.TEL_CONTACT;
                cmd.Parameters.Add("@REMARQUE", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.REMARQUE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                cmd.CommandText = "insert into lg_cmd_fr(CODE_COMMANDE_FOURNISSEUR, code_article, qte, prix_ht, remise, fodec, taux_tva, unite) values (@CODE_COMMANDE_FOURNISSEUR, @code_article, @qte, @prix_ht, @remise, @fodec, @taux_tva, @unite)";
                foreach (DataRow dr in dtDetails.Rows)
                {

                    cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                    cmd.Parameters.Add("@code_article", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@qte", SqlDbType.Decimal).Value = dr["QTE"];
                    cmd.Parameters.Add("@prix_ht", SqlDbType.Decimal).Value = dr["PRIX_HT"];
                    cmd.Parameters.Add("@remise", SqlDbType.Decimal).Value = dr["REMISE"];
                    cmd.Parameters.Add("@fodec", SqlDbType.Decimal).Value = dr["FODEC"];
                    cmd.Parameters.Add("@taux_tva", SqlDbType.Decimal).Value = dr["TAUX_TVA"];
                    cmd.Parameters.Add("@unite", SqlDbType.NVarChar).Value = dr["UNITE"];

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                trans.Commit();
                res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                res.OK = true;
                res.MESSAGE = string.Format("Commande N°{0} enregistrée avec succès.", res.CODE);

            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de la commande.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY validerCOMMANDE_FOURNISSEUR(DCOMMANDE_FOURNISSEUR myCOMMANDE_FOURNISSEUR)
        {

            string reqSQL = "update COMMANDE_FOURNISSEUR	set VALIDE=@VALIDE , USER_VALIDATION=@USER_VALIDATION, DATE_VALIDATION=@DATE_VALIDATION where code_commande_fournisseur=@CODE_COMMANDE_FOURNISSEUR";

            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            RESULT_QUERY res = new RESULT_QUERY();

            try
            {
                cmd.CommandText = reqSQL;

                cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@VALIDE", SqlDbType.Bit).Value = myCOMMANDE_FOURNISSEUR.VALIDE;
                cmd.Parameters.Add("@USER_VALIDATION", SqlDbType.Decimal).Value = myCOMMANDE_FOURNISSEUR.USER_VALIDATION;
                cmd.Parameters.Add("@DATE_VALIDATION", SqlDbType.DateTime).Value = myCOMMANDE_FOURNISSEUR.DATE_VALIDATION;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();




                trans.Commit();
                res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                res.OK = true;
                res.MESSAGE = string.Format("Commande N°{0} validée avec succès.", res.CODE);

            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de la validation de la commande.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public void effaceCOMMANDE_FOURNISSEUR(DCOMMANDE_FOURNISSEUR myCOMMANDE_FOURNISSEUR)
        {

            string reqSQL = "DELETE FROM COMMANDE_FOURNISSEUR WHERE (CODE_COMMANDE_FOURNISSEUR='" + myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        [WebMethod]
        public RESULT_QUERY modifieCOMMANDE_FOURNISSEUR(DCOMMANDE_FOURNISSEUR myCOMMANDE_FOURNISSEUR, DataTable dtDetails)
        {
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            RESULT_QUERY res = new RESULT_QUERY();

            try
            {
                cmd.CommandText = "select VALIDE from COMMANDE_FOURNISSEUR where CODE_COMMANDE_FOURNISSEUR=@CODE_COMMANDE_FOURNISSEUR";
                cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                string rep = cmd.ExecuteScalar().ToString();
                cmd.Parameters.Clear();
                if (rep == "True")
                {
                    trans.Rollback();
                    res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                    res.OK = false;
                    res.MESSAGE = "Commande déja validée, impossible de la modifier!";
                    return res;
                }


                cmd.CommandText = "UPDATE COMMANDE_FOURNISSEUR	set DATE_COMMANDE_FOURNISSEUR=@DATE_COMMANDE_FOURNISSEUR, PRIORITE_COMMANDE_FOURNISSEUR=@PRIORITE_COMMANDE_FOURNISSEUR, DATE_EXPIRATION_COMMANDE_FOURNISSEUR=@DATE_EXPIRATION_COMMANDE_FOURNISSEUR, CODE_FOURNISSEUR=@CODE_FOURNISSEUR, ANNEE_CMDFR=@ANNEE_CMDFR, MOIS_CMDFR=@MOIS_CMDFR, CODE_MAG=@CODE_MAG, ADRESSE_LIVRAISON=@ADRESSE_LIVRAISON, CONTACT=@CONTACT, TEL_CONTACT=@TEL_CONTACT, REMARQUE=@REMARQUE  WHERE (CODE_COMMANDE_FOURNISSEUR=@CODE_COMMANDE_FOURNISSEUR)";

                cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@DATE_COMMANDE_FOURNISSEUR", SqlDbType.DateTime).Value = myCOMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@PRIORITE_COMMANDE_FOURNISSEUR", SqlDbType.Bit).Value = myCOMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@DATE_EXPIRATION_COMMANDE_FOURNISSEUR", SqlDbType.DateTime).Value = myCOMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = myCOMMANDE_FOURNISSEUR.CODE_FOURNISSEUR;
                cmd.Parameters.Add("@ANNEE_CMDFR", SqlDbType.Int).Value = myCOMMANDE_FOURNISSEUR.ANNEE_CMDFR;
                cmd.Parameters.Add("@MOIS_CMDFR", SqlDbType.Int).Value = myCOMMANDE_FOURNISSEUR.MOIS_CMDFR;
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = myCOMMANDE_FOURNISSEUR.CODE_MAG;
                cmd.Parameters.Add("@ADRESSE_LIVRAISON", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.ADRESSE_LIVRAISON;
                cmd.Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CONTACT;
                cmd.Parameters.Add("@TEL_CONTACT", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.TEL_CONTACT;
                cmd.Parameters.Add("@REMARQUE", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.REMARQUE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "delete from lg_cmd_fr where CODE_COMMANDE_FOURNISSEUR=@CODE_COMMANDE_FOURNISSEUR";
                cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "insert into lg_cmd_fr(CODE_COMMANDE_FOURNISSEUR, code_article, qte, prix_ht, remise, fodec, taux_tva, unite) values (@CODE_COMMANDE_FOURNISSEUR, @code_article, @qte, @prix_ht, @remise, @fodec, @taux_tva, @unite)";
                foreach (DataRow dr in dtDetails.Rows)
                {

                    cmd.Parameters.Add("@CODE_COMMANDE_FOURNISSEUR", SqlDbType.NVarChar).Value = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                    cmd.Parameters.Add("@code_article", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@qte", SqlDbType.Decimal).Value = dr["QTE"];
                    cmd.Parameters.Add("@prix_ht", SqlDbType.Decimal).Value = dr["PRIX_HT"];
                    cmd.Parameters.Add("@remise", SqlDbType.Decimal).Value = dr["REMISE"];
                    cmd.Parameters.Add("@fodec", SqlDbType.Decimal).Value = dr["FODEC"];
                    cmd.Parameters.Add("@taux_tva", SqlDbType.Decimal).Value = dr["TAUX_TVA"];
                    cmd.Parameters.Add("@unite", SqlDbType.NVarChar).Value = dr["UNITE"];

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                trans.Commit();
                res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                res.OK = true;
                res.MESSAGE = string.Format("Commande N°{0} modifiée avec succès.", res.CODE);

            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.CODE = myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR;
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de la modification de la commande.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public DCOMMANDE_FOURNISSEUR obtenirInstanceCOMMANDE_FOURNISSEUR(DCOMMANDE_FOURNISSEUR myCOMMANDE_FOURNISSEUR)
        {
            string reqSQL = "SELECT CODE_COMMANDE_FOURNISSEUR, DATE_COMMANDE_FOURNISSEUR, CODE_USER, PRIORITE_COMMANDE_FOURNISSEUR, DATE_EXPIRATION_COMMANDE_FOURNISSEUR, CODE_FOURNISSEUR, ANNEE_CMDFR, MOIS_CMDFR, CODE_MAG, ADRESSE_LIVRAISON, CONTACT, TEL_CONTACT, REMARQUE		FROM COMMANDE_FOURNISSEUR	WHERE (CODE_COMMANDE_FOURNISSEUR='" + myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myCOMMANDE_FOURNISSEUR.CODE_COMMANDE_FOURNISSEUR = (String)myReader["CODE_COMMANDE_FOURNISSEUR"];

                    myCOMMANDE_FOURNISSEUR.DATE_COMMANDE_FOURNISSEUR = Convert.ToDateTime(myReader["DATE_COMMANDE_FOURNISSEUR"]);

                    myCOMMANDE_FOURNISSEUR.CODE_USER = (Decimal)myReader["CODE_USER"];

                    myCOMMANDE_FOURNISSEUR.PRIORITE_COMMANDE_FOURNISSEUR = myReader["PRIORITE_COMMANDE_FOURNISSEUR"].ToString() == "True" ? true : false;

                    myCOMMANDE_FOURNISSEUR.DATE_EXPIRATION_COMMANDE_FOURNISSEUR = Convert.ToDateTime(myReader["DATE_EXPIRATION_COMMANDE_FOURNISSEUR"]);

                    myCOMMANDE_FOURNISSEUR.CODE_FOURNISSEUR = (Decimal)myReader["CODE_FOURNISSEUR"];

                    myCOMMANDE_FOURNISSEUR.ANNEE_CMDFR = (Int32)myReader["ANNEE_CMDFR"];

                    myCOMMANDE_FOURNISSEUR.MOIS_CMDFR = (Int32)myReader["MOIS_CMDFR"];

                    myCOMMANDE_FOURNISSEUR.CODE_MAG = (Decimal)myReader["CODE_MAG"];

                    myCOMMANDE_FOURNISSEUR.ADRESSE_LIVRAISON = (String)myReader["ADRESSE_LIVRAISON"];

                    myCOMMANDE_FOURNISSEUR.CONTACT = (String)myReader["CONTACT"];

                    myCOMMANDE_FOURNISSEUR.TEL_CONTACT = (String)myReader["TEL_CONTACT"];

                    myCOMMANDE_FOURNISSEUR.REMARQUE = (String)myReader["REMARQUE"];


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myCOMMANDE_FOURNISSEUR;
        }

        [WebMethod]
        public DataTable GetCOMMANDE_FOURNISSEUR()
        {

            string reqSQL = "select * from V_CMD_FR";
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
        public DataTable GetDetailCOMMANDE_FOURNISSEUR(string numCmd)
        {

            string reqSQL = "select * from V_LG_CMD_FR where CODE_COMMANDE_FOURNISSEUR LIKE '" + numCmd + "'";
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
        public DataTable GetCOMMANDE_FOURNISSEUREnAttenteLivraisonParFournisseur(decimal codeFournisseur)
        {

            string reqSQL = "select Distinct(CODE_COMMANDE_FOURNISSEUR) from V_LIVRAISON_CMD_ACHAT where CODE_FOURNISSEUR='" + codeFournisseur + "' AND QTE>QTE_LIVREE";
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
        public DataTable GetDetailsCommandeFournisseurEnAttenteLivraison(string codeCommande)
        {

            string reqSQL = "select * from V_LIVRAISON_CMD_ACHAT where CODE_COMMANDE_FOURNISSEUR='" + codeCommande + "' AND QTE>QTE_LIVREE";
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
        #endregion

        #region FACTURE_FOURNISSEUR
        [WebMethod]
        public RESULT_QUERY ajouteFACTURE_FOURNISSEUR(DFACTURE_FOURNISSEUR myFACTURE_FOURNISSEUR, DataTable dtDetails)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "INSERT INTO FACTURE_FOURNISSEUR	(CODE_FACTURE_FOURNISSEUR, NUM_FACT_FR, DATE_FACTURE_FOURNISSEUR, CODE_FOURNISSEUR, USER_CREATION, DATE_CREATION, ANNULEE)VALUES	(@CODE_FACTURE_FOURNISSEUR, @NUM_FACT_FR, @DATE_FACTURE_FOURNISSEUR, @CODE_FOURNISSEUR, @USER_CREATION, @DATE_CREATION, @ANNULEE)";
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR = "";
                cmd.CommandText = "select isnull(prefix1_ff, '') from societe where code_societe ='1'";
                myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "select isnull(num_ff+1, 1) from societe where code_societe ='1'";
                myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR += numberToString(5, Convert.ToInt32(cmd.ExecuteScalar()));

                cmd.CommandText = "select isnull(prefix2_ff, '') from societe where code_societe ='1'";
                myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR += cmd.ExecuteScalar().ToString();

                cmd.CommandText = "update societe set num_ff=num_ff+1 where code_societe ='1'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = reqSQL;
                cmd.Parameters.Add("@CODE_FACTURE_FOURNISSEUR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;
                cmd.Parameters.Add("@NUM_FACT_FR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.NUM_FACT_FR;
                cmd.Parameters.Add("@DATE_FACTURE_FOURNISSEUR", SqlDbType.DateTime).Value = myFACTURE_FOURNISSEUR.DATE_FACTURE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = myFACTURE_FOURNISSEUR.CODE_FOURNISSEUR;
                cmd.Parameters.Add("@USER_CREATION", SqlDbType.Decimal).Value = myFACTURE_FOURNISSEUR.USER_CREATION;
                cmd.Parameters.Add("@DATE_CREATION", SqlDbType.DateTime).Value = myFACTURE_FOURNISSEUR.DATE_CREATION;
                cmd.Parameters.Add("@ANNULEE", SqlDbType.Bit).Value = myFACTURE_FOURNISSEUR.ANNULEE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO LG_FACT_FR(CODE_FACTURE_FOURNISSEUR, CODE_ARTICLE, QTE, UNITE, PRIX_HT, REMISE, FODEC, TAUX_TVA, CODE_BR_FR, CODE_CMD_FR) VALUES (@CODE_FACTURE_FOURNISSEUR, @CODE_ARTICLE, @QTE, @UNITE, @PRIX_HT, @REMISE, @FODEC, @TAUX_TVA, @CODE_BR_FR, @CODE_CMD_FR)";
                foreach (DataRow dr in dtDetails.Rows)
                {
                    cmd.Parameters.Add("@CODE_FACTURE_FOURNISSEUR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = (decimal)dr["QTE"];
                    cmd.Parameters.Add("@UNITE", SqlDbType.NVarChar).Value = dr["UNITE"].ToString();
                    cmd.Parameters.Add("@PRIX_HT", SqlDbType.Decimal).Value = (decimal)dr["PRIX_HT"];
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = (decimal)dr["REMISE"];
                    cmd.Parameters.Add("@FODEC", SqlDbType.Decimal).Value = (decimal)dr["FODEC"];
                    cmd.Parameters.Add("@TAUX_TVA", SqlDbType.Decimal).Value = (decimal)dr["TAUX_TVA"];
                    cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["CODE_BR_FR"];
                    cmd.Parameters.Add("@CODE_CMD_FR", SqlDbType.NVarChar).Value = dr["CODE_CMD_FR"].ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                trans.Commit();
                res.MESSAGE = "Facture enregistrée avec succès.";
                res.OK = true;
                res.CODE = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;

            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de la facture.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public void effaceFACTURE_FOURNISSEUR(DFACTURE_FOURNISSEUR myFACTURE_FOURNISSEUR)
        {

            string reqSQL = "DELETE FROM FACTURE_FOURNISSEUR WHERE (CODE_FACTURE_FOURNISSEUR='" + myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        [WebMethod]
        public RESULT_QUERY modifieFACTURE_FOURNISSEUR(DFACTURE_FOURNISSEUR myFACTURE_FOURNISSEUR, DataTable dtDetails)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "UPDATE FACTURE_FOURNISSEUR	set  NUM_FACT_FR=@NUM_FACT_FR, DATE_FACTURE_FOURNISSEUR=@DATE_FACTURE_FOURNISSEUR, CODE_FOURNISSEUR=@CODE_FOURNISSEUR, USER_MODIFICATION=@USER_MODIFICATION, DATE_MODIFICATION=@DATE_MODIFICATION, ANNULEE=@ANNULEE WHERE (CODE_FACTURE_FOURNISSEUR=@CODE_FACTURE_FOURNISSEUR)";
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {

                cmd.CommandText = reqSQL;
                cmd.Parameters.Add("@CODE_FACTURE_FOURNISSEUR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;
                cmd.Parameters.Add("@NUM_FACT_FR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.NUM_FACT_FR;
                cmd.Parameters.Add("@DATE_FACTURE_FOURNISSEUR", SqlDbType.DateTime).Value = myFACTURE_FOURNISSEUR.DATE_FACTURE_FOURNISSEUR;
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = myFACTURE_FOURNISSEUR.CODE_FOURNISSEUR;
                cmd.Parameters.Add("@USER_MODIFICATION", SqlDbType.Decimal).Value = myFACTURE_FOURNISSEUR.USER_MODIFICATION;
                cmd.Parameters.Add("@DATE_MODIFICATION", SqlDbType.DateTime).Value = myFACTURE_FOURNISSEUR.DATE_MODIFICATION;
                cmd.Parameters.Add("@ANNULEE", SqlDbType.Bit).Value = myFACTURE_FOURNISSEUR.ANNULEE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM LG_FACT_FR WHERE (CODE_FACTURE_FOURNISSEUR=@CODE_FACTURE_FOURNISSEUR)";
                cmd.Parameters.Add("@CODE_FACTURE_FOURNISSEUR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO LG_FACT_FR(CODE_FACTURE_FOURNISSEUR, CODE_ARTICLE, QTE, UNITE, PRIX_HT, REMISE, FODEC, TAUX_TVA, CODE_BR_FR, CODE_CMD_FR) VALUES (@CODE_FACTURE_FOURNISSEUR, @CODE_ARTICLE, @QTE, @UNITE, @PRIX_HT, @REMISE, @FODEC, @TAUX_TVA, @CODE_BR_FR, @CODE_CMD_FR)";
                foreach (DataRow dr in dtDetails.Rows)
                {
                    cmd.Parameters.Add("@CODE_FACTURE_FOURNISSEUR", SqlDbType.NVarChar).Value = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = (decimal)dr["QTE"];
                    cmd.Parameters.Add("@UNITE", SqlDbType.NVarChar).Value = dr["UNITE"].ToString();
                    cmd.Parameters.Add("@PRIX_HT", SqlDbType.Decimal).Value = (decimal)dr["PRIX_HT"];
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = (decimal)dr["REMISE"];
                    cmd.Parameters.Add("@FODEC", SqlDbType.Decimal).Value = (decimal)dr["FODEC"];
                    cmd.Parameters.Add("@TAUX_TVA", SqlDbType.Decimal).Value = (decimal)dr["TAUX_TVA"];
                    cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["CODE_BR_FR"];
                    cmd.Parameters.Add("@CODE_CMD_FR", SqlDbType.NVarChar).Value = dr["CODE_CMD_FR"].ToString();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                trans.Commit();
                res.MESSAGE = "Facture modifiée avec succès.";
                res.OK = true;
                res.CODE = myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR;

            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de la modification de la facture.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public DFACTURE_FOURNISSEUR obtenirInstanceFACTURE_FOURNISSEUR(DFACTURE_FOURNISSEUR myFACTURE_FOURNISSEUR)
        {
            string reqSQL = "SELECT CODE_FACTURE_FOURNISSEUR, NUM_FACT_FR, DATE_FACTURE_FOURNISSEUR, CODE_FOURNISSEUR, USER_CREATION, DATE_CREATION, USER_MODIFICATION, DATE_MODIFICATION, ANNULEE, USER_ANNULATION, DATE_ANNULATION		FROM FACTURE_FOURNISSEUR	WHERE (CODE_FACTURE_FOURNISSEUR='" + myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myFACTURE_FOURNISSEUR.CODE_FACTURE_FOURNISSEUR = (String)myReader["CODE_FACTURE_FOURNISSEUR"];

                    myFACTURE_FOURNISSEUR.NUM_FACT_FR = (String)myReader["NUM_FACT_FR"];

                    myFACTURE_FOURNISSEUR.DATE_FACTURE_FOURNISSEUR = Convert.ToDateTime(myReader["DATE_FACTURE_FOURNISSEUR"]);

                    myFACTURE_FOURNISSEUR.CODE_FOURNISSEUR = (Decimal)myReader["CODE_FOURNISSEUR"];

                    myFACTURE_FOURNISSEUR.USER_CREATION = (Decimal)myReader["USER_CREATION"];

                    myFACTURE_FOURNISSEUR.DATE_CREATION = Convert.ToDateTime(myReader["DATE_CREATION"]);

                    myFACTURE_FOURNISSEUR.USER_MODIFICATION = (Decimal)myReader["USER_MODIFICATION"];

                    myFACTURE_FOURNISSEUR.DATE_MODIFICATION = Convert.ToDateTime(myReader["DATE_MODIFICATION"]);

                    myFACTURE_FOURNISSEUR.ANNULEE = myReader["ANNULEE"].ToString() == "True" ? 1 : 0;

                    myFACTURE_FOURNISSEUR.USER_ANNULATION = (Decimal)myReader["USER_ANNULATION"];

                    myFACTURE_FOURNISSEUR.DATE_ANNULATION = Convert.ToDateTime(myReader["DATE_ANNULATION"]);


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myFACTURE_FOURNISSEUR;
        }

        [WebMethod]
        public DataTable GetFACTURE_FOURNISSEUR()
        {

            string reqSQL = "select * from V_FACTURE_FOURNISSEUR";
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
        public DataTable GetFACTURE_FOURNISSEUR_PAR_FOURNISSEUR(decimal codeFournisseur)
        {

            string reqSQL = "SELECT * FROM V_FACTURE_FOURNISSEUR WHERE (CODE_FOURNISSEUR='" + codeFournisseur + "')";
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
        public DataTable GetDetailsFACTURE_FOURNISSEUR(string codeFactFr)
        {

            string reqSQL = "select * from V_LG_FACT_FR WHERE CODE_FACTURE_FOURNISSEUR='" + codeFactFr + "'";
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
        public bool VerifierNumFactFr(string codeFacture, string numFactFr, decimal codeFournisseur)
        {
            bool valide = true;
            string reqSQL = "select * from V_FACTURE_FOURNISSEUR WHERE CODE_FACTURE_FOURNISSEUR<>'" + codeFacture + "' and NUM_FACT_FR='" + numFactFr + "' and code_fournisseur='" + codeFournisseur + "'";
            try
            {

                DataTable myResult = CnxBase.GetDataTable(reqSQL);
                if (myResult.Rows.Count > 0)
                    valide = false;
            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
            return valide;
        }
        #endregion

        #region CHM_MAGAZIN Membres
        [WebMethod]
        public DataTable LOAD_MAGAZIN(string CODE)
        {
            DataTable MAGAZIN_dt = new DataTable();
            try
            {
                SqlDataAdapter MAGAZIN_da = new SqlDataAdapter("SELECT CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE FROM MAGAZIN WHERE CODE_MAG= '" + CODE + "'", CnxBase.myConn);

                MAGAZIN_dt = CnxBase.GetDataTable(MAGAZIN_da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return MAGAZIN_dt;
        }

        [WebMethod]
        public DataTable SEARCH_MAGAZIN(string INDICE)
        {
            SqlDataAdapter MAGAZIN_da = new SqlDataAdapter("SELECT     CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE FROM MAGAZIN WHERE (NOM_MAG like '%" + INDICE + "%')", CnxBase.myConn);
            DataTable MAGAZIN_dt = new DataTable();
            MAGAZIN_dt = CnxBase.GetDataTable(MAGAZIN_da.SelectCommand.CommandText);
            return MAGAZIN_dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_MAGAZIN()
        {
            DataTable MAGAZIN_dt = new DataTable();
            try
            {
                using (SqlDataAdapter MAGAZIN_da = new SqlDataAdapter("SELECT CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE FROM MAGAZIN", CnxBase.myConn))
                {
                    MAGAZIN_dt = CnxBase.GetDataTable(MAGAZIN_da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return MAGAZIN_dt;
        }

        [WebMethod]
        public RESULT_QUERY DELETE_MAGAZIN(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {

                res.CODE = CODE;
                SqlCommand cmd = new SqlCommand("DELETE FROM MAGAZIN WHERE  (CODE_MAG= @CODE_MAG)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                res.MESSAGE = "Magasin supprimé avec succès.";

            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY INSERT_MAGAZIN(string CODE, string NOM, string ADRESSE, string TEL, string CODE_SOCIETE, string AGENCE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CnxBase.myConn.BeginTransaction();
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.Transaction = sqlTrans;

                try
                {
                    cmd.CommandText = "SELECT     ISNULL(MAX(CODE_MAG), 0) + 1  FROM         MAGAZIN";
                    CODE = ((decimal)cmd.ExecuteScalar()).ToString();

                    res.CODE = CODE;

                    //cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE (RS_SOCIETE LIKE '%" + AGENCE + "%')";
                    //string code_societe = ((decimal)cmd.ExecuteScalar()).ToString();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "INSERT INTO MAGAZIN (CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE) VALUES     (@CODE_MAG, @NOM_MAG, @ADRESSE_MAG, @TEL_MAG, @CODE_SOCIETE, @RS_SOCIETE)";
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = NOM;
                    cmd.Parameters.Add("@ADRESSE_MAG", SqlDbType.NVarChar).Value = ADRESSE;
                    cmd.Parameters.Add("@TEL_MAG", SqlDbType.NVarChar).Value = TEL;
                    cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = CODE_SOCIETE;
                    cmd.Parameters.Add("@RS_SOCIETE", SqlDbType.NVarChar).Value = AGENCE;
                    cmd.ExecuteNonQuery();
                    res.MESSAGE = "Les informations du magasins sont enregistrées avec succès.";
                    cmd.Parameters.Clear();

                    sqlTrans.Commit();
                }
                catch (Exception er)
                {
                    sqlTrans.Rollback();
                    res.OK = false;
                    res.MESSAGE = er.Message;
                }


            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY UPDATE_MAGAZIN(string CODE, string NOM, string ADRESSE, string TEL, string CODE_SOCIETE, string AGENCE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CnxBase.myConn.BeginTransaction();
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.Transaction = sqlTrans;
                try
                {
                    //cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE (RS_SOCIETE LIKE '%" + AGENCE + "%')";
                    //decimal code_societe = (decimal)cmd.ExecuteScalar();

                    res.CODE = CODE;
                    cmd.CommandText = "UPDATE    MAGAZIN SET               NOM_MAG =@NOM_MAG, ADRESSE_MAG =@ADRESSE_MAG, TEL_MAG=@TEL_MAG, CODE_SOCIETE=@CODE_SOCIETE, RS_SOCIETE=@RS_SOCIETE WHERE  (CODE_MAG=@CODE_MAG)";
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = NOM;
                    cmd.Parameters.Add("@ADRESSE_MAG", SqlDbType.NVarChar).Value = ADRESSE;
                    cmd.Parameters.Add("@TEL_MAG", SqlDbType.NVarChar).Value = TEL;
                    cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = CODE_SOCIETE;
                    cmd.Parameters.Add("@RS_SOCIETE", SqlDbType.NVarChar).Value = AGENCE;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    res.MESSAGE = "Magasin modifié avec succès.";


                    sqlTrans.Commit();
                }
                catch (Exception er)
                {
                    sqlTrans.Rollback();
                    res.OK = false;
                    res.MESSAGE = er.Message;
                }
            }

            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }


            return res;
        }




        public string NEW_CODE_MAGASIN(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region CHM_CATEGORIE_ARTICLE Membres
        [WebMethod]
        public RESULT_QUERY DELETE_CATEGORIE(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;
                SqlCommand cmd = new SqlCommand("DELETE FROM CATEGORIE WHERE  (CODE_CATEG= @CODE_CATEG)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;


                cmd.ExecuteNonQuery();
                res.MESSAGE = "Catégorie supprimée avec succès.";
            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY INSERT_CATEGORIE(string CODE, string LABEL, string DESC, decimal CODE_FAMILLE, string REF_CATEG)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqlTrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqlTrans;

            try
            {



                //cmd.CommandText = "SELECT     ISNULL(MAX(CODE_CATEG), 0) + 1  FROM         CATEGORIE";
                //CODE = ((decimal)cmd.ExecuteScalar()).ToString();

                //res.CODE = CODE;
                cmd.CommandText = "SELECT count(*) from categorie where ref_categ like @ref_categ and code_famille=@code_famille";
                cmd.Parameters.Add("@ref_categ", SqlDbType.NVarChar).Value = REF_CATEG;
                cmd.Parameters.Add("@code_famille", SqlDbType.Decimal).Value = CODE_FAMILLE;
                int c = (int)cmd.ExecuteScalar();
                if (c > 0)
                    throw new Exception("Réf. catégorie déja existant avec la famille sélectionnée.");
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO CATEGORIE ( LIB_CATEG, DESCRIPTION_CATEG,CODE_FAMILLE, REF_CATEG) VALUES     (@LIB_CATEG, @DESC_CATEG,@CODE_FAMILLE, @REF_CATEG)";

                cmd.Parameters.Add("@LIB_CATEG", SqlDbType.NVarChar).Value = LABEL;
                cmd.Parameters.Add("@DESC_CATEG", SqlDbType.NVarChar).Value = DESC;
                cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;
                cmd.Parameters.Add("@REF_CATEG", SqlDbType.NVarChar).Value = REF_CATEG;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT MAX(CODE_CATEG) FROM CATEGORIE";
                res.CODE = cmd.ExecuteScalar().ToString();

                sqlTrans.Commit();
                res.MESSAGE = "Catégorie enregistrée avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                sqlTrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }



            return res;


        }

        [WebMethod]
        public DataTable LOAD_CATEGORIE(string CODE)
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT * FROM CATEGORIE WHERE CODE_CATEG= '" + CODE + "'", CnxBase.myConn);

            DataTable CATEGORIE_dt = new DataTable();
            try
            {
                CATEGORIE_dt = CnxBase.GetDataTable(CATEGORIE_da.SelectCommand.CommandText);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CATEGORIE_dt;
        }

        [WebMethod]
        public DataTable SEARCH_CATEGORIE(string INDICE)
        {
            try
            {
                SqlDataAdapter CATEG_da = new SqlDataAdapter("SELECT     CODE_CATEG, LIB_CATEG, DESCRIPTION_CATEG FROM CATEGORIE WHERE (LIB_CATEG like '%" + INDICE + "%')", CnxBase.myConn);
                DataTable CATEG_dt = new DataTable();
                CATEG_dt = CnxBase.GetDataTable(CATEG_da.SelectCommand.CommandText);
                return CATEG_dt;
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        [WebMethod]
        public DataTable SELECT_ALL_CATEGORIE()
        {
            try
            {
                string reqSql = "SELECT        CATEGORIE.CODE_CATEG, CATEGORIE.LIB_CATEG, CATEGORIE.DESCRIPTION_CATEG, CATEGORIE.CODE_FAMILLE, FAMILLE.DESIGNATION_FAMILLE, FAMILLE.REF_FAMILLE , CATEGORIE.REF_CATEG";
                reqSql += " FROM            CATEGORIE INNER JOIN ";
                reqSql += "       FAMILLE ON CATEGORIE.CODE_FAMILLE = FAMILLE.CODE_FAMILLE ";
                SqlDataAdapter CATEGORIE_da = new SqlDataAdapter(reqSql, CnxBase.myConn);
                DataTable CATEGORIE_dt = new DataTable();
                CATEGORIE_dt = CnxBase.GetDataTable(CATEGORIE_da.SelectCommand.CommandText);
                return CATEGORIE_dt;
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        [WebMethod]
        public DataTable SELECT_LISTE_CATEGORIE()
        {
            try
            {
                string reqSql = "SELECT        CATEGORIE.CODE_CATEG, CATEGORIE.LIB_CATEG, CATEGORIE.DESCRIPTION_CATEG, CATEGORIE.CODE_FAMILLE, FAMILLE.DESIGNATION_FAMILLE, FAMILLE.REF_FAMILLE , CATEGORIE.REF_CATEG";
                reqSql += " FROM            CATEGORIE INNER JOIN ";
                reqSql += "       FAMILLE ON CATEGORIE.CODE_FAMILLE = FAMILLE.CODE_FAMILLE ";
                SqlDataAdapter CATEGORIE_da = new SqlDataAdapter(reqSql, CnxBase.myConn);
                DataTable CATEGORIE_dt = new DataTable();
                CATEGORIE_dt = CnxBase.GetDataTable(CATEGORIE_da.SelectCommand.CommandText);
                return CATEGORIE_dt;
            }
            catch (Exception er)
            {

                throw er;
            }

        }

        [WebMethod]
        public RESULT_QUERY UPDATE_CATEGORIE(string CODE, string LABEL, string DESC, decimal CODE_FAMILLE, string REF_CATEG)
        {

            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqlTrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqlTrans;
            try
            {


                res.CODE = CODE;
                cmd.CommandText = "UPDATE    CATEGORIE SET               LIB_CATEG =@LIB_CATEG, DESCRIPTION_CATEG =@DESCRIPTION_CATEG , CODE_FAMILLE=@CODE_FAMILLE, REF_CATEG=@REF_CATEG WHERE  (CODE_CATEG=@CODE_CATEG)";
                cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@LIB_CATEG", SqlDbType.NVarChar).Value = LABEL;
                cmd.Parameters.Add("@DESCRIPTION_CATEG", SqlDbType.NVarChar).Value = DESC;
                cmd.Parameters.Add("@CODE_FAMILLE", SqlDbType.Decimal).Value = CODE_FAMILLE;
                cmd.Parameters.Add("@REF_CATEG", SqlDbType.NVarChar).Value = REF_CATEG;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();



                sqlTrans.Commit();
                res.MESSAGE = "Catégorie modifiée avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                sqlTrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }


            return res;
        }

        public string NEW_CODE_CATEGORIE_ARTICLE(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        [WebMethod]
        public DataTable SELECT_CATEG_PRODUCTS(string param)
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT *, CODE_ARTICLE as code, DESIGNATION_ARTICLE as ref FROM ARTICLE WHERE (CODE_CATEG = '" + param + "')", CnxBase.myConn);
            //CATEGORIE_da.SelectCommand.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_dt = CnxBase.GetDataTable(CATEGORIE_da.SelectCommand.CommandText);
            return CATEGORIE_dt;
        }

        [WebMethod]
        public DataTable LOAD_SCHEMA_ARTICLE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ARTICLE", CnxBase.myConn))
                {
                    da.FillSchema(dt, SchemaType.Source);
                }

            }
            catch (Exception)
            {
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_ARTICLE_PAR_REF(string REF)
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT * FROM ARTICLE WHERE (DESIGNATION_ARTICLE LIKE '" + REF + "')", CnxBase.myConn);
            //CATEGORIE_da.SelectCommand.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_da.FillSchema(CATEGORIE_dt, SchemaType.Source);
            CATEGORIE_da.Fill(CATEGORIE_dt);
            return CATEGORIE_dt;
        }

        #endregion

        #region CHM_SOCIETE Membres
        [WebMethod]
        public RESULT_QUERY ENREGISTRER(string CODE, DataTable dtSociete)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSql = string.Empty;
            try
            {
                reqSql = "UPDATE    SOCIETE SET              RS_SOCIETE =@RS_SOCIETE, ADRESSE_SOCIETE =@ADRESSE_SOCIETE, DESCRIPTION_SOCIETE =@DESCRIPTION_SOCIETE , ";
                reqSql += " CP_SOCIETE =@CP_SOCIETE, TEL_SOCIETE =@TEL_SOCIETE , FAX_SOCIETE =@FAX_SOCIETE, EMAIL_SOCIETE =@EMAIL_SOCIETE,   ";
                reqSql += " SITE_WEB_SOCETE =@SITE_WEB_SOCETE , LOGO_SOCIETE =@LOGO_SOCIETE , CODE_TVA_SOCIETE =@CODE_TVA_SOCIETE, RIB_SOCIETE =@RIB_SOCIETE, ";
                reqSql += " PREFIX1_COMMANDE =@PREFIX1_COMMANDE, PREFIX2_COMMANDE =@PREFIX2_COMMANDE , NUM_COMMANDE =@NUM_COMMANDE, NUM_FACTURE =@NUM_FACTURE, ";
                reqSql += " PREFIX1_FACTURE =@PREFIX1_FACTURE, PREFIXE2_FACTURE =@PREFIXE2_FACTURE,NUM_B_LIV=@NUM_B_LIV,PREFIX1_B_LIV=@PREFIX1_B_LIV, ";
                reqSql += " PREFIX2_B_LIV=@PREFIX2_B_LIV, NUM_CF=@NUM_CF,PREFIX1_CF=@PREFIX1_CF,PREFIX2_CF=@PREFIX2_CF, ";
                reqSql += " NUM_BRETOUR_FR=@NUM_BRETOUR_FR, PREFIX1_BRET_FR=@PREFIX1_BRET_FR, PREFIX2_BRET_FR=@PREFIX2_BRET_FR ";
                reqSql += " , NUM_BRETOUR_CLIENT=@NUM_BRETOUR_CLIENT, PREFIX1_BRET_CLT=@PREFIX1_BRET_CLT, PREFIX2_BRET_CLT=@PREFIX2_BRET_CLT ";
                reqSql += " , NUM_BON_RECEPTION=@NUM_BON_RECEPTION, PREFIX1_BRECEP=@PREFIX1_BRECEP, PREFIX2_BRECEP=@PREFIX2_BRECEP ";
                reqSql += " , NUM_FI=@NUM_FI, PREFIX1_FI=@PREFIX1_FI, PREFIX2_FI=@PREFIX2_FI ";
                reqSql += " , NUM_DEVC=@NUM_DEVC, PREFIX1_DEVC=@PREFIX1_DEVC, PREFIX2_DEVC=@PREFIX2_DEVC ";
                reqSql += " , NUM_TC=@NUM_TC, PREFIX1_TC=@PREFIX1_TC, PREFIX2_TC=@PREFIX2_TC ";
                reqSql += " , TIMBRE=@TIMBRE ";
                reqSql += " WHERE (CODE_SOCIETE=1)";

                SqlCommand cmd = new SqlCommand(reqSql, CnxBase.myConn);
                cmd.Parameters.Add("@RS_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["RS_SOCIETE"];
                cmd.Parameters.Add("@DESCRIPTION_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["DESCRIPTION_SOCIETE"];
                cmd.Parameters.Add("@ADRESSE_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["ADRESSE_SOCIETE"];
                cmd.Parameters.Add("@CP_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["CP_SOCIETE"];
                cmd.Parameters.Add("@TEL_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["TEL_SOCIETE"];
                cmd.Parameters.Add("@FAX_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["FAX_SOCIETE"];
                cmd.Parameters.Add("@EMAIL_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["EMAIL_SOCIETE"];
                cmd.Parameters.Add("@SITE_WEB_SOCETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["SITE_WEB_SOCETE"];
                cmd.Parameters.Add("@LOGO_SOCIETE", SqlDbType.Image).Value = dtSociete.Rows[0]["LOGO_SOCIETE"];
                cmd.Parameters.Add("@CODE_TVA_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["CODE_TVA_SOCIETE"];
                cmd.Parameters.Add("@RIB_SOCIETE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["RIB_SOCIETE"];
                cmd.Parameters.Add("@NUM_COMMANDE", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_COMMANDE"];
                cmd.Parameters.Add("@PREFIX1_COMMANDE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_COMMANDE"];
                cmd.Parameters.Add("@PREFIX2_COMMANDE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_COMMANDE"];
                cmd.Parameters.Add("@NUM_FACTURE", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_FACTURE"];
                cmd.Parameters.Add("@PREFIX1_FACTURE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_FACTURE"];
                cmd.Parameters.Add("@PREFIXE2_FACTURE", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIXE2_FACTURE"];
                cmd.Parameters.Add("@NUM_B_LIV", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_B_LIV"];
                cmd.Parameters.Add("@PREFIX1_B_LIV", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_B_LIV"];
                cmd.Parameters.Add("@PREFIX2_B_LIV", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_B_LIV"];
                cmd.Parameters.Add("@NUM_CF", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_CF"];
                cmd.Parameters.Add("@PREFIX1_CF", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_CF"];
                cmd.Parameters.Add("@PREFIX2_CF", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_CF"];
                cmd.Parameters.Add("@NUM_BRETOUR_FR", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_BRETOUR_FR"];
                cmd.Parameters.Add("@PREFIX1_BRET_FR", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_BRET_FR"];
                cmd.Parameters.Add("@PREFIX2_BRET_FR", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_BRET_FR"];
                cmd.Parameters.Add("@NUM_BRETOUR_CLIENT", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_BRETOUR_CLIENT"];
                cmd.Parameters.Add("@PREFIX1_BRET_CLT", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_BRET_CLT"];
                cmd.Parameters.Add("@PREFIX2_BRET_CLT", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_BRET_CLT"];
                cmd.Parameters.Add("@NUM_BON_RECEPTION", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_BON_RECEPTION"];
                cmd.Parameters.Add("@PREFIX1_BRECEP", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_BRECEP"];
                cmd.Parameters.Add("@PREFIX2_BRECEP", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_BRECEP"];
                cmd.Parameters.Add("@NUM_FI", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_FI"];
                cmd.Parameters.Add("@PREFIX1_FI", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_FI"];
                cmd.Parameters.Add("@PREFIX2_FI", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_FI"];
                cmd.Parameters.Add("@NUM_DEVC", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_DEVC"];
                cmd.Parameters.Add("@PREFIX1_DEVC", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_DEVC"];
                cmd.Parameters.Add("@PREFIX2_DEVC", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_DEVC"];
                cmd.Parameters.Add("@NUM_TC", SqlDbType.Decimal).Value = dtSociete.Rows[0]["NUM_TC"];
                cmd.Parameters.Add("@PREFIX1_TC", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX1_TC"];
                cmd.Parameters.Add("@PREFIX2_TC", SqlDbType.NVarChar).Value = dtSociete.Rows[0]["PREFIX2_TC"];
                cmd.Parameters.Add("@TIMBRE", SqlDbType.Decimal).Value = dtSociete.Rows[0]["TIMBRE"];
                cmd.ExecuteNonQuery();
                res.MESSAGE = "Informations enregistrées avec succès.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public DataTable LOAD_CONFIG_SOCIETE()
        {
            DataTable dt = new DataTable();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     COUNT(CODE_SOCIETE)   FROM         SOCIETE";
                int c = (int)cmd.ExecuteScalar();
                if (c == 0)
                {
                    cmd.CommandText = "INSERT INTO SOCIETE                      (CODE_SOCIETE,RS_SOCIETE, NUM_COMMANDE, NUM_FACTURE, NUM_B_LIV, NUM_CF) VALUES     (1,'',0,0,0,0)";
                    cmd.ExecuteNonQuery();
                }
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.CommandText = "SELECT * FROM SOCIETE";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                sqltrans.Commit();

            }
            catch (Exception er)
            {
                sqltrans.Rollback();
            }
            return dt;
        }


        [WebMethod]
        public DataTable SELECT_ALL_SOCIETE()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SOCIETE", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }


        [WebMethod]
        public string GetParamValue(string paramName, decimal codeSociete)
        {
            string value = string.Empty;
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            cmd.CommandText = string.Format("SELECT {0} FROM SOCIETE WHERE CODE_SOCIETE={1}", paramName, codeSociete);
            try
            {
                value = cmd.ExecuteScalar().ToString();
                trans.Commit();
            }
            catch (Exception er)
            {
                throw er;
            }
            return value;
        }



        [WebMethod]
        public DataTable VIEW_SOCIETE(string CODE_SOCIETE)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SOCIETE WHERE CODE_SOCIETE='" + CODE_SOCIETE + "'", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        #endregion

        #region CHM_UTILISATEUR Membres
        [WebMethod]
        public RESULT_QUERY DELETE_UTILISATEUR(string CODE_USER)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM UTILISATEUR WHERE CODE_USER=@CODE_USER", CnxBase.myConn);
                cmd.Parameters.Add("CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
                cmd.ExecuteNonQuery();
                res.MESSAGE = "Utilisater supprimé avec succès.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULTAT_UTILISATEUR IDENTIFIER(string LOGIN_USER, string PASSWORD_USER)
        {
            RESULTAT_UTILISATEUR res = new RESULTAT_UTILISATEUR();

            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT COUNT(CODE_USER) FROM UTILISATEUR WHERE LOGIN_USER = @LOGIN_USER AND PASSWORD_USER = @PASSWORD_USER";
                cmd.Parameters.Add("@LOGIN_USER", SqlDbType.NVarChar).Value = LOGIN_USER;
                cmd.Parameters.Add("@PASSWORD_USER", SqlDbType.NVarChar).Value = PASSWORD_USER;
                int c = (int)cmd.ExecuteScalar();
                cmd.Parameters.Clear();

                if (c == 0)
                {
                    res.IDENTIFIER = false;
                    res.MESSAGE = "Utilisateur non identifié.";
                }
                else
                {
                    res.IDENTIFIER = true;


                    cmd.CommandText = "SELECT     * FROM PRIVILEGE_UTILISATEUR WHERE CODE_PRIVILEGE=(SELECT CODE_PRIVILEGE FROM FONCTION_UTILISATEUR WHERE CODE_FONCTION_USER=(SELECT CODE_FONCTION_USER FROM UTILISATEUR WHERE LOGIN_USER = @LOGIN_USER AND PASSWORD_USER = @PASSWORD_USER))";
                    cmd.Parameters.Add("@LOGIN_USER", SqlDbType.NVarChar).Value = LOGIN_USER;
                    cmd.Parameters.Add("@PASSWORD_USER", SqlDbType.NVarChar).Value = PASSWORD_USER;
                    SqlDataReader dr = cmd.ExecuteReader();
                    cmd.Parameters.Clear();

                    if (dr.HasRows)
                    {
                        dr.Read();
                        res.FONCTION = Convert.ToString(dr["CODE_PRIVILEGE"]);
                        res.COMMANDE_CLIENT = Convert.ToBoolean(dr["COMMANDE_CLIENT_PRIV"]);
                        res.COMMANDE_FOURNISSEUR = Convert.ToBoolean(dr["COMMANDE_FOURN_PRIV"]);
                        res.FACTURE_CLIENT = Convert.ToBoolean(dr["FACTURE_CLIENT_PRIV"]);
                        res.FACTURE_FOURNISSEUR = Convert.ToBoolean(dr["FACTURE_FOURN_PRIV"]);
                        res.COMPTE_USER = Convert.ToBoolean(dr["COMPTE_USER_PRIV"]);
                        res.AJOUT_STOCK = Convert.ToBoolean(dr["AJOUT_STOCK_PRIV"]);
                        res.CONSULT_STOCK = Convert.ToBoolean(dr["CONSULT_STOCK_PRIV"]);
                    }
                    dr.Close();
                }
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                res.IDENTIFIER = false;
                res.MESSAGE = er.Message;

                sqltrans.Rollback();
            }

            return res;

        }

        [WebMethod]
        public RESULT_QUERY INSERT_UTILISATEUR(string CODE_USER, string NOM_USER, string PRENOM_USER, byte[] PHOTO_USER, string LOGIN_USER, string PASSWORD_USER, bool ETAT_USER, string SOCIETE, string FONCTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {

                cmd.CommandText = "SELECT ISNULL( MAX(CODE_USER), 0) + 1 FROM UTILISATEUR";
                CODE_USER = ((decimal)cmd.ExecuteScalar()).ToString();
                res.CODE = CODE_USER;

                cmd.CommandText = "INSERT INTO UTILISATEUR                      (CODE_USER, NOM_USER, PRENOM_USER, PHOTO_USER, LOGIN_USER, PASSWORD_USER, ETAT_USER, CODE_SOCIETE, CODE_FONCTION_USER) VALUES     (@CODE_USER, @NOM_USER, @PRENOM_USER, @PHOTO_USER, @LOGIN_USER, @PASSWORD_USER, @ETAT_USER, @CODE_SOCIETE, @CODE_FONCTION_USER) ";

                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
                cmd.Parameters.Add("@NOM_USER", SqlDbType.NVarChar).Value = NOM_USER;
                cmd.Parameters.Add("@PRENOM_USER", SqlDbType.NVarChar).Value = PRENOM_USER;
                cmd.Parameters.Add("@PHOTO_USER", SqlDbType.Image).Value = (PHOTO_USER != null) ? PHOTO_USER : (object)DBNull.Value;
                cmd.Parameters.Add("@LOGIN_USER", SqlDbType.NVarChar).Value = LOGIN_USER;
                cmd.Parameters.Add("@PASSWORD_USER", SqlDbType.NVarChar).Value = PASSWORD_USER;
                cmd.Parameters.Add("@ETAT_USER", SqlDbType.Bit).Value = ETAT_USER;
                cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = SOCIETE;
                cmd.Parameters.Add("@CODE_FONCTION_USER", SqlDbType.Decimal).Value = FONCTION;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                sqltrans.Commit();

                res.MESSAGE = "Utilisateur enregistré avec succès.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
                sqltrans.Rollback();
            }
            return res;
        }

        [WebMethod]
        public DataTable LOAD_UTILISATEUR(string CODE_USER)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UTILISATEUR WHERE (CODE_USER = '" + CODE_USER + "')", CnxBase.myConn);

            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(cmd.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable RECHERCHE_UTILISATEUR(string param)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UTILISATEUR WHERE (NOM_USER LIKE '%" + param + "%') OR (PRENOM_USER LIKE '%" + param + "%') OR (LOGIN_USER LIKE '%" + param + "%')", CnxBase.myConn);

            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(cmd.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_UTILISATEUR()
        {
            string reqSql = "SELECT        UTILISATEUR.CODE_USER, UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER, UTILISATEUR.PHOTO_USER, UTILISATEUR.LOGIN_USER, UTILISATEUR.PASSWORD_USER, UTILISATEUR.ETAT_USER, ";
            reqSql += " UTILISATEUR.CODE_SOCIETE, UTILISATEUR.CODE_FONCTION_USER, FONCTION_UTILISATEUR.LIB_FONCTION_USER, SOCIETE.RS_SOCIETE ";
            reqSql += " FROM            UTILISATEUR INNER JOIN ";
            reqSql += "   SOCIETE ON UTILISATEUR.CODE_SOCIETE = SOCIETE.CODE_SOCIETE INNER JOIN ";
            reqSql += "    FONCTION_UTILISATEUR ON UTILISATEUR.CODE_FONCTION_USER = FONCTION_UTILISATEUR.CODE_FONCTION_USER WHERE CODE_USER <>'1' ";
            try
            {
                SqlDataAdapter cmd = new SqlDataAdapter(reqSql, CnxBase.myConn);

                DataTable dt = new DataTable();
                dt = CnxBase.GetDataTable(cmd.SelectCommand.CommandText);
                return dt;
            }
            catch (Exception er)
            {

                throw er;
            }


        }

        [WebMethod]
        public DataTable SELECT_ALL_NOM_UTILISATEUR()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT CODE_USER, PRENOM_USER+' '+NOM_USER AS NOM_UTILISATEUR FROM UTILISATEUR ", CnxBase.myConn);

            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(cmd.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public RESULT_QUERY UPDATE_UTILISATEUR(string CODE_USER, string NOM_USER, string PRENOM_USER, byte[] PHOTO_USER, string LOGIN_USER, string PASSWORD_USER, bool ETAT_USER, string SOCIETE, string FONCTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {



                cmd.CommandText = "UPDATE    UTILISATEUR SET NOM_USER = @NOM_USER, PRENOM_USER = @PRENOM_USER, PHOTO_USER=@PHOTO_USER, LOGIN_USER = @LOGIN_USER, PASSWORD_USER = @PASSWORD_USER, ETAT_USER = @ETAT_USER , CODE_SOCIETE = @CODE_SOCIETE, CODE_FONCTION_USER =@CODE_FONCTION_USER WHERE (CODE_USER= @CODE_USER)";

                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
                cmd.Parameters.Add("@NOM_USER", SqlDbType.NVarChar).Value = NOM_USER;
                cmd.Parameters.Add("@PRENOM_USER", SqlDbType.NVarChar).Value = PRENOM_USER;
                cmd.Parameters.Add("@PHOTO_USER", SqlDbType.Image).Value = (PHOTO_USER != null) ? PHOTO_USER : (object)DBNull.Value;
                cmd.Parameters.Add("@LOGIN_USER", SqlDbType.NVarChar).Value = LOGIN_USER;
                cmd.Parameters.Add("@PASSWORD_USER", SqlDbType.NVarChar).Value = PASSWORD_USER;
                cmd.Parameters.Add("@ETAT_USER", SqlDbType.Bit).Value = ETAT_USER;
                cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = SOCIETE;
                cmd.Parameters.Add("@CODE_FONCTION_USER", SqlDbType.Decimal).Value = FONCTION;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                sqltrans.Commit();

                res.MESSAGE = "Utilisateur modifié avec succès.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
                sqltrans.Rollback();
            }
            return res;
        }



        [WebMethod]
        public DataTable SELECT_FONCTION()
        {
            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter("SELECT CODE_FONCTION_USER,LIB_FONCTION_USER FROM FONCTION_UTILISATEUR where CODE_FONCTION_USER <> '1'", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;

        }



        [WebMethod]
        public DataTable SELECT_B_LIV(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_USER='" + CODE_USER + "'", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_COMMANDE(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_USER='" + CODE_USER + "'", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_FACTURE(string CODE_USER)
        {
            DataTable dt = new DataTable();
            try
            {
                string reqsql = "SELECT        FACTURE.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.CODE_CLIENT, FACTURE.MONTANT_HT_FACTURE, FACTURE.MONTANT_TVA, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE, ";
                reqsql += " FACTURE.MONTANT_BASE, FACTURE.TIMBRE_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_LETTRE, FACTURE.ANNULATION_FACTURE, FACTURE.REGLER, FACTURE.CREDIT,  ";
                reqsql += "  FACTURE.MAGASIN, FACTURE.CODE_USER, FACTURE.PRENOM_USER, FACTURE.NOM_USER, FACTURE.REMARQUE, FACTURE.REMISE, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT,  ";
                reqsql += " UTILISATEUR.PRENOM_USER + ' ' + UTILISATEUR.NOM_USER AS NOM_UTILISATEUR ";
                reqsql += " FROM            FACTURE INNER JOIN ";
                reqsql += "     CLIENT ON FACTURE.CODE_CLIENT = CLIENT.CODE_CLIENT INNER JOIN ";
                reqsql += "   UTILISATEUR ON FACTURE.CODE_USER = UTILISATEUR.CODE_USER";
                reqsql += "WHERE CODE_USER='" + CODE_USER + "'";
                SqlDataAdapter da = new SqlDataAdapter(reqsql, CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {

                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_REGLEMENT(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_USER='" + CODE_USER + "'", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        #endregion

        #region CHM_STOCK Membres

        public RESULT_QUERY ADD_ARTICLE_EN_STOCK()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        [WebMethod]
        public DataTable SEARCH_ARTICLE_STOCK(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     stock.CODE_MAG, magazin.NOM_MAG, stock.CODE_ARTICLE, article.REF_ARTICLE, article.DESIGNATION_ARTICLE, stock.QTTE_STOCK FROM         STOCK inner join article on stock.code_article=article.code_article inner join magazin on stock.code_mag=magazin.code_mag WHERE (DESIGNATION_ARTICLE LIKE '" + param + "')", CnxBase.myConn);
            DataTable dt = new DataTable();
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_ARTICLE_EN_STOCK()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT        STOCK.CODE_MAG, STOCK.CODE_ARTICLE, STOCK.QTTE_STOCK, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE,                          ARTICLE.DESCRIPTION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE, ARTICLE.QTE_MIN_ARTICLE, ARTICLE.PHOTO_ARTICLE, ARTICLE.UNITE_QTE_ARTICLE,                          ARTICLE.PRIX_HT_A_ARTICLE, ARTICLE.PRIX_HT_V_ARTICLE, ARTICLE.MAX_REMISE, ARTICLE.PRIX_SOLDE, ARTICLE.CODE_BARRE_ARTICLE_SOLDE,                          MAGAZIN.NOM_MAG, MAGAZIN.ADRESSE_MAG, MAGAZIN.TEL_MAG, MAGAZIN.CODE_SOCIETE FROM            ARTICLE INNER JOIN                          MAGAZIN ON ARTICLE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                          STOCK ON ARTICLE.CODE_ARTICLE = STOCK.CODE_ARTICLE AND MAGAZIN.CODE_MAG = STOCK.CODE_MAG WHERE ARTICLE.ETAT_ARTICLE='false'", CnxBase.myConn);
            DataTable dt = new DataTable();
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN(decimal CODE_MAG)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT        STOCK.CODE_MAG, STOCK.CODE_ARTICLE, STOCK.QTTE_STOCK, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, ARTICLE.DESCRIPTION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE,  ARTICLE.QTE_MIN_ARTICLE, ARTICLE.PHOTO_ARTICLE, ARTICLE.UNITE_QTE_ARTICLE, ARTICLE.PRIX_HT_A_ARTICLE,   ARTICLE.PRIX_HT_V_ARTICLE, ARTICLE.MAX_REMISE, ARTICLE.PRIX_SOLDE, ARTICLE.CODE_BARRE_ARTICLE_SOLDE,    MAGAZIN.NOM_MAG, MAGAZIN.ADRESSE_MAG, MAGAZIN.TEL_MAG, MAGAZIN.CODE_SOCIETE     FROM            ARTICLE     INNER JOIN STOCK ON ARTICLE.CODE_ARTICLE = STOCK.CODE_ARTICLE     inner join MAGAZIN on MAGAZIN.CODE_MAG = STOCK.CODE_MAG     WHERE ARTICLE.ETAT_ARTICLE='false'  AND STOCK.CODE_MAG='" + CODE_MAG + "'", CnxBase.myConn);
            DataTable dt = new DataTable();
            //da.FillSchema(dt, SchemaType.Source);
            //da.Fill(dt);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            return dt;
        }



        public DataTable SELECT_ARTICLE_EN_RUPTURE_DE_STOCK()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region CHM_REGLEMENT Membres
        [WebMethod]
        public RESULT_QUERY INSERT_REGLEMENT(string CODE_FACTURE, DateTime DATE_REG_CLT, string MODE_REGLEMENT_CLIENT, decimal MONTANT_REGLEMENT_CLIENT, string NUM_PIECE_CLIENT, string BANQUE_CLIENT, string OBSERVATION, string CODE_CLIENT, string CODE_COMPTE_CLIENT)
        {
            string etat = "";
            decimal reste;
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT CODE_COMPTE_CLIENT FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                decimal CODE_COMPTE = (decimal)cmd.ExecuteScalar();
                cmd.Parameters.Clear();

                //cmd.CommandText = "SELECT ISNULL(MAX(CODE_REGLEMENT_CLIENT), 0) + 1 FROM REGLEMENT_CLIENT";
                //decimal code_reg = (decimal)cmd.ExecuteScalar();
                //res.CODE = code_reg.ToString();

                cmd.CommandText = "INSERT INTO REGLEMENT_CLIENT (  CODE_FACTURE, DATE_REG_CLT, MODE_REGLEMENT_CLT, MONTANT_REG_CLIENT, MONTANT_PIECE, NUM_PIECE_CLIENT, BANQUE_CLIENT, OBSERVATION, CODE_COMPTE_CLIENT) VALUES (  @CODE_FACTURE, @DATE_REG_CLT, @MODE_REGLEMENT_CLIENT, @MONTANT_REG_CLIENT, @MONTANT_PIECE, @NUM_PIECE_CLIENT, @BANQUE_CLIENT, @OBSERVATION, @CODE_COMPTE_CLIENT)";
                //cmd.Parameters.Add("@CODE_REGLEMENT_CLIENT", SqlDbType.Decimal).Value = code_reg;
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                cmd.Parameters.Add("@DATE_REG_CLT", SqlDbType.DateTime).Value = DATE_REG_CLT;
                cmd.Parameters.Add("@MODE_REGLEMENT_CLIENT", SqlDbType.NVarChar).Value = MODE_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@MONTANT_REG_CLIENT", SqlDbType.Decimal).Value = MONTANT_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@MONTANT_PIECE", SqlDbType.Decimal).Value = MONTANT_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@BANQUE_CLIENT", SqlDbType.NVarChar).Value = BANQUE_CLIENT;
                cmd.Parameters.Add("@NUM_PIECE_CLIENT", SqlDbType.NVarChar).Value = NUM_PIECE_CLIENT;
                cmd.Parameters.Add("@OBSERVATION", SqlDbType.NVarChar).Value = OBSERVATION;
                cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT ISNULL(MAX(CODE_REGLEMENT_CLIENT), 1)  FROM REGLEMENT_CLIENT";
                decimal code_reg = (decimal)cmd.ExecuteScalar();
                res.CODE = code_reg.ToString();


                cmd.CommandText = "SELECT CREDIT FROM FACTURE WHERE CODE_FACTURE=@CODE_FACTURE";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                decimal CREDIT = (decimal)cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                if (MONTANT_REGLEMENT_CLIENT < CREDIT)
                {
                    etat = "Partiellement reglée";
                    reste = CREDIT - MONTANT_REGLEMENT_CLIENT;
                    res.CODE = reste.ToString();
                    res.MESSAGE = "Réglement enregistré avec succès : il reste" + reste.ToString();
                }
                if (MONTANT_REGLEMENT_CLIENT >= CREDIT)
                {
                    etat = "Reglée";
                    reste = MONTANT_REGLEMENT_CLIENT - CREDIT;
                    res.CODE = reste.ToString();
                    res.MESSAGE = "La facture est payée, le reste est :\n" + reste.ToString();
                }

                cmd.CommandText = "UPDATE FACTURE SET REGLER=@REGLER, CREDIT=CREDIT-@MONTANT_PAYE WHERE (CODE_FACTURE=@CODE_FACTURE)";
                cmd.Parameters.Add("@REGLER", SqlDbType.NVarChar).Value = etat;
                cmd.Parameters.Add("@MONTANT_PAYE", SqlDbType.Decimal).Value = MONTANT_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "UPDATE COMPTE_CLIENT SET TOTAL_CREDIT_CLT=TOTAL_CREDIT_CLT-@TOTAL_CREDIT_CLT, TOTAL_PAYE_CLT=TOTAL_PAYE_CLT+@TOTAL_PAYE_CLT) WHERE (CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT)";
                cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                cmd.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = MONTANT_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@TOTAL_PAYE_CLT", SqlDbType.Decimal).Value = MONTANT_REGLEMENT_CLIENT;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Réglement enregistré avec succès.";


            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        [WebMethod]
        public DataTable SELECT_ALL_REGLEMENT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM V_REG_CLIENT", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }


        [WebMethod]
        public DataTable SELECT_REGLEMENT_CLIENT(string CODE_COMPTE_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM V_REG_CLIENT WHERE CODE_COMPTE_CLIENT='" + CODE_COMPTE_CLIENT + "'", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }




        [WebMethod]
        public DataTable recherche_facture(string param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_FACTURE='" + param + "'", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }



        [WebMethod]
        public DataTable recherche_reglement_par_date(string param, string CODE_COMPTE_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE (DATE_REG_CLT LIKE '%" + param + "%') AND (CODE_COMPTE_CLIENT='" + CODE_COMPTE_CLIENT + "')", CnxBase.myConn);

                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }



        [WebMethod]
        public DataTable recherche_reg_par_date(string param)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE (DATE_REG_CLT LIKE '%" + param + "%') ", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        #endregion

        #region CHM_BON_RECEPTION_FOURNISSEUR Membres

        [WebMethod]
        public RESULT_QUERY DELETE_BR_FR(decimal CODE_BRECEP)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("SELECT [CODE_BRECEP]      ,[CODE_BR_FR]      ,[CODE_ARTICLE]      ,[QTE_LG_BR_FR]      ,[PRIX_ART_BR_FR]  FROM [LG_BR_FR] WHERE [CODE_BRECEP]='" + CODE_BRECEP + "'", CnxBase.myConn);
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

            DataTable dt_br = new DataTable();
            SqlDataAdapter da_br = new SqlDataAdapter();
            da_br = new SqlDataAdapter("SELECT * FROM [BON_RECEP_FOURNISSEUR] WHERE [CODE_BRECEP]='" + CODE_BRECEP + "'", CnxBase.myConn);
            dt_br = CnxBase.GetDataTable(da_br.SelectCommand.CommandText);
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                //Traçabilité
                cmd.CommandText = "INSERT INTO [TRACE_BON_RECEP_FOURNISSEUR] ([CODE_BRECEP],[CODE_BR_FR],[CODE_FOURNISSEUR],[DATE_BR_FR],[CODE_USER] ,[MNT_BR_FR],[CODE_MAG],[RESTE],[REMISE],[DATE_MODIFICATION],[TYPE_TRACE]) SELECT BON_RECEP_FOURNISSEUR.[CODE_BRECEP]      ,BON_RECEP_FOURNISSEUR.[CODE_BR_FR]      ,BON_RECEP_FOURNISSEUR.[CODE_FOURNISSEUR]      ,BON_RECEP_FOURNISSEUR.[DATE_BR_FR]      ,BON_RECEP_FOURNISSEUR.[CODE_USER]      ,BON_RECEP_FOURNISSEUR.[MNT_BR_FR]      ,BON_RECEP_FOURNISSEUR.[CODE_MAG]      ,BON_RECEP_FOURNISSEUR.[RESTE]      ,BON_RECEP_FOURNISSEUR.[REMISE], GETDATE(),'S'  FROM [BON_RECEP_FOURNISSEUR] WHERE [CODE_BRECEP]=@CODE_BRECEP";
                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP;
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                cmd.CommandText = " SELECT MAX([TRACE_BON_RECEP_FOURNISSEUR].[ORDRE]) FROM [TRACE_BON_RECEP_FOURNISSEUR]";
                decimal ordre = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "INSERT INTO [TRACE_LG_BR_FR]           ([ORDRE]           ,[CODE_BRECEP]           ,[CODE_BR_FR]           ,[CODE_ARTICLE]           ,[QTE_LG_BR_FR]           ,[PRIX_ART_BR_FR])     SELECT '" + ordre + "', LG_BR_FR.[CODE_BRECEP]      ,LG_BR_FR.[CODE_BR_FR]      ,LG_BR_FR.[CODE_ARTICLE]      ,LG_BR_FR.[QTE_LG_BR_FR]      ,LG_BR_FR.[PRIX_ART_BR_FR]  FROM [LG_BR_FR] WHERE [CODE_BRECEP]=@CODE_BRECEP";
                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP;
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                //Suppression

                cmd.CommandText = "DELETE FROM [BON_RECEP_FOURNISSEUR]   WHERE [CODE_BRECEP]=@CODE_BRECEP";
                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP;
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK- @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = (decimal)dt_br.Rows[0]["CODE_MAG"]; res.MESSAGE = "14";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                    cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "SELECT isnull(MAX(PRIX_ART_BR_FR),0) FROM LG_BR_FR WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_BRECEP<>@CODE_BRECEP";
                    cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                    decimal prix_max = (decimal)cmd.ExecuteScalar();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE- @QTTE_STOCK, ETAT_ARTICLE='false', PRIX_HT_A_ARTICLE=@PRIX_HT_A_ARTICLE WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                    cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in modifying product's quantity " + dr["CODE_ARTICLE"].ToString();
                    cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = prix_max; res.MESSAGE = "17";


                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                cmd.CommandText = "DELETE FROM [LG_BR_FR]     WHERE [LG_BR_FR].[CODE_BRECEP]=@CODE_BRECEP";
                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP;
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                sqltrans.Commit();
                res.OK = true;
                res.CODE = CODE_BRECEP.ToString();
                res.MESSAGE = "Bon Reception supprimé avec succès.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY INSERT_BR_FR(string CODE_BR_FR, decimal CODE_FOURNISSEUR, decimal CODE_MAG, DateTime DATE_BR_FR, decimal CODE_USER, decimal MNT_BR, decimal REMISE, DataTable dt_lg_br)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * , TVA.TAUX_TVA AS TVA_VENTE from stock inner join article on article.code_article=stock.code_article inner join TVA on article.CODE_TVA=TVA.CODE_TVA where stock.code_mag='" + CODE_MAG + "'", CnxBase.myConn);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            DataTable article = new DataTable();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;

            try
            {
                foreach (DataRow dr in dt_lg_br.Rows)
                {
                    dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";
                    cmd.CommandText = "INSERT INTO STOCK  (CODE_MAG, CODE_ARTICLE, QTTE_STOCK) VALUES (@CODE_MAG,@CODE_ARTICLE,@QTTE_STOCK)";
                    if (article.Rows.Count == 0)
                    {

                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "11";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "12";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = 0; res.MESSAGE = "13";
                        cmd.ExecuteNonQuery(); res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                        cmd.Parameters.Clear();
                    }
                }

                cmd.CommandText = "select * , TVA.TAUX_TVA AS TVA_VENTE from stock inner join article on article.code_article=stock.code_article inner join TVA on article.CODE_TVA=TVA.CODE_TVA where stock.code_mag='" + CODE_MAG + "'";
                da.SelectCommand = cmd;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                sqltrans.Commit();
            }
            catch (Exception ex)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = "Stock incohérant";
                return res;
            }
            sqltrans = CnxBase.myConn.BeginTransaction();
            cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;

            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_BON_RECEPTION) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_BRECEP = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "SELECT PREFIX1_BRECEP FROM SOCIETE WHERE CODE_SOCIETE=1";
                string CODE_BRECEP = string.Format("{0}{1}", cmd.ExecuteScalar().ToString(), NUM_BRECEP);

                cmd.CommandText = "SELECT PREFIX2_BRECEP FROM SOCIETE WHERE CODE_SOCIETE=1";
                CODE_BRECEP += cmd.ExecuteScalar().ToString();

                cmd.CommandText = "INSERT INTO BON_RECEP_FOURNISSEUR (CODE_BRECEP,CODE_BR_FR, CODE_FOURNISSEUR, DATE_BR_FR, CODE_USER, CODE_MAG, MNT_BR_FR, RESTE, REMISE)  VALUES        (@CODE_BRECEP,@CODE_BR_FR,@CODE_FOURNISSEUR,@DATE_BR_FR,@CODE_USER,@CODE_MAG,@MNT_BR_FR,@RESTE, @REMISE)"; res.MESSAGE = "request error";

                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.NVarChar).Value = CODE_BRECEP; res.MESSAGE = "1";
                cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_BR_FR", SqlDbType.DateTime).Value = DATE_BR_FR; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE_FOURNISSEUR; res.MESSAGE = "3";
                cmd.Parameters.Add("@MNT_BR_FR", SqlDbType.Decimal).Value = MNT_BR; res.MESSAGE = "4";
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "5";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "6";
                cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = REMISE;
                cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = (decimal)(MNT_BR * (1 - REMISE / 100));

                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                decimal prix_achat = 0;
                foreach (DataRow dr in dt_lg_br.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_BR_FR (CODE_BRECEP,CODE_BR_FR, CODE_ARTICLE, QTE_LG_BR_FR, UNITE, PRIX_ART_BR_FR, TVA, REMISE, FODEC, CODE_CMD_FR, CODE_FACT_FR) VALUES (@CODE_BRECEP,@CODE_BR_FR, @CODE_ARTICLE, @QTE_LG_BR_FR, @UNITE, @PRIX_ART_BR_FR, @TVA, @REMISE, @FODEC, @CODE_CMD_FR, @CODE_FACT_FR)";
                    cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.NVarChar).Value = NUM_BRECEP; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                    cmd.Parameters.Add("@QTE_LG_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "9";
                    cmd.Parameters.Add("@PRIX_ART_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"]; res.MESSAGE = "9";
                    cmd.Parameters.Add("@UNITE", SqlDbType.NVarChar).Value = dr["UNITE"].ToString(); res.MESSAGE = "10";
                    cmd.Parameters.Add("@TVA", SqlDbType.Decimal).Value = (decimal)dr["TVA"]; res.MESSAGE = "11";
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = (decimal)dr["REMISE"]; res.MESSAGE = "12";
                    cmd.Parameters.Add("@FODEC", SqlDbType.Decimal).Value = (decimal)dr["FODEC"]; res.MESSAGE = "13";
                    cmd.Parameters.Add("@CODE_CMD_FR", SqlDbType.NVarChar).Value = dr["CODE_CMD_FR"].ToString(); res.MESSAGE = "14";
                    cmd.Parameters.Add("@CODE_FACT_FR", SqlDbType.NVarChar).Value = dr["CODE_FACT_FR"].ToString(); res.MESSAGE = "15";
                    cmd.ExecuteNonQuery(); res.MESSAGE = "Error in detail insertion!!!!!";

                    cmd.Parameters.Clear();

                    dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";

                    if (article.Rows.Count == 0)
                    {
                        cmd.CommandText = "INSERT INTO STOCK  (CODE_MAG, CODE_ARTICLE, QTTE_STOCK) VALUES (@CODE_MAG,@CODE_ARTICLE,@QTTE_STOCK)";
                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "11";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "12";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "13";
                        cmd.ExecuteNonQuery(); res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                        cmd.Parameters.Clear();
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK+ @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE+ @QTTE_STOCK, PRIX_HT_V_ARTICLE=@PRIX_HT_V_ARTICLE, ETAT_ARTICLE='false', PRIX_HT_A_ARTICLE=@PRIX_HT_A_ARTICLE, TAUX_MAJORATION=@TAUX_MAJORATION, PRIX_TTC=@PRIX_TTC  WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                    cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in modifying product's quantity " + dr["CODE_ARTICLE"].ToString();

                    prix_achat = (1 - (decimal)dr["REMISE"] / 100) * ((decimal)dr["FODEC"] / 100 + 1) * (decimal)dr["PRIX_ART_BR_FR"];
                    if (article.Rows.Count > 0)
                    {
                        if (article.Rows[0]["PRIX_FIXE"].ToString() == "True")
                        {
                            cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"] < prix_achat ? prix_achat : (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"];
                            cmd.Parameters.Add("@TAUX_MAJORATION", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"] < prix_achat ? (decimal)article.Rows[0]["PRIX_HT_V_ARTICLE"] / prix_achat - 1 : (decimal)article.Rows[0]["TAUX_MAJORATION"];
                            cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_V_ARTICLE"];
                            cmd.Parameters.Add("@PRIX_TTC", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_TTC"];
                        }
                        else
                        {
                            cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"] < prix_achat ? prix_achat : (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"];
                            cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"] < prix_achat ? prix_achat * (1 + (decimal)article.Rows[0]["TAUX_MAJORATION"]) : (decimal)article.Rows[0]["PRIX_HT_V_ARTICLE"];
                            cmd.Parameters.Add("@PRIX_TTC", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"] < prix_achat ? prix_achat * (1 + (decimal)article.Rows[0]["TAUX_MAJORATION"]) * (1 + (decimal)article.Rows[0]["TVA_VENTE"] / 100) : (decimal)article.Rows[0]["PRIX_TTC"];
                            cmd.Parameters.Add("@TAUX_MAJORATION", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["TAUX_MAJORATION"];
                        }
                    }
                    else
                    {

                        cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = prix_achat;


                    }
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();



                }
                cmd.CommandText = "update  SOCIETE set   NUM_BON_RECEPTION=NUM_BON_RECEPTION+1 WHERE  CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                sqltrans.Commit();
                res.OK = true;
                res.CODE = NUM_BRECEP.ToString();
                res.MESSAGE = "Bon de réception enregistré avec succès.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY UPDATE_BR_FR(decimal CODE_BRECEP, string CODE_BR_FR, decimal CODE_FOURNISSEUR, decimal CODE_MAG, DateTime DATE_BR_FR, decimal CODE_USER, decimal MNT_BR, decimal REMISE, DataTable dt_lg_br)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock inner join article on article.code_article=stock.code_article where stock.code_mag='" + CODE_MAG + "'", CnxBase.myConn);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            DataTable dt_detail = new DataTable();
            SqlDataAdapter da_detail = new SqlDataAdapter();
            da_detail = new SqlDataAdapter("SELECT [CODE_BRECEP]      ,[CODE_BR_FR]      ,[CODE_ARTICLE]      ,[QTE_LG_BR_FR]      ,[PRIX_ART_BR_FR]  FROM [LG_BR_FR] WHERE [CODE_BRECEP]='" + CODE_BRECEP + "'", CnxBase.myConn);
            da_detail.FillSchema(dt_detail, SchemaType.Source);
            da_detail.Fill(dt_detail);

            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                //Traçabilité
                cmd.CommandText = "INSERT INTO [TRACE_BON_RECEP_FOURNISSEUR] ([CODE_BRECEP],[CODE_BR_FR],[CODE_FOURNISSEUR],[DATE_BR_FR],[CODE_USER] ,[MNT_BR_FR],[CODE_MAG],[RESTE],[REMISE],[DATE_MODIFICATION],[TYPE_TRACE]) SELECT BON_RECEP_FOURNISSEUR.[CODE_BRECEP]      ,BON_RECEP_FOURNISSEUR.[CODE_BR_FR]      ,BON_RECEP_FOURNISSEUR.[CODE_FOURNISSEUR]      ,BON_RECEP_FOURNISSEUR.[DATE_BR_FR]      ,BON_RECEP_FOURNISSEUR.[CODE_USER]      ,BON_RECEP_FOURNISSEUR.[MNT_BR_FR]      ,BON_RECEP_FOURNISSEUR.[CODE_MAG]      ,BON_RECEP_FOURNISSEUR.[RESTE]      ,BON_RECEP_FOURNISSEUR.[REMISE], GETDATE(),'M'  FROM [BON_RECEP_FOURNISSEUR] WHERE [CODE_BRECEP]=@CODE_BRECEP";
                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP;
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                cmd.CommandText = " SELECT MAX([TRACE_BON_RECEP_FOURNISSEUR].[ORDRE]) FROM [TRACE_BON_RECEP_FOURNISSEUR]";
                decimal ordre = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "INSERT INTO [TRACE_LG_BR_FR]           ([ORDRE]           ,[CODE_BRECEP]           ,[CODE_BR_FR]           ,[CODE_ARTICLE]           ,[QTE_LG_BR_FR]           ,[PRIX_ART_BR_FR])     SELECT '" + ordre + "', LG_BR_FR.[CODE_BRECEP]      ,LG_BR_FR.[CODE_BR_FR]      ,LG_BR_FR.[CODE_ARTICLE]      ,LG_BR_FR.[QTE_LG_BR_FR]      ,LG_BR_FR.[PRIX_ART_BR_FR]  FROM [LG_BR_FR] WHERE [CODE_BRECEP]=@CODE_BRECEP";
                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.NVarChar).Value = CODE_BRECEP;
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                //Modification du bon reception
                cmd.CommandText = "UPDATE BON_RECEP_FOURNISSEUR  SET CODE_BR_FR=@CODE_BR_FR, DATE_BR_FR=@DATE_BR_FR, CODE_USER=@CODE_USER, CODE_MAG=@CODE_MAG, MNT_BR_FR=@MNT_BR_FR, RESTE=@RESTE, REMISE=@REMISE  WHERE CODE_BRECEP=@CODE_BRECEP"; res.MESSAGE = "request error";

                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "1";
                cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_BR_FR", SqlDbType.DateTime).Value = DATE_BR_FR; res.MESSAGE = "2";
                //cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE_FOURNISSEUR; res.MESSAGE = "3";
                cmd.Parameters.Add("@MNT_BR_FR", SqlDbType.Decimal).Value = MNT_BR; res.MESSAGE = "4";
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "5";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "6";
                cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = REMISE;
                cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = (decimal)(MNT_BR * (1 - REMISE / 100));

                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();




                //Detail bon reception
                DataTable article = new DataTable();
                DataTable dt_test;
                int trouve = 0;
                foreach (DataRow dr in dt_detail.Rows)
                {
                    trouve = 0;
                    foreach (DataRow drt in dt_lg_br.Rows)
                    {
                        if (drt["CODE_ARTICLE"].ToString() == dr["CODE_ARTICLE"].ToString())
                        {
                            trouve++;
                        }
                    }
                    if (trouve == 0)
                    {
                        cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK- @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "SELECT isnull(MAX(PRIX_ART_BR_FR),0) FROM LG_BR_FR WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_BRECEP<>@CODE_BRECEP";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                        decimal prix_max = (decimal)cmd.ExecuteScalar();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE- @QTTE_STOCK, ETAT_ARTICLE='false', PRIX_HT_A_ARTICLE=@PRIX_HT_A_ARTICLE WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in modifying product's quantity " + dr["CODE_ARTICLE"].ToString();
                        cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = prix_max; res.MESSAGE = "17";


                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "DELETE FROM [LG_BR_FR]     WHERE [LG_BR_FR].[CODE_BRECEP]=@CODE_BRECEP and CODE_ARTICLE=@CODE_ARTICLE";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP;
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"];
                        cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                        cmd.Parameters.Clear();
                    }
                }

                foreach (DataRow dr in dt_lg_br.Rows)
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM LG_BR_FR WHERE CODE_BRECEP=@CODE_BRECEP and CODE_ARTICLE=@CODE_ARTICLE";
                    cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                    int exist = (int)cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    decimal qte = 0;
                    decimal prix = 0;
                    if (exist > 0)
                    {

                        cmd.CommandText = "SELECT QTE_LG_BR_FR FROM LG_BR_FR WHERE CODE_BRECEP=@CODE_BRECEP and CODE_ARTICLE=@CODE_ARTICLE";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                        qte = (decimal)cmd.ExecuteScalar();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "SELECT PRIX_ART_BR_FR FROM LG_BR_FR WHERE CODE_BRECEP=@CODE_BRECEP and CODE_ARTICLE=@CODE_ARTICLE";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                        prix = (decimal)cmd.ExecuteScalar();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "UPDATE LG_BR_FR SET CODE_BR_FR=@CODE_BR_FR, CODE_ARTICLE=@CODE_ARTICLE, QTE_LG_BR_FR=@QTE_LG_BR_FR, PRIX_ART_BR_FR=@PRIX_ART_BR_FR WHERE CODE_BRECEP=@CODE_BRECEP";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                        cmd.Parameters.Add("@QTE_LG_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "9";
                        cmd.Parameters.Add("@PRIX_ART_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"]; res.MESSAGE = "10";
                        cmd.ExecuteNonQuery(); res.MESSAGE = "Error in detail update!!!!!";

                        dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                        article = dt.DefaultView.ToTable();
                        dt.DefaultView.RowFilter = "";

                        if (article.Rows.Count == 0)
                        {
                            cmd.CommandText = "INSERT INTO STOCK  (CODE_MAG, CODE_ARTICLE, QTTE_STOCK) VALUES (@CODE_MAG,@CODE_ARTICLE,@QTTE_STOCK)";
                            cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "11";
                            cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "12";
                            cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "13";
                            cmd.ExecuteNonQuery(); res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                            cmd.Parameters.Clear();
                        }
                        else
                        {
                            cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK+ @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                            cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                            cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                            cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"] - qte; res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }

                        cmd.CommandText = "SELECT isnull(MAX(PRIX_ART_BR_FR),0) FROM LG_BR_FR WHERE CODE_ARTICLE=@CODE_ARTICLE and CODE_BRECEP<>@CODE_BRECEP";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                        decimal prix_max = (decimal)cmd.ExecuteScalar();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE+ @QTTE_STOCK, ETAT_ARTICLE='false', PRIX_HT_A_ARTICLE=@PRIX_HT_A_ARTICLE WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in modifying product's quantity " + dr["CODE_ARTICLE"].ToString();
                        if (article.Rows.Count > 0)
                        {
                            cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"] < prix_max ? (decimal)dr["PRIX_ART_BR_FR"] : prix_max; res.MESSAGE = "17";
                        }
                        else
                            cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"];
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO LG_BR_FR (CODE_BRECEP,CODE_BR_FR, CODE_ARTICLE, QTE_LG_BR_FR, PRIX_ART_BR_FR) VALUES (@CODE_BRECEP,@CODE_BR_FR,@CODE_ARTICLE,@QTE_LG_BR_FR,@PRIX_ART_BR_FR)";
                        cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.Decimal).Value = CODE_BRECEP; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "7";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                        cmd.Parameters.Add("@QTE_LG_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "9";
                        cmd.Parameters.Add("@PRIX_ART_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"]; res.MESSAGE = "10";
                        cmd.ExecuteNonQuery(); res.MESSAGE = "Error in detail insertion!!!!!";

                        dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                        article = dt.DefaultView.ToTable();
                        dt.DefaultView.RowFilter = "";

                        if (article.Rows.Count == 0)
                        {
                            cmd.CommandText = "INSERT INTO STOCK  (CODE_MAG, CODE_ARTICLE, QTTE_STOCK) VALUES (@CODE_MAG,@CODE_ARTICLE,@QTTE_STOCK)";
                            cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "11";
                            cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "12";
                            cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "13";
                            cmd.ExecuteNonQuery(); res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                            cmd.Parameters.Clear();
                        }
                        else
                        {
                            cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK+ @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                            cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                            cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                            cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }

                        cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE+ @QTTE_STOCK, ETAT_ARTICLE='false', PRIX_HT_A_ARTICLE=@PRIX_HT_A_ARTICLE WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                        cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "16";
                        cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "Error in modifying product's quantity " + dr["CODE_ARTICLE"].ToString();
                        if (article.Rows.Count > 0)
                        {
                            cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"] < (decimal)dr["PRIX_ART_BR_FR"] ? (decimal)dr["PRIX_ART_BR_FR"] : (decimal)article.Rows[0]["PRIX_HT_A_ARTICLE"]; res.MESSAGE = "17";
                        }
                        else
                            cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"];
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }


                sqltrans.Commit();
                res.OK = true;
                res.CODE = CODE_BRECEP.ToString();
                res.MESSAGE = "Bon de réception modifié avec succès.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public DataTable LOAD_BR_FR(decimal CODE_BRECEP)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP, dbo.BON_RECEP_FOURNISSEUR.CODE_BR_FR, dbo.BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR,                       dbo.BON_RECEP_FOURNISSEUR.DATE_BR_FR, dbo.BON_RECEP_FOURNISSEUR.REMISE, dbo.BON_RECEP_FOURNISSEUR.RESTE,                       dbo.BON_RECEP_FOURNISSEUR.CODE_MAG, dbo.BON_RECEP_FOURNISSEUR.MNT_BR_FR, dbo.BON_RECEP_FOURNISSEUR.CODE_USER,                       dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.UTILISATEUR.PRENOM_USER+' '+ dbo.UTILISATEUR.NOM_USER as [USER] FROM         dbo.BON_RECEP_FOURNISSEUR INNER JOIN                       dbo.FOURNISSEUR ON dbo.BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR = dbo.FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN                       dbo.UTILISATEUR ON dbo.BON_RECEP_FOURNISSEUR.CODE_USER = dbo.UTILISATEUR.CODE_USER WHERE dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP='" + CODE_BRECEP + "'", CnxBase.myConn);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public decimal GET_SOMME_RECEP(DateTime datedebut, DateTime datefin)
        {
            decimal somme = 0;
            try
            {
                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.CommandText = "select isnull(SUM(LG_BR_FR.QTE_LG_BR_FR*LG_BR_FR.PRIX_ART_BR_FR),0) from BON_RECEP_FOURNISSEUR inner join LG_BR_FR on LG_BR_FR.CODE_BRECEP=BON_RECEP_FOURNISSEUR.CODE_BRECEP where CONVERT(nvarchar, BON_RECEP_FOURNISSEUR.DATE_BR_FR,103) between '" + datedebut.ToShortDateString() + "' and '" + datefin.ToShortDateString() + "'";
                somme = (decimal)cmd.ExecuteScalar();
            }
            catch (Exception er)
            {
                throw er;
            }
            return somme;
        }

        [WebMethod]
        public DataTable LOAD_LIGNES_BR_FR(decimal CODE_BRECEP)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT        LG_BR_FR.CODE_ARTICLE, LG_BR_FR.QTE_LG_BR_FR, LG_BR_FR.PRIX_ART_BR_FR, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM            LG_BR_FR INNER JOIN  ARTICLE ON LG_BR_FR.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE LG_BR_FR.CODE_BRECEP='" + CODE_BRECEP + "'", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_SCHEMA_LIGNE_BR()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT        LG_BR_FR.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.REF_ARTICLE, LG_BR_FR.QTE_LG_BR_FR, LG_BR_FR.PRIX_ART_BR_FR FROM            LG_BR_FR INNER JOIN                          ARTICLE ON LG_BR_FR.CODE_ARTICLE = ARTICLE.CODE_ARTICLE where LG_BR_FR.CODE_BRECEP='0'", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_BR_FR()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT        BON_RECEP_FOURNISSEUR.CODE_BRECEP,BON_RECEP_FOURNISSEUR.CODE_BR_FR, FOURNISSEUR.RS_FOURNISSEUR, BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR, BON_RECEP_FOURNISSEUR.DATE_BR_FR, BON_RECEP_FOURNISSEUR.CODE_USER, BON_RECEP_FOURNISSEUR.CODE_MAG,  BON_RECEP_FOURNISSEUR.MNT_BR_FR, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER +' '+ UTILISATEUR.PRENOM_USER as USERNAME, BON_RECEP_FOURNISSEUR.RESTE FROM            BON_RECEP_FOURNISSEUR INNER JOIN  FOURNISSEUR ON BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR = FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN MAGAZIN ON BON_RECEP_FOURNISSEUR.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN UTILISATEUR ON BON_RECEP_FOURNISSEUR.CODE_USER = UTILISATEUR.CODE_USER ORDER BY BON_RECEP_FOURNISSEUR.DATE_BR_FR", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_BR_FR_SansFactures(decimal codeFournisseur)
        {
            string reqSql = "SELECT DISTINCT dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP, dbo.BON_RECEP_FOURNISSEUR.CODE_BR_FR ";
            reqSql += " FROM         dbo.BON_RECEP_FOURNISSEUR INNER JOIN ";
            reqSql += "  dbo.LG_BR_FR ON dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP = dbo.LG_BR_FR.CODE_BRECEP ";
            reqSql += " WHERE     ((SELECT     ISNULL(SUM(QTE), 0) AS Expr1";
            reqSql += "  FROM         dbo.LG_FACT_FR AS LG_FACT_FR_1 ";
            reqSql += "  WHERE     (CODE_BR_FR = dbo.LG_BR_FR.CODE_BRECEP) AND (CODE_ARTICLE = dbo.LG_BR_FR.CODE_ARTICLE)) < dbo.LG_BR_FR.QTE_LG_BR_FR)";
            reqSql += " and BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR='" + codeFournisseur + "'";
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_DETAILS_BR_FR_SansFactures(decimal CODE_BRECEP)
        {
            string reqSql = "SELECT * FROM VLG_BR_FR_SANS_FACT WHERE CODE_BRECEP='" + CODE_BRECEP + "'";
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(reqSql, CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable IMPRIMER_BRECEP_FR(decimal CODE_BRECEP)
        {
            DataTable dt = new DataTable();
            try
            {
                string reqSql = "SELECT     dbo.BON_RECEP_FOURNISSEUR.CODE_BR_FR, dbo.BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR, dbo.LG_BR_FR.CODE_ARTICLE,  ";
                reqSql += " dbo.LG_BR_FR.QTE_LG_BR_FR, dbo.LG_BR_FR.PRIX_ART_BR_FR, dbo.ARTICLE.REF_ARTICLE, dbo.ARTICLE.DESIGNATION_ARTICLE,  ";
                reqSql += " dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.SOCIETE.RS_SOCIETE, dbo.SOCIETE.DESCRIPTION_SOCIETE, dbo.SOCIETE.ADRESSE_SOCIETE,  ";
                reqSql += " dbo.SOCIETE.CP_SOCIETE, dbo.SOCIETE.TEL_SOCIETE, dbo.SOCIETE.FAX_SOCIETE, dbo.SOCIETE.EMAIL_SOCIETE, dbo.SOCIETE.SITE_WEB_SOCETE,  ";
                reqSql += " dbo.SOCIETE.LOGO_SOCIETE, dbo.SOCIETE.CODE_TVA_SOCIETE, dbo.MAGAZIN.NOM_MAG, dbo.BON_RECEP_FOURNISSEUR.MNT_BR_FR,  ";
                reqSql += " dbo.BON_RECEP_FOURNISSEUR.DATE_BR_FR, dbo.LG_BR_FR.UNITE, dbo.LG_BR_FR.TVA, dbo.LG_BR_FR.REMISE, dbo.LG_BR_FR.FODEC,  ";
                reqSql += "dbo.LG_BR_FR.CODE_CMD_FR, dbo.LG_BR_FR.CODE_FACT_FR, dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP, dbo.UTILISATEUR.CODE_USER,  ";
                reqSql += " dbo.UTILISATEUR.NOM_USER, dbo.UTILISATEUR.PRENOM_USER ";
                reqSql += " FROM         dbo.BON_RECEP_FOURNISSEUR INNER JOIN ";
                reqSql += " dbo.LG_BR_FR ON dbo.BON_RECEP_FOURNISSEUR.CODE_BR_FR = dbo.LG_BR_FR.CODE_BR_FR INNER JOIN ";
                reqSql += " dbo.ARTICLE ON dbo.LG_BR_FR.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE INNER JOIN ";
                reqSql += " dbo.FOURNISSEUR ON dbo.BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR = dbo.FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN ";
                reqSql += " dbo.MAGAZIN ON dbo.BON_RECEP_FOURNISSEUR.CODE_MAG = dbo.MAGAZIN.CODE_MAG INNER JOIN ";
                reqSql += " dbo.SOCIETE ON dbo.MAGAZIN.CODE_SOCIETE = dbo.SOCIETE.CODE_SOCIETE INNER JOIN ";
                reqSql += " dbo.UTILISATEUR ON dbo.BON_RECEP_FOURNISSEUR.CODE_USER = dbo.UTILISATEUR.CODE_USER ";
                reqSql += "  WHERE BON_RECEP_FOURNISSEUR.CODE_BRECEP='" + CODE_BRECEP + "'";
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

        #endregion

        #region CHM_BRETOUR_CLIENT Membres
        [WebMethod]
        public DataTable IMPRIMER_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     UTILISATEUR.CODE_USER, LIGNE_BRETOUR_CLIENT.CODE_ARTICLE, LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT, LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT, LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT * LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT as PRIX_TOTAL, SOCIETE.RS_SOCIETE, SOCIETE.DESCRIPTION_SOCIETE, SOCIETE.ADRESSE_SOCIETE, SOCIETE.CP_SOCIETE, SOCIETE.TEL_SOCIETE, SOCIETE.FAX_SOCIETE, SOCIETE.EMAIL_SOCIETE, SOCIETE.LOGO_SOCIETE, SOCIETE.SITE_WEB_SOCETE, BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.MNT_BRETOUR, BON_RETOUR_CLIENT.CODE_FACTURE, BON_RETOUR_CLIENT.CODE_MAG, UTILISATEUR.NOM_USER + ' ' + UTILISATEUR.PRENOM_USER AS utilisateur,                       ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM         UTILISATEUR INNER JOIN                      SOCIETE ON UTILISATEUR.CODE_SOCIETE = SOCIETE.CODE_SOCIETE INNER JOIN                      BON_RETOUR_CLIENT INNER JOIN                      LIGNE_BRETOUR_CLIENT ON BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT = LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT INNER JOIN                      ARTICLE ON LIGNE_BRETOUR_CLIENT.CODE_ARTICLE = ARTICLE.CODE_ARTICLE ON UTILISATEUR.CODE_USER = BON_RETOUR_CLIENT.CODE_USER WHERE BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT='" + CODE_BRETOUR_CLIENT + "'", CnxBase.myConn);
                //da.SelectCommand.Parameters.Add("@CODE_BRETOUR_CLIENT", SqlDbType.NVarChar).Value = CODE_BRETOUR_CLIENT;

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


        [WebMethod]
        public DataTable IMPRIMER_BR_CL_PAR_DATE(DateTime date_debut, DateTime date_fin)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATIOn_ARTICLE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT) as QTE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT) as Total from BON_RETOUR_CLIENT inner join LIGNE_BRETOUR_CLIENT on BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT=LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT inner join ARTICLE on LIGNE_BRETOUR_CLIENT.CODE_ARTICLE=ARTICLE.CODE_ARTICLE where CONVERT(nvarchar, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, 103) between '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE", CnxBase.myConn);

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

        [WebMethod]
        public DataTable IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal CODE_USER)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATIOn_ARTICLE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT) as QTE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT) as Total, UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER  as UTILISATEUR from BON_RETOUR_CLIENT inner join LIGNE_BRETOUR_CLIENT on BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT=LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT inner join ARTICLE on LIGNE_BRETOUR_CLIENT.CODE_ARTICLE=ARTICLE.CODE_ARTICLE inner join UTILISATEUR on UTILISATEUR.CODE_USER=BON_RETOUR_CLIENT.CODE_USER where BON_RETOUR_CLIENT.CODE_USER='" + CODE_USER + "' and CONVERT(nvarchar, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, 103) between '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER, ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE", CnxBase.myConn);

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

        [WebMethod]
        public RESULT_QUERY INSERT_BRETOUR_CLIENT(DateTime DATE_BRETOUR_CLIENT, decimal CODE_USER, decimal MNT_BRETOUR, string CODE_FACTURE, decimal CODE_MAG, DataTable dt_lg_bretour)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock inner join article on article.code_article=stock.code_article where stock.code_mag='" + CODE_MAG + "'", CnxBase.myConn);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;

            cmd.CommandText = "SELECT    isnull( NUM_BRETOUR_CLIENT,0) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1"; res.MESSAGE = "erreur selection num br";
            decimal NUM_BRETOUR = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion br";

            string CODE_BRETOUR_CLIENT = "BR" + numberToString(5, Convert.ToInt32(NUM_BRETOUR)) + "/" + DateTime.Now.Year.ToString();
            try
            {
                cmd.CommandText = "INSERT INTO BON_RETOUR_CLIENT (CODE_BRETOUR_CLIENT, DATE_BRETOUR_CLIENT, CODE_USER, MNT_BRETOUR, CODE_FACTURE, CODE_MAG) VALUES  (@CODE_BRETOUR_CLIENT,@DATE_BRETOUR_CLIENT,@CODE_USER,@MNT_BRETOUR,@CODE_FACTURE, @CODE_MAG)"; res.MESSAGE = "request error";
                cmd.Parameters.Add("@CODE_BRETOUR_CLIENT", SqlDbType.NVarChar).Value = CODE_BRETOUR_CLIENT; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_BRETOUR_CLIENT", SqlDbType.DateTime).Value = DATE_BRETOUR_CLIENT; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "3";
                cmd.Parameters.Add("@MNT_BRETOUR", SqlDbType.Decimal).Value = MNT_BRETOUR; res.MESSAGE = "4";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "5";
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "6";

                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                DataTable article = new DataTable();


                foreach (DataRow dr in dt_lg_bretour.Rows)
                {
                    cmd.CommandText = "INSERT INTO LIGNE_BRETOUR_CLIENT  (CODE_BRETOUR_CLIENT, CODE_ARTICLE, QTE_BRETOUR_CLIENT, PRIX_BRETOUR_CLIENT) VALUES (@CODE_BRETOUR_CLIENT,@CODE_ARTICLE,@QTE_BRETOUR_CLIENT,@PRIX_BRETOUR_CLIENT)";
                    cmd.Parameters.Add("@CODE_BRETOUR_CLIENT", SqlDbType.NVarChar).Value = CODE_BRETOUR_CLIENT; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                    cmd.Parameters.Add("@QTE_BRETOUR_CLIENT", SqlDbType.Decimal).Value = (decimal)dr["QTE_BRETOUR_CLIENT"]; res.MESSAGE = "9";
                    cmd.Parameters.Add("@PRIX_BRETOUR_CLIENT", SqlDbType.Decimal).Value = (decimal)dr["PRIX_BRETOUR_CLIENT"]; res.MESSAGE = "10";
                    cmd.ExecuteNonQuery(); res.MESSAGE = "Error in detail insertion!!!!!";

                    cmd.Parameters.Clear();

                    dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";


                    cmd.CommandText = "UPDATE STOCK SET QTTE_STOCK= QTTE_STOCK+ @QTTE_STOCK WHERE  (CODE_MAG = @CODE_MAG AND CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "14";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "15";
                    cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_BRETOUR_CLIENT"]; res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString() + "into stock!!!!!";
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE= QTE_ARTICLE+ @QTTE_STOCK, ETAT_ARTICLE='false' WHERE  (CODE_ARTICLE=@CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "Error in modifying product's quantity " + dr["CODE_ARTICLE"].ToString();
                    cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = (decimal)dr["QTE_BRETOUR_CLIENT"];

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                }
                cmd.CommandText = "UPDATE SOCIETE SET     NUM_BRETOUR_CLIENT=NUM_BRETOUR_CLIENT + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                sqltrans.Commit();

                res.CODE = CODE_BRETOUR_CLIENT;
                res.MESSAGE = "Bon de retour enregistré avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }
            return res;
        }

        [WebMethod]
        public DataTable LOAD_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_BRETOUR_CLIENT, DATE_BRETOUR_CLIENT, CODE_USER, MNT_BRETOUR, CODE_FACTURE, CODE_MAG FROM         BON_RETOUR_CLIENT WHERE CODE_BRETOUR_CLIENT='" + CODE_BRETOUR_CLIENT + "'", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_LIGNES_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_BRETOUR_CLIENT, CODE_ARTICLE, QTE_BRETOUR_CLIENT, PRIX_BRETOUR_CLIENT FROM         LIGNE_BRETOUR_CLIENT WHERE CODE_BRETOUR_CLIENT='" + CODE_BRETOUR_CLIENT + "'", CnxBase.myConn);
                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_BRETOUR_CLIENT.CODE_ARTICLE, LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT,  LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.REF_ARTICLE FROM ARTICLE INNER JOIN LIGNE_BRETOUR_CLIENT ON ARTICLE.CODE_ARTICLE = LIGNE_BRETOUR_CLIENT.CODE_ARTICLE where LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT='0'", CnxBase.myConn);

                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_BRETOUR_CLIENT()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT     MAGAZIN.NOM_MAG, BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.MNT_BRETOUR,  BON_RETOUR_CLIENT.CODE_USER, BON_RETOUR_CLIENT.CODE_FACTURE, BON_RETOUR_CLIENT.CODE_MAG, UTILISATEUR.NOM_USER+ ' '+                       UTILISATEUR.PRENOM_USER as utilisateur FROM         BON_RETOUR_CLIENT INNER JOIN                      UTILISATEUR ON BON_RETOUR_CLIENT.CODE_USER = UTILISATEUR.CODE_USER INNER JOIN                      MAGAZIN ON BON_RETOUR_CLIENT.CODE_MAG = MAGAZIN.CODE_MAG", CnxBase.myConn);

                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }







        #endregion

        #region INVENTAIRE Membres
        [WebMethod]
        public RESULT_QUERY CLOTURE_INVENTAIRE(decimal code_inventaire, decimal code_user, DataTable dt_inventaire, decimal CODE_MAG)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();

            SqlDataAdapter da = new SqlDataAdapter("select * From STOCK where STOCK.CODE_MAG='" + CODE_MAG + "'", CnxBase.myConn);
            da.SelectCommand.Transaction = sqltrans;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);


            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "update INVENTAIRE SET UTILISATEUR_FERM_INV=@UTILISATEUR_FERM_INV, DATE_FIN_INVENTAIRE=@DATE_FIN_INVENTAIRE WHERE CODE_INVENTAIRE=@CODE_INVENTAIRE";
                cmd.Parameters.Add("@UTILISATEUR_FERM_INV", SqlDbType.Decimal).Value = code_user;
                cmd.Parameters.Add("@DATE_FIN_INVENTAIRE", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@CODE_INVENTAIRE", SqlDbType.Decimal).Value = code_inventaire;
                cmd.ExecuteNonQuery();

                DataTable article;

                foreach (DataRow dr in dt_inventaire.Rows)
                {
                    dt.DefaultView.RowFilter = "CODE_ARTICLE='" + (Decimal)dr["CODE_ARTICLE"] + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update stock set qtte_stock=@qtte_stock where stock.code_article=@code_article and stock.CODE_MAG=@CODE_MAG";
                    cmd.Parameters.Add("@qtte_stock", SqlDbType.Decimal).Value = (decimal)dr["QTE_INVENTAIRE"];
                    cmd.Parameters.Add("@code_article", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["CODE_ARTICLE"];
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update ARTICLE set article.QTE_ARTICLE=article.QTE_ARTICLE-@qte1+@qte2 where ARTICLE.CODE_ARTICLE=@CODE_ARTICLE";
                    cmd.Parameters.Add("@qte1", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["QTTE_STOCK"];
                    cmd.Parameters.Add("@qte2", SqlDbType.Decimal).Value = (decimal)dr["QTE_INVENTAIRE"];
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)article.Rows[0]["CODE_ARTICLE"];
                    cmd.ExecuteNonQuery();
                }

                sqltrans.Commit();

                res.MESSAGE = "Inventaire cloturé avec succès. ";
                res.CODE = code_inventaire.ToString();
                res.OK = true;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public DataTable IMPRIMER_SAISIE_INVENTAIRE(decimal code_inventaire)
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG,                          INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.PRENOM_USER+' '+UTILISATEUR.NOM_USER as util,                          LIGNE_INVENTAIRE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, LIGNE_INVENTAIRE.QTE_INVENTAIRE, LIGNE_INVENTAIRE.QTE_STOCK,                          LIGNE_INVENTAIRE.QTE_ACHAT, LIGNE_INVENTAIRE.QTE_VENTE, LIGNE_INVENTAIRE.QTE_RETOUR, ARTICLE.DESIGNATION_ARTICLE,                          ARTICLE.CODE_BARRE_ARTICLE, CATEGORIE.LIB_CATEG FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER INNER JOIN                         LIGNE_INVENTAIRE ON INVENTAIRE.CODE_INVENTAIRE = LIGNE_INVENTAIRE.CODE_INVENTAIRE left outer join ARTICLE on LIGNE_INVENTAIRE.CODE_ARTICLE=ARTICLE.CODE_ARTICLE INNER JOIN                         CATEGORIE ON ARTICLE.CODE_CATEG = CATEGORIE.CODE_CATEG WHERE INVENTAIRE.CODE_INVENTAIRE='" + code_inventaire + "'", CnxBase.myConn))
                {
                    //da.SelectCommand.Transaction = CnxBase.trans;

                    //da.FillSchema(dt, SchemaType.Source);
                    //da.Fill(dt);
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_INVENTAIRE(decimal code_inventaire)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE,INVENTAIRE.CODE_MAG, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG, INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.PRENOM_USER+' '+UTILISATEUR.NOM_USER AS UTIL FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER WHERE INVENTAIRE.CODE_INVENTAIRE='" + code_inventaire + "'", CnxBase.myConn))
                {
                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public DataTable LOAD_LIGNE_INVENTAIRE(decimal code_inventaire)
        {
            //SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG,                          INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER,                          LIGNE_INVENTAIRE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, LIGNE_INVENTAIRE.QTE_INVENTAIRE, LIGNE_INVENTAIRE.QTE_STOCK,                          LIGNE_INVENTAIRE.QTE_ACHAT, LIGNE_INVENTAIRE.QTE_VENTE, LIGNE_INVENTAIRE.QTE_RETOUR, ARTICLE.DESIGNATION_ARTICLE,                          ARTICLE.CODE_BARRE_ARTICLE, CATEGORIE.LIB_CATEG FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER INNER JOIN                         LIGNE_INVENTAIRE ON INVENTAIRE.CODE_INVENTAIRE = LIGNE_INVENTAIRE.CODE_INVENTAIRE left outer join ARTICLE on LIGNE_INVENTAIRE.CODE_ARTICLE=ARTICLE.CODE_ARTICLE INNER JOIN                         CATEGORIE ON ARTICLE.CODE_CATEG = CATEGORIE.CODE_CATEG WHERE INVENTAIRE.CODE_INVENTAIRE='" + code_inventaire + "'", CnxBase.myConn))
                {


                    dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);

                }
            }
            catch (Exception er)
            {

                throw er;
            }
            return dt;
        }

        [WebMethod]
        public RESULT_QUERY OUVERTURE_INVENTAIRE(decimal code_user, decimal code_mag)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     isnull(MAX(CODE_INVENTAIRE) + 1,1) FROM         INVENTAIRE";
                decimal num_inventaire = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO INVENTAIRE  (CODE_INVENTAIRE, DATE_DEBUT_INVENTAIRE, DATE_FIN_INVENTAIRE, CODE_MAG, UTILISATEUR_CREAT_INV, UTILISATEUR_FERM_INV) VALUES  (@CODE_INVENTAIRE,@DATE_DEBUT_INVENTAIRE,@DATE_FIN_INVENTAIRE,@CODE_MAG,@UTILISATEUR_CREAT_INV,@UTILISATEUR_FERM_INV)";
                cmd.Parameters.Add("@CODE_INVENTAIRE", SqlDbType.Decimal).Value = num_inventaire;
                cmd.Parameters.Add("@DATE_DEBUT_INVENTAIRE", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@DATE_FIN_INVENTAIRE", SqlDbType.DateTime).Value = "01/01/1900";
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = code_mag;
                cmd.Parameters.Add("@UTILISATEUR_CREAT_INV", SqlDbType.Decimal).Value = code_user;
                cmd.Parameters.Add("@UTILISATEUR_FERM_INV", SqlDbType.Decimal).Value = 0;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO LIGNE_INVENTAIRE (CODE_INVENTAIRE, CODE_ARTICLE, QTE_INVENTAIRE, QTE_STOCK, QTE_ACHAT, QTE_VENTE, QTE_RETOUR) select @CODE_INVENTAIRE,STOCK.CODE_ARTICLE,0, STOCK.QTTE_STOCK, isnull(sum(LG_BR_FR.QTE_LG_BR_FR),0), isnull(SUM(LIGNE_FACTURE.QTE),0), isnull(SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT),0) from stock inner join ARTICLE on ARTICLE.CODE_ARTICLE=STOCK.CODE_ARTICLE inner join CATEGORIE on ARTICLE.CODE_CATEG=CATEGORIE.CODE_CATEG left outer join LG_BR_FR on STOCK.CODE_ARTICLE=LG_BR_FR.CODE_ARTICLE left outer join LIGNE_FACTURE on LIGNE_FACTURE.CODE_ARTICLE=STOCK.CODE_ARTICLE left outer join LIGNE_BRETOUR_CLIENT on LIGNE_BRETOUR_CLIENT.CODE_ARTICLE=STOCK.CODE_ARTICLE where STOCK.CODE_MAG=@CODE_MAG group by STOCK.CODE_ARTICLE, STOCK.CODE_MAG, STOCK.QTTE_STOCK, ARTICLE.CODE_BARRE_ARTICLE, ARTICLE.QTE_ARTICLE, CATEGORIE.LIB_CATEG order by CATEGORIE.LIB_CATEG ";
                cmd.Parameters.Add("@CODE_INVENTAIRE", SqlDbType.Decimal).Value = num_inventaire;
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = code_mag;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();

                res.CODE = num_inventaire.ToString();
                res.MESSAGE = "Inventaire ouvert avec succès.";
                res.OK = true;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY ENREGISTRER_LIGNE_INVENTAIRE(decimal code_inventaire, decimal code_article, decimal qte)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {

                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE LIGNE_INVENTAIRE  SET QTE_INVENTAIRE=@QTE_INVENTAIRE WHERE CODE_INVENTAIRE=@CODE_INVENTAIRE AND CODE_ARTICLE=@CODE_ARTICLE";
                cmd.Parameters.Add("@QTE_INVENTAIRE", SqlDbType.Decimal).Value = qte;
                cmd.Parameters.Add("@CODE_INVENTAIRE", SqlDbType.Decimal).Value = code_inventaire;
                cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = code_article;
                cmd.ExecuteNonQuery();

                sqltrans.Commit();


                res.MESSAGE = "Invetaire ouvert avec succès. ";
                res.OK = true;
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY VERIFIER_INVENTAIRE_MAGAZIN(decimal CODE_MAG)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG, INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER WHERE MAGAZIN.CODE_MAG='" + CODE_MAG + "' AND convert(nvarchar, DATE_FIN_INVENTAIRE, 103) like '01/01/1900'", CnxBase.myConn);
            DataTable dt = new DataTable();
            dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);


            if (dt.Rows.Count > 0)
            {
                res.OK = false;
            }
            else
            {
                res.OK = true;
            }
            return res;
        }

        [WebMethod]
        public DataTable SELECT_ALL_INVENTAIRE()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG, INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR_1.NOM_USER AS USER_CLOTURE, UTILISATEUR.NOM_USER AS USER_OUVERTURE FROM            UTILISATEUR INNER JOIN INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG ON UTILISATEUR.CODE_USER = INVENTAIRE.UTILISATEUR_CREAT_INV INNER JOIN                         UTILISATEUR AS UTILISATEUR_1 ON INVENTAIRE.UTILISATEUR_FERM_INV = UTILISATEUR_1.CODE_USER", CnxBase.myConn);

                dt = CnxBase.GetDataTable(da.SelectCommand.CommandText);
            }
            catch (Exception er)
            {
                throw er;
            }
            return dt;
        }

        [WebMethod]
        public decimal GET_INVENTAIRE_COURANT_PAR_MAGAZIN(decimal CODE_MAG)
        {
            decimal CODE_INVENTAIRE;
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            try
            {

                SqlCommand cmd = CnxBase.myConn.CreateCommand();
                cmd.Transaction = trans;

                cmd.CommandText = "select CODE_INVENTAIRE FROM INVENTAIRE WHERE CODE_MAG='" + CODE_MAG + "' AND CONVERT(nvarchar,DATE_FIN_INVENTAIRE, 103)='01/01/1900'";


                CODE_INVENTAIRE = (decimal)cmd.ExecuteScalar();
                trans.Commit();
            }
            catch (Exception er)
            {
                trans.Rollback();
                throw er;
            }
            return CODE_INVENTAIRE;
        }
        #endregion

        #region CHM_EMPLOYE Membres
        [WebMethod]
        public RESULT_QUERY DELETE_EMPLOYE(string CODE)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;

            try
            {
                res.CODE = CODE;
                cmd.CommandText = "DELETE FROM EMPLOYE WHERE  (CODE_EMPLOYE= @CODE_EMPLOYE)";
                cmd.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Supprimé avec succès.";

            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;

        }

        [WebMethod]
        public RESULT_QUERY INSERT_EMPLOYE(string CODE, string Nom, string PRENOM, DateTime DATE_NAIS, string ADRESSE, string TEL, string EMAIL, DateTime DATE_EMB, bool ETAT, string AGENCE)
        {


            decimal code_ag;

            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;

            try
            {
                cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE RS_SOCIETE LIKE'" + AGENCE + "'";
                code_ag = (decimal)cmd.ExecuteScalar();


                cmd.CommandText = "SELECT     ISNULL(MAX(CODE_EMPLOYE), 0) + 1  FROM         EMPLOYE";
                CODE = ((decimal)cmd.ExecuteScalar()).ToString();

                res.CODE = CODE;

                cmd.CommandText = "INSERT INTO EMPLOYE (CODE_EMPLOYE, NOM_EMPLOYE, PRENOM_EMPLOYE, DATE_NAIS_EMPLOYE, ADRESSE_EMPLOYE, TEL_EMPLOYE, EMAIL_EMPLOYE, DATE_EMBAUCHE_EMPLOYE, ETAT_EMPLOYE, CODE_SOCIETE) VALUES     (@CODE_EMPLOYE, @NOM_EMPLOYE, @PRENOM_EMPLOYE, @DATE_NAIS_EMPLOYE, @ADRESSE_EMPLOYE, @TEL_EMPLOYE, @EMAIL_EMPLOYE, @DATE_EMBAUCHE_EMPLOYE, @ETAT_USER, @CODE_SOCIETE)";
                cmd.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@NOM_EMPLOYE", SqlDbType.NVarChar).Value = Nom;
                cmd.Parameters.Add("@PRENOM_EMPLOYE", SqlDbType.NVarChar).Value = PRENOM;
                cmd.Parameters.Add("@DATE_NAIS_EMPLOYE", SqlDbType.DateTime).Value = DATE_NAIS;
                cmd.Parameters.Add("@ADRESSE_EMPLOYE", SqlDbType.NVarChar).Value = ADRESSE;
                cmd.Parameters.Add("@TEL_EMPLOYE", SqlDbType.NVarChar).Value = TEL;
                cmd.Parameters.Add("@EMAIL_EMPLOYE", SqlDbType.NVarChar).Value = EMAIL;
                cmd.Parameters.Add("@DATE_EMBAUCHE_EMPLOYE", SqlDbType.DateTime).Value = DATE_EMB;
                cmd.Parameters.Add("@ETAT_EMPLOYE", SqlDbType.Bit).Value = ETAT;
                cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = code_ag;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();

                res.OK = true;
                res.MESSAGE = "Enregistré avec succès.";
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        [WebMethod]
        public DataTable LOAD_EMPLOYE(string CODE)
        {
            SqlDataAdapter EMPLOYE_da = new SqlDataAdapter("SELECT * FROM EMPLOYE WHERE CODE_EMPLOYE= @CODE_EMPLOYE", CnxBase.myConn);
            EMPLOYE_da.SelectCommand.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;
            DataTable EMPLOYE_dt = new DataTable();
            EMPLOYE_da.FillSchema(EMPLOYE_dt, SchemaType.Source);
            EMPLOYE_da.Fill(EMPLOYE_dt);
            return EMPLOYE_dt;
        }

        [WebMethod]
        public DataTable SEARCH_EMPLOYE(string INDICE)
        {
            SqlDataAdapter EMPLOYE_da = new SqlDataAdapter("SELECT     * FROM EMPLOYE WHERE (NOM_EMPLOYE like '%" + INDICE + "%') OR (PRENOM_EMPLOYE like '%" + INDICE + "%') ", CnxBase.myConn);
            DataTable EMPLOYE_dt = new DataTable();
            EMPLOYE_da.FillSchema(EMPLOYE_dt, SchemaType.Source);
            EMPLOYE_da.Fill(EMPLOYE_dt);
            return EMPLOYE_dt;
        }

        [WebMethod]
        public DataTable SELECT_ALL_EMPLOYES()
        {
            SqlDataAdapter EMPLOYE_da = new SqlDataAdapter("SELECT * FROM EMPLOYE", CnxBase.myConn);
            DataTable EMPLOYE_dt = new DataTable();
            EMPLOYE_da.FillSchema(EMPLOYE_dt, SchemaType.Source);
            EMPLOYE_da.Fill(EMPLOYE_dt);
            return EMPLOYE_dt;

        }

        [WebMethod]
        public RESULT_QUERY UPDATE_EMPLOYE(string CODE, string Nom, string PRENOM, DateTime DATE_NAIS, string ADRESSE, string TEL, string EMAIL, DateTime DATE_EMB, bool ETAT, string AGENCE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;


            decimal code_ag;
            try
            {

                cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE RS_SOCIETE LIKE'" + AGENCE + "'";
                code_ag = (decimal)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE EMPLOYE SET  NOM_EMPLOYE=@NOM_EMPLOYE, PRENOM_EMPLOYE=@PRENOM_EMPLOYE, DATE_NAIS_EMPLOYE=@DATE_NAIS_EMPLOYE, ADRESSE_EMPLOYE=@ADRESSE_EMPLOYE, TEL_EMPLOYE=@TEL_EMPLOYE, EMAIL_EMPLOYE=@EMAIL_EMPLOYE, DATE_EMBAUCHE_EMPLOYE=@DATE_EMBAUCHE_EMPLOYE,  ETAT_EMPLOYE=@ETAT_EMPLOYE, CODE_SOCIETE=@CODE_SOCIETE WHERE (CODE_EMPLOYE=@CODE_EMPLOYE)";
                cmd.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@NOM_EMPLOYE", SqlDbType.NVarChar).Value = Nom;
                cmd.Parameters.Add("@PRENOM_EMPLOYE", SqlDbType.NVarChar).Value = PRENOM;
                cmd.Parameters.Add("@DATE_NAIS_EMPLOYE", SqlDbType.DateTime).Value = DATE_NAIS;
                cmd.Parameters.Add("@ADRESSE_EMPLOYE", SqlDbType.NVarChar).Value = ADRESSE;
                cmd.Parameters.Add("@TEL_EMPLOYE", SqlDbType.NVarChar).Value = TEL;
                cmd.Parameters.Add("@EMAIL_EMPLOYE", SqlDbType.NVarChar).Value = EMAIL;
                cmd.Parameters.Add("@DATE_EMBAUCHE_EMPLOYE", SqlDbType.DateTime).Value = DATE_EMB;
                cmd.Parameters.Add("@ETAT_EMPLOYE", SqlDbType.Bit).Value = ETAT;
                cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.NVarChar).Value = code_ag;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Enregistré avec succès.";

            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }



        [WebMethod]
        public string NEW_CODE_EMPLOYE(int nbCHIFRE)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT     ISNULL(MAX(CODE_EMPLOYE), 0) + 1 FROM         EMPLOYE", CnxBase.myConn))
            {
                decimal n = (decimal)cmd.ExecuteScalar();
                string resnb = n.ToString();
                if (nbCHIFRE > resnb.Length)
                {
                    int rep = nbCHIFRE - resnb.Length;
                    for (int i = 0; i < rep; i++)
                    {
                        resnb = "0" + resnb;
                    }
                }
                return resnb;
            }
        }

        #endregion

        #region CHM_FONCTIONNALITE Membres
        [WebMethod]
        public string DELETE_FONCTION(string CODE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM FONCTIONALITE_EMPLOYE WHERE  (CODE_FONCTION= @CODE_FONCTION)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        [WebMethod]
        public string INSERT_FONCTION(string CODE, string LABEL)
        {
            try
            {
                using (SqlCommand cmd_code = new SqlCommand("SELECT     ISNULL(MAX(CODE_FONCTION), 0) + 1  FROM         FONCTIONALITE_EMPLOYE", CnxBase.myConn))
                {
                    CODE = ((decimal)cmd_code.ExecuteScalar()).ToString();
                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO FONCTIONALITE_EMPLOYE (CODE_FONCTION, LIB_FONCTION) VALUES     (@CODE_FONCTION, @LIB_FONCTION)", CnxBase.myConn))
                {
                    cmd.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@LIB_FONCTION", SqlDbType.NVarChar).Value = LABEL;
                    cmd.ExecuteNonQuery();
                }


                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        [WebMethod]
        public DataTable LOAD_FONCTION(string CODE)
        {
            using (SqlDataAdapter FONCTION_da = new SqlDataAdapter("SELECT * FROM FONCTIONALITE_EMPLOYE WHERE CODE_FONCTION= @CODE_FONCTION", CnxBase.myConn))
            {
                FONCTION_da.SelectCommand.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;
                DataTable FONCTION_dt = new DataTable();
                FONCTION_da.FillSchema(FONCTION_dt, SchemaType.Source);
                FONCTION_da.Fill(FONCTION_dt);
                return FONCTION_dt;
            }
        }

        [WebMethod]
        public DataTable SELECT_ALL_FONTIONS()
        {
            using (SqlDataAdapter FONCTION_da = new SqlDataAdapter("SELECT CODE_FONCTION, LIB_FONCTION FROM FONCTIONALITE_EMPLOYE", CnxBase.myConn))
            {
                DataTable FONCTION_dt = new DataTable();
                FONCTION_da.FillSchema(FONCTION_dt, SchemaType.Source);
                FONCTION_da.Fill(FONCTION_dt);
                return FONCTION_dt;
            }
        }

        [WebMethod]
        public string UPDATE_FONCTION(string CODE, string LABEL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE FONCTIONALITE_EMPLOYE SET  LIB_FONCTION=@LIB_FONCTION WHERE (CODE_FONCTION=@CODE_FONCTION)", CnxBase.myConn);
                cmd.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@LIB_FONCTION", SqlDbType.NVarChar).Value = LABEL;



                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }




        public string NEW_CODE_Fonctions(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region UNITE ARTICLE
        [WebMethod]
        public RESULT_QUERY ajouteUNITE_ARTICLE(DUNITE_ARTICLE myUNITE_ARTICLE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "INSERT INTO UNITE	( LIB_UNITE)VALUES	( '" + myUNITE_ARTICLE.LIB_UNITE + "')";
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = reqSQL;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(code_unite) from UNITE";
                decimal code = (decimal)cmd.ExecuteScalar();

                trans.Commit();

                res.CODE = code.ToString();
                res.MESSAGE = "Unité enregistrée avec succès.";
                res.OK = true;

            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.MESSAGE = myErr.Message;
                res.OK = false;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY effaceUNITE_ARTICLE(DUNITE_ARTICLE myUNITE_ARTICLE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "DELETE FROM UNITE WHERE (CODE_UNITE=" + myUNITE_ARTICLE.CODE_UNITE + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Unité supprimé avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }
        }

        [WebMethod]
        public RESULT_QUERY modifieUNITE_ARTICLE(DUNITE_ARTICLE myUNITE_ARTICLE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "UPDATE UNITE SET LIB_UNITE='" + myUNITE_ARTICLE.LIB_UNITE + "' WHERE( CODE_UNITE=" + myUNITE_ARTICLE.CODE_UNITE + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Unité modifiée avec succès.";
                res.OK = true;
                return res;

            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }
        }

        [WebMethod]
        public DUNITE_ARTICLE obtenirInstanceUNITE_ARTICLE(DUNITE_ARTICLE myUNITE_ARTICLE)
        {
            string reqSQL = "SELECT CODE_UNITE, LIB_UNITE		FROM UNITE	WHERE (CODE_UNITE=" + myUNITE_ARTICLE.CODE_UNITE + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myUNITE_ARTICLE.CODE_UNITE = (Decimal)myReader["CODE_UNITE"];

                    myUNITE_ARTICLE.LIB_UNITE = (String)myReader["LIB_UNITE"];


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myUNITE_ARTICLE;
        }

        [WebMethod]
        public DataTable GetUNITE_ARTICLE()
        {

            string reqSQL = "select * from UNITE";
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
        #endregion

        #region TVA
        [WebMethod]
        public RESULT_QUERY ajouteTVA(DTVA myTVA)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;

            try
            {
                string reqSQL = "INSERT INTO TVA	( TVA_LIBELLE)VALUES	(@TVA_LIBELLE)";
                myCommand.CommandText = reqSQL;
                myCommand.Parameters.Add("@TVA_LIBELLE", SqlDbType.NVarChar).Value = myTVA.TVA_LIBELLE;

                
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "select max(code_tva) from tva ";
                res.CODE = myCommand.ExecuteScalar().ToString();

                trans.Commit();

                res.MESSAGE = "Enregistrement effectué avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }

        }

        [WebMethod]
        public RESULT_QUERY ajouteTAXE(DTAXE myTAXE)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            string reqSQL = "INSERT INTO [dbo].[TAXE](CODE_TVA,TAX_LIBELLE,TAX_TAUX,TAX_DEB_APPLIC,TAX_DATE_CREATION,TAX_CREATEUR ";
            reqSQL += ", TAX_DATE_MODIF, TAX_MODIFICATEUR) ";
            reqSQL += " VALUES(@CODE_TVA, @TAX_LIBELLE, @TAX_TAUX, @TAX_DEB_APPLIC, @TAX_DATE_CREATION, @TAX_CREATEUR, @TAX_DATE_MODIF ";
            reqSQL += ", @TAX_MODIFICATEUR) ";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Parameters.Add("@CODE_TVA", SqlDbType.Decimal).Value = myTAXE.CODE_TVA;
                myCommand.Parameters.Add("@TAX_LIBELLE", SqlDbType.NVarChar).Value = myTAXE.TAX_LIBELLE;
                myCommand.Parameters.Add("@TAX_TAUX", SqlDbType.Decimal).Value = myTAXE.TAX_TAUX;
                myCommand.Parameters.Add("@TAX_DEB_APPLIC", SqlDbType.DateTime).Value = myTAXE.TAX_DEB_APPLIC;
                myCommand.Parameters.Add("@TAX_DATE_CREATION", SqlDbType.DateTime).Value = myTAXE.TAX_DATE_CREATION;
                myCommand.Parameters.Add("@TAX_CREATEUR", SqlDbType.Decimal).Value = myTAXE.TAX_CREATEUR;
                myCommand.Parameters.Add("@TAX_DATE_MODIF", SqlDbType.DateTime).Value = myTAXE.TAX_DATE_MODIF;
                myCommand.Parameters.Add("@TAX_MODIFICATEUR", SqlDbType.Decimal).Value = myTAXE.TAX_MODIFICATEUR;


                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Enregistrement effectué avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }

        }

        [WebMethod]
        public RESULT_QUERY effaceTVA(DTVA myTVA)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "DELETE FROM TVA WHERE (CODE_TVA=" + myTVA.CODE_TVA + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Suppression effectuée avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }
        }

        [WebMethod]
        public RESULT_QUERY effaceTAXE(DTAXE myTAXE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "DELETE FROM TAXE WHERE (TAX_ID=" + myTAXE.TAX_ID + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Suppression effectuée avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }
        }

        [WebMethod]
        public RESULT_QUERY modifieTVA(DTVA myTVA)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "UPDATE TVA SET TAUX_TVA=" + myTVA.TVA_LIBELLE + " WHERE( CODE_TVA=" + myTVA.CODE_TVA + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Modification effectuée avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }
        }


        [WebMethod]
        public RESULT_QUERY modifierTAXE(DTAXE myTAXE)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            string reqSQL = "UPDATE TAXE SET CODE_TVA = @CODE_TVA,TAX_LIBELLE = @TAX_LIBELLE,TAX_TAUX = @TAX_TAUX, ";
            reqSQL += " TAX_DEB_APPLIC = @TAX_DEB_APPLIC,TAX_DATE_MODIF = @TAX_DATE_MODIF,TAX_MODIFICATEUR = @TAX_MODIFICATEUR";
            reqSQL += " WHERE (TAX_ID=@TAX_ID)";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Parameters.Add("@CODE_TVA", SqlDbType.Decimal).Value = myTAXE.CODE_TVA;
                myCommand.Parameters.Add("@TAX_LIBELLE", SqlDbType.NVarChar).Value = myTAXE.TAX_LIBELLE;
                myCommand.Parameters.Add("@TAX_TAUX", SqlDbType.Decimal).Value = myTAXE.TAX_TAUX;
                myCommand.Parameters.Add("@TAX_DEB_APPLIC", SqlDbType.DateTime).Value = myTAXE.TAX_DEB_APPLIC;
                myCommand.Parameters.Add("@TAX_DATE_MODIF", SqlDbType.DateTime).Value = myTAXE.TAX_DATE_MODIF;
                myCommand.Parameters.Add("@TAX_MODIFICATEUR", SqlDbType.Decimal).Value = myTAXE.TAX_MODIFICATEUR;
                myCommand.Parameters.Add("@TAX_ID", SqlDbType.Decimal).Value = myTAXE.TAX_ID;


                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.MESSAGE = "Modification effectuée avec succès.";
                res.OK = true;
                return res;
            }
            catch (Exception myErr)
            {
                res.MESSAGE = myErr.Message;
                res.OK = false;
                return res;
            }

        }

        [WebMethod]
        public DTVA obtenirInstanceTVA(DTVA myTVA)
        {
            string reqSQL = "SELECT CODE_TVA, TVA_LIBELLE		FROM TVA	WHERE (CODE_TVA=" + myTVA.CODE_TVA + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myTVA.CODE_TVA = (Decimal)myReader["CODE_TVA"];

                    myTVA.TVA_LIBELLE = myReader["TVA_LIBELLE"].ToString();


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myTVA;
        }

        [WebMethod]
        public DataTable GetTVA()
        {

            string reqSQL = "select * from TVA";
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
        public DataTable GetTAXE()
        {

            string reqSQL = "select * from TAXE";
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


        #endregion

        #region VEHICULE_CLIENT
        [WebMethod]
        public RESULT_QUERY ajouteVEHICULE(DVEHICULE myVEHICULE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;
            string reqSQL = "INSERT INTO VEHICULE	(MATRICULE, CODE_MARQUE, CODE_CLIENT, GAMME, TYPE, PUISSANCE, CYLINDRE) ";
            reqSQL += " VALUES	(@MATRICULE, @CODE_MARQUE, @CODE_CLIENT, @GAMME, @TYPE, @PUISSANCE, @CYLINDRE)";
            try
            {

                myCommand.CommandText = reqSQL;
                myCommand.Parameters.Add("@MATRICULE", SqlDbType.NVarChar).Value = myVEHICULE.MATRICULE;
                myCommand.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = myVEHICULE.CODE_MARQUE;
                myCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = myVEHICULE.CODE_CLIENT;
                myCommand.Parameters.Add("@GAMME", SqlDbType.NVarChar).Value = myVEHICULE.GAMME;
                myCommand.Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = myVEHICULE.TYPE;
                myCommand.Parameters.Add("@PUISSANCE", SqlDbType.Int).Value = myVEHICULE.PUISSANCE;
                myCommand.Parameters.Add("@CYLINDRE", SqlDbType.Int).Value = myVEHICULE.CYLINDRE;


                myCommand.ExecuteNonQuery();
                myCommand.Parameters.Clear();

                myCommand.CommandText = "select max(CODE_VEHICULE) FROM VEHICULE";
                res.CODE = myCommand.ExecuteScalar().ToString();

                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Véhicule enregistré avec succès";
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregstrement du véhicule.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY effaceVEHICULE(DVEHICULE myVEHICULE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;

            string reqSQL = "DELETE FROM VEHICULE WHERE (CODE_VEHICULE=@CODE_VEHICULE)";
            try
            {
                myCommand.CommandText = "Select count(*) from FICHE_INTERVENTION WHERE CODE_VEHICULE=@CODE_VEHICULE";
                myCommand.Parameters.Add("@CODE_VEHICULE", SqlDbType.Decimal).Value = myVEHICULE.CODE_VEHICULE;

                int count = (int)myCommand.ExecuteScalar();
                //da.SelectCommand = myCommand;
                //da.FillSchema(dt, SchemaType.Source);
                //da.Fill(dt);
                myCommand.Parameters.Clear();
                if (count > 0)
                    throw new Exception("Ce véhicule possède des fiches d'intervention");

                myCommand.CommandText = reqSQL;
                myCommand.Parameters.Add("@CODE_VEHICULE", SqlDbType.Decimal).Value = myVEHICULE.CODE_VEHICULE;
                myCommand.ExecuteNonQuery();

                trans.Commit();
                res.MESSAGE = "Véhicule supprimé avec succès!";
                res.OK = true;
                res.CODE = myVEHICULE.CODE_VEHICULE.ToString();
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de la supression du véhicule.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY modifieVEHICULE(DVEHICULE myVEHICULE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "UPDATE VEHICULE SET MATRICULE=@MATRICULE,CODE_MARQUE=@CODE_MARQUE,CODE_CLIENT=@CODE_CLIENT,GAMME=@GAMME,TYPE=@TYPE,PUISSANCE=@PUISSANCE,CYLINDRE=@CYLINDRE WHERE( CODE_VEHICULE=@CODE_VEHICULE)";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;


                myCommand.Parameters.Add("@MATRICULE", SqlDbType.NVarChar).Value = myVEHICULE.MATRICULE;
                myCommand.Parameters.Add("@CODE_MARQUE", SqlDbType.Decimal).Value = myVEHICULE.CODE_MARQUE;
                myCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = myVEHICULE.CODE_CLIENT;
                myCommand.Parameters.Add("@GAMME", SqlDbType.NVarChar).Value = myVEHICULE.GAMME;
                myCommand.Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = myVEHICULE.TYPE;
                myCommand.Parameters.Add("@PUISSANCE", SqlDbType.Int).Value = myVEHICULE.PUISSANCE;
                myCommand.Parameters.Add("@CYLINDRE", SqlDbType.Int).Value = myVEHICULE.CYLINDRE;
                myCommand.Parameters.Add("@CODE_VEHICULE", SqlDbType.Decimal).Value = myVEHICULE.CODE_VEHICULE;

                myCommand.ExecuteNonQuery();
                res.OK = true;
                res.MESSAGE = "Modification effectuée avec succès";
                res.CODE = myVEHICULE.CODE_VEHICULE.ToString();
            }
            catch (Exception myErr)
            {
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de la modification du véhicule.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public DVEHICULE obtenirInstanceVEHICULE(DVEHICULE myVEHICULE)
        {
            string reqSQL = "SELECT CODE_VEHICULE, MATRICULE, VEHICULE.CODE_MARQUE, VEHICULE.CODE_CLIENT, GAMME, TYPE, PUISSANCE, CYLINDRE, REF_CLIENT, RS_CLIENT, TEL_CLIENT, REF_MARQUE, DESIGNATION_MARQUE		FROM VEHICULE INNER JOIN CLIENT ON VEHICULE.CODE_CLIENT=CLIENT.CODE_CLIENT INNER JOIN MARQUE ON VEHICULE.CODE_MARQUE=MARQUE.CODE_MARQUE	WHERE (CODE_VEHICULE=" + myVEHICULE.CODE_VEHICULE + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myVEHICULE.CODE_VEHICULE = (Decimal)myReader["CODE_VEHICULE"];

                    myVEHICULE.MATRICULE = (String)myReader["MATRICULE"];

                    myVEHICULE.CODE_MARQUE = (Decimal)myReader["CODE_MARQUE"];

                    myVEHICULE.CODE_CLIENT = (Decimal)myReader["CODE_CLIENT"];

                    myVEHICULE.GAMME = (String)myReader["GAMME"];

                    myVEHICULE.TYPE = (String)myReader["TYPE"];

                    myVEHICULE.PUISSANCE = (Int32)myReader["PUISSANCE"];

                    myVEHICULE.CYLINDRE = (Int32)myReader["CYLINDRE"];

                    myVEHICULE.REF_CLIENT = (String)myReader["REF_CLIENT"];

                    myVEHICULE.RS_CLIENT = (String)myReader["RS_CLIENT"];

                    myVEHICULE.TEL_CLIENT = (String)myReader["TEL_CLIENT"];

                    myVEHICULE.REF_MARQUE = (String)myReader["REF_MARQUE"];

                    myVEHICULE.DESIGNATION_MARQUE = (String)myReader["DESIGNATION_MARQUE"];
                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myVEHICULE;
        }

        [WebMethod]
        public DataTable GetVEHICULE()
        {

            string reqSQL = "SELECT        VEHICULE.*, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT, MARQUE.REF_MARQUE, MARQUE.DESIGNATION_MARQUE ";
            reqSQL += " FROM            VEHICULE INNER JOIN ";
            reqSQL += " CLIENT ON VEHICULE.CODE_CLIENT = CLIENT.CODE_CLIENT INNER JOIN ";
            reqSQL += "  MARQUE ON VEHICULE.CODE_MARQUE = MARQUE.CODE_MARQUE";
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
        public DataTable GetVEHICULEParClient(decimal CodeClient)
        {

            string reqSQL = "select * from VEHICULE WHERE CODE_CLIENT=" + CodeClient;
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

        #endregion

        #region FICHE_INTERVENTION
        [WebMethod]
        public RESULT_QUERY ajouteFICHE_INTERVENTION(DFICHE_INTERVENTION myFICHE_INTERVENTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;


            try
            {

                myCommand.CommandText = "SELECT PREFIX1_FI+''+left(replicate('0',5-len(convert(nvarchar,ISNULL(NUM_FI+1,1))))+convert(nvarchar,ISNULL(NUM_FI+1,1)),5) +''+PREFIX2_FI FROM SOCIETE WHERE CODE_SOCIETE='1'";
                res.CODE = myCommand.ExecuteScalar().ToString();

                res.MESSAGE = "00";

                myCommand.CommandText = "INSERT INTO FICHE_INTERVENTION	(NUM_FI, DATE_FI, CODE_VEHICULE, KILOMETRAGE, CODE_B_LIV, USER_CR, DATE_MODIF, USER_MODIF, CLOTURE, DATE_CLOTURE, USER_CLOTURE, CODE_MAG)VALUES	(@NUM_FI, @DATE_FI, @CODE_VEHICULE, @KILOMETRAGE, @CODE_B_LIV, @USER_CR, @DATE_MODIF, @USER_MODIF, @CLOTURE, @DATE_CLOTURE, @USER_CLOTURE, @CODE_MAG)";
                myCommand.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = res.CODE; res.MESSAGE = "01";
                myCommand.Parameters.Add("@DATE_FI", SqlDbType.DateTime).Value = myFICHE_INTERVENTION.DATE_FI; res.MESSAGE = "02";
                myCommand.Parameters.Add("@CODE_VEHICULE", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.CODE_VEHICULE;
                myCommand.Parameters.Add("@KILOMETRAGE", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.KILOMETRAGE;
                myCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = myFICHE_INTERVENTION.CODE_B_LIV;
                myCommand.Parameters.Add("@USER_CR", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.USER_CR;
                myCommand.Parameters.Add("@DATE_MODIF", SqlDbType.DateTime).Value = Convert.ToDateTime("01/01/1900");
                myCommand.Parameters.Add("@USER_MODIF", SqlDbType.Decimal).Value = DBNull.Value;
                myCommand.Parameters.Add("@CLOTURE", SqlDbType.Bit).Value = 0;
                myCommand.Parameters.Add("@DATE_CLOTURE", SqlDbType.DateTime).Value = Convert.ToDateTime("01/01/1900");
                myCommand.Parameters.Add("@USER_CLOTURE", SqlDbType.Decimal).Value = DBNull.Value; res.MESSAGE = "03";
                myCommand.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.CODE_MAG; res.MESSAGE = "03";

                myCommand.ExecuteNonQuery();
                myCommand.Parameters.Clear();

                myCommand.CommandText = "INSERT INTO LG_FI(NUM_FI, CODE_ARTICLE, QTE_FI, P_HT_FI, TVA_FI, REMISE_FI)";
                myCommand.CommandText += "VALUES (@NUM_FI, @CODE_ARTICLE, @QTE_FI, @P_HT_FI, @TVA_FI, @REMISE_FI)";
                foreach (DARTICLE dr in myFICHE_INTERVENTION.DETAIL)
                {
                    myCommand.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = res.CODE; res.MESSAGE = "1";
                    myCommand.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr.CODE_ARTICLE; res.MESSAGE = "2";
                    myCommand.Parameters.Add("@QTE_FI", SqlDbType.Decimal).Value = dr.QTE_ARTICLE == null ? 0 : dr.QTE_ARTICLE; res.MESSAGE = "3";
                    myCommand.Parameters.Add("@P_HT_FI", SqlDbType.Decimal).Value = dr.PRIX_HT_V_ARTICLE == null ? 0 : dr.PRIX_HT_V_ARTICLE; res.MESSAGE = "4";
                    myCommand.Parameters.Add("@TVA_FI", SqlDbType.Decimal).Value = dr.TVA_ARTICLE == null ? 0 : dr.TVA_ARTICLE; res.MESSAGE = "5";
                    myCommand.Parameters.Add("@REMISE_FI", SqlDbType.Decimal).Value = dr.MAX_REMISE == null ? 0 : dr.MAX_REMISE; res.MESSAGE = "6";

                    myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                }

                myCommand.CommandText = "UPDATE SOCIETE SET NUM_FI=NUM_FI+1 WHERE CODE_SOCIETE ='1'";
                myCommand.ExecuteNonQuery();
                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Fiche enregistrée avec succès.";
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE += string.Format("Erreurs lors de l'enregistrement de la fiche.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY CloturerFICHE_INTERVENTION(DFICHE_INTERVENTION myFICHE_INTERVENTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;


            try
            {
                myCommand.CommandText = "UPDATE FICHE_INTERVENTIOn SET CLOTURE='True' , USER_CLOTURE=@USER_CLOTURE, DATE_CLOTURE=@DATE_CLOTURE WHERE (NUM_FI=@NUM_FI)";
                myCommand.Parameters.Add("@CLOTURE", SqlDbType.Bit).Value = myFICHE_INTERVENTION.CLOTURE;
                myCommand.Parameters.Add("@DATE_CLOTURE", SqlDbType.DateTime).Value = myFICHE_INTERVENTION.DATE_CLOTURE;
                myCommand.Parameters.Add("@USER_CLOTURE", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.USER_CLOTURE;
                myCommand.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = myFICHE_INTERVENTION.NUM_FI;
                myCommand.ExecuteNonQuery();

                myCommand.Parameters.Clear();

                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Fiche cloturée avec succès.";
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de la cloture de la fiche.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY effaceFICHE_INTERVENTION(DFICHE_INTERVENTION myFICHE_INTERVENTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string reqSQL = "DELETE FROM FICHE_INTERVENTION WHERE (NUM_FI='" + myFICHE_INTERVENTION.NUM_FI + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

                res.OK = true;
                res.MESSAGE = "Fiche supprimée avec succès.";
            }
            catch (Exception myErr)
            {
                res.OK = false;
                res.MESSAGE = myErr.Message;
            }
            return res;
        }

        [WebMethod]
        public RESULT_QUERY modifieFICHE_INTERVENTION(DFICHE_INTERVENTION myFICHE_INTERVENTION)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;


            try
            {


                myCommand.CommandText = "UPDATE FICHE_INTERVENTION SET DATE_FI=@DATE_FI,CODE_VEHICULE=@CODE_VEHICULE,KILOMETRAGE=@KILOMETRAGE,CODE_B_LIV=@CODE_B_LIV,DATE_MODIF=@DATE_MODIF,USER_MODIF=@USER_MODIF,CLOTURE=@CLOTURE,DATE_CLOTURE=@DATE_CLOTURE,USER_CLOTURE=@USER_CLOTURE WHERE( NUM_FI=@NUM_FI)";
                myCommand.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = myFICHE_INTERVENTION.NUM_FI;
                myCommand.Parameters.Add("@DATE_FI", SqlDbType.DateTime).Value = myFICHE_INTERVENTION.DATE_FI;
                myCommand.Parameters.Add("@CODE_VEHICULE", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.CODE_VEHICULE;
                myCommand.Parameters.Add("@KILOMETRAGE", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.KILOMETRAGE;
                myCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = myFICHE_INTERVENTION.CODE_B_LIV;
                myCommand.Parameters.Add("@DATE_MODIF", SqlDbType.DateTime).Value = myFICHE_INTERVENTION.DATE_MODIF;
                myCommand.Parameters.Add("@USER_MODIF", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.USER_MODIF;
                myCommand.Parameters.Add("@CLOTURE", SqlDbType.Bit).Value = myFICHE_INTERVENTION.CLOTURE;
                myCommand.Parameters.Add("@DATE_CLOTURE", SqlDbType.DateTime).Value = myFICHE_INTERVENTION.DATE_CLOTURE;
                myCommand.Parameters.Add("@USER_CLOTURE", SqlDbType.Decimal).Value = myFICHE_INTERVENTION.USER_CLOTURE;

                myCommand.ExecuteNonQuery();
                myCommand.Parameters.Clear();

                myCommand.CommandText = "DELETE FROM LG_FI WHERE( NUM_FI=@NUM_FI)";
                myCommand.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = myFICHE_INTERVENTION.NUM_FI; res.MESSAGE = myFICHE_INTERVENTION.NUM_FI + "0";
                myCommand.ExecuteNonQuery();
                myCommand.Parameters.Clear();

                myCommand.CommandText = "INSERT INTO LG_FI(NUM_FI, CODE_ARTICLE, QTE_FI, P_HT_FI, TVA_FI, REMISE_FI)";
                myCommand.CommandText += "VALUES (@NUM_FI, @CODE_ARTICLE, @QTE_FI, @P_HT_FI, @TVA_FI, @REMISE_FI)";
                foreach (DARTICLE dr in myFICHE_INTERVENTION.DETAIL)
                {
                    myCommand.Parameters.Add("@NUM_FI", SqlDbType.NVarChar).Value = myFICHE_INTERVENTION.NUM_FI;
                    myCommand.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr.CODE_ARTICLE;
                    myCommand.Parameters.Add("@QTE_FI", SqlDbType.Decimal).Value = dr.QTE_ARTICLE;
                    myCommand.Parameters.Add("@P_HT_FI", SqlDbType.Decimal).Value = dr.PRIX_HT_V_ARTICLE;
                    myCommand.Parameters.Add("@TVA_FI", SqlDbType.Decimal).Value = dr.TVA_ARTICLE;
                    myCommand.Parameters.Add("@REMISE_FI", SqlDbType.Decimal).Value = dr.MAX_REMISE;

                    myCommand.ExecuteNonQuery();
                    myCommand.Parameters.Clear();
                }


                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Fiche enregistrée avec succès.";
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de la fiche.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public DFICHE_INTERVENTION obtenirInstanceFICHE_INTERVENTION(DFICHE_INTERVENTION myFICHE_INTERVENTION)
        {
            SqlCommand myCommand = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            myCommand.Transaction = trans;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("mySrcTable");



            string reqSQL = "SELECT NUM_FI, DATE_FI, CODE_VEHICULE, KILOMETRAGE, CODE_B_LIV, USER_CR, DATE_MODIF, USER_MODIF, CLOTURE, DATE_CLOTURE, USER_CLOTURE, CODE_MAG		FROM FICHE_INTERVENTION	WHERE (NUM_FI='" + myFICHE_INTERVENTION.NUM_FI + "')";
            try
            {
                myCommand.CommandText = reqSQL;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myFICHE_INTERVENTION.NUM_FI = (String)myReader["NUM_FI"];

                    myFICHE_INTERVENTION.DATE_FI = myReader["DATE_FI"] == DBNull.Value ? Convert.ToDateTime("01/01/1900") : (DateTime)myReader["DATE_FI"];

                    myFICHE_INTERVENTION.CODE_VEHICULE = myReader["CODE_VEHICULE"] == DBNull.Value ? 0 : (Decimal)myReader["CODE_VEHICULE"];

                    myFICHE_INTERVENTION.KILOMETRAGE = myReader["KILOMETRAGE"] == DBNull.Value ? 0 : (Decimal)myReader["KILOMETRAGE"];

                    myFICHE_INTERVENTION.CODE_B_LIV = myReader["CODE_B_LIV"] == DBNull.Value ? "" : (String)myReader["CODE_B_LIV"];

                    myFICHE_INTERVENTION.USER_CR = myReader["USER_CR"] == DBNull.Value ? 0 : (Decimal)myReader["USER_CR"];

                    myFICHE_INTERVENTION.DATE_MODIF = myReader["DATE_MODIF"] == DBNull.Value ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(myReader["DATE_MODIF"]);

                    myFICHE_INTERVENTION.USER_MODIF = myReader["USER_MODIF"] == DBNull.Value ? 0 : (Decimal)myReader["USER_MODIF"];

                    myFICHE_INTERVENTION.CLOTURE = myReader["CLOTURE"] == DBNull.Value ? 0 : myReader["CLOTURE"].ToString() == "True" ? 1 : 0;

                    myFICHE_INTERVENTION.DATE_CLOTURE = myReader["DATE_CLOTURE"] == DBNull.Value ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(myReader["DATE_CLOTURE"]);

                    myFICHE_INTERVENTION.USER_CLOTURE = myReader["USER_CLOTURE"] == DBNull.Value ? 0 : (Decimal)myReader["USER_CLOTURE"];

                    myFICHE_INTERVENTION.CODE_MAG = myReader["CODE_MAG"] == DBNull.Value ? 0 : (Decimal)myReader["CODE_MAG"];
                }
                myReader.Close();

                myCommand.CommandText = "SELECT     dbo.LG_FI.NUM_FI, dbo.LG_FI.CODE_ARTICLE, dbo.LG_FI.QTE_FI, dbo.LG_FI.P_HT_FI, dbo.LG_FI.TVA_FI, dbo.LG_FI.REMISE_FI, dbo.ARTICLE.REF_ARTICLE, ";
                myCommand.CommandText += "dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.DESCRIPTION_ARTICLE, dbo.UNITE.LIB_UNITE ";
                myCommand.CommandText += " FROM         dbo.LG_FI INNER JOIN ";
                myCommand.CommandText += " dbo.ARTICLE ON dbo.LG_FI.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE INNER JOIN ";
                myCommand.CommandText += " dbo.UNITE ON dbo.ARTICLE.CODE_UNITE = dbo.UNITE.CODE_UNITE ";
                myCommand.CommandText += " WHERE (dbo.LG_FI.NUM_FI='" + myFICHE_INTERVENTION.NUM_FI + "')";
                da.SelectCommand = myCommand;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    DARTICLE article = new DARTICLE();
                    article.CODE_ARTICLE = (decimal)dr["CODE_ARTICLE"];
                    article.QTE_ARTICLE = (decimal)dr["QTE_FI"];
                    article.UNITE_QTE_ARTICLE = (string)dr["LIB_UNITE"];
                    article.DESIGNATION_ARTICLE = (string)dr["DESIGNATION_ARTICLE"];
                    article.REF_ARTICLE = (string)dr["REF_ARTICLE"];
                    article.DESCRIPTION_ARTICLE = (string)dr["DESCRIPTION_ARTICLE"];
                    article.PRIX_HT_V_ARTICLE = (decimal)dr["P_HT_FI"];
                    article.MAX_REMISE = (decimal)dr["REMISE_FI"];
                    article.TVA_ARTICLE = (decimal)dr["TVA_FI"];
                    myFICHE_INTERVENTION.DETAIL.Add(article);
                }

                trans.Commit();
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myFICHE_INTERVENTION;
        }

        [WebMethod]
        public DataTable GetFICHE_INTERVENTION()
        {

            //string reqSQL = "SELECT        FICHE_INTERVENTION.*, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT, CLIENT.TEL_CLIENT, VEHICULE.MATRICULE, VEHICULE.CODE_MARQUE, VEHICULE.CODE_CLIENT, VEHICULE.GAMME, VEHICULE.TYPE, ";
            //reqSQL += " VEHICULE.PUISSANCE, VEHICULE.CYLINDRE, MARQUE.REF_MARQUE, MARQUE.DESIGNATION_MARQUE  ";
            //reqSQL += " FROM            FICHE_INTERVENTION INNER JOIN ";
            //reqSQL += " VEHICULE ON FICHE_INTERVENTION.CODE_VEHICULE = VEHICULE.CODE_VEHICULE INNER JOIN ";
            //reqSQL += " CLIENT ON VEHICULE.CODE_CLIENT = CLIENT.CODE_CLIENT INNER JOIN ";
            //reqSQL += " MARQUE ON VEHICULE.CODE_MARQUE = MARQUE.CODE_MARQUE";

            string reqSQL = "select * from V_FI_EQP";
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
        public DataTable GetFICHE_INTERVENTION_PAR_VEHICULE(decimal codeVehicule)
        {
            string reqSQL = "SELECT        FICHE_INTERVENTION.*, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT, CLIENT.TEL_CLIENT, VEHICULE.MATRICULE, VEHICULE.CODE_MARQUE, VEHICULE.CODE_CLIENT, VEHICULE.GAMME, VEHICULE.TYPE, ";
            reqSQL += " VEHICULE.PUISSANCE, VEHICULE.CYLINDRE, MARQUE.REF_MARQUE, MARQUE.DESIGNATION_MARQUE  ";
            reqSQL += " FROM            FICHE_INTERVENTION INNER JOIN ";
            reqSQL += " VEHICULE ON FICHE_INTERVENTION.CODE_VEHICULE = VEHICULE.CODE_VEHICULE INNER JOIN ";
            reqSQL += " CLIENT ON VEHICULE.CODE_CLIENT = CLIENT.CODE_CLIENT INNER JOIN ";
            reqSQL += " MARQUE ON VEHICULE.CODE_MARQUE = MARQUE.CODE_MARQUE ";
            reqSQL += "  WHERE VEHICULE.CODE_VEHICULE='" + codeVehicule + "'";
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
        public DataTable GetFICHE_INTERVENTION_PAR_EQUIPEMENT(decimal codeVehicule)
        {
            string reqSQL = "select * from V_FI_EQP";
            reqSQL += "  WHERE CODE_VEHICULE='" + codeVehicule + "'";
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
        public DataTable GetDetailFicheIntervention(string NUM_FICHE)
        {
            string reqSQL = string.Empty;
            reqSQL = "SELECT     dbo.LG_FI.NUM_FI, dbo.LG_FI.CODE_ARTICLE, dbo.LG_FI.QTE_FI, dbo.LG_FI.P_HT_FI, dbo.LG_FI.TVA_FI, dbo.LG_FI.REMISE_FI, dbo.ARTICLE.REF_ARTICLE, ";
            reqSQL += "dbo.ARTICLE.DESIGNATION_ARTICLE, dbo.ARTICLE.DESCRIPTION_ARTICLE, dbo.UNITE.LIB_UNITE ";
            reqSQL += " FROM         dbo.LG_FI INNER JOIN ";
            reqSQL += " dbo.ARTICLE ON dbo.LG_FI.CODE_ARTICLE = dbo.ARTICLE.CODE_ARTICLE INNER JOIN ";
            reqSQL += " dbo.UNITE ON dbo.ARTICLE.CODE_UNITE = dbo.UNITE.CODE_UNITE ";
            reqSQL += " WHERE (dbo.LG_FI.NUM_FI='" + NUM_FICHE + "')";
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
        #endregion

        #region TICKET_CAISSE
        [WebMethod]
        public void ajouteTICKET_CAISSE(DTICKET_CAISSE myTICKET_CAISSE)
        {

            string reqSQL = "INSERT INTO TICKET_CAISSE	(CODE_TC, DATE_TC, CODE_CAISSE, CODE_CLIENT, MONTANT_HT, REMISE, MONTANT_TVA, MONTANT_TTC, MONTANT_RECU, RESTE, MAGASIN, CODE_USER, CODE_REGLEMENT, CODE_FACTURE)VALUES	('" + myTICKET_CAISSE.CODE_TC + "', '" + myTICKET_CAISSE.DATE_TC + "', " + myTICKET_CAISSE.CODE_CAISSE + ", " + myTICKET_CAISSE.CODE_CLIENT + ", " + myTICKET_CAISSE.MONTANT_HT + ", " + myTICKET_CAISSE.REMISE + ", " + myTICKET_CAISSE.MONTANT_TVA + ", " + myTICKET_CAISSE.MONTANT_TTC + ", " + myTICKET_CAISSE.MONTANT_RECU + ", " + myTICKET_CAISSE.RESTE + ", " + myTICKET_CAISSE.MAGASIN + ", " + myTICKET_CAISSE.CODE_USER + ", " + myTICKET_CAISSE.CODE_REGLEMENT + ", '" + myTICKET_CAISSE.CODE_FACTURE + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

        }

        [WebMethod]
        public void effaceTICKET_CAISSE(DTICKET_CAISSE myTICKET_CAISSE)
        {

            string reqSQL = "DELETE FROM TICKET_CAISSE WHERE (CODE_TC='" + myTICKET_CAISSE.CODE_TC + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        [WebMethod]
        public void modifieTICKET_CAISSE(DTICKET_CAISSE myTICKET_CAISSE)
        {

            string reqSQL = "UPDATE TICKET_CAISSE SET CODE_TC='" + myTICKET_CAISSE.CODE_TC + "',DATE_TC='" + myTICKET_CAISSE.DATE_TC + "',CODE_CAISSE=" + myTICKET_CAISSE.CODE_CAISSE + ",CODE_CLIENT=" + myTICKET_CAISSE.CODE_CLIENT + ",MONTANT_HT=" + myTICKET_CAISSE.MONTANT_HT + ",REMISE=" + myTICKET_CAISSE.REMISE + ",MONTANT_TVA=" + myTICKET_CAISSE.MONTANT_TVA + ",MONTANT_TTC=" + myTICKET_CAISSE.MONTANT_TTC + ",MONTANT_RECU=" + myTICKET_CAISSE.MONTANT_RECU + ",RESTE=" + myTICKET_CAISSE.RESTE + ",MAGASIN=" + myTICKET_CAISSE.MAGASIN + ",CODE_USER=" + myTICKET_CAISSE.CODE_USER + ",CODE_REGLEMENT=" + myTICKET_CAISSE.CODE_REGLEMENT + ",CODE_FACTURE='" + myTICKET_CAISSE.CODE_FACTURE + "' WHERE( CODE_TC='" + myTICKET_CAISSE.CODE_TC + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }

        [WebMethod]
        public DTICKET_CAISSE obtenirInstanceTICKET_CAISSE(DTICKET_CAISSE myTICKET_CAISSE)
        {
            string reqSQL = "SELECT CODE_TC, DATE_TC, CODE_CAISSE, CODE_CLIENT, MONTANT_HT, REMISE, MONTANT_TVA, MONTANT_TTC, MONTANT_RECU, RESTE, MAGASIN, CODE_USER, CODE_REGLEMENT, CODE_FACTURE		FROM TICKET_CAISSE	WHERE (CODE_TC='" + myTICKET_CAISSE.CODE_TC + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myTICKET_CAISSE.CODE_TC = (String)myReader["CODE_TC"];

                    myTICKET_CAISSE.DATE_TC = Convert.ToDateTime(myReader["DATE_TC"]);

                    myTICKET_CAISSE.CODE_CAISSE = (Decimal)myReader["CODE_CAISSE"];

                    myTICKET_CAISSE.CODE_CLIENT = (Decimal)myReader["CODE_CLIENT"];

                    myTICKET_CAISSE.MONTANT_HT = (Decimal)myReader["MONTANT_HT"];

                    myTICKET_CAISSE.REMISE = (Decimal)myReader["REMISE"];

                    myTICKET_CAISSE.MONTANT_TVA = (Decimal)myReader["MONTANT_TVA"];

                    myTICKET_CAISSE.MONTANT_TTC = (Decimal)myReader["MONTANT_TTC"];

                    myTICKET_CAISSE.MONTANT_RECU = (Decimal)myReader["MONTANT_RECU"];

                    myTICKET_CAISSE.RESTE = (Decimal)myReader["RESTE"];

                    myTICKET_CAISSE.MAGASIN = (Decimal)myReader["MAGASIN"];

                    myTICKET_CAISSE.CODE_USER = (Decimal)myReader["CODE_USER"];

                    myTICKET_CAISSE.CODE_REGLEMENT = (Decimal)myReader["CODE_REGLEMENT"];

                    myTICKET_CAISSE.CODE_FACTURE = (String)myReader["CODE_FACTURE"];


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myTICKET_CAISSE;
        }

        [WebMethod]
        public DataTable GetTICKET_CAISSE()
        {

            string reqSQL = "select * from TICKET_CAISSE";
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
        public DataTable Select_All_TICKET_CAISSE()
        {

            string reqSQL = "select * from V_TC";
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
        public DataTable Select_All_TICKET_CAISSE_Par_Client(decimal codeClient)
        {

            string reqSQL = "select * from V_TC where code_client='" + codeClient + "'";
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
        public DataTable Get_Detail_TC(string code_tc)
        {

            string reqSQL = "SELECT        LG_TC.CODE_TC, LG_TC.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, LG_TC.QTE, LG_TC.UNITE, LG_TC.PRIX_HT, LG_TC.TAUX_REMISE, LG_TC.TVA, LG_TC.PRIX_TTC ";
            reqSQL += " FROM            LG_TC INNER JOIN ";
            reqSQL += "   ARTICLE ON LG_TC.CODE_ARTICLE = ARTICLE.CODE_ARTICLE";
            reqSQL += " where LG_TC.CODE_TC=@CODE_TC";

            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.CommandText = reqSQL;
            cmd.Parameters.Add("@CODE_TC", SqlDbType.NVarChar).Value = code_tc;
            DataTable myResult = new DataTable("MySrcTable");
            try
            {

                da.FillSchema(myResult, SchemaType.Source);
                da.Fill(myResult);
                trans.Commit();
                return myResult;


            }
            catch (Exception myErr)
            {
                trans.Rollback();
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }
        #endregion

        #region DEVIS_CLIENT
        [WebMethod]
        public RESULT_QUERY ajouteDEVIS_CLIENT(DDEVIS_CLIENT myDEVIS_CLIENT, DataTable dtDetails)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_DEVC) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_DEVC = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "SELECT     ISNULL(PREFIX1_DEVC, '') FROM         SOCIETE WHERE CODE_SOCIETE =1";
                string PREFIX1_DEVC = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix1 cmd";

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_DEVC, '') FROM         SOCIETE";
                string PREFIXE2_DEVC = (string)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion prefix2 cmd";

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_DEVC = NUM_DEVC +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_DEVC = PREFIX1_DEVC + numberToString(5, Convert.ToInt32(NUM_DEVC)) + PREFIXE2_DEVC;
                res.MESSAGE = "erreur insertion prefix1 cmd";
                res.CODE = CODE_DEVC;

                cmd.CommandText = "INSERT INTO DEVIS_CLIENT (CODE_DC, DATE_DC, DATE_VALIDITE, CODE_CLIENT, MODE_PAIEMENT, OBSERVATION, UTILISATEUR_CREATION, DATE_CREATION, RESPONSABLE, NB_IMPRIME, TIMBRE) values (@CODE_DC, @DATE_DC, @DATE_VALIDITE, @CODE_CLIENT, @MODE_PAIEMENT, @OBSERVATION, @UTILISATEUR_CREATION, @DATE_CREATION, @RESPONSABLE, @NB_IMPRIME, @TIMBRE)";
                cmd.Parameters.Add("@CODE_DC", SqlDbType.NVarChar).Value = CODE_DEVC; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_DC", SqlDbType.DateTime).Value = myDEVIS_CLIENT.DATE_DC; res.MESSAGE = "2";
                cmd.Parameters.Add("@DATE_VALIDITE", SqlDbType.Decimal).Value = myDEVIS_CLIENT.DATE_VALIDITE; res.MESSAGE = "3";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = myDEVIS_CLIENT.CODE_CLIENT; res.MESSAGE = "4";
                cmd.Parameters.Add("@MODE_PAIEMENT", SqlDbType.NVarChar).Value = myDEVIS_CLIENT.MODE_PAIEMENT; res.MESSAGE = "5";
                cmd.Parameters.Add("@OBSERVATION", SqlDbType.NVarChar).Value = myDEVIS_CLIENT.OBSERVATION; res.MESSAGE = "6";
                cmd.Parameters.Add("@UTILISATEUR_CREATION", SqlDbType.Decimal).Value = myDEVIS_CLIENT.UTILISATEUR_CREATION; res.MESSAGE = "7";
                cmd.Parameters.Add("@DATE_CREATION", SqlDbType.DateTime).Value = myDEVIS_CLIENT.DATE_CREATION; res.MESSAGE = "8";
                cmd.Parameters.Add("@RESPONSABLE", SqlDbType.NVarChar).Value = myDEVIS_CLIENT.RESPONSABLE;
                cmd.Parameters.Add("@NB_IMPRIME", SqlDbType.Decimal).Value = 0;
                cmd.Parameters.Add("@TIMBRE", SqlDbType.Decimal).Value = myDEVIS_CLIENT.TIMBRE;

                cmd.ExecuteNonQuery(); res.MESSAGE = "an error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dtDetails.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_DC( CODE_DC, CODE_ARTICLE, QTE, UNITE, PRIX_U_HT, FODEC, REMISE, TVA, PRIX_HT_ACHAT, TVA_ACHAT) VALUES     ( @CODE_DC, @CODE_ARTICLE, @QTE, @UNITE, @PRIX_U_HT, @FODEC, @REMISE, @TVA, @PRIX_HT_ACHAT, @TVA_ACHAT)";
                    cmd.Parameters.Add("@CODE_DC", SqlDbType.NVarChar).Value = CODE_DEVC; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE"]; res.MESSAGE = "23";
                    cmd.Parameters.Add("@UNITE", SqlDbType.NVarChar).Value = dr["UNITE"]; res.MESSAGE = "24";
                    cmd.Parameters.Add("@PRIX_U_HT", SqlDbType.Decimal).Value = dr["PRIX_U_HT"]; res.MESSAGE = "25";
                    cmd.Parameters.Add("@FODEC", SqlDbType.Decimal).Value = 0; res.MESSAGE = "26";
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = dr["REMISE"]; res.MESSAGE = "27";
                    cmd.Parameters.Add("@TVA", SqlDbType.Decimal).Value = dr["TVA"]; res.MESSAGE = "28";
                    cmd.Parameters.Add("@PRIX_HT_ACHAT", SqlDbType.Decimal).Value = dr["PRIX_HT_ACHAT"]; res.MESSAGE = "29";
                    cmd.Parameters.Add("@TVA_ACHAT", SqlDbType.Decimal).Value = dr["TVA_ACHAT"]; res.MESSAGE = "30";

                    cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                    cmd.Parameters.Clear();
                }

                sqltrans.Commit();

                res.MESSAGE = "Devis client enregistré avec succès.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }
            return res;

        }

        [WebMethod]
        public RESULT_QUERY imprimerDEVIS_CLIENT(string CODE_DC)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CnxBase.myConn.BeginTransaction();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "update DEVIS_CLIENT SET NB_IMPRIME=NB_IMPRIME+1 WHERE CODE_DC like '" + CODE_DC + "'";
                cmd.ExecuteNonQuery();

                sqltrans.Commit();

                res.MESSAGE = "Impression effectuée avec succès.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }
            return res;

        }

        [WebMethod]
        public void effaceDEVIS_CLIENT(DDEVIS_CLIENT myDEVIS_CLIENT)
        {

            string reqSQL = "DELETE FROM DEVIS_CLIENT WHERE (CODE_DC='" + myDEVIS_CLIENT.CODE_DC + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        [WebMethod]
        public void modifieDEVIS_CLIENT(DDEVIS_CLIENT myDEVIS_CLIENT)
        {

            string reqSQL = "UPDATE DEVIS_CLIENT SET CODE_DC='" + myDEVIS_CLIENT.CODE_DC + "',DATE_DC='" + myDEVIS_CLIENT.DATE_DC + "',DATE_VALIDITE=" + myDEVIS_CLIENT.DATE_VALIDITE + ",CODE_CLIENT=" + myDEVIS_CLIENT.CODE_CLIENT + ",MODE_PAIEMENT='" + myDEVIS_CLIENT.MODE_PAIEMENT + "',OBSERVATION='" + myDEVIS_CLIENT.OBSERVATION + "',UTILISATEUR_CREATION=" + myDEVIS_CLIENT.UTILISATEUR_CREATION + ",DATE_CREATION='" + myDEVIS_CLIENT.DATE_CREATION + "',RESPONSABLE='" + myDEVIS_CLIENT.RESPONSABLE + "',NB_IMPRIME=" + myDEVIS_CLIENT.NB_IMPRIME + " WHERE( CODE_DC='" + myDEVIS_CLIENT.CODE_DC + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }


        [WebMethod]
        public DDEVIS_CLIENT obtenirInstanceDEVIS_CLIENT(DDEVIS_CLIENT myDEVIS_CLIENT)
        {
            string reqSQL = "SELECT CODE_DC, DATE_DC, DATE_VALIDITE, CODE_CLIENT, MODE_PAIEMENT, OBSERVATION, UTILISATEUR_CREATION, DATE_CREATION, RESPONSABLE, NB_IMPRIME		FROM DEVIS_CLIENT	WHERE (CODE_DC='" + myDEVIS_CLIENT.CODE_DC + "')";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myDEVIS_CLIENT.CODE_DC = (String)myReader["CODE_DC"];

                    myDEVIS_CLIENT.DATE_DC = Convert.ToDateTime(myReader["DATE_DC"]);

                    myDEVIS_CLIENT.DATE_VALIDITE = (Decimal)myReader["DATE_VALIDITE"];

                    myDEVIS_CLIENT.CODE_CLIENT = (Decimal)myReader["CODE_CLIENT"];

                    myDEVIS_CLIENT.MODE_PAIEMENT = (String)myReader["MODE_PAIEMENT"];

                    myDEVIS_CLIENT.OBSERVATION = (String)myReader["OBSERVATION"];

                    myDEVIS_CLIENT.UTILISATEUR_CREATION = (Decimal)myReader["UTILISATEUR_CREATION"];

                    myDEVIS_CLIENT.DATE_CREATION = Convert.ToDateTime(myReader["DATE_CREATION"]);

                    myDEVIS_CLIENT.RESPONSABLE = (String)myReader["RESPONSABLE"];

                    myDEVIS_CLIENT.NB_IMPRIME = (Decimal)myReader["NB_IMPRIME"];


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myDEVIS_CLIENT;
        }

        [WebMethod]
        public DataTable GetDEVIS_CLIENT()
        {

            string reqSQL = "select * from V_DC";
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
        public DataTable GetDETAILS_DEVIS_CLIENT(string CODE_DC)
        {

            string reqSQL = "select * from V_LG_DC where CODE_DC like '" + CODE_DC + "'";
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
        #endregion

        #region EQUIPEMENT
        [WebMethod]
        public void ajouteEQUIPEMENT(DEQUIPEMENT myEQUIPEMENT)
        {

            string reqSQL = "INSERT INTO EQUIPEMENT	( LIBELLE_EQP, NUM_SERIE, DATE_FAB_EQP, DATE_MISE_SERVICE_EQP, FABRIQUANT, CODE_CLIENT)VALUES	( '" + myEQUIPEMENT.LIBELLE_EQP + "', '" + myEQUIPEMENT.NUM_SERIE + "', '" + myEQUIPEMENT.DATE_FAB_EQP + "', '" + myEQUIPEMENT.DATE_MISE_SERVICE_EQP + "', '" + myEQUIPEMENT.FABRIQUANT + "', " + myEQUIPEMENT.CODE_CLIENT + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

        }

        [WebMethod]
        public void effaceEQUIPEMENT(DEQUIPEMENT myEQUIPEMENT)
        {

            string reqSQL = "DELETE FROM EQUIPEMENT WHERE (CODE_EQP=" + myEQUIPEMENT.CODE_EQP + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        [WebMethod]
        public void modifieEQUIPEMENT(DEQUIPEMENT myEQUIPEMENT)
        {

            string reqSQL = "UPDATE EQUIPEMENT SET LIBELLE_EQP='" + myEQUIPEMENT.LIBELLE_EQP + "',NUM_SERIE='" + myEQUIPEMENT.NUM_SERIE + "',DATE_FAB_EQP='" + myEQUIPEMENT.DATE_FAB_EQP + "',DATE_MISE_SERVICE_EQP='" + myEQUIPEMENT.DATE_MISE_SERVICE_EQP + "',FABRIQUANT='" + myEQUIPEMENT.FABRIQUANT + "',CODE_CLIENT=" + myEQUIPEMENT.CODE_CLIENT + " WHERE( CODE_EQP=" + myEQUIPEMENT.CODE_EQP + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }
        }


        [WebMethod]
        public DEQUIPEMENT obtenirInstanceEQUIPEMENT(DEQUIPEMENT myEQUIPEMENT)
        {
            string reqSQL = "SELECT CODE_EQP, LIBELLE_EQP, NUM_SERIE, DATE_FAB_EQP, DATE_MISE_SERVICE_EQP, FABRIQUANT, EQUIPEMENT.CODE_CLIENT, REF_CLIENT, RS_CLIENT, TEL_CLIENT		FROM EQUIPEMENT INNER JOIN CLIENT ON CLIENT.CODE_CLIENT=EQUIPEMENT.CODE_CLIENT	WHERE (CODE_EQP=" + myEQUIPEMENT.CODE_EQP + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myEQUIPEMENT.CODE_EQP = (Decimal)myReader["CODE_EQP"];

                    myEQUIPEMENT.LIBELLE_EQP = (String)myReader["LIBELLE_EQP"];

                    myEQUIPEMENT.NUM_SERIE = (String)myReader["NUM_SERIE"];

                    myEQUIPEMENT.DATE_FAB_EQP = Convert.ToDateTime(myReader["DATE_FAB_EQP"]);

                    myEQUIPEMENT.DATE_MISE_SERVICE_EQP = Convert.ToDateTime(myReader["DATE_MISE_SERVICE_EQP"]);

                    myEQUIPEMENT.FABRIQUANT = (String)myReader["FABRIQUANT"];

                    myEQUIPEMENT.CODE_CLIENT = (Decimal)myReader["CODE_CLIENT"];

                    myEQUIPEMENT.REF_CLIENT = (String)myReader["REF_CLIENT"];

                    myEQUIPEMENT.RS_CLIENT = (String)myReader["RS_CLIENT"];

                    myEQUIPEMENT.TEL_CLIENT = (String)myReader["TEL_CLIENT"];

                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myEQUIPEMENT;
        }

        [WebMethod]
        public DataTable GetEQUIPEMENT()
        {

            string reqSQL = "select * from V_EQUIPEMENT";
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
        public DataTable GetEQUIPEMENT_Client(decimal codeClt)
        {

            string reqSQL = "select * from V_EQUIPEMENT where CODE_CLIENT='" + codeClt + "'";
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
        #endregion

        #region Maintenance_EQUIPEMENT
        [WebMethod]
        public RESULT_QUERY ajouteTYPE_MAINTENANCE(DTYPE_MAINTENANCE myTYPE_MAINTENANCE)
        {
            string reqSQL = "INSERT INTO TYPE_MAINTENANCE	( LIB_MNT, CODE_UNITE, NB_JOUR, VAL_MNT)VALUES	( @LIB_MNT, @CODE_UNITE, @NB_JOUR, @VAL_MNT)";
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = reqSQL;
                cmd.Parameters.Add("@LIB_MNT", SqlDbType.NVarChar).Value = myTYPE_MAINTENANCE.LIB_MNT;
                cmd.Parameters.Add("@CODE_UNITE", SqlDbType.Decimal).Value = myTYPE_MAINTENANCE.CODE_UNITE;
                cmd.Parameters.Add("@NB_JOUR", SqlDbType.Int).Value = myTYPE_MAINTENANCE.NB_JOUR;
                cmd.Parameters.Add("@VAL_MNT", SqlDbType.Decimal).Value = myTYPE_MAINTENANCE.VAL_MNT;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(code_type_mnt) from type_maintenance";
                int code = (int)cmd.ExecuteScalar();

                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Type de maintenance ajouté avec succés.";
                res.CODE = code.ToString();
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de Type de maintenance.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public void effaceTYPE_MAINTENANCE(DTYPE_MAINTENANCE myTYPE_MAINTENANCE)
        {

            string reqSQL = "DELETE FROM TYPE_MAINTENANCE WHERE (CODE_TYPE_MNT=" + myTYPE_MAINTENANCE.CODE_TYPE_MNT + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        [WebMethod]
        public RESULT_QUERY modifieTYPE_MAINTENANCE(DTYPE_MAINTENANCE myTYPE_MAINTENANCE)
        {

            string reqSQL = "UPDATE TYPE_MAINTENANCE SET LIB_MNT=@LIB_MNT,CODE_UNITE=@CODE_UNITE,NB_JOUR=@NB_JOUR,VAL_MNT=@VAL_MNT WHERE( CODE_TYPE_MNT=@CODE_TYPE_MNT)";
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = reqSQL;
                cmd.Parameters.Add("@CODE_TYPE_MNT", SqlDbType.Int).Value = myTYPE_MAINTENANCE.CODE_TYPE_MNT;
                cmd.Parameters.Add("@LIB_MNT", SqlDbType.NVarChar).Value = myTYPE_MAINTENANCE.LIB_MNT;
                cmd.Parameters.Add("@CODE_UNITE", SqlDbType.Decimal).Value = myTYPE_MAINTENANCE.CODE_UNITE;
                cmd.Parameters.Add("@NB_JOUR", SqlDbType.Int).Value = myTYPE_MAINTENANCE.NB_JOUR;
                cmd.Parameters.Add("@VAL_MNT", SqlDbType.Decimal).Value = myTYPE_MAINTENANCE.VAL_MNT;
                cmd.ExecuteNonQuery();

                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Type de maintenance modifié avec succés.";
                res.CODE = myTYPE_MAINTENANCE.CODE_TYPE_MNT.ToString();
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de Type de maintenance.\n{0}", myErr.Message);
            }
            return res;
        }

        [WebMethod]
        public DTYPE_MAINTENANCE obtenirInstanceTYPE_MAINTENANCE(DTYPE_MAINTENANCE myTYPE_MAINTENANCE)
        {
            string reqSQL = "SELECT CODE_TYPE_MNT, LIB_MNT, CODE_UNITE, NB_JOUR, VAL_MNT		FROM TYPE_MAINTENANCE	WHERE (CODE_TYPE_MNT=" + myTYPE_MAINTENANCE.CODE_TYPE_MNT + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myTYPE_MAINTENANCE.CODE_TYPE_MNT = (Int32)myReader["CODE_TYPE_MNT"];

                    myTYPE_MAINTENANCE.LIB_MNT = (String)myReader["LIB_MNT"];

                    myTYPE_MAINTENANCE.CODE_UNITE = (Decimal)myReader["CODE_UNITE"];

                    myTYPE_MAINTENANCE.NB_JOUR = (Int32)myReader["NB_JOUR"];

                    myTYPE_MAINTENANCE.VAL_MNT = (Decimal)myReader["VAL_MNT"];


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myTYPE_MAINTENANCE;
        }

        [WebMethod]
        public DataTable GetTYPE_MAINTENANCE()
        {

            string reqSQL = "select * from TYPE_MAINTENANCE";
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

        #endregion


        #region CONFIG_MAINT_EQUIP
        public RESULT_QUERY ajouteCONFIG_EQUIP_MAINT(DCONFIG_EQUIP_MAINT myCONFIG_EQUIP_MAINT)
        {

            string reqSQL = "INSERT INTO CONFIG_EQUIP_MAINT	( CODE_EQP, CODE_TYPE_MAINT, CODE_UNITE, DATE_DEBUT_COMPTE, VAL_MAINT, COMPTEUR, VAL_MAINT_SUIV, NB_JOUR, DATE_ECHEANCE)VALUES	( @CODE_EQP, @CODE_TYPE_MAINT, @CODE_UNITE, @DATE_DEBUT_COMPTE, @VAL_MAINT, @COMPTEUR, @VAL_MAINT_SUIV, @NB_JOUR, @DATE_ECHEANCE)";
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = reqSQL;
                cmd.Parameters.Add("@CODE_EQP", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.CODE_EQP;
                cmd.Parameters.Add("@CODE_TYPE_MAINT", SqlDbType.Int).Value = myCONFIG_EQUIP_MAINT.CODE_TYPE_MAINT;
                cmd.Parameters.Add("@CODE_UNITE", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.CODE_UNITE;
                cmd.Parameters.Add("@DATE_DEBUT_COMPTE", SqlDbType.DateTime).Value = myCONFIG_EQUIP_MAINT.DATE_DEBUT_COMPTE;
                cmd.Parameters.Add("@VAL_MAINT", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.VAL_MAINT;
                cmd.Parameters.Add("@COMPTEUR", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.COMPTEUR;
                cmd.Parameters.Add("@VAL_MAINT_SUIV", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.VAL_MAINT_SUIV;
                cmd.Parameters.Add("@NB_JOUR", SqlDbType.Int).Value = myCONFIG_EQUIP_MAINT.NB_JOUR;
                cmd.Parameters.Add("@DATE_ECHEANCE", SqlDbType.DateTime).Value = myCONFIG_EQUIP_MAINT.DATE_ECHEANCE;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(CODE_CONF_MAINT) from CONFIG_EQUIP_MAINT";
                decimal code = (decimal)cmd.ExecuteScalar();

                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Maintenance ajouté avec succés.";
                res.CODE = code.ToString();
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de Type de maintenance.\n{0}", myErr.Message);
            }
            return res;
        }


        public void effaceCONFIG_EQUIP_MAINT(DCONFIG_EQUIP_MAINT myCONFIG_EQUIP_MAINT)
        {

            string reqSQL = "DELETE FROM CONFIG_EQUIP_MAINT WHERE (CODE_CONF_MAINT=" + myCONFIG_EQUIP_MAINT.CODE_CONF_MAINT + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString()));
            }
        }

        public RESULT_QUERY modifieCONFIG_EQUIP_MAINT(DCONFIG_EQUIP_MAINT myCONFIG_EQUIP_MAINT)
        {

            string reqSQL = "UPDATE CONFIG_EQUIP_MAINT SET CODE_CONF_MAINT=" + myCONFIG_EQUIP_MAINT.CODE_CONF_MAINT + ",CODE_EQP=" + myCONFIG_EQUIP_MAINT.CODE_EQP + ",CODE_TYPE_MAINT=" + myCONFIG_EQUIP_MAINT.CODE_TYPE_MAINT + ",CODE_UNITE=" + myCONFIG_EQUIP_MAINT.CODE_UNITE + ",DATE_DEBUT_COMPTE='" + myCONFIG_EQUIP_MAINT.DATE_DEBUT_COMPTE + "',VAL_MAINT=" + myCONFIG_EQUIP_MAINT.VAL_MAINT + ",COMPTEUR=" + myCONFIG_EQUIP_MAINT.COMPTEUR + ",VAL_MAINT_SUIV=" + myCONFIG_EQUIP_MAINT.VAL_MAINT_SUIV + ",NB_JOUR=" + myCONFIG_EQUIP_MAINT.NB_JOUR + ",DATE_ECHEANCE='" + myCONFIG_EQUIP_MAINT.DATE_ECHEANCE + "' WHERE( CODE_CONF_MAINT=" + myCONFIG_EQUIP_MAINT.CODE_CONF_MAINT + ")";
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = reqSQL;
                cmd.Parameters.Add("@CODE_CONF_MAINT", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.CODE_CONF_MAINT;
                cmd.Parameters.Add("@CODE_EQP", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.CODE_EQP;
                cmd.Parameters.Add("@CODE_TYPE_MAINT", SqlDbType.Int).Value = myCONFIG_EQUIP_MAINT.CODE_TYPE_MAINT;
                cmd.Parameters.Add("@CODE_UNITE", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.CODE_UNITE;
                cmd.Parameters.Add("@DATE_DEBUT_COMPTE", SqlDbType.DateTime).Value = myCONFIG_EQUIP_MAINT.DATE_DEBUT_COMPTE;
                cmd.Parameters.Add("@VAL_MAINT", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.VAL_MAINT;
                cmd.Parameters.Add("@COMPTEUR", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.COMPTEUR;
                cmd.Parameters.Add("@VAL_MAINT_SUIV", SqlDbType.Decimal).Value = myCONFIG_EQUIP_MAINT.VAL_MAINT_SUIV;
                cmd.Parameters.Add("@NB_JOUR", SqlDbType.Int).Value = myCONFIG_EQUIP_MAINT.NB_JOUR;
                cmd.Parameters.Add("@DATE_ECHEANCE", SqlDbType.DateTime).Value = myCONFIG_EQUIP_MAINT.DATE_ECHEANCE;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(CODE_CONF_MAINT) from CONFIG_EQUIP_MAINT";
                decimal code = (decimal)cmd.ExecuteScalar();

                trans.Commit();
                res.OK = true;
                res.MESSAGE = "Maintenance ajouté avec succés.";
                res.CODE = code.ToString();
            }
            catch (Exception myErr)
            {
                trans.Rollback();
                res.OK = false;
                res.MESSAGE = string.Format("Erreur lors de l'enregistrement de Type de maintenance.\n{0}", myErr.Message);
            }
            return res;
        }


        public DCONFIG_EQUIP_MAINT obtenirInstanceCONFIG_EQUIP_MAINT(DCONFIG_EQUIP_MAINT myCONFIG_EQUIP_MAINT)
        {
            string reqSQL = "SELECT CODE_CONF_MAINT, CODE_EQP, CODE_TYPE_MAINT, CODE_UNITE, DATE_DEBUT_COMPTE, VAL_MAINT, COMPTEUR, VAL_MAINT_SUIV, NB_JOUR, DATE_ECHEANCE		FROM CONFIG_EQUIP_MAINT	WHERE (CODE_CONF_MAINT=" + myCONFIG_EQUIP_MAINT.CODE_CONF_MAINT + ")";
            try
            {

                SqlCommand myCommand = new SqlCommand(reqSQL, CnxBase.myConn);
                myCommand.Transaction = CnxBase.trans;
                SqlDataReader myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {

                    myCONFIG_EQUIP_MAINT.CODE_CONF_MAINT = (Decimal)myReader["CODE_CONF_MAINT"];

                    myCONFIG_EQUIP_MAINT.CODE_EQP = (Decimal)myReader["CODE_EQP"];

                    myCONFIG_EQUIP_MAINT.CODE_TYPE_MAINT = (Int32)myReader["CODE_TYPE_MAINT"];

                    myCONFIG_EQUIP_MAINT.CODE_UNITE = (Decimal)myReader["CODE_UNITE"];

                    myCONFIG_EQUIP_MAINT.DATE_DEBUT_COMPTE = Convert.ToDateTime(myReader["DATE_DEBUT_COMPTE"]);

                    myCONFIG_EQUIP_MAINT.VAL_MAINT = (Decimal)myReader["VAL_MAINT"];

                    myCONFIG_EQUIP_MAINT.COMPTEUR = (Decimal)myReader["COMPTEUR"];

                    myCONFIG_EQUIP_MAINT.VAL_MAINT_SUIV = (Decimal)myReader["VAL_MAINT_SUIV"];

                    myCONFIG_EQUIP_MAINT.NB_JOUR = (Int32)myReader["NB_JOUR"];

                    myCONFIG_EQUIP_MAINT.DATE_ECHEANCE = Convert.ToDateTime(myReader["DATE_ECHEANCE"]);


                }
                myReader.Close();

            }
            catch (Exception myErr)
            {
                throw (new Exception(myErr.ToString() + reqSQL));
            }

            return myCONFIG_EQUIP_MAINT;
        }

        public DataTable GetCONFIG_EQUIP_MAINT()
        {

            string reqSQL = "select * from CONFIG_EQUIP_MAINT";
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
        #endregion

        #region Tarification

        [WebMethod]
        public DataTable getTRV()
        {
            DataTable dtRes = new DataTable("dtTRV");
            try
            {
                dtRes = CnxBase.GetDataTable("select * from TARIF_VENTE");
                return dtRes;
            }
            catch (Exception er)
            {
                throw er;
            }

        }

        [WebMethod]
        public DataTable getTRVByArticle(decimal codeArticle)
        {
            DataTable dtRes = new DataTable("dtTRV");
            try
            {
                dtRes = CnxBase.GetDataTable("select * from TARIF_VENTE WHERE TRV_CODE_ARTICLE=" + codeArticle);
                return dtRes;
            }
            catch (Exception er)
            {
                throw er;
            }

        }

        [WebMethod]
        public DataTable getTRVByClient(decimal CODE_CLIENT)
        {
            DataTable dtRes = new DataTable("dtTRV");
            try
            {
                dtRes = CnxBase.GetDataTable("select * from TARIF_VENTE WHERE TRV_CODE_CLIENT = " + CODE_CLIENT);
                return dtRes;
            }
            catch (Exception er)
            {
                throw er;
            }

        }

        [WebMethod]
        public RESULT_QUERY AjoutTarifVente(DTARIF_VENTE tarif)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = "INSERT INTO TARIF_VENTE (TRV_LIBELLE ,TRV_CODE_ARTICLE,TRV_CODE_CLIENT,TRV_CODE_UNITE,TRV_PRIX_HT,TRV_TX_REMISE,TRV_DEBUT_VALID ";
                cmd.CommandText += " ,TRV_FIN_VALID,TRV_DATE_CREATION,TRV_CREATEUR,TRV_DATE_MODIF,TRV_MODIFICATEUR) ";
                cmd.CommandText += "  VALUES (@TRV_LIBELLE ,@TRV_CODE_ARTICLE,@TRV_CODE_CLIENT,@TRV_CODE_UNITE,@TRV_PRIX_HT,@TRV_TX_REMISE,@TRV_DEBUT_VALID ";
                cmd.CommandText += " ,@TRV_FIN_VALID,@TRV_DATE_CREATION,@TRV_CREATEUR,@TRV_DATE_MODIF,@TRV_MODIFICATEUR) ";

                cmd.Parameters.Add("@TRV_LIBELLE", SqlDbType.NVarChar).Value = tarif.TRV_LIBELLE;
                cmd.Parameters.Add("@TRV_CODE_ARTICLE", SqlDbType.Decimal).Value = tarif.TRV_CODE_ARTICLE;
                cmd.Parameters.Add("@TRV_CODE_CLIENT", SqlDbType.Decimal).Value = tarif.TRV_CODE_CLIENT;
                cmd.Parameters.Add("@TRV_CODE_UNITE", SqlDbType.Decimal).Value = tarif.TRV_CODE_UNITE;
                cmd.Parameters.Add("@TRV_PRIX_HT", SqlDbType.Decimal).Value = tarif.TRV_PRIX_HT;
                cmd.Parameters.Add("@TRV_TX_REMISE", SqlDbType.Decimal).Value = tarif.TRV_TX_REMISE;
                cmd.Parameters.Add("@TRV_DEBUT_VALID", SqlDbType.DateTime).Value = tarif.TRV_DEBUT_VALID;
                cmd.Parameters.Add("@TRV_FIN_VALID", SqlDbType.DateTime).Value = tarif.TRV_FIN_VALID;
                cmd.Parameters.Add("@TRV_DATE_CREATION", SqlDbType.DateTime).Value = tarif.TRV_DATE_CREATION;
                cmd.Parameters.Add("@TRV_CREATEUR", SqlDbType.Decimal).Value = tarif.TRV_CREATEUR;
                cmd.Parameters.Add("@TRV_DATE_MODIF", SqlDbType.DateTime).Value = tarif.TRV_DATE_MODIF;
                cmd.Parameters.Add("@TRV_MODIFICATEUR", SqlDbType.Decimal).Value = tarif.TRV_MODIFICATEUR;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


                cmd.CommandText = "select max(TRV_ID) from TARIF_VENTE";
                res.CODE = cmd.ExecuteScalar().ToString();

                trans.Commit();


                res.OK = true;
                res.MESSAGE = "tarif ajoutée avec succès.";

            }
            catch (Exception er)
            {
                trans.Rollback();
                res.OK = false;
                res.CODE = string.Empty;
                res.MESSAGE = string.Format("Erreur lors de l'ajout de la tarif.\n{0}", er.Message);

            }
            return res;
        }


        [WebMethod]
        public RESULT_QUERY ModifTarifVente(DTARIF_VENTE tarif)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            SqlTransaction trans = CnxBase.myConn.BeginTransaction();
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = "UPDATE TARIF_VENTE SET TRV_LIBELLE=@TRV_LIBELLE ,TRV_CODE_ARTICLE=@TRV_CODE_ARTICLE,TRV_CODE_CLIENT=@TRV_CODE_CLIENT ";
                cmd.CommandText += " ,TRV_CODE_UNITE=@TRV_CODE_UNITE,TRV_PRIX_HT=@TRV_PRIX_HT  ,TRV_TX_REMISE =@TRV_TX_REMISE,TRV_DEBUT_VALID =@TRV_DEBUT_VALID ";
                cmd.CommandText += " ,TRV_FIN_VALID=@TRV_FIN_VALID,TRV_DATE_MODIF=@TRV_DATE_MODIF,TRV_MODIFICATEUR=@TRV_MODIFICATEUR WHERE (TRV_ID=@TRV_ID) ";

                cmd.Parameters.Add("@TRV_ID", SqlDbType.Decimal).Value = tarif.TRV_ID;
                cmd.Parameters.Add("@TRV_LIBELLE", SqlDbType.NVarChar).Value = tarif.TRV_LIBELLE;
                cmd.Parameters.Add("@TRV_CODE_ARTICLE", SqlDbType.Decimal).Value = tarif.TRV_CODE_ARTICLE;
                cmd.Parameters.Add("@TRV_CODE_CLIENT", SqlDbType.Decimal).Value = tarif.TRV_CODE_CLIENT;
                cmd.Parameters.Add("@TRV_CODE_UNITE", SqlDbType.Decimal).Value = tarif.TRV_CODE_UNITE;
                cmd.Parameters.Add("@TRV_PRIX_HT", SqlDbType.Decimal).Value = tarif.TRV_PRIX_HT;
                cmd.Parameters.Add("@TRV_TX_REMISE", SqlDbType.Decimal).Value = tarif.TRV_TX_REMISE;
                cmd.Parameters.Add("@TRV_DEBUT_VALID", SqlDbType.DateTime).Value = tarif.TRV_DEBUT_VALID;
                cmd.Parameters.Add("@TRV_FIN_VALID", SqlDbType.DateTime).Value = tarif.TRV_FIN_VALID;
                cmd.Parameters.Add("@TRV_DATE_MODIF", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@TRV_MODIFICATEUR", SqlDbType.Decimal).Value = tarif.TRV_MODIFICATEUR;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();



                trans.Commit();

                res.CODE = tarif.TRV_ID.ToString();
                res.OK = true;
                res.MESSAGE = "tarif modifié avec succès.";

            }
            catch (Exception er)
            {
                trans.Rollback();
                res.OK = false;
                res.CODE = string.Empty;
                res.MESSAGE = string.Format("Erreur lors de la modification du tarif.\n{0}", er.Message);

            }
            return res;
        }


        [WebMethod]
        public DataTable VerifExistTarifVente(DTARIF_VENTE tarif)
        {
            string reqSql = "SELECT * FROM TARIF_VENTE ";
            reqSql += " WHERE TRV_CODE_ARTICLE = @TRV_CODE_ARTICLE ";
            reqSql += "  AND TRV_CODE_CLIENT = @TRV_CODE_CLIENT ";
            reqSql += "   AND  TRV_CODE_UNITE=@TRV_CODE_UNITE ";
            reqSql += "  AND  TRV_ID <> @TRV_ID ";
            reqSql += " AND CONVERT(nvarchar, TRV_DEBUT_VALID, 103)= CONVERT(nvarchar, @TRV_DEBUT_VALID, 103) ";
            reqSql += " AND CONVERT(nvarchar, TRV_FIN_VALID, 103)= CONVERT(nvarchar, @TRV_FIN_VALID, 103)";
            DataTable dtTarif = new DataTable("dtTarif");
            SqlCommand cmd = CnxBase.myConn.CreateCommand();
            cmd.CommandText = reqSql;
            cmd.Parameters.Add("@TRV_CODE_ARTICLE", SqlDbType.Decimal).Value = tarif.TRV_CODE_ARTICLE;
            cmd.Parameters.Add("@TRV_CODE_CLIENT", SqlDbType.Decimal).Value = tarif.TRV_CODE_CLIENT;
            cmd.Parameters.Add("@TRV_CODE_UNITE", SqlDbType.Decimal).Value = tarif.TRV_CODE_UNITE;
            cmd.Parameters.Add("@TRV_DEBUT_VALID", SqlDbType.DateTime).Value = tarif.TRV_DEBUT_VALID;
            cmd.Parameters.Add("@TRV_FIN_VALID", SqlDbType.DateTime).Value = tarif.TRV_FIN_VALID;
            cmd.Parameters.Add("@TRV_ID", SqlDbType.Decimal).Value = tarif.TRV_ID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.FillSchema(dtTarif, SchemaType.Source);
            da.Fill(dtTarif);

            return dtTarif;

        }

        #endregion Tarficiation


        #region Famille Comptable
        [WebMethod]
        public DataTable getFAM_COMPTA()
        {
            DataTable dtRes = new DataTable("dtFAC");
            try
            {
                dtRes = CnxBase.GetDataTable("select * from FAM_COMPTA");
                return dtRes;
            }
            catch (Exception er)
            {
                throw er;
            }

        }
        #endregion Famille Comptable

    }



    [Serializable]
    public class RESULT_QUERY
    {
        public string CODE = "";
        public bool OK = true;
        public string MESSAGE = "";
    }

    [Serializable]
    public class RESULTAT_UTILISATEUR
    {
        public bool IDENTIFIER = false;
        public string FONCTION = "";
        public string MESSAGE = "";

        public bool COMMANDE_CLIENT = false;
        public bool COMMANDE_FOURNISSEUR = false;
        public bool FACTURE_CLIENT = false;
        public bool FACTURE_FOURNISSEUR = false;
        public bool COMPTE_USER = false;
        public bool AJOUT_STOCK = false;
        public bool CONSULT_STOCK = false;

    }

    [Serializable]
    public class DUNITE_ARTICLE
    {
        protected decimal _CODE_UNITE;
        protected string _LIB_UNITE;



        public virtual decimal CODE_UNITE
        {
            get
            {
                return _CODE_UNITE;
            }
            set
            {
                _CODE_UNITE = value;
            }
        }


        public virtual string LIB_UNITE
        {
            get
            {
                return _LIB_UNITE;
            }
            set
            {
                _LIB_UNITE = value;
            }
        }
    }


    [Serializable]
    public class DTVA
    {
        protected decimal _CODE_TVA;
        protected string _TVA_LIBELLE;



        public virtual decimal CODE_TVA
        {
            get
            {
                return _CODE_TVA;
            }
            set
            {
                _CODE_TVA = value;
            }
        }


        public virtual string TVA_LIBELLE
        {
            get
            {
                return _TVA_LIBELLE;
            }
            set
            {
                _TVA_LIBELLE = value;
            }
        }
    }
}
