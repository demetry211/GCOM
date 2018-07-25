namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    partial class CHM_FRM_IMP_CB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_IMP_CB));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.chM_DS_IMP_CB1 = new CHM_CLIENT_APP.CHM_ARTICLES.CHM_DS_IMP_CB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDES_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCB_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chM_DS_IMP_CB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 48);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnSupprimer);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAjouter);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.crystalReportViewer1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1103, 504);
            this.splitContainerControl1.SplitterPosition = 364;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(274, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ticket(s).";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Impression par :";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "DT_ART";
            this.gridControl1.DataSource = this.chM_DS_IMP_CB1;
            this.gridControl1.Location = new System.Drawing.Point(3, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(360, 438);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // chM_DS_IMP_CB1
            // 
            this.chM_DS_IMP_CB1.DataSetName = "CHM_DS_IMP_CB";
            this.chM_DS_IMP_CB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_ARTICLE,
            this.colDES_ARTICLE,
            this.colPRIX_TTC,
            this.colCB_ARTICLE,
            this.colQTE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCB_ARTICLE, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            this.colCODE_ARTICLE.Width = 20;
            // 
            // colDES_ARTICLE
            // 
            this.colDES_ARTICLE.Caption = "Désignation";
            this.colDES_ARTICLE.FieldName = "DES_ARTICLE";
            this.colDES_ARTICLE.Name = "colDES_ARTICLE";
            this.colDES_ARTICLE.Visible = true;
            this.colDES_ARTICLE.VisibleIndex = 0;
            this.colDES_ARTICLE.Width = 635;
            // 
            // colPRIX_TTC
            // 
            this.colPRIX_TTC.Caption = "Prix TTC";
            this.colPRIX_TTC.FieldName = "PRIX_TTC";
            this.colPRIX_TTC.Name = "colPRIX_TTC";
            this.colPRIX_TTC.Visible = true;
            this.colPRIX_TTC.VisibleIndex = 2;
            this.colPRIX_TTC.Width = 392;
            // 
            // colCB_ARTICLE
            // 
            this.colCB_ARTICLE.Caption = "Code à barre";
            this.colCB_ARTICLE.FieldName = "CB_ARTICLE";
            this.colCB_ARTICLE.Name = "colCB_ARTICLE";
            this.colCB_ARTICLE.Visible = true;
            this.colCB_ARTICLE.VisibleIndex = 1;
            this.colCB_ARTICLE.Width = 547;
            // 
            // colQTE
            // 
            this.colQTE.Caption = "Qté";
            this.colQTE.FieldName = "QTE";
            this.colQTE.Name = "colQTE";
            this.colQTE.Visible = true;
            this.colQTE.VisibleIndex = 3;
            this.colQTE.Width = 160;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(86, 34);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(5, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowExportButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(734, 504);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entete_Formulaire_21.BackgroundImage")));
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(1103, 48);
            this.entete_Formulaire_21.TabIndex = 1;
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHM_FRM_IMP_CB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 552);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_IMP_CB";
            this.Text = "CHM_FRM_IMP_CB";
            this.Load += new System.EventHandler(this.CHM_FRM_IMP_CB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chM_DS_IMP_CB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private DevExpress.XtraEditors.SimpleButton btnSupprimer;
        private DevExpress.XtraEditors.SimpleButton btnAjouter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_MOUV dS_MOUV1;
        private CHM_DS_IMP_CB chM_DS_IMP_CB1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDES_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colCB_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}