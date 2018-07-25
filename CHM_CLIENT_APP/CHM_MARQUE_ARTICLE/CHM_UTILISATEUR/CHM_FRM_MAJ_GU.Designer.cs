namespace CHM_CLIENT_APP.CHM_UTILISATEUR
{
    partial class CHM_FRM_MAJ_GU
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
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LIB_GROUPE = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_vente = new System.Windows.Forms.RadioButton();
            this.r_achat = new System.Windows.Forms.RadioButton();
            this.r_gestion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 197);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(374, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Désignation :";
            // 
            // txt_LIB_GROUPE
            // 
            this.txt_LIB_GROUPE.Location = new System.Drawing.Point(106, 71);
            this.txt_LIB_GROUPE.Name = "txt_LIB_GROUPE";
            this.txt_LIB_GROUPE.Size = new System.Drawing.Size(208, 20);
            this.txt_LIB_GROUPE.TabIndex = 3;
            this.txt_LIB_GROUPE.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LIB_GROUPE_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(106, 97);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(208, 20);
            this.txt_description.TabIndex = 3;
            this.txt_description.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LIB_GROUPE_Validating);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(374, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.r_vente);
            this.groupBox1.Controls.Add(this.r_achat);
            this.groupBox1.Controls.Add(this.r_gestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type Utilisateur :";
            // 
            // r_vente
            // 
            this.r_vente.AutoSize = true;
            this.r_vente.Location = new System.Drawing.Point(250, 21);
            this.r_vente.Name = "r_vente";
            this.r_vente.Size = new System.Drawing.Size(53, 17);
            this.r_vente.TabIndex = 0;
            this.r_vente.TabStop = true;
            this.r_vente.Tag = "3";
            this.r_vente.Text = "Vente";
            this.r_vente.UseVisualStyleBackColor = true;
            // 
            // r_achat
            // 
            this.r_achat.AutoSize = true;
            this.r_achat.Location = new System.Drawing.Point(138, 21);
            this.r_achat.Name = "r_achat";
            this.r_achat.Size = new System.Drawing.Size(53, 17);
            this.r_achat.TabIndex = 0;
            this.r_achat.TabStop = true;
            this.r_achat.Tag = "2";
            this.r_achat.Text = "Achat";
            this.r_achat.UseVisualStyleBackColor = true;
            // 
            // r_gestion
            // 
            this.r_gestion.AutoSize = true;
            this.r_gestion.Location = new System.Drawing.Point(22, 21);
            this.r_gestion.Name = "r_gestion";
            this.r_gestion.Size = new System.Drawing.Size(61, 17);
            this.r_gestion.TabIndex = 0;
            this.r_gestion.TabStop = true;
            this.r_gestion.Tag = "1";
            this.r_gestion.Text = "Gestion";
            this.r_gestion.UseVisualStyleBackColor = true;
            // 
            // CHM_FRM_MAJ_GU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LIB_GROUPE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_MAJ_GU";
            this.Text = "Ajout de fonction utilisateur";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LIB_GROUPE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r_vente;
        private System.Windows.Forms.RadioButton r_achat;
        private System.Windows.Forms.RadioButton r_gestion;
    }
}