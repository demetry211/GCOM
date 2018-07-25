namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_ARTICLES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_ARTICLES));
            this.CMS_ARTICLE = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_NV_ARTICLE = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_MODIFIER_ARTICLE = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_SUPP_ARTICLE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CMS_IMP_ARTICLE = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_IMP_LISTE_ARTICLE = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ARTICLE_RUP_STCK = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ARTICLE_BLOQUE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_GC1 = new CHM_CLIENT_APP.DS_GC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_UNITE = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colREF_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_TVA_VTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_FIXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FRN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCKABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.CMS_ARTICLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CMS_ARTICLE
            // 
            this.CMS_ARTICLE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_NV_ARTICLE,
            this.CMS_MODIFIER_ARTICLE,
            this.CMS_SUPP_ARTICLE,
            this.toolStripSeparator1,
            this.CMS_IMP_ARTICLE,
            this.toolStripSeparator2,
            this.actualiserToolStripMenuItem});
            this.CMS_ARTICLE.Name = "contextMenuStrip1";
            this.CMS_ARTICLE.Size = new System.Drawing.Size(146, 126);
            this.CMS_ARTICLE.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ARTICLE_Opening_1);
            // 
            // CMS_NV_ARTICLE
            // 
            this.CMS_NV_ARTICLE.Name = "CMS_NV_ARTICLE";
            this.CMS_NV_ARTICLE.Size = new System.Drawing.Size(145, 22);
            this.CMS_NV_ARTICLE.Text = "&Nouveau";
            this.CMS_NV_ARTICLE.Click += new System.EventHandler(this.CMS_NV_ARTICLE_Click);
            // 
            // CMS_MODIFIER_ARTICLE
            // 
            this.CMS_MODIFIER_ARTICLE.Name = "CMS_MODIFIER_ARTICLE";
            this.CMS_MODIFIER_ARTICLE.Size = new System.Drawing.Size(145, 22);
            this.CMS_MODIFIER_ARTICLE.Text = "&Modifier";
            this.CMS_MODIFIER_ARTICLE.Click += new System.EventHandler(this.CMS_MODIFIER_ARTICLE_Click);
            // 
            // CMS_SUPP_ARTICLE
            // 
            this.CMS_SUPP_ARTICLE.Name = "CMS_SUPP_ARTICLE";
            this.CMS_SUPP_ARTICLE.Size = new System.Drawing.Size(145, 22);
            this.CMS_SUPP_ARTICLE.Text = "&Supprimer";
            this.CMS_SUPP_ARTICLE.Click += new System.EventHandler(this.CMS_SUPP_ARTICLE_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // CMS_IMP_ARTICLE
            // 
            this.CMS_IMP_ARTICLE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_IMP_LISTE_ARTICLE,
            this.statistiquesToolStripMenuItem});
            this.CMS_IMP_ARTICLE.Name = "CMS_IMP_ARTICLE";
            this.CMS_IMP_ARTICLE.Size = new System.Drawing.Size(145, 22);
            this.CMS_IMP_ARTICLE.Text = "Imprimer";
            // 
            // CMS_IMP_LISTE_ARTICLE
            // 
            this.CMS_IMP_LISTE_ARTICLE.Name = "CMS_IMP_LISTE_ARTICLE";
            this.CMS_IMP_LISTE_ARTICLE.Size = new System.Drawing.Size(159, 22);
            this.CMS_IMP_LISTE_ARTICLE.Text = "Liste des articles";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_ARTICLE_RUP_STCK,
            this.CMS_ARTICLE_BLOQUE});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // CMS_ARTICLE_RUP_STCK
            // 
            this.CMS_ARTICLE_RUP_STCK.Name = "CMS_ARTICLE_RUP_STCK";
            this.CMS_ARTICLE_RUP_STCK.Size = new System.Drawing.Size(218, 22);
            this.CMS_ARTICLE_RUP_STCK.Text = "Articles en rupture de stock";
            // 
            // CMS_ARTICLE_BLOQUE
            // 
            this.CMS_ARTICLE_BLOQUE.Name = "CMS_ARTICLE_BLOQUE";
            this.CMS_ARTICLE_BLOQUE.Size = new System.Drawing.Size(218, 22);
            this.CMS_ARTICLE_BLOQUE.Text = "Articles  bloqués";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.demandes_un_dossier_icone_3816_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(737, 48);
            this.entete_Formulaire_21.TabIndex = 88;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.CMS_ARTICLE;
            this.gridControl1.DataMember = "V_ARTICLE";
            this.gridControl1.DataSource = this.dS_GC1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(597, 379);
            this.gridControl1.TabIndex = 89;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.dgv_liste_article_DoubleClick);
            // 
            // dS_GC1
            // 
            this.dS_GC1.DataSetName = "DS_GC";
            this.dS_GC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_ARTICLE,
            this.colREF_ARTICLE,
            this.colDESIGNATION_ARTICLE,
            this.colCODE_MARQUE,
            this.colDESCRIPTION_ARTICLE,
            this.colLIB_UNITE,
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
            this.colREF_FOURNISSEUR,
            this.colRS_FOURNISSEUR,
            this.colCODE_BARRE_ARTICLE,
            this.colADRESSE_FOURNISSEUR,
            this.colTEL_FOURNISSEUR,
            this.colLIB_TVA_VTE,
            this.colNOM_MAG,
            this.colADRESSE_MAG,
            this.colTEL_MAG,
            this.colPRIX_FIXE,
            this.colPRIX_TTC,
            this.colREF_FRN,
            this.colSTOCKABLE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Déplacer l\'entête de la colonne à regrouper par";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDESIGNATION_ARTICLE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            this.colCODE_ARTICLE.Width = 42;
            // 
            // colREF_ARTICLE
            // 
            this.colREF_ARTICLE.FieldName = "REF_ARTICLE";
            this.colREF_ARTICLE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colREF_ARTICLE.Name = "colREF_ARTICLE";
            this.colREF_ARTICLE.OptionsColumn.AllowMove = false;
            this.colREF_ARTICLE.OptionsColumn.FixedWidth = true;
            this.colREF_ARTICLE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colREF_ARTICLE.Visible = true;
            this.colREF_ARTICLE.VisibleIndex = 0;
            this.colREF_ARTICLE.Width = 76;
            // 
            // colDESIGNATION_ARTICLE
            // 
            this.colDESIGNATION_ARTICLE.FieldName = "DESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDESIGNATION_ARTICLE.Name = "colDESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.OptionsColumn.AllowMove = false;
            this.colDESIGNATION_ARTICLE.OptionsColumn.FixedWidth = true;
            this.colDESIGNATION_ARTICLE.Visible = true;
            this.colDESIGNATION_ARTICLE.VisibleIndex = 1;
            this.colDESIGNATION_ARTICLE.Width = 202;
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
            // colLIB_UNITE
            // 
            this.colLIB_UNITE.FieldName = "LIB_UNITE";
            this.colLIB_UNITE.Name = "colLIB_UNITE";
            this.colLIB_UNITE.Visible = true;
            this.colLIB_UNITE.VisibleIndex = 4;
            this.colLIB_UNITE.Width = 44;
            // 
            // colQTE_ARTICLE
            // 
            this.colQTE_ARTICLE.FieldName = "QTE_ARTICLE";
            this.colQTE_ARTICLE.Name = "colQTE_ARTICLE";
            this.colQTE_ARTICLE.Visible = true;
            this.colQTE_ARTICLE.VisibleIndex = 3;
            this.colQTE_ARTICLE.Width = 42;
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
            this.colPRIX_HT_A_ARTICLE.Visible = true;
            this.colPRIX_HT_A_ARTICLE.VisibleIndex = 8;
            // 
            // colTAUX_MAJORATION
            // 
            this.colTAUX_MAJORATION.DisplayFormat.FormatString = "p2";
            this.colTAUX_MAJORATION.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTAUX_MAJORATION.FieldName = "TAUX_MAJORATION";
            this.colTAUX_MAJORATION.Name = "colTAUX_MAJORATION";
            this.colTAUX_MAJORATION.Visible = true;
            this.colTAUX_MAJORATION.VisibleIndex = 9;
            // 
            // colCODE_TVA
            // 
            this.colCODE_TVA.FieldName = "CODE_TVA";
            this.colCODE_TVA.Name = "colCODE_TVA";
            // 
            // colETAT_ARTICLE
            // 
            this.colETAT_ARTICLE.FieldName = "ETAT_ARTICLE";
            this.colETAT_ARTICLE.Name = "colETAT_ARTICLE";
            this.colETAT_ARTICLE.Visible = true;
            this.colETAT_ARTICLE.VisibleIndex = 16;
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
            this.colPRIX_HT_V_ARTICLE.VisibleIndex = 10;
            // 
            // colREF_FAMILLE
            // 
            this.colREF_FAMILLE.FieldName = "REF_FAMILLE";
            this.colREF_FAMILLE.Name = "colREF_FAMILLE";
            // 
            // colDESIGNATION_FAMILLE
            // 
            this.colDESIGNATION_FAMILLE.FieldName = "DESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Name = "colDESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Visible = true;
            this.colDESIGNATION_FAMILLE.VisibleIndex = 6;
            this.colDESIGNATION_FAMILLE.Width = 105;
            // 
            // colDESCRIPTION_FAMILLE
            // 
            this.colDESCRIPTION_FAMILLE.FieldName = "DESCRIPTION_FAMILLE";
            this.colDESCRIPTION_FAMILLE.Name = "colDESCRIPTION_FAMILLE";
            // 
            // colLIB_CATEG
            // 
            this.colLIB_CATEG.FieldName = "LIB_CATEG";
            this.colLIB_CATEG.Name = "colLIB_CATEG";
            this.colLIB_CATEG.Visible = true;
            this.colLIB_CATEG.VisibleIndex = 7;
            this.colLIB_CATEG.Width = 112;
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
            this.colDESIGNATION_MARQUE.FieldName = "DESIGNATION_MARQUE";
            this.colDESIGNATION_MARQUE.Name = "colDESIGNATION_MARQUE";
            this.colDESIGNATION_MARQUE.Visible = true;
            this.colDESIGNATION_MARQUE.VisibleIndex = 5;
            this.colDESIGNATION_MARQUE.Width = 112;
            // 
            // colDESCRIPTION_MARQUE
            // 
            this.colDESCRIPTION_MARQUE.FieldName = "DESCRIPTION_MARQUE";
            this.colDESCRIPTION_MARQUE.Name = "colDESCRIPTION_MARQUE";
            // 
            // colREF_FOURNISSEUR
            // 
            this.colREF_FOURNISSEUR.FieldName = "REF_FOURNISSEUR";
            this.colREF_FOURNISSEUR.Name = "colREF_FOURNISSEUR";
            // 
            // colRS_FOURNISSEUR
            // 
            this.colRS_FOURNISSEUR.FieldName = "RS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Name = "colRS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Visible = true;
            this.colRS_FOURNISSEUR.VisibleIndex = 2;
            this.colRS_FOURNISSEUR.Width = 134;
            // 
            // colCODE_BARRE_ARTICLE
            // 
            this.colCODE_BARRE_ARTICLE.FieldName = "CODE_BARRE_ARTICLE";
            this.colCODE_BARRE_ARTICLE.Name = "colCODE_BARRE_ARTICLE";
            this.colCODE_BARRE_ARTICLE.Visible = true;
            this.colCODE_BARRE_ARTICLE.VisibleIndex = 14;
            this.colCODE_BARRE_ARTICLE.Width = 152;
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
            // colLIB_TVA_VTE
            // 
            this.colLIB_TVA_VTE.FieldName = "LIB_TVA_VENTE";
            this.colLIB_TVA_VTE.Name = "colLIB_TVA_VTE";
            this.colLIB_TVA_VTE.Visible = true;
            this.colLIB_TVA_VTE.VisibleIndex = 11;
            // 
            // colNOM_MAG
            // 
            this.colNOM_MAG.FieldName = "NOM_MAG";
            this.colNOM_MAG.Name = "colNOM_MAG";
            this.colNOM_MAG.Visible = true;
            this.colNOM_MAG.VisibleIndex = 15;
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
            this.colPRIX_FIXE.Visible = true;
            this.colPRIX_FIXE.VisibleIndex = 13;
            // 
            // colPRIX_TTC
            // 
            this.colPRIX_TTC.FieldName = "PRIX_TTC";
            this.colPRIX_TTC.Name = "colPRIX_TTC";
            this.colPRIX_TTC.Visible = true;
            this.colPRIX_TTC.VisibleIndex = 12;
            // 
            // colREF_FRN
            // 
            this.colREF_FRN.FieldName = "REF_FRN";
            this.colREF_FRN.Name = "colREF_FRN";
            this.colREF_FRN.Visible = true;
            this.colREF_FRN.VisibleIndex = 17;
            // 
            // colSTOCKABLE
            // 
            this.colSTOCKABLE.FieldName = "STOCKABLE";
            this.colSTOCKABLE.Name = "colSTOCKABLE";
            this.colSTOCKABLE.Visible = true;
            this.colSTOCKABLE.VisibleIndex = 18;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 379);
            this.chM_CMP_CONTROL1.TabIndex = 90;
            // 
            // CHM_LISTE_ARTICLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 427);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "CHM_LISTE_ARTICLES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Articles";
            this.Load += new System.EventHandler(this.CHM_LISTE_ARTICLES_Load);
            this.Shown += new System.EventHandler(this.CHM_LISTE_ARTICLES_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_ARTICLES_KeyDown);
            this.CMS_ARTICLE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CMS_ARTICLE;
        private System.Windows.Forms.ToolStripMenuItem CMS_NV_ARTICLE;
        private System.Windows.Forms.ToolStripMenuItem CMS_MODIFIER_ARTICLE;
        private System.Windows.Forms.ToolStripMenuItem CMS_SUPP_ARTICLE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CMS_IMP_ARTICLE;
        private System.Windows.Forms.ToolStripMenuItem CMS_IMP_LISTE_ARTICLE;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMS_ARTICLE_RUP_STCK;
        private System.Windows.Forms.ToolStripMenuItem CMS_ARTICLE_BLOQUE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_GC dS_GC1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_TVA_VTE;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_MAG;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_FIXE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FRN;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCKABLE;
    }
}