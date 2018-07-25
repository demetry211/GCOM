using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_ARTICLES : Form
    {
        DataTable dt;
        BindingSource bs = new BindingSource();
 
        public CHM_LISTE_ARTICLES()
        {
            InitializeComponent();
            bs = CLIENT_APP_PARAM.ds_param.bsArticle;
            gridControl1.DataSource = bs;

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(actualiserToolStripMenuItem_Click);
            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(CMS_NV_ARTICLE_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(CMS_MODIFIER_ARTICLE_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(CMS_SUPP_ARTICLE_Click);
        }

        

        void btn_afficher_Click(object sender, EventArgs e)
        {
            CHM_ARTICLE f = new CHM_ARTICLE();
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }

        private void chargerListe()
        {
            try
            {
                
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        

        private void CMS_NV_ARTICLE_Click(object sender, EventArgs e)
        {
            bs.AddNew();

            DataRowView drv = (DataRowView)bs.Current;
            drv["CODE_ARTICLE"] = -1;
            drv["CODE_UNITE"] = 1;
            drv["CODE_MARQUE"] = 1;
            drv["CODE_TVA"] = 1;
            drv["CODE_FAMILLE"] = 1;
            drv["CODE_MAG"] = 1;
            drv["CODE_FOURNISSEUR"] = 1;
            drv["CODE_CATEG"] = 1;


            CHM_NV_ARTICLE f = new CHM_NV_ARTICLE(bs);
            f.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(f_Enregistrer);
            f.OnClosing+=new CHM_NV_ARTICLE.Closing(f_OnClosing);
            f.ShowDialog();
        }

        void f_Enregistrer(DataRowView dr, bool nouv)
        {
            if (nouv)
            {
                bs.EndEdit();
                ((DataTable)bs.DataSource).AcceptChanges();
            }
            else
            {
                bs.CancelEdit();
                (bs.DataSource as DataTable).RejectChanges();
            }   
        }

        private void CMS_MODIFIER_ARTICLE_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (bs.Current != null)
                {
                    CHM_NV_ARTICLE f = new CHM_NV_ARTICLE(bs);
                    f.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(f_Enregistrer);
                    f.OnClosing += new CHM_NV_ARTICLE.Closing(f_OnClosing);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
            finally
            {
                
            }
            
        }

        void f_OnClosing(bool changes)
        {
            if (!changes)
            {
                bs.CancelEdit();
                (bs.DataSource as DataTable).RejectChanges();
            }
        }

        private void CMS_SUPP_ARTICLE_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                if (MessageBox.Show("Etes vous sûres de supprimer cet article?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    CHMGC.RESULT_QUERY res;
                    try
                    {
                        DataRowView drv = (DataRowView)bs.Current;
                        Application.DoEvents();
                        res = CLIENT_APP_PARAM.gcws.DELETE_ARTICLE(drv["CODE_ARTICLE"].ToString());
                        if (res.OK)
                        {
                            bs.RemoveCurrent();
                            (bs.DataSource as DataTable).AcceptChanges();
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

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_ALL_ARTICLE();
                CLIENT_APP_PARAM.ds_param.chargerArticles();
                //bs.DataSource = DT_ARTICLE;
                Cursor = Cursors.Default;
            }
            catch (Exception er)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CMS_ARTICLE_Opening_1(object sender, CancelEventArgs e)
        {
            CMS_MODIFIER_ARTICLE.Enabled = true;
            CMS_SUPP_ARTICLE.Enabled = true;
            CMS_NV_ARTICLE.Enabled = true;
            CMS_IMP_ARTICLE.Enabled = true;
            if (bs.Current == null)
            {
                CMS_MODIFIER_ARTICLE.Enabled = false;
                CMS_SUPP_ARTICLE.Enabled = false;
                CMS_IMP_ARTICLE.Enabled = false;
            }
        }

        private void CHM_LISTE_ARTICLES_Shown(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();                
                Cursor = Cursors.WaitCursor;
                Cursor = Cursors.Default;
            }
            catch (Exception er)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool currentlyAnimating = false;

        //This method begins the animation. 
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {

                //Begin the animation only once.
                //ImageAnimator.Animate(pictureBox1.Image, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }

        private void OnFrameChanged(object o, EventArgs e)
        {

            //Force a call to the Paint event handler. 
            //this.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Begin the animation.
            AnimateImage();

            //Get the next frame ready for rendering.
            ImageAnimator.UpdateFrames();

            //Draw the next frame in the animation.
            //e.Graphics.DrawImage(pictureBox1.Image, new Point(0, 0));
        }

        private void CHM_LISTE_ARTICLES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                actualiserToolStripMenuItem_Click(null, null);

            
        }

        

        

        

        
        

        

        

        private void CHM_LISTE_ARTICLES_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_liste_article_DoubleClick(object sender, EventArgs e)
        {
            
        }

        

    }
}
