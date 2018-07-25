using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using CrystalDecisions.CrystalReports.Engine;
using CHM_CLIENT_APP.Properties;

namespace CHM_CLIENT_APP.CHM_DEVI
{
    public partial class CHM_FRM_LISTE_DEVIS : Form
    {
        BindingSource bsListe;

        public CHM_FRM_LISTE_DEVIS()
        {
            InitializeComponent();
            bsListe = new BindingSource();
            bsListe.DataSource = dS_MOUV1.V_DC;
            gridControl1.DataSource = bsListe;
            chargerListe();
            dS_MOUV1.SOCIETE.ImportRow(CLIENT_APP_PARAM.ds_param.SOCIETE.Rows[0]);

            bsListe.PositionChanged += new EventHandler(bsListe_PositionChanged);
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);

            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_afficher.Text = "Aperçu";
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_modifier.Text = "Détails";
            chM_CMP_CONTROL1.btn_modifier.Image = Resources.demande_afficher_la_liste_icone_8709_32;
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (bsListe.Current != null)
            {
                DataRowView drv = (DataRowView)bsListe.Current;
                if ((decimal)drv["NB_IMPRIME"] > 0)
                    MessageBox.Show("Ce Devis ne peut pas être supprimé!");
                else
                {
                    try
                    {
                        DDEVIS_CLIENT devis = new DDEVIS_CLIENT();
                        devis.CODE_DC = drv["CODE_DC"].ToString();
                        CLIENT_APP_PARAM.gcws.effaceDEVIS_CLIENT(devis);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            if (bsListe.Current != null)
            {
                DataRowView drv = (DataRowView)bsListe.Current;
                CHM_NV_DEVI f = new CHM_NV_DEVI(bsListe);
                f.chM_CMP_FICHE1.Visible = true;
                f.chM_CMP_VALIDATION1.Visible = false;
                f.p_control.Visible = false;
                f.OnMaj += new CHM_NV_DEVI.MAJ(f_OnMaj);
                f.StartPosition = FormStartPosition.CenterScreen;
                //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.ShowDialog();  
            }
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bsListe.AddNew();
            CHM_NV_DEVI f = new CHM_NV_DEVI(bsListe);
            f.OnMaj += new CHM_NV_DEVI.MAJ(f_OnMaj);
            f.chM_CMP_FICHE1.Visible = false;
            f.StartPosition = FormStartPosition.CenterScreen;
            //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            f.ShowDialog();   
        }

        void f_OnMaj(string CODE_DC, bool validateChanges)
        {
            if (validateChanges)
            {
                bsListe.EndEdit();
                (bsListe.DataSource as DataTable).AcceptChanges();
            }
            else
            {
                bsListe.CancelEdit();
                (bsListe.DataSource as DataTable).RejectChanges();
            }
            chargerListe();
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsListe.Current != null)
                {
                    DataRowView drv = (DataRowView)bsListe.Current;
                    CHM_ETATS f = new CHM_ETATS();
                    f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;


                    ReportDocument rpt = new CHM_RPT_DEVI_CLIENT();
                    rpt.SetDataSource(dS_MOUV1);                    
                    decimal netAPaye = 0;
                    foreach (DataRow dr in dS_MOUV1.V_LG_DC.Rows)
                    {
                        netAPaye += (decimal)dr["TOTAL_TTC"];
                    }
                    netAPaye += Convert.ToDecimal(CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1).Replace(',', '.'));
                    rpt.SetParameterValue("montantLettre", new NUM_TO_LETTRE.NumberToLetter().ConvertirDinars(netAPaye));
                    if (MessageBox.Show("Aperçu avec entete?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        rpt.SetParameterValue("entete", true);
                    else
                        rpt.SetParameterValue("entete", false);
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    f.Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerListe();
        }

        void bsListe_PositionChanged(object sender, EventArgs e)
        {
            if (bsListe.Current != null)
            {
                chargerDetails();
            }
        }

        private void chargerDetails()
        {
            try
            {
                DataRowView drv = (DataRowView)bsListe.Current;
                dS_MOUV1.V_LG_DC.Clear();
                dS_MOUV1.V_LG_DC.Merge(CLIENT_APP_PARAM.gcws.GetDETAILS_DEVIS_CLIENT(drv["CODE_DC"].ToString()));
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }


        private void chargerListe()
        {
            try
            {
                dS_MOUV1.V_DC.Clear();
                dS_MOUV1.V_DC.Merge(CLIENT_APP_PARAM.gcws.GetDEVIS_CLIENT());
                bsListe_PositionChanged(null, null);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }

        }

        private void CHM_FRM_LISTE_DEVIS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                chargerListe();
        }
    }
}
