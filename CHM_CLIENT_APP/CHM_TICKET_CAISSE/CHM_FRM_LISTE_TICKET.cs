using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.CHM_TICKET_CAISSE
{
    public partial class CHM_FRM_LISTE_TICKET : Form
    {
        BindingSource bs = new BindingSource();
        ReportDocument rpt;
        public CHM_FRM_LISTE_TICKET()
        {
            InitializeComponent();
            bs.DataSource = dS_MOUV1.TICKET_CAISSE;
            gridControl1.DataSource = bs;

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            rpt = new CHM_RPT_TICKET_CAISSE();
            crv_TICKET.ReportSource = rpt;


            chM_CMP_CONTROL1.btn_afficher.Text = "Imprimer";
            chM_CMP_CONTROL1.btn_ajout.Text = "Facturer";
            chM_CMP_CONTROL1.btn_modifier.Visible = false;
            chM_CMP_CONTROL1.btn_supprimer.Visible = false;
        }

        void bs_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null)
                {
                    dS_MOUV1.LG_TC.Clear();
                    string code_tc = (bs.Current as DataRowView)["CODE_TC"].ToString();
                    dS_MOUV1.LG_TC.Merge(CLIENT_APP_PARAM.gcws.Get_Detail_TC(code_tc));

                    rpt.Refresh();
                    rpt.SetDataSource(dS_MOUV1);
                    crv_TICKET.RefreshReport();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            ChargerListeTicket();
        }

        private void ChargerListeTicket()
        {
            try
            {
                dS_MOUV1.TICKET_CAISSE.Clear();
                dS_MOUV1.TICKET_CAISSE.Merge(CLIENT_APP_PARAM.gcws.Select_All_TICKET_CAISSE());

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CHM_FRM_LISTE_TICKET_Load(object sender, EventArgs e)
        {
            ChargerListeTicket();
            bs.PositionChanged += new EventHandler(bs_PositionChanged);
            bs_PositionChanged(null, null);
        }

        private void CHM_FRM_LISTE_TICKET_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                ChargerListeTicket();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
