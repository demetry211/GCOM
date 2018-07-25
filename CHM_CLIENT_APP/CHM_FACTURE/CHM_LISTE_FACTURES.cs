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
    public partial class CHM_LISTE_FACTURES : Form
    {
        int type = 1;
        string code = "";
        public CHM_LISTE_FACTURES(int type, string code)
        {
            InitializeComponent();
            this.type = type;
            this.code = code;
            bs_facture = new BindingSource();
            bs_facture.DataSource = dataSet11.FACTURE;
            gridControl1.DataSource = bs_facture;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                chargerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable dt_facture;
        BindingSource bs_facture ;
        private void CHM_LISTE_FACTURES_Shown(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                chargerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chargerFacture()
        {
            dataSet11.FACTURE.Clear();
            //Toute les factures
            if (type == 1)
                dataSet11.FACTURE.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_FACTURES());
            //Les factures par utilisateur courant
            if (type == 2)
                dataSet11.FACTURE.Merge(  CLIENT_APP_PARAM.gcws.SELECT_FACTURE(CLIENT_APP_PARAM.Fenetre_principale.code_user));
            if (type == 3)
                dataSet11.FACTURE.Merge( CLIENT_APP_PARAM.gcws.select_facture(code));
        }

        private void dgv_LISTE_FACTURE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bs_facture.Current != null)
            {
                CHM_FICHE_FACTURE_CLIENT f = new CHM_FICHE_FACTURE_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString());
                f.RightToLeft = RightToLeft.No;
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void TB_RECHERCHE_TextChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bs_facture.Current != null)
            {
                CHM_FICHE_FACTURE_CLIENT f = new CHM_FICHE_FACTURE_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString());
                f.RightToLeft = RightToLeft.No;
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

        private void BTN_REGELEMENT_Click(object sender, EventArgs e)
        {
            if (bs_facture.Current != null)
            {
                if ((decimal)(bs_facture.Current as DataRowView)["CREDIT"] >= 0)
                {
                    CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString());
                    f.ShowDialog();
                    CHM_LISTE_FACTURES_Shown(null, null);
                }
                else
                {
                    MessageBox.Show("Cette facture est déja payée.", "Reglement de facture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void BTN_APERçU_Click(object sender, EventArgs e)
        {
            if (bs_facture.Current != null)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    ReportDocument rpt = new ReportDocument();
                    if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
                    {
                        rpt = new CHM_FACTURE.CHM_FACTURE_TICKET_CLIENT();
                        //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.ImprimerTICET_FACTURE_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString()));
                        rpt.SetDataSource(CLIENT_APP_PARAM.gcws.ImprimerTICET_FACTURE_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString()));
                    }
                    else
                    {
                        rpt = new CHM_FACTURE.CHM_RPT_FACTURE();
                        rpt.SetDataSource(CLIENT_APP_PARAM.gcws.Imprimer_FACTURE_CLIENT((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString()));
                        rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
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
            else
            {
                MessageBox.Show("Veuillez sélectionner la facture à visualiser", "Aperçu facture", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTN_AJOUTER_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_FACTURE.CHM_FRM_NV_FACTURE fiche = new CHM_CLIENT_APP.CHM_FACTURE.CHM_FRM_NV_FACTURE(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                fiche.WindowState = FormWindowState.Maximized;
                fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                fiche.OnSave += new CHM_CLIENT_APP.CHM_FACTURE.CHM_FRM_NV_FACTURE.ENREGISTREMENT(fiche_OnSave);
                fiche.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void fiche_OnSave(string codeFacture)
        {
            chargerFacture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                chargerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHM_LISTE_FACTURES_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Application.DoEvents();
                chargerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gridView1.ViewCaption = "Liste des factures de vente";
            gridView1.OptionsView.ShowViewCaption = true;
            gridControl1.ViewCollection[0].ShowPrintPreview();
            gridView1.OptionsView.ShowViewCaption = false;
        }
    }
}
