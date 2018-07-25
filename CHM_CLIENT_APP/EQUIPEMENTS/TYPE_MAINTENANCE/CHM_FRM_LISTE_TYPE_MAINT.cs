using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE
{
    public partial class CHM_FRM_LISTE_TYPE_MAINT : Form
    {
        BindingSource bsList;
        string mode = "";
        public delegate void selection(DTYPE_MAINTENANCE maint);
        public event selection OnSelect;
        public CHM_FRM_LISTE_TYPE_MAINT(string mode)
        {
            InitializeComponent();
            bsList = new BindingSource();
            bsList.DataSource = dS_MOUV1.V_TYPE_MAINTENANCE;
            this.mode = mode;
            chargerListe();
            if (mode == "s")
            {
                chM_CMP_CONTROL1.btn_afficher.Visible = true;
                chM_CMP_CONTROL1.btn_afficher.Text = "Sélectionner";
                chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            }
            else
            {
                chM_CMP_CONTROL1.btn_afficher.Visible = false;
            }
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerListe();
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            if (bsList.Current != null)
            {
                DataRowView drv = (DataRowView)bsList.Current;
                if (OnSelect != null)
                {
                    DTYPE_MAINTENANCE typeMnt = new DTYPE_MAINTENANCE();
                    typeMnt.CODE_TYPE_MNT = (int)drv["CODE_TYPE_MNT"];
                    OnSelect(typeMnt);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un Type de maintenance!", this.Text);
            }
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (bsList.Current != null)
            {
                if(MessageBox.Show("Etes vous sûres de supprimer ce type de maintenance!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                    try
                    {
                        DTYPE_MAINTENANCE typeMnt = new DTYPE_MAINTENANCE();
                        typeMnt.CODE_TYPE_MNT = (int)((DataRowView)bsList.Current)["CODE_TYPE_MNT"];
                        CLIENT_APP_PARAM.gcws.effaceTYPE_MAINTENANCE(typeMnt);
                        chargerListe();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, this.Text);
                    }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type de maintenance tout d'abord!", this.Text);
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            if (bsList.Current != null)
            {
                CHM_FRM_MAJ_TYPE_MAINT f = new CHM_FRM_MAJ_TYPE_MAINT(bsList);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.OnMAJ += new CHM_FRM_MAJ_TYPE_MAINT.MajTypeMaint(f_OnMAJ);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Veuillez sélectionner un type de maintenance tout d'abord!", this.Text);
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bsList.AddNew();
            ((DataRowView)bsList.Current)["CODE_TYPE_MNT"] = "-1";
            CHM_FRM_MAJ_TYPE_MAINT f = new CHM_FRM_MAJ_TYPE_MAINT(bsList);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnMAJ += new CHM_FRM_MAJ_TYPE_MAINT.MajTypeMaint(f_OnMAJ);
            f.ShowDialog();
        }

        void f_OnMAJ(DTYPE_MAINTENANCE typeMaint, bool valid)
        {
            if (valid)
            {
                

                bsList.EndEdit();
                (bsList.DataSource as DataTable).AcceptChanges();
            }
            else
            {
                bsList.CancelEdit();
                (bsList.DataSource as DataTable).RejectChanges();
            }
        }

        private void chargerListe()
        {
            try
            {
                dS_MOUV1.V_TYPE_MAINTENANCE.Clear();
                dS_MOUV1.V_TYPE_MAINTENANCE.Merge(CLIENT_APP_PARAM.gcws.GetTYPE_MAINTENANCE());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (mode == "s")
                chM_CMP_CONTROL1.btn_afficher.PerformClick();
            else
                chM_CMP_CONTROL1.btn_modifier.PerformClick();
        }

        private void CHM_FRM_LISTE_TYPE_MAINT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                entete_Formulaire_21.btn_refresh.PerformClick();
        }
    }
}
