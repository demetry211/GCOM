using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON;
using CHM_CLIENT_APP.CHM_FACTURE;

namespace CHM_CLIENT_APP
{
    public partial class Fiche_b_liv : Form
    {
        string CODE_B_LIV = "";
        string CODE_CLIENT = "";
        decimal _CODE_MAG;
        public Fiche_b_liv(string CODE)
        {
            InitializeComponent();
            this.CODE_B_LIV = CODE;
        }
        DataTable dt_b_liv;
        BindingSource bs_b_liv = new BindingSource();
        DataTable dt_lg_b_liv;
        BindingSource bs_lg_b_liv = new BindingSource();
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();
        private void Fiche_Commande_Shown(object sender, EventArgs e)
        {
            dgv_lg_b_liv.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();

                //dt_lg_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LG_B_LIV(CODE_B_LIV);
                dt_lg_b_liv = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(CODE_B_LIV);
                bs_lg_b_liv.DataSource = dt_lg_b_liv;
                dgv_lg_b_liv.DataSource = bs_lg_b_liv;
                Application.DoEvents();
                //dt_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_B_LIV_FACTURE(CODE_B_LIV);
                dt_b_liv = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_FACTURE(CODE_B_LIV);
                bs_b_liv.DataSource = dt_b_liv;
                DataRowView drv_b_liv = (DataRowView)bs_b_liv.Current;
                CODE_B_LIV_.Text = drv_b_liv["CODE_B_LIV"].ToString();
                DATE_B_LIV.Text = drv_b_liv["DATE_B_LIV"].ToString();
                CODE_COMMANDE.Text = drv_b_liv["CODE_COMMANDE"].ToString();
                _CODE_MAG = (decimal)drv_b_liv["CODE_MAG"];
                lb_mag.Text = drv_b_liv["NOM_MAG"].ToString();
                if ((bool)drv_b_liv["PREPARED"] == true)
                    PREPARED.CheckState = CheckState.Checked;
                else
                    PREPARED.CheckState = CheckState.Unchecked;
                if ((bool)drv_b_liv["FACTURED"] == true)
                {
                    FACTURED.CheckState = CheckState.Checked;
                    BTN_FACTURATION.Enabled = false;
                }
                else
                {
                    FACTURED.CheckState = CheckState.Unchecked;
                    BTN_FACTURATION.Enabled = true;
                }
                if ((bool)drv_b_liv["LIVRE"] == true)
                    LIVRED.CheckState = CheckState.Checked;
                else
                    LIVRED.CheckState = CheckState.Unchecked;
                CODE_CLIENT = drv_b_liv["CODE_CLIENT"].ToString();
                //dt_client = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                bs_client.DataSource = dt_client;
                DataRowView drv_client = (DataRowView)bs_client.Current;
                REF_CLIENT.Text = drv_client["REF_CLIENT"].ToString();
                RS_CLIENT.Text = drv_client["RS_CLIENT"].ToString();
                ADRESSE_CLIENT.Text = drv_client["ADRESSE_CLIENT"].ToString() + " " + drv_client["CP_CLIENT"].ToString();
                TEL_CLIENT.Text = drv_client["TEL_CLIENT"].ToString();
                calculerBonLivraison();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_FACTURATION_Click(object sender, EventArgs e)
        {
            //CHM_FICHE_FACTURE fiche = new CHM_FICHE_FACTURE(CODE_B_LIV_.Text);
            //fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            //fiche.WindowState = FormWindowState.Maximized;
            //fiche.RightToLeft = RightToLeft.No;
            //fiche.Show();
            CHM_FRM_NV_FACTURE f = new CHM_FRM_NV_FACTURE(CODE_B_LIV, _CODE_MAG);
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculerBonLivraison()
        {
            decimal montant_ht = 0;
            decimal montant_remise = 0;
            decimal montant_tva = 0;
            decimal montant_ttc = 0;
            for (int i = 0; i < dt_lg_b_liv.Rows.Count; i++)
            {
                montant_ht += (decimal)dt_lg_b_liv.Rows[i]["PRIX_TOTAL_HT"];
                montant_ttc += (decimal)dt_lg_b_liv.Rows[i]["PRIX_TOTAL_TTC"];
                montant_remise += (decimal)dt_lg_b_liv.Rows[i]["QTE_LIGNE_B_LIV"] * (decimal)dt_lg_b_liv.Rows[i]["PRIX_HT_B_LIV"] * (decimal)dt_lg_b_liv.Rows[i]["REMISE"] / 100;
                montant_tva += (decimal)dt_lg_b_liv.Rows[i]["QTE_LIGNE_B_LIV"] * ((decimal)dt_lg_b_liv.Rows[i]["PRIX_HT_B_LIV"] - (decimal)dt_lg_b_liv.Rows[i]["PRIX_HT_B_LIV"] * (decimal)dt_lg_b_liv.Rows[i]["REMISE"] / 100) * (decimal)dt_lg_b_liv.Rows[i]["TVA_B_LIV"] / 100;
            }
            NP.Value = montant_ht;
            lbn_total_remise.Value = montant_remise;
            lbn_TauxTVA.Value = montant_tva;
            lbn_total_ttc.Value = montant_ttc;
        }

        private void BTN_APERçU_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                    
                    DataTable dt = CLIENT_APP_PARAM.gcws.Imprimer_BL(CODE_B_LIV);
                    decimal montant_ht = 0;
                    decimal montant_remise = 0;
                    decimal montant_tva = 0;
                    decimal montant_ttc = 0;
                    for (int i = 0; i < dt_lg_b_liv.Rows.Count; i++)
                    {
                        montant_ht += (decimal)dt_lg_b_liv.Rows[i]["PRIX_TOTAL_HT"];
                        montant_ttc += (decimal)dt_lg_b_liv.Rows[i]["PRIX_TOTAL_TTC"];
                        montant_remise += (decimal)dt_lg_b_liv.Rows[i]["QTE_LIGNE_B_LIV"] * (decimal)dt_lg_b_liv.Rows[i]["PRIX_HT_B_LIV"] * (decimal)dt_lg_b_liv.Rows[i]["REMISE"] / 100;
                        montant_tva += (decimal)dt_lg_b_liv.Rows[i]["QTE_LIGNE_B_LIV"] * ((decimal)dt_lg_b_liv.Rows[i]["PRIX_HT_B_LIV"] - (decimal)dt_lg_b_liv.Rows[i]["PRIX_HT_B_LIV"] * (decimal)dt_lg_b_liv.Rows[i]["REMISE"] / 100) * (decimal)dt_lg_b_liv.Rows[i]["TVA_B_LIV"] / 100;
                    }

                    RPT_B_LIV rpt = new RPT_B_LIV();
                    rpt.SetDataSource(dt);
                    rpt.SetParameterValue("mnt_HT", montant_ht.ToString("#,##0"));
                    rpt.SetParameterValue("Total_Remise", montant_remise.ToString("#,0###"));
                    rpt.SetParameterValue("Total_TVA", montant_tva.ToString("#,0##"));
                    rpt.SetParameterValue("Montant_TTC", montant_ttc.ToString("#,0##"));
                    //rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                    //rpt.PrintToPrinter(1, true, 1, 1);

                    CHM_ETATS etat = new CHM_ETATS();
                    etat.CHM_Aperçu_document.ReportSource = rpt;
                    etat.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    etat.WindowState = FormWindowState.Maximized;
                    etat.Show();
                
            }
            catch (Exception er)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Fiche_b_liv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12) if (BTN_FACTURATION.Enabled) BTN_FACTURATION.PerformClick();
            if (e.KeyCode == Keys.F8) if (BTN_APERçU.Enabled) BTN_APERçU.PerformClick();
        }

    }
}
