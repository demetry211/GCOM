namespace CHM_CLIENT_APP.CHM_FOURNISSEUR
{
    partial class CHM_FRM_SELECT_FOURNISSEUR
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_selection = new System.Windows.Forms.Button();
            this.TB_RECHERCHE_CLT = new System.Windows.Forms.TextBox();
            this.buttonFERMER = new System.Windows.Forms.Button();
            this.dgv_liste_clt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this._REF_FOURNISSEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RS_FOURNISSEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_clt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(-2, -8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(426, 55);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(29, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(372, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Liste des Fournisseurs";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_321;
            this.button1.Location = new System.Drawing.Point(12, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 84;
            this.button1.Text = "Ajouter";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_selection
            // 
            this.btn_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selection.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.btn_selection.Location = new System.Drawing.Point(181, 325);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(111, 43);
            this.btn_selection.TabIndex = 82;
            this.btn_selection.Text = "Sélectionner";
            this.btn_selection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // TB_RECHERCHE_CLT
            // 
            this.TB_RECHERCHE_CLT.Location = new System.Drawing.Point(99, 53);
            this.TB_RECHERCHE_CLT.Name = "TB_RECHERCHE_CLT";
            this.TB_RECHERCHE_CLT.Size = new System.Drawing.Size(256, 20);
            this.TB_RECHERCHE_CLT.TabIndex = 79;
            this.TB_RECHERCHE_CLT.TextChanged += new System.EventHandler(this.TB_RECHERCHE_CLT_TextChanged);
            this.TB_RECHERCHE_CLT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_RECHERCHE_CLT_KeyDown);
            // 
            // buttonFERMER
            // 
            this.buttonFERMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_321;
            this.buttonFERMER.Location = new System.Drawing.Point(298, 325);
            this.buttonFERMER.Name = "buttonFERMER";
            this.buttonFERMER.Size = new System.Drawing.Size(111, 43);
            this.buttonFERMER.TabIndex = 83;
            this.buttonFERMER.Text = "Annuler";
            this.buttonFERMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFERMER.UseVisualStyleBackColor = true;
            this.buttonFERMER.Click += new System.EventHandler(this.buttonFERMER_Click);
            // 
            // dgv_liste_clt
            // 
            this.dgv_liste_clt.AllowUserToAddRows = false;
            this.dgv_liste_clt.AllowUserToDeleteRows = false;
            this.dgv_liste_clt.AllowUserToResizeColumns = false;
            this.dgv_liste_clt.AllowUserToResizeRows = false;
            this.dgv_liste_clt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_liste_clt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_clt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_clt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._REF_FOURNISSEUR,
            this._RS_FOURNISSEUR});
            this.dgv_liste_clt.Location = new System.Drawing.Point(12, 79);
            this.dgv_liste_clt.MultiSelect = false;
            this.dgv_liste_clt.Name = "dgv_liste_clt";
            this.dgv_liste_clt.ReadOnly = true;
            this.dgv_liste_clt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste_clt.Size = new System.Drawing.Size(397, 238);
            this.dgv_liste_clt.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 80;
            this.label1.Text = "Recherche :";
            // 
            // _REF_FOURNISSEUR
            // 
            this._REF_FOURNISSEUR.DataPropertyName = "REF_FOURNISSEUR";
            this._REF_FOURNISSEUR.FillWeight = 74.90637F;
            this._REF_FOURNISSEUR.HeaderText = "Réf.";
            this._REF_FOURNISSEUR.Name = "_REF_FOURNISSEUR";
            this._REF_FOURNISSEUR.ReadOnly = true;
            // 
            // _RS_FOURNISSEUR
            // 
            this._RS_FOURNISSEUR.DataPropertyName = "RS_FOURNISSEUR";
            this._RS_FOURNISSEUR.FillWeight = 127.3609F;
            this._RS_FOURNISSEUR.HeaderText = "Raison Sociale";
            this._RS_FOURNISSEUR.Name = "_RS_FOURNISSEUR";
            this._RS_FOURNISSEUR.ReadOnly = true;
            // 
            // CHM_FRM_SELECT_FOURNISSEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 380);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_selection);
            this.Controls.Add(this.TB_RECHERCHE_CLT);
            this.Controls.Add(this.buttonFERMER);
            this.Controls.Add(this.dgv_liste_clt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_FRM_SELECT_FOURNISSEUR";
            this.Text = "Liste des Fournisseurs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_SELECT_FOURNISSEUR_KeyDown);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_clt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.TextBox TB_RECHERCHE_CLT;
        private System.Windows.Forms.Button buttonFERMER;
        private System.Windows.Forms.DataGridView dgv_liste_clt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _REF_FOURNISSEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RS_FOURNISSEUR;
    }
}