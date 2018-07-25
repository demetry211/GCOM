using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON;
using CHM_CLIENT_APP.CHM_FACTURE;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_BON_LIVRAISON : Form
    {
        public delegate void WindowClose();
        public event WindowClose OnClose;

        List<string> NUM_FI = new List<string>();
        string CODE_CMD;
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();
        DataTable dt_commande;
        BindingSource bs_commande = new BindingSource();
        DataTable dt_lg_b_liv_prepare = new DataTable();
        BindingSource bs_lg_b_liv_prepare = new BindingSource();
        string CODE_CLIENT;
        int _mode = 0;

        public CHM_FICHE_BON_LIVRAISON(string CODE_CMD, DataTable dt_lg_cmd)
        {
            InitializeComponent();
            _mode = 0;
            //Initialisation
            this.CODE_CMD = CODE_CMD;

            chargerMagasins();
            gestionAcces();

            dt_commande = CLIENT_APP_PARAM.gcws.LOAD_COMMANDE(CODE_CMD);
            bs_commande.DataSource = dt_commande;
            bs_commande.MoveFirst();
            DataRowView drv_cmd = (DataRowView)bs_commande.Current;

            dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT(drv_cmd["CODE_CLIENT"].ToString());
            CODE_CLIENT = drv_cmd["CODE_CLIENT"].ToString();
            bs_client.DataSource = dt_client;
            bs_client.MoveFirst();
            DataRowView drv_clt = (DataRowView)bs_client.Current;
            REF_CLIENT.Text = drv_clt["REF_CLIENT"].ToString();
            RS_CLIENT.Text = drv_clt["RS_CLIENT"].ToString();
            TEL_CLIENT.Text = drv_clt["TEL_CLIENT"].ToString();

            dt_lg_b_liv_prepare = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_BON_LIVRAISON();
            bs_lg_b_liv_prepare.DataSource = dataSet11.LG_BON_LIVRAISON;
            gridControl1.DataSource = bs_lg_b_liv_prepare;

            chargerCommandesClient(Convert.ToDecimal(CODE_CLIENT));

            foreach (Control c in p_Commandes_ENCOURS.Controls)
            {
                if (c.Name == CODE_CMD)
                {
                    (c as CHM_SELECTION_CONTROL).selection_state.Checked = true;
                    break;
                }
            }

            entete_Formulaire_21.btn_refresh.Visible = false;
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(BTN_ENREGISTRER_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
        }

        void Fermeture(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sures annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        public CHM_FICHE_BON_LIVRAISON()
        {

            InitializeComponent();
            this.CODE_CMD = CODE_CMD;
            chargerMagasins();
            gestionAcces();
            try
            {
                dt_lg_b_liv_prepare = CLIENT_APP_PARAM.gcws.LOAD_SCHEMA_LG_BON_LIVRAISON();

                bs_lg_b_liv_prepare.DataSource = dataSet11.LG_BON_LIVRAISON;

                gridControl1.DataSource = bs_lg_b_liv_prepare;

                entete_Formulaire_21.btn_refresh.Visible = false;
                chM_CMP_VALIDATION1.button1.Click += new EventHandler(BTN_ENREGISTRER_Click);
                chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void chargerMagasins()
        {
            try
            {
                DataTable dt_magasin = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
                cbx_magasin.DataSource = dt_magasin;
                cbx_magasin.ValueMember = "CODE_MAG";
                cbx_magasin.DisplayMember = "NOM_MAG";
                cbx_magasin.SelectedValue = Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG);
                cbx_magasin.SelectedValueChanged += new EventHandler(cbx_magasin_SelectedValueChanged);


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cbx_magasin_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataSet11.LG_BON_LIVRAISON.Clear();
                //if (CODE_CLIENT != "")
                //{    
                //    chargerCommandesClient(Convert.ToDecimal(CODE_CLIENT));
                //}
                //else
                //{
                //    MessageBox.Show("Veuillez sélectionner le client!");
                //    errorProvider1.SetError(btn_client, "Veuillez sélectionner le client!");
                //    btn_client.Focus();
                //}


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        DataTable dt_article;
        BindingSource bs_article = new BindingSource();

        private void chargerArticles()
        {
            try
            {
                if (cbx_magasin.SelectedValue != null)
                {
                    dt_article = CLIENT_APP_PARAM.gcws.SELECT_ARTICLE_EN_STOCK_PAR_MAGASIN((decimal)cbx_magasin.SelectedValue);
                    bs_article.DataSource = dt_article;
                    //REF_ARTICLE_.DataSource = bs_article;
                    //REF_ARTICLE_.DisplayMember = "REF_ARTICLE";
                    //REF_ARTICLE_.ValueMember = "CODE_ARTICLE";

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }



        private void CHM_FICHE_BON_LIVRAISON_Shown(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void BTN_ENREGISTRER_Click(object sender, EventArgs e)
        {
            if (dataSet11.LG_BON_LIVRAISON.Rows.Count > 0)
            {
                if (MessageBox.Show("Etes vous sur d'enregistrer le bon de livraison?", "Vaalidation enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    try
                    {
                        Application.DoEvents();
                        CODE_CMD = "";
                        foreach (DataRow dr in dataSet11.LG_BON_LIVRAISON.Rows)
                        {
                            if (dr["CODE_COMMANDE"].ToString() != "" && !CODE_CMD.Contains(dr["CODE_COMMANDE"].ToString()))
                                CODE_CMD += dr["CODE_COMMANDE"].ToString();
                        }
                        //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_BON_LIVRAISON.SAVE(DATE_B_LIV.Value, CODE_CLIENT, CODE_CMD, CLIENT_APP_PARAM.Fenetre_principale.code_user, dt_lg_b_liv_prepare);
                        dt_lg_b_liv_prepare.Clear();
                        foreach (DataRow dr in dataSet11.LG_BON_LIVRAISON.Rows)
                        {
                            DataRow drDet = dt_lg_b_liv_prepare.NewRow();
                            drDet.BeginEdit();
                            drDet["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                            drDet["REF_ARTICLE"] = dr["REF_ARTICLE"];
                            drDet["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                            drDet["QTE_LIGNE_B_LIV"] = dr["QTE_LIGNE_B_LIV"];
                            drDet["PRIX_HT_B_LIV"] = dr["PRIX_HT_B_LIV"];
                            drDet["PRIX_TOTAL_HT"] = dr["PRIX_TOTAL_HT"];
                            drDet["REMISE"] = dr["REMISE"];
                            drDet["TVA_B_LIV"] = dr["TVA_B_LIV"];
                            drDet["PRIX_U_TTC"] = dr["PRIX_U_TTC"];
                            drDet["PRIX_TOTAL_TTC"] = dr["PRIX_TOTAL_TTC"];
                            drDet["CODE_COMMANDE"] = dr["CODE_COMMANDE"];
                            drDet["QTTE_STOCK"] = dr["QTTE_STOCK"];
                            drDet["MAX_REMISE"] = dr["MAX_REMISE"];
                            drDet.EndEdit();


                            dt_lg_b_liv_prepare.Rows.Add(drDet);
                            dt_lg_b_liv_prepare.AcceptChanges();
                        }
                        CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.SAVE(DATE_B_LIV.Value, CODE_CLIENT, CODE_CMD, Convert.ToDecimal(cbx_magasin.SelectedValue), CLIENT_APP_PARAM.Fenetre_principale.code_user, dt_lg_b_liv_prepare, NUM_FI.ToArray());
                        if (res.OK)
                        {
                            CODE_B_LIV.Text = res.CODE;
                            MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chM_CMP_VALIDATION1.button1.Enabled = false;
                            this.Cursor = Cursors.Default;
                            if (MessageBox.Show("Voulez vous imprimer le bon de livraison?", "Impression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.Cursor = Cursors.WaitCursor;
                                DataTable dt = CLIENT_APP_PARAM.gcws.Imprimer_BL(res.CODE);
                                decimal montant_ht = 0;
                                decimal montant_remise = 0;
                                decimal montant_TVA = 0;
                                decimal montant_TTC = 0;
                                foreach (DataRow dr in dt.Rows)
                                {
                                    montant_ht += (decimal)dr["PRIX_HT_B_LIV"] * (decimal)dr["QTE_LIGNE_B_LIV"];
                                    montant_remise += (decimal)dr["PRIX_HT_B_LIV"] * (decimal)dr["REMISE"] / 100 * (decimal)dr["QTE_LIGNE_B_LIV"];
                                    montant_TVA += ((decimal)dr["PRIX_HT_B_LIV"] - (decimal)dr["PRIX_HT_B_LIV"] * (decimal)dr["REMISE"] / 100) * (decimal)dr["TVA_B_LIV"] / 100 * (decimal)dr["QTE_LIGNE_B_LIV"];

                                }
                                montant_TTC = montant_ht - montant_remise + montant_TVA;

                                RPT_B_LIV rpt = new RPT_B_LIV();
                                rpt.SetDataSource(dt);
                                rpt.SetParameterValue("mnt_HT", montant_ht);
                                rpt.SetParameterValue("Total_Remise", montant_remise);
                                rpt.SetParameterValue("Total_TVA", montant_TVA);
                                rpt.SetParameterValue("Montant_TTC", montant_TTC);
                                rpt.SetParameterValue("entete", CLIENT_APP_PARAM.entete);
                                rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.ReportPrinter;
                                rpt.PrintToPrinter(1, true, 0, 0);
                                this.Cursor = Cursors.Default;
                            }

                            Close();
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }

                }
            }
            else
            {
                MessageBox.Show("Bon de livraison vide, veuillez insérer les articles!");
            }
        }

        private void BTN_FACTURATION_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_FRM_NV_FACTURE fiche = new CHM_FRM_NV_FACTURE(CODE_B_LIV.Text, Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                fiche.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                fiche.Show();
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            try
            {
                CHM_COMMANDE_CLIENT f = new CHM_COMMANDE_CLIENT();
                f.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(f_client_selection_event);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataTable _dt_commande_encours;
        BindingSource _bs_commandes_encours = new BindingSource();

        DataTable _dt_article_cmd;
        void f_client_selection_event(DCLIENT client)
        {
            try
            {
                REF_CLIENT.Text = client.REF_CLIENT.ToString();
                RS_CLIENT.Text = client.RS_CLIENT.ToString();
                TEL_CLIENT.Text =client.TEL_CLIENT.ToString();
                CODE_CLIENT = client.CODE_CLIENT.ToString();
                gridControl1.DataSource = bs_lg_b_liv_prepare;
                chargerCommandesClient(Convert.ToDecimal(CODE_CLIENT));
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void chargerCommandesClient(decimal CODE_CLI)
        {
            try
            {
                dataSet11.LG_BON_LIVRAISON.Clear();
                p_Commandes_ENCOURS.Controls.Clear();
                _dt_article_cmd = CLIENT_APP_PARAM.gcws.SELECT_DETAIL_COMMANDE_EN_ATTENTE_DISPONIBLE_PAR_CLIENT(CODE_CLI, Convert.ToDecimal(cbx_magasin.SelectedValue));
                _dt_commande_encours = CLIENT_APP_PARAM.gcws.SELECT_COMMANDE_NON_REGLE_PAR_CLIENT(CODE_CLI);

                for (int i = 0; i < _dt_commande_encours.Rows.Count; i++)
                {
                    CHM_SELECTION_CONTROL c = new CHM_SELECTION_CONTROL();
                    if (i % 2 == 0)
                    {
                        c.BackColor = Color.Lavender;
                    }
                    else
                    {
                        c.BackColor = Color.LavenderBlush;
                    }
                    c.LB_TYPE.Text = _dt_commande_encours.Rows[i]["TYPE_PIECE"].ToString();
                    switch (_dt_commande_encours.Rows[i]["TYPE_PIECE"].ToString())
                    {
                        case "CMD":
                            c.LB_TYPE.ForeColor = Color.DarkRed;
                            break;

                        case "F.E":
                            c.LB_TYPE.ForeColor = Color.DarkGreen;
                            break;
                    }
                    c.selection_state.Checked = _dt_commande_encours.Rows[i]["CHECKED"].ToString() == "False" ? false : true;
                    c.entete.Text = _dt_commande_encours.Rows[i]["CODE_COMMANDE"].ToString();
                    c.detail.Text = string.Format("Date création : {0} Date échéance : {1}", Convert.ToDateTime(_dt_commande_encours.Rows[i]["DATE_COMMANDE"]).ToShortDateString(), Convert.ToDateTime(_dt_commande_encours.Rows[i]["DATE_EXPIRATION_COMMANDE"].ToString()).ToShortDateString() == "01/01/1900" ? "Sans échéance" : Convert.ToDateTime(_dt_commande_encours.Rows[i]["DATE_EXPIRATION_COMMANDE"].ToString()).ToShortDateString());
                    c.Name = _dt_commande_encours.Rows[i]["CODE_COMMANDE"].ToString();
                    c.selection_state.CheckedChanged += new EventHandler(selection_state_CheckedChanged);
                    _dt_article_cmd.DefaultView.RowFilter = "CODE_COMMANDE like '" + _dt_commande_encours.Rows[i]["CODE_COMMANDE"].ToString() + "'";
                    DataTable dt = _dt_article_cmd.DefaultView.ToTable();
                    string detail = "";
                    detail = string.Format("Date création : {0} Date échéance : {1}\nDétails :\n", Convert.ToDateTime(_dt_commande_encours.Rows[i]["DATE_COMMANDE"]).ToShortDateString(), Convert.ToDateTime(_dt_commande_encours.Rows[i]["DATE_EXPIRATION_COMMANDE"].ToString()).ToShortDateString() == "01/01/1900" ? "Sans échéance" : Convert.ToDateTime(_dt_commande_encours.Rows[i]["DATE_EXPIRATION_COMMANDE"].ToString()).ToShortDateString());
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        detail += string.Format("Ref:{0}   Des:{1}   Qté:{2}\n", dt.Rows[j]["REF_ARTICLE"], dt.Rows[j]["DESIGNATION_ARTICLE"], dt.Rows[j]["QTE"]);
                    }
                    c.toolTip1.SetToolTip(c.entete, detail);
                    p_Commandes_ENCOURS.Controls.Add(c);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void selection_state_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (((sender as Control).Parent as CHM_SELECTION_CONTROL).LB_TYPE.Text == "CMD")
                {
                    _dt_article_cmd.DefaultView.RowFilter = "CODE_COMMANDE like '" + (sender as Control).Parent.Name + "'";
                    dt = _dt_article_cmd.DefaultView.ToTable();
                    _dt_article_cmd.DefaultView.RowFilter = "";
                }
                else
                {
                    dt = CLIENT_APP_PARAM.gcws.GetDetailFicheIntervention(((sender as Control).Parent as CHM_SELECTION_CONTROL).entete.Text);

                }
                if ((sender as CheckBox).Checked)
                {
                    if (((sender as Control).Parent as CHM_SELECTION_CONTROL).LB_TYPE.Text == "F.E" && !NUM_FI.Contains(((sender as Control).Parent as CHM_SELECTION_CONTROL).entete.Text))
                    {
                        NUM_FI.Add(((sender as Control).Parent as CHM_SELECTION_CONTROL).entete.Text);
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        decimal qte = 0;
                        bool exist = false;
                        foreach (DataRowView drv_exist in bs_lg_b_liv_prepare)
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
                            bs_lg_b_liv_prepare.AddNew();
                            DataRowView drv_add = (DataRowView)bs_lg_b_liv_prepare.Current;
                            drv_add.BeginEdit();
                            if (((sender as Control).Parent as CHM_SELECTION_CONTROL).LB_TYPE.Text == "CMD")
                            {
                                drv_add["CODE_B_LIV"] = -1;
                                drv_add["TYPE_PIECE"] = "CMD";
                                drv_add["CODE_COMMANDE"] = dr["CODE_COMMANDE"];
                                drv_add["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                                drv_add["REF_ARTICLE"] = dr["REF_ARTICLE"];
                                drv_add["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                                drv_add["QTE_LIGNE_B_LIV"] = dr["QTE"];
                                drv_add["PRIX_HT_B_LIV"] = dr["PRIX_HT_V_ARTICLE"];
                                drv_add["PRIX_TOTAL_HT"] = (decimal)drv_add["QTE_LIGNE_B_LIV"] * (decimal)dr["PRIX_HT_V_ARTICLE"];
                                drv_add["REMISE"] = (decimal)0;
                                drv_add["TVA_B_LIV"] = dr["TVA_ARTICLE"];
                                drv_add["PRIX_U_TTC"] = ((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) + (((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) * (decimal)drv_add["TVA_B_LIV"] / 100);
                                drv_add["PRIX_TOTAL_TTC"] = (decimal)drv_add["PRIX_U_TTC"] * (decimal)drv_add["QTE_LIGNE_B_LIV"];
                                drv_add["CODE_COMMANDE"] = dr["CODE_COMMANDE"];
                                drv_add["QTTE_STOCK"] = dr["QTTE_STOCK"];
                                drv_add["MAX_REMISE"] = dr["MAX_REMISE"];
                            }
                            else
                            {
                                drv_add["CODE_B_LIV"] = -1;
                                drv_add["TYPE_PIECE"] = "FI";
                                drv_add["CODE_COMMANDE"] = dr["NUM_FI"];
                                drv_add["CODE_ARTICLE"] = dr["CODE_ARTICLE"];
                                drv_add["REF_ARTICLE"] = dr["REF_ARTICLE"];
                                drv_add["DESIGNATION_ARTICLE"] = dr["DESIGNATION_ARTICLE"];
                                drv_add["QTE_LIGNE_B_LIV"] = dr["QTE_FI"];
                                drv_add["PRIX_HT_B_LIV"] = dr["P_HT_FI"];
                                drv_add["PRIX_TOTAL_HT"] = (decimal)drv_add["QTE_LIGNE_B_LIV"] * (decimal)dr["P_HT_FI"];
                                drv_add["REMISE"] = dr["REMISE_FI"];
                                drv_add["TVA_B_LIV"] = dr["TVA_FI"];
                                drv_add["PRIX_U_TTC"] = ((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) + (((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) * (decimal)drv_add["TVA_B_LIV"] / 100);
                                drv_add["PRIX_TOTAL_TTC"] = (decimal)drv_add["PRIX_U_TTC"] * (decimal)drv_add["QTE_LIGNE_B_LIV"];
                                drv_add["CODE_COMMANDE"] = dr["NUM_FI"];
                                drv_add["QTTE_STOCK"] = 0;
                                drv_add["MAX_REMISE"] = 0;
                            }
                            drv_add.EndEdit();
                            dt_lg_b_liv_prepare.AcceptChanges();
                        }
                        else
                        {

                            bs_lg_b_liv_prepare.Position = bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]);
                            DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                            drv_edit.BeginEdit();
                            if (((sender as Control).Parent as CHM_SELECTION_CONTROL).LB_TYPE.Text == "CMD")
                            {
                                if ((decimal)drv_edit["QTE_LIGNE_B_LIV"] + (decimal)dr["QTE"] <= (decimal)dr["QTTE_STOCK"])
                                    drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] + (decimal)dr["QTE"];
                                else
                                    drv_edit["QTE_LIGNE_B_LIV"] = (decimal)dr["QTTE_STOCK"];

                                drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)dr["PRIX_HT_V_ARTICLE"];
                                drv_edit["TVA_B_LIV"] = dr["TVA_ARTICLE"];
                                drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                                drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];
                            }
                            else
                            {
                                //if ((decimal)drv_edit["QTE_LIGNE_B_LIV"] + (decimal)dr["QTE_FI"] <= (decimal)dr["QTTE_STOCK"])
                                drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] + (decimal)dr["QTE_FI"];
                                //else
                                // drv_edit["QTE_LIGNE_B_LIV"] = (decimal)dr["QTTE_STOCK"];

                                drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)dr["P_HT_FI"];
                                drv_edit["TVA_B_LIV"] = dr["TVA_FI"];
                                drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                                drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];
                            }
                            drv_edit.EndEdit();
                            dt_lg_b_liv_prepare.AcceptChanges();
                        }
                    }
                }
                else
                {
                    if (((sender as Control).Parent as CHM_SELECTION_CONTROL).LB_TYPE.Text == "F.E" && NUM_FI.Contains(((sender as Control).Parent as CHM_SELECTION_CONTROL).entete.Text))
                    {
                        NUM_FI.Remove(((sender as Control).Parent as CHM_SELECTION_CONTROL).entete.Text);
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        decimal qte = 0;
                        bool exist = false;
                        foreach (DataRowView drv_exist in bs_lg_b_liv_prepare)
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
                            if (((sender as Control).Parent as CHM_SELECTION_CONTROL).LB_TYPE.Text == "CMD")
                            {
                                if ((decimal)dr["QTE"] < qte)
                                {
                                    bs_lg_b_liv_prepare.Position = bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]);
                                    DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                                    drv_edit.BeginEdit();

                                    drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] - (decimal)dr["QTE"];
                                    drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)dr["PRIX_HT_V_ARTICLE"];
                                    drv_edit["TVA_B_LIV"] = dr["TVA_ARTICLE"];
                                    drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                                    drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                                    drv_edit.EndEdit();
                                    dt_lg_b_liv_prepare.AcceptChanges();
                                }
                                else
                                {
                                    bs_lg_b_liv_prepare.RemoveAt(bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]));
                                    bs_lg_b_liv_prepare.EndEdit();
                                    dt_lg_b_liv_prepare.AcceptChanges();
                                }
                            }
                            else
                            {
                                
                                if ((decimal)dr["QTE_FI"] < qte)
                                {
                                    bs_lg_b_liv_prepare.Position = bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]);
                                    DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                                    drv_edit.BeginEdit();

                                    drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] - (decimal)dr["QTE_FI"];
                                    drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)dr["P_HT_FI"];
                                    drv_edit["TVA_B_LIV"] = dr["TVA_FI"];
                                    drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                                    drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                                    bs_lg_b_liv_prepare.EndEdit();
                                    dt_lg_b_liv_prepare.AcceptChanges();
                                }
                                else
                                {
                                    bs_lg_b_liv_prepare.RemoveAt(bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (decimal)dr["CODE_ARTICLE"]));
                                    bs_lg_b_liv_prepare.EndEdit();
                                    dt_lg_b_liv_prepare.AcceptChanges();
                                }
                                
                            }
                        }
                    }
                }
                calculerBonLivraison();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }



        private void gestionAcces()
        {
            try
            {
                DataTable dt_groupe = CLIENT_APP_PARAM.gacces.GetGROUPE_USERS(CLIENT_APP_PARAM.Fenetre_principale.code_group);
                dt_groupe.DefaultView.RowFilter = "CODE_FONCTION_USER ='" + CLIENT_APP_PARAM.Fenetre_principale.code_group + "'";
                DataTable dt = dt_groupe.DefaultView.ToTable();
                if (dt.Rows.Count > 0 && (decimal)dt.Rows[0]["CODE_PRIVILEGE"] != 1)
                {
                    cbx_magasin.Visible = label13.Visible = false;

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_magasin.SelectedValue != null)
                {
                    CHM_FRM_SELECTION_ARTICLE f = new CHM_FRM_SELECTION_ARTICLE((decimal)cbx_magasin.SelectedValue, cbx_magasin.Text);
                    f.on_select += new CHM_FRM_SELECTION_ARTICLE.selection_article(f_on_select);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un magasin.");
                }
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
                decimal qtte = 0;
                bool exist = false;
                foreach (DataRowView drv_exist in bs_lg_b_liv_prepare)
                {
                    if ((decimal)drv_exist["CODE_ARTICLE"] == (decimal)Article["CODE_ARTICLE"])
                    {
                        exist = true;
                        qtte = (decimal)drv_exist["QTE_LIGNE_B_LIV"];
                        break;
                    }
                }
                if (!exist)
                {
                    bs_lg_b_liv_prepare.AddNew();
                    DataRowView drv_add = (DataRowView)bs_lg_b_liv_prepare.Current;
                    drv_add.BeginEdit();
                    drv_add["CODE_B_LIV"] = -1;
                    drv_add["TYPE_PIECE"] = "";
                    drv_add["CODE_COMMANDE"] = "";
                    drv_add["CODE_ARTICLE"] = Article["CODE_ARTICLE"];
                    drv_add["REF_ARTICLE"] = Article["REF_ARTICLE"];
                    drv_add["DESIGNATION_ARTICLE"] = Article["DESIGNATION_ARTICLE"];
                    drv_add["QTE_LIGNE_B_LIV"] = qte;
                    drv_add["PRIX_HT_B_LIV"] = Article["PRIX_HT_V_ARTICLE"];
                    drv_add["PRIX_TOTAL_HT"] = (decimal)drv_add["QTE_LIGNE_B_LIV"] * (decimal)Article["PRIX_HT_V_ARTICLE"];
                    drv_add["REMISE"] = (decimal)0;
                    drv_add["TVA_B_LIV"] = Article["TVA_ARTICLE"];
                    drv_add["PRIX_U_TTC"] = ((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) + (((decimal)drv_add["PRIX_HT_B_LIV"] - (decimal)drv_add["PRIX_HT_B_LIV"] * (decimal)drv_add["REMISE"] / 100) * (decimal)drv_add["TVA_B_LIV"] / 100);
                    drv_add["PRIX_TOTAL_TTC"] = (decimal)drv_add["PRIX_U_TTC"] * (decimal)drv_add["QTE_LIGNE_B_LIV"];
                    drv_add["CODE_COMMANDE"] = "";
                    drv_add["QTTE_STOCK"] = Article["QTTE_STOCK"];
                    drv_add["MAX_REMISE"] = Article["MAX_REMISE"];

                    drv_add.EndEdit();
                    dt_lg_b_liv_prepare.AcceptChanges();
                }
                else
                {

                    bs_lg_b_liv_prepare.Position = bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (decimal)Article["CODE_ARTICLE"]);
                    DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                    drv_edit.BeginEdit();
                    if ((decimal)drv_edit["QTE_LIGNE_B_LIV"] + qte <= (decimal)Article["QTTE_STOCK"])
                        drv_edit["QTE_LIGNE_B_LIV"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] + qte;
                    else
                        drv_edit["QTE_LIGNE_B_LIV"] = (decimal)Article["QTTE_STOCK"];

                    drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)Article["PRIX_HT_V_ARTICLE"];
                    drv_edit["TVA_B_LIV"] = Article["TVA_ARTICLE"];
                    drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                    drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                    drv_edit.EndEdit();
                    dt_lg_b_liv_prepare.AcceptChanges();
                }
                calculerBonLivraison();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_lg_b_liv_prepare.Current != null)
                {
                    if (MessageBox.Show("Etes vous sûres de supprimer cet article du bon de livraison?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        bs_lg_b_liv_prepare.RemoveAt(bs_lg_b_liv_prepare.Find("CODE_ARTICLE", (bs_lg_b_liv_prepare.Current as DataRowView)["CODE_ARTICLE"]));
                        bs_lg_b_liv_prepare.EndEdit();
                        dt_lg_b_liv_prepare.AcceptChanges();
                        calculerBonLivraison();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner l'article à supprimer du bon de livraison.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void calculerBonLivraison()
        {
            decimal montant_ht = 0;
            decimal montant_remise = 0;
            decimal montant_tva = 0;
            decimal montant_ttc = 0;
            for (int i = 0; i < dataSet11.LG_BON_LIVRAISON.Rows.Count; i++)
            {
                montant_ht += (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["PRIX_TOTAL_HT"];
                montant_ttc += (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["PRIX_TOTAL_TTC"];
                montant_remise += (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["QTE_LIGNE_B_LIV"] * (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["PRIX_HT_B_LIV"] * (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["REMISE"] / 100;
                montant_tva += (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["QTE_LIGNE_B_LIV"] * ((decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["PRIX_HT_B_LIV"] - (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["PRIX_HT_B_LIV"] * (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["REMISE"] / 100) * (decimal)dataSet11.LG_BON_LIVRAISON.Rows[i]["TVA_B_LIV"] / 100;
            }
            NP.Value = montant_ht;
            lbn_total_remise.Value = montant_remise;
            lbn_TauxTVA.Value = montant_tva;
            lbn_total_ttc.Value = montant_ttc;
        }

        private void dataGridViewLG_B_LIV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
            catch (InvalidCastException er)
            {
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.InnerException.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (dataGridViewLG_B_LIV.Columns[dgv_pointage.CurrentCell.ColumnIndex].Tag != null && dataGridViewLG_B_LIV.Columns[dgv_pointage.CurrentCell.ColumnIndex].Tag == "p")
                //{
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8 || (int)e.KeyChar == 127 || (int)e.KeyChar == 46)
                    e.Handled = false;
                else
                    e.Handled = true;
                //}
                //if (dgv_pointage.Columns[dgv_pointage.CurrentCell.ColumnIndex].Tag == null)
                //{
                //    e.Handled = true;
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, er.InnerException.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLG_B_LIV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    if (bs_lg_b_liv_prepare.Current != null)
                    {
                        DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                        drv_edit.BeginEdit();
                        decimal qte_stock = Convert.ToDecimal((bs_lg_b_liv_prepare.Current as DataRowView)["QTTE_STOCK"]);
                        if (Convert.ToDecimal(e.FormattedValue) > qte_stock)
                        {
                            MessageBox.Show("Vous ne pouvez pas dépasser la quantité en stock : " + qte_stock.ToString(), CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            drv_edit["QTE_LIGNE_B_LIV"] = qte_stock;
                        }
                        else
                            drv_edit["QTE_LIGNE_B_LIV"] = Convert.ToDecimal(e.FormattedValue);
                        drv_edit.EndEdit();
                        dt_lg_b_liv_prepare.AcceptChanges();
                    }
                    calculerLigneBL();
                    calculerBonLivraison();
                }
                if (e.ColumnIndex == 6)
                {
                    if (bs_lg_b_liv_prepare.Current != null)
                    {
                        DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                        drv_edit.BeginEdit();
                        decimal max_remise = Convert.ToDecimal((bs_lg_b_liv_prepare.Current as DataRowView)["MAX_REMISE"]);
                        if (Convert.ToDecimal(e.FormattedValue) * (decimal)drv_edit["PRIX_HT_B_LIV"] / 100 > max_remise)
                        {
                            MessageBox.Show("Vous ne pouvez pas dépasser " + max_remise.ToString("#.000") + " de remise pour cet article!", CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            drv_edit["REMISE"] = max_remise / (decimal)drv_edit["PRIX_HT_B_LIV"] * 100;
                        }
                        else
                            drv_edit["REMISE"] = Convert.ToDecimal(e.FormattedValue);
                        drv_edit.EndEdit();
                        dt_lg_b_liv_prepare.AcceptChanges();
                    }
                    calculerLigneBL();
                    calculerBonLivraison();
                }

                if (e.ColumnIndex == 4)
                {
                    if (bs_lg_b_liv_prepare.Current != null)
                    {
                        DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                        drv_edit.BeginEdit();

                        drv_edit["PRIX_HT_B_LIV"] = Convert.ToDecimal(e.FormattedValue);
                        drv_edit.EndEdit();
                        dt_lg_b_liv_prepare.AcceptChanges();
                    }
                    calculerLigneBL();
                    calculerBonLivraison();
                }

            }
            catch (InvalidCastException cast_er)
            {
                MessageBox.Show(cast_er.Message);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void calculerLigneBL()
        {
            try
            {
                if (bs_lg_b_liv_prepare.Current != null)
                {
                    DataRowView drv_edit = (DataRowView)bs_lg_b_liv_prepare.Current;
                    drv_edit.BeginEdit();


                    drv_edit["PRIX_TOTAL_HT"] = (decimal)drv_edit["QTE_LIGNE_B_LIV"] * (decimal)drv_edit["PRIX_HT_B_LIV"];

                    drv_edit["PRIX_U_TTC"] = ((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) + (((decimal)drv_edit["PRIX_HT_B_LIV"] - (decimal)drv_edit["PRIX_HT_B_LIV"] * (decimal)drv_edit["REMISE"] / 100) * (decimal)drv_edit["TVA_B_LIV"] / 100);
                    drv_edit["PRIX_TOTAL_TTC"] = (decimal)drv_edit["PRIX_U_TTC"] * (decimal)drv_edit["QTE_LIGNE_B_LIV"];

                    drv_edit.EndEdit();
                    dt_lg_b_liv_prepare.AcceptChanges();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dataGridViewLG_B_LIV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //e.SuppressKeyPress = true;
                    SendKeys.Send("{right}");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dataGridViewLG_B_LIV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (dataGridViewLG_B_LIV.CurrentCell.RowIndex == dataGridViewLG_B_LIV.Rows.Count - 1 && (int)e.KeyChar == 13)
            //    e.Handled = true;
        }

        private void dataGridViewLG_B_LIV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (InvalidCastException er)
            {
            }
        }

        private void CHM_FICHE_BON_LIVRAISON_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F12)
            //{
            //    if (BTN_FACTURATION.Enabled) BTN_FACTURATION.PerformClick();
            //}
            if (e.KeyCode == Keys.F10)
                if (chM_CMP_VALIDATION1.button1.Enabled) chM_CMP_VALIDATION1.button1.PerformClick();
        }

        private void CHM_FICHE_BON_LIVRAISON_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewLG_B_LIV_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void cbx_magasin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView1.UpdateCurrentRow();

            calculerLigneBL();
            calculerBonLivraison();
        }

        private void CHM_FICHE_BON_LIVRAISON_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OnClose != null)
            {
                OnClose();
            }
        }


    }
}
