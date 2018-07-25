using System;
using System.Collections.Generic;
using System.Text;
using CHM_GESTION_COMERCIALE;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Runtime;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace CHM_SERVER
{    
    class CHM_GESTION_COM : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_GESTION 
    {
        CHM_CLIENT client=new ICLIENT();
        CHM_ARTICLE article = new CHM_ARTICLE_DEF();
        CHM_COMMANDE cmd = new CHM_COMMANDE_DEF();
        CHM_FONCTIONNALITE fct = new CHM_FONCTION_DEF();
        CHM_FOURNISSEUR fournisseur = new CHM_FOURNISSEUR_DEF();
        CHM_EMPLOYE employe = new CHM_EMPLOYE_DEF();
        CHM_CATEGORIE_ARTICLE categ = new CHM_CATEGORIE_ARTICLE_DEF();
        CHM_MAGAZIN mag = new CHM_MAGAZIN_DEF();
        CHM_SOCIETE societe = new CHM_SOCIETE_DEF();
        CHM_UTILISATEUR utilisateur = new CHM_UTILISATEUR_DEF();
        CHM_BON_LIVRAISON bon_livraison=new CHM_BON_LIVRAISON_DEF();
        CHM_STOCK stock = new CHM_STOCK_DEF();
        CHM_COMPTE_CLIENT compte = new CHM_COMPTE_CLIENT_DEF();
        CHM_FACTURE facture = new CHM_FACTURE_DEF();
        CHM_REGLEMENT reglement = new CHM_REGLEMENT_DEF();
        CHM_DEVI devi = new CHM_DEVI_DEF();
        CHM_BON_RECEP_FOURNISSEUR_DEF br = new CHM_BON_RECEP_FOURNISSEUR_DEF();
        CHM_BRETOUR_CLIENT_DEF bretour_cl = new CHM_BRETOUR_CLIENT_DEF();
        CHM_INVENTAIRE_DEF inventaire = new CHM_INVENTAIRE_DEF();
        
        public static string _workstation="";

        #region CHM_GESTION Membres

        public string Workstation
        {
            get
            {
                return _workstation;
            }
            set
            {
                _workstation = value;
            }
        }

        
        public CHM_CLIENT P_CLIENT
        {
            get 
            {
                return client;
            }
        }

        public CHM_ARTICLE P_ARTICLE
        {
            get { return article; }
        }

        public CHM_COMMANDE P_COMMANDE
        {
            get { return cmd; }
        }

        public CHM_EMPLOYE P_EMPLOYE
        {
            get { return employe; }
        }

        public CHM_FONCTIONNALITE P_FONCTION
        {
            get { return fct; }
        }

        public CHM_FOURNISSEUR P_FOURNISSEUR
        {
            get { return fournisseur; }
        }     
        
        public CHM_CATEGORIE_ARTICLE P_CATEGORIE
        {
            get { return categ; }
        }

        public CHM_MAGAZIN P_MAGAZIN
        {
            get { return mag; }
        }
                
        public CHM_SOCIETE P_SOCIETE
        {
            get
            {
                return societe;
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }
                
        public CHM_UTILISATEUR P_UTILISATEUR
        {
            get { return utilisateur; }
        }

        public CHM_BON_LIVRAISON P_BON_LIVRAISON
        {
            get { return bon_livraison; }
        }

        public CHM_STOCK P_STOCK
        {
            get { return stock; }
        }

        public CHM_COMPTE_CLIENT P_COMPTE_CLIENT
        {
            get
            {
                return compte;
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public CHM_FACTURE P_FACTURE
        {
            get { return facture; }
        }

        public CHM_REGLEMENT P_REGLEMENT
        {
            get { return reglement; }
        }

        public CHM_DEVI P_DEVI
        {
            get
            {
                return devi;
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public CHM_BON_RECEPTION_FOURNISSEUR P_BR_FR
        {
            get { return br; }
        }

        public CHM_BRETOUR_CLIENT P_BRETOUR_CL
        {
            get { return bretour_cl; }
        }

        public INVENTAIRE P_INVENTAIRE
        {
            get { return inventaire; }
        }

        #endregion

        
    }

    

    class ICLIENT : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_CLIENT
    {
        #region CHM_CLIENT Membres

        public RESULT_QUERY DELETE_CLIENT(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;
                SqlCommand cmd = new SqlCommand("DELETE FROM CLIENT WHERE  (CODE_CLIENT= @CODE_CLIENT)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
                
                cmd.ExecuteNonQuery();
                res.MESSAGE = "Delete done.\n „ «·Õ–›.";
            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        public RESULT_QUERY INSERT_CLIENT(string CODE, string REF, string RS, string ADRESSE, string CP, string VILLE, string PAYS, string TEL, string TEL2, string FAX, string EMAIL, bool EXO, string ATTEST_EXO, string CODE_DOUANE, string CODE_TVA, bool ETAT_CLIENT, bool COMPTE, decimal MAX_CREDIT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans =CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
                cmd.Transaction = sqlTrans;
            try
            {
                cmd.CommandText = "SELECT     ISNULL(MAX(CODE_CLIENT), 0) + 1 FROM         CLIENT";
                    CODE = ((decimal)cmd.ExecuteScalar()).ToString();
                    res.CODE = CODE;

                    cmd.CommandText = "INSERT INTO CLIENT (CODE_CLIENT, REF_CLIENT, RS_CLIENT, ADRESSE_CLIENT, CP_CLIENT, VILLE_CLIENT, PAYS_CLIENT, TEL_CLIENT, TEL2_CLIENT, FAX_CLIENT, EMAIL_CLIENT, EXO_CLIENT, ATTEST_EXO_CLIENT, CODE_DOUANE_CLIENT, CODE_TVA_CLIENT, ETAT_CLIENT, MAX_CREDIT) VALUES     (@CODE_CLIENT, @REF_CLIENT, @RS_CLIENT, @ADRESSE_CLIENT, @CP_CLIENT, @VILLE_CLIENT, @PAYS_CLIENT, @TEL_CLIENT, @TEL2_CLIENT, @FAX_CLIENT, @EMAIL_CLIENT, @EXO_CLIENT, @ATTEST_EXO_CLIENT, @CODE_DOUANE_CLIENT, @CODE_TVA_CLIENT, @ETAT_CLIENT,  @MAX_CREDIT)";
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
                //cmd.Parameters.Add("@COMPTE", SqlDbType.Bit).Value = COMPTE;
                cmd.Parameters.Add("@MAX_CREDIT", SqlDbType.Decimal).Value = MAX_CREDIT;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                    sqlTrans.Commit();
                res.MESSAGE = "The client is saved succesfully.\n „ Õ›Ÿ »Ì«‰«  «·“»Ê‰ »‰Ã«Õ";
            }
            catch (Exception error)
            {
                sqlTrans.Rollback();
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

        public System.Data.DataTable LOAD_CLIENT(string CODE)
        {           
            SqlDataAdapter client_da = new SqlDataAdapter("SELECT * FROM CLIENT WHERE CODE_CLIENT= @CODE_CLIENT", CONNECTION_PARAM.cnx);
            client_da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
            DataTable client_dt = new DataTable(); 
            client_da.FillSchema(client_dt, SchemaType.Source);
            client_da.Fill(client_dt);
            return client_dt;
        }

        public System.Data.DataTable SEARCH_CLIENT(string INDICE)
        {
            SqlDataAdapter client_da = new SqlDataAdapter("SELECT     * FROM CLIENT WHERE (RS_CLIENT like '%" + INDICE + "%') OR (ADRESSE_CLIENT like '%" + INDICE + "%') OR ( REF_CLIENT like '%" + INDICE + "%') OR ( EMAIL_CLIENT like '%" + INDICE + "%')", CONNECTION_PARAM.cnx);
            DataTable client_dt = new DataTable();            
            client_da.FillSchema(client_dt, SchemaType.Source);
            client_da.Fill(client_dt);
            return client_dt;
        }

        public System.Data.DataTable SELECT_ALL_CLIENTS()
        {
            //SqlDataAdapter client_da = new SqlDataAdapter("SELECT * FROM CLIENT", CONNECTION_PARAM.cnx);
            SqlDataAdapter client_da = new SqlDataAdapter("SELECT * FROM CLIENT left outer join COMPTE_CLIENT on CLIENT.CODE_CLIENT=COMPTE_CLIENT.CODE_CLIENT", CONNECTION_PARAM.cnx);
            DataTable client_dt = new DataTable();
            client_da.FillSchema(client_dt, SchemaType.Source);
            client_da.Fill(client_dt);
            return client_dt;
            
        }

        public RESULT_QUERY UPDATE_CLIENT(string CODE, string REF, string RS, string ADRESSE, string CP, string VILLE, string PAYS, string TEL, string TEL2, string FAX, string EMAIL, bool EXO, string ATTEST_EXO, string CODE_DOUANE, string CODE_TVA, bool ETAT_CLIENT, decimal MAX_CREDIT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;
                using (SqlCommand cmd = new SqlCommand("UPDATE    CLIENT SET               REF_CLIENT =@REF_CLIENT, RS_CLIENT =@RS_CLIENT, ADRESSE_CLIENT =@ADRESSE_CLIENT, CP_CLIENT =@CP_CLIENT , VILLE_CLIENT=@VILLE_CLIENT, PAYS_CLIENT=@PAYS_CLIENT, TEL_CLIENT =@TEL_CLIENT, TEL2_CLIENT =@TEL2_CLIENT, FAX_CLIENT =@FAX_CLIENT , EMAIL_CLIENT =@EMAIL_CLIENT,   EXO_CLIENT =@EXO_CLIENT, ATTEST_EXO_CLIENT =@ATTEST_EXO_CLIENT, CODE_DOUANE_CLIENT =@CODE_DOUANE_CLIENT, CODE_TVA_CLIENT =@CODE_TVA_CLIENT, ETAT_CLIENT =@ETAT_CLIENT, MAX_CREDIT=@MAX_CREDIT WHERE  (CODE_CLIENT=@CODE_CLIENT)", CONNECTION_PARAM.cnx))
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
                    cmd.ExecuteNonQuery();
                }
                res.MESSAGE = "The client is saved succesfully.\n „ Õ›Ÿ »Ì«‰«  «·“»Ê‰ »‰Ã«Õ";
                
            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        


        public string NEW_CODE(int nbCHIFRE)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT     ISNULL(MAX(CODE_CLIENT), 0) + 1 FROM         CLIENT", CONNECTION_PARAM.cnx))
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

       

        

        public DataTable SELECT_COMMANDE_CLIENT(string CODE)
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        

        public void BLOQUER_CLIENT(string CODE_CLIENT)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
            }
        }

        public DataTable LOAD_COMPTE(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        

        public void UPDATE_ETAT_COMPTE(string CODE_CLIENT)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE CLIENT SET COMPTE=@COMPTE WHERE (CODE_CLIENT=@CODE_CLIENT)";
                cmd.Parameters.Add("@COMPTE", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
            }
        }

        


        public DataTable select_b_liv_client(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable select_facture(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt; 
        }

        #endregion
    }

    class CHM_EMPLOYE_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_EMPLOYE
    {
        #region CHM_EMPLOYE Membres

        public RESULT_QUERY DELETE_EMPLOYE(string CODE)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;

            try
            {
                res.CODE = CODE;
                cmd.CommandText="DELETE FROM EMPLOYE WHERE  (CODE_EMPLOYE= @CODE_EMPLOYE)";
                cmd.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Deleted with succes . \n  „ «·Õ–› »‰Ã«Õ";

            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;                
            }
            return res;
            
        }

        public RESULT_QUERY INSERT_EMPLOYE(string CODE, string Nom, string PRENOM, DateTime DATE_NAIS, string ADRESSE, string TEL, string EMAIL, DateTime DATE_EMB, bool ETAT, string AGENCE)
        {
            
            
            decimal code_ag;
           
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;

            try
            {
                cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE RS_SOCIETE LIKE'" + AGENCE + "'";
                code_ag = (decimal)cmd.ExecuteScalar();         
                   
                                 
                cmd.CommandText="SELECT     ISNULL(MAX(CODE_EMPLOYE), 0) + 1  FROM         EMPLOYE";
                CODE = ((decimal)cmd.ExecuteScalar()).ToString();

                res.CODE = CODE;

                cmd.CommandText="INSERT INTO EMPLOYE (CODE_EMPLOYE, NOM_EMPLOYE, PRENOM_EMPLOYE, DATE_NAIS_EMPLOYE, ADRESSE_EMPLOYE, TEL_EMPLOYE, EMAIL_EMPLOYE, DATE_EMBAUCHE_EMPLOYE, ETAT_EMPLOYE, CODE_SOCIETE) VALUES     (@CODE_EMPLOYE, @NOM_EMPLOYE, @PRENOM_EMPLOYE, @DATE_NAIS_EMPLOYE, @ADRESSE_EMPLOYE, @TEL_EMPLOYE, @EMAIL_EMPLOYE, @DATE_EMBAUCHE_EMPLOYE, @ETAT_USER, @CODE_SOCIETE)";
                cmd.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@NOM_EMPLOYE", SqlDbType.NVarChar).Value = Nom ;
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
                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        public DataTable LOAD_EMPLOYE(string CODE)
        {
            SqlDataAdapter EMPLOYE_da = new SqlDataAdapter("SELECT * FROM EMPLOYE WHERE CODE_EMPLOYE= @CODE_EMPLOYE", CONNECTION_PARAM.cnx);
            EMPLOYE_da.SelectCommand.Parameters.Add("@CODE_EMPLOYE", SqlDbType.Decimal).Value = CODE;
            DataTable EMPLOYE_dt = new DataTable();
            EMPLOYE_da.FillSchema(EMPLOYE_dt, SchemaType.Source);
            EMPLOYE_da.Fill(EMPLOYE_dt);
            return EMPLOYE_dt;
        }

        public DataTable SEARCH_EMPLOYE(string INDICE)
        {
            SqlDataAdapter EMPLOYE_da = new SqlDataAdapter("SELECT     * FROM EMPLOYE WHERE (NOM_EMPLOYE like '%" + INDICE + "%') OR (PRENOM_EMPLOYE like '%" + INDICE + "%') ", CONNECTION_PARAM.cnx);
            DataTable EMPLOYE_dt = new DataTable();
            EMPLOYE_da.FillSchema(EMPLOYE_dt, SchemaType.Source);
            EMPLOYE_da.Fill(EMPLOYE_dt);
            return EMPLOYE_dt;
        }

        public DataTable SELECT_ALL_EMPLOYES()
        {
            SqlDataAdapter EMPLOYE_da = new SqlDataAdapter("SELECT * FROM EMPLOYE", CONNECTION_PARAM.cnx);
            DataTable EMPLOYE_dt = new DataTable();
            EMPLOYE_da.FillSchema(EMPLOYE_dt, SchemaType.Source);
            EMPLOYE_da.Fill(EMPLOYE_dt);
            return EMPLOYE_dt;
            
        }

        public RESULT_QUERY UPDATE_EMPLOYE(string CODE, string Nom, string PRENOM, DateTime DATE_NAIS, string ADRESSE, string TEL, string EMAIL, DateTime DATE_EMB, bool ETAT, string AGENCE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            
            
            decimal code_ag;
           try
            {
            
                cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE RS_SOCIETE LIKE'" + AGENCE + "'";
                code_ag = (decimal)cmd.ExecuteScalar();
            
                cmd.CommandText= "UPDATE EMPLOYE SET  NOM_EMPLOYE=@NOM_EMPLOYE, PRENOM_EMPLOYE=@PRENOM_EMPLOYE, DATE_NAIS_EMPLOYE=@DATE_NAIS_EMPLOYE, ADRESSE_EMPLOYE=@ADRESSE_EMPLOYE, TEL_EMPLOYE=@TEL_EMPLOYE, EMAIL_EMPLOYE=@EMAIL_EMPLOYE, DATE_EMBAUCHE_EMPLOYE=@DATE_EMBAUCHE_EMPLOYE,  ETAT_EMPLOYE=@ETAT_EMPLOYE, CODE_SOCIETE=@CODE_SOCIETE WHERE (CODE_EMPLOYE=@CODE_EMPLOYE)";
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
                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
                
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        


        public string NEW_CODE(int nbCHIFRE)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT     ISNULL(MAX(CODE_EMPLOYE), 0) + 1 FROM         EMPLOYE", CONNECTION_PARAM.cnx))
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
    }

    class CHM_COMPTE_CLIENT_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_COMPTE_CLIENT
    {
        #region CHM_COMPTE_CLIENT Membres

        public RESULT_QUERY CREER_COMPTE_CLIENT(string CODE_CLIENT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt=new DataTable();
            double credit = 0;
            SqlDataAdapter da = new SqlDataAdapter("SELECT CREDIT FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            
           
            
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {         
                 
                

                

                cmd.CommandText = "SELECT ISNULL(MAX(CODE_COMPTE_CLIENT) , 0) + 1 FROM COMPTE_CLIENT";
                decimal code_compte = (decimal)cmd.ExecuteScalar();
                res.CODE = code_compte.ToString();

                string num_compte = "CMP00" + code_compte.ToString() + "2010";

                cmd.CommandText = "INSERT INTO COMPTE_CLIENT(CODE_COMPTE_CLIENT, NUM_COMPTE_CLIENT, TOTAl_CREDIT_CLT, TOTAL_PAYE_CLT, CODE_CLIENT) VALUES (@CODE_COMPTE_CLIENT, @NUM_COMPTE_CLIENT, @TOTAL_CREDIT_CLT, @TOTAL_PAYE_CLT, @CODE_CLIENT)";
                cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = code_compte;
                cmd.Parameters.Add("@NUM_COMPTE_CLIENT", SqlDbType.NVarChar).Value = num_compte;
                cmd.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = 0;
                cmd.Parameters.Add("@TOTAL_PAYE_CLT" , SqlDbType.Decimal).Value = 0;
                cmd.Parameters.Add("@CODE_CLIENT"   , SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Account created with succes.  „  ≈÷«›… «·Õ”«» »‰Ã«Õ";
                
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand cmdcr = new SqlCommand("UPDATE COMPTE_CLIENT SET TOTAL_CREDIT_CLT=TOTAL_CREDIT_CLT+@TOTAL_CREDIT_CLT WHERE (CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT)", CONNECTION_PARAM.cnx))
                {
                    cmdcr.Parameters.Add("@TOTAL_CREDIT_CLT", SqlDbType.Decimal).Value = Convert.ToDecimal(dr["CREDIT"]);
                    cmdcr.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = res.CODE;
                    cmdcr.ExecuteNonQuery();
                    cmdcr.Parameters.Clear();
                }
            }
            return res;
        }

        public DataTable SELECT_ALL_COMPTES_CLIENTS()
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public RESULT_QUERY UPDATE_COMPTE_CLIENT(string CODE_COMPTE_CLIENT, decimal TOTAL_PAYE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt;
            decimal credit = (decimal)0;
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        


        public DataTable LOAD_COMPTE_CLIENT(string CODE_CLIENT)
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable SELECT_COMPTE_NON_REGLE()
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CREDIT > 0", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable SELECT_REGLEMENTS(string CODE_COMPTE_CLIENT)
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        


        public void actualiser_compte(string CODE_CLIENT)
        {
            using (DataTable dt = new DataTable())
            {
                decimal credit = 0;
                SqlDataAdapter da = new SqlDataAdapter("SELECT CREDIT FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx);
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    credit += (decimal)dr["CREDIT"];
                }
                SqlCommand cmdc = new SqlCommand("SELECT CODE_COMPTE_CLIENT CLIENT FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx);
                cmdc.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                string CODE_COMPTE_CLIENT = cmdc.ExecuteScalar().ToString();
                decimal paye = 0;
                DataTable dtp = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter("SELECT MONTANT_REG_CLIENT FROM REGLEMENT_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CONNECTION_PARAM.cnx);
                dap.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                dap.FillSchema(dtp, SchemaType.Source);
                dap.Fill(dtp);
                foreach (DataRow dr in dtp.Rows)
                {
                    paye += (decimal)dr["MONTANT_REG_CLIENT"];
                }
                SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                }
            }
        }

        


        public DataTable LOAD_COMPTE(string CODE_COMPTE_CLIENT)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPTE_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        #endregion
    }

    class CHM_FONCTION_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_FONCTIONNALITE
    {
        #region CHM_FONCTIONNALITE Membres

        public string DELETE_FONCTION(string CODE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM FONCTIONALITE_EMPLOYE WHERE  (CODE_FONCTION= @CODE_FONCTION)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string INSERT_FONCTION(string CODE, string LABEL)
        {
            try
            {
                using (SqlCommand cmd_code = new SqlCommand("SELECT     ISNULL(MAX(CODE_FONCTION), 0) + 1  FROM         FONCTIONALITE_EMPLOYE", CONNECTION_PARAM.cnx))
                {
                    CODE = ((decimal)cmd_code.ExecuteScalar()).ToString();
                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO FONCTIONALITE_EMPLOYE (CODE_FONCTION, LIB_FONCTION) VALUES     (@CODE_FONCTION, @LIB_FONCTION)", CONNECTION_PARAM.cnx))
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

        public DataTable LOAD_FONCTION(string CODE)
        {
            using (SqlDataAdapter FONCTION_da = new SqlDataAdapter("SELECT * FROM FONCTIONALITE_EMPLOYE WHERE CODE_FONCTION= @CODE_FONCTION", CONNECTION_PARAM.cnx))
            {
                FONCTION_da.SelectCommand.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;
                DataTable FONCTION_dt = new DataTable();
                FONCTION_da.FillSchema(FONCTION_dt, SchemaType.Source);
                FONCTION_da.Fill(FONCTION_dt);
                return FONCTION_dt;
            }
        }

        public DataTable SELECT_ALL_FONTIONS()
        {
            using (SqlDataAdapter FONCTION_da = new SqlDataAdapter("SELECT CODE_FONCTION, LIB_FONCTION FROM FONCTIONALITE_EMPLOYE", CONNECTION_PARAM.cnx))
            {
                DataTable FONCTION_dt = new DataTable();
                FONCTION_da.FillSchema(FONCTION_dt, SchemaType.Source);
                FONCTION_da.Fill(FONCTION_dt);
                return FONCTION_dt;
            }
        }

        public string UPDATE_FONCTION(string CODE, string LABEL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE FONCTIONALITE_EMPLOYE SET  LIB_FONCTION=@LIB_FONCTION WHERE (CODE_FONCTION=@CODE_FONCTION)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_FONCTION", SqlDbType.Decimal).Value = CODE;
                cmd.Parameters.Add("@LIB_FONCTION", SqlDbType.NVarChar).Value = LABEL;



                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        


        public string NEW_CODE(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }

    class CHM_BON_LIVRAISON_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_BON_LIVRAISON
    {
        #region CHM_BON_LIVRAISON Membres

        public DataTable LOAD_COMMANDE(string CODE_COMMANDE)
        {
            DataTable dt = new DataTable();              
                                   
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_COMMANDE=@CODE_COMMANDE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable LOAD_LG_BON_LIVRAISON(string CODE_COMMANDE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public RESULT_QUERY SAVE(DateTime DATE_B_LIV, string CODE_CLIENT, string CODE_COMMANDE, string CODE_USER, DataTable dt_lg_b_liv)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            res.MESSAGE = "!";
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_COMMANDE) + 1 FROM         SOCIETE";
                decimal NUM_COMMANDE = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_COMMANDE, '') FROM         SOCIETE";
                string PREFIX2_COMMANDE = (string)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_COMMANDE = NUM_COMMANDE +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_B_LIV = "BL_SF" + NUM_COMMANDE.ToString() + PREFIX2_COMMANDE;

                res.CODE = CODE_B_LIV;

                decimal som = 0;
                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    som += (decimal)dr["QTE_LIGNE_COMMANDE"]*(decimal)dr["PRIX_HT_COMMANDE"];                  
                    
                }

                cmd.CommandText = "INSERT INTO BON_DE_LIVRAISON(CODE_B_LIV, DATE_B_LIV, CODE_CLIENT, CODE_COMMANDE, CODE_USER, SOMME_B_LIV,FACTURED, PREPARED, LIVRE) VALUES     (@CODE_B_LIV, @DATE_B_LIV, @CODE_CLIENT, @CODE_COMMANDE, @CODE_USER , @SOMME_B_LIV,@FACTURED, @PREPARED, @LIVRE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV; res.MESSAGE = "erreur code commande";
                cmd.Parameters.Add("@DATE_B_LIV", SqlDbType.DateTime).Value = DATE_B_LIV;
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "erreur insertion code user";
                cmd.Parameters.Add("@SOMME_B_LIV", SqlDbType.Decimal).Value = som;
                cmd.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "False";
                cmd.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "False";
                cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_BON_LIVRAISON( CODE_B_LIV, CODE_ARTICLE, QTE_LIGNE_B_LIV, PRIX_HT_B_LIV, TVA_B_LIV, PRIX_TOTAL_HT, PRIX_U_TTC, PRIX_TOTAL_TTC ) VALUES     (@CODE_B_LIV, @CODE_ARTICLE, @QTE_LIGNE_B_LIV, @PRIX_HT_B_LIV, @TVA_B_LIV, @PRIX_TOTAL_HT, @PRIX_U_TTC, @PRIX_TOTAL_TTC)";
                    cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE_LIGNE_B_LIV", SqlDbType.Decimal).Value = dr["QTE_LIGNE_COMMANDE"];
                    cmd.Parameters.Add("@PRIX_HT_B_LIV", SqlDbType.Decimal).Value = dr["PRIX_HT_COMMANDE"];
                    cmd.Parameters.Add("@TVA_B_LIV", SqlDbType.Decimal).Value = dr["TVA_COMMANDE"];
                    cmd.Parameters.Add("@PRIX_TOTAL_HT", SqlDbType.Decimal).Value = (decimal)dr["QTE_LIGNE_COMMANDE"] * (decimal)dr["PRIX_HT_COMMANDE"];
                    cmd.Parameters.Add("@PRIX_U_TTC", SqlDbType.Decimal).Value = (decimal)dr["PRIX_HT_COMMANDE"] * (1 + (decimal)dr["TVA_COMMANDE"] / 100);
                    cmd.Parameters.Add("@PRIX_TOTAL_TTC", SqlDbType.Decimal).Value = ((decimal)dr["PRIX_HT_COMMANDE"] * (1 + (decimal)dr["TVA_COMMANDE"] / 100)) * (decimal)dr["QTE_LIGNE_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    
                }
                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    cmd.CommandText = "UPDATE ARTICLE SET QTE_ARTICLE=QTE_ARTICLE-@QTE WHERE CODE_ARTICLE=@CODE_ARTICLE";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear(); 
                }
                


                sqltrans.Commit();

                res.MESSAGE = "The order is saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }

            return res;
        }

        public DataTable SELECT_CLIENT(string CODE_CLIENT)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        


        public DataTable LOAD_SCHEMA_LG_BON_LIVRAISON()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LG_BON_LIVRAISON.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV, LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV FROM         LG_BON_LIVRAISON INNER JOIN ARTICLE ON LG_BON_LIVRAISON.CODE_ARTICLE = ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
            }
            dt.Columns.Add("PRIX_TTC_LG_COMMANDE", typeof(decimal));
            dt.Columns.Add("PRIX_TTC_TOTAL", typeof(decimal));
            dt.Columns.Add("PRIX_HT_TOTAL", typeof(decimal));

            return dt;
        }

        

        public DataTable[] PRINT(string CODE_B_LIV)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("", CONNECTION_PARAM.cnx))
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

        


        public DataTable SELECT_B_LIV_FACTURE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE FACTURED=@FACTURED", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "True";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable SELECT_B_LIV_LIVRE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE LIVRE=@LIVRE", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "True";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SELECT_B_LIV_NON_FACTURE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE FACTURED=@FACTURED", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "False";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SELECT_B_LIV_NON_LIVRE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE LIVRE=@LIVRE", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@LIVRE", SqlDbType.Bit).Value = "False";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SELECT_B_LIV_NON_PREPARE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE PREPARED=@PREPARED", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "False";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SELECT_B_LIV_PREPARE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE PREPARED=@PREPARED", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@PREPARED", SqlDbType.Bit).Value = "True";
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public void UPDATE_FACTURE(string CODE_B_LIV, bool param)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
            }
        }

        public void UPDATE_LIVRE(string CODE_B_LIV)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
            }
        }

        public void UPDATE_PREPARE(string CODE_B_LIV)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
            }
        }

        
        


        public DataTable SELECT_ALL_BON_LIVRAISON()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON ", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }       
        
        public DataTable RECHERCHE(string param)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE (CODE_B_LIV LIKE '%" + param + "%') OR (DATE_B_LIV LIKE '%" + param + "%') OR (CODE_COMMANDE LIKE '%" + param + "%') ", CONNECTION_PARAM.cnx);            
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        

        #endregion
    }

    class CHM_ARTICLE_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_ARTICLE
    {  
        #region CHM_ARTICLE Membres

        public RESULT_QUERY DELETE_ARTICLE(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;

                SqlCommand cmd = new SqlCommand("DELETE FROM ARTICLE WHERE     (CODE_ARTICLE = @CODE_ARTICLE)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE;
                cmd.ExecuteNonQuery();

                res.MESSAGE = "Deleted with succes.\n „ «·Õ–› »‰Ã«Õ";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        public RESULT_QUERY INSERT_ARTICLE(string CODE_ARTICLE, string REF_ARTICLE, string DESIGNATION_ARTICLE, string MARQUE_ARTICLE, string DESCRIPTION_ARTICLE, string CODE_BARRE_ARTICLE, decimal QTE_ARTICLE, string UNITE, decimal QTE_MIN_ARTICLE, byte[] PHOTO_ARTICLE, decimal PRIX_HT_A_ARTICLE, decimal PRIX_HT_V_ARTICLE, decimal TVA_ARTICLE, decimal MAX_REMISE, bool ETAT_ARTICLE, string CATEGORIE, string MAGAZIN, string FOURNISSEUR, decimal PRIX_SOLDE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
                cmd.Transaction = sqlTrans;

                try
                {
                    cmd.CommandText = "SELECT     ISNULL(MAX(CODE_ARTICLE), 0) + 1 FROM         ARTICLE";
                    CODE_ARTICLE = ((decimal)cmd.ExecuteScalar()).ToString();
                    res.CODE = CODE_ARTICLE;

                    cmd.CommandText = "SELECT RS_FOURNISSEUR FROM FOURNISSEUR WHERE CODE_FOURNISSEUR LIKE'" + FOURNISSEUR + "'";
                    string code_fournisseur = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "SELECT LIB_CATEG FROM CATEGORIE WHERE CODE_CATEG LIKE'" + CATEGORIE + "'";
                    string code_categorie = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "SELECT NOM_MAG FROM MAGAZIN WHERE CODE_MAG LIKE'" + MAGAZIN + "'";
                    string code_magazin = (string)cmd.ExecuteScalar();

                    cmd.Parameters.Clear();

                    cmd.CommandText = "INSERT INTO ARTICLE(CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, DESCRIPTION_ARTICLE, CODE_BARRE_ARTICLE, QTE_ARTICLE, UNITE_QTE_ARTICLE, QTE_MIN_ARTICLE, PHOTO_ARTICLE, PRIX_HT_A_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR, MAX_REMISE, PRIX_SOLDE, CODE_BARRE_ARTICLE_SOLDE) VALUES     (@CODE_ARTICLE,@REF_ARTICLE,@DESIGNATION_ARTICLE,@MARQUE_ARTICLE,@DESCRIPTION_ARTICLE,@CODE_BARRE_ARTICLE,@QTE_ARTICLE,@UNITE_QTE_ARTICLE,@QTE_MIN_ARTICLE,@PHOTO_ARTICLE,@PRIX_HT_A_ARTICLE, @PRIX_HT_V_ARTICLE,@TVA_ARTICLE,@ETAT_ARTICLE, @CODE_CATEG, @CODE_MAG, @CODE_FOURNISSEUR, @LIB_CATEG, @NOM_MAG, @RS_FOURNISSEUR, @MAX_REMISE, @PRIX_SOLDE, @CODE_BARRE_ARTICLE_SOLDE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE_ARTICLE;
                    cmd.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
                    cmd.Parameters.Add("@DESIGNATION_ARTICLE", SqlDbType.NVarChar).Value = DESIGNATION_ARTICLE;
                    cmd.Parameters.Add("@MARQUE_ARTICLE", SqlDbType.NVarChar).Value = MARQUE_ARTICLE;
                    cmd.Parameters.Add("@DESCRIPTION_ARTICLE", SqlDbType.NVarChar).Value = DESCRIPTION_ARTICLE;
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE;
                    cmd.Parameters.Add("@QTE_ARTICLE", SqlDbType.Decimal).Value = QTE_ARTICLE;
                    cmd.Parameters.Add("@UNITE_QTE_ARTICLE", SqlDbType.NVarChar).Value = UNITE;
                    cmd.Parameters.Add("@QTE_MIN_ARTICLE", SqlDbType.Decimal).Value = QTE_MIN_ARTICLE;
                    cmd.Parameters.Add("@PHOTO_ARTICLE", SqlDbType.Image).Value = (PHOTO_ARTICLE != null) ? PHOTO_ARTICLE : (object)DBNull.Value;
                    cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_A_ARTICLE;
                    cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_V_ARTICLE;
                    cmd.Parameters.Add("@TVA_ARTICLE", SqlDbType.Decimal).Value = TVA_ARTICLE;
                    cmd.Parameters.Add("@ETAT_ARTICLE", SqlDbType.Bit).Value = ETAT_ARTICLE;
                    cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CATEGORIE;
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = MAGAZIN;
                    cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = FOURNISSEUR;
                    cmd.Parameters.Add("@LIB_CATEG", SqlDbType.NVarChar).Value = code_categorie;
                    cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = code_magazin;
                    cmd.Parameters.Add("@RS_FOURNISSEUR", SqlDbType.NVarChar).Value = code_fournisseur;
                    cmd.Parameters.Add("@MAX_REMISE", SqlDbType.Decimal).Value = MAX_REMISE;
                    cmd.Parameters.Add("@PRIX_SOLDE", SqlDbType.Decimal).Value = PRIX_SOLDE;
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE_SOLDE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE + REF_ARTICLE;


                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    //cmd.CommandText = "INSERT INTO STOCK (CODE_MAG, NOM_MAG, CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, QTTE_STOCK, QTTE_STOCK_MIN) VALUES (@CODE_MAG, @NOM_MAG, @CODE_ARTICLE, @REF_ARTICLE, @DESIGNATION_ARTICLE, @QTTE_STOCK, @QTTE_STOCK_MIN)";
                    //cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = MAGAZIN;
                    //cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = code_magazin;
                    //cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE_ARTICLE;
                    //cmd.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
                    //cmd.Parameters.Add("@DESIGNATION_ARTICLE", SqlDbType.NVarChar).Value = DESIGNATION_ARTICLE;
                    //cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = QTE_ARTICLE;
                    //cmd.Parameters.Add("@QTTE_STOCK_MIN", SqlDbType.Decimal).Value = QTE_MIN_ARTICLE;
                    //cmd.ExecuteNonQuery();
                    //cmd.Parameters.Clear();
                    sqlTrans.Commit();

                    res.MESSAGE = "Product saved successfully.\n „ Õ›Ÿ «·’‰› »‰Ã«Õ.";
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

        public DataTable LOAD_ARTICLE(string CODE)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM ARTICLE WHERE CODE_ARTICLE = @CODE_ARTICLE", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE;
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LOAD_ARTICLE_BY_BARCODE(string BARCODE)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM ARTICLE WHERE CODE_BARRE_ARTICLE = @CODE_BARRE_ARTICLE", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = BARCODE;
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LOAD_ARTICLE_BY_REF(string REF_ARTICLE)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM ARTICLE WHERE REF_ARTICLE = @REF_ARTICLE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        public DataTable SELECT_BY_BARCODE(string BARCODE)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT   * FROM ARTICLE WHERE CODE_BARRE_ARTICLE = @CODE_BARRE_ARTICLE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.Decimal).Value = BARCODE;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        public DataTable SEARCH_ARTICLE(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (REF_ARTICLE LIKE '%" + param + "%') OR (DESIGNATION_ARTICLE LIKE '%" + param + "%') OR (MARQUE_ARTICLE LIKE '%" + param + "%') OR (CODE_BARRE_ARTICLE LIKE '%" + param + "%')", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }

        public DataTable SELECT_ALL_ARTICLE()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, DESCRIPTION_ARTICLE, CODE_BARRE_ARTICLE, QTE_ARTICLE, UNITE_QTE_ARTICLE, QTE_MIN_ARTICLE, PHOTO_ARTICLE, PRIX_HT_A_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, ETAT_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;
            
            
            return dt;
        }

        public RESULT_QUERY UPDATE_ARTICLE(string CODE_ARTICLE, string REF_ARTICLE, string DESIGNATION_ARTICLE, string MARQUE_ARTICLE, string DESCRIPTION_ARTICLE, string CODE_BARRE_ARTICLE, decimal QTE_ARTICLE, string UNITE, decimal QTE_MIN_ARTICLE, byte[] PHOTO_ARTICLE, decimal PRIX_HT_A_ARTICLE, decimal PRIX_HT_V_ARTICLE, decimal TVA_ARTICLE, decimal MAX_REMISE, bool ETAT_ARTICLE, string CATEGORIE, string MAGAZIN, string FOURNISSEUR, decimal PRIX_SOLDE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
                cmd.Transaction = sqlTrans;
                try
                {
                    res.CODE = CODE_ARTICLE;

                    cmd.CommandText = "SELECT RS_FOURNISSEUR FROM FOURNISSEUR WHERE CODE_FOURNISSEUR LIKE'" + FOURNISSEUR + "'";
                    string code_fournisseur = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "SELECT LIB_CATEG FROM CATEGORIE WHERE CODE_CATEG LIKE'" + CATEGORIE + "'";
                    string code_categorie = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "SELECT NOM_MAG FROM MAGAZIN WHERE CODE_MAG LIKE'" + MAGAZIN + "'";
                    string code_magazin = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "UPDATE    ARTICLE SET              REF_ARTICLE = @REF_ARTICLE, DESIGNATION_ARTICLE = @DESIGNATION_ARTICLE, MARQUE_ARTICLE = @MARQUE_ARTICLE, DESCRIPTION_ARTICLE = @DESCRIPTION_ARTICLE, CODE_BARRE_ARTICLE = @CODE_BARRE_ARTICLE, QTE_ARTICLE = @QTE_ARTICLE, UNITE_QTE_ARTICLE=@UNITE_QTE_ARTICLE, QTE_MIN_ARTICLE = @QTE_MIN_ARTICLE, PHOTO_ARTICLE = @PHOTO_ARTICLE, PRIX_HT_A_ARTICLE = @PRIX_HT_A_ARTICLE, PRIX_HT_V_ARTICLE = @PRIX_HT_V_ARTICLE, TVA_ARTICLE = @TVA_ARTICLE, ETAT_ARTICLE = @ETAT_ARTICLE, CODE_CATEG=@CODE_CATEG, CODE_MAG=@CODE_MAG, CODE_FOURNISSEUR=@CODE_FOURNISSEUR, LIB_CATEG=@LIB_CATEG, NOM_MAG=@NOM_MAG, RS_FOURNISSEUR=@RS_FOURNISSEUR, MAX_REMISE=@MAX_REMISE, PRIX_SOLDE=@PRIX_SOLDE, CODE_BARRE_ARTICLE_SOLDE=@CODE_BARRE_ARTICLE_SOLDE  WHERE     (CODE_ARTICLE = @CODE_ARTICLE)";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE_ARTICLE;
                    cmd.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
                    cmd.Parameters.Add("@DESIGNATION_ARTICLE", SqlDbType.NVarChar).Value = DESIGNATION_ARTICLE;
                    cmd.Parameters.Add("@MARQUE_ARTICLE", SqlDbType.NVarChar).Value = MARQUE_ARTICLE;
                    cmd.Parameters.Add("@DESCRIPTION_ARTICLE", SqlDbType.NVarChar).Value = DESCRIPTION_ARTICLE;
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE;
                    cmd.Parameters.Add("@QTE_ARTICLE", SqlDbType.Decimal).Value = QTE_ARTICLE;
                    cmd.Parameters.Add("@UNITE_QTE_ARTICLE", SqlDbType.NVarChar).Value = UNITE;
                    cmd.Parameters.Add("@QTE_MIN_ARTICLE", SqlDbType.Decimal).Value = QTE_MIN_ARTICLE;
                    cmd.Parameters.Add("@PHOTO_ARTICLE", SqlDbType.Image).Value = (PHOTO_ARTICLE != null) ? PHOTO_ARTICLE : (object)DBNull.Value;
                    cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_A_ARTICLE;
                    cmd.Parameters.Add("@TVA_ARTICLE", SqlDbType.Decimal).Value = TVA_ARTICLE;
                    cmd.Parameters.Add("@ETAT_ARTICLE", SqlDbType.Bit).Value = ETAT_ARTICLE;
                    cmd.Parameters.Add("@PRIX_HT_V_ARTICLE", SqlDbType.Decimal).Value = PRIX_HT_V_ARTICLE;
                    cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CATEGORIE;
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = MAGAZIN;
                    cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = FOURNISSEUR;
                    cmd.Parameters.Add("@LIB_CATEG", SqlDbType.NVarChar).Value = code_categorie;
                    cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = code_magazin;
                    cmd.Parameters.Add("@RS_FOURNISSEUR", SqlDbType.NVarChar).Value = code_fournisseur;
                    cmd.Parameters.Add("@MAX_REMISE", SqlDbType.Decimal).Value = MAX_REMISE;
                    cmd.Parameters.Add("@PRIX_SOLDE", SqlDbType.Decimal).Value = PRIX_SOLDE;
                    cmd.Parameters.Add("@CODE_BARRE_ARTICLE_SOLDE", SqlDbType.NVarChar).Value = CODE_BARRE_ARTICLE+REF_ARTICLE;
                    
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    //cmd.CommandText = "UPDATE STOCK  SET  NOM_MAG=@NOM_MAG, REF_ARTICLE=@REF_ARTICLE, DESIGNATION_ARTICLE=@DESIGNATION_ARTICLE, QTTE_STOCK=@QTTE_STOCK, QTTE_STOCK_MIN=@QTTE_STOCK_MIN  WHERE (CODE_MAG=@CODE_MAG) AND (CODE_ARTICLE=@CODE_ARTICLE)";
                    //cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = MAGAZIN;
                    //cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = code_magazin;
                    //cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = CODE_ARTICLE;
                    //cmd.Parameters.Add("@REF_ARTICLE", SqlDbType.NVarChar).Value = REF_ARTICLE;
                    //cmd.Parameters.Add("@DESIGNATION_ARTICLE", SqlDbType.NVarChar).Value = DESIGNATION_ARTICLE;
                    //cmd.Parameters.Add("@QTTE_STOCK", SqlDbType.Decimal).Value = QTE_ARTICLE;
                    //cmd.Parameters.Add("@QTTE_STOCK_MIN", SqlDbType.Decimal).Value = QTE_MIN_ARTICLE;
                    //cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    sqlTrans.Commit();

                    res.MESSAGE = "Product saved successfully.\n „  ⁄œÌ· «·’‰› »‰Ã«Õ.";
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

        public string NEW_CODE(int nbCHIFRE)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT     ISNULL(MAX(CODE_ARTICLE), 0) + 1 FROM         ARTICLE", CONNECTION_PARAM.cnx))
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

        

        public DataTable SELECT_CATEGORIES()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT LIB_CATEG FROM CATEGORIE", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SELECT_FOURNISSEURS()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT RS_FOURNISSEUR FROM FOURNISSEUR", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable SELECT_MAGAZINS()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT NOM_MAG, CODE_MAG FROM MAGAZIN", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            return dt;
        }


        public DataTable SEARCH_ARTICLE_CATEG(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (LIB_CATEG '%" + param + "%') ", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }

        public DataTable SEARCH_ARTICLE_FOURN(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (RS_FOURNISSEUR '%" + param + "%') ", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }

        public DataTable SEARCH_ARTICLE_MAG(string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, ETAT_ARTICLE, CODE_CATEG, CODE_MAG, CODE_FOURNISSEUR, LIB_CATEG, NOM_MAG, RS_FOURNISSEUR FROM         ARTICLE WHERE     (NOM_MAG LIKE '%" + param + "%') ", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }

        

        public void BLOQUER_ARTICLE(string CODE_ARTICLE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DataTable IMPRIMER_CODE_BARRE_ARTICLE(string CODE_ARTICLE, bool solde)
        {
            string sqlCommandText="";
            if (!solde)
                sqlCommandText="select article.DESIGNATION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE, Article.PRIX_HT_V_ARTICLE,Societe.RS_SOCIETE from ARTICLE, SOCIETE WHERE     (CODE_ARTICLE LIKE'" + CODE_ARTICLE + "') ";
            else
                sqlCommandText = "select article.DESIGNATION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE_SOLDE, Article.PRIX_HT_V_ARTICLE, Article.PRIX_SOLDE,Societe.RS_SOCIETE from ARTICLE, SOCIETE WHERE     (CODE_ARTICLE LIKE'" + CODE_ARTICLE + "') ";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommandText, CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
    class CHM_COMMANDE_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_COMMANDE
    {
        #region CHM_COMMANDE Membres

        public DataTable LISTE_CLIENT()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DataTable LOAD_COMMANDE_CLIENT(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     COMMANDE.CODE_COMMANDE, COMMANDE.DATE_COMMANDE, COMMANDE.PRIORITE_COMMANDE, SUM(LIGNE_COMMANDE.PRIX_HT_COMMANDE) AS MONTANT_T_V_HT, 'FALSE' AS CHOIX FROM         COMMANDE INNER JOIN LIGNE_COMMANDE ON COMMANDE.CODE_COMMANDE = LIGNE_COMMANDE.CODE_COMMANDE WHERE     (COMMANDE.CODE_CLIENT = @CODE_CLIENT) GROUP BY COMMANDE.CODE_COMMANDE, COMMANDE.DATE_COMMANDE, COMMANDE.PRIORITE_COMMANDE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["CHOIX"].ReadOnly = false;

            return dt;
        }

        public DataTable LOAD_LG_COMMANDE(string CODE_COMMANDE)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT   LIGNE_COMMANDE.CODE_COMMANDE,  LIGNE_COMMANDE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, LIGNE_COMMANDE.QTE_LIGNE_COMMANDE, LIGNE_COMMANDE.PRIX_HT_COMMANDE, 0 AS PRIX_HT_TOTAL, LIGNE_COMMANDE.TVA_COMMANDE, 0 AS PRIX_TTC_LG_COMMANDE, 0 AS PRIX_TTC_TOTAL, ARTICLE.UNITE_QTE_ARTICLE  FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LIGNE_COMMANDE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE CODE_COMMANDE = @CODE_COMMANDE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            dt.Columns["PRIX_TTC_LG_COMMANDE"].ReadOnly = false;
            dt.Columns["PRIX_TTC_TOTAL"].ReadOnly = false;
            dt.Columns["PRIX_HT_TOTAL"].ReadOnly = false;

            return dt;
        }

        public DataTable LOAD_LISTE_ARTICLE(string NOM_MAG)
        {
            DataTable dt = new DataTable();
            //SqlCommand cmd = new SqlCommand("SELECT CODE_MAG FROM MAGAZIN WHERE ( NOM_MAG LIKE '%" + NOM_MAG + "%')", CONNECTION_PARAM.cnx);

            //decimal CODE = (decimal)cmd.ExecuteScalar();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, DESCRIPTION_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PHOTO_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_ARTICLE, UNITE_QTE_ARTICLE FROM         STOCK inner join article on stock.code_article=article.code_article WHERE     (ETAT_ARTICLE = 'false') AND (CODE_MAG = @CODE) ", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE", SqlDbType.Decimal).Value = Convert.ToDecimal(NOM_MAG);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            dt.Columns["PRIX_TTC_ARTICLE"].ReadOnly = false;

            return dt;
        }

        public DataTable LOAD_LISTE_CLIENT()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_CLIENT, REF_CLIENT, RS_CLIENT FROM         CLIENT", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable LOAD_SCHEMA_LG_COMMANDE()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_COMMANDE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, LIGNE_COMMANDE.QTE_LIGNE_COMMANDE, LIGNE_COMMANDE.PRIX_HT_COMMANDE, LIGNE_COMMANDE.TVA_COMMANDE FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LIGNE_COMMANDE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
            }
            dt.Columns.Add("PRIX_TTC_LG_COMMANDE", typeof(decimal));
            dt.Columns.Add("PRIX_TTC_TOTAL", typeof(decimal));
            dt.Columns.Add("PRIX_HT_TOTAL", typeof(decimal));

            return dt;
        }

        public DataTable[] PRINT(string CODE_COMMANDE)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("", CONNECTION_PARAM.cnx))
            {
                DataTable dt_societe = new DataTable();
                da.SelectCommand.CommandText = "SELECT CODE_SOCIETE, RS_SOCIETE, DESCRIPTION_SOCIETE, ADRESSE_SOCIETE, CP_SOCIETE, TEL_SOCIETE, FAX_SOCIETE, EMAIL_SOCIETE, SITE_WEB_SOCETE, LOGO_SOCIETE, CODE_TVA_SOCIETE, RIB_SOCIETE, NUM_COMMANDE, PREFIX1_COMMANDE, PREFIX2_COMMANDE, PREFIX1_FACTURE, NUM_FACTURE, PREFIX1_FACTURE, PREFIXE2_FACTURE FROM dbo.SOCIETE";
                da.Fill(dt_societe);
                DataTable dt_commande = new DataTable();
                da.SelectCommand.CommandText = "SELECT     COMMANDE.CODE_COMMANDE, COMMANDE.CODE_CLIENT, COMMANDE.DATE_COMMANDE, COMMANDE.PRIORITE_COMMANDE, COMMANDE.DATE_EXPIRATION_COMMANDE, COMMANDE.CODE_USER, CLIENT.REF_CLIENT, CLIENT.RS_CLIENT, CLIENT.ADRESSE_CLIENT, CLIENT.CP_CLIENT FROM         COMMANDE INNER JOIN CLIENT ON COMMANDE.CODE_CLIENT = CLIENT.CODE_CLIENT WHERE COMMANDE.CODE_COMMANDE = @CODE_COMMANDE";
                da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                da.Fill(dt_commande);
                da.SelectCommand.Parameters.Clear();
                DataTable dt_lg_commande = new DataTable();
                da.SelectCommand.CommandText = "SELECT     LIGNE_COMMANDE.CODE_COMMANDE, LIGNE_COMMANDE.CODE_ARTICLE, LIGNE_COMMANDE.QTE_LIGNE_COMMANDE, LIGNE_COMMANDE.PRIX_HT_COMMANDE, LIGNE_COMMANDE.TVA_COMMANDE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, ARTICLE.PHOTO_ARTICLE FROM         LIGNE_COMMANDE INNER JOIN ARTICLE ON LIGNE_COMMANDE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE     (LIGNE_COMMANDE.CODE_COMMANDE = @CODE_COMMANDE)";
                da.SelectCommand.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                da.Fill(dt_lg_commande);
                da.SelectCommand.Parameters.Clear();
                DataTable[] tab = { dt_commande, dt_lg_commande, dt_societe };
                return tab;
            }
        }

        public DataTable RECHERCHE_CLIENT(string REF_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_CLIENT, REF_CLIENT, RS_CLIENT FROM         CLIENT WHERE     (REF_CLIENT = @REF_CLIENT)", CONNECTION_PARAM.cnx))
                {
                    da.SelectCommand.Parameters.Add("@REF_CLIENT", SqlDbType.NVarChar).Value = REF_CLIENT;
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public DataTable RECHERCHE_LISTE_ARTICLE(string param)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_ARTICLE, REF_ARTICLE, DESIGNATION_ARTICLE, MARQUE_ARTICLE, QTE_ARTICLE, QTE_MIN_ARTICLE, PRIX_HT_V_ARTICLE, TVA_ARTICLE, PRIX_HT_V_ARTICLE * (1 + TVA_ARTICLE / 100) AS PRIX_TTC_V_ARTICLE FROM         ARTICLE WHERE     (ETAT_ARTICLE = 'false')    AND (REF_ARTICLE LIKE '%" + param + "%' OR  DESIGNATION_ARTICLE LIKE '%" + param + "%' OR MARQUE_ARTICLE LIKE '%" + param + "%' OR  DESCRIPTION_ARTICLE  LIKE '%" + param + "%'  OR CODE_BARRE_ARTICLE LIKE '%" + param + "%') ", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        public DataTable RECHERCHE_LISTE_CLIENT(string param)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_CLIENT, REF_CLIENT, RS_CLIENT FROM         CLIENT WHERE REF_CLIENT LIKE '%" + param + "%' OR RS_CLIENT LIKE '%" + param + "%' ", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        public RESULT_QUERY SAVE(string CODE_CLIENT, DateTime DATE_COMMANDE, bool PRIORITE_COMMANDE, object DATE_EXPIRATION_COMMANDE, string CODE_USER, bool reglee, DataTable dt_lg_commande)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                    cmd.CommandText = "INSERT INTO LIGNE_COMMANDE(CODE_ARTICLE, CODE_COMMANDE, QTE_LIGNE_COMMANDE, PRIX_HT_COMMANDE, TVA_COMMANDE) VALUES     (@CODE_ARTICLE,@CODE_COMMANDE,@QTE_LIGNE_COMMANDE,@PRIX_HT_COMMANDE,@TVA_COMMANDE)";
                    cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = CODE_COMMANDE;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@QTE_LIGNE_COMMANDE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_COMMANDE"];
                    cmd.Parameters.Add("@PRIX_HT_COMMANDE", SqlDbType.Decimal).Value = dr["PRIX_HT_COMMANDE"];
                    cmd.Parameters.Add("@TVA_COMMANDE", SqlDbType.Decimal).Value = dr["TVA_COMMANDE"];
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                sqltrans.Commit();

                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }

            return res;
        }




        public DataTable LOAD_COMMANDE(string code)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_COMMANDE=@CODE_COMMANDE", CONNECTION_PARAM.cnx))
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

        public DataTable SELECT_ALL_COMMANDE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception)
            {
            }
            return dt;
        }




        public DataTable RECHERCHE_COMMANDES(string client, DateTime date_saisie, DateTime date_expiration)
        {
            DataTable dt = new DataTable();


            if (client != "" && date_saisie == null && date_expiration == null)
            {
                SqlCommand cmd = new SqlCommand("SELECT CODE_CLIENT FROM CLIENT WHERE RS_CLIENT LIKE'%" + client + "%'", CONNECTION_PARAM.cnx);
                string code_clt = cmd.ExecuteScalar().ToString(); MessageBox.Show(code_clt, "fsdf", MessageBoxButtons.OK);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx);
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = code_clt;
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }





        public void REGLE_COMMANDE(string code_commande)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "UPDATE COMMANDE SET REGLEE=@REGLEE WHERE (CODE_COMMANDE=@CODE_COMMANDE)";
                cmd.Parameters.Add("@REGLEE", SqlDbType.Bit).Value = "True";
                cmd.Parameters.Add("@CODE_COMMANDE", SqlDbType.NVarChar).Value = code_commande;
                cmd.ExecuteNonQuery();
                sqltrans.Commit();
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
            }
        }




        public void SELECT_COMMANDE_NON_REGLE()
        {
            throw new Exception("The method or operation is not implemented.");
        }





        #endregion
    }
    class CHM_FACTURE_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_FACTURE
    {
        #region CHM_FACTURE Membres

        public void CANCEL_FACTURE(string CODE_FACTURE)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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

        public RESULT_QUERY INSERT_FACTURE(DateTime DATE_FACTURE, string CODE_CLIENT, string MONTANT_HT_FACTURE, string MONTANT_TVA, string MONTANT_TTC, string TAUX_REMISE, string MONTANT_BASE, string TIMBRE_FACTURE, string MONTANT_TOTAL_FACTURE, string MONTANT_LETTRE_FACTURE, bool ANNULATION_FACTURE, string REGLER, string CREDIT, string CODE_MAG, string CODE_USER, string PRENOM_USER, string NOM_USER, string REMARQUE, DataTable dt_lg_facture)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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

                string CODE_FACTURE = PREFIX1_FACTURE + NUM_FACTURE.ToString() + PREFIX2_FACTURE;
                res.MESSAGE = "erreur insertion prefix1 cmd";
                res.CODE = CODE_FACTURE;

                cmd.CommandText = "INSERT INTO FACTURE (CODE_FACTURE, DATE_FACTURE, CODE_CLIENT, MONTANT_HT_FACTURE, MONTANT_TVA, MONTANT_TTC, TAUX_REMISE, MONTANT_BASE, TIMBRE_FACTURE, MONTANT_TOTAL_FACTURE, MONTANT_LETTRE, ANNULATION_FACTURE, REGLER, CREDIT, MAGASIN, CODE_USER, PRENOM_USER, NOM_USER, REMARQUE) VALUES     (@CODE_FACTURE, @DATE_FACTURE, @CODE_CLIENT, @MONTANT_HT_FACTURE, @MONTANT_TVA, @MONTANT_TTC, @TAUX_REMISE, @MONTANT_BASE, @TIMBRE_FACTURE, @MONTANT_TOTAL_FACTURE, @MONTANT_LETTRE, @ANNULATION_FACTURE, @REGLER, @CREDIT, @MAGASIN, @CODE_USER, @PRENOM_USER, @NOM_USER, @REMARQUE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_FACTURE", SqlDbType.DateTime).Value = DATE_FACTURE; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT; res.MESSAGE = "3";
                cmd.Parameters.Add("@MONTANT_HT_FACTURE", SqlDbType.Decimal).Value = MONTANT_HT_FACTURE; res.MESSAGE = "4";
                cmd.Parameters.Add("@MONTANT_TVA", SqlDbType.Decimal).Value = MONTANT_TVA; res.MESSAGE = "5";
                cmd.Parameters.Add("@MONTANT_TTC", SqlDbType.Decimal).Value = MONTANT_TTC; res.MESSAGE = "6";
                cmd.Parameters.Add("@TAUX_REMISE", SqlDbType.Decimal).Value = TAUX_REMISE; res.MESSAGE = "7";
                cmd.Parameters.Add("@MONTANT_BASE", SqlDbType.Decimal).Value = MONTANT_BASE; res.MESSAGE = "8";
                cmd.Parameters.Add("@TIMBRE_FACTURE", SqlDbType.Decimal).Value = TIMBRE_FACTURE; res.MESSAGE = "9";
                cmd.Parameters.Add("@MONTANT_TOTAL_FACTURE", SqlDbType.Decimal).Value = MONTANT_TOTAL_FACTURE; res.MESSAGE = "10";
                cmd.Parameters.Add("@MONTANT_LETTRE", SqlDbType.NVarChar).Value = MONTANT_LETTRE_FACTURE; res.MESSAGE = "11";
                cmd.Parameters.Add("@ANNULATION_FACTURE", SqlDbType.Bit).Value = ANNULATION_FACTURE; res.MESSAGE = "12";
                cmd.Parameters.Add("@REGLER", SqlDbType.NVarChar).Value = REGLER; res.MESSAGE = "13";
                cmd.Parameters.Add("@CREDIT", SqlDbType.Decimal).Value = CREDIT; res.MESSAGE = "14";
                cmd.Parameters.Add("@MAGASIN", SqlDbType.NVarChar).Value = CODE_MAG; res.MESSAGE = "15";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "16";
                cmd.Parameters.Add("@PRENOM_USER", SqlDbType.NVarChar).Value = PRENOM_USER; res.MESSAGE = "17";
                cmd.Parameters.Add("@NOM_USER", SqlDbType.NVarChar).Value = NOM_USER; res.MESSAGE = "18";
                cmd.Parameters.Add("@REMARQUE", SqlDbType.NVarChar).Value = REMARQUE; res.MESSAGE = "19";
                cmd.ExecuteNonQuery(); res.MESSAGE = "an error occured when executing request!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_lg_facture.Rows)
                {
                    cmd.CommandText = "INSERT INTO LIGNE_FACTURE( CODE_FACTURE, CODE_ARTICLE, QTE, TVA_ARTICLE, PRIX_HT_ARTICLE, PRIX_TOTAL_HT, PRIX_U_TTC, PRIX_TOTAL_TTC, CODE_B_LIV ) VALUES     (@CODE_FACTURE, @CODE_ARTICLE, @QTE, @TVA_ARTICLE, @PRIX_HT_ARTICLE, @PRIX_TOTAL_HT, @PRIX_U_TTC, @PRIX_TOTAL_TTC, @CODE_B_LIV)";
                    cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = dr["CODE_B_LIV"]; res.MESSAGE = "21";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE_LIGNE_B_LIV"]; res.MESSAGE = "23";
                    cmd.Parameters.Add("@TVA_ARTICLE", SqlDbType.Decimal).Value = dr["TVA_B_LIV"]; res.MESSAGE = "24";
                    cmd.Parameters.Add("@PRIX_HT_ARTICLE", SqlDbType.Decimal).Value = dr["PRIX_HT_B_LIV"]; res.MESSAGE = "25";
                    cmd.Parameters.Add("@PRIX_TOTAL_HT", SqlDbType.Decimal).Value = dr["PRIX_TOTAL_HT"]; res.MESSAGE = "26";
                    cmd.Parameters.Add("@PRIX_U_TTC", SqlDbType.Decimal).Value = dr["PRIX_U_TTC"]; res.MESSAGE = "27";
                    cmd.Parameters.Add("@PRIX_TOTAL_TTC", SqlDbType.Decimal).Value = dr["PRIX_TOTAL_TTC"]; res.MESSAGE = "28";

                    cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                    cmd.Parameters.Clear();
                }


                sqltrans.Commit();

                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
                
                
            }
            return res;
        }

        public RESULT_QUERY INSERT_FACTURE_DIRECTE(DateTime DATE_FACTURE, string CODE_CLIENT, string MONTANT_HT_FACTURE, string MONTANT_TVA, string MONTANT_TTC, string TAUX_REMISE, string MONTANT_BASE, string TIMBRE_FACTURE, string MONTANT_TOTAL_FACTURE, string MONTANT_LETTRE_FACTURE, bool ANNULATION_FACTURE, string REGLER, string CREDIT, string CODE_MAG, string CODE_USER, string PRENOM_USER, string NOM_USER, string REMARQUE, DataTable dt_lg_facture)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock where code_mag='" + CODE_MAG + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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

                string CODE_FACTURE = PREFIX1_FACTURE + NUM_FACTURE.ToString() + PREFIX2_FACTURE;
                res.MESSAGE = "erreur insertion prefix1 cmd";
                res.CODE = CODE_FACTURE;

                cmd.CommandText = "INSERT INTO FACTURE (CODE_FACTURE, DATE_FACTURE, CODE_CLIENT, MONTANT_HT_FACTURE, MONTANT_TVA, MONTANT_TTC, TAUX_REMISE, MONTANT_BASE, TIMBRE_FACTURE, MONTANT_TOTAL_FACTURE, MONTANT_LETTRE, ANNULATION_FACTURE, REGLER, CREDIT, MAGASIN, CODE_USER, PRENOM_USER, NOM_USER, REMARQUE) VALUES     (@CODE_FACTURE, @DATE_FACTURE, @CODE_CLIENT, @MONTANT_HT_FACTURE, @MONTANT_TVA, @MONTANT_TTC, @TAUX_REMISE, @MONTANT_BASE, @TIMBRE_FACTURE, @MONTANT_TOTAL_FACTURE, @MONTANT_LETTRE, @ANNULATION_FACTURE, @REGLER, @CREDIT, @MAGASIN, @CODE_USER, @PRENOM_USER, @NOM_USER, @REMARQUE)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_FACTURE", SqlDbType.DateTime).Value = DATE_FACTURE; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT; res.MESSAGE = "3";
                cmd.Parameters.Add("@MONTANT_HT_FACTURE", SqlDbType.Decimal).Value = MONTANT_HT_FACTURE; res.MESSAGE = "4";
                cmd.Parameters.Add("@MONTANT_TVA", SqlDbType.Decimal).Value = MONTANT_TVA; res.MESSAGE = "5";
                cmd.Parameters.Add("@MONTANT_TTC", SqlDbType.Decimal).Value = MONTANT_TTC; res.MESSAGE = "6";
                cmd.Parameters.Add("@TAUX_REMISE", SqlDbType.Decimal).Value = TAUX_REMISE; res.MESSAGE = "7";
                cmd.Parameters.Add("@MONTANT_BASE", SqlDbType.Decimal).Value = MONTANT_BASE; res.MESSAGE = "8";
                cmd.Parameters.Add("@TIMBRE_FACTURE", SqlDbType.Decimal).Value = TIMBRE_FACTURE; res.MESSAGE = "9";
                cmd.Parameters.Add("@MONTANT_TOTAL_FACTURE", SqlDbType.Decimal).Value = MONTANT_TOTAL_FACTURE; res.MESSAGE = "10";
                cmd.Parameters.Add("@MONTANT_LETTRE", SqlDbType.NVarChar).Value = MONTANT_LETTRE_FACTURE; res.MESSAGE = "11";
                cmd.Parameters.Add("@ANNULATION_FACTURE", SqlDbType.Bit).Value = ANNULATION_FACTURE; res.MESSAGE = "12";
                cmd.Parameters.Add("@REGLER", SqlDbType.NVarChar).Value = REGLER; res.MESSAGE = "13";
                cmd.Parameters.Add("@CREDIT", SqlDbType.Decimal).Value = CREDIT; res.MESSAGE = "14";
                cmd.Parameters.Add("@MAGASIN", SqlDbType.NVarChar).Value = CODE_MAG; res.MESSAGE = "15";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "16";
                cmd.Parameters.Add("@PRENOM_USER", SqlDbType.NVarChar).Value = PRENOM_USER; res.MESSAGE = "17";
                cmd.Parameters.Add("@NOM_USER", SqlDbType.NVarChar).Value = NOM_USER; res.MESSAGE = "18";
                cmd.Parameters.Add("@REMARQUE", SqlDbType.NVarChar).Value = REMARQUE; res.MESSAGE = "19";
                cmd.ExecuteNonQuery(); res.MESSAGE = "an error occured when executing request!!!!!";
                cmd.Parameters.Clear();
                DataTable article = new DataTable();


                

                foreach (DataRow dr in dt_lg_facture.Rows)
                {
                    cmd.CommandText = "INSERT INTO LIGNE_FACTURE (CODE_FACTURE, CODE_ARTICLE, QTE, TVA_ARTICLE, PRIX_HT_ARTICLE, PRIX_TOTAL_HT, PRIX_U_TTC,";
                    cmd.CommandText += " PRIX_TOTAL_TTC, REMISE, PRIX_FACTURE) VALUES (@CODE_FACTURE,@CODE_ARTICLE,@QTE,@TVA_ARTICLE,@PRIX_HT_ARTICLE,";
                    cmd.CommandText += "@PRIX_TOTAL_HT,@PRIX_U_TTC,@PRIX_TOTAL_TTC,@REMISE,@PRIX_FACTURE)";
                    cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE; res.MESSAGE = "20";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "22";
                    cmd.Parameters.Add("@QTE", SqlDbType.Decimal).Value = dr["QTE"]; res.MESSAGE = "23";
                    cmd.Parameters.Add("@TVA_ARTICLE", SqlDbType.Decimal).Value = 0; res.MESSAGE = "24";
                    cmd.Parameters.Add("@PRIX_HT_ARTICLE", SqlDbType.Decimal).Value = dr["PRIX_HT_ARTICLE"]; res.MESSAGE = "25";
                    cmd.Parameters.Add("@PRIX_TOTAL_HT", SqlDbType.Decimal).Value = dr["PRIX_TOTAL_HT"]; res.MESSAGE = "26";
                    cmd.Parameters.Add("@PRIX_U_TTC", SqlDbType.Decimal).Value = dr["PRIX_U_TTC"]; res.MESSAGE = "27";
                    cmd.Parameters.Add("@PRIX_TOTAL_TTC", SqlDbType.Decimal).Value = dr["PRIX_TOTAL_TTC"]; res.MESSAGE = "28";
                    cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = dr["REMISE"];
                    cmd.Parameters.Add("@PRIX_FACTURE", SqlDbType.Decimal).Value = dr["PRIX_FACTURE"];

                    cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                    cmd.Parameters.Clear();

                    dt.DefaultView.RowFilter = "CODE_ARTICLE ='" + dr["CODE_ARTICLE"].ToString() + "'";
                    article = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";

                    if (article.Rows.Count == 0)
                    {
                        Exception er = new Exception("Œÿ√. Â–« «·’‰› €Ì— „ÊÃÊœ »«·„Œ“‰");
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

                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }


        public DataTable LOAD_B_LIV_CLIENT(string CODE_CLIENT)
        {
            
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_CLIENT=@CODE_CLIENT AND FACTURED=@FACTURED", CONNECTION_PARAM.cnx))
                {
                    da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                    da.SelectCommand.Parameters.Add("@FACTURED", SqlDbType.Bit).Value = "False";
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
                
            }
            catch (Exception er)
            {
                
            }
            return dt;
        }

        public DataTable LOAD_B_LIV_FACTURE(string CODE_B_LIV)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_B_LIV=@CODE_B_LIV", CONNECTION_PARAM.cnx))
                {
                    da.SelectCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt;
        }

        public DataTable LOAD_CLIENT_FACTURE(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENT WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
                {
                    da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt;
        }

        public DataTable LOAD_LG_B_LIV(string CODE_B_LIV)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LG_BON_LIVRAISON.CODE_B_LIV, LG_BON_LIVRAISON.CODE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV,                       LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV, LG_BON_LIVRAISON.PRIX_TOTAL_HT, LG_BON_LIVRAISON.PRIX_U_TTC,                       LG_BON_LIVRAISON.PRIX_TOTAL_TTC, ARTICLE.CODE_ARTICLE AS Expr1, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM         LG_BON_LIVRAISON INNER JOIN                      ARTICLE ON LG_BON_LIVRAISON.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE (LG_BON_LIVRAISON.CODE_B_LIV=@CODE_B_LIV)", CONNECTION_PARAM.cnx))
                {
                    da.SelectCommand.Parameters.Add("@CODE_B_LIV", SqlDbType.NVarChar).Value = CODE_B_LIV;
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt;
        }

        public DataTable LOAD_REGLEMENT_FACTURE(string CODE_FACTURE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DataTable SELECT_FACTURE_ANNULEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE ANNULATION_FACTURE=@ANNULATION_FACTURE", CONNECTION_PARAM.cnx))
                {
                    da.SelectCommand.Parameters.Add("@ANNULATION_FACTURE", SqlDbType.Bit).Value = "True";
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt; ;
        }

        public DataTable SELECT_FACTURE_NON_REGLEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (CREDIT=MONTANT_TOTAL_FACTURE)", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt; ;
        }

        public DataTable SELECT_FACTURE_PARTIELLEMENT_REGLEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (CREDIT<MONTANT_TOTAL_FACTURE)", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt; ;
        }

        public DataTable SELECT_FACTURE_REGLEE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (CREDIT=0)", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {
                
            }
            return dt; ;
        }

        public RESULT_QUERY UPDATE_ETAT_FACTURE(string CODE_FACTURE, string MONTANT_PAYE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            string etat = "";
            decimal reste ;
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                
                cmd.CommandText = "SELECT CREDIT FROM FACTURE WHERE CODE_FACTURE=@CODE_FACTURE";
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                decimal CREDIT = (decimal)cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                if ((Convert.ToDecimal(MONTANT_PAYE)) < CREDIT)
                {
                    etat = "Partiellement reglÈe";
                    reste=CREDIT-(Convert.ToDecimal(MONTANT_PAYE));
                    res.CODE=reste.ToString();
                    res.MESSAGE=" „  ≈÷«›… «·œ›⁄… ⁄·Ï «·Õ”«» »«·‰”»… ·Â« Â «·›« Ê—…\n«·„»·€ «·„ »ﬁ ÂÊ :" +reste.ToString();
                }
                if ((Convert.ToDecimal(MONTANT_PAYE)) >= CREDIT)
                {
                    etat = "ReglÈe";
                    reste=(Convert.ToDecimal(MONTANT_PAYE))-CREDIT;
                    res.CODE=reste.ToString();
                    res.MESSAGE="Invoice payed, the rest is : \n  „ ”œ«œ «·›« Ê—… , »«ﬁÌ «·“»Ê‰ ÂÊ :\n"+reste.ToString();
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

        


        public DataTable LOAD_SCHEMA_LG_FACTURE()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     LG_BON_LIVRAISON.CODE_B_LIV, LG_BON_LIVRAISON.CODE_ARTICLE, LG_BON_LIVRAISON.QTE_LIGNE_B_LIV,                      LG_BON_LIVRAISON.PRIX_HT_B_LIV, LG_BON_LIVRAISON.TVA_B_LIV, LG_BON_LIVRAISON.PRIX_TOTAL_HT, LG_BON_LIVRAISON.PRIX_U_TTC,                       LG_BON_LIVRAISON.PRIX_TOTAL_TTC,  ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM         ARTICLE INNER JOIN                     LG_BON_LIVRAISON ON ARTICLE.CODE_ARTICLE = LG_BON_LIVRAISON.CODE_ARTICLE", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            
            return dt;
        }

        public DataTable LOAD_SCHEMA_LG_FACTURE_DIRECTE()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT        LIGNE_FACTURE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, LIGNE_FACTURE.QTE, LIGNE_FACTURE.PRIX_HT_ARTICLE,  LIGNE_FACTURE.PRIX_TOTAL_HT, LIGNE_FACTURE.PRIX_U_TTC, LIGNE_FACTURE.PRIX_TOTAL_TTC, LIGNE_FACTURE.REMISE, LIGNE_FACTURE.PRIX_FACTURE FROM LIGNE_FACTURE INNER JOIN ARTICLE ON LIGNE_FACTURE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
            }

            return dt;
        }       

        public void FACTURATION(string CODE_FACTURE, string CODE_B_LIV, DateTime DATE_FACTURE)
        {
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                
            }

        }
       

        public DataTable LOAD_FACTURE(string CODE_CLIENT)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_CLIENT=@CODE_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_CLIENT", SqlDbType.NVarChar).Value = CODE_CLIENT;
                da.SelectCommand.ExecuteNonQuery();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        

        public DataTable SELECT_ALL_FACTURES()
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE ", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Transaction = CONNECTION_PARAM.trans;  
                da.SelectCommand.ExecuteNonQuery();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        


        public DataTable LOAD_FACTURE_PAR_CODE(string CODE_FATCURE)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_FACTURE=@CODE_FACTURE", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FATCURE;
                da.SelectCommand.ExecuteNonQuery();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable LOAD_LIGNES_FACTURE(string CODE_FATCURE)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_FACTURE.CODE_FACTURE, LIGNE_FACTURE.QTE, LIGNE_FACTURE.TVA_ARTICLE, LIGNE_FACTURE.PRIX_HT_ARTICLE, LIGNE_FACTURE.PRIX_TOTAL_HT, LIGNE_FACTURE.PRIX_U_TTC, LIGNE_FACTURE.PRIX_TOTAL_TTC, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.CODE_ARTICLE    FROM         LIGNE_FACTURE INNER JOIN                      ARTICLE ON LIGNE_FACTURE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE   WHERE CODE_FACTURE=@CODE_FACTURE", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FATCURE;
                da.SelectCommand.ExecuteNonQuery();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

       


        public DataTable RECHERCHE_FACTURE(string param, string etat)
        {
            DataTable dt = new DataTable();

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE (REGLER LIKE'%" + etat + "%') AND ((CODE_FACTURE LIKE'%" + param + "%')OR(DATE_FACTURE LIKE'%" + param + "%') OR (CODE_CLIENT LIKE'%" + param + "%') OR (NOM_USER LIKE'%" + param + "%') OR (PRENOM_USER LIKE'%" + param + "%'))", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.ExecuteNonQuery();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        


        public DataTable LOAD_SCHEMA_LIGNE_B_LIV_FACTURE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                }
                
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable ImprimerTICET_FACTURE_CLIENT(string CODE_FACTURE)
        {
            string commandText="";
            commandText="SELECT        FACTURE.DATE_FACTURE, FACTURE.CODE_CLIENT, FACTURE.MONTANT_HT_FACTURE, FACTURE.MONTANT_TVA, FACTURE.MONTANT_TTC, ";
            commandText += "FACTURE.TAUX_REMISE, FACTURE.MONTANT_BASE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.TIMBRE_FACTURE, FACTURE.MONTANT_LETTRE, ";
            commandText+="FACTURE.CODE_USER, FACTURE.MAGASIN, FACTURE.CODE_FACTURE, LIGNE_FACTURE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, LIGNE_FACTURE.QTE, ";
            commandText+="ARTICLE.REF_ARTICLE, LIGNE_FACTURE.PRIX_HT_ARTICLE, LIGNE_FACTURE.PRIX_TOTAL_HT, LIGNE_FACTURE.PRIX_U_TTC, ";
            commandText+="LIGNE_FACTURE.PRIX_TOTAL_TTC, LIGNE_FACTURE.REMISE, SOCIETE.RS_SOCIETE, SOCIETE.DESCRIPTION_SOCIETE, SOCIETE.ADRESSE_SOCIETE, ";
            commandText+="SOCIETE.CP_SOCIETE, SOCIETE.TEL_SOCIETE, SOCIETE.FAX_SOCIETE, SOCIETE.EMAIL_SOCIETE, SOCIETE.SITE_WEB_SOCETE, SOCIETE.LOGO_SOCIETE,"; 
            commandText+="SOCIETE.CODE_TVA_SOCIETE, FACTURE.REGLER, FACTURE.CREDIT, FACTURE.REMARQUE, UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER , ";
            commandText+="UTILISATEUR.PRENOM_USER+' '+UTILISATEUR.NOM_USER as USERNAME ";
            commandText+="FROM            FACTURE INNER JOIN ";
            commandText+="LIGNE_FACTURE ON FACTURE.CODE_FACTURE = LIGNE_FACTURE.CODE_FACTURE INNER JOIN ";
            commandText+="ARTICLE ON LIGNE_FACTURE.CODE_ARTICLE = ARTICLE.CODE_ARTICLE INNER JOIN ";
            commandText += "UTILISATEUR ON FACTURE.CODE_USER = UTILISATEUR.CODE_USER INNER JOIN ";
            commandText += "SOCIETE ON UTILISATEUR.CODE_SOCIETE = SOCIETE.CODE_SOCIETE where FACTURE.CODE_FACTURE='"+CODE_FACTURE+"'";
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(commandText, CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
                
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GET_LISTE_VENTE_PAR_DATE(DateTime date_debut, DateTime date_fin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select article.code_article, designation_article, SUM(ligne_facture.qte) as qte, SUM(ligne_facture.qte*LIGNE_FACTURE.PRIX_U_TTC) as total from FACTURE inner join LIGNE_FACTURE on FACTURE.CODE_FACTURE=LIGNE_FACTURE.CODE_FACTURE inner join ARTICLE on ARTICLE.CODE_ARTICLE=LIGNE_FACTURE.CODE_ARTICLE where convert(nvarchar,FACTURE.DATE_FACTURE,103) between '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE ", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
                
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(DateTime date_debut, DateTime date_fin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select facture.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE* FACTURE.MONTANT_TTC/100 as REMISE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE-FACTURE.CREDIT as  REGLER, FACTURE.CREDIT , UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER as [USER], CLIENT.RS_CLIENT from FACTURE inner join UTILISATEUR on FACTURE.CODE_USER=UTILISATEUR.CODE_USER inner join CLIENT on FACTURE.CODE_CLIENT=CLIENT.CODE_CLIENT WHERE convert(nvarchar,FACTURE.DATE_FACTURE,103) BETWEEN '"+date_debut.ToShortDateString()+"' and '"+date_fin.ToShortDateString()+"' order by FACTURE.DATE_FACTURE", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }

            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal code_user)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select facture.CODE_FACTURE, FACTURE.DATE_FACTURE, FACTURE.MONTANT_TTC, FACTURE.TAUX_REMISE* FACTURE.MONTANT_TTC/100 as REMISE, FACTURE.MONTANT_TOTAL_FACTURE, FACTURE.MONTANT_TOTAL_FACTURE-FACTURE.CREDIT as  REGLER, FACTURE.CREDIT , UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER as [USER], CLIENT.RS_CLIENT from FACTURE inner join UTILISATEUR on FACTURE.CODE_USER=UTILISATEUR.CODE_USER inner join CLIENT on FACTURE.CODE_CLIENT=CLIENT.CODE_CLIENT WHERE convert(nvarchar,FACTURE.DATE_FACTURE,103) BETWEEN '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' and FACTURE.CODE_USER='"+code_user+"' order by FACTURE.DATE_FACTURE", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }

            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal code_user)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select article.code_article, designation_article, SUM(ligne_facture.qte) as qte, SUM(ligne_facture.qte*LIGNE_FACTURE.PRIX_U_TTC) as [totalv] , UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER  as UTILISATEUR from FACTURE inner join LIGNE_FACTURE on FACTURE.CODE_FACTURE=LIGNE_FACTURE.CODE_FACTURE inner join ARTICLE on ARTICLE.CODE_ARTICLE=LIGNE_FACTURE.CODE_ARTICLE inner join UTILISATEUR on UTILISATEUR.CODE_USER=FACTURE.CODE_USER where FACTURE.CODE_USER='" + code_user + "' and convert(nvarchar,FACTURE.DATE_FACTURE,103) between  '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER, ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE ", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }

            }
            catch (Exception)
            {
            }
            return dt;
        }

        public DataTable LOAD_GAIN_DETAIL(DateTime datedebut, DateTime datefin)
        {
            DataTable dt = new DataTable();
            
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, SUM(LIGNE_FACTURE.QTE) as qtte,  SUM(LIGNE_FACTURE.QTE*LIGNE_FACTURE.PRIX_U_TTC) as total_v, SUM(LIGNE_FACTURE.QTE*ARTICLE.PRIX_HT_A_ARTICLE) as total_a, SUM(LIGNE_FACTURE.QTE*LIGNE_FACTURE.PRIX_U_TTC)- SUM(LIGNE_FACTURE.QTE*ARTICLE.PRIX_HT_A_ARTICLE) as total_g from LIGNE_FACTURE inner join ARTICLE on LIGNE_FACTURE.CODE_ARTICLE=ARTICLE.CODE_ARTICLE inner join FACTURE on FACTURE.CODE_FACTURE=LIGNE_FACTURE.CODE_FACTURE where convert(date, FACTURE.DATE_FACTURE) between CONVERT(date,'" + datedebut.ToShortDateString() + "') and CONVERT(date,'" + datefin.ToShortDateString() + "') group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE order by ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                    da.Fill(dt);
                }
            }
            catch (Exception er)
            {

            }
            return dt;
        }

        public DataTable LOAD_qte_retour(DateTime datedebut, DateTime datefin)
        {
            DataTable dt_retour = new DataTable();

            try
            {
                using (SqlDataAdapter da_retour = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT) as qtte, SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT)- SUM(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*ARTICLE.PRIX_HT_A_ARTICLE) as total_p  from LIGNE_BRETOUR_CLIENT inner join BON_RETOUR_CLIENT on LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT=BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT inner join ARTICLE on ARTICLE.CODE_ARTICLE=LIGNE_BRETOUR_CLIENT.CODE_ARTICLE where CONVERT(date, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT) between CONVERT(date,'" + datedebut.ToShortDateString() + "') and CONVERT(date,'" + datefin.ToShortDateString() + "') group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE order by ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx))
                {
                    da_retour.FillSchema(dt_retour, SchemaType.Source);
                    da_retour.Fill(dt_retour);
                }
            }
            catch (Exception er)
            {

            }
            return dt_retour;
        }
        
        #endregion
    }

    class CHM_FOURNISSEUR_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_FOURNISSEUR
    {        
        #region CHM_FOURNISSEUR Membres

        public string DELETE_FOURNISSEUR(string CODE)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM FOURNISSEUR WHERE  (CODE_FOURNISSEUR= @CODE_FOURNISSEUR)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public string INSERT_FOURNISSEUR(string CODE, string REF, string RS, string ADRESSE, string TEL, string FAX, string EMAIL, string SITEWEB, string RIB, string CODE_TVA)
        {
            try
            {

                using (SqlCommand cmd_code = new SqlCommand("SELECT     ISNULL(MAX(CODE_FOURNISSEUR), 0) + 1  FROM         FOURNISSEUR", CONNECTION_PARAM.cnx))
                {
                    CODE = ((decimal)cmd_code.ExecuteScalar()).ToString();
                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO FOURNISSEUR (CODE_FOURNISSEUR, REF_FOURNISSEUR, RS_FOURNISSEUR, ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR, FAX_FOURNISSEUR, EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR) VALUES     (@CODE_FOURNISSEUR, @REF_FOURNISSEUR, @RS_FOURNISSEUR, @ADRESSE_FOURNISSEUR, @TEL_FOURNISSEUR, @FAX_FOURNISSEUR, @EMAIL_FOURNISSEUR, @SITE_WEB_FOURNISSEUR, @RIB_FOURNISSEUR, @CODE_TVA_FOURNISSEUR)", CONNECTION_PARAM.cnx))
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
                    cmd.ExecuteNonQuery();
                }
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public DataTable LOAD_FOURNISSEUR(string CODE)
        {
            using (SqlDataAdapter FOURNISSEUR_da = new SqlDataAdapter("SELECT * FROM FOURNISSEUR WHERE CODE_FOURNISSEUR= @CODE_FOURNISSEUR", CONNECTION_PARAM.cnx))
            {
                FOURNISSEUR_da.SelectCommand.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE;
                DataTable FOURNISSEUR_dt = new DataTable();
                FOURNISSEUR_da.FillSchema(FOURNISSEUR_dt, SchemaType.Source);
                FOURNISSEUR_da.Fill(FOURNISSEUR_dt);
                return FOURNISSEUR_dt;
            }
        }

        public DataTable SEARCH_FOURNISSEUR(string INDICE)
        {
            SqlDataAdapter FOURNISSEUR_da = new SqlDataAdapter("SELECT     CODE_FOURNISSEUR, REF_FOURNISSEUR, RS_FOURNISSEUR, ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR, FAX_FOURNISSEUR, EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR FROM FOURNISSEUR WHERE (RS_FOURNISSEUR like '%" + INDICE + "%') OR (ADRESSE_FOURNISSEUR like '%" + INDICE + "%') OR ( REF_FOURNISSEUR like '%" + INDICE + "%') OR ( EMAIL_FOURNISSEUR like '%" + INDICE + "%')", CONNECTION_PARAM.cnx);
            DataTable FOURNISSEUR_dt = new DataTable();
            FOURNISSEUR_da.FillSchema(FOURNISSEUR_dt, SchemaType.Source);
            FOURNISSEUR_da.Fill(FOURNISSEUR_dt);
            return FOURNISSEUR_dt;
        }

        public string UPDATE_FOURNISSEUR(string CODE, string REF, string RS, string ADRESSE, string TEL, string FAX, string EMAIL, string SITEWEB, string RIB, string CODE_TVA)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE FOURNISSEUR SET  REF_FOURNISSEUR=@REF_FOURNISSEUR, RS_FOURNISSEUR=@RS_FOURNISSEUR, ADRESSE_FOURNISSEUR=@ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR=@TEL_FOURNISSEUR, FAX_FOURNISSEUR=@FAX_FOURNISSEUR, EMAIL_FOURNISSEUR=@EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR=@SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR=@RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR=@CODE_TVA_FOURNISSEUR WHERE (CODE_FOURNISSEUR=@CODE_FOURNISSEUR)", CONNECTION_PARAM.cnx);
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
                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        public DataTable SELECT_ALL_FOURNISSEURS()
        {
            SqlDataAdapter FOURNISSEUR_da = new SqlDataAdapter(" SELECT CODE_FOURNISSEUR, REF_FOURNISSEUR, RS_FOURNISSEUR, ADRESSE_FOURNISSEUR, TEL_FOURNISSEUR, FAX_FOURNISSEUR, EMAIL_FOURNISSEUR, SITE_WEB_FOURNISSEUR, RIB_FOURNISSEUR, CODE_TVA_FOURNISSEUR FROM FOURNISSEUR", CONNECTION_PARAM.cnx);
            DataTable FOURNISSEUR_dt = new DataTable();
            FOURNISSEUR_da.FillSchema(FOURNISSEUR_dt, SchemaType.Source);
            FOURNISSEUR_da.Fill(FOURNISSEUR_dt);
            return FOURNISSEUR_dt;
        }

        

        public string NEW_CODE(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }

    class CHM_MAGAZIN_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_MAGAZIN
    {
        #region CHM_MAGAZIN Membres       
               
        public DataTable LOAD_MAGAZIN(string CODE)
        {
            SqlDataAdapter MAGAZIN_da = new SqlDataAdapter("SELECT CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE FROM MAGAZIN WHERE CODE_MAG= @CODE_MAG", CONNECTION_PARAM.cnx);
            MAGAZIN_da.SelectCommand.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE;
            DataTable MAGAZIN_dt = new DataTable();
            MAGAZIN_da.FillSchema(MAGAZIN_dt, SchemaType.Source);
            MAGAZIN_da.Fill(MAGAZIN_dt);
            return MAGAZIN_dt;
        }

        public DataTable SEARCH_MAGAZIN(string INDICE)
        {
            SqlDataAdapter MAGAZIN_da = new SqlDataAdapter("SELECT     CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE FROM MAGAZIN WHERE (NOM_MAG like '%" + INDICE + "%')", CONNECTION_PARAM.cnx);
            DataTable MAGAZIN_dt = new DataTable();
            MAGAZIN_da.FillSchema(MAGAZIN_dt, SchemaType.Source);
            MAGAZIN_da.Fill(MAGAZIN_dt);
            return MAGAZIN_dt;
        }

        public DataTable SELECT_ALL_MAGAZIN()
        {
            using (SqlDataAdapter MAGAZIN_da = new SqlDataAdapter("SELECT CODE_MAG, NOM_MAG, ADRESSE_MAG, TEL_MAG, CODE_SOCIETE, RS_SOCIETE FROM MAGAZIN", CONNECTION_PARAM.cnx))
            {
                MAGAZIN_da.SelectCommand.Transaction = CONNECTION_PARAM.trans;
                DataTable MAGAZIN_dt = new DataTable();
                MAGAZIN_da.FillSchema(MAGAZIN_dt, SchemaType.Source);
                MAGAZIN_da.Fill(MAGAZIN_dt);
                return MAGAZIN_dt;
            }
        }
                          
        RESULT_QUERY CHM_MAGAZIN.DELETE_MAGAZIN(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {

                res.CODE = CODE;
                SqlCommand cmd = new SqlCommand("DELETE FROM MAGAZIN WHERE  (CODE_MAG= @CODE_MAG)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE;

                cmd.ExecuteNonQuery();
                res.MESSAGE = "Deleted with succes.\n  „ «·Õ–› »‰Ã«Õ";
                
            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        RESULT_QUERY CHM_MAGAZIN.INSERT_MAGAZIN(string CODE, string NOM, string ADRESSE, string TEL, string CODE_SOCIETE, string AGENCE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                    res.MESSAGE = "Saved with succes \n  „ «·Õ›Ÿ »‰Ã«Õ";
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

        RESULT_QUERY CHM_MAGAZIN.UPDATE_MAGAZIN(string CODE, string NOM, string ADRESSE, string TEL, string CODE_SOCIETE, string AGENCE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
                cmd.Transaction = sqlTrans;
                try
                {
                    //cmd.CommandText = "SELECT CODE_SOCIETE FROM SOCIETE WHERE (RS_SOCIETE LIKE '%" + AGENCE + "%')";
                    //decimal code_societe = (decimal)cmd.ExecuteScalar();

                    res.CODE = CODE;
                    cmd .CommandText="UPDATE    MAGAZIN SET               NOM_MAG =@NOM_MAG, ADRESSE_MAG =@ADRESSE_MAG, TEL_MAG=@TEL_MAG, CODE_SOCIETE=@CODE_SOCIETE, RS_SOCIETE=@RS_SOCIETE WHERE  (CODE_MAG=@CODE_MAG)";
                    cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@NOM_MAG", SqlDbType.NVarChar).Value = NOM;
                    cmd.Parameters.Add("@ADRESSE_MAG", SqlDbType.NVarChar).Value = ADRESSE;
                    cmd.Parameters.Add("@TEL_MAG", SqlDbType.NVarChar).Value = TEL;
                    cmd.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = CODE_SOCIETE;
                    cmd.Parameters.Add("@RS_SOCIETE", SqlDbType.NVarChar).Value = AGENCE;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    res.MESSAGE = "Modification done with succes.\n „ «· ⁄œÌ· »‰Ã«Õ";
                        

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

        


        public string NEW_CODE(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
    class CHM_CATEGORIE_ARTICLE_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_CATEGORIE_ARTICLE
    {
        #region CHM_CATEGORIE_ARTICLE Membres

        public RESULT_QUERY DELETE_CATEGORIE(string CODE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                res.CODE = CODE;
                SqlCommand cmd = new SqlCommand("DELETE FROM CATEGORIE WHERE  (CODE_CATEG= @CODE_CATEG)", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;

                
                cmd.ExecuteNonQuery();
                res.MESSAGE = "Deleted succesfully.\n  „ «·Õ–› »‰Ã«Õ";
            }
            catch (Exception error)
            {
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        public RESULT_QUERY INSERT_CATEGORIE(string CODE, string LABEL, string DESC)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
                cmd.Transaction = sqlTrans;

                try
                {
                    
                    

                    cmd.CommandText = "SELECT     ISNULL(MAX(CODE_CATEG), 0) + 1  FROM         CATEGORIE";
                    CODE = ((decimal)cmd.ExecuteScalar()).ToString();

                    res.CODE = CODE;

                    cmd.CommandText="INSERT INTO CATEGORIE (CODE_CATEG, LIB_CATEG, DESCRIPTION_CATEG) VALUES     (@CODE_CATEG, @LIB_CATEG, @DESC_CATEG)";
                    cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@LIB_CATEG", SqlDbType.NVarChar).Value = LABEL;
                    cmd.Parameters.Add("@DESC_CATEG", SqlDbType.NVarChar).Value = DESC;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    sqlTrans.Commit();
                    res.MESSAGE = "Category added with succes.\n „  ≈÷«›… «·„Ã„Ê⁄… »‰Ã«Õ";
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

        public DataTable LOAD_CATEGORIE(string CODE)
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT * FROM CATEGORIE WHERE CODE_CATEG= @CODE_CATEG", CONNECTION_PARAM.cnx);
            CATEGORIE_da.SelectCommand.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_da.FillSchema(CATEGORIE_dt, SchemaType.Source);
            CATEGORIE_da.Fill(CATEGORIE_dt);
            return CATEGORIE_dt;
        }

        public DataTable SEARCH_CATEGORIE(string INDICE)
        {
            SqlDataAdapter CATEG_da = new SqlDataAdapter("SELECT     CODE_CATEG, LIB_CATEG, DESCRIPTION_CATEG FROM CATEGORIE WHERE (LIB_CATEG like '%" + INDICE + "%')", CONNECTION_PARAM.cnx);
            DataTable CATEG_dt = new DataTable();
            CATEG_da.FillSchema(CATEG_dt, SchemaType.Source);
            CATEG_da.Fill(CATEG_dt);
            return CATEG_dt;
        }

        public DataTable SELECT_ALL_CATEGORIE()
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT *, CODE_CATEG as code, LIB_CATEG as ref FROM CATEGORIE", CONNECTION_PARAM.cnx);
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_da.FillSchema(CATEGORIE_dt, SchemaType.Source);
            CATEGORIE_da.Fill(CATEGORIE_dt);
            return CATEGORIE_dt;
        }

        public DataTable SELECT_LISTE_CATEGORIE()
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT * FROM CATEGORIE", CONNECTION_PARAM.cnx);
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_da.FillSchema(CATEGORIE_dt, SchemaType.Source);
            CATEGORIE_da.Fill(CATEGORIE_dt);
            return CATEGORIE_dt;
        }

        public RESULT_QUERY UPDATE_CATEGORIE(string CODE, string LABEL, string DESC)
        {
             
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlTransaction sqlTrans = CONNECTION_PARAM.cnx.BeginTransaction();
                SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
                cmd.Transaction = sqlTrans;
                try
                {
                   

                    res.CODE = CODE;
                    cmd.CommandText = "UPDATE    CATEGORIE SET               LIB_CATEG =@LIB_CATEG, DESCRIPTION_CATEG =@DESCRIPTION_CATEG WHERE  (CODE_CATEG=@CODE_CATEG)";
                    cmd.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
                    cmd.Parameters.Add("@LIB_CATEG", SqlDbType.NVarChar).Value = LABEL;
                    cmd.Parameters.Add("@DESCRIPTION_CATEG", SqlDbType.NVarChar).Value = DESC;
                    cmd.ExecuteNonQuery();
                
                    cmd.Parameters.Clear();
                    res.MESSAGE = "Modification done with succes.\n „ «· ⁄œÌ· »‰Ã«Õ";


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

        public string NEW_CODE(int nbCHIFRE)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        
        public DataTable SELECT_CATEG_PRODUCTS(string param)
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT *, CODE_ARTICLE as code, DESIGNATION_ARTICLE as ref FROM ARTICLE WHERE (CODE_CATEG = '" + param + "')", CONNECTION_PARAM.cnx);
            //CATEGORIE_da.SelectCommand.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_da.FillSchema(CATEGORIE_dt, SchemaType.Source);
            CATEGORIE_da.Fill(CATEGORIE_dt);
            return CATEGORIE_dt;
        }

        public DataTable LOAD_SCHEMA_ARTICLE()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ARTICLE", CONNECTION_PARAM.cnx))
                {
                    da.FillSchema(dt, SchemaType.Source);
                }

            }
            catch (Exception)
            {
            }
            return dt;
        }

       
        public DataTable LOAD_ARTICLE_PAR_REF(string REF)
        {
            SqlDataAdapter CATEGORIE_da = new SqlDataAdapter("SELECT * FROM ARTICLE WHERE (DESIGNATION_ARTICLE LIKE '" + REF + "')", CONNECTION_PARAM.cnx);
            //CATEGORIE_da.SelectCommand.Parameters.Add("@CODE_CATEG", SqlDbType.Decimal).Value = CODE;
            DataTable CATEGORIE_dt = new DataTable();
            CATEGORIE_da.FillSchema(CATEGORIE_dt, SchemaType.Source);
            CATEGORIE_da.Fill(CATEGORIE_dt);
            return CATEGORIE_dt;
        }

        #endregion
    }
    class CHM_SOCIETE_DEF: MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_SOCIETE
    {
        #region CHM_SOCIETE Membres

        public RESULT_QUERY ENREGISTRER(string CODE, string RS_SOCIETE, string DESCRIPTION_SOCIETE,
            string ADRESSE_SOCIETE, string CP_SOCIETE, string TEL_SOCIETE, string FAX_SOCIETE, 
            string EMAIL_SOCIETE, string SITE_WEB_SOCETE, byte[] LOGO_SOCIETE, string CODE_TVA_SOCIETE,
            string RIB_SOCIETE, decimal NUM_COMMANDE, string PREFIX1_COMMANDE, string PREFIX2_COMMANDE,
            decimal NUM_FACTURE, string PREFIX1_FACTURE, string PREFIXE2_FACTURE)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE    SOCIETE SET              RS_SOCIETE =@RS_SOCIETE, ADRESSE_SOCIETE =@ADRESSE_SOCIETE, DESCRIPTION_SOCIETE =@DESCRIPTION_SOCIETE , CP_SOCIETE =@CP_SOCIETE, TEL_SOCIETE =@TEL_SOCIETE , FAX_SOCIETE =@FAX_SOCIETE, EMAIL_SOCIETE =@EMAIL_SOCIETE,                     SITE_WEB_SOCETE =@SITE_WEB_SOCETE , LOGO_SOCIETE =@LOGO_SOCIETE , CODE_TVA_SOCIETE =@CODE_TVA_SOCIETE, RIB_SOCIETE =@RIB_SOCIETE, PREFIX1_COMMANDE =@PREFIX1_COMMANDE, PREFIX2_COMMANDE =@PREFIX2_COMMANDE ,                       NUM_COMMANDE =@NUM_COMMANDE, NUM_FACTURE =@NUM_FACTURE, PREFIX1_FACTURE =@PREFIX1_FACTURE, PREFIXE2_FACTURE =@PREFIXE2_FACTURE WHERE CODE_SOCIETE=1", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("@RS_SOCIETE", SqlDbType.NVarChar).Value=RS_SOCIETE;
                cmd.Parameters.Add("@DESCRIPTION_SOCIETE", SqlDbType.NVarChar).Value=DESCRIPTION_SOCIETE;
                cmd.Parameters.Add("@ADRESSE_SOCIETE", SqlDbType.NVarChar).Value=ADRESSE_SOCIETE;
                cmd.Parameters.Add("@CP_SOCIETE", SqlDbType.NVarChar).Value=CP_SOCIETE;
                cmd.Parameters.Add("@TEL_SOCIETE", SqlDbType.NVarChar).Value=TEL_SOCIETE;
                cmd.Parameters.Add("@FAX_SOCIETE", SqlDbType.NVarChar).Value=FAX_SOCIETE;
                cmd.Parameters.Add("@EMAIL_SOCIETE", SqlDbType.NVarChar).Value=EMAIL_SOCIETE;
                cmd.Parameters.Add("@SITE_WEB_SOCETE", SqlDbType.NVarChar).Value=SITE_WEB_SOCETE;
                cmd.Parameters.Add("@LOGO_SOCIETE", SqlDbType.Image).Value=(LOGO_SOCIETE!=null)? LOGO_SOCIETE :(object)DBNull.Value;
                cmd.Parameters.Add("@CODE_TVA_SOCIETE", SqlDbType.NVarChar).Value=CODE_TVA_SOCIETE;
                cmd.Parameters.Add("@RIB_SOCIETE", SqlDbType.NVarChar).Value=RIB_SOCIETE;
                cmd.Parameters.Add("@NUM_COMMANDE", SqlDbType.Decimal).Value=NUM_COMMANDE;
                cmd.Parameters.Add("@PREFIX1_COMMANDE", SqlDbType.NVarChar).Value=PREFIX1_COMMANDE;
                cmd.Parameters.Add("@PREFIX2_COMMANDE", SqlDbType.NVarChar).Value=PREFIX2_COMMANDE;
                cmd.Parameters.Add("@NUM_FACTURE", SqlDbType.Decimal).Value=NUM_FACTURE;
                cmd.Parameters.Add("@PREFIX1_FACTURE", SqlDbType.NVarChar).Value=PREFIX1_FACTURE;
                cmd.Parameters.Add("@PREFIXE2_FACTURE", SqlDbType.NVarChar).Value=PREFIXE2_FACTURE;
                cmd.ExecuteNonQuery();
                res.MESSAGE="Informations saved with succes.\n „ Õ›Ÿ «·»Ì«‰«  »‰Ã«Õ.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        public DataTable LOAD()
        {
            DataTable dt = new DataTable();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     COUNT(CODE_SOCIETE)   FROM         SOCIETE";
                int c = (int)cmd.ExecuteScalar();
                if (c == 0)
                {
                    cmd.CommandText = "INSERT INTO SOCIETE                      (CODE_SOCIETE, NUM_COMMANDE, NUM_FACTURE) VALUES     (1,0,0)";
                    cmd.ExecuteNonQuery();
                }
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.CommandText = "SELECT * FROM SOCIETE";
                da.FillSchema(dt,SchemaType.Source);
                da.Fill(dt);
                sqltrans.Commit();

            }
            catch(Exception er) 
            {
                sqltrans.Rollback();
            }
            return dt;
        }

        

        public DataTable SELECT_ALL_SOCIETE()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM SOCIETE", CONNECTION_PARAM.cnx);
            da.FillSchema(dt,SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        


        public DataTable VIEW_SOCIETE(string CODE_SOCIETE)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SOCIETE WHERE CODE_SOCIETE=@CODE_SOCIETE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_SOCIETE", SqlDbType.Decimal).Value = CODE_SOCIETE;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
    class CHM_UTILISATEUR_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_UTILISATEUR
    {
        #region CHM_UTILISATEUR Membres

        public RESULT_QUERY DELETE_UTILISATEUR(string CODE_USER)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM UTILISATEUR WHERE CODE_USER=@CODE_USER", CONNECTION_PARAM.cnx);
                cmd.Parameters.Add("CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
                cmd.ExecuteNonQuery();
                res.MESSAGE = "Delete with succes.\n „ «·Õ–› »‰Ã«Õ.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        public RESULTAT_UTILISATEUR IDENTIFIER(string LOGIN_USER, string PASSWORD_USER)
        {
            RESULTAT_UTILISATEUR res = new RESULTAT_UTILISATEUR();

            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                    res.MESSAGE = "User not identified.\nÂ–« «·„” Œœ„ €Ì— „⁄—Ê›.";
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

        public RESULT_QUERY INSERT_UTILISATEUR(string CODE_USER, string NOM_USER, string PRENOM_USER, byte[] PHOTO_USER, string LOGIN_USER, string PASSWORD_USER, bool ETAT_USER, string SOCIETE, string FONCTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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

                res.MESSAGE = "Informations saved with succes.\n „ Õ›Ÿ «·»Ì«‰«  »‰Ã«Õ.";
            }
            catch(Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
                sqltrans.Rollback();
            }
            return res;
        }

        public DataTable LOAD_UTILISATEUR(string CODE_USER)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UTILISATEUR WHERE (CODE_USER = @CODE_USER)", CONNECTION_PARAM.cnx);
            cmd.SelectCommand.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
            DataTable dt = new DataTable();
            cmd.FillSchema(dt, SchemaType.Source);
            cmd.Fill(dt);
            return dt;
        }

        public DataTable RECHERCHE_UTILISATEUR(string param)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UTILISATEUR WHERE (NOM_USER LIKE '%"+param+"%') OR (PRENOM_USER LIKE '%"+param+"%') OR (LOGIN_USER LIKE '%"+param+"%')", CONNECTION_PARAM.cnx);
            
            DataTable dt = new DataTable();
            cmd.FillSchema(dt, SchemaType.Source);
            cmd.Fill(dt);
            return dt;
        }

        public DataTable SELECT_ALL_UTILISATEUR()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM UTILISATEUR ", CONNECTION_PARAM.cnx);
            
            DataTable dt = new DataTable();
            cmd.FillSchema(dt, SchemaType.Source);
            cmd.Fill(dt);
            return dt;
        }

        public DataTable SELECT_ALL_NOM_UTILISATEUR()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT CODE_USER, PRENOM_USER+' '+NOM_USER AS NOM_UTILISATEUR FROM UTILISATEUR ", CONNECTION_PARAM.cnx);

            DataTable dt = new DataTable();
            cmd.FillSchema(dt, SchemaType.Source);
            cmd.Fill(dt);
            return dt;
        }

        public RESULT_QUERY UPDATE_UTILISATEUR(string CODE_USER, string NOM_USER, string PRENOM_USER, byte[] PHOTO_USER, string LOGIN_USER, string PASSWORD_USER, bool ETAT_USER, string SOCIETE, string FONCTION)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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

                res.MESSAGE = "Informations saved with succes.\n „ Õ›Ÿ «·»Ì«‰«  »‰Ã«Õ.";
            }
            catch (Exception er)
            {
                res.OK = false;
                res.MESSAGE = er.Message;
                sqltrans.Rollback();
            }
            return res;
        }

        


        public DataTable SELECT_FONCTION()
        {
            DataTable dt = new DataTable();
            
            
            SqlDataAdapter da = new SqlDataAdapter("SELECT LIB_FONCTION_USER FROM FONCTION_UTILISATEUR", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;

        }

        


        public DataTable SELECT_B_LIV(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_USER=@CODE_USER", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable SELECT_COMMANDE(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMMANDE WHERE CODE_USER=@CODE_USER", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable SELECT_FACTURE(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_USER=@CODE_USER", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable SELECT_REGLEMENT(string CODE_USER)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BON_DE_LIVRAISON WHERE CODE_USER=@CODE_USER", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
    class CHM_STOCK_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_STOCK
    {
        #region CHM_STOCK Membres

        public RESULT_QUERY ADD_ARTICLE_EN_STOCK()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DataTable SEARCH_ARTICLE_STOCK( string param)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     stock.CODE_MAG, magazin.NOM_MAG, stock.CODE_ARTICLE, article.REF_ARTICLE, article.DESIGNATION_ARTICLE, stock.QTTE_STOCK FROM         STOCK inner join article on stock.code_article=article.code_article inner join magazin on stock.code_mag=magazin.code_mag WHERE (DESIGNATION_ARTICLE LIKE '" + param + "')", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
           

            return dt;
        }

        public DataTable SELECT_ALL_ARTICLE_EN_STOCK()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT        STOCK.CODE_MAG, STOCK.CODE_ARTICLE, STOCK.QTTE_STOCK, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE,                          ARTICLE.DESCRIPTION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE, ARTICLE.QTE_MIN_ARTICLE, ARTICLE.PHOTO_ARTICLE, ARTICLE.UNITE_QTE_ARTICLE,                          ARTICLE.PRIX_HT_A_ARTICLE, ARTICLE.PRIX_HT_V_ARTICLE, ARTICLE.MAX_REMISE, ARTICLE.PRIX_SOLDE, ARTICLE.CODE_BARRE_ARTICLE_SOLDE,                          MAGAZIN.NOM_MAG, MAGAZIN.ADRESSE_MAG, MAGAZIN.TEL_MAG, MAGAZIN.CODE_SOCIETE FROM            ARTICLE INNER JOIN                          MAGAZIN ON ARTICLE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                          STOCK ON ARTICLE.CODE_ARTICLE = STOCK.CODE_ARTICLE AND MAGAZIN.CODE_MAG = STOCK.CODE_MAG WHERE ARTICLE.ETAT_ARTICLE='false'", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            
            return dt;
        }

        public DataTable SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN(decimal CODE_MAG)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT        STOCK.CODE_MAG, STOCK.CODE_ARTICLE, STOCK.QTTE_STOCK, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.MARQUE_ARTICLE, ARTICLE.DESCRIPTION_ARTICLE, ARTICLE.CODE_BARRE_ARTICLE, ARTICLE.QTE_MIN_ARTICLE, ARTICLE.PHOTO_ARTICLE, ARTICLE.UNITE_QTE_ARTICLE, ARTICLE.PRIX_HT_A_ARTICLE, ARTICLE.PRIX_HT_V_ARTICLE, ARTICLE.MAX_REMISE, ARTICLE.PRIX_SOLDE, ARTICLE.CODE_BARRE_ARTICLE_SOLDE, MAGAZIN.NOM_MAG, MAGAZIN.ADRESSE_MAG, MAGAZIN.TEL_MAG, MAGAZIN.CODE_SOCIETE FROM            ARTICLE INNER JOIN MAGAZIN ON ARTICLE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN STOCK ON ARTICLE.CODE_ARTICLE = STOCK.CODE_ARTICLE AND MAGAZIN.CODE_MAG = STOCK.CODE_MAG WHERE ARTICLE.ETAT_ARTICLE='false' AND STOCK.QTTE_STOCK>0 AND STOCK.CODE_MAG='" + CODE_MAG + "'", CONNECTION_PARAM.cnx);            
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }



        public DataTable SELECT_ARTICLE_EN_RUPTURE_DE_STOCK()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
    class CHM_REGLEMENT_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_REGLEMENT
    {
        #region CHM_REGLEMENT Membres

        public RESULT_QUERY INSERT_REGLEMENT(string CODE_FACTURE, DateTime DATE_REG_CLT, string MODE_REGLEMENT_CLIENT, string MONTANT_REGLEMENT_CLIENT, string NUM_PIECE_CLIENT, string BANQUE_CLIENT, string OBSERVATION, string CODE_CLIENT)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT CODE_COMPTE_CLIENT FROM COMPTE_CLIENT WHERE CODE_CLIENT=@CODE_CLIENT";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT;
                decimal CODE_COMPTE = (decimal)cmd.ExecuteScalar();
                cmd.Parameters.Clear();

                cmd.CommandText = "SELECT ISNULL(MAX(CODE_REGLEMENT_CLIENT), 0) + 1 FROM REGLEMENT_CLIENT";
                decimal code_reg = (decimal)cmd.ExecuteScalar();
                res.CODE= code_reg.ToString();

                cmd.CommandText="INSERT INTO REGLEMENT_CLIENT ( CODE_REGLEMENT_CLIENT , CODE_FACTURE, DATE_REG_CLT, MODE_REGLEMENT_CLT, MONTANT_REG_CLIENT, NUM_PIECE_CLIENT, BANQUE_CLIENT, OBSERVATION, CODE_COMPTE_CLIENT) VALUES ( @CODE_REGLEMENT_CLIENT , @CODE_FACTURE, @DATE_REG_CLT, @MODE_REGLEMENT_CLIENT, @MONTANT_REG_CLIENT, @NUM_PIECE_CLIENT, @BANQUE_CLIENT, @OBSERVATION, @CODE_COMPTE_CLIENT)";
                cmd.Parameters.Add("@CODE_REGLEMENT_CLIENT", SqlDbType.Decimal).Value = code_reg;
                cmd.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = CODE_FACTURE;
                cmd.Parameters.Add("@DATE_REG_CLT", SqlDbType.DateTime).Value = DATE_REG_CLT;
                cmd.Parameters.Add("@MODE_REGLEMENT_CLIENT", SqlDbType.NVarChar).Value = MODE_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@MONTANT_REG_CLIENT", SqlDbType.Decimal).Value = MONTANT_REGLEMENT_CLIENT;
                cmd.Parameters.Add("@BANQUE_CLIENT", SqlDbType.NVarChar).Value = BANQUE_CLIENT;
                cmd.Parameters.Add("@NUM_PIECE_CLIENT", SqlDbType.NVarChar).Value = NUM_PIECE_CLIENT;
                cmd.Parameters.Add("@OBSERVATION", SqlDbType.NVarChar).Value = OBSERVATION;
                cmd.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                sqltrans.Commit();
                res.OK = true;
                res.MESSAGE = "Regulation saved with succes.\n „ «·”œ«œ »‰Ã«Õ";
            }
            catch (Exception error)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = error.Message;
            }
            return res;
        }

        public DataTable SELECT_ALL_REGLEMENT()
        {
            DataTable dt=new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT", CONNECTION_PARAM.cnx))
            {
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable SELECT_REGLEMENT_CLIENT(string CODE_COMPTE_CLIENT)
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        

        

        public DataTable recherche_facture(string param)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FACTURE WHERE CODE_FACTURE=@CODE_FACTURE", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_FACTURE", SqlDbType.NVarChar).Value = param;
            da.SelectCommand.ExecuteNonQuery();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        


        public DataTable recherche_reglement_par_date(string param, string CODE_COMPTE_CLIENT)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE (DATE_REG_CLT LIKE '%" + param + "%') AND (CODE_COMPTE_CLIENT=@CODE_COMPTE_CLIENT)", CONNECTION_PARAM.cnx);
            
            da.SelectCommand.Parameters.Add("@CODE_COMPTE_CLIENT", SqlDbType.Decimal).Value = CODE_COMPTE_CLIENT;
            da.SelectCommand.ExecuteNonQuery();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        


        public DataTable recherche_reg_par_date(string param)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REGLEMENT_CLIENT WHERE (DATE_REG_CLT LIKE '%" + param + "%') ", CONNECTION_PARAM.cnx);

            
            da.SelectCommand.ExecuteNonQuery();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            return dt;
        }

        #endregion
    }
    class CHM_DEVI_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_DEVI
    {
        #region CHM_DEVI Membres

        public RESULT_QUERY DELETE_DEVIS(string CODE_DEVIS)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        RESULT_QUERY CHM_DEVI.INSERT_ARTICLE()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public RESULT_QUERY SAVE_DEVI(string CODE_CLIENT, DateTime DATE_DEVIS, object DATE_EXPIRATION_DEVIS, string CODE_USER, DataTable dt_lg_devis)
        {
            RESULT_QUERY res = new RESULT_QUERY();

            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            res.MESSAGE = "!";
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_COMMANDE) + 1 FROM         SOCIETE";
                decimal NUM_DEVIS = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";


                string PREFIX1_DEVIS = "DEV";

                cmd.CommandText = "SELECT     ISNULL(PREFIX2_COMMANDE, '') FROM         SOCIETE";
                string PREFIX2_DEVIS = (string)cmd.ExecuteScalar();

                cmd.CommandText = "UPDATE    SOCIETE SET              NUM_COMMANDE = NUM_COMMANDE +  1 WHERE CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                string CODE_DEVIS = PREFIX1_DEVIS + NUM_DEVIS.ToString() + PREFIX2_DEVIS;

                res.CODE = CODE_DEVIS;

                cmd.CommandText = "INSERT INTO DEVIS(CODE_DEVIS, CODE_CLIENT, DATE_SAISIE_DEVIS, DATE_EXPIRATION_DEVIS, CODE_USER) VALUES     (@CODE_DEVIS, @DATE_SAISIE_DEVIS,  @DATE_EXPIRATION_DEVIS, @CODE_CLIENT, @CODE_USER)"; res.MESSAGE = "erreur insertion";
                cmd.Parameters.Add("@CODE_DEVIS", SqlDbType.NVarChar).Value = CODE_DEVIS; res.MESSAGE = "erreur code commande";
                cmd.Parameters.Add("@DATE_SAISIE_DEVIS", SqlDbType.DateTime).Value = DATE_DEVIS; res.MESSAGE = "erreur code client";
                cmd.Parameters.Add("@DATE_EXPIRATION_DEVIS", SqlDbType.DateTime).Value = DATE_EXPIRATION_DEVIS; res.MESSAGE = "erreur insertion date commande";
                cmd.Parameters.Add("@CODE_CLIENT", SqlDbType.Decimal).Value = CODE_CLIENT; res.MESSAGE = "erreur priorite commande";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "erreur insertion code user";

                cmd.ExecuteNonQuery(); res.MESSAGE = "erreur execution requete!!!!!";
                cmd.Parameters.Clear();

                foreach (DataRow dr in dt_lg_devis.Rows)
                {
                    cmd.CommandText = "INSERT INTO LIGNE_DEVIS(CODE_DEVIS, CODE_ARTICLE, PRIX_HT_ARTICLE_DEV, QTE_LIGNE_DEVIS, TVA_ARTICLE_DEV) VALUES     (@CODE_DEVIS, @CODE_ARTICLE, @PRIX_HT_ARTICLE_DEV, @QTE_LIGNE_DEVIS, @TVA_ARTICLE_DEV)";
                    cmd.Parameters.Add("@CODE_DEVI", SqlDbType.NVarChar).Value = CODE_DEVIS;
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = dr["CODE_ARTICLE"];
                    cmd.Parameters.Add("@PRIX_HT_ARTICLE_DEV", SqlDbType.Decimal).Value = dr["PRIX_HT_ARTICLE"];
                    cmd.Parameters.Add("@TVA_ARTICLE_DEV", SqlDbType.Decimal).Value = dr["TVA_ARTICLE_DEV"];

                    cmd.Parameters.Add("@QTE_LIGNE_DEVIS", SqlDbType.Decimal).Value = dr["QTE_DEVIS"];

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }


                sqltrans.Commit();

                res.MESSAGE = "Informations saved with succes.\n „ Õ›Ÿ «·»Ì«‰«  »‰Ã«Õ.";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }

            return res;
        }

        public DataTable SELECT_ALL_DEVIS()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DEVIS", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }


        public DataTable LOAD_SCHEMA_LG_DEVIS()
        {
            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_DEVIS.TVA_ARTICLE_DEV, LIGNE_DEVIS.QTE_LIGNE_DEVIS, LIGNE_DEVIS.PRIX_HT_ARTICLE_DEV, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.CODE_ARTICLE, ARTICLE.MARQUE_ARTICLE, ARTICLE.DESCRIPTION_ARTICLE, ARTICLE.PRIX_HT_V_ARTICLE FROM LIGNE_DEVIS INNER JOIN ARTICLE ON LIGNE_DEVIS.CODE_ARTICLE = ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx);

            da.FillSchema(dt, SchemaType.Source);
            dt.Columns.Add("PRIX_TTC_LG_DEVIS", typeof(decimal));
            dt.Columns.Add("PRIX_TTC_TOTAL", typeof(decimal));
            dt.Columns.Add("PRIX_HT_TOTAL", typeof(decimal));



            return dt;
        }

        #endregion
    }

    class CHM_BON_RECEP_FOURNISSEUR_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_BON_RECEPTION_FOURNISSEUR
    {
        #region CHM_BON_RECEPTION_FOURNISSEUR Membres

        public RESULT_QUERY DELETE_BR_FR(decimal CODE_BRECEP)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(); 
            da = new SqlDataAdapter("SELECT [CODE_BRECEP]      ,[CODE_BR_FR]      ,[CODE_ARTICLE]      ,[QTE_LG_BR_FR]      ,[PRIX_ART_BR_FR]  FROM [LG_BR_FR] WHERE [CODE_BRECEP]='" + CODE_BRECEP + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            DataTable dt_br = new DataTable();
            SqlDataAdapter da_br = new SqlDataAdapter();
            da_br = new SqlDataAdapter("SELECT * FROM [BON_RECEP_FOURNISSEUR] WHERE [CODE_BRECEP]='" + CODE_BRECEP + "'", CONNECTION_PARAM.cnx);
            da_br.FillSchema(dt_br, SchemaType.Source);
            da_br.Fill(dt_br);
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                //TraÁabilitÈ
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
                    cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value =  prix_max ; res.MESSAGE = "17";
                    
                       
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
                res.MESSAGE = "Deleted with succes.\n „ «·Õ–› »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        public RESULT_QUERY INSERT_BR_FR(string CODE_BR_FR, decimal CODE_FOURNISSEUR, decimal CODE_MAG, DateTime DATE_BR_FR, decimal CODE_USER, decimal MNT_BR, decimal REMISE, DataTable dt_lg_br)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(); 
            da = new SqlDataAdapter("select * from stock inner join article on article.code_article=stock.code_article where stock.code_mag='" + CODE_MAG + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                cmd.CommandText = "SELECT     MAX(NUM_BON_RECEPTION) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1";
                decimal NUM_BRECEP = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion num commande";

                cmd.CommandText = "INSERT INTO BON_RECEP_FOURNISSEUR (CODE_BRECEP,CODE_BR_FR, CODE_FOURNISSEUR, DATE_BR_FR, CODE_USER, CODE_MAG, MNT_BR_FR, RESTE, REMISE)  VALUES        (@CODE_BRECEP,@CODE_BR_FR,@CODE_FOURNISSEUR,@DATE_BR_FR,@CODE_USER,@CODE_MAG,@MNT_BR_FR,@RESTE, @REMISE)"; res.MESSAGE = "request error";

                cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.NVarChar).Value = NUM_BRECEP; res.MESSAGE = "1";
                cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "1";
                cmd.Parameters.Add("@DATE_BR_FR", SqlDbType.DateTime).Value = DATE_BR_FR; res.MESSAGE = "2";
                cmd.Parameters.Add("@CODE_FOURNISSEUR", SqlDbType.Decimal).Value = CODE_FOURNISSEUR; res.MESSAGE = "3";
                cmd.Parameters.Add("@MNT_BR_FR", SqlDbType.Decimal).Value = MNT_BR; res.MESSAGE = "4";
                cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value = CODE_MAG; res.MESSAGE = "5";
                cmd.Parameters.Add("@CODE_USER", SqlDbType.Decimal).Value = CODE_USER; res.MESSAGE = "6";
                cmd.Parameters.Add("@REMISE", SqlDbType.Decimal).Value = REMISE;
                cmd.Parameters.Add("@RESTE", SqlDbType.Decimal).Value = (decimal)(MNT_BR*(1-REMISE/100));
                
                cmd.ExecuteNonQuery(); res.MESSAGE = "An error occured when executing request!!!!!";
                cmd.Parameters.Clear();



                DataTable article = new DataTable(); 
                             
                
                foreach (DataRow dr in dt_lg_br.Rows)
                {
                    cmd.CommandText = "INSERT INTO LG_BR_FR (CODE_BRECEP,CODE_BR_FR, CODE_ARTICLE, QTE_LG_BR_FR, PRIX_ART_BR_FR) VALUES (@CODE_BRECEP,@CODE_BR_FR,@CODE_ARTICLE,@QTE_LG_BR_FR,@PRIX_ART_BR_FR)";
                    cmd.Parameters.Add("@CODE_BRECEP", SqlDbType.NVarChar).Value = NUM_BRECEP; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_BR_FR", SqlDbType.NVarChar).Value = CODE_BR_FR; res.MESSAGE = "7";
                    cmd.Parameters.Add("@CODE_ARTICLE", SqlDbType.Decimal).Value = (decimal)dr["CODE_ARTICLE"]; res.MESSAGE = "8";
                    cmd.Parameters.Add("@QTE_LG_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["QTE_LG_BR_FR"]; res.MESSAGE = "9";
                    cmd.Parameters.Add("@PRIX_ART_BR_FR", SqlDbType.Decimal).Value = (decimal)dr["PRIX_ART_BR_FR"]; res.MESSAGE = "10";
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
                        cmd.ExecuteNonQuery(); res.MESSAGE = "Error in insertion product " + dr["CODE_ARTICLE"].ToString()+ "into stock!!!!!";
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
                        cmd.Parameters.Add("@PRIX_HT_A_ARTICLE", SqlDbType.Decimal).Value =(decimal)dr["PRIX_ART_BR_FR"];
                    cmd.ExecuteNonQuery(); 
                    cmd.Parameters.Clear();

                    

                }
                cmd.CommandText = "update  SOCIETE set   NUM_BON_RECEPTION=NUM_BON_RECEPTION+1 WHERE  CODE_SOCIETE =1";
                cmd.ExecuteNonQuery();

                sqltrans.Commit();
                res.OK = true;
                res.CODE = NUM_BRECEP.ToString();
                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;


            }
            return res;
        }

        public RESULT_QUERY UPDATE_BR_FR(decimal CODE_BRECEP, string CODE_BR_FR, decimal CODE_FOURNISSEUR, decimal CODE_MAG, DateTime DATE_BR_FR, decimal CODE_USER, decimal MNT_BR, decimal REMISE, DataTable dt_lg_br)
        {

            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock inner join article on article.code_article=stock.code_article where stock.code_mag='" + CODE_MAG + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            DataTable dt_detail = new DataTable();
            SqlDataAdapter da_detail = new SqlDataAdapter();
            da_detail = new SqlDataAdapter("SELECT [CODE_BRECEP]      ,[CODE_BR_FR]      ,[CODE_ARTICLE]      ,[QTE_LG_BR_FR]      ,[PRIX_ART_BR_FR]  FROM [LG_BR_FR] WHERE [CODE_BRECEP]='" + CODE_BRECEP + "'", CONNECTION_PARAM.cnx);
            da_detail.FillSchema(dt_detail, SchemaType.Source);
            da_detail.Fill(dt_detail);

            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;
            try
            {
                //TraÁabilitÈ
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
                    if (trouve==0)
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
                res.MESSAGE = "Changed with succes.\n „ «· ⁄œÌ· »‰Ã«Õ";
            }
            catch (Exception er)
            {
                sqltrans.Rollback();
                res.OK = false;
                res.MESSAGE = er.Message;
            }
            return res;
        }

        public DataTable LOAD_BR_FR(decimal CODE_BRECEP)
        {            
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT     dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP, dbo.BON_RECEP_FOURNISSEUR.CODE_BR_FR, dbo.BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR,                       dbo.BON_RECEP_FOURNISSEUR.DATE_BR_FR, dbo.BON_RECEP_FOURNISSEUR.REMISE, dbo.BON_RECEP_FOURNISSEUR.RESTE,                       dbo.BON_RECEP_FOURNISSEUR.CODE_MAG, dbo.BON_RECEP_FOURNISSEUR.MNT_BR_FR, dbo.BON_RECEP_FOURNISSEUR.CODE_USER,                       dbo.FOURNISSEUR.RS_FOURNISSEUR, dbo.UTILISATEUR.PRENOM_USER+' '+ dbo.UTILISATEUR.NOM_USER as [USER] FROM         dbo.BON_RECEP_FOURNISSEUR INNER JOIN                       dbo.FOURNISSEUR ON dbo.BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR = dbo.FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN                       dbo.UTILISATEUR ON dbo.BON_RECEP_FOURNISSEUR.CODE_USER = dbo.UTILISATEUR.CODE_USER WHERE dbo.BON_RECEP_FOURNISSEUR.CODE_BRECEP='" + CODE_BRECEP + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public decimal GET_SOMME_RECEP(DateTime datedebut, DateTime datefin)
        {
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.CommandText = "select isnull(SUM(LG_BR_FR.QTE_LG_BR_FR*LG_BR_FR.PRIX_ART_BR_FR),0) from BON_RECEP_FOURNISSEUR inner join LG_BR_FR on LG_BR_FR.CODE_BRECEP=BON_RECEP_FOURNISSEUR.CODE_BRECEP where CONVERT(nvarchar, BON_RECEP_FOURNISSEUR.DATE_BR_FR,103) between '"+datedebut.ToShortDateString()+"' and '"+datefin.ToShortDateString()+"'";
            decimal somme = (decimal)cmd.ExecuteScalar();
            return somme;
        }

        public DataTable LOAD_LIGNES_BR_FR(decimal CODE_BRECEP)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT        LG_BR_FR.CODE_ARTICLE, LG_BR_FR.QTE_LG_BR_FR, LG_BR_FR.PRIX_ART_BR_FR, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM            LG_BR_FR INNER JOIN  ARTICLE ON LG_BR_FR.CODE_ARTICLE = ARTICLE.CODE_ARTICLE WHERE LG_BR_FR.CODE_BRECEP='" + CODE_BRECEP + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable LOAD_SCHEMA_LIGNE_BR()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT        LG_BR_FR.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.REF_ARTICLE, LG_BR_FR.QTE_LG_BR_FR, LG_BR_FR.PRIX_ART_BR_FR FROM            LG_BR_FR INNER JOIN                          ARTICLE ON LG_BR_FR.CODE_ARTICLE = ARTICLE.CODE_ARTICLE", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            return dt;
        }

        public DataTable SELECT_ALL_BR_FR()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT        BON_RECEP_FOURNISSEUR.CODE_BRECEP,BON_RECEP_FOURNISSEUR.CODE_BR_FR, FOURNISSEUR.RS_FOURNISSEUR, BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR, BON_RECEP_FOURNISSEUR.DATE_BR_FR, BON_RECEP_FOURNISSEUR.CODE_USER, BON_RECEP_FOURNISSEUR.CODE_MAG,  BON_RECEP_FOURNISSEUR.MNT_BR_FR, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER +' '+ UTILISATEUR.PRENOM_USER as USERNAME, BON_RECEP_FOURNISSEUR.RESTE FROM            BON_RECEP_FOURNISSEUR INNER JOIN  FOURNISSEUR ON BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR = FOURNISSEUR.CODE_FOURNISSEUR INNER JOIN MAGAZIN ON BON_RECEP_FOURNISSEUR.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN UTILISATEUR ON BON_RECEP_FOURNISSEUR.CODE_USER = UTILISATEUR.CODE_USER ORDER BY BON_RECEP_FOURNISSEUR.DATE_BR_FR", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable IMPRIMER_BRECEP_FR(decimal CODE_BRECEP)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("SELECT        BON_RECEP_FOURNISSEUR.CODE_BR_FR, BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR, LG_BR_FR.CODE_ARTICLE, LG_BR_FR.QTE_LG_BR_FR,                          LG_BR_FR.PRIX_ART_BR_FR, ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE, FOURNISSEUR.RS_FOURNISSEUR, SOCIETE.RS_SOCIETE,                          SOCIETE.DESCRIPTION_SOCIETE, SOCIETE.ADRESSE_SOCIETE, SOCIETE.CP_SOCIETE, SOCIETE.TEL_SOCIETE, SOCIETE.FAX_SOCIETE,                          SOCIETE.EMAIL_SOCIETE, SOCIETE.SITE_WEB_SOCETE, SOCIETE.LOGO_SOCIETE, SOCIETE.CODE_TVA_SOCIETE, MAGAZIN.NOM_MAG,                          BON_RECEP_FOURNISSEUR.MNT_BR_FR, BON_RECEP_FOURNISSEUR.DATE_BR_FR FROM            BON_RECEP_FOURNISSEUR INNER JOIN                          LG_BR_FR ON BON_RECEP_FOURNISSEUR.CODE_BR_FR = LG_BR_FR.CODE_BR_FR INNER JOIN                          ARTICLE ON LG_BR_FR.CODE_ARTICLE = ARTICLE.CODE_ARTICLE INNER JOIN                          FOURNISSEUR ON BON_RECEP_FOURNISSEUR.CODE_FOURNISSEUR = FOURNISSEUR.CODE_FOURNISSEUR  INNER JOIN                          MAGAZIN ON BON_RECEP_FOURNISSEUR.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                          SOCIETE ON MAGAZIN.CODE_SOCIETE = SOCIETE.CODE_SOCIETE  WHERE BON_RECEP_FOURNISSEUR.CODE_BRECEP='" + CODE_BRECEP + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        #endregion       
    }

    class CHM_BRETOUR_CLIENT_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.CHM_BRETOUR_CLIENT
    {
        #region CHM_BRETOUR_CLIENT Membres

        public DataTable IMPRIMER_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     UTILISATEUR.CODE_USER, LIGNE_BRETOUR_CLIENT.CODE_ARTICLE, LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT, LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT, LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT * LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT as PRIX_TOTAL, SOCIETE.RS_SOCIETE, SOCIETE.DESCRIPTION_SOCIETE, SOCIETE.ADRESSE_SOCIETE, SOCIETE.CP_SOCIETE, SOCIETE.TEL_SOCIETE, SOCIETE.FAX_SOCIETE, SOCIETE.EMAIL_SOCIETE, SOCIETE.LOGO_SOCIETE, SOCIETE.SITE_WEB_SOCETE, BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.MNT_BRETOUR, BON_RETOUR_CLIENT.CODE_FACTURE, BON_RETOUR_CLIENT.CODE_MAG, UTILISATEUR.NOM_USER + ' ' + UTILISATEUR.PRENOM_USER AS utilisateur,                       ARTICLE.REF_ARTICLE, ARTICLE.DESIGNATION_ARTICLE FROM         UTILISATEUR INNER JOIN                      SOCIETE ON UTILISATEUR.CODE_SOCIETE = SOCIETE.CODE_SOCIETE INNER JOIN                      BON_RETOUR_CLIENT INNER JOIN                      LIGNE_BRETOUR_CLIENT ON BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT = LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT INNER JOIN                      ARTICLE ON LIGNE_BRETOUR_CLIENT.CODE_ARTICLE = ARTICLE.CODE_ARTICLE ON UTILISATEUR.CODE_USER = BON_RETOUR_CLIENT.CODE_USER WHERE BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT=@CODE_BRETOUR_CLIENT", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_BRETOUR_CLIENT", SqlDbType.NVarChar).Value=CODE_BRETOUR_CLIENT;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        

        public DataTable IMPRIMER_BR_CL_PAR_DATE(DateTime date_debut, DateTime date_fin)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATIOn_ARTICLE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT) as QTE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT) as Total from BON_RETOUR_CLIENT inner join LIGNE_BRETOUR_CLIENT on BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT=LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT inner join ARTICLE on LIGNE_BRETOUR_CLIENT.CODE_ARTICLE=ARTICLE.CODE_ARTICLE where CONVERT(nvarchar, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, 103) between '"+date_debut.ToShortDateString()+"' and '"+date_fin.ToShortDateString()+"' group by ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal CODE_USER)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATIOn_ARTICLE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT) as QTE, sum(LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT*LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT) as Total, UTILISATEUR.PRENOM_USER+' '+ UTILISATEUR.NOM_USER  as UTILISATEUR from BON_RETOUR_CLIENT inner join LIGNE_BRETOUR_CLIENT on BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT=LIGNE_BRETOUR_CLIENT.CODE_BRETOUR_CLIENT inner join ARTICLE on LIGNE_BRETOUR_CLIENT.CODE_ARTICLE=ARTICLE.CODE_ARTICLE inner join UTILISATEUR on UTILISATEUR.CODE_USER=BON_RETOUR_CLIENT.CODE_USER where BON_RETOUR_CLIENT.CODE_USER='" + CODE_USER + "' and CONVERT(nvarchar, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, 103) between '" + date_debut.ToShortDateString() + "' and '" + date_fin.ToShortDateString() + "' group by UTILISATEUR.NOM_USER, UTILISATEUR.PRENOM_USER, ARTICLE.CODE_ARTICLE, ARTICLE.DESIGNATION_ARTICLE", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public RESULT_QUERY INSERT_BRETOUR_CLIENT( DateTime DATE_BRETOUR_CLIENT, decimal CODE_USER, decimal MNT_BRETOUR, string CODE_FACTURE, decimal CODE_MAG, DataTable dt_lg_bretour)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter("select * from stock inner join article on article.code_article=stock.code_article where stock.code_mag='" + CODE_MAG + "'", CONNECTION_PARAM.cnx);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);

            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = sqltrans;

            cmd.CommandText = "SELECT     MAX(NUM_BRETOUR_CLIENT) + 1 FROM         SOCIETE WHERE  CODE_SOCIETE =1"; res.MESSAGE = "erreur selection num br";
            decimal NUM_BRETOUR = (decimal)cmd.ExecuteScalar(); res.MESSAGE = "erreur insertion br";

            string CODE_BRETOUR_CLIENT = "BR" + NUM_BRETOUR.ToString() +"/"+ DateTime.Now.Year.ToString();
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
                res.MESSAGE = "Saved with succes.\n „ «·Õ›Ÿ »‰Ã«Õ";
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

        public DataTable LOAD_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_BRETOUR_CLIENT, DATE_BRETOUR_CLIENT, CODE_USER, MNT_BRETOUR, CODE_FACTURE, CODE_MAG FROM         BON_RETOUR_CLIENT WHERE CODE_BRETOUR_CLIENT=@CODE_BRETOUR_CLIENT", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_BRETOUR_CLIENT", SqlDbType.NVarChar).Value = CODE_BRETOUR_CLIENT;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable LOAD_LIGNES_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     CODE_BRETOUR_CLIENT, CODE_ARTICLE, QTE_BRETOUR_CLIENT, PRIX_BRETOUR_CLIENT FROM         LIGNE_BRETOUR_CLIENT WHERE CODE_BRETOUR_CLIENT=@CODE_BRETOUR_CLIENT", CONNECTION_PARAM.cnx);
            da.SelectCommand.Parameters.Add("@CODE_BRETOUR_CLIENT", SqlDbType.NVarChar).Value=CODE_BRETOUR_CLIENT;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        public DataTable LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     LIGNE_BRETOUR_CLIENT.CODE_ARTICLE, LIGNE_BRETOUR_CLIENT.QTE_BRETOUR_CLIENT,  LIGNE_BRETOUR_CLIENT.PRIX_BRETOUR_CLIENT, ARTICLE.DESIGNATION_ARTICLE, ARTICLE.REF_ARTICLE FROM ARTICLE INNER JOIN LIGNE_BRETOUR_CLIENT ON ARTICLE.CODE_ARTICLE = LIGNE_BRETOUR_CLIENT.CODE_ARTICLE", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            return dt;
        }

        public DataTable SELECT_ALL_BRETOUR_CLIENT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT     MAGAZIN.NOM_MAG, BON_RETOUR_CLIENT.CODE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.DATE_BRETOUR_CLIENT, BON_RETOUR_CLIENT.MNT_BRETOUR,  BON_RETOUR_CLIENT.CODE_USER, BON_RETOUR_CLIENT.CODE_FACTURE, BON_RETOUR_CLIENT.CODE_MAG, UTILISATEUR.NOM_USER+ ' '+                       UTILISATEUR.PRENOM_USER as utilisateur FROM         BON_RETOUR_CLIENT INNER JOIN                      UTILISATEUR ON BON_RETOUR_CLIENT.CODE_USER = UTILISATEUR.CODE_USER INNER JOIN                      MAGAZIN ON BON_RETOUR_CLIENT.CODE_MAG = MAGAZIN.CODE_MAG", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            return dt;
        }

        

        


        
        #endregion
    }

    class CHM_INVENTAIRE_DEF : MarshalByRefObject, CHM_GESTION_COMERCIALE.INVENTAIRE
    {
        #region INVENTAIRE Membres

        public RESULT_QUERY CLOTURE_INVENTAIRE(decimal code_inventaire, decimal code_user, DataTable dt_inventaire, decimal CODE_MAG)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();

            SqlDataAdapter da = new SqlDataAdapter("select * From STOCK where STOCK.CODE_MAG='"+CODE_MAG+"'", CONNECTION_PARAM.cnx);
            da.SelectCommand.Transaction = sqltrans;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            

            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                    dt.DefaultView.RowFilter = "CODE_ARTICLE='" + (Decimal)dr["CODE_ARTICLE"] +"'";
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
                
                res.MESSAGE = "Inventary closed with succes.\n „ ≈€·«ﬁ «·Ã—œ »‰Ã«Õ ";
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

        public DataTable IMPRIMER_SAISIE_INVENTAIRE(decimal code_inventaire)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG,                          INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.PRENOM_USER+' '+UTILISATEUR.NOM_USER as util,                          LIGNE_INVENTAIRE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, LIGNE_INVENTAIRE.QTE_INVENTAIRE, LIGNE_INVENTAIRE.QTE_STOCK,                          LIGNE_INVENTAIRE.QTE_ACHAT, LIGNE_INVENTAIRE.QTE_VENTE, LIGNE_INVENTAIRE.QTE_RETOUR, ARTICLE.DESIGNATION_ARTICLE,                          ARTICLE.CODE_BARRE_ARTICLE, CATEGORIE.LIB_CATEG FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER INNER JOIN                         LIGNE_INVENTAIRE ON INVENTAIRE.CODE_INVENTAIRE = LIGNE_INVENTAIRE.CODE_INVENTAIRE left outer join ARTICLE on LIGNE_INVENTAIRE.CODE_ARTICLE=ARTICLE.CODE_ARTICLE INNER JOIN                         CATEGORIE ON ARTICLE.CODE_CATEG = CATEGORIE.CODE_CATEG WHERE INVENTAIRE.CODE_INVENTAIRE='" + code_inventaire + "'", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Transaction = CONNECTION_PARAM.trans;
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LOAD_INVENTAIRE(decimal code_inventaire)
        {

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE,INVENTAIRE.CODE_MAG, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG, INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.PRENOM_USER+' '+UTILISATEUR.NOM_USER AS UTIL FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER WHERE INVENTAIRE.CODE_INVENTAIRE='" + code_inventaire + "'", CONNECTION_PARAM.cnx))
            {
                da.SelectCommand.Transaction = CONNECTION_PARAM.trans;
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable LOAD_LIGNE_INVENTAIRE(decimal code_inventaire)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG,                          INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER,                          LIGNE_INVENTAIRE.CODE_ARTICLE, ARTICLE.REF_ARTICLE, LIGNE_INVENTAIRE.QTE_INVENTAIRE, LIGNE_INVENTAIRE.QTE_STOCK,                          LIGNE_INVENTAIRE.QTE_ACHAT, LIGNE_INVENTAIRE.QTE_VENTE, LIGNE_INVENTAIRE.QTE_RETOUR, ARTICLE.DESIGNATION_ARTICLE,                          ARTICLE.CODE_BARRE_ARTICLE, CATEGORIE.LIB_CATEG FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER INNER JOIN                         LIGNE_INVENTAIRE ON INVENTAIRE.CODE_INVENTAIRE = LIGNE_INVENTAIRE.CODE_INVENTAIRE left outer join ARTICLE on LIGNE_INVENTAIRE.CODE_ARTICLE=ARTICLE.CODE_ARTICLE INNER JOIN                         CATEGORIE ON ARTICLE.CODE_CATEG = CATEGORIE.CODE_CATEG WHERE INVENTAIRE.CODE_INVENTAIRE='" + code_inventaire + "'", CONNECTION_PARAM.cnx))
            {
                SqlTransaction trans = CONNECTION_PARAM.cnx.BeginTransaction();
                da.SelectCommand.Transaction = trans;
                da.SelectCommand.Transaction = CONNECTION_PARAM.trans;
                DataTable dt = new DataTable();
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
                trans.Commit();
                return dt;
            }
        }

        public RESULT_QUERY OUVERTURE_INVENTAIRE(decimal code_user, decimal code_mag)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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
                res.MESSAGE = "Inventary opened with succes.\n „ › Õ «·Ã—œ »‰Ã«Õ ";
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

         public RESULT_QUERY ENREGISTRER_LIGNE_INVENTAIRE(decimal code_inventaire, decimal code_article, decimal qte)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlTransaction sqltrans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
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

                
                res.MESSAGE = "Inventary opened with succes.\n „ › Õ «·Ã—œ »‰Ã«Õ ";
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

        public RESULT_QUERY VERIFIER_INVENTAIRE_MAGAZIN(decimal CODE_MAG)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG, INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER WHERE MAGAZIN.CODE_MAG='" + CODE_MAG + "'", CONNECTION_PARAM.cnx);
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);


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

        public DataTable SELECT_ALL_INVENTAIRE()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT        INVENTAIRE.CODE_INVENTAIRE, INVENTAIRE.DATE_DEBUT_INVENTAIRE, INVENTAIRE.DATE_FIN_INVENTAIRE, INVENTAIRE.CODE_MAG, INVENTAIRE.UTILISATEUR_CREAT_INV, INVENTAIRE.UTILISATEUR_FERM_INV, MAGAZIN.NOM_MAG, UTILISATEUR.NOM_USER FROM            INVENTAIRE INNER JOIN                         MAGAZIN ON INVENTAIRE.CODE_MAG = MAGAZIN.CODE_MAG INNER JOIN                         UTILISATEUR ON INVENTAIRE.UTILISATEUR_CREAT_INV = UTILISATEUR.CODE_USER", CONNECTION_PARAM.cnx);
            SqlTransaction trans = CONNECTION_PARAM.cnx.BeginTransaction();
            da.SelectCommand.Transaction = trans;
            DataTable dt = new DataTable();
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
            trans.Commit();
            return dt;
        }

        public decimal GET_INVENTAIRE_COURANT_PAR_MAGAZIN(decimal CODE_MAG)
        {
            decimal CODE_INVENTAIRE;
            
            SqlTransaction trans = CONNECTION_PARAM.cnx.BeginTransaction();
            SqlCommand cmd = CONNECTION_PARAM.cnx.CreateCommand();
            cmd.Transaction = trans;

            cmd.CommandText = "select CODE_INVENTAIRE FROM INVENTAIRE WHERE CODE_MAG=@CODE_MAG AND CONVERT(nvarchar,DATE_FIN_INVENTAIRE, 103)='01/01/1900'";
            cmd.Parameters.Add("@CODE_MAG", SqlDbType.Decimal).Value=CODE_MAG;

            CODE_INVENTAIRE = (decimal)cmd.ExecuteScalar();
            trans.Commit();
            return CODE_INVENTAIRE;
        }
        #endregion
    }
}
