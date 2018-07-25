namespace CHM_CLIENT_APP.EQUIPEMENTS
{
    partial class CHM_FRM_EQP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_EQP));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.pClient = new DevExpress.XtraEditors.GroupControl();
            this.txt_REF_CLIENT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PARCOURIR_LISTE_CLIENT = new System.Windows.Forms.Button();
            this.lbCodeTVAClient = new System.Windows.Forms.Label();
            this.lbAdresseClient = new System.Windows.Forms.Label();
            this.txt_RS_CLIENT = new System.Windows.Forms.Label();
            this.pEqp = new DevExpress.XtraEditors.GroupControl();
            this.lbCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFabriquant = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.dtpDateService = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFabrication = new System.Windows.Forms.DateTimePicker();
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            this.chM_CMP_FICHE1 = new CHM_STYLE.CHM_CMP_FICHE();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPlanifierMaintenance = new DevExpress.XtraEditors.SimpleButton();
            this.btnSupprimerMaintenance = new DevExpress.XtraEditors.SimpleButton();
            this.btnAjoutMaintenance = new DevExpress.XtraEditors.SimpleButton();
            this.dgvListMaintenance = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dgvListEntretien = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dS_MOUV1 = new CHM_CLIENT_APP.DS_MOUV();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pClient)).BeginInit();
            this.pClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEqp)).BeginInit();
            this.pEqp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEntretien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entete_Formulaire_21.BackgroundImage")));
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(599, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // pClient
            // 
            this.pClient.Controls.Add(this.txt_REF_CLIENT);
            this.pClient.Controls.Add(this.label15);
            this.pClient.Controls.Add(this.label14);
            this.pClient.Controls.Add(this.label1);
            this.pClient.Controls.Add(this.PARCOURIR_LISTE_CLIENT);
            this.pClient.Controls.Add(this.lbCodeTVAClient);
            this.pClient.Controls.Add(this.lbAdresseClient);
            this.pClient.Controls.Add(this.txt_RS_CLIENT);
            this.pClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pClient.Location = new System.Drawing.Point(0, 0);
            this.pClient.Name = "pClient";
            this.pClient.Size = new System.Drawing.Size(593, 103);
            this.pClient.TabIndex = 103;
            this.pClient.Text = "Détails Client";
            // 
            // txt_REF_CLIENT
            // 
            this.txt_REF_CLIENT.Location = new System.Drawing.Point(76, 27);
            this.txt_REF_CLIENT.Name = "txt_REF_CLIENT";
            this.txt_REF_CLIENT.Size = new System.Drawing.Size(56, 20);
            this.txt_REF_CLIENT.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(19, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Mle Fiscal :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(19, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Adresse :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Client :";
            // 
            // PARCOURIR_LISTE_CLIENT
            // 
            this.PARCOURIR_LISTE_CLIENT.AccessibleDescription = "dgsdfdsf";
            this.PARCOURIR_LISTE_CLIENT.Location = new System.Drawing.Point(339, 26);
            this.PARCOURIR_LISTE_CLIENT.Name = "PARCOURIR_LISTE_CLIENT";
            this.PARCOURIR_LISTE_CLIENT.Size = new System.Drawing.Size(31, 20);
            this.PARCOURIR_LISTE_CLIENT.TabIndex = 92;
            this.PARCOURIR_LISTE_CLIENT.Text = "...";
            this.PARCOURIR_LISTE_CLIENT.UseVisualStyleBackColor = true;
            this.PARCOURIR_LISTE_CLIENT.Click += new System.EventHandler(this.PARCOURIR_LISTE_CLIENT_Click);
            // 
            // lbCodeTVAClient
            // 
            this.lbCodeTVAClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCodeTVAClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCodeTVAClient.Location = new System.Drawing.Point(85, 75);
            this.lbCodeTVAClient.Name = "lbCodeTVAClient";
            this.lbCodeTVAClient.Size = new System.Drawing.Size(248, 20);
            this.lbCodeTVAClient.TabIndex = 83;
            this.lbCodeTVAClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAdresseClient
            // 
            this.lbAdresseClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdresseClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAdresseClient.Location = new System.Drawing.Point(76, 50);
            this.lbAdresseClient.Name = "lbAdresseClient";
            this.lbAdresseClient.Size = new System.Drawing.Size(257, 20);
            this.lbAdresseClient.TabIndex = 83;
            this.lbAdresseClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_RS_CLIENT
            // 
            this.txt_RS_CLIENT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RS_CLIENT.Location = new System.Drawing.Point(138, 27);
            this.txt_RS_CLIENT.Name = "txt_RS_CLIENT";
            this.txt_RS_CLIENT.Size = new System.Drawing.Size(195, 20);
            this.txt_RS_CLIENT.TabIndex = 83;
            this.txt_RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pEqp
            // 
            this.pEqp.Controls.Add(this.lbCode);
            this.pEqp.Controls.Add(this.label7);
            this.pEqp.Controls.Add(this.label6);
            this.pEqp.Controls.Add(this.label5);
            this.pEqp.Controls.Add(this.label3);
            this.pEqp.Controls.Add(this.label4);
            this.pEqp.Controls.Add(this.label2);
            this.pEqp.Controls.Add(this.txtFabriquant);
            this.pEqp.Controls.Add(this.txtSerie);
            this.pEqp.Controls.Add(this.txtLibelle);
            this.pEqp.Controls.Add(this.dtpDateService);
            this.pEqp.Controls.Add(this.dtpDateFabrication);
            this.pEqp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEqp.Location = new System.Drawing.Point(0, 103);
            this.pEqp.Name = "pEqp";
            this.pEqp.Size = new System.Drawing.Size(593, 243);
            this.pEqp.TabIndex = 104;
            this.pEqp.Text = "Détails Equipement";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(73, 36);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(31, 13);
            this.lbCode.TabIndex = 2;
            this.lbCode.Text = "code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date de mise en service :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date Fabriquation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fabriquant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° Série :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Libellé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code :";
            // 
            // txtFabriquant
            // 
            this.txtFabriquant.Location = new System.Drawing.Point(76, 81);
            this.txtFabriquant.Name = "txtFabriquant";
            this.txtFabriquant.Size = new System.Drawing.Size(231, 20);
            this.txtFabriquant.TabIndex = 1;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(296, 57);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(144, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(76, 57);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(144, 20);
            this.txtLibelle.TabIndex = 1;
            // 
            // dtpDateService
            // 
            this.dtpDateService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateService.Location = new System.Drawing.Point(144, 129);
            this.dtpDateService.Name = "dtpDateService";
            this.dtpDateService.Size = new System.Drawing.Size(114, 20);
            this.dtpDateService.TabIndex = 0;
            // 
            // dtpDateFabrication
            // 
            this.dtpDateFabrication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFabrication.Location = new System.Drawing.Point(144, 103);
            this.dtpDateFabrication.Name = "dtpDateFabrication";
            this.dtpDateFabrication.Size = new System.Drawing.Size(114, 20);
            this.dtpDateFabrication.TabIndex = 0;
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 475);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(599, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 105;
            // 
            // chM_CMP_FICHE1
            // 
            this.chM_CMP_FICHE1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_FICHE1.ButtonCaption = null;
            this.chM_CMP_FICHE1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_FICHE1.Location = new System.Drawing.Point(0, 420);
            this.chM_CMP_FICHE1.Name = "chM_CMP_FICHE1";
            this.chM_CMP_FICHE1.Size = new System.Drawing.Size(599, 55);
            this.chM_CMP_FICHE1.TabIndex = 106;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 48);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(599, 372);
            this.xtraTabControl1.TabIndex = 107;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pEqp);
            this.xtraTabPage1.Controls.Add(this.pClient);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(593, 346);
            this.xtraTabPage1.Text = "Général";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnPlanifierMaintenance);
            this.xtraTabPage2.Controls.Add(this.btnSupprimerMaintenance);
            this.xtraTabPage2.Controls.Add(this.btnAjoutMaintenance);
            this.xtraTabPage2.Controls.Add(this.dgvListMaintenance);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(593, 346);
            this.xtraTabPage2.Text = "Configuration Maintenance";
            // 
            // btnPlanifierMaintenance
            // 
            this.btnPlanifierMaintenance.Location = new System.Drawing.Point(230, 4);
            this.btnPlanifierMaintenance.Name = "btnPlanifierMaintenance";
            this.btnPlanifierMaintenance.Size = new System.Drawing.Size(106, 43);
            this.btnPlanifierMaintenance.TabIndex = 1;
            this.btnPlanifierMaintenance.Text = "Planifier";
            // 
            // btnSupprimerMaintenance
            // 
            this.btnSupprimerMaintenance.Location = new System.Drawing.Point(118, 4);
            this.btnSupprimerMaintenance.Name = "btnSupprimerMaintenance";
            this.btnSupprimerMaintenance.Size = new System.Drawing.Size(106, 43);
            this.btnSupprimerMaintenance.TabIndex = 1;
            this.btnSupprimerMaintenance.Text = "Supprimer";
            // 
            // btnAjoutMaintenance
            // 
            this.btnAjoutMaintenance.Location = new System.Drawing.Point(6, 4);
            this.btnAjoutMaintenance.Name = "btnAjoutMaintenance";
            this.btnAjoutMaintenance.Size = new System.Drawing.Size(106, 43);
            this.btnAjoutMaintenance.TabIndex = 1;
            this.btnAjoutMaintenance.Text = "Ajouter";
            // 
            // dgvListMaintenance
            // 
            this.dgvListMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListMaintenance.Location = new System.Drawing.Point(-1, 52);
            this.dgvListMaintenance.MainView = this.gridView1;
            this.dgvListMaintenance.Name = "dgvListMaintenance";
            this.dgvListMaintenance.Size = new System.Drawing.Size(594, 294);
            this.dgvListMaintenance.TabIndex = 0;
            this.dgvListMaintenance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvListMaintenance;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.dgvListEntretien);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(593, 346);
            this.xtraTabPage3.Text = "Suivi Maintenance";
            // 
            // dgvListEntretien
            // 
            this.dgvListEntretien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListEntretien.Location = new System.Drawing.Point(0, 0);
            this.dgvListEntretien.MainView = this.gridView2;
            this.dgvListEntretien.Name = "dgvListEntretien";
            this.dgvListEntretien.Size = new System.Drawing.Size(593, 346);
            this.dgvListEntretien.TabIndex = 0;
            this.dgvListEntretien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgvListEntretien;
            this.gridView2.Name = "gridView2";
            // 
            // dS_MOUV1
            // 
            this.dS_MOUV1.DataSetName = "DS_MOUV";
            this.dS_MOUV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CHM_FRM_EQP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 527);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.chM_CMP_FICHE1);
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_EQP";
            this.Text = "CHM_FRM_EQP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CHM_FRM_EQP_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pClient)).EndInit();
            this.pClient.ResumeLayout(false);
            this.pClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEqp)).EndInit();
            this.pEqp.ResumeLayout(false);
            this.pEqp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEntretien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_MOUV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private System.Windows.Forms.TextBox txt_REF_CLIENT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PARCOURIR_LISTE_CLIENT;
        private System.Windows.Forms.Label lbCodeTVAClient;
        private System.Windows.Forms.Label lbAdresseClient;
        private System.Windows.Forms.Label txt_RS_CLIENT;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.DateTimePicker dtpDateFabrication;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFabriquant;
        private System.Windows.Forms.DateTimePicker dtpDateService;
        public DevExpress.XtraEditors.GroupControl pEqp;
        public CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
        public CHM_STYLE.CHM_CMP_FICHE chM_CMP_FICHE1;
        public DevExpress.XtraEditors.GroupControl pClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private DS_MOUV dS_MOUV1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnAjoutMaintenance;
        private DevExpress.XtraGrid.GridControl dgvListMaintenance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPlanifierMaintenance;
        private DevExpress.XtraEditors.SimpleButton btnSupprimerMaintenance;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl dgvListEntretien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}