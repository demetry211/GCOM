namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_MAGAZIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_MAGAZIN));
            this.dgv_magazin = new System.Windows.Forms.DataGridView();
            this.nom_mag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adr_mag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_mag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rs_societe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_MAGAZIN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RECHERCHE_MAG = new System.Windows.Forms.TextBox();
            this.BTN_MODIFIER = new System.Windows.Forms.Button();
            this.BTN_SUPPRIMER = new System.Windows.Forms.Button();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_inventaire = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magazin)).BeginInit();
            this.CMS_MAGAZIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_magazin
            // 
            this.dgv_magazin.AllowUserToAddRows = false;
            this.dgv_magazin.AllowUserToDeleteRows = false;
            this.dgv_magazin.AllowUserToResizeColumns = false;
            this.dgv_magazin.AllowUserToResizeRows = false;
            this.dgv_magazin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_magazin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_magazin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_magazin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_mag,
            this.adr_mag,
            this.tel_mag,
            this.rs_societe});
            this.dgv_magazin.ContextMenuStrip = this.CMS_MAGAZIN;
            this.dgv_magazin.Location = new System.Drawing.Point(13, 149);
            this.dgv_magazin.Name = "dgv_magazin";
            this.dgv_magazin.ReadOnly = true;
            this.dgv_magazin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_magazin.Size = new System.Drawing.Size(676, 239);
            this.dgv_magazin.TabIndex = 0;
            // 
            // nom_mag
            // 
            this.nom_mag.DataPropertyName = "NOM_MAG";
            this.nom_mag.FillWeight = 81.81818F;
            this.nom_mag.HeaderText = "Magasin";
            this.nom_mag.Name = "nom_mag";
            this.nom_mag.ReadOnly = true;
            // 
            // adr_mag
            // 
            this.adr_mag.DataPropertyName = "ADRESSE_MAG";
            this.adr_mag.FillWeight = 173.6549F;
            this.adr_mag.HeaderText = "Adresse";
            this.adr_mag.Name = "adr_mag";
            this.adr_mag.ReadOnly = true;
            // 
            // tel_mag
            // 
            this.tel_mag.DataPropertyName = "TEL_MAG";
            this.tel_mag.FillWeight = 44.5269F;
            this.tel_mag.HeaderText = "Tel.";
            this.tel_mag.Name = "tel_mag";
            this.tel_mag.ReadOnly = true;
            // 
            // rs_societe
            // 
            this.rs_societe.DataPropertyName = "RS_SOCIETE";
            this.rs_societe.HeaderText = "Société";
            this.rs_societe.Name = "rs_societe";
            this.rs_societe.ReadOnly = true;
            this.rs_societe.Visible = false;
            // 
            // CMS_MAGAZIN
            // 
            this.CMS_MAGAZIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.supprimerToolStripMenuItem});
            this.CMS_MAGAZIN.Name = "CMS_MAGAZIN";
            this.CMS_MAGAZIN.Size = new System.Drawing.Size(168, 98);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nouveauToolStripMenuItem.Text = "&Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifierToolStripMenuItem.Text = "&Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "&Supprimer";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.supprimerToolStripMenuItem.Text = "&Actualiser";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche :";
            // 
            // RECHERCHE_MAG
            // 
            this.RECHERCHE_MAG.Location = new System.Drawing.Point(129, 123);
            this.RECHERCHE_MAG.Name = "RECHERCHE_MAG";
            this.RECHERCHE_MAG.Size = new System.Drawing.Size(197, 20);
            this.RECHERCHE_MAG.TabIndex = 3;
            this.RECHERCHE_MAG.TextChanged += new System.EventHandler(this.RECHERCHE_MAG_TextChanged);
            // 
            // BTN_MODIFIER
            // 
            this.BTN_MODIFIER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_MODIFIER.Image = global::CHM_CLIENT_APP.Properties.Resources.arrow_tourner_vers_la_droite_icone_8357_32;
            this.BTN_MODIFIER.Location = new System.Drawing.Point(458, 60);
            this.BTN_MODIFIER.Name = "BTN_MODIFIER";
            this.BTN_MODIFIER.Size = new System.Drawing.Size(113, 44);
            this.BTN_MODIFIER.TabIndex = 74;
            this.BTN_MODIFIER.Text = "Modifier";
            this.BTN_MODIFIER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_MODIFIER.UseVisualStyleBackColor = true;
            this.BTN_MODIFIER.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // BTN_SUPPRIMER
            // 
            this.BTN_SUPPRIMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SUPPRIMER.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.BTN_SUPPRIMER.Location = new System.Drawing.Point(577, 60);
            this.BTN_SUPPRIMER.Name = "BTN_SUPPRIMER";
            this.BTN_SUPPRIMER.Size = new System.Drawing.Size(113, 44);
            this.BTN_SUPPRIMER.TabIndex = 73;
            this.BTN_SUPPRIMER.Text = "Supprimer";
            this.BTN_SUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_SUPPRIMER.UseVisualStyleBackColor = true;
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(338, 60);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(113, 44);
            this.BTN_AJOUTER.TabIndex = 72;
            this.BTN_AJOUTER.Text = "Ajouter";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // btn_inventaire
            // 
            this.btn_inventaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inventaire.Image = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_32;
            this.btn_inventaire.Location = new System.Drawing.Point(215, 60);
            this.btn_inventaire.Name = "btn_inventaire";
            this.btn_inventaire.Size = new System.Drawing.Size(113, 44);
            this.btn_inventaire.TabIndex = 72;
            this.btn_inventaire.Text = "Inventaire";
            this.btn_inventaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inventaire.UseVisualStyleBackColor = true;
            this.btn_inventaire.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stock.Image = global::CHM_CLIENT_APP.Properties.Resources.Copie_de_prev;
            this.btn_stock.Location = new System.Drawing.Point(96, 60);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(113, 44);
            this.btn_stock.TabIndex = 72;
            this.btn_stock.Text = "Afficher le stock";
            this.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.dossier_home3_icone_4318_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(700, 48);
            this.entete_Formulaire_21.TabIndex = 89;
            // 
            // CHM_LISTE_MAGAZIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 398);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_MODIFIER);
            this.Controls.Add(this.BTN_SUPPRIMER);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_inventaire);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_magazin);
            this.Controls.Add(this.RECHERCHE_MAG);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_LISTE_MAGAZIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Magasins";
            this.Shown += new System.EventHandler(this.CHM_LISTE_MAGAZIN_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_MAGAZIN_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magazin)).EndInit();
            this.CMS_MAGAZIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_magazin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox RECHERCHE_MAG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CMS_MAGAZIN;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BTN_MODIFIER;
        private System.Windows.Forms.Button BTN_SUPPRIMER;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_inventaire;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn adr_mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_mag;
        private System.Windows.Forms.DataGridViewTextBoxColumn rs_societe;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}