namespace CHM_CLIENT_APP.BON_RETOUR_CLIENT
{
    partial class CHM_LISTE_BON_RETOUR_CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_BON_RETOUR_CLIENT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_APERçU = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_RECHERCHE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(143, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(797, 403);
            this.dataGridView1.TabIndex = 81;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CODE_BRETOUR_CLIENT";
            this.Column1.HeaderText = "N° Bon de Retour";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CODE_FACTURE";
            this.Column2.HeaderText = "N° Facture";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DATE_BRETOUR_CLIENT";
            this.Column3.HeaderText = "Date de Retour";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MNT_BRETOUR";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "Montant";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "utilisateur";
            this.Column4.HeaderText = "Utilisateur";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // BTN_APERçU
            // 
            this.BTN_APERçU.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_APERçU.Image = global::CHM_CLIENT_APP.Properties.Resources.filefind_icone_7697_32;
            this.BTN_APERçU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_APERçU.Location = new System.Drawing.Point(12, 204);
            this.BTN_APERçU.Name = "BTN_APERçU";
            this.BTN_APERçU.Size = new System.Drawing.Size(125, 47);
            this.BTN_APERçU.TabIndex = 95;
            this.BTN_APERçU.Text = "Aperçu";
            this.BTN_APERçU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_APERçU.UseVisualStyleBackColor = false;
            this.BTN_APERçU.Click += new System.EventHandler(this.BTN_APERçU_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 47);
            this.button2.TabIndex = 94;
            this.button2.Text = "Afficher";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.ForeColor = System.Drawing.Color.Black;
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(12, 98);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(125, 47);
            this.BTN_AJOUTER.TabIndex = 93;
            this.BTN_AJOUTER.Text = "&Ajouter";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.BTN_AJOUTER_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(141, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // TB_RECHERCHE
            // 
            this.TB_RECHERCHE.Location = new System.Drawing.Point(251, 72);
            this.TB_RECHERCHE.Name = "TB_RECHERCHE";
            this.TB_RECHERCHE.Size = new System.Drawing.Size(332, 20);
            this.TB_RECHERCHE.TabIndex = 96;
            this.TB_RECHERCHE.TextChanged += new System.EventHandler(this.TB_RECHERCHE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Recherche :";
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(952, 48);
            this.entete_Formulaire_21.TabIndex = 99;
            // 
            // CHM_LISTE_BON_RETOUR_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 513);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_RECHERCHE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_APERçU);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CHM_LISTE_BON_RETOUR_CLIENT";
            this.Text = "Liste des Bons de Retour Client";
            this.Load += new System.EventHandler(this.CHM_LISTE_BON_RETOUR_CLIENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_APERçU;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_RECHERCHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}