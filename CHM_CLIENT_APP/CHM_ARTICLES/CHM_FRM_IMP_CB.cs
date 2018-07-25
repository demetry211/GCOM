using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    public partial class CHM_FRM_IMP_CB : Form
    {
        ReportDocument rpt5;
        ReportDocument rpt4;
        ReportDocument rpt1;
        BindingSource bsArticle;
        BindingSource bsCB5;
        BindingSource bsCB4;
        BindingSource bsCB1;

        public CHM_FRM_IMP_CB()
        {
            InitializeComponent();
            this.Text = entete_Formulaire_21.windows_name.Text = "Impression Code à Barre";
            rpt5 = new CHM_RPT_IMP_CB5();
            rpt4 = new CHM_RPT_IMP_CB4();
            rpt1 = new CHM_RPT_IMP_CB1();
            bsArticle = new BindingSource();
            bsArticle.DataSource = chM_DS_IMP_CB1.DT_ART;
            gridControl1.DataSource = bsArticle;
            bsCB5 = new BindingSource();
            bsCB5.DataSource = chM_DS_IMP_CB1.CB5;
            bsCB4 = new BindingSource();
            bsCB4.DataSource = chM_DS_IMP_CB1.CB4;
            bsCB1 = new BindingSource();
            bsCB1.DataSource = chM_DS_IMP_CB1.CB1;
        }

        private void CHM_FRM_IMP_CB_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_COMMANDE_ARTICLE fArt = new CHM_COMMANDE_ARTICLE("CMD_CL");
                fArt.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(fArt_confirm_ajout);
                fArt.StartPosition = FormStartPosition.CenterScreen;
                fArt.ShowDialog();
                //CHM_FRM_SELECTION_ARTICLE f = new CHM_FRM_SELECTION_ARTICLE(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG), "");
                //f.on_select += new CHM_FRM_SELECTION_ARTICLE.selection_article(f_on_select);
                //f.ShowDialog();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void fArt_confirm_ajout(DataRowView article, decimal qte, decimal prix)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //dS_MOUV1.CB.Clear();              
                bsArticle.AddNew();
                DataRowView drv = (DataRowView)bsArticle.Current;

                drv["CODE_ARTICLE"] = article["CODE_ARTICLE"];
                drv["DES_ARTICLE"] = article["DESIGNATION_ARTICLE"];
                drv["PRIX_TTC"] = article["PRIX_TTC"];
                drv["CB_ARTICLE"] = article["CODE_BARRE_ARTICLE"];
                drv["QTE"] = qte;

                

                bsArticle.EndEdit();
                (bsArticle.DataSource as DataTable).AcceptChanges();

                //remplir5();
                //remplir4();
                //remplir1();

                comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void remplir1()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                chM_DS_IMP_CB1.CB1.Clear();
                foreach (DataRow dr in chM_DS_IMP_CB1.DT_ART.Rows)
                {
                    for (int j = 0; j < Convert.ToInt32(dr["QTE"]); j++)
                    {
                        bsCB1.AddNew();
                        DataRowView drv = (DataRowView)bsCB1.Current;

                        drv["CODE_ARTICLE1"] = dr["CODE_ARTICLE"];
                        drv["DES_ARTICLE1"] = dr["DES_ARTICLE"];
                        drv["CB_ARTICLE1"] = dr["CB_ARTICLE"];
                        drv["PRIX_TTC1"] = dr["PRIX_TTC"];
                    }
                }

                bsCB1.EndEdit();
                (bsCB1.DataSource as DataTable).AcceptChanges();
                //rpt1.SetDataSource(chM_DS_IMP_CB1);
                //rpt1.Refresh();
                //crystalReportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void remplir4()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                chM_DS_IMP_CB1.CB4.Clear();
                int i = 0;
                foreach (DataRow dr in chM_DS_IMP_CB1.DT_ART.Rows)
                {
                    for (int j = 0; j < Convert.ToInt32(dr["QTE"]); j++)
                    {
                        if (i % 4 == 0)
                        {
                            i = 0;
                            bsCB4.AddNew();
                        }
                        i++;
                        DataRowView drv = (DataRowView)bsCB4.Current;

                        drv[string.Format("CODE_ARTICLE{0}", i)] = dr["CODE_ARTICLE"];
                        drv[string.Format("DES_ARTICLE{0}", i)] = dr["DES_ARTICLE"];
                        drv[string.Format("CB_ARTICLE{0}", i)] = dr["CB_ARTICLE"];
                        drv[string.Format("PRIX_TTC{0}", i)] = dr["PRIX_TTC"];
                    }
                }

                bsCB4.EndEdit();
                (bsCB4.DataSource as DataTable).AcceptChanges();
                //rpt4.SetDataSource(chM_DS_IMP_CB1);
                //rpt4.Refresh();
                //crystalReportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void remplir5()
        {
            
            try
            {
                Cursor = Cursors.WaitCursor;
                chM_DS_IMP_CB1.CB5.Clear();
                int i = 0;
                foreach (DataRow dr in chM_DS_IMP_CB1.DT_ART.Rows)
                {
                    for (int j = 0; j < Convert.ToInt32(dr["QTE"]); j++)
                    {
                        if (i % 5 == 0)
                        {
                            i = 0;
                            bsCB5.AddNew();
                        }
                        i++;
                        DataRowView drv = (DataRowView)bsCB5.Current;

                        drv[string.Format("CODE_ARTICLE{0}", i)] = dr["CODE_ARTICLE"];
                        drv[string.Format("DES_ARTICLE{0}", i)] = dr["DES_ARTICLE"];
                        drv[string.Format("CB_ARTICLE{0}", i)] = dr["CB_ARTICLE"];
                        drv[string.Format("PRIX_TTC{0}", i)] = dr["PRIX_TTC"];
                    }
                }

                bsCB5.EndEdit();
                (bsCB5.DataSource as DataTable).AcceptChanges();
                //rpt5.SetDataSource(chM_DS_IMP_CB1);
                //rpt5.Refresh();
                //crystalReportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (bsArticle.Current != null)
            {
                bsArticle.RemoveCurrent();
                (bsArticle.DataSource as DataTable).AcceptChanges();
                //remplir1();
                //remplir4();
                //remplir5();

                comboBox1_SelectedIndexChanged(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    remplir1();
                    rpt1.SetDataSource(chM_DS_IMP_CB1);
                    crystalReportViewer1.ReportSource = rpt1;
                    
                    //rpt1.Refresh();
                    //crystalReportViewer1.RefreshReport();
                    break;

                case 1:
                    remplir4();
                    rpt4.SetDataSource(chM_DS_IMP_CB1);
                    crystalReportViewer1.ReportSource = rpt4;
                    
                    //rpt4.Refresh();
                    //crystalReportViewer1.RefreshReport();
                    break;

                case 2:
                    remplir5();
                    rpt5.SetDataSource(chM_DS_IMP_CB1);
                    crystalReportViewer1.ReportSource = rpt5;
                    
                    //rpt5.Refresh();
                    //crystalReportViewer1.RefreshReport();
                    break;
            }
        }

    }
}
