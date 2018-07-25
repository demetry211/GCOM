using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_FOURNISSEUR : Form
    {
        DataTable tab_fournisseur = new DataTable();
        BindingSource srcb_fournisseur = new BindingSource();
        public CHM_FICHE_FOURNISSEUR()
        {
            InitializeComponent();
        }

        private void CHM_FICHE_FOURNISSEUR_Shown(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                //tab_fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SELECT_ALL_FOURNISSEURS();
                tab_fournisseur = CLIENT_APP_PARAM.gcws.SELECT_ALL_FOURNISSEURS();
                srcb_fournisseur.DataSource = tab_fournisseur;
                if (tab_fournisseur.Rows.Count > 0)
                {
                    srcb_fournisseur.MoveFirst();
                    if (srcb_fournisseur.Current != null)
                    {

                        DataRowView drv = (DataRowView)srcb_fournisseur.Current;

                        REF_FOURNISSEUR.Text = drv["REF_FOURNISSEUR"].ToString();
                        RS_FOURNISSEUR.Text = drv["RS_FOURNISSEUR"].ToString();
                        ADRESSE_FOURNISSEUR.Text = drv["ADRESSE_FOURNISSEUR"].ToString();
                        TEL_FOURNISSEUR.Text = drv["TEL_FOURNISSEUR"].ToString();
                        FAX_FOURNISSEUR.Text = drv["FAX_FOURNISSEUR"].ToString();
                        EMAIL_FOURNISSEUR.Text = drv["EMAIL_FOURNISSEUR"].ToString();
                        SITE_WEB_FOURNISSEUR.Text = drv["SITE_WEB_FOURNISSEUR"].ToString();
                        RIB_FOURNISSEUR.Text = drv["RIB_FOURNISSEUR"].ToString();
                        CODE_TVA_FOURNISSEUR.Text = drv["CODE_TVA_FOURNISSEUR"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Aucun fournisseur n'est encore enregistré.","CHM Commercial Management Program");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHM_FICHE_FOURNISSEUR_Load(object sender, EventArgs e)
        {

            
        }

        private void BTN_FOURNISSEUR_SUIVANT_Click(object sender, EventArgs e)
        {
            srcb_fournisseur.MoveNext();
            if (srcb_fournisseur.Current != null)
            {
                DataRowView drv = (DataRowView)srcb_fournisseur.Current;
                REF_FOURNISSEUR.Text = drv["REF_FOURNISSEUR"].ToString();
                RS_FOURNISSEUR.Text = drv["RS_FOURNISSEUR"].ToString();
                ADRESSE_FOURNISSEUR.Text = drv["ADRESSE_FOURNISSEUR"].ToString();
                TEL_FOURNISSEUR.Text = drv["TEL_FOURNISSEUR"].ToString();
                FAX_FOURNISSEUR.Text = drv["FAX_FOURNISSEUR"].ToString();
                EMAIL_FOURNISSEUR.Text = drv["EMAIL_FOURNISSEUR"].ToString();
                SITE_WEB_FOURNISSEUR.Text = drv["SITE_WEB_FOURNISSEUR"].ToString();
                RIB_FOURNISSEUR.Text = drv["RIB_FOURNISSEUR"].ToString();
                CODE_TVA_FOURNISSEUR.Text = drv["CODE_TVA_FOURNISSEUR"].ToString();
            }
        }

        private void BTN_FOURNISSEUR_PRECEDENT_Click(object sender, EventArgs e)
        {
            srcb_fournisseur.MovePrevious();
            if (srcb_fournisseur.Current != null)
            {
                DataRowView drv = (DataRowView)srcb_fournisseur.Current;
                REF_FOURNISSEUR.Text = drv["REF_FOURNISSEUR"].ToString();
                RS_FOURNISSEUR.Text = drv["RS_FOURNISSEUR"].ToString();
                ADRESSE_FOURNISSEUR.Text = drv["ADRESSE_FOURNISSEUR"].ToString();
                TEL_FOURNISSEUR.Text = drv["TEL_FOURNISSEUR"].ToString();
                FAX_FOURNISSEUR.Text = drv["FAX_FOURNISSEUR"].ToString();
                EMAIL_FOURNISSEUR.Text = drv["EMAIL_FOURNISSEUR"].ToString();
                SITE_WEB_FOURNISSEUR.Text = drv["SITE_WEB_FOURNISSEUR"].ToString();
                RIB_FOURNISSEUR.Text = drv["RIB_FOURNISSEUR"].ToString();
                CODE_TVA_FOURNISSEUR.Text = drv["CODE_TVA_FOURNISSEUR"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void BTN_ANNULER_FOURNISSEUR_Click(object sender, EventArgs e)
        {
            if (srcb_fournisseur.Current != null)
            {
                DataRowView drv = (DataRowView)srcb_fournisseur.Current;

                CHM_NV_FOURNISSEUR fiche = new CHM_NV_FOURNISSEUR(drv["CODE_FOURNISSEUR"].ToString());
                fiche.enreg_fourn_ev += new CHM_NV_FOURNISSEUR.ENREG_FOURNISSEUR_DELEG(fiche_enreg_fourn_ev);
                fiche.ShowDialog();
            }
        }

        private void BTN_ENREG_FOURNISSEUR_Click(object sender, EventArgs e)
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
            srcb_fournisseur.EndEdit();
            tab_fournisseur.AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void client_to_liste_Click(object sender, EventArgs e)
        {
            CHM_LISTE_FOURNISSEUR l = new CHM_LISTE_FOURNISSEUR();
            l.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            l.Show();
            this.Close();
        }
    }
}
