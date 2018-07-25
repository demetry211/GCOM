namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_UTILISATEURS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_UTILISATEURS));
            this.MENU_UTILISATEUR = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MENU_NOUVEAU = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_MODIFIER = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_SUPPRIMER = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RECHERCHE_UTILISATEUR = new System.Windows.Forms.TextBox();
            this.dgv_LISTE_UTILISATEUR = new System.Windows.Forms.DataGridView();
            this.NOM_USER_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN_USER_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FONCTION_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_societe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT_USER_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRENOM_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHOTO_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGIN_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colETAT_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_SOCIETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FONCTION_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIB_FONCTION_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_SOCIETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.MENU_UTILISATEUR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_UTILISATEUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU_UTILISATEUR
            // 
            this.MENU_UTILISATEUR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_NOUVEAU,
            this.MENU_MODIFIER,
            this.MENU_SUPPRIMER,
            this.toolStripSeparator1,
            this.actualiserToolStripMenuItem});
            this.MENU_UTILISATEUR.Name = "MENU_CLIENT";
            this.MENU_UTILISATEUR.Size = new System.Drawing.Size(166, 98);
            // 
            // MENU_NOUVEAU
            // 
            this.MENU_NOUVEAU.Name = "MENU_NOUVEAU";
            this.MENU_NOUVEAU.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MENU_NOUVEAU.Size = new System.Drawing.Size(165, 22);
            this.MENU_NOUVEAU.Text = "&Nouveau";
            // 
            // MENU_MODIFIER
            // 
            this.MENU_MODIFIER.Name = "MENU_MODIFIER";
            this.MENU_MODIFIER.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MENU_MODIFIER.Size = new System.Drawing.Size(165, 22);
            this.MENU_MODIFIER.Text = "&Modifier";
            // 
            // MENU_SUPPRIMER
            // 
            this.MENU_SUPPRIMER.Name = "MENU_SUPPRIMER";
            this.MENU_SUPPRIMER.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MENU_SUPPRIMER.Size = new System.Drawing.Size(165, 22);
            this.MENU_SUPPRIMER.Text = "&Supprimer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.actualiserToolStripMenuItem.Text = "&Actualiser";
            // 
            // RECHERCHE_UTILISATEUR
            // 
            this.RECHERCHE_UTILISATEUR.Location = new System.Drawing.Point(84, 32);
            this.RECHERCHE_UTILISATEUR.Name = "RECHERCHE_UTILISATEUR";
            this.RECHERCHE_UTILISATEUR.Size = new System.Drawing.Size(228, 20);
            this.RECHERCHE_UTILISATEUR.TabIndex = 8;
            // 
            // dgv_LISTE_UTILISATEUR
            // 
            this.dgv_LISTE_UTILISATEUR.AllowUserToAddRows = false;
            this.dgv_LISTE_UTILISATEUR.AllowUserToDeleteRows = false;
            this.dgv_LISTE_UTILISATEUR.AllowUserToResizeColumns = false;
            this.dgv_LISTE_UTILISATEUR.AllowUserToResizeRows = false;
            this.dgv_LISTE_UTILISATEUR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LISTE_UTILISATEUR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LISTE_UTILISATEUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LISTE_UTILISATEUR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOM_USER_,
            this.prenom_user,
            this.LOGIN_USER_,
            this.FONCTION_,
            this.code_societe,
            this.ETAT_USER_});
            this.dgv_LISTE_UTILISATEUR.ContextMenuStrip = this.MENU_UTILISATEUR;
            this.dgv_LISTE_UTILISATEUR.Location = new System.Drawing.Point(-1, 59);
            this.dgv_LISTE_UTILISATEUR.MultiSelect = false;
            this.dgv_LISTE_UTILISATEUR.Name = "dgv_LISTE_UTILISATEUR";
            this.dgv_LISTE_UTILISATEUR.ReadOnly = true;
            this.dgv_LISTE_UTILISATEUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LISTE_UTILISATEUR.Size = new System.Drawing.Size(534, 346);
            this.dgv_LISTE_UTILISATEUR.TabIndex = 10;
            // 
            // NOM_USER_
            // 
            this.NOM_USER_.DataPropertyName = "NOM_USER";
            this.NOM_USER_.FillWeight = 148.9273F;
            this.NOM_USER_.HeaderText = "Nom";
            this.NOM_USER_.Name = "NOM_USER_";
            this.NOM_USER_.ReadOnly = true;
            // 
            // prenom_user
            // 
            this.prenom_user.DataPropertyName = "PRENOM_USER";
            this.prenom_user.HeaderText = "Prénom";
            this.prenom_user.Name = "prenom_user";
            this.prenom_user.ReadOnly = true;
            // 
            // LOGIN_USER_
            // 
            this.LOGIN_USER_.DataPropertyName = "LOGIN_USER";
            this.LOGIN_USER_.FillWeight = 100.8757F;
            this.LOGIN_USER_.HeaderText = "Login";
            this.LOGIN_USER_.Name = "LOGIN_USER_";
            this.LOGIN_USER_.ReadOnly = true;
            // 
            // FONCTION_
            // 
            this.FONCTION_.DataPropertyName = "CODE_FONCTION_USER";
            this.FONCTION_.FillWeight = 153.5671F;
            this.FONCTION_.HeaderText = "Fonction";
            this.FONCTION_.Name = "FONCTION_";
            this.FONCTION_.ReadOnly = true;
            // 
            // code_societe
            // 
            this.code_societe.DataPropertyName = "CODE_SOCIETE";
            this.code_societe.HeaderText = "Société";
            this.code_societe.Name = "code_societe";
            this.code_societe.ReadOnly = true;
            // 
            // ETAT_USER_
            // 
            this.ETAT_USER_.DataPropertyName = "ETAT_USER";
            this.ETAT_USER_.FillWeight = 84.11852F;
            this.ETAT_USER_.HeaderText = "Bloqué?";
            this.ETAT_USER_.Name = "ETAT_USER_";
            this.ETAT_USER_.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recherche :";
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(731, 48);
            this.entete_Formulaire_21.TabIndex = 1;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 332);
            this.chM_CMP_CONTROL1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "UTILISATEUR";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(386, 332);
            this.gridControl1.TabIndex = 3;
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
            this.colCODE_USER,
            this.colNOM_USER,
            this.colPRENOM_USER,
            this.colPHOTO_USER,
            this.colLOGIN_USER,
            this.colPASSWORD_USER,
            this.colETAT_USER,
            this.colCODE_SOCIETE,
            this.colCODE_FONCTION_USER,
            this.colLIB_FONCTION_USER,
            this.colRS_SOCIETE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de groupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colCODE_USER
            // 
            this.colCODE_USER.FieldName = "CODE_USER";
            this.colCODE_USER.Name = "colCODE_USER";
            this.colCODE_USER.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colCODE_USER.Visible = true;
            this.colCODE_USER.VisibleIndex = 0;
            // 
            // colNOM_USER
            // 
            this.colNOM_USER.FieldName = "NOM_USER";
            this.colNOM_USER.Name = "colNOM_USER";
            this.colNOM_USER.Visible = true;
            this.colNOM_USER.VisibleIndex = 1;
            // 
            // colPRENOM_USER
            // 
            this.colPRENOM_USER.FieldName = "PRENOM_USER";
            this.colPRENOM_USER.Name = "colPRENOM_USER";
            this.colPRENOM_USER.Visible = true;
            this.colPRENOM_USER.VisibleIndex = 2;
            // 
            // colPHOTO_USER
            // 
            this.colPHOTO_USER.FieldName = "PHOTO_USER";
            this.colPHOTO_USER.Name = "colPHOTO_USER";
            // 
            // colLOGIN_USER
            // 
            this.colLOGIN_USER.FieldName = "LOGIN_USER";
            this.colLOGIN_USER.Name = "colLOGIN_USER";
            this.colLOGIN_USER.Visible = true;
            this.colLOGIN_USER.VisibleIndex = 3;
            // 
            // colPASSWORD_USER
            // 
            this.colPASSWORD_USER.ColumnEdit = this.repositoryItemTextEdit1;
            this.colPASSWORD_USER.FieldName = "PASSWORD_USER";
            this.colPASSWORD_USER.Name = "colPASSWORD_USER";
            this.colPASSWORD_USER.Visible = true;
            this.colPASSWORD_USER.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.PasswordChar = '*';
            // 
            // colETAT_USER
            // 
            this.colETAT_USER.FieldName = "ETAT_USER";
            this.colETAT_USER.Name = "colETAT_USER";
            this.colETAT_USER.Visible = true;
            this.colETAT_USER.VisibleIndex = 5;
            // 
            // colCODE_SOCIETE
            // 
            this.colCODE_SOCIETE.FieldName = "CODE_SOCIETE";
            this.colCODE_SOCIETE.Name = "colCODE_SOCIETE";
            // 
            // colCODE_FONCTION_USER
            // 
            this.colCODE_FONCTION_USER.FieldName = "CODE_FONCTION_USER";
            this.colCODE_FONCTION_USER.Name = "colCODE_FONCTION_USER";
            // 
            // colLIB_FONCTION_USER
            // 
            this.colLIB_FONCTION_USER.FieldName = "LIB_FONCTION_USER";
            this.colLIB_FONCTION_USER.Name = "colLIB_FONCTION_USER";
            this.colLIB_FONCTION_USER.Visible = true;
            this.colLIB_FONCTION_USER.VisibleIndex = 6;
            // 
            // colRS_SOCIETE
            // 
            this.colRS_SOCIETE.FieldName = "RS_SOCIETE";
            this.colRS_SOCIETE.Name = "colRS_SOCIETE";
            this.colRS_SOCIETE.Visible = true;
            this.colRS_SOCIETE.VisibleIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(531, 48);
            this.panelControl1.MaximumSize = new System.Drawing.Size(200, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 332);
            this.panelControl1.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(19, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(163, 182);
            this.pictureEdit1.TabIndex = 0;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(526, 48);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 332);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // CHM_LISTE_UTILISATEURS
            // 
            this.ClientSize = new System.Drawing.Size(731, 380);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_LISTE_UTILISATEURS";
            this.Text = "Liste des utilisateurs";
            this.MENU_UTILISATEUR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_UTILISATEUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MENU_UTILISATEUR;
        private System.Windows.Forms.ToolStripMenuItem MENU_NOUVEAU;
        private System.Windows.Forms.ToolStripMenuItem MENU_MODIFIER;
        private System.Windows.Forms.ToolStripMenuItem MENU_SUPPRIMER;
        private System.Windows.Forms.TextBox RECHERCHE_UTILISATEUR;
        private System.Windows.Forms.DataGridView dgv_LISTE_UTILISATEUR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_USER_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGIN_USER_;
        private System.Windows.Forms.DataGridViewTextBoxColumn FONCTION_;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_societe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ETAT_USER_;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colPRENOM_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colPHOTO_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGIN_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD_USER;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colETAT_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_SOCIETE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FONCTION_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colLIB_FONCTION_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_SOCIETE;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}