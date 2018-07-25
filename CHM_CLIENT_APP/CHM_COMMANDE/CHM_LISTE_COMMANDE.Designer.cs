namespace CHM_CLIENT_APP
{
    partial class CHM_LISTE_COMMANDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_COMMANDE));
            this.dgv_LISTE_COMMANDE = new System.Windows.Forms.DataGridView();
            this.CODE_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_clt_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIORITE_COMMANDE_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.date_expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGLEE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DATE_EXPIRATION_COMMANDE = new System.Windows.Forms.DateTimePicker();
            this.DATE_COMMANDE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_dt_expiration = new System.Windows.Forms.CheckBox();
            this.cb_dt_saisie = new System.Windows.Forms.CheckBox();
            this.cb_client = new System.Windows.Forms.CheckBox();
            this.BTN_RECHERCHER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.REF_CLIENT = new System.Windows.Forms.TextBox();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.BTN_Aperçu_cmd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_RECHERCHE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_DETAIL = new System.Windows.Forms.Button();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_COMMANDE)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LISTE_COMMANDE
            // 
            this.dgv_LISTE_COMMANDE.AllowUserToAddRows = false;
            this.dgv_LISTE_COMMANDE.AllowUserToDeleteRows = false;
            this.dgv_LISTE_COMMANDE.AllowUserToResizeColumns = false;
            this.dgv_LISTE_COMMANDE.AllowUserToResizeRows = false;
            this.dgv_LISTE_COMMANDE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LISTE_COMMANDE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LISTE_COMMANDE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LISTE_COMMANDE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_COMMANDE_,
            this.code_clt_cmd,
            this.DATE_COMMANDE_,
            this.PRIORITE_COMMANDE_,
            this.date_expiration,
            this.code_user,
            this.REGLEE});
            this.dgv_LISTE_COMMANDE.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_LISTE_COMMANDE.Location = new System.Drawing.Point(135, 106);
            this.dgv_LISTE_COMMANDE.MultiSelect = false;
            this.dgv_LISTE_COMMANDE.Name = "dgv_LISTE_COMMANDE";
            this.dgv_LISTE_COMMANDE.ReadOnly = true;
            this.dgv_LISTE_COMMANDE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LISTE_COMMANDE.Size = new System.Drawing.Size(831, 370);
            this.dgv_LISTE_COMMANDE.TabIndex = 34;
            this.dgv_LISTE_COMMANDE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LISTE_COMMANDE_CellDoubleClick);
            // 
            // CODE_COMMANDE_
            // 
            this.CODE_COMMANDE_.DataPropertyName = "CODE_COMMANDE";
            this.CODE_COMMANDE_.FillWeight = 166.2706F;
            this.CODE_COMMANDE_.HeaderText = "N° Commande";
            this.CODE_COMMANDE_.Name = "CODE_COMMANDE_";
            this.CODE_COMMANDE_.ReadOnly = true;
            // 
            // code_clt_cmd
            // 
            this.code_clt_cmd.DataPropertyName = "RS_CLIENT";
            this.code_clt_cmd.FillWeight = 102.8591F;
            this.code_clt_cmd.HeaderText = "Client";
            this.code_clt_cmd.Name = "code_clt_cmd";
            this.code_clt_cmd.ReadOnly = true;
            // 
            // DATE_COMMANDE_
            // 
            this.DATE_COMMANDE_.DataPropertyName = "DATE_COMMANDE";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DATE_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle1;
            this.DATE_COMMANDE_.FillWeight = 124.7515F;
            this.DATE_COMMANDE_.HeaderText = "Date création";
            this.DATE_COMMANDE_.Name = "DATE_COMMANDE_";
            this.DATE_COMMANDE_.ReadOnly = true;
            // 
            // PRIORITE_COMMANDE_
            // 
            this.PRIORITE_COMMANDE_.DataPropertyName = "PRIORITE_COMMANDE";
            this.PRIORITE_COMMANDE_.FillWeight = 57.16626F;
            this.PRIORITE_COMMANDE_.HeaderText = "Priorité";
            this.PRIORITE_COMMANDE_.Name = "PRIORITE_COMMANDE_";
            this.PRIORITE_COMMANDE_.ReadOnly = true;
            this.PRIORITE_COMMANDE_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRIORITE_COMMANDE_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // date_expiration
            // 
            this.date_expiration.DataPropertyName = "DATE_EXPIARTION_COMMANDE";
            this.date_expiration.FillWeight = 122.6317F;
            this.date_expiration.HeaderText = "Date échéance";
            this.date_expiration.Name = "date_expiration";
            this.date_expiration.ReadOnly = true;
            // 
            // code_user
            // 
            this.code_user.DataPropertyName = "USER";
            this.code_user.FillWeight = 101.8203F;
            this.code_user.HeaderText = "Utilisateur";
            this.code_user.Name = "code_user";
            this.code_user.ReadOnly = true;
            // 
            // REGLEE
            // 
            this.REGLEE.DataPropertyName = "REGLEE";
            this.REGLEE.FillWeight = 99.73726F;
            this.REGLEE.HeaderText = "Livrée?";
            this.REGLEE.Name = "REGLEE";
            this.REGLEE.ReadOnly = true;
            this.REGLEE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REGLEE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.rechercherToolStripMenuItem.Text = "&Search";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // DATE_EXPIRATION_COMMANDE
            // 
            this.DATE_EXPIRATION_COMMANDE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE_EXPIRATION_COMMANDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_EXPIRATION_COMMANDE.Location = new System.Drawing.Point(144, 78);
            this.DATE_EXPIRATION_COMMANDE.Name = "DATE_EXPIRATION_COMMANDE";
            this.DATE_EXPIRATION_COMMANDE.Size = new System.Drawing.Size(162, 20);
            this.DATE_EXPIRATION_COMMANDE.TabIndex = 36;
            // 
            // DATE_COMMANDE
            // 
            this.DATE_COMMANDE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE_COMMANDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_COMMANDE.Location = new System.Drawing.Point(144, 53);
            this.DATE_COMMANDE.Name = "DATE_COMMANDE";
            this.DATE_COMMANDE.Size = new System.Drawing.Size(162, 20);
            this.DATE_COMMANDE.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Date de saisie :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date d\'expiration :";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_dt_expiration);
            this.panel1.Controls.Add(this.cb_dt_saisie);
            this.panel1.Controls.Add(this.cb_client);
            this.panel1.Controls.Add(this.BTN_RECHERCHER);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.REF_CLIENT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DATE_COMMANDE);
            this.panel1.Controls.Add(this.DATE_EXPIRATION_COMMANDE);
            this.panel1.Location = new System.Drawing.Point(319, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 180);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // cb_dt_expiration
            // 
            this.cb_dt_expiration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_dt_expiration.AutoSize = true;
            this.cb_dt_expiration.Location = new System.Drawing.Point(28, 81);
            this.cb_dt_expiration.Name = "cb_dt_expiration";
            this.cb_dt_expiration.Size = new System.Drawing.Size(15, 14);
            this.cb_dt_expiration.TabIndex = 43;
            this.cb_dt_expiration.UseVisualStyleBackColor = true;
            // 
            // cb_dt_saisie
            // 
            this.cb_dt_saisie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_dt_saisie.AutoSize = true;
            this.cb_dt_saisie.Location = new System.Drawing.Point(28, 56);
            this.cb_dt_saisie.Name = "cb_dt_saisie";
            this.cb_dt_saisie.Size = new System.Drawing.Size(15, 14);
            this.cb_dt_saisie.TabIndex = 42;
            this.cb_dt_saisie.UseVisualStyleBackColor = true;
            // 
            // cb_client
            // 
            this.cb_client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_client.AutoSize = true;
            this.cb_client.Location = new System.Drawing.Point(28, 29);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(15, 14);
            this.cb_client.TabIndex = 41;
            this.cb_client.UseVisualStyleBackColor = true;
            // 
            // BTN_RECHERCHER
            // 
            this.BTN_RECHERCHER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RECHERCHER.Image = global::CHM_CLIENT_APP.Properties.Resources.jumelles_icone_4914_48;
            this.BTN_RECHERCHER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RECHERCHER.Location = new System.Drawing.Point(109, 116);
            this.BTN_RECHERCHER.Name = "BTN_RECHERCHER";
            this.BTN_RECHERCHER.Size = new System.Drawing.Size(125, 51);
            this.BTN_RECHERCHER.TabIndex = 40;
            this.BTN_RECHERCHER.Text = "&Rechercher";
            this.BTN_RECHERCHER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_RECHERCHER.UseVisualStyleBackColor = true;
            this.BTN_RECHERCHER.Click += new System.EventHandler(this.BTN_RECHERCHER_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Client :";
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.REF_CLIENT.Location = new System.Drawing.Point(144, 27);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.Size = new System.Drawing.Size(162, 20);
            this.REF_CLIENT.TabIndex = 39;
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.ForeColor = System.Drawing.Color.Black;
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(12, 106);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(110, 49);
            this.BTN_AJOUTER.TabIndex = 79;
            this.BTN_AJOUTER.Text = "Ajouter [F6]";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.BTN_AJOUTER_Click);
            // 
            // BTN_Aperçu_cmd
            // 
            this.BTN_Aperçu_cmd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Aperçu_cmd.Image = global::CHM_CLIENT_APP.Properties.Resources.pdf_icone_6190_48;
            this.BTN_Aperçu_cmd.Location = new System.Drawing.Point(12, 216);
            this.BTN_Aperçu_cmd.Name = "BTN_Aperçu_cmd";
            this.BTN_Aperçu_cmd.Size = new System.Drawing.Size(110, 49);
            this.BTN_Aperçu_cmd.TabIndex = 80;
            this.BTN_Aperçu_cmd.Text = "Aperçu [F8]";
            this.BTN_Aperçu_cmd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aperçu_cmd.UseVisualStyleBackColor = true;
            this.BTN_Aperçu_cmd.Click += new System.EventHandler(this.BTN_Aperçu_cmd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(136, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // TB_RECHERCHE
            // 
            this.TB_RECHERCHE.Location = new System.Drawing.Point(255, 75);
            this.TB_RECHERCHE.Name = "TB_RECHERCHE";
            this.TB_RECHERCHE.Size = new System.Drawing.Size(389, 20);
            this.TB_RECHERCHE.TabIndex = 83;
            this.TB_RECHERCHE.TextChanged += new System.EventHandler(this.TB_RECHERCHE_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Recherche :";
            // 
            // BTN_DETAIL
            // 
            this.BTN_DETAIL.ForeColor = System.Drawing.Color.Black;
            this.BTN_DETAIL.Image = global::CHM_CLIENT_APP.Properties.Resources.document_revenir_icone_4759_32;
            this.BTN_DETAIL.Location = new System.Drawing.Point(12, 161);
            this.BTN_DETAIL.Name = "BTN_DETAIL";
            this.BTN_DETAIL.Size = new System.Drawing.Size(110, 49);
            this.BTN_DETAIL.TabIndex = 79;
            this.BTN_DETAIL.Text = "Détails [F7]";
            this.BTN_DETAIL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_DETAIL.UseVisualStyleBackColor = true;
            this.BTN_DETAIL.Click += new System.EventHandler(this.BTN_DETAIL_Click);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.ecommerce_panier_shoping_webshop_icone_6530_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(978, 48);
            this.entete_Formulaire_21.TabIndex = 86;
            // 
            // CHM_LISTE_COMMANDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 488);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.TB_RECHERCHE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_LISTE_COMMANDE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_AJOUTER);
            this.Controls.Add(this.BTN_Aperçu_cmd);
            this.Controls.Add(this.BTN_DETAIL);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_LISTE_COMMANDE";
            this.Text = "Liste des commandes Client";
            this.Shown += new System.EventHandler(this.CHM_LISTE_COMMANDE_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_COMMANDE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LISTE_COMMANDE)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LISTE_COMMANDE;
        private System.Windows.Forms.DateTimePicker DATE_EXPIRATION_COMMANDE;
        private System.Windows.Forms.DateTimePicker DATE_COMMANDE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_RECHERCHER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox REF_CLIENT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_dt_expiration;
        private System.Windows.Forms.CheckBox cb_dt_saisie;
        private System.Windows.Forms.CheckBox cb_client;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button BTN_Aperçu_cmd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_RECHERCHE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_DETAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_clt_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMMANDE_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PRIORITE_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_expiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_user;
        private System.Windows.Forms.DataGridViewCheckBoxColumn REGLEE;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}