namespace CHM_CLIENT_APP
{
    partial class CHM_AVOIR_CLIENT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NOM_FENETRE = new System.Windows.Forms.Label();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PARCOURIR_LISTE_CLIENT = new System.Windows.Forms.Button();
            this.REF_CLIENT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ref_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.NOM_FENETRE);
            this.groupBox1.Location = new System.Drawing.Point(-5, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NOM_FENETRE
            // 
            this.NOM_FENETRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_FENETRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FENETRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NOM_FENETRE.Location = new System.Drawing.Point(15, 17);
            this.NOM_FENETRE.Name = "NOM_FENETRE";
            this.NOM_FENETRE.Size = new System.Drawing.Size(763, 29);
            this.NOM_FENETRE.TabIndex = 2;
            this.NOM_FENETRE.Text = "AVOIR";
            this.NOM_FENETRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RS_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RS_CLIENT.Location = new System.Drawing.Point(76, 91);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(195, 20);
            this.RS_CLIENT.TabIndex = 33;
            this.RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(73, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Client :";
            // 
            // PARCOURIR_LISTE_CLIENT
            // 
            this.PARCOURIR_LISTE_CLIENT.AccessibleDescription = "dgsdfdsf";
            this.PARCOURIR_LISTE_CLIENT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PARCOURIR_LISTE_CLIENT.Image = global::CHM_CLIENT_APP.Properties.Resources.loupe;
            this.PARCOURIR_LISTE_CLIENT.Location = new System.Drawing.Point(277, 69);
            this.PARCOURIR_LISTE_CLIENT.Name = "PARCOURIR_LISTE_CLIENT";
            this.PARCOURIR_LISTE_CLIENT.Size = new System.Drawing.Size(41, 42);
            this.PARCOURIR_LISTE_CLIENT.TabIndex = 34;
            this.PARCOURIR_LISTE_CLIENT.UseVisualStyleBackColor = true;
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.REF_CLIENT.Location = new System.Drawing.Point(118, 69);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.Size = new System.Drawing.Size(153, 20);
            this.REF_CLIENT.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ref_article,
            this.designation,
            this.qte});
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 163);
            this.dataGridView1.TabIndex = 35;
            // 
            // ref_article
            // 
            this.ref_article.DataPropertyName = "REF_ARTICLE";
            this.ref_article.HeaderText = "Réf ";
            this.ref_article.Name = "ref_article";
            // 
            // designation
            // 
            this.designation.DataPropertyName = "DESIGNATION_ARTICLE";
            this.designation.HeaderText = "Désignation";
            this.designation.Name = "designation";
            // 
            // qte
            // 
            this.qte.DataPropertyName = "QTE_ARTICLE";
            this.qte.HeaderText = "Quantité";
            this.qte.Name = "qte";
            // 
            // CHM_AVOIR_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RS_CLIENT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PARCOURIR_LISTE_CLIENT);
            this.Controls.Add(this.REF_CLIENT);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CHM_AVOIR_CLIENT";
            this.Text = "CHM_AVOIR_CLIENT";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NOM_FENETRE;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PARCOURIR_LISTE_CLIENT;
        private System.Windows.Forms.TextBox REF_CLIENT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
    }
}