using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace CHM_CLIENT_APP
{
    public partial class CHM_ACTIVER_UTILISATEUR : Form
    {
        public CHM_ACTIVER_UTILISATEUR()
        {
            InitializeComponent();
        }

        private void CHM_ACTIVER_UTILISATEUR_Shown(object sender, EventArgs e)
        {
            LOGIN_USER.Text = CLIENT_APP_PARAM.Fenetre_principale.login_user;
            PASSWORD_USER.Focus();

        }

        static WaitHandle[] waithandles = new WaitHandle[] { new AutoResetEvent(false) };
        private void buttonVALIDER_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(CLIENT_APP_PARAM.connect), waithandles[0]);
                WaitHandle.WaitAll(waithandles);
                //CLIENT_APP_PARAM.connect();
                if (PASSWORD_USER.Text == CLIENT_APP_PARAM.Fenetre_principale.password_user)
                {
                    PASSWORD_USER.Text = "";
                    if (CLIENT_APP_PARAM.Fenetre_principale.code_user != "")
                    {
                        CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_ON.Visible = true;
                        CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_OFF.Visible = false;
                        CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_disabled.Visible = false;
                        CLIENT_APP_PARAM.Fenetre_principale.r = 0;
                    }
                    foreach (Form f in CLIENT_APP_PARAM.Fenetre_principale.MdiChildren)
                    {
                        f.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Information incorrecte. Veuillez vérifier le login et le mot de passe.", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.None);
                    PASSWORD_USER.SelectAll();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres de charger l'utilisateur?\nLa session courante sera fermée et les informations peut etre perdues.", "Changement d'utilisateur", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CLIENT_APP_PARAM.Fenetre_principale.code_user = "";
                CLIENT_APP_PARAM.Fenetre_principale.nom_user = "";
                CLIENT_APP_PARAM.Fenetre_principale.prenom_user = "";
                CLIENT_APP_PARAM.Fenetre_principale.password_user = "";
                CLIENT_APP_PARAM.Fenetre_principale.PHOTO_USER.DataBindings.Clear();
                if (CLIENT_APP_PARAM.Fenetre_principale.code_user == "")
                {
                    IEnumerator i = CLIENT_APP_PARAM.Fenetre_principale.imageList1.Images.GetEnumerator();

                    i.Reset();
                    i.MoveNext();
                    i.MoveNext();
                    i.MoveNext();

                    CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_OFF.Image = (Image)i.Current;
                }
                foreach (Form f in CLIENT_APP_PARAM.Fenetre_principale.MdiChildren)
                {
                    f.Close();
                }
                this.Close();
                CHM_IDENTIFICATION_UTILISATEUR fenetre = new CHM_IDENTIFICATION_UTILISATEUR();
                fenetre.after_use += new CHM_IDENTIFICATION_UTILISATEUR.using_windows(fenetre_after_use);
                fenetre.ShowDialog();
            }
        }

        void fenetre_after_use()
        {
            CLIENT_APP_PARAM.chargerAccesMenu();
        }

        private void CHM_ACTIVER_UTILISATEUR_KeyDown(object sender, KeyEventArgs e)
        {
            if (PASSWORD_USER.Focused && e.KeyCode == Keys.Enter)
                buttonVALIDER.PerformClick();
        }
    }
}
