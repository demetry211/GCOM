namespace CHM_CLIENT_APP.CHM_MARQUE_ARTICLE
{
    partial class CHM_FRM_LISTE_MARQUES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_MARQUES));
            this.dataSet1 = new System.Data.DataSet();
            this.DT_MARQUE = new System.Data.DataTable();
            this.CODE_MARQUE = new System.Data.DataColumn();
            this.REF_MARQUE = new System.Data.DataColumn();
            this.DESIGNATION_MARQUE = new System.Data.DataColumn();
            this.DESCRIPTION_MARQUE = new System.Data.DataColumn();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_GC = new CHM_CLIENT_APP.DS_GC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MARQUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DT_MARQUE});
            // 
            // DT_MARQUE
            // 
            this.DT_MARQUE.Columns.AddRange(new System.Data.DataColumn[] {
            this.CODE_MARQUE,
            this.REF_MARQUE,
            this.DESIGNATION_MARQUE,
            this.DESCRIPTION_MARQUE});
            this.DT_MARQUE.TableName = "DT_MARQUE";
            // 
            // CODE_MARQUE
            // 
            this.CODE_MARQUE.Caption = "Code";
            this.CODE_MARQUE.ColumnName = "CODE_MARQUE";
            this.CODE_MARQUE.DataType = typeof(decimal);
            // 
            // REF_MARQUE
            // 
            this.REF_MARQUE.Caption = "Réf.";
            this.REF_MARQUE.ColumnName = "REF_MARQUE";
            // 
            // DESIGNATION_MARQUE
            // 
            this.DESIGNATION_MARQUE.Caption = "Désignation";
            this.DESIGNATION_MARQUE.ColumnName = "DESIGNATION_MARQUE";
            // 
            // DESCRIPTION_MARQUE
            // 
            this.DESCRIPTION_MARQUE.Caption = "Description";
            this.DESCRIPTION_MARQUE.ColumnName = "DESCRIPTION_MARQUE";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.marque32;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(566, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 315);
            this.chM_CMP_CONTROL1.TabIndex = 91;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "MARQUE";
            this.gridControl1.DataSource = this.dS_GC;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(426, 315);
            this.gridControl1.TabIndex = 92;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // dS_GC
            // 
            this.dS_GC.DataSetName = "DS_GC";
            this.dS_GC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_MARQUE,
            this.colREF_MARQUE,
            this.colDESIGNATION_MARQUE,
            this.colDESCRIPTION_MARQUE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCODE_MARQUE
            // 
            this.colCODE_MARQUE.FieldName = "CODE_MARQUE";
            this.colCODE_MARQUE.Name = "colCODE_MARQUE";
            this.colCODE_MARQUE.OptionsColumn.ReadOnly = true;
            this.colCODE_MARQUE.Width = 62;
            // 
            // colREF_MARQUE
            // 
            this.colREF_MARQUE.FieldName = "REF_MARQUE";
            this.colREF_MARQUE.Name = "colREF_MARQUE";
            this.colREF_MARQUE.Visible = true;
            this.colREF_MARQUE.VisibleIndex = 0;
            this.colREF_MARQUE.Width = 60;
            // 
            // colDESIGNATION_MARQUE
            // 
            this.colDESIGNATION_MARQUE.FieldName = "DESIGNATION_MARQUE";
            this.colDESIGNATION_MARQUE.Name = "colDESIGNATION_MARQUE";
            this.colDESIGNATION_MARQUE.Visible = true;
            this.colDESIGNATION_MARQUE.VisibleIndex = 1;
            this.colDESIGNATION_MARQUE.Width = 116;
            // 
            // colDESCRIPTION_MARQUE
            // 
            this.colDESCRIPTION_MARQUE.FieldName = "DESCRIPTION_MARQUE";
            this.colDESCRIPTION_MARQUE.Name = "colDESCRIPTION_MARQUE";
            this.colDESCRIPTION_MARQUE.Visible = true;
            this.colDESCRIPTION_MARQUE.VisibleIndex = 2;
            this.colDESCRIPTION_MARQUE.Width = 271;
            // 
            // CHM_FRM_LISTE_MARQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 363);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "CHM_FRM_LISTE_MARQUES";
            this.Text = "Liste des marques";
            this.Load += new System.EventHandler(this.CHM_FRM_LISTE_MARQUES_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_MARQUES_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MARQUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        public System.Data.DataSet dataSet1;
        private System.Data.DataTable DT_MARQUE;
        private System.Data.DataColumn CODE_MARQUE;
        private System.Data.DataColumn REF_MARQUE;
        private System.Data.DataColumn DESIGNATION_MARQUE;
        private System.Data.DataColumn DESCRIPTION_MARQUE;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DS_GC dS_GC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION_MARQUE;
    }
}