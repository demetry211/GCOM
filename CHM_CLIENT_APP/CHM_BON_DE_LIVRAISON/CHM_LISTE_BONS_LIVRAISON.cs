using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_BONS_LIVRAISON : Form
    {
        string type = "";
        public CHM_LISTE_BONS_LIVRAISON(string type)
        {
            InitializeComponent();
            this.type = type;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                ChargerBL();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        private void CHM_LISTE_BONS_LIVRAISON_Shown(object sender, EventArgs e)
        {
            dgv_LISTE_B_LIV.AutoGenerateColumns = false;
            ChargerBL();
        }

        private void ChargerBL()
        {
            if (type == "1")
            {
                try
                {
                    Application.DoEvents();
                    //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_ALL_BON_LIVRAISON();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_BON_LIVRAISON();
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (type == "2")
            {
                try
                {
                    Application.DoEvents();
                    entete_Formulaire_21.windows_name.Text = "Bons de livaison facturés";
                    //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_FACTURE();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_FACTURE();
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (type == "3")
            {
                try
                {
                    Application.DoEvents();
                    entete_Formulaire_21.windows_name.Text = "Bons de livaison non facturés";
                    //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_NON_FACTURE();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_NON_FACTURE();
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (type == "4")
            {
                try
                {
                    Application.DoEvents();
                    entete_Formulaire_21.windows_name.Text = "Bons de livaison livrés";
                    //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_LIVRE();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_LIVRE();
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (type == "5")
            {
                try
                {
                    Application.DoEvents();
                    entete_Formulaire_21.windows_name.Text = "Bons de livaison non livrés";
                    //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_NON_LIVRE();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_NON_LIVRE();
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (type == "6")
            {
                try
                {
                    Application.DoEvents();
                    entete_Formulaire_21.windows_name.Text = "Liste des Bons de livaison";
                    //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_PREPARE();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_PREPARE();
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (type == "7")
            {
                try
                {
                    Application.DoEvents();
                    entete_Formulaire_21.windows_name.Text = "Liste des Bons de livaison";
                    //dt = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.SELECT_B_LIV(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TB_RECHERCHE_CLT_TextChanged(object sender, EventArgs e)
        {
            dgv_LISTE_B_LIV.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                if (TB_RECHERCHE.Text == "")
                {
                    bs.DataSource = dt;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                    DataTable dt_search = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "CODE_B_LIV like '%"+TB_RECHERCHE.Text+"%'";
                    bs.DataSource = dt_search;
                    dgv_LISTE_B_LIV.DataSource = bs;
                }
                
                //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.RECHERCHE(TB_RECHERCHE.Text);
                //bs.DataSource = dt;
                //dgv_LISTE_B_LIV.DataSource = bs;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_LISTE_B_LIV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                Fiche_b_liv f = new Fiche_b_liv(drv["CODE_B_LIV"].ToString());
                f.WindowState = FormWindowState.Maximized;
                f.RightToLeft = RightToLeft.No;
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CHM_LISTE_BONS_LIVRAISON_Load(object sender, EventArgs e)
        {

        }

        private void BTN_AJOUTER_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
                if (dt.Rows.Count > 0)
                {
                    CHM_FICHE_BON_LIVRAISON f = new CHM_FICHE_BON_LIVRAISON();
                    //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    //f.WindowState = FormWindowState.Maximized;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.OnClose += new CHM_FICHE_BON_LIVRAISON.WindowClose(f_OnClose);
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Veuillez pramètrer vos magasins");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void f_OnClose()
        {
            ChargerBL();
        }

        private void BTN_DETAIL_Click(object sender, EventArgs e)
        {
            if(bs.Current!=null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                Fiche_b_liv f = new Fiche_b_liv(drv["CODE_B_LIV"].ToString());
                //f.WindowState = FormWindowState.Maximized;                
                //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }            
        }

        private void BTN_Aperçu_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (bs.Current != null)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    DataTable dt = CLIENT_APP_PARAM.gcws.Imprimer_BL(drv["CODE_B_LIV"].ToString());
                    decimal montant_ht = 0;
                    decimal montant_remise = 0;
                    decimal montant_TVA = 0;
                    decimal montant_TTC = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        montant_ht += (decimal)dr["PRIX_HT_B_LIV"] * (decimal)dr["QTE_LIGNE_B_LIV"];
                        montant_remise += (decimal)dr["PRIX_HT_B_LIV"] * (decimal)dr["REMISE"] / 100 * (decimal)dr["QTE_LIGNE_B_LIV"];
                        montant_TVA += ((decimal)dr["PRIX_HT_B_LIV"] - (decimal)dr["PRIX_HT_B_LIV"] * (decimal)dr["REMISE"] / 100) * (decimal)dr["TVA_B_LIV"] / 100 * (decimal)dr["QTE_LIGNE_B_LIV"];

                    }
                    montant_TTC = montant_ht - montant_remise + montant_TVA;

                    RPT_B_LIV rpt = new RPT_B_LIV();
                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("mnt_HT", montant_ht);
                    rpt.SetParameterValue("Total_Remise", montant_remise);
                    rpt.SetParameterValue("Total_TVA", montant_TVA);
                    rpt.SetParameterValue("Montant_TTC", montant_TTC);
                    rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
                    //rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                    //rpt.PrintToPrinter(1, true, 1, 1);

                    CHM_ETATS etat = new CHM_ETATS();
                    etat.CHM_Aperçu_document.ReportSource = rpt;
                    etat.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    etat.WindowState = FormWindowState.Maximized;
                    etat.Show();
                }
                else
                {
                    MessageBox.Show("Sélectionnez le bon de livraison à imprimer.");
                }
            }
            catch (Exception er)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CHM_LISTE_BONS_LIVRAISON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6) if (BTN_AJOUTER.Enabled) BTN_AJOUTER.PerformClick();
            if (e.KeyCode == Keys.F7) if (BTN_DETAIL.Enabled) BTN_DETAIL.PerformClick();
            if (e.KeyCode == Keys.F8) if (BTN_Aperçu_cmd.Enabled) BTN_Aperçu_cmd.PerformClick();
            if (e.KeyCode == Keys.F5)
            {
                #region
                dgv_LISTE_B_LIV.AutoGenerateColumns = false;
                if (type == "1")
                {
                    try
                    {
                        Application.DoEvents();
                        //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_ALL_BON_LIVRAISON();
                        dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_BON_LIVRAISON();
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type == "2")
                {
                    try
                    {
                        Application.DoEvents();
                        entete_Formulaire_21.windows_name.Text = "Bons de livaison facturés";
                        //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_FACTURE();
                        dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_FACTURE();
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type == "3")
                {
                    try
                    {
                        Application.DoEvents();
                        entete_Formulaire_21.windows_name.Text = "Bons de livaison non facturés";
                        //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_NON_FACTURE();
                        dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_NON_FACTURE();
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type == "4")
                {
                    try
                    {
                        Application.DoEvents();
                        entete_Formulaire_21.windows_name.Text = "Bons de livaison livrés";
                        //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_LIVRE();
                        dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_LIVRE();
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type == "5")
                {
                    try
                    {
                        Application.DoEvents();
                        entete_Formulaire_21.windows_name.Text = "Bons de livaison non livrés";
                        //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_NON_LIVRE();
                        dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_NON_LIVRE();
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type == "6")
                {
                    try
                    {
                        Application.DoEvents();
                        entete_Formulaire_21.windows_name.Text = "Liste des Bons de livaison";
                        //dt = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SELECT_B_LIV_PREPARE();
                        dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV_PREPARE();
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type == "7")
                {
                    try
                    {
                        Application.DoEvents();
                        entete_Formulaire_21.windows_name.Text = "Liste des Bons de livaison";
                        //dt = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.SELECT_B_LIV(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                        dt = CLIENT_APP_PARAM.gcws.SELECT_B_LIV(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                        bs.DataSource = dt;
                        dgv_LISTE_B_LIV.DataSource = bs;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {

        }
    }
}
