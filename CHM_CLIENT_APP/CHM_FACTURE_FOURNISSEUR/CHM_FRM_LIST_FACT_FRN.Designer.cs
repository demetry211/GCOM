namespace CHM_CLIENT_APP.CHM_FACTURE_FOURNISSEUR
{
    partial class CHM_FRM_LIST_FACT_FRN
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_FACTURE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUM_FACT_FR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FACTURE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESSE_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_TVA_FOURNISSEUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_CREATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_CREATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_CREATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_MODIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_MODIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_MODIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANNULEE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_ANNULATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUTILISATEUR_ANNULATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_ANNULATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_TVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(654, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 378);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_FACTURE_FOURNISSEUR";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(514, 378);
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
            this.colCODE_FACTURE_FOURNISSEUR,
            this.colNUM_FACT_FR,
            this.colDATE_FACTURE_FOURNISSEUR,
            this.colCODE_FOURNISSEUR,
            this.colREF_FOURNISSEUR,
            this.colRS_FOURNISSEUR,
            this.colADRESSE_FOURNISSEUR,
            this.colTEL_FOURNISSEUR,
            this.colFAX_FOURNISSEUR,
            this.colEMAIL_FOURNISSEUR,
            this.colCODE_TVA_FOURNISSEUR,
            this.colUSER_CREATION,
            this.colUTILISATEUR_CREATION,
            this.colDATE_CREATION,
            this.colUSER_MODIFICATION,
            this.colUTILISATEUR_MODIFICATION,
            this.colDATE_MODIFICATION,
            this.colANNULEE,
            this.colUSER_ANNULATION,
            this.colUTILISATEUR_ANNULATION,
            this.colDATE_ANNULATION,
            this.colTOTAL_HT,
            this.colTOTAL_REMISE,
            this.colTOTAL_TVA,
            this.colTOTAL_TTC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_HT", this.colTOTAL_HT, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_REMISE", this.colTOTAL_REMISE, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_TTC", this.colTOTAL_TTC, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_TVA", this.colTOTAL_TVA, "{0:n3}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CODE_FACTURE_FOURNISSEUR", this.colCODE_FACTURE_FOURNISSEUR, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.UsePrintStyles = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDATE_FACTURE_FOURNISSEUR, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.ViewCaption = "Liste des Factures Achat";
            this.gridView1.ViewCaptionHeight = 10;
            // 
            // colCODE_FACTURE_FOURNISSEUR
            // 
            this.colCODE_FACTURE_FOURNISSEUR.FieldName = "CODE_FACTURE_FOURNISSEUR";
            this.colCODE_FACTURE_FOURNISSEUR.Name = "colCODE_FACTURE_FOURNISSEUR";
            this.colCODE_FACTURE_FOURNISSEUR.Visible = true;
            this.colCODE_FACTURE_FOURNISSEUR.VisibleIndex = 0;
            this.colCODE_FACTURE_FOURNISSEUR.Width = 81;
            // 
            // colNUM_FACT_FR
            // 
            this.colNUM_FACT_FR.FieldName = "NUM_FACT_FR";
            this.colNUM_FACT_FR.Name = "colNUM_FACT_FR";
            this.colNUM_FACT_FR.Visible = true;
            this.colNUM_FACT_FR.VisibleIndex = 1;
            this.colNUM_FACT_FR.Width = 86;
            // 
            // colDATE_FACTURE_FOURNISSEUR
            // 
            this.colDATE_FACTURE_FOURNISSEUR.FieldName = "DATE_FACTURE_FOURNISSEUR";
            this.colDATE_FACTURE_FOURNISSEUR.Name = "colDATE_FACTURE_FOURNISSEUR";
            this.colDATE_FACTURE_FOURNISSEUR.Visible = true;
            this.colDATE_FACTURE_FOURNISSEUR.VisibleIndex = 2;
            this.colDATE_FACTURE_FOURNISSEUR.Width = 95;
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
            // 
            // colRS_FOURNISSEUR
            // 
            this.colRS_FOURNISSEUR.FieldName = "RS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Name = "colRS_FOURNISSEUR";
            this.colRS_FOURNISSEUR.Visible = true;
            this.colRS_FOURNISSEUR.VisibleIndex = 3;
            this.colRS_FOURNISSEUR.Width = 174;
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
            // colEMAIL_FOURNISSEUR
            // 
            this.colEMAIL_FOURNISSEUR.FieldName = "EMAIL_FOURNISSEUR";
            this.colEMAIL_FOURNISSEUR.Name = "colEMAIL_FOURNISSEUR";
            // 
            // colCODE_TVA_FOURNISSEUR
            // 
            this.colCODE_TVA_FOURNISSEUR.FieldName = "CODE_TVA_FOURNISSEUR";
            this.colCODE_TVA_FOURNISSEUR.Name = "colCODE_TVA_FOURNISSEUR";
            // 
            // colUSER_CREATION
            // 
            this.colUSER_CREATION.FieldName = "USER_CREATION";
            this.colUSER_CREATION.Name = "colUSER_CREATION";
            this.colUSER_CREATION.Width = 97;
            // 
            // colUTILISATEUR_CREATION
            // 
            this.colUTILISATEUR_CREATION.FieldName = "UTILISATEUR_CREATION";
            this.colUTILISATEUR_CREATION.Name = "colUTILISATEUR_CREATION";
            this.colUTILISATEUR_CREATION.OptionsColumn.ReadOnly = true;
            this.colUTILISATEUR_CREATION.Visible = true;
            this.colUTILISATEUR_CREATION.VisibleIndex = 8;
            // 
            // colDATE_CREATION
            // 
            this.colDATE_CREATION.FieldName = "DATE_CREATION";
            this.colDATE_CREATION.Name = "colDATE_CREATION";
            this.colDATE_CREATION.Visible = true;
            this.colDATE_CREATION.VisibleIndex = 9;
            // 
            // colUSER_MODIFICATION
            // 
            this.colUSER_MODIFICATION.FieldName = "USER_MODIFICATION";
            this.colUSER_MODIFICATION.Name = "colUSER_MODIFICATION";
            // 
            // colUTILISATEUR_MODIFICATION
            // 
            this.colUTILISATEUR_MODIFICATION.FieldName = "UTILISATEUR_MODIFICATION";
            this.colUTILISATEUR_MODIFICATION.Name = "colUTILISATEUR_MODIFICATION";
            this.colUTILISATEUR_MODIFICATION.OptionsColumn.ReadOnly = true;
            this.colUTILISATEUR_MODIFICATION.Visible = true;
            this.colUTILISATEUR_MODIFICATION.VisibleIndex = 10;
            // 
            // colDATE_MODIFICATION
            // 
            this.colDATE_MODIFICATION.FieldName = "DATE_MODIFICATION";
            this.colDATE_MODIFICATION.Name = "colDATE_MODIFICATION";
            this.colDATE_MODIFICATION.Visible = true;
            this.colDATE_MODIFICATION.VisibleIndex = 11;
            // 
            // colANNULEE
            // 
            this.colANNULEE.FieldName = "ANNULEE";
            this.colANNULEE.Name = "colANNULEE";
            this.colANNULEE.Visible = true;
            this.colANNULEE.VisibleIndex = 12;
            // 
            // colUSER_ANNULATION
            // 
            this.colUSER_ANNULATION.FieldName = "USER_ANNULATION";
            this.colUSER_ANNULATION.Name = "colUSER_ANNULATION";
            // 
            // colUTILISATEUR_ANNULATION
            // 
            this.colUTILISATEUR_ANNULATION.FieldName = "UTILISATEUR_ANNULATION";
            this.colUTILISATEUR_ANNULATION.Name = "colUTILISATEUR_ANNULATION";
            this.colUTILISATEUR_ANNULATION.OptionsColumn.ReadOnly = true;
            // 
            // colDATE_ANNULATION
            // 
            this.colDATE_ANNULATION.FieldName = "DATE_ANNULATION";
            this.colDATE_ANNULATION.Name = "colDATE_ANNULATION";
            // 
            // colTOTAL_HT
            // 
            this.colTOTAL_HT.DisplayFormat.FormatString = "{0:n3}";
            this.colTOTAL_HT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTAL_HT.FieldName = "TOTAL_HT";
            this.colTOTAL_HT.Name = "colTOTAL_HT";
            this.colTOTAL_HT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_HT", "{0:n3}")});
            this.colTOTAL_HT.Visible = true;
            this.colTOTAL_HT.VisibleIndex = 4;
            this.colTOTAL_HT.Width = 96;
            // 
            // colTOTAL_REMISE
            // 
            this.colTOTAL_REMISE.DisplayFormat.FormatString = "{0:n3}";
            this.colTOTAL_REMISE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTAL_REMISE.FieldName = "TOTAL_REMISE";
            this.colTOTAL_REMISE.Name = "colTOTAL_REMISE";
            this.colTOTAL_REMISE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_REMISE", "{0:n3}")});
            this.colTOTAL_REMISE.Visible = true;
            this.colTOTAL_REMISE.VisibleIndex = 5;
            this.colTOTAL_REMISE.Width = 92;
            // 
            // colTOTAL_TVA
            // 
            this.colTOTAL_TVA.DisplayFormat.FormatString = "{0:n3}";
            this.colTOTAL_TVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTAL_TVA.FieldName = "TOTAL_TVA";
            this.colTOTAL_TVA.Name = "colTOTAL_TVA";
            this.colTOTAL_TVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_TVA", "{0:n3}")});
            this.colTOTAL_TVA.Visible = true;
            this.colTOTAL_TVA.VisibleIndex = 6;
            // 
            // colTOTAL_TTC
            // 
            this.colTOTAL_TTC.DisplayFormat.FormatString = "{0:n3}";
            this.colTOTAL_TTC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTAL_TTC.FieldName = "TOTAL_TTC";
            this.colTOTAL_TTC.Name = "colTOTAL_TTC";
            this.colTOTAL_TTC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_TTC", "{0:n3}")});
            this.colTOTAL_TTC.Visible = true;
            this.colTOTAL_TTC.VisibleIndex = 7;
            this.colTOTAL_TTC.Width = 93;
            // 
            // CHM_FRM_LIST_FACT_FRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 426);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_LIST_FACT_FRN";
            this.Text = "Liste des factures Achat";
            this.Load += new System.EventHandler(this.CHM_FRM_LIST_FACT_FRN_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FACTURE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_FACT_FR;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FACTURE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESSE_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_TVA_FOURNISSEUR;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_CREATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_CREATION;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_CREATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_MODIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_MODIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_MODIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colANNULEE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ANNULATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUTILISATEUR_ANNULATION;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_ANNULATION;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_TVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_TTC;
    }
}