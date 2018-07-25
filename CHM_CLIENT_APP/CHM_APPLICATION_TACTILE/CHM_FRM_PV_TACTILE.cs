using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    public partial class CHM_FRM_PV_TACTILE : Form
    {
        Point location ;

        public CHM_FRM_PV_TACTILE()
        {
            InitializeComponent();
            location = new Point(0, 0);
        }

        private void CHM_FRM_PV_TACTILE_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.Text = textBox1.Text;
            lb.Location = location;
            location = new Point(location.X, location.Y + 15);
            textBox1.Text = "";
            textBox1.Select();
            timer1.Enabled = false;
            panel1.Controls.Add(lb);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
