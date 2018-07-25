using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using CHM_GESTION_COMERCIALE;
     

namespace CHM_CLIENT_APP
{
    public partial class APPLICATION_TACTILE : Form
    {
        DataTable _dt_categ;
        BindingSource _bs_categ = new BindingSource();
        DataTable _dt_article;
        DataTable _dt_produits_selectionnes;
        BindingSource _bs_produits_selectionnes = new BindingSource();
        public APPLICATION_TACTILE()
        {
            InitializeComponent();
            //_dt_categ = CLIENT_APP_PARAM.GEST.P_CATEGORIE.SELECT_ALL_CATEGORIE();
            _dt_categ = CLIENT_APP_PARAM.gcws.SELECT_ALL_CATEGORIE();
            //_dt_article = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_ALL_ARTICLE();
            _dt_article = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE();
            remplire_panel_avec_boutons_en_liste(p_Liste_Categorie, _dt_categ, 50, "c");
        }

        private void remplire_panel_avec_boutons_en_liste(Panel p, DataTable dt, int button_height, string type)
        {
            p.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Name = dt.Rows[i]["code"].ToString();
                btn.Text = dt.Rows[i]["ref"].ToString();
                btn.Tag = type;
                btn.Size = new Size((int)(p.Width * 0.97), button_height);
                btn.Location = new Point((int)((p.Width - btn.Width) * 0.5), i * (button_height + 2) );
                btn.Click += btn_Click;
                p.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Tag.ToString())
            {
                case "c":
                    //_dt_produits_selectionnes = CLIENT_APP_PARAM.GEST.P_CATEGORIE.SELECT_CATEG_PRODUCTS((sender as Control).Name);
                    _dt_produits_selectionnes = CLIENT_APP_PARAM.gcws.SELECT_CATEG_PRODUCTS((sender as Control).Name);
                    remplire_panel_avec_boutons_en_liste(p_Liste_Article, _dt_produits_selectionnes, 40, "p");
                    break;
                case "p":

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SELLECTION_PRODUITS f = new SELLECTION_PRODUITS())
            {
                f.ENREG_EV += new SELLECTION_PRODUITS.ENREG_DEL(f_ENREG_EV);
                f.ShowDialog();
            }
        }

        PLACE[] BOUTONS;
        int i = 0;
        DataTable dt_prod_btn;
        BindingSource bs_prod_btn = new BindingSource();

        void f_ENREG_EV(BindingSource bs_produits, int nb_prod)
        {
            BOUTONS = diviser_PANEL(nb_prod, 30, 40, 600, 500, 4, bs_produits);
            for (i = 0; i < nb_prod; i++)
            {
                Button f = new Button();
                f.Name = BOUTONS[i].CODE;
                //dt_prod_btn = CLIENT_APP_PARAM.GEST.P_ARTICLE.LOAD_ARTICLE(f.Name);
                dt_prod_btn = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE(f.Name);
                bs_prod_btn.DataSource = dt_prod_btn;
                if (bs_prod_btn.Current != null)
                {
                    DataRowView drv = (DataRowView)bs_prod_btn.Current;

                    byte[] tableau = (byte[])drv["PHOTO_ARTICLE"];
                    Image image;
                    using (MemoryStream ms = new MemoryStream(tableau))
                    {
                        image = Image.FromStream(ms);
                        f.Image = image;
                    }
                }
                f.SetBounds(BOUTONS[i].locationX, BOUTONS[i].locationY, BOUTONS[i].width - 5, BOUTONS[i].height - 5);

                f.Text = BOUTONS[i].REF;
                this.Controls.Add(f);
                f.Visible = true;

            }
        }

        public PLACE[] diviser_PANEL( int nb_bouton, int locX_panel, int locY_panel, int width_panel, int height_panel, int nb_categ, BindingSource bs)
        {
            int nb_ligne = nb_categ;
            int nb_colone = nb_bouton / nb_categ;
            if (nb_bouton > (nb_ligne * nb_colone))
                nb_colone += 1;
            PLACE[] BOUTONS = new PLACE[nb_colone * nb_ligne];
            int largeur_place = width_panel / nb_colone;
            int longueur_place = height_panel / nb_ligne;
            int locationX_courante = locX_panel;
            int locationY_courante = locY_panel;
            int btn = 0;
            for (int i = 0; i < nb_ligne; i++)
            {
                for (int j = 0; j < nb_colone; j++)
                {

                    BOUTONS[btn] = new PLACE(locationX_courante, locationY_courante, largeur_place, longueur_place, "", "");

                    locationX_courante += largeur_place;
                    btn++;

                }
                locationY_courante += longueur_place;
                locationX_courante = locX_panel;
            }
            int h = 0;
            foreach (DataRowView drv in bs)
            {
                BOUTONS[h].CODE = drv["CODE_ARTICLE"].ToString();
                BOUTONS[h].REF = drv["REF_ARTICLE"].ToString();
                h++;
            }
            return BOUTONS;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void charger_article(string BAR_CODE)
        {
        }

        private void APPLICATION_TACTILE_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void template_Liste_Facture_Ouverte1_Load(object sender, EventArgs e)
        {

        }
    }
}
