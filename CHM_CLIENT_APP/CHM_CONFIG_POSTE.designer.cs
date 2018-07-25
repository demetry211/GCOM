namespace CHM_CLIENT_APP
{
    partial class CHM_CONFIG_POSTE
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbx_entete = new System.Windows.Forms.CheckBox();
            this.cbx_InvoiceOption = new System.Windows.Forms.ComboBox();
            this.cbx_magazin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_data_bit = new System.Windows.Forms.TextBox();
            this.txt_baudrate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_parity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_port_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Ticket_Printer = new System.Windows.Forms.ComboBox();
            this.txt_Report_Printer = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_annuler.Location = new System.Drawing.Point(256, 201);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_valider.Location = new System.Drawing.Point(149, 201);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "Enregistrer";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 186);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Report_Printer);
            this.tabPage1.Controls.Add(this.txt_Ticket_Printer);
            this.tabPage1.Controls.Add(this.chbx_entete);
            this.tabPage1.Controls.Add(this.cbx_InvoiceOption);
            this.tabPage1.Controls.Add(this.cbx_magazin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Impression";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chbx_entete
            // 
            this.chbx_entete.AutoSize = true;
            this.chbx_entete.Location = new System.Drawing.Point(20, 123);
            this.chbx_entete.Name = "chbx_entete";
            this.chbx_entete.Size = new System.Drawing.Size(138, 17);
            this.chbx_entete.TabIndex = 17;
            this.chbx_entete.Text = "Impression Avec Entete";
            this.chbx_entete.UseVisualStyleBackColor = true;
            // 
            // cbx_InvoiceOption
            // 
            this.cbx_InvoiceOption.FormattingEnabled = true;
            this.cbx_InvoiceOption.Items.AddRange(new object[] {
            "Ticket",
            "Report"});
            this.cbx_InvoiceOption.Location = new System.Drawing.Point(142, 40);
            this.cbx_InvoiceOption.Name = "cbx_InvoiceOption";
            this.cbx_InvoiceOption.Size = new System.Drawing.Size(222, 21);
            this.cbx_InvoiceOption.TabIndex = 13;
            // 
            // cbx_magazin
            // 
            this.cbx_magazin.FormattingEnabled = true;
            this.cbx_magazin.Location = new System.Drawing.Point(142, 15);
            this.cbx_magazin.Name = "cbx_magazin";
            this.cbx_magazin.Size = new System.Drawing.Size(222, 21);
            this.cbx_magazin.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imprimante de rapport :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imprimante de Tickets :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type d\'impression :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Magasin :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_data_bit);
            this.tabPage2.Controls.Add(this.txt_baudrate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_parity);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_port_name);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ecran de caisse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_data_bit
            // 
            this.txt_data_bit.Location = new System.Drawing.Point(85, 93);
            this.txt_data_bit.Name = "txt_data_bit";
            this.txt_data_bit.Size = new System.Drawing.Size(365, 20);
            this.txt_data_bit.TabIndex = 18;
            // 
            // txt_baudrate
            // 
            this.txt_baudrate.Location = new System.Drawing.Point(85, 67);
            this.txt_baudrate.Name = "txt_baudrate";
            this.txt_baudrate.Size = new System.Drawing.Size(365, 20);
            this.txt_baudrate.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(16, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "DataBits :";
            // 
            // txt_parity
            // 
            this.txt_parity.Location = new System.Drawing.Point(85, 41);
            this.txt_parity.Name = "txt_parity";
            this.txt_parity.Size = new System.Drawing.Size(365, 20);
            this.txt_parity.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "BaudRate :";
            // 
            // txt_port_name
            // 
            this.txt_port_name.Location = new System.Drawing.Point(85, 15);
            this.txt_port_name.Name = "txt_port_name";
            this.txt_port_name.Size = new System.Drawing.Size(365, 20);
            this.txt_port_name.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Parity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Port Name :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(465, 160);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tiroir à caisse";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(14, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "DataBits :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 20);
            this.textBox3.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(14, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "BaudRate :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(330, 20);
            this.textBox4.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(14, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Parity :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(14, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Port Name :";
            // 
            // txt_Ticket_Printer
            // 
            this.txt_Ticket_Printer.FormattingEnabled = true;
            this.txt_Ticket_Printer.Location = new System.Drawing.Point(142, 65);
            this.txt_Ticket_Printer.Name = "txt_Ticket_Printer";
            this.txt_Ticket_Printer.Size = new System.Drawing.Size(302, 21);
            this.txt_Ticket_Printer.TabIndex = 18;
            // 
            // txt_Report_Printer
            // 
            this.txt_Report_Printer.FormattingEnabled = true;
            this.txt_Report_Printer.Location = new System.Drawing.Point(142, 89);
            this.txt_Report_Printer.Name = "txt_Report_Printer";
            this.txt_Report_Printer.Size = new System.Drawing.Size(302, 21);
            this.txt_Report_Printer.TabIndex = 18;
            // 
            // CHM_CONFIG_POSTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 236);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_CONFIG_POSTE";
            this.Text = "Configuration de la poste";
            this.Load += new System.EventHandler(this.CHM_CONFIG_POSTE_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbx_InvoiceOption;
        private System.Windows.Forms.ComboBox cbx_magazin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_data_bit;
        private System.Windows.Forms.TextBox txt_baudrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_parity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_port_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chbx_entete;
        private System.Windows.Forms.ComboBox txt_Report_Printer;
        private System.Windows.Forms.ComboBox txt_Ticket_Printer;
    }
}