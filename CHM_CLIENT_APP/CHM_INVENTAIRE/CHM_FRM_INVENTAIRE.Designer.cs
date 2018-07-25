namespace CHM_CLIENT_APP.CHM_INVENTAIRE
{
    partial class CHM_FRM_INVENTAIRE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_FRM_INVENTAIRE));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CODE_INVENTAIRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MAGASIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DATE_OUV_INVENTAIRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UTILISATEUR_OUV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_code_barre = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_code_barre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(151, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CODE_ARTICLE";
            this.Column1.FillWeight = 34.76245F;
            this.Column1.HeaderText = "Ref.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DESIGNATION_ARTICLE";
            this.Column2.FillWeight = 230.4853F;
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QTE_INVENTAIRE";
            this.Column3.FillWeight = 34.75229F;
            this.Column3.HeaderText = "Qté";
            this.Column3.Name = "Column3";
            // 
            // txt_CODE_INVENTAIRE
            // 
            this.txt_CODE_INVENTAIRE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CODE_INVENTAIRE.BackColor = System.Drawing.Color.White;
            this.txt_CODE_INVENTAIRE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CODE_INVENTAIRE.Location = new System.Drawing.Point(112, 60);
            this.txt_CODE_INVENTAIRE.Name = "txt_CODE_INVENTAIRE";
            this.txt_CODE_INVENTAIRE.ReadOnly = true;
            this.txt_CODE_INVENTAIRE.Size = new System.Drawing.Size(125, 21);
            this.txt_CODE_INVENTAIRE.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Code Inventaire:";
            // 
            // txt_MAGASIN
            // 
            this.txt_MAGASIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MAGASIN.BackColor = System.Drawing.Color.White;
            this.txt_MAGASIN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAGASIN.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_MAGASIN.Location = new System.Drawing.Point(319, 60);
            this.txt_MAGASIN.Name = "txt_MAGASIN";
            this.txt_MAGASIN.ReadOnly = true;
            this.txt_MAGASIN.Size = new System.Drawing.Size(125, 21);
            this.txt_MAGASIN.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(257, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Magasin :";
            // 
            // txt_DATE_OUV_INVENTAIRE
            // 
            this.txt_DATE_OUV_INVENTAIRE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_DATE_OUV_INVENTAIRE.BackColor = System.Drawing.Color.White;
            this.txt_DATE_OUV_INVENTAIRE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DATE_OUV_INVENTAIRE.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_DATE_OUV_INVENTAIRE.Location = new System.Drawing.Point(796, 61);
            this.txt_DATE_OUV_INVENTAIRE.Name = "txt_DATE_OUV_INVENTAIRE";
            this.txt_DATE_OUV_INVENTAIRE.ReadOnly = true;
            this.txt_DATE_OUV_INVENTAIRE.Size = new System.Drawing.Size(125, 21);
            this.txt_DATE_OUV_INVENTAIRE.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(698, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Date d\'ouverture :";
            // 
            // txt_UTILISATEUR_OUV
            // 
            this.txt_UTILISATEUR_OUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_UTILISATEUR_OUV.BackColor = System.Drawing.Color.White;
            this.txt_UTILISATEUR_OUV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UTILISATEUR_OUV.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_UTILISATEUR_OUV.Location = new System.Drawing.Point(546, 60);
            this.txt_UTILISATEUR_OUV.Name = "txt_UTILISATEUR_OUV";
            this.txt_UTILISATEUR_OUV.ReadOnly = true;
            this.txt_UTILISATEUR_OUV.Size = new System.Drawing.Size(125, 21);
            this.txt_UTILISATEUR_OUV.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(484, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Utilisateur :";
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(248, 89);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_recherche.Size = new System.Drawing.Size(201, 20);
            this.txt_recherche.TabIndex = 83;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(455, 92);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "F3";
            // 
            // txt_code_barre
            // 
            this.txt_code_barre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_code_barre.Location = new System.Drawing.Point(12, 464);
            this.txt_code_barre.Name = "txt_code_barre";
            this.txt_code_barre.Size = new System.Drawing.Size(133, 20);
            this.txt_code_barre.TabIndex = 83;
            this.txt_code_barre.TextChanged += new System.EventHandler(this.txt_code_barre_TextChanged);
            this.txt_code_barre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_code_barre_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_code_barre
            // 
            this.btn_code_barre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_code_barre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_code_barre.Image = global::CHM_CLIENT_APP.Properties.Resources.barcode_id_icone_7345_48;
            this.btn_code_barre.Location = new System.Drawing.Point(12, 404);
            this.btn_code_barre.Name = "btn_code_barre";
            this.btn_code_barre.Size = new System.Drawing.Size(133, 60);
            this.btn_code_barre.TabIndex = 96;
            this.btn_code_barre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_code_barre.UseVisualStyleBackColor = true;
            this.btn_code_barre.Click += new System.EventHandler(this.btn_code_barre_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.Fichier_Commande;
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 60);
            this.button1.TabIndex = 97;
            this.button1.Text = "Cloturer l\'inventaire";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(148, 91);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 98;
            this.label6.Text = "Recherche :";
            // 
            // button2
            // 
            this.button2.Image = global::CHM_CLIENT_APP.Properties.Resources.printer;
            this.button2.Location = new System.Drawing.Point(12, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 60);
            this.button2.TabIndex = 97;
            this.button2.Text = "Imprimer l\'Inventaire";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources._3_presse_papiers_icone_7006_64;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(933, 48);
            this.entete_Formulaire_21.TabIndex = 99;
            // 
            // CHM_FRM_INVENTAIRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 495);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_code_barre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_code_barre);
            this.Controls.Add(this.txt_recherche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UTILISATEUR_OUV);
            this.Controls.Add(this.txt_DATE_OUV_INVENTAIRE);
            this.Controls.Add(this.txt_MAGASIN);
            this.Controls.Add(this.txt_CODE_INVENTAIRE);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_FRM_INVENTAIRE";
            this.Text = "Inventaire";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_FRM_INVENTAIRE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_CODE_INVENTAIRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MAGASIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DATE_OUV_INVENTAIRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UTILISATEUR_OUV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_code_barre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_code_barre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}