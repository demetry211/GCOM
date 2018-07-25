namespace CHM_CLIENT_APP
{
    partial class liste_client
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
            this.MENU_CLIENT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_NV_CLT = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_MODIFIER_CLT = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_SUPP_CLT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CMS_STATISTIQUE_CLT = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiffresDaffairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_IMPRIMER_CLT = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.dS_GC1 = new CHM_CLIENT_APP.DS_GC();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXO_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATTEST_EXO_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_DOUANE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_TVA_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETAT_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVILLE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAX_CREDIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL2_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MENU_CLIENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU_CLIENT
            // 
            this.MENU_CLIENT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_NV_CLT,
            this.CMS_MODIFIER_CLT,
            this.CMS_SUPP_CLT,
            this.toolStripSeparator2,
            this.CMS_STATISTIQUE_CLT,
            this.CMS_IMPRIMER_CLT});
            this.MENU_CLIENT.Name = "contextMenuStrip1";
            this.MENU_CLIENT.Size = new System.Drawing.Size(154, 120);
            this.MENU_CLIENT.Opening += new System.ComponentModel.CancelEventHandler(this.MENU_CLIENT_Opening);
            // 
            // CMS_NV_CLT
            // 
            this.CMS_NV_CLT.Name = "CMS_NV_CLT";
            this.CMS_NV_CLT.Size = new System.Drawing.Size(153, 22);
            this.CMS_NV_CLT.Text = "&Nouveau";
            this.CMS_NV_CLT.Click += new System.EventHandler(this.CMS_NV_CLT_Click);
            // 
            // CMS_MODIFIER_CLT
            // 
            this.CMS_MODIFIER_CLT.Name = "CMS_MODIFIER_CLT";
            this.CMS_MODIFIER_CLT.Size = new System.Drawing.Size(153, 22);
            this.CMS_MODIFIER_CLT.Text = "&Modifier";
            this.CMS_MODIFIER_CLT.Click += new System.EventHandler(this.CMS_MODIFIER_CLT_Click);
            // 
            // CMS_SUPP_CLT
            // 
            this.CMS_SUPP_CLT.Name = "CMS_SUPP_CLT";
            this.CMS_SUPP_CLT.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.CMS_SUPP_CLT.Size = new System.Drawing.Size(153, 22);
            this.CMS_SUPP_CLT.Text = "&Supprimer";
            this.CMS_SUPP_CLT.Click += new System.EventHandler(this.CMS_SUPP_CLT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // CMS_STATISTIQUE_CLT
            // 
            this.CMS_STATISTIQUE_CLT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCommandesToolStripMenuItem,
            this.listeFacturesToolStripMenuItem,
            this.chiffresDaffairesToolStripMenuItem});
            this.CMS_STATISTIQUE_CLT.Name = "CMS_STATISTIQUE_CLT";
            this.CMS_STATISTIQUE_CLT.Size = new System.Drawing.Size(153, 22);
            this.CMS_STATISTIQUE_CLT.Text = "S&tatistique";
            // 
            // listeCommandesToolStripMenuItem
            // 
            this.listeCommandesToolStripMenuItem.Name = "listeCommandesToolStripMenuItem";
            this.listeCommandesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listeCommandesToolStripMenuItem.Text = "Liste des commandes";
            this.listeCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesToolStripMenuItem_Click);
            // 
            // listeFacturesToolStripMenuItem
            // 
            this.listeFacturesToolStripMenuItem.Name = "listeFacturesToolStripMenuItem";
            this.listeFacturesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listeFacturesToolStripMenuItem.Text = "Liste des  factures";
            this.listeFacturesToolStripMenuItem.Click += new System.EventHandler(this.listeFacturesToolStripMenuItem_Click);
            // 
            // chiffresDaffairesToolStripMenuItem
            // 
            this.chiffresDaffairesToolStripMenuItem.Name = "chiffresDaffairesToolStripMenuItem";
            this.chiffresDaffairesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.chiffresDaffairesToolStripMenuItem.Text = "Chiffres d\'affaires";
            // 
            // CMS_IMPRIMER_CLT
            // 
            this.CMS_IMPRIMER_CLT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientsToolStripMenuItem});
            this.CMS_IMPRIMER_CLT.Name = "CMS_IMPRIMER_CLT";
            this.CMS_IMPRIMER_CLT.Size = new System.Drawing.Size(153, 22);
            this.CMS_IMPRIMER_CLT.Text = "Imprimer";
            // 
            // listeClientsToolStripMenuItem
            // 
            this.listeClientsToolStripMenuItem.Name = "listeClientsToolStripMenuItem";
            this.listeClientsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listeClientsToolStripMenuItem.Text = "Liste Clients";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.bill_homme_personne_utilisateur_icone_6596_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(683, 48);
            this.entete_Formulaire_21.TabIndex = 79;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.BackColor = System.Drawing.Color.Transparent;
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 295);
            this.chM_CMP_CONTROL1.TabIndex = 91;
            // 
            // dS_GC1
            // 
            this.dS_GC1.DataSetName = "DS_GC";
            this.dS_GC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "CLIENT";
            this.gridControl1.DataSource = this.dS_GC1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(543, 295);
            this.gridControl1.TabIndex = 92;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_CLIENT,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colADRESSE_CLIENT,
            this.colCP_CLIENT,
            this.colTEL_CLIENT,
            this.colFAX_CLIENT,
            this.colEMAIL_CLIENT,
            this.colEXO_CLIENT,
            this.colATTEST_EXO_CLIENT,
            this.colCODE_DOUANE_CLIENT,
            this.colCODE_TVA_CLIENT,
            this.colETAT_CLIENT,
            this.colCOMPTE,
            this.colVILLE_CLIENT,
            this.colPAYS_CLIENT,
            this.colMAX_CREDIT,
            this.colTEL2_CLIENT,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
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
            this.colREF_CLIENT.Visible = true;
            this.colREF_CLIENT.VisibleIndex = 0;
            this.colREF_CLIENT.Width = 146;
            // 
            // colRS_CLIENT
            // 
            this.colRS_CLIENT.FieldName = "RS_CLIENT";
            this.colRS_CLIENT.Name = "colRS_CLIENT";
            this.colRS_CLIENT.Visible = true;
            this.colRS_CLIENT.VisibleIndex = 1;
            this.colRS_CLIENT.Width = 279;
            // 
            // colADRESSE_CLIENT
            // 
            this.colADRESSE_CLIENT.FieldName = "ADRESSE_CLIENT";
            this.colADRESSE_CLIENT.Name = "colADRESSE_CLIENT";
            this.colADRESSE_CLIENT.Visible = true;
            this.colADRESSE_CLIENT.VisibleIndex = 3;
            this.colADRESSE_CLIENT.Width = 346;
            // 
            // colCP_CLIENT
            // 
            this.colCP_CLIENT.FieldName = "CP_CLIENT";
            this.colCP_CLIENT.Name = "colCP_CLIENT";
            this.colCP_CLIENT.Width = 48;
            // 
            // colTEL_CLIENT
            // 
            this.colTEL_CLIENT.FieldName = "TEL_CLIENT";
            this.colTEL_CLIENT.Name = "colTEL_CLIENT";
            this.colTEL_CLIENT.Visible = true;
            this.colTEL_CLIENT.VisibleIndex = 4;
            this.colTEL_CLIENT.Width = 196;
            // 
            // colFAX_CLIENT
            // 
            this.colFAX_CLIENT.FieldName = "FAX_CLIENT";
            this.colFAX_CLIENT.Name = "colFAX_CLIENT";
            this.colFAX_CLIENT.Visible = true;
            this.colFAX_CLIENT.VisibleIndex = 5;
            this.colFAX_CLIENT.Width = 154;
            // 
            // colEMAIL_CLIENT
            // 
            this.colEMAIL_CLIENT.FieldName = "EMAIL_CLIENT";
            this.colEMAIL_CLIENT.Name = "colEMAIL_CLIENT";
            this.colEMAIL_CLIENT.Width = 32;
            // 
            // colEXO_CLIENT
            // 
            this.colEXO_CLIENT.FieldName = "EXO_CLIENT";
            this.colEXO_CLIENT.Name = "colEXO_CLIENT";
            this.colEXO_CLIENT.Width = 32;
            // 
            // colATTEST_EXO_CLIENT
            // 
            this.colATTEST_EXO_CLIENT.FieldName = "ATTEST_EXO_CLIENT";
            this.colATTEST_EXO_CLIENT.Name = "colATTEST_EXO_CLIENT";
            this.colATTEST_EXO_CLIENT.Width = 32;
            // 
            // colCODE_DOUANE_CLIENT
            // 
            this.colCODE_DOUANE_CLIENT.FieldName = "CODE_DOUANE_CLIENT";
            this.colCODE_DOUANE_CLIENT.Name = "colCODE_DOUANE_CLIENT";
            this.colCODE_DOUANE_CLIENT.Width = 32;
            // 
            // colCODE_TVA_CLIENT
            // 
            this.colCODE_TVA_CLIENT.FieldName = "CODE_TVA_CLIENT";
            this.colCODE_TVA_CLIENT.Name = "colCODE_TVA_CLIENT";
            this.colCODE_TVA_CLIENT.Visible = true;
            this.colCODE_TVA_CLIENT.VisibleIndex = 6;
            this.colCODE_TVA_CLIENT.Width = 193;
            // 
            // colETAT_CLIENT
            // 
            this.colETAT_CLIENT.FieldName = "ETAT_CLIENT";
            this.colETAT_CLIENT.Name = "colETAT_CLIENT";
            this.colETAT_CLIENT.Visible = true;
            this.colETAT_CLIENT.VisibleIndex = 7;
            this.colETAT_CLIENT.Width = 101;
            // 
            // colCOMPTE
            // 
            this.colCOMPTE.FieldName = "COMPTE";
            this.colCOMPTE.Name = "colCOMPTE";
            this.colCOMPTE.Visible = true;
            this.colCOMPTE.VisibleIndex = 8;
            this.colCOMPTE.Width = 130;
            // 
            // colVILLE_CLIENT
            // 
            this.colVILLE_CLIENT.FieldName = "VILLE_CLIENT";
            this.colVILLE_CLIENT.Name = "colVILLE_CLIENT";
            this.colVILLE_CLIENT.Width = 28;
            // 
            // colPAYS_CLIENT
            // 
            this.colPAYS_CLIENT.FieldName = "PAYS_CLIENT";
            this.colPAYS_CLIENT.Name = "colPAYS_CLIENT";
            this.colPAYS_CLIENT.Width = 28;
            // 
            // colMAX_CREDIT
            // 
            this.colMAX_CREDIT.FieldName = "MAX_CREDIT";
            this.colMAX_CREDIT.Name = "colMAX_CREDIT";
            this.colMAX_CREDIT.Width = 28;
            // 
            // colTEL2_CLIENT
            // 
            this.colTEL2_CLIENT.FieldName = "TEL2_CLIENT";
            this.colTEL2_CLIENT.Name = "colTEL2_CLIENT";
            this.colTEL2_CLIENT.Width = 82;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Responsable";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "RESP_CLIENT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 189;
            // 
            // liste_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 343);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "liste_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des CLients";
            this.Shown += new System.EventHandler(this.liste_client_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.liste_client_KeyDown);
            this.MENU_CLIENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MENU_CLIENT;
        private System.Windows.Forms.ToolStripMenuItem CMS_NV_CLT;
        private System.Windows.Forms.ToolStripMenuItem CMS_MODIFIER_CLT;
        private System.Windows.Forms.ToolStripMenuItem CMS_SUPP_CLT;
        private System.Windows.Forms.ToolStripMenuItem CMS_STATISTIQUE_CLT;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiffresDaffairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CMS_IMPRIMER_CLT;
        private System.Windows.Forms.ToolStripMenuItem listeClientsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DS_GC dS_GC1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCP_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colEXO_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colATTEST_EXO_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_DOUANE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colETAT_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPTE;
        private DevExpress.XtraGrid.Columns.GridColumn colVILLE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colPAYS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAX_CREDIT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL2_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}

