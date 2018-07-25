namespace CHM_CLIENT_APP
{
    partial class CHM_REGLEMENT_CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_REGLEMENT_CLIENT));
            this.NP = new LABEL_NUM.LabelNumerique();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CODE_FACTURE = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RS_CLIENT = new System.Windows.Forms.Label();
            this.NUM_COMPTE_CLIENT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MODE_REG = new System.Windows.Forms.ComboBox();
            this.NUM_PIECE = new System.Windows.Forms.TextBox();
            this.BANQUE_CLIENT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OBSERVATION = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MONTANT_PAYE = new DevExpress.XtraEditors.TextEdit();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONTANT_PAYE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NP
            // 
            this.NP.BackColor = System.Drawing.Color.Transparent;
            this.NP.Clinote = true;
            this.NP.Couleur1 = System.Drawing.Color.Gray;
            this.NP.Couleur2 = System.Drawing.Color.OrangeRed;
            this.NP.DecimalPlaces = 3;
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NP.ForeColor = System.Drawing.Color.Gray;
            this.NP.Location = new System.Drawing.Point(521, 94);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(150, 24);
            this.NP.TabIndex = 6;
            this.NP.Text = "0.000";
            this.NP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NP.ThousandsSeparator = true;
            this.NP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Net à payer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Montant Reçu :";
            // 
            // CODE_FACTURE
            // 
            this.CODE_FACTURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CODE_FACTURE.BackColor = System.Drawing.Color.White;
            this.CODE_FACTURE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CODE_FACTURE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_FACTURE.ForeColor = System.Drawing.Color.DimGray;
            this.CODE_FACTURE.Location = new System.Drawing.Point(99, 90);
            this.CODE_FACTURE.Name = "CODE_FACTURE";
            this.CODE_FACTURE.Size = new System.Drawing.Size(163, 20);
            this.CODE_FACTURE.TabIndex = 31;
            this.CODE_FACTURE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CODE_FACTURE.Click += new System.EventHandler(this.CODE_FACTURE_Click);
            this.CODE_FACTURE.Leave += new System.EventHandler(this.CODE_FACTURE_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.daffaires_monnaies_dolar_metal_argent_paiement_icone_3854_481;
            this.button1.Location = new System.Drawing.Point(443, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Payer";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RS_CLIENT.BackColor = System.Drawing.Color.White;
            this.RS_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RS_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS_CLIENT.ForeColor = System.Drawing.Color.DimGray;
            this.RS_CLIENT.Location = new System.Drawing.Point(100, 30);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.Size = new System.Drawing.Size(162, 20);
            this.RS_CLIENT.TabIndex = 32;
            this.RS_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RS_CLIENT.Click += new System.EventHandler(this.RS_CLIENT_Click);
            // 
            // NUM_COMPTE_CLIENT
            // 
            this.NUM_COMPTE_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUM_COMPTE_CLIENT.BackColor = System.Drawing.Color.White;
            this.NUM_COMPTE_CLIENT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NUM_COMPTE_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_COMPTE_CLIENT.ForeColor = System.Drawing.Color.DimGray;
            this.NUM_COMPTE_CLIENT.Location = new System.Drawing.Point(100, 60);
            this.NUM_COMPTE_CLIENT.Name = "NUM_COMPTE_CLIENT";
            this.NUM_COMPTE_CLIENT.Size = new System.Drawing.Size(162, 20);
            this.NUM_COMPTE_CLIENT.TabIndex = 33;
            this.NUM_COMPTE_CLIENT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NUM_COMPTE_CLIENT.Click += new System.EventHandler(this.NUM_COMPTE_CLIENT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "N° Facture :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Client :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "N° Compte :";
            // 
            // MODE_REG
            // 
            this.MODE_REG.FormattingEnabled = true;
            this.MODE_REG.Items.AddRange(new object[] {
            "Espèce",
            "Chèque",
            "Carte bancaire"});
            this.MODE_REG.Location = new System.Drawing.Point(111, 33);
            this.MODE_REG.Name = "MODE_REG";
            this.MODE_REG.Size = new System.Drawing.Size(163, 21);
            this.MODE_REG.TabIndex = 37;
            this.MODE_REG.SelectedIndexChanged += new System.EventHandler(this.MODE_REG_SelectedIndexChanged);
            // 
            // NUM_PIECE
            // 
            this.NUM_PIECE.Location = new System.Drawing.Point(111, 67);
            this.NUM_PIECE.Name = "NUM_PIECE";
            this.NUM_PIECE.Size = new System.Drawing.Size(162, 20);
            this.NUM_PIECE.TabIndex = 38;
            // 
            // BANQUE_CLIENT
            // 
            this.BANQUE_CLIENT.Location = new System.Drawing.Point(111, 100);
            this.BANQUE_CLIENT.Name = "BANQUE_CLIENT";
            this.BANQUE_CLIENT.Size = new System.Drawing.Size(162, 20);
            this.BANQUE_CLIENT.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Regulation mode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sheet n. :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(17, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Bank :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CODE_FACTURE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RS_CLIENT);
            this.groupBox1.Controls.Add(this.NUM_COMPTE_CLIENT);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 129);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DATE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BANQUE_CLIENT);
            this.groupBox2.Controls.Add(this.NUM_PIECE);
            this.groupBox2.Controls.Add(this.MODE_REG);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(14, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 162);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type de règlement :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(17, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Date :";
            // 
            // DATE
            // 
            this.DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE.Location = new System.Drawing.Point(111, 126);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(162, 20);
            this.DATE.TabIndex = 49;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OBSERVATION
            // 
            this.OBSERVATION.BackColor = System.Drawing.Color.White;
            this.OBSERVATION.Location = new System.Drawing.Point(353, 313);
            this.OBSERVATION.Multiline = true;
            this.OBSERVATION.Name = "OBSERVATION";
            this.OBSERVATION.ReadOnly = true;
            this.OBSERVATION.Size = new System.Drawing.Size(301, 50);
            this.OBSERVATION.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(350, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Observations :";
            // 
            // MONTANT_PAYE
            // 
            this.MONTANT_PAYE.EditValue = "0.000";
            this.MONTANT_PAYE.Location = new System.Drawing.Point(521, 149);
            this.MONTANT_PAYE.Name = "MONTANT_PAYE";
            this.MONTANT_PAYE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MONTANT_PAYE.Properties.Appearance.Options.UseFont = true;
            this.MONTANT_PAYE.Properties.Appearance.Options.UseTextOptions = true;
            this.MONTANT_PAYE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MONTANT_PAYE.Properties.DisplayFormat.FormatString = "N3";
            this.MONTANT_PAYE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MONTANT_PAYE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MONTANT_PAYE.Size = new System.Drawing.Size(150, 26);
            this.MONTANT_PAYE.TabIndex = 52;
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.daffaires_monnaies_dolar_metal_argent_paiement_icone_3854_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(696, 48);
            this.entete_Formulaire_21.TabIndex = 53;
            // 
            // CHM_REGLEMENT_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 378);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.MONTANT_PAYE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OBSERVATION);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CHM_REGLEMENT_CLIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Règlement";
            this.Shown += new System.EventHandler(this.CHM_REGLEMENT_CLIENT_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MONTANT_PAYE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LABEL_NUM.LabelNumerique NP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CODE_FACTURE;
        private System.Windows.Forms.Label RS_CLIENT;
        private System.Windows.Forms.Label NUM_COMPTE_CLIENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MODE_REG;
        private System.Windows.Forms.TextBox NUM_PIECE;
        private System.Windows.Forms.TextBox BANQUE_CLIENT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DATE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OBSERVATION;
        private DevExpress.XtraEditors.TextEdit MONTANT_PAYE;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}