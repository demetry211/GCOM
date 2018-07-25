using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_IDENTIFICATION_UTILISATEUR : Form
    {
        private Timer timer1 = new Timer();
        private string titre = "Authentification";
        private int i = 0;
        bool verifie;
        public CHM_IDENTIFICATION_UTILISATEUR()
        {
            InitializeComponent();
            PHOTO_USER.DataBindings.Clear();
            verifie = false;
        }

        int nb = 0;
        DataTable dt;
        BindingSource bs = new BindingSource();
        

        public delegate void using_windows();
        public event using_windows after_use;
        private void buttonVALIDER_Click(object sender, EventArgs e)
        
        {
            //CHM_GESTION_COMERCIALE.RESULTAT_UTILISATEUR res = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.IDENTIFIER(LOGIN_USER.Text, PASSWORD_USER.Text);
            CHMGC.RESULTAT_UTILISATEUR res = CLIENT_APP_PARAM.gcws.IDENTIFIER(LOGIN_USER.Text, PASSWORD_USER.Text);

            try
            {
                if (res.IDENTIFIER)
                {
                    verifie = true;
                    #region old
                    ////CLIENT_APP_PARAM.Fenetre_principale.VenteMenu.Visible = res.COMMANDE_CLIENT;
                    //CLIENT_APP_PARAM.Fenetre_principale.tsb_livraison.Visible = res.COMMANDE_CLIENT;
                    //CLIENT_APP_PARAM.Fenetre_principale.tsb_reglement.Visible = res.COMMANDE_CLIENT;
                    //CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_client.Visible = res.COMMANDE_CLIENT;
                    //CLIENT_APP_PARAM.Fenetre_principale.tsb_commande.Visible = res.COMMANDE_CLIENT;
                    //CLIENT_APP_PARAM.Fenetre_principale.tsb_fournisseur.Visible = res.COMMANDE_FOURNISSEUR;
                    //CLIENT_APP_PARAM.Fenetre_principale.tsb_fc.Visible = res.COMMANDE_CLIENT;
                    ////CLIENT_APP_PARAM.Fenetre_principale.AchatMenu.Visible = res.COMMANDE_FOURNISSEUR;
                    ////CLIENT_APP_PARAM.Fenetre_principale.StockMenu.Visible = res.COMMANDE_FOURNISSEUR;
                    ////CLIENT_APP_PARAM.Fenetre_principale.ComptesMenu.Visible = res.COMPTE_USER;
                    ////CLIENT_APP_PARAM.Fenetre_principale.nouvelArticleToolStripMenuItem.Enabled = res.AJOUT_STOCK;
                    //CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_disabled.Visible = false;
                    //CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_OFF.Visible = false;
                    //CLIENT_APP_PARAM.Fenetre_principale.USER_CONNECTION_ON.Visible = true;
                    //switch (res.FONCTION)
                    //{
                    //    case "1":
                    //        CLIENT_APP_PARAM.Fenetre_principale.windowsMenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.StockMenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.windowsMenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.windmenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.VenteMenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.fileMenu.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_other.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fc.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_commande.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_bl.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_article.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_client.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fournisseur.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_livraison.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_reglement.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.btn_rapport_journalier.Visible = true;
                    //        break;
                    //    case "2":

                    //        //CLIENT_APP_PARAM.Fenetre_principale.StockMenu.Visible = false;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.windowsMenu.Visible = false;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.windmenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.VenteMenu.Visible = false;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.fileMenu.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_other.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fc.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_commande.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_bl.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_article.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_client.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fournisseur.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_livraison.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_reglement.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.btn_rapport_journalier.Visible = false;
                    //        break;
                    //    case "3":

                    //        //CLIENT_APP_PARAM.Fenetre_principale.StockMenu.Visible = false;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.windowsMenu.Visible = false;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.windmenu.Visible = true;
                    //        //CLIENT_APP_PARAM.Fenetre_principale.VenteMenu.Visible = true;

                    //        //CLIENT_APP_PARAM.Fenetre_principale.fileMenu.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_other.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fc.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_commande.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_bl.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_article.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fiche_client.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_fournisseur.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_livraison.Visible = false;
                    //        CLIENT_APP_PARAM.Fenetre_principale.tsb_reglement.Visible = true;
                    //        CLIENT_APP_PARAM.Fenetre_principale.btn_rapport_journalier.Visible = true;
                    //        break;
                    //} 
                    #endregion

                    if (bs.Current != null)
                    {
                        DataRowView drv = (DataRowView)bs.Current;
                        CLIENT_APP_PARAM.Fenetre_principale.code_user = drv["CODE_USER"].ToString();
                        CLIENT_APP_PARAM.Fenetre_principale.nom_user = drv["NOM_USER"].ToString();
                        CLIENT_APP_PARAM.Fenetre_principale.prenom_user = drv["PRENOM_USER"].ToString();
                        CLIENT_APP_PARAM.Fenetre_principale.password_user = drv["PASSWORD_USER"].ToString();
                        CLIENT_APP_PARAM.Fenetre_principale.login_user = drv["LOGIN_USER"].ToString();
                        CLIENT_APP_PARAM.Fenetre_principale.code_group = (decimal)drv["CODE_FONCTION_USER"];

                        CLIENT_APP_PARAM.Fenetre_principale.PHOTO_USER.DataBindings.Clear();
                        CLIENT_APP_PARAM.Fenetre_principale.PHOTO_USER.DataBindings.Add("Image", bs, "PHOTO_USER", true);
                        CLIENT_APP_PARAM.Fenetre_principale.NOM_USER_.Text = CLIENT_APP_PARAM.Fenetre_principale.nom_user + " " + CLIENT_APP_PARAM.Fenetre_principale.prenom_user + "\n vient de se connecter";
                        if ((Convert.ToDecimal(drv["CODE_FONCTION_USER"])) == 1)
                            CLIENT_APP_PARAM.Fenetre_principale.FONCTION_USER.Text = "Administrateur";
                        if ((Convert.ToDecimal(drv["CODE_FONCTION_USER"])) == 2)
                            CLIENT_APP_PARAM.Fenetre_principale.FONCTION_USER.Text = "Utilisateur d'achat";
                        if ((Convert.ToDecimal(drv["CODE_FONCTION_USER"])) == 3)
                            CLIENT_APP_PARAM.Fenetre_principale.FONCTION_USER.Text = "Utilisateur de vente";
                    }

                    
                    CLIENT_APP_PARAM.Fenetre_principale.chargement.Visible = false;
                    CLIENT_APP_PARAM.Fenetre_principale.USER_PANEL.Visible = true;
                    if (after_use != null)
                        after_use();
                    this.Close();
                }
                else
                {
                    nb++;
                    if (nb == 3)
                    {
                        CLIENT_APP_PARAM.Fenetre_principale.Close();
                    }
                    MessageBox.Show("Information non valides.\nVérifier le nom d'utilisateur et le mot de passe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            CLIENT_APP_PARAM.Fenetre_principale.Close();
        }

        private void CHM_IDENTIFICATION_UTILISATEUR_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (LOGIN_USER.Focused && e.KeyCode == Keys.Enter)
                {
                    PASSWORD_USER.Focus();
                    return;
                }

                if (PASSWORD_USER.Focused && e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        buttonVALIDER.PerformClick();
                        return;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHM_IDENTIFICATION_UTILISATEUR_Shown(object sender, EventArgs e)
        {
            try
            {
                LOGIN_USER.Focus();
               
                //CLIENT_APP_PARAM.GEST = (CHM_GESTION_COMERCIALE.CHM_GESTION)Activator.GetObject(typeof(CHM_GESTION_COMERCIALE.CHM_GESTION), "tcp://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/" + CLIENT_APP_PARAM.instance);
                //CLIENT_APP_PARAM.connect();
                //dt = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.RECHERCHE_UTILISATEUR(LOGIN_USER.Text);
                dt = CLIENT_APP_PARAM.gcws.RECHERCHE_UTILISATEUR(LOGIN_USER.Text);
                bs.DataSource = dt;
                bs.MoveFirst();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHM_IDENTIFICATION_UTILISATEUR_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    dt = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.RECHERCHE_UTILISATEUR(LOGIN_USER.Text);
            //    bs.DataSource = dt;
            //    bs.MoveFirst();
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LOGIN_USER_Leave(object sender, EventArgs e)
        {
            try
            {
                //dt = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.RECHERCHE_UTILISATEUR(LOGIN_USER.Text);
                dt = CLIENT_APP_PARAM.gcws.RECHERCHE_UTILISATEUR(LOGIN_USER.Text);
                bs.DataSource = dt;
                bs.MoveFirst();
                if (((DataRowView)bs.Current)["PHOTO_USER"] != null && LOGIN_USER.Text != "")
                {
                    PHOTO_USER.DataBindings.Add("Image", bs, "PHOTO_USER", true);
                    PHOTO_USER.DataBindings.Clear();
                }

                if (Convert.ToBoolean(((DataRowView)bs.Current)["ETAT_USER"]) == true)
                {
                    MessageBox.Show("Acces refusé, Cet utilisateur est bloqué!", "Accés refusé", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LOGIN_USER.SelectAll();
                    buttonVALIDER.Enabled = false;
                }
                else
                {
                    buttonVALIDER.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login invalide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PHOTO_USER.Image = PHOTO_USER.InitialImage;
                LOGIN_USER.SelectAll();
            }
        }

        private void CHM_IDENTIFICATION_UTILISATEUR_Activated(object sender, EventArgs e)
        {
            CLIENT_APP_PARAM.Fenetre_principale.STATUS.Text = "User authentification";
            CLIENT_APP_PARAM.Fenetre_principale.chargement.Visible = true;
        }

        private void LOGIN_USER_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LOGIN_USER.Text == "")
                    PHOTO_USER.Image = PHOTO_USER.InitialImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Login invalide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PHOTO_USER.Image = PHOTO_USER.InitialImage;
                LOGIN_USER.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CHM_CONFIG_SERVER f = new CHM_CONFIG_SERVER();
            //f.ShowDialog();
        }

        private void btn_configuration_Click(object sender, EventArgs e)
        {
            CHM_FRM_PASSWORD frm = new CHM_FRM_PASSWORD();
            frm.ShowDialog();
            if (frm.authentified)
            {
                CHM_DB_CONFIG f = new CHM_DB_CONFIG();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
        }

        private void CHM_IDENTIFICATION_UTILISATEUR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (verifie == false)
            {
                Application.Exit();
            }
        }

    }
}
