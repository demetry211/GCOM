using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.CHM_CLIENT
{
    public partial class CHM_FRM_LISTE_VEHICULE : Form
    {
        public delegate void Selection(decimal codeVehicule);
        public event Selection OnSelect;

        BindingSource bs = new BindingSource();
        string Mode = string.Empty;


        public CHM_FRM_LISTE_VEHICULE(string mode)
        {
            InitializeComponent();
            this.Mode = mode;
            bs.DataSource = dS_MOUV.V_VEHICULE;
            gridControl1.DataSource = bs;

            switch (Mode)
            {
                case "l":
                    chM_CMP_CONTROL1.btn_afficher.Text = "Afficher";
                    chM_CMP_CONTROL1.btn_afficher.Visible = false;
                    break;
                case "s":
                    chM_CMP_CONTROL1.btn_afficher.Text = "Sélectionner";
                    break;
            }

            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
            chargerListe();
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null && MessageBox.Show("Etes vous sûres de supprimer ce véhicule?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DVEHICULE vehicule = new DVEHICULE();
                    vehicule.CODE_VEHICULE = (decimal)(bs.Current as DataRowView)["CODE_VEHICULE"];
                    CHM_CLIENT_APP.CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                    res = CLIENT_APP_PARAM.gcws.effaceVEHICULE(vehicule);
                    if (res.OK)
                    {

                        bs.RemoveCurrent();
                        (bs.DataSource as DataTable).AcceptChanges();

                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_VEHICULE f = new CHM_FRM_MAJ_VEHICULE(bs);
            f.OnMaj += new CHM_FRM_MAJ_VEHICULE.MAJ(f_OnMaj);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            (bs.Current as DataRowView)["CODE_VEHICULE"] = -1;
            CHM_FRM_MAJ_VEHICULE f = new CHM_FRM_MAJ_VEHICULE(bs);
            f.OnMaj += new CHM_FRM_MAJ_VEHICULE.MAJ(f_OnMaj);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void f_OnMaj(decimal codeVehicule, bool ValidateChanges)
        {
            if (ValidateChanges)
            {
                bs.EndEdit();
                (bs.DataSource as DataTable).AcceptChanges();
            }
            else
            {
                bs.CancelEdit();
            }
        }

        private void chargerListe()
        {
            try
            {
                dS_MOUV.V_VEHICULE.Clear();
                dS_MOUV.V_VEHICULE.Merge(CLIENT_APP_PARAM.gcws.GetVEHICULE());

                
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            if (Mode == "s" && OnSelect != null && bs.Current != null)
            {
                OnSelect((decimal)((bs.Current as DataRowView)["CODE_VEHICULE"]));
            }
            Close();
        }
    }
}
