namespace CHM_CLIENT_APP.CHM_INVENTAIRE
{
    partial class CHM_FRM_LISTE_INVENTAIRE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_INVENTAIRE));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dS_GC1 = new CHM_CLIENT_APP.DS_GC();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.colCODE_INVENTAIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_DEBUT_INVENTAIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FIN_INVENTAIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_CREAT_INV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_FERM_INV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_CLOTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_OUVERTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(690, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 326);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "INVENTAIRE";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 326);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_INVENTAIRE,
            this.colDATE_DEBUT_INVENTAIRE,
            this.colDATE_FIN_INVENTAIRE,
            this.colCODE_MAG,
            this.colUTILISATEUR_CREAT_INV,
            this.colUTILISATEUR_FERM_INV,
            this.colNOM_MAG,
            this.colUSER_CLOTURE,
            this.colUSER_OUVERTURE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // dS_GC1
            // 
            this.dS_GC1.DataSetName = "DS_GC";
            this.dS_GC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colCODE_INVENTAIRE
            // 
            this.colCODE_INVENTAIRE.FieldName = "CODE_INVENTAIRE";
            this.colCODE_INVENTAIRE.Name = "colCODE_INVENTAIRE";
            this.colCODE_INVENTAIRE.Visible = true;
            this.colCODE_INVENTAIRE.VisibleIndex = 0;
            // 
            // colDATE_DEBUT_INVENTAIRE
            // 
            this.colDATE_DEBUT_INVENTAIRE.FieldName = "DATE_DEBUT_INVENTAIRE";
            this.colDATE_DEBUT_INVENTAIRE.Name = "colDATE_DEBUT_INVENTAIRE";
            this.colDATE_DEBUT_INVENTAIRE.Visible = true;
            this.colDATE_DEBUT_INVENTAIRE.VisibleIndex = 1;
            // 
            // colDATE_FIN_INVENTAIRE
            // 
            this.colDATE_FIN_INVENTAIRE.FieldName = "DATE_FIN_INVENTAIRE";
            this.colDATE_FIN_INVENTAIRE.Name = "colDATE_FIN_INVENTAIRE";
            this.colDATE_FIN_INVENTAIRE.Visible = true;
            this.colDATE_FIN_INVENTAIRE.VisibleIndex = 2;
            // 
            // colCODE_MAG
            // 
            this.colCODE_MAG.FieldName = "CODE_MAG";
            this.colCODE_MAG.Name = "colCODE_MAG";
            this.colCODE_MAG.Visible = true;
            this.colCODE_MAG.VisibleIndex = 3;
            // 
            // colUTILISATEUR_CREAT_INV
            // 
            this.colUTILISATEUR_CREAT_INV.FieldName = "UTILISATEUR_CREAT_INV";
            this.colUTILISATEUR_CREAT_INV.Name = "colUTILISATEUR_CREAT_INV";
            this.colUTILISATEUR_CREAT_INV.Visible = true;
            this.colUTILISATEUR_CREAT_INV.VisibleIndex = 4;
            // 
            // colUTILISATEUR_FERM_INV
            // 
            this.colUTILISATEUR_FERM_INV.FieldName = "UTILISATEUR_FERM_INV";
            this.colUTILISATEUR_FERM_INV.Name = "colUTILISATEUR_FERM_INV";
            this.colUTILISATEUR_FERM_INV.Visible = true;
            this.colUTILISATEUR_FERM_INV.VisibleIndex = 5;
            // 
            // colNOM_MAG
            // 
            this.colNOM_MAG.FieldName = "NOM_MAG";
            this.colNOM_MAG.Name = "colNOM_MAG";
            this.colNOM_MAG.Visible = true;
            this.colNOM_MAG.VisibleIndex = 6;
            // 
            // colUSER_CLOTURE
            // 
            this.colUSER_CLOTURE.FieldName = "USER_CLOTURE";
            this.colUSER_CLOTURE.Name = "colUSER_CLOTURE";
            this.colUSER_CLOTURE.Visible = true;
            this.colUSER_CLOTURE.VisibleIndex = 7;
            // 
            // colUSER_OUVERTURE
            // 
            this.colUSER_OUVERTURE.FieldName = "USER_OUVERTURE";
            this.colUSER_OUVERTURE.Name = "colUSER_OUVERTURE";
            this.colUSER_OUVERTURE.Visible = true;
            this.colUSER_OUVERTURE.VisibleIndex = 8;
            // 
            // CHM_FRM_LISTE_INVENTAIRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 374);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_LISTE_INVENTAIRE";
            this.Text = "Liste des inventaires";
            this.Load += new System.EventHandler(this.CHM_FRM_LISTE_INVENTAIRE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_GC dS_GC1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_INVENTAIRE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_DEBUT_INVENTAIRE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FIN_INVENTAIRE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_CREAT_INV;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_FERM_INV;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_CLOTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_OUVERTURE;
    }
}