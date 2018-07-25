namespace CHM_CLIENT_APP
{
    partial class SELLECTION_PRODUITS
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
            this.CATEGORIE = new System.Windows.Forms.ComboBox();
            this.PRODUITS = new System.Windows.Forms.CheckedListBox();
            this.dgv_liste_article = new System.Windows.Forms.DataGridView();
            this.ref_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marq_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_ht_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tva_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_TTC_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat_article = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_article)).BeginInit();
            this.SuspendLayout();
            // 
            // CATEGORIE
            // 
            this.CATEGORIE.FormattingEnabled = true;
            this.CATEGORIE.Location = new System.Drawing.Point(112, 21);
            this.CATEGORIE.Name = "CATEGORIE";
            this.CATEGORIE.Size = new System.Drawing.Size(156, 21);
            this.CATEGORIE.TabIndex = 0;
            this.CATEGORIE.SelectedIndexChanged += new System.EventHandler(this.CATEGORIE_SelectedIndexChanged);
            // 
            // PRODUITS
            // 
            this.PRODUITS.FormattingEnabled = true;
            this.PRODUITS.Location = new System.Drawing.Point(290, 21);
            this.PRODUITS.Name = "PRODUITS";
            this.PRODUITS.Size = new System.Drawing.Size(156, 124);
            this.PRODUITS.TabIndex = 1;
            this.PRODUITS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PRODUITS_MouseClick);
            // 
            // dgv_liste_article
            // 
            this.dgv_liste_article.AllowUserToAddRows = false;
            this.dgv_liste_article.AllowUserToDeleteRows = false;
            this.dgv_liste_article.AllowUserToResizeColumns = false;
            this.dgv_liste_article.AllowUserToResizeRows = false;
            this.dgv_liste_article.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_liste_article.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_article.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_article.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ref_article,
            this.Column2,
            this.marq_article,
            this.qte_article,
            this.Column1,
            this.prix_ht_vente,
            this.tva_article,
            this.prix_TTC_article,
            this.etat_article});
            this.dgv_liste_article.Location = new System.Drawing.Point(12, 162);
            this.dgv_liste_article.Name = "dgv_liste_article";
            this.dgv_liste_article.ReadOnly = true;
            this.dgv_liste_article.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste_article.Size = new System.Drawing.Size(688, 223);
            this.dgv_liste_article.TabIndex = 2;
            // 
            // ref_article
            // 
            this.ref_article.DataPropertyName = "REF_ARTICLE";
            this.ref_article.FillWeight = 69.63249F;
            this.ref_article.HeaderText = "Réf.";
            this.ref_article.Name = "ref_article";
            this.ref_article.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DESIGNATION_ARTICLE";
            this.Column2.FillWeight = 165.3627F;
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // marq_article
            // 
            this.marq_article.DataPropertyName = "MARQUE_ARTICLE";
            this.marq_article.FillWeight = 107.4928F;
            this.marq_article.HeaderText = "Marque";
            this.marq_article.Name = "marq_article";
            this.marq_article.ReadOnly = true;
            // 
            // qte_article
            // 
            this.qte_article.DataPropertyName = "QTE_ARTICLE";
            this.qte_article.FillWeight = 103.0486F;
            this.qte_article.HeaderText = "Quantité";
            this.qte_article.Name = "qte_article";
            this.qte_article.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "QTE_MIN_ARTICLE";
            this.Column1.FillWeight = 114.9778F;
            this.Column1.HeaderText = "QTE minimale";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // prix_ht_vente
            // 
            this.prix_ht_vente.DataPropertyName = "PRIX_HT_V_ARTICLE";
            this.prix_ht_vente.FillWeight = 106.4627F;
            this.prix_ht_vente.HeaderText = "Prix HT ";
            this.prix_ht_vente.Name = "prix_ht_vente";
            this.prix_ht_vente.ReadOnly = true;
            // 
            // tva_article
            // 
            this.tva_article.DataPropertyName = "TVA_ARTICLE";
            this.tva_article.FillWeight = 98.77116F;
            this.tva_article.HeaderText = "TVA";
            this.tva_article.Name = "tva_article";
            this.tva_article.ReadOnly = true;
            // 
            // prix_TTC_article
            // 
            this.prix_TTC_article.DataPropertyName = "PRIX_TTC_ARTICLE";
            this.prix_TTC_article.FillWeight = 91.67629F;
            this.prix_TTC_article.HeaderText = "Prix TTC";
            this.prix_TTC_article.Name = "prix_TTC_article";
            this.prix_TTC_article.ReadOnly = true;
            // 
            // etat_article
            // 
            this.etat_article.DataPropertyName = "ETAT_ARTICLE";
            this.etat_article.FillWeight = 42.57544F;
            this.etat_article.HeaderText = "Bloqué ?";
            this.etat_article.Name = "etat_article";
            this.etat_article.ReadOnly = true;
            this.etat_article.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.etat_article.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Terminer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SELLECTION_PRODUITS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_liste_article);
            this.Controls.Add(this.PRODUITS);
            this.Controls.Add(this.CATEGORIE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SELLECTION_PRODUITS";
            this.Text = "SELLECTION_PRODUITS";
            this.Load += new System.EventHandler(this.SELLECTION_PRODUITS_Load);
            this.Shown += new System.EventHandler(this.SELLECTION_PRODUITS_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_article)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CATEGORIE;
        private System.Windows.Forms.CheckedListBox PRODUITS;
        private System.Windows.Forms.DataGridView dgv_liste_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn marq_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_ht_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tva_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_TTC_article;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etat_article;
        private System.Windows.Forms.Button button1;
    }
}