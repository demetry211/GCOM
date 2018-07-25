namespace CHM_CLIENT_APP
{
    partial class CHM_COMPTE_CREDIT_CLIENT
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
            this.NUM_COMPTE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CREDIT = new System.Windows.Forms.TextBox();
            this.PAYE = new System.Windows.Forms.TextBox();
            this.CLIENT = new System.Windows.Forms.TextBox();
            this.BTN_FERME = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NOM_FENETRE = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NUM_COMPTE
            // 
            this.NUM_COMPTE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NUM_COMPTE.BackColor = System.Drawing.Color.White;
            this.NUM_COMPTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUM_COMPTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_COMPTE.Location = new System.Drawing.Point(118, 143);
            this.NUM_COMPTE.Name = "NUM_COMPTE";
            this.NUM_COMPTE.Size = new System.Drawing.Size(208, 32);
            this.NUM_COMPTE.TabIndex = 0;
            this.NUM_COMPTE.Text = "label1";
            this.NUM_COMPTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total credit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total payé:";
            // 
            // CREDIT
            // 
            this.CREDIT.BackColor = System.Drawing.Color.White;
            this.CREDIT.Location = new System.Drawing.Point(121, 220);
            this.CREDIT.Name = "CREDIT";
            this.CREDIT.ReadOnly = true;
            this.CREDIT.Size = new System.Drawing.Size(256, 20);
            this.CREDIT.TabIndex = 4;
            // 
            // PAYE
            // 
            this.PAYE.BackColor = System.Drawing.Color.White;
            this.PAYE.Location = new System.Drawing.Point(121, 245);
            this.PAYE.Name = "PAYE";
            this.PAYE.ReadOnly = true;
            this.PAYE.Size = new System.Drawing.Size(256, 20);
            this.PAYE.TabIndex = 6;
            // 
            // CLIENT
            // 
            this.CLIENT.BackColor = System.Drawing.Color.White;
            this.CLIENT.Location = new System.Drawing.Point(121, 194);
            this.CLIENT.Name = "CLIENT";
            this.CLIENT.ReadOnly = true;
            this.CLIENT.Size = new System.Drawing.Size(256, 20);
            this.CLIENT.TabIndex = 7;
            // 
            // BTN_FERME
            // 
            this.BTN_FERME.BackColor = System.Drawing.Color.Transparent;
            this.BTN_FERME.FlatAppearance.BorderSize = 0;
            this.BTN_FERME.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_FERME.Image = global::CHM_CLIENT_APP.Properties.Resources.demande_afficher_la_liste_icone_8709_321;
            this.BTN_FERME.Location = new System.Drawing.Point(253, 66);
            this.BTN_FERME.Name = "BTN_FERME";
            this.BTN_FERME.Size = new System.Drawing.Size(88, 38);
            this.BTN_FERME.TabIndex = 8;
            this.BTN_FERME.Text = "Details ";
            this.BTN_FERME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_FERME.UseVisualStyleBackColor = false;
            this.BTN_FERME.Click += new System.EventHandler(this.BTN_FERME_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_321;
            this.button1.Location = new System.Drawing.Point(349, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fermer";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "N° :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.NOM_FENETRE);
            this.groupBox1.Location = new System.Drawing.Point(-2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 53);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // NOM_FENETRE
            // 
            this.NOM_FENETRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_FENETRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FENETRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NOM_FENETRE.Location = new System.Drawing.Point(14, 16);
            this.NOM_FENETRE.Name = "NOM_FENETRE";
            this.NOM_FENETRE.Size = new System.Drawing.Size(423, 29);
            this.NOM_FENETRE.TabIndex = 1;
            this.NOM_FENETRE.Text = "Compte client";
            this.NOM_FENETRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHM_COMPTE_CREDIT_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_FERME);
            this.Controls.Add(this.CLIENT);
            this.Controls.Add(this.PAYE);
            this.Controls.Add(this.CREDIT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUM_COMPTE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_COMPTE_CREDIT_CLIENT";
            this.Text = "Compte client";
            this.Load += new System.EventHandler(this.CHM_COMPTE_CREDIT_CLIENT_Load);
            this.Shown += new System.EventHandler(this.CHM_COMPTE_CREDIT_CLIENT_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NUM_COMPTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CREDIT;
        private System.Windows.Forms.TextBox PAYE;
        private System.Windows.Forms.TextBox CLIENT;
        private System.Windows.Forms.Button BTN_FERME;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NOM_FENETRE;
    }
}