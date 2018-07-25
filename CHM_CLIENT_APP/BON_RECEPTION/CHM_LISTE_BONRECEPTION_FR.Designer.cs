namespace CHM_CLIENT_APP.BON_RECEPTION
{
    partial class CHM_LISTE_BONRECEPTION_FR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_LISTE_BONRECEPTION_FR));
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this._CODE_BR_FR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RS_FOURNISSEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NOM_MAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DATE_BR_FR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._MNT_BR_FR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RESTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NP = new LABEL_NUM.LabelNumerique();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbn_total = new LABEL_NUM.LabelNumerique();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_liste
            // 
            this.dgv_liste.AllowUserToAddRows = false;
            this.dgv_liste.AllowUserToDeleteRows = false;
            this.dgv_liste.AllowUserToResizeRows = false;
            this.dgv_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._CODE_BR_FR,
            this._RS_FOURNISSEUR,
            this._NOM_MAG,
            this._DATE_BR_FR,
            this._MNT_BR_FR,
            this._RESTE,
            this._USERNAME});
            this.dgv_liste.Location = new System.Drawing.Point(150, 57);
            this.dgv_liste.MultiSelect = false;
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.Size = new System.Drawing.Size(650, 370);
            this.dgv_liste.TabIndex = 0;
            // 
            // _CODE_BR_FR
            // 
            this._CODE_BR_FR.DataPropertyName = "CODE_BR_FR";
            this._CODE_BR_FR.HeaderText = "B.R N°";
            this._CODE_BR_FR.Name = "_CODE_BR_FR";
            this._CODE_BR_FR.ReadOnly = true;
            // 
            // _RS_FOURNISSEUR
            // 
            this._RS_FOURNISSEUR.DataPropertyName = "RS_FOURNISSEUR";
            this._RS_FOURNISSEUR.HeaderText = "Fournisseur";
            this._RS_FOURNISSEUR.Name = "_RS_FOURNISSEUR";
            this._RS_FOURNISSEUR.ReadOnly = true;
            // 
            // _NOM_MAG
            // 
            this._NOM_MAG.DataPropertyName = "NOM_MAG";
            this._NOM_MAG.HeaderText = "Magasin";
            this._NOM_MAG.Name = "_NOM_MAG";
            this._NOM_MAG.ReadOnly = true;
            // 
            // _DATE_BR_FR
            // 
            this._DATE_BR_FR.DataPropertyName = "DATE_BR_FR";
            this._DATE_BR_FR.HeaderText = "Date réception";
            this._DATE_BR_FR.Name = "_DATE_BR_FR";
            this._DATE_BR_FR.ReadOnly = true;
            // 
            // _MNT_BR_FR
            // 
            this._MNT_BR_FR.DataPropertyName = "MNT_BR_FR";
            this._MNT_BR_FR.HeaderText = "Montant Total";
            this._MNT_BR_FR.Name = "_MNT_BR_FR";
            this._MNT_BR_FR.ReadOnly = true;
            // 
            // _RESTE
            // 
            this._RESTE.DataPropertyName = "RESTE";
            this._RESTE.HeaderText = "Reste non payé";
            this._RESTE.Name = "_RESTE";
            this._RESTE.ReadOnly = true;
            // 
            // _USERNAME
            // 
            this._USERNAME.DataPropertyName = "USERNAME";
            this._USERNAME.HeaderText = "Utilisater";
            this._USERNAME.Name = "_USERNAME";
            this._USERNAME.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Image = global::CHM_CLIENT_APP.Properties.Resources.ajouter_icone_5107_321;
            this.button1.Location = new System.Drawing.Point(9, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::CHM_CLIENT_APP.Properties.Resources.filefind_icone_7697_48;
            this.button2.Location = new System.Drawing.Point(9, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Aperçu";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NP
            // 
            this.NP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NP.BackColor = System.Drawing.Color.Silver;
            this.NP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NP.Clinote = true;
            this.NP.Couleur1 = System.Drawing.Color.Gray;
            this.NP.Couleur2 = System.Drawing.Color.OrangeRed;
            this.NP.DecimalPlaces = 3;
            this.NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NP.ForeColor = System.Drawing.Color.OrangeRed;
            this.NP.Location = new System.Drawing.Point(632, 433);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(168, 28);
            this.NP.TabIndex = 88;
            this.NP.Text = "0.000";
            this.NP.ThousandsSeparator = true;
            this.NP.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(492, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 14);
            this.label7.TabIndex = 87;
            this.label7.Text = "Total BR Non payés :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(164, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 87;
            this.label1.Text = "Total BR :";
            // 
            // lbn_total
            // 
            this.lbn_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbn_total.BackColor = System.Drawing.Color.Silver;
            this.lbn_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbn_total.Clinote = true;
            this.lbn_total.Couleur1 = System.Drawing.Color.Black;
            this.lbn_total.Couleur2 = System.Drawing.Color.Black;
            this.lbn_total.DecimalPlaces = 3;
            this.lbn_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_total.ForeColor = System.Drawing.Color.Black;
            this.lbn_total.Location = new System.Drawing.Point(237, 433);
            this.lbn_total.Name = "lbn_total";
            this.lbn_total.Size = new System.Drawing.Size(204, 28);
            this.lbn_total.TabIndex = 88;
            this.lbn_total.Text = "0.000";
            this.lbn_total.ThousandsSeparator = true;
            this.lbn_total.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // btn_modifier
            // 
            this.btn_modifier.Image = global::CHM_CLIENT_APP.Properties.Resources.arrow_tourner_vers_la_droite_icone_8357_32;
            this.btn_modifier.Location = new System.Drawing.Point(9, 244);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(132, 54);
            this.btn_modifier.TabIndex = 1;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Visible = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.btn_annuler.Location = new System.Drawing.Point(9, 184);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(132, 54);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Annuler le B.R.";
            this.btn_annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click_1);
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.BLFrn;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(812, 48);
            this.entete_Formulaire_21.TabIndex = 89;
            // 
            // CHM_LISTE_BONRECEPTION_FR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 473);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.lbn_total);
            this.Controls.Add(this.NP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_liste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_LISTE_BONRECEPTION_FR";
            this.Text = "Liste des Bons de Réception";
            this.Load += new System.EventHandler(this.CHM_LISTE_BONRECEPTION_FR_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHM_LISTE_BONRECEPTION_FR_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private LABEL_NUM.LabelNumerique NP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private LABEL_NUM.LabelNumerique lbn_total;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODE_BR_FR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RS_FOURNISSEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NOM_MAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DATE_BR_FR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _MNT_BR_FR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RESTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _USERNAME;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}