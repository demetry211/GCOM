namespace CHM_CLIENT_APP.CHM_UTILISATEUR
{
    partial class CHM_FRM_DroitsAcces
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
            this.p_groups = new System.Windows.Forms.Panel();
            this.p_pages = new System.Windows.Forms.Panel();
            this.btn_valider = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_groups
            // 
            this.p_groups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_groups.AutoScroll = true;
            this.p_groups.BackColor = System.Drawing.Color.White;
            this.p_groups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_groups.Location = new System.Drawing.Point(0, 26);
            this.p_groups.Name = "p_groups";
            this.p_groups.Size = new System.Drawing.Size(251, 394);
            this.p_groups.TabIndex = 0;
            // 
            // p_pages
            // 
            this.p_pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_pages.AutoScroll = true;
            this.p_pages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_pages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_pages.Location = new System.Drawing.Point(0, 26);
            this.p_pages.Name = "p_pages";
            this.p_pages.Size = new System.Drawing.Size(573, 394);
            this.p_pages.TabIndex = 0;
            this.p_pages.MouseEnter += new System.EventHandler(this.p_pages_MouseEnter);
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_valider.BackColor = System.Drawing.SystemColors.Control;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Location = new System.Drawing.Point(735, 480);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(90, 35);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Enregistrer";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.p_groups);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.p_pages);
            this.splitContainer1.Size = new System.Drawing.Size(831, 420);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liste des  groupes utilisateurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des menus";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(837, 48);
            this.entete_Formulaire_21.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_321;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(222, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHM_FRM_DroitsAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 521);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.entete_Formulaire_21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CHM_FRM_DroitsAcces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des droits d\'accès";
            this.Load += new System.EventHandler(this.CHM_FRM_DroitsAcces_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_groups;
        private System.Windows.Forms.Panel p_pages;
        private System.Windows.Forms.Button btn_valider;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}