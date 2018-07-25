namespace CHM_CLIENT_APP
{
    partial class CHM_ARTICLE_FOURNISSEUR
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
            this.dgv_lise_fournisseur = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_RECHERCHE_FOURNISSEUR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.BTN_SELECT = new System.Windows.Forms.Button();
            this.BTN_FERMER = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ref_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rs_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lise_fournisseur)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.ref_fourn,
            this.rs_fourn});
            this.dgv_lise_fournisseur.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_lise_fournisseur.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_lise_fournisseur.Location = new System.Drawing.Point(14, 114);
            this.dgv_lise_fournisseur.Name = "dgv_lise_fournisseur";
            this.dgv_lise_fournisseur.ReadOnly = true;
            this.dgv_lise_fournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lise_fournisseur.Size = new System.Drawing.Size(409, 203);
            this.dgv_lise_fournisseur.StandardTab = true;
            this.dgv_lise_fournisseur.TabIndex = 1;
            this.dgv_lise_fournisseur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lise_fournisseur_CellDoubleClick);
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
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // MENU_RECHERCHE_FOURNISSEUR
            // 
            this.MENU_RECHERCHE_FOURNISSEUR.Location = new System.Drawing.Point(98, 89);
            this.MENU_RECHERCHE_FOURNISSEUR.Name = "MENU_RECHERCHE_FOURNISSEUR";
            this.MENU_RECHERCHE_FOURNISSEUR.Size = new System.Drawing.Size(212, 20);
            this.MENU_RECHERCHE_FOURNISSEUR.TabIndex = 4;
            this.MENU_RECHERCHE_FOURNISSEUR.TextChanged += new System.EventHandler(this.MENU_RECHERCHE_FOURNISSEUR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recherche :";
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.vcard_ajouter_icone_9305_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(343, 47);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(87, 36);
            this.BTN_AJOUTER.TabIndex = 5;
            this.BTN_AJOUTER.Text = "Ajouter";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_SELECT
            // 
            this.BTN_SELECT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SELECT.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_321;
            this.BTN_SELECT.Location = new System.Drawing.Point(196, 324);
            this.BTN_SELECT.Name = "BTN_SELECT";
            this.BTN_SELECT.Size = new System.Drawing.Size(111, 40);
            this.BTN_SELECT.TabIndex = 6;
            this.BTN_SELECT.Text = "Sélectionner";
            this.BTN_SELECT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_SELECT.UseVisualStyleBackColor = true;
            this.BTN_SELECT.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_FERMER
            // 
            this.BTN_FERMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_FERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_322;
            this.BTN_FERMER.Location = new System.Drawing.Point(313, 324);
            this.BTN_FERMER.Name = "BTN_FERMER";
            this.BTN_FERMER.Size = new System.Drawing.Size(111, 40);
            this.BTN_FERMER.TabIndex = 7;
            this.BTN_FERMER.Text = "Annuler";
            this.BTN_FERMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_FERMER.UseVisualStyleBackColor = true;
            this.BTN_FERMER.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(-4, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(33, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Liste des fournisseurs";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ref_fourn
            // 
            this.ref_fourn.DataPropertyName = "REF_FOURNISSEUR";
            this.ref_fourn.FillWeight = 34.27897F;
            this.ref_fourn.HeaderText = "Code";
            this.ref_fourn.Name = "ref_fourn";
            this.ref_fourn.ReadOnly = true;
            // 
            // rs_fourn
            // 
            this.rs_fourn.DataPropertyName = "RS_FOURNISSEUR";
            this.rs_fourn.FillWeight = 91.18206F;
            this.rs_fourn.HeaderText = "RS Fournisseur";
            this.rs_fourn.Name = "rs_fourn";
            this.rs_fourn.ReadOnly = true;
            // 
            // CHM_ARTICLE_FOURNISSEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SELECT);
            this.Controls.Add(this.dgv_lise_fournisseur);
            this.Controls.Add(this.MENU_RECHERCHE_FOURNISSEUR);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.BTN_FERMER);
            this.DoubleBuffered = true;
            this.Name = "CHM_ARTICLE_FOURNISSEUR";
            this.Text = "Liste des fournisseurs";
            this.Shown += new System.EventHandler(this.CHM_ARTICLE_FOURNISSEUR_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lise_fournisseur)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lise_fournisseur;
        private System.Windows.Forms.TextBox MENU_RECHERCHE_FOURNISSEUR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button BTN_SELECT;
        private System.Windows.Forms.Button BTN_FERMER;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rs_fourn;
    }
}