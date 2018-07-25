namespace CHM_CLIENT_APP
{
    partial class CHM_ARTICLE_MAGAZIN
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
            this.MENU_RECHERCHE_CATEGORIE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_lise_fournisseur = new System.Windows.Forms.DataGridView();
            this.code_mag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.BTN_SELECT = new System.Windows.Forms.Button();
            this.BTN_FERMER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lise_fournisseur)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU_RECHERCHE_CATEGORIE
            // 
            this.MENU_RECHERCHE_CATEGORIE.Location = new System.Drawing.Point(84, 91);
            this.MENU_RECHERCHE_CATEGORIE.Name = "MENU_RECHERCHE_CATEGORIE";
            this.MENU_RECHERCHE_CATEGORIE.Size = new System.Drawing.Size(212, 20);
            this.MENU_RECHERCHE_CATEGORIE.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recherche :";
            // 
            // dgv_lise_fournisseur
            // 
            this.dgv_lise_fournisseur.AllowUserToAddRows = false;
            this.dgv_lise_fournisseur.AllowUserToDeleteRows = false;
            this.dgv_lise_fournisseur.AllowUserToResizeColumns = false;
            this.dgv_lise_fournisseur.AllowUserToResizeRows = false;
            this.dgv_lise_fournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lise_fournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lise_fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lise_fournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_mag,
            this.nom_mag});
            this.dgv_lise_fournisseur.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_lise_fournisseur.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_lise_fournisseur.Location = new System.Drawing.Point(12, 117);
            this.dgv_lise_fournisseur.Name = "dgv_lise_fournisseur";
            this.dgv_lise_fournisseur.ReadOnly = true;
            this.dgv_lise_fournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lise_fournisseur.Size = new System.Drawing.Size(420, 206);
            this.dgv_lise_fournisseur.StandardTab = true;
            this.dgv_lise_fournisseur.TabIndex = 16;
            // 
            // code_mag
            // 
            this.code_mag.DataPropertyName = "CODE_MAG";
            this.code_mag.FillWeight = 54.3162F;
            this.code_mag.HeaderText = "Code";
            this.code_mag.Name = "code_mag";
            this.code_mag.ReadOnly = true;
            // 
            // nom_mag
            // 
            this.nom_mag.DataPropertyName = "NOM_MAG";
            this.nom_mag.FillWeight = 71.14483F;
            this.nom_mag.HeaderText = "Magasin";
            this.nom_mag.Name = "nom_mag";
            this.nom_mag.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.actualiserToolStripMenuItem.Text = "&Actualiser";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(-4, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 53);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(19, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(386, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Liste des dépots";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_321;
            this.BTN_AJOUTER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(347, 49);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(87, 40);
            this.BTN_AJOUTER.TabIndex = 19;
            this.BTN_AJOUTER.Text = "&Ajouter";
            this.BTN_AJOUTER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            // 
            // BTN_SELECT
            // 
            this.BTN_SELECT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SELECT.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.BTN_SELECT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SELECT.Location = new System.Drawing.Point(207, 329);
            this.BTN_SELECT.Name = "BTN_SELECT";
            this.BTN_SELECT.Size = new System.Drawing.Size(111, 39);
            this.BTN_SELECT.TabIndex = 20;
            this.BTN_SELECT.Text = "&Sélectionner";
            this.BTN_SELECT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SELECT.UseVisualStyleBackColor = true;
            // 
            // BTN_FERMER
            // 
            this.BTN_FERMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_FERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_322;
            this.BTN_FERMER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FERMER.Location = new System.Drawing.Point(324, 329);
            this.BTN_FERMER.Name = "BTN_FERMER";
            this.BTN_FERMER.Size = new System.Drawing.Size(111, 39);
            this.BTN_FERMER.TabIndex = 21;
            this.BTN_FERMER.Text = "&Fermer";
            this.BTN_FERMER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_FERMER.UseVisualStyleBackColor = true;
            // 
            // CHM_ARTICLE_MAGAZIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MENU_RECHERCHE_CATEGORIE);
            this.Controls.Add(this.dgv_lise_fournisseur);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SELECT);
            this.Controls.Add(this.BTN_FERMER);
            this.Name = "CHM_ARTICLE_MAGAZIN";
            this.Text = "Liste des dépots";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lise_fournisseur)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MENU_RECHERCHE_CATEGORIE;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button BTN_SELECT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_lise_fournisseur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.Button BTN_FERMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mag;
    }
}