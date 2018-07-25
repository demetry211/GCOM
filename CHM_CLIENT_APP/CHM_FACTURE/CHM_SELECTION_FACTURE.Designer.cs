namespace CHM_CLIENT_APP.CHM_FACTURE
{
    partial class CHM_SELECTION_FACTURE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_LISTE_FACTURE = new System.Windows.Forms.DataGridView();
            this.CODE_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_HT_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_TVA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_TTC_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAUX_REMISE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_BASE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMBRE_FACTURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_TOTAL_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annulation_facture_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.NOM_FENETRE = new System.Windows.Forms.Label();
            this.btn_selection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_RECHERCHE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_FACTURE)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LISTE_FACTURE
            // 
            this.dgv_LISTE_FACTURE.AllowUserToAddRows = false;
            this.dgv_LISTE_FACTURE.AllowUserToDeleteRows = false;
            this.dgv_LISTE_FACTURE.AllowUserToResizeColumns = false;
            this.dgv_LISTE_FACTURE.AllowUserToResizeRows = false;
            this.dgv_LISTE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LISTE_FACTURE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LISTE_FACTURE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LISTE_FACTURE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_FACTURE_,
            this.DATE_FACTURE_,
            this.CODE_CLIENT_,
            this.CODE_HT_FACTURE_,
            this.MONTANT_TVA_,
            this.MONTANT_TTC_,
            this.TAUX_REMISE_,
            this.MONTANT_BASE_,
            this.TIMBRE_FACTURE,
            this.MONTANT_TOTAL_FACTURE_,
            this.CREDIT_,
            this.CODE_USER,
            this.Annulation_facture_});
            this.dgv_LISTE_FACTURE.Location = new System.Drawing.Point(12, 105);
            this.dgv_LISTE_FACTURE.MultiSelect = false;
            this.dgv_LISTE_FACTURE.Name = "dgv_LISTE_FACTURE";
            this.dgv_LISTE_FACTURE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LISTE_FACTURE.Size = new System.Drawing.Size(552, 301);
            this.dgv_LISTE_FACTURE.TabIndex = 84;
            this.dgv_LISTE_FACTURE.DoubleClick += new System.EventHandler(this.dgv_LISTE_FACTURE_DoubleClick);
            // 
            // CODE_FACTURE_
            // 
            this.CODE_FACTURE_.DataPropertyName = "CODE_FACTURE";
            this.CODE_FACTURE_.FillWeight = 165.8312F;
            this.CODE_FACTURE_.HeaderText = "N° Facture";
            this.CODE_FACTURE_.Name = "CODE_FACTURE_";
            this.CODE_FACTURE_.ReadOnly = true;
            // 
            // DATE_FACTURE_
            // 
            this.DATE_FACTURE_.DataPropertyName = "DATE_FACTURE";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DATE_FACTURE_.DefaultCellStyle = dataGridViewCellStyle1;
            this.DATE_FACTURE_.FillWeight = 107.38F;
            this.DATE_FACTURE_.HeaderText = "Date Création";
            this.DATE_FACTURE_.Name = "DATE_FACTURE_";
            // 
            // CODE_CLIENT_
            // 
            this.CODE_CLIENT_.DataPropertyName = "CODE_CLIENT";
            dataGridViewCellStyle2.NullValue = null;
            this.CODE_CLIENT_.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODE_CLIENT_.FillWeight = 102.5314F;
            this.CODE_CLIENT_.HeaderText = "Client";
            this.CODE_CLIENT_.Name = "CODE_CLIENT_";
            this.CODE_CLIENT_.ReadOnly = true;
            this.CODE_CLIENT_.Visible = false;
            // 
            // CODE_HT_FACTURE_
            // 
            this.CODE_HT_FACTURE_.DataPropertyName = "MONTANT_HT_FACTURE";
            this.CODE_HT_FACTURE_.FillWeight = 118.3931F;
            this.CODE_HT_FACTURE_.HeaderText = "Total Brut";
            this.CODE_HT_FACTURE_.Name = "CODE_HT_FACTURE_";
            this.CODE_HT_FACTURE_.ReadOnly = true;
            this.CODE_HT_FACTURE_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODE_HT_FACTURE_.Visible = false;
            // 
            // MONTANT_TVA_
            // 
            this.MONTANT_TVA_.DataPropertyName = "MONTANT_TVA";
            this.MONTANT_TVA_.FillWeight = 129.5837F;
            this.MONTANT_TVA_.HeaderText = "Total TVA";
            this.MONTANT_TVA_.Name = "MONTANT_TVA_";
            // 
            // MONTANT_TTC_
            // 
            this.MONTANT_TTC_.DataPropertyName = "MONTANT_TTC";
            this.MONTANT_TTC_.FillWeight = 129.2688F;
            this.MONTANT_TTC_.HeaderText = "Total Sans Remise";
            this.MONTANT_TTC_.Name = "MONTANT_TTC_";
            // 
            // TAUX_REMISE_
            // 
            this.TAUX_REMISE_.DataPropertyName = "TAUX_REMISE";
            this.TAUX_REMISE_.FillWeight = 97.19653F;
            this.TAUX_REMISE_.HeaderText = "Remise";
            this.TAUX_REMISE_.Name = "TAUX_REMISE_";
            // 
            // MONTANT_BASE_
            // 
            this.MONTANT_BASE_.DataPropertyName = "MONTANT_BASE";
            this.MONTANT_BASE_.FillWeight = 96.01762F;
            this.MONTANT_BASE_.HeaderText = "Total Apres remise";
            this.MONTANT_BASE_.Name = "MONTANT_BASE_";
            // 
            // TIMBRE_FACTURE
            // 
            this.TIMBRE_FACTURE.DataPropertyName = "TIMBRE_FACTURE";
            this.TIMBRE_FACTURE.FillWeight = 96.03836F;
            this.TIMBRE_FACTURE.HeaderText = "Timbre";
            this.TIMBRE_FACTURE.Name = "TIMBRE_FACTURE";
            this.TIMBRE_FACTURE.Visible = false;
            // 
            // MONTANT_TOTAL_FACTURE_
            // 
            this.MONTANT_TOTAL_FACTURE_.DataPropertyName = "MONTANT_TOTAL_FACTURE";
            this.MONTANT_TOTAL_FACTURE_.FillWeight = 96.05759F;
            this.MONTANT_TOTAL_FACTURE_.HeaderText = "Montant total";
            this.MONTANT_TOTAL_FACTURE_.Name = "MONTANT_TOTAL_FACTURE_";
            // 
            // CREDIT_
            // 
            this.CREDIT_.DataPropertyName = "CREDIT";
            this.CREDIT_.FillWeight = 97.19267F;
            this.CREDIT_.HeaderText = "Credit";
            this.CREDIT_.Name = "CREDIT_";
            // 
            // CODE_USER
            // 
            this.CODE_USER.DataPropertyName = "CODE_USER";
            this.CODE_USER.FillWeight = 96.0141F;
            this.CODE_USER.HeaderText = "Utilisateur";
            this.CODE_USER.Name = "CODE_USER";
            this.CODE_USER.Visible = false;
            // 
            // Annulation_facture_
            // 
            this.Annulation_facture_.DataPropertyName = "ANNULATION_FACTURE";
            this.Annulation_facture_.FillWeight = 96.03507F;
            this.Annulation_facture_.HeaderText = "Annulée?";
            this.Annulation_facture_.Name = "Annulation_facture_";
            this.Annulation_facture_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Annulation_facture_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Annulation_facture_.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.NOM_FENETRE);
            this.groupBox5.Location = new System.Drawing.Point(-2, -11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(690, 65);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(532, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 33);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // NOM_FENETRE
            // 
            this.NOM_FENETRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_FENETRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FENETRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NOM_FENETRE.Location = new System.Drawing.Point(6, 14);
            this.NOM_FENETRE.Name = "NOM_FENETRE";
            this.NOM_FENETRE.Size = new System.Drawing.Size(520, 48);
            this.NOM_FENETRE.TabIndex = 0;
            this.NOM_FENETRE.Text = "Liste des factures Client";
            this.NOM_FENETRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_selection
            // 
            this.btn_selection.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.btn_selection.Location = new System.Drawing.Point(453, 412);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(111, 43);
            this.btn_selection.TabIndex = 86;
            this.btn_selection.Text = "Sélectionner";
            this.btn_selection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // TB_RECHERCHE
            // 
            this.TB_RECHERCHE.Location = new System.Drawing.Point(135, 75);
            this.TB_RECHERCHE.Name = "TB_RECHERCHE";
            this.TB_RECHERCHE.Size = new System.Drawing.Size(229, 20);
            this.TB_RECHERCHE.TabIndex = 88;
            this.TB_RECHERCHE.TextChanged += new System.EventHandler(this.TB_RECHERCHE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Recherche :";
            // 
            // CHM_SELECTION_FACTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 463);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_RECHERCHE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selection);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dgv_LISTE_FACTURE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CHM_SELECTION_FACTURE";
            this.Text = "Liste des factures Client";
            this.Load += new System.EventHandler(this.CHM_SELECTION_FACTURE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_FACTURE)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LISTE_FACTURE;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label NOM_FENETRE;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_RECHERCHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_CLIENT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_HT_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_TVA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_TTC_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAUX_REMISE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_BASE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMBRE_FACTURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_TOTAL_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_USER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Annulation_facture_;
    }
}