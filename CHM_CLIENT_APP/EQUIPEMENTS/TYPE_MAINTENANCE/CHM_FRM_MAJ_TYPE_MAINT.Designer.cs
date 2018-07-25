namespace CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE
{
    partial class CHM_FRM_MAJ_TYPE_MAINT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_MAJ_TYPE_MAINT));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_UNITE = new System.Windows.Forms.ComboBox();
            this.txt_LIB_TYPE_MAINT = new System.Windows.Forms.TextBox();
            this.chM_CMP_VALIDATION1 = new CHM_STYLE.STYLE.CHM_CMP_VALIDATION();
            this.txt_VAL_MAINT = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NB_JOUR = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CODE_TYPE_MAINT = new System.Windows.Forms.TextBox();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_VAL_MAINT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NB_JOUR.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé :";
            // 
            // cbx_UNITE
            // 
            this.cbx_UNITE.FormattingEnabled = true;
            this.cbx_UNITE.Location = new System.Drawing.Point(93, 113);
            this.cbx_UNITE.Name = "cbx_UNITE";
            this.cbx_UNITE.Size = new System.Drawing.Size(125, 21);
            this.cbx_UNITE.TabIndex = 1;
            // 
            // txt_LIB_TYPE_MAINT
            // 
            this.txt_LIB_TYPE_MAINT.Location = new System.Drawing.Point(93, 87);
            this.txt_LIB_TYPE_MAINT.Name = "txt_LIB_TYPE_MAINT";
            this.txt_LIB_TYPE_MAINT.Size = new System.Drawing.Size(163, 20);
            this.txt_LIB_TYPE_MAINT.TabIndex = 0;
            // 
            // chM_CMP_VALIDATION1
            // 
            this.chM_CMP_VALIDATION1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chM_CMP_VALIDATION1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chM_CMP_VALIDATION1.Location = new System.Drawing.Point(0, 202);
            this.chM_CMP_VALIDATION1.Name = "chM_CMP_VALIDATION1";
            this.chM_CMP_VALIDATION1.Size = new System.Drawing.Size(283, 52);
            this.chM_CMP_VALIDATION1.TabIndex = 4;
            // 
            // txt_VAL_MAINT
            // 
            this.txt_VAL_MAINT.EditValue = "0.000";
            this.txt_VAL_MAINT.Location = new System.Drawing.Point(146, 139);
            this.txt_VAL_MAINT.Name = "txt_VAL_MAINT";
            this.txt_VAL_MAINT.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_VAL_MAINT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_VAL_MAINT.Properties.DisplayFormat.FormatString = "N3";
            this.txt_VAL_MAINT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_VAL_MAINT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_VAL_MAINT.Size = new System.Drawing.Size(110, 20);
            this.txt_VAL_MAINT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valeur Maintenance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nbr Jour :";
            // 
            // txt_NB_JOUR
            // 
            this.txt_NB_JOUR.EditValue = "0";
            this.txt_NB_JOUR.Location = new System.Drawing.Point(146, 165);
            this.txt_NB_JOUR.Name = "txt_NB_JOUR";
            this.txt_NB_JOUR.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_NB_JOUR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_NB_JOUR.Properties.DisplayFormat.FormatString = "N0";
            this.txt_NB_JOUR.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_NB_JOUR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_NB_JOUR.Size = new System.Drawing.Size(110, 20);
            this.txt_NB_JOUR.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code :";
            // 
            // txt_CODE_TYPE_MAINT
            // 
            this.txt_CODE_TYPE_MAINT.Enabled = false;
            this.txt_CODE_TYPE_MAINT.Location = new System.Drawing.Point(93, 61);
            this.txt_CODE_TYPE_MAINT.Name = "txt_CODE_TYPE_MAINT";
            this.txt_CODE_TYPE_MAINT.Size = new System.Drawing.Size(47, 20);
            this.txt_CODE_TYPE_MAINT.TabIndex = 2;
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
            this.entete_Formulaire_21.Size = new System.Drawing.Size(283, 48);
            this.entete_Formulaire_21.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHM_FRM_MAJ_TYPE_MAINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NB_JOUR);
            this.Controls.Add(this.txt_VAL_MAINT);
            this.Controls.Add(this.chM_CMP_VALIDATION1);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.txt_CODE_TYPE_MAINT);
            this.Controls.Add(this.txt_LIB_TYPE_MAINT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_UNITE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "CHM_FRM_MAJ_TYPE_MAINT";
            this.Text = "CHM_FRM_MAJ_TYPE_MAINT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CHM_FRM_MAJ_TYPE_MAINT_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txt_VAL_MAINT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NB_JOUR.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_UNITE;
        private System.Windows.Forms.TextBox txt_LIB_TYPE_MAINT;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
        private CHM_STYLE.STYLE.CHM_CMP_VALIDATION chM_CMP_VALIDATION1;
        private DevExpress.XtraEditors.TextEdit txt_VAL_MAINT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_NB_JOUR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CODE_TYPE_MAINT;
        private System.Windows.Forms.Button button1;
    }
}