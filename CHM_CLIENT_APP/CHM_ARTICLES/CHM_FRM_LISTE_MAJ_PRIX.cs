using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    public partial class CHM_FRM_LISTE_MAJ_PRIX : Form
    {
        public CHM_FRM_LISTE_MAJ_PRIX()
        {
            InitializeComponent();
        }

        private void BTN_AJOUTER_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_PRIX f = new CHM_FRM_MAJ_PRIX();
            f.ShowDialog();
        }

        private void CHM_FRM_LISTE_MAJ_PRIX_Load(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void chargerListe()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DT_MAJ.Clear();
                DT_MAJ.Merge(CLIENT_APP_PARAM.gcws.selectAllMAJPrix());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BTN_MODIFIER_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_PRIX f = new CHM_FRM_MAJ_PRIX(Convert.ToDecimal(0));
            f.ShowDialog();
            chargerListe();
        }

        

        private void CHM_FRM_LISTE_MAJ_PRIX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                chargerListe();
        }
    }
}