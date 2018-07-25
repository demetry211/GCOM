using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using CHM_CLIENT_APP.CHM_CLIENT;
using CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON;
using CHM_CLIENT_APP.CHM_FACTURE;
using CHM_CLIENT_APP.EQUIPEMENTS;

namespace CHM_CLIENT_APP.FICHE_INTERVENTION
{
    public partial class CHM_FRM_MAJ_FI : Form
    {
        DFICHE_INTERVENTION Fiche;
        BindingSource bs = new BindingSource();
        BindingSource bsDetail = new BindingSource();
        bool ValidateChanges = false;

        public delegate void MAJ(string NumFi, bool validateChanges);
        public event MAJ OnMaj;

        public CHM_FRM_MAJ_FI(BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;
            bsDetail.DataSource = dS_MOUV1.LG_FI;
            gridControl1.DataSource = bsDetail;
            Fiche = new DFICHE_INTERVENTION();
            try
            {
                txt_CODE_B_LIV.DataBindings.Add("Text", bs, "CODE_B_LIV", true);
                //txt_CODE_VEHICULE.DataBindings.Add("Text", bs, "CODE_VEHICULE", true);
                txt_DATE_FI.DataBindings.Add("DateTime", bs, "DATE_FI", true);
                txt_GAMME.DataBindings.Add("Text", bs, "GAMME", true);
                txt_KILOMETRAGE.DataBindings.Add("Text", bs, "KILOMETRAGE", true);
                //txt_MARQUE.DataBindings.Add("Text", bs, "DESIGNATION_MARQUE", true);
                //txt_MATRICULE.DataBindings.Add("Text", bs, "MATRICULE", true);
                txt_NUM_FI.DataBindings.Add("Text", bs, "NUM_FI", true);
                txt_REF_CLIENT.DataBindings.Add("Text", bs, "REF_CLIENT", true);
                txt_RS_CLIENT.DataBindings.Add("Text", bs, "RS_CLIENT", true);
                txt_TEL_CLIENT.DataBindings.Add("Text", bs, "TEL_CLIENT", true);
                chbx_CLOTURE.DataBindings.Add("Checked", bs, "CLOTURE", true);
                txt_REF_CLIENT.DataBindings.Add("Tag", bs, "CODE_CLIENT", true);
                lbCode.DataBindings.Add("Text", bs, "CODE_VEHICULE", true);
                txtFabriquant.DataBindings.Add("Text", bs, "FABRIQUANT", true);
                txtSerie.DataBindings.Add("Text", bs, "NUM_SERIE", true);
                txtLibelle.DataBindings.Add("Text", bs, "LIBELLE_EQP", true);
                dtpDateService.DataBindings.Add("Value", bs, "DATE_MISE_SERVICE_EQP", true);
                dtpDateFabrication.DataBindings.Add("Value", bs, "DATE_FAB_EQP", true);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }

            this.Text = entete_Formulaire_21.windows_name.Text = (bs.Current as DataRowView)["NUM_FI"].ToString() == "" ? "Nouvelle fiche d'entretien" : string.Format("Fiche d'entretien N° {0}", (bs.Current as DataRowView)["NUM_FI"]);
            if ((bs.Current as DataRowView)["NUM_FI"].ToString() == "")
                txt_DATE_FI.DateTime = DateTime.Now;
            bs.PositionChanged += new EventHandler(bs_PositionChanged);


            chM_CMP_FICHE1.button1.Text = "Imprimer";
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);

            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
            bareCodeReader1.OnRead += new CHMComponents.BareCodeReader.CBRActions(bareCodeReader1_OnRead);

            bs_PositionChanged(null, null);
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
                    foreach (DataRow item in dS_MOUV1.LG_FI.Rows)
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

