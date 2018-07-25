namespace CHM_CLIENT_APP.CHM_TICKET_CAISSE
{
    partial class CHM_FRM_LISTE_TICKET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_LISTE_TICKET));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_TC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CAISSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTANT_RECU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGASIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_REGLEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_UTILISATEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.crv_TICKET = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(1089, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 384);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "TICKET_CAISSE";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(582, 384);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_TC,
            this.colDATE_TC,
            this.colCODE_CAISSE,
            this.colCODE_CLIENT,
            this.colMONTANT_HT,
            this.colREMISE,
            this.colMONTANT_TVA,
            this.colMONTANT_TTC,
            this.colMONTANT_RECU,
            this.colRESTE,
            this.colMAGASIN,
            this.colCODE_USER,
            this.colCODE_REGLEMENT,
            this.colCODE_FACTURE,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colNOM_UTILISATEUR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de regroupement";
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_HT", this.colMONTANT_HT, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_RECU", this.colMONTANT_RECU, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_TTC", null, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_TVA", this.colMONTANT_TVA, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CODE_TC", this.colCODE_TC, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCODE_TC
            // 
            this.colCODE_TC.FieldName = "CODE_TC";
            this.colCODE_TC.Name = "colCODE_TC";
            this.colCODE_TC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colCODE_TC.Visible = true;
            this.colCODE_TC.VisibleIndex = 0;
            this.colCODE_TC.Width = 84;
            // 
            // colDATE_TC
            // 
            this.colDATE_TC.FieldName = "DATE_TC";
            this.colDATE_TC.Name = "colDATE_TC";
            this.colDATE_TC.Visible = true;
            this.colDATE_TC.VisibleIndex = 1;
            this.colDATE_TC.Width = 121;
            // 
            // colCODE_CAISSE
            // 
            this.colCODE_CAISSE.FieldName = "CODE_CAISSE";
            this.colCODE_CAISSE.Name = "colCODE_CAISSE";
            this.colCODE_CAISSE.Visible = true;
            this.colCODE_CAISSE.VisibleIndex = 3;
            this.colCODE_CAISSE.Width = 121;
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
            // 
            // colMONTANT_HT
            // 
            this.colMONTANT_HT.FieldName = "MONTANT_HT";
            this.colMONTANT_HT.Name = "colMONTANT_HT";
            // 
            // colREMISE
            // 
            this.colREMISE.DisplayFormat.FormatString = "{0:n3}";
            this.colREMISE.FieldName = "REMISE";
            this.colREMISE.Name = "colREMISE";
            this.colREMISE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colREMISE.Visible = true;
            this.colREMISE.VisibleIndex = 4;
            this.colREMISE.Width = 121;
            // 
            // colMONTANT_TVA
            // 
            this.colMONTANT_TVA.FieldName = "MONTANT_TVA";
            this.colMONTANT_TVA.Name = "colMONTANT_TVA";
            // 
            // colMONTANT_TTC
            // 
            this.colMONTANT_TTC.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_TTC.FieldName = "MONTANT_TTC";
            this.colMONTANT_TTC.Name = "colMONTANT_TTC";
            this.colMONTANT_TTC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_TTC", "{0:n3}")});
            this.colMONTANT_TTC.Visible = true;
            this.colMONTANT_TTC.VisibleIndex = 5;
            this.colMONTANT_TTC.Width = 121;
            // 
            // colMONTANT_RECU
            // 
            this.colMONTANT_RECU.DisplayFormat.FormatString = "{0:n3}";
            this.colMONTANT_RECU.FieldName = "MONTANT_RECU";
            this.colMONTANT_RECU.Name = "colMONTANT_RECU";
            this.colMONTANT_RECU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTANT_RECU", "{0:n3}")});
            this.colMONTANT_RECU.Visible = true;
            this.colMONTANT_RECU.VisibleIndex = 6;
            this.colMONTANT_RECU.Width = 121;
            // 
            // colRESTE
            // 
            this.colRESTE.DisplayFormat.FormatString = "{0:n3}";
            this.colRESTE.FieldName = "RESTE";
            this.colRESTE.Name = "colRESTE";
            this.colRESTE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RESTE", "{0:n3}")});
            this.colRESTE.Visible = true;
            this.colRESTE.VisibleIndex = 7;
            this.colRESTE.Width = 121;
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
            // colCODE_REGLEMENT
            // 
            this.colCODE_REGLEMENT.FieldName = "CODE_REGLEMENT";
            this.colCODE_REGLEMENT.Name = "colCODE_REGLEMENT";
            // 
            // colCODE_FACTURE
            // 
            this.colCODE_FACTURE.FieldName = "CODE_FACTURE";
            this.colCODE_FACTURE.Name = "colCODE_FACTURE";
            this.colCODE_FACTURE.Visible = true;
            this.colCODE_FACTURE.VisibleIndex = 9;
            this.colCODE_FACTURE.Width = 128;
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
            this.colRS_CLIENT.VisibleIndex = 2;
            this.colRS_CLIENT.Width = 121;
            // 
            // colNOM_UTILISATEUR
            // 
            this.colNOM_UTILISATEUR.FieldName = "NOM_UTILISATEUR";
            this.colNOM_UTILISATEUR.Name = "colNOM_UTILISATEUR";
            this.colNOM_UTILISATEUR.OptionsColumn.ReadOnly = true;
            this.colNOM_UTILISATEUR.Visible = true;
            this.colNOM_UTILISATEUR.VisibleIndex = 8;
            this.colNOM_UTILISATEUR.Width = 121;
            // 
            // crv_TICKET
            // 
            this.crv_TICKET.ActiveViewIndex = -1;
            this.crv_TICKET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_TICKET.DisplayGroupTree = false;
            this.crv_TICKET.Dock = System.Windows.Forms.DockStyle.Right;
            this.crv_TICKET.Location = new System.Drawing.Point(727, 48);
            this.crv_TICKET.Name = "crv_TICKET";
            this.crv_TICKET.SelectionFormula = "";
            this.crv_TICKET.ShowGroupTreeButton = false;
            this.crv_TICKET.Size = new System.Drawing.Size(362, 384);
            this.crv_TICKET.TabIndex = 3;
            this.crv_TICKET.ViewTimeSelectionFormula = "";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(722, 48);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 384);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // CHM_FRM_LISTE_TICKET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 432);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.crv_TICKET);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_TICKET";
            this.Text = "Liste des tickets de caisse";
            this.Load += new System.EventHandler(this.CHM_FRM_LISTE_TICKET_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_TICKET_KeyDown);
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
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TC;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_TC;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CAISSE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colREMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTANT_RECU;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGASIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_REGLEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_UTILISATEUR;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_TICKET;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
    }
}