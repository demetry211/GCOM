namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    partial class CHM_FRM_RAPPORT_VENTE_TOTAL
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.rd_groupe = new System.Windows.Forms.RadioButton();
            this.rd_detail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_au = new System.Windows.Forms.DateTimePicker();
            this.dtp_du = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.nom_fenetre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(122, 157);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(171, 33);
            this.btn_valider.TabIndex = 81;
            this.btn_valider.Text = "Afficher";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // rd_groupe
            // 
            this.rd_groupe.AutoSize = true;
            this.rd_groupe.BackColor = System.Drawing.Color.Transparent;
            this.rd_groupe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_groupe.Location = new System.Drawing.Point(251, 113);
            this.rd_groupe.Name = "rd_groupe";
            this.rd_groupe.Size = new System.Drawing.Size(75, 20);
            this.rd_groupe.TabIndex = 79;
            this.rd_groupe.TabStop = true;
            this.rd_groupe.Text = "Général";
            this.rd_groupe.UseVisualStyleBackColor = false;
            // 
            // rd_detail
            // 
            this.rd_detail.AutoSize = true;
            this.rd_detail.BackColor = System.Drawing.Color.Transparent;
            this.rd_detail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_detail.Location = new System.Drawing.Point(96, 113);
            this.rd_detail.Name = "rd_detail";
            this.rd_detail.Size = new System.Drawing.Size(74, 20);
            this.rd_detail.TabIndex = 80;
            this.rd_detail.TabStop = true;
            this.rd_detail.Text = "Détaillé";
            this.rd_detail.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Au :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Du :";
            // 
            // dtp_au
            // 
            this.dtp_au.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_au.Location = new System.Drawing.Point(275, 64);
            this.dtp_au.Name = "dtp_au";
            this.dtp_au.Size = new System.Drawing.Size(114, 20);
            this.dtp_au.TabIndex = 75;
            // 
            // dtp_du
            // 
            this.dtp_du.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_du.Location = new System.Drawing.Point(96, 64);
            this.dtp_du.Name = "dtp_du";
            this.dtp_du.Size = new System.Drawing.Size(103, 20);
            this.dtp_du.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.nom_fenetre);
            this.groupBox1.Location = new System.Drawing.Point(-5, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 47);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(375, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 43);
            this.button5.TabIndex = 81;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nom_fenetre
            // 
            this.nom_fenetre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_fenetre.BackColor = System.Drawing.Color.Transparent;
            this.nom_fenetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_fenetre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nom_fenetre.Location = new System.Drawing.Point(13, 12);
            this.nom_fenetre.Name = "nom_fenetre";
            this.nom_fenetre.Size = new System.Drawing.Size(365, 30);
            this.nom_fenetre.TabIndex = 0;
            this.nom_fenetre.Text = "Rapport de vente";
            this.nom_fenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHM_FRM_RAPPORT_VENTE_TOTAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.rd_groupe);
            this.Controls.Add(this.rd_detail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_au);
            this.Controls.Add(this.dtp_du);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_FRM_RAPPORT_VENTE_TOTAL";
            this.Text = "Rapport de vente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.RadioButton rd_groupe;
        private System.Windows.Forms.RadioButton rd_detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_au;
        private System.Windows.Forms.DateTimePicker dtp_du;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label nom_fenetre;
    }
}