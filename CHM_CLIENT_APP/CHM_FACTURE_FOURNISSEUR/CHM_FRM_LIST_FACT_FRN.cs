using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.Properties;
using DevExpress.XtraPrinting;
using DevExpress.Utils;

namespace CHM_CLIENT_APP.CHM_FACTURE_FOURNISSEUR
{
    public partial class CHM_FRM_LIST_FACT_FRN : Form
    {
        BindingSource bsListe;
        public CHM_FRM_LIST_FACT_FRN()
        {
            InitializeComponent();
            bsListe = new BindingSource();
            bsListe.DataSource = dS_MOUV1.V_FACTURE_FOURNISSEUR;
            gridControl1.DataSource = bsListe;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chargerListe();
            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Text = "Aperçu";
            chM_CMP_CONTROL1.btn_supprimer.Image = Resources.Preview_32x32;
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(previewListe);
            bsListe.PositionChanged += new EventHandler(bsListe_PositionChanged);
            bsListe_PositionChanged(null, null);
            gridView1.OptionsView.ShowViewCaption = false;
        }

        void previewListe(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowViewCaption = true;
            colUSER_CREATION.Visible = false;
            colUTILISATEUR_CREATION.Visible = false;
            colUTILISATEUR_MODIFICATION.Visible = false;
            colDATE_MODIFICATION.Visible = false;
            colANNULEE.Visible = false;
            gridControl1.ViewCollection[0].ShowPrintPreview();
            gridView1.OptionsView.ShowViewCaption = false;
            colUSER_CREATION.Visible = true;
            colUTILISATEUR_CREATION.Visible = true;
            colUTILISATEUR_MODIFICATION.Visible = true;
            colDATE_MODIFICATION.Visible = true;
            colANNULEE.Visible = true;
        }

        void bsListe_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (bsListe.Current != null)
                {
                    DataRowView drv = (DataRowView)bsListe.Current;
                    
                    dS_MOUV1.V_LG_FACT_FR.Clear();
                    dS_MOUV1.V_LG_FACT_FR.Merge(CLIENT_APP_PARAM.gcws.GetDetailsFACTURE_FOURNISSEUR(drv["CODE_FACTURE_FOURNISSEUR"].ToString()));
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur lors du chargement des détails de la fatcure.\n{0}", er.Message), this.Text);
            }
        }

        

        void btn_modifier_Click(object sender, EventArgs e)
        {
            CHM_FRM_FACTURE_FOURNISSEUR f = new CHM_FRM_FACTURE_FOURNISSEUR(bsListe);
            f.pBR.Visible = true;
            f.chM_CMP_VALIDATION1.Visible = true;
            f.pEntFac.Enabled = true;
            f.pFrn.Enabled = true;
            f.chM_CMP_FICHE1.Visible = false;
            f.OnMaj += new CHM_FRM_FACTURE_FOURNISSEUR.FactFrnUse(f_OnMaj);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            CHM_FRM_FACTURE_FOURNISSEUR f = new CHM_FRM_FACTURE_FOURNISSEUR();
            f.pBR.Visible = true;
            f.chM_CMP_VALIDATION1.Visible = true;
            f.pEntFac.Enabled = true;
            f.pFrn.Enabled = true;
            f.chM_CMP_FICHE1.Visible = false;
            f.OnMaj += new CHM_FRM_FACTURE_FOURNISSEUR.FactFrnUse(f_OnMaj);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void f_OnMaj(CHM_CLIENT_APP.CHMGC.DFACTURE_FOURNISSEUR fact, bool validation)
        {
            if (validation)
            {
                chargerListe();
            }
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            CHM_FRM_FACTURE_FOURNISSEUR f = new CHM_FRM_FACTURE_FOURNISSEUR(bsListe);
            f.pBR.Visible = false;
            f.chM_CMP_VALIDATION1.Visible = false;
            f.pEntFac.Enabled = false;
            f.pFrn.Enabled = false;
            f.chM_CMP_FICHE1.Visible = true;
            f.StartPosition = FormStartPosition.CenterScreen;
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
                dS_MOUV1.V_FACTURE_FOURNISSEUR.Clear();
                dS_MOUV1.V_FACTURE_FOURNISSEUR.Merge(CLIENT_APP_PARAM.gcws.GetFACTURE_FOURNISSEUR());
            }
            catch (Exception er)
            {
                MessageBox.Show("Erreur lors du chargement des factures fournisseurs.\nVeuillez vérifier votre connexion au serveur et si le problème persiste contacter votre Fournisseur Produit.", this.Text);
            }
        }

        private void CHM_FRM_LIST_FACT_FRN_Load(object sender, EventArgs e)
        {

        }
    }
}
