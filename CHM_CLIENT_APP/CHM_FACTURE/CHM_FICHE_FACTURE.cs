using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_FACTURE : Form
    {
        string CODE_B_LIV = "-1";
        string REMARQUE = "Bon de livraison facturés :";
        public CHM_FICHE_FACTURE(string CODE_B_LIV)
        {
            InitializeComponent();
            this.CODE_B_LIV = CODE_B_LIV;
            BTN_REGLEMENT.Enabled = false;
            BTN_APERçU.Enabled = false;
        }
        string CODE_CLIENT = "-1";
        string CODE_MAG = "";

        private void FICHE_FACTURE_KeyDown(object sender, KeyEventArgs e)
        {
            if (REF_CLIENT.Focused && e.KeyCode == Keys.Enter && REF_CLIENT.Text != "")
            {
                Application.DoEvents();
                //DataTable dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.RECHERCHE_CLIENT(this.REF_CLIENT.Text);
                DataTable dt = CLIENT_APP_PARAM.gcws.RECHERCHE_CLIENT(this.REF_CLIENT.Text);
                if (dt.Rows.Count != 0)
                {
                    CODE_CLIENT = dt.Rows[0]["CODE_CLIENT"].ToString();
                    RS_CLIENT.Text = dt.Rows[0]["RS_CLIENT"].ToString();
                    CODE_MAG = dt.Rows[0]["CODE_MAG"].ToString();
                    dt_b_liv = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_CLIENT_NON_GENERE(CODE_CLIENT);
                    bs_b_liv.DataSource = dt_b_liv;
                    dgv_b_liv.DataSource = bs_b_liv;

                    calculMontantTotal();
                }
                else
                {
                    CODE_CLIENT = "-1";
                    RS_CLIENT.Text = "Référence invalide !";
                }
            }

            if (e.KeyCode == Keys.Enter && REF_CLIENT.Focused && REF_CLIENT.Text.Trim() == "")
            {
                CHM_COMMANDE_CLIENT f = new CHM_COMMANDE_CLIENT();
                f.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(f_client_selection_event);
                f.ShowDialog();
            }
            if (e.KeyCode == Keys.F5)
                if (button1.Enabled)
                    button1.PerformClick();
            if (e.KeyCode == Keys.F8)
                if (BTN_APERçU.Enabled)
                    BTN_APERçU.PerformClick();
            if (e.KeyCode == Keys.F12)
                if (BTN_REGLEMENT.Enabled)
                    BTN_REGLEMENT.PerformClick();
            if (e.KeyCode == Keys.F10)
                if (BTN_ENREGISTRER.Enabled)
                    BTN_ENREGISTRER.PerformClick();
        }

        void f_client_selection_event(DataRowView client)
        {
            REF_CLIENT.Text = client["REF_CLIENT"].ToString();
            RS_CLIENT.Text = client["RS_CLIENT"].ToString();
            CODE_CLIENT = client["CODE_CLIENT"].ToString();

            //dt_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_B_LIV_CLIENT(CODE_CLIENT);
            dt_b_liv = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_CLIENT_NON_GENERE(CODE_CLIENT);
            bs_b_liv.DataSource = dt_b_liv;
            dgv_b_liv.DataSource = bs_b_liv;

            calculMontantTotal();
        }

        private void buttonAJOUTER_Click(object sender, EventArgs e)
        {
            if (CODE_CLIENT == "-1")
            {
                REF_CLIENT.Focus();
                MessageBox.Show("Vous devez choisir un client!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //chargeement de la liste des commande du client choisi
        }

        DataTable dt_b_liv_selectionne;
        BindingSource bs_b_liv_selectionne = new BindingSource();
        private void dataGridViewCOMMANDE_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgv_lg_b_liv.AutoGenerateColumns = false;
            if (bs_b_liv.Current != null)
            {
                DataRowView drv_b_liv_select = (DataRowView)bs_b_liv.Current;
                string code_b_liv = "";
                if (dgv_b_liv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper() == "TRUE")
                {
                    // Ajouter le bon de livraison en cours au bons de livraison selectionnés
                    bs_b_liv_selectionne.AddNew();
                    DataRowView drv_selection = (DataRowView)bs_b_liv_selectionne.Current;
                    drv_selection["CODE_B_LIV"] = drv_b_liv_select["CODE_B_LIV"];
                    drv_selection["DATE_B_LIV"] = drv_b_liv_select["DATE_B_LIV"];
                    drv_selection["CODE_CLIENT"] = drv_b_liv_select["CODE_CLIENT"];
                    drv_selection["CODE_COMMANDE"] = drv_b_liv_select["CODE_COMMANDE"];
                    drv_selection["CODE_USER"] = drv_b_liv_select["CODE_USER"];
                    drv_selection["SOMME_B_LIV"] = drv_b_liv_select["SOMME_B_LIV"];
                    drv_selection["FACTURED"] = drv_b_liv_select["FACTURED"];
                    drv_selection["PREPARED"] = drv_b_liv_select["PREPARED"];
                    drv_selection["LIVRE"] = drv_b_liv_select["LIVRE"];
                    drv_selection["CODE_MAG"] = drv_b_liv_select["CODE_MAG"];
                    bs_b_liv_selectionne.EndEdit();
                    dt_b_liv_selectionne.AcceptChanges();
                    // Remplire les lignes de la facture selon les bons de livraison selectionnés

                    dt_lg_b_liv.Clear();
                    dgv_lg_b_liv.AutoGenerateColumns = false;

                    try
                    {

                        Application.DoEvents();
                        //dt_lg_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_SCHEMA_LG_FACTURE();
                        dt_lg_b_liv = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_FACTURE();
                        bs_lg_b_liv.DataSource = dt_lg_b_liv;
                        dgv_lg_b_liv.DataSource = bs_lg_b_liv;

                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (DataRowView drv in bs_b_liv_selectionne)
                    {
                        DataTable dt;
                        BindingSource bs = new BindingSource();
                        //dt = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LG_B_LIV(drv["CODE_B_LIV"].ToString());
                        dt = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(drv["CODE_B_LIV"].ToString());
                        bs.DataSource = dt;
                        foreach (DataRowView dr in bs)
                        {
                            bs_lg_b_liv.AddNew();
                            DataRowView drv_lg = (DataRowView)bs_lg_b_liv.Current;
                            drv_lg["CODE_B_LIV"] = dr["CODE_B_LIV"];
                            drv_lg["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                            drv_lg["REF_ARTICLE"] = dr["REF_ARTICLE"];
                            drv_lg["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                            drv_lg["QTE_LIGNE_B_LIV"] = dr["QTE_LIGNE_B_LIV"];
                            drv_lg["PRIX_HT_B_LIV"] = dr["PRIX_HT_B_LIV"];
                            drv_lg["PRIX_TOTAL_HT"] = dr["PRIX_TOTAL_HT"];
                            drv_lg["TVA_B_LIV"] = dr["TVA_B_LIV"];
                            drv_lg["PRIX_U_TTC"] = dr["PRIX_U_TTC"];
                            drv_lg["PRIX_TOTAL_TTC"] = dr["PRIX_TOTAL_TTC"];
                            bs_lg_b_liv.EndEdit();
                            dt_lg_b_liv.AcceptChanges();
                        }
                    }
                }
                else
                {
                    code_b_liv = dgv_b_liv.Rows[e.RowIndex].Cells[0].Value.ToString();

                    foreach (DataRowView drv in bs_b_liv_selectionne)
                    {
                        if (drv["CODE_B_LIV"].ToString() == code_b_liv)
                        {
                            bs_b_liv_selectionne.RemoveCurrent();
                            dt_b_liv_selectionne.AcceptChanges();
                        }
                    }
                    dt_lg_b_liv.Clear();
                    dgv_lg_b_liv.AutoGenerateColumns = false;

                    try
                    {

                        Application.DoEvents();
                        //dt_lg_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_SCHEMA_LG_FACTURE();
                        dt_lg_b_liv = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_FACTURE();
                        bs_lg_b_liv.DataSource = dt_lg_b_liv;
                        dgv_lg_b_liv.DataSource = bs_lg_b_liv;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    foreach (DataRowView drv in bs_b_liv_selectionne)
                    {
                        DataTable dt;
                        BindingSource bs = new BindingSource();
                        //dt = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LG_B_LIV(drv["CODE_B_LIV"].ToString());
                        dt = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(drv["CODE_B_LIV"].ToString());
                        bs.DataSource = dt;
                        foreach (DataRowView dr in bs)
                        {
                            bs_lg_b_liv.AddNew();
                            DataRowView drv_lg = (DataRowView)bs_lg_b_liv.Current;
                            drv_lg["CODE_B_LIV"] = dr["CODE_B_LIV"];
                            drv_lg["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                            drv_lg["REF_ARTICLE"] = dr["REF_ARTICLE"];
                            drv_lg["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                            drv_lg["QTE_LIGNE_B_LIV"] = dr["QTE_LIGNE_B_LIV"];
                            drv_lg["PRIX_HT_B_LIV"] = dr["PRIX_HT_B_LIV"];
                            drv_lg["PRIX_TOTAL_HT"] = dr["PRIX_TOTAL_HT"];
                            drv_lg["TVA_B_LIV"] = dr["TVA_B_LIV"];
                            drv_lg["PRIX_U_TTC"] = dr["PRIX_U_TTC"];
                            drv_lg["PRIX_TOTAL_TTC"] = dr["PRIX_TOTAL_TTC"];
                            bs_lg_b_liv.EndEdit();
                            dt_lg_b_liv.AcceptChanges();
                        }
                    }
                }
            }
        }

        void calculMontantTotal()
        {
            HT.Value = 0;
            TVA.Value = 0;
            if (dt_lg_b_liv != null)
            {
                foreach (DataRow dr in dt_lg_b_liv.Rows)
                {
                    decimal ht_remise = Convert.ToDecimal(dr["PRIX_TOTAL_HT"])  * (1 - TAUX_REMISE.Value / 100);

                    HT.Value += ht_remise;
                    TVA.Value += ht_remise * Convert.ToDecimal(dr["TVA_B_LIV"]) / 100;

                }
            }

            TTC.Value = HT.Value + TVA.Value;
            NP.Value = TTC.Value + TIMBRE.Value;

            ML.Text = "Arreter la présente facture à la somme de : " + new NUM_TO_LETTRE.NumberToLetter().ConvertirDinars(NP.Value);
        }

        private void TAUX_REMISE_ValueChanged(object sender, EventArgs e)
        {
            calculMontantTotal();
        }

        private void dataGridViewCOMMANDE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string code = dgv_b_liv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Fiche_b_liv fiche = new Fiche_b_liv(code);
            fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            fiche.Show();
        }
        DataTable dt_b_liv;
        BindingSource bs_b_liv = new BindingSource();
        DataTable dt_lg_b_liv;
        BindingSource bs_lg_b_liv = new BindingSource();
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();

        private void CHM_FICHE_FACTURE_Shown(object sender, EventArgs e)
        {
            dgv_b_liv.AutoGenerateColumns = false;
            dgv_lg_b_liv.AutoGenerateColumns = false;
            try
            {

                Application.DoEvents();
                //dt_lg_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_SCHEMA_LG_FACTURE();
                dt_lg_b_liv = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_FACTURE();
                bs_lg_b_liv.DataSource = dt_lg_b_liv;
                dgv_lg_b_liv.DataSource = bs_lg_b_liv;
                //dt_b_liv_selectionne = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_SCHEMA_LIGNE_B_LIV_FACTURE();
                dt_b_liv_selectionne = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LIGNE_B_LIV_FACTURE();
                bs_b_liv_selectionne.DataSource = dt_b_liv_selectionne;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataRow drv in dt_b_liv_selectionne.Rows)
            {
                DataTable dt;
                BindingSource bs = new BindingSource();
                //dt = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LG_B_LIV(drv["CODE_B_LIV"].ToString());
                dt = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(drv["CODE_B_LIV"].ToString());
                bs.DataSource = dt;
                foreach (DataRowView dr in bs)
                {
                    bs_lg_b_liv.AddNew();
                    DataRowView drv_lg = (DataRowView)bs_lg_b_liv.Current;
                    drv_lg["CODE_B_LIV"] = dr["CODE_B_LIV"];
                    drv_lg["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                    drv_lg["REF_ARTICLE"] = dr["REF_ARTICLE"];
                    drv_lg["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                    drv_lg["QTE_LIGNE_B_LIV"] = dr["QTE_LIGNE_B_LIV"];
                    drv_lg["PRIX_HT_B_LIV"] = dr["PRIX_HT_B_LIV"];
                    drv_lg["PRIX_TOTAL_HT"] = dr["PRIX_TOTAL_HT"];
                    drv_lg["TVA_B_LIV"] = dr["TVA_B_LIV"];
                    drv_lg["PRIX_U_TTC"] = dr["PRIX_U_TTC"];
                    drv_lg["PRIX_TOTAL_TTC"] = dr["PRIX_TOTAL_TTC"];
                    bs_lg_b_liv.EndEdit();
                    dt_lg_b_liv.AcceptChanges();
                }
            }
            if (CODE_B_LIV != "-1")
            {
                dgv_b_liv.AutoGenerateColumns = false;
                try
                {
                    Application.DoEvents();
                    //dt_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_B_LIV_FACTURE(CODE_B_LIV);
                    dt_b_liv = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_FACTURE(CODE_B_LIV);
                    bs_b_liv.DataSource = dt_b_liv;

                    dgv_b_liv.DataSource = bs_b_liv;
                    bs_b_liv.MoveFirst();
                    //foreach (DataRow dr in dgv_b_liv.Rows)
                    //{
                    //}
                    if (bs_b_liv.Current != null)
                    {
                        DataRowView drv = (DataRowView)bs_b_liv.Current;
                        decimal CODE_CLT = (decimal)drv["CODE_CLIENT"];
                        CODE_CLIENT = CODE_CLT.ToString();
                        //dt_client = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_CLIENT_FACTURE(CODE_CLT.ToString());
                        dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT_FACTURE(CODE_CLT.ToString());
                        bs_client.DataSource = dt_client;
                        DataRowView drv_client = (DataRowView)bs_client.Current;
                        REF_CLIENT.Text = drv_client["REF_CLIENT"].ToString();
                        RS_CLIENT.Text = drv_client["RS_CLIENT"].ToString();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgv_lg_b_liv.AutoGenerateColumns = false;
                try
                {
                    Application.DoEvents();
                    //dt_lg_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LG_B_LIV(CODE_B_LIV);
                    dt_lg_b_liv = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(CODE_B_LIV);
                    bs_lg_b_liv.DataSource = dt_lg_b_liv;
                    dgv_lg_b_liv.DataSource = bs_lg_b_liv;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                calculMontantTotal();
            }
        }

        private void dgv_lg_b_liv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculMontantTotal();
        }

        private void PARCOURIR_LISTE_CLIENT_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_CLIENT f = new CHM_COMMANDE_CLIENT();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(f_client_selection_event);
            f.ShowDialog();
        }

        private void dgv_lg_b_liv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculMontantTotal();
        }

        private void BTN_ENREGISTRER_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Application.DoEvents();
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.INSERT_FACTURE_CLIENT(DATE_FACTURE.Value, CODE_CLIENT, HT.Value, TVA.Value, TTC.Value,
                    TAUX_REMISE.Value, TTC.Value, TIMBRE.Value, NP.Value, ML.Text, false, "Non reglée", TTC.Value, Convert.ToDecimal( CODE_MAG), 
                    Convert.ToDecimal( CLIENT_APP_PARAM.Fenetre_principale.code_user), CLIENT_APP_PARAM.Fenetre_principale.prenom_user, 
                    CLIENT_APP_PARAM.Fenetre_principale.nom_user, REMARQUE, dt_lg_b_liv);
                if (res.OK)
                {
                    CODE_FACTURE.Text = res.CODE;
                    MessageBox.Show(res.MESSAGE, "INVOICE SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BTN_ENREGISTRER.Enabled = false;
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            foreach (DataRowView dr in bs_b_liv_selectionne)
            {
                //CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.UPDATE_FACTURE(dr["CODE_B_LIV"].ToString(), true);
                CLIENT_APP_PARAM.gcws.UPDATE_FACTURE(dr["CODE_B_LIV"].ToString(), true);
                //CLIENT_APP_PARAM.GEST.P_FACTURE.FACTURATION(CODE_FACTURE.Text, dr["CODE_B_LIV"].ToString(), DATE_FACTURE.Value);
                CLIENT_APP_PARAM.gcws.FACTURATION_CLIENT(CODE_FACTURE.Text, dr["CODE_B_LIV"].ToString(), DATE_FACTURE.Value);
                REMARQUE += dr["CODE_B_LIV"].ToString() + "   //  ";
            }
            remarq.Text = "Remarque : " + REMARQUE;
            BTN_REGLEMENT.Enabled = true;
            BTN_APERçU.Enabled = true;
            CHM_FICHE_FACTURE_CLIENT f = new CHM_FICHE_FACTURE_CLIENT(CODE_FACTURE.Text);
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();

        }

        private void BTN_FACTURATION_Click(object sender, EventArgs e)
        {
            CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT(CODE_FACTURE.Text);
            f.ShowDialog();
        }

        private void btn_liste_commande_Click(object sender, EventArgs e)
        {
            CHM_LISTE_FACTURES f = new CHM_LISTE_FACTURES(1, "");
            f.RightToLeft = RightToLeft.No;
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_FICHE_FACTURE f = new CHM_FICHE_FACTURE("-1");
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
