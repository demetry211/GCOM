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
    public partial class CHM_RPT_BR_ALL : Form
    {
        public CHM_RPT_BR_ALL()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
            {
                if (rd_detail.Checked)
                {
                    ReportDocument rpt = new BON_RETOUR_CLIENT.CHM_RPT_LISTE_BR_CL();
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE(dtp_du.Value, dtp_au.Value));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE(dtp_du.Value, dtp_au.Value));

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
                    ReportDocument rpt = new CHM_ETAT.RPT_BON_RETOUR_A4();
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE(dtp_du.Value, dtp_au.Value));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE(dtp_du.Value, dtp_au.Value));
                    if (dtp_du.Value == dtp_au.Value)
                    {
                        rpt.SetParameterValue("date", "Date: " + dtp_du.Value.ToShortDateString());
                    }
                    else
                    {
                        rpt.SetParameterValue("date", "Du : " + dtp_du.Value.ToShortDateString() + "Au : " + dtp_au.Value.ToShortDateString());
                    }
                    rpt.SetParameterValue("user", "" );

                    CHM_ETATS f = new CHM_ETATS();
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    f.WindowState = FormWindowState.Maximized;
                    f.ShowDialog();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}