namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    partial class CHM_FRM_LISTE_MAJ_PRIX
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
            this.dataSet1 = new System.Data.DataSet();
            this.DT_MAJ = new System.Data.DataTable();
            this._CODE_MAJ_P = new System.Data.DataColumn();
            this._DESCRIPTION_MAJ = new System.Data.DataColumn();
            this._USER_IMPORTATION = new System.Data.DataColumn();
            this._NOM_USER_IMPORTATION = new System.Data.DataColumn();
            this._DATE_IMPORTATION = new System.Data.DataColumn();
            this._VALIDEE = new System.Data.DataColumn();
            this._USER_VALIDATION = new System.Data.DataColumn();
            this._NOM_USER_VALIDATION = new System.Data.DataColumn();
            this._DATE_VALIDATION = new System.Data.DataColumn();
            this._ANNULEE = new System.Data.DataColumn();
            this._DATE_ANNULATION = new System.Data.DataColumn();
            this._USER_ANNULATION = new System.Data.DataColumn();
            this._NOM_USER_ANNULATION = new System.Data.DataColumn();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_CONTROL1 = new CHM_STYLE.CHM_CMP_CONTROL();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MAJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DT_MAJ});
            // 
            // DT_MAJ
            // 
            this.DT_MAJ.Columns.AddRange(new System.Data.DataColumn[] {
            this._CODE_MAJ_P,
            this._DESCRIPTION_MAJ,
            this._USER_IMPORTATION,
            this._NOM_USER_IMPORTATION,
            this._DATE_IMPORTATION,
            this._VALIDEE,
            this._USER_VALIDATION,
            this._NOM_USER_VALIDATION,
            this._DATE_VALIDATION,
            this._ANNULEE,
            this._DATE_ANNULATION,
            this._USER_ANNULATION,
            this._NOM_USER_ANNULATION});
            this.DT_MAJ.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CODE_MAJ_P"}, true)});
            this.DT_MAJ.PrimaryKey = new System.Data.DataColumn[] {
        this._CODE_MAJ_P};
            this.DT_MAJ.TableName = "DT_MAJ";
            // 
            // _CODE_MAJ_P
            // 
            this._CODE_MAJ_P.AllowDBNull = false;
            this._CODE_MAJ_P.Caption = "CODE_MAJ_P";
            this._CODE_MAJ_P.ColumnName = "CODE_MAJ_P";
            this._CODE_MAJ_P.DataType = typeof(decimal);
            // 
            // _DESCRIPTION_MAJ
            // 
            this._DESCRIPTION_MAJ.Caption = "DESCRIPTION_MAJ";
            this._DESCRIPTION_MAJ.ColumnName = "DESCRIPTION_MAJ";
            // 
            // _USER_IMPORTATION
            // 
            this._USER_IMPORTATION.Caption = "USER_IMPORTATION";
            this._USER_IMPORTATION.ColumnName = "USER_IMPORTATION";
            this._USER_IMPORTATION.DataType = typeof(decimal);
            // 
            // _NOM_USER_IMPORTATION
            // 
            this._NOM_USER_IMPORTATION.Caption = "NOM_USER_IMPORTATION";
            this._NOM_USER_IMPORTATION.ColumnName = "NOM_USER_IMPORTATION";
            // 
            // _DATE_IMPORTATION
            // 
            this._DATE_IMPORTATION.Caption = "DATE_IMPORTATION";
            this._DATE_IMPORTATION.ColumnName = "DATE_IMPORTATION";
            this._DATE_IMPORTATION.DataType = typeof(System.DateTime);
            // 
            // _VALIDEE
            // 
            this._VALIDEE.Caption = "VALIDEE";
            this._VALIDEE.ColumnName = "VALIDEE";
            this._VALIDEE.DataType = typeof(bool);
            // 
            // _USER_VALIDATION
            // 
            this._USER_VALIDATION.Caption = "USER_VALIDATION";
            this._USER_VALIDATION.ColumnName = "USER_VALIDATION";
            this._USER_VALIDATION.DataType = typeof(decimal);
            // 
            // _NOM_USER_VALIDATION
            // 
            this._NOM_USER_VALIDATION.Caption = "NOM_USER_VALIDATION";
            this._NOM_USER_VALIDATION.ColumnName = "NOM_USER_VALIDATION";
            // 
            // _DATE_VALIDATION
            // 
            this._DATE_VALIDATION.Caption = "DATE_VALIDATION";
            this._DATE_VALIDATION.ColumnName = "DATE_VALIDATION";
            this._DATE_VALIDATION.DataType = typeof(System.DateTime);
            // 
            // _ANNULEE
            // 
            this._ANNULEE.Caption = "ANNULEE";
            this._ANNULEE.ColumnName = "ANNULEE";
            this._ANNULEE.DataType = typeof(bool);
            // 
            // _DATE_ANNULATION
            // 
            this._DATE_ANNULATION.Caption = "DATE_ANNULATION";
            this._DATE_ANNULATION.ColumnName = "DATE_ANNULATION";
            this._DATE_ANNULATION.DataType = typeof(System.DateTime);
            // 
            // _USER_ANNULATION
            // 
            this._USER_ANNULATION.Caption = "USER_ANNULATION";
            this._USER_ANNULATION.ColumnName = "USER_ANNULATION";
            this._USER_ANNULATION.DataType = typeof(decimal);
            // 
            // _NOM_USER_ANNULATION
            // 
            this._NOM_USER_ANNULATION.Caption = "NOM_USER_ANNULATION";
            this._NOM_USER_ANNULATION.ColumnName = "NOM_USER_ANNULATION";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.completeTest;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(727, 48);
            this.entete_Formulaire_21.TabIndex = 86;
            // 
            // chM_CMP_CONTROL1
            // 
            this.chM_CMP_CONTROL1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chM_CMP_CONTROL1.Location = new System.Drawing.Point(0, 48);
            this.chM_CMP_CONTROL1.MinimumSize = new System.Drawing.Size(140, 248);
            this.chM_CMP_CONTROL1.Name = "chM_CMP_CONTROL1";
            this.chM_CMP_CONTROL1.Size = new System.Drawing.Size(140, 305);
            this.chM_CMP_CONTROL1.TabIndex = 87;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(140, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(587, 305);
            this.gridControl1.TabIndex = 88;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CHM_FRM_LISTE_MAJ_PRIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 353);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chM_CMP_CONTROL1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.KeyPreview = true;
            this.Name = "CHM_FRM_LISTE_MAJ_PRIX";
            this.Text = "Liste des mises à jour de prix";
            this.Load += new System.EventHandler(this.CHM_FRM_LISTE_MAJ_PRIX_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_LISTE_MAJ_PRIX_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MAJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable DT_MAJ;
        private System.Data.DataColumn _CODE_MAJ_P;
        private System.Data.DataColumn _DESCRIPTION_MAJ;
        private System.Data.DataColumn _USER_IMPORTATION;
        private System.Data.DataColumn _NOM_USER_IMPORTATION;
        private System.Data.DataColumn _DATE_IMPORTATION;
        private System.Data.DataColumn _VALIDEE;
        private System.Data.DataColumn _USER_VALIDATION;
        private System.Data.DataColumn _NOM_USER_VALIDATION;
        private System.Data.DataColumn _DATE_VALIDATION;
        private System.Data.DataColumn _ANNULEE;
        private System.Data.DataColumn _DATE_ANNULATION;
        private System.Data.DataColumn _USER_ANNULATION;
        private System.Data.DataColumn _NOM_USER_ANNULATION;
        private CHM_STYLE.CHM_CMP_CONTROL chM_CMP_CONTROL1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}