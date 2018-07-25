using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    public partial class CHM_FRM_ABOUT : Form
    {
        public CHM_FRM_ABOUT()
        {
            InitializeComponent();
        }

        private void CHM_FRM_ABOUT_Load(object sender, EventArgs e)
        {
            License.License license = new License.License();
            //DataTable dt = CLIENT_APP_PARAM.GEST.P_FACTURE.SELECT_ALL_FACTURES();
            DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_FACTURES();
            if (license.license_type != "O")
            {
                lb_license.Text = license.nb.ToString() + "Factures";
            }
            else
            {
                lb_license.Text = "Version Complète";
            }
        }
    }
}