                        drv["NUM_FI"] = txt_NUM_FI.Text;
                        drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drv["REF_ARTICLE"] = dr["REF_ARTICLE"];
                        drv["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                        drv["LIB_UNITE"] = dr["LIB_UNITE"];
                        drv["QTE_FI"] = 1;
                        drv["TVA_FI"] = dr["TVA_ARTICLE"];
                        drv["P_HT_FI"] = dr["PRIX_HT_V_ARTICLE"];
                        drv["REMISE_FI"] = 0;

                        //calculerLigne();

                        bsDetail.EndEdit();
                        (bsDetail.DataSource as DataTable).AcceptChanges();
                        gridView1.UpdateCurrentRow();
                    }
                    else
                    {
                        bsDetail.Position = bsDetail.Find("CODE_ARTICLE", dr["CODE_ARTICLE"]);
                        DataRowView drv = (DataRowView)bsDetail.Current;


                        drv["QTE_FI"] = (decimal)drv["QTE_FI"] + 1;
                        //calculerLigne();
                        bsDetail.EndEdit();
                        (bsDetail.DataSource as DataTable).AcceptChanges();
                        gridView1.UpdateCurrentRow();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        void button1_Click(object sender, EventArgs e)
        {
            #region Verification champs
            errorProvider1.SetError(btnSelectEqp, "");
            if (lbCode.Text == string.Empty)
            {
                errorProvider1.SetError(btnSelectEqp, "Veuillez sélectionner l'équipement!");
                btnSelectEqp.Focus();
                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(gridControl1, "");
            if (bsDetail.Count==0)
            {
                errorProvider1.SetError(gridControl1, "Fiche vide!");
                btn_AJOUTER_ARTICLE.Focus();
                return;
            }
            errorProvider1.Clear();
            #endregion

            try
            {
                this.Cursor = Cursors.WaitCursor;
                RESULT_QUERY res = new RESULT_QUERY();

                Fiche.NUM_FI = txt_NUM_FI.Text;


                Fiche.CLOTURE = chbx_CLOTURE.Checked ? 1 : 0;
                Fiche.CODE_B_LIV = txt_CODE_B_LIV.Text;
                Fiche.CODE_VEHICULE = Convert.ToDecimal(lbCode.Text);
                Fiche.DATE_CLOTURE = Convert.ToDateTime("01/01/1900");
                Fiche.DATE_FI = txt_DATE_FI.DateTime;
                Fiche.DETAIL = new DARTICLE[dS_MOUV1.LG_FI.Rows.Count];
                Fiche.CODE_MAG = Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG);
                int i = 0;
                foreach (DataRow dr in dS_MOUV1.LG_FI.Rows)
                {
                    DARTICLE article = new DARTICLE();
                    article.CODE_ARTICLE = (decimal)dr["CODE_ARTICLE"];
                    article.QTE_ARTICLE = (decimal)dr["QTE_FI"];
                    article.UNITE_QTE_ARTICLE = (string)dr["LIB_UNITE"];
                    article.DESIGNATION_ARTICLE = (string)dr["DESIGNATION_ARTICLE"];
                    article.REF_ARTICLE = (string)dr["REF_ARTICLE"];
                    article.TVA_ARTICLE = (decimal)dr["TVA_FI"];
                    article.PRIX_HT_V_ARTICLE = (decimal)dr["P_HT_FI"];

                    Fiche.DETAIL[i] = article;
                    i++;
                }
                Fiche.KILOMETRAGE = Convert.ToDecimal(txt_KILOMETRAGE.Text.Trim() == string.Empty ? "0" : txt_KILOMETRAGE.Text);




                if (txt_NUM_FI.Text == string.Empty)
                {
                    Fiche.USER_CR = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);

                    res = CLIENT_APP_PARAM.gcws.ajouteFICHE_INTERVENTION(Fiche);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                        (bs.Current as DataRowView)["NUM_FI"] = res.CODE;
                        txt_NUM_FI.Text = res.CODE;
                        ValidateChanges = true;
                        if (MessageBox.Show("Fermer la fiche?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                        ValidateChanges = false;
                    }
                }
                else
                {
                    Fiche.USER_MODIF = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                    Fiche.DATE_MODIF = CLIENT_APP_PARAM.gcws.getDateS();

                    res = CLIENT_APP_PARAM.gcws.modifieFICHE_INTERVENTION(Fiche);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                        ValidateChanges = true;
                        if (MessageBox.Show("Fermer la fiche?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text);
                        ValidateChanges = false;

                    }
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

        void btn_suivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        void btn_premier_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        void btn_precedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        void btn_dernier_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        void bs_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
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

                    btn_TC.Enabled = chbx_CLOTURE.Checked && txt_CODE_B_LIV.Text.Trim() == string.Empty;
                    this.Text = entete_Formulaire_21.windows_name.Text = drv["NUM_FI"].ToString() == "" ? "Nouvelle fiche d'entretien" : string.Format("Fiche d'entretien N° {0}", drv["NUM_FI"]);
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



        private void CHM_FRM_MAJ_FI_FormClosing(object sender, FormClosingEventArgs e)
        {
            bs.PositionChanged -= bs_PositionChanged;

            if (OnMaj != null)
                OnMaj(txt_NUM_FI.Text, ValidateChanges);
        }

        private void btn_SELECT_VEHICULE_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_VEHICULE f = new CHM_FRM_LISTE_VEHICULE("s");
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnSelect += new CHM_FRM_LISTE_VEHICULE.Selection(f_OnSelect);
            f.ShowDialog();
        }

        void f_OnSelect(decimal codeVehicule)
        {
            DVEHICULE vehicule = new DVEHICULE();
            vehicule.CODE_VEHICULE = codeVehicule;
            try
            {
                vehicule = CLIENT_APP_PARAM.gcws.obtenirInstanceVEHICULE(vehicule);

                txt_MARQUE.Text = vehicule.DESIGNATION_MARQUE;
                txt_MATRICULE.Text = vehicule.MATRICULE;
                txt_GAMME.Text = vehicule.GAMME;
                txt_RS_CLIENT.Text = vehicule.RS_CLIENT;
                txt_TEL_CLIENT.Text = vehicule.TEL_CLIENT;
                txt_REF_CLIENT.Text = vehicule.REF_CLIENT;
                txt_CODE_VEHICULE.Text = vehicule.CODE_VEHICULE.ToString();
                txt_REF_CLIENT.Tag = vehicule.CODE_CLIENT;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void chbx_CLOTURE_CheckedChanged(object sender, EventArgs e)
        {
            chM_CMP_VALIDATION1.button1.Enabled = btn_Cloturer.Enabled = btn_SUPPRIMER_ARTICLE.Enabled = txt_DATE_FI.Enabled = !chbx_CLOTURE.Checked;
            btn_AJOUTER_ARTICLE.Enabled = bareCodeReader1.Enabled = !chbx_CLOTURE.Checked;
            btn_TC.Enabled = chbx_CLOTURE.Checked && txt_CODE_B_LIV.Text.Trim() == string.Empty;
        }

        private void btn_AJOUTER_ARTICLE_Click(object sender, EventArgs e)
        {
            try
            {

                CHM_FRM_SELECTION_ARTICLE f = new CHM_FRM_SELECTION_ARTICLE(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG), "");
                f.on_select += new CHM_FRM_SELECTION_ARTICLE.selection_article(f_on_select);
                f.ShowDialog();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void f_on_select(DataRowView Article, decimal qte)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bool trouve = false;
                foreach (DataRow item in dS_MOUV1.LG_FI.Rows)
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

                    drv["NUM_FI"] = txt_NUM_FI.Text;
                    drv["CODE_ARTICLE"] = Article["CODE_ARTICLE"];
                    drv["REF_ARTICLE"] = Article["REF_ARTICLE"];
                    drv["DESIGNATION_ARTICLE"] = Article["DESIGNATION_ARTICLE"];
                    drv["LIB_UNITE"] = Article["LIB_UNITE"];
                    drv["QTE_FI"] = qte;
                    drv["TVA_FI"] = Article["TVA_ARTICLE"];
                    drv["P_HT_FI"] = Article["PRIX_HT_V_ARTICLE"];
                    drv["REMISE_FI"] = 0;
                    //calculerLigne();

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

        private void calculerLigne()
        {
            if (bsDetail.Current != null)
            {
                DataRowView drv = (DataRowView)bsDetail.Current;
                drv.BeginEdit();

                drv["P_U_TTC"] = (decimal)drv["P_HT_FI"] * (1 - (decimal)drv["REMISE_FI"] / 100) * (1 + (decimal)drv["TVA_FI"] / 100);
                drv["P_TOT_TTC"] = (decimal)drv["P_U_TTC"] * (decimal)drv["QTE_FI"];

                drv.EndEdit();
                (bs.DataSource as DataTable).AcceptChanges();
            }
        }

        private void btn_SUPPRIMER_ARTICLE_Click(object sender, EventArgs e)
        {
            if (bsDetail.Current != null && MessageBox.Show("Etes vous sures de supprimer cet article?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bsDetail.RemoveCurrent();
                (bsDetail.DataSource as DataTable).AcceptChanges();
            }
        }

        private void btn_Cloturer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres de cloturer cette fiche d'entretien?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Fiche.NUM_FI = txt_NUM_FI.Text;
                Fiche.DATE_CLOTURE = CLIENT_APP_PARAM.gcws.getDateS();
                Fiche.USER_CLOTURE = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);

                RESULT_QUERY res = new RESULT_QUERY();
                try
                {
                    Cursor = Cursors.WaitCursor;
                    res = CLIENT_APP_PARAM.gcws.CloturerFICHE_INTERVENTION(Fiche);
                    if (res.OK)
                    {
                        chbx_CLOTURE.Checked = true;

                        bs.EndEdit();
                        (bs.DataSource as DataTable).AcceptChanges();

                        MessageBox.Show(res.MESSAGE, this.Text);
                        ValidateChanges = true;
                        //Close();
                    }
                    else
                    {
                        ValidateChanges = false;
                        MessageBox.Show(res.MESSAGE, this.Text);
                    }
                }
                catch (Exception er)
                {

                    MessageBox.Show(er.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btn_TC_Click(object sender, EventArgs e)
        {
            if (chbx_CLOTURE.Checked)
            {
                CHM_FRM_REG f = new CHM_FRM_REG(Convert.ToDecimal(gridColumn2.SummaryText), "TC");
                f.StartPosition = FormStartPosition.CenterScreen;
                f.OnPaiement += new CHM_FRM_REG.Paiement(f_OnPaiement);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Vous devez tout d'abord clôturer la fiche d'entretien!", this.Text);

        }

        void f_OnPaiement(decimal NetAPayer, decimal MntReçu, decimal Reste, DataTable dtReglement)
        {
            try
            {
                decimal montantHt = Convert.ToDecimal(gridColumn5.SummaryText);
                decimal montantTVA = Convert.ToDecimal(gridColumn3.SummaryText);
                decimal montantRemise = Convert.ToDecimal(gridColumn4.SummaryText);
                DataTable dtDetail = new DataTable("details");

                foreach (DataColumn col in dS_MOUV1.LG_FI.Columns)
                {
                    dtDetail.Columns.Add(col.ColumnName, col.DataType);

                }

                foreach (DataRow dr in dS_MOUV1.LG_FI.Rows)
                {
                    dtDetail.ImportRow(dr);
                }

                decimal codeclt = (decimal)(bs.Current as DataRowView)["CODE_CLIENT"];
                RESULT_QUERY res = new RESULT_QUERY();
                res = CLIENT_APP_PARAM.gcws.REGLER_FI_TC(CLIENT_APP_PARAM.gcws.getDateS(), codeclt, montantHt
                    , montantTVA, NetAPayer, montantRemise, "", MntReçu, Reste, Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG),
                    Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), dtDetail, (bs.Current as DataRowView)["NUM_FI"].ToString(), dtReglement);

                if (res.OK)
                {
                    MessageBox.Show(res.MESSAGE, this.Text);

                    (bs.Current as DataRowView)["CODE_B_LIV"] = res.CODE;
                    (bs.DataSource as DataTable).AcceptChanges();
                    Close();
                }
                else
                {
                    throw new Exception(res.MESSAGE);
                }
            }
            catch (Exception er)
            {

                throw er;
            }
        }





        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView1.UpdateCurrentRow();
            calculerLigne();
        }

        private void gridView1_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {

        }

        private void CHM_FRM_MAJ_FI_Load(object sender, EventArgs e)
        {
            btn_TC.Enabled = chbx_CLOTURE.Checked && txt_CODE_B_LIV.Text.Trim() == string.Empty;
        }

        private void btnSelectEqp_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_EQP f = new CHM_FRM_LISTE_EQP("select");
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnSelect += new CHM_FRM_LISTE_EQP.Selection(SelectEqp);
            f.ShowDialog();
        }

        void SelectEqp(DEQUIPEMENT eqp)
        {
            lbCode.Text = eqp.CODE_EQP.ToString();
            txtLibelle.Text = eqp.LIBELLE_EQP;
            txtFabriquant.Text = eqp.FABRIQUANT;
            txtSerie.Text = eqp.NUM_SERIE;
            dtpDateFabrication.Value = eqp.DATE_FAB_EQP;
            dtpDateService.Value = eqp.DATE_MISE_SERVICE_EQP;
            txt_REF_CLIENT.Text = eqp.REF_CLIENT;
            txt_REF_CLIENT.Tag = eqp.CODE_CLIENT;
            txt_RS_CLIENT.Text = eqp.RS_CLIENT;
            txt_TEL_CLIENT.Text = eqp.TEL_CLIENT;
        }

        


    }
}
