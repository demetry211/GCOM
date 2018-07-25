namespace CHM_CLIENT_APP
{
    partial class CHM_IDENTIFICATION_UTILISATEUR
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
            this.buttonFERMER = new System.Windows.Forms.Button();
            this.buttonVALIDER = new System.Windows.Forms.Button();
            this.PASSWORD_USER = new System.Windows.Forms.TextBox();
            this.LOGIN_USER = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PHOTO_USER = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_configuration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFERMER
            // 
            this.buttonFERMER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.porte_en_icone_7778_321;
            this.buttonFERMER.Location = new System.Drawing.Point(196, 275);
            this.buttonFERMER.Name = "buttonFERMER";
            this.buttonFERMER.Size = new System.Drawing.Size(103, 54);
            this.buttonFERMER.TabIndex = 4;
            this.buttonFERMER.Text = "Annuler";
            this.buttonFERMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFERMER.UseVisualStyleBackColor = true;
            this.buttonFERMER.Click += new System.EventHandler(this.buttonFERMER_Click);
            // 
            // buttonVALIDER
            // 
            this.buttonVALIDER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVALIDER.Image = global::CHM_CLIENT_APP.Properties.Resources.porte_sur_icone_9461_32;
            this.buttonVALIDER.Location = new System.Drawing.Point(63, 275);
            this.buttonVALIDER.Name = "buttonVALIDER";
            this.buttonVALIDER.Size = new System.Drawing.Size(103, 54);
            this.buttonVALIDER.TabIndex = 3;
            this.buttonVALIDER.Text = "Valider";
            this.buttonVALIDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVALIDER.UseVisualStyleBackColor = true;
            this.buttonVALIDER.Click += new System.EventHandler(this.buttonVALIDER_Click);
            // 
            // PASSWORD_USER
            // 
            this.PASSWORD_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PASSWORD_USER.Location = new System.Drawing.Point(138, 227);
            this.PASSWORD_USER.Name = "PASSWORD_USER";
            this.PASSWORD_USER.Size = new System.Drawing.Size(145, 20);
            this.PASSWORD_USER.TabIndex = 2;
            this.PASSWORD_USER.UseSystemPasswordChar = true;
            // 
            // LOGIN_USER
            // 
            this.LOGIN_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGIN_USER.Location = new System.Drawing.Point(138, 201);
            this.LOGIN_USER.Name = "LOGIN_USER";
            this.LOGIN_USER.Size = new System.Drawing.Size(145, 20);
            this.LOGIN_USER.TabIndex = 1;
            this.LOGIN_USER.TextChanged += new System.EventHandler(this.LOGIN_USER_TextChanged);
            this.LOGIN_USER.Leave += new System.EventHandler(this.LOGIN_USER_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(42, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // PHOTO_USER
            // 
            this.PHOTO_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PHOTO_USER.BackColor = System.Drawing.Color.Transparent;
            this.PHOTO_USER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PHOTO_USER.Image = global::CHM_CLIENT_APP.Properties.Resources.point_interrogation_utilisateur_icone_6379_96;
            this.PHOTO_USER.InitialImage = global::CHM_CLIENT_APP.Properties.Resources.point_interrogation_utilisateur_icone_6379_96;
            this.PHOTO_USER.Location = new System.Drawing.Point(92, 19);
            this.PHOTO_USER.Name = "PHOTO_USER";
            this.PHOTO_USER.Size = new System.Drawing.Size(179, 153);
            this.PHOTO_USER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PHOTO_USER.TabIndex = 26;
            this.PHOTO_USER.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CHM_CLIENT_APP.Properties.Resources.touches_icone_8868_96;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.service_manager_icone_5775_32;
            this.button1.Location = new System.Drawing.Point(150, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Settings";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_configuration
            // 
            this.btn_configuration.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.gestionnaire_session_icone_6949_961;
            this.btn_configuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_configuration.Location = new System.Drawing.Point(311, 12);
            this.btn_configuration.Name = "btn_configuration";
            this.btn_configuration.Size = new System.Drawing.Size(39, 38);
            this.btn_configuration.TabIndex = 31;
            this.btn_configuration.UseVisualStyleBackColor = true;
            this.btn_configuration.Click += new System.EventHandler(this.btn_configuration_Click);
            // 
            // CHM_IDENTIFICATION_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 345);
            this.ControlBox = false;
            this.Controls.Add(this.btn_configuration);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PHOTO_USER);
            this.Controls.Add(this.buttonFERMER);
            this.Controls.Add(this.buttonVALIDER);
            this.Controls.Add(this.PASSWORD_USER);
            this.Controls.Add(this.LOGIN_USER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_IDENTIFICATION_UTILISATEUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.CHM_IDENTIFICATION_UTILISATEUR_Load);
            this.Shown += new System.EventHandler(this.CHM_IDENTIFICATION_UTILISATEUR_Shown);
            this.Activated += new System.EventHandler(this.CHM_IDENTIFICATION_UTILISATEUR_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CHM_IDENTIFICATION_UTILISATEUR_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_IDENTIFICATION_UTILISATEUR_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PHOTO_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFERMER;
        private System.Windows.Forms.Button buttonVALIDER;
        private System.Windows.Forms.TextBox PASSWORD_USER;
        private System.Windows.Forms.TextBox LOGIN_USER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PHOTO_USER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_configuration;
    }
}