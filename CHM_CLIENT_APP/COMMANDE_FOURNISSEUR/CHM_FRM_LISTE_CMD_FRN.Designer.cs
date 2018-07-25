namespace CHM_CLIENT_APP.COMMANDE_FOURNISSEUR
{
    partial class CHM_FRM_LISTE_CMD_FRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_CMD_FRN));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_COMMANDE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_COMMANDE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIORITE_COMMANDE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_TVA_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANNEE_CMDFR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOIS_CMDFR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_MAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_LIVRAISON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_CONTACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_VALIDATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBR_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNBR_ARTICLE_LIVRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_VALIDATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_VALIDATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALIDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ETAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chbxToutes = new System.Windows.Forms.RadioButton();
            this.chbxEnAttente = new System.Windows.Forms.RadioButton();
            this.chbxNonLivrees = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(803, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 406);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_CMD_FR";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 83);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(663, 371);
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
            this.colCODE_COMMANDE_FOURNISSEUR,
            this.colDATE_COMMANDE_FOURNISSEUR,
            this.colCODE_USER,
            this.colPRIORITE_COMMANDE_FOURNISSEUR,
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR,
            this.colCODE_FOURNISSEUR,
            this.colREF_FOURNISSEUR,
            this.colRS_FOURNISSEUR,
            this.colADRESSE_FOURNISSEUR,
            this.colTEL_FOURNISSEUR,
            this.colFAX_FOURNISSEUR,
            this.colCODE_TVA_FOURNISSEUR,
            this.colANNEE_CMDFR,
            this.colMOIS_CMDFR,
            this.colCODE_MAG,
            this.colNOM_MAG,
            this.colADRESSE_MAG,
            this.colTEL_MAG,
            this.colADRESSE_LIVRAISON,
            this.colCONTACT,
            this.colTEL_CONTACT,
            this.colREMARQUE,
            this.colDATE_VALIDATION,
            this.colNBR_ARTICLE,
            this.colNBR_ARTICLE_LIVRES,
            this.colUSER_VALIDATION,
            this.colUTILISATEUR_VALIDATION,
            this.colVALIDE,
            this.ETAT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de regroupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colCODE_COMMANDE_FOURNISSEUR
            // 
            this.colCODE_COMMANDE_FOURNISSEUR.FieldName = "CODE_COMMANDE_FOURNISSEUR";
            this.colCODE_COMMANDE_FOURNISSEUR.Name = "colCODE_COMMANDE_FOURNISSEUR";
            this.colCODE_COMMANDE_FOURNISSEUR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colCODE_COMMANDE_FOURNISSEUR.Visible = true;
            this.colCODE_COMMANDE_FOURNISSEUR.VisibleIndex = 0;
            this.colCODE_COMMANDE_FOURNISSEUR.Width = 95;
            // 
            // colDATE_COMMANDE_FOURNISSEUR
            // 
            this.colDATE_COMMANDE_FOURNISSEUR.FieldName = "DATE_COMMANDE_FOURNISSEUR";
            this.colDATE_COMMANDE_FOURNISSEUR.Name = "colDATE_COMMANDE_FOURNISSEUR";
            this.colDATE_COMMANDE_FOURNISSEUR.Visible = true;
            this.colDATE_COMMANDE_FOURNISSEUR.VisibleIndex = 1;
            this.colDATE_COMMANDE_FOURNISSEUR.Width = 92;
            // 
            // colCODE_USER
            // 
            this.colCODE_USER.FieldName = "CODE_USER";
            this.colCODE_USER.Name = "colCODE_USER";
            // 
            // colPRIORITE_COMMANDE_FOURNISSEUR
            // 
            this.colPRIORITE_COMMANDE_FOURNISSEUR.FieldName = "PRIORITE_COMMANDE_FOURNISSEUR";
            this.colPRIORITE_COMMANDE_FOURNISSEUR.Name = "colPRIORITE_COMMANDE_FOURNISSEUR";
            this.colPRIORITE_COMMANDE_FOURNISSEUR.Visible = true;
            this.colPRIORITE_COMMANDE_FOURNISSEUR.VisibleIndex = 2;
            this.colPRIORITE_COMMANDE_FOURNISSEUR.Width = 73;
            // 
            // colDATE_EXPIRATION_COMMANDE_FOURNISSEUR
            // 
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR.FieldName = "DATE_EXPIRATION_COMMANDE_FOURNISSEUR";
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR.Name = "colDATE_EXPIRATION_COMMANDE_FOURNISSEUR";
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR.Visible = true;
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR.VisibleIndex = 3;
            this.colDATE_EXPIRATION_COMMANDE_FOURNISSEUR.Width = 95;
            // 
            // colCODE_FOURNISSEUR
            // 
            this.colCODE_FOURNISSEUR.FieldName = "CODE_FOURNISSEUR";
            this.colCODE_FOURNISSEUR.Name = "colCODE_FOURNISSEUR";
            // 
            // colREF_FOURNISSEUR
            // 
            this.colREF_FOURNISSEUR.FieldName = "REF_FOURNISSEUR";
            this.colREF_FOURNISSEUR.Name = "colREF_FOURNISSEUR";
            this.colREF_FOURNISSEUR.Width = 95;
            // 
            // colRS_FOURNISSEUR
            // 
            this.colRS_FOURNISSEUR.FieldName = "RS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Name = "colRS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Visible = true;
            this.colRS_FOURNISSEUR.VisibleIndex = 4;
            this.colRS_FOURNISSEUR.Width = 101;
            // 
            // colADRESSE_FOURNISSEUR
            // 
            this.colADRESSE_FOURNISSEUR.FieldName = "ADRESSE_FOURNISSEUR";
            this.colADRESSE_FOURNISSEUR.Name = "colADRESSE_FOURNISSEUR";
            // 
            // colTEL_FOURNISSEUR
            // 
            this.colTEL_FOURNISSEUR.FieldName = "TEL_FOURNISSEUR";
            this.colTEL_FOURNISSEUR.Name = "colTEL_FOURNISSEUR";
            // 
            // colFAX_FOURNISSEUR
            // 
            this.colFAX_FOURNISSEUR.FieldName = "FAX_FOURNISSEUR";
            this.colFAX_FOURNISSEUR.Name = "colFAX_FOURNISSEUR";
            // 
            // colCODE_TVA_FOURNISSEUR
            // 
            this.colCODE_TVA_FOURNISSEUR.FieldName = "CODE_TVA_FOURNISSEUR";
            this.colCODE_TVA_FOURNISSEUR.Name = "colCODE_TVA_FOURNISSEUR";
            this.colCODE_TVA_FOURNISSEUR.Visible = true;
            this.colCODE_TVA_FOURNISSEUR.VisibleIndex = 5;
            this.colCODE_TVA_FOURNISSEUR.Width = 101;
            // 
            // colANNEE_CMDFR
            // 
            this.colANNEE_CMDFR.FieldName = "ANNEE_CMDFR";
            this.colANNEE_CMDFR.Name = "colANNEE_CMDFR";
            // 
            // colMOIS_CMDFR
            // 
            this.colMOIS_CMDFR.FieldName = "MOIS_CMDFR";
            this.colMOIS_CMDFR.Name = "colMOIS_CMDFR";
            // 
            // colCODE_MAG
            // 
            this.colCODE_MAG.FieldName = "CODE_MAG";
            this.colCODE_MAG.Name = "colCODE_MAG";
            // 
            // colNOM_MAG
            // 
            this.colNOM_MAG.FieldName = "NOM_MAG";
            this.colNOM_MAG.Name = "colNOM_MAG";
            this.colNOM_MAG.Visible = true;
            this.colNOM_MAG.VisibleIndex = 6;
            this.colNOM_MAG.Width = 101;
            // 
            // colADRESSE_MAG
            // 
            this.colADRESSE_MAG.FieldName = "ADRESSE_MAG";
            this.colADRESSE_MAG.Name = "colADRESSE_MAG";
            // 
            // colTEL_MAG
            // 
            this.colTEL_MAG.FieldName = "TEL_MAG";
            this.colTEL_MAG.Name = "colTEL_MAG";
            // 
            // colADRESSE_LIVRAISON
            // 
            this.colADRESSE_LIVRAISON.FieldName = "ADRESSE_LIVRAISON";
            this.colADRESSE_LIVRAISON.Name = "colADRESSE_LIVRAISON";
            // 
            // colCONTACT
            // 
            this.colCONTACT.FieldName = "CONTACT";
            this.colCONTACT.Name = "colCONTACT";
            this.colCONTACT.Visible = true;
            this.colCONTACT.VisibleIndex = 7;
            this.colCONTACT.Width = 101;
            // 
            // colTEL_CONTACT
            // 
            this.colTEL_CONTACT.FieldName = "TEL_CONTACT";
            this.colTEL_CONTACT.Name = "colTEL_CONTACT";
            this.colTEL_CONTACT.Visible = true;
            this.colTEL_CONTACT.VisibleIndex = 8;
            this.colTEL_CONTACT.Width = 101;
            // 
            // colREMARQUE
            // 
            this.colREMARQUE.FieldName = "REMARQUE";
            this.colREMARQUE.Name = "colREMARQUE";
            this.colREMARQUE.Visible = true;
            this.colREMARQUE.VisibleIndex = 9;
            this.colREMARQUE.Width = 101;
            // 
            // colDATE_VALIDATION
            // 
            this.colDATE_VALIDATION.FieldName = "DATE_VALIDATION";
            this.colDATE_VALIDATION.Name = "colDATE_VALIDATION";
            this.colDATE_VALIDATION.Visible = true;
            this.colDATE_VALIDATION.VisibleIndex = 10;
            this.colDATE_VALIDATION.Width = 101;
            // 
            // colNBR_ARTICLE
            // 
            this.colNBR_ARTICLE.FieldName = "NBR_ARTICLE";
            this.colNBR_ARTICLE.Name = "colNBR_ARTICLE";
            // 
            // colNBR_ARTICLE_LIVRES
            // 
            this.colNBR_ARTICLE_LIVRES.Caption = "Nbr Articles Livrés";
            this.colNBR_ARTICLE_LIVRES.FieldName = "NBR_ARTICLE_LIVRES";
            this.colNBR_ARTICLE_LIVRES.Name = "colNBR_ARTICLE_LIVRES";
            // 
            // colUSER_VALIDATION
            // 
            this.colUSER_VALIDATION.FieldName = "USER_VALIDATION";
            this.colUSER_VALIDATION.Name = "colUSER_VALIDATION";
            // 
            // colUTILISATEUR_VALIDATION
            // 
            this.colUTILISATEUR_VALIDATION.FieldName = "UTILISATEUR_VALIDATION";
            this.colUTILISATEUR_VALIDATION.Name = "colUTILISATEUR_VALIDATION";
            this.colUTILISATEUR_VALIDATION.Visible = true;
            this.colUTILISATEUR_VALIDATION.VisibleIndex = 11;
            this.colUTILISATEUR_VALIDATION.Width = 101;
            // 
            // colVALIDE
            // 
            this.colVALIDE.FieldName = "VALIDE";
            this.colVALIDE.Name = "colVALIDE";
            this.colVALIDE.Visible = true;
            this.colVALIDE.VisibleIndex = 12;
            this.colVALIDE.Width = 43;
            // 
            // ETAT
            // 
            this.ETAT.Caption = "Etat";
            this.ETAT.FieldName = "gridColumn1";
            this.ETAT.Name = "ETAT";
            this.ETAT.UnboundExpression = resources.GetString("ETAT.UnboundExpression");
            this.ETAT.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ETAT.Visible = true;
            this.ETAT.VisibleIndex = 13;
            this.ETAT.Width = 208;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chbxToutes);
            this.panelControl1.Controls.Add(this.chbxEnAttente);
            this.panelControl1.Controls.Add(this.chbxNonLivrees);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(140, 48);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(663, 35);
            this.panelControl1.TabIndex = 3;
            // 
            // chbxToutes
            // 
            this.chbxToutes.AutoSize = true;
            this.chbxToutes.Location = new System.Drawing.Point(302, 12);
            this.chbxToutes.Name = "chbxToutes";
            this.chbxToutes.Size = new System.Drawing.Size(134, 17);
            this.chbxToutes.TabIndex = 0;
            this.chbxToutes.TabStop = true;
            this.chbxToutes.Text = "Toutes les commandes";
            this.chbxToutes.UseVisualStyleBackColor = true;
            this.chbxToutes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // chbxEnAttente
            // 
            this.chbxEnAttente.AutoSize = true;
            this.chbxEnAttente.Location = new System.Drawing.Point(6, 12);
            this.chbxEnAttente.Name = "chbxEnAttente";
            this.chbxEnAttente.Size = new System.Drawing.Size(137, 17);
            this.chbxEnAttente.TabIndex = 0;
            this.chbxEnAttente.TabStop = true;
            this.chbxEnAttente.Text = "En attente de validation";
            this.chbxEnAttente.UseVisualStyleBackColor = true;
            this.chbxEnAttente.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // chbxNonLivrees
            // 
            this.chbxNonLivrees.AutoSize = true;
            this.chbxNonLivrees.Location = new System.Drawing.Point(188, 12);
            this.chbxNonLivrees.Name = "chbxNonLivrees";
            this.chbxNonLivrees.Size = new System.Drawing.Size(78, 17);
            this.chbxNonLivrees.TabIndex = 0;
            this.chbxNonLivrees.TabStop = true;
            this.chbxNonLivrees.Text = "Non livrées";
            this.chbxNonLivrees.UseVisualStyleBackColor = true;
            this.chbxNonLivrees.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CHM_FRM_LISTE_CMD_FRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 454);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_CMD_FRN";
            this.Text = "Liste des Commandes d\'achat";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_CMD_FRN_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_COMMANDE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_COMMANDE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIORITE_COMMANDE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_EXPIRATION_COMMANDE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colANNEE_CMDFR;
        private DevExpress.XtraGrid.Columns.GridColumn colMOIS_CMDFR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_MAG;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_LIVRAISON;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_CONTACT;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_VALIDATION;
        private DevExpress.XtraGrid.Columns.GridColumn colNBR_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colNBR_ARTICLE_LIVRES;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_VALIDATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_VALIDATION;
        private DevExpress.XtraGrid.Columns.GridColumn colVALIDE;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton chbxToutes;
        private System.Windows.Forms.RadioButton chbxNonLivrees;
        private System.Windows.Forms.RadioButton chbxEnAttente;
        private DevExpress.XtraGrid.Columns.GridColumn ETAT;
    }
}