using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_FAMILLES_ART
{
    public partial class CHM_FRM_LISTE_FAMILLE : Form
    {
        public delegate void Selection(decimal codeFamille);
        public event Selection OnSelect;
        string Mode = string.Empty;
        BindingSource bs;

        public CHM_FRM_LISTE_FAMILLE(string mode)
        {
            InitializeComponent();
            bs = CLIENT_APP_PARAM.ds_param.bsFamille;
            gridControl1.DataSource = bs;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            Mode = mode;
            switch (Mode)
            {
                case "s":
                    chM_CMP_CONTROL1.btn_afficher.Visible = true;
                    chM_CMP_CONTROL1.btn_afficher.Text = "Sélectionner";
                    chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(OnSelectFamille);
                    break;
                case "l":
                    chM_CMP_CONTROL1.btn_afficher.Visible = false;
                    break;
            }
            
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
        }

        void OnSelectFamille(object sender, EventArgs e)
        {
            if(OnSelect!=null)
                OnSelect((decimal)(bs.Current as DataRowView)["CODE_FAMILLE"]);
            Close();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            CLIENT_APP_PARAM.ds_param.chargerFamilles();
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (bs.Current != null && MessageBox.Show("Etes vous sûres de supprimer la famille sélectionnée?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    
                    CHM_CLIENT_APP.CHM_FAMILLE_ARTICLE.RESULT_QUERY res = new CHM_CLIENT_APP.CHM_FAMILLE_ARTICLE.RESULT_QUERY();
                    res = CLIENT_APP_PARAM.gfamilleArticle.deleteFamille((decimal)((bs.Current as DataRowView)["CODE_FAMILLE"]));
                    if (res.OK)
                    {
                        CLIENT_APP_PARAM.ds_param.chargerFamilles();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text);
                }
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_FAMILLE f = new CHM_FRM_MAJ_FAMILLE(bs);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnMaj += new CHM_FRM_MAJ_FAMILLE.MAJ(f_OnMaj);
            f.ShowDialog();
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            (bs.Current as DataRowView)["CODE_FAMILLE"] = "-1";
            CHM_FRM_MAJ_FAMILLE f = new CHM_FRM_MAJ_FAMILLE(bs);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnMaj += new CHM_FRM_MAJ_FAMILLE.MAJ(f_OnMaj);
            f.ShowDialog();
        }

        void f_OnMaj(decimal codeFamArt)
        {
            
        }

        private void CHM_FRM_LISTE_FAMILLE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                if (entete_Formulaire_21.btn_refresh.Visible)
                    entete_Formulaire_21.btn_refresh.PerformClick();
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            switch (Mode)
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