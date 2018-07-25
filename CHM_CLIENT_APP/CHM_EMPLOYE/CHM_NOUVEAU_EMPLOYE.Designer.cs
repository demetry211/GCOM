namespace CHM_CLIENT_APP
{
    partial class CHM_NOUVEAU_EMPLOYE
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
            this.NV_SOCIETE = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NV_PRENOM_EMPLOYE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_FERMER = new System.Windows.Forms.Button();
            this.BTN_ENREGISTRER = new System.Windows.Forms.Button();
            this.NV_ADRESSE_EMPLOYE = new System.Windows.Forms.TextBox();
            this.NV_NOM_EMPLOYE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nom_fenetre = new System.Windows.Forms.Label();
            this.NV_TEL_EMPLOYE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NV_DATE_EMBAUCHE_EMPLOYE = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.NV_EMAIL_EMPLOYE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NV_ETAT_EMPLOYE = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NV_DATE_NAISS_EMPLOYE = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NV_SOCIETE
            // 
            this.NV_SOCIETE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NV_SOCIETE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NV_SOCIETE.Location = new System.Drawing.Point(167, 325);
            this.NV_SOCIETE.Name = "NV_SOCIETE";
            this.NV_SOCIETE.Size = new System.Drawing.Size(250, 21);
            this.NV_SOCIETE.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(62, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Société :";
            // 
            // NV_PRENOM_EMPLOYE
            // 
            this.NV_PRENOM_EMPLOYE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NV_PRENOM_EMPLOYE.Location = new System.Drawing.Point(167, 134);
            this.NV_PRENOM_EMPLOYE.Name = "NV_PRENOM_EMPLOYE";
            this.NV_PRENOM_EMPLOYE.Size = new System.Drawing.Size(159, 20);
            this.NV_PRENOM_EMPLOYE.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(62, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Prenom :";
            // 
            // BTN_FERMER
            // 
            this.BTN_FERMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_FERMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.BTN_FERMER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FERMER.Location = new System.Drawing.Point(344, 411);
            this.BTN_FERMER.Name = "BTN_FERMER";
            this.BTN_FERMER.Size = new System.Drawing.Size(113, 43);
            this.BTN_FERMER.TabIndex = 44;
            this.BTN_FERMER.Text = "&Fermer";
            this.BTN_FERMER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_FERMER.UseVisualStyleBackColor = true;
            this.BTN_FERMER.Click += new System.EventHandler(this.BTN_FERMER_Click);
            // 
            // BTN_ENREGISTRER
            // 
            this.BTN_ENREGISTRER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ENREGISTRER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ENREGISTRER.Image = global::CHM_CLIENT_APP.Properties.Resources.document_enregistrez_icone_7256_32;
            this.BTN_ENREGISTRER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ENREGISTRER.Location = new System.Drawing.Point(220, 411);
            this.BTN_ENREGISTRER.Name = "BTN_ENREGISTRER";
            this.BTN_ENREGISTRER.Size = new System.Drawing.Size(118, 43);
            this.BTN_ENREGISTRER.TabIndex = 43;
            this.BTN_ENREGISTRER.Text = "&Enregistrer";
            this.BTN_ENREGISTRER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ENREGISTRER.UseVisualStyleBackColor = true;
            this.BTN_ENREGISTRER.Click += new System.EventHandler(this.BTN_ENREGISTRER_Click);
            // 
            // NV_ADRESSE_EMPLOYE
            // 
            this.NV_ADRESSE_EMPLOYE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NV_ADRESSE_EMPLOYE.Location = new System.Drawing.Point(167, 184);
            this.NV_ADRESSE_EMPLOYE.Multiline = true;
            this.NV_ADRESSE_EMPLOYE.Name = "NV_ADRESSE_EMPLOYE";
            this.NV_ADRESSE_EMPLOYE.Size = new System.Drawing.Size(250, 54);
            this.NV_ADRESSE_EMPLOYE.TabIndex = 41;
            this.NV_ADRESSE_EMPLOYE.UseSystemPasswordChar = true;
            // 
            // NV_NOM_EMPLOYE
            // 
            this.NV_NOM_EMPLOYE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NV_NOM_EMPLOYE.Location = new System.Drawing.Point(167, 110);
            this.NV_NOM_EMPLOYE.Name = "NV_NOM_EMPLOYE";
            this.NV_NOM_EMPLOYE.Size = new System.Drawing.Size(159, 20);
            this.NV_NOM_EMPLOYE.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(62, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(62, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Date de naissance :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(62, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.nom_fenetre);
            this.groupBox1.Location = new System.Drawing.Point(-2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 67);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.ajouter_forum_deux_utilisateurs_icone_4495_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 45);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // nom_fenetre
            // 
            this.nom_fenetre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_fenetre.BackColor = System.Drawing.Color.Transparent;
            this.nom_fenetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_fenetre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nom_fenetre.Location = new System.Drawing.Point(68, 17);
            this.nom_fenetre.Name = "nom_fenetre";
            this.nom_fenetre.Size = new System.Drawing.Size(394, 42);
            this.nom_fenetre.TabIndex = 0;
            this.nom_fenetre.Text = "Nouveau magasinier";
            this.nom_fenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NV_TEL_EMPLOYE
            // 
            this.NV_TEL_EMPLOYE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NV_TEL_EMPLOYE.Location = new System.Drawing.Point(167, 244);
            this.NV_TEL_EMPLOYE.Name = "NV_TEL_EMPLOYE";
            this.NV_TEL_EMPLOYE.Size = new System.Drawing.Size(250, 20);
            this.NV_TEL_EMPLOYE.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(62, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Tel :";
            // 
            // NV_DATE_EMBAUCHE_EMPLOYE
            // 
            this.NV_DATE_EMBAUCHE_EMPLOYE.Location = new System.Drawing.Point(167, 299);
            this.NV_DATE_EMBAUCHE_EMPLOYE.Name = "NV_DATE_EMBAUCHE_EMPLOYE";
            this.NV_DATE_EMBAUCHE_EMPLOYE.Size = new System.Drawing.Size(250, 20);
            this.NV_DATE_EMBAUCHE_EMPLOYE.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(62, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Date d\'embauche :";
            // 
            // NV_EMAIL_EMPLOYE
            // 
            this.NV_EMAIL_EMPLOYE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NV_EMAIL_EMPLOYE.Location = new System.Drawing.Point(167, 270);
            this.NV_EMAIL_EMPLOYE.Name = "NV_EMAIL_EMPLOYE";
            this.NV_EMAIL_EMPLOYE.Size = new System.Drawing.Size(250, 20);
            this.NV_EMAIL_EMPLOYE.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(62, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "E-mail :";
            // 
            // NV_ETAT_EMPLOYE
            // 
            this.NV_ETAT_EMPLOYE.AutoSize = true;
            this.NV_ETAT_EMPLOYE.BackColor = System.Drawing.Color.Transparent;
            this.NV_ETAT_EMPLOYE.Location = new System.Drawing.Point(355, 124);
            this.NV_ETAT_EMPLOYE.Name = "NV_ETAT_EMPLOYE";
            this.NV_ETAT_EMPLOYE.Size = new System.Drawing.Size(68, 17);
            this.NV_ETAT_EMPLOYE.TabIndex = 77;
            this.NV_ETAT_EMPLOYE.Text = "Bloqué ?";
            this.NV_ETAT_EMPLOYE.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NV_DATE_NAISS_EMPLOYE
            // 
            this.NV_DATE_NAISS_EMPLOYE.Location = new System.Drawing.Point(167, 159);
            this.NV_DATE_NAISS_EMPLOYE.Name = "NV_DATE_NAISS_EMPLOYE";
            this.NV_DATE_NAISS_EMPLOYE.Size = new System.Drawing.Size(158, 20);
            this.NV_DATE_NAISS_EMPLOYE.TabIndex = 78;
            // 
            // CHM_NOUVEAU_EMPLOYE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 475);
            this.ControlBox = false;
            this.Controls.Add(this.NV_DATE_NAISS_EMPLOYE);
            this.Controls.Add(this.NV_ETAT_EMPLOYE);
            this.Controls.Add(this.NV_EMAIL_EMPLOYE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NV_DATE_EMBAUCHE_EMPLOYE);
            this.Controls.Add(this.NV_TEL_EMPLOYE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NV_SOCIETE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NV_PRENOM_EMPLOYE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_FERMER);
            this.Controls.Add(this.BTN_ENREGISTRER);
            this.Controls.Add(this.NV_ADRESSE_EMPLOYE);
            this.Controls.Add(this.NV_NOM_EMPLOYE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CHM_NOUVEAU_EMPLOYE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel employé";
            this.Shown += new System.EventHandler(this.CHM_NOUVEAU_EMPLOYE_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NV_SOCIETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NV_PRENOM_EMPLOYE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_FERMER;
        private System.Windows.Forms.Button BTN_ENREGISTRER;
        private System.Windows.Forms.TextBox NV_ADRESSE_EMPLOYE;
        private System.Windows.Forms.TextBox NV_NOM_EMPLOYE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nom_fenetre;
        private System.Windows.Forms.TextBox NV_TEL_EMPLOYE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NV_DATE_EMBAUCHE_EMPLOYE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NV_EMAIL_EMPLOYE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox NV_ETAT_EMPLOYE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker NV_DATE_NAISS_EMPLOYE;
    }
}