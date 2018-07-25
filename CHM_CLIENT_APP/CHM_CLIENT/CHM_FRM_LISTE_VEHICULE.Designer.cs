namespace CHM_CLIENT_APP.CHM_CLIENT
{
    partial class CHM_FRM_LISTE_VEHICULE
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
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_VEHICULE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRICULE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGAMME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUISSANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCYLINDRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_MARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dSMOUVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_MOUV = new CHM_CLIENT_APP.DS_MOUV();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMOUVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV)).BeginInit();
            this.SuspendLayout();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(613, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 387);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_VEHICULE,
            this.colMATRICULE,
            this.colCODE_MARQUE,
            this.colCODE_CLIENT,
            this.colGAMME,
            this.colTYPE,
            this.colPUISSANCE,
            this.colCYLINDRE,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colREF_MARQUE,
            this.colDESIGNATION_MARQUE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de groupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsDetail.SmartDetailExpand = false;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCODE_VEHICULE
            // 
            this.colCODE_VEHICULE.FieldName = "CODE_VEHICULE";
            this.colCODE_VEHICULE.Name = "colCODE_VEHICULE";
            this.colCODE_VEHICULE.OptionsColumn.ReadOnly = true;
            // 
            // colMATRICULE
            // 
            this.colMATRICULE.FieldName = "MATRICULE";
            this.colMATRICULE.Name = "colMATRICULE";
            this.colMATRICULE.Visible = true;
            this.colMATRICULE.VisibleIndex = 0;
            // 
            // colCODE_MARQUE
            // 
            this.colCODE_MARQUE.FieldName = "CODE_MARQUE";
            this.colCODE_MARQUE.Name = "colCODE_MARQUE";
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
            // 
            // colGAMME
            // 
            this.colGAMME.FieldName = "GAMME";
            this.colGAMME.Name = "colGAMME";
            this.colGAMME.Visible = true;
            this.colGAMME.VisibleIndex = 1;
            // 
            // colTYPE
            // 
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.Visible = true;
            this.colTYPE.VisibleIndex = 2;
            // 
            // colPUISSANCE
            // 
            this.colPUISSANCE.FieldName = "PUISSANCE";
            this.colPUISSANCE.Name = "colPUISSANCE";
            this.colPUISSANCE.Visible = true;
            this.colPUISSANCE.VisibleIndex = 3;
            // 
            // colCYLINDRE
            // 
            this.colCYLINDRE.FieldName = "CYLINDRE";
            this.colCYLINDRE.Name = "colCYLINDRE";
            this.colCYLINDRE.Visible = true;
            this.colCYLINDRE.VisibleIndex = 4;
            // 
            // colREF_CLIENT
            // 
            this.colREF_CLIENT.FieldName = "REF_CLIENT";
            this.colREF_CLIENT.Name = "colREF_CLIENT";
            // 
            // colRS_CLIENT
            // 
            this.colRS_CLIENT.FieldName = "RS_CLIENT";
            this.colRS_CLIENT.Name = "colRS_CLIENT";
            this.colRS_CLIENT.Visible = true;
            this.colRS_CLIENT.VisibleIndex = 5;
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
            this.colDESIGNATION_MARQUE.VisibleIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_VEHICULE";
            this.gridControl1.DataSource = this.dSMOUVBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(473, 387);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dSMOUVBindingSource
            // 
            this.dSMOUVBindingSource.DataSource = this.dS_MOUV;
            this.dSMOUVBindingSource.Position = 0;
            // 
            // dS_MOUV
            // 
            this.dS_MOUV.DataSetName = "DS_MOUV";
            this.dS_MOUV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHM_FRM_LISTE_VEHICULE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 435);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_LISTE_VEHICULE";
            this.Text = "Liste des Véhicules";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMOUVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_VEHICULE;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRICULE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colGAMME;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colPUISSANCE;
        private DevExpress.XtraGrid.Columns.GridColumn colCYLINDRE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_MARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_MARQUE;
        private System.Windows.Forms.BindingSource dSMOUVBindingSource;
        private DS_MOUV dS_MOUV;
    }
}