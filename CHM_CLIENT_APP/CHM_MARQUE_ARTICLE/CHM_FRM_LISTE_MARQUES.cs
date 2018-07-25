using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_MARQUE_ARTICLE
{
    public partial class CHM_FRM_LISTE_MARQUES : Form
    {
        public delegate void SELECTION(decimal code);
        public event SELECTION OnSelect;
        private string mode;
        BindingSource bs;
        public CHM_FRM_LISTE_MARQUES(string mode)
        {


            InitializeComponent();
            //bs = CLIENT_APP_PARAM.ds_param.bsMarque;
            bs = new BindingSource();
            gridControl1.DataSource = bs;
            this.mode = mode;
            if (mode == "s")
            {
                chM_CMP_CONTROL1.btn_afficher.Visible = true;
                chM_CMP_CONTROL1.btn_afficher.Text = "Sélectionner";
                chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            }
            else
                chM_CMP_CONTROL1.btn_afficher.Visible = false;
            
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {

            if (bs.Current != null && MessageBox.Show("Etes vous sûres de supprimer cette marque?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DataRowView drv=(DataRowView)bs.Current;
                CHM_CLIENT_APP.CHMMARQUE.RESULT_QUERY res = new CHM_CLIENT_APP.CHMMARQUE.RESULT_QUERY();
                res = CLIENT_APP_PARAM.gmarque.deleteMarque((decimal)drv["CODE_MARQUE"]);
                if (res.OK)
                {
                    bs.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                }
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {                
                CHM_FRM_MAJ_MARQUE f = new CHM_FRM_MAJ_MARQUE(bs);
                f.ShowDialog();
            }
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            ((DataRowView)bs.Current)["CODE_MARQUE"] = -1;
            CHM_FRM_MAJ_MARQUE f = new CHM_FRM_MAJ_MARQUE(bs);
            f.ShowDialog();
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            if (mode == "s" )
            {
                if (bs.Current != null)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    if (OnSelect != null)
                        OnSelect((decimal)drv["CODE_MARQUE"]);
                    Close();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une marque");
                }
            }

        }

        private void charger_liste()
        {
            try
            {
                CLIENT_APP_PARAM.ds_param.chargerMarques();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void CHM_FRM_LISTE_MARQUES_Load(object sender, EventArgs e)
        {
            bs.DataSource = CLIENT_APP_PARAM.ds_param.MARQUE;
            
        }
        private void tdbg_liste_DoubleClick(object sender, EventArgs e)
        {

        }

        private void CHM_FRM_LISTE_MARQUES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                charger_liste();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "s":
                    chM_CMP_CONTROL1.btn_afficher.PerformClick();
                    break;
                case "l":
                    chM_CMP_CONTROL1.btn_modifier.PerformClick();
                    break;
            }
        }
    }
}