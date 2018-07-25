using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_ARTICLES;
using CHM_CLIENT_APP.CHM_MARQUE_ARTICLE;
using CHM_CLIENT_APP.CHM_FAMILLES_ART;
using System.Xml;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NV_ARTICLE : Form
    {
        private DataTable dtTVAAchat = new DataTable("DT_TVA_ACHAT");
        private Rectangle _PropertyName;
        DataTable dt;
        BindingSource bs = new BindingSource();
        BindingSource bs_fourn = new BindingSource();
        BindingSource bs_categ = new BindingSource();
        BindingSource bsMarque = new BindingSource();
        BindingSource bsFamille = new BindingSource();

        bool validateChanges = false;
        public delegate void Enregistrer_event(DataRowView dr, bool nouv);
        public event Enregistrer_event Enregistrer;

        public delegate void Closing(bool changes);
        public event Closing OnClosing;


        string CODE_ARTICLE = "-1";
        public CHM_NV_ARTICLE(BindingSource bs)
        {
            this.bs = bs;
            InitializeComponent();

            this.CODE_ARTICLE = ((DataRowView)bs.Current)["CODE_ARTICLE"].ToString();

            if (CODE_ARTICLE != "-1")
            {
                txt_REF_ARTICLE.Enabled = false;
                btn_duplication.Text = "Enregister & Dupliquer\n[F11]";
            }
            bs.PositionChanged += new EventHandler(bs_PositionChanged);

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (CODE_ARTICLE != "-1")
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Modification d'Article";
                    txt_REF_ARTICLE.Enabled = false;
                }
                if (CODE_ARTICLE == "-1")
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Nouvel Article";
                    DataRowView drv = (DataRowView)bs.Current;

                    drv["CODE_ARTICLE"] = -1;
                    //drv["CODE_CATEG"] = 1;
                    //drv["CODE_MAG"] = 1;
                    drv["CODE_FOURNISSEUR"] = 1;
                    drv["ETAT_ARTICLE"] = false;
                    drv["QTE_ARTICLE"] = 0;
                    drv["QTE_MIN_ARTICLE"] = 0;
                    drv["PRIX_HT_A_ARTICLE"] = 0;
                    drv["PRIX_HT_V_ARTICLE"] = 0;
                    drv["PRIX_HT_V_ARTICLE"] = 0;
                    //drv["MAX_REMISE"] = 0;
                    drv["TAUX_TVA"] = 0;
                }
            }
            catch (Exception er)
            {
                btn_enreg_article.Enabled = false;
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            #region chargement paramètrage
            try
            {
                chargerMarque();
                chargerFamille();
                chargerCategorie();
                chargerFournisseur();
                chargerUnite();
                chargerTVA();
            }
            catch (Exception er)
            {
                throw er;
            }
            #endregion


            #region Binding components
            Application.DoEvents();
            try
            {
                txt_REF_ARTICLE.DataBindings.Add("Text", bs, "REF_ARTICLE", true);
                ETAT_NV_ARTICLE.DataBindings.Add("Checked", bs, "ETAT_ARTICLE", true);
                txt_DESIGNATION_NV_ARTICLE.DataBindings.Add("Text", bs, "DESIGNATION_ARTICLE", true);
                cbx_MARQUE.DataBindings.Add("Text", bs, "DESIGNATION_MARQUE", true);
                cbx_MARQUE.DataBindings.Add("SelectedValue", bs, "CODE_MARQUE", true);
                cbxCategorie.DataBindings.Add("SelectedValue", bs, "CODE_CATEG", true);
                cbxCategorie.DataBindings.Add("Text", bs, "LIB_CATEG", true);
                lb_ref_categ.DataBindings.Add("Text", bs_categ, "REF_CATEG", true);

                cbxFournisseur.DataBindings.Add("Text", bs, "RS_FOURNISSEUR", true);
                cbxFournisseur.DataBindings.Add("SelectedValue", bs, "CODE_FOURNISSEUR", true);
                cbxFamille.DataBindings.Add("Text", bs, "DESIGNATION_FAMILLE", true);
                cbxFamille.DataBindings.Add("SelectedValue", bs, "CODE_FAMILLE", true);
                txt_DescArticle.DataBindings.Add("Text", bs, "DESCRIPTION_ARTICLE", true);
                PHOTO_NV_ARTICLE.DataBindings.Add("Image", bs, "PHOTO_ARTICLE", true);
                nud_QTE_NV_ARTICLE.DataBindings.Add("Value", bs, "QTE_ARTICLE", true);
                nud_QTE_MIN_NV_ARTICLE.DataBindings.Add("Value", bs, "QTE_MIN_ARTICLE", true);
                txt_PRIX_HT_A_ARTICLE.DataBindings.Add("EditValue", bs, "PRIX_HT_A_ARTICLE", true);
                txt_PRIX_HT_V_NV_ARTICLE.DataBindings.Add("EditValue", bs, "PRIX_HT_V_ARTICLE", true);
                txt_MAX_REMISE.DataBindings.Add("EditValue", bs, "MAX_REMISE", true);
                cbx_TVA_NV_ARTICLE.DataBindings.Add("SelectedValue", bs, "CODE_TVA", true);
                cbx_TVA_NV_ARTICLE.DataBindings.Add("Text", bs, "TAUX_TVA", true);
                cbxUnite.DataBindings.Add("SelectedValue", bs, "CODE_TVA", true);
                cbxUnite.DataBindings.Add("Text", bs, "LIB_UNITE", true);
                txt_PRIX_SOLDE.DataBindings.Add("EditValue", bs, "PRIX_SOLDE", true);
                txt_taux_majoration.DataBindings.Add("EditValue", bs, "TAUX_MAJORATION", true);
                //lb_REF_FAMILLE.DataBindings.Add("Text", bsFamille, "REF_FAMILLE", true);
                //lb_ref_fournisseur.DataBindings.Add("Text", bs_fourn, "REF_FOURNISSEUR", true);
                txt_CodeAbarre.DataBindings.Add("Text", bs, "CODE_BARRE_ARTICLE", true);
                lb_REF_MARQUE.DataBindings.Add("Text", bsMarque, "REF_MARQUE", true);
                CODE_BARRE_ARTICLE.DataBindings.Add("barcode", txt_CodeAbarre, "Text", true);
                txt_prix_ttc.DataBindings.Add("EditValue", bs, "PRIX_TTC", true);
                chbx_PRIX_FIXE.DataBindings.Add("Checked", bs, "PRIX_FIXE", true);
                txt_REF_FOURNISSEUR.DataBindings.Add("Text", bs, "REF_FRN", true);
                cbx_AchatArticle.DataBindings.Add("SelectedValue", bs, "TVA_ACHAT", true);
            }
            catch (Exception er)
            {
                throw er;
            }
            #endregion
        }

        void bs_PositionChanged(object sender, EventArgs e)
        {
            checkEdit1_CheckedChanged(null, null);
        }



        private void btn_enreg_article_Click(object sender, EventArgs e)
        {
            #region TEST
            if (txt_REF_ARTICLE.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_REF_ARTICLE, "");
                if (txt_REF_ARTICLE.Text.Trim() == "")
                {
                    errorProvider1.SetError(txt_REF_ARTICLE, "Veuillez entrer la désignation de l'article !");
                    txt_REF_ARTICLE.Focus();

                    return;
                }
            }
            errorProvider1.Clear();

            errorProvider1.SetError(txt_REF_ARTICLE, "");
            if (txt_REF_ARTICLE.Text.Trim() == "")
            {


                errorProvider1.SetError(txt_REF_ARTICLE, "Veuillez entrer la désignation de l'article !");
                txt_REF_ARTICLE.Focus();

                return;

            }
            errorProvider1.Clear();

            errorProvider1.SetError(txt_DESIGNATION_NV_ARTICLE, "");
            if (txt_DESIGNATION_NV_ARTICLE.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_DESIGNATION_NV_ARTICLE, "Veuillez entrer la désignation de l'article !");
                txt_DESIGNATION_NV_ARTICLE.Focus();
                return;

            }
            errorProvider1.Clear();

            errorProvider1.SetError(cbx_MARQUE, "");
            if (cbx_MARQUE.SelectedValue == null)
            {
                errorProvider1.SetError(cbx_MARQUE, "Veuillez entrer la marque de l'article !");
                cbx_MARQUE.Focus();
                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(cbxCategorie, "");
            if (cbxCategorie.SelectedValue == null)
            {
                errorProvider1.SetError(cbxCategorie, "Veuillez entrer la categorie de l'article !");
                cbxCategorie.Focus();

                return;
            }
            errorProvider1.Clear();

            //if (MAGASIN.Text.Trim() == "")
            //{
            //    errorProvider1.SetError(CATEGORIE, "");
            //    if (MAGASIN.Text.Trim() == "")
            //    {
            //        errorProvider1.SetError(MAGASIN, "Veuillez entrer la categorie de l'article !");
            //        MAGASIN.Focus();

            //        return;
            //    }
            //}

            //errorProvider1.Clear();

            //if (FOURNISSEUR.Text.Trim() == "")
            //{
            //    errorProvider1.SetError(CATEGORIE, "");
            //    if (FOURNISSEUR.Text.Trim() == "")
            //    {
            //        errorProvider1.SetError(FOURNISSEUR, "Veuillez entrer la categorie de l'article !");
            //        FOURNISSEUR.Focus();

            //        return;
            //    }
            //}

            //errorProvider1.Clear();

            if (cbxUnite.Text == "")
            {
                errorProvider1.SetError(cbxUnite, "");
                if (cbxUnite.Text == "")
                {
                    errorProvider1.SetError(cbxUnite, "Veuillez sélectionner l'unite de mesure de l'article !");
                    cbxUnite.Focus();

                    return;
                }
            }
            errorProvider1.Clear();

            //if (QTE_NV_ARTICLE.Value.Equals(0))
            //{
            //    errorProvider1.SetError(QTE_NV_ARTICLE, "");
            //    if (QTE_NV_ARTICLE.Value.Equals(0))
            //    {
            //        errorProvider1.SetError(QTE_NV_ARTICLE, "Veuillez entrer la quantité de l'article !");
            //        QTE_NV_ARTICLE.Focus();
            //        return;
            //    }
            //}
            //errorProvider1.Clear();

            if (cbx_TVA_NV_ARTICLE.SelectedValue == null)
            {
                errorProvider1.SetError(cbx_TVA_NV_ARTICLE, "");
                if (cbx_TVA_NV_ARTICLE.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbx_TVA_NV_ARTICLE, "Veuillez sélectionner la valeur de Tva de Vente !");
                    cbx_TVA_NV_ARTICLE.Focus();

                    return;
                }
            }
            errorProvider1.Clear();


            if (cbx_AchatArticle.SelectedValue == null)
            {
                errorProvider1.SetError(cbx_AchatArticle, "");
                if (cbx_AchatArticle.Text.Trim() == "")
                {
                    errorProvider1.SetError(cbx_AchatArticle, "Veuillez sélectionner la valeur de Tva de Vente !");
                    cbx_AchatArticle.Focus();

                    return;
                }
            }
            errorProvider1.Clear();
            #endregion
            try
            {



                int zero = 0;

                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                if (CODE_ARTICLE == "-1")
                {
                    Application.DoEvents();
                    res = CLIENT_APP_PARAM.gcws.INSERT_ARTICLE((decimal)cbx_MARQUE.SelectedValue, (decimal)cbxFamille.SelectedValue,
                        (decimal)cbxCategorie.SelectedValue, txt_REF_ARTICLE.Text, (decimal)cbxFournisseur.SelectedValue,
                        txt_DESIGNATION_NV_ARTICLE.Text, txt_DescArticle.Text, txt_CodeAbarre.Text, nud_QTE_NV_ARTICLE.Value,
                        (decimal)cbxUnite.SelectedValue, nud_QTE_MIN_NV_ARTICLE.Value, CLIENT_APP_PARAM.IMAGE_TO_BYTE(PHOTO_NV_ARTICLE.Image),
                        Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue), Convert.ToDecimal(txt_taux_majoration.EditValue), Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue),
                        (decimal)cbx_TVA_NV_ARTICLE.SelectedValue, Convert.ToDecimal(txt_MAX_REMISE.EditValue), ETAT_NV_ARTICLE.Checked, Convert.ToDecimal(txt_PRIX_SOLDE.EditValue),
                        0, txt_REF_FOURNISSEUR.Text, chbx_PRIX_FIXE.Checked, Convert.ToDecimal(txt_prix_ttc.EditValue), (decimal)cbx_AchatArticle.SelectedValue);
                    if (res.OK)
                    {
                        CODE_ARTICLE = res.CODE;
                        ((DataRowView)this.bs.Current)["CODE_ARTICLE"] = CODE_ARTICLE;
                        validateChanges = true;
                        if (Enregistrer != null)
                            Enregistrer((DataRowView)bs.Current, validateChanges);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE);
                        return;
                    }

                }
                else
                {
                    Application.DoEvents();

                    res = CLIENT_APP_PARAM.gcws.UPDATE_ARTICLE(CODE_ARTICLE, (decimal)cbx_MARQUE.SelectedValue, (decimal)cbxFamille.SelectedValue,
                        (decimal)cbxCategorie.SelectedValue, (decimal)cbxFournisseur.SelectedValue, txt_REF_ARTICLE.Text,
                        txt_REF_FOURNISSEUR.Text, txt_DESIGNATION_NV_ARTICLE.Text, "", txt_DescArticle.Text,
                        txt_CodeAbarre.Text, nud_QTE_NV_ARTICLE.Value, (decimal)cbxUnite.SelectedValue, nud_QTE_MIN_NV_ARTICLE.Value,
                        CLIENT_APP_PARAM.IMAGE_TO_BYTE(PHOTO_NV_ARTICLE.Image), Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue), Convert.ToDecimal(txt_taux_majoration.EditValue), Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue),
                        (decimal)cbx_TVA_NV_ARTICLE.SelectedValue, Convert.ToDecimal(txt_MAX_REMISE.EditValue), ETAT_NV_ARTICLE.Checked, Convert.ToDecimal(txt_PRIX_SOLDE.EditValue)
                        , chbx_PRIX_FIXE.Checked, Convert.ToDecimal(txt_prix_ttc.EditValue), (decimal)cbx_AchatArticle.SelectedValue);

                    if (res.OK)
                    {

                        validateChanges = true;
                        MessageBox.Show(res.MESSAGE);
                        if (Enregistrer != null)
                            Enregistrer((DataRowView)bs.Current, validateChanges);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE);
                        return;
                    }

                }


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_fermer_nv_article_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_parcourir_article_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PHOTO_NV_ARTICLE.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BN_ANNULER_PHOTO_Click(object sender, EventArgs e)
        {
            PHOTO_NV_ARTICLE.Image = null;
        }

        private void CODE_BARRE_NV_ARTICLE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHM_NV_ARTICLE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            if (e.KeyCode == Keys.F10)
            {
                if (btn_enreg_article.Enabled) btn_enreg_article.PerformClick();
            }


        }

        private void comboBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CHM_ARTICLE_FOURNISSEUR f = new CHM_ARTICLE_FOURNISSEUR();
            f.select_fournisseur_event += new CHM_ARTICLE_FOURNISSEUR.fournisseur_select(f_select_fournisseur_event);
            f.ShowDialog();
        }
        
        DataTable dt_recherche_en_stock;
        private void DESIGNATION_NV_ARTICLE_Leave(object sender, EventArgs e)
        {

            try
            {
                //dt_recherche_en_stock = CLIENT_APP_PARAM.GEST.P_STOCK.SEARCH_ARTICLE_STOCK(DESIGNATION_NV_ARTICLE.Text);
                dt_recherche_en_stock = CLIENT_APP_PARAM.gcws.SEARCH_ARTICLE_STOCK(txt_DESIGNATION_NV_ARTICLE.Text);
                if (dt_recherche_en_stock.Rows.Count != 0)
                {
                    if (MessageBox.Show("Ce produit est déja existant.\nVoulez vous l'afficher et le modifier?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;


                        CHM_RECHERCHE_STOCK f = new CHM_RECHERCHE_STOCK(txt_DESIGNATION_NV_ARTICLE.Text);
                        f.fermer += new CHM_RECHERCHE_STOCK.fermer_deleg(f_fermer);
                        f.Show();



                    }
                    else
                    {
                        //DESIGNATION_NV_ARTICLE.Text = "";
                    }
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

        void f_fermer()
        {
            this.Close();
        }

        private void sélectionnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_ARTICLE_CATEGORIE fenetre = new CHM_ARTICLE_CATEGORIE("s");
            fenetre.selection += new CHM_ARTICLE_CATEGORIE.select_deleg(fenetre_selection);
            fenetre.StartPosition = FormStartPosition.CenterScreen;
            fenetre.ShowDialog();
        }

        void fenetre_selection(decimal code_Categ, decimal codeFamille)
        {
            cbxCategorie.SelectedValue = code_Categ;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //CHM_ARTICLE_FOURNISSEUR f = new CHM_ARTICLE_FOURNISSEUR();
            //f.select_fournisseur_event += new CHM_ARTICLE_FOURNISSEUR.fournisseur_select(f_select_fournisseur_event);
            //f.ShowDialog();
        }



        private void CATEGORIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }





        private void REF_NV_ARTICLE_Leave(object sender, EventArgs e)
        {
            if (CODE_ARTICLE == "-1")
            {
                try
                {
                    if (txt_REF_ARTICLE.Text.Trim() == "")
                    {
                        Application.DoEvents();
                        //REF_NV_ARTICLE.Text = CLIENT_APP_PARAM.GEST.P_ARTICLE.NEW_CODE(5);
                        txt_REF_ARTICLE.Text = CLIENT_APP_PARAM.gcws.NEW_CODE_ARTICLE(5);

                        txt_DESIGNATION_NV_ARTICLE.Focus();
                    }
                    else
                    {
                        Application.DoEvents();
                        DataTable dt_verfif = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE_BY_REF(txt_REF_ARTICLE.Text);
                        if (dt_verfif.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Il existe déja un article avec cette référence,\nvoulez vous afficher ses informations et la modifier?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                CODE_ARTICLE = dt_verfif.Rows[0]["CODE_ARTICLE"].ToString();
                                dt = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE(CODE_ARTICLE);
                                bs.DataSource = dt;


                                if (CODE_ARTICLE != "-1")
                                {
                                    this.Text = entete_Formulaire_21.windows_name.Text = "Modification d'Article";
                                    cbxCategorie.SelectedValue = (bs.Current as DataRowView)["CODE_CATEG"];
                                    //MAGASIN.SelectedValue = (bs.Current as DataRowView)["CODE_MAG"];
                                    //FOURNISSEUR.SelectedValue = (bs.Current as DataRowView)["CODE_FOURNISSEUR"];

                                }
                            }
                            else
                            {
                                txt_REF_ARTICLE.Text = "";
                                txt_REF_ARTICLE.Focus();
                                txt_REF_ARTICLE.SelectAll();
                            }
                        }
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void nud_PRIX_SOLDE_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_PRIX_SOLDE.EditValue) >= Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue))
            {
                errorProvider1.SetError(txt_PRIX_SOLDE, "Le prix en solde doit etre inférieur ou égal au prix de vente normal.");
                txt_PRIX_SOLDE.Focus();
                txt_PRIX_SOLDE.Select();
            }
        }

        private void btn_categ_Click(object sender, EventArgs e)
        {
            CHM_ARTICLE_CATEGORIE f = new CHM_ARTICLE_CATEGORIE("s");
            f.selection += new CHM_ARTICLE_CATEGORIE.select_deleg(f_selection_categ);
            f.ShowDialog();
        }

        void f_selection_categ(decimal code_categ, decimal codeFamille)
        {
            chargerFamille();
            chargerCategorie();
            cbxFamille.SelectedValue = codeFamille;
            cbxCategorie.SelectedValue = code_categ;
        }






        private void btn_ajouter_codebarre_Click(object sender, EventArgs e)
        {
            CHM_CMP_BARCODE br = new CHM_CMP_BARCODE();
            br.verifierExistance += new CHM_CMP_BARCODE.Verif(br_verifierExistance);
            br.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
            p_barcode.Controls.Add(br);
        }

        void br_verifierExistance(string barCode)
        {
            //foreach (Control c in p_barcode.Controls)
            //{
            //    if((c as CHM_CMP_BARCODE).barcode==)
            //}
        }


        string _selected_Barcode = "";
        void btn_supprimer_Click(object sender, EventArgs e)
        {
            _selected_Barcode = ((sender as Control).Parent as CHM_CMP_BARCODE).barcode;
            foreach (Control c in p_barcode.Controls)
            {
                if ((c as CHM_CMP_BARCODE).barcode == _selected_Barcode)
                    c.Dispose();
            }
        }




        #region Chargement paramètrage

        #region MARQUE
        private void chargerMarque()
        {
            try
            {

                bsMarque.DataSource = CLIENT_APP_PARAM.ds_param.MARQUE;
                cbx_MARQUE.DataSource = bsMarque;
                cbx_MARQUE.DisplayMember = "DESIGNATION_MARQUE";
                cbx_MARQUE.ValueMember = "CODE_MARQUE";
                cbx_MARQUE.SelectedValueChanged += new EventHandler(MARQUE_NV_ARTICLE_SelectedValueChanged);
            }
            catch (Exception er)
            {
                throw er;
            }

        }

        void MARQUE_NV_ARTICLE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lb_REF_MARQUE.Text = (bsMarque[bsMarque.Find("CODE_MARQUE", (decimal)cbx_MARQUE.SelectedValue)] as DataRowView)["REF_MARQUE"].ToString();
                if (CODE_ARTICLE == "-1")
                    txt_REF_ARTICLE.Text = string.Format("{0}{1}{2}", lb_REF_MARQUE.Text, lb_REF_FAMILLE.Text, CODE_ARTICLE == "-1" ? CLIENT_APP_PARAM.gcws.NEW_CODE_ARTICLE(5) : dt.Rows[0]["REF_ARTICLE"]);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Marques");
            }
        }
        #endregion

        #region FAMILLE ARTICLE
        private void chargerFamille()
        {
            try
            {
                bsFamille.DataSource = CLIENT_APP_PARAM.ds_param.FAMILLE;
                cbxFamille.DataSource = bsFamille;
                cbxFamille.DisplayMember = "DESIGNATION_FAMILLE";
                cbxFamille.ValueMember = "CODE_FAMILLE";
                cbxFamille.SelectedValueChanged += new EventHandler(cbx_FAMILLE_SelectedValueChanged);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        void cbx_FAMILLE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CLIENT_APP_PARAM.ds_param.CATEGORIE.DefaultView.RowFilter = "CODE_FAMILLE = '" + cbxFamille.SelectedValue.ToString() + "'";
                bs_categ.DataSource = CLIENT_APP_PARAM.ds_param.CATEGORIE.DefaultView.ToTable();
                CLIENT_APP_PARAM.ds_param.CATEGORIE.DefaultView.RowFilter = "";

                //bs_categ.DataSource = CLIENT_APP_PARAM.ds_param.CATEGORIE("CODE_FAMILLE = '" + cbxFamille.SelectedValue.ToString() + "'");
                //bs_categ.DataSource=
                lb_REF_FAMILLE.Text = CLIENT_APP_PARAM.ds_param.FAMILLE.Select("CODE_FAMILLE = '" + cbxFamille.SelectedValue.ToString() + "'")[0]["REF_FAMILLE"].ToString();
                if (CODE_ARTICLE == "-1")
                    txt_REF_ARTICLE.Text = string.Format("{0}{1}{2}", lb_REF_MARQUE.Text, lb_REF_FAMILLE.Text, CODE_ARTICLE == "-1" ? CLIENT_APP_PARAM.gcws.NEW_CODE_ARTICLE(5) : dt.Rows[0]["REF_ARTICLE"]);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

        #region Fournisseur
        private void chargerFournisseur()
        {
            try
            {
                bs_fourn.DataSource = CLIENT_APP_PARAM.ds_param.FOURNISSEUR;
                cbxFournisseur.DataSource = bs_fourn;
                cbxFournisseur.DisplayMember = "RS_FOURNISSEUR";
                cbxFournisseur.ValueMember = "CODE_FOURNISSEUR";
                cbxFournisseur.SelectedValueChanged += new EventHandler(FOURNISSEUR_SelectedValueChanged);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        void FOURNISSEUR_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lb_ref_fournisseur.Text = (bs_fourn[bs_fourn.Find("CODE_FOURNISSEUR", (decimal)cbxFournisseur.SelectedValue)] as DataRowView)["REF_FOURNISSEUR"].ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Fournisseurs");
            }
        }
        #endregion

        #region Catégorie
        private void chargerCategorie()
        {
            try
            {
                CLIENT_APP_PARAM.ds_param.CATEGORIE.DefaultView.RowFilter = cbxFamille.SelectedValue != null ? "CODE_FAMILLE = '" + cbxFamille.SelectedValue.ToString() + "'" : "CODE_FAMILLE = ''";
                bs_categ.DataSource = CLIENT_APP_PARAM.ds_param.CATEGORIE.DefaultView.ToTable();
                CLIENT_APP_PARAM.ds_param.CATEGORIE.DefaultView.RowFilter = "";


                //bs_categ.DataSource = cbxFamille.SelectedValue != null ? CLIENT_APP_PARAM.ds_param.CATEGORIE.Select("CODE_FAMILLE = '" + cbxFamille.SelectedValue.ToString() + "'") : CLIENT_APP_PARAM.ds_param.CATEGORIE;
                //bs_categ.DataSource = CLIENT_APP_PARAM.ds_param.CATEGORIE.Select();
                cbxCategorie.DataSource = bs_categ;
                cbxCategorie.DisplayMember = "LIB_CATEG";
                cbxCategorie.ValueMember = "CODE_CATEG";
                cbxCategorie.SelectedValueChanged += new EventHandler(cbx_CATEGORIE_SelectedValueChanged);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        void cbx_CATEGORIE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //lb_ref_categ.Text = (bs_categ[bs_categ.Find("CODE_CATEG", (decimal)cbxCategorie.SelectedValue)] as DataRowView)["CODE_CATEG"].ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Catégories");
            }
        }

        #endregion

        #region Unité

        private void chargerUnite()
        {

            cbxUnite.DataSource = CLIENT_APP_PARAM.ds_param.UNITE;
            cbxUnite.DisplayMember = "LIB_UNITE";
            cbxUnite.ValueMember = "CODE_UNITE";
        }
        #endregion

        #region TVA
        private void chargerTVA()
        {
            cbx_TVA_NV_ARTICLE.DataSource = CLIENT_APP_PARAM.ds_param.TVA;
            cbx_TVA_NV_ARTICLE.DisplayMember = "TAUX_TVA";
            cbx_TVA_NV_ARTICLE.ValueMember = "CODE_TVA";

            dtTVAAchat.Clear();
            dtTVAAchat.Merge(CLIENT_APP_PARAM.ds_param.TVA);
            cbx_AchatArticle.DataSource = dtTVAAchat;
            cbx_AchatArticle.DisplayMember = "TAUX_TVA";
            cbx_AchatArticle.ValueMember = "CODE_TVA";
        }

        #endregion

        #endregion





        private void btn_select_MARQUE_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_MARQUES f = new CHM_FRM_LISTE_MARQUES("s");
            f.OnSelect += new CHM_FRM_LISTE_MARQUES.SELECTION(f_OnSelect);
            f.ShowDialog();

        }

        void f_OnSelect(decimal code)
        {
            cbx_MARQUE.SelectedValue = code;
        }

        private void btn_select_famille_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_FAMILLE f = new CHM_FRM_LISTE_FAMILLE("s");
            f.OnSelect += new CHM_FRM_LISTE_FAMILLE.Selection(OnSelectFamille);
            f.ShowDialog();
        }

        void OnSelectFamille(decimal codeFamille)
        {
            chargerFamille();
            chargerCategorie();
            cbxFamille.SelectedValue = codeFamille;
        }

        private void CHM_NV_ARTICLE_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbx_MARQUE.SelectedValueChanged -= MARQUE_NV_ARTICLE_SelectedValueChanged;
            cbxCategorie.SelectedValueChanged -= cbx_CATEGORIE_SelectedValueChanged;
            cbxFamille.SelectedValueChanged -= cbx_FAMILLE_SelectedValueChanged;
            cbxFournisseur.SelectedValueChanged -= FOURNISSEUR_SelectedValueChanged;
            txt_taux_majoration.EditValueChanged -= txt_taux_majoration_EditValueChanged;
            txt_prix_ttc.EditValueChanged -= txt_prix_ttc_EditValueChanged;
            txt_PRIX_HT_V_NV_ARTICLE.EditValueChanged -= txt_PRIX_HT_V_NV_ARTICLE_EditValueChanged;
            bs.PositionChanged -= bs_PositionChanged;
            
            if (OnClosing != null)
                OnClosing(validateChanges);
            this.Dispose();
        }

        private void txt_taux_majoration_EditValueChanged(object sender, EventArgs e)
        {
            if (chbx_PRIX_FIXE.Checked)
            {

            }
            else
            {
                txt_PRIX_HT_V_NV_ARTICLE.EditValue = Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) == 0 ? Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) : Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) * (1 + (decimal)txt_taux_majoration.EditValue);
                //txt_taux_majoration.EditValue = Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) / (Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) == 0 ? 1 : Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue)) - 1;
                txt_prix_ttc.EditValue = Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) * Convert.ToDecimal(1 + Convert.ToDecimal(cbx_TVA_NV_ARTICLE.Text) / 100);
            }
        }

        private void txt_PRIX_HT_V_NV_ARTICLE_EditValueChanged(object sender, EventArgs e)
        {
            if (chbx_PRIX_FIXE.Checked)
            {

            }
            else
            {
                txt_taux_majoration.EditValue = Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) == 0 ? txt_taux_majoration.EditValue : Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) / Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue);
                txt_prix_ttc.EditValue = Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) * Convert.ToDecimal(1 + Convert.ToDecimal(cbx_TVA_NV_ARTICLE.Text) / 100);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

            txt_prix_ttc.Enabled = chbx_PRIX_FIXE.Checked;
            txt_taux_majoration.Enabled = !chbx_PRIX_FIXE.Checked;
        }


        private void calculerPrix()
        {

        }

        private void txt_prix_ttc_EditValueChanged(object sender, EventArgs e)
        {
            if (chbx_PRIX_FIXE.Checked)
            {
                txt_PRIX_HT_V_NV_ARTICLE.EditValue = Convert.ToDecimal(txt_prix_ttc.EditValue) / (1 + Convert.ToDecimal(cbx_TVA_NV_ARTICLE.Text) / 100);
                txt_taux_majoration.EditValue = Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) == 0 ? txt_taux_majoration.EditValue : Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) / Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) - 1;
            }
            else
            {

            }
        }

        private void CHM_NV_ARTICLE_Load(object sender, EventArgs e)
        {
            checkEdit1_CheckedChanged(null, null);
        }

        private void cbx_TVA_NV_ARTICLE_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (chbx_PRIX_FIXE.Checked)
                {
                    txt_PRIX_HT_V_NV_ARTICLE.EditValue = Convert.ToDecimal(txt_prix_ttc.EditValue) / (1 + Convert.ToDecimal(cbx_TVA_NV_ARTICLE.Text) / 100);
                    txt_taux_majoration.EditValue = Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) == 0 ? txt_taux_majoration.EditValue : Convert.ToDecimal(txt_PRIX_HT_V_NV_ARTICLE.EditValue) / Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue) - 1;
                }
                else
                {
                    txt_PRIX_HT_V_NV_ARTICLE.EditValue = Convert.ToDecimal(1 + cbx_AchatArticle.Text == null ? 0 : Convert.ToDecimal(cbx_AchatArticle.Text))
                        / Convert.ToDecimal(1 + (cbx_TVA_NV_ARTICLE.Text == null || cbx_TVA_NV_ARTICLE.Text == string.Empty ? 0 : Convert.ToDecimal(cbx_TVA_NV_ARTICLE.Text)))
                        * (txt_PRIX_HT_A_ARTICLE.EditValue == null || txt_PRIX_HT_A_ARTICLE.EditValue == string.Empty ? 0 : Convert.ToDecimal(txt_PRIX_HT_A_ARTICLE.EditValue))
                        * (txt_taux_majoration.EditValue == null || txt_taux_majoration.EditValue == string.Empty ? 0 : Convert.ToDecimal(txt_taux_majoration.EditValue));
                }
            }
            catch (Exception er)
            {
                
            }
        }

        private void txt_CodeAbarre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txt_CodeAbarre.Text != string.Empty)
                {
                    DataTable dt = CLIENT_APP_PARAM.gcws.LOAD_ARTICLE_BY_BARCODE(txt_CodeAbarre.Text);
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["CODE_ARTICLE"] != CODE_ARTICLE)
                        {
                            MessageBox.Show(string.Format("Code à barre déja utilisé avec un autre article.\nDétails :\nCode Article :{0}\nRéf. Article : {1}\nDésignation Article : {2}", dt.Rows[0]["CODE_ARTICLE"], dt.Rows[0]["REF_ARTICLE"], dt.Rows[0]["DESIGNATION_ARTICLE"]), this.Text);
                            errorProvider1.SetError(txt_CodeAbarre, string.Format("Code à barre déja utilisé avec un autre article."));

                            txt_CodeAbarre.SelectAll();
                            
                            e.Cancel = true;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
            finally
            {
                
            }
        }

        private void btn_select_fournisseur_Click(object sender, EventArgs e)
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
            //txt_fournisseur.Text = (string)fournisseur["RS_FOURNISSEUR"];
            //txt_fournisseur.Tag = (decimal)fournisseur["CODE_FOURNISSEUR"];
            //txtAdresseFournisseur.Text = fournisseur["ADRESSE_FOURNISSEUR"].ToString();
            //txtCodeTvaFournisseur.Text = fournisseur["CODE_TVA_FOURNISSEUR"].ToString();
            //txtTelFournisseur.Text = fournisseur["TEL_FOURNISSEUR"].ToString();
            //txtFaxFournisseur.Text = fournisseur["FAX_FOURNISSEUR"].ToString();

            cbxFournisseur.SelectedValue = (decimal)fournisseur["CODE_FOURNISSEUR"];
            
        }
    }
}
