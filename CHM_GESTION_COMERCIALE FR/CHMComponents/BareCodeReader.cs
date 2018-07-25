using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHMComponents
{
    public partial class BareCodeReader : UserControl
    {

        string _cb_art_selectionne = string.Empty;
        public delegate void CBRActions(string CodeABarre);
        public event CBRActions OnRead;

        public BareCodeReader()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox2.Select();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _cb_art_selectionne = textBox2.Text;
                textBox2.Text = "";
                timer1.Enabled = false; 
                if(OnRead!=null)
                    OnRead(_cb_art_selectionne);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
        }
    }
}
