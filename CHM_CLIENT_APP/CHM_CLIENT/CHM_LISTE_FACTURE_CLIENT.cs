using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_FACTURE_CLIENT : Form
    {
        public delegate void selection_deleg(DataRowView facture);
        public event selection_deleg selection_event;
        string CODE_CLIENT = "-1";
        public CHM_LISTE_FACTURE_CLIENT(string CODE_CLIENT)
        {
            InitializeComponent();
            this.CODE_CLIENT = CODE_CLIENT;
        }

        private void dgv_LISTE_FACTURE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bs.Current != null && CODE_CLIENT != "-1")
            {
                DataRowView drv = (DataRowView)bs.Current;
                if (selection_event != null)
                    selection_event(drv);
                this.Close();
            }
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        private void CHM_LISTE_FACTURE_CLIENT_Shown(object sender, EventArgs e)
        {
            dgv_LISTE_FACTURE.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_CLIENT.select_facture(CODE_CLIENT);
                dt = CLIENT_APP_PARAM.gcws.select_facture(CODE_CLIENT);
                bs.DataSource = dt;
                dgv_LISTE_FACTURE.DataSource = bs;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_RECHERCHE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TB_RECHERCHE.Text == "")
                {
                    dt = CLIENT_APP_PARAM.gcws.select_facture(CODE_CLIENT);
                    bs.DataSource = dt;
                    dgv_LISTE_FACTURE.DataSource = bs;
                }
                else
                {
                    dt.DefaultView.RowFilter = "CODE_FACTURE like '%" + TB_RECHERCHE.Text + "%'";
                    DataTable dt_recherche = dt.DefaultView.ToTable();
                    bs.DataSource = dt_recherche;
                    dgv_LISTE_FACTURE.DataSource = bs;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
