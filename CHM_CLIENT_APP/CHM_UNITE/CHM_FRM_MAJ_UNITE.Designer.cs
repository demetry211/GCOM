namespace CHM_CLIENT_APP.CHM_UNITE
{
    partial class CHM_FRM_MAJ_UNITE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_MAJ_UNITE));
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entete_Formulaire_21.BackgroundImage")));
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = null;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(321, 48);
            this.entete_Formulaire_21.TabIndex = 0;
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 131);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(321, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libellé :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 3;
            // 
            // CHM_FRM_MAJ_UNITE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 183);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Name = "CHM_FRM_MAJ_UNITE";
            this.Text = "CHM_FRM_MAJ_UNITE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}