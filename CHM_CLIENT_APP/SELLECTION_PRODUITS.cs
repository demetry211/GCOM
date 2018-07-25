using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class SELLECTION_PRODUITS : Form
    {
        int nb_produits = 0;
        public delegate void ENREG_DEL(BindingSource bs_produits , int nb_prod);
        public event ENREG_DEL ENREG_EV;
        public SELLECTION_PRODUITS()
        {
            InitializeComponent();
        }
        DataTable dt_categ;
        BindingSource bs_categ = new BindingSource();
        DataTable dt_produits_selectionnes;
        BindingSource bs_produits_selectionnes = new BindingSource();
        private void SELLECTION_PRODUITS_Shown(object sender, EventArgs e)
        {
            dgv_liste_article.AutoGenerateColumns = false;
            dt_produits_selectionnes = CLIENT_APP_PARAM.GEST.P_CATEGORIE.LOAD_SCHEMA_ARTICLE();
            bs_produits_selectionnes.DataSource = dt_produits_selectionnes;
            dgv_liste_article.DataSource = bs_produits_selectionnes;
            dt_categ = CLIENT_APP_PARAM.GEST.P_CATEGORIE.SELECT_ALL_CATEGORIE();
            bs_categ.DataSource = dt_categ;
            foreach (DataRowView drv_categ in bs_categ)
            {
                CATEGORIE.Items.Add(drv_categ["LIB_CATEG"]);
            }
        }
        DataTable dt_produits;
        BindingSource bs_produits = new BindingSource();
        private void CATEGORIE_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRODUITS.Items.Clear();
            string categ = CATEGORIE.Text;
            dt_produits = CLIENT_APP_PARAM.GEST.P_CATEGORIE.SELECT_CATEG_PRODUCTS(categ);
            bs_produits.DataSource = dt_produits;
            foreach (DataRowView drv_produits in bs_produits)
            {
                PRODUITS.Items.Add(drv_produits["DESIGNATION_ARTICLE"]);
            }
        }

        private void PRODUITS_MouseClick(object sender, MouseEventArgs e)
        {
            PRODUITS.ItemCheck += new ItemCheckEventHandler(PRODUITS_ItemCheck);
        }
        DataTable dt_select_item;
        BindingSource bs_selected_item = new BindingSource();
        void PRODUITS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool trouve = false;

            dt_select_item = CLIENT_APP_PARAM.GEST.P_CATEGORIE.LOAD_ARTICLE_PAR_REF(PRODUITS.SelectedItem.ToString());
            bs_selected_item.DataSource = dt_select_item;
            if (bs_selected_item.Current != null)
            {
                DataRowView drv_selected_item = (DataRowView)bs_selected_item.Current;
                foreach (DataRow drc in dt_produits_selectionnes.Rows)
                {
                    if (drc["CODE_ARTICLE"].ToString() == drv_selected_item["CODE_ARTICLE"].ToString())
                    {
                        trouve = true;

                    }
                }

                if (trouve == false)
                {
                    nb_produits++;
                    bs_produits_selectionnes.AddNew();
                    DataRowView drv_element_ajoute = (DataRowView)bs_produits_selectionnes.Current;
                    drv_element_ajoute["CODE_ARTICLE"] = drv_selected_item["CODE_ARTICLE"];
                    drv_element_ajoute["REF_ARTICLE"] = drv_selected_item["REF_ARTICLE"];
                    drv_element_ajoute["DESIGNATION_ARTICLE"] = drv_selected_item["DESIGNATION_ARTICLE"];
                    drv_element_ajoute["MARQUE_ARTICLE"] = drv_selected_item["MARQUE_ARTICLE"];
                    drv_element_ajoute["DESCRIPTION_ARTICLE"] = drv_selected_item["DESCRIPTION_ARTICLE"];
                    drv_element_ajoute["CODE_BARRE_ARTICLE"] = drv_selected_item["CODE_BARRE_ARTICLE"];
                    drv_element_ajoute["QTE_ARTICLE"] = drv_selected_item["QTE_ARTICLE"];
                    drv_element_ajoute["UNITE_QTE_ARTICLE"] = drv_selected_item["UNITE_QTE_ARTICLE"];
                    drv_element_ajoute["QTE_MIN_ARTICLE"] = drv_selected_item["QTE_MIN_ARTICLE"];
                    drv_element_ajoute["PHOTO_ARTICLE"] = drv_selected_item["PHOTO_ARTICLE"];
                    drv_element_ajoute["PRIX_HT_A_ARTICLE"] = drv_selected_item["PRIX_HT_A_ARTICLE"];
                    drv_element_ajoute["PRIX_HT_V_ARTICLE"] = drv_selected_item["PRIX_HT_V_ARTICLE"];
                    drv_element_ajoute["TVA_ARTICLE"] = drv_selected_item["TVA_ARTICLE"];
                    drv_element_ajoute["ETAT_ARTICLE"] = drv_selected_item["ETAT_ARTICLE"];
                    drv_element_ajoute["CODE_CATEG"] = drv_selected_item["CODE_CATEG"];
                    drv_element_ajoute["CODE_MAG"] = drv_selected_item["CODE_MAG"];
                    drv_element_ajoute["CODE_FOURNISSEUR"] = drv_selected_item["CODE_FOURNISSEUR"];
                    drv_element_ajoute["LIB_CATEG"] = drv_selected_item["LIB_CATEG"];
                    drv_element_ajoute["NOM_MAG"] = drv_selected_item["NOM_MAG"];
                    drv_element_ajoute["RS_FOURNISSEUR"] = drv_selected_item["RS_FOURNISSEUR"];
                    bs_produits_selectionnes.EndEdit();
                    dt_produits_selectionnes.AcceptChanges();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ENREG_EV != null)
                ENREG_EV(bs_produits_selectionnes , nb_produits);
            this.Close();
        }

        private void SELLECTION_PRODUITS_Load(object sender, EventArgs e)
        {

        }
    }
}
