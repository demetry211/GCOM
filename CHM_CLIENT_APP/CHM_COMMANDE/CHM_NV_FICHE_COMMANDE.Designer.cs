namespace CHM_CLIENT_APP
{
    partial class CHM_FICHE_COMMANDE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PRIORITE_COMMANDE = new System.Windows.Forms.CheckBox();
            this.dataGridViewLG_COMMANDE = new System.Windows.Forms.DataGridView();
            this.REF_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARQUE_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_HT_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_tot_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_TTC_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_ttc_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DATE_EXPIRATION_COMMANDE = new System.Windows.Forms.DateTimePicker();
            this.DATE_COMMANDE = new System.Windows.Forms.DateTimePicker();
            this.CODE_COMMANDE = new System.Windows.Forms.Label();
            this.REF_CLIENT = new System.Windows.Forms.TextBox();
            this.BTN_B_LIV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.BTN_Aperçu_cmd = new System.Windows.Forms.Button();
            this.btn_liste_commande = new System.Windows.Forms.Button();
            this.buttonENREGISTRER = new System.Windows.Forms.Button();
            this.buttonAJOUTER = new System.Windows.Forms.Button();
            this.buttonSUPPRIMER = new System.Windows.Forms.Button();
            this.PARCOURIR_LISTE_CLIENT = new System.Windows.Forms.Button();
            this.somme_cmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.REGLEE = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLG_COMMANDE)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PRIORITE_COMMANDE
            // 
            this.PRIORITE_COMMANDE.AutoSize = true;
            this.PRIORITE_COMMANDE.BackColor = System.Drawing.Color.Transparent;
            this.PRIORITE_COMMANDE.ForeColor = System.Drawing.Color.Transparent;
            this.PRIORITE_COMMANDE.Location = new System.Drawing.Point(15, 132);
            this.PRIORITE_COMMANDE.Name = "PRIORITE_COMMANDE";
            this.PRIORITE_COMMANDE.Size = new System.Drawing.Size(61, 17);
            this.PRIORITE_COMMANDE.TabIndex = 23;
            this.PRIORITE_COMMANDE.Text = "Priorité ";
            this.PRIORITE_COMMANDE.UseVisualStyleBackColor = false;
            this.PRIORITE_COMMANDE.CheckedChanged += new System.EventHandler(this.PRIORITE_COMMANDE_CheckedChanged);
            // 
            // dataGridViewLG_COMMANDE
            // 
            this.dataGridViewLG_COMMANDE.AllowUserToAddRows = false;
            this.dataGridViewLG_COMMANDE.AllowUserToDeleteRows = false;
            this.dataGridViewLG_COMMANDE.AllowUserToResizeColumns = false;
            this.dataGridViewLG_COMMANDE.AllowUserToResizeRows = false;
            this.dataGridViewLG_COMMANDE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLG_COMMANDE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLG_COMMANDE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewLG_COMMANDE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLG_COMMANDE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF_ARTICLE_,
            this.DESIGNATION_ARTICLE_,
            this.MARQUE_ARTICLE_,
            this.QTE_LG_COMMANDE_,
            this.PRIX_HT_LG_COMMANDE_,
            this.prix_tot_ht,
            this.TVA_LG_COMMANDE_,
            this.PRIX_TTC_LG_COMMANDE_,
            this.prix_ttc_total});
            this.dataGridViewLG_COMMANDE.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLG_COMMANDE.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewLG_COMMANDE.Location = new System.Drawing.Point(12, 163);
            this.dataGridViewLG_COMMANDE.MultiSelect = false;
            this.dataGridViewLG_COMMANDE.Name = "dataGridViewLG_COMMANDE";
            this.dataGridViewLG_COMMANDE.ReadOnly = true;
            this.dataGridViewLG_COMMANDE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLG_COMMANDE.Size = new System.Drawing.Size(865, 373);
            this.dataGridViewLG_COMMANDE.TabIndex = 24;
            this.dataGridViewLG_COMMANDE.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewLG_COMMANDE_RowsAdded);
            this.dataGridViewLG_COMMANDE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLG_COMMANDE_CellContentClick);
            // 
            // REF_ARTICLE_
            // 
            this.REF_ARTICLE_.DataPropertyName = "REF_ARTICLE";
            this.REF_ARTICLE_.FillWeight = 81.86047F;
            this.REF_ARTICLE_.HeaderText = "Code";
            this.REF_ARTICLE_.Name = "REF_ARTICLE_";
            this.REF_ARTICLE_.ReadOnly = true;
            // 
            // DESIGNATION_ARTICLE_
            // 
            this.DESIGNATION_ARTICLE_.DataPropertyName = "DESIGNATION_ARTICLE";
            this.DESIGNATION_ARTICLE_.FillWeight = 187.8047F;
            this.DESIGNATION_ARTICLE_.HeaderText = "Désignation";
            this.DESIGNATION_ARTICLE_.Name = "DESIGNATION_ARTICLE_";
            this.DESIGNATION_ARTICLE_.ReadOnly = true;
            // 
            // MARQUE_ARTICLE_
            // 
            this.MARQUE_ARTICLE_.DataPropertyName = "MARQUE_ARTICLE";
            this.MARQUE_ARTICLE_.FillWeight = 117.8234F;
            this.MARQUE_ARTICLE_.HeaderText = "Marque";
            this.MARQUE_ARTICLE_.Name = "MARQUE_ARTICLE_";
            this.MARQUE_ARTICLE_.ReadOnly = true;
            // 
            // QTE_LG_COMMANDE_
            // 
            this.QTE_LG_COMMANDE_.DataPropertyName = "QTE_LIGNE_COMMANDE";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = null;
            this.QTE_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle9;
            this.QTE_LG_COMMANDE_.FillWeight = 73.06697F;
            this.QTE_LG_COMMANDE_.HeaderText = "Quantité";
            this.QTE_LG_COMMANDE_.Name = "QTE_LG_COMMANDE_";
            this.QTE_LG_COMMANDE_.ReadOnly = true;
            // 
            // PRIX_HT_LG_COMMANDE_
            // 
            this.PRIX_HT_LG_COMMANDE_.DataPropertyName = "PRIX_HT_COMMANDE";
            dataGridViewCellStyle10.Format = "N3";
            this.PRIX_HT_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle10;
            this.PRIX_HT_LG_COMMANDE_.FillWeight = 100.0685F;
            this.PRIX_HT_LG_COMMANDE_.HeaderText = "Prix Unitaire";
            this.PRIX_HT_LG_COMMANDE_.Name = "PRIX_HT_LG_COMMANDE_";
            this.PRIX_HT_LG_COMMANDE_.ReadOnly = true;
            // 
            // prix_tot_ht
            // 
            this.prix_tot_ht.DataPropertyName = "PRIX_HT_TOTAL";
            this.prix_tot_ht.HeaderText = "Prix total";
            this.prix_tot_ht.Name = "prix_tot_ht";
            this.prix_tot_ht.ReadOnly = true;
            // 
            // TVA_LG_COMMANDE_
            // 
            this.TVA_LG_COMMANDE_.DataPropertyName = "TVA_COMMANDE";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.TVA_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle11;
            this.TVA_LG_COMMANDE_.FillWeight = 58.59332F;
            this.TVA_LG_COMMANDE_.HeaderText = "TVA";
            this.TVA_LG_COMMANDE_.Name = "TVA_LG_COMMANDE_";
            this.TVA_LG_COMMANDE_.ReadOnly = true;
            this.TVA_LG_COMMANDE_.Visible = false;
            // 
            // PRIX_TTC_LG_COMMANDE_
            // 
            this.PRIX_TTC_LG_COMMANDE_.DataPropertyName = "PRIX_TTC_LG_COMMANDE";
            dataGridViewCellStyle12.Format = "N3";
            this.PRIX_TTC_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle12;
            this.PRIX_TTC_LG_COMMANDE_.FillWeight = 109.2761F;
            this.PRIX_TTC_LG_COMMANDE_.HeaderText = "Prix U. TTC";
            this.PRIX_TTC_LG_COMMANDE_.Name = "PRIX_TTC_LG_COMMANDE_";
            this.PRIX_TTC_LG_COMMANDE_.ReadOnly = true;
            this.PRIX_TTC_LG_COMMANDE_.Visible = false;
            // 
            // prix_ttc_total
            // 
            this.prix_ttc_total.DataPropertyName = "PRIX_TTC_TOTAL";
            dataGridViewCellStyle13.Format = "N3";
            dataGridViewCellStyle13.NullValue = null;
            this.prix_ttc_total.DefaultCellStyle = dataGridViewCellStyle13;
            this.prix_ttc_total.HeaderText = "Prix TTC Total";
            this.prix_ttc_total.Name = "prix_ttc_total";
            this.prix_ttc_total.ReadOnly = true;
            this.prix_ttc_total.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualiserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualiserToolStripMenuItem.Text = "&Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // DATE_EXPIRATION_COMMANDE
            // 
            this.DATE_EXPIRATION_COMMANDE.Enabled = false;
            this.DATE_EXPIRATION_COMMANDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_EXPIRATION_COMMANDE.Location = new System.Drawing.Point(189, 129);
            this.DATE_EXPIRATION_COMMANDE.Name = "DATE_EXPIRATION_COMMANDE";
            this.DATE_EXPIRATION_COMMANDE.Size = new System.Drawing.Size(85, 20);
            this.DATE_EXPIRATION_COMMANDE.TabIndex = 22;
            // 
            // DATE_COMMANDE
            // 
            this.DATE_COMMANDE.Enabled = false;
            this.DATE_COMMANDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_COMMANDE.Location = new System.Drawing.Point(99, 103);
            this.DATE_COMMANDE.Name = "DATE_COMMANDE";
            this.DATE_COMMANDE.Size = new System.Drawing.Size(139, 20);
            this.DATE_COMMANDE.TabIndex = 21;
            // 
            // CODE_COMMANDE
            // 
            this.CODE_COMMANDE.BackColor = System.Drawing.Color.White;
            this.CODE_COMMANDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_COMMANDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_COMMANDE.ForeColor = System.Drawing.Color.Maroon;
            this.CODE_COMMANDE.Location = new System.Drawing.Point(99, 76);
            this.CODE_COMMANDE.Name = "CODE_COMMANDE";
            this.CODE_COMMANDE.Size = new System.Drawing.Size(158, 20);
            this.CODE_COMMANDE.TabIndex = 19;
            this.CODE_COMMANDE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.REF_CLIENT.Location = new System.Drawing.Point(404, 76);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.Size = new System.Drawing.Size(153, 20);
            this.REF_CLIENT.TabIndex = 18;
            // 
            // BTN_B_LIV
            // 
            this.BTN_B_LIV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_B_LIV.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_B_LIV.Image = global::CHM_CLIENT_APP.Properties.Resources.coller_icone_5810_48;
            this.BTN_B_LIV.Location = new System.Drawing.Point(883, 478);
            this.BTN_B_LIV.Name = "BTN_B_LIV";
            this.BTN_B_LIV.Size = new System.Drawing.Size(133, 58);
            this.BTN_B_LIV.TabIndex = 33;
            this.BTN_B_LIV.Text = "Générer en bon de livraison [F11]";
            this.BTN_B_LIV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_B_LIV.UseVisualStyleBackColor = false;
            this.BTN_B_LIV.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(359, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(87, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date d\'expiration :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date Création :";
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RS_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RS_CLIENT.Location = new System.Drawing.Point(362, 98);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(195, 20);
            this.RS_CLIENT.TabIndex = 20;
            this.RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_Aperçu_cmd
            // 
            this.BTN_Aperçu_cmd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Aperçu_cmd.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Aperçu_cmd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Aperçu_cmd.Image = global::CHM_CLIENT_APP.Properties.Resources.pdf_icone_6190_48;
            this.BTN_Aperçu_cmd.Location = new System.Drawing.Point(883, 352);
            this.BTN_Aperçu_cmd.Name = "BTN_Aperçu_cmd";
            this.BTN_Aperçu_cmd.Size = new System.Drawing.Size(133, 57);
            this.BTN_Aperçu_cmd.TabIndex = 36;
            this.BTN_Aperçu_cmd.Text = "Aperçu [F8]";
            this.BTN_Aperçu_cmd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aperçu_cmd.UseVisualStyleBackColor = false;
            this.BTN_Aperçu_cmd.Click += new System.EventHandler(this.BTN_Aperçu_cmd_Click);
            // 
            // btn_liste_commande
            // 
            this.btn_liste_commande.AccessibleDescription = "ergdfgdf";
            this.btn_liste_commande.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_liste_commande.BackColor = System.Drawing.SystemColors.Control;
            this.btn_liste_commande.Image = global::CHM_CLIENT_APP.Properties.Resources.liste_tableau_fenetre_icone_8813_48;
            this.btn_liste_commande.Location = new System.Drawing.Point(883, 415);
            this.btn_liste_commande.Name = "btn_liste_commande";
            this.btn_liste_commande.Size = new System.Drawing.Size(133, 57);
            this.btn_liste_commande.TabIndex = 31;
            this.btn_liste_commande.Tag = "";
            this.btn_liste_commande.Text = "Liste des Commandes clients [Ctrl+L]";
            this.btn_liste_commande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_liste_commande.UseVisualStyleBackColor = false;
            this.btn_liste_commande.Click += new System.EventHandler(this.btn_liste_commande_Click);
            // 
            // buttonENREGISTRER
            // 
            this.buttonENREGISTRER.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonENREGISTRER.BackColor = System.Drawing.SystemColors.Control;
            this.buttonENREGISTRER.Image = global::CHM_CLIENT_APP.Properties.Resources.save;
            this.buttonENREGISTRER.Location = new System.Drawing.Point(883, 289);
            this.buttonENREGISTRER.Name = "buttonENREGISTRER";
            this.buttonENREGISTRER.Size = new System.Drawing.Size(133, 57);
            this.buttonENREGISTRER.TabIndex = 27;
            this.buttonENREGISTRER.Text = "Enregistrer [F10]";
            this.buttonENREGISTRER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonENREGISTRER.UseVisualStyleBackColor = false;
            this.buttonENREGISTRER.Click += new System.EventHandler(this.buttonENREGISTRER_Click);
            // 
            // buttonAJOUTER
            // 
            this.buttonAJOUTER.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAJOUTER.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAJOUTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.information_2;
            this.buttonAJOUTER.Location = new System.Drawing.Point(883, 163);
            this.buttonAJOUTER.Name = "buttonAJOUTER";
            this.buttonAJOUTER.Size = new System.Drawing.Size(133, 57);
            this.buttonAJOUTER.TabIndex = 26;
            this.buttonAJOUTER.Text = "Ajout d\'article [F6]";
            this.buttonAJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAJOUTER.UseVisualStyleBackColor = false;
            this.buttonAJOUTER.Click += new System.EventHandler(this.buttonAJOUTER_Click);
            // 
            // buttonSUPPRIMER
            // 
            this.buttonSUPPRIMER.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSUPPRIMER.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSUPPRIMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSUPPRIMER.Image = global::CHM_CLIENT_APP.Properties.Resources.yield_2;
            this.buttonSUPPRIMER.Location = new System.Drawing.Point(883, 226);
            this.buttonSUPPRIMER.Name = "buttonSUPPRIMER";
            this.buttonSUPPRIMER.Size = new System.Drawing.Size(133, 57);
            this.buttonSUPPRIMER.TabIndex = 25;
            this.buttonSUPPRIMER.Text = "Supprimer Article    [Suppr]";
            this.buttonSUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSUPPRIMER.UseVisualStyleBackColor = false;
            this.buttonSUPPRIMER.Click += new System.EventHandler(this.buttonSUPPRIMER_Click);
            // 
            // PARCOURIR_LISTE_CLIENT
            // 
            this.PARCOURIR_LISTE_CLIENT.AccessibleDescription = "dgsdfdsf";
            this.PARCOURIR_LISTE_CLIENT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PARCOURIR_LISTE_CLIENT.BackColor = System.Drawing.SystemColors.Control;
            this.PARCOURIR_LISTE_CLIENT.Image = global::CHM_CLIENT_APP.Properties.Resources.loupe;
            this.PARCOURIR_LISTE_CLIENT.Location = new System.Drawing.Point(563, 76);
            this.PARCOURIR_LISTE_CLIENT.Name = "PARCOURIR_LISTE_CLIENT";
            this.PARCOURIR_LISTE_CLIENT.Size = new System.Drawing.Size(41, 42);
            this.PARCOURIR_LISTE_CLIENT.TabIndex = 30;
            this.PARCOURIR_LISTE_CLIENT.UseVisualStyleBackColor = false;
            this.PARCOURIR_LISTE_CLIENT.Click += new System.EventHandler(this.PARCOURIR_LISTE_CLIENT_Click);
            // 
            // somme_cmd
            // 
            this.somme_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.somme_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somme_cmd.Location = new System.Drawing.Point(669, 114);
            this.somme_cmd.Name = "somme_cmd";
            this.somme_cmd.ReadOnly = true;
            this.somme_cmd.Size = new System.Drawing.Size(208, 40);
            this.somme_cmd.TabIndex = 38;
            this.somme_cmd.Text = "0.000";
            this.somme_cmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "N° Commande :";
            // 
            // REGLEE
            // 
            this.REGLEE.AutoSize = true;
            this.REGLEE.BackColor = System.Drawing.Color.Transparent;
            this.REGLEE.Enabled = false;
            this.REGLEE.ForeColor = System.Drawing.Color.Transparent;
            this.REGLEE.Location = new System.Drawing.Point(296, 132);
            this.REGLEE.Name = "REGLEE";
            this.REGLEE.Size = new System.Drawing.Size(55, 17);
            this.REGLEE.TabIndex = 79;
            this.REGLEE.Text = "Livré?";
            this.REGLEE.UseVisualStyleBackColor = false;
            this.REGLEE.Visible = false;
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(1021, 48);
            this.entete_Formulaire_21.TabIndex = 80;
            // 
            // CHM_FICHE_COMMANDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 548);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.dataGridViewLG_COMMANDE);
            this.Controls.Add(this.BTN_Aperçu_cmd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.somme_cmd);
            this.Controls.Add(this.REGLEE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAJOUTER);
            this.Controls.Add(this.RS_CLIENT);
            this.Controls.Add(this.PRIORITE_COMMANDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_B_LIV);
            this.Controls.Add(this.DATE_COMMANDE);
            this.Controls.Add(this.DATE_EXPIRATION_COMMANDE);
            this.Controls.Add(this.CODE_COMMANDE);
            this.Controls.Add(this.btn_liste_commande);
            this.Controls.Add(this.PARCOURIR_LISTE_CLIENT);
            this.Controls.Add(this.buttonENREGISTRER);
            this.Controls.Add(this.REF_CLIENT);
            this.Controls.Add(this.buttonSUPPRIMER);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "CHM_FICHE_COMMANDE";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle commande";
            this.Load += new System.EventHandler(this.CHM_FICHE_COMMANDE_Load);
            this.Shown += new System.EventHandler(this.CHM_FICHE_COMMANDE_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FICHE_COMMANDE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLG_COMMANDE)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonENREGISTRER;
        private System.Windows.Forms.Button PARCOURIR_LISTE_CLIENT;
        private System.Windows.Forms.Button buttonAJOUTER;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_liste_commande;
        private System.Windows.Forms.Button buttonSUPPRIMER;
        private System.Windows.Forms.CheckBox PRIORITE_COMMANDE;
        private System.Windows.Forms.DateTimePicker DATE_EXPIRATION_COMMANDE;
        private System.Windows.Forms.DateTimePicker DATE_COMMANDE;
        private System.Windows.Forms.Label CODE_COMMANDE;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.TextBox REF_CLIENT;
        private System.Windows.Forms.Button BTN_B_LIV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Aperçu_cmd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.TextBox somme_cmd;
        public System.Windows.Forms.DataGridView dataGridViewLG_COMMANDE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox REGLEE;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARQUE_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_HT_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_tot_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_TTC_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_ttc_total;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}