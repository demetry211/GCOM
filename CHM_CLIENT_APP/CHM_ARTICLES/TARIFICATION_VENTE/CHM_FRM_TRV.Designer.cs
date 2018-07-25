namespace CHM_CLIENT_APP.CHM_ARTICLES.TARIFICATION_VENTE
{
    partial class CHM_FRM_TRV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_TRV));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.btn_refresh = new CHM_STYLE.CHM_BUTTON(this.components);
            this.chM_WAITER1 = new CHM_STYLE.CHM_WAITER(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSTRVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_TRV = new CHM_CLIENT_APP.CHM_ARTICLES.TARIFICATION_VENTE.DS_TRV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRV_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_LIBELLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_CODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.aRTICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTRV_CODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cLIENTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.colTRV_CODE_UNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.uNITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTRV_PRIX_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_TX_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_DEBUT_VALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_FIN_VALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_DATE_CREATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_CREATEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_DATE_MODIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRV_MODIFICATEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.uNITETableAdapter = new CHM_CLIENT_APP.CHM_ARTICLES.TARIFICATION_VENTE.DS_TRVTableAdapters.UNITETableAdapter();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entete_Formulaire_21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chM_WAITER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTRVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_TRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Controls.Add(this.btn_refresh);
            this.entete_Formulaire_21.Controls.Add(this.chM_WAITER1);
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(694, 48);
            this.entete_Formulaire_21.TabIndex = 82;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(831, 8);
            this.btn_refresh.MouseHoverColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(35, 33);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // chM_WAITER1
            // 
            this.chM_WAITER1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chM_WAITER1.BackColor = System.Drawing.Color.Transparent;
            this.chM_WAITER1.Image = ((System.Drawing.Image)(resources.GetObject("chM_WAITER1.Image")));
            this.chM_WAITER1.Location = new System.Drawing.Point(797, 9);
            this.chM_WAITER1.Name = "chM_WAITER1";
            this.chM_WAITER1.Size = new System.Drawing.Size(31, 31);
            this.chM_WAITER1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chM_WAITER1.TabIndex = 6;
            this.chM_WAITER1.TabStop = false;
            this.chM_WAITER1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "TRV";
            this.gridControl1.DataSource = this.dSTRVBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(694, 354);
            this.gridControl1.TabIndex = 83;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dSTRVBindingSource
            // 
            this.dSTRVBindingSource.DataSource = this.dS_TRV;
            this.dSTRVBindingSource.Position = 0;
            // 
            // dS_TRV
            // 
            this.dS_TRV.DataSetName = "DS_TRV";
            this.dS_TRV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRV_ID,
            this.colTRV_LIBELLE,
            this.colTRV_CODE_ARTICLE,
            this.colTRV_CODE_CLIENT,
            this.colTRV_CODE_UNITE,
            this.colTRV_PRIX_HT,
            this.colTRV_TX_REMISE,
            this.colTRV_DEBUT_VALID,
            this.colTRV_FIN_VALID,
            this.colTRV_DATE_CREATION,
            this.colTRV_CREATEUR,
            this.colTRV_DATE_MODIF,
            this.colTRV_MODIFICATEUR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes à regrouper par";
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Cliquer ici pour ajouter une nouvelle ligne";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRV_CODE_UNITE, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colTRV_ID
            // 
            this.colTRV_ID.FieldName = "TRV_ID";
            this.colTRV_ID.Name = "colTRV_ID";
            // 
            // colTRV_LIBELLE
            // 
            this.colTRV_LIBELLE.FieldName = "TRV_LIBELLE";
            this.colTRV_LIBELLE.Name = "colTRV_LIBELLE";
            this.colTRV_LIBELLE.Visible = true;
            this.colTRV_LIBELLE.VisibleIndex = 0;
            // 
            // colTRV_CODE_ARTICLE
            // 
            this.colTRV_CODE_ARTICLE.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colTRV_CODE_ARTICLE.FieldName = "TRV_CODE_ARTICLE";
            this.colTRV_CODE_ARTICLE.Name = "colTRV_CODE_ARTICLE";
            this.colTRV_CODE_ARTICLE.Visible = true;
            this.colTRV_CODE_ARTICLE.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_ARTICLE", "Code", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REF_ARTICLE", "Réf.", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESIGNATION_ARTICLE", "Désignation", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_MARQUE", "Code Marque", 74, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPTION_ARTICLE", "Description Article", 96, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_BARRE_ARTICLE", "Code à barre", 73, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QTE_ARTICLE", "Qté", 28, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_UNITE", "Code Unité", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QTE_MIN_ARTICLE", "Qté Minimale", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHOTO_ARTICLE", "Photo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRIX_HT_A_ARTICLE", "Prix HT Achat", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TAUX_MAJORATION", "% Majoration", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_TVA", "Code TVA Vente", 88, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ETAT_ARTICLE", "Bloqué", 42, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_FAMILLE", "Code Famille", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_CATEG", "Code Catégorie", 85, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_MAG", "Code Magasin", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_FOURNISSEUR", "Code Fournisseur", 94, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAX_REMISE", "% Max Remise", 81, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRIX_SOLDE", "Prix Solde", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_BARRE_ARTICLE_SOLDE", "Code à barre Solde", 102, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRIX_HT_V_ARTICLE", "Prix HT Vente", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REF_FAMILLE", "Réf Famille", 62, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESIGNATION_FAMILLE", "Famille", 42, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPTION_FAMILLE", "Desc. Famille", 72, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LIB_CATEG", "Catégorie", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPTION_CATEG", "Desc. Categorie", 87, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REF_MARQUE", "Ref. Marque", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESIGNATION_MARQUE", "Marque", 46, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPTION_MARQUE", "Desc. Marque", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LIB_UNITE", "Unité", 35, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REF_FOURNISSEUR", "Réf. Fournisseur", 90, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RS_FOURNISSEUR", "Fournisseur", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADRESSE_FOURNISSEUR", "Adresse Fournisseur", 108, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEL_FOURNISSEUR", "Tel Fournisseur", 83, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TAUX_TVA", "Taux Tva Vente", 86, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOM_MAG", "Magasin Par Défaut", 104, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADRESSE_MAG", "Adresse Magasin", 91, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEL_MAG", "Tel Magasin", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REF_FRN", "Reférence Fournisseur", 119, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STOCKABLE", "Stockable", 56, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRIX_FIXE", "Prix Fixe", 51, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRIX_TTC", "Prix TTC", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TVA_ACHAT", "Code Tva Achat", 87, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TAUX_TVA_ACHAT", "Taux Tva Achat", 86, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit2.DataSource = this.aRTICLEBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "DESIGNATION_ARTICLE";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ShowHeader = false;
            this.repositoryItemLookUpEdit2.ValidateOnEnterKey = true;
            this.repositoryItemLookUpEdit2.ValueMember = "CODE_ARTICLE";
            // 
            // aRTICLEBindingSource
            // 
            this.aRTICLEBindingSource.DataMember = "ARTICLE";
            this.aRTICLEBindingSource.DataSource = this.dSTRVBindingSource;
            // 
            // colTRV_CODE_CLIENT
            // 
            this.colTRV_CODE_CLIENT.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colTRV_CODE_CLIENT.FieldName = "TRV_CODE_CLIENT";
            this.colTRV_CODE_CLIENT.Name = "colTRV_CODE_CLIENT";
            this.colTRV_CODE_CLIENT.Visible = true;
            this.colTRV_CODE_CLIENT.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_CLIENT", "CODE_CLIENT", 92, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("REF_CLIENT", "REF_CLIENT", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RS_CLIENT", "RS_CLIENT", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit3.DataSource = this.cLIENTBindingSource2;
            this.repositoryItemLookUpEdit3.DisplayMember = "RS_CLIENT";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemLookUpEdit3.ShowHeader = false;
            this.repositoryItemLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit3.ValidateOnEnterKey = true;
            this.repositoryItemLookUpEdit3.ValueMember = "CODE_CLIENT";
            // 
            // cLIENTBindingSource2
            // 
            this.cLIENTBindingSource2.DataMember = "CLIENT";
            this.cLIENTBindingSource2.DataSource = this.dS_TRV;
            // 
            // colTRV_CODE_UNITE
            // 
            this.colTRV_CODE_UNITE.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTRV_CODE_UNITE.FieldName = "TRV_CODE_UNITE";
            this.colTRV_CODE_UNITE.Name = "colTRV_CODE_UNITE";
            this.colTRV_CODE_UNITE.Visible = true;
            this.colTRV_CODE_UNITE.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE_UNITE", "Code", 48, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LIB_UNITE", "LIB_UNITE", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.uNITEBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "LIB_UNITE";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.ValidateOnEnterKey = true;
            this.repositoryItemLookUpEdit1.ValueMember = "CODE_UNITE";
            // 
            // uNITEBindingSource
            // 
            this.uNITEBindingSource.DataMember = "UNITE";
            this.uNITEBindingSource.DataSource = this.dSTRVBindingSource;
            // 
            // colTRV_PRIX_HT
            // 
            this.colTRV_PRIX_HT.DisplayFormat.FormatString = "N3";
            this.colTRV_PRIX_HT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTRV_PRIX_HT.FieldName = "TRV_PRIX_HT";
            this.colTRV_PRIX_HT.Name = "colTRV_PRIX_HT";
            this.colTRV_PRIX_HT.Visible = true;
            this.colTRV_PRIX_HT.VisibleIndex = 4;
            // 
            // colTRV_TX_REMISE
            // 
            this.colTRV_TX_REMISE.DisplayFormat.FormatString = "N2";
            this.colTRV_TX_REMISE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTRV_TX_REMISE.FieldName = "TRV_TX_REMISE";
            this.colTRV_TX_REMISE.Name = "colTRV_TX_REMISE";
            this.colTRV_TX_REMISE.Visible = true;
            this.colTRV_TX_REMISE.VisibleIndex = 5;
            // 
            // colTRV_DEBUT_VALID
            // 
            this.colTRV_DEBUT_VALID.FieldName = "TRV_DEBUT_VALID";
            this.colTRV_DEBUT_VALID.Name = "colTRV_DEBUT_VALID";
            this.colTRV_DEBUT_VALID.Visible = true;
            this.colTRV_DEBUT_VALID.VisibleIndex = 6;
            // 
            // colTRV_FIN_VALID
            // 
            this.colTRV_FIN_VALID.FieldName = "TRV_FIN_VALID";
            this.colTRV_FIN_VALID.Name = "colTRV_FIN_VALID";
            this.colTRV_FIN_VALID.Visible = true;
            this.colTRV_FIN_VALID.VisibleIndex = 7;
            // 
            // colTRV_DATE_CREATION
            // 
            this.colTRV_DATE_CREATION.FieldName = "TRV_DATE_CREATION";
            this.colTRV_DATE_CREATION.Name = "colTRV_DATE_CREATION";
            // 
            // colTRV_CREATEUR
            // 
            this.colTRV_CREATEUR.FieldName = "TRV_CREATEUR";
            this.colTRV_CREATEUR.Name = "colTRV_CREATEUR";
            // 
            // colTRV_DATE_MODIF
            // 
            this.colTRV_DATE_MODIF.FieldName = "TRV_DATE_MODIF";
            this.colTRV_DATE_MODIF.Name = "colTRV_DATE_MODIF";
            // 
            // colTRV_MODIFICATEUR
            // 
            this.colTRV_MODIFICATEUR.FieldName = "TRV_MODIFICATEUR";
            this.colTRV_MODIFICATEUR.Name = "colTRV_MODIFICATEUR";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.cLIENTBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "RS_CLIENT";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "CODE_CLIENT";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.dSTRVBindingSource;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // uNITETableAdapter
            // 
            this.uNITETableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTBindingSource1
            // 
            this.cLIENTBindingSource1.DataMember = "CLIENT";
            this.cLIENTBindingSource1.DataSource = this.dSTRVBindingSource;
            // 
            // CHM_FRM_TRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 402);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_TRV";
            this.Text = "Tarif Vente";
            this.Load += new System.EventHandler(this.CHM_FRM_TRV_Load);
            this.entete_Formulaire_21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chM_WAITER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTRVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_TRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_BUTTON btn_refresh;
        private CHM_STYLE.CHM_WAITER chM_WAITER1;
        private DevExpress.XtraGrid.GridControl gridControl1=new DevExpress.XtraGrid.GridControl();
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource dSTRVBindingSource;
        private DS_TRV dS_TRV;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_LIBELLE;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_CODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_CODE_CLIENT;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_CODE_UNITE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_PRIX_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_TX_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_DEBUT_VALID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_FIN_VALID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_DATE_CREATION;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_CREATEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_DATE_MODIF;
        private DevExpress.XtraGrid.Columns.GridColumn colTRV_MODIFICATEUR;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource uNITEBindingSource;
        private CHM_CLIENT_APP.CHM_ARTICLES.TARIFICATION_VENTE.DS_TRVTableAdapters.UNITETableAdapter uNITETableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource aRTICLEBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
        private System.Windows.Forms.BindingSource cLIENTBindingSource2;
    }
}