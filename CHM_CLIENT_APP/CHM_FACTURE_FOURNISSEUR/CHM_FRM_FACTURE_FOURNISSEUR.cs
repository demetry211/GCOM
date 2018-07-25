using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using System.Xml;

namespace CHM_CLIENT_APP.CHM_FACTURE_FOURNISSEUR
{
    public partial class CHM_FRM_FACTURE_FOURNISSEUR : Form
    {
        BindingSource bsFacture;
        BindingSource bsDetails;
        bool valide = false;
        DFACTURE_FOURNISSEUR facture=new DFACTURE_FOURNISSEUR();

        public delegate void FactFrnUse(DFACTURE_FOURNISSEUR fact, bool validation);
        public event FactFrnUse OnMaj;

        public CHM_FRM_FACTURE_FOURNISSEUR()
        {
            InitializeComponent();
            timbre.Value = Convert.ToDecimal(CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1).Replace(',', '.'));
            bsFacture = new BindingSource();
            bsFacture.DataSource = dS_MOUV1.V_FACTURE_FOURNISSEUR;
            

            bsDetails = new BindingSource();
            bsDetails.DataSource = dS_MOUV1.V_LG_FACT_FR;
            gridControl1.DataSource = bsDetails;

            txt_NUM_FACTURE.DataBindings.Add("Text", bsFacture, "CODE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACT_FR.DataBindings.Add("Text", bsFacture, "NUM_FACT_FR", true);
            txt_fournisseur.DataBindings.Add("Text", bsFacture, "RS_FOURNISSEUR", true);
            txt_fournisseur.DataBindings.Add("Tag", bsFacture, "CODE_FOURNISSEUR", true);
            txtAdresseFournisseur.DataBindings.Add("Text", bsFacture, "ADRESSE_FOURNISSEUR", true);
            txtCodeTvaFournisseur.DataBindings.Add("Text", bsFacture, "CODE_TVA_FOURNISSEUR", true);
            txtFaxFournisseur.DataBindings.Add("Text", bsFacture, "FAX_FOURNISSEUR", true);
            txtTelFournisseur.DataBindings.Add("Text", bsFacture, "TEL_FOURNISSEUR", true);
            dtp_DATE_FACTURE.DataBindings.Add("Value", bsFacture, "DATE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACT_FR.Enabled = true;
            bsFacture.AddNew();
            bsFacture_PositionChanged(null, null);

            chM_CMP_VALIDATION1.button1.Click += new EventHandler(Validation);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);
            chM_CMP_FICHE1.button1.Visible = false;
        }

        void btn_suivant_Click(object sender, EventArgs e)
        {
            bsFacture.MoveNext();
        }

        void btn_premier_Click(object sender, EventArgs e)
        {
            bsFacture.MoveFirst();
        }

        void btn_precedent_Click(object sender, EventArgs e)
        {
            bsFacture.MovePrevious();
        }

        void btn_dernier_Click(object sender, EventArgs e)
        {
            bsFacture.MoveLast();
        }

        

        

        public CHM_FRM_FACTURE_FOURNISSEUR(decimal CODE_FOURNISSEUR)
        {
            InitializeComponent();
            timbre.Value = Convert.ToDecimal(CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1).Replace(',', '.'));
            bsFacture = new BindingSource();
            bsFacture.DataSource = dS_MOUV1.V_FACTURE_FOURNISSEUR;
            bsFacture.AddNew();

            bsDetails = new BindingSource();
            bsDetails.DataSource = dS_MOUV1.V_LG_FACT_FR;
            gridControl1.DataSource = bsDetails;

