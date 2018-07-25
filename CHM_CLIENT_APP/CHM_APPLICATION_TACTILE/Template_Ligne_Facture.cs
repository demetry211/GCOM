using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    public partial class Template_Ligne_Facture : UserControl
    {
        DataTable _dt_article;
        int _index;
        string _codart;

        public Template_Ligne_Facture()
        {
            InitializeComponent();
        }

        public Template_Ligne_Facture(int index)
        {
            InitializeComponent();
            _index = index;
        }

        private void btn_nbr_art_Click(object sender, EventArgs e)
        {
            if ((sender as Control).Text.Trim() != "")
            {
                CHM_FRM_QTE f = new CHM_FRM_QTE(Convert.ToInt32((sender as Control).Text), this.Name);
                f._augmenter_quantite += new CHM_FRM_QTE.augmenter(f__augmenter_quantite);
                f._diminuer_quantite += new CHM_FRM_QTE.diminuer(f__diminuer_quantite);
                f.Parent = this.Parent;
                f.ShowDialog();
            }
        }

        void f__diminuer_quantite(int num)
        {
            this.btn_nbr_art.Text = num.ToString();
        }

        void f__augmenter_quantite(int num)
        {
            this.btn_nbr_art.Text = num.ToString();
        }

        public void charger_article(string codart)
        {
            _codart = codart;
            //_dt_article = CLIENT_APP_PARAM.GEST.P_ARTICLE.LOAD_ARTICLE(codart);
            _dt_article = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE(codart);
            btn_ref_art.Text = _dt_article.Rows[0]["REF_ARTICLE"].ToString();
            btn_des_art.Text = _dt_article.Rows[0][""].ToString();
            btn_prix_art.Text = Convert.ToString((decimal)_dt_article.Rows[0][""]);
            btn_nbr_art.Text = "1";
        }

        private void calculer_prix_total()
        {
            btn_prix_total.Text = Convert.ToString((decimal)(Convert.ToDecimal(btn_nbr_art.Text) * Convert.ToDecimal(btn_prix_art.Text)));
        }

        private void btn_nbr_art_TextChanged(object sender, EventArgs e)
        {
            if (btn_prix_art.Text != "")
                calculer_prix_total();
        }
    }
}
