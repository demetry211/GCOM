namespace CHM_CLIENT_APP.BON_RETOUR_CLIENT
{
    partial class CHM_FRM_BON_RETOUR_CLIENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_BON_RETOUR_CLIENT));
            this.dgv_detail_br = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.nv_clt_titre = new System.Windows.Forms.Label();
            this.CODE_Facture = new System.Windows.Forms.TextBox();
            this.btn_RECHERCHE_FACTURE = new System.Windows.Forms.Button();
            this.btn_VALIDER_BRC = new System.Windows.Forms.Button();
            this.TTC = new System.Windows.Forms.Label();
            this.NP = new System.Windows.Forms.Label();
            this.TAUX_REMISE = new System.Windows.Forms.Label();
            this.lb_mnt_retour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_lg_facture = new System.Windows.Forms.DataGridView();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DATE_FACTURE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.REF_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_HT_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_tot_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_TTC_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_br)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lg_facture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detail_br
            // 
            this.dgv_detail_br.AllowUserToAddRows = false;
            this.dgv_detail_br.AllowUserToDeleteRows = false;
            this.dgv_detail_br.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_detail_br.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detail_br.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detail_br.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail_br.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detail_br.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detail_br.Location = new System.Drawing.Point(7, 19);
            this.dgv_detail_br.Name = "dgv_detail_br";
            this.dgv_detail_br.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detail_br.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_detail_br.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detail_br.Size = new System.Drawing.Size(391, 408);
            this.dgv_detail_br.TabIndex = 0;
            this.dgv_detail_br.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detail_br_CellClick);
            this.dgv_detail_br.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detail_br_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.nv_clt_titre);
            this.groupBox2.Location = new System.Drawing.Point(-3, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 63);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(945, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 43);
            this.button5.TabIndex = 80;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nv_clt_titre
            // 
            this.nv_clt_titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nv_clt_titre.BackColor = System.Drawing.Color.Transparent;
            this.nv_clt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_clt_titre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nv_clt_titre.Location = new System.Drawing.Point(9, 13);
            this.nv_clt_titre.Name = "nv_clt_titre";
            this.nv_clt_titre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nv_clt_titre.Size = new System.Drawing.Size(930, 44);
            this.nv_clt_titre.TabIndex = 43;
            this.nv_clt_titre.Text = "Bon de Retour Client";
            this.nv_clt_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CODE_Facture
            // 
            this.CODE_Facture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CODE_Facture.BackColor = System.Drawing.Color.White;
            this.CODE_Facture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_Facture.ForeColor = System.Drawing.Color.DarkRed;
            this.CODE_Facture.Location = new System.Drawing.Point(30, 19);
            this.CODE_Facture.Name = "CODE_Facture";
            this.CODE_Facture.ReadOnly = true;
            this.CODE_Facture.Size = new System.Drawing.Size(129, 21);
            this.CODE_Facture.TabIndex = 80;
            // 
            // btn_RECHERCHE_FACTURE
            // 
            this.btn_RECHERCHE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RECHERCHE_FACTURE.BackColor = System.Drawing.SystemColors.Control;
            this.btn_RECHERCHE_FACTURE.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.btn_RECHERCHE_FACTURE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RECHERCHE_FACTURE.Location = new System.Drawing.Point(165, 13);
            this.btn_RECHERCHE_FACTURE.Name = "btn_RECHERCHE_FACTURE";
            this.btn_RECHERCHE_FACTURE.Size = new System.Drawing.Size(30, 30);
            this.btn_RECHERCHE_FACTURE.TabIndex = 81;
            this.btn_RECHERCHE_FACTURE.UseVisualStyleBackColor = false;
            this.btn_RECHERCHE_FACTURE.Click += new System.EventHandler(this.btn_RECHERCHE_FACTURE_Click);
            // 
            // btn_VALIDER_BRC
            // 
            this.btn_VALIDER_BRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_VALIDER_BRC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VALIDER_BRC.Image = global::CHM_CLIENT_APP.Properties.Resources.document_enregistrez_icone_7256_32;
            this.btn_VALIDER_BRC.Location = new System.Drawing.Point(875, 60);
            this.btn_VALIDER_BRC.Name = "btn_VALIDER_BRC";
            this.btn_VALIDER_BRC.Size = new System.Drawing.Size(115, 42);
            this.btn_VALIDER_BRC.TabIndex = 81;
            this.btn_VALIDER_BRC.Text = "Enregistrer [F10]";
            this.btn_VALIDER_BRC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_VALIDER_BRC.UseVisualStyleBackColor = true;
            this.btn_VALIDER_BRC.Click += new System.EventHandler(this.btn_VALIDER_BRC_Click);
            // 
            // TTC
            // 
            this.TTC.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TTC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTC.ForeColor = System.Drawing.Color.DarkBlue;
            this.TTC.Location = new System.Drawing.Point(394, 20);
            this.TTC.Name = "TTC";
            this.TTC.Size = new System.Drawing.Size(162, 23);
            this.TTC.TabIndex = 82;
            this.TTC.Text = "...";
            this.TTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NP
            // 
            this.NP.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.NP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NP.ForeColor = System.Drawing.Color.DarkGreen;
            this.NP.Location = new System.Drawing.Point(414, 430);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(148, 23);
            this.NP.TabIndex = 82;
            this.NP.Text = "0,000";
            this.NP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TAUX_REMISE
            // 
            this.TAUX_REMISE.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TAUX_REMISE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAUX_REMISE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAUX_REMISE.ForeColor = System.Drawing.Color.DarkBlue;
            this.TAUX_REMISE.Location = new System.Drawing.Point(394, 56);
            this.TAUX_REMISE.Name = "TAUX_REMISE";
            this.TAUX_REMISE.Size = new System.Drawing.Size(162, 23);
            this.TAUX_REMISE.TabIndex = 82;
            this.TAUX_REMISE.Text = "...";
            this.TAUX_REMISE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TAUX_REMISE.Click += new System.EventHandler(this.lb_remise_Click);
            // 
            // lb_mnt_retour
            // 
            this.lb_mnt_retour.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lb_mnt_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_mnt_retour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mnt_retour.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mnt_retour.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_mnt_retour.Location = new System.Drawing.Point(259, 430);
            this.lb_mnt_retour.Name = "lb_mnt_retour";
            this.lb_mnt_retour.Size = new System.Drawing.Size(139, 23);
            this.lb_mnt_retour.TabIndex = 82;
            this.lb_mnt_retour.Text = "0,000";
            this.lb_mnt_retour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Montant :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(344, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Total Net :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(328, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Total :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(328, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Remise :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_mnt_retour);
            this.groupBox1.Controls.Add(this.dgv_detail_br);
            this.groupBox1.Location = new System.Drawing.Point(591, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 459);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails Bon de Retour";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgv_lg_facture);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.RS_CLIENT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DATE_FACTURE);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TAUX_REMISE);
            this.groupBox3.Controls.Add(this.NP);
            this.groupBox3.Controls.Add(this.TTC);
            this.groupBox3.Controls.Add(this.btn_RECHERCHE_FACTURE);
            this.groupBox3.Controls.Add(this.CODE_Facture);
            this.groupBox3.Location = new System.Drawing.Point(12, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 459);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Détails Facture";
            // 
            // dgv_lg_facture
            // 
            this.dgv_lg_facture.AllowUserToAddRows = false;
            this.dgv_lg_facture.AllowUserToDeleteRows = false;
            this.dgv_lg_facture.AllowUserToResizeColumns = false;
            this.dgv_lg_facture.AllowUserToResizeRows = false;
            this.dgv_lg_facture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lg_facture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lg_facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lg_facture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF_ARTICLE_,
            this.DESIGNATION_ARTICLE_,
            this.QTE_,
            this.PRIX_HT_LG_COMMANDE_,
            this.prix_tot_ht,
            this.TVA_,
            this.PRIX_TTC_LG_COMMANDE_,
            this.Column2});
            this.dgv_lg_facture.Location = new System.Drawing.Point(11, 87);
            this.dgv_lg_facture.MultiSelect = false;
            this.dgv_lg_facture.Name = "dgv_lg_facture";
            this.dgv_lg_facture.ReadOnly = true;
            this.dgv_lg_facture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_lg_facture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lg_facture.Size = new System.Drawing.Size(551, 340);
            this.dgv_lg_facture.TabIndex = 89;
            this.dgv_lg_facture.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_lg_facture_CellMouseClick);
            this.dgv_lg_facture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lg_facture_CellClick);
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RS_CLIENT.BackColor = System.Drawing.Color.Transparent;
            this.RS_CLIENT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS_CLIENT.Location = new System.Drawing.Point(109, 63);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(152, 13);
            this.RS_CLIENT.TabIndex = 83;
            this.RS_CLIENT.Text = "...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Client :";
            // 
            // DATE_FACTURE
            // 
            this.DATE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE_FACTURE.BackColor = System.Drawing.Color.Transparent;
            this.DATE_FACTURE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_FACTURE.Location = new System.Drawing.Point(109, 46);
            this.DATE_FACTURE.Name = "DATE_FACTURE";
            this.DATE_FACTURE.Size = new System.Drawing.Size(152, 13);
            this.DATE_FACTURE.TabIndex = 83;
            this.DATE_FACTURE.Text = "...";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Date facture :";
            // 
            // REF_ARTICLE_
            // 
            this.REF_ARTICLE_.DataPropertyName = "REF_ARTICLE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REF_ARTICLE_.DefaultCellStyle = dataGridViewCellStyle4;
            this.REF_ARTICLE_.FillWeight = 81.86047F;
            this.REF_ARTICLE_.HeaderText = "Réf.";
            this.REF_ARTICLE_.Name = "REF_ARTICLE_";
            this.REF_ARTICLE_.ReadOnly = true;
            this.REF_ARTICLE_.Visible = false;
            // 
            // DESIGNATION_ARTICLE_
            // 
            this.DESIGNATION_ARTICLE_.DataPropertyName = "DESIGNATION_ARTICLE";
            this.DESIGNATION_ARTICLE_.FillWeight = 187.8047F;
            this.DESIGNATION_ARTICLE_.HeaderText = "Désignation";
            this.DESIGNATION_ARTICLE_.Name = "DESIGNATION_ARTICLE_";
            this.DESIGNATION_ARTICLE_.ReadOnly = true;
            // 
            // QTE_
            // 
            this.QTE_.DataPropertyName = "QTE";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.QTE_.DefaultCellStyle = dataGridViewCellStyle5;
            this.QTE_.FillWeight = 73.06697F;
            this.QTE_.HeaderText = "Qté";
            this.QTE_.Name = "QTE_";
            this.QTE_.ReadOnly = true;
            // 
            // PRIX_HT_LG_COMMANDE_
            // 
            this.PRIX_HT_LG_COMMANDE_.DataPropertyName = "PRIX_HT_ARTICLE";
            dataGridViewCellStyle6.Format = "N3";
            this.PRIX_HT_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle6;
            this.PRIX_HT_LG_COMMANDE_.FillWeight = 100.0685F;
            this.PRIX_HT_LG_COMMANDE_.HeaderText = "Prix Unitaire";
            this.PRIX_HT_LG_COMMANDE_.Name = "PRIX_HT_LG_COMMANDE_";
            this.PRIX_HT_LG_COMMANDE_.ReadOnly = true;
            // 
            // prix_tot_ht
            // 
            this.prix_tot_ht.DataPropertyName = "PRIX_TOTAL_HT";
            this.prix_tot_ht.HeaderText = "Total avant remise";
            this.prix_tot_ht.Name = "prix_tot_ht";
            this.prix_tot_ht.ReadOnly = true;
            this.prix_tot_ht.Visible = false;
            // 
            // TVA_
            // 
            this.TVA_.DataPropertyName = "TVA_ARTICLE";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.TVA_.DefaultCellStyle = dataGridViewCellStyle7;
            this.TVA_.FillWeight = 58.59332F;
            this.TVA_.HeaderText = "TVA";
            this.TVA_.Name = "TVA_";
            this.TVA_.ReadOnly = true;
            this.TVA_.Visible = false;
            // 
            // PRIX_TTC_LG_COMMANDE_
            // 
            this.PRIX_TTC_LG_COMMANDE_.DataPropertyName = "PRIX_U_TTC";
            dataGridViewCellStyle8.Format = "N3";
            this.PRIX_TTC_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle8;
            this.PRIX_TTC_LG_COMMANDE_.FillWeight = 109.2761F;
            this.PRIX_TTC_LG_COMMANDE_.HeaderText = "Prix U. TTC";
            this.PRIX_TTC_LG_COMMANDE_.Name = "PRIX_TTC_LG_COMMANDE_";
            this.PRIX_TTC_LG_COMMANDE_.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PRIX_TOTAL_TTC";
            this.Column2.HeaderText = "Total TTC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DESIGNATION_ARTICLE";
            this.Column1.FillWeight = 172.4138F;
            this.Column1.HeaderText = "Désignation";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QTE_BRETOUR_CLIENT";
            this.Column3.FillWeight = 42.58307F;
            this.Column3.HeaderText = "Qté";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PRIX_BRETOUR_CLIENT";
            this.Column4.FillWeight = 85.00315F;
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // CHM_FRM_BON_RETOUR_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_VALIDER_BRC);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_FRM_BON_RETOUR_CLIENT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bon de Retour Client";
            this.Load += new System.EventHandler(this.CHM_FRM_BON_RETOUR_CLIENT_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_BON_RETOUR_CLIENT_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_br)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lg_facture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detail_br;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label nv_clt_titre;
        private System.Windows.Forms.TextBox CODE_Facture;
        private System.Windows.Forms.Button btn_RECHERCHE_FACTURE;
        private System.Windows.Forms.Button btn_VALIDER_BRC;
        private System.Windows.Forms.Label TTC;
        private System.Windows.Forms.Label NP;
        private System.Windows.Forms.Label TAUX_REMISE;
        private System.Windows.Forms.Label lb_mnt_retour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DATE_FACTURE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_lg_facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_HT_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_tot_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_TTC_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}