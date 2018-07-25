namespace CHM_CLIENT_APP.CHM_FACTURE
{
    partial class CHM_FACTURE_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FACTURE_POS));
            this.lbn_total_apres_remise = new LABEL_NUM.LabelNumerique();
            this.NP = new LABEL_NUM.LabelNumerique();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbn_total_remise = new LABEL_NUM.LabelNumerique();
            this.btn_Espece = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonAJOUTER = new System.Windows.Forms.Button();
            this.buttonSUPPRIMER = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.btn_credit = new System.Windows.Forms.Button();
            this.btn_qte_aug = new System.Windows.Forms.Button();
            this.btn_qte_dim = new System.Windows.Forms.Button();
            this.nud_qte = new System.Windows.Forms.NumericUpDown();
            this.btn_remise_aug = new System.Windows.Forms.Button();
            this.btn_remise_dim = new System.Windows.Forms.Button();
            this.nud_remise_prct = new System.Windows.Forms.NumericUpDown();
            this.nud_remise_ttc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CODE_BARRE_ARTICLE = new BARRE_CODE.BarCodeCtrl();
            this.txt_REF_CLIENT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PARCOURIR_LISTE_CLIENT = new System.Windows.Forms.Button();
            this.txt_RS_CLIENT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_remise_ttc_totale = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chM_PAVE_NUMERIQUE1 = new CHMComponents.CHM_PAVE_NUMERIQUE();
            this.p_maj_art = new DevExpress.XtraEditors.PanelControl();
            this.txt_remise_ttc_totale = new DevExpress.XtraEditors.TextEdit();
            this.txt_remise_ttc = new DevExpress.XtraEditors.TextEdit();
            this.txt_remise_prct = new DevExpress.XtraEditors.TextEdit();
            this.txt_qte = new DevExpress.XtraEditors.TextEdit();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESIGNATION_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNITE_QTE_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTVA_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_HT_ARTICLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TOTAL_HT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_U_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_TOTAL_TTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRIX_FACTURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAX_REMISE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTE_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_BARRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pFamille = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbSelectedFamille = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pCategorie = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbSelectedCateg = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pArticle = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dS_GC1 = new CHM_CLIENT_APP.DS_GC();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_remise_prct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_remise_ttc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_remise_ttc_totale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_maj_art)).BeginInit();
            this.p_maj_art.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_remise_ttc_totale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_remise_ttc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_remise_prct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbn_total_apres_remise
            // 
            this.lbn_total_apres_remise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbn_total_apres_remise.BackColor = System.Drawing.Color.Black;
            this.lbn_total_apres_remise.Clinote = true;
            this.lbn_total_apres_remise.Couleur1 = System.Drawing.Color.Lime;
            this.lbn_total_apres_remise.Couleur2 = System.Drawing.Color.Lime;
            this.lbn_total_apres_remise.DecimalPlaces = 3;
            this.lbn_total_apres_remise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbn_total_apres_remise.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_total_apres_remise.ForeColor = System.Drawing.Color.Lime;
            this.lbn_total_apres_remise.Location = new System.Drawing.Point(332, 26);
            this.lbn_total_apres_remise.Name = "lbn_total_apres_remise";
            this.lbn_total_apres_remise.Size = new System.Drawing.Size(236, 44);
            this.lbn_total_apres_remise.TabIndex = 92;
            this.lbn_total_apres_remise.Text = "0.000";
            this.lbn_total_apres_remise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbn_total_apres_remise.ThousandsSeparator = true;
            this.lbn_total_apres_remise.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NP
            // 
            this.NP.BackColor = System.Drawing.Color.Black;
            this.NP.Clinote = true;
            this.NP.Couleur1 = System.Drawing.Color.Lime;
            this.NP.Couleur2 = System.Drawing.Color.Lime;
            this.NP.DecimalPlaces = 3;
            this.NP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NP.ForeColor = System.Drawing.Color.Lime;
            this.NP.Location = new System.Drawing.Point(72, 8);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(189, 30);
            this.NP.TabIndex = 93;
            this.NP.Text = "0.000";
            this.NP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NP.ThousandsSeparator = true;
            this.NP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "Total remise :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(328, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 88;
            this.label10.Text = "Net à Payer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 90;
            this.label7.Text = "Total :";
            // 
            // lbn_total_remise
            // 
            this.lbn_total_remise.BackColor = System.Drawing.Color.Black;
            this.lbn_total_remise.Clinote = true;
            this.lbn_total_remise.Couleur1 = System.Drawing.Color.Lime;
            this.lbn_total_remise.Couleur2 = System.Drawing.Color.Lime;
            this.lbn_total_remise.DecimalPlaces = 3;
            this.lbn_total_remise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbn_total_remise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_total_remise.ForeColor = System.Drawing.Color.Lime;
            this.lbn_total_remise.Location = new System.Drawing.Point(132, 48);
            this.lbn_total_remise.Name = "lbn_total_remise";
            this.lbn_total_remise.Size = new System.Drawing.Size(129, 30);
            this.lbn_total_remise.TabIndex = 93;
            this.lbn_total_remise.Text = "0.000";
            this.lbn_total_remise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbn_total_remise.ThousandsSeparator = true;
            this.lbn_total_remise.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // btn_Espece
            // 
            this.btn_Espece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Espece.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Espece.Image = ((System.Drawing.Image)(resources.GetObject("btn_Espece.Image")));
            this.btn_Espece.Location = new System.Drawing.Point(820, 417);
            this.btn_Espece.Name = "btn_Espece";
            this.btn_Espece.Size = new System.Drawing.Size(174, 111);
            this.btn_Espece.TabIndex = 94;
            this.btn_Espece.Text = "Payer";
            this.btn_Espece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Espece.UseVisualStyleBackColor = true;
            this.btn_Espece.Click += new System.EventHandler(this.btn_Espece_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textBox2.Location = new System.Drawing.Point(160, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 96;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Image = global::CHM_CLIENT_APP.Properties.Resources.douchette;
            this.button4.Location = new System.Drawing.Point(10, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 94);
            this.button4.TabIndex = 95;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonAJOUTER
            // 
            this.buttonAJOUTER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAJOUTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAJOUTER.Image = ((System.Drawing.Image)(resources.GetObject("buttonAJOUTER.Image")));
            this.buttonAJOUTER.Location = new System.Drawing.Point(11, 65);
            this.buttonAJOUTER.Name = "buttonAJOUTER";
            this.buttonAJOUTER.Size = new System.Drawing.Size(133, 64);
            this.buttonAJOUTER.TabIndex = 98;
            this.buttonAJOUTER.Text = "Ajouter Article";
            this.buttonAJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAJOUTER.UseVisualStyleBackColor = true;
            this.buttonAJOUTER.Click += new System.EventHandler(this.buttonAJOUTER_Click);
            // 
            // buttonSUPPRIMER
            // 
            this.buttonSUPPRIMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSUPPRIMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSUPPRIMER.Image = ((System.Drawing.Image)(resources.GetObject("buttonSUPPRIMER.Image")));
            this.buttonSUPPRIMER.Location = new System.Drawing.Point(11, 133);
            this.buttonSUPPRIMER.Name = "buttonSUPPRIMER";
            this.buttonSUPPRIMER.Size = new System.Drawing.Size(133, 64);
            this.buttonSUPPRIMER.TabIndex = 97;
            this.buttonSUPPRIMER.Text = "Supprimer Article";
            this.buttonSUPPRIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSUPPRIMER.UseVisualStyleBackColor = true;
            this.buttonSUPPRIMER.Click += new System.EventHandler(this.buttonSUPPRIMER_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 26);
            this.textBox1.TabIndex = 96;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(160, 152);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(225, 45);
            this.button16.TabIndex = 99;
            this.button16.Text = "Recherche Code à barre";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(304, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 100;
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.application_excel_facture_feuille_calcul_icone_7666_32;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(1186, 48);
            this.entete_Formulaire_21.TabIndex = 101;
            // 
            // btn_credit
            // 
            this.btn_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_credit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credit.Image = ((System.Drawing.Image)(resources.GetObject("btn_credit.Image")));
            this.btn_credit.Location = new System.Drawing.Point(1000, 417);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.Size = new System.Drawing.Size(174, 111);
            this.btn_credit.TabIndex = 94;
            this.btn_credit.Text = "À Compte";
            this.btn_credit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_credit.UseVisualStyleBackColor = true;
            this.btn_credit.Visible = false;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // btn_qte_aug
            // 
            this.btn_qte_aug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_qte_aug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qte_aug.Location = new System.Drawing.Point(293, 74);
            this.btn_qte_aug.Name = "btn_qte_aug";
            this.btn_qte_aug.Size = new System.Drawing.Size(45, 44);
            this.btn_qte_aug.TabIndex = 0;
            this.btn_qte_aug.Text = "+";
            this.btn_qte_aug.UseVisualStyleBackColor = true;
            this.btn_qte_aug.Click += new System.EventHandler(this.btn_qte_aug_Click);
            // 
            // btn_qte_dim
            // 
            this.btn_qte_dim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_qte_dim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qte_dim.Location = new System.Drawing.Point(340, 74);
            this.btn_qte_dim.Name = "btn_qte_dim";
            this.btn_qte_dim.Size = new System.Drawing.Size(45, 44);
            this.btn_qte_dim.TabIndex = 0;
            this.btn_qte_dim.Text = "-";
            this.btn_qte_dim.UseVisualStyleBackColor = true;
            this.btn_qte_dim.Click += new System.EventHandler(this.button2_Click);
            // 
            // nud_qte
            // 
            this.nud_qte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_qte.DecimalPlaces = 2;
            this.nud_qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_qte.ForeColor = System.Drawing.Color.Black;
            this.nud_qte.Location = new System.Drawing.Point(185, 84);
            this.nud_qte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_qte.Name = "nud_qte";
            this.nud_qte.Size = new System.Drawing.Size(86, 22);
            this.nud_qte.TabIndex = 1;
            this.nud_qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_qte.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_qte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_qte.ValueChanged += new System.EventHandler(this.nud_qte_ValueChanged);
            this.nud_qte.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // btn_remise_aug
            // 
            this.btn_remise_aug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remise_aug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remise_aug.Location = new System.Drawing.Point(293, 16);
            this.btn_remise_aug.Name = "btn_remise_aug";
            this.btn_remise_aug.Size = new System.Drawing.Size(41, 38);
            this.btn_remise_aug.TabIndex = 0;
            this.btn_remise_aug.Text = "+";
            this.btn_remise_aug.UseVisualStyleBackColor = true;
            this.btn_remise_aug.Click += new System.EventHandler(this.btn_remise_aug_Click);
            // 
            // btn_remise_dim
            // 
            this.btn_remise_dim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remise_dim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remise_dim.Location = new System.Drawing.Point(344, 16);
            this.btn_remise_dim.Name = "btn_remise_dim";
            this.btn_remise_dim.Size = new System.Drawing.Size(41, 38);
            this.btn_remise_dim.TabIndex = 0;
            this.btn_remise_dim.Text = "-";
            this.btn_remise_dim.UseVisualStyleBackColor = true;
            this.btn_remise_dim.Click += new System.EventHandler(this.btn_remise_dim_Click);
            // 
            // nud_remise_prct
            // 
            this.nud_remise_prct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_remise_prct.DecimalPlaces = 2;
            this.nud_remise_prct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_remise_prct.ForeColor = System.Drawing.Color.Black;
            this.nud_remise_prct.Location = new System.Drawing.Point(187, 25);
            this.nud_remise_prct.Name = "nud_remise_prct";
            this.nud_remise_prct.Size = new System.Drawing.Size(84, 22);
            this.nud_remise_prct.TabIndex = 1;
            this.nud_remise_prct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_remise_prct.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_remise_prct.ValueChanged += new System.EventHandler(this.nud_remise_ValueChanged);
            this.nud_remise_prct.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // nud_remise_ttc
            // 
            this.nud_remise_ttc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_remise_ttc.BackColor = System.Drawing.Color.White;
            this.nud_remise_ttc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_remise_ttc.DecimalPlaces = 3;
            this.nud_remise_ttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_remise_ttc.Location = new System.Drawing.Point(101, 25);
            this.nud_remise_ttc.Name = "nud_remise_ttc";
            this.nud_remise_ttc.Size = new System.Drawing.Size(84, 22);
            this.nud_remise_ttc.TabIndex = 88;
            this.nud_remise_ttc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_remise_ttc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_remise_ttc.Visible = false;
            this.nud_remise_ttc.ValueChanged += new System.EventHandler(this.nud_total_remise_ValueChanged);
            this.nud_remise_ttc.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "%";
            // 
            // CODE_BARRE_ARTICLE
            // 
            this.CODE_BARRE_ARTICLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CODE_BARRE_ARTICLE.BarCode = "";
            this.CODE_BARRE_ARTICLE.BarCodeHeight = 40;
            this.CODE_BARRE_ARTICLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_BARRE_ARTICLE.ChargerImage = true;
            this.CODE_BARRE_ARTICLE.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CODE_BARRE_ARTICLE.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CODE_BARRE_ARTICLE.HeaderText = "BarCode Demo";
            this.CODE_BARRE_ARTICLE.LeftMargin = 10;
            this.CODE_BARRE_ARTICLE.Location = new System.Drawing.Point(160, 203);
            this.CODE_BARRE_ARTICLE.Name = "CODE_BARRE_ARTICLE";
            this.CODE_BARRE_ARTICLE.ShowFooter = false;
            this.CODE_BARRE_ARTICLE.ShowHeader = false;
            this.CODE_BARRE_ARTICLE.Size = new System.Drawing.Size(225, 94);
            this.CODE_BARRE_ARTICLE.TabIndex = 103;
            this.CODE_BARRE_ARTICLE.TopMargin = 10;
            this.CODE_BARRE_ARTICLE.VertAlign = BARRE_CODE.BarCodeCtrl.AlignType.Center;
            this.CODE_BARRE_ARTICLE.Weight = BARRE_CODE.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // txt_REF_CLIENT
            // 
            this.txt_REF_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_REF_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_REF_CLIENT.Location = new System.Drawing.Point(662, 52);
            this.txt_REF_CLIENT.Multiline = true;
            this.txt_REF_CLIENT.Name = "txt_REF_CLIENT";
            this.txt_REF_CLIENT.Size = new System.Drawing.Size(87, 43);
            this.txt_REF_CLIENT.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(591, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Client :";
            // 
            // PARCOURIR_LISTE_CLIENT
            // 
            this.PARCOURIR_LISTE_CLIENT.AccessibleDescription = "dgsdfdsf";
            this.PARCOURIR_LISTE_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARCOURIR_LISTE_CLIENT.Location = new System.Drawing.Point(1131, 52);
            this.PARCOURIR_LISTE_CLIENT.Name = "PARCOURIR_LISTE_CLIENT";
            this.PARCOURIR_LISTE_CLIENT.Size = new System.Drawing.Size(43, 42);
            this.PARCOURIR_LISTE_CLIENT.TabIndex = 107;
            this.PARCOURIR_LISTE_CLIENT.Text = "...";
            this.PARCOURIR_LISTE_CLIENT.UseVisualStyleBackColor = true;
            this.PARCOURIR_LISTE_CLIENT.Click += new System.EventHandler(this.PARCOURIR_LISTE_CLIENT_Click);
            // 
            // txt_RS_CLIENT
            // 
            this.txt_RS_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RS_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RS_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RS_CLIENT.Location = new System.Drawing.Point(755, 52);
            this.txt_RS_CLIENT.Name = "txt_RS_CLIENT";
            this.txt_RS_CLIENT.Size = new System.Drawing.Size(370, 43);
            this.txt_RS_CLIENT.TabIndex = 106;
            this.txt_RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(104, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "% U. TTC :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 105;
            this.label5.Text = "% Article TTC :";
            // 
            // nud_remise_ttc_totale
            // 
            this.nud_remise_ttc_totale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_remise_ttc_totale.BackColor = System.Drawing.Color.White;
            this.nud_remise_ttc_totale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_remise_ttc_totale.DecimalPlaces = 3;
            this.nud_remise_ttc_totale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_remise_ttc_totale.Location = new System.Drawing.Point(11, 24);
            this.nud_remise_ttc_totale.Name = "nud_remise_ttc_totale";
            this.nud_remise_ttc_totale.Size = new System.Drawing.Size(85, 22);
            this.nud_remise_ttc_totale.TabIndex = 88;
            this.nud_remise_ttc_totale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_remise_ttc_totale.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud_remise_ttc_totale.Visible = false;
            this.nud_remise_ttc_totale.ValueChanged += new System.EventHandler(this.nud_remise_ttc_totale_ValueChanged);
            this.nud_remise_ttc_totale.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(184, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Remise U. HT :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(184, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 105;
            this.label8.Text = "Quantité :";
            // 
            // chM_PAVE_NUMERIQUE1
            // 
            this.chM_PAVE_NUMERIQUE1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chM_PAVE_NUMERIQUE1.Location = new System.Drawing.Point(392, 5);
            this.chM_PAVE_NUMERIQUE1.MinimumSize = new System.Drawing.Size(178, 240);
            this.chM_PAVE_NUMERIQUE1.Name = "chM_PAVE_NUMERIQUE1";
            this.chM_PAVE_NUMERIQUE1.Size = new System.Drawing.Size(178, 294);
            this.chM_PAVE_NUMERIQUE1.TabIndex = 108;
            // 
            // p_maj_art
            // 
            this.p_maj_art.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p_maj_art.Controls.Add(this.textBox2);
            this.p_maj_art.Controls.Add(this.txt_remise_ttc_totale);
            this.p_maj_art.Controls.Add(this.txt_remise_ttc);
            this.p_maj_art.Controls.Add(this.txt_remise_prct);
            this.p_maj_art.Controls.Add(this.txt_qte);
            this.p_maj_art.Controls.Add(this.chM_PAVE_NUMERIQUE1);
            this.p_maj_art.Controls.Add(this.btn_qte_dim);
            this.p_maj_art.Controls.Add(this.buttonAJOUTER);
            this.p_maj_art.Controls.Add(this.buttonSUPPRIMER);
            this.p_maj_art.Controls.Add(this.btn_qte_aug);
            this.p_maj_art.Controls.Add(this.nud_qte);
            this.p_maj_art.Controls.Add(this.label8);
            this.p_maj_art.Controls.Add(this.label5);
            this.p_maj_art.Controls.Add(this.nud_remise_ttc_totale);
            this.p_maj_art.Controls.Add(this.textBox1);
            this.p_maj_art.Controls.Add(this.btn_remise_dim);
            this.p_maj_art.Controls.Add(this.button16);
            this.p_maj_art.Controls.Add(this.label6);
            this.p_maj_art.Controls.Add(this.label4);
            this.p_maj_art.Controls.Add(this.button4);
            this.p_maj_art.Controls.Add(this.CODE_BARRE_ARTICLE);
            this.p_maj_art.Controls.Add(this.btn_remise_aug);
            this.p_maj_art.Controls.Add(this.nud_remise_ttc);
            this.p_maj_art.Controls.Add(this.label2);
            this.p_maj_art.Controls.Add(this.nud_remise_prct);
            this.p_maj_art.Location = new System.Drawing.Point(595, 103);
            this.p_maj_art.Name = "p_maj_art";
            this.p_maj_art.Size = new System.Drawing.Size(579, 305);
            this.p_maj_art.TabIndex = 109;
            // 
            // txt_remise_ttc_totale
            // 
            this.txt_remise_ttc_totale.EditValue = "0.00";
            this.txt_remise_ttc_totale.Location = new System.Drawing.Point(11, 25);
            this.txt_remise_ttc_totale.Name = "txt_remise_ttc_totale";
            this.txt_remise_ttc_totale.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_remise_ttc_totale.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remise_ttc_totale.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_remise_ttc_totale.Properties.Appearance.Options.UseBackColor = true;
            this.txt_remise_ttc_totale.Properties.Appearance.Options.UseFont = true;
            this.txt_remise_ttc_totale.Properties.Appearance.Options.UseForeColor = true;
            this.txt_remise_ttc_totale.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_remise_ttc_totale.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_remise_ttc_totale.Properties.DisplayFormat.FormatString = "N3";
            this.txt_remise_ttc_totale.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_remise_ttc_totale.Properties.Mask.EditMask = "######0.000";
            this.txt_remise_ttc_totale.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_remise_ttc_totale.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_remise_ttc_totale.Properties.ValidateOnEnterKey = true;
            this.txt_remise_ttc_totale.Size = new System.Drawing.Size(84, 22);
            this.txt_remise_ttc_totale.TabIndex = 109;
            this.txt_remise_ttc_totale.EditValueChanged += new System.EventHandler(this.txt_remise_ttc_totale_EditValueChanged);
            this.txt_remise_ttc_totale.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // txt_remise_ttc
            // 
            this.txt_remise_ttc.EditValue = "0.00";
            this.txt_remise_ttc.Location = new System.Drawing.Point(101, 26);
            this.txt_remise_ttc.Name = "txt_remise_ttc";
            this.txt_remise_ttc.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_remise_ttc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remise_ttc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_remise_ttc.Properties.Appearance.Options.UseBackColor = true;
            this.txt_remise_ttc.Properties.Appearance.Options.UseFont = true;
            this.txt_remise_ttc.Properties.Appearance.Options.UseForeColor = true;
            this.txt_remise_ttc.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_remise_ttc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_remise_ttc.Properties.DisplayFormat.FormatString = "N3";
            this.txt_remise_ttc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_remise_ttc.Properties.Mask.EditMask = "######0.000";
            this.txt_remise_ttc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_remise_ttc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_remise_ttc.Properties.ValidateOnEnterKey = true;
            this.txt_remise_ttc.Size = new System.Drawing.Size(84, 22);
            this.txt_remise_ttc.TabIndex = 109;
            this.txt_remise_ttc.EditValueChanged += new System.EventHandler(this.txt_remise_ttc_EditValueChanged);
            this.txt_remise_ttc.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // txt_remise_prct
            // 
            this.txt_remise_prct.EditValue = "0.00";
            this.txt_remise_prct.Location = new System.Drawing.Point(187, 26);
            this.txt_remise_prct.Name = "txt_remise_prct";
            this.txt_remise_prct.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_remise_prct.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remise_prct.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_remise_prct.Properties.Appearance.Options.UseBackColor = true;
            this.txt_remise_prct.Properties.Appearance.Options.UseFont = true;
            this.txt_remise_prct.Properties.Appearance.Options.UseForeColor = true;
            this.txt_remise_prct.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_remise_prct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_remise_prct.Properties.DisplayFormat.FormatString = "N3";
            this.txt_remise_prct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_remise_prct.Properties.Mask.EditMask = "######0.00";
            this.txt_remise_prct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_remise_prct.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_remise_prct.Properties.ValidateOnEnterKey = true;
            this.txt_remise_prct.Size = new System.Drawing.Size(84, 22);
            this.txt_remise_prct.TabIndex = 109;
            this.txt_remise_prct.EditValueChanged += new System.EventHandler(this.txt_remise_prct_EditValueChanged);
            this.txt_remise_prct.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // txt_qte
            // 
            this.txt_qte.EditValue = "0.00";
            this.txt_qte.Location = new System.Drawing.Point(185, 85);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_qte.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_qte.Properties.Appearance.Options.UseBackColor = true;
            this.txt_qte.Properties.Appearance.Options.UseFont = true;
            this.txt_qte.Properties.Appearance.Options.UseForeColor = true;
            this.txt_qte.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_qte.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_qte.Properties.DisplayFormat.FormatString = "N3";
            this.txt_qte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_qte.Properties.Mask.EditMask = "######0.000";
            this.txt_qte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_qte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_qte.Properties.ValidateOnEnterKey = true;
            this.txt_qte.Size = new System.Drawing.Size(86, 22);
            this.txt_qte.TabIndex = 109;
            this.txt_qte.EditValueChanged += new System.EventHandler(this.txt_qte_EditValueChanged);
            this.txt_qte.Click += new System.EventHandler(this.txt_MntRecu_Click);
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "DETAIL_TICKET_POS";
            this.gridControl1.DataSource = this.dS_MOUV1;
            this.gridControl1.Location = new System.Drawing.Point(12, 142);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(577, 267);
            this.gridControl1.TabIndex = 110;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODE_ARTICLE,
            this.colREF_ARTICLE,
            this.colDESIGNATION_ARTICLE,
            this.colQTE,
            this.colUNITE_QTE_ARTICLE,
            this.colTVA_ARTICLE,
            this.colPRIX_HT_ARTICLE,
            this.colPRIX_TOTAL_HT,
            this.colREMISE,
            this.colPRIX_U_TTC,
            this.colPRIX_TOTAL_TTC,
            this.colPRIX_FACTURE,
            this.colMAX_REMISE,
            this.colQTE_STOCK,
            this.colCODE_BARRE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.RowHeight = 30;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colCODE_ARTICLE
            // 
            this.colCODE_ARTICLE.FieldName = "CODE_ARTICLE";
            this.colCODE_ARTICLE.Name = "colCODE_ARTICLE";
            this.colCODE_ARTICLE.Width = 61;
            // 
            // colREF_ARTICLE
            // 
            this.colREF_ARTICLE.FieldName = "REF_ARTICLE";
            this.colREF_ARTICLE.Name = "colREF_ARTICLE";
            // 
            // colDESIGNATION_ARTICLE
            // 
            this.colDESIGNATION_ARTICLE.FieldName = "DESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Name = "colDESIGNATION_ARTICLE";
            this.colDESIGNATION_ARTICLE.Visible = true;
            this.colDESIGNATION_ARTICLE.VisibleIndex = 1;
            this.colDESIGNATION_ARTICLE.Width = 668;
            // 
            // colQTE
            // 
            this.colQTE.FieldName = "QTE";
            this.colQTE.Name = "colQTE";
            this.colQTE.Visible = true;
            this.colQTE.VisibleIndex = 2;
            this.colQTE.Width = 93;
            // 
            // colUNITE_QTE_ARTICLE
            // 
            this.colUNITE_QTE_ARTICLE.FieldName = "UNITE_QTE_ARTICLE";
            this.colUNITE_QTE_ARTICLE.Name = "colUNITE_QTE_ARTICLE";
            this.colUNITE_QTE_ARTICLE.Visible = true;
            this.colUNITE_QTE_ARTICLE.VisibleIndex = 3;
            this.colUNITE_QTE_ARTICLE.Width = 95;
            // 
            // colTVA_ARTICLE
            // 
            this.colTVA_ARTICLE.FieldName = "TVA_ARTICLE";
            this.colTVA_ARTICLE.Name = "colTVA_ARTICLE";
            // 
            // colPRIX_HT_ARTICLE
            // 
            this.colPRIX_HT_ARTICLE.DisplayFormat.FormatString = "{0:n3}";
            this.colPRIX_HT_ARTICLE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPRIX_HT_ARTICLE.FieldName = "PRIX_HT_ARTICLE";
            this.colPRIX_HT_ARTICLE.Name = "colPRIX_HT_ARTICLE";
            // 
            // colPRIX_TOTAL_HT
            // 
            this.colPRIX_TOTAL_HT.DisplayFormat.FormatString = "{0:n3}";
            this.colPRIX_TOTAL_HT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPRIX_TOTAL_HT.FieldName = "PRIX_TOTAL_HT";
            this.colPRIX_TOTAL_HT.Name = "colPRIX_TOTAL_HT";
            // 
            // colREMISE
            // 
            this.colREMISE.FieldName = "REMISE";
            this.colREMISE.Name = "colREMISE";
            this.colREMISE.Visible = true;
            this.colREMISE.VisibleIndex = 4;
            this.colREMISE.Width = 83;
            // 
            // colPRIX_U_TTC
            // 
            this.colPRIX_U_TTC.DisplayFormat.FormatString = "{0:n3}";
            this.colPRIX_U_TTC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPRIX_U_TTC.FieldName = "PRIX_U_TTC";
            this.colPRIX_U_TTC.Name = "colPRIX_U_TTC";
            this.colPRIX_U_TTC.Visible = true;
            this.colPRIX_U_TTC.VisibleIndex = 5;
            this.colPRIX_U_TTC.Width = 202;
            // 
            // colPRIX_TOTAL_TTC
            // 
            this.colPRIX_TOTAL_TTC.DisplayFormat.FormatString = "{0:n3}";
            this.colPRIX_TOTAL_TTC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPRIX_TOTAL_TTC.FieldName = "PRIX_TOTAL_TTC";
            this.colPRIX_TOTAL_TTC.Name = "colPRIX_TOTAL_TTC";
            this.colPRIX_TOTAL_TTC.Visible = true;
            this.colPRIX_TOTAL_TTC.VisibleIndex = 6;
            this.colPRIX_TOTAL_TTC.Width = 248;
            // 
            // colPRIX_FACTURE
            // 
            this.colPRIX_FACTURE.DisplayFormat.FormatString = "{0:n3}";
            this.colPRIX_FACTURE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPRIX_FACTURE.FieldName = "PRIX_FACTURE";
            this.colPRIX_FACTURE.Name = "colPRIX_FACTURE";
            // 
            // colMAX_REMISE
            // 
            this.colMAX_REMISE.FieldName = "MAX_REMISE";
            this.colMAX_REMISE.Name = "colMAX_REMISE";
            // 
            // colQTE_STOCK
            // 
            this.colQTE_STOCK.FieldName = "QTE_STOCK";
            this.colQTE_STOCK.Name = "colQTE_STOCK";
            // 
            // colCODE_BARRE
            // 
            this.colCODE_BARRE.Caption = "Code";
            this.colCODE_BARRE.FieldName = "CODE_BARRE";
            this.colCODE_BARRE.Name = "colCODE_BARRE";
            this.colCODE_BARRE.Visible = true;
            this.colCODE_BARRE.VisibleIndex = 0;
            this.colCODE_BARRE.Width = 284;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbn_total_apres_remise);
            this.panel1.Controls.Add(this.lbn_total_remise);
            this.panel1.Controls.Add(this.NP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 87);
            this.panel1.TabIndex = 111;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 415);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.AutoScroll = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pArticle);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl5);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(576, 297);
            this.splitContainerControl1.SplitterPosition = 362;
            this.splitContainerControl1.TabIndex = 112;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.pFamille);
            this.splitContainerControl2.Panel1.Controls.Add(this.panelControl3);
            this.splitContainerControl2.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.pCategorie);
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl4);
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(362, 297);
            this.splitContainerControl2.SplitterPosition = 181;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // pFamille
            // 
            this.pFamille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFamille.Location = new System.Drawing.Point(0, 43);
            this.pFamille.Name = "pFamille";
            this.pFamille.Size = new System.Drawing.Size(145, 254);
            this.pFamille.TabIndex = 2;
            this.pFamille.SizeChanged += new System.EventHandler(this.pFamille_SizeChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.button5);
            this.panelControl3.Controls.Add(this.button3);
            this.panelControl3.Controls.Add(this.button2);
            this.panelControl3.Controls.Add(this.button1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(145, 43);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(36, 254);
            this.panelControl3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Image = global::CHM_CLIENT_APP.Properties.Resources.DoubleDown;
            this.button5.Location = new System.Drawing.Point(0, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 36);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button3
            // 
            this.button3.Image = global::CHM_CLIENT_APP.Properties.Resources.Down;
            this.button3.Location = new System.Drawing.Point(0, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 36);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::CHM_CLIENT_APP.Properties.Resources.Up;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.DoubleUp;
            this.button1.Location = new System.Drawing.Point(0, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbSelectedFamille);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(181, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // lbSelectedFamille
            // 
            this.lbSelectedFamille.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbSelectedFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedFamille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbSelectedFamille.Location = new System.Drawing.Point(2, 15);
            this.lbSelectedFamille.Name = "lbSelectedFamille";
            this.lbSelectedFamille.Size = new System.Drawing.Size(177, 26);
            this.lbSelectedFamille.TabIndex = 0;
            this.lbSelectedFamille.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Famille :";
            // 
            // pCategorie
            // 
            this.pCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCategorie.Location = new System.Drawing.Point(0, 43);
            this.pCategorie.Name = "pCategorie";
            this.pCategorie.Size = new System.Drawing.Size(140, 254);
            this.pCategorie.TabIndex = 3;
            this.pCategorie.SizeChanged += new System.EventHandler(this.pCategorie_SizeChanged);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.button6);
            this.panelControl4.Controls.Add(this.button7);
            this.panelControl4.Controls.Add(this.button8);
            this.panelControl4.Controls.Add(this.button9);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(140, 43);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(36, 254);
            this.panelControl4.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Image = global::CHM_CLIENT_APP.Properties.Resources.DoubleDown;
            this.button6.Location = new System.Drawing.Point(-1, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 36);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Image = global::CHM_CLIENT_APP.Properties.Resources.Down;
            this.button7.Location = new System.Drawing.Point(-1, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 36);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Image = global::CHM_CLIENT_APP.Properties.Resources.Up;
            this.button8.Location = new System.Drawing.Point(-1, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 36);
            this.button8.TabIndex = 5;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Image = global::CHM_CLIENT_APP.Properties.Resources.DoubleUp;
            this.button9.Location = new System.Drawing.Point(-1, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 36);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbSelectedCateg);
            this.panelControl2.Controls.Add(this.label11);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(176, 43);
            this.panelControl2.TabIndex = 0;
            // 
            // lbSelectedCateg
            // 
            this.lbSelectedCateg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbSelectedCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedCateg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbSelectedCateg.Location = new System.Drawing.Point(2, 15);
            this.lbSelectedCateg.Name = "lbSelectedCateg";
            this.lbSelectedCateg.Size = new System.Drawing.Size(172, 26);
            this.lbSelectedCateg.TabIndex = 0;
            this.lbSelectedCateg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Catégorie :";
            // 
            // pArticle
            // 
            this.pArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pArticle.Location = new System.Drawing.Point(0, 0);
            this.pArticle.Name = "pArticle";
            this.pArticle.Size = new System.Drawing.Size(173, 297);
            this.pArticle.TabIndex = 0;
            this.pArticle.SizeChanged += new System.EventHandler(this.pArticle_SizeChanged);
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.button10);
            this.panelControl5.Controls.Add(this.button11);
            this.panelControl5.Controls.Add(this.button12);
            this.panelControl5.Controls.Add(this.button13);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl5.Location = new System.Drawing.Point(173, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(36, 297);
            this.panelControl5.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Image = global::CHM_CLIENT_APP.Properties.Resources.DoubleDown;
            this.button10.Location = new System.Drawing.Point(0, 252);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 36);
            this.button10.TabIndex = 7;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Image = global::CHM_CLIENT_APP.Properties.Resources.Down;
            this.button11.Location = new System.Drawing.Point(0, 182);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 36);
            this.button11.TabIndex = 6;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Image = global::CHM_CLIENT_APP.Properties.Resources.Up;
            this.button12.Location = new System.Drawing.Point(0, 133);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 36);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Image = global::CHM_CLIENT_APP.Properties.Resources.DoubleUp;
            this.button13.Location = new System.Drawing.Point(0, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 36);
            this.button13.TabIndex = 4;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dS_GC1
            // 
            this.dS_GC1.DataSetName = "DS_GC";
            this.dS_GC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHM_FACTURE_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 724);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.p_maj_art);
            this.Controls.Add(this.txt_REF_CLIENT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PARCOURIR_LISTE_CLIENT);
            this.Controls.Add(this.txt_RS_CLIENT);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_credit);
            this.Controls.Add(this.btn_Espece);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_FACTURE_POS";
            this.Text = "Nouvelle Facture";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FACTURE_POS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_remise_prct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_remise_ttc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_remise_ttc_totale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_maj_art)).EndInit();
            this.p_maj_art.ResumeLayout(false);
            this.p_maj_art.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_remise_ttc_totale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_remise_ttc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_remise_prct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_GC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LABEL_NUM.LabelNumerique lbn_total_apres_remise;
        private LABEL_NUM.LabelNumerique NP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private LABEL_NUM.LabelNumerique lbn_total_remise;
        private System.Windows.Forms.Button btn_Espece;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonAJOUTER;
        private System.Windows.Forms.Button buttonSUPPRIMER;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox textBox3;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private System.Windows.Forms.Button btn_credit;
        private System.Windows.Forms.NumericUpDown nud_qte;
        private System.Windows.Forms.Button btn_qte_dim;
        private System.Windows.Forms.Button btn_qte_aug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_remise_ttc;
        private System.Windows.Forms.NumericUpDown nud_remise_prct;
        private System.Windows.Forms.Button btn_remise_dim;
        private System.Windows.Forms.Button btn_remise_aug;
        private DS_MOUV dS_MOUV1;
        private BARRE_CODE.BarCodeCtrl CODE_BARRE_ARTICLE;
        private System.Windows.Forms.TextBox txt_REF_CLIENT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PARCOURIR_LISTE_CLIENT;
        private System.Windows.Forms.Label txt_RS_CLIENT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_remise_ttc_totale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private CHMComponents.CHM_PAVE_NUMERIQUE chM_PAVE_NUMERIQUE1;
        private DevExpress.XtraEditors.PanelControl p_maj_art;
        private DevExpress.XtraEditors.TextEdit txt_qte;
        private DevExpress.XtraEditors.TextEdit txt_remise_ttc;
        private DevExpress.XtraEditors.TextEdit txt_remise_prct;
        private DevExpress.XtraEditors.TextEdit txt_remise_ttc_totale;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESIGNATION_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNITE_QTE_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colTVA_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_HT_ARTICLE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TOTAL_HT;
        private DevExpress.XtraGrid.Columns.GridColumn colREMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_U_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_TOTAL_TTC;
        private DevExpress.XtraGrid.Columns.GridColumn colPRIX_FACTURE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAX_REMISE;
        private DevExpress.XtraGrid.Columns.GridColumn colQTE_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_BARRE;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DS_GC dS_GC1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl pArticle;
        private DevExpress.XtraEditors.XtraScrollableControl pFamille;
        private DevExpress.XtraEditors.XtraScrollableControl pCategorie;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbSelectedFamille;
        private System.Windows.Forms.Label lbSelectedCateg;
    }
}