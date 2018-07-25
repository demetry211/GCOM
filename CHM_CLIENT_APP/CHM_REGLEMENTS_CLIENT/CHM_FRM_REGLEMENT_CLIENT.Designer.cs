namespace CHM_CLIENT_APP.CHM_REGLEMENT
{
    partial class CHM_FRM_REGLEMENT_CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_REGLEMENT_CLIENT));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_REGLEMENT_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_REG_CLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODE_REGLEMENT_CLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_REG_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUM_PIECE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANQUE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOBSERVATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_COMPTE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE_PIECE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
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
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.daffaires_monnaies_dolar_metal_argent_paiement_icone_3854_481;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(598, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "REGLEMENT_CLIENT";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(458, 338);
            this.gridControl1.TabIndex = 1;
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
            this.colCODE_REGLEMENT_CLIENT,
            this.colCODE_FACTURE,
            this.colDATE_REG_CLT,
            this.colMODE_REGLEMENT_CLT,
            this.colMONTANT_REG_CLIENT,
            this.colMONTANT_PIECE,
            this.colRESTE,
            this.colNUM_PIECE_CLIENT,
            this.colBANQUE_CLIENT,
            this.colOBSERVATION,
            this.colCODE_COMPTE_CLIENT,
            this.colTYPE_PIECE,
            this.colREF_CLIENT,
            this.colRS_CLIENT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de regroupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMONTANT_REG_CLIENT, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCODE_REGLEMENT_CLIENT
            // 
            this.colCODE_REGLEMENT_CLIENT.FieldName = "CODE_REGLEMENT_CLIENT";
            this.colCODE_REGLEMENT_CLIENT.Name = "colCODE_REGLEMENT_CLIENT";
            this.colCODE_REGLEMENT_CLIENT.OptionsColumn.ReadOnly = true;
            this.colCODE_REGLEMENT_CLIENT.Visible = true;
            this.colCODE_REGLEMENT_CLIENT.VisibleIndex = 2;
            this.colCODE_REGLEMENT_CLIENT.Width = 74;
            // 
            // colCODE_FACTURE
            // 
            this.colCODE_FACTURE.FieldName = "CODE_FACTURE";
            this.colCODE_FACTURE.Name = "colCODE_FACTURE";
            this.colCODE_FACTURE.Visible = true;
            this.colCODE_FACTURE.VisibleIndex = 3;
            this.colCODE_FACTURE.Width = 87;
            // 
            // colDATE_REG_CLT
            // 
            this.colDATE_REG_CLT.FieldName = "DATE_REG_CLT";
            this.colDATE_REG_CLT.Name = "colDATE_REG_CLT";
            this.colDATE_REG_CLT.Visible = true;
            this.colDATE_REG_CLT.VisibleIndex = 4;
            this.colDATE_REG_CLT.Width = 80;
            // 
            // colMODE_REGLEMENT_CLT
            // 
            this.colMODE_REGLEMENT_CLT.FieldName = "MODE_REGLEMENT_CLT";
            this.colMODE_REGLEMENT_CLT.Name = "colMODE_REGLEMENT_CLT";
            this.colMODE_REGLEMENT_CLT.Visible = true;
            this.colMODE_REGLEMENT_CLT.VisibleIndex = 5;
            this.colMODE_REGLEMENT_CLT.Width = 83;
            // 
            // colMONTANT_REG_CLIENT
            // 
            this.colMONTANT_REG_CLIENT.FieldName = "MONTANT_REG_CLIENT";
            this.colMONTANT_REG_CLIENT.Name = "colMONTANT_REG_CLIENT";
            this.colMONTANT_REG_CLIENT.Visible = true;
            this.colMONTANT_REG_CLIENT.VisibleIndex = 6;
            this.colMONTANT_REG_CLIENT.Width = 79;
            // 
            // colMONTANT_PIECE
            // 
            this.colMONTANT_PIECE.FieldName = "MONTANT_PIECE";
            this.colMONTANT_PIECE.Name = "colMONTANT_PIECE";
            this.colMONTANT_PIECE.Visible = true;
            this.colMONTANT_PIECE.VisibleIndex = 7;
            this.colMONTANT_PIECE.Width = 69;
            // 
            // colRESTE
            // 
            this.colRESTE.FieldName = "RESTE";
            this.colRESTE.Name = "colRESTE";
            this.colRESTE.Visible = true;
            this.colRESTE.VisibleIndex = 8;
            this.colRESTE.Width = 67;
            // 
            // colNUM_PIECE_CLIENT
            // 
            this.colNUM_PIECE_CLIENT.FieldName = "NUM_PIECE_CLIENT";
            this.colNUM_PIECE_CLIENT.Name = "colNUM_PIECE_CLIENT";
            this.colNUM_PIECE_CLIENT.Visible = true;
            this.colNUM_PIECE_CLIENT.VisibleIndex = 9;
            this.colNUM_PIECE_CLIENT.Width = 80;
            // 
            // colBANQUE_CLIENT
            // 
            this.colBANQUE_CLIENT.FieldName = "BANQUE_CLIENT";
            this.colBANQUE_CLIENT.Name = "colBANQUE_CLIENT";
            this.colBANQUE_CLIENT.Visible = true;
            this.colBANQUE_CLIENT.VisibleIndex = 10;
            this.colBANQUE_CLIENT.Width = 87;
            // 
            // colOBSERVATION
            // 
            this.colOBSERVATION.FieldName = "OBSERVATION";
            this.colOBSERVATION.Name = "colOBSERVATION";
            this.colOBSERVATION.Visible = true;
            this.colOBSERVATION.VisibleIndex = 11;
            this.colOBSERVATION.Width = 68;
            // 
            // colCODE_COMPTE_CLIENT
            // 
            this.colCODE_COMPTE_CLIENT.FieldName = "CODE_COMPTE_CLIENT";
            this.colCODE_COMPTE_CLIENT.Name = "colCODE_COMPTE_CLIENT";
            this.colCODE_COMPTE_CLIENT.Visible = true;
            this.colCODE_COMPTE_CLIENT.VisibleIndex = 12;
            this.colCODE_COMPTE_CLIENT.Width = 82;
            // 
            // colTYPE_PIECE
            // 
            this.colTYPE_PIECE.FieldName = "TYPE_PIECE";
            this.colTYPE_PIECE.Name = "colTYPE_PIECE";
            this.colTYPE_PIECE.Visible = true;
            this.colTYPE_PIECE.VisibleIndex = 13;
            this.colTYPE_PIECE.Width = 91;
            // 
            // colREF_CLIENT
            // 
            this.colREF_CLIENT.FieldName = "REF_CLIENT";
            this.colREF_CLIENT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colREF_CLIENT.Name = "colREF_CLIENT";
            this.colREF_CLIENT.Visible = true;
            this.colREF_CLIENT.VisibleIndex = 0;
            this.colREF_CLIENT.Width = 73;
            // 
            // colRS_CLIENT
            // 
            this.colRS_CLIENT.FieldName = "RS_CLIENT";
            this.colRS_CLIENT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colRS_CLIENT.Name = "colRS_CLIENT";
            this.colRS_CLIENT.Visible = true;
            this.colRS_CLIENT.VisibleIndex = 1;
            this.colRS_CLIENT.Width = 160;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 338);
            this.chM_CMP_CONTROL1.TabIndex = 2;
            // 
            // CHM_FRM_REGLEMENT_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 386);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_FRM_REGLEMENT_CLIENT";
            this.Text = "Liste des règlements des CLient";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_REGLEMENT_CLIENT_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DS_MOUV dS_MOUV1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_REGLEMENT_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_REG_CLT;
        private DevExpress.XtraGrid.Columns.GridColumn colMODE_REGLEMENT_CLT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_REG_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_PIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTE;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_PIECE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colBANQUE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colOBSERVATION;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_COMPTE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE_PIECE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
    }
}