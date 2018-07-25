namespace CHM_CLIENT_APP.CHM_MAGAZIN
{
    partial class CHM_LISTE_STOCK_PAR_MAGAZIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_STOCK_PAR_MAGAZIN));
            this.cbx_magasin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recherche_article = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTTE_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARQUE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE_MIN_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHOTO_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNITE_QTE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT_A_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT_V_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAX_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_SOLDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE_ARTICLE_SOLDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_SOCIETE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_magasin
            // 
            this.cbx_magasin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_magasin.FormattingEnabled = true;
            this.cbx_magasin.Location = new System.Drawing.Point(529, 16);
            this.cbx_magasin.Name = "cbx_magasin";
            this.cbx_magasin.Size = new System.Drawing.Size(228, 21);
            this.cbx_magasin.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 154);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Recherche :";
            // 
            // recherche_article
            // 
            this.recherche_article.Location = new System.Drawing.Point(234, 150);
            this.recherche_article.Name = "recherche_article";
            this.recherche_article.Size = new System.Drawing.Size(244, 20);
            this.recherche_article.TabIndex = 28;
            this.recherche_article.TextChanged += new System.EventHandler(this.recherche_article_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Magasin :";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(851, 48);
            this.entete_Formulaire_21.TabIndex = 30;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 336);
            this.chM_CMP_CONTROL1.TabIndex = 31;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "STOCK";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(711, 336);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_MAG,
            this.colCODE_ARTICLE,
            this.colQTTE_STOCK,
            this.colREF_ARTICLE,
            this.colDESIGNATION_ARTICLE,
            this.colMARQUE_ARTICLE,
            this.colDESCRIPTION_ARTICLE,
            this.colCODE_BARRE_ARTICLE,
            this.colQTE_MIN_ARTICLE,
            this.colPHOTO_ARTICLE,
            this.colUNITE_QTE_ARTICLE,
            this.colPRIX_HT_A_ARTICLE,
            this.colPRIX_HT_V_ARTICLE,
            this.colMAX_REMISE,
            this.colPRIX_SOLDE,
            this.colCODE_BARRE_ARTICLE_SOLDE,
            this.colNOM_MAG,
            this.colADRESSE_MAG,
            this.colTEL_MAG,
            this.colCODE_SOCIETE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupPanelText = "Faites glisser un en-tête de colonne ici pour grouper par cette colonne";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNOM_MAG, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_MAG
            // 
            this.colCODE_MAG.FieldName = "CODE_MAG";
            this.colCODE_MAG.Name = "colCODE_MAG";
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            // 
            // colQTTE_STOCK
            // 
            this.colQTTE_STOCK.FieldName = "QTTE_STOCK";
            this.colQTTE_STOCK.Name = "colQTTE_STOCK";
            this.colQTTE_STOCK.Visible = true;
            this.colQTTE_STOCK.VisibleIndex = 4;
            // 
            // colREF_ARTICLE
            // 
            this.colREF_ARTICLE.FieldName = "REF_ARTICLE";
            this.colREF_ARTICLE.Name = "colREF_ARTICLE";
            this.colREF_ARTICLE.Visible = true;
            this.colREF_ARTICLE.VisibleIndex = 0;
            // 
            // colDESIGNATION_ARTICLE
            // 
            this.colDESIGNATION_ARTICLE.FieldName = "DESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Name = "colDESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Visible = true;
            this.colDESIGNATION_ARTICLE.VisibleIndex = 1;
            // 
            // colMARQUE_ARTICLE
            // 
            this.colMARQUE_ARTICLE.FieldName = "MARQUE_ARTICLE";
            this.colMARQUE_ARTICLE.Name = "colMARQUE_ARTICLE";
            this.colMARQUE_ARTICLE.Visible = true;
            this.colMARQUE_ARTICLE.VisibleIndex = 2;
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
            this.colCODE_BARRE_ARTICLE.Visible = true;
            this.colCODE_BARRE_ARTICLE.VisibleIndex = 3;
            // 
            // colQTE_MIN_ARTICLE
            // 
            this.colQTE_MIN_ARTICLE.FieldName = "QTE_MIN_ARTICLE";
            this.colQTE_MIN_ARTICLE.Name = "colQTE_MIN_ARTICLE";
            this.colQTE_MIN_ARTICLE.Visible = true;
            this.colQTE_MIN_ARTICLE.VisibleIndex = 5;
            // 
            // colPHOTO_ARTICLE
            // 
            this.colPHOTO_ARTICLE.FieldName = "PHOTO_ARTICLE";
            this.colPHOTO_ARTICLE.Name = "colPHOTO_ARTICLE";
            // 
            // colUNITE_QTE_ARTICLE
            // 
            this.colUNITE_QTE_ARTICLE.FieldName = "UNITE_QTE_ARTICLE";
            this.colUNITE_QTE_ARTICLE.Name = "colUNITE_QTE_ARTICLE";
            this.colUNITE_QTE_ARTICLE.Visible = true;
            this.colUNITE_QTE_ARTICLE.VisibleIndex = 6;
            // 
            // colPRIX_HT_A_ARTICLE
            // 
            this.colPRIX_HT_A_ARTICLE.FieldName = "PRIX_HT_A_ARTICLE";
            this.colPRIX_HT_A_ARTICLE.Name = "colPRIX_HT_A_ARTICLE";
            this.colPRIX_HT_A_ARTICLE.Visible = true;
            this.colPRIX_HT_A_ARTICLE.VisibleIndex = 7;
            // 
            // colPRIX_HT_V_ARTICLE
            // 
            this.colPRIX_HT_V_ARTICLE.FieldName = "PRIX_HT_V_ARTICLE";
            this.colPRIX_HT_V_ARTICLE.Name = "colPRIX_HT_V_ARTICLE";
            this.colPRIX_HT_V_ARTICLE.Visible = true;
            this.colPRIX_HT_V_ARTICLE.VisibleIndex = 8;
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
            // colNOM_MAG
            // 
            this.colNOM_MAG.FieldName = "NOM_MAG";
            this.colNOM_MAG.Name = "colNOM_MAG";
            this.colNOM_MAG.Visible = true;
            this.colNOM_MAG.VisibleIndex = 9;
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
            // colCODE_SOCIETE
            // 
            this.colCODE_SOCIETE.FieldName = "CODE_SOCIETE";
            this.colCODE_SOCIETE.Name = "colCODE_SOCIETE";
            // 
            // CHM_LISTE_STOCK_PAR_MAGAZIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 384);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_magasin);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recherche_article);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CHM_LISTE_STOCK_PAR_MAGAZIN";
            this.Text = "Liste des Articles par Magasin";
            this.Load += new System.EventHandler(this.CHM_LISTE_STOCK_PAR_MAGAZIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_magasin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recherche_article;
        private System.Windows.Forms.Label label1;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTTE_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colMARQUE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BARRE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE_MIN_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPHOTO_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNITE_QTE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT_A_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT_V_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAX_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_SOLDE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BARRE_ARTICLE_SOLDE;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_SOCIETE;
    }
}