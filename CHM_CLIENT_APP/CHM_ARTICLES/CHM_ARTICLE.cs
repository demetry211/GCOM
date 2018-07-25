using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP
{
    public partial class CHM_ARTICLE : Form
    {
        int _mode = 0;
        decimal _CODE_ARTICLE;
        public CHM_ARTICLE()
        {
            InitializeComponent();
        }

        public CHM_ARTICLE(decimal CODE_ARTICLE)
        {
            InitializeComponent();
            _mode = 1;
            _CODE_ARTICLE = CODE_ARTICLE;
        }

        DataTable dt;
        BindingSource bs = new BindingSource();

        private void CHM_ARTICLE_Shown(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_ALL_ARTICLE();
                //dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE();
                bs = CLIENT_APP_PARAM.ds_param.bsArticle;


                chargerArticle();
                if (_mode == 1)
                {
                    bs.Position = bs.Find("CODE_ARTICLE", _CODE_ARTICLE);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }



        private void chargerArticle()
        {
            try
            {
                //if (bs.Current != null)
                //{
                //DataRowView drv = (DataRowView)bs.Current;
                //REF_ARTICLE.Text = drv["REF_ARTICLE"].ToString();
                //if ((bool)drv["ETAT_ARTICLE"] == true)
                //    ETAT_ARTICLE.CheckState = CheckState.Checked;
                //else
                //    ETAT_ARTICLE.CheckState = CheckState.Unchecked;
                //DESIGNATION_ARTICLE.Text = drv["DESIGNATION_ARTICLE"].ToString();
                //MARQUE_ARTICLE.Text = drv["DESIGNATION_MARQUE"].ToString();
                //DESCRIPTION_ARTICLE.Text = drv["DESCRIPTION_ARTICLE"].ToString();
                //CODE_BARRE_ARTICLE.Text = drv["CODE_BARRE_ARTICLE"].ToString();
                //CTRL_CODE_BARRE_ARTICLE.BarCode = CODE_BARRE_ARTICLE.Text;
                //PHOTO_ARTICLE.DataBindings.Add("Image", bs, "PHOTO_ARTICLE", true);
                //QTE_ARTICLE.Text = drv["QTE_ARTICLE"].ToString();
                //UNITE_QTE.Text = drv["LIB_UNITE"].ToString();
                //QTE_MIN_ARTICLE.Text = drv["QTE_MIN_ARTICLE"].ToString();
                //UNITE_QTE_M.Text = drv["LIB_UNITE"].ToString();
                //PRIX_HT_A_ARTICLE.Text = drv["PRIX_HT_A_ARTICLE"].ToString();
                //TVA_ARTICLE.Text = drv["TAUX_TVA"].ToString();
                //PRIX_HT_V_ARTICLE.Text = drv["PRIX_HT_V_ARTICLE"].ToString();
                //CATEGORIE.Text = drv["LIB_CATEG"].ToString();
                //MAGASIN.Text = drv["NOM_MAG"].ToString();
                //FOURNISSEUR.Text = drv["RS_FOURNISSEUR"].ToString();
                //}

                REF_ARTICLE.DataBindings.Add("Text", bs, "REF_ARTICLE", true);
                ETAT_ARTICLE.DataBindings.Add("Checked", bs, "ETAT_ARTICLE", true);
                DESIGNATION_ARTICLE.DataBindings.Add("Text", bs, "DESIGNATION_ARTICLE", true);
                CODE_BARRE_ARTICLE.DataBindings.Add("Text", bs, "CODE_BARRE_ARTICLE", true);
                CTRL_CODE_BARRE_ARTICLE.DataBindings.Add("BarCode", bs, "CODE_BARRE_ARTICLE", true);
                PHOTO_ARTICLE.DataBindings.Add("Image", bs, "PHOTO_ARTICLE", true);
                QTE_ARTICLE.DataBindings.Add("Text", bs, "QTE_ARTICLE", true);
                UNITE_QTE.DataBindings.Add("Text", bs, "LIB_UNITE", true);
                QTE_MIN_ARTICLE.DataBindings.Add("Text", bs, "QTE_MIN_ARTICLE", true);
                UNITE_QTE_M.DataBindings.Add("Text", bs, "LIB_UNITE", true);
                PRIX_HT_A_ARTICLE.DataBindings.Add("Text", bs, "PRIX_HT_A_ARTICLE", true);
                TVA_ARTICLE.DataBindings.Add("Text", bs, "TAUX_TVA", true);
                PRIX_HT_V_ARTICLE.DataBindings.Add("Text", bs, "PRIX_HT_V_ARTICLE", true);
                CATEGORIE.DataBindings.Add("Text", bs, "LIB_CATEG", true);
                MAGASIN.DataBindings.Add("Text", bs, "NOM_MAG", true);
                FOURNISSEUR.DataBindings.Add("Text", bs, "RS_FOURNISSEUR", true);

            }
            catch (Exception er)
            {
                throw er;
            }

        }



        private void btn_article_suivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btn_article_prec_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void buttonENREGISTRER_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            ((DataRowView)bs.Current)["CODE_ARTICLE"] = "-1";
            CHM_NV_ARTICLE fiche = new CHM_NV_ARTICLE(bs);
            fiche.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(fiche_Enregistrer);
            fiche.ShowDialog();
        }

        void fiche_Enregistrer(DataRowView dr, bool nouv)
        {
            if (nouv)
                bs.AddNew();

            DataRowView drv = (DataRowView)bs.Current;
            drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
            drv["REF_ARTICLE"] = dr["REF_ARTICLE"];
            drv["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
            drv["MARQUE_ARTICLE"] = dr["MARQUE_ARTICLE"];
            drv["QTE_ARTICLE"] = dr["QTE_ARTICLE"];
            drv["UNITE_QTE_ARTICLE"] = dr["UNITE_QTE_ARTICLE"];
            drv["QTE_MIN_ARTICLE"] = dr["QTE_MIN_ARTICLE"];
            drv["PRIX_HT_A_ARTICLE"] = dr["PRIX_HT_A_ARTICLE"];
            drv["PRIX_HT_V_ARTICLE"] = dr["PRIX_HT_V_ARTICLE"];
            drv["TVA_ARTICLE"] = dr["TVA_ARTICLE"];
            drv["PRIX_TTC_ARTICLE"] = Convert.ToDecimal(dr["PRIX_HT_V_ARTICLE"]) * (1 + Convert.ToDecimal(dr["TVA_ARTICLE"]) / 100);
            drv["ETAT_ARTICLE"] = dr["ETAT_ARTICLE"];
            drv["CODE_CATEG"] = dr["CODE_CATEG"];
            drv["CODE_MAG"] = dr["CODE_MAG"];
            drv["CODE_FOURNISSEUR"] = dr["CODE_FOURNISSEUR"];
            drv["LIB_CATEG"] = dr["LIB_CATEG"];
            drv["NOM_MAG"] = dr["NOM_MAG"];
            drv["RS_FOURNISSEUR"] = dr["RS_FOURNISSEUR"];
            bs.EndEdit();
            dt.AcceptChanges();
        }

        private void BTN_MODIFIER_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    CHM_NV_ARTICLE fiche = new CHM_NV_ARTICLE(bs);
                    fiche.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(fiche_Enregistrer);
                    fiche.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void BTN_SUPPRIMER_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                if (MessageBox.Show("Etes vous sûres de supprimer cet article?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res;
                    CHMGC.RESULT_QUERY res;
                    try
                    {
                        DataRowView drv = (DataRowView)bs.Current;
                        Application.DoEvents();
                        //res = CLIENT_APP_PARAM.GEST.P_ARTICLE.DELETE_ARTICLE(drv["CODE_ARTICLE"].ToString());
                        res = CLIENT_APP_PARAM.gcws.DELETE_ARTICLE(drv["CODE_ARTICLE"].ToString());
                        if (res.OK)
                        {
                            bs.RemoveCurrent();
                            dt.AcceptChanges();
                        }
                        else
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CHM_ARTICLE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                btn_article_suivant.PerformClick();
            if (e.KeyCode == Keys.Right)
                btn_article_prec.PerformClick();
        }

        private void CHM_ARTICLE_Load(object sender, EventArgs e)
        {

        }

        private void client_to_liste_Click(object sender, EventArgs e)
        {

            CHM_LISTE_ARTICLES f = new CHM_LISTE_ARTICLES();
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.WindowState = FormWindowState.Maximized;
            //f.RightToLeft = RightToLeft.No;
            f.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string code = (bs.Current as DataRowView)[0].ToString();
                ReportDocument rpt = new CHM_CLIENT_APP.CHM_ETAT.CODE_BARRE_ARTICLE();
                //DataTable dt = CLIENT_APP_PARAM.GEST.P_ARTICLE.IMPRIMER_CODE_BARRE_ARTICLE(code, false);
                DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_CODE_BARRE_ARTICLE(code, false);
                rpt.SetDataSource(dt);

                CHM_ETATS f = new CHM_ETATS();
                f.CHM_Aperçu_document.ReportSource = rpt;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = (bs.Current as DataRowView)["CODE_ARTICLE"].ToString();
                ReportDocument rpt = new CHM_CLIENT_APP.CHM_ETAT.CHM_CODE_BARRE_ARTICLE_SOLDE();
                //DataTable dt = CLIENT_APP_PARAM.GEST.P_ARTICLE.IMPRIMER_CODE_BARRE_ARTICLE(code, true);
                DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_CODE_BARRE_ARTICLE(code, true);
                rpt.SetDataSource(dt);

                CHM_ETATS f = new CHM_ETATS();
                f.CHM_Aperçu_document.ReportSource = rpt;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

    }
}
