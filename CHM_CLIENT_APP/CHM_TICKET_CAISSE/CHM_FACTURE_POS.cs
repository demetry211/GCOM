using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;
using System.IO.Ports;
using CHM_CLIENT_APP.CHMGC;
using System.Threading;
using DevExpress.XtraEditors;

namespace CHM_CLIENT_APP.CHM_FACTURE
{
    public partial class CHM_FACTURE_POS : Form
    {

        DataTable _dt_article;
        string _cb_art_selectionne = "";
        DataTable _article_selectionne;
        DataTable _dt_details_FC;
        BindingSource _bs_details_FC = new BindingSource();
        string _code_facture = "";
        decimal _code_client;
        decimal _max_remise = 0;
        string FocusedControl = string.Empty;

        DataTable dtArt;
        DataTable dtFam;
        DataTable dtCateg;
        List<Control> lArt=new List<Control>();
        List<Control> lCateg = new List<Control>();
        List<Control> lFam = new List<Control>();


        DCLIENT client = new DCLIENT();

        #region variable pour le tiroir de type USB
        [DllImport("FIRIDLLU.dll")]
        private static extern int OpenFRIDoor();
        [DllImport("FIRIDLLU.dll")]
        private static extern void InitFRIUSBLibrary();
        [DllImport("FIRIDLLU.dll")]
        private static extern void GetDeviceNumber();
        [DllImport("FIRIDLLU.dll")]
        private static extern void CloseFRIUSBLibrary();
        #endregion

        #region Variable por Status Tiroir
        byte port_open = 0;
        byte[] buff = new byte[6];
        #endregion

        string tiroir = "U";

        public CHM_FACTURE_POS()
        {
            InitializeComponent();

            //tiroir
            serialPort2.PortName = "COM1";
            serialPort2.Parity = GetParity("Aucun");
            serialPort2.BaudRate = int.Parse("9600");
            serialPort2.StopBits = StopBits.Two;
            serialPort2.DataBits = int.Parse("8");

            //Afficheur
            serialPort1.PortName = "COM8";
            serialPort1.Parity = GetParity("Aucun");
            serialPort1.BaudRate = int.Parse("9600");
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = int.Parse("8");

            serialPort2.ReadTimeout = 500;
            serialPort2.WriteTimeout = 500;
            buff[0] = 0;
            buff[1] = 1;
            buff[2] = 2;
            buff[3] = 3;
            buff[4] = 4;
            buff[5] = 5;
            try
            {
                serialPort2.Open();
            }
            catch (Exception)
            {
            }
            chM_PAVE_NUMERIQUE1.OnButtonPress += new CHMComponents.CHM_PAVE_NUMERIQUE.ButtonUse(chM_PAVE_NUMERIQUE1_OnButtonPress);
            chM_PAVE_NUMERIQUE1.OnEfface += new CHMComponents.CHM_PAVE_NUMERIQUE.ButtonUse(chM_PAVE_NUMERIQUE1_OnEfface);

            try
            {
                
                dS_GC1.bsCategorie = new BindingSource();
                dS_GC1.bsFamille = new BindingSource();
                dS_GC1.bsArticle = new BindingSource();
                dS_GC1.chargerCategories();
                dS_GC1.chargerFamilles();
                dS_GC1.chargerArticles();

                pFamille.Controls.Clear();
                dtFam = dS_GC1.FAMILLE;    
                

                RemplireItems(dtFam, pFamille, "CODE_FAMILLE", "DESIGNATION_FAMILLE", lFam);
                foreach (Control c in lFam)
                {
                    c.Click += new EventHandler(chargerCategorie);
                    
                }

                

                _dt_article = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));


                _dt_details_FC = new DataTable("details");
                _bs_details_FC.DataSource = dS_MOUV1.DETAIL_TICKET_POS;
                gridControl1.DataSource = _bs_details_FC;

                //nud_qte.DataBindings.Add("Value", txt_qte, "EditValue", true);
                nud_qte.DataBindings.Add("Value", _bs_details_FC, "QTE", true);
                txt_qte.DataBindings.Add("EditValue", _bs_details_FC, "QTE", true);

                nud_remise_prct.DataBindings.Add("Value", txt_remise_prct, "EditValue", true);
                txt_remise_prct.DataBindings.Add("EditValue", nud_remise_prct, "Value", true);

                nud_remise_ttc.DataBindings.Add("Value", txt_remise_ttc, "EditValue", true);
                nud_remise_ttc_totale.DataBindings.Add("Value", txt_remise_ttc_totale, "EditValue", true);
                //txt_qte.DataBindings.Add("EditValue", _bs_details_FC, "QTE", true);
                //txt_remise_prct.DataBindings.Add("EditValue", _bs_details_FC, "REMISE", true);
                _bs_details_FC.PositionChanged += new EventHandler(_bs_details_FC_PositionChanged);
                _bs_details_FC.CurrentChanged += new EventHandler(_bs_details_FC_CurrentChanged);
                nud_qte.Visible = false;
                nud_remise_prct.Visible = false;

                textBox2.Focus();
                textBox2.Select();

                client.CODE_CLIENT = 1;
                client = CLIENT_APP_PARAM.gcws.obtenirInstanceCLIENT(client);
                txt_REF_CLIENT.Text = client.REF_CLIENT;
                txt_RS_CLIENT.Text = client.RS_CLIENT;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void chargerCategorie(object sender, EventArgs e)
        {
            lbSelectedFamille.Text = (sender as Control).Text;
            dS_GC1.CATEGORIE.DefaultView.RowFilter = "CODE_FAMILLE=" + (sender as Control).Name;
            dtCateg = dS_GC1.CATEGORIE.DefaultView.ToTable();
            dS_GC1.V_ARTICLE.DefaultView.RowFilter = "";

            RemplireItems(dtCateg, pCategorie, "CODE_CATEG", "LIB_CATEG", lCateg);
            foreach (Control c in lCateg)
            {
                c.Click += new EventHandler(chargerArticle);
            }
        }

        void chargerArticle(object sender, EventArgs e)
        {
            lbSelectedCateg.Text = (sender as Control).Text;
            dS_GC1.V_ARTICLE.DefaultView.RowFilter = "CODE_CATEG=" + (sender as Control).Name;
            dtArt = dS_GC1.V_ARTICLE.DefaultView.ToTable();
            dS_GC1.V_ARTICLE.DefaultView.RowFilter = "";

            RemplireItems(dtArt, pArticle, "CODE_ARTICLE", "DESIGNATION_ARTICLE", lArt);
            foreach (Control c in lArt)
            {
                (c as Button).Click += new EventHandler(CHM_FACTURE_POS_Click);
            }
        }

