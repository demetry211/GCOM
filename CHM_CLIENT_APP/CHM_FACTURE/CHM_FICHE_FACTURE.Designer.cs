namespace CHM_CLIENT_APP
{
    partial class CHM_FICHE_FACTURE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PARCOURIR_LISTE_CLIENT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remarq = new System.Windows.Forms.Label();
            this.HT = new LABEL_NUM.LabelNumerique();
            this.TVA = new LABEL_NUM.LabelNumerique();
            this.TTC = new LABEL_NUM.LabelNumerique();
            this.TIMBRE = new LABEL_NUM.LabelNumerique();
            this.NP = new LABEL_NUM.LabelNumerique();
            this.TAUX_REMISE = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TTC1 = new System.Windows.Forms.Label();
            this.TVA1 = new System.Windows.Forms.Label();
            this.ML = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DATE_FACTURE = new System.Windows.Forms.DateTimePicker();
            this.CODE_FACTURE = new System.Windows.Forms.Label();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.REF_CLIENT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_b_liv = new System.Windows.Forms.DataGridView();
            this.CODE_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOMME_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOIX_ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_lg_b_liv = new System.Windows.Forms.DataGridView();
            this.REF_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE_LG_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_HT_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_tot_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_TTC_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_APERçU = new System.Windows.Forms.Button();
            this.BTN_ENREGISTRER = new System.Windows.Forms.Button();
            this.BTN_REGLEMENT = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_liste_commande = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAUX_REMISE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_b_liv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lg_b_liv)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PARCOURIR_LISTE_CLIENT
            // 
            this.PARCOURIR_LISTE_CLIENT.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.trouver_loupe_recherche_zoom_icone_6756_32;
            this.PARCOURIR_LISTE_CLIENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PARCOURIR_LISTE_CLIENT.Location = new System.Drawing.Point(370, 103);
            this.PARCOURIR_LISTE_CLIENT.Name = "PARCOURIR_LISTE_CLIENT";
            this.PARCOURIR_LISTE_CLIENT.Size = new System.Drawing.Size(38, 36);
            this.PARCOURIR_LISTE_CLIENT.TabIndex = 32;
            this.PARCOURIR_LISTE_CLIENT.UseVisualStyleBackColor = true;
            this.PARCOURIR_LISTE_CLIENT.Click += new System.EventHandler(this.PARCOURIR_LISTE_CLIENT_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.remarq);
            this.panel1.Controls.Add(this.HT);
            this.panel1.Controls.Add(this.TVA);
            this.panel1.Controls.Add(this.TTC);
            this.panel1.Controls.Add(this.TIMBRE);
            this.panel1.Controls.Add(this.NP);
            this.panel1.Controls.Add(this.TAUX_REMISE);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TTC1);
            this.panel1.Controls.Add(this.TVA1);
            this.panel1.Controls.Add(this.ML);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 150);
            this.panel1.TabIndex = 35;
            // 
            // remarq
            // 
            this.remarq.AutoSize = true;
            this.remarq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarq.Location = new System.Drawing.Point(3, 106);
            this.remarq.Name = "remarq";
            this.remarq.Size = new System.Drawing.Size(0, 13);
            this.remarq.TabIndex = 8;
            // 
            // HT
            // 
            this.HT.AutoSize = true;
            this.HT.Clinote = false;
            this.HT.Couleur1 = System.Drawing.Color.Black;
            this.HT.Couleur2 = System.Drawing.Color.Red;
            this.HT.DecimalPlaces = 3;
            this.HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HT.ForeColor = System.Drawing.Color.Black;
            this.HT.Location = new System.Drawing.Point(97, 7);
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(39, 13);
            this.HT.TabIndex = 6;
            this.HT.Text = "0.000";
            this.HT.ThousandsSeparator = true;
            this.HT.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TVA
            // 
            this.TVA.AutoSize = true;
            this.TVA.Clinote = false;
            this.TVA.Couleur1 = System.Drawing.Color.Black;
            this.TVA.Couleur2 = System.Drawing.Color.Red;
            this.TVA.DecimalPlaces = 3;
            this.TVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVA.ForeColor = System.Drawing.Color.Black;
            this.TVA.Location = new System.Drawing.Point(603, 7);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(39, 13);
            this.TVA.TabIndex = 7;
            this.TVA.Text = "0.000";
            this.TVA.ThousandsSeparator = true;
            this.TVA.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TTC
            // 
            this.TTC.AutoSize = true;
            this.TTC.Clinote = false;
            this.TTC.Couleur1 = System.Drawing.Color.Black;
            this.TTC.Couleur2 = System.Drawing.Color.Red;
            this.TTC.DecimalPlaces = 3;
            this.TTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTC.ForeColor = System.Drawing.Color.Black;
            this.TTC.Location = new System.Drawing.Point(867, 7);
            this.TTC.Name = "TTC";
            this.TTC.Size = new System.Drawing.Size(39, 13);
            this.TTC.TabIndex = 5;
            this.TTC.Text = "0.000";
            this.TTC.ThousandsSeparator = true;
            this.TTC.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TIMBRE
            // 
            this.TIMBRE.AutoSize = true;
            this.TIMBRE.Clinote = false;
            this.TIMBRE.Couleur1 = System.Drawing.Color.Black;
            this.TIMBRE.Couleur2 = System.Drawing.Color.Red;
            this.TIMBRE.DecimalPlaces = 3;
            this.TIMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIMBRE.ForeColor = System.Drawing.Color.Black;
            this.TIMBRE.Location = new System.Drawing.Point(867, 27);
            this.TIMBRE.Name = "TIMBRE";
            this.TIMBRE.Size = new System.Drawing.Size(39, 13);
            this.TIMBRE.TabIndex = 3;
            this.TIMBRE.Text = "0.300";
            this.TIMBRE.ThousandsSeparator = true;
            this.TIMBRE.Value = new decimal(new int[] {
            300,
            0,
            0,
            196608});
            // 
            // NP
            // 
            this.NP.AutoSize = true;
            this.NP.Clinote = true;
            this.NP.Couleur1 = System.Drawing.Color.Gray;
            this.NP.Couleur2 = System.Drawing.Color.OrangeRed;
            this.NP.DecimalPlaces = 3;
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NP.ForeColor = System.Drawing.Color.Gray;
            this.NP.Location = new System.Drawing.Point(859, 75);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(60, 24);
            this.NP.TabIndex = 4;
            this.NP.Text = "0.000";
            this.NP.ThousandsSeparator = true;
            this.NP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TAUX_REMISE
            // 
            this.TAUX_REMISE.DecimalPlaces = 2;
            this.TAUX_REMISE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAUX_REMISE.Location = new System.Drawing.Point(321, 5);
            this.TAUX_REMISE.Name = "TAUX_REMISE";
            this.TAUX_REMISE.Size = new System.Drawing.Size(82, 20);
            this.TAUX_REMISE.TabIndex = 1;
            this.TAUX_REMISE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TAUX_REMISE.ValueChanged += new System.EventHandler(this.TAUX_REMISE_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(346, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Remise :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(714, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Net a payer :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(759, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Timbre :";
            // 
            // TTC1
            // 
            this.TTC1.AutoSize = true;
            this.TTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTC1.Location = new System.Drawing.Point(759, 7);
            this.TTC1.Name = "TTC1";
            this.TTC1.Size = new System.Drawing.Size(105, 13);
            this.TTC1.TabIndex = 0;
            this.TTC1.Text = "Montant T. TTC :";
            // 
            // TVA1
            // 
            this.TVA1.AutoSize = true;
            this.TVA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVA1.Location = new System.Drawing.Point(492, 7);
            this.TVA1.Name = "TVA1";
            this.TVA1.Size = new System.Drawing.Size(105, 13);
            this.TVA1.TabIndex = 0;
            this.TVA1.Text = "Montant T. TVA :";
            // 
            // ML
            // 
            this.ML.AutoSize = true;
            this.ML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ML.Location = new System.Drawing.Point(3, 75);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(245, 13);
            this.ML.TabIndex = 0;
            this.ML.Text = "Arreter la présente facture à la somme de ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Montant T. HT :";
            // 
            // DATE_FACTURE
            // 
            this.DATE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE_FACTURE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_FACTURE.Location = new System.Drawing.Point(874, 112);
            this.DATE_FACTURE.Name = "DATE_FACTURE";
            this.DATE_FACTURE.Size = new System.Drawing.Size(124, 20);
            this.DATE_FACTURE.TabIndex = 31;
            // 
            // CODE_FACTURE
            // 
            this.CODE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CODE_FACTURE.BackColor = System.Drawing.Color.White;
            this.CODE_FACTURE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_FACTURE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_FACTURE.ForeColor = System.Drawing.Color.Maroon;
            this.CODE_FACTURE.Location = new System.Drawing.Point(666, 112);
            this.CODE_FACTURE.Name = "CODE_FACTURE";
            this.CODE_FACTURE.Size = new System.Drawing.Size(193, 20);
            this.CODE_FACTURE.TabIndex = 30;
            this.CODE_FACTURE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RS_CLIENT.Location = new System.Drawing.Point(166, 111);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(203, 20);
            this.RS_CLIENT.TabIndex = 29;
            this.RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.Location = new System.Drawing.Point(64, 111);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.Size = new System.Drawing.Size(96, 20);
            this.REF_CLIENT.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Client :";
            // 
            // dgv_b_liv
            // 
            this.dgv_b_liv.AllowUserToAddRows = false;
            this.dgv_b_liv.AllowUserToDeleteRows = false;
            this.dgv_b_liv.AllowUserToResizeColumns = false;
            this.dgv_b_liv.AllowUserToResizeRows = false;
            this.dgv_b_liv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_b_liv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_b_liv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_b_liv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_B_LIV_,
            this.DATE_B_LIV_,
            this.SOMME_B_LIV_,
            this.CHOIX_});
            this.dgv_b_liv.Location = new System.Drawing.Point(15, 143);
            this.dgv_b_liv.MultiSelect = false;
            this.dgv_b_liv.Name = "dgv_b_liv";
            this.dgv_b_liv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_b_liv.Size = new System.Drawing.Size(986, 108);
            this.dgv_b_liv.TabIndex = 33;
            this.dgv_b_liv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCOMMANDE_CellValueChanged);
            this.dgv_b_liv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCOMMANDE_CellDoubleClick);
            // 
            // CODE_B_LIV_
            // 
            this.CODE_B_LIV_.DataPropertyName = "CODE_B_LIV";
            this.CODE_B_LIV_.FillWeight = 166.1824F;
            this.CODE_B_LIV_.HeaderText = "N° Bon de Livraison";
            this.CODE_B_LIV_.Name = "CODE_B_LIV_";
            this.CODE_B_LIV_.ReadOnly = true;
            // 
            // DATE_B_LIV_
            // 
            this.DATE_B_LIV_.DataPropertyName = "DATE_B_LIV";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.DATE_B_LIV_.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATE_B_LIV_.FillWeight = 90.67374F;
            this.DATE_B_LIV_.HeaderText = "Date";
            this.DATE_B_LIV_.Name = "DATE_B_LIV_";
            this.DATE_B_LIV_.ReadOnly = true;
            // 
            // SOMME_B_LIV_
            // 
            this.SOMME_B_LIV_.DataPropertyName = "SOMME_B_LIV";
            this.SOMME_B_LIV_.HeaderText = "Montant TTC";
            this.SOMME_B_LIV_.Name = "SOMME_B_LIV_";
            // 
            // CHOIX_
            // 
            this.CHOIX_.DataPropertyName = "CHOIX";
            this.CHOIX_.FillWeight = 62.33535F;
            this.CHOIX_.HeaderText = "Choix";
            this.CHOIX_.Name = "CHOIX_";
            // 
            // dgv_lg_b_liv
            // 
            this.dgv_lg_b_liv.AllowUserToAddRows = false;
            this.dgv_lg_b_liv.AllowUserToDeleteRows = false;
            this.dgv_lg_b_liv.AllowUserToResizeColumns = false;
            this.dgv_lg_b_liv.AllowUserToResizeRows = false;
            this.dgv_lg_b_liv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lg_b_liv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lg_b_liv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lg_b_liv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF_ARTICLE_,
            this.DESIGNATION_ARTICLE_,
            this.QTE_LG_B_LIV_,
            this.PRIX_HT_LG_COMMANDE_,
            this.prix_tot_ht,
            this.TVA_LG_COMMANDE_,
            this.PRIX_TTC_LG_COMMANDE_,
            this.Column2});
            this.dgv_lg_b_liv.Location = new System.Drawing.Point(15, 257);
            this.dgv_lg_b_liv.MultiSelect = false;
            this.dgv_lg_b_liv.Name = "dgv_lg_b_liv";
            this.dgv_lg_b_liv.ReadOnly = true;
            this.dgv_lg_b_liv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lg_b_liv.Size = new System.Drawing.Size(986, 247);
            this.dgv_lg_b_liv.TabIndex = 36;
            this.dgv_lg_b_liv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_lg_b_liv_RowsAdded);
            this.dgv_lg_b_liv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_lg_b_liv_RowsRemoved);
            // 
            // REF_ARTICLE_
            // 
            this.REF_ARTICLE_.DataPropertyName = "REF_ARTICLE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REF_ARTICLE_.DefaultCellStyle = dataGridViewCellStyle8;
            this.REF_ARTICLE_.FillWeight = 81.86047F;
            this.REF_ARTICLE_.HeaderText = "Réf.";
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
            // QTE_LG_B_LIV_
            // 
            this.QTE_LG_B_LIV_.DataPropertyName = "QTE_LIGNE_B_LIV";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = null;
            this.QTE_LG_B_LIV_.DefaultCellStyle = dataGridViewCellStyle9;
            this.QTE_LG_B_LIV_.FillWeight = 73.06697F;
            this.QTE_LG_B_LIV_.HeaderText = "Qte";
            this.QTE_LG_B_LIV_.Name = "QTE_LG_B_LIV_";
            this.QTE_LG_B_LIV_.ReadOnly = true;
            // 
            // PRIX_HT_LG_COMMANDE_
            // 
            this.PRIX_HT_LG_COMMANDE_.DataPropertyName = "PRIX_HT_B_LIV";
            dataGridViewCellStyle10.Format = "N3";
            this.PRIX_HT_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle10;
            this.PRIX_HT_LG_COMMANDE_.FillWeight = 100.0685F;
            this.PRIX_HT_LG_COMMANDE_.HeaderText = "Prix U. HT";
            this.PRIX_HT_LG_COMMANDE_.Name = "PRIX_HT_LG_COMMANDE_";
            this.PRIX_HT_LG_COMMANDE_.ReadOnly = true;
            // 
            // prix_tot_ht
            // 
            this.prix_tot_ht.DataPropertyName = "PRIX_TOTAL_HT";
            this.prix_tot_ht.HeaderText = "Prix Total HT. ";
            this.prix_tot_ht.Name = "prix_tot_ht";
            this.prix_tot_ht.ReadOnly = true;
            // 
            // TVA_LG_COMMANDE_
            // 
            this.TVA_LG_COMMANDE_.DataPropertyName = "TVA_B_LIV";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.TVA_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle11;
            this.TVA_LG_COMMANDE_.FillWeight = 58.59332F;
            this.TVA_LG_COMMANDE_.HeaderText = "TVA";
            this.TVA_LG_COMMANDE_.Name = "TVA_LG_COMMANDE_";
            this.TVA_LG_COMMANDE_.ReadOnly = true;
            // 
            // PRIX_TTC_LG_COMMANDE_
            // 
            this.PRIX_TTC_LG_COMMANDE_.DataPropertyName = "PRIX_U_TTC";
            dataGridViewCellStyle12.Format = "N3";
            this.PRIX_TTC_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle12;
            this.PRIX_TTC_LG_COMMANDE_.FillWeight = 109.2761F;
            this.PRIX_TTC_LG_COMMANDE_.HeaderText = "Prix U. TTC";
            this.PRIX_TTC_LG_COMMANDE_.Name = "PRIX_TTC_LG_COMMANDE_";
            this.PRIX_TTC_LG_COMMANDE_.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PRIX_TOTAL_TTC";
            this.Column2.HeaderText = "Prix Total TTC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // BTN_APERçU
            // 
            this.BTN_APERçU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_APERçU.BackColor = System.Drawing.Color.Transparent;
            this.BTN_APERçU.Image = global::CHM_CLIENT_APP.Properties.Resources.filefind_icone_7697_32;
            this.BTN_APERçU.Location = new System.Drawing.Point(667, 58);
            this.BTN_APERçU.Name = "BTN_APERçU";
            this.BTN_APERçU.Size = new System.Drawing.Size(106, 43);
            this.BTN_APERçU.TabIndex = 39;
            this.BTN_APERçU.Text = "Aperçu [F8]";
            this.BTN_APERçU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_APERçU.UseVisualStyleBackColor = false;
            // 
            // BTN_ENREGISTRER
            // 
            this.BTN_ENREGISTRER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ENREGISTRER.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ENREGISTRER.Image = global::CHM_CLIENT_APP.Properties.Resources.document_enregistrez_icone_7256_32;
            this.BTN_ENREGISTRER.Location = new System.Drawing.Point(435, 58);
            this.BTN_ENREGISTRER.Name = "BTN_ENREGISTRER";
            this.BTN_ENREGISTRER.Size = new System.Drawing.Size(106, 43);
            this.BTN_ENREGISTRER.TabIndex = 38;
            this.BTN_ENREGISTRER.Text = "Enregistrer [F10]";
            this.BTN_ENREGISTRER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_ENREGISTRER.UseVisualStyleBackColor = false;
            this.BTN_ENREGISTRER.Click += new System.EventHandler(this.BTN_ENREGISTRER_Click);
            // 
            // BTN_REGLEMENT
            // 
            this.BTN_REGLEMENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_REGLEMENT.BackColor = System.Drawing.Color.Transparent;
            this.BTN_REGLEMENT.Image = global::CHM_CLIENT_APP.Properties.Resources.daffaires_monnaies_dolar_metal_argent_paiement_icone_3854_32;
            this.BTN_REGLEMENT.Location = new System.Drawing.Point(551, 58);
            this.BTN_REGLEMENT.Name = "BTN_REGLEMENT";
            this.BTN_REGLEMENT.Size = new System.Drawing.Size(106, 43);
            this.BTN_REGLEMENT.TabIndex = 37;
            this.BTN_REGLEMENT.Text = "Réglement [F12]";
            this.BTN_REGLEMENT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_REGLEMENT.UseVisualStyleBackColor = false;
            this.BTN_REGLEMENT.Click += new System.EventHandler(this.BTN_FACTURATION_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(-2, -10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1020, 62);
            this.groupBox5.TabIndex = 79;
            this.groupBox5.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(972, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 33);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(948, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nouvelle Facture Client";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_liste_commande
            // 
            this.btn_liste_commande.AccessibleDescription = "ergdfgdf";
            this.btn_liste_commande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_liste_commande.Image = global::CHM_CLIENT_APP.Properties.Resources.demande_afficher_la_liste_icone_8709_322;
            this.btn_liste_commande.Location = new System.Drawing.Point(785, 58);
            this.btn_liste_commande.Name = "btn_liste_commande";
            this.btn_liste_commande.Size = new System.Drawing.Size(106, 43);
            this.btn_liste_commande.TabIndex = 80;
            this.btn_liste_commande.Tag = "";
            this.btn_liste_commande.Text = "Liste des factures [CTRL+L]";
            this.btn_liste_commande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_liste_commande.UseVisualStyleBackColor = true;
            this.btn_liste_commande.Click += new System.EventHandler(this.btn_liste_commande_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.fleches_interagir_recharger_mise_a_jour_icone_5225_32;
            this.button1.Location = new System.Drawing.Point(897, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 91;
            this.button1.Text = "Actualiser [F5]";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHM_FICHE_FACTURE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1017, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_liste_commande);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BTN_APERçU);
            this.Controls.Add(this.BTN_ENREGISTRER);
            this.Controls.Add(this.BTN_REGLEMENT);
            this.Controls.Add(this.dgv_lg_b_liv);
            this.Controls.Add(this.PARCOURIR_LISTE_CLIENT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DATE_FACTURE);
            this.Controls.Add(this.CODE_FACTURE);
            this.Controls.Add(this.RS_CLIENT);
            this.Controls.Add(this.REF_CLIENT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_b_liv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "CHM_FICHE_FACTURE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle Facture Client";
            this.Shown += new System.EventHandler(this.CHM_FICHE_FACTURE_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FICHE_FACTURE_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAUX_REMISE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_b_liv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lg_b_liv)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PARCOURIR_LISTE_CLIENT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown TAUX_REMISE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TTC1;
        private System.Windows.Forms.Label TVA1;
        private System.Windows.Forms.Label ML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DATE_FACTURE;
        private System.Windows.Forms.Label CODE_FACTURE;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.TextBox REF_CLIENT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_b_liv;
        private LABEL_NUM.LabelNumerique HT;
        private LABEL_NUM.LabelNumerique TVA;
        private LABEL_NUM.LabelNumerique TTC;
        private LABEL_NUM.LabelNumerique TIMBRE;
        private LABEL_NUM.LabelNumerique NP;
        private System.Windows.Forms.DataGridView dgv_lg_b_liv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOMME_B_LIV_;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHOIX_;
        private System.Windows.Forms.Button BTN_APERçU;
        private System.Windows.Forms.Button BTN_ENREGISTRER;
        private System.Windows.Forms.Button BTN_REGLEMENT;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_liste_commande;
        private System.Windows.Forms.Label remarq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE_LG_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_HT_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_tot_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_TTC_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button6;
    }
}