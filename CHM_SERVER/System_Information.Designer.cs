namespace CHM_SERVER
{
    partial class System_Information
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
            this.BTN_OK = new System.Windows.Forms.Button();
            this.ADRESSE_IP_SERVER = new System.Windows.Forms.TextBox();
            this.NOM_MACHINE_SERVER = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_OK.Location = new System.Drawing.Point(90, 149);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(111, 52);
            this.BTN_OK.TabIndex = 0;
            this.BTN_OK.Text = "&OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // ADRESSE_IP_SERVER
            // 
            this.ADRESSE_IP_SERVER.Location = new System.Drawing.Point(61, 80);
            this.ADRESSE_IP_SERVER.Name = "ADRESSE_IP_SERVER";
            this.ADRESSE_IP_SERVER.Size = new System.Drawing.Size(168, 20);
            this.ADRESSE_IP_SERVER.TabIndex = 1;
            // 
            // NOM_MACHINE_SERVER
            // 
            this.NOM_MACHINE_SERVER.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.NOM_MACHINE_SERVER.Location = new System.Drawing.Point(61, 54);
            this.NOM_MACHINE_SERVER.Name = "NOM_MACHINE_SERVER";
            this.NOM_MACHINE_SERVER.Size = new System.Drawing.Size(168, 20);
            this.NOM_MACHINE_SERVER.TabIndex = 1;
            // 
            // System_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_SERVER.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 233);
            this.Controls.Add(this.NOM_MACHINE_SERVER);
            this.Controls.Add(this.ADRESSE_IP_SERVER);
            this.Controls.Add(this.BTN_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "System_Information";
            this.Text = "CHM Server Machine Informations";
            this.Shown += new System.EventHandler(this.System_Information_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.TextBox ADRESSE_IP_SERVER;
        private System.Windows.Forms.TextBox NOM_MACHINE_SERVER;
    }
}