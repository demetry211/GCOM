namespace CHM_CLIENT_APP
{
    partial class CHM_ARTICLE_CATEGORIE
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
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_GC1 = new CHM_CLIENT_APP.DS_GC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_CATEG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.Root_Category;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(573, 48);
            this.entete_Formulaire_21.TabIndex = 74;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 273);
            this.chM_CMP_CONTROL1.TabIndex = 75;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "CATEGORIE";
            this.gridControl1.DataSource = this.dS_GC1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(433, 273);
            this.gridControl1.TabIndex = 76;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dS_GC1
            // 
            this.dS_GC1.DataSetName = "DS_GC";
            this.dS_GC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_CATEG,
            this.colREF_CATEG,
            this.colLIB_CATEG,
            this.colDESCRIPTION_CATEG,
            this.colCODE_FAMILLE,
            this.colREF_FAMILLE,
            this.colDESIGNATION_FAMILLE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupPanelText = "Glisser Ici les colonnes de regroupement";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.colREF_CATEG, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDESIGNATION_FAMILLE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_CATEG
            // 
            this.colCODE_CATEG.FieldName = "CODE_CATEG";
            this.colCODE_CATEG.Name = "colCODE_CATEG";
            // 
            // colREF_CATEG
            // 
            this.colREF_CATEG.FieldName = "REF_CATEG";
            this.colREF_CATEG.Name = "colREF_CATEG";
            this.colREF_CATEG.Visible = true;
            this.colREF_CATEG.VisibleIndex = 0;
            this.colREF_CATEG.Width = 50;
            // 
            // colLIB_CATEG
            // 
            this.colLIB_CATEG.FieldName = "LIB_CATEG";
            this.colLIB_CATEG.Name = "colLIB_CATEG";
            this.colLIB_CATEG.Visible = true;
            this.colLIB_CATEG.VisibleIndex = 1;
            this.colLIB_CATEG.Width = 153;
            // 
            // colDESCRIPTION_CATEG
            // 
            this.colDESCRIPTION_CATEG.FieldName = "DESCRIPTION_CATEG";
            this.colDESCRIPTION_CATEG.Name = "colDESCRIPTION_CATEG";
            this.colDESCRIPTION_CATEG.Width = 83;
            // 
            // colCODE_FAMILLE
            // 
            this.colCODE_FAMILLE.FieldName = "CODE_FAMILLE";
            this.colCODE_FAMILLE.Name = "colCODE_FAMILLE";
            // 
            // colREF_FAMILLE
            // 
            this.colREF_FAMILLE.FieldName = "REF_FAMILLE";
            this.colREF_FAMILLE.Name = "colREF_FAMILLE";
            this.colREF_FAMILLE.Width = 63;
            // 
            // colDESIGNATION_FAMILLE
            // 
            this.colDESIGNATION_FAMILLE.FieldName = "DESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Name = "colDESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Visible = true;
            this.colDESIGNATION_FAMILLE.VisibleIndex = 2;
            this.colDESIGNATION_FAMILLE.Width = 149;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // CHM_ARTICLE_CATEGORIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 321);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_ARTICLE_CATEGORIE";
            this.Text = "Liste des catégories";
            this.Shown += new System.EventHandler(this.CHM_ARTICLE_CATEGORIE_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_ARTICLE_CATEGORIE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DS_GC dS_GC1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_CATEG;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_FAMILLE;
    }
}