using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.FICHE_INTERVENTION
{
    public partial class CHM_FRM_LISTE_FI : Form
    {
        BindingSource bs = new BindingSource();
        
        public CHM_FRM_LISTE_FI()
        {
            InitializeComponent();
            bs.DataSource = dS_MOUV1.V_FICHE_INTERVENTION;
            gridControl1.DataSource = bs;

            chargerListe();
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);

            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);


            bs.PositionChanged += new EventHandler(bs_PositionChanged);
            bs_PositionChanged(null, null);
        }

        void bs_PositionChanged(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                DFICHE_INTERVENTION fiche = new DFICHE_INTERVENTION();
                fiche.NUM_FI = drv["NUM_FI"].ToString();
                fiche = CLIENT_APP_PARAM.gcws.obtenirInstanceFICHE_INTERVENTION(fiche);

                dS_MOUV1.LG_FI.Clear();

                foreach (DARTICLE article in fiche.DETAIL)
                {
                    DataRow dr = dS_MOUV1.LG_FI.NewRow();
                    dr["NUM_FI"] = fiche.NUM_FI;
                    dr["REF_ARTICLE"] = article.REF_ARTICLE;
                    dr["CODE_ARTICLE"] = article.CODE_ARTICLE;
                    dr["DESIGNATION_ARTICLE"] = article.DESIGNATION_ARTICLE;
                    dr["LIB_UNITE"] = article.UNITE_QTE_ARTICLE;
                    dr["QTE_FI"] = article.QTE_ARTICLE;
                    dr["TVA_FI"] = article.TVA_ARTICLE;
                    dr["P_HT_FI"] = article.PRIX_HT_V_ARTICLE;
                    dr["REMISE_FI"] = article.MAX_REMISE;


                    dS_MOUV1.LG_FI.AddLG_FIRow((DS_MOUV.LG_FIRow)dr);

                }
            }
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_FI f = new CHM_FRM_MAJ_FI(bs);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnMaj += new CHM_FRM_MAJ_FI.MAJ(f_OnMaj);
            f.chM_CMP_FICHE1.Visible = false;
            f.ShowDialog();
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bs.AddNew();

            CHM_FRM_MAJ_FI f = new CHM_FRM_MAJ_FI(bs);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnMaj += new CHM_FRM_MAJ_FI.MAJ(f_OnMaj);
            f.chM_CMP_FICHE1.Visible = false;
            f.ShowDialog();
        }

        void f_OnMaj(string NumFi, bool validateChanges)
        {
            if (validateChanges)
            {
                bs.EndEdit();
                (bs.DataSource as DataTable).AcceptChanges();
            }
            else
            {
                bs.CancelEdit();
                (bs.DataSource as DataTable).RejectChanges();
            }
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_FI f = new CHM_FRM_MAJ_FI(bs);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnMaj += new CHM_FRM_MAJ_FI.MAJ(f_OnMaj);
            f.chM_CMP_VALIDATION1.Visible = false;
            f.pEqp.Enabled = false;
            f.pArticle.Visible = false;
            f.pFI.Enabled = false;
            f.ShowDialog();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void chargerListe()
        {
            try
            {
                dS_MOUV1.V_FICHE_INTERVENTION.Clear();
                dS_MOUV1.V_FICHE_INTERVENTION.Merge(CLIENT_APP_PARAM.gcws.GetFICHE_INTERVENTION());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        private void CHM_FRM_LISTE_FI_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    chargerListe();
                    break;
            }
        }
    }
}
