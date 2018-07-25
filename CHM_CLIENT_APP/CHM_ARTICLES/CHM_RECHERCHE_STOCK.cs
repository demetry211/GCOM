using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_RECHERCHE_STOCK : Form
    {
        string des_article;
        public delegate void fermer_deleg();
        public event fermer_deleg fermer;
        public CHM_RECHERCHE_STOCK(string designation)
        {
            InitializeComponent();
            this.des_article = designation;
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        private void CHM_RECHERCHE_STOCK_Shown(object sender, EventArgs e)
        {
            dgv_liste_article_en_stock.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_STOCK.SEARCH_ARTICLE_STOCK(des_article);
                dt = CLIENT_APP_PARAM.gcws.SEARCH_ARTICLE_STOCK(des_article);
                bs.DataSource = dt;
                dgv_liste_article_en_stock.DataSource = bs;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_selection_Click(object sender, EventArgs e)
        {
            if (fermer != null)
                fermer();
            DataRowView drv = (DataRowView)bs.Current;
            string code_article = drv["CODE_ARTICLE"].ToString();
            this.Close();
            CLIENT_APP_PARAM.ds_param.bsArticle.AddNew();
            ((DataRowView)bs.Current)["CODE_ARTICLE"] = -1;
            CHM_NV_ARTICLE f = new CHM_NV_ARTICLE(CLIENT_APP_PARAM.ds_param.bsArticle);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.RightToLeft = RightToLeft.No;
            //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.ShowDialog();
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
