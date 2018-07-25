namespace CHM_CLIENT_APP
{
    partial class APPLICATION_TACTILE
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
            this.button1 = new System.Windows.Forms.Button();
            this.p_Liste_Categorie = new System.Windows.Forms.Panel();
            this.p_Liste_Article = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.NOM_FENETRE = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.template_Liste_Facture_Ouverte1 = new CHM_CLIENT_APP.CHM_APPLICATION_TACTILE.Template_Liste_Facture_Ouverte();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(-107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selection des produits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_Liste_Categorie
            // 
            this.p_Liste_Categorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Liste_Categorie.BackColor = System.Drawing.Color.Transparent;
            this.p_Liste_Categorie.Location = new System.Drawing.Point(825, 70);
            this.p_Liste_Categorie.Name = "p_Liste_Categorie";
            this.p_Liste_Categorie.Size = new System.Drawing.Size(190, 609);
            this.p_Liste_Categorie.TabIndex = 1;
            // 
            // p_Liste_Article
            // 
            this.p_Liste_Article.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Liste_Article.BackColor = System.Drawing.Color.Transparent;
            this.p_Liste_Article.Location = new System.Drawing.Point(629, 70);
            this.p_Liste_Article.Name = "p_Liste_Article";
            this.p_Liste_Article.Size = new System.Drawing.Size(190, 609);
            this.p_Liste_Article.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.NOM_FENETRE);
            this.groupBox1.Location = new System.Drawing.Point(-2, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(4, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 37);
            this.button8.TabIndex = 83;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // NOM_FENETRE
            // 
            this.NOM_FENETRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NOM_FENETRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_FENETRE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NOM_FENETRE.Location = new System.Drawing.Point(48, 16);
            this.NOM_FENETRE.Name = "NOM_FENETRE";
            this.NOM_FENETRE.Size = new System.Drawing.Size(971, 29);
            this.NOM_FENETRE.TabIndex = 2;
            this.NOM_FENETRE.Text = "شاشة المبيعات";
            this.NOM_FENETRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 572);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(457, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 82);
            this.button7.TabIndex = 0;
            this.button7.Text = "button2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 82);
            this.button4.TabIndex = 0;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(368, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 82);
            this.button6.TabIndex = 0;
            this.button6.Text = "button2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 82);
            this.button3.TabIndex = 0;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 82);
            this.button5.TabIndex = 0;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 82);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // template_Liste_Facture_Ouverte1
            // 
            this.template_Liste_Facture_Ouverte1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.template_Liste_Facture_Ouverte1.Location = new System.Drawing.Point(13, 67);
            this.template_Liste_Facture_Ouverte1.Name = "template_Liste_Facture_Ouverte1";
            this.template_Liste_Facture_Ouverte1.Size = new System.Drawing.Size(606, 503);
            this.template_Liste_Facture_Ouverte1.TabIndex = 7;
            this.template_Liste_Facture_Ouverte1.Load += new System.EventHandler(this.template_Liste_Facture_Ouverte1_Load);
            // 
            // APPLICATION_TACTILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 691);
            this.Controls.Add(this.template_Liste_Facture_Ouverte1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.p_Liste_Article);
            this.Controls.Add(this.p_Liste_Categorie);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "APPLICATION_TACTILE";
            this.Text = "APPLICATION_TACTILE";
            this.Load += new System.EventHandler(this.APPLICATION_TACTILE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel p_Liste_Categorie;
        private System.Windows.Forms.Panel p_Liste_Article;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NOM_FENETRE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private CHM_CLIENT_APP.CHM_APPLICATION_TACTILE.Template_Liste_Facture_Ouverte template_Liste_Facture_Ouverte1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;

    }
}