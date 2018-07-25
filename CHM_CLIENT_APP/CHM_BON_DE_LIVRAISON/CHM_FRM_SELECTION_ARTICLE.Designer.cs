namespace CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON
{
    partial class CHM_FRM_SELECTION_ARTICLE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_SELECTION_ARTICLE));
            this.lb_magasin = new System.Windows.Forms.Label();
            this.dgv_Liste = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.recherche_article = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.panel_qte = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_validation_ajout = new System.Windows.Forms.Button();
            this.qte_select_article = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).BeginInit();
            this.panel_qte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qte_select_article)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_magasin
            // 
            this.lb_magasin.BackColor = System.Drawing.Color.Transparent;
            this.lb_magasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_magasin.ForeColor = System.Drawing.Color.Black;
            this.lb_magasin.Location = new System.Drawing.Point(511, 26);
            this.lb_magasin.Name = "lb_magasin";
            this.lb_magasin.Size = new System.Drawing.Size(242, 17);
            this.lb_magasin.TabIndex = 81;
            this.lb_magasin.Text = "label1";
            // 
            // dgv_Liste
            // 
            this.dgv_Liste.AllowUserToAddRows = false;
            this.dgv_Liste.AllowUserToDeleteRows = false;
            this.dgv_Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Liste.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Liste.Location = new System.Drawing.Point(12, 90);
            this.dgv_Liste.Name = "dgv_Liste";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Liste.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Liste.Size = new System.Drawing.Size(821, 300);
            this.dgv_Liste.TabIndex = 80;
            this.dgv_Liste.DoubleClick += new System.EventHandler(this.dgv_Liste_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "REF_ARTICLE";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 51.41389F;
            this.Column1.HeaderText = "Réf.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DESIGNATION_ARTICLE";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 203.9128F;
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QTTE_STOCK";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 64.92657F;
            this.Column3.HeaderText = "Qté Disponible";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PRIX_HT_V_ARTICLE";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FillWeight = 79.74677F;
            this.Column4.HeaderText = "Prix U. HT Vente";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 83;
            this.label1.Text = "Recherche :";
            // 
            // recherche_article
            // 
            this.recherche_article.Location = new System.Drawing.Point(102, 64);
            this.recherche_article.Name = "recherche_article";
            this.recherche_article.Size = new System.Drawing.Size(400, 20);
            this.recherche_article.TabIndex = 82;
            this.recherche_article.TextChanged += new System.EventHandler(this.recherche_article_TextChanged);
            // 
            // btn_select
            // 
            this.btn_select.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.btn_select.Location = new System.Drawing.Point(602, 396);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(111, 41);
            this.btn_select.TabIndex = 84;
            this.btn_select.Text = "Sélectionner";
            this.btn_select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Image = global::CHM_CLIENT_APP.Properties.Resources.porte_en_icone_7778_321;
            this.btn_annuler.Location = new System.Drawing.Point(722, 396);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(111, 41);
            this.btn_annuler.TabIndex = 84;
            this.btn_annuler.Text = "Terminer";
            this.btn_annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // panel_qte
            // 
            this.panel_qte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_qte.BackColor = System.Drawing.Color.Transparent;
            this.panel_qte.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.panel_qte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_qte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_qte.Controls.Add(this.button2);
            this.panel_qte.Controls.Add(this.btn_validation_ajout);
            this.panel_qte.Controls.Add(this.qte_select_article);
            this.panel_qte.Controls.Add(this.label9);
            this.panel_qte.Location = new System.Drawing.Point(299, 168);
            this.panel_qte.Name = "panel_qte";
            this.panel_qte.Size = new System.Drawing.Size(247, 140);
            this.panel_qte.TabIndex = 85;
            this.panel_qte.Visible = false;
            this.panel_qte.VisibleChanged += new System.EventHandler(this.panel_qte_VisibleChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(126, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_validation_ajout
            // 
            this.btn_validation_ajout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validation_ajout.Location = new System.Drawing.Point(45, 81);
            this.btn_validation_ajout.Name = "btn_validation_ajout";
            this.btn_validation_ajout.Size = new System.Drawing.Size(75, 45);
            this.btn_validation_ajout.TabIndex = 2;
            this.btn_validation_ajout.Text = "Ajouter";
            this.btn_validation_ajout.UseVisualStyleBackColor = true;
            this.btn_validation_ajout.Click += new System.EventHandler(this.btn_validation_ajout_Click);
            // 
            // qte_select_article
            // 
            this.qte_select_article.DecimalPlaces = 3;
            this.qte_select_article.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_select_article.Location = new System.Drawing.Point(116, 23);
            this.qte_select_article.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.qte_select_article.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qte_select_article.Name = "qte_select_article";
            this.qte_select_article.Size = new System.Drawing.Size(109, 26);
            this.qte_select_article.TabIndex = 0;
            this.qte_select_article.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qte_select_article.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qte_select_article.ValueChanged += new System.EventHandler(this.qte_select_article_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantité :";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Transparent;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(845, 48);
            this.entete_Formulaire_21.TabIndex = 86;
            // 
            // CHM_FRM_SELECTION_ARTICLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 449);
            this.Controls.Add(this.lb_magasin);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.panel_qte);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recherche_article);
            this.Controls.Add(this.dgv_Liste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_FRM_SELECTION_ARTICLE";
            this.Text = "Liste des Article en stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).EndInit();
            this.panel_qte.ResumeLayout(false);
            this.panel_qte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qte_select_article)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Liste;
        private System.Windows.Forms.Label lb_magasin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recherche_article;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel_qte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_validation_ajout;
        private System.Windows.Forms.NumericUpDown qte_select_article;
        private System.Windows.Forms.Label label9;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}