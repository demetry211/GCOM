namespace CHM_CLIENT_APP
{
    partial class CHM_VENTE
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
            this.BTN_CLIENTS = new System.Windows.Forms.Button();
            this.BTN_COMMANDES = new System.Windows.Forms.Button();
            this.BTN_FACTURES = new System.Windows.Forms.Button();
            this.BTN_REGLEMENT = new System.Windows.Forms.Button();
            this.BTN_LIVRAISON = new System.Windows.Forms.Button();
            this.CLIENT_PANEL = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CLIENT_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_CLIENTS
            // 
            this.BTN_CLIENTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_CLIENTS.Location = new System.Drawing.Point(156, 364);
            this.BTN_CLIENTS.Name = "BTN_CLIENTS";
            this.BTN_CLIENTS.Size = new System.Drawing.Size(82, 70);
            this.BTN_CLIENTS.TabIndex = 0;
            this.BTN_CLIENTS.Text = "&Client";
            this.BTN_CLIENTS.UseVisualStyleBackColor = true;
            this.BTN_CLIENTS.Click += new System.EventHandler(this.BTN_CLIENTS_Click);
            // 
            // BTN_COMMANDES
            // 
            this.BTN_COMMANDES.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_COMMANDES.Location = new System.Drawing.Point(244, 364);
            this.BTN_COMMANDES.Name = "BTN_COMMANDES";
            this.BTN_COMMANDES.Size = new System.Drawing.Size(82, 70);
            this.BTN_COMMANDES.TabIndex = 1;
            this.BTN_COMMANDES.Text = "&Commandes";
            this.BTN_COMMANDES.UseVisualStyleBackColor = true;
            // 
            // BTN_FACTURES
            // 
            this.BTN_FACTURES.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_FACTURES.Location = new System.Drawing.Point(420, 364);
            this.BTN_FACTURES.Name = "BTN_FACTURES";
            this.BTN_FACTURES.Size = new System.Drawing.Size(82, 70);
            this.BTN_FACTURES.TabIndex = 2;
            this.BTN_FACTURES.Text = "&Factures";
            this.BTN_FACTURES.UseVisualStyleBackColor = true;
            // 
            // BTN_REGLEMENT
            // 
            this.BTN_REGLEMENT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_REGLEMENT.Location = new System.Drawing.Point(508, 364);
            this.BTN_REGLEMENT.Name = "BTN_REGLEMENT";
            this.BTN_REGLEMENT.Size = new System.Drawing.Size(82, 70);
            this.BTN_REGLEMENT.TabIndex = 3;
            this.BTN_REGLEMENT.Text = "&Règlement";
            this.BTN_REGLEMENT.UseVisualStyleBackColor = true;
            // 
            // BTN_LIVRAISON
            // 
            this.BTN_LIVRAISON.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_LIVRAISON.Location = new System.Drawing.Point(332, 364);
            this.BTN_LIVRAISON.Name = "BTN_LIVRAISON";
            this.BTN_LIVRAISON.Size = new System.Drawing.Size(82, 70);
            this.BTN_LIVRAISON.TabIndex = 4;
            this.BTN_LIVRAISON.Text = "&Livraison";
            this.BTN_LIVRAISON.UseVisualStyleBackColor = true;
            // 
            // CLIENT_PANEL
            // 
            this.CLIENT_PANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CLIENT_PANEL.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.client;
            this.CLIENT_PANEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLIENT_PANEL.Controls.Add(this.button1);
            this.CLIENT_PANEL.Controls.Add(this.button2);
            this.CLIENT_PANEL.Controls.Add(this.button3);
            this.CLIENT_PANEL.Location = new System.Drawing.Point(203, 93);
            this.CLIENT_PANEL.Name = "CLIENT_PANEL";
            this.CLIENT_PANEL.Size = new System.Drawing.Size(340, 261);
            this.CLIENT_PANEL.TabIndex = 5;
            this.CLIENT_PANEL.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.description__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(133, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Fiche client";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Image = global::CHM_CLIENT_APP.Properties.Resources.dossier_des_idees_rouge_icone_9673_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(223, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 70);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Liste des clients";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Image = global::CHM_CLIENT_APP.Properties.Resources.profil_icone_6739_481;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(43, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 70);
            this.button3.TabIndex = 8;
            this.button3.Text = "&Nouvel client";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CHM_VENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 446);
            this.Controls.Add(this.CLIENT_PANEL);
            this.Controls.Add(this.BTN_LIVRAISON);
            this.Controls.Add(this.BTN_REGLEMENT);
            this.Controls.Add(this.BTN_FACTURES);
            this.Controls.Add(this.BTN_COMMANDES);
            this.Controls.Add(this.BTN_CLIENTS);
            this.Name = "CHM_VENTE";
            this.Text = "Vente";
            this.CLIENT_PANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_CLIENTS;
        private System.Windows.Forms.Button BTN_COMMANDES;
        private System.Windows.Forms.Button BTN_FACTURES;
        private System.Windows.Forms.Button BTN_REGLEMENT;
        private System.Windows.Forms.Button BTN_LIVRAISON;
        private System.Windows.Forms.Panel CLIENT_PANEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}