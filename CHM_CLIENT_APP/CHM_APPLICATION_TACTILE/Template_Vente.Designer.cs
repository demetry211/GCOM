namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    partial class Template_Vente
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_montant = new LABEL_NUM.LabelNumerique();
            this.entete = new CHM_CLIENT_APP.CHM_APPLICATION_TACTILE.Template_Ligne_Facture();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 317);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(178, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "الإجمالي :";
            // 
            // lb_montant
            // 
            this.lb_montant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_montant.Clinote = true;
            this.lb_montant.Couleur1 = System.Drawing.Color.Gray;
            this.lb_montant.Couleur2 = System.Drawing.Color.OrangeRed;
            this.lb_montant.DecimalPlaces = 3;
            this.lb_montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_montant.ForeColor = System.Drawing.Color.Gray;
            this.lb_montant.Location = new System.Drawing.Point(3, 361);
            this.lb_montant.Name = "lb_montant";
            this.lb_montant.Size = new System.Drawing.Size(169, 24);
            this.lb_montant.TabIndex = 5;
            this.lb_montant.Text = "0.000";
            this.lb_montant.ThousandsSeparator = true;
            this.lb_montant.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // entete
            // 
            this.entete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entete.BackColor = System.Drawing.Color.White;
            this.entete.Location = new System.Drawing.Point(21, 0);
            this.entete.Name = "entete";
            this.entete.Size = new System.Drawing.Size(574, 39);
            this.entete.TabIndex = 6;
            // 
            // Template_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.entete);
            this.Controls.Add(this.lb_montant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Template_Vente";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(596, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        
        private LABEL_NUM.LabelNumerique lb_montant;
        private Template_Ligne_Facture entete;
    }
}
