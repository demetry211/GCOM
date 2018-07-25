namespace CHM_CLIENT_APP.EQUIPEMENTS
{
    partial class CHM_FRM_LISTE_EQP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_EQP));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIBELLE_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUM_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FAB_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_MISE_SERVICE_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFABRIQUANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_TVA_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_preview = new CHM_STYLE.CHM_BUTTON(this.components);
            this.chM_BUTTON1 = new CHM_STYLE.CHM_BUTTON(this.components);
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(586, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 332);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_EQUIPEMENT";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(446, 332);
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
            this.colCODE_EQP,
            this.colLIBELLE_EQP,
            this.colNUM_SERIE,
            this.colDATE_FAB_EQP,
            this.colDATE_MISE_SERVICE_EQP,
            this.colFABRIQUANT,
            this.colCODE_CLIENT,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colADRESSE_CLIENT,
            this.colCP_CLIENT,
            this.colTEL_CLIENT,
            this.colCODE_TVA_CLIENT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Faites glisser un en-tête de colonne ici pour grouper par cette colonne";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.ViewCaption = "Liste des Equipemets";
            // 
            // colCODE_EQP
            // 
            this.colCODE_EQP.FieldName = "CODE_EQP";
            this.colCODE_EQP.Name = "colCODE_EQP";
            this.colCODE_EQP.Visible = true;
            this.colCODE_EQP.VisibleIndex = 0;
            // 
            // colLIBELLE_EQP
            // 
            this.colLIBELLE_EQP.FieldName = "LIBELLE_EQP";
            this.colLIBELLE_EQP.Name = "colLIBELLE_EQP";
            this.colLIBELLE_EQP.Visible = true;
            this.colLIBELLE_EQP.VisibleIndex = 1;
            // 
            // colNUM_SERIE
            // 
            this.colNUM_SERIE.FieldName = "NUM_SERIE";
            this.colNUM_SERIE.Name = "colNUM_SERIE";
            this.colNUM_SERIE.Visible = true;
            this.colNUM_SERIE.VisibleIndex = 2;
            // 
            // colDATE_FAB_EQP
            // 
            this.colDATE_FAB_EQP.FieldName = "DATE_FAB_EQP";
            this.colDATE_FAB_EQP.Name = "colDATE_FAB_EQP";
            this.colDATE_FAB_EQP.Visible = true;
            this.colDATE_FAB_EQP.VisibleIndex = 3;
            // 
            // colDATE_MISE_SERVICE_EQP
            // 
            this.colDATE_MISE_SERVICE_EQP.FieldName = "DATE_MISE_SERVICE_EQP";
            this.colDATE_MISE_SERVICE_EQP.Name = "colDATE_MISE_SERVICE_EQP";
            this.colDATE_MISE_SERVICE_EQP.Visible = true;
            this.colDATE_MISE_SERVICE_EQP.VisibleIndex = 4;
            // 
            // colFABRIQUANT
            // 
            this.colFABRIQUANT.FieldName = "FABRIQUANT";
            this.colFABRIQUANT.Name = "colFABRIQUANT";
            this.colFABRIQUANT.Visible = true;
            this.colFABRIQUANT.VisibleIndex = 5;
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
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
            this.colRS_CLIENT.VisibleIndex = 6;
            // 
            // colADRESSE_CLIENT
            // 
            this.colADRESSE_CLIENT.FieldName = "ADRESSE_CLIENT";
            this.colADRESSE_CLIENT.Name = "colADRESSE_CLIENT";
            // 
            // colCP_CLIENT
            // 
            this.colCP_CLIENT.FieldName = "CP_CLIENT";
            this.colCP_CLIENT.Name = "colCP_CLIENT";
            // 
            // colTEL_CLIENT
            // 
            this.colTEL_CLIENT.FieldName = "TEL_CLIENT";
            this.colTEL_CLIENT.Name = "colTEL_CLIENT";
            // 
            // colCODE_TVA_CLIENT
            // 
            this.colCODE_TVA_CLIENT.FieldName = "CODE_TVA_CLIENT";
            this.colCODE_TVA_CLIENT.Name = "colCODE_TVA_CLIENT";
            // 
            // btn_preview
            // 
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Image = global::CHM_CLIENT_APP.Properties.Resources.Print_32x321;
            this.btn_preview.Location = new System.Drawing.Point(13, 285);
            this.btn_preview.MouseHoverColor = System.Drawing.Color.Transparent;
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(112, 49);
            this.btn_preview.TabIndex = 3;
            this.btn_preview.Text = "Imprimer Liste";
            this.btn_preview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // chM_BUTTON1
            // 
            this.chM_BUTTON1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chM_BUTTON1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chM_BUTTON1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chM_BUTTON1.Location = new System.Drawing.Point(12, 340);
            this.chM_BUTTON1.MouseHoverColor = System.Drawing.Color.Transparent;
            this.chM_BUTTON1.Name = "chM_BUTTON1";
            this.chM_BUTTON1.Size = new System.Drawing.Size(112, 49);
            this.chM_BUTTON1.TabIndex = 3;
            this.chM_BUTTON1.Text = "Imprimer Fiche";
            this.chM_BUTTON1.UseVisualStyleBackColor = true;
            this.chM_BUTTON1.Click += new System.EventHandler(this.chM_BUTTON1_Click);
            // 
            // CHM_FRM_LISTE_EQP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 380);
            this.Controls.Add(this.chM_BUTTON1);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_LISTE_EQP";
            this.Text = "Liste des Equipements";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colLIBELLE_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FAB_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_MISE_SERVICE_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colFABRIQUANT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCP_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA_CLIENT;
        private CHM_STYLE.CHM_BUTTON btn_preview;
        private CHM_STYLE.CHM_BUTTON chM_BUTTON1;
    }
}