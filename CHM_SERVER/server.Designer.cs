namespace CHM_SERVER
{
    partial class server
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
            this.button3 = new System.Windows.Forms.Button();
            this.btn_demarrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = global::CHM_SERVER.Properties.Resources.modem;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 105);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Arrèter";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_demarrer
            // 
            this.btn_demarrer.Image = global::CHM_SERVER.Properties.Resources.communications;
            this.btn_demarrer.Location = new System.Drawing.Point(0, 0);
            this.btn_demarrer.Name = "btn_demarrer";
            this.btn_demarrer.Size = new System.Drawing.Size(119, 105);
            this.btn_demarrer.TabIndex = 3;
            this.btn_demarrer.Text = "&Démarrer";
            this.btn_demarrer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_demarrer.UseVisualStyleBackColor = true;
            this.btn_demarrer.Click += new System.EventHandler(this.btn_demarrer_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(119, 106);
            this.ControlBox = false;
            this.Controls.Add(this.btn_demarrer);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "server";
            this.Load += new System.EventHandler(this.server_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button btn_demarrer;
    }
}