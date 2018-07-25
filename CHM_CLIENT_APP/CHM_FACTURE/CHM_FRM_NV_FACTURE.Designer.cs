namespace CHM_CLIENT_APP.CHM_FACTURE
{
    partial class CHM_FRM_NV_FACTURE
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_NV_FACTURE));
            this.dataGridViewLG_B_LIV = new System.Windows.Forms.DataGridView();
            this.REF_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CODE_BL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARQUE_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_HT_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_tot_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_TTC_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remarq = new System.Windows.Forms.Label();
            this.HT = new LABEL_NUM.LabelNumerique();
            this.TAUX_REMISE = new LABEL_NUM.LabelNumerique();
            this.TVA = new LABEL_NUM.LabelNumerique();
            this.TTC = new LABEL_NUM.LabelNumerique();
            this.TIMBRE = new LABEL_NUM.LabelNumerique();
            this.NP = new LABEL_NUM.LabelNumerique();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TTC1 = new System.Windows.Forms.Label();
            this.TVA1 = new System.Windows.Forms.Label();
            this.ML = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_Commandes_ENCOURS = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PARCOURIR_LISTE_CLIENT = new System.Windows.Forms.Button();
            this.DATE_FACTURE = new System.Windows.Forms.DateTimePicker();
            this.CODE_FACTURE = new System.Windows.Forms.Label();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.REF_CLIENT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TEL_CLIENT = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TOTAL_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_U_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TOTAL_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTVA_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPRIX_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTYPE_PIECE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTE_NP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FACTURE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHECKED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.de_Au = new System.Windows.Forms.DateTimePicker();
            this.de_DU = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAu = new System.Windows.Forms.Label();
            this.lbDu = new System.Windows.Forms.Label();
            this.rb_periode = new System.Windows.Forms.RadioButton();
            this.rb_Date = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLG_B_LIV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLG_B_LIV
            // 
            this.dataGridViewLG_B_LIV.AllowUserToAddRows = false;
            this.dataGridViewLG_B_LIV.AllowUserToDeleteRows = false;
            this.dataGridViewLG_B_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLG_B_LIV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLG_B_LIV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLG_B_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLG_B_LIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF_ARTICLE_,
            this._CODE_BL,
            this.DESIGNATION_ARTICLE_,
            this.MARQUE_ARTICLE_,
            this.QTE_LG_COMMANDE_,
            this.PRIX_HT_LG_COMMANDE_,
            this.prix_tot_ht,
            this.Column6,
            this.TVA_LG_COMMANDE_,
            this.PRIX_TTC_LG_COMMANDE_,
            this.Column2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLG_B_LIV.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewLG_B_LIV.Location = new System.Drawing.Point(296, 100);
            this.dataGridViewLG_B_LIV.MultiSelect = false;
            this.dataGridViewLG_B_LIV.Name = "dataGridViewLG_B_LIV";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLG_B_LIV.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewLG_B_LIV.Size = new System.Drawing.Size(634, 255);
            this.dataGridViewLG_B_LIV.TabIndex = 81;
            // 
            // REF_ARTICLE_
            // 
            this.REF_ARTICLE_.DataPropertyName = "REF_ARTICLE";
            this.REF_ARTICLE_.FillWeight = 91.94871F;
            this.REF_ARTICLE_.HeaderText = "Réf.";
            this.REF_ARTICLE_.Name = "REF_ARTICLE_";
            this.REF_ARTICLE_.ReadOnly = true;
            // 
            // _CODE_BL
            // 
            this._CODE_BL.DataPropertyName = "CODE_BL";
            this._CODE_BL.HeaderText = "Code B.L.";
            this._CODE_BL.Name = "_CODE_BL";
            // 
            // DESIGNATION_ARTICLE_
            // 
            this.DESIGNATION_ARTICLE_.DataPropertyName = "DESIGNATION_ARTICLE";
            this.DESIGNATION_ARTICLE_.FillWeight = 206.1886F;
            this.DESIGNATION_ARTICLE_.HeaderText = "Désignation";
            this.DESIGNATION_ARTICLE_.Name = "DESIGNATION_ARTICLE_";
            this.DESIGNATION_ARTICLE_.ReadOnly = true;
            // 
            // MARQUE_ARTICLE_
            // 
            this.MARQUE_ARTICLE_.DataPropertyName = "MARQUE_ARTICLE";
            this.MARQUE_ARTICLE_.FillWeight = 117.8234F;
            this.MARQUE_ARTICLE_.HeaderText = "Marque";
            this.MARQUE_ARTICLE_.Name = "MARQUE_ARTICLE_";
            this.MARQUE_ARTICLE_.ReadOnly = true;
            this.MARQUE_ARTICLE_.Visible = false;
            // 
            // QTE_LG_COMMANDE_
            // 
            this.QTE_LG_COMMANDE_.DataPropertyName = "QTE_LIGNE_B_LIV";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.QTE_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle2;
            this.QTE_LG_COMMANDE_.FillWeight = 75.39296F;
            this.QTE_LG_COMMANDE_.HeaderText = "Quantité";
            this.QTE_LG_COMMANDE_.Name = "QTE_LG_COMMANDE_";
            // 
            // PRIX_HT_LG_COMMANDE_
            // 
            this.PRIX_HT_LG_COMMANDE_.DataPropertyName = "PRIX_HT_B_LIV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N3";
            this.PRIX_HT_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle3;
            this.PRIX_HT_LG_COMMANDE_.FillWeight = 101.4899F;
            this.PRIX_HT_LG_COMMANDE_.HeaderText = "Prix U. HT";
            this.PRIX_HT_LG_COMMANDE_.Name = "PRIX_HT_LG_COMMANDE_";
            // 
            // prix_tot_ht
            // 
            this.prix_tot_ht.DataPropertyName = "PRIX_TOTAL_HT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.prix_tot_ht.DefaultCellStyle = dataGridViewCellStyle4;
            this.prix_tot_ht.FillWeight = 102.7744F;
            this.prix_tot_ht.HeaderText = "Prix HT. Total";
            this.prix_tot_ht.Name = "prix_tot_ht";
            this.prix_tot_ht.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "REMISE";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.FillWeight = 55.79971F;
            this.Column6.HeaderText = "Remise";
            this.Column6.Name = "Column6";
            // 
            // TVA_LG_COMMANDE_
            // 
            this.TVA_LG_COMMANDE_.DataPropertyName = "TVA_B_LIV";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.TVA_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle6;
            this.TVA_LG_COMMANDE_.FillWeight = 58.68565F;
            this.TVA_LG_COMMANDE_.HeaderText = "TVA";
            this.TVA_LG_COMMANDE_.Name = "TVA_LG_COMMANDE_";
            this.TVA_LG_COMMANDE_.ReadOnly = true;
            // 
            // PRIX_TTC_LG_COMMANDE_
            // 
            this.PRIX_TTC_LG_COMMANDE_.DataPropertyName = "PRIX_U_TTC";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "N3";
            this.PRIX_TTC_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle7;
            this.PRIX_TTC_LG_COMMANDE_.FillWeight = 109.3034F;
            this.PRIX_TTC_LG_COMMANDE_.HeaderText = "Prix U. TTC";
            this.PRIX_TTC_LG_COMMANDE_.Name = "PRIX_TTC_LG_COMMANDE_";
            this.PRIX_TTC_LG_COMMANDE_.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PRIX_TOTAL_TTC";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.FillWeight = 109.0868F;
            this.Column2.HeaderText = "Prix Total TTC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.remarq);
            this.panel1.Controls.Add(this.HT);
            this.panel1.Controls.Add(this.TAUX_REMISE);
            this.panel1.Controls.Add(this.TVA);
            this.panel1.Controls.Add(this.TTC);
            this.panel1.Controls.Add(this.TIMBRE);
            this.panel1.Controls.Add(this.NP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TTC1);
            this.panel1.Controls.Add(this.TVA1);
            this.panel1.Controls.Add(this.ML);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(296, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 140);
            this.panel1.TabIndex = 82;
            // 
            // remarq
            // 
            this.remarq.AutoSize = true;
            this.remarq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.remarq.Location = new System.Drawing.Point(9, 106);
            this.remarq.Name = "remarq";
            this.remarq.Size = new System.Drawing.Size(0, 13);
            this.remarq.TabIndex = 8;
            // 
            // HT
            // 
            this.HT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HT.Clinote = false;
            this.HT.Couleur1 = System.Drawing.Color.Black;
            this.HT.Couleur2 = System.Drawing.Color.Red;
            this.HT.DecimalPlaces = 3;
            this.HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.HT.ForeColor = System.Drawing.Color.Black;
            this.HT.Location = new System.Drawing.Point(489, 6);
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(123, 13);
            this.HT.TabIndex = 6;
            this.HT.Text = "0.000";
            this.HT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HT.ThousandsSeparator = true;
            this.HT.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TAUX_REMISE
            // 
            this.TAUX_REMISE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TAUX_REMISE.Clinote = false;
            this.TAUX_REMISE.Couleur1 = System.Drawing.Color.Black;
            this.TAUX_REMISE.Couleur2 = System.Drawing.Color.Red;
            this.TAUX_REMISE.DecimalPlaces = 3;
            this.TAUX_REMISE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TAUX_REMISE.ForeColor = System.Drawing.Color.Black;
            this.TAUX_REMISE.Location = new System.Drawing.Point(489, 27);
            this.TAUX_REMISE.Name = "TAUX_REMISE";
            this.TAUX_REMISE.Size = new System.Drawing.Size(123, 13);
            this.TAUX_REMISE.TabIndex = 7;
            this.TAUX_REMISE.Text = "0.000";
            this.TAUX_REMISE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TAUX_REMISE.ThousandsSeparator = true;
            this.TAUX_REMISE.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TVA
            // 
            this.TVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TVA.Clinote = false;
            this.TVA.Couleur1 = System.Drawing.Color.Black;
            this.TVA.Couleur2 = System.Drawing.Color.Red;
            this.TVA.DecimalPlaces = 3;
            this.TVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TVA.ForeColor = System.Drawing.Color.Black;
            this.TVA.Location = new System.Drawing.Point(489, 48);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(123, 13);
            this.TVA.TabIndex = 7;
            this.TVA.Text = "0.000";
            this.TVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TVA.ThousandsSeparator = true;
            this.TVA.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TTC
            // 
            this.TTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTC.Clinote = false;
            this.TTC.Couleur1 = System.Drawing.Color.Black;
            this.TTC.Couleur2 = System.Drawing.Color.Red;
            this.TTC.DecimalPlaces = 3;
            this.TTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TTC.ForeColor = System.Drawing.Color.Black;
            this.TTC.Location = new System.Drawing.Point(489, 69);
            this.TTC.Name = "TTC";
            this.TTC.Size = new System.Drawing.Size(123, 13);
            this.TTC.TabIndex = 5;
            this.TTC.Text = "0.000";
            this.TTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTC.ThousandsSeparator = true;
            this.TTC.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TIMBRE
            // 
            this.TIMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TIMBRE.Clinote = false;
            this.TIMBRE.Couleur1 = System.Drawing.Color.Black;
            this.TIMBRE.Couleur2 = System.Drawing.Color.Red;
            this.TIMBRE.DecimalPlaces = 3;
            this.TIMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TIMBRE.ForeColor = System.Drawing.Color.Black;
            this.TIMBRE.Location = new System.Drawing.Point(489, 90);
            this.TIMBRE.Name = "TIMBRE";
            this.TIMBRE.Size = new System.Drawing.Size(123, 13);
            this.TIMBRE.TabIndex = 3;
            this.TIMBRE.Text = "0.400";
            this.TIMBRE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIMBRE.ThousandsSeparator = true;
            this.TIMBRE.Value = new decimal(new int[] {
            400,
            0,
            0,
            196608});
            // 
            // NP
            // 
            this.NP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NP.Clinote = true;
            this.NP.Couleur1 = System.Drawing.Color.Gray;
            this.NP.Couleur2 = System.Drawing.Color.OrangeRed;
            this.NP.DecimalPlaces = 3;
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.NP.ForeColor = System.Drawing.Color.OrangeRed;
            this.NP.Location = new System.Drawing.Point(505, 106);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(111, 24);
            this.NP.TabIndex = 4;
            this.NP.Text = "0.000";
            this.NP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NP.ThousandsSeparator = true;
            this.NP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(329, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Remise :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(328, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Net a payer :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(329, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Timbre :";
            // 
            // TTC1
            // 
            this.TTC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTC1.AutoSize = true;
            this.TTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TTC1.Location = new System.Drawing.Point(329, 66);
            this.TTC1.Name = "TTC1";
            this.TTC1.Size = new System.Drawing.Size(98, 13);
            this.TTC1.TabIndex = 0;
            this.TTC1.Text = "Montant Total : ";
            // 
            // TVA1
            // 
            this.TVA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TVA1.AutoSize = true;
            this.TVA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TVA1.Location = new System.Drawing.Point(329, 46);
            this.TVA1.Name = "TVA1";
            this.TVA1.Size = new System.Drawing.Size(105, 13);
            this.TVA1.TabIndex = 0;
            this.TVA1.Text = "Montant T. TVA :";
            // 
            // ML
            // 
            this.ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ML.Location = new System.Drawing.Point(3, 6);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(320, 56);
            this.ML.TabIndex = 0;
            this.ML.Text = "Arreter la présente facture à la somme de ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(329, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Montant T. HT :";
            // 
            // p_Commandes_ENCOURS
            // 
            this.p_Commandes_ENCOURS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.p_Commandes_ENCOURS.AutoScroll = true;
            this.p_Commandes_ENCOURS.BackColor = System.Drawing.Color.Silver;
            this.p_Commandes_ENCOURS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Commandes_ENCOURS.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.p_Commandes_ENCOURS.Location = new System.Drawing.Point(6, 110);
            this.p_Commandes_ENCOURS.Name = "p_Commandes_ENCOURS";
            this.p_Commandes_ENCOURS.Size = new System.Drawing.Size(234, 270);
            this.p_Commandes_ENCOURS.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Liste des bons de livraison non facturés :";
            // 
            // PARCOURIR_LISTE_CLIENT
            // 
            this.PARCOURIR_LISTE_CLIENT.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.PARCOURIR_LISTE_CLIENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PARCOURIR_LISTE_CLIENT.Location = new System.Drawing.Point(112, 3);
            this.PARCOURIR_LISTE_CLIENT.Name = "PARCOURIR_LISTE_CLIENT";
            this.PARCOURIR_LISTE_CLIENT.Size = new System.Drawing.Size(24, 23);
            this.PARCOURIR_LISTE_CLIENT.TabIndex = 109;
            this.PARCOURIR_LISTE_CLIENT.UseVisualStyleBackColor = true;
            this.PARCOURIR_LISTE_CLIENT.Click += new System.EventHandler(this.PARCOURIR_LISTE_CLIENT_Click);
            // 
            // DATE_FACTURE
            // 
            this.DATE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE_FACTURE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_FACTURE.Location = new System.Drawing.Point(806, 74);
            this.DATE_FACTURE.Name = "DATE_FACTURE";
            this.DATE_FACTURE.Size = new System.Drawing.Size(124, 20);
            this.DATE_FACTURE.TabIndex = 108;
            // 
            // CODE_FACTURE
            // 
            this.CODE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CODE_FACTURE.BackColor = System.Drawing.Color.White;
            this.CODE_FACTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_FACTURE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CODE_FACTURE.ForeColor = System.Drawing.Color.Maroon;
            this.CODE_FACTURE.Location = new System.Drawing.Point(806, 51);
            this.CODE_FACTURE.Name = "CODE_FACTURE";
            this.CODE_FACTURE.Size = new System.Drawing.Size(124, 20);
            this.CODE_FACTURE.TabIndex = 107;
            this.CODE_FACTURE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RS_CLIENT.Location = new System.Drawing.Point(8, 30);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(263, 20);
            this.RS_CLIENT.TabIndex = 106;
            this.RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.Location = new System.Drawing.Point(51, 5);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.Size = new System.Drawing.Size(55, 20);
            this.REF_CLIENT.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Client :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 114;
            this.label7.Text = "Tel :";
            // 
            // TEL_CLIENT
            // 
            this.TEL_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TEL_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEL_CLIENT.Location = new System.Drawing.Point(37, 52);
            this.TEL_CLIENT.Name = "TEL_CLIENT";
            this.TEL_CLIENT.Size = new System.Drawing.Size(125, 20);
            this.TEL_CLIENT.TabIndex = 115;
            this.TEL_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(938, 48);
            this.entete_Formulaire_21.TabIndex = 116;
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "LIGNE_FACTURE";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Location = new System.Drawing.Point(296, 98);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(634, 258);
            this.gridControl1.TabIndex = 117;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_FACTURE,
            this.colCODE_ARTICLE,
            this.colCODE_BL,
            this.colCODE_BARRE_ARTICLE,
            this.colREF_ARTICLE,
            this.colDESIGNATION_ARTICLE,
            this.colDESCRIPTION_ARTICLE,
            this.colUNITE,
            this.colQTE,
            this.colPRIX_HT_ARTICLE,
            this.colPRIX_TOTAL_HT,
            this.colREMISE,
            this.colPRIX_U_TTC,
            this.colPRIX_TOTAL_TTC,
            this.colTVA_ARTICLE,
            this.colPRIX_FACTURE,
            this.colTYPE_PIECE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PRIX_TOTAL_TTC", this.colPRIX_TOTAL_TTC, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QTE", this.colQTE, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PRIX_TOTAL_HT", this.colPRIX_TOTAL_HT, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "REF_ARTICLE", this.colREF_ARTICLE, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCODE_BL, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_FACTURE
            // 
            this.colCODE_FACTURE.FieldName = "CODE_FACTURE";
            this.colCODE_FACTURE.Name = "colCODE_FACTURE";
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            // 
            // colCODE_BL
            // 
            this.colCODE_BL.FieldName = "CODE_BL";
            this.colCODE_BL.Name = "colCODE_BL";
            this.colCODE_BL.OptionsColumn.ReadOnly = true;
            // 
            // colCODE_BARRE_ARTICLE
            // 
            this.colCODE_BARRE_ARTICLE.FieldName = "CODE_BARRE_ARTICLE";
            this.colCODE_BARRE_ARTICLE.Name = "colCODE_BARRE_ARTICLE";
            this.colCODE_BARRE_ARTICLE.OptionsColumn.ReadOnly = true;
            this.colCODE_BARRE_ARTICLE.Visible = true;
            this.colCODE_BARRE_ARTICLE.VisibleIndex = 0;
            // 
            // colREF_ARTICLE
            // 
            this.colREF_ARTICLE.FieldName = "REF_ARTICLE";
            this.colREF_ARTICLE.Name = "colREF_ARTICLE";
            this.colREF_ARTICLE.OptionsColumn.ReadOnly = true;
            this.colREF_ARTICLE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colREF_ARTICLE.Visible = true;
            this.colREF_ARTICLE.VisibleIndex = 1;
            // 
            // colDESIGNATION_ARTICLE
            // 
            this.colDESIGNATION_ARTICLE.FieldName = "DESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Name = "colDESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.OptionsColumn.ReadOnly = true;
            this.colDESIGNATION_ARTICLE.Visible = true;
            this.colDESIGNATION_ARTICLE.VisibleIndex = 2;
            this.colDESIGNATION_ARTICLE.Width = 141;
            // 
            // colDESCRIPTION_ARTICLE
            // 
            this.colDESCRIPTION_ARTICLE.FieldName = "DESCRIPTION_ARTICLE";
            this.colDESCRIPTION_ARTICLE.Name = "colDESCRIPTION_ARTICLE";
            this.colDESCRIPTION_ARTICLE.Visible = true;
            this.colDESCRIPTION_ARTICLE.VisibleIndex = 3;
            // 
            // colUNITE
            // 
            this.colUNITE.FieldName = "UNITE";
            this.colUNITE.Name = "colUNITE";
            this.colUNITE.OptionsColumn.ReadOnly = true;
            this.colUNITE.Visible = true;
            this.colUNITE.VisibleIndex = 4;
            this.colUNITE.Width = 32;
            // 
            // colQTE
            // 
            this.colQTE.FieldName = "QTE";
            this.colQTE.Name = "colQTE";
            this.colQTE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colQTE.Visible = true;
            this.colQTE.VisibleIndex = 5;
            this.colQTE.Width = 37;
            // 
            // colPRIX_HT_ARTICLE
            // 
            this.colPRIX_HT_ARTICLE.FieldName = "PRIX_HT_ARTICLE";
            this.colPRIX_HT_ARTICLE.Name = "colPRIX_HT_ARTICLE";
            this.colPRIX_HT_ARTICLE.Visible = true;
            this.colPRIX_HT_ARTICLE.VisibleIndex = 6;
            // 
            // colPRIX_TOTAL_HT
            // 
            this.colPRIX_TOTAL_HT.FieldName = "PRIX_TOTAL_HT";
            this.colPRIX_TOTAL_HT.Name = "colPRIX_TOTAL_HT";
            this.colPRIX_TOTAL_HT.OptionsColumn.ReadOnly = true;
            this.colPRIX_TOTAL_HT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPRIX_TOTAL_HT.Visible = true;
            this.colPRIX_TOTAL_HT.VisibleIndex = 7;
            // 
            // colREMISE
            // 
            this.colREMISE.FieldName = "REMISE";
            this.colREMISE.Name = "colREMISE";
            this.colREMISE.Visible = true;
            this.colREMISE.VisibleIndex = 8;
            // 
            // colPRIX_U_TTC
            // 
            this.colPRIX_U_TTC.FieldName = "PRIX_U_TTC";
            this.colPRIX_U_TTC.Name = "colPRIX_U_TTC";
            this.colPRIX_U_TTC.OptionsColumn.ReadOnly = true;
            this.colPRIX_U_TTC.Visible = true;
            this.colPRIX_U_TTC.VisibleIndex = 9;
            // 
            // colPRIX_TOTAL_TTC
            // 
            this.colPRIX_TOTAL_TTC.FieldName = "PRIX_TOTAL_TTC";
            this.colPRIX_TOTAL_TTC.Name = "colPRIX_TOTAL_TTC";
            this.colPRIX_TOTAL_TTC.OptionsColumn.ReadOnly = true;
            this.colPRIX_TOTAL_TTC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPRIX_TOTAL_TTC.Visible = true;
            this.colPRIX_TOTAL_TTC.VisibleIndex = 10;
            // 
            // colTVA_ARTICLE
            // 
            this.colTVA_ARTICLE.ColumnEdit = this.repositoryItemComboBox1;
            this.colTVA_ARTICLE.FieldName = "TVA_ARTICLE";
            this.colTVA_ARTICLE.Name = "colTVA_ARTICLE";
            this.colTVA_ARTICLE.OptionsColumn.AllowEdit = false;
            this.colTVA_ARTICLE.Visible = true;
            this.colTVA_ARTICLE.VisibleIndex = 11;
            this.colTVA_ARTICLE.Width = 40;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colPRIX_FACTURE
            // 
            this.colPRIX_FACTURE.FieldName = "PRIX_FACTURE";
            this.colPRIX_FACTURE.Name = "colPRIX_FACTURE";
            this.colPRIX_FACTURE.OptionsColumn.ReadOnly = true;
            this.colPRIX_FACTURE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPRIX_FACTURE.Visible = true;
            this.colPRIX_FACTURE.VisibleIndex = 12;
            // 
            // colTYPE_PIECE
            // 
            this.colTYPE_PIECE.Caption = "Type Pièce";
            this.colTYPE_PIECE.FieldName = "TYPE_PIECE";
            this.colTYPE_PIECE.Name = "colTYPE_PIECE";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "V_PIECE_CLIENT_SANS_FACTURE";
            this.gridControl2.DataSource = this.dS_MOUV1;
            this.gridControl2.Location = new System.Drawing.Point(0, 90);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(272, 300);
            this.gridControl2.TabIndex = 118;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTYPE_PIECE1,
            this.colCODE_PIECE,
            this.colDATE_PIECE,
            this.colCODE_CLIENT,
            this.colMONTANT_PIECE,
            this.colRESTE_NP,
            this.colCODE_FACTURE1,
            this.colCHECKED});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            this.gridView2.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanging);
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // colTYPE_PIECE1
            // 
            this.colTYPE_PIECE1.Caption = "Type";
            this.colTYPE_PIECE1.FieldName = "TYPE_PIECE";
            this.colTYPE_PIECE1.Name = "colTYPE_PIECE1";
            this.colTYPE_PIECE1.OptionsColumn.ReadOnly = true;
            this.colTYPE_PIECE1.Visible = true;
            this.colTYPE_PIECE1.VisibleIndex = 0;
            this.colTYPE_PIECE1.Width = 48;
            // 
            // colCODE_PIECE
            // 
            this.colCODE_PIECE.Caption = "Code Pièce";
            this.colCODE_PIECE.FieldName = "CODE_PIECE";
            this.colCODE_PIECE.Name = "colCODE_PIECE";
            this.colCODE_PIECE.OptionsColumn.ReadOnly = true;
            this.colCODE_PIECE.Visible = true;
            this.colCODE_PIECE.VisibleIndex = 1;
            // 
            // colDATE_PIECE
            // 
            this.colDATE_PIECE.Caption = "Date Pièce";
            this.colDATE_PIECE.FieldName = "DATE_PIECE";
            this.colDATE_PIECE.Name = "colDATE_PIECE";
            this.colDATE_PIECE.OptionsColumn.ReadOnly = true;
            this.colDATE_PIECE.Visible = true;
            this.colDATE_PIECE.VisibleIndex = 2;
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
            this.colCODE_CLIENT.OptionsColumn.ReadOnly = true;
            // 
            // colMONTANT_PIECE
            // 
            this.colMONTANT_PIECE.Caption = "Montant";
            this.colMONTANT_PIECE.FieldName = "MONTANT_PIECE";
            this.colMONTANT_PIECE.Name = "colMONTANT_PIECE";
            this.colMONTANT_PIECE.OptionsColumn.ReadOnly = true;
            this.colMONTANT_PIECE.Visible = true;
            this.colMONTANT_PIECE.VisibleIndex = 3;
            // 
            // colRESTE_NP
            // 
            this.colRESTE_NP.Caption = "Reste";
            this.colRESTE_NP.FieldName = "RESTE_NP";
            this.colRESTE_NP.Name = "colRESTE_NP";
            this.colRESTE_NP.OptionsColumn.ReadOnly = true;
            this.colRESTE_NP.Visible = true;
            this.colRESTE_NP.VisibleIndex = 4;
            // 
            // colCODE_FACTURE1
            // 
            this.colCODE_FACTURE1.FieldName = "CODE_FACTURE";
            this.colCODE_FACTURE1.Name = "colCODE_FACTURE1";
            this.colCODE_FACTURE1.OptionsColumn.ReadOnly = true;
            // 
            // colCHECKED
            // 
            this.colCHECKED.Caption = "Selectionnée";
            this.colCHECKED.FieldName = "CHECKED";
            this.colCHECKED.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCHECKED.Name = "colCHECKED";
            this.colCHECKED.Visible = true;
            this.colCHECKED.VisibleIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 56);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(278, 445);
            this.xtraTabControl1.TabIndex = 119;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.gridControl2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.p_Commandes_ENCOURS);
            this.xtraTabPage1.Controls.Add(this.REF_CLIENT);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Controls.Add(this.RS_CLIENT);
            this.xtraTabPage1.Controls.Add(this.TEL_CLIENT);
            this.xtraTabPage1.Controls.Add(this.PARCOURIR_LISTE_CLIENT);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(272, 419);
            this.xtraTabPage1.Text = "Par Client";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(145, 394);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(119, 23);
            this.simpleButton3.TabIndex = 119;
            this.simpleButton3.Text = "Dé-sélectionner tout";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Location = new System.Drawing.Point(4, 394);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 23);
            this.simpleButton2.TabIndex = 119;
            this.simpleButton2.Text = "Sélectionner tout";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton4);
            this.xtraTabPage2.Controls.Add(this.simpleButton5);
            this.xtraTabPage2.Controls.Add(this.de_Au);
            this.xtraTabPage2.Controls.Add(this.de_DU);
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.gridControl3);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.lbAu);
            this.xtraTabPage2.Controls.Add(this.lbDu);
            this.xtraTabPage2.Controls.Add(this.rb_periode);
            this.xtraTabPage2.Controls.Add(this.rb_Date);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(272, 419);
            this.xtraTabPage2.Text = "Facturation Ticket de caisse";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.Location = new System.Drawing.Point(144, 393);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(119, 23);
            this.simpleButton4.TabIndex = 124;
            this.simpleButton4.Text = "Dé-sélectionner tout";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton5.Location = new System.Drawing.Point(3, 393);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(103, 23);
            this.simpleButton5.TabIndex = 123;
            this.simpleButton5.Text = "Sélectionner tout";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // de_Au
            // 
            this.de_Au.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.de_Au.Location = new System.Drawing.Point(169, 64);
            this.de_Au.Name = "de_Au";
            this.de_Au.Size = new System.Drawing.Size(100, 20);
            this.de_Au.TabIndex = 122;
            this.de_Au.ValueChanged += new System.EventHandler(this.de_Au_EditValueChanged);
            // 
            // de_DU
            // 
            this.de_DU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.de_DU.Location = new System.Drawing.Point(36, 64);
            this.de_DU.Name = "de_DU";
            this.de_DU.Size = new System.Drawing.Size(100, 20);
            this.de_DU.TabIndex = 122;
            this.de_DU.ValueChanged += new System.EventHandler(this.de_DU_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(194, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 121;
            this.simpleButton1.Text = "Afficher";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataMember = "V_PIECE_CLIENT_SANS_FACTURE";
            this.gridControl3.DataSource = this.dS_MOUV1;
            this.gridControl3.Location = new System.Drawing.Point(0, 90);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(272, 299);
            this.gridControl3.TabIndex = 119;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView3_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Type";
            this.gridColumn1.FieldName = "TYPE_PIECE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 48;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Code Pièce";
            this.gridColumn2.FieldName = "CODE_PIECE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Date Pièce";
            this.gridColumn3.FieldName = "DATE_PIECE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "CODE_CLIENT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Montant";
            this.gridColumn5.FieldName = "MONTANT_PIECE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Reste";
            this.gridColumn6.FieldName = "RESTE_NP";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "CODE_FACTURE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Selectionnée";
            this.gridColumn8.FieldName = "CHECKED";
            this.gridColumn8.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "La facture sera comptée sur le compte du client passagé.";
            // 
            // lbAu
            // 
            this.lbAu.AutoSize = true;
            this.lbAu.Location = new System.Drawing.Point(142, 66);
            this.lbAu.Name = "lbAu";
            this.lbAu.Size = new System.Drawing.Size(26, 13);
            this.lbAu.TabIndex = 1;
            this.lbAu.Text = "Au :";
            // 
            // lbDu
            // 
            this.lbDu.AutoSize = true;
            this.lbDu.Location = new System.Drawing.Point(3, 66);
            this.lbDu.Name = "lbDu";
            this.lbDu.Size = new System.Drawing.Size(27, 13);
            this.lbDu.TabIndex = 1;
            this.lbDu.Text = "Du :";
            // 
            // rb_periode
            // 
            this.rb_periode.AutoSize = true;
            this.rb_periode.Location = new System.Drawing.Point(89, 42);
            this.rb_periode.Name = "rb_periode";
            this.rb_periode.Size = new System.Drawing.Size(79, 17);
            this.rb_periode.TabIndex = 0;
            this.rb_periode.TabStop = true;
            this.rb_periode.Text = "Par période";
            this.rb_periode.UseVisualStyleBackColor = true;
            this.rb_periode.CheckedChanged += new System.EventHandler(this.rb_periode_CheckedChanged);
            // 
            // rb_Date
            // 
            this.rb_Date.AutoSize = true;
            this.rb_Date.Location = new System.Drawing.Point(11, 42);
            this.rb_Date.Name = "rb_Date";
            this.rb_Date.Size = new System.Drawing.Size(65, 17);
            this.rb_Date.TabIndex = 0;
            this.rb_Date.TabStop = true;
            this.rb_Date.Text = "Par date";
            this.rb_Date.UseVisualStyleBackColor = true;
            this.rb_Date.CheckedChanged += new System.EventHandler(this.rb_Date_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(711, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Facture N° :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(711, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Facture :";
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 506);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(938, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 120;
            // 
            // CHM_FRM_NV_FACTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 558);
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.DATE_FACTURE);
            this.Controls.Add(this.CODE_FACTURE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewLG_B_LIV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_FRM_NV_FACTURE";
            this.Text = "Nouvelle Facture Client";
            this.Load += new System.EventHandler(this.CHM_FRM_NV_FACTURE_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_NV_FACTURE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLG_B_LIV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLG_B_LIV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label remarq;
        private LABEL_NUM.LabelNumerique HT;
        private LABEL_NUM.LabelNumerique TVA;
        private LABEL_NUM.LabelNumerique TTC;
        private LABEL_NUM.LabelNumerique TIMBRE;
        private LABEL_NUM.LabelNumerique NP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TTC1;
        private System.Windows.Forms.Label TVA1;
        private System.Windows.Forms.Label ML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel p_Commandes_ENCOURS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PARCOURIR_LISTE_CLIENT;
        private System.Windows.Forms.DateTimePicker DATE_FACTURE;
        private System.Windows.Forms.Label CODE_FACTURE;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.TextBox REF_CLIENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TEL_CLIENT;
        private LABEL_NUM.LabelNumerique TAUX_REMISE;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private DS_MOUV dS_MOUV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODE_BL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARQUE_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_HT_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_tot_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_TTC_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BL;
        private DevExpress.XtraGrid.Columns.GridColumn colUNITE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE;
        private DevExpress.XtraGrid.Columns.GridColumn colTVA_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TOTAL_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_U_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TOTAL_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colREMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BARRE_ARTICLE;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE_PIECE;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE_PIECE1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_PIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_PIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_PIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTE_NP;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FACTURE1;
        private DevExpress.XtraGrid.Columns.GridColumn colCHECKED;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label lbDu;
        private System.Windows.Forms.RadioButton rb_periode;
        private System.Windows.Forms.RadioButton rb_Date;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker de_Au;
        private System.Windows.Forms.DateTimePicker de_DU;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
    }
}