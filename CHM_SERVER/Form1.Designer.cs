namespace CHM_SERVER
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_demarrer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SERVER_IP_ADDRESS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NOM_MACHINE_SERVER = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.LOGINPANEL = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.LOGINPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "communications_2.png");
            this.imageList1.Images.SetKeyName(1, "communications-category.png");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(458, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::CHM_SERVER.Properties.Resources.modem;
            this.button3.Location = new System.Drawing.Point(213, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 105);
            this.button3.TabIndex = 1;
            this.button3.Text = "&Arrèter";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CHM_SERVER.Properties.Resources.communications_category;
            this.pictureBox2.Location = new System.Drawing.Point(460, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 73);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CHM_SERVER.Properties.Resources.communications_2;
            this.pictureBox1.Location = new System.Drawing.Point(460, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::CHM_SERVER.Properties.Resources.workstation_computer;
            this.button2.Location = new System.Drawing.Point(384, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "Server Info";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::CHM_SERVER.Properties.Resources.network;
            this.button1.Location = new System.Drawing.Point(38, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Machines connectées";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_demarrer
            // 
            this.btn_demarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_demarrer.Image = global::CHM_SERVER.Properties.Resources.communications;
            this.btn_demarrer.Location = new System.Drawing.Point(213, 160);
            this.btn_demarrer.Name = "btn_demarrer";
            this.btn_demarrer.Size = new System.Drawing.Size(119, 105);
            this.btn_demarrer.TabIndex = 0;
            this.btn_demarrer.Text = "&Démarrer";
            this.btn_demarrer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_demarrer.UseVisualStyleBackColor = true;
            this.btn_demarrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CHM_SERVER.Properties.Resources.interface_interne_clients;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SERVER_IP_ADDRESS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NOM_MACHINE_SERVER);
            this.panel1.Controls.Add(this.BTN_OK);
            this.panel1.Location = new System.Drawing.Point(107, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 142);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // SERVER_IP_ADDRESS
            // 
            this.SERVER_IP_ADDRESS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SERVER_IP_ADDRESS.Location = new System.Drawing.Point(141, 42);
            this.SERVER_IP_ADDRESS.Name = "SERVER_IP_ADDRESS";
            this.SERVER_IP_ADDRESS.Size = new System.Drawing.Size(149, 20);
            this.SERVER_IP_ADDRESS.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresse IP :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de machine :";
            // 
            // NOM_MACHINE_SERVER
            // 
            this.NOM_MACHINE_SERVER.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.NOM_MACHINE_SERVER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_MACHINE_SERVER.Location = new System.Drawing.Point(141, 15);
            this.NOM_MACHINE_SERVER.Name = "NOM_MACHINE_SERVER";
            this.NOM_MACHINE_SERVER.Size = new System.Drawing.Size(149, 20);
            this.NOM_MACHINE_SERVER.TabIndex = 3;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_OK.Location = new System.Drawing.Point(112, 81);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(111, 42);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "&Close";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // LOGINPANEL
            // 
            this.LOGINPANEL.BackColor = System.Drawing.Color.Transparent;
            this.LOGINPANEL.BackgroundImage = global::CHM_SERVER.Properties.Resources.interface_interne_clients;
            this.LOGINPANEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOGINPANEL.Controls.Add(this.textBox1);
            this.LOGINPANEL.Controls.Add(this.label5);
            this.LOGINPANEL.Controls.Add(this.label4);
            this.LOGINPANEL.Controls.Add(this.LOGIN);
            this.LOGINPANEL.Location = new System.Drawing.Point(128, 213);
            this.LOGINPANEL.Name = "LOGINPANEL";
            this.LOGINPANEL.Size = new System.Drawing.Size(288, 75);
            this.LOGINPANEL.TabIndex = 8;
            this.LOGINPANEL.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Login :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mot de passe  :";
            // 
            // LOGIN
            // 
            this.LOGIN.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.LOGIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LOGIN.Location = new System.Drawing.Point(115, 12);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(143, 20);
            this.LOGIN.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = global::CHM_SERVER.Properties.Resources.Database;
            this.button4.Location = new System.Drawing.Point(207, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "DataBase connection Configuration";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_SERVER.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 419);
            this.Controls.Add(this.LOGINPANEL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_demarrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHM Server application v 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LOGINPANEL.ResumeLayout(false);
            this.LOGINPANEL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button btn_demarrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NOM_MACHINE_SERVER;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SERVER_IP_ADDRESS;
        private System.Windows.Forms.Panel LOGINPANEL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LOGIN;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

