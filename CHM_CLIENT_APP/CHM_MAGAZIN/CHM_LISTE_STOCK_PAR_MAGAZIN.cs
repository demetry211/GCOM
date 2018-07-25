using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.Properties;

namespace CHM_CLIENT_APP.CHM_MAGAZIN
{
    public partial class CHM_LISTE_STOCK_PAR_MAGAZIN : Form
    {
        DataTable _dt_article;
        BindingSource _bs_article = new BindingSource();

        DataTable dt_mag;
        decimal _CODE_MAG;



        public CHM_LISTE_STOCK_PAR_MAGAZIN()
        {
            InitializeComponent();
            try
            {
                _bs_article.DataSource = dS_MOUV1.STOCK;
                gridControl1.DataSource = _bs_article;
                //dt_mag = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_MAGAZINS();
                dt_mag = CLIENT_APP_PARAM.gcws.SELECT_MAGAZINS();
                cbx_magasin.DataSource = dt_mag;
                cbx_magasin.DisplayMember = "NOM_MAG";
                cbx_magasin.ValueMember = "CODE_MAG";
                if (dt_mag.Rows.Count > 0)
                {
                    //if ( ((CHM_GESTION_COMERCIALE.RESULT_QUERY)CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG))).OK)
                    if (((CHMGC.RESULT_QUERY)CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG))).OK)
                    {
                        cbx_magasin.SelectedValueChanged += new EventHandler(cbx_magasin_SelectedValueChanged);
                        cbx_magasin.SelectedValue = Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG);
                        cbx_magasin_SelectedValueChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Ce magasin est inventaire");
                    }
                }
                else
                    MessageBox.Show("Veuillez sélectionner le magasin.");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_afficher.Visible = true;
            chM_CMP_CONTROL1.btn_ajout.Visible = false;
            chM_CMP_CONTROL1.btn_modifier.Visible = false;
            chM_CMP_CONTROL1.btn_supprimer.Visible = false;

            chM_CMP_CONTROL1.btn_afficher.Text = "Imprimer Liste";
            chM_CMP_CONTROL1.btn_afficher.Image = Resources.Print_32x32;
            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            gridView1.ViewCaption = "Liste des articles en stock\nMagasin : " + cbx_magasin.Text;
            gridView1.OptionsView.ShowViewCaption = true;
            gridControl1.ViewCollection[0].ShowPrintPreview();
            gridView1.OptionsView.ShowViewCaption = false;
            //gridControl1.Print();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            cbx_magasin_SelectedValueChanged(null, null);
        }

        public CHM_LISTE_STOCK_PAR_MAGAZIN(decimal CODE_MAG)
        {
            InitializeComponent();
            
            //dt_mag = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_MAGAZINS();
            dt_mag = CLIENT_APP_PARAM.gcws.SELECT_MAGAZINS();
            cbx_magasin.DataSource = dt_mag;
            cbx_magasin.DisplayMember = "NOM_MAG";
            cbx_magasin.ValueMember = "CODE_MAG";
            cbx_magasin.SelectedValueChanged += new EventHandler(cbx_magasin_SelectedValueChanged);
            
            _CODE_MAG = CODE_MAG;
            cbx_magasin.SelectedValue = Convert.ToDecimal(_CODE_MAG);
            cbx_magasin_SelectedValueChanged(null, null);
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_afficher.Visible = true;
            chM_CMP_CONTROL1.btn_ajout.Visible = false;
            chM_CMP_CONTROL1.btn_modifier.Visible = false;
            chM_CMP_CONTROL1.btn_supprimer.Visible = false;

            chM_CMP_CONTROL1.btn_afficher.Text = "Imprimer Liste";
            chM_CMP_CONTROL1.btn_afficher.Image = Resources.Print_32x32;
            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
        }

        void cbx_magasin_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (((CHM_GESTION_COMERCIALE.RESULT_QUERY)CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal((decimal)cbx_magasin.SelectedValue))).OK)
                if (((CHMGC.RESULT_QUERY)CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal((decimal)cbx_magasin.SelectedValue))).OK)
                {
                    //_dt_article = CLIENT_APP_PARAM.GEST.P_STOCK.SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN((decimal)cbx_magasin.SelectedValue);
                    //_dt_article = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN((decimal)cbx_magasin.SelectedValue);
                    //_bs_article.DataSource = _dt_article;
                    dS_MOUV1.STOCK.Clear();
                    dS_MOUV1.STOCK.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN((decimal)cbx_magasin.SelectedValue));
                }
                else
                {
                    MessageBox.Show("Ce magasin est en inventaire");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CHM_LISTE_STOCK_PAR_MAGAZIN_Load(object sender, EventArgs e)
        {

        }

        private void recherche_article_TextChanged(object sender, EventArgs e)
        {
            //if (recherche_article.Text=="")
            //{
            //    _bs_article.DataSource = _dt_article;
            //    dgv_Liste_article.DataSource = _bs_article;
            //}
            //else
            //{
            //    _dt_article.DefaultView.RowFilter = "REF_ARTICLE like '%" + recherche_article.Text + "%' OR DESIGNATION_ARTICLE like '%" + recherche_article.Text + "%' OR CODE_BARRE_ARTICLE like '%" + recherche_article.Text + "%'";
            //    DataTable dt = _dt_article.DefaultView.ToTable();
            //    _dt_article.DefaultView.RowFilter = "";
            //    _bs_article.DataSource = dt;
            //    dgv_Liste_article.DataSource = _bs_article;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}