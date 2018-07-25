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
    public partial class CHM_LISTE_BON_RETOUR_CLIENT : Form
    {
        DataTable dt_liste_br_cl;
        BindingSource bs_liste_br_cl = new BindingSource();
        public CHM_LISTE_BON_RETOUR_CLIENT()
        {
            InitializeComponent();
        }

        private void CHM_LISTE_BON_RETOUR_CLIENT_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            //dt_liste_br_cl = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.SELECT_ALL_BRETOUR_CLIENT();
            dt_liste_br_cl = CLIENT_APP_PARAM.gcws.SELECT_ALL_BRETOUR_CLIENT();
            bs_liste_br_cl.DataSource = dt_liste_br_cl;
            dataGridView1.DataSource = bs_liste_br_cl;
        }

        private void BTN_APERçU_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_liste_br_cl.Current != null)
                {
                    ReportDocument rpt = new BON_RETOUR_CLIENT.CHM_TICKET_BON_RETOUR_CLIENT();
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BRETOUR_CLIENT((bs_liste_br_cl.Current as DataRowView)["CODE_BRETOUR_CLIENT"].ToString()));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BRETOUR_CLIENT((bs_liste_br_cl.Current as DataRowView)["CODE_BRETOUR_CLIENT"].ToString()));
                    CHM_ETATS f = new CHM_ETATS();
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    f.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        private void BTN_AJOUTER_Click(object sender, EventArgs e)
        {
            BON_RETOUR_CLIENT.CHM_FRM_BON_RETOUR_CLIENT f = new CHM_CLIENT_APP.BON_RETOUR_CLIENT.CHM_FRM_BON_RETOUR_CLIENT();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            dataGridView1.AutoGenerateColumns = false;
            //dt_liste_br_cl = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.SELECT_ALL_BRETOUR_CLIENT();
            dt_liste_br_cl = CLIENT_APP_PARAM.gcws.SELECT_ALL_BRETOUR_CLIENT();
            bs_liste_br_cl.DataSource = dt_liste_br_cl;
            dataGridView1.DataSource = bs_liste_br_cl;
        }

        private void TB_RECHERCHE_TextChanged(object sender, EventArgs e)
        {
            if (TB_RECHERCHE.Text == "")
            {
                bs_liste_br_cl.DataSource = dt_liste_br_cl;
                dataGridView1.DataSource = bs_liste_br_cl;
            }
            else
            {
                dt_liste_br_cl.DefaultView.RowFilter = "CODE_BRETOUR_CLIENT like '%" + TB_RECHERCHE.Text + "%' OR CODE_FACTURE like '%" + TB_RECHERCHE.Text + "%'";
                DataTable dt = dt_liste_br_cl.DefaultView.ToTable();
                dt_liste_br_cl.DefaultView.RowFilter = "";
                bs_liste_br_cl.DataSource = dt;
                dataGridView1.DataSource = bs_liste_br_cl;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}