using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_UTILISATEUR;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NV_UTILISATEUR : Form
    {
        public delegate void ENREG_DELEG(DataRowView user, bool type_ev);
        public event ENREG_DELEG ENREG_EV;
        string code_user = "-1";
        DataTable dt;
        BindingSource srcb = new BindingSource();
        public CHM_NV_UTILISATEUR(string code_user)
        {
            InitializeComponent();
            this.code_user = code_user;
        }

        private void BTN_FERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ENREGISTRER_Click(object sender, EventArgs e)
        {
            #region TEST
            errorProvider1.SetError(NV_NOM_USER, "");
            if (NV_NOM_USER.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_NOM_USER, "Veuillez entrer le nom !");
                NV_NOM_USER.Focus();

                return;
            }
            errorProvider1.Clear();


            errorProvider1.SetError(NV_PRENOM_USER, "");
            if (NV_PRENOM_USER.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_PRENOM_USER, "Veuillez entrer le prenom !");
                NV_PRENOM_USER.Focus();

                return;
            }
            errorProvider1.Clear();
            errorProvider1.SetError(NV_LOGIN_USER, "");
            if (NV_LOGIN_USER.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_LOGIN_USER, "Veuillez entrer le pseudo-name ");
                NV_LOGIN_USER.Focus();

                return;
            }
            errorProvider1.Clear();
            errorProvider1.SetError(NV_PASSWORD_USER, "");
            if (NV_PASSWORD_USER.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_PASSWORD_USER, "Veuillez entrer le mot de passe !");
                NV_PASSWORD_USER.Focus();

                return;
            }
            errorProvider1.Clear();
            errorProvider1.SetError(NV_FONCTION_USER, "");
            if (NV_FONCTION_USER.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_FONCTION_USER, "Veuillez choisir la fonction de l'utilisateur !");
                NV_FONCTION_USER.Focus();

                return;
            }
            errorProvider1.Clear();

            #endregion
            try
            {
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                try
                {
                    srcb.EndEdit();
                    dt.AcceptChanges();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt.RejectChanges();
                    return;
                }
                if (code_user == "-1")
                {
                    Application.DoEvents();
                    res = CLIENT_APP_PARAM.gcws.INSERT_UTILISATEUR(code_user, NV_NOM_USER.Text, NV_PRENOM_USER.Text, CLIENT_APP_PARAM.IMAGE_TO_BYTE(NV_PHOTO_USER.Image), NV_LOGIN_USER.Text, NV_PASSWORD_USER.Text, NV_ETAT_USER.Checked, ((int)NV_SOCIETE.SelectedIndex + 1).ToString(), (NV_FONCTION_USER.SelectedIndex + 1).ToString());
                    code_user = res.CODE;
                    ((DataRowView)srcb.Current)["CODE_USER"] = code_user;
                    if (ENREG_EV != null)
                        ENREG_EV((DataRowView)srcb.Current, true);

                    if (res.OK)
                    {

                        MessageBox.Show(res.MESSAGE , "Ajout d'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE , "Ajout d'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.DoEvents();
                    string fct = NV_FONCTION_USER.SelectedValue.ToString();
                    res = CLIENT_APP_PARAM.gcws.UPDATE_UTILISATEUR(code_user, NV_NOM_USER.Text, NV_PRENOM_USER.Text, CLIENT_APP_PARAM.IMAGE_TO_BYTE(NV_PHOTO_USER.Image), NV_LOGIN_USER.Text, NV_PASSWORD_USER.Text, NV_ETAT_USER.Checked, NV_SOCIETE.SelectedValue.ToString(), NV_FONCTION_USER.SelectedValue.ToString());
                    if (ENREG_EV != null)
                        ENREG_EV((DataRowView)srcb.Current, false);

                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE , "Modification d'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE , "Modification d'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable df;
        BindingSource bsf = new BindingSource();
        DataTable dt_societe;
        BindingSource bs_societe = new BindingSource();
        private void CHM_NV_UTILISATEUR_Shown(object sender, EventArgs e)
        {
            try
            {
                if (code_user != "-1")
                {
                    this.Text =nom_fenetre.Text= "Modification d'utilisateur";
                }
                Application.DoEvents();
                dt = CLIENT_APP_PARAM.gcws.LOAD_UTILISATEUR(code_user);
                srcb.DataSource = dt;
                dt_societe = CLIENT_APP_PARAM.gcws.SELECT_ALL_SOCIETE();
                NV_SOCIETE.DataSource = dt_societe;
                NV_SOCIETE.DisplayMember = "RS_SOCIETE";
                NV_SOCIETE.ValueMember = "CODE_SOCIETE";
                NV_NOM_USER.DataBindings.Add("Text", srcb, "NOM_USER");
                NV_PRENOM_USER.DataBindings.Add("Text", srcb, "PRENOM_USER", true);
                NV_ETAT_USER.DataBindings.Add("Checked", srcb, "ETAT_USER", true);
                NV_PHOTO_USER.DataBindings.Add("Image", srcb, "PHOTO_USER", true);
                NV_LOGIN_USER.DataBindings.Add("Text", srcb, "LOGIN_USER", true);
                NV_PASSWORD_USER.DataBindings.Add("Text", srcb, "PASSWORD_USER", true);
                //NV_FONCTION_USER.DataBindings.Add("Text", srcb, "CODE_FONCTION_USER", true);
                NV_SOCIETE.DataBindings.Add("Text", srcb, "CODE_SOCIETE", true);
                df = CLIENT_APP_PARAM.gcws.SELECT_FONCTION();
                //bsf.DataSource = df;
                NV_FONCTION_USER.DataSource = df;
                NV_FONCTION_USER.DisplayMember = "LIB_FONCTION_USER";
                NV_FONCTION_USER.ValueMember = "CODE_FONCTION_USER";
                if (code_user != "-1")
                {
                    NV_FONCTION_USER.SelectedValue = (srcb.Current as DataRowView)["CODE_FONCTION_USER"];
                }
                if (code_user == "-1")
                {
                    this.Text = "Ajout d'utilisateur";
                    srcb.AddNew();
                    DataRowView drv = (DataRowView)srcb.Current;
                    drv["CODE_USER"] = -1;
                    drv["ETAT_USER"] = false;     
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NV_PHOTO_USER_Click(object sender, EventArgs e)
        {
            if (ofd_PHOTO_USER.ShowDialog() == DialogResult.OK)
            {
                NV_PHOTO_USER.Image = Image.FromFile(ofd_PHOTO_USER.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_GU f = new CHM_FRM_MAJ_GU(0);
            f.ShowDialog();
            df = CLIENT_APP_PARAM.gcws.SELECT_FONCTION();            
            NV_FONCTION_USER.DataSource = df;
            NV_FONCTION_USER.DisplayMember = "LIB_FONCTION_USER";
            NV_FONCTION_USER.ValueMember = "CODE_FONCTION_USER";
        }

    }
}
