using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LIVRAISON_CLIENT : Form
    {
        string B_LIV = "-1";
        public CHM_LIVRAISON_CLIENT(string BON_DE_LIVRAISON)
        {
            InitializeComponent();
            this.B_LIV = BON_DE_LIVRAISON;
        }
        DataTable dt_b_liv;
        BindingSource bs_b_liv = new BindingSource();
        DataTable dt_employe;
        BindingSource bs_employer = new BindingSource();
        private void CHM_LIVRAISON_CLIENT_Shown(object sender, EventArgs e)
        {
            if (B_LIV != "-1")
            {
                //dt_b_liv = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_B_LIV_FACTURE(B_LIV);
                dt_b_liv = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_FACTURE(B_LIV);
                bs_b_liv.DataSource = dt_b_liv;
                dgv_LISTE_B_LIV.DataSource = bs_b_liv;
            }
            try
            {
                //dt_employe = CLIENT_APP_PARAM.GEST.P_EMPLOYE.SELECT_ALL_EMPLOYES();
                dt_employe = CLIENT_APP_PARAM.gcws.SELECT_ALL_EMPLOYES();
                bs_employer.DataSource = dt_employe;
                foreach (DataRowView drv in bs_employer)
                {
                    string emp = drv["NOM_EMPLOYE"].ToString() + drv["PRENOM_EMPLOYE"].ToString();
                    EMPLOYE.Items.Add(emp);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
