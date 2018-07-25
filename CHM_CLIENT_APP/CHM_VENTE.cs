using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_VENTE : Form
    {
        public CHM_VENTE()
        {
            InitializeComponent();
        }
        int visiblite_panel_client = 0;
        private void BTN_CLIENTS_Click(object sender, EventArgs e)
        {
            CLIENT_PANEL.Visible = true;
            visiblite_panel_client = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
