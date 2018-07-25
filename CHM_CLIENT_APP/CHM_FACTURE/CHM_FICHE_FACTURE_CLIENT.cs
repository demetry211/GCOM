using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CHM_CLIENT_APP.CHM_FACTURE;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_FACTURE_CLIENT : Form
    {
        string CODE_FACTURE_ = "";
        string CODE_CLIENT = "";
        DataTable dt_facture;
        BindingSource bs_facture = new BindingSource();
        DataTable dt_lg_facture;
        BindingSource bs_lg_facture = new BindingSource();
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();

        public CHM_FICHE_FACTURE_CLIENT(string CODE_FACTURE)
        {
            InitializeComponent();
            this.CODE_FACTURE_ = CODE_FACTURE;
        }
        private void CHM_FICHE_FACTURE_CLIENT_Shown(object sender, EventArgs e)
        {
            try
            {
                dgv_lg_facture.AutoGenerateColumns = false;
                Application.DoEvents();

                //dt_lg_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LIGNES_FACTURE(CODE_FACTURE_);
                dt_lg_facture = CLIENT_APP_PARAM.gcws.LOAD_LIGNES_FACTURE(CODE_FACTURE_);
                bs_lg_facture.DataSource = dt_lg_facture;
                dgv_lg_facture.DataSource = bs_lg_facture;

                Application.DoEvents();

                //dt_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_FACTURE_PAR_CODE(CODE_FACTURE_);
                dt_facture = CLIENT_APP_PARAM.gcws.LOAD_FACTURE_PAR_CODE(CODE_FACTURE_);
                bs_facture.DataSource = dt_facture;
                DataRowView drv_facture = (DataRowView)bs_facture.Current;
                CODE_Facture.Text = drv_facture["CODE_FACTURE"].ToString();
                DATE_FACTURE.Value = (DateTime)drv_facture["DATE_FACTURE"];
                ETAT_REGLEMENT.Text = drv_facture["REGLER"].ToString();
                HT.Value = (decimal)drv_facture["MONTANT_HT_FACTURE"];
                TAUX_REMISE.Value = (decimal)drv_facture["TAUX_REMISE"];
                TVA.Value = (decimal)drv_facture["MONTANT_TVA"];
                TTC.Value = (decimal)drv_facture["MONTANT_TTC"];
                TIMBRE.Value = (decimal)drv_facture["TIMBRE_FACTURE"];
                NP.Value = (decimal)drv_facture["MONTANT_TOTAL_FACTURE"];
                ML.Text = "Arreter la prÃ©sente facture Ã  la somme de " + drv_facture["MONTANT_LETTRE"].ToString();
                remarq.Text = "Remarque :" + drv_facture["REMARQUE"].ToString();
                if ((bool)drv_facture["ANNULATION_FACTURE"] == true)
                    ANNULATION.CheckState = CheckState.Checked;
                else
                    ANNULATION.CheckState = CheckState.Unchecked;
                CREDIT.Text = drv_facture["CREDIT"].ToString();
                if ((decimal)drv_facture["CREDIT"] <= 0)
                    BTN_REGELEMENT.Enabled = false;
                else
                    BTN_REGELEMENT.Enabled = true;

                //Une facture en cours de reglement ne peut pas etre annulÃ©e
                if ((decimal)drv_facture["CREDIT"] < (decimal)drv_facture["MONTANT_TTC"])
                    button2.Enabled = false;
                else
                    button2.Enabled = true;

                CODE_CLIENT = drv_facture["CODE_CLIENT"].ToString();
                //dt_client = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                bs_client.DataSource = dt_client;
                DataRowView drv_client = (DataRowView)bs_client.Current;
                REF_CLIENT.Text = drv_client["REF_CLIENT"].ToString();
                RS_CLIENT.Text = drv_client["RS_CLIENT"].ToString();
                ADRESSE_CLIENT.Text = drv_client["ADRESSE_CLIENT"].ToString() + " " + drv_client["CP_CLIENT"].ToString();
                TEL_CLIENT.Text = drv_client["TEL_CLIENT"].ToString();

                calculerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTN_REGELEMENT_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT(CODE_Facture.Text);
                f.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_lg_facture.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();

                //dt_lg_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_LIGNES_FACTURE(CODE_FACTURE_);
                dt_lg_facture = CLIENT_APP_PARAM.gcws.LOAD_LIGNES_FACTURE(CODE_FACTURE_);
                bs_lg_facture.DataSource = dt_lg_facture;
                dgv_lg_facture.DataSource = bs_lg_facture;

                Application.DoEvents();

                //dt_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_FACTURE_PAR_CODE(CODE_FACTURE_);
                dt_facture = CLIENT_APP_PARAM.gcws.LOAD_FACTURE_PAR_CODE(CODE_FACTURE_);
                bs_facture.DataSource = dt_facture;
                DataRowView drv_facture = (DataRowView)bs_facture.Current;
                CODE_Facture.Text = drv_facture["CODE_FACTURE"].ToString();
                DATE_FACTURE.Value = (DateTime)drv_facture["DATE_FACTURE"];
                ETAT_REGLEMENT.Text = drv_facture["REGLER"].ToString();
                HT.Value = (decimal)drv_facture["MONTANT_HT_FACTURE"];
                TAUX_REMISE.Value = (decimal)drv_facture["TAUX_REMISE"];
                TVA.Value = (decimal)drv_facture["MONTANT_TVA"];
                TTC.Value = (decimal)drv_facture["MONTANT_TTC"];
                TIMBRE.Value = (decimal)drv_facture["TIMBRE_FACTURE"];
                NP.Value = (decimal)drv_facture["MONTANT_TOTAL_FACTURE"];
                ML.Text = "Arreter la prÃ©sente facture Ã  la somme de " + drv_facture["MONTANT_LETTRE"].ToString();
                remarq.Text = "Remarque :" + drv_facture["REMARQUE"].ToString();
                if ((bool)drv_facture["ANNULATION_FACTURE"] == true)
                    ANNULATION.CheckState = CheckState.Checked;
                else
                    ANNULATION.CheckState = CheckState.Unchecked;

                CREDIT.Text = drv_facture["CREDIT"].ToString();

                if ((decimal)drv_facture["CREDIT"] <= 0)
                    BTN_REGELEMENT.Enabled = false;
                else
                    BTN_REGELEMENT.Enabled = true;
                //Une facture en cours de reglement ne peut pas etre annulÃ©e
                if ((decimal)drv_facture["CREDIT"] < (decimal)drv_facture["MONTANT_TTC"])
                    button2.Enabled = false;
                else
                    button2.Enabled = true;

                CODE_CLIENT = drv_facture["CODE_CLIENT"].ToString();
                //dt_client = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                bs_client.DataSource = dt_client;
                DataRowView drv_client = (DataRowView)bs_client.Current;
                REF_CLIENT.Text = drv_client["REF_CLIENT"].ToString();
                RS_CLIENT.Text = drv_client["RS_CLIENT"].ToString();
                ADRESSE_CLIENT.Text = drv_client["ADRESSE_CLIENT"].ToString() + " " + drv_client["CP_CLIENT"].ToString();
                TEL_CLIENT.Text = drv_client["TEL_CLIENT"].ToString();

                calculerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouler vous vraiment annuler cette facture?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    //CLIENT_APP_PARAM.GEST.P_FACTURE.CANCEL_FACTURE(CODE_FACTURE_);
                    CLIENT_APP_PARAM.gcws.CANCEL_FACTURE_CLIENT(CODE_FACTURE_);
                    button1.PerformClick();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculerLigneBL()
        {
            try
            {
                if (bs_lg_facture.Current != null)
                {
                    DataRowView drv_edit = (DataRowView)bs_lg_facture.Current;
                    drv_edit.BeginEdit();


                    drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)drv_edit["PRIX_HT_B_LIV"];

                    drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                    drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                    drv_edit.EndEdit();
                    dt_lg_facture.AcceptChanges();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void calculerFacture()
        {
            decimal montant_ht = 0;
            decimal montant_remise = 0;
            decimal montant_tva = 0;
            decimal montant_ttc = 0;
            for (int i = 0; i < dt_lg_facture.Rows.Count; i++)
            {
                montant_ht += (decimal)dt_lg_facture.Rows[i]["PRIX_TOTAL_HT"];
                montant_ttc += (decimal)dt_lg_facture.Rows[i]["PRIX_TOTAL_TTC"];
                montant_remise += (decimal)dt_lg_facture.Rows[i]["QTE"] * (decimal)dt_lg_facture.Rows[i]["PRIX_HT_ARTICLE"] * (decimal)dt_lg_facture.Rows[i]["REMISE"] / 100;
                montant_tva += (decimal)dt_lg_facture.Rows[i]["QTE"] * ((decimal)dt_lg_facture.Rows[i]["PRIX_HT_ARTICLE"] - (decimal)dt_lg_facture.Rows[i]["PRIX_HT_ARTICLE"] * (decimal)dt_lg_facture.Rows[i]["REMISE"] / 100) * (decimal)dt_lg_facture.Rows[i]["TVA_ARTICLE"] / 100;
            }
            HT.Value = montant_ht;
            TAUX_REMISE.Value = montant_remise;
            TVA.Value = montant_tva;
            TTC.Value = montant_ttc;
            NP.Value = montant_ttc + TIMBRE.Value;
        }

        public void BTN_APERçU_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ReportDocument rpt = new ReportDocument();
                if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
                {
                    rpt = new CHM_FACTURE.CHM_FACTURE_TICKET_CLIENT();
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.ImprimerTICET_FACTURE_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString()));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.ImprimerTICET_FACTURE_CLIENT(CODE_FACTURE_));
                }
                else
                {
                    rpt = new CHM_FACTURE.CHM_RPT_FACTURE();
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.Imprimer_FACTURE_CLIENT(CODE_FACTURE_));
                    rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                }
                CHM_ETATS f = new CHM_ETATS();
                f.CHM_Aperçu_document.ReportSource = rpt;
                f.WindowState = FormWindowState.Maximized;
                this.Cursor = Cursors.Default;
                f.ShowDialog();
            }
            catch (Exception er)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

    }
}
