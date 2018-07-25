using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_COMMANDE_ARTICLE : Form
    {
        public delegate void ajout_article_deleg(DataRowView article, decimal qte, decimal prix);
        public event ajout_article_deleg confirm_ajout;
        DataTable dt;
        BindingSource bs;

        DataTable dt_fourn;
        BindingSource bs_fourn;
        DataTable dt_categ;
        BindingSource bs_categ;
        DataTable dt_mag;
        BindingSource bs_mag;

        string _mode = "";

        public CHM_COMMANDE_ARTICLE(string mode)
        {
            InitializeComponent();
            _mode = mode;
            bs = new BindingSource();
            bs_fourn = new BindingSource();
            bs_categ = new BindingSource();
            bs_mag = new BindingSource();

            dt_mag = CLIENT_APP_PARAM.gcws.SELECT_MAGAZINS();
            magazin_article.DataSource = dt_mag;
            magazin_article.DisplayMember = "NOM_MAG";
            magazin_article.ValueMember = "CODE_MAG";

            bs.DataSource = CLIENT_APP_PARAM.ds_param.V_ARTICLE;
            gridControl1.DataSource = bs;
        }
        
        private void CHM_COMMANDE_ARTICLE_Shown(object sender, EventArgs e)
        {
            //dt_mag = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_MAGAZINS();
            //bs_mag.DataSource = dt_mag;
            
            //dt_fourn = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_FOURNISSEURS();
            //bs_fourn.DataSource = dt_fourn;
            //dt_categ = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_CATEGORIES();
            //bs_categ.DataSource = dt_categ;
            //if (magazin_article.Text.Trim() == "")
            //{
            //    errorProvider1.SetError(magazin_article, "");
            //    if (magazin_article.SelectedText == "")
            //    {
            //        errorProvider1.SetError(magazin_article, "You should select the store!\nÌÃ» «Œ Ì«— «·„Œ“‰");
            //        magazin_article.Focus();

            //        //return;
            //    }
            //}
            try
            {
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                
                
                //dt_fourn = CLIENT_APP_PARAM.gcws.SELECT_FOURNISSEURS();
                bs_fourn.DataSource = CLIENT_APP_PARAM.ds_param.FOURNISSEUR;

                //dt_categ = CLIENT_APP_PARAM.gcws.SELECT_CATEGORIES();
                bs_categ.DataSource = CLIENT_APP_PARAM.ds_param.CATEGORIE;
                Application.DoEvents();
                
                label4.Visible = false;
                magazin_article.Visible = false;
                btn_ajout.Visible = true;
                if (_mode == "CMD_FR" || _mode == "BR_FR")
                {                    
                    colPRIX_HT_A_ARTICLE.Visible = true;
                    colPRIX_HT_V_ARTICLE.Visible = false;
                    colTAUX_TVA.Visible = false;
                    colTAUX_TVA_ACHAT.Visible = true;
                }

                if (_mode != "CMD_CL" && _mode != "BR_FR" && _mode != "CMD_FR")
                {
                    btn_ajout.Visible = false;
                    Application.DoEvents();
                    //dt = CLIENT_APP_PARAM.GEST.P_STOCK.SELECT_ALL_ARTICLE_EN_STOCK();
                    dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE_EN_STOCK();
                    bs.DataSource = dt;
                    magazin_article.Visible = true;
                    label4.Visible = true;
                    magazin_article.Enabled=false;
                    //dt_mag = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_MAGAZINS();
                    
                    magazin_article.SelectedValueChanged += new EventHandler(magazin_article_SelectedValueChanged);
                    magazin_article.SelectedValue = Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG);
                }                
                panel_qte.Visible = false;               
                    Cursor = Cursors.Default;
            }
            catch (Exception er)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_mode != "CMD_CL" && _mode != "BR_FR" && magazin_article.Text.Trim() == "")
            {
                errorProvider1.SetError(magazin_article, "");
                if (magazin_article.SelectedValue==null)
                {
                    errorProvider1.SetError(magazin_article, "Veuillez sÈlectionner le magasin.");
                    magazin_article.Focus();

                    //return;
                }
            }
        }

        

        
        private void button2_Click(object sender, EventArgs e)
        {
            panel_qte.Visible = false;
        }

        private void btn_validation_ajout_Click(object sender, EventArgs e)
        {
            if (confirm_ajout != null)
            {
                confirm_ajout((DataRowView)bs.Current, qte_select_article.Value, nud_prix.Value);
                panel_qte.Visible = false;
                gridControl1.Focus();
                qte_select_article.Value = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                panel_qte.Visible = true;
                qte_select_article.Focus();
                qte_select_article.Value = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Avez vous terminÈ la sÈlection des articles", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void dgv_liste_article_KeyDown(object sender, KeyEventArgs e)
        {
            if (bs.Current != null && e.KeyCode == Keys.Enter)
            {
                panel_qte.Visible = true;
                qte_select_article.Focus();
                qte_select_article.Value = 1;
            }
            if (e.KeyCode == Keys.Escape && PANEL_PHOTO.Visible == true)
            {
                PHOTO_ARTICLE.Visible = false;
            }
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_ALL_ARTICLE();
                dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE();
                bs.DataSource = dt;
                gridControl1.DataSource = bs;
                panel_qte.Visible = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void magazin_article_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_COMMANDE.LOAD_LISTE_ARTICLE(magazin_article.SelectedItem.ToString());
                dt = CLIENT_APP_PARAM.gcws.LOAD_LISTE_ARTICLE(magazin_article.SelectedItem.ToString());
                bs.DataSource = dt;
                //gridControl1.DataSource = bs;
                panel_qte.Visible = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_liste_article_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PHOTO_ARTICLE.DataBindings.Clear();
            pictureBox1.DataBindings.Clear();
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                pictureBox1.DataBindings.Add("Image", bs, "PHOTO_ARTICLE", true);
                PHOTO_ARTICLE.DataBindings.Add("Image", bs, "PHOTO_ARTICLE", true);
            }
        }

        private void dgv_liste_article_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            PANEL_PHOTO.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PANEL_PHOTO.Visible = true;

        }

        private void panel_qte_VisibleChanged(object sender, EventArgs e)
        {
            if (panel_qte.Visible)
            {
                if (_mode == "BR_FR")
                {
                    label2.Visible = true;
                    nud_prix.Visible = true;
                    qte_select_article.Visible = true;
                    qte_select_article.Focus();
                }
                if (_mode == "CMD_CL")
                {
                    label2.Visible = false;
                    nud_prix.Visible = false;
                    qte_select_article.Focus();
                }
                gridControl1.Enabled = false;
            }
            if (!panel_qte.Visible)
            {
                nud_prix.Value = 0;
                qte_select_article.Value = 1;
                gridControl1.Enabled = true;
            }
        }
        DataTable dt_search_stock;
        private void magazin_article_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dt.DefaultView.RowFilter = "CODE_MAG ='" + magazin_article.SelectedValue.ToString() + "'";
                dt_search_stock = dt.DefaultView.ToTable();
                dt.DefaultView.RowFilter = "";
                bs.DataSource = dt_search_stock;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            CLIENT_APP_PARAM.ds_param.bsArticle.AddNew();
            ((DataRowView)CLIENT_APP_PARAM.ds_param.bsArticle.Current)["CODE_ARTICLE"] = -1;
            CHM_NV_ARTICLE f = new CHM_NV_ARTICLE(CLIENT_APP_PARAM.ds_param.bsArticle);
            f.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(f_Enregistrer);
            f.ShowDialog();
        }

        void f_Enregistrer(DataRowView dr, bool nouv)
        {
            CLIENT_APP_PARAM.ds_param.chargerArticles();
        }

        private void CHM_COMMANDE_ARTICLE_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                SendKeys.Send("{tab}");
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    UNITE_ARTICLE.Text = drv["LIB_UNITE"].ToString();
                    panel_qte.Visible = true;
                    qte_select_article.Focus();
                    qte_select_article.Value = 1;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
