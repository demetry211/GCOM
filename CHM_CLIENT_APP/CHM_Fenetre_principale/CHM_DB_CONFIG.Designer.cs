namespace CHM_CLIENT_APP
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
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_instance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(92, 22);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(169, 20);
            this.txt_server.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serveur :";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(92, 48);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(169, 20);
            this.txt_Port.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // txt_instance
            // 
            this.txt_instance.Location = new System.Drawing.Point(92, 74);
            this.txt_instance.Name = "txt_instance";
            this.txt_instance.Size = new System.Drawing.Size(169, 20);
            this.txt_instance.TabIndex = 0;
            this.txt_instance.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Instance :";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(55, 113);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Enregistrer";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(162, 113);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // CHM_DB_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(291, 150);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_instance);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_DB_CONFIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration du serveur";
            this.Load += new System.EventHandler(this.CHM_DB_CONFIG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_instance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}