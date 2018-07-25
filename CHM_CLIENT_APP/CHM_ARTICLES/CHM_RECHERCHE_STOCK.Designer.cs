namespace CHM_CLIENT_APP
{
    partial class CHM_RECHERCHE_STOCK
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
            this.dgv_liste_article_en_stock = new System.Windows.Forms.DataGridView();
            this.btn_selection = new System.Windows.Forms.Button();
            this.buttonFERMER = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ref_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtte_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_article_en_stock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_liste_article_en_stock
            // 
            this.dgv_liste_article_en_stock.AllowUserToAddRows = false;
            this.dgv_liste_article_en_stock.AllowUserToDeleteRows = false;
            this.dgv_liste_article_en_stock.AllowUserToResizeColumns = false;
            this.dgv_liste_article_en_stock.AllowUserToResizeRows = false;
            this.dgv_liste_article_en_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_liste_article_en_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_article_en_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_article_en_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ref_article,
            this.designation_article,
            this.nom_mag,
            this.qtte_stock});
            this.dgv_liste_article_en_stock.Location = new System.Drawing.Point(12, 62);
            this.dgv_liste_article_en_stock.MultiSelect = false;
            this.dgv_liste_article_en_stock.Name = "dgv_liste_article_en_stock";
            this.dgv_liste_article_en_stock.ReadOnly = true;
            this.dgv_liste_article_en_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste_article_en_stock.Size = new System.Drawing.Size(531, 272);
            this.dgv_liste_article_en_stock.TabIndex = 7;
            // 
            // btn_selection
            // 
            this.btn_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selection.Location = new System.Drawing.Point(316, 340);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(111, 27);
            this.btn_selection.TabIndex = 9;
            this.btn_selection.Text = "Sélectionner";
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // buttonFERMER
            // 
            this.buttonFERMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFERMER.Location = new System.Drawing.Point(433, 340);
            this.buttonFERMER.Name = "buttonFERMER";
            this.buttonFERMER.Size = new System.Drawing.Size(111, 27);
            this.buttonFERMER.TabIndex = 10;
            this.buttonFERMER.Text = "Annuler";
            this.buttonFERMER.UseVisualStyleBackColor = true;
            this.buttonFERMER.Click += new System.EventHandler(this.buttonFERMER_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détail de stockage de l\'article par magasin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ref_article
            // 
            this.ref_article.DataPropertyName = "REF_ARTICLE";
            this.ref_article.FillWeight = 71.53076F;
            this.ref_article.HeaderText = "Réf.";
            this.ref_article.Name = "ref_article";
            this.ref_article.ReadOnly = true;
            // 
            // designation_article
            // 
            this.designation_article.DataPropertyName = "DESIGNATION_ARTICLE";
            this.designation_article.FillWeight = 176.34F;
            this.designation_article.HeaderText = "Désignation";
            this.designation_article.Name = "designation_article";
            this.designation_article.ReadOnly = true;
            // 
            // nom_mag
            // 
            this.nom_mag.DataPropertyName = "NOM_MAG";
            this.nom_mag.FillWeight = 102.6726F;
            this.nom_mag.HeaderText = "Magasin";
            this.nom_mag.Name = "nom_mag";
            this.nom_mag.ReadOnly = true;
            // 
            // qtte_stock
            // 
            this.qtte_stock.DataPropertyName = "QTTE_STOCK";
            this.qtte_stock.FillWeight = 76.72491F;
            this.qtte_stock.HeaderText = "Qte";
            this.qtte_stock.Name = "qtte_stock";
            this.qtte_stock.ReadOnly = true;
            // 
            // CHM_RECHERCHE_STOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_selection);
            this.Controls.Add(this.buttonFERMER);
            this.Controls.Add(this.dgv_liste_article_en_stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_RECHERCHE_STOCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail de stockage de l\'article par magasin";
            this.Shown += new System.EventHandler(this.CHM_RECHERCHE_STOCK_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_article_en_stock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste_article_en_stock;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.Button buttonFERMER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtte_stock;
    }
}