            txt_NUM_FACTURE.DataBindings.Add("Text", bsFacture, "CODE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACT_FR.DataBindings.Add("Text", bsFacture, "NUM_FACT_FR", true);
            txt_fournisseur.DataBindings.Add("Text", bsFacture, "RS_FOURNISSEUR", true);
            txt_fournisseur.DataBindings.Add("Tag", bsFacture, "CODE_FOURNISSEUR", true);
            txtAdresseFournisseur.DataBindings.Add("Text", bsFacture, "ADRESSE_FOURNISSEUR", true);
            txtCodeTvaFournisseur.DataBindings.Add("Text", bsFacture, "CODE_TVA_FOURNISSEUR", true);
            txtFaxFournisseur.DataBindings.Add("Text", bsFacture, "FAX_FOURNISSEUR", true);
            txtTelFournisseur.DataBindings.Add("Text", bsFacture, "TEL_FOURNISSEUR", true);
            dtp_DATE_FACTURE.DataBindings.Add("Value", bsFacture, "DATE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACTURE.DataBindings.Add("Text", bsFacture, "CODE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACTURE.DataBindings.Add("Text", bsFacture, "CODE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACT_FR.Enabled = true;

            bsFacture_PositionChanged(null, null);
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(Validation);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);
            chM_CMP_FICHE1.button1.Visible = false;
        }

        public CHM_FRM_FACTURE_FOURNISSEUR(BindingSource bs)
        {
            InitializeComponent();
            timbre.Value = Convert.ToDecimal(CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1).Replace(',', '.'));

            bsFacture = bs;

            txt_NUM_FACTURE.DataBindings.Add("Text", bsFacture, "CODE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACT_FR.DataBindings.Add("Text", bsFacture, "NUM_FACT_FR", true);
            txt_fournisseur.DataBindings.Add("Text", bsFacture, "RS_FOURNISSEUR", true);
            txt_fournisseur.DataBindings.Add("Tag", bsFacture, "CODE_FOURNISSEUR", true);
            txtAdresseFournisseur.DataBindings.Add("Text", bsFacture, "ADRESSE_FOURNISSEUR", true);
            txtCodeTvaFournisseur.DataBindings.Add("Text", bsFacture, "CODE_TVA_FOURNISSEUR", true);
            txtFaxFournisseur.DataBindings.Add("Text", bsFacture, "FAX_FOURNISSEUR", true);
            txtTelFournisseur.DataBindings.Add("Text", bsFacture, "TEL_FOURNISSEUR", true);
            dtp_DATE_FACTURE.DataBindings.Add("Value", bsFacture, "DATE_FACTURE_FOURNISSEUR", true);
            txt_NUM_FACT_FR.Enabled = true ;

            
            bsFacture.PositionChanged += new EventHandler(bsFacture_PositionChanged);

            bsDetails = new BindingSource();
            bsDetails.DataSource = dS_MOUV1.V_LG_FACT_FR;
            gridControl1.DataSource = bsDetails;
            
            bsFacture_PositionChanged(null, null);

            
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(Validation);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);
            chM_CMP_FICHE1.button1.Visible = false;
        }

