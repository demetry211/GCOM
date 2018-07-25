namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    partial class CHM_FRM_GAIN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_au = new System.Windows.Forms.DateTimePicker();
            this.dtp_du = new System.Windows.Forms.DateTimePicker();
            this.lb_recu = new LABEL_NUM.LabelNumerique();
            this.lb_retour = new LABEL_NUM.LabelNumerique();
            this.lb_vente = new LABEL_NUM.LabelNumerique();
            this.lb_gain = new LABEL_NUM.LabelNumerique();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Au :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Du :";
            // 
            // dtp_au
            // 
            this.dtp_au.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_au.Location = new System.Drawing.Point(288, 25);
            this.dtp_au.Name = "dtp_au";
            this.dtp_au.Size = new System.Drawing.Size(114, 20);
            this.dtp_au.TabIndex = 79;
            this.dtp_au.ValueChanged += new System.EventHandler(this.dtp_au_ValueChanged);
            // 
            // dtp_du
            // 
            this.dtp_du.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_du.Location = new System.Drawing.Point(111, 25);
            this.dtp_du.Name = "dtp_du";
            this.dtp_du.Size = new System.Drawing.Size(103, 20);
            this.dtp_du.TabIndex = 80;
            this.dtp_du.ValueChanged += new System.EventHandler(this.dtp_du_ValueChanged);
            // 
            // lb_recu
            // 
            this.lb_recu.BackColor = System.Drawing.Color.Silver;
            this.lb_recu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_recu.Clinote = true;
            this.lb_recu.Couleur1 = System.Drawing.Color.Black;
            this.lb_recu.Couleur2 = System.Drawing.Color.Black;
            this.lb_recu.DecimalPlaces = 3;
            this.lb_recu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recu.ForeColor = System.Drawing.Color.Black;
            this.lb_recu.Location = new System.Drawing.Point(330, 101);
            this.lb_recu.Name = "lb_recu";
            this.lb_recu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_recu.Size = new System.Drawing.Size(129, 30);
            this.lb_recu.TabIndex = 87;
            this.lb_recu.Text = "0.000";
            this.lb_recu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_recu.ThousandsSeparator = true;
            this.lb_recu.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lb_retour
            // 
            this.lb_retour.BackColor = System.Drawing.Color.Silver;
            this.lb_retour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_retour.Clinote = true;
            this.lb_retour.Couleur1 = System.Drawing.Color.Black;
            this.lb_retour.Couleur2 = System.Drawing.Color.Black;
            this.lb_retour.DecimalPlaces = 3;
            this.lb_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_retour.ForeColor = System.Drawing.Color.Black;
            this.lb_retour.Location = new System.Drawing.Point(171, 101);
            this.lb_retour.Name = "lb_retour";
            this.lb_retour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_retour.Size = new System.Drawing.Size(129, 30);
            this.lb_retour.TabIndex = 87;
            this.lb_retour.Text = "0.000";
            this.lb_retour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_retour.ThousandsSeparator = true;
            this.lb_retour.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lb_vente
            // 
            this.lb_vente.BackColor = System.Drawing.Color.Silver;
            this.lb_vente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_vente.Clinote = true;
            this.lb_vente.Couleur1 = System.Drawing.Color.Black;
            this.lb_vente.Couleur2 = System.Drawing.Color.Black;
            this.lb_vente.DecimalPlaces = 3;
            this.lb_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vente.ForeColor = System.Drawing.Color.Black;
            this.lb_vente.Location = new System.Drawing.Point(12, 101);
            this.lb_vente.Name = "lb_vente";
            this.lb_vente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_vente.Size = new System.Drawing.Size(129, 30);
            this.lb_vente.TabIndex = 87;
            this.lb_vente.Text = "0.000";
            this.lb_vente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_vente.ThousandsSeparator = true;
            this.lb_vente.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lb_vente.Click += new System.EventHandler(this.labelNumerique2_Click);
            // 
            // lb_gain
            // 
            this.lb_gain.BackColor = System.Drawing.Color.Silver;
            this.lb_gain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_gain.Clinote = true;
            this.lb_gain.Couleur1 = System.Drawing.Color.Gray;
            this.lb_gain.Couleur2 = System.Drawing.Color.OrangeRed;
            this.lb_gain.DecimalPlaces = 3;
            this.lb_gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gain.ForeColor = System.Drawing.Color.Gray;
            this.lb_gain.Location = new System.Drawing.Point(91, 155);
            this.lb_gain.Name = "lb_gain";
            this.lb_gain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_gain.Size = new System.Drawing.Size(153, 30);
            this.lb_gain.TabIndex = 87;
            this.lb_gain.Text = "0.000";
            this.lb_gain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_gain.ThousandsSeparator = true;
            this.lb_gain.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Vente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Retour :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Achat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "Gain :";
            // 
            // CHM_FRM_GAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.ClientSize = new System.Drawing.Size(471, 213);
            this.Controls.Add(this.lb_vente);
            this.Controls.Add(this.lb_gain);
            this.Controls.Add(this.lb_retour);
            this.Controls.Add(this.lb_recu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_au);
            this.Controls.Add(this.dtp_du);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_FRM_GAIN";
            this.Text = "Rapport général :";
            this.Load += new System.EventHandler(this.CHM_FRM_GAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_au;
        private System.Windows.Forms.DateTimePicker dtp_du;
        private LABEL_NUM.LabelNumerique lb_recu;
        private LABEL_NUM.LabelNumerique lb_retour;
        private LABEL_NUM.LabelNumerique lb_vente;
        private LABEL_NUM.LabelNumerique lb_gain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}