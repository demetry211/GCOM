using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.BON_RETOUR_CLIENT
{
    public partial class CHM_FRM_BON_RETOUR_CLIENT : Form
    {
        DataTable dt_lg_facture;
        BindingSource bs_lg_facture = new BindingSource();
        DataTable dt_facture;
        BindingSource bs_facture = new BindingSource();
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();
        DataTable dt_br;
        BindingSource bs_br=new BindingSource();

        public CHM_FRM_BON_RETOUR_CLIENT()
        {
            InitializeComponent();
            dgv_lg_facture.RowTemplate.Height = 50;
            dgv_detail_br.RowTemplate.Height = 50;
            dgv_detail_br.Font = dgv_lg_facture.Font= new System.Drawing.Font("Tahoma", 10F);
        }

        private void CHM_FRM_BON_RETOUR_CLIENT_Load(object sender, EventArgs e)
        {
            dgv_detail_br.AutoGenerateColumns = false;
            //dt_br = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT();
            dt_br = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT();
            bs_br.DataSource = dt_br;
            dgv_detail_br.DataSource = bs_br;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_RECHERCHE_FACTURE_Click(object sender, EventArgs e)
        {
            CHM_FACTURE.CHM_SELECTION_FACTURE f = new CHM_CLIENT_APP.CHM_FACTURE.CHM_SELECTION_FACTURE();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.onSelect += new CHM_CLIENT_APP.CHM_FACTURE.CHM_SELECTION_FACTURE.Selection_Facture(f_onSelect);
            f.ShowDialog();
        }

        void f_onSelect(string code_facture)
        {
            try
            {
                dgv_lg_facture.AutoGenerateColumns = false;
                Application.DoEvents();

                //dt_lg_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LIGNES_FACTURE(code_facture);
                dt_lg_facture = CLIENT_APP_PARAM.gcws.LOAD_LIGNES_FACTURE(code_facture);
                bs_lg_facture.DataSource = dt_lg_facture;
                dgv_lg_facture.DataSource = bs_lg_facture;

                Application.DoEvents();

                //dt_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_FACTURE_PAR_CODE(code_facture);
                dt_facture = CLIENT_APP_PARAM.gcws.LOAD_FACTURE_PAR_CODE(code_facture);
                bs_facture.DataSource = dt_facture;
                DataRowView drv_facture = (DataRowView)bs_facture.Current;
                CODE_Facture.Text = drv_facture["CODE_FACTURE"].ToString();
                DATE_FACTURE.Text = ((DateTime)drv_facture["DATE_FACTURE"]).ToString();
                TAUX_REMISE.Text = ((decimal)drv_facture["TAUX_REMISE"]).ToString();
                TTC.Text = ((decimal)drv_facture["MONTANT_TTC"]).ToString();
                NP.Text = ((decimal)drv_facture["MONTANT_TOTAL_FACTURE"]).ToString();

                //dt_client = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_CLIENT_FACTURE(drv_facture["CODE_CLIENT"].ToString());
                dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT_FACTURE(drv_facture["CODE_CLIENT"].ToString());
                bs_client.DataSource = dt_client;
                DataRowView drv_client = (DataRowView)bs_client.Current;
                RS_CLIENT.Text = drv_client["RS_CLIENT"].ToString();

                dgv_detail_br.AutoGenerateColumns = false;
                //dt_br = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT();
                dt_br = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT();
                bs_br.DataSource = dt_br;
                dgv_detail_br.DataSource = bs_br;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_remise_Click(object sender, EventArgs e)
        {

        }

        private void dgv_detail_br_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_lg_facture_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgv_detail_br_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal code_article = (decimal)(bs_br.Current as DataRowView)["CODE_ARTICLE"];
                bool exist = false;
                foreach (DataRowView drv_lg_fr in bs_lg_facture)
                {
                    if ((decimal)drv_lg_fr["CODE_ARTICLE"] == code_article)
                    {
                        drv_lg_fr["QTE"] = (decimal)drv_lg_fr["QTE"] + 1;
                        dt_lg_facture.AcceptChanges();
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    //DataTable dt_repair = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LIGNES_FACTURE(dt_facture.Rows[0]["CODE_FACTURE"].ToString());
                    DataTable dt_repair = CLIENT_APP_PARAM.gcws.LOAD_LIGNES_FACTURE(dt_facture.Rows[0]["CODE_FACTURE"].ToString());
                    BindingSource bs_repair = new BindingSource();
                    bs_repair.DataSource = dt_repair;
                    DataRowView drv_repair = (DataRowView)bs_repair.Current;
                    foreach (DataRowView drv in bs_repair)
                    {
                        if ((decimal)drv["CODE_ARTICLE"] == (decimal)(bs_br.Current as DataRowView)["CODE_ARTICLE"])
                        {
                            drv_repair = drv;
                            break;
                        }
                    }
                    
                    bs_lg_facture.AddNew();
                    DataRowView drv_lgf = (DataRowView)bs_lg_facture.Current;
                    drv_lgf["CODE_ARTICLE"] = (bs_br.Current as DataRowView)["CODE_ARTICLE"];
                    drv_lgf["QTE"] = 1;
                    drv_lgf["PRIX_U_TTC"] = (bs_br.Current as DataRowView)["PRIX_BRETOUR_CLIENT"];
                    drv_lgf["DESIGNATION_ARTICLE"] = (bs_br.Current as DataRowView)["DESIGNATION_ARTICLE"];
                    drv_lgf["REF_ARTICLE"] = (bs_br.Current as DataRowView)["REF_ARTICLE"];
                    drv_lgf["CODE_FACTURE"] = drv_repair["CODE_FACTURE"];
                    drv_lgf["TVA_ARTICLE"] = drv_repair["TVA_ARTICLE"];
                    drv_lgf["PRIX_HT_ARTICLE"] = drv_repair["PRIX_HT_ARTICLE"];
                    //drv_lgf["REMISE"] = drv_repair["REMISE"];
                    drv_lgf["PRIX_TOTAL_TTC"] = drv_repair["PRIX_TOTAL_TTC"];
                    drv_lgf["PRIX_TOTAL_HT"] = drv_repair["PRIX_TOTAL_HT"];
                    //drv_lgf["PRIX_FACTURE"] = drv_repair["PRIX_FACTURE"];                    
                    bs_lg_facture.EndEdit();
                    dt_lg_facture.AcceptChanges();
                }
                if ((decimal)(bs_br.Current as DataRowView)["QTE_BRETOUR_CLIENT"] > 1)
                    (bs_br.Current as DataRowView)["QTE_BRETOUR_CLIENT"] = (decimal)(bs_br.Current as DataRowView)["QTE_BRETOUR_CLIENT"] - 1;
                else
                    bs_br.RemoveCurrent();
                dt_br.AcceptChanges();
                calculerMontant();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void dgv_lg_facture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                bool exist = false;
                foreach (DataRowView drv_br in bs_br)
                {
                    if ((decimal)drv_br["CODE_ARTICLE"] == (decimal)(bs_lg_facture.Current as DataRowView)["CODE_ARTICLE"])
                    {
                        drv_br["QTE_BRETOUR_CLIENT"] = (decimal)drv_br["QTE_BRETOUR_CLIENT"] + 1;
                        dt_br.AcceptChanges();
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    bs_br.AddNew();
                    DataRowView drv_br = (DataRowView)bs_br.Current;
                    drv_br["CODE_ARTICLE"] = (bs_lg_facture.Current as DataRowView)["CODE_ARTICLE"];
                    drv_br["QTE_BRETOUR_CLIENT"] = 1;
                    drv_br["PRIX_BRETOUR_CLIENT"] = (bs_lg_facture.Current as DataRowView)["PRIX_U_TTC"];
                    drv_br["DESIGNATION_ARTICLE"] = (bs_lg_facture.Current as DataRowView)["DESIGNATION_ARTICLE"];
                    drv_br["REF_ARTICLE"] = (bs_lg_facture.Current as DataRowView)["REF_ARTICLE"];
                    bs_br.EndEdit();
                    dt_br.AcceptChanges();
                }
                if ((decimal)(bs_lg_facture.Current as DataRowView)["QTE"] > 1)
                {
                    DataRowView drv_lg_f_current = (DataRowView)bs_lg_facture.Current;
                    drv_lg_f_current["QTE"] = (decimal)drv_lg_f_current["QTE"] - 1;
                    bs_lg_facture.EndEdit();
                    dt_lg_facture.AcceptChanges();
                }
                else
                    bs_lg_facture.RemoveCurrent();
                calculerMontant();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void calculerMontant()
        {
            decimal somme = 0;
            foreach(DataRow dr in dt_br.Rows)
            {
                somme += (decimal)dr["QTE_BRETOUR_CLIENT"] * (decimal)dr["PRIX_BRETOUR_CLIENT"];
            }
            lb_mnt_retour.Text = somme.ToString();
        }

        private void btn_VALIDER_BRC_Click(object sender, EventArgs e)
        {
            //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
            CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
            try
            {
                if (dt_br.Rows.Count > 0)
                {
                    decimal mnt = Convert.ToDecimal(lb_mnt_retour.Text);
                    decimal mag = Convert.ToDecimal(dt_facture.Rows[0]["MAGASIN"].ToString());
                    //res = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.INSERT_BRETOUR_CLIENT(DateTime.Now, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), mnt, CODE_Facture.Text, mag, dt_br);
                    res = CLIENT_APP_PARAM.gcws.INSERT_BRETOUR_CLIENT(DateTime.Now, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), mnt, CODE_Facture.Text, mag, dt_br);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReportDocument rpt = new BON_RETOUR_CLIENT.CHM_TICKET_BON_RETOUR_CLIENT();
                        //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BRETOUR_CLIENT(res.CODE));
                        rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BRETOUR_CLIENT(res.CODE));
                        rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                        rpt.PrintToPrinter(1, true, 0, 0);
                        Close();
                    }
                }
                else
                    MessageBox.Show("Veuillez sélectionner les articles tout d'abord.", this.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(res.MESSAGE, this.Text);
            }
        }

        private void CHM_FRM_BON_RETOUR_CLIENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                if (btn_VALIDER_BRC.Enabled) btn_VALIDER_BRC.PerformClick();
            if (e.KeyCode == Keys.Escape)
                if (button5.Enabled) button5.PerformClick();
        }
    }
}