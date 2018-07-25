namespace CHM_CLIENT_APP.CHM_TVA
{
    partial class CHM_LIST_TVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LIST_TVA));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSTVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTVA = new CHM_CLIENT_APP.CHM_TVA.DSTVA();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTVA_LIBELLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tAXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAXEBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(633, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "TVA";
            this.gridControl1.DataSource = this.dSTVABindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(633, 336);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // dSTVABindingSource
            // 
            this.dSTVABindingSource.DataSource = this.dSTVA;
            this.dSTVABindingSource.Position = 0;
            // 
            // dSTVA
            // 
            this.dSTVA.DataSetName = "DSTVA";
            this.dSTVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_TVA,
            this.colTVA_LIBELLE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colCODE_TVA
            // 
            this.colCODE_TVA.FieldName = "CODE_TVA";
            this.colCODE_TVA.Name = "colCODE_TVA";
            // 
            // colTVA_LIBELLE
            // 
            this.colTVA_LIBELLE.Caption = "TVA";
            this.colTVA_LIBELLE.FieldName = "TVA_LIBELLE";
            this.colTVA_LIBELLE.Name = "colTVA_LIBELLE";
            this.colTVA_LIBELLE.Visible = true;
            this.colTVA_LIBELLE.VisibleIndex = 0;
            this.colTVA_LIBELLE.Width = 159;
            // 
            // tAXEBindingSource
            // 
            this.tAXEBindingSource.DataMember = "TAXE";
            this.tAXEBindingSource.DataSource = this.dSTVABindingSource;
            // 
            // CHM_LIST_TVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 384);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_LIST_TVA";
            this.Text = "Paramètrage TVA";
            this.Load += new System.EventHandler(this.CHM_LIST_TVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAXEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dSTVABindingSource;
        private DSTVA dSTVA;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTVA_LIBELLE;
        private System.Windows.Forms.BindingSource tAXEBindingSource;
    }
}