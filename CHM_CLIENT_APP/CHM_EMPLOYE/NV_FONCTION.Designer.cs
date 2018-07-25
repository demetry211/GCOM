namespace CHM_CLIENT_APP
{
    partial class NV_FONCTION
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
            this.label1 = new System.Windows.Forms.Label();
            this.NV_FCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NV_DESC_FCT = new System.Windows.Forms.TextBox();
            this.btn_ENREG_FCT = new System.Windows.Forms.Button();
            this.btn_FERMER_FCT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fonction :";
            // 
            // NV_FCT
            // 
            this.NV_FCT.Location = new System.Drawing.Point(101, 21);
            this.NV_FCT.Name = "NV_FCT";
            this.NV_FCT.Size = new System.Drawing.Size(190, 20);
            this.NV_FCT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // NV_DESC_FCT
            // 
            this.NV_DESC_FCT.Location = new System.Drawing.Point(101, 51);
            this.NV_DESC_FCT.Multiline = true;
            this.NV_DESC_FCT.Name = "NV_DESC_FCT";
            this.NV_DESC_FCT.Size = new System.Drawing.Size(190, 20);
            this.NV_DESC_FCT.TabIndex = 3;
            // 
            // btn_ENREG_FCT
            // 
            this.btn_ENREG_FCT.Location = new System.Drawing.Point(61, 99);
            this.btn_ENREG_FCT.Name = "btn_ENREG_FCT";
            this.btn_ENREG_FCT.Size = new System.Drawing.Size(75, 23);
            this.btn_ENREG_FCT.TabIndex = 4;
            this.btn_ENREG_FCT.Text = "&Enregistrer";
            this.btn_ENREG_FCT.UseVisualStyleBackColor = true;
            this.btn_ENREG_FCT.Click += new System.EventHandler(this.btn_ENREG_FCT_Click);
            // 
            // btn_FERMER_FCT
            // 
            this.btn_FERMER_FCT.Location = new System.Drawing.Point(177, 99);
            this.btn_FERMER_FCT.Name = "btn_FERMER_FCT";
            this.btn_FERMER_FCT.Size = new System.Drawing.Size(75, 23);
            this.btn_FERMER_FCT.TabIndex = 5;
            this.btn_FERMER_FCT.Text = "&Fermer";
            this.btn_FERMER_FCT.UseVisualStyleBackColor = true;
            this.btn_FERMER_FCT.Click += new System.EventHandler(this.btn_FERMER_FCT_Click);
            // 
            // NV_FONCTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 151);
            this.Controls.Add(this.btn_FERMER_FCT);
            this.Controls.Add(this.btn_ENREG_FCT);
            this.Controls.Add(this.NV_DESC_FCT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NV_FCT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NV_FONCTION";
            this.Text = "Nouvelle fonction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NV_FCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NV_DESC_FCT;
        private System.Windows.Forms.Button btn_ENREG_FCT;
        private System.Windows.Forms.Button btn_FERMER_FCT;
    }
}