namespace CHM_CLIENT_APP
{
    partial class CHM_COMMANDE_ARTICLE
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
            this.magazin_article = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ARTICLE = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_qte = new System.Windows.Forms.Panel();
            this.nud_prix = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.UNITE_ARTICLE = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_validation_ajout = new System.Windows.Forms.Button();
            this.qte_select_article = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PANEL_PHOTO = new System.Windows.Forms.Panel();
            this.PHOTO_ARTICLE = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSGCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GC = new CHM_CLIENT_APP.DS_GC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_UNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE_MIN_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHOTO_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT_A_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAUX_MAJORATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETAT_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAX_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_SOLDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE_ARTICLE_SOLDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT_V_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_UNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAUX_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_FIXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FRN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAUX_TVA_ACHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTVA_ACHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMS_ARTICLE.SuspendLayout();
            this.panel_qte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qte_select_article)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PANEL_PHOTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_ARTICLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // magazin_article
            // 
            this.magazin_article.FormattingEnabled = true;
            this.magazin_article.Location = new System.Drawing.Point(110, 107);
            this.magazin_article.Name = "magazin_article";
            this.magazin_article.Size = new System.Drawing.Size(263, 21);
            this.magazin_article.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Magasin :";
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.actualiserToolStripMenuItem.Text = "Refresh تحديث";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // CMS_ARTICLE
            // 
            this.CMS_ARTICLE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.actualiserToolStripMenuItem});
            this.CMS_ARTICLE.Name = "contextMenuStrip1";
            this.CMS_ARTICLE.Size = new System.Drawing.Size(168, 32);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // panel_qte
            // 
            this.panel_qte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_qte.BackColor = System.Drawing.Color.Transparent;
            this.panel_qte.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.panel_qte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_qte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_qte.Controls.Add(this.nud_prix);
            this.panel_qte.Controls.Add(this.label2);
            this.panel_qte.Controls.Add(this.UNITE_ARTICLE);
            this.panel_qte.Controls.Add(this.button2);
            this.panel_qte.Controls.Add(this.btn_validation_ajout);
            this.panel_qte.Controls.Add(this.qte_select_article);
            this.panel_qte.Controls.Add(this.label9);
            this.panel_qte.Location = new System.Drawing.Point(251, 216);
            this.panel_qte.Name = "panel_qte";
            this.panel_qte.Size = new System.Drawing.Size(247, 140);
            this.panel_qte.TabIndex = 4;
            this.panel_qte.Visible = false;
            this.panel_qte.VisibleChanged += new System.EventHandler(this.panel_qte_VisibleChanged);
            // 
            // nud_prix
            // 
            this.nud_prix.DecimalPlaces = 3;
            this.nud_prix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_prix.Location = new System.Drawing.Point(123, 46);
            this.nud_prix.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nud_prix.Name = "nud_prix";
            this.nud_prix.Size = new System.Drawing.Size(99, 30);
            this.nud_prix.TabIndex = 1;
            this.nud_prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prix :";
            // 
            // UNITE_ARTICLE
            // 
            this.UNITE_ARTICLE.AutoSize = true;
            this.UNITE_ARTICLE.BackColor = System.Drawing.Color.Transparent;
            this.UNITE_ARTICLE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UNITE_ARTICLE.Location = new System.Drawing.Point(177, 49);
            this.UNITE_ARTICLE.Name = "UNITE_ARTICLE";
            this.UNITE_ARTICLE.Size = new System.Drawing.Size(0, 13);
            this.UNITE_ARTICLE.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(126, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_validation_ajout
            // 
            this.btn_validation_ajout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validation_ajout.Location = new System.Drawing.Point(45, 88);
            this.btn_validation_ajout.Name = "btn_validation_ajout";
            this.btn_validation_ajout.Size = new System.Drawing.Size(75, 45);
            this.btn_validation_ajout.TabIndex = 2;
            this.btn_validation_ajout.Text = "Ajouter";
            this.btn_validation_ajout.UseVisualStyleBackColor = true;
            this.btn_validation_ajout.Click += new System.EventHandler(this.btn_validation_ajout_Click);
            // 
            // qte_select_article
            // 
            this.qte_select_article.DecimalPlaces = 3;
            this.qte_select_article.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_select_article.Location = new System.Drawing.Point(123, 11);
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
            this.qte_select_article.Size = new System.Drawing.Size(99, 26);
            this.qte_select_article.TabIndex = 0;
            this.qte_select_article.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qte_select_article.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantité :";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.button1.Location = new System.Drawing.Point(513, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sélectionner";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::CHM_CLIENT_APP.Properties.Resources.porte_en_icone_7778_32;
            this.button3.Location = new System.Drawing.Point(627, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Terminer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(-2, -8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(760, 62);
            this.groupBox5.TabIndex = 78;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(46, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(661, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Liste des Articles";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PANEL_PHOTO
            // 
            this.PANEL_PHOTO.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_PHOTO.Controls.Add(this.PHOTO_ARTICLE);
            this.PANEL_PHOTO.Location = new System.Drawing.Point(318, 144);
            this.PANEL_PHOTO.Name = "PANEL_PHOTO";
            this.PANEL_PHOTO.Size = new System.Drawing.Size(238, 212);
            this.PANEL_PHOTO.TabIndex = 79;
            this.PANEL_PHOTO.Visible = false;
            // 
            // PHOTO_ARTICLE
            // 
            this.PHOTO_ARTICLE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PHOTO_ARTICLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PHOTO_ARTICLE.Location = new System.Drawing.Point(1, 1);
            this.PHOTO_ARTICLE.Name = "PHOTO_ARTICLE";
            this.PHOTO_ARTICLE.Size = new System.Drawing.Size(234, 208);
            this.PHOTO_ARTICLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PHOTO_ARTICLE.TabIndex = 0;
            this.PHOTO_ARTICLE.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(615, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(24, 58);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(135, 44);
            this.btn_ajout.TabIndex = 81;
            this.btn_ajout.Text = "Ajouter Article";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "V_ARTICLE";
            this.gridControl1.DataSource = this.dSGCBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 134);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 283);
            this.gridControl1.TabIndex = 82;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // dSGCBindingSource
            // 
            this.dSGCBindingSource.DataSource = this.dS_GC;
            this.dSGCBindingSource.Position = 0;
            // 
            // dS_GC
            // 
            this.dS_GC.DataSetName = "DS_GC";
            this.dS_GC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_ARTICLE,
            this.colREF_ARTICLE,
            this.colDESIGNATION_ARTICLE,
            this.colCODE_MARQUE,
            this.colDESCRIPTION_ARTICLE,
            this.colCODE_BARRE_ARTICLE,
            this.colQTE_ARTICLE,
            this.colCODE_UNITE,
            this.colQTE_MIN_ARTICLE,
            this.colPHOTO_ARTICLE,
            this.colPRIX_HT_A_ARTICLE,
            this.colTAUX_MAJORATION,
            this.colCODE_TVA,
            this.colETAT_ARTICLE,
            this.colCODE_FAMILLE,
            this.colCODE_CATEG,
            this.colCODE_MAG,
            this.colCODE_FOURNISSEUR,
            this.colMAX_REMISE,
            this.colPRIX_SOLDE,
            this.colCODE_BARRE_ARTICLE_SOLDE,
            this.colPRIX_HT_V_ARTICLE,
            this.colREF_FAMILLE,
            this.colDESIGNATION_FAMILLE,
            this.colDESCRIPTION_FAMILLE,
            this.colLIB_CATEG,
            this.colDESCRIPTION_CATEG,
            this.colREF_MARQUE,
            this.colDESIGNATION_MARQUE,
            this.colDESCRIPTION_MARQUE,
            this.colLIB_UNITE,
            this.colREF_FOURNISSEUR,
            this.colRS_FOURNISSEUR,
            this.colADRESSE_FOURNISSEUR,
            this.colTEL_FOURNISSEUR,
            this.colTAUX_TVA,
            this.colNOM_MAG,
            this.colADRESSE_MAG,
            this.colTEL_MAG,
            this.colPRIX_FIXE,
            this.colPRIX_TTC,
            this.colREF_FRN,
            this.colSTOCKABLE,
            this.colTAUX_TVA_ACHAT,
            this.colTVA_ACHAT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPRIX_HT_V_ARTICLE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            // 
            // colREF_ARTICLE
            // 
            this.colREF_ARTICLE.FieldName = "REF_ARTICLE";
            this.colREF_ARTICLE.Name = "colREF_ARTICLE";
            this.colREF_ARTICLE.Visible = true;
            this.colREF_ARTICLE.VisibleIndex = 0;
            this.colREF_ARTICLE.Width = 71;
            // 
            // colDESIGNATION_ARTICLE
            // 
            this.colDESIGNATION_ARTICLE.FieldName = "DESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Name = "colDESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Visible = true;
            this.colDESIGNATION_ARTICLE.VisibleIndex = 1;
            this.colDESIGNATION_ARTICLE.Width = 218;
            // 
            // colCODE_MARQUE
            // 
            this.colCODE_MARQUE.FieldName = "CODE_MARQUE";
            this.colCODE_MARQUE.Name = "colCODE_MARQUE";
            // 
            // colDESCRIPTION_ARTICLE
            // 
            this.colDESCRIPTION_ARTICLE.FieldName = "DESCRIPTION_ARTICLE";
            this.colDESCRIPTION_ARTICLE.Name = "colDESCRIPTION_ARTICLE";
            // 
            // colCODE_BARRE_ARTICLE
            // 
            this.colCODE_BARRE_ARTICLE.FieldName = "CODE_BARRE_ARTICLE";
            this.colCODE_BARRE_ARTICLE.Name = "colCODE_BARRE_ARTICLE";
            // 
            // colQTE_ARTICLE
            // 
            this.colQTE_ARTICLE.Caption = "Qté";
            this.colQTE_ARTICLE.FieldName = "QTE_ARTICLE";
            this.colQTE_ARTICLE.Name = "colQTE_ARTICLE";
            this.colQTE_ARTICLE.Visible = true;
            this.colQTE_ARTICLE.VisibleIndex = 3;
            this.colQTE_ARTICLE.Width = 44;
            // 
            // colCODE_UNITE
            // 
            this.colCODE_UNITE.FieldName = "CODE_UNITE";
            this.colCODE_UNITE.Name = "colCODE_UNITE";
            // 
            // colQTE_MIN_ARTICLE
            // 
            this.colQTE_MIN_ARTICLE.FieldName = "QTE_MIN_ARTICLE";
            this.colQTE_MIN_ARTICLE.Name = "colQTE_MIN_ARTICLE";
            // 
            // colPHOTO_ARTICLE
            // 
            this.colPHOTO_ARTICLE.FieldName = "PHOTO_ARTICLE";
            this.colPHOTO_ARTICLE.Name = "colPHOTO_ARTICLE";
            // 
            // colPRIX_HT_A_ARTICLE
            // 
            this.colPRIX_HT_A_ARTICLE.FieldName = "PRIX_HT_A_ARTICLE";
            this.colPRIX_HT_A_ARTICLE.Name = "colPRIX_HT_A_ARTICLE";
            // 
            // colTAUX_MAJORATION
            // 
            this.colTAUX_MAJORATION.FieldName = "TAUX_MAJORATION";
            this.colTAUX_MAJORATION.Name = "colTAUX_MAJORATION";
            // 
            // colCODE_TVA
            // 
            this.colCODE_TVA.FieldName = "CODE_TVA";
            this.colCODE_TVA.Name = "colCODE_TVA";
            // 
            // colETAT_ARTICLE
            // 
            this.colETAT_ARTICLE.Caption = "Bloqué";
            this.colETAT_ARTICLE.FieldName = "ETAT_ARTICLE";
            this.colETAT_ARTICLE.Name = "colETAT_ARTICLE";
            this.colETAT_ARTICLE.Visible = true;
            this.colETAT_ARTICLE.VisibleIndex = 10;
            this.colETAT_ARTICLE.Width = 56;
            // 
            // colCODE_FAMILLE
            // 
            this.colCODE_FAMILLE.FieldName = "CODE_FAMILLE";
            this.colCODE_FAMILLE.Name = "colCODE_FAMILLE";
            // 
            // colCODE_CATEG
            // 
            this.colCODE_CATEG.FieldName = "CODE_CATEG";
            this.colCODE_CATEG.Name = "colCODE_CATEG";
            // 
            // colCODE_MAG
            // 
            this.colCODE_MAG.FieldName = "CODE_MAG";
            this.colCODE_MAG.Name = "colCODE_MAG";
            // 
            // colCODE_FOURNISSEUR
            // 
            this.colCODE_FOURNISSEUR.FieldName = "CODE_FOURNISSEUR";
            this.colCODE_FOURNISSEUR.Name = "colCODE_FOURNISSEUR";
            // 
            // colMAX_REMISE
            // 
            this.colMAX_REMISE.FieldName = "MAX_REMISE";
            this.colMAX_REMISE.Name = "colMAX_REMISE";
            // 
            // colPRIX_SOLDE
            // 
            this.colPRIX_SOLDE.FieldName = "PRIX_SOLDE";
            this.colPRIX_SOLDE.Name = "colPRIX_SOLDE";
            // 
            // colCODE_BARRE_ARTICLE_SOLDE
            // 
            this.colCODE_BARRE_ARTICLE_SOLDE.FieldName = "CODE_BARRE_ARTICLE_SOLDE";
            this.colCODE_BARRE_ARTICLE_SOLDE.Name = "colCODE_BARRE_ARTICLE_SOLDE";
            // 
            // colPRIX_HT_V_ARTICLE
            // 
            this.colPRIX_HT_V_ARTICLE.FieldName = "PRIX_HT_V_ARTICLE";
            this.colPRIX_HT_V_ARTICLE.Name = "colPRIX_HT_V_ARTICLE";
            this.colPRIX_HT_V_ARTICLE.Visible = true;
            this.colPRIX_HT_V_ARTICLE.VisibleIndex = 4;
            this.colPRIX_HT_V_ARTICLE.Width = 93;
            // 
            // colREF_FAMILLE
            // 
            this.colREF_FAMILLE.FieldName = "REF_FAMILLE";
            this.colREF_FAMILLE.Name = "colREF_FAMILLE";
            // 
            // colDESIGNATION_FAMILLE
            // 
            this.colDESIGNATION_FAMILLE.Caption = "Famille";
            this.colDESIGNATION_FAMILLE.FieldName = "DESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Name = "colDESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Visible = true;
            this.colDESIGNATION_FAMILLE.VisibleIndex = 6;
            this.colDESIGNATION_FAMILLE.Width = 129;
            // 
            // colDESCRIPTION_FAMILLE
            // 
            this.colDESCRIPTION_FAMILLE.FieldName = "DESCRIPTION_FAMILLE";
            this.colDESCRIPTION_FAMILLE.Name = "colDESCRIPTION_FAMILLE";
            // 
            // colLIB_CATEG
            // 
            this.colLIB_CATEG.Caption = "Catégorie";
            this.colLIB_CATEG.FieldName = "LIB_CATEG";
            this.colLIB_CATEG.Name = "colLIB_CATEG";
            this.colLIB_CATEG.Visible = true;
            this.colLIB_CATEG.VisibleIndex = 7;
            this.colLIB_CATEG.Width = 129;
            // 
            // colDESCRIPTION_CATEG
            // 
            this.colDESCRIPTION_CATEG.FieldName = "DESCRIPTION_CATEG";
            this.colDESCRIPTION_CATEG.Name = "colDESCRIPTION_CATEG";
            // 
            // colREF_MARQUE
            // 
            this.colREF_MARQUE.FieldName = "REF_MARQUE";
            this.colREF_MARQUE.Name = "colREF_MARQUE";
            // 
            // colDESIGNATION_MARQUE
            // 
            this.colDESIGNATION_MARQUE.Caption = "Marque";
            this.colDESIGNATION_MARQUE.FieldName = "DESIGNATION_MARQUE";
            this.colDESIGNATION_MARQUE.Name = "colDESIGNATION_MARQUE";
            this.colDESIGNATION_MARQUE.Visible = true;
            this.colDESIGNATION_MARQUE.VisibleIndex = 8;
            this.colDESIGNATION_MARQUE.Width = 129;
            // 
            // colDESCRIPTION_MARQUE
            // 
            this.colDESCRIPTION_MARQUE.FieldName = "DESCRIPTION_MARQUE";
            this.colDESCRIPTION_MARQUE.Name = "colDESCRIPTION_MARQUE";
            // 
            // colLIB_UNITE
            // 
            this.colLIB_UNITE.Caption = "Unité";
            this.colLIB_UNITE.FieldName = "LIB_UNITE";
            this.colLIB_UNITE.Name = "colLIB_UNITE";
            this.colLIB_UNITE.Visible = true;
            this.colLIB_UNITE.VisibleIndex = 2;
            this.colLIB_UNITE.Width = 51;
            // 
            // colREF_FOURNISSEUR
            // 
            this.colREF_FOURNISSEUR.FieldName = "REF_FOURNISSEUR";
            this.colREF_FOURNISSEUR.Name = "colREF_FOURNISSEUR";
            // 
            // colRS_FOURNISSEUR
            // 
            this.colRS_FOURNISSEUR.Caption = "Fournisseur";
            this.colRS_FOURNISSEUR.FieldName = "RS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Name = "colRS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Visible = true;
            this.colRS_FOURNISSEUR.VisibleIndex = 9;
            this.colRS_FOURNISSEUR.Width = 213;
            // 
            // colADRESSE_FOURNISSEUR
            // 
            this.colADRESSE_FOURNISSEUR.FieldName = "ADRESSE_FOURNISSEUR";
            this.colADRESSE_FOURNISSEUR.Name = "colADRESSE_FOURNISSEUR";
            // 
            // colTEL_FOURNISSEUR
            // 
            this.colTEL_FOURNISSEUR.FieldName = "TEL_FOURNISSEUR";
            this.colTEL_FOURNISSEUR.Name = "colTEL_FOURNISSEUR";
            // 
            // colTAUX_TVA
            // 
            this.colTAUX_TVA.Caption = "TVA";
            this.colTAUX_TVA.FieldName = "TAUX_TVA";
            this.colTAUX_TVA.Name = "colTAUX_TVA";
            this.colTAUX_TVA.Visible = true;
            this.colTAUX_TVA.VisibleIndex = 5;
            this.colTAUX_TVA.Width = 47;
            // 
            // colNOM_MAG
            // 
            this.colNOM_MAG.FieldName = "NOM_MAG";
            this.colNOM_MAG.Name = "colNOM_MAG";
            // 
            // colADRESSE_MAG
            // 
            this.colADRESSE_MAG.FieldName = "ADRESSE_MAG";
            this.colADRESSE_MAG.Name = "colADRESSE_MAG";
            // 
            // colTEL_MAG
            // 
            this.colTEL_MAG.FieldName = "TEL_MAG";
            this.colTEL_MAG.Name = "colTEL_MAG";
            // 
            // colPRIX_FIXE
            // 
            this.colPRIX_FIXE.FieldName = "PRIX_FIXE";
            this.colPRIX_FIXE.Name = "colPRIX_FIXE";
            // 
            // colPRIX_TTC
            // 
            this.colPRIX_TTC.FieldName = "PRIX_TTC";
            this.colPRIX_TTC.Name = "colPRIX_TTC";
            // 
            // colREF_FRN
            // 
            this.colREF_FRN.FieldName = "REF_FRN";
            this.colREF_FRN.Name = "colREF_FRN";
            // 
            // colSTOCKABLE
            // 
            this.colSTOCKABLE.FieldName = "STOCKABLE";
            this.colSTOCKABLE.Name = "colSTOCKABLE";
            // 
            // colTAUX_TVA_ACHAT
            // 
            this.colTAUX_TVA_ACHAT.FieldName = "TAUX_TVA_ACHAT";
            this.colTAUX_TVA_ACHAT.Name = "colTAUX_TVA_ACHAT";
            // 
            // colTVA_ACHAT
            // 
            this.colTVA_ACHAT.FieldName = "TVA_ACHAT";
            this.colTVA_ACHAT.Name = "colTVA_ACHAT";
            // 
            // CHM_COMMANDE_ARTICLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 473);
            this.Controls.Add(this.panel_qte);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PANEL_PHOTO);
            this.Controls.Add(this.magazin_article);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "CHM_COMMANDE_ARTICLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Articles";
            this.Shown += new System.EventHandler(this.CHM_COMMANDE_ARTICLE_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_COMMANDE_ARTICLE_KeyDown);
            this.CMS_ARTICLE.ResumeLayout(false);
            this.panel_qte.ResumeLayout(false);
            this.panel_qte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qte_select_article)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PANEL_PHOTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_ARTICLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox magazin_article;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_ARTICLE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel_qte;
        private System.Windows.Forms.Button btn_validation_ajout;
        private System.Windows.Forms.NumericUpDown qte_select_article;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label UNITE_ARTICLE;
        private System.Windows.Forms.Panel PANEL_PHOTO;
        private System.Windows.Forms.PictureBox PHOTO_ARTICLE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nud_prix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ajout;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dSGCBindingSource;
        private DS_GC dS_GC;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BARRE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_UNITE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE_MIN_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPHOTO_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT_A_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colTAUX_MAJORATION;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colETAT_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colMAX_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_SOLDE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BARRE_ARTICLE_SOLDE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT_V_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_UNITE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTAUX_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_FIXE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FRN;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colTAUX_TVA_ACHAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTVA_ACHAT;
    }
}