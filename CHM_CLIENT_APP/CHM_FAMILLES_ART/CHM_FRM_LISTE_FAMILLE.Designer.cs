namespace CHM_CLIENT_APP.CHM_FAMILLES_ART
{
    partial class CHM_FRM_LISTE_FAMILLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_FAMILLE));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSGCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GC = new CHM_CLIENT_APP.DS_GC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_FAMILLE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entete_Formulaire_21.BackgroundImage")));
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.category__1_;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(572, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 299);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "FAMILLE";
            this.gridControl1.DataSource = this.dSGCBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(432, 299);
            this.gridControl1.TabIndex = 2;
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
            this.colCODE_FAMILLE,
            this.colREF_FAMILLE,
            this.colDESIGNATION_FAMILLE,
            this.colDESCRIPTION_FAMILLE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCODE_FAMILLE
            // 
            this.colCODE_FAMILLE.FieldName = "CODE_FAMILLE";
            this.colCODE_FAMILLE.Name = "colCODE_FAMILLE";
            this.colCODE_FAMILLE.OptionsColumn.ReadOnly = true;
            this.colCODE_FAMILLE.Width = 73;
            // 
            // colREF_FAMILLE
            // 
            this.colREF_FAMILLE.FieldName = "REF_FAMILLE";
            this.colREF_FAMILLE.Name = "colREF_FAMILLE";
            this.colREF_FAMILLE.Visible = true;
            this.colREF_FAMILLE.VisibleIndex = 0;
            this.colREF_FAMILLE.Width = 87;
            // 
            // colDESIGNATION_FAMILLE
            // 
            this.colDESIGNATION_FAMILLE.FieldName = "DESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Name = "colDESIGNATION_FAMILLE";
            this.colDESIGNATION_FAMILLE.Visible = true;
            this.colDESIGNATION_FAMILLE.VisibleIndex = 1;
            this.colDESIGNATION_FAMILLE.Width = 162;
            // 
            // colDESCRIPTION_FAMILLE
            // 
            this.colDESCRIPTION_FAMILLE.FieldName = "DESCRIPTION_FAMILLE";
            this.colDESCRIPTION_FAMILLE.Name = "colDESCRIPTION_FAMILLE";
            this.colDESCRIPTION_FAMILLE.Visible = true;
            this.colDESCRIPTION_FAMILLE.VisibleIndex = 2;
            this.colDESCRIPTION_FAMILLE.Width = 288;
            // 
            // CHM_FRM_LISTE_FAMILLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 347);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_FAMILLE";
            this.Text = "Liste des Familles Articles";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_FAMILLE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dSGCBindingSource;
        private DS_GC dS_GC;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_FAMILLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_FAMILLE;
    }
}