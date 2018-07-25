using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON
{
    public partial class CHM_FRM_SELECTION_ARTICLE : Form
    {
        private string _NOM_MAG;
        private decimal _CODE_MAG;
        DataTable _dt_liste;
        BindingSource _bs_liste = new BindingSource();
        public delegate void selection_article(DataRowView Article, decimal qte);
        public event selection_article on_select;
        public CHM_FRM_SELECTION_ARTICLE(decimal CODE_MAG, string NOM_MAG)
        {
            InitializeComponent();
            _CODE_MAG = CODE_MAG;
            _NOM_MAG = NOM_MAG;
            lb_magasin.Text = string.Format("Magasin : {0}", _NOM_MAG);
            chargerArticles();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chargerArticles()
        {
            try
            {
                dgv_Liste.AutoGenerateColumns = false;
                _dt_liste = CLIENT_APP_PARAM.gcws.SELECT_ARTICLE_EN_STOCK_PAR_MAGASIN(_CODE_MAG);
                _bs_liste.DataSource = _dt_liste;
                dgv_Liste.DataSource = _bs_liste;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void recherche_article_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (recherche_article.Text == "")
                {
                    _bs_liste.DataSource = _dt_liste;
                    dgv_Liste.DataSource = _bs_liste;
                }
                else
                {
                    _dt_liste.DefaultView.RowFilter = "REF_ARTICLE like '%" + recherche_article.Text + "%' OR DESIGNATION_ARTICLE LIKE '%" + recherche_article.Text + "%'";
                    DataTable dt = _dt_liste.DefaultView.ToTable();
                    _bs_liste.DataSource = dt;
                    dgv_Liste.DataSource = _bs_liste;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dgv_Liste_DoubleClick(object sender, EventArgs e)
        {
            panel_qte.Visible = true;
            qte_select_article.Focus();
        }

        private void btn_validation_ajout_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bs_liste.Current != null && on_select != null)
                    on_select((DataRowView)_bs_liste.Current, qte_select_article.Value);
                panel_qte.Visible = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_qte.Visible = false;
        }

        private void panel_qte_VisibleChanged(object sender, EventArgs e)
        {
            dgv_Liste.Enabled = !panel_qte.Visible;            
        }

        private void qte_select_article_ValueChanged(object sender, EventArgs e)
        {
            if (qte_select_article.Value > Convert.ToDecimal((_bs_liste.Current as DataRowView)["QTTE_STOCK"]))
            {
                MessageBox.Show("Vous ne pouvez pas livrer une qté supérieure à celle disponible au stock.", CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //qte_select_article.Value = Convert.ToDecimal((_bs_liste.Current as DataRowView)["QTTE_STOCK"]);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            panel_qte.Visible = true;
            qte_select_article.Focus();
        }
    }
}