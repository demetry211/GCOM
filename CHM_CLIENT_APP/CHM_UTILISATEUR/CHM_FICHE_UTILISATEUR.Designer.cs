namespace CHM_CLIENT_APP
{
    partial class CHM_FICHE_UTILISATEUR
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
            this.PRENOM_USER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFERMER = new System.Windows.Forms.Button();
            this.buttonENREGISTRER = new System.Windows.Forms.Button();
            this.ETAT_USER = new System.Windows.Forms.CheckBox();
            this.PASSWORD_USER = new System.Windows.Forms.TextBox();
            this.LOGIN_USER = new System.Windows.Forms.TextBox();
            this.NOM_USER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PHOTO_USER = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_PRECEDENT = new System.Windows.Forms.Button();
            this.BTN_SUIVANT = new System.Windows.Forms.Button();
            this.CODE_SOCIETE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FONCTION_USER = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nom_fenetre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_USER)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PRENOM_USER
            // 
            this.PRENOM_USER.BackColor = System.Drawing.Color.White;
            this.PRENOM_USER.Location = new System.Drawing.Point(332, 49);
            this.PRENOM_USER.Name = "PRENOM_USER";
            this.PRENOM_USER.ReadOnly = true;
            this.PRENOM_USER.Size = new System.Drawing.Size(181, 20);
            this.PRENOM_USER.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(245, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Prénom :";
            // 
            // buttonFERMER
            // 
            this.buttonFERMER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFERMER.BackColor = System.Drawing.Color.Transparent;
            this.buttonFERMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.buttonFERMER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFERMER.Location = new System.Drawing.Point(440, 86);
            this.buttonFERMER.Name = "buttonFERMER";
            this.buttonFERMER.Size = new System.Drawing.Size(99, 43);
            this.buttonFERMER.TabIndex = 46;
            this.buttonFERMER.Text = "Supprimer";
            this.buttonFERMER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFERMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFERMER.UseVisualStyleBackColor = false;
            this.buttonFERMER.Click += new System.EventHandler(this.buttonFERMER_Click);
            // 
            // buttonENREGISTRER
            // 
            this.buttonENREGISTRER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonENREGISTRER.BackColor = System.Drawing.Color.Transparent;
            this.buttonENREGISTRER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENREGISTRER.Image = global::CHM_CLIENT_APP.Properties.Resources.arrow_tourner_vers_la_droite_icone_8357_32;
            this.buttonENREGISTRER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonENREGISTRER.Location = new System.Drawing.Point(335, 86);
            this.buttonENREGISTRER.Name = "buttonENREGISTRER";
            this.buttonENREGISTRER.Size = new System.Drawing.Size(99, 43);
            this.buttonENREGISTRER.TabIndex = 45;
            this.buttonENREGISTRER.Text = "Modifier";
            this.buttonENREGISTRER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonENREGISTRER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonENREGISTRER.UseVisualStyleBackColor = false;
            this.buttonENREGISTRER.Click += new System.EventHandler(this.buttonENREGISTRER_Click);
            // 
            // ETAT_USER
            // 
            this.ETAT_USER.AutoSize = true;
            this.ETAT_USER.BackColor = System.Drawing.Color.Transparent;
            this.ETAT_USER.Location = new System.Drawing.Point(55, 178);
            this.ETAT_USER.Name = "ETAT_USER";
            this.ETAT_USER.Size = new System.Drawing.Size(65, 17);
            this.ETAT_USER.TabIndex = 44;
            this.ETAT_USER.Text = "Bloqué?";
            this.ETAT_USER.UseVisualStyleBackColor = false;
            // 
            // PASSWORD_USER
            // 
            this.PASSWORD_USER.BackColor = System.Drawing.Color.White;
            this.PASSWORD_USER.Location = new System.Drawing.Point(332, 101);
            this.PASSWORD_USER.Name = "PASSWORD_USER";
            this.PASSWORD_USER.ReadOnly = true;
            this.PASSWORD_USER.Size = new System.Drawing.Size(181, 20);
            this.PASSWORD_USER.TabIndex = 42;
            this.PASSWORD_USER.UseSystemPasswordChar = true;
            // 
            // LOGIN_USER
            // 
            this.LOGIN_USER.BackColor = System.Drawing.Color.White;
            this.LOGIN_USER.Location = new System.Drawing.Point(332, 75);
            this.LOGIN_USER.Name = "LOGIN_USER";
            this.LOGIN_USER.ReadOnly = true;
            this.LOGIN_USER.Size = new System.Drawing.Size(181, 20);
            this.LOGIN_USER.TabIndex = 41;
            // 
            // NOM_USER
            // 
            this.NOM_USER.BackColor = System.Drawing.Color.White;
            this.NOM_USER.Location = new System.Drawing.Point(332, 25);
            this.NOM_USER.Name = "NOM_USER";
            this.NOM_USER.ReadOnly = true;
            this.NOM_USER.Size = new System.Drawing.Size(181, 20);
            this.NOM_USER.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(245, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fonction :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(245, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mot de passse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(245, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Non d\'utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(245, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nom :";
            // 
            // PHOTO_USER
            // 
            this.PHOTO_USER.BackColor = System.Drawing.Color.Transparent;
            this.PHOTO_USER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PHOTO_USER.Image = global::CHM_CLIENT_APP.Properties.Resources.utilisateur_icone_9647_96;
            this.PHOTO_USER.InitialImage = global::CHM_CLIENT_APP.Properties.Resources.utilisateur_icone_9647_96;
            this.PHOTO_USER.Location = new System.Drawing.Point(12, 16);
            this.PHOTO_USER.Name = "PHOTO_USER";
            this.PHOTO_USER.Size = new System.Drawing.Size(162, 156);
            this.PHOTO_USER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PHOTO_USER.TabIndex = 47;
            this.PHOTO_USER.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(230, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 45;
            this.button1.Text = "Ajouter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_PRECEDENT
            // 
            this.BTN_PRECEDENT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_PRECEDENT.BackColor = System.Drawing.Color.Transparent;
            this.BTN_PRECEDENT.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.back;
            this.BTN_PRECEDENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_PRECEDENT.FlatAppearance.BorderSize = 0;
            this.BTN_PRECEDENT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BTN_PRECEDENT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_PRECEDENT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_PRECEDENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRECEDENT.Location = new System.Drawing.Point(192, 360);
            this.BTN_PRECEDENT.Name = "BTN_PRECEDENT";
            this.BTN_PRECEDENT.Size = new System.Drawing.Size(47, 44);
            this.BTN_PRECEDENT.TabIndex = 50;
            this.BTN_PRECEDENT.UseVisualStyleBackColor = false;
            this.BTN_PRECEDENT.Click += new System.EventHandler(this.BTN_PRECEDENT_Click);
            // 
            // BTN_SUIVANT
            // 
            this.BTN_SUIVANT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_SUIVANT.BackColor = System.Drawing.Color.Transparent;
            this.BTN_SUIVANT.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.forward;
            this.BTN_SUIVANT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_SUIVANT.FlatAppearance.BorderSize = 0;
            this.BTN_SUIVANT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BTN_SUIVANT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_SUIVANT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_SUIVANT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SUIVANT.Location = new System.Drawing.Point(307, 360);
            this.BTN_SUIVANT.Name = "BTN_SUIVANT";
            this.BTN_SUIVANT.Size = new System.Drawing.Size(47, 44);
            this.BTN_SUIVANT.TabIndex = 50;
            this.BTN_SUIVANT.UseVisualStyleBackColor = false;
            this.BTN_SUIVANT.Click += new System.EventHandler(this.BTN_SUIVANT_Click);
            // 
            // CODE_SOCIETE
            // 
            this.CODE_SOCIETE.BackColor = System.Drawing.Color.White;
            this.CODE_SOCIETE.Location = new System.Drawing.Point(332, 156);
            this.CODE_SOCIETE.Name = "CODE_SOCIETE";
            this.CODE_SOCIETE.ReadOnly = true;
            this.CODE_SOCIETE.Size = new System.Drawing.Size(181, 20);
            this.CODE_SOCIETE.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(245, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Société :";
            // 
            // FONCTION_USER
            // 
            this.FONCTION_USER.BackColor = System.Drawing.Color.White;
            this.FONCTION_USER.Location = new System.Drawing.Point(332, 130);
            this.FONCTION_USER.Name = "FONCTION_USER";
            this.FONCTION_USER.ReadOnly = true;
            this.FONCTION_USER.Size = new System.Drawing.Size(181, 20);
            this.FONCTION_USER.TabIndex = 53;
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
            this.groupBox1.Location = new System.Drawing.Point(-3, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 89);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.Utilisateurs1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 69);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // nom_fenetre
            // 
            this.nom_fenetre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_fenetre.BackColor = System.Drawing.Color.Transparent;
            this.nom_fenetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_fenetre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nom_fenetre.Location = new System.Drawing.Point(93, 18);
            this.nom_fenetre.Name = "nom_fenetre";
            this.nom_fenetre.Size = new System.Drawing.Size(453, 65);
            this.nom_fenetre.TabIndex = 0;
            this.nom_fenetre.Text = "Fiche Utilisateur";
            this.nom_fenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.FONCTION_USER);
            this.groupBox2.Controls.Add(this.CODE_SOCIETE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PRENOM_USER);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PHOTO_USER);
            this.groupBox2.Controls.Add(this.ETAT_USER);
            this.groupBox2.Controls.Add(this.PASSWORD_USER);
            this.groupBox2.Controls.Add(this.LOGIN_USER);
            this.groupBox2.Controls.Add(this.NOM_USER);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 216);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            // 
            // CHM_FICHE_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_SUIVANT);
            this.Controls.Add(this.BTN_PRECEDENT);
            this.Controls.Add(this.buttonFERMER);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonENREGISTRER);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_FICHE_UTILISATEUR";
            this.Text = "Fiche Utilisateur";
            this.Shown += new System.EventHandler(this.CHM_FICHE_UTILISATEUR_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_USER)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PRENOM_USER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PHOTO_USER;
        private System.Windows.Forms.Button buttonFERMER;
        private System.Windows.Forms.Button buttonENREGISTRER;
        private System.Windows.Forms.CheckBox ETAT_USER;
        private System.Windows.Forms.TextBox PASSWORD_USER;
        private System.Windows.Forms.TextBox LOGIN_USER;
        private System.Windows.Forms.TextBox NOM_USER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_PRECEDENT;
        private System.Windows.Forms.Button BTN_SUIVANT;
        private System.Windows.Forms.TextBox CODE_SOCIETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FONCTION_USER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nom_fenetre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}