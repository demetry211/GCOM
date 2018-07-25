using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_COMMANDE : Form
    {
        DataTable dt_lg_commande;
        BindingSource bs = new BindingSource();
        string CODE_CLIENT = "-1";
        string CODE_CMD = "-1";
        public CHM_FICHE_COMMANDE(string CODE_CMD)
        {
            InitializeComponent();
            this.CODE_CMD = CODE_CMD;
            entete_Formulaire_21.btn_refresh.Click+=new EventHandler(CHM_FICHE_COMMANDE_Shown);
            
        }

        private void PRIORITE_COMMANDE_CheckedChanged(object sender, EventArgs e)
        {
            DATE_EXPIRATION_COMMANDE.Enabled = PRIORITE_COMMANDE.Checked;
        }

        private void buttonENREGISTRER_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(RS_CLIENT, "");
            if (CODE_CLIENT == "-1")
            {
                REF_CLIENT.Focus();
                errorProvider1.SetError(RS_CLIENT, "Sélectionner le client. ");
                RS_CLIENT.Text = "Sélectionner le client. ";
                return;
            }
            if (MessageBox.Show("Etes sûres d'enregistrer la commande?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    Application.DoEvents();
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_COMMANDE.SAVE(CODE_CLIENT, DATE_COMMANDE.Value, PRIORITE_COMMANDE.Checked, (PRIORITE_COMMANDE.Checked == true) ? DATE_EXPIRATION_COMMANDE.Value : (object)null, CLIENT_APP_PARAM.Fenetre_principale.code_user.ToString(), false , dt_lg_commande);
                    CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.SAVE_COMMANDE_CLIENT(CODE_CLIENT, DATE_COMMANDE.Value, PRIORITE_COMMANDE.Checked, (PRIORITE_COMMANDE.Checked == true) ? DATE_EXPIRATION_COMMANDE.Value : (object)null, CLIENT_APP_PARAM.Fenetre_principale.code_user.ToString(), false, dt_lg_commande);
                    if (res.OK)
                    {
                        CODE_COMMANDE.Text = res.CODE;
                        MessageBox.Show(res.MESSAGE, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonENREGISTRER.Enabled = false;
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
            }
        }

        private void CHM_FICHE_COMMANDE_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.REF_CLIENT.Focused && e.KeyCode == Keys.Enter && this.REF_CLIENT.Text != "")
            {
                Application.DoEvents();
                //DataTable dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.RECHERCHE_CLIENT(this.REF_CLIENT.Text);
                DataTable dt = CLIENT_APP_PARAM.gcws.RECHERCHE_CLIENT(this.REF_CLIENT.Text);
                if (dt.Rows.Count != 0)
                {
                    this.CODE_CLIENT = dt.Rows[0]["CODE_CLIENT"].ToString();
                    this.RS_CLIENT.Text = dt.Rows[0]["RS_CLIENT"].ToString();
                }
                else
                {
                    this.CODE_CLIENT = "-1";
                    this.RS_CLIENT.Text = "Référence invalide !";
                }
            }
            if (this.REF_CLIENT.Focused && e.KeyCode == Keys.Enter && this.REF_CLIENT.Text.Trim() == "")
            {
                CHM_COMMANDE_CLIENT c_clt = new CHM_COMMANDE_CLIENT();
                c_clt.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(c_clt_client_selection_event);
                c_clt.ShowDialog();
            }

            if (e.KeyCode == Keys.F5)
                if (entete_Formulaire_21.btn_refresh.Enabled) entete_Formulaire_21.btn_refresh.PerformClick();
            if (e.KeyCode == Keys.F6)
            {
                if (buttonAJOUTER.Enabled) buttonAJOUTER.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (buttonSUPPRIMER.Enabled) buttonSUPPRIMER.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                if (buttonENREGISTRER.Enabled) buttonENREGISTRER.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                if (BTN_Aperçu_cmd.Enabled) BTN_Aperçu_cmd.PerformClick();
            }
            if (e.KeyCode==Keys.F11)
            {
                if (BTN_B_LIV.Enabled) BTN_B_LIV.PerformClick();
            }
            if (e.KeyCode == Keys.Control && e.KeyCode==Keys.L)
            {
                if (btn_liste_commande.Enabled) btn_liste_commande.PerformClick();
            }
        }

        void c_clt_client_selection_event(DCLIENT client)
        {
            REF_CLIENT.Text = client.REF_CLIENT.ToString();
            RS_CLIENT.Text = client.RS_CLIENT.ToString();
            CODE_CLIENT = client.CODE_CLIENT.ToString();
        }

        private void PARCOURIR_LISTE_CLIENT_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_CLIENT c_clt = new CHM_COMMANDE_CLIENT();
            c_clt.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(c_clt_client_selection_event);
            c_clt.ShowDialog();
        }
        DataTable dt_commande = new DataTable();
        BindingSource bs_commande = new BindingSource();
        DataTable dt_client = new DataTable();
        BindingSource bs_client = new BindingSource();
        string code_clt;
        private void CHM_FICHE_COMMANDE_Shown(object sender, EventArgs e)
        {
            if (CODE_CMD == "-1")
            {
                CODE_COMMANDE.Enabled = true;
                REF_CLIENT.Enabled = true;
                RS_CLIENT.Enabled = true;
                DATE_COMMANDE.Enabled = true;
                DATE_EXPIRATION_COMMANDE.Enabled = true;
                PRIORITE_COMMANDE.Enabled = true;
                somme_cmd.Enabled = true;
                buttonENREGISTRER.Enabled = true;
                buttonAJOUTER.Visible = true;
                buttonSUPPRIMER.Visible = true;
                PARCOURIR_LISTE_CLIENT.Visible = true;
                try
                {

                    dataGridViewLG_COMMANDE.AutoGenerateColumns = false;
                    Application.DoEvents();
                    //dt_lg_commande = CLIENT_APP_PARAM.GEST.P_COMMANDE.LOAD_SCHEMA_LG_COMMANDE();
                    dt_lg_commande = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_COMMANDE();
                    bs.DataSource = dt_lg_commande;
                    dataGridViewLG_COMMANDE.DataSource = bs;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CODE_COMMANDE.Enabled = false;
                REF_CLIENT.Enabled = false;
                RS_CLIENT.Enabled = false;
                DATE_COMMANDE.Enabled = false;
                DATE_EXPIRATION_COMMANDE.Enabled = false;
                PRIORITE_COMMANDE.Enabled = false;
                somme_cmd.Enabled = false;
                buttonENREGISTRER.Enabled = false;
                buttonAJOUTER.Enabled = false;
                buttonSUPPRIMER.Enabled = false;
                PARCOURIR_LISTE_CLIENT.Visible = false;
                REGLEE.Visible = true;
                REGLEE.Enabled = false;
                try
                {
                    Application.DoEvents();
                    //dt_commande = CLIENT_APP_PARAM.GEST.P_COMMANDE.LOAD_COMMANDE(CODE_CMD);
                    dt_commande = CLIENT_APP_PARAM.gcws.LOAD_COMMANDE(CODE_CMD);
                    bs_commande.DataSource = dt_commande;
                    bs_commande.MoveFirst();
                    if (bs_commande.Current != null)
                    {
                        DataRowView drv_cmd = (DataRowView)bs_commande.Current;
                        CODE_COMMANDE.Text = CODE_CMD;
                        DATE_COMMANDE.Text = drv_cmd["DATE_COMMANDE"].ToString();
                        if (Convert.ToBoolean(drv_cmd["PRIORITE_COMMANDE"]) == true)
                        {
                            PRIORITE_COMMANDE.CheckState = CheckState.Checked;
                            DATE_EXPIRATION_COMMANDE.Enabled = PRIORITE_COMMANDE.Checked;
                            DATE_EXPIRATION_COMMANDE.Text = drv_cmd["DATE_EXPIRATION_COMMANDE"].ToString();

                        }
                        else
                        {
                            PRIORITE_COMMANDE.CheckState = CheckState.Unchecked;
                            DATE_EXPIRATION_COMMANDE.Enabled = PRIORITE_COMMANDE.Checked;
                        }

                        code_clt = drv_cmd["CODE_CLIENT"].ToString();
                        //dt_client = CLIENT_APP_PARAM.GEST.P_CLIENT.LOAD_CLIENT(code_clt);
                        dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT(code_clt);
                        bs_client.DataSource = dt_client;
                        DataRowView drv_clt = (DataRowView)bs_client.Current;
                        REF_CLIENT.Text = drv_clt["REF_CLIENT"].ToString();
                        RS_CLIENT.Text = drv_clt["RS_CLIENT"].ToString();
                        if (Convert.ToBoolean(drv_cmd["REGLEE"]) == true)
                        {
                            REGLEE.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            REGLEE.CheckState = CheckState.Unchecked;
                        }
                        if (REGLEE.Checked)
                            BTN_B_LIV.Enabled = false;
                    }
                    dataGridViewLG_COMMANDE.AutoGenerateColumns = false;
                    //dt_lg_commande = CLIENT_APP_PARAM.GEST.P_COMMANDE.LOAD_SCHEMA_LG_COMMANDE();
                    dt_lg_commande = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_COMMANDE();
                    bs.DataSource = dt_lg_commande;
                    dataGridViewLG_COMMANDE.DataSource = bs;
                    Application.DoEvents();
                    DataTable dt= CLIENT_APP_PARAM.gcws.LOAD_LG_COMMANDE(CODE_CMD);
                    BindingSource bs_detail=new BindingSource();
                    bs_detail.DataSource=dt;
                    //dt_lg_commande = CLIENT_APP_PARAM.GEST.P_COMMANDE.LOAD_LG_COMMANDE(CODE_CMD);
                    //dt_lg_commande = CLIENT_APP_PARAM.gcws.LOAD_LG_COMMANDE(CODE_CMD);
                    foreach (DataRow drc in dt.Rows)
                    {
                        bs.AddNew();
                        DataRowView drv = (DataRowView)bs.Current;
                        drv["CODE_ARTICLE"] = drc["CODE_ARTICLE"];
                        string code_article = drv["CODE_ARTICLE"].ToString();
                        DataTable dt_article;
                        BindingSource bs_article = new BindingSource();
                        //dt_article = CLIENT_APP_PARAM.GEST.P_ARTICLE.LOAD_ARTICLE(code_article);
                        dt_article = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE(code_article);
                        bs_article.DataSource = dt_article;
                        DataRowView drv_article = (DataRowView)bs_article.Current;
                        drv["REF_ARTICLE"] = drv_article["REF_ARTICLE"];
                        drv["DESIGNATION_ARTICLE"] = drv_article["DESIGNATION_ARTICLE"];
                        drv["MARQUE_ARTICLE"] = drv_article["DESIGNATION_MARQUE"];
                        drv["QTE_LIGNE_COMMANDE"] = drc["QTE_LIGNE_COMMANDE"];
                        drv["PRIX_HT_COMMANDE"] = drc["PRIX_HT_COMMANDE"];
                        drv["PRIX_HT_TOTAL"] = Convert.ToDecimal(drc["PRIX_HT_COMMANDE"]) * Convert.ToDecimal(drc["QTE_LIGNE_COMMANDE"]);
                        drv["TVA_COMMANDE"] = drc["TVA_COMMANDE"];
                        drv["PRIX_TTC_LG_COMMANDE"] = Convert.ToDecimal(drc["PRIX_HT_COMMANDE"]) * (1 + (Convert.ToDecimal(drc["TVA_COMMANDE"])) / 100);
                        drv["PRIX_TTC_TOTAL"] = Convert.ToDecimal(drv["PRIX_TTC_LG_COMMANDE"]) * Convert.ToDecimal(drc["QTE_LIGNE_COMMANDE"]);
                        drv.EndEdit();
                        bs.EndEdit();
                        
                        dt_lg_commande.AcceptChanges();

                    }
                    calculerTotalCmd();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAJOUTER_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_ARTICLE aj_art = new CHM_COMMANDE_ARTICLE("CMD_CL");
            aj_art.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(aj_art_confirm_ajout);
            aj_art.ShowDialog();
        }

        void aj_art_confirm_ajout(DataRowView article, decimal qte, decimal prix)
        {
            try
            {
                bool trouve = false;

                foreach (DataRow drc in dt_lg_commande.Rows)
                {
                    if (drc["CODE_ARTICLE"].ToString() == article["CODE_ARTICLE"].ToString())
                    {
                        drc["QTE_LIGNE_COMMANDE"] = Convert.ToDecimal(drc["QTE_LIGNE_COMMANDE"]) + qte;
                        trouve = true;

                    }
                }

                if (!trouve)
                {
                    bs.AddNew();
                    DataRowView drv = (DataRowView)bs.Current;
                    drv["CODE_ARTICLE"] = article["CODE_ARTICLE"];
                    drv["REF_ARTICLE"] = article["REF_ARTICLE"];
                    drv["DESIGNATION_ARTICLE"] = article["DESIGNATION_ARTICLE"];
                    drv["MARQUE_ARTICLE"] = article["DESIGNATION_ARTICLE"];
                    drv["QTE_LIGNE_COMMANDE"] = qte;
                    drv["PRIX_HT_COMMANDE"] = article["PRIX_HT_V_ARTICLE"];
                    drv["PRIX_HT_TOTAL"] = Convert.ToDecimal(article["PRIX_HT_V_ARTICLE"]) * qte;
                    drv["TVA_COMMANDE"] = article["TAUX_TVA"];
                    drv["PRIX_TTC_LG_COMMANDE"] = (decimal)drv["PRIX_HT_COMMANDE"] * (1 + ((decimal)drv["TVA_COMMANDE"]) / 100);
                    drv["PRIX_TTC_TOTAL"] = Convert.ToDecimal(drv["PRIX_TTC_LG_COMMANDE"]) * qte;

                    bs.EndEdit();
                    dt_lg_commande.AcceptChanges();
                }
                calculerTotalCmd();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculerTotalCmd()
        {
            //if (CODE_CMD == "-1")
            //{
                decimal somme = 0;
                foreach (DataRow dr in dt_lg_commande.Rows)
                {
                    somme += (decimal)dr["PRIX_TTC_TOTAL"];
                }
                string s = somme.ToString("0.000");
                somme_cmd.Text = s;
            //}
        }

        private void buttonSUPPRIMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null && MessageBox.Show("Confirmer suppression ?", "Suppression d'article", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bs.RemoveCurrent();
                    bs.EndEdit();
                    bs.MoveLast();
                    dt_lg_commande.AcceptChanges();
                    calculerTotalCmd();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridViewLG_COMMANDE.AutoGenerateColumns = false;
                Application.DoEvents();
                //dt_lg_commande = CLIENT_APP_PARAM.GEST.P_COMMANDE.LOAD_SCHEMA_LG_COMMANDE();
                dt_lg_commande = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_COMMANDE();
                bs.DataSource = dt_lg_commande;
                dataGridViewLG_COMMANDE.DataSource = bs;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_Aperçu_cmd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (buttonENREGISTRER.Enabled == false)
                {
                    Application.DoEvents();
                    //DataTable[] tab = CLIENT_APP_PARAM.GEST.P_COMMANDE.PRINT(CODE_COMMANDE.Text);
                    DataTable[] tab = CLIENT_APP_PARAM.gcws.PRINT_COMMANDE(CODE_COMMANDE.Text);
                    DataSet1 ds = new DataSet1();
                    if (tab[2].Rows.Count != 0)
                    {
                        ds.SOCIETE.ImportRow(tab[2].Rows[0]);
                    }

                    if (tab[0].Rows.Count != 0)
                        ds.COMMANDE.ImportRow(tab[0].Rows[0]);

                    foreach (DataRow dr in tab[1].Rows)
                    {
                        ds.LIGNE_COMMANDE.ImportRow(dr);
                    }



                    CHM_ETAT_COMMANDE c = new CHM_ETAT_COMMANDE();
                    c.SetDataSource(ds);



                    CHM_ETATS etat = new CHM_ETATS();
                    etat.CHM_Aperçu_document.ReportSource = c;
                    etat.WindowState = FormWindowState.Maximized;
                    etat.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    etat.Show();
                }
                else
                    MessageBox.Show("Veuillez tout d'abord enregistrer la commande", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dataGridViewLG_COMMANDE_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (buttonENREGISTRER.Enabled == false)
                {
                    Application.DoEvents();
                    CHM_FICHE_BON_LIVRAISON fiche = new CHM_FICHE_BON_LIVRAISON(CODE_COMMANDE.Text, dt_lg_commande);
                    fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    fiche.Show();
                }
                else
                    MessageBox.Show("Veuillez tout d'abord enregistrer la commande", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_liste_commande_Click(object sender, EventArgs e)
        {
            Close();
            CHM_LISTE_COMMANDE liste = new CHM_LISTE_COMMANDE(1, "");
            liste.WindowState = FormWindowState.Maximized;
            liste.RightToLeft = RightToLeft.No;
            liste.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            liste.Show();
        }

        private void dataGridViewLG_COMMANDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CHM_FICHE_COMMANDE_Load(object sender, EventArgs e)
        {

        }

    }
}
