namespace CHM_CLIENT_APP
{
    partial class CHM_NV_UTILISATEUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_NV_UTILISATEUR));
            this.BTN_FERMER = new System.Windows.Forms.Button();
            this.BTN_ENREGISTRER = new System.Windows.Forms.Button();
            this.NV_FONCTION_USER = new System.Windows.Forms.ComboBox();
            this.NV_PASSWORD_USER = new System.Windows.Forms.TextBox();
            this.NV_LOGIN_USER = new System.Windows.Forms.TextBox();
            this.NV_NOM_USER = new System.Windows.Forms.TextBox();
            this.NV_PHOTO_USER = new System.Windows.Forms.PictureBox();
            this.ofd_PHOTO_USER = new System.Windows.Forms.OpenFileDialog();
            this.NV_PRENOM_USER = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NV_SOCIETE = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nom_fenetre = new System.Windows.Forms.Label();
            this.NV_ETAT_USER = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NV_PHOTO_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_FERMER
            // 
            this.BTN_FERMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.BTN_FERMER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FERMER.Location = new System.Drawing.Point(405, 295);
            this.BTN_FERMER.Name = "BTN_FERMER";
            this.BTN_FERMER.Size = new System.Drawing.Size(108, 45);
            this.BTN_FERMER.TabIndex = 8;
            this.BTN_FERMER.Text = "Annuler";
            this.BTN_FERMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_FERMER.UseVisualStyleBackColor = true;
            this.BTN_FERMER.Click += new System.EventHandler(this.BTN_FERMER_Click);
            // 
            // BTN_ENREGISTRER
            // 
            this.BTN_ENREGISTRER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ENREGISTRER.Image = global::CHM_CLIENT_APP.Properties.Resources.document_enregistrez_icone_7256_32;
            this.BTN_ENREGISTRER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ENREGISTRER.Location = new System.Drawing.Point(290, 295);
            this.BTN_ENREGISTRER.Name = "BTN_ENREGISTRER";
            this.BTN_ENREGISTRER.Size = new System.Drawing.Size(111, 45);
            this.BTN_ENREGISTRER.TabIndex = 7;
            this.BTN_ENREGISTRER.Text = "Enregistrer";
            this.BTN_ENREGISTRER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_ENREGISTRER.UseVisualStyleBackColor = true;
            this.BTN_ENREGISTRER.Click += new System.EventHandler(this.BTN_ENREGISTRER_Click);
            // 
            // NV_FONCTION_USER
            // 
            this.NV_FONCTION_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NV_FONCTION_USER.Location = new System.Drawing.Point(308, 214);
            this.NV_FONCTION_USER.Name = "NV_FONCTION_USER";
            this.NV_FONCTION_USER.Size = new System.Drawing.Size(154, 21);
            this.NV_FONCTION_USER.TabIndex = 5;
            // 
            // NV_PASSWORD_USER
            // 
            this.NV_PASSWORD_USER.Location = new System.Drawing.Point(308, 188);
            this.NV_PASSWORD_USER.Name = "NV_PASSWORD_USER";
            this.NV_PASSWORD_USER.Size = new System.Drawing.Size(181, 20);
            this.NV_PASSWORD_USER.TabIndex = 4;
            this.NV_PASSWORD_USER.UseSystemPasswordChar = true;
            // 
            // NV_LOGIN_USER
            // 
            this.NV_LOGIN_USER.Location = new System.Drawing.Point(308, 162);
            this.NV_LOGIN_USER.Name = "NV_LOGIN_USER";
            this.NV_LOGIN_USER.Size = new System.Drawing.Size(181, 20);
            this.NV_LOGIN_USER.TabIndex = 3;
            // 
            // NV_NOM_USER
            // 
            this.NV_NOM_USER.Location = new System.Drawing.Point(308, 112);
            this.NV_NOM_USER.Name = "NV_NOM_USER";
            this.NV_NOM_USER.Size = new System.Drawing.Size(181, 20);
            this.NV_NOM_USER.TabIndex = 1;
            // 
            // NV_PHOTO_USER
            // 
            this.NV_PHOTO_USER.BackColor = System.Drawing.Color.Transparent;
            this.NV_PHOTO_USER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NV_PHOTO_USER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NV_PHOTO_USER.InitialImage = global::CHM_CLIENT_APP.Properties.Resources.utilisateur_icone_9647_96;
            this.NV_PHOTO_USER.Location = new System.Drawing.Point(21, 106);
            this.NV_PHOTO_USER.Name = "NV_PHOTO_USER";
            this.NV_PHOTO_USER.Size = new System.Drawing.Size(162, 156);
            this.NV_PHOTO_USER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NV_PHOTO_USER.TabIndex = 33;
            this.NV_PHOTO_USER.TabStop = false;
            this.NV_PHOTO_USER.Click += new System.EventHandler(this.NV_PHOTO_USER_Click);
            // 
            // ofd_PHOTO_USER
            // 
            this.ofd_PHOTO_USER.FileName = "openFileDialog1";
            // 
            // NV_PRENOM_USER
            // 
            this.NV_PRENOM_USER.Location = new System.Drawing.Point(308, 136);
            this.NV_PRENOM_USER.Name = "NV_PRENOM_USER";
            this.NV_PRENOM_USER.Size = new System.Drawing.Size(181, 20);
            this.NV_PRENOM_USER.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NV_SOCIETE
            // 
            this.NV_SOCIETE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NV_SOCIETE.Location = new System.Drawing.Point(308, 241);
            this.NV_SOCIETE.Name = "NV_SOCIETE";
            this.NV_SOCIETE.Size = new System.Drawing.Size(181, 21);
            this.NV_SOCIETE.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.nom_fenetre);
            this.groupBox1.Location = new System.Drawing.Point(-2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 76);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.ajouter_forum_deux_utilisateurs_icone_4495_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 55);
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
            this.nom_fenetre.Location = new System.Drawing.Point(108, 21);
            this.nom_fenetre.Name = "nom_fenetre";
            this.nom_fenetre.Size = new System.Drawing.Size(368, 42);
            this.nom_fenetre.TabIndex = 0;
            this.nom_fenetre.Text = "Nouvel Utilisateur";
            this.nom_fenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NV_ETAT_USER
            // 
            this.NV_ETAT_USER.AutoSize = true;
            this.NV_ETAT_USER.BackColor = System.Drawing.Color.Transparent;
            this.NV_ETAT_USER.Location = new System.Drawing.Point(65, 286);
            this.NV_ETAT_USER.Name = "NV_ETAT_USER";
            this.NV_ETAT_USER.Size = new System.Drawing.Size(59, 17);
            this.NV_ETAT_USER.TabIndex = 12;
            this.NV_ETAT_USER.Text = "Bloqué";
            this.NV_ETAT_USER.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(218, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Société :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(218, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(218, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Fonction :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(218, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Mot de passse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(218, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Non d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(218, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nom :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHM_NV_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 357);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NV_SOCIETE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NV_PRENOM_USER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NV_PHOTO_USER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_FERMER);
            this.Controls.Add(this.BTN_ENREGISTRER);
            this.Controls.Add(this.NV_ETAT_USER);
            this.Controls.Add(this.NV_FONCTION_USER);
            this.Controls.Add(this.NV_PASSWORD_USER);
            this.Controls.Add(this.NV_LOGIN_USER);
            this.Controls.Add(this.NV_NOM_USER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_NV_UTILISATEUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel Utilisateur";
            this.Shown += new System.EventHandler(this.CHM_NV_UTILISATEUR_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.NV_PHOTO_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_FERMER;
        private System.Windows.Forms.Button BTN_ENREGISTRER;
        private System.Windows.Forms.ComboBox NV_FONCTION_USER;
        private System.Windows.Forms.TextBox NV_PASSWORD_USER;
        private System.Windows.Forms.TextBox NV_LOGIN_USER;
        private System.Windows.Forms.TextBox NV_NOM_USER;
        private System.Windows.Forms.PictureBox NV_PHOTO_USER;
        private System.Windows.Forms.OpenFileDialog ofd_PHOTO_USER;
        private System.Windows.Forms.TextBox NV_PRENOM_USER;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox NV_SOCIETE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nom_fenetre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox NV_ETAT_USER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}