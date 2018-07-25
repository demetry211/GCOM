using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    public partial class CHM_FRM_QTE : Form
    {
        public delegate void valider_quantite(int num);
        public event valider_quantite _valider_quantite;

        public delegate void augmenter(int num);
        public event augmenter _augmenter_quantite;

        public delegate void diminuer(int num);
        public event diminuer _diminuer_quantite;

        string _codart = "";

        public CHM_FRM_QTE()
        {
            InitializeComponent();
            text_num.Text = "0";
        }

        public CHM_FRM_QTE(int num, string codart)
        {
            InitializeComponent();
            text_num.Text = num.ToString();
            _codart = codart;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_valider_quantite != null)
                _valider_quantite(Convert.ToInt32(text_num.Text));
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_num.Text = Convert.ToString(Convert.ToInt32(text_num.Text) + 1);
            if (_augmenter_quantite != null)
                _augmenter_quantite(Convert.ToInt32(text_num.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_num.Text = Convert.ToString(Convert.ToInt32(text_num.Text) - 1);
            if (_diminuer_quantite != null)
                _diminuer_quantite(Convert.ToInt32(text_num.Text));
        }


    }
}
