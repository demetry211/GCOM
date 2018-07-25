namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_BONS_LIVRAISON
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_BONS_LIVRAISON));
            this.dgv_LISTE_B_LIV = new System.Windows.Forms.DataGridView();
            this.CODE_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_USER_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREPARED_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LIVRED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FACTURED_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_RECHERCHE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Aperçu_cmd = new System.Windows.Forms.Button();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.BTN_DETAIL = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_B_LIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LISTE_B_LIV
            // 
            this.dgv_LISTE_B_LIV.AllowUserToAddRows = false;
            this.dgv_LISTE_B_LIV.AllowUserToDeleteRows = false;
            this.dgv_LISTE_B_LIV.AllowUserToResizeColumns = false;
            this.dgv_LISTE_B_LIV.AllowUserToResizeRows = false;
            this.dgv_LISTE_B_LIV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LISTE_B_LIV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LISTE_B_LIV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LISTE_B_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LISTE_B_LIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_B_LIV_,
            this.DATE_B_LIV_,
            this.CODE_CLIENT_,
            this.CODE_COMMANDE_,
            this.Column1,
            this.CODE_USER_,
            this.PREPARED_,
            this.LIVRED,
            this.FACTURED_,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LISTE_B_LIV.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_LISTE_B_LIV.Location = new System.Drawing.Point(124, 102);
            this.dgv_LISTE_B_LIV.MultiSelect = false;
            this.dgv_LISTE_B_LIV.Name = "dgv_LISTE_B_LIV";
            this.dgv_LISTE_B_LIV.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LISTE_B_LIV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_LISTE_B_LIV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LISTE_B_LIV.Size = new System.Drawing.Size(835, 348);
            this.dgv_LISTE_B_LIV.TabIndex = 35;
            this.dgv_LISTE_B_LIV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LISTE_B_LIV_CellDoubleClick);
            // 
            // CODE_B_LIV_
            // 
            this.CODE_B_LIV_.DataPropertyName = "CODE_B_LIV";
            this.CODE_B_LIV_.FillWeight = 123.5436F;
            this.CODE_B_LIV_.HeaderText = "Code B.L.";
            this.CODE_B_LIV_.Name = "CODE_B_LIV_";
            this.CODE_B_LIV_.ReadOnly = true;
            // 
            // DATE_B_LIV_
            // 
            this.DATE_B_LIV_.DataPropertyName = "DATE_B_LIV";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DATE_B_LIV_.DefaultCellStyle = dataGridViewCellStyle2;
            this.DATE_B_LIV_.FillWeight = 109.7423F;
            this.DATE_B_LIV_.HeaderText = "Date";
            this.DATE_B_LIV_.Name = "DATE_B_LIV_";
            this.DATE_B_LIV_.ReadOnly = true;
            // 
            // CODE_CLIENT_
            // 
            this.CODE_CLIENT_.DataPropertyName = "RS_CLIENT";
            dataGridViewCellStyle3.NullValue = null;
            this.CODE_CLIENT_.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_CLIENT_.FillWeight = 198.4842F;
            this.CODE_CLIENT_.HeaderText = "Client";
            this.CODE_CLIENT_.Name = "CODE_CLIENT_";
            this.CODE_CLIENT_.ReadOnly = true;
            // 
            // CODE_COMMANDE_
            // 
            this.CODE_COMMANDE_.DataPropertyName = "CODE_COMMANDE";
            this.CODE_COMMANDE_.FillWeight = 106.5831F;
            this.CODE_COMMANDE_.HeaderText = "Code Commande";
            this.CODE_COMMANDE_.Name = "CODE_COMMANDE_";
            this.CODE_COMMANDE_.ReadOnly = true;
            this.CODE_COMMANDE_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NOM_MAG";
            this.Column1.FillWeight = 152.8814F;
            this.Column1.HeaderText = "Magasin";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CODE_USER_
            // 
            this.CODE_USER_.DataPropertyName = "UTIL";
            this.CODE_USER_.FillWeight = 149.8106F;
            this.CODE_USER_.HeaderText = "Utilisateur";
            this.CODE_USER_.Name = "CODE_USER_";
            this.CODE_USER_.ReadOnly = true;
            // 
            // PREPARED_
            // 
            this.PREPARED_.DataPropertyName = "PREPARED";
            this.PREPARED_.FillWeight = 59.44917F;
            this.PREPARED_.HeaderText = "Préparé";
            this.PREPARED_.Name = "PREPARED_";
            this.PREPARED_.ReadOnly = true;
            this.PREPARED_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PREPARED_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LIVRED
            // 
            this.LIVRED.DataPropertyName = "LIVRE";
            this.LIVRED.FillWeight = 58.76171F;
            this.LIVRED.HeaderText = "Livré";
            this.LIVRED.Name = "LIVRED";
            this.LIVRED.ReadOnly = true;
            this.LIVRED.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LIVRED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FACTURED_
            // 
            this.FACTURED_.DataPropertyName = "FACTURED";
            this.FACTURED_.FillWeight = 58.20479F;
            this.FACTURED_.HeaderText = "Facturé";
            this.FACTURED_.Name = "FACTURED_";
            this.FACTURED_.ReadOnly = true;
            this.FACTURED_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FACTURED_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ANNULE";
            this.Column2.FillWeight = 57.77586F;
            this.Column2.HeaderText = "Annulé";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(124, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // TB_RECHERCHE
            // 
            this.TB_RECHERCHE.Location = new System.Drawing.Point(243, 72);
            this.TB_RECHERCHE.Name = "TB_RECHERCHE";
            this.TB_RECHERCHE.Size = new System.Drawing.Size(389, 20);
            this.TB_RECHERCHE.TabIndex = 80;
            this.TB_RECHERCHE.TextChanged += new System.EventHandler(this.TB_RECHERCHE_CLT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Recherche :";
            // 
            // BTN_Aperçu_cmd
            // 
            this.BTN_Aperçu_cmd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Aperçu_cmd.Image = global::CHM_CLIENT_APP.Properties.Resources.pdf_icone_6190_48;
            this.BTN_Aperçu_cmd.Location = new System.Drawing.Point(8, 212);
            this.BTN_Aperçu_cmd.Name = "BTN_Aperçu_cmd";
            this.BTN_Aperçu_cmd.Size = new System.Drawing.Size(110, 49);
            this.BTN_Aperçu_cmd.TabIndex = 84;
            this.BTN_Aperçu_cmd.Text = "Aperçu [F8]";
            this.BTN_Aperçu_cmd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aperçu_cmd.UseVisualStyleBackColor = true;
            this.BTN_Aperçu_cmd.Click += new System.EventHandler(this.BTN_Aperçu_cmd_Click);
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.ForeColor = System.Drawing.Color.Black;
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(8, 102);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(110, 49);
            this.BTN_AJOUTER.TabIndex = 86;
            this.BTN_AJOUTER.Text = "Ajouter [F6]";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.BTN_AJOUTER_Click);
            // 
            // BTN_DETAIL
            // 
            this.BTN_DETAIL.ForeColor = System.Drawing.Color.Black;
            this.BTN_DETAIL.Image = global::CHM_CLIENT_APP.Properties.Resources.document_revenir_icone_4759_32;
            this.BTN_DETAIL.Location = new System.Drawing.Point(8, 157);
            this.BTN_DETAIL.Name = "BTN_DETAIL";
            this.BTN_DETAIL.Size = new System.Drawing.Size(110, 49);
            this.BTN_DETAIL.TabIndex = 85;
            this.BTN_DETAIL.Text = "Détails [F7]";
            this.BTN_DETAIL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_DETAIL.UseVisualStyleBackColor = true;
            this.BTN_DETAIL.Click += new System.EventHandler(this.BTN_DETAIL_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.ForeColor = System.Drawing.Color.Black;
            this.btn_annuler.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_322;
            this.btn_annuler.Location = new System.Drawing.Point(8, 267);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(110, 49);
            this.btn_annuler.TabIndex = 86;
            this.btn_annuler.Text = "Annuler [F9]";
            this.btn_annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(971, 48);
            this.entete_Formulaire_21.TabIndex = 87;
            // 
            // CHM_LISTE_BONS_LIVRAISON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 462);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.BTN_DETAIL);
            this.Controls.Add(this.BTN_Aperçu_cmd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_RECHERCHE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LISTE_B_LIV);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_LISTE_BONS_LIVRAISON";
            this.Text = "Liste des Bons de Livraison";
            this.Load += new System.EventHandler(this.CHM_LISTE_BONS_LIVRAISON_Load);
            this.Shown += new System.EventHandler(this.CHM_LISTE_BONS_LIVRAISON_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_BONS_LIVRAISON_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_B_LIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LISTE_B_LIV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_RECHERCHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Aperçu_cmd;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button BTN_DETAIL;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_CLIENT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_USER_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PREPARED_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LIVRED;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FACTURED_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}