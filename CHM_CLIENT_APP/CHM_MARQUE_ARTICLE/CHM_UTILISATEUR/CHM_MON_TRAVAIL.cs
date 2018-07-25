using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_MON_TRAVAIL : Form
    {
        public CHM_MON_TRAVAIL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CHM_LISTE_COMMANDE f = new CHM_LISTE_COMMANDE(2, "");
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CHM_LISTE_BONS_LIVRAISON f = new CHM_LISTE_BONS_LIVRAISON("7");
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CHM_LISTE_FACTURES f = new CHM_LISTE_FACTURES(2, "");
            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.Show();
        }
    }
}
