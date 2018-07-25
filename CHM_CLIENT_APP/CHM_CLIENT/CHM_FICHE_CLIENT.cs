using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CHM_CLIENT_APP.CHM_CLIENT;
using CHM_CLIENT_APP.CHMGC;


namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_CLIENT : Form
    {
        DataTable dtVehicule;
        BindingSource bsVehicule = new BindingSource();

        DataTable dtFI;
        BindingSource bsFI = new BindingSource();

        DataTable dtCommande;
        BindingSource bsCommande = new BindingSource();

        DataTable dtBL;
        BindingSource bsBL = new BindingSource();

        DataTable dtFct;
        BindingSource bsFct = new BindingSource();

        DataTable dtReg ;
        BindingSource bsReglement = new BindingSource();

        DataTable dtTC;
        BindingSource bsTC = new BindingSource();

        DataTable dtEqp;
        BindingSource bsEqp = new BindingSource();

        DataTable dtFIEQP;
        BindingSource bsFIEQP = new BindingSource();

        DataTable dtEncours;
        BindingSource bsEncours = new BindingSource();

        DataTable dt;
        BindingSource srcb = new BindingSource();
        decimal CodeClient = 0;
        public CHM_FICHE_CLIENT(BindingSource bsClient)
        {
            InitializeComponent();

            dt = new DataTable();
            dtBL = new DataTable();
            dtCommande = new DataTable();
            dtFct = new DataTable();
            dtFI = new DataTable();
            dtVehicule = new DataTable();
            dtEqp = new DataTable();
            dtFIEQP = new DataTable();
            dtTC = new DataTable();
            dtEncours = new DataTable();

            bsBL.DataSource = dtBL;
            gc_BLIV.DataSource = bsBL;

            bsCommande.DataSource = dtCommande;
            gc_CMD.DataSource = bsCommande;

            bsFct.DataSource = dtFct;
            gc_FCT.DataSource = bsFct;

            bsFI.DataSource = dtFI;
            gc_FI.DataSource = bsFI;

            bsReglement.DataSource = dtReg;
            gc_REGLEMENT.DataSource = bsReglement;

            bsTC.DataSource = dtTC;
            gcTC.DataSource = bsTC;

            bsVehicule.DataSource = dtVehicule;
            gc_VEHICULE.DataSource = bsVehicule;
            bsVehicule.CurrentChanged += new EventHandler(bsVehicule_CurrentChanged);

            bsFIEQP.DataSource = dtFIEQP;
            gc_fi_eqp.DataSource = bsFIEQP;

            bsEqp.DataSource = dtEqp;
            gc_eqp.DataSource = bsEqp;
            bsEqp.PositionChanged += new EventHandler(bsEqp_PositionChanged);

            bsEncours.DataSource = dtEncours;
            gcEncours.DataSource = bsEncours;

            try
            {
                //dt = CLIENT_APP_PARAM.GEST.P_CLIENT.SELECT_ALL_CLIENTS();
                //dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_CLIENTS();
                srcb = bsClient;

                dgv_fiche_clt.DataSource = srcb;
                //srcb.MoveFirst();

                REF_CLIENT.DataBindings.Add("Text", srcb, "REF_CLIENT", true);
                RS_CLIENT.DataBindings.Add("Text", srcb, "RS_CLIENT", true);
                ADRESSE_CLIENT.DataBindings.Add("Text", srcb, "ADRESSE_CLIENT", true);
                CP_CLIENT.DataBindings.Add("Text", srcb, "CP_CLIENT", true);
                TEL_CLIENT.DataBindings.Add("Text", srcb, "TEL_CLIENT", true);
                FAX_CLIENT.DataBindings.Add("Text", srcb, "FAX_CLIENT", true);
                EMAIL_CLIENT.DataBindings.Add("Text", srcb, "EMAIL_CLIENT", true);
                EXO_CLIENT.DataBindings.Add("Checked", srcb, "EXO_CLIENT", true);
                ATTEST_EXO_CLIENT.DataBindings.Add("Text", srcb, "ATTEST_EXO_CLIENT", true);
                ATTEST_EXO_CLIENT.DataBindings.Add("Enabled", srcb, "EXO_CLIENT", true);
                CODE_DOUANE_CLIENT.DataBindings.Add("Text", srcb, "CODE_DOUANE_CLIENT", true);
                CODE_TVA_CLIENT.DataBindings.Add("Text", srcb, "CODE_TVA_CLIENT", true);
                VILLE_CLIENT.DataBindings.Add("Text", srcb, "VILLE_CLIENT", true);
                PAYS_CLIENT.DataBindings.Add("Text", srcb, "PAYS_CLIENT", true);
                TEL2_CLIENT.DataBindings.Add("Text", srcb, "TEL2_CLIENT", true);
                MAX_CREDIT.DataBindings.Add("Text", srcb, "MAX_CREDIT", true);
                CREDIT_CLIENT.DataBindings.Add("Text", srcb, "TOTAl_CREDIT_CLT", true);
                RESP_CLIENT.DataBindings.Add("Text", srcb, "RESP_CLIENT", true);

                bsClient_PositionChanged(null, null);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bsClient.PositionChanged += new EventHandler(bsClient_PositionChanged);
        }

        void bsEqp_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (bsEqp.Current != null)
                {
                    chargerFI_EQP((decimal)((bsEqp.Current as DataRowView)["CODE_EQP"]));
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void chargerFI_EQP(decimal p)
        {
            try
            {
                dtFIEQP.Clear();
                dtFIEQP.Merge(CLIENT_APP_PARAM.gcws.GetFICHE_INTERVENTION_PAR_EQUIPEMENT(p));
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        void bsVehicule_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (bsVehicule.Current != null)
                {
                    chargerFI((decimal)((bsVehicule.Current as DataRowView)["CODE_VEHICULE"]));
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void bsClient_PositionChanged(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;

                CodeClient = (decimal)drv["CODE_CLIENT"];

                this.Text = entete_Formulaire_21.windows_name.Text = string.Format("Fiche CLient - {0} {1}", drv["REF_CLIENT"], drv["RS_CLIENT"]);

                if ((bool)drv["ETAT_CLIENT"] == true)
                {
                    ETAT_CLIENT.Text = "Bloqué";
                    ETAT_CLIENT.ForeColor = Color.Red;
                }
                else
                {
                    ETAT_CLIENT.Text = "OK";
                    ETAT_CLIENT.ForeColor = Color.Green;
                }

                if ((bool)drv["COMPTE"] == true)
                {
                    compte = true;
                    BTN_COMPTE.Text = "Afficher compte";
                }
                else
                {
                    compte = false;
                    BTN_COMPTE.Text = "Créer un compte";
                }
                chargerMvtClient();
                
            }
        }

        private void client_to_liste_Click(object sender, EventArgs e)
        {
            liste_client liste = new liste_client("l");
            liste.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            liste.Show();
            this.Close();
        }

        private void CHM_FICHE_CLIENT_Load(object sender, EventArgs e)
        {

            dgv_fiche_clt.AutoGenerateColumns = false;

        }

        private void btn_ajout_clt_Click(object sender, EventArgs e)
        {
            CHM_NOUVEAU_CLIENT nv_clt = new CHM_NOUVEAU_CLIENT("-1");
            nv_clt.ShowDialog();
        }



        private void btn_supp_clt_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)srcb.Current;
            //DataTable dt1 = CLIENT_APP_PARAM.GEST.P_CLIENT.select_b_liv_client(drv["CODE_CLIENT"].ToString());
            DataTable dt1 = CLIENT_APP_PARAM.gcws.select_b_liv_client(drv["CODE_CLIENT"].ToString());
            //DataTable dt2 = CLIENT_APP_PARAM.GEST.P_CLIENT.SELECT_COMMANDE_CLIENT(drv["CODE_CLIENT"].ToString());
            DataTable dt2 = CLIENT_APP_PARAM.gcws.SELECT_COMMANDE_CLIENT(drv["CODE_CLIENT"].ToString());
            //DataTable dt3 = CLIENT_APP_PARAM.GEST.P_CLIENT.select_facture(drv["CODE_CLIENT"].ToString());
            DataTable dt3 = CLIENT_APP_PARAM.gcws.select_facture(drv["CODE_CLIENT"].ToString());
            if (dt1.Rows.Count > 0 || dt2.Rows.Count > 0 || dt3.Rows.Count > 0)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer ce client.");
            }
            else
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                if (srcb.Current != null)
                {
                    if (MessageBox.Show("Etes vous sûres de supprimer ce client?", "Cofirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes && compte == false)
                    {
                        try
                        {
                            //res = CLIENT_APP_PARAM.GEST.P_CLIENT.DELETE_CLIENT(drv["CODE_CLIENT"].ToString());
                            res = CLIENT_APP_PARAM.gcws.DELETE_CLIENT(drv["CODE_CLIENT"].ToString());
                            if (res.OK)
                            {
                                srcb.RemoveCurrent();
                                dt.AcceptChanges();
                            }
                            else
                                MessageBox.Show(res.MESSAGE, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btn_modif_clt_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                CHM_NOUVEAU_CLIENT nv_clt = new CHM_NOUVEAU_CLIENT(drv["CODE_CLIENT"].ToString());
                nv_clt.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHM_FICHE_CLIENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        bool compte = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                if ((bool)drv["COMPTE"] != true)
                {
                    try
                    {
                        //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                        CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                        //res = CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.CREER_COMPTE_CLIENT(drv["CODE_CLIENT"].ToString());
                        res = CLIENT_APP_PARAM.gcws.CREER_COMPTE_CLIENT(drv["CODE_CLIENT"].ToString());
                        if (res.OK)
                        {
                            MessageBox.Show(res.MESSAGE, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //CLIENT_APP_PARAM.GEST.P_CLIENT.UPDATE_ETAT_COMPTE(drv["CODE_CLIENT"].ToString());
                            CLIENT_APP_PARAM.gcws.UPDATE_ETAT_COMPTE(drv["CODE_CLIENT"].ToString());
                            CHM_COMPTE_CREDIT_CLIENT fenetre = new CHM_COMPTE_CREDIT_CLIENT(drv["CODE_CLIENT"].ToString());
                            fenetre.Show();
                        }
                        else
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    CHM_COMPTE_CREDIT_CLIENT fenetre = new CHM_COMPTE_CREDIT_CLIENT(drv["CODE_CLIENT"].ToString());
                    fenetre.Show();
                }
            }

        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_fiche_clt.AutoGenerateColumns = false;
            try
            {

                //dt = CLIENT_APP_PARAM.GEST.P_CLIENT.SELECT_ALL_CLIENTS();
                CLIENT_APP_PARAM.ds_param.chargerClients();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void REF_CLIENT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CHM_FICHE_CLIENT_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLIENT_APP_PARAM.ds_param.bsClient.PositionChanged -= bsClient_PositionChanged;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            bsVehicule.AddNew();
            (bsVehicule.Current as DataRowView)["CODE_VEHICULE"] = -1;
            (bsVehicule.Current as DataRowView)["CODE_CLIENT"] = CodeClient;
            CHM_FRM_MAJ_VEHICULE f = new CHM_FRM_MAJ_VEHICULE(bsVehicule);
            f.OnMaj += new CHM_FRM_MAJ_VEHICULE.MAJ(f_OnMajVehicule);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void f_OnMajVehicule(decimal codeVehicule, bool ValidateChanges)
        {
            if (ValidateChanges)
            {
                bsVehicule.EndEdit();
                (bsVehicule.DataSource as DataTable).AcceptChanges();
                try
                {
                    chargerVehicule();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text);
                }
            }
            else
            {
                bsVehicule.CancelEdit();
            }
        }


        private void chargerVehicule()
        {
            try
            {
                dtVehicule.Clear();
                dtVehicule.Merge(CLIENT_APP_PARAM.gcws.GetVEHICULEParClient((decimal)(((DataRowView)srcb.Current)["CODE_CLIENT"])));
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        private void chargerCommande()
        {
            try
            {
                dtCommande.Clear();
                dtCommande.Merge(CLIENT_APP_PARAM.gcws.SELECT_COMMANDE_CLIENT((((DataRowView)srcb.Current)["CODE_CLIENT"]).ToString()));
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void chargerBL()
        {
            try
            {
                string code = (((DataRowView)srcb.Current)["CODE_CLIENT"]).ToString();
                dtBL.Clear();
                dtBL.Merge(CLIENT_APP_PARAM.gcws.select_b_liv_client(code));
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void chargerFacture()
        {
            try
            {
                dtFct.Clear();
                dtFct.Merge(CLIENT_APP_PARAM.gcws.select_facture((((DataRowView)srcb.Current)["CODE_CLIENT"]).ToString()));
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void chargerFI(decimal codeVehicule)
        {
            try
            {
                dtFI.Clear();
                dtFI.Merge(CLIENT_APP_PARAM.gcws.GetFICHE_INTERVENTION_PAR_VEHICULE(codeVehicule));
            }
            catch (Exception er)
            {

                throw er;
            }
        }


        private void chargerTC()
        {
            try
            {
                string code = (((DataRowView)srcb.Current)["CODE_CLIENT"]).ToString();
                dtTC.Clear();
                dtTC.Merge(CLIENT_APP_PARAM.gcws.Select_All_TICKET_CAISSE_Par_Client((decimal)((DataRowView)srcb.Current)["CODE_CLIENT"]));
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void chargerEncours()
        {
            try
            {
                dtEncours.Clear();
                dtEncours.Merge(CLIENT_APP_PARAM.gcws.select_encoursVenteParClient((((DataRowView)srcb.Current)["CODE_CLIENT"]).ToString()));
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void chargerMvtClient()
        {
            try
            {
                chargerBL();
                chargerCommande();
                chargerFacture();
                //chargerVehicule();
                chargerTC();
                chargerReglement();
                chargerEqp();
                chargerEncours();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void chargerEqp()
        {
            try
            {
                dtEqp.Clear();
                dtEqp.Merge(CLIENT_APP_PARAM.gcws.GetEQUIPEMENT_Client((decimal)(((DataRowView)srcb.Current)["CODE_CLIENT"])));
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        DataTable dt_compte;
        BindingSource bs_compte = new BindingSource();
        string CODE_COMPTE = "";
        private void chargerReglement()
        {
            dt_compte = CLIENT_APP_PARAM.gcws.LOAD_COMPTE((((DataRowView)srcb.Current)["CODE_CLIENT"]).ToString());
            bs_compte.DataSource = dt_compte;
            DataRowView drv = (DataRowView)bs_compte.Current;
            CODE_COMPTE = drv["CODE_COMPTE_CLIENT"].ToString();
            dtReg = CLIENT_APP_PARAM.gcws.SELECT_REGLEMENT_CLIENT(CODE_COMPTE);
            bsReglement.DataSource = dtReg;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_VEHICULE f = new CHM_FRM_MAJ_VEHICULE(bsVehicule);
            f.OnMaj += new CHM_FRM_MAJ_VEHICULE.MAJ(f_OnMajVehicule);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void chM_BOUTON_PRECEDENT1_Click(object sender, EventArgs e)
        {
            srcb.MovePrevious();
        }

        private void chM_BOUTON_SUIVANT1_Click(object sender, EventArgs e)
        {
            srcb.MoveNext();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (bsVehicule.Current != null && MessageBox.Show("Etes vous sûres de supprimer ce véhicule?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DVEHICULE vehicule = new DVEHICULE();
                vehicule.CODE_VEHICULE = (decimal)(bsVehicule.Current as DataRowView)["CODE_VEHICULE"];
                CHM_CLIENT_APP.CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                res = CLIENT_APP_PARAM.gcws.effaceVEHICULE(vehicule);
                if (res.OK)
                {
                    try
                    {
                        chargerVehicule();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, this.Text);
                    }
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                }
            }
        }       
    }
}
