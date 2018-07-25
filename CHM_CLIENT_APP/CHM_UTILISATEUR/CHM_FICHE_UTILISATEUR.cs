using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_UTILISATEUR : Form
    {
        public CHM_FICHE_UTILISATEUR()
        {
            InitializeComponent();
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        private void CHM_FICHE_UTILISATEUR_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_UTILISATEUR();
            bs.DataSource = dt;
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                NOM_USER.Text = drv["NOM_USER"].ToString();
                if ((bool)drv["ETAT_USER"] == true)
                    ETAT_USER.CheckState = CheckState.Checked;
                else
                    ETAT_USER.CheckState = CheckState.Unchecked;
                PRENOM_USER.Text = drv["PRENOM_USER"].ToString();
                PHOTO_USER.DataBindings.Add("Image", bs, "PHOTO_USER", true);
                LOGIN_USER.Text = drv["LOGIN_USER"].ToString();
                PASSWORD_USER.Text = drv["PASSWORD_USER"].ToString();
                CODE_SOCIETE.Text = drv["CODE_SOCIETE"].ToString();
                FONCTION_USER.Text = drv["CODE_FONCTION_USER"].ToString();

            }
        }

        private void BTN_SUIVANT_Click(object sender, EventArgs e)
        {
            PHOTO_USER.DataBindings.Clear();
            bs.MoveNext();
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                NOM_USER.Text = drv["NOM_USER"].ToString();
                if ((bool)drv["ETAT_USER"] == true)
                    ETAT_USER.CheckState = CheckState.Checked;
                else
                    ETAT_USER.CheckState = CheckState.Unchecked;
                PRENOM_USER.Text = drv["PRENOM_USER"].ToString();
                PHOTO_USER.DataBindings.Add("Image", bs, "PHOTO_USER", true);
                LOGIN_USER.Text = drv["LOGIN_USER"].ToString();
                PASSWORD_USER.Text = drv["PASSWORD_USER"].ToString();
                CODE_SOCIETE.Text = drv["CODE_SOCIETE"].ToString();
                FONCTION_USER.Text = drv["CODE_FONCTION_USER"].ToString();
            }
        }

        private void BTN_PRECEDENT_Click(object sender, EventArgs e)
        {
            PHOTO_USER.DataBindings.Clear();
            bs.MovePrevious();
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                NOM_USER.Text = drv["NOM_USER"].ToString();
                if ((bool)drv["ETAT_USER"] == true)
                    ETAT_USER.CheckState = CheckState.Checked;
                else
                    ETAT_USER.CheckState = CheckState.Unchecked;
                PRENOM_USER.Text = drv["PRENOM_USER"].ToString();
                PHOTO_USER.DataBindings.Add("Image", bs, "PHOTO_USER", true);
                LOGIN_USER.Text = drv["LOGIN_USER"].ToString();
                PASSWORD_USER.Text = drv["PASSWORD_USER"].ToString();
                CODE_SOCIETE.Text = drv["CODE_SOCIETE"].ToString();
                FONCTION_USER.Text = drv["CODE_FONCTION_USER"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_NV_UTILISATEUR fiche = new CHM_NV_UTILISATEUR("-1");
            fiche.ENREG_EV += new CHM_NV_UTILISATEUR.ENREG_DELEG(fiche_ENREG_EV);
            fiche.ShowDialog();
        }

        void fiche_ENREG_EV(DataRowView user, bool type_ev)
        {
            if (type_ev)
            {
                bs.AddNew();
            }
            DataRowView drv = (DataRowView)bs.Current;
            drv["CODE_USER"] = user["CODE_USER"];
            drv["NOM_USER"] = user["NOM_USER"];
            drv["PRENOM_USER"] = user["PRENOM_USER"];
            drv["PHOTO_USER"] = user["PHOTO_USER"];
            drv["LOGIN_USER"] = user["LOGIN_USER"];
            drv["PASSWORD_USER"] = user["PASSWORD_USER"];
            drv["ETAT_USER"] = user["ETAT_USER"];
            drv["CODE_SOCIETE"] = user["CODE_SOCIETE"];
            drv["CODE_FONCTION_USER"] = user["CODE_FONCTION_USER"];
            bs.EndEdit();
            dt.AcceptChanges();
        }

        private void buttonENREGISTRER_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                CHM_NV_UTILISATEUR fiche = new CHM_NV_UTILISATEUR(drv["CODE_USER"].ToString());
                fiche.ENREG_EV += new CHM_NV_UTILISATEUR.ENREG_DELEG(fiche_ENREG_EV);
                fiche.ShowDialog();
            }
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                if (MessageBox.Show("Voulez vous confirmer la supression ?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res;
                    CHMGC.RESULT_QUERY res;
                    try
                    {
                        DataRowView drv = (DataRowView)bs.Current;
                        Application.DoEvents();
                        //res = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.DELETE_UTILISATEUR(drv["CODE_USER"].ToString());
                        res = CLIENT_APP_PARAM.gcws.DELETE_UTILISATEUR(drv["CODE_USER"].ToString());
                        if (res.OK)
                        {
                            bs.RemoveCurrent();
                            dt.AcceptChanges();
                        }
                        else
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
