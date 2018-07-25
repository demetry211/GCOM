namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_FACTURES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_FACTURES));
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.BTN_APERçU = new System.Windows.Forms.Button();
            this.BTN_REGELEMENT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet11 = new CHM_CLIENT_APP.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_HT_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAUX_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_BASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIMBRE_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TOTAL_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_LETTRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANNULATION_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREGLER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREDIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGASIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRENOM_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_UTILISATEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.ForeColor = System.Drawing.Color.Black;
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(9, 93);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(107, 43);
            this.BTN_AJOUTER.TabIndex = 88;
            this.BTN_AJOUTER.Text = "Ajouter";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.BTN_AJOUTER_Click);
            // 
            // BTN_APERçU
            // 
            this.BTN_APERçU.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_APERçU.Image = global::CHM_CLIENT_APP.Properties.Resources.filefind_icone_7697_32;
            this.BTN_APERçU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_APERçU.Location = new System.Drawing.Point(9, 191);
            this.BTN_APERçU.Name = "BTN_APERçU";
            this.BTN_APERçU.Size = new System.Drawing.Size(107, 43);
            this.BTN_APERçU.TabIndex = 92;
            this.BTN_APERçU.Text = "Aperçu";
            this.BTN_APERçU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_APERçU.UseVisualStyleBackColor = false;
            this.BTN_APERçU.Click += new System.EventHandler(this.BTN_APERçU_Click);
            // 
            // BTN_REGELEMENT
            // 
            this.BTN_REGELEMENT.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_REGELEMENT.Image = global::CHM_CLIENT_APP.Properties.Resources.daffaires_monnaies_dolar_metal_argent_paiement_icone_3854_32;
            this.BTN_REGELEMENT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_REGELEMENT.Location = new System.Drawing.Point(9, 240);
            this.BTN_REGELEMENT.Name = "BTN_REGELEMENT";
            this.BTN_REGELEMENT.Size = new System.Drawing.Size(107, 43);
            this.BTN_REGELEMENT.TabIndex = 91;
            this.BTN_REGELEMENT.Text = "Règlement";
            this.BTN_REGELEMENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_REGELEMENT.UseVisualStyleBackColor = false;
            this.BTN_REGELEMENT.Click += new System.EventHandler(this.BTN_REGELEMENT_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 43);
            this.button2.TabIndex = 91;
            this.button2.Text = "Afficher";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(868, 48);
            this.entete_Formulaire_21.TabIndex = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "FACTURE";
            this.gridControl1.DataSource = this.dataSet11;
            this.gridControl1.Location = new System.Drawing.Point(122, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(743, 391);
            this.gridControl1.TabIndex = 95;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_FACTURE,
            this.colDATE_FACTURE,
            this.colCODE_CLIENT,
            this.colMONTANT_HT_FACTURE,
            this.colMONTANT_TVA,
            this.colMONTANT_TTC,
            this.colTAUX_REMISE,
            this.colMONTANT_BASE,
            this.colTIMBRE_FACTURE,
            this.colMONTANT_TOTAL_FACTURE,
            this.colMONTANT_LETTRE,
            this.colANNULATION_FACTURE,
            this.colREGLER,
            this.colCREDIT,
            this.colMAGASIN,
            this.colCODE_USER,
            this.colPRENOM_USER,
            this.colNOM_USER,
            this.colREMARQUE,
            this.colREMISE,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colNOM_UTILISATEUR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de regroupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDATE_FACTURE, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colCODE_FACTURE
            // 
            this.colCODE_FACTURE.FieldName = "CODE_FACTURE";
            this.colCODE_FACTURE.Name = "colCODE_FACTURE";
            this.colCODE_FACTURE.Visible = true;
            this.colCODE_FACTURE.VisibleIndex = 0;
            this.colCODE_FACTURE.Width = 84;
            // 
            // colDATE_FACTURE
            // 
            this.colDATE_FACTURE.FieldName = "DATE_FACTURE";
            this.colDATE_FACTURE.Name = "colDATE_FACTURE";
            this.colDATE_FACTURE.Visible = true;
            this.colDATE_FACTURE.VisibleIndex = 15;
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
            // 
            // colMONTANT_HT_FACTURE
            // 
            this.colMONTANT_HT_FACTURE.FieldName = "MONTANT_HT_FACTURE";
            this.colMONTANT_HT_FACTURE.Name = "colMONTANT_HT_FACTURE";
            this.colMONTANT_HT_FACTURE.Visible = true;
            this.colMONTANT_HT_FACTURE.VisibleIndex = 2;
            this.colMONTANT_HT_FACTURE.Width = 78;
            // 
            // colMONTANT_TVA
            // 
            this.colMONTANT_TVA.FieldName = "MONTANT_TVA";
            this.colMONTANT_TVA.Name = "colMONTANT_TVA";
            this.colMONTANT_TVA.Visible = true;
            this.colMONTANT_TVA.VisibleIndex = 3;
            this.colMONTANT_TVA.Width = 67;
            // 
            // colMONTANT_TTC
            // 
            this.colMONTANT_TTC.FieldName = "MONTANT_TTC";
            this.colMONTANT_TTC.Name = "colMONTANT_TTC";
            this.colMONTANT_TTC.Visible = true;
            this.colMONTANT_TTC.VisibleIndex = 4;
            this.colMONTANT_TTC.Width = 67;
            // 
            // colTAUX_REMISE
            // 
            this.colTAUX_REMISE.FieldName = "TAUX_REMISE";
            this.colTAUX_REMISE.Name = "colTAUX_REMISE";
            this.colTAUX_REMISE.Visible = true;
            this.colTAUX_REMISE.VisibleIndex = 5;
            this.colTAUX_REMISE.Width = 67;
            // 
            // colMONTANT_BASE
            // 
            this.colMONTANT_BASE.FieldName = "MONTANT_BASE";
            this.colMONTANT_BASE.Name = "colMONTANT_BASE";
            this.colMONTANT_BASE.Visible = true;
            this.colMONTANT_BASE.VisibleIndex = 7;
            this.colMONTANT_BASE.Width = 71;
            // 
            // colTIMBRE_FACTURE
            // 
            this.colTIMBRE_FACTURE.FieldName = "TIMBRE_FACTURE";
            this.colTIMBRE_FACTURE.Name = "colTIMBRE_FACTURE";
            this.colTIMBRE_FACTURE.Visible = true;
            this.colTIMBRE_FACTURE.VisibleIndex = 8;
            this.colTIMBRE_FACTURE.Width = 65;
            // 
            // colMONTANT_TOTAL_FACTURE
            // 
            this.colMONTANT_TOTAL_FACTURE.FieldName = "MONTANT_TOTAL_FACTURE";
            this.colMONTANT_TOTAL_FACTURE.Name = "colMONTANT_TOTAL_FACTURE";
            this.colMONTANT_TOTAL_FACTURE.Visible = true;
            this.colMONTANT_TOTAL_FACTURE.VisibleIndex = 9;
            this.colMONTANT_TOTAL_FACTURE.Width = 96;
            // 
            // colMONTANT_LETTRE
            // 
            this.colMONTANT_LETTRE.FieldName = "MONTANT_LETTRE";
            this.colMONTANT_LETTRE.Name = "colMONTANT_LETTRE";
            // 
            // colANNULATION_FACTURE
            // 
            this.colANNULATION_FACTURE.FieldName = "ANNULATION_FACTURE";
            this.colANNULATION_FACTURE.Name = "colANNULATION_FACTURE";
            this.colANNULATION_FACTURE.Visible = true;
            this.colANNULATION_FACTURE.VisibleIndex = 13;
            this.colANNULATION_FACTURE.Width = 52;
            // 
            // colREGLER
            // 
            this.colREGLER.FieldName = "REGLER";
            this.colREGLER.Name = "colREGLER";
            this.colREGLER.Visible = true;
            this.colREGLER.VisibleIndex = 10;
            this.colREGLER.Width = 62;
            // 
            // colCREDIT
            // 
            this.colCREDIT.FieldName = "CREDIT";
            this.colCREDIT.Name = "colCREDIT";
            this.colCREDIT.Visible = true;
            this.colCREDIT.VisibleIndex = 11;
            this.colCREDIT.Width = 62;
            // 
            // colMAGASIN
            // 
            this.colMAGASIN.FieldName = "MAGASIN";
            this.colMAGASIN.Name = "colMAGASIN";
            // 
            // colCODE_USER
            // 
            this.colCODE_USER.FieldName = "CODE_USER";
            this.colCODE_USER.Name = "colCODE_USER";
            // 
            // colPRENOM_USER
            // 
            this.colPRENOM_USER.FieldName = "PRENOM_USER";
            this.colPRENOM_USER.Name = "colPRENOM_USER";
            // 
            // colNOM_USER
            // 
            this.colNOM_USER.FieldName = "NOM_USER";
            this.colNOM_USER.Name = "colNOM_USER";
            // 
            // colREMARQUE
            // 
            this.colREMARQUE.FieldName = "REMARQUE";
            this.colREMARQUE.Name = "colREMARQUE";
            this.colREMARQUE.Visible = true;
            this.colREMARQUE.VisibleIndex = 12;
            this.colREMARQUE.Width = 62;
            // 
            // colREMISE
            // 
            this.colREMISE.FieldName = "REMISE";
            this.colREMISE.Name = "colREMISE";
            this.colREMISE.Visible = true;
            this.colREMISE.VisibleIndex = 6;
            this.colREMISE.Width = 63;
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
            this.colRS_CLIENT.VisibleIndex = 1;
            this.colRS_CLIENT.Width = 155;
            // 
            // colNOM_UTILISATEUR
            // 
            this.colNOM_UTILISATEUR.FieldName = "NOM_UTILISATEUR";
            this.colNOM_UTILISATEUR.Name = "colNOM_UTILISATEUR";
            this.colNOM_UTILISATEUR.OptionsColumn.ReadOnly = true;
            this.colNOM_UTILISATEUR.Visible = true;
            this.colNOM_UTILISATEUR.VisibleIndex = 14;
            this.colNOM_UTILISATEUR.Width = 129;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.Print_32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 92;
            this.button1.Text = "Imprimer Liste";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CHM_LISTE_FACTURES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 448);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_APERçU);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_REGELEMENT);
            this.Controls.Add(this.BTN_AJOUTER);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_LISTE_FACTURES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Factures Client";
            this.Shown += new System.EventHandler(this.CHM_LISTE_FACTURES_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_FACTURES_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button BTN_APERçU;
        private System.Windows.Forms.Button BTN_REGELEMENT;
        private System.Windows.Forms.Button button2;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DataSet1 dataSet11;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_HT_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTAUX_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_BASE;
        private DevExpress.XtraGrid.Columns.GridColumn colTIMBRE_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TOTAL_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_LETTRE;
        private DevExpress.XtraGrid.Columns.GridColumn colANNULATION_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colREGLER;
        private DevExpress.XtraGrid.Columns.GridColumn colCREDIT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGASIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colPRENOM_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colREMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_UTILISATEUR;
        private System.Windows.Forms.Button button1;
    }
}