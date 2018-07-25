namespace CHM_CLIENT_APP
{
    partial class Fiche_b_liv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiche_b_liv));
            this.dgv_lg_b_liv = new System.Windows.Forms.DataGridView();
            this.REF_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION_ARTICLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTE_LG_B_LIV_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_HT_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_tot_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_TTC_LG_COMMANDE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TEL_CLIENT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ADRESSE_CLIENT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.REF_CLIENT = new System.Windows.Forms.Label();
            this.BTN_APERçU = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CODE_B_LIV_ = new System.Windows.Forms.Label();
            this.LIVRED = new System.Windows.Forms.CheckBox();
            this.FACTURED = new System.Windows.Forms.CheckBox();
            this.PREPARED = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DATE_B_LIV = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_mag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CODE_COMMANDE = new System.Windows.Forms.Label();
            this.BTN_FACTURATION = new System.Windows.Forms.Button();
            this.lbn_total_ttc = new LABEL_NUM.LabelNumerique();
            this.lbn_TauxTVA = new LABEL_NUM.LabelNumerique();
            this.lbn_total_remise = new LABEL_NUM.LabelNumerique();
            this.NP = new LABEL_NUM.LabelNumerique();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lg_b_liv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.Column1,
            this.prix_tot_ht,
            this.TVA_LG_COMMANDE_,
            this.PRIX_TTC_LG_COMMANDE_,
            this.Column2});
            this.dgv_lg_b_liv.Location = new System.Drawing.Point(12, 226);
            this.dgv_lg_b_liv.MultiSelect = false;
            this.dgv_lg_b_liv.Name = "dgv_lg_b_liv";
            this.dgv_lg_b_liv.ReadOnly = true;
            this.dgv_lg_b_liv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lg_b_liv.Size = new System.Drawing.Size(966, 231);
            this.dgv_lg_b_liv.TabIndex = 38;
            // 
            // REF_ARTICLE_
            // 
            this.REF_ARTICLE_.DataPropertyName = "REF_ARTICLE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REF_ARTICLE_.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.QTE_LG_B_LIV_.DefaultCellStyle = dataGridViewCellStyle2;
            this.QTE_LG_B_LIV_.FillWeight = 73.06697F;
            this.QTE_LG_B_LIV_.HeaderText = "Qte";
            this.QTE_LG_B_LIV_.Name = "QTE_LG_B_LIV_";
            this.QTE_LG_B_LIV_.ReadOnly = true;
            // 
            // PRIX_HT_LG_COMMANDE_
            // 
            this.PRIX_HT_LG_COMMANDE_.DataPropertyName = "PRIX_HT_B_LIV";
            dataGridViewCellStyle3.Format = "N3";
            this.PRIX_HT_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle3;
            this.PRIX_HT_LG_COMMANDE_.FillWeight = 100.0685F;
            this.PRIX_HT_LG_COMMANDE_.HeaderText = "Prix U. HT";
            this.PRIX_HT_LG_COMMANDE_.Name = "PRIX_HT_LG_COMMANDE_";
            this.PRIX_HT_LG_COMMANDE_.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "REMISE";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Remise";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.TVA_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle5;
            this.TVA_LG_COMMANDE_.FillWeight = 58.59332F;
            this.TVA_LG_COMMANDE_.HeaderText = "TVA";
            this.TVA_LG_COMMANDE_.Name = "TVA_LG_COMMANDE_";
            this.TVA_LG_COMMANDE_.ReadOnly = true;
            // 
            // PRIX_TTC_LG_COMMANDE_
            // 
            this.PRIX_TTC_LG_COMMANDE_.DataPropertyName = "PRIX_U_TTC";
            dataGridViewCellStyle6.Format = "N3";
            this.PRIX_TTC_LG_COMMANDE_.DefaultCellStyle = dataGridViewCellStyle6;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TEL_CLIENT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ADRESSE_CLIENT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RS_CLIENT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.REF_CLIENT);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 113);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tel :";
            // 
            // TEL_CLIENT
            // 
            this.TEL_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TEL_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEL_CLIENT.Location = new System.Drawing.Point(80, 83);
            this.TEL_CLIENT.Name = "TEL_CLIENT";
            this.TEL_CLIENT.Size = new System.Drawing.Size(126, 20);
            this.TEL_CLIENT.TabIndex = 33;
            this.TEL_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Adresse :";
            // 
            // ADRESSE_CLIENT
            // 
            this.ADRESSE_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ADRESSE_CLIENT.Location = new System.Drawing.Point(80, 52);
            this.ADRESSE_CLIENT.Multiline = true;
            this.ADRESSE_CLIENT.Name = "ADRESSE_CLIENT";
            this.ADRESSE_CLIENT.Size = new System.Drawing.Size(347, 24);
            this.ADRESSE_CLIENT.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "RS Client :";
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RS_CLIENT.Location = new System.Drawing.Point(288, 22);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(139, 20);
            this.RS_CLIENT.TabIndex = 29;
            this.RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Code :";
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REF_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.REF_CLIENT.Location = new System.Drawing.Point(80, 22);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.Size = new System.Drawing.Size(110, 20);
            this.REF_CLIENT.TabIndex = 29;
            this.REF_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_APERçU
            // 
            this.BTN_APERçU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_APERçU.BackColor = System.Drawing.Color.Transparent;
            this.BTN_APERçU.Image = global::CHM_CLIENT_APP.Properties.Resources.filefind_icone_7697_32;
            this.BTN_APERçU.Location = new System.Drawing.Point(856, 58);
            this.BTN_APERçU.Name = "BTN_APERçU";
            this.BTN_APERçU.Size = new System.Drawing.Size(117, 43);
            this.BTN_APERçU.TabIndex = 39;
            this.BTN_APERçU.Text = "Aperçu [F8]";
            this.BTN_APERçU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_APERçU.UseVisualStyleBackColor = false;
            this.BTN_APERçU.Click += new System.EventHandler(this.BTN_APERçU_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CODE_B_LIV_);
            this.groupBox2.Controls.Add(this.LIVRED);
            this.groupBox2.Controls.Add(this.FACTURED);
            this.groupBox2.Controls.Add(this.PREPARED);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DATE_B_LIV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lb_mag);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CODE_COMMANDE);
            this.groupBox2.Location = new System.Drawing.Point(460, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 113);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information du bon de livraison";
            // 
            // CODE_B_LIV_
            // 
            this.CODE_B_LIV_.BackColor = System.Drawing.Color.White;
            this.CODE_B_LIV_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_B_LIV_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_B_LIV_.ForeColor = System.Drawing.Color.Maroon;
            this.CODE_B_LIV_.Location = new System.Drawing.Point(106, 18);
            this.CODE_B_LIV_.Name = "CODE_B_LIV_";
            this.CODE_B_LIV_.Size = new System.Drawing.Size(157, 20);
            this.CODE_B_LIV_.TabIndex = 41;
            this.CODE_B_LIV_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LIVRED
            // 
            this.LIVRED.AutoSize = true;
            this.LIVRED.Location = new System.Drawing.Point(463, 90);
            this.LIVRED.Name = "LIVRED";
            this.LIVRED.Size = new System.Drawing.Size(49, 17);
            this.LIVRED.TabIndex = 40;
            this.LIVRED.Text = "Livré";
            this.LIVRED.UseVisualStyleBackColor = true;
            // 
            // FACTURED
            // 
            this.FACTURED.AutoSize = true;
            this.FACTURED.Location = new System.Drawing.Point(376, 90);
            this.FACTURED.Name = "FACTURED";
            this.FACTURED.Size = new System.Drawing.Size(62, 17);
            this.FACTURED.TabIndex = 39;
            this.FACTURED.Text = "Facturé";
            this.FACTURED.UseVisualStyleBackColor = true;
            // 
            // PREPARED
            // 
            this.PREPARED.AutoSize = true;
            this.PREPARED.Location = new System.Drawing.Point(287, 90);
            this.PREPARED.Name = "PREPARED";
            this.PREPARED.Size = new System.Drawing.Size(63, 17);
            this.PREPARED.TabIndex = 38;
            this.PREPARED.Text = "Préparé";
            this.PREPARED.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Date de livraison :";
            // 
            // DATE_B_LIV
            // 
            this.DATE_B_LIV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_B_LIV.Location = new System.Drawing.Point(106, 44);
            this.DATE_B_LIV.Name = "DATE_B_LIV";
            this.DATE_B_LIV.Size = new System.Drawing.Size(157, 20);
            this.DATE_B_LIV.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Code B.L. :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Magasin :";
            // 
            // lb_mag
            // 
            this.lb_mag.BackColor = System.Drawing.Color.White;
            this.lb_mag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mag.ForeColor = System.Drawing.Color.Maroon;
            this.lb_mag.Location = new System.Drawing.Point(106, 70);
            this.lb_mag.Name = "lb_mag";
            this.lb_mag.Size = new System.Drawing.Size(157, 20);
            this.lb_mag.TabIndex = 20;
            this.lb_mag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Code commande :";
            // 
            // CODE_COMMANDE
            // 
            this.CODE_COMMANDE.BackColor = System.Drawing.Color.White;
            this.CODE_COMMANDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_COMMANDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_COMMANDE.ForeColor = System.Drawing.Color.Maroon;
            this.CODE_COMMANDE.Location = new System.Drawing.Point(287, 41);
            this.CODE_COMMANDE.Name = "CODE_COMMANDE";
            this.CODE_COMMANDE.Size = new System.Drawing.Size(225, 20);
            this.CODE_COMMANDE.TabIndex = 20;
            this.CODE_COMMANDE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_FACTURATION
            // 
            this.BTN_FACTURATION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_FACTURATION.BackColor = System.Drawing.Color.Transparent;
            this.BTN_FACTURATION.Image = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_32;
            this.BTN_FACTURATION.Location = new System.Drawing.Point(734, 58);
            this.BTN_FACTURATION.Name = "BTN_FACTURATION";
            this.BTN_FACTURATION.Size = new System.Drawing.Size(117, 43);
            this.BTN_FACTURATION.TabIndex = 41;
            this.BTN_FACTURATION.Text = "Facturation [F12]";
            this.BTN_FACTURATION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_FACTURATION.UseVisualStyleBackColor = false;
            this.BTN_FACTURATION.Click += new System.EventHandler(this.BTN_FACTURATION_Click);
            // 
            // lbn_total_ttc
            // 
            this.lbn_total_ttc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbn_total_ttc.BackColor = System.Drawing.Color.Black;
            this.lbn_total_ttc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbn_total_ttc.Clinote = true;
            this.lbn_total_ttc.Couleur1 = System.Drawing.Color.Lime;
            this.lbn_total_ttc.Couleur2 = System.Drawing.Color.OrangeRed;
            this.lbn_total_ttc.DecimalPlaces = 3;
            this.lbn_total_ttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_total_ttc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbn_total_ttc.Location = new System.Drawing.Point(826, 483);
            this.lbn_total_ttc.Name = "lbn_total_ttc";
            this.lbn_total_ttc.Size = new System.Drawing.Size(152, 30);
            this.lbn_total_ttc.TabIndex = 104;
            this.lbn_total_ttc.Text = "0.000";
            this.lbn_total_ttc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbn_total_ttc.ThousandsSeparator = true;
            this.lbn_total_ttc.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lbn_TauxTVA
            // 
            this.lbn_TauxTVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbn_TauxTVA.BackColor = System.Drawing.Color.Silver;
            this.lbn_TauxTVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbn_TauxTVA.Clinote = true;
            this.lbn_TauxTVA.Couleur1 = System.Drawing.Color.Black;
            this.lbn_TauxTVA.Couleur2 = System.Drawing.Color.Black;
            this.lbn_TauxTVA.DecimalPlaces = 3;
            this.lbn_TauxTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_TauxTVA.ForeColor = System.Drawing.Color.Black;
            this.lbn_TauxTVA.Location = new System.Drawing.Point(291, 483);
            this.lbn_TauxTVA.Name = "lbn_TauxTVA";
            this.lbn_TauxTVA.Size = new System.Drawing.Size(129, 30);
            this.lbn_TauxTVA.TabIndex = 107;
            this.lbn_TauxTVA.Text = "0.000";
            this.lbn_TauxTVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbn_TauxTVA.ThousandsSeparator = true;
            this.lbn_TauxTVA.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lbn_total_remise
            // 
            this.lbn_total_remise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbn_total_remise.BackColor = System.Drawing.Color.Silver;
            this.lbn_total_remise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbn_total_remise.Clinote = true;
            this.lbn_total_remise.Couleur1 = System.Drawing.Color.Black;
            this.lbn_total_remise.Couleur2 = System.Drawing.Color.Black;
            this.lbn_total_remise.DecimalPlaces = 3;
            this.lbn_total_remise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_total_remise.ForeColor = System.Drawing.Color.Black;
            this.lbn_total_remise.Location = new System.Drawing.Point(153, 483);
            this.lbn_total_remise.Name = "lbn_total_remise";
            this.lbn_total_remise.Size = new System.Drawing.Size(129, 30);
            this.lbn_total_remise.TabIndex = 106;
            this.lbn_total_remise.Text = "0.000";
            this.lbn_total_remise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbn_total_remise.ThousandsSeparator = true;
            this.lbn_total_remise.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NP
            // 
            this.NP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NP.BackColor = System.Drawing.Color.Silver;
            this.NP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NP.Clinote = true;
            this.NP.Couleur1 = System.Drawing.Color.Black;
            this.NP.Couleur2 = System.Drawing.Color.Black;
            this.NP.DecimalPlaces = 3;
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NP.ForeColor = System.Drawing.Color.Black;
            this.NP.Location = new System.Drawing.Point(15, 483);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(129, 30);
            this.NP.TabIndex = 105;
            this.NP.Text = "0.000";
            this.NP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NP.ThousandsSeparator = true;
            this.NP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(288, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 102;
            this.label12.Text = "Total TVA :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(150, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Total remise :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(823, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 100;
            this.label10.Text = "Total Net :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 103;
            this.label6.Text = "Total H.T.:";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(990, 48);
            this.entete_Formulaire_21.TabIndex = 108;
            // 
            // Fiche_b_liv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 522);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.lbn_total_ttc);
            this.Controls.Add(this.lbn_TauxTVA);
            this.Controls.Add(this.lbn_total_remise);
            this.Controls.Add(this.NP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_FACTURATION);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_APERçU);
            this.Controls.Add(this.dgv_lg_b_liv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Fiche_b_liv";
            this.Text = "Bon de livraison";
            this.Shown += new System.EventHandler(this.Fiche_Commande_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fiche_b_liv_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lg_b_liv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lg_b_liv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TEL_CLIENT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ADRESSE_CLIENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label REF_CLIENT;
        private System.Windows.Forms.Button BTN_APERçU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox LIVRED;
        private System.Windows.Forms.CheckBox FACTURED;
        private System.Windows.Forms.CheckBox PREPARED;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DATE_B_LIV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CODE_COMMANDE;
        private System.Windows.Forms.Label CODE_B_LIV_;
        private System.Windows.Forms.Button BTN_FACTURATION;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_mag;
        private LABEL_NUM.LabelNumerique lbn_total_ttc;
        private LABEL_NUM.LabelNumerique lbn_TauxTVA;
        private LABEL_NUM.LabelNumerique lbn_total_remise;
        private LABEL_NUM.LabelNumerique NP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION_ARTICLE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTE_LG_B_LIV_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_HT_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_tot_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_TTC_LG_COMMANDE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}