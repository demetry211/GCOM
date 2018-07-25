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
    public partial class CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET : Form
    {
        DataTable _dt_utilisateur;

        public CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET()
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (CLIENT_APP_PARAM.InvoicePrintOption == "Ticket")
            {
                if (rd_detail.Checked)
                {
                    ReportDocument rpt = new CHM_Fenetre_principale.CHM_LISTE_VENTE_PAR_UTILISATEUR();
                    //DataTable dt = CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue);
                    DataTable dt = CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue);
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));


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
                    ReportDocument rpt = new CHM_ETAT.RPT_TOUS_LISTE_VENTE_A4_PAR_UTILISATEUR();

                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    if (dtp_du.Value.ToShortDateString() != dtp_au.Value.ToShortDateString())
                        rpt.SetParameterValue("date", "du :" + dtp_du.Value.ToShortDateString() + "  au:" + dtp_au.Value.ToShortDateString());
                    if (dtp_du.Value.ToShortDateString() == dtp_au.Value.ToShortDateString())
                        rpt.SetParameterValue("date", "Date :" + dtp_du.Value.ToShortDateString());
                    

                    CHM_ETATS f = new CHM_ETATS();
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    f.WindowState = FormWindowState.Maximized;
                    f.ShowDialog();
                }
                if (rd_groupe.Checked)
                {
                    ReportDocument rpt = new CHM_Fenetre_principale.RPT_VENTE_TOTAL_PAR_FACTURE_PAR_DATE_PAR_UTILISATEUR();

                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE_PAR_UTILISATEUR(dtp_du.Value, dtp_au.Value, (decimal)cbx_utilisateur.SelectedValue));
                    if (dtp_du.Value.ToShortDateString() != dtp_au.Value.ToShortDateString())
                        rpt.SetParameterValue("date_debut", "Du :" + dtp_du.Value.ToShortDateString() + "  Au : " + dtp_au.Value.ToShortDateString());
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

        private void dtp_au_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rd_detail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_groupe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}