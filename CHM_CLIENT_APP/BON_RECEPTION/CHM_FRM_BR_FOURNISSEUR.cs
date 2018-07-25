using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.BON_RECEPTION
{
    public partial class CHM_FRM_BR_FOURNISSEUR : Form
    {
        decimal _CODE_BRECEP = -1;
        decimal _code_fournisseur;
        decimal _code_magazin;

        DataTable _dt_br;

        DataTable _dt_article;
        string _cb_art_selectionne = "";
        DataTable _article_selectionne;
        DataTable _dt_details_br;
        BindingSource _bs_details_br= new BindingSource();

        public delegate void EnregistrementBR(decimal Code);
        public event EnregistrementBR OnSave;

        public CHM_FRM_BR_FOURNISSEUR(decimal CODE_BRECEP)
        {
            InitializeComponent();
            _CODE_BRECEP = CODE_BRECEP;
            

            Cursor = Cursors.WaitCursor;

            dS_MOUV1.SOCIETE.ImportRow(CLIENT_APP_PARAM.ds_param.SOCIETE.Rows[0]);
            
            //cbx_magazin.DataSource = CLIENT_APP_PARAM.GEST.P_MAGAZIN.SELECT_ALL_MAGAZIN();
            cbx_magazin.DataSource = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
            cbx_magazin.DisplayMember = "NOM_MAG";
            cbx_magazin.ValueMember = "CODE_MAG";
            //_dt_article = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_ALL_ARTICLE();
            //_dt_article = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE();
            _bs_details_br.DataSource = dS_MOUV1.LG_BR_FR;
            gridControl1.DataSource = _bs_details_br;
            if (_CODE_BRECEP == -1)
            {                
                //_dt_details_br = CLIENT_APP_PARAM.GEST.P_BR_FR.LOAD_SCHEMA_LIGNE_BR();
                
                
            }
            else
            {
                //_dt_br = CLIENT_APP_PARAM.GEST.P_BR_FR.LOAD_BR_FR(_CODE_BRECEP);
                _dt_br = CLIENT_APP_PARAM.gcws.LOAD_BR_FR(_CODE_BRECEP);
                txt_fournisseur.Text = _dt_br.Rows[0]["RS_FOURNISSEUR"].ToString();
                txt_NUM_ORDER.Text = _dt_br.Rows[0]["CODE_BR_FR"].ToString();
                cbx_magazin.SelectedValue = (decimal)_dt_br.Rows[0]["CODE_MAG"];
                cbx_magazin.Enabled = false;
                dateTimePicker1.Value = Convert.ToDateTime(_dt_br.Rows[0]["DATE_BR_FR"].ToString());

                //_dt_details_br = CLIENT_APP_PARAM.GEST.P_BR_FR.LOAD_LIGNES_BR_FR(_CODE_BRECEP);
                //_dt_details_br = CLIENT_APP_PARAM.gcws.LOAD_LIGNES_BR_FR(_CODE_BRECEP);
                //_bs_details_br.DataSource = _dt_details_br;
                dS_MOUV1.LG_BR_FR.Merge(CLIENT_APP_PARAM.gcws.LOAD_LIGNES_BR_FR(_CODE_BRECEP));

                calculer_montant();
                nud_pourcentage_remise.Value = (decimal)_dt_br.Rows[0]["REMISE"];
                calculer_montant();
            }
            Cursor = Cursors.Default;
        }

        public CHM_FRM_BR_FOURNISSEUR(BindingSource BsBrRECEP)
        {
            InitializeComponent();
            
            

            Cursor = Cursors.WaitCursor;
            //cbx_magazin.DataSource = CLIENT_APP_PARAM.GEST.P_MAGAZIN.SELECT_ALL_MAGAZIN();
            cbx_magazin.DataSource = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
            cbx_magazin.DisplayMember = "NOM_MAG";
            cbx_magazin.ValueMember = "CODE_MAG";
            //_dt_article = CLIENT_APP_PARAM.GEST.P_ARTICLE.SELECT_ALL_ARTICLE();
            _dt_article = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE();
            if (_CODE_BRECEP == -1)
            {                
                //_dt_details_br = CLIENT_APP_PARAM.GEST.P_BR_FR.LOAD_SCHEMA_LIGNE_BR();
               
            }
            else
            {
                //_dt_br = CLIENT_APP_PARAM.GEST.P_BR_FR.LOAD_BR_FR(_CODE_BRECEP);
                _dt_br = CLIENT_APP_PARAM.gcws.LOAD_BR_FR(_CODE_BRECEP);
                txt_fournisseur.Text = _dt_br.Rows[0]["RS_FOURNISSEUR"].ToString();
                txt_NUM_ORDER.Text = _dt_br.Rows[0]["CODE_BR_FR"].ToString();
                cbx_magazin.SelectedValue = (decimal)_dt_br.Rows[0]["CODE_MAG"];
                cbx_magazin.Enabled = false;
                dateTimePicker1.Value = Convert.ToDateTime(_dt_br.Rows[0]["DATE_BR_FR"].ToString());

                //_dt_details_br = CLIENT_APP_PARAM.GEST.P_BR_FR.LOAD_LIGNES_BR_FR(_CODE_BRECEP);
                
                calculer_montant();
                nud_pourcentage_remise.Value = (decimal)_dt_br.Rows[0]["REMISE"];
                calculer_montant();
            }
            Cursor = Cursors.Default;
        }

        private void CHM_FRM_BR_FOURNISSEUR_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _cb_art_selectionne = textBox2.Text;
                textBox2.Text = "";
                timer1.Enabled = false;
                _article_selectionne = CLIENT_APP_PARAM.gcws.SELECT_BY_BARCODE(_cb_art_selectionne);
                if (_article_selectionne.Rows.Count > 0)
                {
                    label5.Text = _article_selectionne.Rows[0]["REF_ARTICLE"] + "\n" + _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                    nud_prix.Value = 0;
                    qte_select_article.Value = 1;
                    qte_select_article.Focus();
                    qte_select_article.Select();
                    panel_qte.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cet article n'est pas enregistré dans votre base.", "CHM Commercial Management Program");
                }
                calculer_montant();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message,"Error");
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
            
            _code_fournisseur=(decimal)fournisseur["CODE_FOURNISSEUR"];
            txt_fournisseur.Text = (string)fournisseur["RS_FOURNISSEUR"];

            dS_MOUV1.LG_BR_FR.Clear();
            chcklist_cmdFr.Items.Clear();
            chcklist_cmdFr.DataSource = CLIENT_APP_PARAM.gcws.GetCOMMANDE_FOURNISSEUREnAttenteLivraisonParFournisseur(_code_fournisseur);
            chcklist_cmdFr.DisplayMember = "CODE_COMMANDE_FOURNISSEUR";
            chcklist_cmdFr.ValueMember = "CODE_COMMANDE_FOURNISSEUR";
        }

        private void buttonSUPPRIMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_br.Current != null)
                {
                    if (MessageBox.Show("Etes vous sûres de supprimer cet article?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        _bs_details_br.RemoveCurrent();
                        (_bs_details_br.DataSource as DataTable).AcceptChanges();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
            calculer_montant();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //timer1.Enabled = true;
        }

        private void cbx_magazin_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void panel_qte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_validation_ajout_Click(object sender, EventArgs e)
        {
            try
            {
                bool exist=false;
                foreach (DataRow dr_detail in dS_MOUV1.LG_BR_FR.Rows)
                {
                    if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == dr_detail["CODE_ARTICLE"].ToString())
                    {
                        dr_detail["QTE_LG_BR_FR"] = (decimal)dr_detail["QTE_LG_BR_FR"] + (decimal)qte_select_article.Value;
                        //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                        exist = true;
                        panel_qte.Visible = false;
                    }
                }
                if (!exist)
                {
                    _bs_details_br.AddNew();
                    DataRowView drv = (DataRowView)_bs_details_br.Current;
                    

                    drv["CODE_BRECEP"] = _CODE_BRECEP;
                    drv["CODE_BR_FR"] = "";
                    drv["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                    drv["REF_ARTICLE"] = _article_selectionne.Rows[0]["REF_ARTICLE"];
                    drv["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                    drv["QTE_LG_BR_FR"] = qte_select_article.Value;
                    drv["PRIX_ART_BR_FR"] = nud_prix.Value;
                    drv["UNITE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                    drv["TVA"] = _article_selectionne.Rows[0]["TAUX_TVA_ACHAT"];
                    drv["REMISE"] = 0;
                    drv["FODEC"] = 0;
                    drv["CODE_CMD_FR"] = "";
                    drv["CODE_FACT_FR"] = "";
                    _bs_details_br.EndEdit();
                    (_bs_details_br.DataSource as DataTable).AcceptChanges();
                    textBox2.Focus();
                    textBox2.Select();
                    panel_qte.Visible = false;
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
            calculer_montant();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_qte.Visible = false;
            label5.Text = "";
            qte_select_article.Value = 1;
            nud_prix.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox2.Select();
        }

        private void CHM_FRM_BR_FOURNISSEUR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            if (e.KeyCode == Keys.Escape)
            {
                if (panel_qte.Visible)
                {
                    panel_qte.Visible = false;
                    qte_select_article.Value = 1;
                    nud_prix.Value = 0;
                }
                else
                {
                    if (MessageBox.Show("Etes vous sures d'annuler ce bon de réception?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        this.Close();
                }
            }
        }

        private void buttonAJOUTER_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_ARTICLE f = new CHM_COMMANDE_ARTICLE("BR_FR");
            f.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(f_confirm_ajout);
            f.ShowDialog();
        }

        void f_confirm_ajout(DataRowView article, decimal qte, decimal prix)
        {
            try
            {
                bool exist = false;
                foreach (DataRow dr_detail in dS_MOUV1.LG_BR_FR.Rows)
                {
                    if (article["CODE_ARTICLE"].ToString() == dr_detail["CODE_ARTICLE"].ToString() && dr_detail["CODE_CMD_FR"].ToString() == "")
                    {
                        dr_detail["QTE_LG_BR_FR"] = (decimal)dr_detail["QTE_LG_BR_FR"] + qte;
                        //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                        exist = true;
                        panel_qte.Visible = false;
                    }
                }
                if (!exist)
                {
                    _bs_details_br.AddNew();
                    DataRowView drv = (DataRowView)_bs_details_br.Current;
                    drv["CODE_BRECEP"] = _CODE_BRECEP;
                    drv["CODE_BR_FR"] = "";
                    drv["CODE_ARTICLE"] = article["CODE_ARTICLE"];
                    drv["REF_ARTICLE"] = article["REF_ARTICLE"];
                    drv["DESIGNATION_ARTICLE"] = article["DESIGNATION_ARTICLE"];
                    drv["QTE_LG_BR_FR"] = qte;
                    drv["PRIX_ART_BR_FR"] = prix;
                    drv["UNITE"] = article["LIB_UNITE"];
                    drv["TVA"] = article["TAUX_TVA_ACHAT"];
                    drv["REMISE"] = 0;
                    drv["FODEC"] = 0;
                    drv["CODE_CMD_FR"] = "";
                    drv["CODE_FACT_FR"] = "";
                    _bs_details_br.EndEdit();
                    (_bs_details_br.DataSource as DataTable).AcceptChanges();
                    textBox2.Focus();
                    textBox2.Select();
                    panel_qte.Visible = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
            calculer_montant();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
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

                foreach (DataRow dr in dS_MOUV1.LG_BR_FR.Rows)
                {
                    montant_tva += (decimal)dr["QTE_LG_BR_FR"] * (decimal)dr["PRIX_ART_BR_FR"] * (1 - (decimal)dr["REMISE"] / 100) * (decimal)dr["TVA"] / 100;
                    montant_ht += (decimal)dr["QTE_LG_BR_FR"] * (decimal)dr["PRIX_ART_BR_FR"];
                    montant_remise += (decimal)dr["QTE_LG_BR_FR"] * (decimal)dr["PRIX_ART_BR_FR"] * (decimal)dr["REMISE"] / 100;
                    montant_ttc += (decimal)dr["QTE_LG_BR_FR"] * (decimal)dr["PRIX_ART_BR_FR"] * (1 - (decimal)dr["REMISE"] / 100) * (1 + (decimal)dr["TVA"] / 100);
                }
                lb_MNT_HT.Value = montant_ht;
                lb_MNT_REMISE.Value = montant_remise;
                lb_MNT_TVA.Value = montant_tva;
                lb_MNT_TTC.Value = montant_ttc;
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

        private void buttonENREGISTRER_Click(object sender, EventArgs e)
        {
            #region Validation des champs
            errorProvider1.SetError(txt_fournisseur, "");
            {
                if (txt_fournisseur.Text.Trim() == "")
                {
                    errorProvider1.SetError(button2, "Saisir Fournisseur!");
                    button2.Focus();
                    return;
                }
            }

            errorProvider1.SetError(cbx_magazin, "");
            {
                if (cbx_magazin.SelectedValue == null)
                {
                    errorProvider1.SetError(cbx_magazin, "Sélectionner le Magasin!");
                    cbx_magazin.Focus();
                    return;
                }
            }

            errorProvider1.SetError(txt_NUM_ORDER, "");
            {
                if (txt_NUM_ORDER.Text.Trim() == "")
                {
                    errorProvider1.SetError(txt_NUM_ORDER, "N° de BL Fournisseur manquant!");
                    txt_NUM_ORDER.Focus();
                    txt_NUM_ORDER.Select();
                    return;
                }
            }

            errorProvider1.SetError(gridControl1, "");
            {
                if (dS_MOUV1.LG_BR_FR.Rows.Count==0)
                {
                    errorProvider1.SetError(gridControl1, "Rien à enregistrer");
                    return;
                }
            }
            #endregion
            
            if (MessageBox.Show("Etes vous sûres d'enregistrer le bon de réception?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _dt_details_br = new DataTable("dtDetails");
                foreach (DataColumn c in dS_MOUV1.LG_BR_FR.Columns)
                {
                    DataColumn newCol = new DataColumn();
                    newCol.ColumnName = c.ColumnName;
                    newCol.DataType = c.DataType;

                    _dt_details_br.Columns.Add(newCol);
                }

                foreach (DataRow  dr in dS_MOUV1.LG_BR_FR.Rows)
                {
                    _dt_details_br.ImportRow(dr);
                }
                if (_CODE_BRECEP == -1)
                {
                    try
                    {

                        Cursor = Cursors.WaitCursor;
                        Application.DoEvents();
                        //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_BR_FR.INSERT_BR_FR(txt_NUM_ORDER.Text, _code_fournisseur, (decimal)cbx_magazin.SelectedValue, dateTimePicker1.Value, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), NP.Value, nud_pourcentage_remise.Value, _dt_details_br);
                        CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.INSERT_BR_FR(txt_NUM_ORDER.Text, _code_fournisseur, (decimal)cbx_magazin.SelectedValue, dateTimePicker1.Value, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), lb_MNT_HT.Value, nud_pourcentage_remise.Value, _dt_details_br);
                        if (res.OK)
                        {
                            MessageBox.Show(res.MESSAGE, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonENREGISTRER.Enabled = false;
                            if (OnSave != null)
                            {
                                OnSave(_CODE_BRECEP);
                            }

                            if (MessageBox.Show("Vouler vous visualiser le bon de réception?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                ReportDocument rpt = new BON_RECEPTION.RPT_BR_FR();
                                //DataTable dt = CLIENT_APP_PARAM.GEST.P_BR_FR.IMPRIMER_BRECEP_FR(Convert.ToDecimal(res.CODE));
                                DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_BRECEP_FR(Convert.ToDecimal(res.CODE));
                                rpt.SetDataSource(dt);

                                CHM_ETATS f = new CHM_ETATS();
                                f.CHM_Aperçu_document.ReportSource = rpt;
                                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                                f.Show();
                            }


                            Close();
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
                else
                {
                    try
                    {

                        Cursor = Cursors.WaitCursor;
                        Application.DoEvents();
                        //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_BR_FR.UPDATE_BR_FR(_CODE_BRECEP, txt_NUM_ORDER.Text, _code_fournisseur, (decimal)cbx_magazin.SelectedValue, dateTimePicker1.Value, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), NP.Value, nud_pourcentage_remise.Value, _dt_details_br);
                        CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.UPDATE_BR_FR(_CODE_BRECEP, txt_NUM_ORDER.Text, _code_fournisseur, (decimal)cbx_magazin.SelectedValue, dateTimePicker1.Value, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), lb_MNT_HT.Value, nud_pourcentage_remise.Value, _dt_details_br);
                        if (res.OK)
                        {
                            MessageBox.Show(res.MESSAGE, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonENREGISTRER.Enabled = false;
                            ReportDocument rpt = new BON_RECEPTION.RPT_BR_FR();
                            //DataTable dt = CLIENT_APP_PARAM.GEST.P_BR_FR.IMPRIMER_BRECEP_FR(Convert.ToDecimal(res.CODE));
                            DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_BRECEP_FR(Convert.ToDecimal(res.CODE));
                            rpt.SetDataSource(dt);

                            CHM_ETATS f = new CHM_ETATS();
                            f.CHM_Aperçu_document.ReportSource = rpt;
                            f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                            f.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
            }

        }

        private void panel_qte_VisibleChanged(object sender, EventArgs e)
        {
            if ((sender as Control).Visible)
            {
                gridControl1.Enabled = false;
                qte_select_article.Focus();
            }
            else
            {
                nud_prix.Value = 0;
                gridControl1.Enabled = true;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (lb_MNT_HT.Value > 0)
            {
                nud_pourcentage_remise.Value = nud_total_remise.Value * 100 / lb_MNT_HT.Value;
                lb_MNT_TTC.Value = lb_MNT_HT.Value - nud_total_remise.Value;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (lb_MNT_HT.Value > 0)
            {
                nud_total_remise.Value =  lb_MNT_HT.Value/100 * nud_pourcentage_remise.Value;
                lb_MNT_TTC.Value = lb_MNT_HT.Value - nud_total_remise.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLIENT_APP_PARAM.ds_param.bsArticle.AddNew();
            CHM_NV_ARTICLE f = new CHM_NV_ARTICLE(CLIENT_APP_PARAM.ds_param.bsArticle);
            f.Enregistrer += new CHM_NV_ARTICLE.Enregistrer_event(f_Enregistrer);
            f.ShowDialog();
        }

        void f_Enregistrer(DataRowView dr, bool nouv)
        {
            try
            {


                if (nouv)
                {
                    CLIENT_APP_PARAM.ds_param.bsArticle.EndEdit();
                    ((DataTable)CLIENT_APP_PARAM.ds_param.bsArticle.DataSource).AcceptChanges();
                }
                else
                {
                    CLIENT_APP_PARAM.ds_param.bsArticle.CancelEdit();
                    (CLIENT_APP_PARAM.ds_param.bsArticle.DataSource as DataTable).RejectChanges();
                } 
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            calculer_montant();
        }

        private void chcklist_cmdFr_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            try
            {
                if (e.State == CheckState.Checked)
                {
                    string numCmd = (sender as DevExpress.XtraEditors.CheckedListBoxControl).SelectedValue.ToString();
                    DataTable dt = CLIENT_APP_PARAM.gcws.GetDetailsCommandeFournisseurEnAttenteLivraison(numCmd);
                    foreach (DataRow dr in dt.Rows)
                    {
                        _bs_details_br.AddNew();
                        DataRowView drv = (DataRowView)_bs_details_br.Current;
                        drv["CODE_BRECEP"] = _CODE_BRECEP;
                        drv["CODE_BR_FR"] = "";
                        drv["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drv["REF_ARTICLE"] = dr["REF_ARTICLE"];
                        drv["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                        drv["QTE_LG_BR_FR"] = (decimal)dr["QTE"] - (decimal)dr["QTE_LIVREE"];
                        drv["PRIX_ART_BR_FR"] = dr["PRIX_HT"];
                        drv["UNITE"] = dr["UNITE"];
                        drv["TVA"] = dr["TAUX_TVA"];
                        drv["REMISE"] = dr["REMISE"];
                        drv["FODEC"] = dr["FODEC"];
                        drv["CODE_CMD_FR"] = dr["CODE_COMMANDE_FOURNISSEUR"];
                        drv["CODE_FACT_FR"] = "";
                        _bs_details_br.EndEdit();
                        (_bs_details_br.DataSource as DataTable).AcceptChanges();
                        textBox2.Focus();
                        textBox2.Select();
                        panel_qte.Visible = false;
                    }
                }
                else
                {
                    string numCmd = (sender as DevExpress.XtraEditors.CheckedListBoxControl).SelectedValue.ToString();
                    DataTable dt = CLIENT_APP_PARAM.gcws.GetDetailsCommandeFournisseurEnAttenteLivraison(numCmd);

                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataRow drsource in dS_MOUV1.LG_BR_FR.Rows)
                        {
                            if (drsource["CODE_CMD_FR"].ToString() == dr["CODE_COMMANDE_FOURNISSEUR"].ToString() && drsource["CODE_ARTICLE"].ToString() == dr["CODE_ARTICLE"].ToString())
                            {
                                dS_MOUV1.LG_BR_FR.Rows.Remove(drsource);
                                dS_MOUV1.LG_BR_FR.AcceptChanges();
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

       

        
    }
}
