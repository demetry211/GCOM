namespace CHM_CLIENT_APP.COMMANDE_FOURNISSEUR
{
    partial class CHM_FRM_NV_CMD_FR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_NV_CMD_FR));
            this.dataSet1 = new System.Data.DataSet();
            this.DT_LG_FACTURE = new System.Data.DataTable();
            this.CODE_ARTICLE = new System.Data.DataColumn();
            this.DESIGNATION_ARTICLE = new System.Data.DataColumn();
            this.QTE_LG_FACTURE = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.ARTICLE = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_fournisseur = new System.Windows.Forms.TextBox();
            this.cbx_magazin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAJOUTER = new System.Windows.Forms.Button();
            this.buttonSUPPRIMER = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pEnteteCmd = new System.Windows.Forms.Panel();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chbx_VALIDE = new System.Windows.Forms.CheckBox();
            this.chbx_priorite = new System.Windows.Forms.CheckBox();
            this.dtp_DATE_EXPIRATION = new System.Windows.Forms.DateTimePicker();
            this.dtp_DATE_COMMANDE = new System.Windows.Forms.DateTimePicker();
            this.lb_expiration = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_REMARQUE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_NUM_COMMANDE = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_ADRESSE_LIVRAISON = new System.Windows.Forms.TextBox();
            this.txt_TEL_CONTACT = new System.Windows.Forms.TextBox();
            this.txt_CONTACT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFaxFournisseur = new System.Windows.Forms.TextBox();
            this.txtTelFournisseur = new System.Windows.Forms.TextBox();
            this.txtCodeTvaFournisseur = new System.Windows.Forms.TextBox();
            this.txtAdresseFournisseur = new System.Windows.Forms.TextBox();
            this.HT = new LABEL_NUM.LabelNumerique();
            this.REMISE = new LABEL_NUM.LabelNumerique();
            this.TVA = new LABEL_NUM.LabelNumerique();
            this.TTC = new LABEL_NUM.LabelNumerique();
            this.label9 = new System.Windows.Forms.Label();
            this.TTC1 = new System.Windows.Forms.Label();
            this.TVA1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_qte = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.UNITE_ARTICLE = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_validation_ajout = new System.Windows.Forms.Button();
            this.nud_prix = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.qte_select_article = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_COMMANDE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFODEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAUX_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_UNITE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNT_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNT_NET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNT_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNT_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bareCodeReader1 = new CHMComponents.BareCodeReader();
            this.pMAJDetails = new DevExpress.XtraEditors.PanelControl();
            this.chM_CMP_FICHE1 = new CHM_STYLE.CHM_CMP_FICHE();
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            this.pMontant = new System.Windows.Forms.Panel();
            this.btn_Valider = new CHM_STYLE.CHM_BUTTON(this.components);
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_LG_FACTURE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICLE)).BeginInit();
            this.pEnteteCmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NUM_COMMANDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel_qte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qte_select_article)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMAJDetails)).BeginInit();
            this.pMAJDetails.SuspendLayout();
            this.pMontant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DT_LG_FACTURE,
            this.ARTICLE});
            // 
            // DT_LG_FACTURE
            // 
            this.DT_LG_FACTURE.Columns.AddRange(new System.Data.DataColumn[] {
            this.CODE_ARTICLE,
            this.DESIGNATION_ARTICLE,
            this.QTE_LG_FACTURE,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn9});
            this.DT_LG_FACTURE.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Code"}, true)});
            this.DT_LG_FACTURE.PrimaryKey = new System.Data.DataColumn[] {
        this.CODE_ARTICLE};
            this.DT_LG_FACTURE.TableName = "LIGNE_CMD_FR";
            // 
            // CODE_ARTICLE
            // 
            this.CODE_ARTICLE.AllowDBNull = false;
            this.CODE_ARTICLE.Caption = "CODE_ARTICLE";
            this.CODE_ARTICLE.ColumnName = "Code";
            // 
            // DESIGNATION_ARTICLE
            // 
            this.DESIGNATION_ARTICLE.Caption = "DESIGNATION_ARTICLE";
            this.DESIGNATION_ARTICLE.ColumnName = "Désignation";
            // 
            // QTE_LG_FACTURE
            // 
            this.QTE_LG_FACTURE.Caption = "QTE";
            this.QTE_LG_FACTURE.ColumnName = "Qte";
            this.QTE_LG_FACTURE.DataType = typeof(decimal);
            this.QTE_LG_FACTURE.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Prix_HT";
            this.dataColumn1.DataType = typeof(decimal);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Remise";
            this.dataColumn2.DataType = typeof(decimal);
            this.dataColumn2.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Prix_Net";
            this.dataColumn3.DataType = typeof(decimal);
            this.dataColumn3.Expression = "Prix_HT*(1-Remise/100)";
            this.dataColumn3.ReadOnly = true;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "TVA";
            this.dataColumn4.DataType = typeof(decimal);
            this.dataColumn4.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Prix TTC";
            this.dataColumn5.ColumnName = "Prix_TTC";
            this.dataColumn5.DataType = typeof(decimal);
            this.dataColumn5.Expression = "Qte*Prix_Net*(1+TVA/100)";
            this.dataColumn5.ReadOnly = true;
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Réf.";
            this.dataColumn9.ColumnName = "REF_ARTICLE";
            // 
            // ARTICLE
            // 
            this.ARTICLE.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.ARTICLE.TableName = "ARTICLE";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Code Article";
            this.dataColumn6.ColumnName = "CODE_ARTICLE";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Réf.";
            this.dataColumn7.ColumnName = "REF_ARTICLE";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Désignation";
            this.dataColumn8.ColumnName = "DESIGNATION_ARTICLE";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Transparent;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(1022, 48);
            this.entete_Formulaire_21.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 115;
            this.label1.Text = "R.S. :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 24);
            this.button2.TabIndex = 114;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_fournisseur
            // 
            this.txt_fournisseur.BackColor = System.Drawing.Color.White;
            this.txt_fournisseur.Location = new System.Drawing.Point(96, 27);
            this.txt_fournisseur.Name = "txt_fournisseur";
            this.txt_fournisseur.ReadOnly = true;
            this.txt_fournisseur.Size = new System.Drawing.Size(192, 20);
            this.txt_fournisseur.TabIndex = 113;
            // 
            // cbx_magazin
            // 
            this.cbx_magazin.FormattingEnabled = true;
            this.cbx_magazin.Location = new System.Drawing.Point(80, 30);
            this.cbx_magazin.Name = "cbx_magazin";
            this.cbx_magazin.Size = new System.Drawing.Size(248, 21);
            this.cbx_magazin.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 117;
            this.label3.Text = "Magasin :";
            // 
            // buttonAJOUTER
            // 
            this.buttonAJOUTER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAJOUTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_321;
            this.buttonAJOUTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAJOUTER.Location = new System.Drawing.Point(7, 4);
            this.buttonAJOUTER.Name = "buttonAJOUTER";
            this.buttonAJOUTER.Size = new System.Drawing.Size(134, 51);
            this.buttonAJOUTER.TabIndex = 119;
            this.buttonAJOUTER.Text = "Ajouter Article";
            this.buttonAJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAJOUTER, "Sélectionner les articles");
            this.buttonAJOUTER.UseVisualStyleBackColor = true;
            this.buttonAJOUTER.Click += new System.EventHandler(this.buttonAJOUTER_Click);
            // 
            // buttonSUPPRIMER
            // 
            this.buttonSUPPRIMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSUPPRIMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSUPPRIMER.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.buttonSUPPRIMER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSUPPRIMER.Location = new System.Drawing.Point(7, 61);
            this.buttonSUPPRIMER.Name = "buttonSUPPRIMER";
            this.buttonSUPPRIMER.Size = new System.Drawing.Size(134, 51);
            this.buttonSUPPRIMER.TabIndex = 118;
            this.buttonSUPPRIMER.Text = "Supprimer Article";
            this.buttonSUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonSUPPRIMER, "Supprimer Article");
            this.buttonSUPPRIMER.UseVisualStyleBackColor = true;
            this.buttonSUPPRIMER.Click += new System.EventHandler(this.buttonSUPPRIMER_Click);
            // 
            // pEnteteCmd
            // 
            this.pEnteteCmd.BackColor = System.Drawing.SystemColors.Control;
            this.pEnteteCmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEnteteCmd.Controls.Add(this.groupControl4);
            this.pEnteteCmd.Controls.Add(this.groupControl2);
            this.pEnteteCmd.Controls.Add(this.groupControl1);
            this.pEnteteCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEnteteCmd.Location = new System.Drawing.Point(0, 48);
            this.pEnteteCmd.Name = "pEnteteCmd";
            this.pEnteteCmd.Size = new System.Drawing.Size(1022, 168);
            this.pEnteteCmd.TabIndex = 120;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.chbx_VALIDE);
            this.groupControl4.Controls.Add(this.chbx_priorite);
            this.groupControl4.Controls.Add(this.dtp_DATE_EXPIRATION);
            this.groupControl4.Controls.Add(this.dtp_DATE_COMMANDE);
            this.groupControl4.Controls.Add(this.lb_expiration);
            this.groupControl4.Controls.Add(this.label12);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.txt_REMARQUE);
            this.groupControl4.Controls.Add(this.label14);
            this.groupControl4.Controls.Add(this.txt_NUM_COMMANDE);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(352, 166);
            this.groupControl4.TabIndex = 130;
            this.groupControl4.Text = "Entete Commande";
            // 
            // chbx_VALIDE
            // 
            this.chbx_VALIDE.AutoCheck = false;
            this.chbx_VALIDE.AutoSize = true;
            this.chbx_VALIDE.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_VALIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_VALIDE.ForeColor = System.Drawing.Color.Green;
            this.chbx_VALIDE.Location = new System.Drawing.Point(5, 144);
            this.chbx_VALIDE.Name = "chbx_VALIDE";
            this.chbx_VALIDE.Size = new System.Drawing.Size(74, 19);
            this.chbx_VALIDE.TabIndex = 127;
            this.chbx_VALIDE.Text = "Validée";
            this.chbx_VALIDE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbx_VALIDE.UseVisualStyleBackColor = true;
            this.chbx_VALIDE.CheckedChanged += new System.EventHandler(this.chbx_VALIDE_CheckedChanged);
            // 
            // chbx_priorite
            // 
            this.chbx_priorite.AutoSize = true;
            this.chbx_priorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_priorite.Location = new System.Drawing.Point(5, 72);
            this.chbx_priorite.Name = "chbx_priorite";
            this.chbx_priorite.Size = new System.Drawing.Size(105, 19);
            this.chbx_priorite.TabIndex = 127;
            this.chbx_priorite.Text = "Avec priorité";
            this.chbx_priorite.UseVisualStyleBackColor = true;
            this.chbx_priorite.CheckedChanged += new System.EventHandler(this.chbx_priorite_CheckedChanged);
            // 
            // dtp_DATE_EXPIRATION
            // 
            this.dtp_DATE_EXPIRATION.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DATE_EXPIRATION.Location = new System.Drawing.Point(232, 72);
            this.dtp_DATE_EXPIRATION.Name = "dtp_DATE_EXPIRATION";
            this.dtp_DATE_EXPIRATION.Size = new System.Drawing.Size(104, 20);
            this.dtp_DATE_EXPIRATION.TabIndex = 125;
            // 
            // dtp_DATE_COMMANDE
            // 
            this.dtp_DATE_COMMANDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DATE_COMMANDE.Location = new System.Drawing.Point(125, 50);
            this.dtp_DATE_COMMANDE.Name = "dtp_DATE_COMMANDE";
            this.dtp_DATE_COMMANDE.Size = new System.Drawing.Size(104, 20);
            this.dtp_DATE_COMMANDE.TabIndex = 126;
            this.dtp_DATE_COMMANDE.ValueChanged += new System.EventHandler(this.dtp_DATE_COMMANDE_ValueChanged);
            // 
            // lb_expiration
            // 
            this.lb_expiration.AutoSize = true;
            this.lb_expiration.BackColor = System.Drawing.Color.Transparent;
            this.lb_expiration.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_expiration.ForeColor = System.Drawing.Color.Black;
            this.lb_expiration.Location = new System.Drawing.Point(112, 75);
            this.lb_expiration.Name = "lb_expiration";
            this.lb_expiration.Size = new System.Drawing.Size(110, 14);
            this.lb_expiration.TabIndex = 124;
            this.lb_expiration.Text = "Date Expiration :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 14);
            this.label12.TabIndex = 122;
            this.label12.Text = "Date Commande :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 123;
            this.label2.Text = "Remarque :";
            // 
            // txt_REMARQUE
            // 
            this.txt_REMARQUE.Location = new System.Drawing.Point(86, 95);
            this.txt_REMARQUE.Multiline = true;
            this.txt_REMARQUE.Name = "txt_REMARQUE";
            this.txt_REMARQUE.Size = new System.Drawing.Size(250, 46);
            this.txt_REMARQUE.TabIndex = 121;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 15);
            this.label14.TabIndex = 119;
            this.label14.Text = "Commande N° :";
            // 
            // txt_NUM_COMMANDE
            // 
            this.txt_NUM_COMMANDE.Enabled = false;
            this.txt_NUM_COMMANDE.Location = new System.Drawing.Point(125, 26);
            this.txt_NUM_COMMANDE.Name = "txt_NUM_COMMANDE";
            this.txt_NUM_COMMANDE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NUM_COMMANDE.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_NUM_COMMANDE.Properties.Appearance.Options.UseFont = true;
            this.txt_NUM_COMMANDE.Properties.Appearance.Options.UseForeColor = true;
            this.txt_NUM_COMMANDE.Size = new System.Drawing.Size(104, 21);
            this.txt_NUM_COMMANDE.TabIndex = 120;
            this.txt_NUM_COMMANDE.EditValueChanged += new System.EventHandler(this.txt_NUM_COMMANDE_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_ADRESSE_LIVRAISON);
            this.groupControl2.Controls.Add(this.txt_TEL_CONTACT);
            this.groupControl2.Controls.Add(this.txt_CONTACT);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.cbx_magazin);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(352, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(341, 166);
            this.groupControl2.TabIndex = 129;
            this.groupControl2.Text = "Lieu de livraison";
            // 
            // txt_ADRESSE_LIVRAISON
            // 
            this.txt_ADRESSE_LIVRAISON.Location = new System.Drawing.Point(13, 96);
            this.txt_ADRESSE_LIVRAISON.Multiline = true;
            this.txt_ADRESSE_LIVRAISON.Name = "txt_ADRESSE_LIVRAISON";
            this.txt_ADRESSE_LIVRAISON.Size = new System.Drawing.Size(315, 46);
            this.txt_ADRESSE_LIVRAISON.TabIndex = 118;
            // 
            // txt_TEL_CONTACT
            // 
            this.txt_TEL_CONTACT.Location = new System.Drawing.Point(228, 57);
            this.txt_TEL_CONTACT.Name = "txt_TEL_CONTACT";
            this.txt_TEL_CONTACT.Size = new System.Drawing.Size(100, 20);
            this.txt_TEL_CONTACT.TabIndex = 118;
            // 
            // txt_CONTACT
            // 
            this.txt_CONTACT.Location = new System.Drawing.Point(80, 56);
            this.txt_CONTACT.Name = "txt_CONTACT";
            this.txt_CONTACT.Size = new System.Drawing.Size(100, 20);
            this.txt_CONTACT.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 14);
            this.label11.TabIndex = 117;
            this.label11.Text = "Adresse de Livraison :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(192, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 14);
            this.label10.TabIndex = 117;
            this.label10.Text = "Tel :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 117;
            this.label8.Text = "Contact :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.label17);
            this.groupControl1.Controls.Add(this.label16);
            this.groupControl1.Controls.Add(this.label15);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.txtFaxFournisseur);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtTelFournisseur);
            this.groupControl1.Controls.Add(this.txtCodeTvaFournisseur);
            this.groupControl1.Controls.Add(this.txtAdresseFournisseur);
            this.groupControl1.Controls.Add(this.txt_fournisseur);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(693, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 166);
            this.groupControl1.TabIndex = 128;
            this.groupControl1.Text = "Fournisseur";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(182, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 14);
            this.label17.TabIndex = 115;
            this.label17.Text = "Fax :";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(5, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 14);
            this.label16.TabIndex = 115;
            this.label16.Text = "Tel :";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(5, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 14);
            this.label15.TabIndex = 115;
            this.label15.Text = "Mle Fiscal :";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(5, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 115;
            this.label13.Text = "Adresse :";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFaxFournisseur
            // 
            this.txtFaxFournisseur.BackColor = System.Drawing.Color.White;
            this.txtFaxFournisseur.Location = new System.Drawing.Point(220, 116);
            this.txtFaxFournisseur.Name = "txtFaxFournisseur";
            this.txtFaxFournisseur.ReadOnly = true;
            this.txtFaxFournisseur.Size = new System.Drawing.Size(104, 20);
            this.txtFaxFournisseur.TabIndex = 113;
            // 
            // txtTelFournisseur
            // 
            this.txtTelFournisseur.BackColor = System.Drawing.Color.White;
            this.txtTelFournisseur.Location = new System.Drawing.Point(54, 116);
            this.txtTelFournisseur.Name = "txtTelFournisseur";
            this.txtTelFournisseur.ReadOnly = true;
            this.txtTelFournisseur.Size = new System.Drawing.Size(104, 20);
            this.txtTelFournisseur.TabIndex = 113;
            // 
            // txtCodeTvaFournisseur
            // 
            this.txtCodeTvaFournisseur.BackColor = System.Drawing.Color.White;
            this.txtCodeTvaFournisseur.Location = new System.Drawing.Point(96, 94);
            this.txtCodeTvaFournisseur.Name = "txtCodeTvaFournisseur";
            this.txtCodeTvaFournisseur.ReadOnly = true;
            this.txtCodeTvaFournisseur.Size = new System.Drawing.Size(227, 20);
            this.txtCodeTvaFournisseur.TabIndex = 113;
            // 
            // txtAdresseFournisseur
            // 
            this.txtAdresseFournisseur.BackColor = System.Drawing.Color.White;
            this.txtAdresseFournisseur.Location = new System.Drawing.Point(96, 53);
            this.txtAdresseFournisseur.Multiline = true;
            this.txtAdresseFournisseur.Name = "txtAdresseFournisseur";
            this.txtAdresseFournisseur.ReadOnly = true;
            this.txtAdresseFournisseur.Size = new System.Drawing.Size(227, 36);
            this.txtAdresseFournisseur.TabIndex = 113;
            // 
            // HT
            // 
            this.HT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HT.Clinote = false;
            this.HT.Couleur1 = System.Drawing.Color.Black;
            this.HT.Couleur2 = System.Drawing.Color.Red;
            this.HT.DecimalPlaces = 3;
            this.HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HT.ForeColor = System.Drawing.Color.Black;
            this.HT.Location = new System.Drawing.Point(896, 7);
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(112, 13);
            this.HT.TabIndex = 105;
            this.HT.Text = "0.000";
            this.HT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HT.ThousandsSeparator = true;
            this.HT.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // REMISE
            // 
            this.REMISE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.REMISE.Clinote = false;
            this.REMISE.Couleur1 = System.Drawing.Color.Black;
            this.REMISE.Couleur2 = System.Drawing.Color.Red;
            this.REMISE.DecimalPlaces = 3;
            this.REMISE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMISE.ForeColor = System.Drawing.Color.Black;
            this.REMISE.Location = new System.Drawing.Point(896, 25);
            this.REMISE.Name = "REMISE";
            this.REMISE.Size = new System.Drawing.Size(112, 13);
            this.REMISE.TabIndex = 104;
            this.REMISE.Text = "0.000";
            this.REMISE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.REMISE.ThousandsSeparator = true;
            this.REMISE.Value = new decimal(new int[] {
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
            this.TVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVA.ForeColor = System.Drawing.Color.Black;
            this.TVA.Location = new System.Drawing.Point(896, 42);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(112, 13);
            this.TVA.TabIndex = 103;
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
            this.TTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTC.ForeColor = System.Drawing.Color.Black;
            this.TTC.Location = new System.Drawing.Point(896, 60);
            this.TTC.Name = "TTC";
            this.TTC.Size = new System.Drawing.Size(112, 13);
            this.TTC.TabIndex = 102;
            this.TTC.Text = "0.000";
            this.TTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTC.ThousandsSeparator = true;
            this.TTC.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(792, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Remise :";
            // 
            // TTC1
            // 
            this.TTC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTC1.AutoSize = true;
            this.TTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTC1.Location = new System.Drawing.Point(792, 60);
            this.TTC1.Name = "TTC1";
            this.TTC1.Size = new System.Drawing.Size(105, 13);
            this.TTC1.TabIndex = 0;
            this.TTC1.Text = "Montant T. TTC :";
            // 
            // TVA1
            // 
            this.TVA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TVA1.AutoSize = true;
            this.TVA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVA1.Location = new System.Drawing.Point(792, 42);
            this.TVA1.Name = "TVA1";
            this.TVA1.Size = new System.Drawing.Size(105, 13);
            this.TVA1.TabIndex = 0;
            this.TVA1.Text = "Montant T. TVA :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(792, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Montant T. HT :";
            // 
            // panel_qte
            // 
            this.panel_qte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_qte.BackColor = System.Drawing.Color.Transparent;
            this.panel_qte.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.panel_qte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_qte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_qte.Controls.Add(this.label5);
            this.panel_qte.Controls.Add(this.UNITE_ARTICLE);
            this.panel_qte.Controls.Add(this.button3);
            this.panel_qte.Controls.Add(this.btn_validation_ajout);
            this.panel_qte.Controls.Add(this.nud_prix);
            this.panel_qte.Controls.Add(this.label6);
            this.panel_qte.Controls.Add(this.qte_select_article);
            this.panel_qte.Controls.Add(this.label7);
            this.panel_qte.Location = new System.Drawing.Point(338, 205);
            this.panel_qte.Name = "panel_qte";
            this.panel_qte.Size = new System.Drawing.Size(247, 205);
            this.panel_qte.TabIndex = 124;
            this.panel_qte.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 56);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UNITE_ARTICLE
            // 
            this.UNITE_ARTICLE.AutoSize = true;
            this.UNITE_ARTICLE.BackColor = System.Drawing.Color.Transparent;
            this.UNITE_ARTICLE.ForeColor = System.Drawing.Color.Black;
            this.UNITE_ARTICLE.Location = new System.Drawing.Point(187, 101);
            this.UNITE_ARTICLE.Name = "UNITE_ARTICLE";
            this.UNITE_ARTICLE.Size = new System.Drawing.Size(0, 13);
            this.UNITE_ARTICLE.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(126, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_validation_ajout
            // 
            this.btn_validation_ajout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validation_ajout.Location = new System.Drawing.Point(25, 141);
            this.btn_validation_ajout.Name = "btn_validation_ajout";
            this.btn_validation_ajout.Size = new System.Drawing.Size(95, 48);
            this.btn_validation_ajout.TabIndex = 3;
            this.btn_validation_ajout.Text = "Ajouter";
            this.btn_validation_ajout.UseVisualStyleBackColor = true;
            // 
            // nud_prix
            // 
            this.nud_prix.DecimalPlaces = 3;
            this.nud_prix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_prix.Location = new System.Drawing.Point(104, 103);
            this.nud_prix.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nud_prix.Name = "nud_prix";
            this.nud_prix.Size = new System.Drawing.Size(117, 30);
            this.nud_prix.TabIndex = 2;
            this.nud_prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prix :";
            // 
            // qte_select_article
            // 
            this.qte_select_article.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_select_article.Location = new System.Drawing.Point(117, 65);
            this.qte_select_article.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.qte_select_article.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qte_select_article.Name = "qte_select_article";
            this.qte_select_article.Size = new System.Drawing.Size(104, 30);
            this.qte_select_article.TabIndex = 1;
            this.qte_select_article.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qte_select_article.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quantité :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_LG_CMD_FR";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(870, 156);
            this.gridControl1.TabIndex = 125;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_COMMANDE_FOURNISSEUR,
            this.colCODE_ARTICLE,
            this.colQTE,
            this.colPRIX_HT,
            this.colREMISE,
            this.colFODEC,
            this.colTAUX_TVA,
            this.colUNITE,
            this.colCODE_UNITE_ARTICLE,
            this.colREF_ARTICLE,
            this.colDESIGNATION_ARTICLE,
            this.colDESCRIPTION_ARTICLE,
            this.colMNT_HT,
            this.colMNT_NET,
            this.colMNT_REMISE,
            this.colMNT_TVA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMNT_TVA, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colCODE_COMMANDE_FOURNISSEUR
            // 
            this.colCODE_COMMANDE_FOURNISSEUR.FieldName = "CODE_COMMANDE_FOURNISSEUR";
            this.colCODE_COMMANDE_FOURNISSEUR.Name = "colCODE_COMMANDE_FOURNISSEUR";
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            // 
            // colQTE
            // 
            this.colQTE.FieldName = "QTE";
            this.colQTE.Name = "colQTE";
            this.colQTE.Visible = true;
            this.colQTE.VisibleIndex = 4;
            this.colQTE.Width = 25;
            // 
            // colPRIX_HT
            // 
            this.colPRIX_HT.FieldName = "PRIX_HT";
            this.colPRIX_HT.Name = "colPRIX_HT";
            this.colPRIX_HT.Visible = true;
            this.colPRIX_HT.VisibleIndex = 5;
            this.colPRIX_HT.Width = 52;
            // 
            // colREMISE
            // 
            this.colREMISE.FieldName = "REMISE";
            this.colREMISE.Name = "colREMISE";
            this.colREMISE.Visible = true;
            this.colREMISE.VisibleIndex = 6;
            this.colREMISE.Width = 35;
            // 
            // colFODEC
            // 
            this.colFODEC.FieldName = "FODEC";
            this.colFODEC.Name = "colFODEC";
            // 
            // colTAUX_TVA
            // 
            this.colTAUX_TVA.ColumnEdit = this.repositoryItemComboBox1;
            this.colTAUX_TVA.FieldName = "TAUX_TVA";
            this.colTAUX_TVA.Name = "colTAUX_TVA";
            this.colTAUX_TVA.Visible = true;
            this.colTAUX_TVA.VisibleIndex = 7;
            this.colTAUX_TVA.Width = 34;
            // 
            // colUNITE
            // 
            this.colUNITE.FieldName = "UNITE";
            this.colUNITE.Name = "colUNITE";
            this.colUNITE.Visible = true;
            this.colUNITE.VisibleIndex = 3;
            this.colUNITE.Width = 32;
            // 
            // colCODE_UNITE_ARTICLE
            // 
            this.colCODE_UNITE_ARTICLE.FieldName = "CODE_UNITE_ARTICLE";
            this.colCODE_UNITE_ARTICLE.Name = "colCODE_UNITE_ARTICLE";
            // 
            // colREF_ARTICLE
            // 
            this.colREF_ARTICLE.FieldName = "REF_ARTICLE";
            this.colREF_ARTICLE.Name = "colREF_ARTICLE";
            this.colREF_ARTICLE.OptionsColumn.ReadOnly = true;
            this.colREF_ARTICLE.Visible = true;
            this.colREF_ARTICLE.VisibleIndex = 0;
            this.colREF_ARTICLE.Width = 61;
            // 
            // colDESIGNATION_ARTICLE
            // 
            this.colDESIGNATION_ARTICLE.FieldName = "DESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Name = "colDESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.OptionsColumn.ReadOnly = true;
            this.colDESIGNATION_ARTICLE.Visible = true;
            this.colDESIGNATION_ARTICLE.VisibleIndex = 1;
            this.colDESIGNATION_ARTICLE.Width = 215;
            // 
            // colDESCRIPTION_ARTICLE
            // 
            this.colDESCRIPTION_ARTICLE.FieldName = "DESCRIPTION_ARTICLE";
            this.colDESCRIPTION_ARTICLE.Name = "colDESCRIPTION_ARTICLE";
            this.colDESCRIPTION_ARTICLE.Visible = true;
            this.colDESCRIPTION_ARTICLE.VisibleIndex = 2;
            this.colDESCRIPTION_ARTICLE.Width = 96;
            // 
            // colMNT_HT
            // 
            this.colMNT_HT.FieldName = "MNT_HT";
            this.colMNT_HT.Name = "colMNT_HT";
            this.colMNT_HT.OptionsColumn.ReadOnly = true;
            this.colMNT_HT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colMNT_HT.Visible = true;
            this.colMNT_HT.VisibleIndex = 8;
            this.colMNT_HT.Width = 72;
            // 
            // colMNT_NET
            // 
            this.colMNT_NET.FieldName = "MNT_NET";
            this.colMNT_NET.Name = "colMNT_NET";
            this.colMNT_NET.OptionsColumn.ReadOnly = true;
            this.colMNT_NET.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colMNT_NET.Visible = true;
            this.colMNT_NET.VisibleIndex = 11;
            this.colMNT_NET.Width = 91;
            // 
            // colMNT_REMISE
            // 
            this.colMNT_REMISE.FieldName = "MNT_REMISE";
            this.colMNT_REMISE.Name = "colMNT_REMISE";
            this.colMNT_REMISE.OptionsColumn.ReadOnly = true;
            this.colMNT_REMISE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colMNT_REMISE.Visible = true;
            this.colMNT_REMISE.VisibleIndex = 9;
            this.colMNT_REMISE.Width = 71;
            // 
            // colMNT_TVA
            // 
            this.colMNT_TVA.FieldName = "MNT_TVA";
            this.colMNT_TVA.Name = "colMNT_TVA";
            this.colMNT_TVA.OptionsColumn.ReadOnly = true;
            this.colMNT_TVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colMNT_TVA.Visible = true;
            this.colMNT_TVA.VisibleIndex = 10;
            this.colMNT_TVA.Width = 72;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // bareCodeReader1
            // 
            this.bareCodeReader1.Location = new System.Drawing.Point(13, 132);
            this.bareCodeReader1.Name = "bareCodeReader1";
            this.bareCodeReader1.Size = new System.Drawing.Size(130, 97);
            this.bareCodeReader1.TabIndex = 126;
            // 
            // pMAJDetails
            // 
            this.pMAJDetails.Controls.Add(this.buttonAJOUTER);
            this.pMAJDetails.Controls.Add(this.bareCodeReader1);
            this.pMAJDetails.Controls.Add(this.buttonSUPPRIMER);
            this.pMAJDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pMAJDetails.Location = new System.Drawing.Point(872, 22);
            this.pMAJDetails.Name = "pMAJDetails";
            this.pMAJDetails.Size = new System.Drawing.Size(148, 156);
            this.pMAJDetails.TabIndex = 127;
            // 
            // chM_CMP_FICHE1
            // 
            this.chM_CMP_FICHE1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_FICHE1.ButtonCaption = null;
            this.chM_CMP_FICHE1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_FICHE1.Location = new System.Drawing.Point(0, 533);
            this.chM_CMP_FICHE1.Name = "chM_CMP_FICHE1";
            this.chM_CMP_FICHE1.Size = new System.Drawing.Size(1022, 55);
            this.chM_CMP_FICHE1.TabIndex = 128;
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 481);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(1022, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 129;
            // 
            // pMontant
            // 
            this.pMontant.BackColor = System.Drawing.SystemColors.Control;
            this.pMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMontant.Controls.Add(this.HT);
            this.pMontant.Controls.Add(this.REMISE);
            this.pMontant.Controls.Add(this.TVA);
            this.pMontant.Controls.Add(this.TTC);
            this.pMontant.Controls.Add(this.label4);
            this.pMontant.Controls.Add(this.label9);
            this.pMontant.Controls.Add(this.TVA1);
            this.pMontant.Controls.Add(this.TTC1);
            this.pMontant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMontant.Location = new System.Drawing.Point(0, 396);
            this.pMontant.Name = "pMontant";
            this.pMontant.Size = new System.Drawing.Size(1022, 85);
            this.pMontant.TabIndex = 130;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valider.Location = new System.Drawing.Point(12, 544);
            this.btn_Valider.MouseHoverColor = System.Drawing.Color.Transparent;
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(101, 34);
            this.btn_Valider.TabIndex = 131;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Controls.Add(this.pMAJDetails);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 216);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1022, 180);
            this.groupControl3.TabIndex = 132;
            this.groupControl3.Text = "Détails";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // CHM_FRM_NV_CMD_FR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 588);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.pMontant);
            this.Controls.Add(this.panel_qte);
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.chM_CMP_FICHE1);
            this.Controls.Add(this.pEnteteCmd);
            this.Controls.Add(this.entete_Formulaire_21);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_FRM_NV_CMD_FR";
            this.Text = "Commade d\'achat";
            this.Load += new System.EventHandler(this.CHM_FRM_NV_CMD_FR_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CHM_FRM_NV_CMD_FR_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_NV_CMD_FR_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_LG_FACTURE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICLE)).EndInit();
            this.pEnteteCmd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NUM_COMMANDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel_qte.ResumeLayout(false);
            this.panel_qte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qte_select_article)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMAJDetails)).EndInit();
            this.pMAJDetails.ResumeLayout(false);
            this.pMontant.ResumeLayout(false);
            this.pMontant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable DT_LG_FACTURE;
        private System.Data.DataColumn CODE_ARTICLE;
        private System.Data.DataColumn DESIGNATION_ARTICLE;
        private System.Data.DataColumn QTE_LG_FACTURE;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private System.Data.DataTable ARTICLE;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_fournisseur;
        private System.Windows.Forms.ComboBox cbx_magazin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAJOUTER;
        private System.Windows.Forms.Button buttonSUPPRIMER;
        private System.Windows.Forms.ToolTip toolTip1;
        private LABEL_NUM.LabelNumerique HT;
        private LABEL_NUM.LabelNumerique REMISE;
        private LABEL_NUM.LabelNumerique TVA;
        private LABEL_NUM.LabelNumerique TTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TTC1;
        private System.Windows.Forms.Label TVA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_qte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UNITE_ARTICLE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_validation_ajout;
        private System.Windows.Forms.NumericUpDown nud_prix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown qte_select_article;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Data.DataColumn dataColumn9;
        private CHMComponents.BareCodeReader bareCodeReader1;
        public DevExpress.XtraEditors.PanelControl pMAJDetails;
        private DS_MOUV dS_MOUV1;
        public System.Windows.Forms.Panel pEnteteCmd;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.Panel pMontant;
        private System.Windows.Forms.TextBox txt_ADRESSE_LIVRAISON;
        private System.Windows.Forms.TextBox txt_TEL_CONTACT;
        private System.Windows.Forms.TextBox txt_CONTACT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_COMMANDE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colREMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colFODEC;
        private DevExpress.XtraGrid.Columns.GridColumn colTAUX_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colUNITE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_UNITE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_ARTICLE;
        public CHM_STYLE.CHM_CMP_FICHE chM_CMP_FICHE1;
        public CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
        private DevExpress.XtraGrid.Columns.GridColumn colMNT_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colMNT_NET;
        private DevExpress.XtraGrid.Columns.GridColumn colMNT_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colMNT_TVA;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txt_NUM_COMMANDE;
        private System.Windows.Forms.DateTimePicker dtp_DATE_EXPIRATION;
        private System.Windows.Forms.DateTimePicker dtp_DATE_COMMANDE;
        private System.Windows.Forms.Label lb_expiration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_REMARQUE;
        public CHM_STYLE.CHM_BUTTON btn_Valider;
        private System.Windows.Forms.CheckBox chbx_priorite;
        private System.Windows.Forms.CheckBox chbx_VALIDE;
        private System.Windows.Forms.TextBox txtTelFournisseur;
        private System.Windows.Forms.TextBox txtCodeTvaFournisseur;
        private System.Windows.Forms.TextBox txtAdresseFournisseur;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFaxFournisseur;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}