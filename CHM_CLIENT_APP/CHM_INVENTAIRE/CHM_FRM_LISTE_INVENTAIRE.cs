using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_INVENTAIRE
{
    public partial class CHM_FRM_LISTE_INVENTAIRE : Form
    {
        public CHM_FRM_LISTE_INVENTAIRE()
        {
            InitializeComponent();
        }

        private void CHM_FRM_LISTE_INVENTAIRE_Load(object sender, EventArgs e)
        {
            try
            {
                dS_MOUV1.INVENTAIRE.Clear();
                dS_MOUV1.INVENTAIRE.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_INVENTAIRE());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }
    }
}
