namespace CHM_CLIENT_APP
{
    partial class CHM_ETATS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_ETATS));
            this.CHM_Aperçu_document = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.SuspendLayout();
            // 
            // CHM_Aperçu_document
            // 
            this.CHM_Aperçu_document.ActiveViewIndex = -1;
            this.CHM_Aperçu_document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CHM_Aperçu_document.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHM_Aperçu_document.DisplayGroupTree = false;
            this.CHM_Aperçu_document.Location = new System.Drawing.Point(0, 54);
            this.CHM_Aperçu_document.Name = "CHM_Aperçu_document";
            this.CHM_Aperçu_document.SelectionFormula = "";
            this.CHM_Aperçu_document.Size = new System.Drawing.Size(764, 465);
            this.CHM_Aperçu_document.TabIndex = 0;
            this.CHM_Aperçu_document.ViewTimeSelectionFormula = "";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.filefind_icone_7697_48;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(764, 48);
            this.entete_Formulaire_21.TabIndex = 1;
            // 
            // CHM_ETATS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 519);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.CHM_Aperçu_document);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CHM_ETATS";
            this.Text = "Aperçu des Rapports";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CHM_Aperçu_document;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}