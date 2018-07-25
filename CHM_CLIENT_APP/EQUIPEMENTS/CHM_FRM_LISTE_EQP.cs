using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.EQUIPEMENTS
{
    public partial class CHM_FRM_LISTE_EQP : Form
    {
        BindingSource bsListe;

        public delegate void Selection(DEQUIPEMENT eqp);
        public event Selection OnSelect;

        DS_MOUV dsImpressionFiche = new DS_MOUV();

        public CHM_FRM_LISTE_EQP()
        {
            InitializeComponent();
            bsListe = new BindingSource();
            bsListe.DataSource = dS_MOUV1.V_EQUIPEMENT;
            gridControl1.DataSource = bsListe;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chargerListe();

            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);

            bsListe.PositionChanged += new EventHandler(bsListe_PositionChanged);
        }

        void bsListe_PositionChanged(object sender, EventArgs e)
        {

        }

        private void chargerFI_EQP(decimal p)
        {
            try
            {
                dsImpressionFiche.Clear();
                dsImpressionFiche.V_EQUIPEMENT.ImportRow(dS_MOUV1.V_EQUIPEMENT.Select("CODE_EQP='" + p + "'")[0]);
                dsImpressionFiche.V_FICHE_INTERVENTION.Merge(CLIENT_APP_PARAM.gcws.GetFICHE_INTERVENTION_PAR_EQUIPEMENT(p));
                foreach (DataRow dr in dsImpressionFiche.V_FICHE_INTERVENTION.Rows)
                {
                    DFICHE_INTERVENTION fiche = new DFICHE_INTERVENTION();
                    fiche.NUM_FI = dr["NUM_FI"].ToString();
                    fiche = CLIENT_APP_PARAM.gcws.obtenirInstanceFICHE_INTERVENTION(fiche);

                    

                    foreach (DARTICLE article in fiche.DETAIL)
                    {
                        DataRow newdr = dsImpressionFiche.LG_FI.NewRow();
                        newdr["NUM_FI"] = fiche.NUM_FI;
                        newdr["REF_ARTICLE"] = article.REF_ARTICLE;
                        newdr["CODE_ARTICLE"] = article.CODE_ARTICLE;
                        newdr["DESIGNATION_ARTICLE"] = article.DESIGNATION_ARTICLE;
                        newdr["LIB_UNITE"] = article.UNITE_QTE_ARTICLE;
                        newdr["QTE_FI"] = article.QTE_ARTICLE;
                        newdr["TVA_FI"] = article.TVA_ARTICLE;
                        newdr["P_HT_FI"] = article.PRIX_HT_V_ARTICLE;
                        newdr["REMISE_FI"] = article.MAX_REMISE;


                        dsImpressionFiche.LG_FI.AddLG_FIRow((DS_MOUV.LG_FIRow)newdr);
                    }
                }

            }
            catch (Exception er)
            {

                throw er;
            }
        }

        public CHM_FRM_LISTE_EQP(string mode)
        {
            InitializeComponent();
            bsListe = new BindingSource();
            bsListe.DataSource = dS_MOUV1.V_EQUIPEMENT;
            gridControl1.DataSource = bsListe;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chargerListe();

            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
            gridView1.DoubleClick += new EventHandler(SelectEqp);
        }

        void SelectEqp(object sender, EventArgs e)
        {
            if (OnSelect != null && bsListe.Current != null)
            {
                DataRowView drv = (DataRowView)bsListe.Current;
                DEQUIPEMENT eqp = new DEQUIPEMENT();
                eqp.CODE_EQP = (decimal)drv["CODE_EQP"];
                eqp = CLIENT_APP_PARAM.gcws.obtenirInstanceEQUIPEMENT(eqp);
                OnSelect(eqp);
                Close();
            }
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (bsListe.Current != null && MessageBox.Show("Etes vous sûres de supprimer l'équipement sélectionné?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)bsListe.Current;
                DEQUIPEMENT eqp = new DEQUIPEMENT();
                eqp.CODE_EQP = (decimal)drv["CODE_EQP"];

                try
                {
                    CLIENT_APP_PARAM.gcws.effaceEQUIPEMENT(eqp);
                    MessageBox.Show("Equipement supprimé.", this.Text);
                    chargerListe();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Erreur lors de la suppression de l'équipement", this.Text);
                }
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            CHM_FRM_EQP f = new CHM_FRM_EQP(bsListe);
            f.pClient.Enabled = true;
            f.pEqp.Enabled = true;
            f.chM_CMP_FICHE1.Visible = false;
            f.chM_CMP_VALIDATION1.Visible = true;
            f.OnMaj += new CHM_FRM_EQP.Equipement(f_OnMaj);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            CHM_FRM_EQP f = new CHM_FRM_EQP();
            f.pClient.Enabled = true;
            f.pEqp.Enabled = true;
            f.chM_CMP_FICHE1.Visible = false;
            f.chM_CMP_VALIDATION1.Visible = true;
            f.OnMaj += new CHM_FRM_EQP.Equipement(f_OnMaj);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            CHM_FRM_EQP f = new CHM_FRM_EQP(bsListe);
            f.pClient.Enabled = false;
            f.pEqp.Enabled = false;
            f.chM_CMP_FICHE1.Visible = true;
            f.chM_CMP_VALIDATION1.Visible = false;

            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void f_OnMaj(CHM_CLIENT_APP.CHMGC.DEQUIPEMENT eqp, bool validation)
        {
            if (validation)
                chargerListe();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void chargerListe()
        {
            try
            {
                dS_MOUV1.V_EQUIPEMENT.Clear();
                dS_MOUV1.V_EQUIPEMENT.Merge(CLIENT_APP_PARAM.gcws.GetEQUIPEMENT());
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur lors du chargement des équipements.\n{0}", er.Message), this.Text);
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            gridView1.ViewCaption = "Liste des équipement";
            gridView1.OptionsView.ShowViewCaption = true;
            gridControl1.ViewCollection[0].ShowPrintPreview();
            gridView1.OptionsView.ShowViewCaption = false;
        }

        private void chM_BUTTON1_Click(object sender, EventArgs e)
        {
            if (bsListe.Current != null)
            {
                DataRowView drv = (DataRowView)bsListe.Current;
                chargerFI_EQP((decimal)drv["CODE_EQP"]);

                CHM_RPT_FICHE_SUIVEUSE_EQP rpt = new CHM_RPT_FICHE_SUIVEUSE_EQP();
                rpt.SetDataSource(dsImpressionFiche);
                CHM_ETATS f = new CHM_ETATS();
                f.CHM_Aperçu_document.ReportSource = rpt;
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
                
            }
            
        }
    }
}
