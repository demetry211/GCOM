using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_REGLEMENT
{
    public partial class CHM_FRM_REGLEMENT_CLIENT : Form
    {
        BindingSource bsListe = new BindingSource();
        public CHM_FRM_REGLEMENT_CLIENT()
        {
            InitializeComponent();
            bsListe.DataSource = dS_MOUV1.REGLEMENT_CLIENT;
            gridControl1.DataSource = bsListe;

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_afficher.Visible = false;
            chM_CMP_CONTROL1.btn_modifier.Visible = false;
            chM_CMP_CONTROL1.btn_supprimer.Visible = false;
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chargerLIste();
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT("-1");
            f.RightToLeft = RightToLeft.No;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            chargerLIste();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerLIste();
        }

        private void CHM_FRM_REGLEMENT_CLIENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                chargerLIste();
        }

        private void chargerLIste()
        {
            try
            {
                dS_MOUV1.REGLEMENT_CLIENT.Clear();
                dS_MOUV1.REGLEMENT_CLIENT.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_REGLEMENT());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }
    }
}
