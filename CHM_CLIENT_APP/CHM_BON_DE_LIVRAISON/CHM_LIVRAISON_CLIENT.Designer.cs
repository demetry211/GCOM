namespace CHM_CLIENT_APP
{
    partial class CHM_LIVRAISON_CLIENT
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NOM_FENETRE = new System.Windows.Forms.Label();
            this.EMPLOYE = new System.Windows.Forms.ComboBox();
            this.dgv_LISTE_B_LIV = new System.Windows.Forms.DataGridView();
            this.CODE_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURED_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LIVRED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_AJOUT = new System.Windows.Forms.Button();
            this.BTN_SUPPRIMER = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_B_LIV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.NOM_FENETRE);
            this.groupBox3.Location = new System.Drawing.Point(-2, -8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 54);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // NOM_FENETRE
            // 
            this.NOM_FENETRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_FENETRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FENETRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NOM_FENETRE.Location = new System.Drawing.Point(49, 16);
            this.NOM_FENETRE.Name = "NOM_FENETRE";
            this.NOM_FENETRE.Size = new System.Drawing.Size(614, 29);
            this.NOM_FENETRE.TabIndex = 1;
            this.NOM_FENETRE.Text = "Livraison";
            this.NOM_FENETRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EMPLOYE
            // 
            this.EMPLOYE.FormattingEnabled = true;
            this.EMPLOYE.Location = new System.Drawing.Point(178, 300);
            this.EMPLOYE.Name = "EMPLOYE";
            this.EMPLOYE.Size = new System.Drawing.Size(191, 21);
            this.EMPLOYE.TabIndex = 49;
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
            this.dgv_LISTE_B_LIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LISTE_B_LIV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_B_LIV_,
            this.DATE_B_LIV_,
            this.Column1,
            this.FACTURED_,
            this.LIVRED});
            this.dgv_LISTE_B_LIV.Location = new System.Drawing.Point(9, 102);
            this.dgv_LISTE_B_LIV.MultiSelect = false;
            this.dgv_LISTE_B_LIV.Name = "dgv_LISTE_B_LIV";
            this.dgv_LISTE_B_LIV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LISTE_B_LIV.Size = new System.Drawing.Size(652, 192);
            this.dgv_LISTE_B_LIV.TabIndex = 50;
            // 
            // CODE_B_LIV_
            // 
            this.CODE_B_LIV_.DataPropertyName = "CODE_B_LIV";
            this.CODE_B_LIV_.FillWeight = 165.7425F;
            this.CODE_B_LIV_.HeaderText = "N° Bon de livraison";
            this.CODE_B_LIV_.Name = "CODE_B_LIV_";
            this.CODE_B_LIV_.ReadOnly = true;
            // 
            // DATE_B_LIV_
            // 
            this.DATE_B_LIV_.DataPropertyName = "DATE_B_LIV";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATE_B_LIV_.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATE_B_LIV_.FillWeight = 108.1848F;
            this.DATE_B_LIV_.HeaderText = "Date de préparation";
            this.DATE_B_LIV_.Name = "DATE_B_LIV_";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date d\'expiration";
            this.Column1.Name = "Column1";
            // 
            // FACTURED_
            // 
            this.FACTURED_.DataPropertyName = "FACTURED";
            this.FACTURED_.FillWeight = 78.92999F;
            this.FACTURED_.HeaderText = "Facturé ?";
            this.FACTURED_.Name = "FACTURED_";
            this.FACTURED_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FACTURED_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LIVRED
            // 
            this.LIVRED.DataPropertyName = "LIVRE";
            this.LIVRED.FillWeight = 86.03567F;
            this.LIVRED.HeaderText = "Livré ?";
            this.LIVRED.Name = "LIVRED";
            this.LIVRED.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LIVRED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Magasinier responsable :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Liste des bons de livraison à livrer :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.archiver_dossier_services_publics_icone_7132_64;
            this.button1.Location = new System.Drawing.Point(461, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 70);
            this.button1.TabIndex = 53;
            this.button1.Text = "Livrer";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_AJOUT
            // 
            this.BTN_AJOUT.Image = global::CHM_CLIENT_APP.Properties.Resources.pass_small;
            this.BTN_AJOUT.Location = new System.Drawing.Point(461, 74);
            this.BTN_AJOUT.Name = "BTN_AJOUT";
            this.BTN_AJOUT.Size = new System.Drawing.Size(97, 23);
            this.BTN_AJOUT.TabIndex = 54;
            this.BTN_AJOUT.Text = "&Insèrer";
            this.BTN_AJOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUT.UseVisualStyleBackColor = true;
            // 
            // BTN_SUPPRIMER
            // 
            this.BTN_SUPPRIMER.Image = global::CHM_CLIENT_APP.Properties.Resources.na_2;
            this.BTN_SUPPRIMER.Location = new System.Drawing.Point(564, 74);
            this.BTN_SUPPRIMER.Name = "BTN_SUPPRIMER";
            this.BTN_SUPPRIMER.Size = new System.Drawing.Size(97, 23);
            this.BTN_SUPPRIMER.TabIndex = 55;
            this.BTN_SUPPRIMER.Text = "&Eliminer";
            this.BTN_SUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_SUPPRIMER.UseVisualStyleBackColor = true;
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
            this.button6.Location = new System.Drawing.Point(6, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 33);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CHM_LIVRAISON_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 426);
            this.Controls.Add(this.BTN_SUPPRIMER);
            this.Controls.Add(this.BTN_AJOUT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LISTE_B_LIV);
            this.Controls.Add(this.EMPLOYE);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Name = "CHM_LIVRAISON_CLIENT";
            this.Text = "CHM_LIVRAISON_CLIENT";
            this.Shown += new System.EventHandler(this.CHM_LIVRAISON_CLIENT_Shown);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_B_LIV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NOM_FENETRE;
        private System.Windows.Forms.ComboBox EMPLOYE;
        private System.Windows.Forms.DataGridView dgv_LISTE_B_LIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FACTURED_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LIVRED;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_AJOUT;
        private System.Windows.Forms.Button BTN_SUPPRIMER;
        private System.Windows.Forms.Button button6;
    }
}