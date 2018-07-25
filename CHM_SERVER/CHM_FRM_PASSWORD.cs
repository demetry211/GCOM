using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_SERVER
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
                if (textBox1.Text == CONNECTION_PARAM.pwd_admin)
                {
                    authentified = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}