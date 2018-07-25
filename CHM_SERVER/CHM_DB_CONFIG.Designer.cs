namespace CHM_SERVER
{
    partial class CHM_DB_CONFIG
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
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(92, 22);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(169, 20);
            this.txt_User.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User :";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(92, 48);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(169, 20);
            this.txt_Password.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(92, 74);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(169, 20);
            this.txt_Server.TabIndex = 0;
            this.txt_Server.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server :";
            // 
            // txt_DB
            // 
            this.txt_DB.Location = new System.Drawing.Point(92, 100);
            this.txt_DB.Name = "txt_DB";
            this.txt_DB.Size = new System.Drawing.Size(169, 20);
            this.txt_DB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Base :";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(54, 145);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Save";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(161, 145);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Cancel";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // CHM_DB_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_SERVER.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(291, 193);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DB);
            this.Controls.Add(this.txt_Server);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_DB_CONFIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Configuration إعدادات قاعدة البيانات";
            this.Load += new System.EventHandler(this.CHM_DB_CONFIG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}