        void Fermeture(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        void Validation(object sender, EventArgs e)
        {
            #region Verification champs
            errorProvider1.SetError(txt_fournisseur, "");
            if(txt_fournisseur.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Veuillez sélectionner le fournisseur!", this.Text);
                errorProvider1.SetError(btn_SELECT_FOURNISSEUR, "Veuillez sélectionner le fournisseur!");
                btn_SELECT_FOURNISSEUR.Focus();
                return;
            }
            errorProvider1.Clear();


            errorProvider1.SetError(txt_NUM_FACT_FR, "");
            if (txt_NUM_FACT_FR.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez saisir le numéro facture du fournisseur!", this.Text);
                errorProvider1.SetError(txt_NUM_FACT_FR, "Veuillez saisir le numéro facture du fournisseur!");
                txt_NUM_FACT_FR.Focus();
                return;
            }
            errorProvider1.Clear();


            errorProvider1.SetError(txt_NUM_FACT_FR, "");
            decimal codeFrn = (decimal)txt_fournisseur.Tag;
            if (!CLIENT_APP_PARAM.gcws.VerifierNumFactFr(txt_NUM_FACTURE.Text ,txt_NUM_FACT_FR.Text, codeFrn))
            {
                MessageBox.Show("Numéro facture du fournisseur déja existant!", this.Text);
                errorProvider1.SetError(txt_NUM_FACT_FR, "Numéro facture du fournisseur déja existant!");
                txt_NUM_FACT_FR.Focus();
                txt_NUM_FACT_FR.SelectAll();
                return;
            }
            errorProvider1.Clear();

            #endregion

            facture = new DFACTURE_FOURNISSEUR();
            facture.NUM_FACT_FR = txt_NUM_FACT_FR.Text;
            facture.CODE_FOURNISSEUR = codeFrn;
            facture.USER_CREATION = Convert.ToDecimal( CLIENT_APP_PARAM.Fenetre_principale.code_user);
            facture.DATE_CREATION = CLIENT_APP_PARAM.gcws.getDateS();
            facture.DATE_FACTURE_FOURNISSEUR = dtp_DATE_FACTURE.Value;


            DataTable dtDetails = new DataTable("details");
            foreach (DataColumn dc in dS_MOUV1.V_LG_FACT_FR.Columns)
            {
                DataColumn newCol = new DataColumn();
                newCol.ColumnName = dc.ColumnName;
                newCol.DataType = dc.DataType;

                dtDetails.Columns.Add(newCol);
            }

            foreach (DataRow dr in dS_MOUV1.V_LG_FACT_FR.Rows)
            {
                dtDetails.ImportRow(dr);
            }

            RESULT_QUERY res = new RESULT_QUERY();
            if (txt_NUM_FACTURE.Text == string.Empty)
            {
                res = CLIENT_APP_PARAM.gcws.ajouteFACTURE_FOURNISSEUR(facture, dtDetails);
                if (res.OK)
                {
                    txt_NUM_FACTURE.Text = res.CODE;
                    MessageBox.Show(res.MESSAGE, this.Text);
                    valide = true;
                    Close();
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                    valide = false;
                    return;
                }
            }
            else
            {
                facture.CODE_FACTURE_FOURNISSEUR = txt_NUM_FACTURE.Text;
                facture.USER_MODIFICATION = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                facture.DATE_MODIFICATION = CLIENT_APP_PARAM.gcws.getDateS();
                res = CLIENT_APP_PARAM.gcws.modifieFACTURE_FOURNISSEUR(facture, dtDetails);
                if (res.OK)
                {
                    
                    MessageBox.Show(res.MESSAGE, this.Text);
                    valide = true;
                    Close();
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                    valide = false;
                    return;
                }
            }
        }

        void bsFacture_PositionChanged(object sender, EventArgs e)
        {
            try
            {                
                if (bsFacture.Current != null)
                {
                    DataRowView drv = (DataRowView)bsFacture.Current;
                    if (drv["CODE_FACTURE_FOURNISSEUR"].ToString().Trim() == string.Empty)
                        this.Text = entete_Formulaire_21.windows_name.Text = "Nouvelle facture d'achat";
                    else
                        this.Text = entete_Formulaire_21.windows_name.Text = string.Format("Facture d'achat N° {0}", drv["CODE_FACTURE_FOURNISSEUR"]);
                    dS_MOUV1.V_LG_FACT_FR.Clear();
                    dS_MOUV1.V_LG_FACT_FR.Merge(CLIENT_APP_PARAM.gcws.GetDetailsFACTURE_FOURNISSEUR(drv["CODE_FACTURE_FOURNISSEUR"].ToString()));
                    calculer_montant();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur lors du chargement des détails de la fatcure.\n{0}", er.Message), this.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_ARTICLE_FOURNISSEUR f = new CHM_ARTICLE_FOURNISSEUR();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.select_fournisseur_event += new CHM_ARTICLE_FOURNISSEUR.fournisseur_select(f_select_fournisseur_event);
                f.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
        }

        void f_select_fournisseur_event(DataRowView fournisseur)
        {
            try
            {
                txt_fournisseur.Text = (string)fournisseur["RS_FOURNISSEUR"];
                txt_fournisseur.Tag = (decimal)fournisseur["CODE_FOURNISSEUR"];
                txtAdresseFournisseur.Text = fournisseur["ADRESSE_FOURNISSEUR"].ToString();
                txtCodeTvaFournisseur.Text = fournisseur["CODE_TVA_FOURNISSEUR"].ToString();
                txtTelFournisseur.Text = fournisseur["TEL_FOURNISSEUR"].ToString();
                txtFaxFournisseur.Text = fournisseur["FAX_FOURNISSEUR"].ToString();

                chargerBRFR();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void chargerBRFR()
        {

            try
            {
                dS_MOUV1.V_LG_FACT_FR.Clear();
                chbx_BR.Items.Clear();
                chbx_BR.DataSource = CLIENT_APP_PARAM.gcws.SELECT_BR_FR_SansFactures(Convert.ToDecimal(txt_fournisseur.Tag));
                chbx_BR.DisplayMember = "CODE_BR_FR";
                chbx_BR.ValueMember = "CODE_BRECEP";
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur lors du chargement des Bons de livraison en instance du fournisseur {0}.\n{1}", txt_fournisseur.Text, er.Message), this.Text);
            }
        }

        private void CHM_FRM_FACTURE_FOURNISSEUR_Load(object sender, EventArgs e)
        {

        }

        private void chbx_BR_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            try
            {
                if (e.State == CheckState.Checked)
                {
                    decimal CODE_BRECEP = (decimal)(sender as DevExpress.XtraEditors.CheckedListBoxControl).SelectedValue;
                    DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_DETAILS_BR_FR_SansFactures(CODE_BRECEP);
                    foreach (DataRow dr in dt.Rows)
                    {
                        bsDetails.AddNew();
                        DataRowView drv = (DataRowView)bsDetails.Current;
                        drv["CODE_BR_FR"] = dr["CODE_BRECEP"];
                        drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drv["REF_ARTICLE"] = dr["REF_ARTICLE"];
                        drv["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                        drv["QTE"] = (decimal)dr["QTE"];
                        drv["PRIX_HT"] = dr["PRIX_ART_BR_FR"];
                        drv["UNITE"] = dr["UNITE"];
                        drv["TAUX_TVA"] = dr["TVA"];
                        drv["REMISE"] = dr["REMISE"];
                        drv["FODEC"] = dr["FODEC"];
                        drv["CODE_FACTURE_FOURNISSEUR"] = "";
                        drv["CODE_CMD_FR"] = dr["CODE_CMD_FR"];
                        drv["CODE_BR"] = dr["CODE_BR_FR"];
                        bsDetails.EndEdit();
                        (bsDetails.DataSource as DataTable).AcceptChanges();                        
                    }
                }
                else
                {
                    decimal CODE_BRECEP = (decimal)(sender as DevExpress.XtraEditors.CheckedListBoxControl).SelectedValue;
                    DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_DETAILS_BR_FR_SansFactures(CODE_BRECEP);

                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataRow drsource in dS_MOUV1.V_LG_FACT_FR.Rows)
                        {
                            if (drsource["CODE_BR_FR"].ToString() == dr["CODE_BRECEP"].ToString() && drsource["CODE_ARTICLE"].ToString() == dr["CODE_ARTICLE"].ToString())
                            {
                                dS_MOUV1.V_LG_FACT_FR.Rows.Remove(drsource);
                                dS_MOUV1.V_LG_FACT_FR.AcceptChanges();
                                break;
                            }
                        }
                    }


                }

                calculer_montant();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);

            }
        }

        private void calculer_montant()
        {

            try
            {
                Cursor = Cursors.WaitCursor;
                decimal somme = 0;
                decimal montant_tva = 0;
                decimal montant_ht = 0;
                decimal montant_ttc = 0;
                decimal montant_remise = 0;

                foreach (DataRow dr in dS_MOUV1.V_LG_FACT_FR.Rows)
                {
                    montant_tva += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"] * (1 - (decimal)dr["REMISE"] / 100) * (decimal)dr["TAUX_TVA"] / 100;
                    montant_ht += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"] * (1 + (decimal)dr["FODEC"]/100);
                    montant_remise += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"]*(1 + (decimal)dr["FODEC"] / 100) * (decimal)dr["REMISE"] / 100;
                    montant_ttc += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"] * (1 + (decimal)dr["FODEC"] / 100) * (1 - (decimal)dr["REMISE"] / 100) * (1 + (decimal)dr["TAUX_TVA"] / 100);
                }
                HT.Value = montant_ht;
                REMISE.Value = montant_remise;
                TVA.Value = montant_tva;
                ttc.Value = montant_ttc+ timbre.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void CHM_FRM_FACTURE_FOURNISSEUR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(OnMaj!=null)
                OnMaj(facture, valide);
            bsFacture.PositionChanged -= bsFacture_PositionChanged;
        }

        private void btnActualiserBR_Click(object sender, EventArgs e)
        {
            try
            {
                chbx_BR.Items.Clear();
                chbx_BR.DataSource = CLIENT_APP_PARAM.gcws.SELECT_BR_FR_SansFactures(Convert.ToDecimal(txt_fournisseur.Tag));
                chbx_BR.DisplayMember = "CODE_BR_FR";
                chbx_BR.ValueMember = "CODE_BRECEP";
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur lors du chargement des Bons de livraison en instance du fournisseur {0}.\n{1}", txt_fournisseur.Text, er.Message), this.Text);
            }
        }

    }
}
