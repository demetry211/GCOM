namespace CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE
{
    partial class CHM_FRM_LISTE_TYPE_MAINT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_TYPE_MAINT));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_TYPE_MNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_MNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_UNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNB_JOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAL_MNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_UNITE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(644, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 397);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_TYPE_MAINTENANCE";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(504, 397);
            this.gridControl1.TabIndex = 2;
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
            this.colCODE_TYPE_MNT,
            this.colLIB_MNT,
            this.colCODE_UNITE,
            this.colNB_JOUR,
            this.colVAL_MNT,
            this.colLIB_UNITE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Placer ici les colonnes à grouper par";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCODE_TYPE_MNT
            // 
            this.colCODE_TYPE_MNT.FieldName = "CODE_TYPE_MNT";
            this.colCODE_TYPE_MNT.Name = "colCODE_TYPE_MNT";
            this.colCODE_TYPE_MNT.Visible = true;
            this.colCODE_TYPE_MNT.VisibleIndex = 0;
            this.colCODE_TYPE_MNT.Width = 151;
            // 
            // colLIB_MNT
            // 
            this.colLIB_MNT.FieldName = "LIB_MNT";
            this.colLIB_MNT.Name = "colLIB_MNT";
            this.colLIB_MNT.Visible = true;
            this.colLIB_MNT.VisibleIndex = 1;
            this.colLIB_MNT.Width = 706;
            // 
            // colCODE_UNITE
            // 
            this.colCODE_UNITE.FieldName = "CODE_UNITE";
            this.colCODE_UNITE.Name = "colCODE_UNITE";
            // 
            // colNB_JOUR
            // 
            this.colNB_JOUR.FieldName = "NB_JOUR";
            this.colNB_JOUR.Name = "colNB_JOUR";
            this.colNB_JOUR.Visible = true;
            this.colNB_JOUR.VisibleIndex = 4;
            this.colNB_JOUR.Width = 297;
            // 
            // colVAL_MNT
            // 
            this.colVAL_MNT.FieldName = "VAL_MNT";
            this.colVAL_MNT.Name = "colVAL_MNT";
            this.colVAL_MNT.Visible = true;
            this.colVAL_MNT.VisibleIndex = 3;
            this.colVAL_MNT.Width = 290;
            // 
            // colLIB_UNITE
            // 
            this.colLIB_UNITE.FieldName = "LIB_UNITE";
            this.colLIB_UNITE.Name = "colLIB_UNITE";
            this.colLIB_UNITE.Visible = true;
            this.colLIB_UNITE.VisibleIndex = 2;
            this.colLIB_UNITE.Width = 290;
            // 
            // CHM_FRM_LISTE_TYPE_MAINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 445);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_TYPE_MAINT";
            this.Text = "Liste des types de maintenance";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_TYPE_MAINT_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TYPE_MNT;
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_MNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_UNITE;
        private DevExpress.XtraGrid.Columns.GridColumn colNB_JOUR;
        private DevExpress.XtraGrid.Columns.GridColumn colVAL_MNT;
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_UNITE;
    }
}