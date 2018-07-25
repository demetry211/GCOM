namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    partial class Template_Liste_Facture_Ouverte
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
            this.btn_ajouter_Facture = new System.Windows.Forms.Button();
            this.p_entete_facture = new System.Windows.Forms.Panel();
            this.p_liste_facture = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_ajouter_Facture
            // 
            this.btn_ajouter_Facture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter_Facture.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_Facture.Location = new System.Drawing.Point(545, 3);
            this.btn_ajouter_Facture.Name = "btn_ajouter_Facture";
            this.btn_ajouter_Facture.Size = new System.Drawing.Size(60, 56);
            this.btn_ajouter_Facture.TabIndex = 0;
            this.btn_ajouter_Facture.Text = "+";
            this.btn_ajouter_Facture.UseVisualStyleBackColor = true;
            this.btn_ajouter_Facture.Click += new System.EventHandler(this.btn_ajouter_Facture_Click);
            // 
            // p_entete_facture
            // 
            this.p_entete_facture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_entete_facture.AutoScroll = true;
            this.p_entete_facture.Location = new System.Drawing.Point(3, 3);
            this.p_entete_facture.Name = "p_entete_facture";
            this.p_entete_facture.Size = new System.Drawing.Size(536, 56);
            this.p_entete_facture.TabIndex = 1;
            // 
            // p_liste_facture
            // 
            this.p_liste_facture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_liste_facture.Location = new System.Drawing.Point(3, 65);
            this.p_liste_facture.Name = "p_liste_facture";
            this.p_liste_facture.Size = new System.Drawing.Size(602, 336);
            this.p_liste_facture.TabIndex = 1;
            // 
            // Template_Liste_Facture_Ouverte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_liste_facture);
            this.Controls.Add(this.p_entete_facture);
            this.Controls.Add(this.btn_ajouter_Facture);
            this.Name = "Template_Liste_Facture_Ouverte";
            this.Size = new System.Drawing.Size(608, 404);
            this.Load += new System.EventHandler(this.Template_Liste_Facture_Ouverte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_entete_facture;
        private System.Windows.Forms.Panel p_liste_facture;
        public System.Windows.Forms.Button btn_ajouter_Facture;
    }
}
