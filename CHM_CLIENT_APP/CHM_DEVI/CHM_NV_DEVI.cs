using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON;
using CHM_CLIENT_APP.CHMGC;
using CrystalDecisions.CrystalReports.Engine;
using CHM_CLIENT_APP.CHM_DEVI;
using DevExpress.XtraGrid.Views.Grid;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NV_DEVI : Form
    {
        DDEVIS_CLIENT Devis = new DDEVIS_CLIENT();
        BindingSource bsDevis = new BindingSource();
        BindingSource bsDetail = new BindingSource();
        bool ValidateChanges = false;

        public delegate void MAJ(string CODE_DC, bool validateChanges);
        public event MAJ OnMaj;

        string CODE_CLIENT = "-1";
        DataTable dt_lg_devis;



        public CHM_NV_DEVI(BindingSource bsDevi)
        {
            InitializeComponent();
            bsDevis = bsDevi;
            bsDetail.DataSource = dS_MOUV1.V_LG_DC;
            gridControl1.DataSource = bsDetail;
            chargerDetails();
            bareCodeReader1.OnRead += new CHMComponents.BareCodeReader.CBRActions(bareCodeReader1_OnRead);

            try
            {
                txt_CODE_DC.DataBindings.Add("Text", bsDevis, "CODE_DC", true);
                txt_MODE_PAIEMENT.DataBindings.Add("Text", bsDevis, "MODE_PAIEMENT", true);
                txt_OBSERVATION.DataBindings.Add("Text", bsDevis, "OBSERVATION", true);
                dtp_DATE_DC.DataBindings.Add("Value", bsDevis, "DATE_DC", true);
                txt_REF_CLIENT.DataBindings.Add("Text", bsDevis, "REF_CLIENT", true);
                txt_RS_CLIENT.DataBindings.Add("Text", bsDevis, "RS_CLIENT", true);
                txt_REF_CLIENT.DataBindings.Add("Tag", bsDevis, "CODE_CLIENT", true);
                nud_DATE_VALIDITE.DataBindings.Add("Value", bsDevis, "DATE_VALIDITE", true);
                txt_Responsable.DataBindings.Add("Text", bsDevis, "RESPONSABLE", true);
                TTC.DataBindings.Add("Value", bsDevis, "MONTANT_TTC", true);
                TVA.DataBindings.Add("Value", bsDevis, "MONTANT_TVA", true);
                HT.DataBindings.Add("Value", bsDevis, "MONTANT_HT", true);
                TAUX_REMISE.DataBindings.Add("Value", bsDevis, "MONTANT_REMISE_HT", true);
                TIMBRE.DataBindings.Add("Value", bsDevis, "TIMBRE", true);
                lbCodeTVAClient.DataBindings.Add("Text", bsDevis, "CODE_TVA_CLIENT", true);
                lbAdresseClient.DataBindings.Add("Text", bsDevis, "ADRESSE_CLIENT", true);

                TIMBRE.Value = Convert.ToDecimal(CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1).Replace(',', '.'));
                dS_MOUV1.SOCIETE.ImportRow(CLIENT_APP_PARAM.ds_param.SOCIETE.Rows[0]);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }

            foreach (DataRow dr in CLIENT_APP_PARAM.ds_param.TVA.Rows)
            {
                repositoryItemComboBox1.Items.Add(dr["TVA_LIBELLE"]);
            }
            repositoryItemComboBox1.KeyDown += new KeyEventHandler(repositoryItemComboBox1_KeyDown);
            


            entete_Formulaire_21.btn_refresh.Visible = false;
            chM_CMP_FICHE1.button1.Text = "Imprimer";
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);


            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);

            bsDevis.PositionChanged += new EventHandler(bsDevis_PositionChanged);
            bsDevis_PositionChanged(null, null);
        }

        void repositoryItemComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        void bsDevis_PositionChanged(object sender, EventArgs e)
        {
            if (bsDevis.Current != null)
            {
                DataRowView drv = (DataRowView)bsDevis.Current;
                this.Text = entete_Formulaire_21.windows_name.Text = (drv["CODE_DC"].ToString() == string.Empty || drv["CODE_DC"] == null) ? "Nouveau Devis CLient" : string.Format("Devis Client N°: {0}", drv["CODE_DC"]);
            }
            chargerDetails();
            calculerDevis();
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void calculerDevis()
        {
            try
            {
                decimal montant_ht = 0;
                decimal montant_remise = 0;
                decimal montant_tva = 0;
                decimal montant_ttc = 0;
                TVAAchat.Value = 0;
                HTAchat.Value = 0;
                TTCAchat.Value = 0;
                gain.Value = 0;
                foreach (DataRow dr in dS_MOUV1.V_LG_DC.Rows)
                {
                    montant_ht += (decimal)dr["TOTAL_HT"];
                    montant_remise += (decimal)dr["TOTAL_REMISE"];
                    montant_ttc += (decimal)dr["TOTAL_TTC"];
                    montant_tva += (decimal)dr["TOTAL_TVA"];
                    HTAchat.Value += (decimal)dr["PRIX_HT_ACHAT"] * (decimal)dr["QTE"];
                    TVAAchat.Value += (decimal)dr["PRIX_HT_ACHAT"] * (decimal)dr["QTE"] * (decimal)dr["TVA_ACHAT"]/100;
                    TTCAchat.Value = +HTAchat.Value + TVAAchat.Value;
                    gain.Value = montant_ttc - TTCAchat.Value;
                    if (gain.Value > 0)
                        gain.Couleur2 = Color.Lime;
                    else
                        gain.Couleur2 = Color.Red;
                }
                HT.Value = montant_ht;
                TAUX_REMISE.Value = montant_remise;
                TVA.Value = montant_tva;
                TTC.Value = montant_ttc;
                NP.Value = montant_ttc + TIMBRE.Value;
                ML.Text = string.Format("Arreté le présent devis à la somme de  de {0}", new NUM_TO_LETTRE.NumberToLetter().ConvertirDinars(NP.Value));

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, this.Text);
            }
        }


        void button1_Click(object sender, EventArgs e)
        {

            errorProvider1.SetError(txt_REF_CLIENT, "");
            if (txt_REF_CLIENT.Text == string.Empty)
            {
                errorProvider1.SetError(txt_REF_CLIENT, "Veuillez sélectionner le client!");
                PARCOURIR_LISTE_CLIENT.Focus();
                return;
            }
            if (dS_MOUV1.V_LG_DC.Rows.Count > 0)
            {
                if (MessageBox.Show("Etes vous sûres d'enregistrer le devis?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {

                        Devis = new DDEVIS_CLIENT();
                        Devis.DATE_CREATION = dtp_DATE_DC.Value;
                        Devis.CODE_CLIENT = (decimal)txt_REF_CLIENT.Tag;
                        Devis.DATE_DC = dtp_DATE_DC.Value;
                        Devis.DATE_VALIDITE = nud_DATE_VALIDITE.Value;
                        Devis.MODE_PAIEMENT = txt_MODE_PAIEMENT.Text;
                        Devis.OBSERVATION = txt_OBSERVATION.Text;
                        Devis.RESPONSABLE = txt_Responsable.Text;
                        Devis.UTILISATEUR_CREATION = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                        Devis.TIMBRE = TIMBRE.Value;

                        DataTable mydetails = new DataTable("devisDetails");
                        foreach (DataColumn c in dS_MOUV1.V_LG_DC.Columns)
                        {
                            DataColumn col = new DataColumn(c.ColumnName, c.DataType);
                            mydetails.Columns.Add(col);
                        }

                        foreach (DataRow dr in dS_MOUV1.V_LG_DC.Rows)
                        {

                            mydetails.ImportRow(dr);
                        }

                        RESULT_QUERY res = new RESULT_QUERY();
                        res = CLIENT_APP_PARAM.gcws.ajouteDEVIS_CLIENT(Devis, mydetails);
                        if (res.OK)
                        {
                            Devis.CODE_DC = txt_CODE_DC.Text = res.CODE;
                            MessageBox.Show(res.MESSAGE, this.Text);
                            ValidateChanges = true;
                            bsDevis.EndEdit();
                            (bsDevis.DataSource as DataTable).AcceptChanges();
                            if (MessageBox.Show("Voulez vous imprimer le devis?", "Impression Devis", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                try
                                {
                                    foreach (DataRow dr in dS_MOUV1.V_LG_DC.Rows)
                                    {
                                        dr["CODE_DC"] = res.CODE;
                                        dS_MOUV1.V_LG_DC.AcceptChanges();
                                    }
                                    this.Cursor = Cursors.WaitCursor;
                                    dS_MOUV1.V_DC.Clear();
                                    dS_MOUV1.V_DC.ImportRow((bsDevis.DataSource as DataTable).Select("CODE_DC like '" + txt_CODE_DC.Text + "'")[0]);

                                    ReportDocument rpt = new CHM_RPT_DEVI_CLIENT();
                                    rpt.SetDataSource(dS_MOUV1);
                                    rpt.SetParameterValue("montantLettre", new NUM_TO_LETTRE.NumberToLetter().ConvertirDinars(NP.Value));
                                    rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
                                    rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                                    rpt.PrintToPrinter(1, true, 0, 0);

                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.Message, "Erreur d'impression");
                                }
                                finally
                                {
                                    this.Cursor = Cursors.Default;
                                }
                            }
                            if (OnMaj != null)
                                OnMaj(res.CODE, ValidateChanges);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, this.Text);
                            return;
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Erreur");
                    }
                }
            }
            else
            {
                MessageBox.Show("Devis Vide!");
            }
        }

        void btn_suivant_Click(object sender, EventArgs e)
        {
            bsDevis.MoveNext();
        }

        void btn_premier_Click(object sender, EventArgs e)
        {
            bsDevis.MoveFirst();
        }

        void btn_precedent_Click(object sender, EventArgs e)
        {
            bsDevis.MovePrevious();
        }

        void btn_dernier_Click(object sender, EventArgs e)
        {
            bsDevis.MoveLast();
        }

        void bareCodeReader1_OnRead(string CodeABarre)
        {
            try
            {


                DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_BY_BARCODE_BY_MAGASIN(CodeABarre, CLIENT_APP_PARAM.CODE_MAG);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    bool trouve = false;
                    foreach (DataRow item in dS_MOUV1.V_LG_DC.Rows)
                    {
                        if (item["CODE_ARTICLE"].ToString() == dr["CODE_ARTICLE"].ToString())
                        {
                            trouve = true;
                            
                            break;
                        }
                    }

                    if (!trouve)
                    {
                        bsDetail.AddNew();
                        DataRowView drv = (DataRowView)bsDetail.Current;

                        drv["CODE_DC"] = "";
                        drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drv["REF_ARTICLE"] = dr["REF_ARTICLE"];
                        drv["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                        drv["UNITE"] = dr["LIB_UNITE"];
                        drv["QTE"] = 1;
                        drv["TVA"] = dr["TVA_ARTICLE"];
                        drv["PRIX_U_HT"] = dr["PRIX_HT_V_ARTICLE"];
                        drv["REMISE"] = 0;
                        drv["MAX_REMISE"] = dr["MAX_REMISE"];
                        drv["PRIX_HT_ACHAT"] = dr["PRIX_HT_A_ARTICLE"];
                        drv["TVA_ACHAT"] = dr["TVA_ACHAT"];
                        //calculerLigne();

                        bsDetail.EndEdit();
                        (bsDetail.DataSource as DataTable).AcceptChanges();
                    }
                    else
                    {
                        bsDetail.Position = bsDetail.Find("CODE_ARTICLE", dr["CODE_ARTICLE"]);
                        DataRowView drv = (DataRowView)bsDetail.Current;


                        drv["QTE"] = (decimal)drv["QTE"] + 1;
                        //calculerLigne();
                        bsDetail.EndEdit();
                        (bsDetail.DataSource as DataTable).AcceptChanges();
                        
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void chargerDetails()
        {
            try
            {
                if (bsDevis.Current != null)
                {
                    DataRowView drv = (DataRowView)bsDevis.Current;
                    dS_MOUV1.V_LG_DC.Clear();
                    dS_MOUV1.V_LG_DC.Merge(CLIENT_APP_PARAM.gcws.GetDETAILS_DEVIS_CLIENT(drv["CODE_DC"].ToString()));
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void buttonAJOUTER_Click(object sender, EventArgs e)
        {
            //CHM_COMMANDE_ARTICLE f = new CHM_COMMANDE_ARTICLE();
            //f.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(f_confirm_ajout);
            //f.ShowDialog();
        }

        void f_confirm_ajout(DataRowView article, decimal qte)
        {

        }

        private void PARCOURIR_LISTE_CLIENT_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_CLIENT c_clt = new CHM_COMMANDE_CLIENT();
            c_clt.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(c_clt_client_selection_event);
            c_clt.ShowDialog();
        }

        void c_clt_client_selection_event(DCLIENT client)
        {
            txt_REF_CLIENT.Text = client.REF_CLIENT;
            txt_REF_CLIENT.Tag = client.CODE_CLIENT;
            txt_RS_CLIENT.Text = client.RS_CLIENT;
            CODE_CLIENT = client.CODE_CLIENT.ToString();
            lbAdresseClient.Text = client.ADRESSE_CLIENT;
            lbCodeTVAClient.Text = client.CODE_TVA_CLIENT;
        }

        private void CHM_NV_DEVI_Shown(object sender, EventArgs e)
        {

            try
            {
                #region old
                //dgv_lg_devis.AutoGenerateColumns = false;
                //Application.DoEvents();
                ////dt_lg_devis = CLIENT_APP_PARAM.GEST.P_DEVI.LOAD_SCHEMA_LG_DEVIS();
                //dt_lg_devis = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_DEVIS();
                //bs.DataSource = dt_lg_devis;
                //dgv_lg_devis.DataSource = bs; 
                #endregion

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        decimal somme = 0;



        private void buttonENREGISTRER_Click(object sender, EventArgs e)
        {

        }

        private void btn_AJOUTER_ARTICLE_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_COMMANDE_ARTICLE fArt = new CHM_COMMANDE_ARTICLE("CMD_CL");
                fArt.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(fArt_confirm_ajout);
                fArt.StartPosition = FormStartPosition.CenterScreen;
                fArt.ShowDialog();
                //CHM_FRM_SELECTION_ARTICLE f = new CHM_FRM_SELECTION_ARTICLE(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG), "");
                //f.on_select += new CHM_FRM_SELECTION_ARTICLE.selection_article(f_on_select);
                //f.ShowDialog();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void fArt_confirm_ajout(DataRowView article, decimal qte, decimal prix)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bool trouve = false;
                foreach (DataRow item in dS_MOUV1.V_LG_DC.Rows)
                {
                    if (item["CODE_ARTICLE"].ToString() == article["CODE_ARTICLE"].ToString())
                    {
                        trouve = true;
                        break;
                    }
                }

                if (!trouve)
                {
                    bsDetail.AddNew();
                    DataRowView drv = (DataRowView)bsDetail.Current;

                    drv["CODE_DC"] = "";
                    drv["CODE_ARTICLE"] = article["CODE_ARTICLE"];
                    drv["REF_ARTICLE"] = article["REF_ARTICLE"];
                    drv["DESIGNATION_ARTICLE"] = article["DESIGNATION_ARTICLE"];
                    drv["UNITE"] = article["LIB_UNITE"];
                    drv["QTE"] = qte;
                    drv["TVA"] = article["TAUX_TVA"];
                    drv["PRIX_U_HT"] = article["PRIX_HT_V_ARTICLE"];
                    drv["REMISE"] = 0;
                    drv["MAX_REMISE"] = article["MAX_REMISE"];
                    drv["PRIX_HT_ACHAT"] = article["PRIX_HT_A_ARTICLE"];
                    drv["TVA_ACHAT"] = article["TAUX_TVA_ACHAT"];
                    //calculerLigne();

                    bsDetail.EndEdit();
                    (bsDetail.DataSource as DataTable).AcceptChanges();
                }
                else
                {
                    bsDetail.Position = bsDetail.Find("CODE_ARTICLE", article["CODE_ARTICLE"]);
                    DataRowView drv = (DataRowView)bsDetail.Current;


                    drv["QTE"] = (decimal)drv["QTE"] + qte;
                    //calculerLigne();

                    bsDetail.EndEdit();
                    (bsDetail.DataSource as DataTable).AcceptChanges();
                }
                calculerDevis();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void f_on_select(DataRowView Article, decimal qte)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bool trouve = false;
                foreach (DataRow item in dS_MOUV1.V_LG_DC.Rows)
                {
                    if (item["CODE_ARTICLE"].ToString() == Article["CODE_ARTICLE"].ToString())
                    {
                        trouve = true;
                        break;
                    }
                }

                if (!trouve)
                {
                    bsDetail.AddNew();
                    DataRowView drv = (DataRowView)bsDetail.Current;


                    drv["CODE_ARTICLE"] = Article["CODE_ARTICLE"];
                    drv["REF_ARTICLE"] = Article["REF_ARTICLE"];
                    drv["DESIGNATION_ARTICLE"] = Article["DESIGNATION_ARTICLE"];
                    drv["LIB_UNITE"] = Article["LIB_UNITE"];
                    drv["QTE_FI"] = qte;
                    drv["TVA_FI"] = Article["TVA_ARTICLE"];
                    drv["P_HT_FI"] = Article["PRIX_HT_V_ARTICLE"];
                    drv["REMISE_FI"] = 0;
                    drv["MAX_REMISE"] = Article["MAX_REMISE"];
                    drv["PRIX_HT_ACHAT"] = Article["PRIX_HT_A_ARTICLE"];
                    drv["TVA_ACHAT"] = Article["TAUX_TVA_ACHAT"];
                    bsDetail.EndEdit();
                    (bsDetail.DataSource as DataTable).AcceptChanges();
                }
                else
                {
                    bsDetail.Position = bsDetail.Find("CODE_ARTICLE", Article["CODE_ARTICLE"]);
                    DataRowView drv = (DataRowView)bsDetail.Current;


                    drv["QTE_FI"] = (decimal)drv["QTE_FI"] + qte;
                    //calculerLigne();

                    bsDetail.EndEdit();
                    (bsDetail.DataSource as DataTable).AcceptChanges();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_SUPPRIMER_ARTICLE_Click(object sender, EventArgs e)
        {

            if (bsDetail.Current != null && MessageBox.Show("Etes vous sures de supprimer cet article?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bsDetail.RemoveCurrent();
                (bsDetail.DataSource as DataTable).AcceptChanges();
            }
            calculerDevis();
        }

        private void CHM_NV_DEVI_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CHM_NV_DEVI_FormClosing(object sender, FormClosingEventArgs e)
        {
            bsDevis.PositionChanged -= bsDevis_PositionChanged;

            if (OnMaj != null)
                OnMaj(txt_CODE_DC.Text, ValidateChanges);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {            
            bsDetail.EndEdit();
            (bsDetail.DataSource as DataTable).AcceptChanges();
            calculerDevis();            
        }

        private void btn_aperçu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dS_MOUV1.V_LG_DC.Rows.Count>0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    dS_MOUV1.V_DC.Clear();
                    dS_MOUV1.V_DC.ImportRow((bsDevis.DataSource as DataTable).Select("CODE_DC like '" + txt_CODE_DC.Text + "'")[0]);

                    ReportDocument rpt = new CHM_RPT_DEVI_CLIENT();
                    rpt.SetDataSource(dS_MOUV1);
                    rpt.SetParameterValue("montantLettre", new NUM_TO_LETTRE.NumberToLetter().ConvertirDinars(NP.Value));
                    if (MessageBox.Show("Aperçu avec entete?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        rpt.SetParameterValue("entete", true);
                    else
                        rpt.SetParameterValue("entete", false);
                    CHM_ETATS f = new CHM_ETATS();
                    f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Rien à afficher");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Erreur d'impression");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (txt_CODE_DC.Text == "")
                {
                    GridView View = sender as GridView;
                    if (e.RowHandle >= 0)
                    {
                        decimal pAchat = Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["PRIX_HT_ACHAT"])) * (1+Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["TVA_ACHAT"]))/100);
                        decimal pVente = Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["PRIX_U_HT"])) * (1 - Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["REMISE"]))/100) * (1 + Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, View.Columns["TVA"]))/100);
                        

                        if (pVente<pAchat)
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }

                        
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void p_control_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
