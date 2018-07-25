using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_FOURNISSEUR : Form
    {
        DataTable tab_fournisseur = new DataTable();
        BindingSource srcb_fournisseur = new BindingSource();
        public CHM_LISTE_FOURNISSEUR()
        {
            InitializeComponent();
            srcb_fournisseur.DataSource = CLIENT_APP_PARAM.ds_param.bsFournisseur;
            dgv_lise_fournisseur.AutoGenerateColumns = false;
            dgv_lise_fournisseur.DataSource = srcb_fournisseur;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                CLIENT_APP_PARAM.ds_param.chargerFournisseurs();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);   
            }
        }

        private void CHM_LISTE_FOURNISSEUR_Shown(object sender, EventArgs e)
        {
            
            try
            {
                Application.DoEvents();
                //tab_fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SELECT_ALL_FOURNISSEURS();
                //tab_fournisseur = CLIENT_APP_PARAM.gcws.SELECT_ALL_FOURNISSEURS();
                //srcb_fournisseur.DataSource = tab_fournisseur;
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MENU_RECHERCHE_FOURNISSEUR_TextChanged(object sender, EventArgs e)
        {
            dgv_lise_fournisseur.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                if (MENU_RECHERCHE_FOURNISSEUR.Text != string.Empty)
                {
                    //tab_fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SEARCH_FOURNISSEUR(MENU_RECHERCHE_FOURNISSEUR.Text);
                    tab_fournisseur = CLIENT_APP_PARAM.gcws.SEARCH_FOURNISSEUR(MENU_RECHERCHE_FOURNISSEUR.Text);
                    srcb_fournisseur.DataSource = tab_fournisseur;
                }
                else
                {
                    CLIENT_APP_PARAM.ds_param.chargerFournisseurs();
                    srcb_fournisseur = CLIENT_APP_PARAM.ds_param.bsFournisseur;
                    dgv_lise_fournisseur.DataSource = srcb_fournisseur;
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NV_FOURNISSEUR fiche = new CHM_NV_FOURNISSEUR("-1");
            fiche.enreg_fourn_ev += new CHM_NV_FOURNISSEUR.ENREG_FOURNISSEUR_DELEG(fiche_enreg_fourn_ev);
            fiche.ShowDialog();
        }

        void fiche_enreg_fourn_ev(DataRowView fournisseur, bool type)
        {
            if (type == true)
                srcb_fournisseur.AddNew();
            DataRowView drv = (DataRowView)srcb_fournisseur.Current;
            drv["CODE_FOURNISSEUR"] = fournisseur["CODE_FOURNISSEUR"];
            drv["REF_FOURNISSEUR"] = fournisseur["REF_FOURNISSEUR"];
            drv["RS_FOURNISSEUR"] = fournisseur["RS_FOURNISSEUR"];
            drv["ADRESSE_FOURNISSEUR"] = fournisseur["ADRESSE_FOURNISSEUR"];
            drv["TEL_FOURNISSEUR"] = fournisseur["TEL_FOURNISSEUR"];
            drv["FAX_FOURNISSEUR"] = fournisseur["FAX_FOURNISSEUR"];
            drv["EMAIL_FOURNISSEUR"] = fournisseur["EMAIL_FOURNISSEUR"];
            drv["SITE_WEB_FOURNISSEUR"] = fournisseur["SITE_WEB_FOURNISSEUR"];
            drv["RIB_FOURNISSEUR"] = fournisseur["RIB_FOURNISSEUR"];
            drv["CODE_TVA_FOURNISSEUR"] = fournisseur["CODE_TVA_FOURNISSEUR"];
            drv["RETENUE_SOURCE"] = fournisseur["RETENUE_SOURCE"];
            srcb_fournisseur.EndEdit();
            tab_fournisseur.AcceptChanges();
            CHM_LISTE_FOURNISSEUR_Shown(null, null);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (srcb_fournisseur.Current != null)
            {
                DataRowView drv = (DataRowView)srcb_fournisseur.Current;

                CHM_NV_FOURNISSEUR fiche = new CHM_NV_FOURNISSEUR(drv["CODE_FOURNISSEUR"].ToString());
                fiche.enreg_fourn_ev += new CHM_NV_FOURNISSEUR.ENREG_FOURNISSEUR_DELEG(fiche_enreg_fourn_ev);
                fiche.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (srcb_fournisseur.Current != null)
            {
                if (MessageBox.Show("Voulez vous confirmer la suppression?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Application.DoEvents();
                        DataRowView drv = (DataRowView)srcb_fournisseur.Current;
                        //string res = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.DELETE_FOURNISSEUR(drv["CODE_FOURNISSEUR"].ToString());
                        string res = CLIENT_APP_PARAM.gcws.DELETE_FOURNISSEUR(drv["CODE_FOURNISSEUR"].ToString());
                        if (res == "OK")
                        {

                            MessageBox.Show("La suppression du fournisseur à été effectuée avec succes.", "Suppression du fournisseur" + drv["CODE_FOURNISSEUR"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            srcb_fournisseur.RemoveCurrent();
                            tab_fournisseur.AcceptChanges();

                        }
                        else
                        {
                            MessageBox.Show(res, "Suppression du fournisseur" + drv["CODE_FOURNISSEUR"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void client_to_form_Click(object sender, EventArgs e)
        {
            CHM_FICHE_FOURNISSEUR f = new CHM_FICHE_FOURNISSEUR();
            f.WindowState = FormWindowState.Normal;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.RightToLeft = RightToLeft.No;
            //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.ShowDialog();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHM_LISTE_FOURNISSEUR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                CLIENT_APP_PARAM.ds_param.chargerFournisseurs();
        }
    }
}
