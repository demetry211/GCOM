namespace CHM_CLIENT_APP
{
    partial class CHM_ARTICLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_ARTICLE));
            this.BTN_MODIFIER = new System.Windows.Forms.Button();
            this.BTN_SUPPRIMER = new System.Windows.Forms.Button();
            this.BTN_AJOUTER = new System.Windows.Forms.Button();
            this.client_to_liste = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_general = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DESCRIPTION_ARTICLE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UNITE_QTE_M = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UNITE_QTE = new System.Windows.Forms.TextBox();
            this.CTRL_CODE_BARRE_ARTICLE = new BARRE_CODE.BarCodeCtrl();
            this.CODE_BARRE_ARTICLE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PRIX_HT_V_ARTICLE = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TVA_ARTICLE = new System.Windows.Forms.TextBox();
            this.QTE_MIN_ARTICLE = new System.Windows.Forms.TextBox();
            this.PRIX_HT_A_ARTICLE = new System.Windows.Forms.TextBox();
            this.QTE_ARTICLE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MARQUE_ARTICLE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DESIGNATION_ARTICLE = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MAGASIN = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CATEGORIE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FOURNISSEUR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.REF_ARTICLE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ETAT_ARTICLE = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_article_suivant = new System.Windows.Forms.Button();
            this.btn_article_prec = new System.Windows.Forms.Button();
            this.PHOTO_ARTICLE = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ds_fiche_article = new System.Data.DataSet();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.tabControl1.SuspendLayout();
            this.tp_general.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_ARTICLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_fiche_article)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_MODIFIER
            // 
            this.BTN_MODIFIER.Image = global::CHM_CLIENT_APP.Properties.Resources.arrow_tourner_vers_la_droite_icone_8357_32;
            this.BTN_MODIFIER.Location = new System.Drawing.Point(675, 54);
            this.BTN_MODIFIER.Name = "BTN_MODIFIER";
            this.BTN_MODIFIER.Size = new System.Drawing.Size(94, 45);
            this.BTN_MODIFIER.TabIndex = 71;
            this.BTN_MODIFIER.Text = "Modifier";
            this.BTN_MODIFIER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_MODIFIER.UseVisualStyleBackColor = true;
            this.BTN_MODIFIER.Click += new System.EventHandler(this.BTN_MODIFIER_Click);
            // 
            // BTN_SUPPRIMER
            // 
            this.BTN_SUPPRIMER.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.BTN_SUPPRIMER.Location = new System.Drawing.Point(778, 54);
            this.BTN_SUPPRIMER.Name = "BTN_SUPPRIMER";
            this.BTN_SUPPRIMER.Size = new System.Drawing.Size(94, 45);
            this.BTN_SUPPRIMER.TabIndex = 70;
            this.BTN_SUPPRIMER.Text = "Supprimer";
            this.BTN_SUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_SUPPRIMER.UseVisualStyleBackColor = true;
            this.BTN_SUPPRIMER.Click += new System.EventHandler(this.BTN_SUPPRIMER_Click);
            // 
            // BTN_AJOUTER
            // 
            this.BTN_AJOUTER.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.BTN_AJOUTER.Location = new System.Drawing.Point(571, 54);
            this.BTN_AJOUTER.Name = "BTN_AJOUTER";
            this.BTN_AJOUTER.Size = new System.Drawing.Size(94, 45);
            this.BTN_AJOUTER.TabIndex = 69;
            this.BTN_AJOUTER.Text = "Ajouter";
            this.BTN_AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_AJOUTER.UseVisualStyleBackColor = true;
            this.BTN_AJOUTER.Click += new System.EventHandler(this.buttonENREGISTRER_Click);
            // 
            // client_to_liste
            // 
            this.client_to_liste.BackColor = System.Drawing.Color.Transparent;
            this.client_to_liste.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.demande_afficher_la_liste_icone_8709_321;
            this.client_to_liste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.client_to_liste.FlatAppearance.BorderSize = 0;
            this.client_to_liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_to_liste.Location = new System.Drawing.Point(5, 48);
            this.client_to_liste.Name = "client_to_liste";
            this.client_to_liste.Size = new System.Drawing.Size(51, 46);
            this.client_to_liste.TabIndex = 78;
            this.toolTip1.SetToolTip(this.client_to_liste, "Lister les articles");
            this.client_to_liste.UseVisualStyleBackColor = false;
            this.client_to_liste.Click += new System.EventHandler(this.client_to_liste_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_general);
            this.tabControl1.Location = new System.Drawing.Point(5, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 425);
            this.tabControl1.TabIndex = 79;
            // 
            // tp_general
            // 
            this.tp_general.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.tp_general.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tp_general.Controls.Add(this.groupBox2);
            this.tp_general.Controls.Add(this.groupBox1);
            this.tp_general.Location = new System.Drawing.Point(4, 22);
            this.tp_general.Name = "tp_general";
            this.tp_general.Padding = new System.Windows.Forms.Padding(3);
            this.tp_general.Size = new System.Drawing.Size(503, 399);
            this.tp_general.TabIndex = 0;
            this.tp_general.Text = "Général";
            this.tp_general.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.ETAT_ARTICLE);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.DESCRIPTION_ARTICLE);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.UNITE_QTE_M);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UNITE_QTE);
            this.groupBox2.Controls.Add(this.CTRL_CODE_BARRE_ARTICLE);
            this.groupBox2.Controls.Add(this.CODE_BARRE_ARTICLE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PRIX_HT_V_ARTICLE);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.TVA_ARTICLE);
            this.groupBox2.Controls.Add(this.QTE_MIN_ARTICLE);
            this.groupBox2.Controls.Add(this.PRIX_HT_A_ARTICLE);
            this.groupBox2.Controls.Add(this.QTE_ARTICLE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 264);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caractéristiques";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 41);
            this.button2.TabIndex = 108;
            this.button2.Text = "Imp. Code à barre solde";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DESCRIPTION_ARTICLE
            // 
            this.DESCRIPTION_ARTICLE.BackColor = System.Drawing.Color.White;
            this.DESCRIPTION_ARTICLE.Location = new System.Drawing.Point(90, 13);
            this.DESCRIPTION_ARTICLE.Multiline = true;
            this.DESCRIPTION_ARTICLE.Name = "DESCRIPTION_ARTICLE";
            this.DESCRIPTION_ARTICLE.ReadOnly = true;
            this.DESCRIPTION_ARTICLE.Size = new System.Drawing.Size(386, 39);
            this.DESCRIPTION_ARTICLE.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 41);
            this.button1.TabIndex = 108;
            this.button1.Text = "Imp. Code à barre ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UNITE_QTE_M
            // 
            this.UNITE_QTE_M.BackColor = System.Drawing.Color.White;
            this.UNITE_QTE_M.Location = new System.Drawing.Point(356, 176);
            this.UNITE_QTE_M.Name = "UNITE_QTE_M";
            this.UNITE_QTE_M.ReadOnly = true;
            this.UNITE_QTE_M.Size = new System.Drawing.Size(36, 20);
            this.UNITE_QTE_M.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Description :";
            // 
            // UNITE_QTE
            // 
            this.UNITE_QTE.BackColor = System.Drawing.Color.White;
            this.UNITE_QTE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UNITE_QTE.Location = new System.Drawing.Point(51, 176);
            this.UNITE_QTE.Name = "UNITE_QTE";
            this.UNITE_QTE.ReadOnly = true;
            this.UNITE_QTE.Size = new System.Drawing.Size(57, 20);
            this.UNITE_QTE.TabIndex = 106;
            // 
            // CTRL_CODE_BARRE_ARTICLE
            // 
            this.CTRL_CODE_BARRE_ARTICLE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CTRL_CODE_BARRE_ARTICLE.BarCode = "";
            this.CTRL_CODE_BARRE_ARTICLE.BarCodeHeight = 40;
            this.CTRL_CODE_BARRE_ARTICLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTRL_CODE_BARRE_ARTICLE.ChargerImage = true;
            this.CTRL_CODE_BARRE_ARTICLE.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CTRL_CODE_BARRE_ARTICLE.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CTRL_CODE_BARRE_ARTICLE.HeaderText = "BarCode Demo";
            this.CTRL_CODE_BARRE_ARTICLE.LeftMargin = 10;
            this.CTRL_CODE_BARRE_ARTICLE.Location = new System.Drawing.Point(16, 84);
            this.CTRL_CODE_BARRE_ARTICLE.Name = "CTRL_CODE_BARRE_ARTICLE";
            this.CTRL_CODE_BARRE_ARTICLE.ShowFooter = false;
            this.CTRL_CODE_BARRE_ARTICLE.ShowHeader = false;
            this.CTRL_CODE_BARRE_ARTICLE.Size = new System.Drawing.Size(229, 58);
            this.CTRL_CODE_BARRE_ARTICLE.TabIndex = 94;
            this.CTRL_CODE_BARRE_ARTICLE.TopMargin = 10;
            this.CTRL_CODE_BARRE_ARTICLE.VertAlign = BARRE_CODE.BarCodeCtrl.AlignType.Center;
            this.CTRL_CODE_BARRE_ARTICLE.Weight = BARRE_CODE.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // CODE_BARRE_ARTICLE
            // 
            this.CODE_BARRE_ARTICLE.BackColor = System.Drawing.Color.White;
            this.CODE_BARRE_ARTICLE.Location = new System.Drawing.Point(90, 58);
            this.CODE_BARRE_ARTICLE.Name = "CODE_BARRE_ARTICLE";
            this.CODE_BARRE_ARTICLE.ReadOnly = true;
            this.CODE_BARRE_ARTICLE.Size = new System.Drawing.Size(155, 20);
            this.CODE_BARRE_ARTICLE.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Code à Barre :";
            // 
            // PRIX_HT_V_ARTICLE
            // 
            this.PRIX_HT_V_ARTICLE.BackColor = System.Drawing.Color.White;
            this.PRIX_HT_V_ARTICLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRIX_HT_V_ARTICLE.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PRIX_HT_V_ARTICLE.Location = new System.Drawing.Point(345, 228);
            this.PRIX_HT_V_ARTICLE.Name = "PRIX_HT_V_ARTICLE";
            this.PRIX_HT_V_ARTICLE.ReadOnly = true;
            this.PRIX_HT_V_ARTICLE.Size = new System.Drawing.Size(127, 29);
            this.PRIX_HT_V_ARTICLE.TabIndex = 80;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(119, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 79;
            this.textBox1.Visible = false;
            // 
            // TVA_ARTICLE
            // 
            this.TVA_ARTICLE.BackColor = System.Drawing.Color.White;
            this.TVA_ARTICLE.Location = new System.Drawing.Point(356, 202);
            this.TVA_ARTICLE.Name = "TVA_ARTICLE";
            this.TVA_ARTICLE.ReadOnly = true;
            this.TVA_ARTICLE.Size = new System.Drawing.Size(114, 20);
            this.TVA_ARTICLE.TabIndex = 79;
            this.TVA_ARTICLE.Visible = false;
            // 
            // QTE_MIN_ARTICLE
            // 
            this.QTE_MIN_ARTICLE.BackColor = System.Drawing.Color.White;
            this.QTE_MIN_ARTICLE.Location = new System.Drawing.Point(393, 176);
            this.QTE_MIN_ARTICLE.Name = "QTE_MIN_ARTICLE";
            this.QTE_MIN_ARTICLE.ReadOnly = true;
            this.QTE_MIN_ARTICLE.Size = new System.Drawing.Size(78, 20);
            this.QTE_MIN_ARTICLE.TabIndex = 78;
            // 
            // PRIX_HT_A_ARTICLE
            // 
            this.PRIX_HT_A_ARTICLE.BackColor = System.Drawing.Color.White;
            this.PRIX_HT_A_ARTICLE.Location = new System.Drawing.Point(90, 202);
            this.PRIX_HT_A_ARTICLE.Name = "PRIX_HT_A_ARTICLE";
            this.PRIX_HT_A_ARTICLE.ReadOnly = true;
            this.PRIX_HT_A_ARTICLE.Size = new System.Drawing.Size(121, 20);
            this.PRIX_HT_A_ARTICLE.TabIndex = 77;
            // 
            // QTE_ARTICLE
            // 
            this.QTE_ARTICLE.BackColor = System.Drawing.Color.White;
            this.QTE_ARTICLE.Location = new System.Drawing.Point(111, 176);
            this.QTE_ARTICLE.Name = "QTE_ARTICLE";
            this.QTE_ARTICLE.ReadOnly = true;
            this.QTE_ARTICLE.Size = new System.Drawing.Size(59, 20);
            this.QTE_ARTICLE.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Qte min :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Taux de majoration :";
            this.label15.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Prix d\'achat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Tva :";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Prix de vente :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Qte :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.MARQUE_ARTICLE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DESIGNATION_ARTICLE);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.MAGASIN);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.CATEGORIE);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.FOURNISSEUR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.REF_ARTICLE);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 124);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Référencement";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(81, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 82;
            this.label18.Text = "Ligne :";
            // 
            // MARQUE_ARTICLE
            // 
            this.MARQUE_ARTICLE.BackColor = System.Drawing.Color.White;
            this.MARQUE_ARTICLE.Location = new System.Drawing.Point(81, 70);
            this.MARQUE_ARTICLE.Name = "MARQUE_ARTICLE";
            this.MARQUE_ARTICLE.ReadOnly = true;
            this.MARQUE_ARTICLE.Size = new System.Drawing.Size(189, 20);
            this.MARQUE_ARTICLE.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Marque :";
            // 
            // DESIGNATION_ARTICLE
            // 
            this.DESIGNATION_ARTICLE.BackColor = System.Drawing.Color.White;
            this.DESIGNATION_ARTICLE.Location = new System.Drawing.Point(81, 44);
            this.DESIGNATION_ARTICLE.Name = "DESIGNATION_ARTICLE";
            this.DESIGNATION_ARTICLE.ReadOnly = true;
            this.DESIGNATION_ARTICLE.Size = new System.Drawing.Size(189, 20);
            this.DESIGNATION_ARTICLE.TabIndex = 76;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(275, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 98;
            this.label23.Text = "Famille :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Catégorie :";
            // 
            // MAGASIN
            // 
            this.MAGASIN.BackColor = System.Drawing.Color.White;
            this.MAGASIN.Location = new System.Drawing.Point(345, 95);
            this.MAGASIN.Name = "MAGASIN";
            this.MAGASIN.ReadOnly = true;
            this.MAGASIN.Size = new System.Drawing.Size(131, 20);
            this.MAGASIN.TabIndex = 103;
            this.MAGASIN.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(345, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 101;
            // 
            // CATEGORIE
            // 
            this.CATEGORIE.BackColor = System.Drawing.Color.White;
            this.CATEGORIE.Location = new System.Drawing.Point(345, 44);
            this.CATEGORIE.Name = "CATEGORIE";
            this.CATEGORIE.ReadOnly = true;
            this.CATEGORIE.Size = new System.Drawing.Size(131, 20);
            this.CATEGORIE.TabIndex = 101;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "Magasin :";
            this.label13.Visible = false;
            // 
            // FOURNISSEUR
            // 
            this.FOURNISSEUR.BackColor = System.Drawing.Color.White;
            this.FOURNISSEUR.Location = new System.Drawing.Point(345, 69);
            this.FOURNISSEUR.Name = "FOURNISSEUR";
            this.FOURNISSEUR.ReadOnly = true;
            this.FOURNISSEUR.Size = new System.Drawing.Size(131, 20);
            this.FOURNISSEUR.TabIndex = 102;
            this.FOURNISSEUR.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Désignation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Référence :";
            // 
            // REF_ARTICLE
            // 
            this.REF_ARTICLE.BackColor = System.Drawing.Color.White;
            this.REF_ARTICLE.Location = new System.Drawing.Point(81, 19);
            this.REF_ARTICLE.Name = "REF_ARTICLE";
            this.REF_ARTICLE.ReadOnly = true;
            this.REF_ARTICLE.Size = new System.Drawing.Size(189, 20);
            this.REF_ARTICLE.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 100;
            this.label14.Text = "Fournisseur :";
            this.label14.Visible = false;
            // 
            // ETAT_ARTICLE
            // 
            this.ETAT_ARTICLE.AutoSize = true;
            this.ETAT_ARTICLE.Location = new System.Drawing.Point(411, 123);
            this.ETAT_ARTICLE.Name = "ETAT_ARTICLE";
            this.ETAT_ARTICLE.Size = new System.Drawing.Size(59, 17);
            this.ETAT_ARTICLE.TabIndex = 75;
            this.ETAT_ARTICLE.Text = "Bloqué";
            this.ETAT_ARTICLE.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btn_article_suivant);
            this.groupBox3.Controls.Add(this.btn_article_prec);
            this.groupBox3.Controls.Add(this.PHOTO_ARTICLE);
            this.groupBox3.Location = new System.Drawing.Point(520, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 405);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            // 
            // btn_article_suivant
            // 
            this.btn_article_suivant.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.forward;
            this.btn_article_suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_article_suivant.Location = new System.Drawing.Point(209, 297);
            this.btn_article_suivant.Name = "btn_article_suivant";
            this.btn_article_suivant.Size = new System.Drawing.Size(76, 64);
            this.btn_article_suivant.TabIndex = 75;
            this.btn_article_suivant.UseVisualStyleBackColor = true;
            this.btn_article_suivant.Click += new System.EventHandler(this.btn_article_suivant_Click);
            // 
            // btn_article_prec
            // 
            this.btn_article_prec.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.back;
            this.btn_article_prec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_article_prec.Location = new System.Drawing.Point(72, 297);
            this.btn_article_prec.Name = "btn_article_prec";
            this.btn_article_prec.Size = new System.Drawing.Size(76, 64);
            this.btn_article_prec.TabIndex = 74;
            this.btn_article_prec.UseVisualStyleBackColor = true;
            this.btn_article_prec.Click += new System.EventHandler(this.btn_article_prec_Click);
            // 
            // PHOTO_ARTICLE
            // 
            this.PHOTO_ARTICLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PHOTO_ARTICLE.InitialImage = global::CHM_CLIENT_APP.Properties.Resources.build;
            this.PHOTO_ARTICLE.Location = new System.Drawing.Point(17, 45);
            this.PHOTO_ARTICLE.Name = "PHOTO_ARTICLE";
            this.PHOTO_ARTICLE.Size = new System.Drawing.Size(315, 244);
            this.PHOTO_ARTICLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PHOTO_ARTICLE.TabIndex = 73;
            this.PHOTO_ARTICLE.TabStop = false;
            // 
            // ds_fiche_article
            // 
            this.ds_fiche_article.DataSetName = "NewDataSet";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(883, 48);
            this.entete_Formulaire_21.TabIndex = 81;
            // 
            // CHM_ARTICLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 528);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.client_to_liste);
            this.Controls.Add(this.BTN_MODIFIER);
            this.Controls.Add(this.BTN_SUPPRIMER);
            this.Controls.Add(this.BTN_AJOUTER);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_ARTICLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Article";
            this.Load += new System.EventHandler(this.CHM_ARTICLE_Load);
            this.Shown += new System.EventHandler(this.CHM_ARTICLE_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_ARTICLE_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tp_general.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_ARTICLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_fiche_article)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_MODIFIER;
        private System.Windows.Forms.Button BTN_SUPPRIMER;
        private System.Windows.Forms.Button BTN_AJOUTER;
        private System.Windows.Forms.Button client_to_liste;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_general;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UNITE_QTE_M;
        private System.Windows.Forms.TextBox UNITE_QTE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CATEGORIE;
        private System.Windows.Forms.TextBox MAGASIN;
        private System.Windows.Forms.TextBox FOURNISSEUR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private BARRE_CODE.BarCodeCtrl CTRL_CODE_BARRE_ARTICLE;
        private System.Windows.Forms.TextBox CODE_BARRE_ARTICLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PRIX_HT_V_ARTICLE;
        private System.Windows.Forms.TextBox TVA_ARTICLE;
        private System.Windows.Forms.TextBox QTE_MIN_ARTICLE;
        private System.Windows.Forms.TextBox PRIX_HT_A_ARTICLE;
        private System.Windows.Forms.TextBox QTE_ARTICLE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ETAT_ARTICLE;
        private System.Windows.Forms.TextBox DESCRIPTION_ARTICLE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MARQUE_ARTICLE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DESIGNATION_ARTICLE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox REF_ARTICLE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_article_suivant;
        private System.Windows.Forms.Button btn_article_prec;
        private System.Windows.Forms.PictureBox PHOTO_ARTICLE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataSet ds_fiche_article;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox3;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;

    }
}