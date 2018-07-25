using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    public partial class Template_Liste_Facture_Ouverte : UserControl
    {
        int _nb_facture = 0;
        public Template_Liste_Facture_Ouverte()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Facture_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = _nb_facture.ToString();
            b.Name = _nb_facture.ToString();
            b.Size = new Size(70, 30);
            b.Location = new Point(_nb_facture * b.Width + 1, 1);
            b.Click += new EventHandler(b_Click);
            p_entete_facture.Controls.Add(b);

            Template_Vente tv = new Template_Vente();
            tv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tv.Name = _nb_facture.ToString();
            tv.Location = new Point(0, 0);
            tv.Height = p_liste_facture.Height;
            tv.Visible = true;
            p_liste_facture.Controls.Add(tv);

            b_Click(b, null);
            _nb_facture++;
        }

        void b_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in p_entete_facture.Controls)
            {
                if (ctrl.Name != (sender as Control).Name)
                    ctrl.BackColor = Color.Transparent;
                (sender as Control).BackColor = Color.OrangeRed;
            }

            foreach (Control c in p_liste_facture.Controls)
            {
                if (c.Name != (sender as Control).Name)
                    c.Visible = false;
            }
            p_liste_facture.Controls[(sender as Control).Name].Visible = true;
        }

        private void Template_Liste_Facture_Ouverte_Load(object sender, EventArgs e)
        {
            btn_ajouter_Facture.PerformClick();
        }
    }
}
