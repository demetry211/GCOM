using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_FACTURE
{
    public partial class CHM_SELECTION_FACTURE : Form
    {
        DataTable dt_facture;
        BindingSource bs_facture = new BindingSource();
        public delegate void Selection_Facture(string code_facture);
        public event Selection_Facture onSelect;

        public CHM_SELECTION_FACTURE()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CHM_SELECTION_FACTURE_Load(object sender, EventArgs e)
        {
            dgv_LISTE_FACTURE.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //Toute les factures
                //if (type == 1)
                //dt_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.SELECT_ALL_FACTURES();
                dt_facture = CLIENT_APP_PARAM.gcws.SELECT_ALL_FACTURES();
                //Les factures par utilisateur courant
                //if (type == 2)
                //    dt_facture = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.SELECT_FACTURE(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                //if (type == 3)
                //    dt_facture = CLIENT_APP_PARAM.GEST.P_CLIENT.select_facture(code);
                bs_facture.DataSource = dt_facture;
                dgv_LISTE_FACTURE.DataSource = bs_facture;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_selection_Click(object sender, EventArgs e)
        {
            if (bs_facture.Current != null)
            {
                if (onSelect != null)
                    onSelect((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString());
                Close();
            }
        }

        private void TB_RECHERCHE_TextChanged(object sender, EventArgs e)
        {
            if (TB_RECHERCHE.Text == "")
            {
                bs_facture.DataSource = dt_facture;
                dgv_LISTE_FACTURE.DataSource = bs_facture;
            }
            else
            {
                dt_facture.DefaultView.RowFilter = "(CODE_FACTURE like '%" + TB_RECHERCHE.Text + "%')";
                DataTable dt = dt_facture.DefaultView.ToTable();
                dt_facture.DefaultView.RowFilter = "";
                bs_facture.DataSource = dt;
                dgv_LISTE_FACTURE.DataSource = bs_facture;
            }
        }

        private void dgv_LISTE_FACTURE_DoubleClick(object sender, EventArgs e)
        {
            if (bs_facture.Current != null)
            {
                if (onSelect != null)
                    onSelect((((DataRowView)bs_facture.Current)["CODE_FACTURE"]).ToString());
                Close();
            }
        }
    }
}
