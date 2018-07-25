using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using CHM_CLIENT_APP.CHM_STOCK;
using CHM_CLIENT_APP.CHM_Fenetre_principale;
using System.Threading;
using CHM_CLIENT_APP.CHM_CLIENT;
using CHM_CLIENT_APP.FICHE_INTERVENTION;
using CHM_CLIENT_APP.CHM_INVENTAIRE;
using CHM_CLIENT_APP.CHM_TICKET_CAISSE;
using CHM_CLIENT_APP.CHM_DEVI;
using CrystalDecisions.CrystalReports.Engine;
using CHM_CLIENT_APP.CHM_REGLEMENT;
using CHM_CLIENT_APP.EQUIPEMENTS;
using CHM_CLIENT_APP.CHM_ARTICLES;
using CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE;
using CHM_CLIENT_APP.CHM_ARTICLES.TARIFICATION_VENTE;
using CHM_CLIENT_APP.CHM_TVA;

namespace CHM_CLIENT_APP
{
    public partial class CHM_COMMERCIAL_MANAGEMENT_PROGRAM : Form
    {
        private int childFormNumber = 0;
        public string code_user = "";
        public string nom_user = "";
        public string prenom_user = "";
        public string password_user = "";
        public string login_user = "";
        public string nom_machine = "";
        public string ip_address = "";
        public decimal code_group = 0;
        private string[] adresse_ip;
        public bool licensefied = false;
        public CHM_COMMERCIAL_MANAGEMENT_PROGRAM()
        {
            InitializeComponent();

            
            //CLIENT_APP_PARAM.ds_param = new DS_GC();
            //adresse_ip = GetIPaddresses(nom_machine);
            //int i = 0;
            //while (adresse_ip[i] != null)
            //{
            //    ip_address = adresse_ip[i];
            //    i++;
            //}
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Créez une nouvelle instance du formulaire enfant.
            Form childForm = new Form();
            // Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO : ajoutez le code ici pour ouvrir le fichier.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO : ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : utilisez System.Windows.Forms.Clipboard pour insérer le texte ou les images sélectionnés dans le Presse-papiers
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : utilisez System.Windows.Forms.Clipboard pour insérer le texte ou les images sélectionnés dans le Presse-papiers
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : utilisez System.Windows.Forms.Clipboard.GetText() ou System.Windows.Forms.GetData pour extraire les informations du Presse-papiers.
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NOUVEAU_CLIENT clt = new CHM_NOUVEAU_CLIENT("-1");
            clt.StartPosition = FormStartPosition.CenterScreen;
            clt.WindowState = FormWindowState.Normal;
            clt.RightToLeft = RightToLeft.No;
            clt.ShowDialog();
        }

        private void fichesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FICHE_CLIENT clt = new CHM_FICHE_CLIENT(CLIENT_APP_PARAM.ds_param.bsClient);
            clt.StartPosition = FormStartPosition.CenterScreen;
            clt.WindowState = FormWindowState.Normal;
            clt.RightToLeft = RightToLeft.No;
            clt.ShowDialog();
        }

