﻿namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    partial class CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.nom_fenetre = new System.Windows.Forms.Label();
            this.dtp_du = new System.Windows.Forms.DateTimePicker();
            this.dtp_au = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_utilisateur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_detail = new System.Windows.Forms.RadioButton();
            this.rd_groupe = new System.Windows.Forms.RadioButton();
            this.btn_valider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(-2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 47);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(375, 8);
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
            this.nom_fenetre.Location = new System.Drawing.Point(6, 14);
            this.nom_fenetre.Name = "nom_fenetre";
            this.nom_fenetre.Size = new System.Drawing.Size(365, 30);
            this.nom_fenetre.TabIndex = 0;
            this.nom_fenetre.Text = "Rapport de Vente Par Utilisateur";
            this.nom_fenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_du
            // 
            this.dtp_du.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_du.Location = new System.Drawing.Point(86, 96);
            this.dtp_du.Name = "dtp_du";
            this.dtp_du.Size = new System.Drawing.Size(103, 20);
            this.dtp_du.TabIndex = 69;
            this.dtp_du.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtp_au
            // 
            this.dtp_au.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_au.Location = new System.Drawing.Point(262, 96);
            this.dtp_au.Name = "dtp_au";
            this.dtp_au.Size = new System.Drawing.Size(114, 20);
            this.dtp_au.TabIndex = 69;
            this.dtp_au.ValueChanged += new System.EventHandler(this.dtp_au_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Du :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Au :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbx_utilisateur
            // 
            this.cbx_utilisateur.FormattingEnabled = true;
            this.cbx_utilisateur.Location = new System.Drawing.Point(162, 54);
            this.cbx_utilisateur.Name = "cbx_utilisateur";
            this.cbx_utilisateur.Size = new System.Drawing.Size(184, 21);
            this.cbx_utilisateur.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Utilisateur :";
            // 
            // rd_detail
            // 
            this.rd_detail.AutoSize = true;
            this.rd_detail.BackColor = System.Drawing.Color.Transparent;
            this.rd_detail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_detail.Location = new System.Drawing.Point(102, 130);
            this.rd_detail.Name = "rd_detail";
            this.rd_detail.Size = new System.Drawing.Size(74, 20);
            this.rd_detail.TabIndex = 72;
            this.rd_detail.TabStop = true;
            this.rd_detail.Text = "Détaillé";
            this.rd_detail.UseVisualStyleBackColor = false;
            this.rd_detail.CheckedChanged += new System.EventHandler(this.rd_detail_CheckedChanged);
            // 
            // rd_groupe
            // 
            this.rd_groupe.AutoSize = true;
            this.rd_groupe.BackColor = System.Drawing.Color.Transparent;
            this.rd_groupe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_groupe.Location = new System.Drawing.Point(244, 130);
            this.rd_groupe.Name = "rd_groupe";
            this.rd_groupe.Size = new System.Drawing.Size(75, 20);
            this.rd_groupe.TabIndex = 72;
            this.rd_groupe.TabStop = true;
            this.rd_groupe.Text = "Général";
            this.rd_groupe.UseVisualStyleBackColor = false;
            this.rd_groupe.CheckedChanged += new System.EventHandler(this.rd_groupe_CheckedChanged);
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(121, 166);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(171, 33);
            this.btn_valider.TabIndex = 73;
            this.btn_valider.Text = "Afficher";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 211);
            this.ControlBox = false;
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.rd_groupe);
            this.Controls.Add(this.rd_detail);
            this.Controls.Add(this.cbx_utilisateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_au);
            this.Controls.Add(this.dtp_du);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_RAPPORT_VENTE_TOTAL_PAR_DATE_TICKET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport de Vente Par Utilisateur";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nom_fenetre;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtp_du;
        private System.Windows.Forms.DateTimePicker dtp_au;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_utilisateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_detail;
        private System.Windows.Forms.RadioButton rd_groupe;
        private System.Windows.Forms.Button btn_valider;
    }
}