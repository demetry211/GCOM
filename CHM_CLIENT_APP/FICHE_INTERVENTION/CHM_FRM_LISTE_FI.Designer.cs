namespace CHM_CLIENT_APP.FICHE_INTERVENTION
{
    partial class CHM_FRM_LISTE_FI
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
            this.colNUM_FI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_VEHICULE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKILOMETRAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_B_LIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_CR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_MODIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_MODIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_CLOTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_CLOTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRS_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_FAB_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_MISE_SERVICE_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFABRIQUANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLIBELLE_EQP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUM_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE_PIECE_REG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(686, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 307);
            this.chM_CMP_CONTROL1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "V_FICHE_INTERVENTION";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 307);
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
            this.colNUM_FI,
            this.colDATE_FI,
            this.colCODE_VEHICULE,
            this.colKILOMETRAGE,
            this.colCODE_B_LIV,
            this.colUSER_CR,
            this.colDATE_MODIF,
            this.colUSER_MODIF,
            this.colCLOTURE,
            this.colDATE_CLOTURE,
            this.colUSER_CLOTURE,
            this.colREF_CLIENT,
            this.colRS_CLIENT,
            this.colTEL_CLIENT,
            this.colCODE_CLIENT,
            this.colDATE_FAB_EQP,
            this.colDATE_MISE_SERVICE_EQP,
            this.colFABRIQUANT,
            this.colLIBELLE_EQP,
            this.colNUM_SERIE,
            this.colTYPE_PIECE_REG});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Glisser ici les colonnes de groupement";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colNUM_FI
            // 
            this.colNUM_FI.FieldName = "NUM_FI";
            this.colNUM_FI.Name = "colNUM_FI";
            this.colNUM_FI.Visible = true;
            this.colNUM_FI.VisibleIndex = 0;
            // 
            // colDATE_FI
            // 
            this.colDATE_FI.FieldName = "DATE_FI";
            this.colDATE_FI.Name = "colDATE_FI";
            this.colDATE_FI.Visible = true;
            this.colDATE_FI.VisibleIndex = 1;
            // 
            // colCODE_VEHICULE
            // 
            this.colCODE_VEHICULE.FieldName = "CODE_VEHICULE";
            this.colCODE_VEHICULE.Name = "colCODE_VEHICULE";
            // 
            // colKILOMETRAGE
            // 
            this.colKILOMETRAGE.Caption = "Nbr Heure Marche";
            this.colKILOMETRAGE.FieldName = "KILOMETRAGE";
            this.colKILOMETRAGE.Name = "colKILOMETRAGE";
            this.colKILOMETRAGE.Visible = true;
            this.colKILOMETRAGE.VisibleIndex = 5;
            // 
            // colCODE_B_LIV
            // 
            this.colCODE_B_LIV.FieldName = "CODE_B_LIV";
            this.colCODE_B_LIV.Name = "colCODE_B_LIV";
            this.colCODE_B_LIV.Visible = true;
            this.colCODE_B_LIV.VisibleIndex = 8;
            // 
            // colUSER_CR
            // 
            this.colUSER_CR.FieldName = "USER_CR";
            this.colUSER_CR.Name = "colUSER_CR";
            // 
            // colDATE_MODIF
            // 
            this.colDATE_MODIF.FieldName = "DATE_MODIF";
            this.colDATE_MODIF.Name = "colDATE_MODIF";
            // 
            // colUSER_MODIF
            // 
            this.colUSER_MODIF.FieldName = "USER_MODIF";
            this.colUSER_MODIF.Name = "colUSER_MODIF";
            // 
            // colCLOTURE
            // 
            this.colCLOTURE.FieldName = "CLOTURE";
            this.colCLOTURE.Name = "colCLOTURE";
            this.colCLOTURE.Visible = true;
            this.colCLOTURE.VisibleIndex = 6;
            // 
            // colDATE_CLOTURE
            // 
            this.colDATE_CLOTURE.FieldName = "DATE_CLOTURE";
            this.colDATE_CLOTURE.Name = "colDATE_CLOTURE";
            this.colDATE_CLOTURE.Visible = true;
            this.colDATE_CLOTURE.VisibleIndex = 7;
            // 
            // colUSER_CLOTURE
            // 
            this.colUSER_CLOTURE.FieldName = "USER_CLOTURE";
            this.colUSER_CLOTURE.Name = "colUSER_CLOTURE";
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
            // 
            // colTEL_CLIENT
            // 
            this.colTEL_CLIENT.FieldName = "TEL_CLIENT";
            this.colTEL_CLIENT.Name = "colTEL_CLIENT";
            // 
            // colCODE_CLIENT
            // 
            this.colCODE_CLIENT.FieldName = "CODE_CLIENT";
            this.colCODE_CLIENT.Name = "colCODE_CLIENT";
            // 
            // colDATE_FAB_EQP
            // 
            this.colDATE_FAB_EQP.FieldName = "DATE_FAB_EQP";
            this.colDATE_FAB_EQP.Name = "colDATE_FAB_EQP";
            this.colDATE_FAB_EQP.Visible = true;
            this.colDATE_FAB_EQP.VisibleIndex = 9;
            // 
            // colDATE_MISE_SERVICE_EQP
            // 
            this.colDATE_MISE_SERVICE_EQP.FieldName = "DATE_MISE_SERVICE_EQP";
            this.colDATE_MISE_SERVICE_EQP.Name = "colDATE_MISE_SERVICE_EQP";
            this.colDATE_MISE_SERVICE_EQP.Visible = true;
            this.colDATE_MISE_SERVICE_EQP.VisibleIndex = 10;
            // 
            // colFABRIQUANT
            // 
            this.colFABRIQUANT.FieldName = "FABRIQUANT";
            this.colFABRIQUANT.Name = "colFABRIQUANT";
            this.colFABRIQUANT.Visible = true;
            this.colFABRIQUANT.VisibleIndex = 11;
            // 
            // colLIBELLE_EQP
            // 
            this.colLIBELLE_EQP.FieldName = "LIBELLE_EQP";
            this.colLIBELLE_EQP.Name = "colLIBELLE_EQP";
            this.colLIBELLE_EQP.Visible = true;
            this.colLIBELLE_EQP.VisibleIndex = 3;
            // 
            // colNUM_SERIE
            // 
            this.colNUM_SERIE.FieldName = "NUM_SERIE";
            this.colNUM_SERIE.Name = "colNUM_SERIE";
            this.colNUM_SERIE.Visible = true;
            this.colNUM_SERIE.VisibleIndex = 4;
            // 
            // colTYPE_PIECE_REG
            // 
            this.colTYPE_PIECE_REG.Caption = "Type Pièce Reg.";
            this.colTYPE_PIECE_REG.FieldName = "TYPE_PIECE_REG";
            this.colTYPE_PIECE_REG.Name = "colTYPE_PIECE_REG";
            this.colTYPE_PIECE_REG.Visible = true;
            this.colTYPE_PIECE_REG.VisibleIndex = 12;
            // 
            // CHM_FRM_LISTE_FI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 355);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_FI";
            this.Text = "Liste des entretiens";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_FI_KeyDown);
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
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_FI;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FI;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_VEHICULE;
        private DevExpress.XtraGrid.Columns.GridColumn colKILOMETRAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_B_LIV;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_CR;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_MODIF;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_MODIF;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_CLOTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_CLOTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colRS_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_FAB_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_MISE_SERVICE_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colFABRIQUANT;
        private DevExpress.XtraGrid.Columns.GridColumn colLIBELLE_EQP;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE_PIECE_REG;
    }
}