namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    partial class CHM_FRM_MAJ_PRIX
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
            C1.Win.C1TrueDBGrid.Style style1 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style2 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style3 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style4 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style5 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style6 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style7 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style8 = new C1.Win.C1TrueDBGrid.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_MAJ_PRIX));
            C1.Win.C1TrueDBGrid.Style style9 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style10 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style11 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style12 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style13 = new C1.Win.C1TrueDBGrid.Style();
            this.txt_nomFichier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select_fichier = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.ficheir_selection = new System.Windows.Forms.OpenFileDialog();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.c1TrueDBGrid2 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_date_importation = new System.Windows.Forms.Label();
            this.chbx_validee = new System.Windows.Forms.CheckBox();
            this.chbx_annulee = new System.Windows.Forms.CheckBox();
            this.lb_date_validation = new System.Windows.Forms.Label();
            this.lb_user_validation = new System.Windows.Forms.Label();
            this.lb_date_annulation = new System.Windows.Forms.Label();
            this.lb_user_annulation = new System.Windows.Forms.Label();
            this.lb_user_importation = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nomFichier
            // 
            this.txt_nomFichier.Location = new System.Drawing.Point(98, 58);
            this.txt_nomFichier.Name = "txt_nomFichier";
            this.txt_nomFichier.Size = new System.Drawing.Size(293, 20);
            this.txt_nomFichier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fichier source :";
            // 
            // btn_select_fichier
            // 
            this.btn_select_fichier.Location = new System.Drawing.Point(397, 56);
            this.btn_select_fichier.Name = "btn_select_fichier";
            this.btn_select_fichier.Size = new System.Drawing.Size(29, 23);
            this.btn_select_fichier.TabIndex = 3;
            this.btn_select_fichier.Text = "...";
            this.btn_select_fichier.UseVisualStyleBackColor = true;
            this.btn_select_fichier.Click += new System.EventHandler(this.btn_select_fichier_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(432, 56);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(100, 23);
            this.btn_import.TabIndex = 5;
            this.btn_import.Text = "Importer";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_valider.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.btn_valider.Location = new System.Drawing.Point(498, 415);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(101, 43);
            this.btn_valider.TabIndex = 5;
            this.btn_valider.Text = "Valider";
            this.btn_valider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // ficheir_selection
            // 
            this.ficheir_selection.FileName = "openFileDialog1";
            this.ficheir_selection.Filter = "Fichier Excel ou CSV | *.csv;*.xslx";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.completeTest;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(721, 48);
            this.entete_Formulaire_21.TabIndex = 4;
            // 
            // c1TrueDBGrid2
            // 
            this.c1TrueDBGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TrueDBGrid2.CaptionHeight = 17;
            this.c1TrueDBGrid2.CaptionStyle = style1;
            this.c1TrueDBGrid2.CollapseColor = System.Drawing.Color.Black;
            this.c1TrueDBGrid2.EditorStyle = style2;
            this.c1TrueDBGrid2.EvenRowStyle = style3;
            this.c1TrueDBGrid2.ExpandColor = System.Drawing.Color.Black;
            this.c1TrueDBGrid2.FilterBarStyle = style4;
            this.c1TrueDBGrid2.FooterStyle = style5;
            this.c1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid2.GroupStyle = style6;
            this.c1TrueDBGrid2.HeadingStyle = style7;
            this.c1TrueDBGrid2.HighLightRowStyle = style8;
            this.c1TrueDBGrid2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid2.Images"))));
            this.c1TrueDBGrid2.InactiveStyle = style9;
            this.c1TrueDBGrid2.Location = new System.Drawing.Point(3, 3);
            this.c1TrueDBGrid2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder;
            this.c1TrueDBGrid2.Name = "c1TrueDBGrid2";
            this.c1TrueDBGrid2.OddRowStyle = style10;
            this.c1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid2.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid2.PrintInfo.PageSettings")));
            this.c1TrueDBGrid2.PrintInfo.ShowOptionsDialog = false;
            this.c1TrueDBGrid2.RecordSelectorStyle = style11;
            this.c1TrueDBGrid2.RecordSelectorWidth = 17;
            this.c1TrueDBGrid2.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBGrid2.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid2.RowHeight = 15;
            this.c1TrueDBGrid2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBGrid2.SelectedStyle = style12;
            this.c1TrueDBGrid2.Size = new System.Drawing.Size(0, 258);
            this.c1TrueDBGrid2.Style = style13;
            this.c1TrueDBGrid2.TabIndex = 6;
            this.c1TrueDBGrid2.Text = "c1TrueDBGrid2";
            this.c1TrueDBGrid2.PropBag = resources.GetString("c1TrueDBGrid2.PropBag");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 160);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1TrueDBGrid2);
            this.splitContainer1.Panel1MinSize = 5;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2MinSize = 5;
            this.splitContainer1.Size = new System.Drawing.Size(697, 248);
            this.splitContainer1.SplitterDistance = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_annuler.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_321;
            this.btn_annuler.Location = new System.Drawing.Point(607, 415);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(101, 43);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(84, 105);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(247, 20);
            this.txt_description.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date Maj :";
            // 
            // lb_date_importation
            // 
            this.lb_date_importation.AutoSize = true;
            this.lb_date_importation.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_importation.ForeColor = System.Drawing.Color.Blue;
            this.lb_date_importation.Location = new System.Drawing.Point(83, 86);
            this.lb_date_importation.Name = "lb_date_importation";
            this.lb_date_importation.Size = new System.Drawing.Size(0, 13);
            this.lb_date_importation.TabIndex = 8;
            // 
            // chbx_validee
            // 
            this.chbx_validee.AutoSize = true;
            this.chbx_validee.BackColor = System.Drawing.Color.Transparent;
            this.chbx_validee.Enabled = false;
            this.chbx_validee.ForeColor = System.Drawing.Color.Green;
            this.chbx_validee.Location = new System.Drawing.Point(15, 135);
            this.chbx_validee.Name = "chbx_validee";
            this.chbx_validee.Size = new System.Drawing.Size(55, 17);
            this.chbx_validee.TabIndex = 9;
            this.chbx_validee.Text = "Validé";
            this.chbx_validee.UseVisualStyleBackColor = false;
            this.chbx_validee.CheckedChanged += new System.EventHandler(this.chbx_validee_CheckedChanged);
            // 
            // chbx_annulee
            // 
            this.chbx_annulee.AutoSize = true;
            this.chbx_annulee.BackColor = System.Drawing.Color.Transparent;
            this.chbx_annulee.Enabled = false;
            this.chbx_annulee.ForeColor = System.Drawing.Color.Red;
            this.chbx_annulee.Location = new System.Drawing.Point(311, 135);
            this.chbx_annulee.Name = "chbx_annulee";
            this.chbx_annulee.Size = new System.Drawing.Size(59, 17);
            this.chbx_annulee.TabIndex = 9;
            this.chbx_annulee.Text = "Annulé";
            this.chbx_annulee.UseVisualStyleBackColor = false;
            this.chbx_annulee.CheckedChanged += new System.EventHandler(this.chbx_annulee_CheckedChanged);
            // 
            // lb_date_validation
            // 
            this.lb_date_validation.AutoSize = true;
            this.lb_date_validation.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_validation.ForeColor = System.Drawing.Color.Green;
            this.lb_date_validation.Location = new System.Drawing.Point(104, 136);
            this.lb_date_validation.Name = "lb_date_validation";
            this.lb_date_validation.Size = new System.Drawing.Size(0, 13);
            this.lb_date_validation.TabIndex = 10;
            // 
            // lb_user_validation
            // 
            this.lb_user_validation.AutoSize = true;
            this.lb_user_validation.BackColor = System.Drawing.Color.Transparent;
            this.lb_user_validation.ForeColor = System.Drawing.Color.Green;
            this.lb_user_validation.Location = new System.Drawing.Point(190, 136);
            this.lb_user_validation.Name = "lb_user_validation";
            this.lb_user_validation.Size = new System.Drawing.Size(0, 13);
            this.lb_user_validation.TabIndex = 10;
            // 
            // lb_date_annulation
            // 
            this.lb_date_annulation.AutoSize = true;
            this.lb_date_annulation.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_annulation.ForeColor = System.Drawing.Color.Red;
            this.lb_date_annulation.Location = new System.Drawing.Point(429, 136);
            this.lb_date_annulation.Name = "lb_date_annulation";
            this.lb_date_annulation.Size = new System.Drawing.Size(0, 13);
            this.lb_date_annulation.TabIndex = 10;
            // 
            // lb_user_annulation
            // 
            this.lb_user_annulation.AutoSize = true;
            this.lb_user_annulation.BackColor = System.Drawing.Color.Transparent;
            this.lb_user_annulation.ForeColor = System.Drawing.Color.Red;
            this.lb_user_annulation.Location = new System.Drawing.Point(538, 136);
            this.lb_user_annulation.Name = "lb_user_annulation";
            this.lb_user_annulation.Size = new System.Drawing.Size(0, 13);
            this.lb_user_annulation.TabIndex = 10;
            this.lb_user_annulation.Click += new System.EventHandler(this.lb_user_annulation_Click);
            // 
            // lb_user_importation
            // 
            this.lb_user_importation.AutoSize = true;
            this.lb_user_importation.BackColor = System.Drawing.Color.Transparent;
            this.lb_user_importation.ForeColor = System.Drawing.Color.Blue;
            this.lb_user_importation.Location = new System.Drawing.Point(168, 86);
            this.lb_user_importation.Name = "lb_user_importation";
            this.lb_user_importation.Size = new System.Drawing.Size(0, 13);
            this.lb_user_importation.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.Image = global::CHM_CLIENT_APP.Properties.Resources.arrow_tourner_vers_la_droite_icone_8357_32;
            this.btn_refresh.Location = new System.Drawing.Point(24, 417);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 43);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Rafraichir Importation";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(688, 248);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CHM_FRM_MAJ_PRIX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 472);
            this.Controls.Add(this.lb_user_annulation);
            this.Controls.Add(this.lb_date_annulation);
            this.Controls.Add(this.lb_user_validation);
            this.Controls.Add(this.lb_date_validation);
            this.Controls.Add(this.chbx_annulee);
            this.Controls.Add(this.chbx_validee);
            this.Controls.Add(this.lb_user_importation);
            this.Controls.Add(this.lb_date_importation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.btn_select_fichier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_nomFichier);
            this.Name = "CHM_FRM_MAJ_PRIX";
            this.Text = "Mise à jour prix";
            this.Load += new System.EventHandler(this.CHM_FRM_MAJ_PRIX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomFichier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select_fichier;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.OpenFileDialog ficheir_selection;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_date_importation;
        private System.Windows.Forms.CheckBox chbx_validee;
        private System.Windows.Forms.CheckBox chbx_annulee;
        private System.Windows.Forms.Label lb_date_validation;
        private System.Windows.Forms.Label lb_user_validation;
        private System.Windows.Forms.Label lb_date_annulation;
        private System.Windows.Forms.Label lb_user_annulation;
        private System.Windows.Forms.Label lb_user_importation;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_refresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}