        void _bs_details_FC_CurrentChanged(object sender, EventArgs e)
        {

        }

        void _bs_details_FC_PositionChanged(object sender, EventArgs e)
        {

        }

        private Parity GetParity(string Valeur)
        {
            Parity p = Parity.None;
            switch (Valeur)
            {
                case "Aucun":
                    p = Parity.None;
                    break;
                case "Pair":
                    p = Parity.Even;
                    break;
                case "Impair":
                    p = Parity.Odd;
                    break;
                case "Marque":
                    p = Parity.Mark;
                    break;
                case "Espace":
                    p = Parity.Space;
                    break;
            }
            return p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (nud_qte.Value - nud_qte.Increment >= nud_qte.Minimum)
                nud_qte.Value -= nud_qte.Increment;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente.");
            }
        }

        private void buttonAJOUTER_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_ARTICLE f = new CHM_COMMANDE_ARTICLE("CMD_CL");
            f.confirm_ajout += new CHM_COMMANDE_ARTICLE.ajout_article_deleg(f_confirm_ajout);
            f.ShowDialog();
        }

        void f_confirm_ajout(DataRowView article, decimal qte, decimal prix)
        {
            //for (int i = 0; i < qte; i++)
            //{
            //    textBox2.Text = article["CODE_BARRE_ARTICLE"].ToString();
            //    Thread.Sleep(10);
            //}


            try
            {

                _article_selectionne = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE(article["CODE_ARTICLE"].ToString());
                //_dt_article.DefaultView.RowFilter = "CODE_BARRE_ARTICLE like '" + _cb_art_selectionne + "' OR CODE_BARRE_ARTICLE_SOLDE like '" + _cb_art_selectionne + "'";

                //_article_selectionne = _dt_article.DefaultView.ToTable();
                //_dt_article.DefaultView.RowFilter = "";
                if (_article_selectionne.Rows.Count > 0)
                {
                    _max_remise = (decimal)_article_selectionne.Rows[0]["MAX_REMISE"];

                    bool exist = false;
                    foreach (DataRowView drv_detail in _bs_details_FC)
                    {
                        if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == drv_detail["CODE_ARTICLE"].ToString() && drv_detail["REF_ARTICLE"].ToString() != "S")
                        {
                            drv_detail["QTE"] = (decimal)drv_detail["QTE"] + 1;
                            //drv_detail["PRIX_TOTAL_HT"] = (decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"];
                            //drv_detail["PRIX_U_TTC"] = decimal.Round((decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                            //drv_detail["PRIX_TOTAL_TTC"] = decimal.Round((decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                            //drv_detail["PRIX_FACTURE"] = drv_detail["PRIX_TOTAL_TTC"];
                            //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                            exist = true;
                        }
                        (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                    }
                    if (!exist)
                    {
                        _bs_details_FC.AddNew();
                        DataRowView newRow = (DataRowView)_bs_details_FC.Current;
                        newRow["CODE_BARRE"] = _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"];
                        newRow["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                        newRow["REF_ARTICLE"] = "N";
                        newRow["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                        newRow["QTE"] = qte;
                        newRow["UNITE_QTE_ARTICLE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                        newRow["TVA_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["TAUX_TVA"];
                        newRow["PRIX_HT_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"]; //* (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100); ;
                        //newRow["PRIX_TOTAL_HT"] = (decimal)newRow["QTE"] * (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                        newRow["REMISE"] = 0;
                        decimal pttc = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TAUX_TVA"] / 100), 2);
                        //newRow["PRIX_U_TTC"] = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TAUX_TVA"] / 100), 2);
                        //newRow["PRIX_TOTAL_TTC"] = decimal.Round((decimal)newRow["QTE"] * (decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TAUX_TVA"] / 100), 2);
                        //newRow["PRIX_FACTURE"] = newRow["PRIX_TOTAL_TTC"];
                        newRow["MAX_REMISE"] = _article_selectionne.Rows[0]["MAX_REMISE"];
                        newRow["QTE_STOCK"] = _article_selectionne.Rows[0]["QTE_ARTICLE"];
                        _bs_details_FC.EndEdit();
                        (_bs_details_FC.DataSource as DataTable).AcceptChanges();

                        textBox2.Focus();
                        textBox2.Select();

                    }
                    //calcul_ligne();
                    calcul_facture();
                }
                else
                {
                    MessageBox.Show("Code à barre non valid!", "CHM Commercial Management Program");
                }
                colorier_solde();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CODE_BARRE_ARTICLE.BarCode = textBox2.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _cb_art_selectionne = textBox2.Text.ToUpper();
                textBox2.Text = "";
                timer1.Enabled = false;
                _article_selectionne = CLIENT_APP_PARAM.gcws.SELECT_BY_BARCODE_BY_MAGASIN(_cb_art_selectionne, CLIENT_APP_PARAM.CODE_MAG);
                //_dt_article.DefaultView.RowFilter = "CODE_BARRE_ARTICLE like '" + _cb_art_selectionne + "' OR CODE_BARRE_ARTICLE_SOLDE like '" + _cb_art_selectionne + "'";

                //_article_selectionne = _dt_article.DefaultView.ToTable();
                //_dt_article.DefaultView.RowFilter = "";
                if (_article_selectionne.Rows.Count > 0)
                {
                    _max_remise = (decimal)_article_selectionne.Rows[0]["MAX_REMISE"];
                    if (_cb_art_selectionne == _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"].ToString())
                    {
                        bool exist = false;
                        foreach (DataRowView drv_detail in _bs_details_FC)
                        {
                            if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == drv_detail["CODE_ARTICLE"].ToString() && drv_detail["REF_ARTICLE"].ToString() != "S")
                            {
                                drv_detail["QTE"] = (decimal)drv_detail["QTE"] + 1;
                                //drv_detail["PRIX_TOTAL_HT"] = (decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"];
                                //drv_detail["PRIX_U_TTC"] = decimal.Round((decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                //drv_detail["PRIX_TOTAL_TTC"] = decimal.Round((decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                //drv_detail["PRIX_FACTURE"] = drv_detail["PRIX_TOTAL_TTC"];
                                //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                                exist = true;
                            }
                            (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                        }
                        if (!exist)
                        {
                            _bs_details_FC.AddNew();
                            DataRowView newRow = (DataRowView)_bs_details_FC.Current;

                            newRow["CODE_BARRE"] = _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"];
                            newRow["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                            newRow["REF_ARTICLE"] = "N";
                            newRow["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                            newRow["QTE"] = 1;
                            newRow["UNITE_QTE_ARTICLE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                            newRow["TVA_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"];
                            newRow["PRIX_HT_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"]; //* (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100); ;
                            //newRow["PRIX_TOTAL_HT"] = (decimal)newRow["QTE"] * (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                            newRow["REMISE"] = 0;
                            decimal pttc = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                            //newRow["PRIX_U_TTC"] = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                            //newRow["PRIX_TOTAL_TTC"] = decimal.Round((decimal)newRow["QTE"] * (decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                            //newRow["PRIX_FACTURE"] = newRow["PRIX_TOTAL_TTC"];
                            newRow["MAX_REMISE"] = _article_selectionne.Rows[0]["MAX_REMISE"];
                            newRow["QTE_STOCK"] = _article_selectionne.Rows[0]["QTTE_STOCK"];
                            _bs_details_FC.EndEdit();
                            (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                            _bs_details_FC.Position = _bs_details_FC.Find("CODE_BARRE", _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"]);
                            textBox2.Focus();
                            textBox2.Select();

                        }
                        calcul_ligne();
                    }
                    if (_cb_art_selectionne == _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE_SOLDE"].ToString())
                    {
                        bool exist = false;
                        foreach (DataRowView drv_detail in _bs_details_FC)
                        {
                            if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == drv_detail["CODE_ARTICLE"].ToString() && drv_detail["REF_ARTICLE"].ToString() != "N")
                            {
                                drv_detail["QTE"] = (decimal)drv_detail["QTE"] + 1;
                                //drv_detail["PRIX_TOTAL_HT"] = (decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"];
                                //drv_detail["PRIX_U_TTC"] = decimal.Round((decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                //drv_detail["PRIX_TOTAL_TTC"] = decimal.Round((decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                //drv_detail["PRIX_FACTURE"] = drv_detail["PRIX_TOTAL_TTC"];
                                //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                                exist = true;
                            }
                        }
                        if (!exist)
                        {
                            _bs_details_FC.AddNew();
                            DataRowView newRow = (DataRowView)_bs_details_FC.Current;

                            newRow["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                            newRow["CODE_BARRE"] = _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE_SOLDE"];
                            newRow["REF_ARTICLE"] = "S";
                            newRow["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                            newRow["QTE"] = 1;
                            newRow["UNITE_QTE_ARTICLE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                            newRow["TVA_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"];
                            newRow["PRIX_HT_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                            //newRow["PRIX_TOTAL_HT"] = (decimal)newRow["QTE"] * (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                            newRow["REMISE"] = 0;
                            //newRow["PRIX_U_TTC"] = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                            //newRow["PRIX_TOTAL_TTC"] = decimal.Round((decimal)newRow["QTE"] * (decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                            //newRow["PRIX_FACTURE"] = newRow["PRIX_TOTAL_TTC"];
                            _bs_details_FC.EndEdit();
                            (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                            textBox2.Focus();
                            textBox2.Select();

                        }
                        //calcul_ligne();
                    }
                    calcul_facture();
                }
                else
                {
                    MessageBox.Show("Code à barre non valid!", "CHM Commercial Management Program");
                }
                colorier_solde();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
        }





        private void CHM_FACTURE_POS_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                    _dt_article = CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente");
            }
        }

        private void btn_qte_aug_Click(object sender, EventArgs e)
        {
            try
            {
                //if (nud_qte.Value + nud_qte.Increment <= nud_qte.Maximum)
                nud_qte.Value += nud_qte.Increment;
                calcul_facture();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente");
            }
        }

        private void btn_remise_aug_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_remise_prct.Value + nud_remise_prct.Increment <= nud_remise_prct.Maximum)
                    nud_remise_prct.Value += nud_remise_prct.Increment;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente");
            }
        }

        private void btn_remise_dim_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_remise_prct.Value - nud_remise_prct.Increment >= nud_remise_prct.Minimum)
                    nud_remise_prct.Value -= nud_remise_prct.Increment;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nud_remise_prct.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_details_FC.Current;
                    drv["QTE"] = nud_qte.Value;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente");
            }
        }



        private void btn_validation_ajout_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_details_FC.Current;
                    drv["REMISE"] = nud_remise_prct.Value;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox2.Select();
        }

        private void nud_qte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    //dgv_liste.SelectedRows[0].Cells["_QTE"].Value = nud_qte.Value;
                    //(_bs_details_FC.Current as DataRowView)["QTE"] = nud_qte.Value;
                    //_bs_details_FC.EndEdit();
                    //(_bs_details_FC.DataSource as DataTable).AcceptChanges();
                    //calcul_ligne();


                    txt_qte.EditValue = nud_qte.Value;
                    nud_remise_ttc_totale.Value = nud_qte.Value * nud_remise_ttc.Value;
                    calcul_facture();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un article!", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur inattendue.\n{0}", er.Message), this.Text);
            }
        }

        private void nud_remise_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_remise_prct.EditValue = nud_remise_prct.Value;
                //dgv_liste.SelectedRows[0].Cells["_REMISE"].Value = nud_remise_prct.Value;
                ////(_bs_details_FC.Current as DataRowView)["REMISE"] = nud_remise.Value;
                //decimal remise = (decimal)nud_remise_prct.Value * (decimal)(_bs_details_FC.Current as DataRowView)["PRIX_HT_ARTICLE"] / 100;
                //nud_remise_ttc.Value = remise;
                ////txt_remise.Text = remise.ToString();
                //_dt_details_FC.AcceptChanges();
                //calcul_ligne();
                calcul_facture();
            }
            catch (Exception er)
            {
                MessageBox.Show("Max remise dépassé", this.Text);
            }
        }

        private void calcul_ligne()
        {
            try
            {
                //if (dgv_liste.SelectedRows.Count > 0)
                //{
                //    dgv_liste.SelectedRows[0].Cells["_PRIX_TOTAL_HT"].Value = (decimal)dgv_liste.SelectedRows[0].Cells["_QTE"].Value * (decimal)dgv_liste.SelectedRows[0].Cells["_PRIX_HT_ARTICLE"].Value;
                //    dgv_liste.SelectedRows[0].Cells["PRIX_U_TTC"].Value = (decimal)dgv_liste.SelectedRows[0].Cells["_PRIX_HT_ARTICLE"].Value - ((decimal)dgv_liste.SelectedRows[0].Cells["_PRIX_HT_ARTICLE"].Value / 100 * (decimal)dgv_liste.SelectedRows[0].Cells["_REMISE"].Value);
                //    dgv_liste.SelectedRows[0].Cells["_PRIX_TOTAL_TTC"].Value = (decimal)dgv_liste.SelectedRows[0].Cells["PRIX_U_TTC"].Value * (decimal)dgv_liste.SelectedRows[0].Cells["_QTE"].Value;
                //    (_bs_details_FC.Current as DataRowView)["PRIX_FACTURE"] = (decimal)dgv_liste.SelectedRows[0].Cells["_PRIX_TOTAL_TTC"].Value;
                //}

                if (_bs_details_FC.Current != null)
                {
                    //DataRowView drv = (DataRowView)_bs_details_FC.Current;
                    //drv["PRIX_TOTAL_HT"] = (decimal)drv["QTE"] * (decimal)drv["PRIX_HT_ARTICLE"];
                    //drv["PRIX_U_TTC"] = (decimal)drv["PRIX_HT_ARTICLE"] * (1 - (decimal)drv["REMISE"] / 100) * (1 + (decimal)drv["TVA_ARTICLE"] / 100);
                    //drv["PRIX_TOTAL_TTC"] = (decimal)drv["PRIX_U_TTC"] * (decimal)drv["QTE"];
                    //drv["PRIX_FACTURE"] = (decimal)drv["PRIX_TOTAL_TTC"];
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void calcul_facture()
        {
            try
            {
                decimal somme_sans_remise = 0;
                decimal somme_remise = 0;
                decimal somme_HT = 0;
                decimal mnt_TVA = 0;
                foreach (DataRowView drv in _bs_details_FC)
                {
                    mnt_TVA += (decimal)drv["PRIX_TOTAL_HT"] * (decimal)drv["TVA_ARTICLE"] / 100;
                    somme_HT += (decimal)drv["PRIX_TOTAL_HT"];
                    somme_sans_remise += (decimal)drv["PRIX_TOTAL_HT"] * (1 + (decimal)drv["TVA_ARTICLE"] / 100);
                    somme_remise += (decimal)drv["PRIX_TOTAL_HT"] * (decimal)drv["REMISE"] / 100;
                }
                NP.Value = somme_sans_remise;
                lbn_total_remise.Value = somme_remise;
                lbn_total_apres_remise.Value = NP.Value - lbn_total_remise.Value;

                //try
                //{
                //    serialPort1.Open();
                //    int LenStr;
                //    string Affiche = "";
                //    Affiche = lbn_total_apres_remise.Text;
                //    if (Affiche.Length >= 20)
                //        Affiche = Affiche.Substring(0, 19);
                //    LenStr = 19 - Affiche.Length;
                //    Affiche = "Total : " + Affiche;
                //    serialPort1.NewLine = Affiche.PadRight(40, ' ');
                //    serialPort1.WriteLine(serialPort1.NewLine);
                //    //serialPort1.NewLine = "*";
                //    //serialPort1.WriteLine(serialPort1.NewLine);
                //    textBox3.Text = serialPort1.NewLine;
                //    serialPort1.Close();
                //}
                //catch (Exception error)
                //{

                //}
            }
            catch (Exception er)
            {
                //MessageBox.Show(er.Message);
            }
        }

        private void buttonSUPPRIMER_Click(object sender, EventArgs e)
        {
            if (_bs_details_FC.Current != null)
            {
                _bs_details_FC.RemoveCurrent();
                (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                //_dt_details_FC.AcceptChanges();
                calcul_facture();
                colorier_solde();
            }
        }

        private void colorier_solde()
        {
            try
            {
                //foreach (DataGridViewRow row in gridControl1.Rows)
                //{
                //    DataGridViewCell type = row.Cells["_REF_ARTICLE"];
                //    string type_value = type.Value.ToString();
                //    if (type_value == "S")
                //    {
                //        row.DefaultCellStyle.BackColor = Color.GreenYellow;
                //    }
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_Espece_Click(object sender, EventArgs e)
        {
            #region Old
            //int zero = 0;
            //this.Cursor = Cursors.WaitCursor;
            //try
            //{
            //    if (_dt_details_FC.Rows.Count > 0)
            //    {
            //        if (MessageBox.Show("Etes vous sûres de vouloir cloturer la facture?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //        {

            //            Application.DoEvents();
            //            btn_Espece.Enabled = false;
            //            btn_credit.Enabled = false;



            //            //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_FACTURE.INSERT_FACTURE_DIRECTE(DateTime.Now, "1", NP.Value.ToString(), zero.ToString(), NP.Value.ToString(), Convert.ToString(lbn_total_remise.Value / NP.Value * 100), lbn_total_apres_remise.Value.ToString(), zero.ToString(), lbn_total_apres_remise.Value.ToString(), "", false, lbn_total_apres_remise.Value.ToString(), zero.ToString(), CLIENT_APP_PARAM.CODE_MAG, CLIENT_APP_PARAM.Fenetre_principale.code_user, "", "", "POS", _dt_details_FC);
            //            CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.INSERT_FACTURE_DIRECTE(DateTime.Now, "1", NP.Value, NP.Value, NP.Value, lbn_total_remise.Value, "Espèce", 0, 0, Convert.ToDecimal( CLIENT_APP_PARAM.CODE_MAG), Convert.ToDecimal( CLIENT_APP_PARAM.Fenetre_principale.code_user), _dt_details_FC);
            //                //CLIENT_APP_PARAM.gcws.INSERT_FACTURE_DIRECTE(DateTime.Now, "1", NP.Value.ToString(), zero.ToString(), NP.Value.ToString(), Convert.ToString(lbn_total_remise.Value / NP.Value * 100), lbn_total_apres_remise.Value.ToString(), zero.ToString(), lbn_total_apres_remise.Value.ToString(), "", false, lbn_total_apres_remise.Value.ToString(), zero.ToString(), CLIENT_APP_PARAM.CODE_MAG, CLIENT_APP_PARAM.Fenetre_principale.code_user, "", "", "POS", _dt_details_FC);
            //            if (res.OK)
            //            {
            //                _code_facture = res.CODE;
            //                MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                ReportDocument rpt = new CHM_FACTURE.CHM_FACTURE_TICKET_CLIENT();
            //                //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.ImprimerTICET_FACTURE_CLIENT(_code_facture));
            //                rpt.SetDataSource(CLIENT_APP_PARAM.gcws.ImprimerTICET_FACTURE_CLIENT(_code_facture));
            //                rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
            //                rpt.PrintToPrinter(1, false, 0, 0);

            //                try
            //                {
            //                    InitFRIUSBLibrary();
            //                    int j = OpenFRIDoor();
            //                    CloseFRIUSBLibrary();
            //                }
            //                catch (Exception)
            //                {

            //                }

            //                try
            //                {
            //                    openCashDrawer();
            //                }
            //                catch (Exception)
            //                {

            //                }

            //                try
            //                {
            //                    if (serialPort2.IsOpen == false)
            //                        serialPort2.Open();
            //                    byte[] buff1 = new byte[7];
            //                    buff1[0] = 27;
            //                    buff1[1] = 112;
            //                    buff1[2] = 48;
            //                    buff1[3] = 55;
            //                    buff1[4] = 121;
            //                    serialPort2.Write(buff1, 0, 5);
            //                    port_open = 1;
            //                }
            //                catch (Exception)
            //                {

            //                }

            //                //CHM_ETATS f = new CHM_ETATS();
            //                //f.CHM_Aperçu_document.ReportSource = rpt;
            //                //f.WindowState = FormWindowState.Maximized;
            //                //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
            //                //f.Show();
            //                //Close();



            //                refresh();
            //                btn_Espece.Enabled = true;
            //                btn_credit.Enabled = true;

            //            }
            //            else
            //            {
            //                MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //    }
            //    else
            //        MessageBox.Show("Rien a facturer!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //    btn_Espece.Enabled = true;
            //    btn_credit.Enabled = true;
            //}
            #endregion

            #region Verification Champs
            errorProvider1.SetError(txt_RS_CLIENT, "");
            if (txt_REF_CLIENT.Text.Trim() == string.Empty || txt_RS_CLIENT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez sélectionner un client!", this.Text);
                errorProvider1.SetError(txt_RS_CLIENT, "Veuillez sélectionner un client!");
                return;
            }
            errorProvider1.Clear();
            #endregion

            try
            {
                if (dS_MOUV1.DETAIL_TICKET_POS.Rows.Count > 0)
                {
                    CHM_FRM_REG f = new CHM_FRM_REG(lbn_total_apres_remise.Value, "TC", client);
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.OnPaiement += new CHM_FRM_REG.Paiement(f_OnPaiement);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Rien à facturer!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void f_OnPaiement(decimal NetAPayer, decimal MntReçu, decimal Reste, DataTable dtReglement)
        {
            _dt_details_FC.Dispose();
            _dt_details_FC = new DataTable("details");
            try
            {
                decimal montantHt = 0;
                decimal montantTVA = 0;
                decimal montant_recu = 0;
                foreach (DataRow dr in dS_MOUV1.DETAIL_TICKET_POS.Rows)
                {
                    montantHt += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT_ARTICLE"] / (1 + (decimal)dr["TVA_ARTICLE"] / 100);
                    montantTVA += (decimal)dr["QTE"] * (decimal)dr["PRIX_HT_ARTICLE"] * (decimal)dr["TVA_ARTICLE"] / 100;
                }

                foreach (DataRow drreg in dtReglement.Rows)
                {
                    montant_recu += Convert.ToDecimal(drreg["MONTANT_PIECE"]);
                }

                foreach (DataColumn c in dS_MOUV1.DETAIL_TICKET_POS.Columns)
                {
                    DataColumn col = new DataColumn(c.ColumnName, c.DataType);
                    _dt_details_FC.Columns.Add(col);
                }

                foreach (DataRow dr in dS_MOUV1.DETAIL_TICKET_POS.Rows)
                {

                    _dt_details_FC.ImportRow(dr);
                }


                decimal montantRemise = Convert.ToDecimal(lbn_total_remise.Value);

                RESULT_QUERY res = new RESULT_QUERY();
                res = CLIENT_APP_PARAM.gcws.INSERT_FACTURE_DIRECTE(CLIENT_APP_PARAM.gcws.getDateS(), this.client.CODE_CLIENT.ToString(), montantHt
                    , montantTVA, NetAPayer, montantRemise, "", montant_recu, Reste, Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG),
                    Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), _dt_details_FC, dtReglement);

                if (res.OK)
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                    Close();
                }
                else
                {
                    throw new Exception(res.MESSAGE);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void openCashDrawer()
        {
            byte[] codeOpenCashDrawer = new byte[] { 27, 112, 48, 55, 121 };
            IntPtr pUnmanagedBytes = new IntPtr(0);
            pUnmanagedBytes = Marshal.AllocCoTaskMem(5);
            Marshal.Copy(codeOpenCashDrawer, 0, pUnmanagedBytes, 5);
            RawPrinterHelper.SendBytesToPrinter(CLIENT_APP_PARAM.TicketPrinter, pUnmanagedBytes, 5);
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
        }

        private void refresh()
        {
            //_dt_details_FC = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_SCHEMA_LG_FACTURE_DIRECTE();

        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            int zero = 0;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (_dt_details_FC.Rows.Count > 0)
                {
                    if (MessageBox.Show("Etes vous sûres de cloturer la facture?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        CHM_COMMANDE_CLIENT client = new CHM_COMMANDE_CLIENT();
                        client.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(f_client_selection_event);
                        client.ShowDialog();
                        Application.DoEvents();
                        btn_Espece.Enabled = false;
                        btn_credit.Enabled = false;

                        CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                        // res=CLIENT_APP_PARAM.gcws.INSERT_FACTURE_DIRECTE(DateTime.Now, _code_client.ToString(), NP.Value.ToString(), zero.ToString(), NP.Value.ToString(), Convert.ToString(lbn_total_remise.Value / NP.Value * 100), lbn_total_apres_remise.Value.ToString(), zero.ToString(), lbn_total_apres_remise.Value.ToString(), "", false, zero.ToString(), lbn_total_apres_remise.Value.ToString(), CLIENT_APP_PARAM.CODE_MAG, CLIENT_APP_PARAM.Fenetre_principale.code_user, "", "", "POS", _dt_details_FC);
                        if (res.OK)
                        {
                            _code_facture = res.CODE;
                            MessageBox.Show(res.MESSAGE, "Point de vente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Espece.Enabled = false;
                            btn_credit.Enabled = false;
                            if (MessageBox.Show("Etes vous sur de cloturer la facture?", "Point de vente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                CHM_REGLEMENT_CLIENT f = new CHM_REGLEMENT_CLIENT(_code_facture);
                                f.ShowDialog();
                            }

                            ReportDocument rpt = new CHM_FACTURE.CHM_FACTURE_TICKET_CLIENT();
                            //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_FACTURE.ImprimerTICET_FACTURE_CLIENT(_code_facture));
                            rpt.SetDataSource(CLIENT_APP_PARAM.gcws.ImprimerTICET_FACTURE_CLIENT(_code_facture));
                            rpt.PrintOptions.PrinterName = CLIENT_APP_PARAM.TicketPrinter;
                            rpt.PrintToPrinter(1, false, 0, 0);

                            //CHM_ETATS f = new CHM_ETATS();
                            //f.CHM_Aperçu_document.ReportSource = rpt;
                            //f.WindowState = FormWindowState.Maximized;
                            //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                            //f.Show();
                            refresh();
                            btn_Espece.Enabled = true;
                            btn_credit.Enabled = true;
                            //Close();
                        }
                        else
                        {
                            MessageBox.Show(res.MESSAGE, "Point de vente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                    MessageBox.Show("Rien à facturer", "Point de vente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Point de vente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        void f_client_selection_event(DCLIENT client)
        {
            _code_client = client.CODE_CLIENT;
        }

        private void nud_total_remise_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nud_remise_prct.Value = nud_remise_ttc.Value / (decimal)(_bs_details_FC.Current as DataRowView)["PRIX_HT_ARTICLE"] * 100;
                txt_remise_ttc.EditValue = nud_remise_ttc.Value;

                nud_remise_ttc_totale.Value = nud_remise_ttc.Value * nud_qte.Value;
            }
            catch (Exception er)
            {
                MessageBox.Show("Maximum remise dépassé", this.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    _cb_art_selectionne = textBox1.Text;
                    textBox1.Text = "";

                    _article_selectionne = CLIENT_APP_PARAM.gcws.SELECT_BY_BARCODE_BY_MAGASIN(_cb_art_selectionne, CLIENT_APP_PARAM.CODE_MAG);
                    //_dt_article.DefaultView.RowFilter = "CODE_BARRE_ARTICLE like '" + _cb_art_selectionne + "' OR CODE_BARRE_ARTICLE_SOLDE like '" + _cb_art_selectionne + "'";

                    //_article_selectionne = _dt_article.DefaultView.ToTable();
                    //_dt_article.DefaultView.RowFilter = "";
                    if (_article_selectionne.Rows.Count > 0)
                    {
                        _max_remise = (decimal)_article_selectionne.Rows[0]["MAX_REMISE"];
                        if (_cb_art_selectionne == _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"].ToString())
                        {
                            bool exist = false;
                            foreach (DataRowView drv_detail in _bs_details_FC)
                            {
                                if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == drv_detail["CODE_ARTICLE"].ToString() && drv_detail["REF_ARTICLE"].ToString() != "S")
                                {
                                    drv_detail["QTE"] = (decimal)drv_detail["QTE"] + 1;
                                    //drv_detail["PRIX_TOTAL_HT"] = (decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"];
                                    //drv_detail["PRIX_U_TTC"] = decimal.Round((decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                    //drv_detail["PRIX_TOTAL_TTC"] = decimal.Round((decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                    //drv_detail["PRIX_FACTURE"] = drv_detail["PRIX_TOTAL_TTC"];
                                    //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                                    exist = true;
                                    _dt_details_FC.AcceptChanges();
                                }

                            }
                            if (!exist)
                            {
                                _bs_details_FC.AddNew();
                                DataRowView newRow = (DataRowView)_bs_details_FC.Current;
                                newRow["CODE_BARRE"] = _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"];
                                newRow["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                                newRow["REF_ARTICLE"] = "N";
                                newRow["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                                newRow["QTE"] = 1;
                                newRow["UNITE_QTE_ARTICLE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                                newRow["TVA_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"];
                                newRow["PRIX_HT_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                                //newRow["PRIX_TOTAL_HT"] = (decimal)newRow["QTE"] * (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                                newRow["REMISE"] = 0;
                                //newRow["PRIX_U_TTC"] = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                                //newRow["PRIX_TOTAL_TTC"] = decimal.Round((decimal)newRow["QTE"] * (decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                                //newRow["PRIX_FACTURE"] = newRow["PRIX_TOTAL_TTC"];
                                newRow["MAX_REMISE"] = _article_selectionne.Rows[0]["MAX_REMISE"];
                                newRow["QTE_STOCK"] = _article_selectionne.Rows[0]["QTTE_STOCK"];
                                _bs_details_FC.EndEdit();
                                _dt_details_FC.AcceptChanges();

                                textBox2.Focus();
                                textBox2.Select();

                            }
                            calcul_ligne();
                        }
                        if (_cb_art_selectionne == _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE_SOLDE"].ToString())
                        {
                            bool exist = false;
                            foreach (DataRowView drv_detail in _bs_details_FC)
                            {
                                if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == drv_detail["CODE_ARTICLE"].ToString() && drv_detail["REF_ARTICLE"].ToString() != "N")
                                {
                                    drv_detail["QTE"] = (decimal)drv_detail["QTE"] + 1;
                                    drv_detail["PRIX_TOTAL_HT"] = (decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"];
                                    drv_detail["PRIX_U_TTC"] = decimal.Round((decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                    drv_detail["PRIX_TOTAL_TTC"] = decimal.Round((decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                                    drv_detail["PRIX_FACTURE"] = drv_detail["PRIX_TOTAL_TTC"];
                                    //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                                    exist = true;
                                }
                            }
                            if (!exist)
                            {
                                _bs_details_FC.AddNew();
                                DataRowView newRow = (DataRowView)_bs_details_FC.Current;
                                newRow["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                                newRow["REF_ARTICLE"] = "S";
                                newRow["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                                newRow["QTE"] = 1;
                                newRow["QTE_STOCK"] = _article_selectionne.Rows[0]["QTE_ARTICLE"]; ;
                                newRow["UNITE_QTE_ARTICLE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                                newRow["TVA_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"];
                                newRow["PRIX_HT_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                                newRow["PRIX_TOTAL_HT"] = (decimal)newRow["QTE"] * (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                                newRow["MAX_REMISE"] = 0;
                                newRow["PRIX_U_TTC"] = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                                newRow["PRIX_TOTAL_TTC"] = decimal.Round((decimal)newRow["QTE"] * (decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100), 2);
                                newRow["PRIX_FACTURE"] = newRow["PRIX_TOTAL_TTC"];
                                _bs_details_FC.EndEdit();
                                _dt_details_FC.AcceptChanges();
                                textBox2.Focus();
                                textBox2.Select();

                            }
                            //calcul_ligne();
                        }
                        calcul_facture();
                    }
                    else
                    {
                        MessageBox.Show("Code à barre non valid!", "CHM Commercial Management Program");
                    }
                    colorier_solde();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialPort2.BytesToRead < 4)
                    ;
                serialPort2.Read(buff, 0, 4);
                string s = string.Format(" Data returned = {0},{1},{2},{3}", buff[0], buff[1], buff[2], buff[3]);
                if (buff[0].ToString() == "20")
                {
                    port_open = 0;
                }
                else
                    port_open = 1;

            }
            catch (Exception err)
            {
                //LogError(err.ToString());
                //Reopen serial port & reset buffer
                //openSerialPort();
                //msg = "";
                MessageBox.Show(err.Message);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            //textBox2.CharacterCasing = CharacterCasing.Upper;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            this.client = client;
        }

        void chM_PAVE_NUMERIQUE1_OnEfface(string button)
        {
            try
            {
                p_maj_art.Controls[FocusedControl].Focus();
                p_maj_art.Controls[FocusedControl].Text = "0";
                //txt_MntRecu.Focus();
                //txt_MntRecu.Text = "0";
            }
            catch (Exception er)
            {

            }
        }

        void chM_PAVE_NUMERIQUE1_OnButtonPress(string button)
        {
            //if (FocusedControl != string.Empty)
            //{
            p_maj_art.Controls[FocusedControl].Focus();
            //txt_MntRecu.Focus();
            string s = "{" + string.Format("{0}", button) + "}";
            SendKeys.Send(s);
            //}
        }

        private void txt_MntRecu_Click(object sender, EventArgs e)
        {
            FocusedControl = (sender as Control).Name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CODE_BARRE_ARTICLE.BarCode = textBox1.Text;
        }

        private void txt_remise_prct_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_details_FC.Current;
                    drv["REMISE"] = txt_remise_prct.EditValue;
                    //(_bs_details_FC.Current as DataRowView)["REMISE"] = nud_remise.Value;
                    decimal remise = (decimal)txt_remise_prct.EditValue * (decimal)(_bs_details_FC.Current as DataRowView)["PRIX_HT_ARTICLE"] / 100;
                    nud_remise_ttc.Value = remise;
                    //txt_remise.Text = remise.ToString();
                    (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                    //calcul_ligne();
                    calcul_facture();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Max remise dépassé", this.Text);
            }
        }

        private void txt_remise_ttc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_details_FC.Current;
                    decimal prix_ht = (decimal)drv["PRIX_HT_ARTICLE"];
                    txt_remise_prct.EditValue = Convert.ToDecimal(txt_remise_ttc.EditValue) / prix_ht * 100;
                    txt_remise_ttc_totale.EditValue = Convert.ToDecimal(txt_remise_ttc.EditValue) * nud_qte.Value;
                    calcul_facture();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Maximum remise dépassé", this.Text);
            }
        }

        private void txt_qte_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    //dgv_liste.SelectedRows[0].Cells["_QTE"].Value = nud_qte.Value;
                    (_bs_details_FC.Current as DataRowView)["QTE"] = txt_qte.EditValue;
                    _bs_details_FC.EndEdit();
                    (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                    //calcul_ligne();
                    calcul_facture();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un article!", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur inattendue.\n{0}", er.Message), this.Text);
            }
        }

        private void nud_remise_ttc_totale_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nud_remise_ttc.Value = nud_remise_ttc_totale.Value / nud_qte.Value;
                txt_remise_ttc_totale.EditValue = nud_remise_ttc_totale.Value;
                calcul_facture();
            }
            catch (Exception er)
            {
                txt_remise_ttc_totale.EditValue = nud_remise_ttc_totale.Value = 0;
                MessageBox.Show(string.Format("La remise ne doit pas dépasser {0}", nud_remise_ttc.Maximum), this.Text);

            }
        }

        private void txt_remise_ttc_totale_EditValueChanged(object sender, EventArgs e)
        {
            nud_remise_ttc_totale.Value = Convert.ToDecimal(txt_remise_ttc_totale.EditValue);
            calcul_facture();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (_bs_details_FC.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_details_FC.Current;

                    txt_qte.EditValue = nud_qte.Value = (decimal)drv["QTE"];
                    txt_remise_prct.EditValue = nud_remise_prct.Value = (decimal)drv["REMISE"];
                    nud_remise_ValueChanged(null, null);
                    //nud_qte.Maximum = (decimal)drv["QTE_STOCK"];
                    //decimal max_r = (decimal)drv["MAX_REMISE"];
                    //nud_remise_ttc.Maximum = max_r;

                    //lb_qte_article.Text = string.Format("Qté de l'article : {0} {1}", drv["REF_ARTICLE"], drv["DESIGNATION_ARTICLE"]);
                    //lb_remise_article.Text = string.Format("Qté de l'article : {0} {1}", drv["REF_ARTICLE"], drv["DESIGNATION_ARTICLE"]);
                }
            }
            catch (Exception er)
            {

            }
        }

        private void RemplireItems(DataTable dt, XtraScrollableControl p, string itemValueMember, string itemDisplayMember, List<Control> list)
        {
            if (dt != null)
            {
                
                list.Clear();
                
                Button b;
                foreach (DataRow dr in dt.Rows)
                {
                    b = new Button();
                    b.Name = dr[itemValueMember].ToString();
                    b.Text = dr[itemDisplayMember].ToString();
                    list.Add(b);
                }


                RemplirPanel(p, list, s, pt);
            }
        }

        Size s = new Size(100, 100);
        Point pt = new Point(5, 5);

        private void RemplirPanel(XtraScrollableControl p, List<Control> list, Size s, Point pt)
        {
            
            
            int colonne = 0;
            if (p.Width / (s.Width+5) < 1)
                colonne = 1;
            else
                colonne = p.Width / (s.Width + 5);



            int nb = 0;
            p.Controls.Clear();
            foreach (Control c in list)
            {
                pt = new Point(5 + nb % colonne * (s.Width + 5), 5 + nb / colonne * (s.Width + 5));

                c.Size = s;
                c.Location = pt;

                p.Controls.Add(c);
                nb++;
            }
        }

        void CHM_FACTURE_POS_Click(object sender, EventArgs e)
        {
            try
            {

                _article_selectionne = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE((sender as Control).Name);
                //_dt_article.DefaultView.RowFilter = "CODE_BARRE_ARTICLE like '" + _cb_art_selectionne + "' OR CODE_BARRE_ARTICLE_SOLDE like '" + _cb_art_selectionne + "'";

                //_article_selectionne = _dt_article.DefaultView.ToTable();
                //_dt_article.DefaultView.RowFilter = "";
                if (_article_selectionne.Rows.Count > 0)
                {
                    _max_remise = (decimal)_article_selectionne.Rows[0]["MAX_REMISE"];

                    bool exist = false;
                    foreach (DataRowView drv_detail in _bs_details_FC)
                    {
                        if (_article_selectionne.Rows[0]["CODE_ARTICLE"].ToString() == drv_detail["CODE_ARTICLE"].ToString() && drv_detail["REF_ARTICLE"].ToString() != "S")
                        {
                            drv_detail["QTE"] = (decimal)drv_detail["QTE"] + 1;
                            //drv_detail["PRIX_TOTAL_HT"] = (decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"];
                            //drv_detail["PRIX_U_TTC"] = decimal.Round((decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                            //drv_detail["PRIX_TOTAL_TTC"] = decimal.Round((decimal)drv_detail["QTE"] * (decimal)drv_detail["PRIX_HT_ARTICLE"] * (1 + (decimal)drv_detail["TVA_ARTICLE"] / 100), 2);
                            //drv_detail["PRIX_FACTURE"] = drv_detail["PRIX_TOTAL_TTC"];
                            //dr_detail["PRIX_ART_BR_FR"] = nud_prix.Value;
                            exist = true;
                        }
                        (_bs_details_FC.DataSource as DataTable).AcceptChanges();
                    }
                    if (!exist)
                    {
                        _bs_details_FC.AddNew();
                        DataRowView newRow = (DataRowView)_bs_details_FC.Current;
                        newRow["CODE_BARRE"] = _article_selectionne.Rows[0]["CODE_BARRE_ARTICLE"];
                        newRow["CODE_ARTICLE"] = _article_selectionne.Rows[0]["CODE_ARTICLE"];
                        newRow["REF_ARTICLE"] = "N";
                        newRow["DESIGNATION_ARTICLE"] = _article_selectionne.Rows[0]["DESIGNATION_ARTICLE"];
                        newRow["QTE"] = 1;
                        newRow["UNITE_QTE_ARTICLE"] = _article_selectionne.Rows[0]["LIB_UNITE"];
                        newRow["TVA_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["TAUX_TVA"];
                        newRow["PRIX_HT_ARTICLE"] = (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"]; //* (1 + (decimal)_article_selectionne.Rows[0]["TVA_ARTICLE"] / 100); ;
                        //newRow["PRIX_TOTAL_HT"] = (decimal)newRow["QTE"] * (decimal)_article_selectionne.Rows[0]["PRIX_HT_V_ARTICLE"];
                        newRow["REMISE"] = 0;
                        decimal pttc = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TAUX_TVA"] / 100), 2);
                        //newRow["PRIX_U_TTC"] = decimal.Round((decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TAUX_TVA"] / 100), 2);
                        //newRow["PRIX_TOTAL_TTC"] = decimal.Round((decimal)newRow["QTE"] * (decimal)newRow["PRIX_HT_ARTICLE"] * (1 + (decimal)_article_selectionne.Rows[0]["TAUX_TVA"] / 100), 2);
                        //newRow["PRIX_FACTURE"] = newRow["PRIX_TOTAL_TTC"];
                        newRow["MAX_REMISE"] = _article_selectionne.Rows[0]["MAX_REMISE"];
                        newRow["QTE_STOCK"] = _article_selectionne.Rows[0]["QTE_ARTICLE"];
                        _bs_details_FC.EndEdit();
                        (_bs_details_FC.DataSource as DataTable).AcceptChanges();


                        textBox2.Focus();
                        textBox2.Select();

                    }
                    //calcul_ligne();
                    calcul_facture();
                    _bs_details_FC.Position = _bs_details_FC.Find("CODE_ARTICLE", _article_selectionne.Rows[0]["CODE_ARTICLE"].ToString());
                }
                else
                {
                    MessageBox.Show("Code à barre non valid!", "CHM Commercial Management Program");
                }
                colorier_solde();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (pFamille.VerticalScroll.Value - pFamille.VerticalScroll.Minimum > 105)
                    pFamille.VerticalScroll.Value -= 105;
                else
                    pFamille.VerticalScroll.Value = 0;
            }
            catch (Exception er)
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pFamille.VerticalScroll.Value - pFamille.VerticalScroll.Maximum < -105)
                    pFamille.VerticalScroll.Value += 105;
                else
                    pFamille.VerticalScroll.Value = pFamille.VerticalScroll.Maximum;
            }
            catch (Exception er)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pFamille.VerticalScroll.Value - pFamille.VerticalScroll.Minimum > 315)
                    pFamille.VerticalScroll.Value -= 315;
                else
                    pFamille.VerticalScroll.Value = 0;
            }
            catch (Exception er)
            {

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (pFamille.VerticalScroll.Value - pFamille.VerticalScroll.Maximum < -315)
                    pFamille.VerticalScroll.Value += 315;
                else
                    pFamille.VerticalScroll.Value = pFamille.VerticalScroll.Maximum;
            }
            catch (Exception er)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (pCategorie.VerticalScroll.Value - pCategorie.VerticalScroll.Minimum > 315)
                    pCategorie.VerticalScroll.Value -= 315;
                else
                    pCategorie.VerticalScroll.Value = 0;
            }
            catch (Exception er)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (pCategorie.VerticalScroll.Value - pCategorie.VerticalScroll.Minimum > 105)
                    pCategorie.VerticalScroll.Value -= 105;
                else
                    pCategorie.VerticalScroll.Value = 0;
            }
            catch (Exception er)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (pCategorie.VerticalScroll.Value - pCategorie.VerticalScroll.Maximum < -105)
                    pCategorie.VerticalScroll.Value += 105;
                else
                    pCategorie.VerticalScroll.Value = pCategorie.VerticalScroll.Maximum;
            }
            catch (Exception er)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (pCategorie.VerticalScroll.Value - pCategorie.VerticalScroll.Maximum < -315)
                    pCategorie.VerticalScroll.Value += 315;
                else
                    pCategorie.VerticalScroll.Value = pCategorie.VerticalScroll.Maximum;
            }
            catch (Exception er)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (pArticle.VerticalScroll.Value - pArticle.VerticalScroll.Minimum > 315)
                    pArticle.VerticalScroll.Value -= 315;
                else
                    pArticle.VerticalScroll.Value = 0;
            }
            catch (Exception er)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (pArticle.VerticalScroll.Value - pArticle.VerticalScroll.Minimum > 105)
                    pArticle.VerticalScroll.Value -= 105;
                else
                    pArticle.VerticalScroll.Value = 0;
            }
            catch (Exception er)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (pArticle.VerticalScroll.Value - pArticle.VerticalScroll.Maximum < -105)
                pArticle.VerticalScroll.Value += 105;
                else
                    pArticle.VerticalScroll.Value = pArticle.VerticalScroll.Maximum;
            }
            catch (Exception er)
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (pArticle.VerticalScroll.Value - pArticle.VerticalScroll.Maximum < -315)
                    pArticle.VerticalScroll.Value += 315;
                else
                    pArticle.VerticalScroll.Value = pArticle.VerticalScroll.Maximum;
            }
            catch (Exception er)
            {

            }
        }

        private void pArticle_SizeChanged(object sender, EventArgs e)
        {
            RemplirPanel(pArticle, lArt, s, pt);
            
        }

        private void pCategorie_SizeChanged(object sender, EventArgs e)
        {
            RemplirPanel(pCategorie, lCateg, s, pt);
            
        }

        private void pFamille_SizeChanged(object sender, EventArgs e)
        {
            RemplirPanel(pFamille, lFam, s, pt);
            
        }
    }
}
