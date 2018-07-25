namespace CHM_CLIENT_APP.CHM_DEVI
{
    partial class CHM_FRM_LISTE_DEVIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_DEVIS));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_DC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_DC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_VALIDITE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_TVA_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODE_PAIEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOBSERVATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_CREATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_UTILISATEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_CREATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESPONSABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNB_IMPRIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_REMISE_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_REMISE_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(657, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 336);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_DC";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(517, 336);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_DC,
            this.colDATE_DC,
            this.colDATE_VALIDITE,
            this.colCODE_CLIENT,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colADRESSE_CLIENT,
            this.colCP_CLIENT,
            this.colTEL_CLIENT,
            this.colFAX_CLIENT,
            this.colCODE_TVA_CLIENT,
            this.colMODE_PAIEMENT,
            this.colOBSERVATION,
            this.colUTILISATEUR_CREATION,
            this.colNOM_UTILISATEUR,
            this.colDATE_CREATION,
            this.colRESPONSABLE,
            this.colNB_IMPRIME,
            this.colMONTANT_HT,
            this.colMONTANT_REMISE_HT,
            this.colMONTANT_REMISE_TTC,
            this.colMONTANT_TVA,
            this.colMONTANT_TTC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de regroupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCODE_DC
            // 
            this.colCODE_DC.FieldName = "CODE_DC";
            this.colCODE_DC.Name = "colCODE_DC";
            this.colCODE_DC.Visible = true;
            this.colCODE_DC.VisibleIndex = 0;
            this.colCODE_DC.Width = 95;
            // 
            // colDATE_DC
            // 
            this.colDATE_DC.FieldName = "DATE_DC";
            this.colDATE_DC.Name = "colDATE_DC";
            this.colDATE_DC.Visible = true;
            this.colDATE_DC.VisibleIndex = 1;
            this.colDATE_DC.Width = 94;
            // 
            // colDATE_VALIDITE
            // 
            this.colDATE_VALIDITE.FieldName = "DATE_VALIDITE";
            this.colDATE_VALIDITE.Name = "colDATE_VALIDITE";
            this.colDATE_VALIDITE.Visible = true;
            this.colDATE_VALIDITE.VisibleIndex = 2;
            this.colDATE_VALIDITE.Width = 100;
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
            this.colCODE_CLIENT.Width = 43;
            // 
            // colREF_CLIENT
            // 
            this.colREF_CLIENT.FieldName = "REF_CLIENT";
            this.colREF_CLIENT.Name = "colREF_CLIENT";
            this.colREF_CLIENT.Visible = true;
            this.colREF_CLIENT.VisibleIndex = 3;
            this.colREF_CLIENT.Width = 82;
            // 
            // colRS_CLIENT
            // 
            this.colRS_CLIENT.FieldName = "RS_CLIENT";
            this.colRS_CLIENT.Name = "colRS_CLIENT";
            this.colRS_CLIENT.Visible = true;
            this.colRS_CLIENT.VisibleIndex = 4;
            this.colRS_CLIENT.Width = 203;
            // 
            // colADRESSE_CLIENT
            // 
            this.colADRESSE_CLIENT.FieldName = "ADRESSE_CLIENT";
            this.colADRESSE_CLIENT.Name = "colADRESSE_CLIENT";
            this.colADRESSE_CLIENT.Width = 43;
            // 
            // colCP_CLIENT
            // 
            this.colCP_CLIENT.FieldName = "CP_CLIENT";
            this.colCP_CLIENT.Name = "colCP_CLIENT";
            this.colCP_CLIENT.Width = 43;
            // 
            // colTEL_CLIENT
            // 
            this.colTEL_CLIENT.FieldName = "TEL_CLIENT";
            this.colTEL_CLIENT.Name = "colTEL_CLIENT";
            this.colTEL_CLIENT.Width = 43;
            // 
            // colFAX_CLIENT
            // 
            this.colFAX_CLIENT.FieldName = "FAX_CLIENT";
            this.colFAX_CLIENT.Name = "colFAX_CLIENT";
            this.colFAX_CLIENT.Width = 43;
            // 
            // colCODE_TVA_CLIENT
            // 
            this.colCODE_TVA_CLIENT.FieldName = "CODE_TVA_CLIENT";
            this.colCODE_TVA_CLIENT.Name = "colCODE_TVA_CLIENT";
            this.colCODE_TVA_CLIENT.Width = 43;
            // 
            // colMODE_PAIEMENT
            // 
            this.colMODE_PAIEMENT.FieldName = "MODE_PAIEMENT";
            this.colMODE_PAIEMENT.Name = "colMODE_PAIEMENT";
            this.colMODE_PAIEMENT.Width = 43;
            // 
            // colOBSERVATION
            // 
            this.colOBSERVATION.FieldName = "OBSERVATION";
            this.colOBSERVATION.Name = "colOBSERVATION";
            this.colOBSERVATION.Width = 43;
            // 
            // colUTILISATEUR_CREATION
            // 
            this.colUTILISATEUR_CREATION.FieldName = "UTILISATEUR_CREATION";
            this.colUTILISATEUR_CREATION.Name = "colUTILISATEUR_CREATION";
            this.colUTILISATEUR_CREATION.Width = 43;
            // 
            // colNOM_UTILISATEUR
            // 
            this.colNOM_UTILISATEUR.FieldName = "NOM_UTILISATEUR";
            this.colNOM_UTILISATEUR.Name = "colNOM_UTILISATEUR";
            this.colNOM_UTILISATEUR.OptionsColumn.ReadOnly = true;
            this.colNOM_UTILISATEUR.Visible = true;
            this.colNOM_UTILISATEUR.VisibleIndex = 11;
            this.colNOM_UTILISATEUR.Width = 79;
            // 
            // colDATE_CREATION
            // 
            this.colDATE_CREATION.FieldName = "DATE_CREATION";
            this.colDATE_CREATION.Name = "colDATE_CREATION";
            this.colDATE_CREATION.Width = 43;
            // 
            // colRESPONSABLE
            // 
            this.colRESPONSABLE.FieldName = "RESPONSABLE";
            this.colRESPONSABLE.Name = "colRESPONSABLE";
            this.colRESPONSABLE.Visible = true;
            this.colRESPONSABLE.VisibleIndex = 5;
            this.colRESPONSABLE.Width = 63;
            // 
            // colNB_IMPRIME
            // 
            this.colNB_IMPRIME.FieldName = "NB_IMPRIME";
            this.colNB_IMPRIME.Name = "colNB_IMPRIME";
            this.colNB_IMPRIME.Width = 43;
            // 
            // colMONTANT_HT
            // 
            this.colMONTANT_HT.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_HT.FieldName = "MONTANT_HT";
            this.colMONTANT_HT.Name = "colMONTANT_HT";
            this.colMONTANT_HT.Visible = true;
            this.colMONTANT_HT.VisibleIndex = 6;
            this.colMONTANT_HT.Width = 81;
            // 
            // colMONTANT_REMISE_HT
            // 
            this.colMONTANT_REMISE_HT.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_REMISE_HT.FieldName = "MONTANT_REMISE_HT";
            this.colMONTANT_REMISE_HT.Name = "colMONTANT_REMISE_HT";
            this.colMONTANT_REMISE_HT.Visible = true;
            this.colMONTANT_REMISE_HT.VisibleIndex = 7;
            this.colMONTANT_REMISE_HT.Width = 100;
            // 
            // colMONTANT_REMISE_TTC
            // 
            this.colMONTANT_REMISE_TTC.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_REMISE_TTC.FieldName = "MONTANT_REMISE_TTC";
            this.colMONTANT_REMISE_TTC.Name = "colMONTANT_REMISE_TTC";
            this.colMONTANT_REMISE_TTC.Visible = true;
            this.colMONTANT_REMISE_TTC.VisibleIndex = 8;
            this.colMONTANT_REMISE_TTC.Width = 76;
            // 
            // colMONTANT_TVA
            // 
            this.colMONTANT_TVA.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_TVA.FieldName = "MONTANT_TVA";
            this.colMONTANT_TVA.Name = "colMONTANT_TVA";
            this.colMONTANT_TVA.Visible = true;
            this.colMONTANT_TVA.VisibleIndex = 9;
            this.colMONTANT_TVA.Width = 79;
            // 
            // colMONTANT_TTC
            // 
            this.colMONTANT_TTC.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_TTC.FieldName = "MONTANT_TTC";
            this.colMONTANT_TTC.Name = "colMONTANT_TTC";
            this.colMONTANT_TTC.Visible = true;
            this.colMONTANT_TTC.VisibleIndex = 10;
            this.colMONTANT_TTC.Width = 128;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // CHM_FRM_LISTE_DEVIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 384);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_DEVIS";
            this.Text = "Liste des devis de vente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_DEVIS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_DC;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_DC;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_VALIDITE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCP_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colMODE_PAIEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colOBSERVATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_CREATION;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_UTILISATEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_CREATION;
        private DevExpress.XtraGrid.Columns.GridColumn colRESPONSABLE;
        private DevExpress.XtraGrid.Columns.GridColumn colNB_IMPRIME;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_REMISE_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_REMISE_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TTC;
    }
}