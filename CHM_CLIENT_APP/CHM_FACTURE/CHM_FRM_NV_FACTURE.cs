using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraGrid.Views.Grid;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.CHM_FACTURE
{
    public partial class CHM_FRM_NV_FACTURE : Form
    {

        string _CODE_B_LIV;
        decimal CODE_CLIENT;
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();

        DataTable dt_b_liv_client;
        BindingSource bs_b_liv_client = new BindingSource();
        DataTable dt_lg_b_liv_client;
        BindingSource bs_lg_b_liv_client = new BindingSource();
        DataTable dt_ligne_facture;
        BindingSource bs_ligne_facture = new BindingSource();
        string REMARQUE = "Bons de livraison généré(s) dans la facture : ";
        decimal CODE_MAG;
        List<string> bl_facture = new List<string>();



        BindingSource bs_Detail_fc = new BindingSource();
        BindingSource bsPieceSansFacture = new BindingSource();

        public delegate void ENREGISTREMENT(string codeFacture);
        public event ENREGISTREMENT OnSave;

        public CHM_FRM_NV_FACTURE(string code_bl, decimal CODE_MAG)
        {
            InitializeComponent();
            _CODE_B_LIV = code_bl;
            bs_Detail_fc = new BindingSource();
            bs_Detail_fc.DataSource = dS_MOUV1.LIGNE_FACTURE;
            gridControl1.DataSource = bs_Detail_fc;
            try
            {
                dt_ligne_facture = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_BON_LIVRAISON();
                bs_ligne_facture.DataSource = dt_ligne_facture;
                dataGridViewLG_B_LIV.AutoGenerateColumns = false;
                dataGridViewLG_B_LIV.DataSource = bs_ligne_facture;


                dt_b_liv_client = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_FACTURE(_CODE_B_LIV);
                CODE_CLIENT = (decimal)dt_b_liv_client.Rows[0]["CODE_CLIENT"];
                dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT(CODE_CLIENT.ToString());

                bs_client.DataSource = dt_client;
                bs_client.MoveFirst();
                DataRowView drv_clt = (DataRowView)bs_client.Current;
                REF_CLIENT.Text = drv_clt["REF_CLIENT"].ToString();
                RS_CLIENT.Text = drv_clt["RS_CLIENT"].ToString();
                TEL_CLIENT.Text = drv_clt["TEL_CLIENT"].ToString();

                TIMBRE.Value = Convert.ToDecimal(CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1).Replace(',', '.'));

                chargerPieceSansFactureClient(CODE_CLIENT);
                //chargerBonLivraisonClient(CODE_CLIENT);
                //foreach (Control c in p_Commandes_ENCOURS.Controls)
                //{
                //    if (c.Name == _CODE_B_LIV)
                //    {
                //        (c as CHM_SELECTION_CONTROL).selection_state.Checked = true;
                //        break;
                //    }
                //}
                foreach (DataRow dr in dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Rows)
                {
                    if (dr["CODE_PIECE"].ToString() == _CODE_B_LIV)
                    {
                        dr["CHECKED"] = "True";
                        break;
                    }
                }

                rb_periode_CheckedChanged(null, null);

                chM_CMP_VALIDATION1.button1.Click += new EventHandler(BTN_ENREGISTRER_Click);
                chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
                entete_Formulaire_21.btn_refresh.Visible = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        public CHM_FRM_NV_FACTURE(decimal CODE_MAG)
        {
            InitializeComponent();
            try
            {
                bs_Detail_fc.DataSource = dS_MOUV1.LIGNE_FACTURE;
                gridControl1.DataSource = bs_Detail_fc;

                bsPieceSansFacture.DataSource = dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE;
                gridControl2.DataSource = bsPieceSansFacture;
                gridControl3.DataSource = bsPieceSansFacture;
                string v = CLIENT_APP_PARAM.gcws.GetParamValue("TIMBRE", 1);
                TIMBRE.Value = Convert.ToDecimal(v.Replace(',', '.'));
                dt_ligne_facture = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_BON_LIVRAISON();
                bs_ligne_facture.DataSource = dt_ligne_facture;
                rb_periode_CheckedChanged(null, null);
                chM_CMP_VALIDATION1.button1.Click += new EventHandler(BTN_ENREGISTRER_Click);
                chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
                entete_Formulaire_21.btn_refresh.Visible = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void PARCOURIR_LISTE_CLIENT_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_CLIENT f = new CHM_COMMANDE_CLIENT();
            f.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(f_client_selection_event);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void f_client_selection_event(DCLIENT client)
        {
            try
            {

                CODE_CLIENT = client.CODE_CLIENT;
                REF_CLIENT.Text = client.REF_CLIENT.ToString();
                RS_CLIENT.Text =client.RS_CLIENT.ToString();
                TEL_CLIENT.Text = client.TEL_CLIENT.ToString();

                dt_ligne_facture = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_BON_LIVRAISON();
                bs_ligne_facture.DataSource = dt_ligne_facture;
                dataGridViewLG_B_LIV.AutoGenerateColumns = false;
                dataGridViewLG_B_LIV.DataSource = bs_ligne_facture;
                //chargerBonLivraisonClient(CODE_CLIENT);
                chargerPieceSansFactureClient(CODE_CLIENT);
                gridControl3.DataSource = bsPieceSansFacture;

                dS_MOUV1.LIGNE_FACTURE.Clear();

                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void chargerPieceSansFactureClient(decimal codeClient)
        {
            dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Clear();
            dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Merge(CLIENT_APP_PARAM.gcws.GET_PIECE_NON_FACTURE_CLIENT(codeClient));
        }

        private void calculerLigneBL()
        {
            try
            {
                if (bs_ligne_facture.Current != null)
                {
                    DataRowView drv_edit = (DataRowView)bs_ligne_facture.Current;
                    drv_edit.BeginEdit();


                    drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)drv_edit["PRIX_HT_B_LIV"];

                    drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                    drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                    drv_edit.EndEdit();
                    dt_ligne_facture.AcceptChanges();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void calculerFacture()
        {
            decimal montant_ht = 0;
            decimal montant_remise = 0;
            decimal montant_tva = 0;
            decimal montant_ttc = 0;
            foreach (DataRow dr in dS_MOUV1.LIGNE_FACTURE.Rows)
            {
                montant_ht += (decimal)dr["PRIX_TOTAL_HT"];
                montant_remise += (decimal)dr["PRIX_HT_ARTICLE"] * (decimal)dr["REMISE"] / 100 * (decimal)dr["QTE"];
                montant_ttc += (decimal)dr["PRIX_TOTAL_TTC"];
                montant_tva += (decimal)dr["PRIX_TOTAL_HT"] * (1 - (decimal)dr["REMISE"] / 100) * (decimal)dr["TVA_ARTICLE"] / 100;
            }
            HT.Value = montant_ht;
            TAUX_REMISE.Value = montant_remise;
            TVA.Value = montant_tva;
            TTC.Value = montant_ttc;
            NP.Value = montant_ttc + TIMBRE.Value;
            ML.Text = string.Format("Arretée la présente facture à la somme de {0}", new NUM_TO_LETTRE.NumberToLetter().ConvertirDinars(NP.Value));
            REMARQUE = "Bons de livraison généré(s) dans la facture : ";
            bl_facture = new List<string>();
            foreach (Control c in p_Commandes_ENCOURS.Controls)
            {
                if ((c as CHM_SELECTION_CONTROL).selection_state.Checked)
                {
                    REMARQUE += (c as CHM_SELECTION_CONTROL).entete.Text;
                    bl_facture.Add((c as CHM_SELECTION_CONTROL).entete.Text);
                }
            }
        }

        private void chargerBonLivraisonClient(decimal code_client)
        {
            try
            {
                p_Commandes_ENCOURS.Controls.Clear();
                dt_b_liv_client = CLIENT_APP_PARAM.gcws.LOAD_B_LIV_CLIENT_NON_GENERE(code_client.ToString());
                bs_b_liv_client.DataSource = dt_b_liv_client;

                foreach (DataRow dr in dt_b_liv_client.Rows)
                {
                    CHM_BON_DE_LIVRAISON.CHM_SELECTION_CONTROL c = new CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON.CHM_SELECTION_CONTROL();
                    c.Name = dr["CODE_B_LIV"].ToString();
                    c.entete.Text = dr["CODE_B_LIV"].ToString();
                    c.detail.Text = string.Format("Date : {0}  Montant TTC : {1}", dr["DATE_B_LIV"], dr["SOMME_B_LIV"]);
                    c.selection_state.Checked = false;
                    c.selection_state.CheckedChanged += new EventHandler(selection_state_CheckedChanged);
                    c.LB_TYPE.Text = "BL";
                    p_Commandes_ENCOURS.Controls.Add(c);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        void selection_state_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if ((sender as CheckBox).Checked)
                {
                    dt_lg_b_liv_client = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV((sender as CheckBox).Parent.Name);
                    bs_lg_b_liv_client.DataSource = dt_lg_b_liv_client;
                    foreach (DataRow dr in dt_lg_b_liv_client.Rows)
                    {
                        bs_Detail_fc.AddNew();
                        DataRowView drvDetail = (DataRowView)bs_Detail_fc.Current;
                        drvDetail["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                        drvDetail["CODE_FACTURE"] = "";
                        drvDetail["CODE_BL"] = dr["CODE_B_LIV"];
                        drvDetail["TYPE_PIECE"] = ((sender as Control).Parent.Controls["LB_TYPE"].Text);
                        drvDetail["REF_ARTICLE"] = dr["CODE_ARTICLE"];
                        drvDetail["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                        drvDetail["DESCRIPTION_ARTICLE"] = dr["DESCRIPTION_ARTICLE"];
                        drvDetail["QTE"] = dr["QTE_LIGNE_B_LIV"];
                        drvDetail["UNITE"] = "";
                        drvDetail["TVA_ARTICLE"] = dr["TVA_B_LIV"];
                        drvDetail["REMISE"] = dr["REMISE"];
                        drvDetail["PRIX_HT_ARTICLE"] = dr["PRIX_HT_B_LIV"];


                        bs_Detail_fc.EndEdit();
                        (bs_Detail_fc.DataSource as DataTable).AcceptChanges();


                        decimal qte = 0;
                        bool exist = false;
                        foreach (DataRowView drv_exist in bs_ligne_facture)
                        {
                            if ((decimal)drv_exist["CODE_ARTICLE"] == (decimal)dr["CODE_ARTICLE"])
                            {
                                exist = true;
                                qte = (decimal)drv_exist["QTE_LIGNE_B_LIV"];
                                break;
                            }
                        }
                        if (!exist)
                        {
                            bs_ligne_facture.AddNew();
                            DataRowView drv_add = (DataRowView)bs_ligne_facture.Current;
                            drv_add.BeginEdit();
                            drv_add["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                            drv_add["REF_ARTICLE"] = dr["REF_ARTICLE"];
                            drv_add["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                            drv_add["QTE_LIGNE_B_LIV"] = dr["QTE_LIGNE_B_LIV"];
                            drv_add["PRIX_HT_B_LIV"] = dr["PRIX_HT_B_LIV"];
                            drv_add["PRIX_TOTAL_HT"] = (decimal)drv_add["QTE_LIGNE_B_LIV"] * (decimal)dr["PRIX_HT_B_LIV"];
                            drv_add["REMISE"] = dr["REMISE"];
                            drv_add["TVA_B_LIV"] = dr["TVA_B_LIV"];
                            drv_add["PRIX_U_TTC"] = ((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) + (((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) * (decimal)drv_add["TVA_B_LIV"] / 100);
                            drv_add["PRIX_TOTAL_TTC"] = (decimal)drv_add["PRIX_U_TTC"] * (decimal)drv_add["QTE_LIGNE_B_LIV"];
                            drv_add["CODE_COMMANDE"] = dr["CODE_B_LIV"];
                            //drv_add["QTTE_STOCK"] = dr["QTTE_STOCK"];
                            //drv_add["MAX_REMISE"] = dr["MAX_REMISE"];
                            drv_add.EndEdit();
                            dt_ligne_facture.AcceptChanges();


                        }
                        else
                        {

                            bs_ligne_facture.Position = bs_ligne_facture.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]);
                            DataRowView drv_edit = (DataRowView)bs_ligne_facture.Current;
                            drv_edit.BeginEdit();
                            //if ((decimal)drv_edit["QTE_LIGNE_B_LIV"] + (decimal)dr["QTE"] <= (decimal)dr["QTTE_STOCK"])
                            drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] + (decimal)dr["QTE_LIGNE_B_LIV"];
                            //else
                            //    drv_edit["QTE_LIGNE_B_LIV"] = (decimal)dr["QTTE_STOCK"];

                            drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)dr["PRIX_HT_B_LIV"];
                            drv_edit["TVA_B_LIV"] = dr["TVA_B_LIV"];
                            drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                            drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                            drv_edit.EndEdit();
                            dt_ligne_facture.AcceptChanges();
                        }
                    }
                }
                else
                {
                    foreach (DataRow drDetail in dS_MOUV1.LIGNE_FACTURE.Rows)
                    {
                        if (drDetail["CODE_BL"].ToString() == (sender as CheckBox).Parent.Name)
                        {
                            drDetail.Delete();

                        }
                    }
                    dS_MOUV1.LIGNE_FACTURE.AcceptChanges();
                    foreach (DataRow dr in dt_lg_b_liv_client.Rows)
                    {

                        decimal qte = 0;
                        bool exist = false;
                        foreach (DataRowView drv_exist in bs_ligne_facture)
                        {
                            if ((decimal)drv_exist["CODE_ARTICLE"] == (decimal)dr["CODE_ARTICLE"])
                            {
                                exist = true;
                                qte = (decimal)drv_exist["QTE_LIGNE_B_LIV"];
                                break;
                            }
                        }
                        if (exist)
                        {
                            if ((decimal)dr["QTE_LIGNE_B_LIV"] < qte)
                            {
                                bs_ligne_facture.Position = bs_ligne_facture.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]);
                                DataRowView drv_edit = (DataRowView)bs_ligne_facture.Current;
                                drv_edit.BeginEdit();
                                drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] - (decimal)dr["QTE_LIGNE_B_LIV"];
                                drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)dr["PRIX_HT_B_LIV"];
                                drv_edit["TVA_B_LIV"] = dr["TVA_B_LIV"];
                                drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                                drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];
                                drv_edit.EndEdit();
                                dt_ligne_facture.AcceptChanges();
                            }
                            else
                            {
                                bs_ligne_facture.RemoveAt(bs_ligne_facture.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]));
                                bs_ligne_facture.EndEdit();
                                dt_ligne_facture.AcceptChanges();
                            }
                        }
                    }
                }
                calculerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BTN_ENREGISTRER_Click(object sender, EventArgs e)
        {
            #region Verification des champs
            if (xtraTabControl1.SelectedTabPageIndex == 0 && RS_CLIENT.Text == string.Empty)
            {
                MessageBox.Show("Veuillez sélectionner le client!", this.Text);
                return;
            }
            #endregion
            if (dS_MOUV1.LIGNE_FACTURE.Rows.Count > 0 && MessageBox.Show("Etes vous sûres d'enregistrer la facture?", "Enregistrement facture", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    DataTable dtDetailsFc = new DataTable("dtDetailsFc");
                    foreach (DataColumn c in dS_MOUV1.LIGNE_FACTURE.Columns)
                    {
                        DataColumn col = new DataColumn(c.ColumnName, c.DataType);
                        dtDetailsFc.Columns.Add(col);
                    }

                    foreach (DataRow dr in dS_MOUV1.LIGNE_FACTURE.Rows)
                    {

                        dtDetailsFc.ImportRow(dr);
                    }

                    Application.DoEvents();
                    string[] bl = new string[bl_facture.Count];
                    for (int i = 0; i < bl_facture.Count; i++)
                    {
                        bl[i] = bl_facture[i];
                    }
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_FACTURE.INSERT_FACTURE(DATE_FACTURE.Value, CODE_CLIENT, HT.Text, TVA.Value.ToString(), TTC.Value.ToString(), TAUX_REMISE.Value.ToString(), TTC.Value.ToString(), TIMBRE.Value.ToString(), NP.Value.ToString(), ML.Text, false, "Non reglée", TTC.Value.ToString(), CODE_MAG, CLIENT_APP_PARAM.Fenetre_principale.code_user, CLIENT_APP_PARAM.Fenetre_principale.prenom_user, CLIENT_APP_PARAM.Fenetre_principale.nom_user, REMARQUE, dt_lg_b_liv);

                    decimal credit = TIMBRE.Value;
                    foreach (DataRow dr in dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Rows)
                    {
                        if (dr["CHECKED"].ToString() == "True")
                        {
                            credit += (decimal)dr["RESTE_NP"];
                        }
                    }

                    CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.INSERT_FACTURE_CLIENT(DATE_FACTURE.Value, CODE_CLIENT.ToString(), HT.Value, TVA.Value, TTC.Value, TAUX_REMISE.Value, TTC.Value, TIMBRE.Value, NP.Value, ML.Text, false, "Non reglée", credit, CODE_MAG, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), CLIENT_APP_PARAM.Fenetre_principale.prenom_user, CLIENT_APP_PARAM.Fenetre_principale.nom_user, REMARQUE, dtDetailsFc, bl);
                    if (res.OK)
                    {
                        CODE_FACTURE.Text = res.CODE;
                        MessageBox.Show(res.MESSAGE, "Enregistrement de facture.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chM_CMP_VALIDATION1.button1.Enabled = false;

                        if (MessageBox.Show("Voulez vous imprimer la facture?", "Impression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            try
                            {
                                this.Cursor = Cursors.WaitCursor;
                                ReportDocument rpt = new CHM_RPT_FACTURE();
                                rpt.SetDataSource(CLIENT_APP_PARAM.gcws.Imprimer_FACTURE_CLIENT(res.CODE));
                                rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
                                rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                                rpt.PrintToPrinter(1, true, 0, 0);
                                this.Cursor = Cursors.Default;
                            }
                            catch (Exception print_er)
                            {
                                MessageBox.Show(print_er.Message, "Problème Impression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                this.Cursor = Cursors.Default;
                            }

                        }
                        if (OnSave != null) OnSave(res.CODE);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }


            }
            else
            {
                MessageBox.Show("Rien à facturer!", "Enregistrement facture", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CHM_FRM_NV_FACTURE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                if (chM_CMP_VALIDATION1.button1.Enabled)
                    chM_CMP_VALIDATION1.button1.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres de fermer la fenetre et annuler la facture?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CHM_FRM_NV_FACTURE_Load(object sender, EventArgs e)
        {

        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                string typePiece = View.GetRowCellValue(e.RowHandle, View.Columns["TYPE_PIECE"]).ToString();
                string codePiece = View.GetRowCellValue(e.RowHandle, View.Columns["CODE_PIECE"]).ToString();
                if (e.Column.Name == "colCHECKED")
                {

                    if ((Boolean)e.Value == true)
                    {
                        if (typePiece == "BL")
                        {
                            dt_lg_b_liv_client = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(codePiece);
                            bs_lg_b_liv_client.DataSource = dt_lg_b_liv_client;
                            foreach (DataRow dr in dt_lg_b_liv_client.Rows)
                            {
                                bs_Detail_fc.AddNew();
                                DataRowView drvDetail = (DataRowView)bs_Detail_fc.Current;
                                drvDetail["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                                drvDetail["CODE_FACTURE"] = "";
                                drvDetail["CODE_BL"] = dr["CODE_B_LIV"];
                                drvDetail["TYPE_PIECE"] = "BL";
                                drvDetail["REF_ARTICLE"] = dr["REF_ARTICLE"];
                                drvDetail["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                                drvDetail["DESCRIPTION_ARTICLE"] = dr["DESCRIPTION_ARTICLE"];
                                drvDetail["QTE"] = dr["QTE_LIGNE_B_LIV"];
                                drvDetail["UNITE"] = "";
                                drvDetail["TVA_ARTICLE"] = dr["TVA_B_LIV"];
                                drvDetail["REMISE"] = dr["REMISE"];
                                drvDetail["PRIX_HT_ARTICLE"] = dr["PRIX_HT_B_LIV"];


                                bs_Detail_fc.EndEdit();
                                (bs_Detail_fc.DataSource as DataTable).AcceptChanges();
                            }
                        }
                        if (typePiece == "TC")
                        {
                            dt_lg_b_liv_client = CLIENT_APP_PARAM.gcws.Get_Detail_TC(codePiece);
                            bs_lg_b_liv_client.DataSource = dt_lg_b_liv_client;
                            foreach (DataRow dr in dt_lg_b_liv_client.Rows)
                            {
                                bs_Detail_fc.AddNew();
                                DataRowView drvDetail = (DataRowView)bs_Detail_fc.Current;
                                drvDetail["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                                drvDetail["CODE_FACTURE"] = "";
                                drvDetail["CODE_BL"] = dr["CODE_TC"];
                                drvDetail["TYPE_PIECE"] = "TC";
                                drvDetail["REF_ARTICLE"] = dr["REF_ARTICLE"];
                                drvDetail["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                                drvDetail["DESCRIPTION_ARTICLE"] = "";
                                drvDetail["QTE"] = dr["QTE"];
                                drvDetail["UNITE"] = dr["UNITE"];
                                drvDetail["TVA_ARTICLE"] = dr["TVA"];
                                drvDetail["REMISE"] = dr["TAUX_REMISE"];
                                drvDetail["PRIX_HT_ARTICLE"] = dr["PRIX_HT"];


                                bs_Detail_fc.EndEdit();
                                (bs_Detail_fc.DataSource as DataTable).AcceptChanges();
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow drDetail in dS_MOUV1.LIGNE_FACTURE.Rows)
                        {
                            if (drDetail["CODE_BL"].ToString() == codePiece)
                            {
                                drDetail.Delete();

                            }
                        }
                        dS_MOUV1.LIGNE_FACTURE.AcceptChanges();
                    }
                }
                calculerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }
        

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            dS_MOUV1.LIGNE_FACTURE.Clear();
            dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Clear();
            if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                CODE_CLIENT = 1;
            }
            else
            {
                CODE_CLIENT = 0;
                RS_CLIENT.Text = REF_CLIENT.Text = TEL_CLIENT.Text = string.Empty;
            }
        }

        private void rb_Date_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_periode_CheckedChanged(object sender, EventArgs e)
        {
            de_Au.Visible = lbAu.Visible = rb_periode.Checked;
        }

        private void de_Au_EditValueChanged(object sender, EventArgs e)
        {
            if (rb_periode.Checked && de_Au.Value < de_DU.Value)
            {
                MessageBox.Show("Cette date doit être supérieure ou égale à la date de début de période");
                de_Au.Value = de_DU.Value;
                return;
            }
        }

        private void de_DU_EditValueChanged(object sender, EventArgs e)
        {
            if (rb_periode.Checked && de_Au.Value < de_DU.Value)
            {
                MessageBox.Show("Cette date doit être inférieure ou égale à la date de fin de période");
                de_DU.Value = de_Au.Value;
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dS_MOUV1.LIGNE_FACTURE.Clear();
                dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Clear();
                if (rb_Date.Checked)
                {
                    string date = de_DU.Value.ToShortDateString();
                    dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Merge(CLIENT_APP_PARAM.gcws.GET_TICKET_CAISSE_SANS_FACTURES_PAR_DATE(string.Format("{0}/{1}/{2}",de_DU.Value.Month, de_DU.Value.Day, de_DU.Value.Year)));
                }
                if (rb_periode.Checked)
                    dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Merge(CLIENT_APP_PARAM.gcws.GET_TICKET_CAISSE_SANS_FACTURES_PERIODE(/*de_DU.Value.ToShortDateString(), de_Au.Value.ToShortDateString()*/string.Format("{0}/{1}/{2}", de_DU.Value.Month, de_DU.Value.Day, de_DU.Value.Year), string.Format("{0}/{1}/{2}", de_Au.Value.Month, de_Au.Value.Day, de_Au.Value.Year)));
            }
            catch ( Exception er)
            {
                dS_MOUV1.LIGNE_FACTURE.Clear();
                dS_MOUV1.V_PIECE_CLIENT_SANS_FACTURE.Clear();
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, colCHECKED, "True");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, colCHECKED, "False");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                gridView3.SetRowCellValue(i, gridColumn8, "True");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                gridView3.SetRowCellValue(i, gridColumn8, "False");
            }
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                string typePiece = View.GetRowCellValue(e.RowHandle, View.Columns["TYPE_PIECE"]).ToString();
                string codePiece = View.GetRowCellValue(e.RowHandle, View.Columns["CODE_PIECE"]).ToString();
                if (e.Column.Name == "gridColumn8")
                {

                    if ((Boolean)e.Value == true)
                    {
                        if (typePiece == "BL")
                        {
                            dt_lg_b_liv_client = CLIENT_APP_PARAM.gcws.LOAD_LG_B_LIV(codePiece);
                            bs_lg_b_liv_client.DataSource = dt_lg_b_liv_client;
                            foreach (DataRow dr in dt_lg_b_liv_client.Rows)
                            {
                                bs_Detail_fc.AddNew();
                                DataRowView drvDetail = (DataRowView)bs_Detail_fc.Current;
                                drvDetail["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                                drvDetail["CODE_FACTURE"] = "";
                                drvDetail["CODE_BL"] = dr["CODE_B_LIV"];
                                drvDetail["TYPE_PIECE"] = "BL";
                                drvDetail["REF_ARTICLE"] = dr["REF_ARTICLE"];
                                drvDetail["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                                drvDetail["DESCRIPTION_ARTICLE"] = dr["DESCRIPTION_ARTICLE"];
                                drvDetail["QTE"] = dr["QTE_LIGNE_B_LIV"];
                                drvDetail["UNITE"] = "";
                                drvDetail["TVA_ARTICLE"] = dr["TVA_B_LIV"];
                                drvDetail["REMISE"] = dr["REMISE"];
                                drvDetail["PRIX_HT_ARTICLE"] = dr["PRIX_HT_B_LIV"];


                                bs_Detail_fc.EndEdit();
                                (bs_Detail_fc.DataSource as DataTable).AcceptChanges();
                            }
                        }
                        if (typePiece == "TC")
                        {
                            dt_lg_b_liv_client = CLIENT_APP_PARAM.gcws.Get_Detail_TC(codePiece);
                            bs_lg_b_liv_client.DataSource = dt_lg_b_liv_client;
                            foreach (DataRow dr in dt_lg_b_liv_client.Rows)
                            {
                                bs_Detail_fc.AddNew();
                                DataRowView drvDetail = (DataRowView)bs_Detail_fc.Current;
                                drvDetail["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                                drvDetail["CODE_FACTURE"] = "";
                                drvDetail["CODE_BL"] = dr["CODE_TC"];
                                drvDetail["TYPE_PIECE"] = "TC";
                                drvDetail["REF_ARTICLE"] = dr["REF_ARTICLE"];
                                drvDetail["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                                drvDetail["DESCRIPTION_ARTICLE"] = "";
                                drvDetail["QTE"] = dr["QTE"];
                                drvDetail["UNITE"] = dr["UNITE"];
                                drvDetail["TVA_ARTICLE"] = dr["TVA"];
                                drvDetail["REMISE"] = dr["TAUX_REMISE"];
                                drvDetail["PRIX_HT_ARTICLE"] = dr["PRIX_HT"];


                                bs_Detail_fc.EndEdit();
                                (bs_Detail_fc.DataSource as DataTable).AcceptChanges();
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow drDetail in dS_MOUV1.LIGNE_FACTURE.Rows)
                        {
                            if (drDetail["CODE_BL"].ToString() == codePiece)
                            {
                                drDetail.Delete();

                            }
                        }
                        dS_MOUV1.LIGNE_FACTURE.AcceptChanges();
                    }
                }
                calculerFacture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

    }
}
