using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.COMMANDE_FOURNISSEUR
{
    public partial class CHM_FRM_NV_CMD_FR : Form
    {
        decimal _code_fournisseur;
        private BindingSource bsDetails;
        private BindingSource bsCommande;
        bool ValidateChanges = false;

        public delegate void MAJ(string codeCMDFR, bool validateChanges);
        public event MAJ OnMaj;

        public CHM_FRM_NV_CMD_FR(BindingSource bsCmd)
        {
            InitializeComponent();
            CHM_GESTION_CONTROL.chargerComboMagazin(cbx_magazin);
            if (CLIENT_APP_PARAM.CODE_MAG.Trim() != "") cbx_magazin.SelectedValue = CLIENT_APP_PARAM.CODE_MAG;
            //c1TrueDBDropdown1.DataSource = CLIENT_APP_PARAM.ds_param.V_ARTICLE;
            //this.bsCommande = new BindingSource();
            this.bsCommande = bsCmd;

            bsDetails = new BindingSource();
            bsDetails.DataSource = dS_MOUV1.V_LG_CMD_FR;
            gridControl1.DataSource = bsDetails;
            try
            {
                this.cbx_magazin.DataBindings.Add("SelectedValue", bsCommande, "CODE_MAG", true);
                this.txt_ADRESSE_LIVRAISON.DataBindings.Add("Text", bsCommande, "ADRESSE_LIVRAISON", true);
                this.txt_CONTACT.DataBindings.Add("Text", bsCommande, "CONTACT", true);
                this.txt_fournisseur.DataBindings.Add("Text", bsCommande, "RS_FOURNISSEUR", true);
                txt_fournisseur.DataBindings.Add("Tag", bsCommande, "CODE_FOURNISSEUR", true);
                this.txt_REMARQUE.DataBindings.Add("Text", bsCommande, "REMARQUE", true);
                this.txt_TEL_CONTACT.DataBindings.Add("Text", bsCommande, "TEL_CONTACT", true);
                this.dtp_DATE_COMMANDE.DataBindings.Add("Value", bsCommande, "DATE_COMMANDE_FOURNISSEUR", true);
                this.dtp_DATE_EXPIRATION.DataBindings.Add("Value", bsCommande, "DATE_EXPIRATION_COMMANDE_FOURNISSEUR", true);
                txt_NUM_COMMANDE.DataBindings.Add("Text", bsCommande, "CODE_COMMANDE_FOURNISSEUR", true);
                chbx_priorite.DataBindings.Add("Checked", bsCommande, "PRIORITE_COMMANDE_FOURNISSEUR", true);
                chbx_VALIDE.DataBindings.Add("Checked", bsCommande, "VALIDE", true);
                this.txtAdresseFournisseur.DataBindings.Add("Text", bsCommande, "ADRESSE_FOURNISSEUR", true);
                this.txtCodeTvaFournisseur.DataBindings.Add("Text", bsCommande, "CODE_TVA_FOURNISSEUR", true);
                this.txtTelFournisseur.DataBindings.Add("Text", bsCommande, "TEL_FOURNISSEUR", true);
                this.txtFaxFournisseur.DataBindings.Add("Text", bsCommande, "FAX_FOURNISSEUR", true);
                dS_MOUV1.SOCIETE.ImportRow(CLIENT_APP_PARAM.ds_param.SOCIETE.Rows[0]);

                foreach (DataRow dr in CLIENT_APP_PARAM.ds_param.TVA.Rows)
                {
                    repositoryItemComboBox1.Items.Add(dr["TAUX_TVA"]);
                }
                repositoryItemComboBox1.KeyDown += new KeyEventHandler(repositoryItemComboBox1_KeyDown);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                Close();
            }
            
            this.bsCommande.PositionChanged += new EventHandler(bsCommande_PositionChanged);
            bareCodeReader1.OnRead += new CHMComponents.BareCodeReader.CBRActions(bareCodeReader1_OnRead);
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);

            chM_CMP_VALIDATION1.button1.Text = "Enregistrer";
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(onValidate);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(onClose);
        }

        void repositoryItemComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        void bareCodeReader1_OnRead(string CodeABarre)
        {
            try
            {
                DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_BY_BARCODE(CodeABarre);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    bool exist = false;
                    foreach (DataRow item in dS_MOUV1.V_LG_CMD_FR.Rows)
                    {
                        if (item["CODE_ARTICLE"].ToString() == dr["CODE_ARTICLE"].ToString())
                        {
                            exist = true;
                            break;
                        }
                    }
                    
                    if (!exist)
                    {
                        bsDetails.AddNew();
                        DataRowView drv = (DataRowView)bsDetails.Current;
                        drv["CODE_COMMANDE_FOURNISSEUR"] = -1;
                        drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drv["QTE"] = 1;
                        drv["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                        drv["DESCRIPTION_ARTICLE"] = dr["DESCRIPTION_ARTICLE"];
                        drv["REF_ARTICLE"] = dr["REF_ARTICLE"];
                        drv["TAUX_TVA"] = dr["TAUX_TVA_ACHAT"];
                        drv["UNITE"] = dr["LIB_UNITE"];
                        drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drv["PRIX_HT"] = dr["PRIX_HT_A_ARTICLE"];
                        drv["REMISE"] = 0;
                        drv["FODEC"] = 0;

                        bsDetails.EndEdit();
                        (bsDetails.DataSource as DataTable).AcceptChanges();
                        gridView1.UpdateCurrentRow();
                    }
                    else
                    {
                        bsDetails.Position = bsDetails.Find("CODE_ARTICLE", dr["CODE_ARTICLE"]);
                        DataRowView drv = (DataRowView)bsDetails.Current;
                        drv["QTE"] = (decimal)drv["QTE"] + 1;
                        bsDetails.EndEdit();
                        (bsDetails.DataSource as DataTable).AcceptChanges();
                        gridView1.UpdateCurrentRow();
                    }
                    
                }
                calculMontantTotal();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void onClose(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        void onValidate(object sender, EventArgs e)
        {
            #region test
            if (cbx_magazin.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner le dépot!");
                return;
            }

            if (cbx_magazin.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner le Fournisseur!");
                return;
            }

            if (dS_MOUV1.V_LG_CMD_FR.Rows.Count <1)
            {
                MessageBox.Show("Veuillez sélectionner les articles à commander!");
                return;
            }
            #endregion
            try
            {
                if (dS_MOUV1.V_LG_CMD_FR.Rows.Count > 0)
                {
                    DCOMMANDE_FOURNISSEUR cmd = new DCOMMANDE_FOURNISSEUR();
                    cmd.CODE_COMMANDE_FOURNISSEUR = txt_NUM_COMMANDE.Text;
                    cmd.CODE_FOURNISSEUR = _code_fournisseur;
                    cmd.REMARQUE = txt_REMARQUE.Text;
                    cmd.DATE_COMMANDE_FOURNISSEUR = dtp_DATE_COMMANDE.Value;
                    cmd.PRIORITE_COMMANDE_FOURNISSEUR = chbx_priorite.Checked;
                    cmd.DATE_EXPIRATION_COMMANDE_FOURNISSEUR = chbx_priorite.Checked ? dtp_DATE_EXPIRATION.Value : Convert.ToDateTime("01/01/1900");
                    cmd.MOIS_CMDFR = dtp_DATE_COMMANDE.Value.Month;
                    cmd.ANNEE_CMDFR = dtp_DATE_COMMANDE.Value.Year;
                    cmd.ADRESSE_LIVRAISON = txt_ADRESSE_LIVRAISON.Text;
                    cmd.CODE_FOURNISSEUR = Convert.ToDecimal(txt_fournisseur.Tag);
                    cmd.CODE_MAG = Convert.ToDecimal(cbx_magazin.SelectedValue);
                    cmd.CODE_USER = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    cmd.CONTACT = txt_CONTACT.Text;
                    cmd.DATE_VALIDATION = Convert.ToDateTime("01/01/1900");
                    cmd.TEL_CONTACT = txt_TEL_CONTACT.Text;



                    DataTable dtDetail = new DataTable("details");
                    foreach (DataColumn dc in dS_MOUV1.V_LG_CMD_FR.Columns)
                    {
                        DataColumn c = new DataColumn();
                        c.Caption = dc.Caption;
                        c.ColumnName = dc.ColumnName;
                        c.DataType = dc.DataType;
                        dtDetail.Columns.Add(c);
                    }
                    foreach (DataRow drdetail in dS_MOUV1.V_LG_CMD_FR.Rows)
                    {
                        dtDetail.ImportRow(drdetail);
                    }


                    RESULT_QUERY res = new RESULT_QUERY();
                    if (cmd.CODE_COMMANDE_FOURNISSEUR == "")
                    {
                        res = CLIENT_APP_PARAM.gcws.ajouteCOMMANDE_FOURNISSEUR(cmd, dtDetail);
                        if (res.OK)
                        {
                            DataRowView drv = (DataRowView)bsCommande.Current;
                            drv["CODE_USER"] = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                            drv["CODE_COMMANDE_FOURNISSEUR"] = res.CODE;
                            drv["VALIDE"] = "False";
                            txt_NUM_COMMANDE.Text = res.CODE;
                            foreach (DataRow dr in dS_MOUV1.V_LG_CMD_FR.Rows)
                            {
                                dr["CODE_COMMANDE_FOURNISSEUR"]=res.CODE;
                                dS_MOUV1.V_LG_CMD_FR.AcceptChanges();
                            }

                            ValidateChanges = true;
                            bsCommande.EndEdit();
                            (bsCommande.DataSource as DataTable).AcceptChanges();
                            bsCommande.Position = bsCommande.Find("CODE_COMMANDE_FOURNISSEUR", res.CODE);
                            bsCommande_PositionChanged(null, null);
                            dS_MOUV1.V_CMD_FR.Clear();
                            dS_MOUV1.V_CMD_FR.ImportRow((bsCommande.DataSource as DataTable).Select("CODE_COMMANDE_FOURNISSEUR like '" + res.CODE + "'")[0]);
                            
                            if (MessageBox.Show("Voulez vous une copie test de la commande?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                ReportDocument rpt = new CHM_RPT_CMD_FR();
                                rpt.SetDataSource(dS_MOUV1);
                                rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
                                rpt.PrintOptions.PrinterName=CLIENT_APP_PARAM.ReportPrinter;
                                rpt.PrintToPrinter(1, true, 0, 0);
                            }
                            if (MessageBox.Show("Voulez vous fermer la commande?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, this.Text);
                            ValidateChanges = false;
                            return;
                        }
                    }
                    else
                    {
                        res = CLIENT_APP_PARAM.gcws.modifieCOMMANDE_FOURNISSEUR(cmd, dtDetail);
                        if (res.OK)
                        {
                            DataRowView drv = (DataRowView)bsCommande.Current;
                            drv["CODE_USER"] = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);

                            txt_NUM_COMMANDE.Text = res.CODE;

                            ValidateChanges = true;
                            if (MessageBox.Show("Voulez vous une copie test de la commande?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                //Impression
                            }
                            if (MessageBox.Show("Voulez vous fermer la commande?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, this.Text);
                            ValidateChanges = false;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Commandes vide!\nVeuillez sélectionner les articles à commander.", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        void btn_suivant_Click(object sender, EventArgs e)
        {
            bsCommande.MoveNext();
        }

        void btn_premier_Click(object sender, EventArgs e)
        {
            bsCommande.MoveFirst();
        }

        void btn_precedent_Click(object sender, EventArgs e)
        {
            bsCommande.MovePrevious();
        }

        void btn_dernier_Click(object sender, EventArgs e)
        {
            bsCommande.MoveLast();
        }

        void bsCommande_PositionChanged(object sender, EventArgs e)
        {
            if (bsCommande.Current != null)
            {
                DataRowView drv = (DataRowView)bsCommande.Current;
                if (drv["CODE_COMMANDE_FOURNISSEUR"].ToString().Trim() != "" )
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = string.Format("Commande d'achat N°: {0}", drv["CODE_COMMANDE_FOURNISSEUR"]);
                    var valide = drv["VALIDE"].ToString();
                    if (valide == "True")
                    {
                        chbx_VALIDE.Text = string.Format("Validée le {0}", drv["DATE_VALIDATION"]);
                        btn_Valider.Enabled = false;
                    }
                    else
                    {
                        chbx_VALIDE.Text = "Validée";
                        btn_Valider.Enabled = true;
                    }
                    
                }
                else
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Nouvelle commande d'achat";
                    btn_Valider.Enabled = false;
                }

                chargerDetails();

            }
        }

        private void chargerDetails()
        {
            try
            {
                
                dS_MOUV1.V_LG_CMD_FR.Clear();
                dS_MOUV1.V_LG_CMD_FR.Merge(CLIENT_APP_PARAM.gcws.GetDetailCOMMANDE_FOURNISSEUR(((DataRowView)bsCommande.Current)["CODE_COMMANDE_FOURNISSEUR"].ToString()));
                calculMontantTotal();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
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
            _code_fournisseur = (decimal)fournisseur["CODE_FOURNISSEUR"];
            txt_fournisseur.Text = (string)fournisseur["RS_FOURNISSEUR"];
            txt_fournisseur.Tag = (decimal)fournisseur["CODE_FOURNISSEUR"];
            txtAdresseFournisseur.Text = fournisseur["ADRESSE_FOURNISSEUR"].ToString();
            txtCodeTvaFournisseur.Text = fournisseur["CODE_TVA_FOURNISSEUR"].ToString();
            txtTelFournisseur.Text = fournisseur["TEL_FOURNISSEUR"].ToString();
            txtFaxFournisseur.Text = fournisseur["FAX_FOURNISSEUR"].ToString();
        }

        private void buttonAJOUTER_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_ARTICLE f = new CHM_COMMANDE_ARTICLE("CMD_FR");
            f.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(f_confirm_ajout);
            f.ShowDialog();
        }

        void f_confirm_ajout(DataRowView article, decimal qte, decimal prix)
        {
            try
            {
                bool exist = false;
                foreach (DataRow dr_detail in dS_MOUV1.V_LG_CMD_FR.Rows)
                {
                    if (article["CODE_ARTICLE"].ToString() == dr_detail["CODE_ARTICLE"].ToString())
                    {
                        dr_detail["QTE"] = (decimal)dr_detail["QTE"] + qte;
                        //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                        exist = true;
                    }
                }
                if (!exist)
                {
                    bsDetails.AddNew();
                    DataRowView drv = (DataRowView)bsDetails.Current;
                    drv["CODE_COMMANDE_FOURNISSEUR"] = -1;
                    drv["CODE_ARTICLE"] = article["CODE_ARTICLE"];
                    drv["QTE"] = qte;
                    drv["DESIGNATION_ARTICLE"] = article["DESIGNATION_ARTICLE"];
                    drv["DESCRIPTION_ARTICLE"] = article["DESCRIPTION_ARTICLE"];
                    drv["REF_ARTICLE"] = article["REF_ARTICLE"];
                    drv["TAUX_TVA"] = article["TAUX_TVA_ACHAT"];
                    drv["UNITE"] = article["LIB_UNITE"];
                    drv["CODE_ARTICLE"] = article["CODE_ARTICLE"];
                    drv["PRIX_HT"] = article["PRIX_HT_A_ARTICLE"];
                    drv["REMISE"] = 0;
                    drv["FODEC"] = 0;

                    bsDetails.EndEdit();
                    (bsDetails.DataSource as DataTable).AcceptChanges();
                    gridView1.UpdateCurrentRow();
                }
                calculMontantTotal();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur");
            }
        }

        void calculMontantTotal()
        {
            HT.Value = 0;
            TVA.Value = 0;
            REMISE.Value = 0;

            foreach (DataRow dr in dS_MOUV1.V_LG_CMD_FR.Rows)
            {    
                HT.Value += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"];
                REMISE.Value += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"] * (decimal)dr["REMISE"] / 100;
                TVA.Value += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT"] * (1-(decimal)dr["REMISE"] / 100)* (decimal)dr["TAUX_TVA"]/100;
            }


            TTC.Value = HT.Value - REMISE.Value + TVA.Value;
        }

        private void buttonSUPPRIMER_Click(object sender, EventArgs e)
        {
            if (bsDetails.Current != null && MessageBox.Show("Etes vous sures de supprimer l'article suivant?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                bsDetails.RemoveCurrent();
            }
        }        

        private void CHM_FRM_NV_CMD_FR_FormClosing(object sender, FormClosingEventArgs e)
        {
            bsCommande.PositionChanged -= bsCommande_PositionChanged;

            if (OnMaj != null)
                OnMaj(txt_NUM_COMMANDE.Text, ValidateChanges);
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sûres de valider la commande?\nNB: Une commande validée ne peut pas être modifiée!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    DCOMMANDE_FOURNISSEUR cmd = new DCOMMANDE_FOURNISSEUR();
                    cmd.CODE_COMMANDE_FOURNISSEUR = txt_NUM_COMMANDE.Text;
                    cmd.VALIDE = true;
                    cmd.USER_VALIDATION = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    cmd.DATE_VALIDATION = CLIENT_APP_PARAM.gcws.getDateS();

                    RESULT_QUERY res = new RESULT_QUERY();
                    res = CLIENT_APP_PARAM.gcws.validerCOMMANDE_FOURNISSEUR(cmd);
                    if (res.OK)
                    {
                        ValidateChanges = true;
                        ((DataRowView)bsCommande.Current)["Valide"] = "True";
                        ((DataRowView)bsCommande.Current)["USER_VALIDATION"] = cmd.USER_VALIDATION;
                        ((DataRowView)bsCommande.Current)["DATE_VALIDATION"] = cmd.DATE_VALIDATION;
                        MessageBox.Show("Commande validée avec succès.");
                        dS_MOUV1.V_CMD_FR.Clear();
                        dS_MOUV1.V_CMD_FR.ImportRow((bsCommande.DataSource as DataTable).Select("CODE_COMMANDE_FOURNISSEUR like '" + txt_NUM_COMMANDE.Text + "'")[0]);
   
                        if (MessageBox.Show("Voulez vous imprimer la commande?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            ReportDocument rpt = new CHM_RPT_CMD_FR();
                            rpt.SetDataSource(dS_MOUV1);
                            rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
                            rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                            rpt.PrintToPrinter(1, true, 0, 0);
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                        return;
                        ValidateChanges = false;

                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }            
        }

        private void dtp_DATE_COMMANDE_ValueChanged(object sender, EventArgs e)
        {
            dtp_DATE_EXPIRATION.MinDate = dtp_DATE_COMMANDE.Value;
        }

        private void chbx_priorite_CheckedChanged(object sender, EventArgs e)
        {
            lb_expiration.Visible = dtp_DATE_EXPIRATION.Visible = chbx_priorite.Checked;
            
        }

        private void txt_NUM_COMMANDE_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            calculMontantTotal();
        }

        private void CHM_FRM_NV_CMD_FR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                onClose(null, null);
            if (e.KeyCode == Keys.F2)
            {
                if (txt_fournisseur.Focused)
                {
                    button2_Click(null, null);
                }
                else
                {
                    buttonAJOUTER_Click(null, null);
                }
            }
        }

        private void CHM_FRM_NV_CMD_FR_Load(object sender, EventArgs e)
        {
            bsCommande_PositionChanged(null, null);
            chbx_priorite_CheckedChanged(null, null);
            chbx_VALIDE_CheckedChanged(null, null);
        }

        private void chbx_VALIDE_CheckedChanged(object sender, EventArgs e)
        {        
                if (chbx_VALIDE.Checked)
                {
                    btn_Valider.Enabled = false;
                    pEnteteCmd.Enabled = false;
                    pMAJDetails.Visible = false;
                }
                else
                {
                    if (txt_NUM_COMMANDE.Text == "")
                    {
                        btn_Valider.Enabled = false;
                    }
                    else
                    {
                        btn_Valider.Enabled = true;
                    }
                    pEnteteCmd.Enabled = true;
                    pMAJDetails.Visible = true;
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}