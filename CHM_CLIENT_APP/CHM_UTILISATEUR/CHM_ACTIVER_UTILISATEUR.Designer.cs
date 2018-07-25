namespace CHM_CLIENT_APP
{
    partial class CHM_ACTIVER_UTILISATEUR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFERMER
            // 
            this.buttonFERMER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFERMER.Image = global::CHM_CLIENT_APP.Properties.Resources.session_interrupteur_icone_6284_48;
            this.buttonFERMER.Location = new System.Drawing.Point(131, 147);
            this.buttonFERMER.Name = "buttonFERMER";
            this.buttonFERMER.Size = new System.Drawing.Size(201, 53);
            this.buttonFERMER.TabIndex = 35;
            this.buttonFERMER.Text = "Changer d\'utilisateur";
            this.buttonFERMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFERMER.UseVisualStyleBackColor = true;
            this.buttonFERMER.Click += new System.EventHandler(this.buttonFERMER_Click);
            // 
            // buttonVALIDER
            // 
            this.buttonVALIDER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVALIDER.Image = global::CHM_CLIENT_APP.Properties.Resources.accepter_vert_ok_oui_icone_6163_32;
            this.buttonVALIDER.Location = new System.Drawing.Point(183, 97);
            this.buttonVALIDER.Name = "buttonVALIDER";
            this.buttonVALIDER.Size = new System.Drawing.Size(96, 44);
            this.buttonVALIDER.TabIndex = 34;
            this.buttonVALIDER.Text = "Entrer";
            this.buttonVALIDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVALIDER.UseVisualStyleBackColor = true;
            this.buttonVALIDER.Click += new System.EventHandler(this.buttonVALIDER_Click);
            // 
            // PASSWORD_USER
            // 
            this.PASSWORD_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PASSWORD_USER.Location = new System.Drawing.Point(239, 51);
            this.PASSWORD_USER.Name = "PASSWORD_USER";
            this.PASSWORD_USER.Size = new System.Drawing.Size(143, 20);
            this.PASSWORD_USER.TabIndex = 33;
            this.PASSWORD_USER.UseSystemPasswordChar = true;
            // 
            // LOGIN_USER
            // 
            this.LOGIN_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGIN_USER.Enabled = false;
            this.LOGIN_USER.Location = new System.Drawing.Point(239, 25);
            this.LOGIN_USER.Name = "LOGIN_USER";
            this.LOGIN_USER.Size = new System.Drawing.Size(143, 20);
            this.LOGIN_USER.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(118, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mot de passe :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(118, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nom d\'utilisateur :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.Lock;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 87);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // CHM_ACTIVER_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 220);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFERMER);
            this.Controls.Add(this.buttonVALIDER);
            this.Controls.Add(this.PASSWORD_USER);
            this.Controls.Add(this.LOGIN_USER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "CHM_ACTIVER_UTILISATEUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vérouillé";
            this.Shown += new System.EventHandler(this.CHM_ACTIVER_UTILISATEUR_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_ACTIVER_UTILISATEUR_KeyDown);
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}