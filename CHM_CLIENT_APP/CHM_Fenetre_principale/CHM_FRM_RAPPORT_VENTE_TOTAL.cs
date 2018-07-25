using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    public partial class CHM_FRM_RAPPORT_VENTE_TOTAL : Form
    {
        public CHM_FRM_RAPPORT_VENTE_TOTAL()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
                {
                    if (rd_detail.Checked)
                    {
                        ReportDocument rpt = new CHM_Fenetre_principale.CHM_LISTE_VENTE();
                        //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE(dtp_du.Value, dtp_au.Value));
                        rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE(dtp_du.Value, dtp_au.Value));

                        CHM_ETATS f = new CHM_ETATS();
                        f.CHM_Aperçu_document.ReportSource = rpt;
                        //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                        f.WindowState = FormWindowState.Maximized;
                        f.ShowDialog();
                    }
                }
                else
                {
                    if (rd_detail.Checked)
                    {
                        ReportDocument rpt = new CHM_ETAT.RPT_TOUS_LISTE_VENTE_A4();

                        //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE(dtp_du.Value, dtp_au.Value));
                        rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE(dtp_du.Value, dtp_au.Value));
                        if (dtp_du.Value.ToShortDateString() != dtp_au.Value.ToShortDateString())
                            rpt.SetParameterValue("date", "du :" + dtp_du.Value.ToShortDateString() + " au :" + dtp_au.Value.ToShortDateString());
                        if (dtp_du.Value.ToShortDateString() == dtp_au.Value.ToShortDateString())
                            rpt.SetParameterValue("date", "Date :" + dtp_du.Value.ToShortDateString());

                        rpt.SetParameterValue("user", "");

                        CHM_ETATS f = new CHM_ETATS();
                        f.CHM_Aperçu_document.ReportSource = rpt;
                        //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                        f.WindowState = FormWindowState.Maximized;
                        f.ShowDialog();
                    }
                    if (rd_groupe.Checked)
                    {
                        ReportDocument rpt = new CHM_Fenetre_principale.RPT_VENTE_TOTAL_PAR_FACTURE_PAR_DATE();

                        //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(dtp_du.Value, dtp_au.Value));
                        rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(dtp_du.Value, dtp_au.Value));
                        if (dtp_du.Value.ToShortDateString() != dtp_au.Value.ToShortDateString())
                            rpt.SetParameterValue("date_debut", "du :" + dtp_du.Value.ToShortDateString() + "  au :" + dtp_au.Value.ToShortDateString());
                        if (dtp_du.Value.ToShortDateString() == dtp_au.Value.ToShortDateString())
                            rpt.SetParameterValue("date_debut", "Date :" + dtp_du.Value.ToShortDateString());

                        CHM_ETATS f = new CHM_ETATS();
                        f.CHM_Aperçu_document.ReportSource = rpt;
                        //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                        f.WindowState = FormWindowState.Maximized;
                        f.ShowDialog();
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}