using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FRM_PASSWORD : Form
    {
        public bool authentified = false;
        public CHM_FRM_PASSWORD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == CLIENT_APP_PARAM.pwd_admin)
                {
                    authentified = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Mot de passe invalid");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CHM_FRM_PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
        }
    }
}