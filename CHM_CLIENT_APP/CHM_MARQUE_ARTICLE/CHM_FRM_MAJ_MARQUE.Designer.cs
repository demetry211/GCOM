namespace CHM_CLIENT_APP.CHM_MARQUE_ARTICLE
{
    partial class CHM_FRM_MAJ_MARQUE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_MAJ_MARQUE));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_REF_MARQUE = new System.Windows.Forms.TextBox();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DESIGNATION_MARQUE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DESCRIPTION_MARQUE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence :";
            // 
            // txt_REF_MARQUE
            // 
            this.txt_REF_MARQUE.Location = new System.Drawing.Point(81, 63);
            this.txt_REF_MARQUE.Name = "txt_REF_MARQUE";
            this.txt_REF_MARQUE.Size = new System.Drawing.Size(144, 20);
            this.txt_REF_MARQUE.TabIndex = 0;
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entete_Formulaire_21.BackgroundImage")));
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.marque32;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(351, 48);
            this.entete_Formulaire_21.TabIndex = 4;
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 207);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(351, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Désignation :";
            // 
            // txt_DESIGNATION_MARQUE
            // 
            this.txt_DESIGNATION_MARQUE.Location = new System.Drawing.Point(81, 89);
            this.txt_DESIGNATION_MARQUE.Name = "txt_DESIGNATION_MARQUE";
            this.txt_DESIGNATION_MARQUE.Size = new System.Drawing.Size(253, 20);
            this.txt_DESIGNATION_MARQUE.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description :";
            // 
            // txt_DESCRIPTION_MARQUE
            // 
            this.txt_DESCRIPTION_MARQUE.Location = new System.Drawing.Point(81, 115);
            this.txt_DESCRIPTION_MARQUE.Multiline = true;
            this.txt_DESCRIPTION_MARQUE.Name = "txt_DESCRIPTION_MARQUE";
            this.txt_DESCRIPTION_MARQUE.Size = new System.Drawing.Size(253, 78);
            this.txt_DESCRIPTION_MARQUE.TabIndex = 2;
            // 
            // CHM_FRM_MAJ_MARQUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 259);
            this.ControlBox = false;
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.txt_DESCRIPTION_MARQUE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DESIGNATION_MARQUE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_REF_MARQUE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CHM_FRM_MAJ_MARQUE";
            this.Text = "CHM_FRM_MAJ_MARQUE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_MAJ_MARQUE_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_REF_MARQUE;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DESIGNATION_MARQUE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DESCRIPTION_MARQUE;
    }
}