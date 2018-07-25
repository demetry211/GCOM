using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_ARTICLE_FOURNISSEUR : Form
    {
        DataTable tab_fournisseur;
        BindingSource srcb_fournisseur = new BindingSource();
        public delegate void fournisseur_select(DataRowView fournisseur);
        public event fournisseur_select select_fournisseur_event;
        public CHM_ARTICLE_FOURNISSEUR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHM_ARTICLE_FOURNISSEUR_Shown(object sender, EventArgs e)
        {
            dgv_lise_fournisseur.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //tab_fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SELECT_ALL_FOURNISSEURS();
                tab_fournisseur = CLIENT_APP_PARAM.gcws.SELECT_ALL_FOURNISSEURS();
                srcb_fournisseur.DataSource = tab_fournisseur;
                dgv_lise_fournisseur.DataSource = srcb_fournisseur;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MENU_RECHERCHE_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            dgv_lise_fournisseur.AutoGenerateColumns = false;
            try
            {

                if (MENU_RECHERCHE_FOURNISSEUR.Text == "")
                {
                    srcb_fournisseur.DataSource = tab_fournisseur;
                    dgv_lise_fournisseur.DataSource = srcb_fournisseur;
                }
                else
                {
                    tab_fournisseur.DefaultView.RowFilter = "(REF_FOURNISSEUR='%" + MENU_RECHERCHE_FOURNISSEUR.Text + "%') OR (RS_FOURNISSEUR='%" + MENU_RECHERCHE_FOURNISSEUR.Text + "%')";
                    DataTable dt_search = tab_fournisseur.DefaultView.ToTable();
                    tab_fournisseur.DefaultView.RowFilter = "";
                    srcb_fournisseur.DataSource = tab_fournisseur;
                    dgv_lise_fournisseur.DataSource = srcb_fournisseur;
                }
                //Application.DoEvents();
                //tab_fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SEARCH_FOURNISSEUR(MENU_RECHERCHE_FOURNISSEUR.Text);
                //srcb_fournisseur.DataSource = tab_fournisseur;
                //dgv_lise_fournisseur.DataSource = srcb_fournisseur;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_NV_FOURNISSEUR nv = new CHM_NV_FOURNISSEUR("-1");
            nv.ShowDialog();
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_lise_fournisseur.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //tab_fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SELECT_ALL_FOURNISSEURS();
                tab_fournisseur = CLIENT_APP_PARAM.gcws.SELECT_ALL_FOURNISSEURS();
                srcb_fournisseur.DataSource = tab_fournisseur;
                dgv_lise_fournisseur.DataSource = srcb_fournisseur;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (srcb_fournisseur.Current != null)
            {
                if (select_fournisseur_event != null)
                    select_fournisseur_event((DataRowView)srcb_fournisseur.Current);
                this.Close();
            }
        }

        private void dgv_lise_fournisseur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (srcb_fournisseur.Current != null)
            {
                if (select_fournisseur_event != null)
                    select_fournisseur_event((DataRowView)srcb_fournisseur.Current);
                this.Close();
            }
        }

    }
}
