namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_FACTURE_CLIENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_LISTE_FACTURE = new System.Windows.Forms.DataGridView();
            this.CODE_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_TOTAL_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NOM_FENETRE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_RECHERCHE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
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
            this.MONTANT_TOTAL_FACTURE_,
            this.CREDIT_});
            this.dgv_LISTE_FACTURE.Location = new System.Drawing.Point(4, 94);
            this.dgv_LISTE_FACTURE.MultiSelect = false;
            this.dgv_LISTE_FACTURE.Name = "dgv_LISTE_FACTURE";
            this.dgv_LISTE_FACTURE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LISTE_FACTURE.Size = new System.Drawing.Size(580, 295);
            this.dgv_LISTE_FACTURE.TabIndex = 88;
            this.dgv_LISTE_FACTURE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LISTE_FACTURE_CellDoubleClick);
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
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATE_FACTURE_.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATE_FACTURE_.FillWeight = 107.38F;
            this.DATE_FACTURE_.HeaderText = "Date Création";
            this.DATE_FACTURE_.Name = "DATE_FACTURE_";
            // 
            // MONTANT_TOTAL_FACTURE_
            // 
            this.MONTANT_TOTAL_FACTURE_.DataPropertyName = "MONTANT_TOTAL_FACTURE";
            this.MONTANT_TOTAL_FACTURE_.FillWeight = 96.05759F;
            this.MONTANT_TOTAL_FACTURE_.HeaderText = "Montant";
            this.MONTANT_TOTAL_FACTURE_.Name = "MONTANT_TOTAL_FACTURE_";
            // 
            // CREDIT_
            // 
            this.CREDIT_.DataPropertyName = "CREDIT";
            this.CREDIT_.FillWeight = 97.19267F;
            this.CREDIT_.HeaderText = "Reste";
            this.CREDIT_.Name = "CREDIT_";
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
            this.groupBox5.Location = new System.Drawing.Point(-2, -8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(592, 58);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            // 
            // NOM_FENETRE
            // 
            this.NOM_FENETRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_FENETRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FENETRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NOM_FENETRE.Location = new System.Drawing.Point(6, 12);
            this.NOM_FENETRE.Name = "NOM_FENETRE";
            this.NOM_FENETRE.Size = new System.Drawing.Size(527, 42);
            this.NOM_FENETRE.TabIndex = 0;
            this.NOM_FENETRE.Text = "Liste des Factures Clients";
            this.NOM_FENETRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // TB_RECHERCHE
            // 
            this.TB_RECHERCHE.BackColor = System.Drawing.Color.White;
            this.TB_RECHERCHE.Location = new System.Drawing.Point(127, 64);
            this.TB_RECHERCHE.Name = "TB_RECHERCHE";
            this.TB_RECHERCHE.Size = new System.Drawing.Size(313, 20);
            this.TB_RECHERCHE.TabIndex = 90;
            this.TB_RECHERCHE.TextChanged += new System.EventHandler(this.TB_RECHERCHE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Recherche :";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(543, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 33);
            this.button6.TabIndex = 93;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CHM_LISTE_FACTURE_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 393);
            this.Controls.Add(this.dgv_LISTE_FACTURE);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_RECHERCHE);
            this.Controls.Add(this.label1);
            this.Name = "CHM_LISTE_FACTURE_CLIENT";
            this.Text = "Liste des Factures Clients";
            this.Shown += new System.EventHandler(this.CHM_LISTE_FACTURE_CLIENT_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_FACTURE)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LISTE_FACTURE;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label NOM_FENETRE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_RECHERCHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_TOTAL_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT_;
        private System.Windows.Forms.Button button6;
    }
}