        private void listesDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste_client clt = new liste_client("l");
            clt.WindowState = FormWindowState.Maximized;
            clt.RightToLeft = RightToLeft.No;
            clt.MdiParent = this;
            clt.Show();
        }

        private void fonctionnalitésUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FONCTIONNALITE_UTILISATEUR fct = new FONCTIONNALITE_UTILISATEUR();
            fct.MdiParent = this;
            fct.Show();
        }

        private void nouvelArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            ((DataRowView)bs.Current)["CODE_ARTICLE"] = -1;
            CHM_NV_ARTICLE article = new CHM_NV_ARTICLE(CLIENT_APP_PARAM.ds_param.bsArticle);
            article.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(article_Enregistrer);
            article.ShowDialog();
        }

        void article_Enregistrer(DataRowView dr, bool nouv)
        {
            
        }

        private void listesDesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {
                    CHM_LISTE_ARTICLES liste = new CHM_LISTE_ARTICLES();
                    liste.MdiParent = this;
                    liste.WindowState = FormWindowState.Maximized;
                    liste.RightToLeft = RightToLeft.No;
                    liste.Show();
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

        private void ficheArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_ARTICLE article = new CHM_ARTICLE();
            article.MdiParent = this;
            article.Show();
        }

        private void fichesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FICHE_FOURNISSEUR fiche = new CHM_FICHE_FOURNISSEUR();
            fiche.WindowState = FormWindowState.Normal;
            fiche.StartPosition = FormStartPosition.CenterScreen;
            fiche.RightToLeft = RightToLeft.No;
            //fiche.MdiParent = this;
            fiche.ShowDialog();
        }

        private void listeDesFournisseursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_LISTE_FOURNISSEUR liste = new CHM_LISTE_FOURNISSEUR();
            liste.WindowState = FormWindowState.Maximized;
            liste.RightToLeft = RightToLeft.No;
            liste.MdiParent = this;
            liste.Show();
        }

        private void nouvelFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NV_FOURNISSEUR nv = new CHM_NV_FOURNISSEUR("-1");
            nv.WindowState = FormWindowState.Normal;
            nv.StartPosition = FormStartPosition.CenterScreen;
            //nv.MdiParent = this;
            nv.ShowDialog();
        }

        private void paramètresDeLaSociétéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FICHE_SOCIETE fiche = new CHM_FICHE_SOCIETE();
            fiche.RightToLeft = RightToLeft.No;
            fiche.StartPosition = FormStartPosition.CenterScreen;
            //fiche.MdiParent = this;
            fiche.ShowDialog();
        }

        private void nouvelleCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {
                    CHM_FICHE_COMMANDE cmd = new CHM_FICHE_COMMANDE("-1");
                    cmd.WindowState = FormWindowState.Maximized;
                    cmd.RightToLeft = RightToLeft.No;
                    cmd.MdiParent = this;
                    cmd.Show();
                }
                else
                {
                    MessageBox.Show("Magasin encours d'inventaire.", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NOUVEAU_CLIENT nv = new CHM_NOUVEAU_CLIENT("-1");
            nv.ShowDialog();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NV_FOURNISSEUR nv = new CHM_NV_FOURNISSEUR("-1");
            nv.ShowDialog();
        }

        private void articleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_NV_ARTICLE nv = new CHM_NV_ARTICLE(CLIENT_APP_PARAM.ds_param.bsArticle);
            nv.ShowDialog();
        }

        private void ficheArticlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_ARTICLE fiche = new CHM_ARTICLE();
            fiche.MdiParent = this;
            fiche.Show();
        }

        private void ficheClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FICHE_CLIENT fiche = new CHM_FICHE_CLIENT(CLIENT_APP_PARAM.ds_param.bsClient);
            fiche.MdiParent = this;
            fiche.Show();
        }

        private void listeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste_client liste = new liste_client("l");
            liste.MdiParent = this;
            liste.Show();
        }

        private void ficheFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FICHE_FOURNISSEUR fiche = new CHM_FICHE_FOURNISSEUR();
            fiche.MdiParent = this;
            fiche.Show();
        }

        private void listeFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_FOURNISSEUR liste = new CHM_LISTE_FOURNISSEUR();
            liste.MdiParent = this;
            liste.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CHM_FICHE_COMMANDE fiche = new CHM_FICHE_COMMANDE("-1");
            fiche.MdiParent = this;
            fiche.Show();

        }

        private void CHM_COMMERCIAL_MANAGEMENT_PROGRAM_FormClosing(object sender, FormClosingEventArgs e)
        {
            tsb_bl.Enabled = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {
                    CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("1");
                    l.RightToLeft = RightToLeft.No;
                    l.WindowState = FormWindowState.Maximized;
                    l.MdiParent = this;
                    l.Show();
                }
                else
                {
                    MessageBox.Show("Magasin encours d'inventaire.", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //CHM_FICHE_COMMANDE cmd = new CHM_FICHE_COMMANDE("-1");
                //cmd.WindowState = FormWindowState.Maximized;
                //cmd.RightToLeft =   RightToLeft.No;
                //cmd.MdiParent = this;
                //cmd.Show();
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {

                    //CHM_FACTURE.CHM_FACTURE_POS f = new CHM_CLIENT_APP.CHM_FACTURE.CHM_FACTURE_POS();
                    //f.WindowState = FormWindowState.Maximized;
                    //f.MdiParent = this;
                    //f.Show();
                    CHM_LISTE_COMMANDE liste = new CHM_LISTE_COMMANDE(1, "");
                    liste.WindowState = FormWindowState.Maximized;
                    liste.RightToLeft = RightToLeft.No;
                    liste.MdiParent = this;
                    liste.Show();
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //CHM_ARTICLE fiche = new CHM_ARTICLE();
                //fiche.MdiParent = this;
                //fiche.Show();
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {
                    CHM_LISTE_ARTICLES liste = new CHM_LISTE_ARTICLES();
                    liste.MdiParent = this;
                    liste.WindowState = FormWindowState.Maximized;
                    liste.RightToLeft = RightToLeft.No;
                    liste.Show();
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //CHM_FICHE_CLIENT fiche = new CHM_FICHE_CLIENT();
            //fiche.StartPosition = FormStartPosition.CenterScreen;
            ////fiche.MdiParent = this;
            //fiche.Show();

            liste_client clt = new liste_client("l");
            clt.WindowState = FormWindowState.Maximized;
            clt.RightToLeft = RightToLeft.No;
            clt.MdiParent = this;
            clt.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //CHM_FICHE_FOURNISSEUR fiche = new CHM_FICHE_FOURNISSEUR();
            ////fiche.MdiParent = this;
            //fiche.StartPosition = FormStartPosition.CenterScreen;
            //fiche.Show();

            CHM_LISTE_FOURNISSEUR liste = new CHM_LISTE_FOURNISSEUR();
            liste.WindowState = FormWindowState.Maximized;
            liste.RightToLeft = RightToLeft.No;
            liste.MdiParent = this;
            liste.Show();
        }

        private void listesDesUtilisateursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_LISTE_UTILISATEURS liste = new CHM_LISTE_UTILISATEURS();
            liste.MdiParent = this;
            liste.Show();
        }

        private void listesDesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_UTILISATEURS liste = new CHM_LISTE_UTILISATEURS();
            liste.RightToLeft = RightToLeft.No;
            //liste.WindowState = FormWindowState.Maximized;
            liste.MdiParent = this;
            liste.Show();
        }

        private void nouvelComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NV_UTILISATEUR fiche = new CHM_NV_UTILISATEUR("-1");
            fiche.RightToLeft = RightToLeft.No;
            fiche.StartPosition = FormStartPosition.CenterScreen;
            fiche.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CHM_FICHE_UTILISATEUR fiche = new CHM_FICHE_UTILISATEUR();
            fiche.RightToLeft = RightToLeft.No;
            fiche.StartPosition = FormStartPosition.CenterScreen;
            fiche.Show();
        }
        string server_connection_state;
        string user_connection_state;
        public int r = 0;
        int b = 0;
        int i;
        int j;
        DataTable dt;
        BindingSource bs = new BindingSource();

        DateTime date=new DateTime();

        CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_FRM_INTRO Intro;
        private void CHM_COMMERCIAL_MANAGEMENT_PROGRAM_Shown(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void fenetre_after_use()
        {
            try
            {
                CLIENT_APP_PARAM.chargerAccesMenu();
                TMR_REFRECH_CNX_Tick(null, null);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void fenetr_Shown(object sender, EventArgs e)
        {
            r = 0;
            MessageBox.Show("Le serveur est connecté, voulez vous continuer?", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void fenetr_Activated(object sender, EventArgs e)
        {
            r = 0;
            MessageBox.Show("Le serveur est connecté, voulez vous continuer?", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void arreterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres de fermer l'applications?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                tsb_bl.Enabled = true;
            }
        }

        private void redémarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres de redémarrer l'applications?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USER_PANEL.Visible = false;
            if (code_user != "")
            {
                USER_CONNECTION_ON.Visible = true;
                USER_CONNECTION_OFF.Visible = false;
                USER_CONNECTION_disabled.Visible = false;
            }
        }

        private void fermerLaSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sûre de changer d'utilisateur?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    code_user = "";
                    nom_user = "";
                    prenom_user = "";
                    PHOTO_USER.DataBindings.Clear();
                    if (code_user == "")
                    {
                        IEnumerator i = imageList1.Images.GetEnumerator();

                        i.Reset();
                        i.MoveNext();
                        i.MoveNext();
                        i.MoveNext();
                        USER_CONNECTION_OFF.Image = (Image)i.Current;
                    }
                    foreach (Form f in this.MdiChildren)
                    {
                        f.Close();
                    }
                    CONTROL_PANEL.Visible = false;
                    CHM_IDENTIFICATION_UTILISATEUR fenetre = new CHM_IDENTIFICATION_UTILISATEUR();
                    fenetre.after_use += new CHM_IDENTIFICATION_UTILISATEUR.using_windows(fenetre_after_use);
                    fenetre.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void listeDesCommandesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_LISTE_COMMANDE liste = new CHM_LISTE_COMMANDE(1, "");
            liste.WindowState = FormWindowState.Maximized;
            liste.RightToLeft = RightToLeft.No;
            liste.MdiParent = this;
            liste.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "Quitter";
            BUTTON_FUNCTION.ForeColor = Color.Red;

        }

        private void BTN_ARRETER_MouseLeave(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "";
        }

        private void BTN_REDEMARRER_MouseEnter(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "Redémarrer";
            BUTTON_FUNCTION.ForeColor = Color.Green;

        }

        private void BTN_REDEMARRER_MouseLeave(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "";
        }

        private void BTN_CHANGER_DE_SESSION_MouseEnter(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "Changer d'utilisateur";
            BUTTON_FUNCTION.ForeColor = Color.Blue;
        }

        private void BTN_CHANGER_DE_SESSION_MouseLeave(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "";
        }

        private void BTN_VEROUILLER_MouseEnter(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "Vérouiller";
            BUTTON_FUNCTION.ForeColor = Color.Yellow;
        }

        private void BTN_VEROUILLER_MouseLeave(object sender, EventArgs e)
        {
            BUTTON_FUNCTION.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CONTROL_PANEL.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CONTROL_PANEL.Visible = false;
        }

        private void verouilerLaSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sûres de verouiller l'application.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (Form f in this.MdiChildren)
                    {
                        f.Hide();
                    }
                    CONTROL_PANEL.Visible = false;
                    CHM_ACTIVER_UTILISATEUR g = new CHM_ACTIVER_UTILISATEUR();
                    g.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CALENDER_PANEL.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CALENDER_PANEL.Visible = false;
        }

        string[] GetIPaddresses(string computername)
        {
            string[] saddr = null;

            IPAddress[] addr = Dns.Resolve(computername).AddressList;



            if (addr.Length > 0)
            {
                saddr = new String[addr.Length];
                for (int l = 0; l < addr.Length; l++)

                    saddr[l] = addr[l].ToString();

            }

            return saddr;

        }

        private void listeDesCatègoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_ARTICLE_CATEGORIE f = new CHM_ARTICLE_CATEGORIE("l");
            f.StartPosition = FormStartPosition.CenterScreen;
            f.MdiParent = this;
            f.Show();
        }

        private void bonsDeLivraisonsPréparésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("6");
            l.RightToLeft = RightToLeft.No;
            l.WindowState = FormWindowState.Maximized;
            l.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            l.Show();
        }

        private void bonsDeLivraisonFacturésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("2");
            l.RightToLeft = RightToLeft.No;
            l.WindowState = FormWindowState.Maximized;
            l.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            l.Show();
        }

        private void bonsLivraisonNonFacturésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("3");
            l.RightToLeft = RightToLeft.No;
            l.WindowState = FormWindowState.Maximized;
            l.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            l.Show();
        }

        private void bonsDeLivraisonLivrésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("4");
            l.RightToLeft = RightToLeft.No;
            l.WindowState = FormWindowState.Maximized;
            l.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            l.Show();
        }

        private void bonsDeLivraisonNonLivrèsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("5");
            l.RightToLeft = RightToLeft.No;
            l.WindowState = FormWindowState.Maximized;
            l.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            l.Show();
        }
        
        private void listeBonDeLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON l = new CHM_LISTE_BONS_LIVRAISON("1");
            l.RightToLeft =  RightToLeft.No;
            l.WindowState = FormWindowState.Maximized;
            l.MdiParent = this;
            l.Show();
        }

        private void commandesPréparéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_COMMANDE f = new CHM_LISTE_COMMANDE(1, "");
            f.RightToLeft = RightToLeft.No;
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void listeDesFacturesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_LISTE_FACTURES f = new CHM_LISTE_FACTURES(1, "");
            f.RightToLeft = RightToLeft.No;
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_LISTE_FACTURES f = new CHM_LISTE_FACTURES(1, "");
                f.RightToLeft = RightToLeft.No;
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_REGLEMENT_CLIENT"] != null)
                Application.OpenForms["CHM_FRM_REGLEMENT_CLIENT"].Show();
            else
            {
                CHM_FRM_REGLEMENT_CLIENT f = new CHM_FRM_REGLEMENT_CLIENT();
                f.MdiParent = this;
                f.Show();
            }
            //CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT("-1");
            //f.RightToLeft = RightToLeft.No;
            //f.StartPosition = FormStartPosition.CenterScreen;            
            //f.ShowDialog();
        }

        private void nouvelUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NOUVEAU_EMPLOYE f = new CHM_NOUVEAU_EMPLOYE("-1");
            f.RightToLeft = RightToLeft.No;
            f.StartPosition = FormStartPosition.CenterScreen;            
            f.ShowDialog();
        }

        private void CHM_COMMERCIAL_MANAGEMENT_PROGRAM_Click(object sender, EventArgs e)
        {
            CONTROL_PANEL.Visible = false;
            CALENDER_PANEL.Visible = false;
            USER_PANEL.Visible = false;
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            CHM_LIVRAISON_CLIENT f = new CHM_LIVRAISON_CLIENT("-1");
            f.RightToLeft = RightToLeft.No;
            f.MdiParent = this;
            f.Show();
        }

        private void nouvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS_MOUV ds = new DS_MOUV();
            BindingSource bsDevi = new BindingSource();
            bsDevi.DataSource = ds.V_DC;
            bsDevi.AddNew();

            CHM_NV_DEVI f = new CHM_NV_DEVI(bsDevi);
            f.RightToLeft = RightToLeft.No;
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void nouveauMagazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NV_MAGAZIN f = new CHM_NV_MAGAZIN("-1");
            f.RightToLeft = RightToLeft.No;
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void listeDesMagazinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_LISTE_MAGAZIN f = new CHM_LISTE_MAGAZIN();
            //f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void boite_outil_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            CHM_MON_TRAVAIL f = new CHM_MON_TRAVAIL();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void tactileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //APPLICATION_TACTILE f = new APPLICATION_TACTILE();
            //f.WindowState = FormWindowState.Maximized;
            //f.RightToLeft =  RightToLeft.No;
            //f.MdiParent = this;            
            //f.Show();

            //CHM_APPLICATION_TACTILE.CHM_FRM_PV_TACTILE f = new CHM_CLIENT_APP.CHM_APPLICATION_TACTILE.CHM_FRM_PV_TACTILE();
            //f.ShowDialog();

            CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            if (res.OK)
            {

                CHM_FACTURE.CHM_FACTURE_POS f = new CHM_CLIENT_APP.CHM_FACTURE.CHM_FACTURE_POS();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show("Magasin encours d'inventaire.", this.Text);
            }
        }

        static WaitHandle[] waithandles = new WaitHandle[] { new AutoResetEvent(false) };
        private void CHM_COMMERCIAL_MANAGEMENT_PROGRAM_Load(object sender, EventArgs e)
        {
            try
            {


                this.Hide();
                Intro = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_FRM_INTRO();
                Intro.Show();
                CLIENT_APP_PARAM.configurer_poste();
                CLIENT_APP_PARAM.configurer_connection();
                string s = string.Format("{0}", Environment.MachineName);
                try
                {
                    //License.License l = new License.License();
                    //if (l.verifier_license(CLIENT_APP_PARAM.key, Environment.MachineName.ToUpper())) licensefied = true;
                    //else
                    //{
                    //    CHM_FRM_LICENSE f = new CHM_FRM_LICENSE();
                    //    f.ShowDialog();
                    //}
                }
                catch (Exception error)
                {
                    Application.Exit();
                }
                try
                {
                    
                    ThreadPool.QueueUserWorkItem(new WaitCallback(CLIENT_APP_PARAM.connect), waithandles[0]);
                    WaitHandle.WaitAll(waithandles);
                    CLIENT_APP_PARAM.ds_param = new DS_GC();
                    CLIENT_APP_PARAM.ds_param.dsInitialize();
                    //CLIENT_APP_PARAM.connect();
                }
                catch (Exception cnx_er)
                {
                    MessageBox.Show(cnx_er.Message);
                }
                Intro.Close();
                this.Show();
                tsb_bl.Enabled = true;
                jour.Text = dateTimePicker1.Value.Day.ToString();
                mois.Text = dateTimePicker1.Value.Month.ToString();
                if (code_user == "")
                {
                    USER_CONNECTION_ON.Visible = false;
                    USER_CONNECTION_OFF.Visible = true;
                    USER_CONNECTION_disabled.Visible = false;
                }
                try
                {
                    CLIENT_APP_PARAM.declarer_menu(menuStrip);
                }
                catch (Exception cnx_er)
                {
                    MessageBox.Show("Problème lors de la connexion au serveur");
                }
                CHM_IDENTIFICATION_UTILISATEUR fenetre = new CHM_IDENTIFICATION_UTILISATEUR();
                fenetre.after_use += new CHM_IDENTIFICATION_UTILISATEUR.using_windows(fenetre_after_use);
                fenetre.ShowDialog();
                timer1_Tick(null, null);
                if (nom_user != "")
                    user_connection_state = "Utilisateur courant : " + nom_user + " " + prenom_user;

                button1.Focus();

                #region old
                //for (i = 0; i < 999999999 && tsb_facture.Enabled == true; i++)
                //{
                //    Application.DoEvents();
                //    j = 0;
                //    while (j < 100)
                //    {
                //        try
                //        {
                //            if (nom_user != "")
                //                user_connection_state = "Utilisateur courant : " + nom_user + " " + prenom_user;
                //            else
                //                user_connection_state = "Application verouillée.";
                //            Application.DoEvents();
                //            //dt = CLIENT_APP_PARAM.GEST.P_MAGAZIN.SELECT_ALL_MAGAZIN();
                //            //dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
                //            //CLIENT_APP_PARAM.connect();
                //            date = CLIENT_APP_PARAM.gccnx.getDate();
                //        }
                //        catch (Exception er)
                //        {


                //            SERVER_CONNECTION_ON.Visible = false;
                //            SERVER_CONNECTION_OFF.Visible = true;
                //            SERVER_CONNECTION_disabled.Visible = false;
                //            server_connection_state = "Pas de connexion";
                //            user_connection_state = "Session verouillée , utilisateur courant : " + nom_user + " " + prenom_user;
                //            STATUS.Text = server_connection_state + "   " + user_connection_state;
                //            if (r == 0)
                //            {
                //                if (MessageBox.Show("Serveur déconnecté !\nAttention aucune requete ne peut être traitée ! \nVotre session sera verouillée en attendant la connexion .", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                //                {
                //                    r = 1;
                //                    USER_CONNECTION_ON.Visible = false;
                //                    USER_CONNECTION_OFF.Visible = false;
                //                    USER_CONNECTION_disabled.Visible = true;
                //                    foreach (Form f in this.MdiChildren)
                //                    {
                //                        f.Hide();
                //                    }
                //                    CHM_ACTIVER_UTILISATEUR fenetr = new CHM_ACTIVER_UTILISATEUR();
                //                    fenetr.MdiParent = this;
                //                    fenetr.Show();

                //                }
                //            }
                //        }

                //        j++;
                //    }
                //    //bs.DataSource = dt;

                //    //if ( bs.Current != null)
                //    if (date.Date.ToString() != "01/01/0001 00:00:00")
                //    {
                //        SERVER_CONNECTION_ON.Visible = true;
                //        SERVER_CONNECTION_OFF.Visible = false;
                //        SERVER_CONNECTION_disabled.Visible = false;
                //        server_connection_state = "Serveur connecté";
                //        STATUS.Text = server_connection_state + "   " + user_connection_state;

                //    }
                //    //if (bs.Current == null)
                //    if (date.Date.ToString() == "01/01/0001 00:00:00")
                //    {
                //        SERVER_CONNECTION_ON.Visible = false;
                //        SERVER_CONNECTION_OFF.Visible = true;
                //        SERVER_CONNECTION_disabled.Visible = false;
                //        r = 1;
                //    }
                //    if (i == 999999999)
                //        i = 0;
                //}
                #endregion
                timer1.Enabled = true;
                TMR_REFRECH_CNX.Enabled = true;
            }
            catch (Exception er)
            {
                Intro.Close();
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ds_param_Initialized(object sender, EventArgs e)
        {
            
        }

        private void TMR_REFRECH_CNX_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();

            try
            {
                TMR_REFRECH_CNX.Enabled = false;
                if (nom_user != "")
                    user_connection_state = "Utilisateur courant : " + nom_user + " " + prenom_user;
                else
                    user_connection_state = "Application verouillée.";
                //Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_MAGAZIN.SELECT_ALL_MAGAZIN();
                //dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
                //CLIENT_APP_PARAM.connect();
                date = CLIENT_APP_PARAM.gccnx.getDate();

                
                //DataTable dt = CLIENT_APP_PARAM.gcstat.SELECT_NB_ARTICLE_EN_RUPTURE_STOCK();
                //if (dt.Rows.Count > 0)
                //    if (Convert.ToDecimal(dt.Rows[0][0]) > 0) pbx_ruptureStock.Visible = true;
                //    else pbx_ruptureStock.Visible = false;
                TMR_REFRECH_CNX.Enabled=true;
                r = 0;
            }
            catch (Exception er)
            {

                date = new DateTime();
                SERVER_CONNECTION_ON.Visible = false;
                SERVER_CONNECTION_OFF.Visible = true;
                SERVER_CONNECTION_disabled.Visible = false;
                server_connection_state = "Pas de connexion";
                user_connection_state = "Session verouillée , utilisateur courant : " + nom_user + " " + prenom_user;
                STATUS.Text = server_connection_state + "  " + user_connection_state;
                if (r == 0)
                {
                    r = 1;
                    if (MessageBox.Show("Serveur déconnecté !\nAttention aucune requete ne peut être traitée ! \nVotre session sera verouillée en attendant la connexion .", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        
                        USER_CONNECTION_ON.Visible = false;
                        USER_CONNECTION_OFF.Visible = false;
                        USER_CONNECTION_disabled.Visible = true;
                        foreach (Form f in this.MdiChildren)
                        {
                            f.Hide();
                        }
                        CHM_ACTIVER_UTILISATEUR fenetr = new CHM_ACTIVER_UTILISATEUR();
                        //fenetr.MdiParent = this;
                        fenetr.ShowDialog();
                        TMR_REFRECH_CNX_Tick(null, null);
                    }
                }
            }
            finally
            {
                if (date.Date.ToString() != "01/01/0001 00:00:00")
                {
                    SERVER_CONNECTION_ON.Visible = true;
                    SERVER_CONNECTION_OFF.Visible = false;
                    SERVER_CONNECTION_disabled.Visible = false;
                    server_connection_state = "Serveur connecté";
                    STATUS.Text = server_connection_state + "   " + user_connection_state;

                }
                //if (bs.Current == null)
                if (date.Date.ToString() == "01/01/0001 00:00:00")
                {
                    SERVER_CONNECTION_ON.Visible = false;
                    SERVER_CONNECTION_OFF.Visible = true;
                    SERVER_CONNECTION_disabled.Visible = false;
                    r = 1;
                }
                TMR_REFRECH_CNX.Enabled = true;
            }
        }

        private void matérielToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientsNonRèglésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fournisseursNonPayésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void commandesSuiviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bonsDeLivraisonSuivisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturesSuiviesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_FRM_ABOUT f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_FRM_ABOUT();
            f.ShowDialog();
        }

        private void societeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compteClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receptionOrdersListقائمةأذوناتالتسليمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BON_RECEPTION.CHM_LISTE_BONRECEPTION_FR f = new CHM_CLIENT_APP.BON_RECEPTION.CHM_LISTE_BONRECEPTION_FR();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void nouvelleFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            if (res.OK)
            {
                try
                {
                    CHM_FACTURE.CHM_FRM_NV_FACTURE fiche = new CHM_CLIENT_APP.CHM_FACTURE.CHM_FRM_NV_FACTURE(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                    fiche.WindowState = FormWindowState.Maximized;
                    fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    fiche.Show();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le magasin est encours d'inventaire.", this.Text);
            }
        }

        private void addReceptionOrderإضافةإذنتسليمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            if (res.OK)
            {
                BON_RECEPTION.CHM_FRM_BR_FOURNISSEUR f = new CHM_CLIENT_APP.BON_RECEPTION.CHM_FRM_BR_FOURNISSEUR(-1);
                f.StartPosition = FormStartPosition.CenterScreen;
                //f.RightToLeft = RightToLeft.No;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Le magasin est encours d'inventaire.", this.Text);
            }
        }

        private void paramètresDeConnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_CONFIG_POSTE f = new CHM_CONFIG_POSTE();
            f.ShowDialog();
        }

        private void Horloge_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            jour.Text = DateTime.Now.Day.ToString();
            mois.Text = DateTime.Now.Month.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsByStoresقائمةالأصنافحسبالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            if (res.OK)
            {
                CHM_MAGAZIN.CHM_LISTE_STOCK_PAR_MAGAZIN f = new CHM_CLIENT_APP.CHM_MAGAZIN.CHM_LISTE_STOCK_PAR_MAGAZIN();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show("Le magasin est encours d'inventaire.", this.Text);
            }
        }

        private void newDeliveryOrderإضافةوصلتسليمبناءعلىطلبيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeDesRèglementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FRM_REGLEMENT_CLIENT f = new CHM_FRM_REGLEMENT_CLIENT();
            f.MdiParent = this;
            f.Show();
        }

        private void إضافةإرجاعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BON_RETOUR_CLIENT.CHM_FRM_BON_RETOUR_CLIENT f = new CHM_CLIENT_APP.BON_RETOUR_CLIENT.CHM_FRM_BON_RETOUR_CLIENT();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void nouveauRèglementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT("-1");
            f.RightToLeft = RightToLeft.No;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void facturesRégléesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturesNonRègléesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnsListقائمةالإرجاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BON_RETOUR_CLIENT.CHM_LISTE_BON_RETOUR_CLIENT f = new CHM_CLIENT_APP.BON_RETOUR_CLIENT.CHM_LISTE_BON_RETOUR_CLIENT();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btn_rapport_journalier_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
                {
                    ReportDocument rpt_facture = new CHM_Fenetre_principale.CHM_LISTE_VENTE();
                    //rpt_facture.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_facture.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_facture.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                    rpt_facture.PrintToPrinter(1, true, 0, 0);

                    ReportDocument rpt_BR_CL = new BON_RETOUR_CLIENT.CHM_RPT_LISTE_BR_CL();
                    //rpt_BR_CL.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_BR_CL.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_BR_CL.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                    rpt_BR_CL.PrintToPrinter(1, true, 0, 0);
                }
                else
                {
                    ReportDocument rpt = new CHM_Fenetre_principale.RPT_VENTE_TOTAL_PAR_FACTURE_PAR_DATE();
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt.SetParameterValue("date_debut", "ليوم :" + DateTime.Now.ToShortDateString());
                    rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                    rpt.PrintToPrinter(1, true,0,0);

                    ReportDocument rpt_vente_detail = new CHM_ETAT.RPT_TOUS_LISTE_VENTE_A4();                    
                    //rpt_vente_detail.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_vente_detail.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_vente_detail.SetParameterValue("date", "ليوم :" + DateTime.Now.ToShortDateString());
                    rpt_vente_detail.SetParameterValue("user", "");
                    rpt_vente_detail.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                    rpt_vente_detail.PrintToPrinter(1, true, 0, 0);

                    ReportDocument rpt_retour = new CHM_ETAT.RPT_BON_RETOUR_A4();
                    //rpt_retour.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_retour.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_retour.SetParameterValue("date", "ليوم : " + DateTime.Now.ToShortDateString());
                    rpt_retour.SetParameterValue("user", "");
                    //rpt_retour.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_retour.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE(DateTime.Now, DateTime.Now));
                    rpt_retour.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                    rpt_retour.PrintToPrinter(1, true, 0, 0);
                }
                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void تقريرالمبيعاتحسبالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET();
            f.ShowDialog();
        }

        private void closeSessionإقفالالورديةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_FRM_RAPPORT_VENTE_TOTAL f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_FRM_RAPPORT_VENTE_TOTAL();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void تقريرالمبيعاتحسبالمستخدمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_RPT_BR f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_RPT_BR();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void تقريرالإرجاعاتحسبالمستخدموالتاريخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_RPT_BR_ALL f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_RPT_BR_ALL();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void incomeالإيرادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_FRM_GAIN f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_FRM_GAIN();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void المرابيحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_Fenetre_principale.CHM_FRM_GAIN_DETAIL f = new CHM_CLIENT_APP.CHM_Fenetre_principale.CHM_FRM_GAIN_DETAIL();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void articlesToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void droitsDaccèsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbx_ruptureStock_Click(object sender, EventArgs e)
        {
            CHM_FRM_RUPTURE_STOCK f = new CHM_FRM_RUPTURE_STOCK();
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }

        private void License_Tick(object sender, EventArgs e)
        {

        }

        private void baseDeDonnèesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_UTILISATEUR.CHM_FRM_DroitsAcces f = new CHM_CLIENT_APP.CHM_UTILISATEUR.CHM_FRM_DroitsAcces();
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }

        private void listeDesDevisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_DEVIS f = new CHM_FRM_LISTE_DEVIS();
            f.MdiParent = this;
            f.Show();
        }
       
            License.License l = new License.License();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r == 0)
            {
                try
                {
                    DataTable dt = CLIENT_APP_PARAM.gcstat.SELECT_NB_FACTURE();
                    int nb = (int)dt.Rows[0][0];
                    if (l.license_type != "O")
                    {
                        int reste = l.nb - nb;
                        if (reste < 10 && reste > 0)
                        {
                            MessageBox.Show("Votre license vient d'être expirée.\nVous ne pourrez créer plus que" + reste.ToString() + "factures de vente.", CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (reste <= 0)
                        {
                            MessageBox.Show("Votre license est expirée.", CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void listeDesCommandesDAchatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_CMD_FRN"] != null)
                Application.OpenForms["CHM_FRM_LISTE_CMD_FRN"].Activate();
            else
            {
                COMMANDE_FOURNISSEUR.CHM_FRM_LISTE_CMD_FRN f = new CHM_CLIENT_APP.COMMANDE_FOURNISSEUR.CHM_FRM_LISTE_CMD_FRN();
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void nouvelleCommandeDachatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //COMMANDE_FOURNISSEUR.CHM_FRM_NV_CMD_FR f = new CHM_CLIENT_APP.COMMANDE_FOURNISSEUR.CHM_FRM_NV_CMD_FR();
            //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            //f.WindowState = FormWindowState.Normal;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }

        private void listeDesMarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_MARQUES"] != null)
                Application.OpenForms["CHM_FRM_LISTE_MARQUES"].Activate();
            else
            {
                CHM_MARQUE_ARTICLE.CHM_FRM_LISTE_MARQUES f = new CHM_CLIENT_APP.CHM_MARQUE_ARTICLE.CHM_FRM_LISTE_MARQUES("l");
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_MAJ_PRIX"] != null)
                Application.OpenForms["CHM_FRM_LISTE_MAJ_PRIX"].Activate();
            else
            {
                CHM_ARTICLES.CHM_FRM_LISTE_MAJ_PRIX f = new CHM_CLIENT_APP.CHM_ARTICLES.CHM_FRM_LISTE_MAJ_PRIX();
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void listeDesFamillesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_FAMILLE"] != null)
                Application.OpenForms["CHM_FRM_LISTE_FAMILLE"].Activate();
            else
            {
                CHM_FAMILLES_ART.CHM_FRM_LISTE_FAMILLE f = new CHM_CLIENT_APP.CHM_FAMILLES_ART.CHM_FRM_LISTE_FAMILLE("l");
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void listeDesLignesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_VEHICULE"] != null)
                Application.OpenForms["CHM_FRM_LISTE_VEHICULE"].Activate();
            else
            {
                CHM_FRM_LISTE_VEHICULE f = new CHM_FRM_LISTE_VEHICULE("l");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_FI"] != null)
                Application.OpenForms["CHM_FRM_LISTE_FI"].Activate();
            else
            {
                CHM_FRM_LISTE_FI f = new CHM_FRM_LISTE_FI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void listeDesInventairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_INVENTAIRE"] != null)
                Application.OpenForms["CHM_FRM_LISTE_INVENTAIRE"].Activate();
            else
            {
                CHM_FRM_LISTE_INVENTAIRE f = new CHM_FRM_LISTE_INVENTAIRE();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void fichesDentretiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_FI"] != null)
                Application.OpenForms["CHM_FRM_LISTE_FI"].Activate();
            else
            {
                CHM_FRM_LISTE_FI f = new CHM_FRM_LISTE_FI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void listeDesVéhiculesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_VEHICULE"] != null)
                Application.OpenForms["CHM_FRM_LISTE_VEHICULE"].Activate();
            else
            {
                CHM_FRM_LISTE_VEHICULE f = new CHM_FRM_LISTE_VEHICULE("l");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void listeDesTicketsDeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_TICKET"] != null)
                Application.OpenForms["CHM_FRM_LISTE_TICKET"].Activate();
            else
            {
                CHM_FRM_LISTE_TICKET f = new CHM_FRM_LISTE_TICKET();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton5_Click_2(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {

                    CHM_FACTURE.CHM_FACTURE_POS f = new CHM_CLIENT_APP.CHM_FACTURE.CHM_FACTURE_POS();
                    f.WindowState = FormWindowState.Maximized;
                    f.MdiParent = this;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Magasin encours d'inventaire.", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void tsbTicketCaisse_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_TICKET"] != null)
                Application.OpenForms["CHM_FRM_LISTE_TICKET"].Activate();
            else
            {
                CHM_FRM_LISTE_TICKET f = new CHM_FRM_LISTE_TICKET();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbDevisClient_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_DEVIS"] != null)
                Application.OpenForms["CHM_FRM_LISTE_DEVIS"].Activate();
            else
            {
                CHM_FRM_LISTE_DEVIS f = new CHM_FRM_LISTE_DEVIS();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tsbBLFrn_Click(object sender, EventArgs e)
        {
            try
            {
                BON_RECEPTION.CHM_LISTE_BONRECEPTION_FR f = new CHM_CLIENT_APP.BON_RECEPTION.CHM_LISTE_BONRECEPTION_FR();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void tsbCmdFrn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_CMD_FRN"] != null)
                Application.OpenForms["CHM_FRM_LISTE_CMD_FRN"].Activate();
            else
            {
                COMMANDE_FOURNISSEUR.CHM_FRM_LISTE_CMD_FRN f = new CHM_CLIENT_APP.COMMANDE_FOURNISSEUR.CHM_FRM_LISTE_CMD_FRN();
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LIST_FACT_FRN"] != null)
                Application.OpenForms["CHM_FRM_LIST_FACT_FRN"].Activate();
            else
            {
                CHM_FACTURE_FOURNISSEUR.CHM_FRM_LIST_FACT_FRN f = new CHM_FACTURE_FOURNISSEUR.CHM_FRM_LIST_FACT_FRN();
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void listeDesFacturesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LIST_FACT_FRN"] != null)
                Application.OpenForms["CHM_FRM_LIST_FACT_FRN"].Activate();
            else
            {
                CHM_FACTURE_FOURNISSEUR.CHM_FRM_LIST_FACT_FRN f = new CHM_FACTURE_FOURNISSEUR.CHM_FRM_LIST_FACT_FRN();
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void listeDesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_EQP"] != null)
                Application.OpenForms["CHM_FRM_LISTE_EQP"].Activate();
            else
            {
                CHM_FRM_LISTE_EQP f = new CHM_FRM_LISTE_EQP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void listeDesEncoursClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_ENCOURS_CLIENT"] != null)
                Application.OpenForms["CHM_FRM_ENCOURS_CLIENT"].Activate();
            else
            {
                CHM_FRM_ENCOURS_CLIENT f = new CHM_FRM_ENCOURS_CLIENT();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_IMP_CB"] != null)
                Application.OpenForms["CHM_FRM_IMP_CB"].Activate();
            else
            {
                CHM_FRM_IMP_CB f = new CHM_FRM_IMP_CB();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void typeDeMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_LISTE_TYPE_MAINT"] != null)
                Application.OpenForms["CHM_FRM_LISTE_TYPE_MAINT"].Activate();
            else
            {
                CHM_FRM_LISTE_TYPE_MAINT f = new CHM_FRM_LISTE_TYPE_MAINT("l");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void venteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_FRM_TRV"] != null)
                Application.OpenForms["CHM_FRM_TRV"].Activate();
            else
            {
                CHM_FRM_TRV f = new CHM_FRM_TRV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void tVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHM_LIST_TVA"] != null)
                Application.OpenForms["CHM_LIST_TVA"].Activate();
            else
            {
                CHM_LIST_TVA f = new CHM_LIST_TVA();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
