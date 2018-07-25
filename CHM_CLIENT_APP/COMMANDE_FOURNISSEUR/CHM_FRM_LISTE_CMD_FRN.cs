using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using CHM_CLIENT_APP.Properties;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.COMMANDE_FOURNISSEUR
{
    public partial class CHM_FRM_LISTE_CMD_FRN : Form
    {
        public CHM_FRM_LISTE_CMD_FRN instance;
        BindingSource bs = new BindingSource();



        public CHM_FRM_LISTE_CMD_FRN()
        {
            InitializeComponent();

            bs.DataSource = dS_MOUV1.V_CMD_FR;
            gridControl1.DataSource = bs;

            try
            {
                dS_MOUV1.SOCIETE.ImportRow(CLIENT_APP_PARAM.ds_param.SOCIETE.Rows[0]);
            }
            catch (Exception er)
            {
                MessageBox.Show("Paramètres société nom disponibles!", this.Text);
                Close();
            }
            chargerListe();


            bs.PositionChanged += new EventHandler(bs_PositionChanged);

            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Text = "Aperçu";
            chM_CMP_CONTROL1.btn_supprimer.Image = Resources.Preview_32x32;
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(PreviewCommande);
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            
        }

        void PreviewCommande(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null)
                {
                    ReportDocument rpt = new CHM_RPT_CMD_FR();
                    rpt.SetDataSource(dS_MOUV1);
                    rpt.SetParameterValue("entete", MessageBox.Show("Impression avec entête?", "Impression Commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes?true:false);


                    CHM_ETATS f = new CHM_ETATS();
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
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

        void bs_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    chargerDetails(drv["CODE_COMMANDE_FOURNISSEUR"].ToString());

                    if (drv["VALIDE"].ToString() == "True")
                    {
                        chM_CMP_CONTROL1.btn_modifier.Enabled = false;
                    }
                    else
                    {
                        chM_CMP_CONTROL1.btn_modifier.Enabled = true;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void chargerDetails(string codeCmd)
        {
            try
            {

                dS_MOUV1.V_LG_CMD_FR.Clear();
                dS_MOUV1.V_LG_CMD_FR.Merge(CLIENT_APP_PARAM.gcws.GetDetailCOMMANDE_FOURNISSEUR(codeCmd));
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_FRM_NV_CMD_FR f = new CHM_FRM_NV_CMD_FR(bs);
                f.OnMaj += new CHM_FRM_NV_CMD_FR.MAJ(f_OnMaj);
                f.chM_CMP_FICHE1.Visible = false;
                f.chM_CMP_VALIDATION1.Visible = true;
                f.ShowDialog();
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
                dS_MOUV1.V_CMD_FR.Clear();
                dS_MOUV1.V_CMD_FR.Merge(CLIENT_APP_PARAM.gcws.GetCOMMANDE_FOURNISSEUR());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {

            try
            {
                chbxEnAttente.Checked = true;
                bs.AddNew();
                CHM_FRM_NV_CMD_FR f = new CHM_FRM_NV_CMD_FR(bs);
                f.OnMaj += new CHM_FRM_NV_CMD_FR.MAJ(f_OnMaj);
                f.chM_CMP_FICHE1.Visible = false;
                f.chM_CMP_VALIDATION1.Visible = true;
                f.ShowDialog();
            }
            catch (Exception er)
            {
                bs.CancelEdit();
                (bs.DataSource as DataTable).RejectChanges();
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void f_OnMaj(string codeCMDFR, bool validateChanges)
        {

            if (validateChanges)
            {
                
                bs.EndEdit();
                (bs.DataSource as DataTable).AcceptChanges();
                chargerListe();
            }
            else
            {
                bs.CancelEdit();
                (bs.DataSource as DataTable).RejectChanges();
            }
            
        }



        void btn_afficher_Click(object sender, EventArgs e)
        {
            CHM_FRM_NV_CMD_FR f = new CHM_FRM_NV_CMD_FR(bs);
            f.chM_CMP_FICHE1.Visible = true;
            f.chM_CMP_FICHE1.button1.Visible = false;
            f.pEnteteCmd.Enabled = false;
            f.pMAJDetails.Visible = false;
            f.chM_CMP_VALIDATION1.Visible = false;
            f.ShowDialog();
        }

        public CHM_FRM_LISTE_CMD_FRN getInstance()
        {
            if (instance == null)
                instance = new CHM_FRM_LISTE_CMD_FRN();
            return instance;
        }

        private void CHM_FRM_LISTE_CMD_FRN_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    chargerListe();
                    break;
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {

                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    //decimal nbrArt = Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["NBR_ARTICLE"]));
                    //decimal nbrArtLivre = Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["NBR_ARTICLE_LIVRES"]));
                    //DateTime dateEcheance=Convert.ToDateTime(View.GetRowCellValue(e.RowHandle, View.Columns["DATE_EXPIRATION_COMMANDE_FOURNISSEUR"]));
                    string etat = View.GetRowCellValue(e.RowHandle, View.Columns["gridColumn1"]).ToString();

                    //if (nbrArtLivre < nbrArt && (dateEcheance.ToShortDateString()!="01/01/1900"? DateTime.Now>dateEcheance : true))
                    //{
                    //    e.Appearance.ForeColor = Color.Red;
                    //}

                    switch (etat)
                    {
                        case "Echue non livrée":
                            e.Appearance.BackColor2 = Color.Red;
                            break;
                        case "En attente de validation":
                            e.Appearance.ForeColor = Color.Gray;
                            break;
                        case "En attente de livraison":
                            e.Appearance.BackColor2 = Color.Yellow;
                            break;
                        case "Livrée":
                            e.Appearance.BackColor2 = Color.Green;
                            break;
                        case "Partiellement Livrée":
                            e.Appearance.BackColor2 = Color.LightBlue;
                            break;
                    }

                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxEnAttente.Checked)
            {
                gridView1.ActiveFilterString = "[VALIDE] = false";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxNonLivrees.Checked)
            {
                gridView1.ActiveFilterString = "[NBR_ARTICLE_LIVRES] < [NBR_ARTICLE] AND [VALIDE] = true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxToutes.Checked)
            {
                gridView1.ActiveFilterString = "";
            }
        }


    }
}
