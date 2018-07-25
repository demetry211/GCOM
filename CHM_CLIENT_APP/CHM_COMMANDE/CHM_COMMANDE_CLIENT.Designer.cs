namespace CHM_CLIENT_APP
{
    partial class CHM_COMMANDE_CLIENT
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
            this.btn_selection = new System.Windows.Forms.Button();
            this.TB_RECHERCHE_CLT = new System.Windows.Forms.TextBox();
            this.buttonFERMER = new System.Windows.Forms.Button();
            this.dgv_liste_clt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.REF_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RS_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_clt)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_selection
            // 
            this.btn_selection.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.btn_selection.Location = new System.Drawing.Point(212, 301);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(111, 43);
            this.btn_selection.TabIndex = 7;
            this.btn_selection.Text = "Sélectionner";
            this.btn_selection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // TB_RECHERCHE_CLT
            // 
            this.TB_RECHERCHE_CLT.Location = new System.Drawing.Point(112, 68);
            this.TB_RECHERCHE_CLT.Name = "TB_RECHERCHE_CLT";
            this.TB_RECHERCHE_CLT.Size = new System.Drawing.Size(240, 20);
            this.TB_RECHERCHE_CLT.TabIndex = 4;
            this.TB_RECHERCHE_CLT.TextChanged += new System.EventHandler(this.TB_RECHERCHE_CLT_TextChanged);
            // 
            // buttonFERMER
            // 
            this.buttonFERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_321;
            this.buttonFERMER.Location = new System.Drawing.Point(329, 301);
            this.buttonFERMER.Name = "buttonFERMER";
            this.buttonFERMER.Size = new System.Drawing.Size(111, 43);
            this.buttonFERMER.TabIndex = 8;
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
            this.dgv_liste_clt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_liste_clt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_clt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_clt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF_CLIENT_,
            this.RS_CLIENT_});
            this.dgv_liste_clt.Location = new System.Drawing.Point(12, 96);
            this.dgv_liste_clt.MultiSelect = false;
            this.dgv_liste_clt.Name = "dgv_liste_clt";
            this.dgv_liste_clt.ReadOnly = true;
            this.dgv_liste_clt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste_clt.Size = new System.Drawing.Size(429, 199);
            this.dgv_liste_clt.TabIndex = 6;
            this.dgv_liste_clt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_liste_clt_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recherche :";
            // 
            // button1
            // 
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_321;
            this.button1.Location = new System.Drawing.Point(12, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nouveau Client";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(-2, -10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 55);
            this.groupBox5.TabIndex = 78;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(57, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Liste des Clients";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // REF_CLIENT_
            // 
            this.REF_CLIENT_.DataPropertyName = "REF_CLIENT";
            this.REF_CLIENT_.FillWeight = 74.90637F;
            this.REF_CLIENT_.HeaderText = "Réf.";
            this.REF_CLIENT_.Name = "REF_CLIENT_";
            this.REF_CLIENT_.ReadOnly = true;
            // 
            // RS_CLIENT_
            // 
            this.RS_CLIENT_.DataPropertyName = "RS_CLIENT";
            this.RS_CLIENT_.FillWeight = 127.3609F;
            this.RS_CLIENT_.HeaderText = "Raison sociale";
            this.RS_CLIENT_.Name = "RS_CLIENT_";
            this.RS_CLIENT_.ReadOnly = true;
            // 
            // CHM_COMMANDE_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 356);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_selection);
            this.Controls.Add(this.TB_RECHERCHE_CLT);
            this.Controls.Add(this.buttonFERMER);
            this.Controls.Add(this.dgv_liste_clt);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_COMMANDE_CLIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Clients";
            this.Shown += new System.EventHandler(this.CHM_COMMANDE_CLIENT_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_clt)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.TextBox TB_RECHERCHE_CLT;
        private System.Windows.Forms.Button buttonFERMER;
        private System.Windows.Forms.DataGridView dgv_liste_clt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_CLIENT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn RS_CLIENT_;
    }
}