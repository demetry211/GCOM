using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_COMMANDE : Form
    {
        int type = 1;
        string CODE = "";
        public CHM_LISTE_COMMANDE(int type, string CODE)
        {
            InitializeComponent();
            this.type = type;
            this.CODE = CODE;
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        private void CHM_LISTE_COMMANDE_Shown(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void chargerListe()
        {
            dgv_LISTE_COMMANDE.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                if (type == 1)
                {
                    //dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.SELECT_ALL_COMMANDE();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_COMMANDE_CLIENT();
                    this.Text = entete_Formulaire_21.windows_name.Text = "Liste des Commandes Client";
                }
                if (type == 2)
                {
                    //dt = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.SELECT_COMMANDE(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    dt = CLIENT_APP_PARAM.gcws.SELECT_COMMANDE(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    this.Text = entete_Formulaire_21.windows_name.Text = "Liste des Commandes par Utilisateur";
                }
                if (type == 3)
                {
                    //dt = CLIENT_APP_PARAM.GEST.P_CLIENT.SELECT_COMMANDE_CLIENT(CODE);
                    dt = CLIENT_APP_PARAM.gcws.SELECT_COMMANDE_CLIENT(CODE);
                    this.Text = entete_Formulaire_21.windows_name.Text = "Liste des Commandes par Client";
                }
                bs.DataSource = dt;
                dgv_LISTE_COMMANDE.DataSource = bs;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHM_LISTE_COMMANDE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.F)
            {
                panel1.Visible = true;
            }
            if (e.KeyCode == Keys.F6)
            {
                if (BTN_AJOUTER.Enabled) BTN_AJOUTER.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                if (BTN_DETAIL.Enabled) BTN_DETAIL.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                if (BTN_Aperçu_cmd.Enabled) BTN_Aperçu_cmd.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                chargerListe();
            }
            if (e.KeyCode == Keys.F3)
            {
                TB_RECHERCHE.Focus();
                TB_RECHERCHE.SelectAll();
            }
        }

        private void BTN_RECHERCHER_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dgv_LISTE_COMMANDE.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                if (cb_client.CheckState == CheckState.Checked && cb_dt_saisie.CheckState == CheckState.Checked && cb_dt_expiration.CheckState == CheckState.Checked)
                    //dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.RECHERCHE_COMMANDES(REF_CLIENT.Text, DATE_COMMANDE.Value, DATE_EXPIRATION_COMMANDE.Value);
                dt = CLIENT_APP_PARAM.gcws.RECHERCHE_COMMANDES_CLIENT_PAR_RS(REF_CLIENT.Text, DATE_COMMANDE.Value, DATE_EXPIRATION_COMMANDE.Value);
                if (cb_client.CheckState == CheckState.Checked && cb_dt_saisie.CheckState == CheckState.Checked && cb_dt_expiration.CheckState == CheckState.Unchecked)
                    //dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.RECHERCHE_COMMANDES(REF_CLIENT.Text, DATE_COMMANDE.Value, Convert.ToDateTime(null));
                dt = CLIENT_APP_PARAM.gcws.RECHERCHE_COMMANDES_CLIENT_PAR_RS(REF_CLIENT.Text, DATE_COMMANDE.Value, Convert.ToDateTime(null));
                if (cb_client.CheckState == CheckState.Checked && cb_dt_saisie.CheckState == CheckState.Unchecked && cb_dt_expiration.CheckState == CheckState.Unchecked)
                    //dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.RECHERCHE_COMMANDES(REF_CLIENT.Text, Convert.ToDateTime(null), Convert.ToDateTime(null));
                dt = CLIENT_APP_PARAM.gcws.RECHERCHE_COMMANDES_CLIENT_PAR_RS(REF_CLIENT.Text, Convert.ToDateTime(null), Convert.ToDateTime(null));
                if (cb_client.CheckState == CheckState.Unchecked && cb_dt_saisie.CheckState == CheckState.Checked && cb_dt_expiration.CheckState == CheckState.Checked)
                    //dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.RECHERCHE_COMMANDES("", DATE_COMMANDE.Value, DATE_EXPIRATION_COMMANDE.Value);
                dt = CLIENT_APP_PARAM.gcws.RECHERCHE_COMMANDES_CLIENT_PAR_RS("", DATE_COMMANDE.Value, DATE_EXPIRATION_COMMANDE.Value);
                bs.DataSource = dt;
                dgv_LISTE_COMMANDE.DataSource = bs;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void dgv_LISTE_COMMANDE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                CHM_FICHE_COMMANDE fiche = new CHM_FICHE_COMMANDE(drv["CODE_COMMANDE"].ToString());
                fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                fiche.Show();
            }
        }

        private void BTN_AJOUTER_Click(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {
                    CHM_FICHE_COMMANDE cmd = new CHM_FICHE_COMMANDE("-1");
                    cmd.WindowState = FormWindowState.Maximized;
                    cmd.RightToLeft = RightToLeft.No;
                    cmd.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    cmd.Show();
                }
                else
                {
                    MessageBox.Show("Magasin encours d'inventaire.", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void BTN_Aperçu_cmd_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                this.Cursor = Cursors.WaitCursor;

                try
                {

                    Application.DoEvents();
                    //DataTable[] tab = CLIENT_APP_PARAM.GEST.P_COMMANDE.PRINT((bs.Current as DataRowView)["CODE_COMMANDE"].ToString());
                    DataTable[] tab = CLIENT_APP_PARAM.gcws.PRINT_COMMANDE((bs.Current as DataRowView)["CODE_COMMANDE"].ToString());
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
                    etat.Show();

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TB_RECHERCHE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TB_RECHERCHE.Text == "")
                {
                    bs.DataSource = dt;
                    dgv_LISTE_COMMANDE.DataSource = bs;
                }
                else
                {
                    dt.DefaultView.RowFilter = "CODE_COMMANDE like '%" + TB_RECHERCHE.Text + "%'";
                    DataTable dt_search = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";
                    bs.DataSource = dt_search;
                    dgv_LISTE_COMMANDE.DataSource = bs;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void BTN_DETAIL_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                CHM_FICHE_COMMANDE fiche = new CHM_FICHE_COMMANDE(drv["CODE_COMMANDE"].ToString());
                fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                fiche.Show();
            }
        }

    }
}
