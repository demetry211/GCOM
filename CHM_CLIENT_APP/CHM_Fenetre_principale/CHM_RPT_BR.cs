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
    public partial class CHM_RPT_BR : Form
    {
        DataTable _dt_utilisateur;
        public CHM_RPT_BR()
        {
            InitializeComponent();
            //_dt_utilisateur = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.SELECT_ALL_NOM_UTILISATEUR();
            _dt_utilisateur = CLIENT_APP_PARAM.gcws.SELECT_ALL_NOM_UTILISATEUR();
            cbx_utilisateur.DataSource = _dt_utilisateur;
            cbx_utilisateur.DisplayMember = "NOM_UTILISATEUR";
            cbx_utilisateur.ValueMember = "CODE_USER";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
            {
                if (rd_detail.Checked)
                {
                    ReportDocument rpt = new BON_RETOUR_CLIENT.RPT_BR_CL_UTILISATEUR();
                    //DataTable dt = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue);
                    DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue);
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));


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
                    //DataTable dt = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue);
                    DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue);
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    if (dtp_du.Value == dtp_au.Value)
                    {
                        rpt.SetParameterValue("date", "Date : " + dtp_du.Value.ToShortDateString());
                    }
                    else
                    {
                        rpt.SetParameterValue("date", "Du : " + dtp_du.Value.ToShortDateString() + "Au : " + dtp_au.Value.ToShortDateString());
                    }
                    rpt.SetParameterValue("user", "Date : " + cbx_utilisateur.Text);

                    CHM_ETATS f = new CHM_ETATS();
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    f.WindowState = FormWindowState.Maximized;
                    f.ShowDialog();
                }
                if(rd_groupe.Checked)
                {

                }
            }
        }
    }
}