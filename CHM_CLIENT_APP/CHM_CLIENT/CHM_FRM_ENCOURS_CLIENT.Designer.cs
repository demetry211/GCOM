namespace CHM_CLIENT_APP.CHM_CLIENT
{
    partial class CHM_FRM_ENCOURS_CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_ENCOURS_CLIENT));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gcEncours = new DevExpress.XtraGrid.GridControl();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTYPEPIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_REG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_CLIENT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEncours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(557, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 378);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcEncours
            // 
            this.gcEncours.DataMember = "V_ENCOURS_VENTE";
            this.gcEncours.DataSource = this.dS_MOUV1;
            this.gcEncours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEncours.Location = new System.Drawing.Point(140, 48);
            this.gcEncours.MainView = this.gridView12;
            this.gcEncours.Name = "gcEncours";
            this.gcEncours.Size = new System.Drawing.Size(417, 378);
            this.gcEncours.TabIndex = 2;
            this.gcEncours.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView12});
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTYPEPIECE,
            this.colCODE_PIECE,
            this.colCODE_CLIENT7,
            this.colMONTANT,
            this.colMONTANT_REG,
            this.colRESTE2,
            this.colREF_CLIENT7,
            this.colRS_CLIENT7,
            this.colTEL_CLIENT2});
            this.gridView12.GridControl = this.gcEncours;
            this.gridView12.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT", this.colMONTANT, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_REG", this.colMONTANT_REG, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RESTE", this.colRESTE2, "{0:n3}")});
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsBehavior.ReadOnly = true;
            this.gridView12.OptionsView.ShowAutoFilterRow = true;
            this.gridView12.OptionsView.ShowFooter = true;
            // 
            // colTYPEPIECE
            // 
            this.colTYPEPIECE.FieldName = "TYPE PIECE";
            this.colTYPEPIECE.Name = "colTYPEPIECE";
            this.colTYPEPIECE.Visible = true;
            this.colTYPEPIECE.VisibleIndex = 1;
            // 
            // colCODE_PIECE
            // 
            this.colCODE_PIECE.FieldName = "CODE_PIECE";
            this.colCODE_PIECE.Name = "colCODE_PIECE";
            this.colCODE_PIECE.Visible = true;
            this.colCODE_PIECE.VisibleIndex = 2;
            // 
            // colCODE_CLIENT7
            // 
            this.colCODE_CLIENT7.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT7.Name = "colCODE_CLIENT7";
            // 
            // colMONTANT
            // 
            this.colMONTANT.FieldName = "MONTANT";
            this.colMONTANT.Name = "colMONTANT";
            this.colMONTANT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT", "{0:n3}")});
            this.colMONTANT.Visible = true;
            this.colMONTANT.VisibleIndex = 3;
            // 
            // colMONTANT_REG
            // 
            this.colMONTANT_REG.FieldName = "MONTANT_REG";
            this.colMONTANT_REG.Name = "colMONTANT_REG";
            this.colMONTANT_REG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_REG", "{0:n3}")});
            this.colMONTANT_REG.Visible = true;
            this.colMONTANT_REG.VisibleIndex = 4;
            // 
            // colRESTE2
            // 
            this.colRESTE2.FieldName = "RESTE";
            this.colRESTE2.Name = "colRESTE2";
            this.colRESTE2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RESTE", "{0:n3}")});
            this.colRESTE2.Visible = true;
            this.colRESTE2.VisibleIndex = 5;
            // 
            // colREF_CLIENT7
            // 
            this.colREF_CLIENT7.FieldName = "REF_CLIENT";
            this.colREF_CLIENT7.Name = "colREF_CLIENT7";
            // 
            // colRS_CLIENT7
            // 
            this.colRS_CLIENT7.FieldName = "RS_CLIENT";
            this.colRS_CLIENT7.Name = "colRS_CLIENT7";
            this.colRS_CLIENT7.Visible = true;
            this.colRS_CLIENT7.VisibleIndex = 0;
            // 
            // colTEL_CLIENT2
            // 
            this.colTEL_CLIENT2.FieldName = "TEL_CLIENT";
            this.colTEL_CLIENT2.Name = "colTEL_CLIENT2";
            this.colTEL_CLIENT2.Visible = true;
            this.colTEL_CLIENT2.VisibleIndex = 6;
            // 
            // CHM_FRM_ENCOURS_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 426);
            this.Controls.Add(this.gcEncours);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_ENCOURS_CLIENT";
            this.Text = "Encours Vente";
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEncours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.GridControl gcEncours;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPEPIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_PIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT7;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_REG;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTE2;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT7;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT7;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_CLIENT2;
    }
}