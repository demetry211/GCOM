namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_FOURNISSEUR
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
            this.ref_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rs_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_FOURNISSEUR = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touteLaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresDuFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adr_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site_fourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MENU_RECHERCHE_FOURNISSEUR = new System.Windows.Forms.TextBox();
            this.client_to_form = new System.Windows.Forms.Button();
            this.BTN_MODIFIER = new System.Windows.Forms.Button();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.BTN_SUPPRIMER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lise_fournisseur)).BeginInit();
            this.CMS_FOURNISSEUR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgv_lise_fournisseur.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_lise_fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lise_fournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ref_fourn,
            this.rs_fourn,
            this.adr_fourn,
            this.tel_fourn,
            this.fax_fourn,
            this.email_fourn,
            this.site_fourn});
            this.dgv_lise_fournisseur.ContextMenuStrip = this.CMS_FOURNISSEUR;
            this.dgv_lise_fournisseur.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_lise_fournisseur.Location = new System.Drawing.Point(10, 141);
            this.dgv_lise_fournisseur.Name = "dgv_lise_fournisseur";
            this.dgv_lise_fournisseur.ReadOnly = true;
            this.dgv_lise_fournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lise_fournisseur.Size = new System.Drawing.Size(923, 302);
            this.dgv_lise_fournisseur.StandardTab = true;
            this.dgv_lise_fournisseur.TabIndex = 0;
            // 
            // ref_fourn
            // 
            this.ref_fourn.DataPropertyName = "REF_FOURNISSEUR";
            this.ref_fourn.FillWeight = 54.3162F;
            this.ref_fourn.HeaderText = "Ref.";
            this.ref_fourn.Name = "ref_fourn";
            this.ref_fourn.ReadOnly = true;
            // 
            // rs_fourn
            // 
            this.rs_fourn.ContextMenuStrip = this.CMS_FOURNISSEUR;
            this.rs_fourn.DataPropertyName = "RS_FOURNISSEUR";
            this.rs_fourn.FillWeight = 71.14483F;
            this.rs_fourn.HeaderText = "Raison Sociale";
            this.rs_fourn.Name = "rs_fourn";
            this.rs_fourn.ReadOnly = true;
            // 
            // CMS_FOURNISSEUR
            // 
            this.CMS_FOURNISSEUR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem});
            this.CMS_FOURNISSEUR.Name = "CMS_FOURNISSEUR";
            this.CMS_FOURNISSEUR.Size = new System.Drawing.Size(130, 98);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.nouveauToolStripMenuItem.Text = "&Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "&Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "&Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesFournisseursToolStripMenuItem,
            this.paramètresDuFournisseurToolStripMenuItem});
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // listeDesFournisseursToolStripMenuItem
            // 
            this.listeDesFournisseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.touteLaListeToolStripMenuItem,
            this.fournisseurParVilleToolStripMenuItem});
            this.listeDesFournisseursToolStripMenuItem.Name = "listeDesFournisseursToolStripMenuItem";
            this.listeDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listeDesFournisseursToolStripMenuItem.Text = "Liste des fournisseurs";
            // 
            // touteLaListeToolStripMenuItem
            // 
            this.touteLaListeToolStripMenuItem.Name = "touteLaListeToolStripMenuItem";
            this.touteLaListeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.touteLaListeToolStripMenuItem.Text = "Toute la liste";
            // 
            // fournisseurParVilleToolStripMenuItem
            // 
            this.fournisseurParVilleToolStripMenuItem.Name = "fournisseurParVilleToolStripMenuItem";
            this.fournisseurParVilleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.fournisseurParVilleToolStripMenuItem.Text = "Fournisseur par ville";
            // 
            // paramètresDuFournisseurToolStripMenuItem
            // 
            this.paramètresDuFournisseurToolStripMenuItem.Name = "paramètresDuFournisseurToolStripMenuItem";
            this.paramètresDuFournisseurToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.paramètresDuFournisseurToolStripMenuItem.Text = "Paramètres du fournisseur";
            // 
            // adr_fourn
            // 
            this.adr_fourn.DataPropertyName = "ADRESSE_FOURNISSEUR";
            this.adr_fourn.FillWeight = 181.9054F;
            this.adr_fourn.HeaderText = "Adresse";
            this.adr_fourn.Name = "adr_fourn";
            this.adr_fourn.ReadOnly = true;
            // 
            // tel_fourn
            // 
            this.tel_fourn.DataPropertyName = "TEL_FOURNISSEUR";
            this.tel_fourn.FillWeight = 63.63645F;
            this.tel_fourn.HeaderText = "Tel ";
            this.tel_fourn.Name = "tel_fourn";
            this.tel_fourn.ReadOnly = true;
            // 
            // fax_fourn
            // 
            this.fax_fourn.DataPropertyName = "FAX_FOURNISSEUR";
            this.fax_fourn.FillWeight = 65.98203F;
            this.fax_fourn.HeaderText = "Fax ";
            this.fax_fourn.Name = "fax_fourn";
            this.fax_fourn.ReadOnly = true;
            // 
            // email_fourn
            // 
            this.email_fourn.DataPropertyName = "EMAIL_FOURNISSEUR";
            this.email_fourn.FillWeight = 136.2002F;
            this.email_fourn.HeaderText = "E-mail  ";
            this.email_fourn.Name = "email_fourn";
            this.email_fourn.ReadOnly = true;
            // 
            // site_fourn
            // 
            this.site_fourn.DataPropertyName = "SITE_WEB_FOURNISSEUR";
            this.site_fourn.FillWeight = 126.815F;
            this.site_fourn.HeaderText = "Site Web";
            this.site_fourn.Name = "site_fourn";
            this.site_fourn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche :";
            // 
            // MENU_RECHERCHE_FOURNISSEUR
            // 
            this.MENU_RECHERCHE_FOURNISSEUR.Location = new System.Drawing.Point(153, 113);
            this.MENU_RECHERCHE_FOURNISSEUR.Name = "MENU_RECHERCHE_FOURNISSEUR";
            this.MENU_RECHERCHE_FOURNISSEUR.Size = new System.Drawing.Size(241, 20);
            this.MENU_RECHERCHE_FOURNISSEUR.TabIndex = 2;
            this.MENU_RECHERCHE_FOURNISSEUR.TextChanged += new System.EventHandler(this.MENU_RECHERCHE_FOURNISSEUR_TextChanged);
            // 
            // client_to_form
            // 
            this.client_to_form.BackColor = System.Drawing.Color.Transparent;
            this.client_to_form.FlatAppearance.BorderSize = 0;
            this.client_to_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_to_form.Image = global::CHM_CLIENT_APP.Properties.Resources.fileview_liste_texte_icone_5928_48;
            this.client_to_form.Location = new System.Drawing.Point(10, 50);
            this.client_to_form.Name = "client_to_form";
            this.client_to_form.Size = new System.Drawing.Size(54, 50);
            this.client_to_form.TabIndex = 81;
            this.client_to_form.UseVisualStyleBackColor = false;
            this.client_to_form.Click += new System.EventHandler(this.client_to_form_Click);
            // 
            // BTN_MODIFIER
            // 
            this.BTN_MODIFIER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_MODIFIER.BackColor = System.Drawing.Color.Transparent;
            this.BTN_MODIFIER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_MODIFIER.FlatAppearance.BorderSize = 0;
            this.BTN_MODIFIER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_MODIFIER.Image = global::CHM_CLIENT_APP.Properties.Resources.arrow_tourner_vers_la_droite_icone_8357_32;
            this.BTN_MODIFIER.Location = new System.Drawing.Point(736, 53);
            this.BTN_MODIFIER.Name = "BTN_MODIFIER";
            this.BTN_MODIFIER.Size = new System.Drawing.Size(94, 44);
            this.BTN_MODIFIER.TabIndex = 84;
            this.BTN_MODIFIER.Text = "Modifier";
            this.BTN_MODIFIER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_MODIFIER.UseVisualStyleBackColor = false;
            this.BTN_MODIFIER.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AJOUTER.BackColor = System.Drawing.Color.Transparent;
            this.BTN_AJOUTER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AJOUTER.FlatAppearance.BorderSize = 0;
            this.BTN_AJOUTER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(642, 53);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(94, 44);
            this.BTN_AJOUTER.TabIndex = 82;
            this.BTN_AJOUTER.Text = "Ajouter";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = false;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // BTN_SUPPRIMER
            // 
            this.BTN_SUPPRIMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SUPPRIMER.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SUPPRIMER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_SUPPRIMER.FlatAppearance.BorderSize = 0;
            this.BTN_SUPPRIMER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_SUPPRIMER.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.BTN_SUPPRIMER.Location = new System.Drawing.Point(830, 53);
            this.BTN_SUPPRIMER.Name = "BTN_SUPPRIMER";
            this.BTN_SUPPRIMER.Size = new System.Drawing.Size(94, 44);
            this.BTN_SUPPRIMER.TabIndex = 83;
            this.BTN_SUPPRIMER.Text = "Supprimer";
            this.BTN_SUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_SUPPRIMER.UseVisualStyleBackColor = false;
            this.BTN_SUPPRIMER.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.Fournisseurs64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(947, 48);
            this.entete_Formulaire_21.TabIndex = 88;
            // 
            // CHM_LISTE_FOURNISSEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 448);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_MODIFIER);
            this.Controls.Add(this.dgv_lise_fournisseur);
            this.Controls.Add(this.client_to_form);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.BTN_SUPPRIMER);
            this.Controls.Add(this.MENU_RECHERCHE_FOURNISSEUR);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "CHM_LISTE_FOURNISSEUR";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Fournisseurs";
            this.Shown += new System.EventHandler(this.CHM_LISTE_FOURNISSEUR_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_FOURNISSEUR_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lise_fournisseur)).EndInit();
            this.CMS_FOURNISSEUR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lise_fournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MENU_RECHERCHE_FOURNISSEUR;
        private System.Windows.Forms.ContextMenuStrip CMS_FOURNISSEUR;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.Button client_to_form;
        private System.Windows.Forms.Button BTN_MODIFIER;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button BTN_SUPPRIMER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem touteLaListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresDuFournisseurToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rs_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adr_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_fourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn site_fourn;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}