namespace CHM_CLIENT_APP
{
    partial class CHM_SUIVI_REGLEMENT_CLIENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHM_SUIVI_REGLEMENT_CLIENT));
            this.dgv_Liste_reglement = new System.Windows.Forms.DataGridView();
            this.CODE_REGLEMENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_REGLMENT_CLT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_FACTURE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODE_REGLEMENT_CLT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_REG_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_PIECE_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANQUE_CLIENT_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_REG = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.REF_CLIENT = new System.Windows.Forms.TextBox();
            this.RS_CLIENT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entete_Formulaire_21 = new CHM_STYLE.Entete_Formulaire_2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_reglement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Liste_reglement
            // 
            this.dgv_Liste_reglement.AllowUserToAddRows = false;
            this.dgv_Liste_reglement.AllowUserToDeleteRows = false;
            this.dgv_Liste_reglement.AllowUserToResizeColumns = false;
            this.dgv_Liste_reglement.AllowUserToResizeRows = false;
            this.dgv_Liste_reglement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Liste_reglement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Liste_reglement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Liste_reglement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste_reglement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_REGLEMENT_,
            this.DATE_REGLMENT_CLT_,
            this.CODE_FACTURE_,
            this.MODE_REGLEMENT_CLT_,
            this.MONTANT_REG_CLIENT_,
            this.NUM_PIECE_CLIENT_,
            this.BANQUE_CLIENT_});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Liste_reglement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Liste_reglement.Location = new System.Drawing.Point(12, 113);
            this.dgv_Liste_reglement.MultiSelect = false;
            this.dgv_Liste_reglement.Name = "dgv_Liste_reglement";
            this.dgv_Liste_reglement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Liste_reglement.Size = new System.Drawing.Size(699, 269);
            this.dgv_Liste_reglement.TabIndex = 35;
            // 
            // CODE_REGLEMENT_
            // 
            this.CODE_REGLEMENT_.DataPropertyName = "CODE_REGLEMENT_CLIENT";
            this.CODE_REGLEMENT_.FillWeight = 98.82621F;
            this.CODE_REGLEMENT_.HeaderText = "Code règlement";
            this.CODE_REGLEMENT_.Name = "CODE_REGLEMENT_";
            this.CODE_REGLEMENT_.ReadOnly = true;
            // 
            // DATE_REGLMENT_CLT_
            // 
            this.DATE_REGLMENT_CLT_.DataPropertyName = "DATE_REG_CLT";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DATE_REGLMENT_CLT_.DefaultCellStyle = dataGridViewCellStyle2;
            this.DATE_REGLMENT_CLT_.FillWeight = 102.4026F;
            this.DATE_REGLMENT_CLT_.HeaderText = "Date Réglement";
            this.DATE_REGLMENT_CLT_.Name = "DATE_REGLMENT_CLT_";
            this.DATE_REGLMENT_CLT_.ReadOnly = true;
            // 
            // CODE_FACTURE_
            // 
            this.CODE_FACTURE_.DataPropertyName = "CODE_FACTURE";
            this.CODE_FACTURE_.FillWeight = 172.4616F;
            this.CODE_FACTURE_.HeaderText = "N° Facture";
            this.CODE_FACTURE_.Name = "CODE_FACTURE_";
            // 
            // MODE_REGLEMENT_CLT_
            // 
            this.MODE_REGLEMENT_CLT_.DataPropertyName = "MODE_REGLEMENT_CLT";
            this.MODE_REGLEMENT_CLT_.FillWeight = 102.2778F;
            this.MODE_REGLEMENT_CLT_.HeaderText = "Type Pièce";
            this.MODE_REGLEMENT_CLT_.Name = "MODE_REGLEMENT_CLT_";
            this.MODE_REGLEMENT_CLT_.ReadOnly = true;
            this.MODE_REGLEMENT_CLT_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MONTANT_REG_CLIENT_
            // 
            this.MONTANT_REG_CLIENT_.DataPropertyName = "MONTANT_REG_CLIENT";
            this.MONTANT_REG_CLIENT_.FillWeight = 94.38022F;
            this.MONTANT_REG_CLIENT_.HeaderText = "Montant";
            this.MONTANT_REG_CLIENT_.Name = "MONTANT_REG_CLIENT_";
            // 
            // NUM_PIECE_CLIENT_
            // 
            this.NUM_PIECE_CLIENT_.DataPropertyName = "NUM_PIECE_CLIENT";
            this.NUM_PIECE_CLIENT_.FillWeight = 114.1768F;
            this.NUM_PIECE_CLIENT_.HeaderText = "N° Pièce";
            this.NUM_PIECE_CLIENT_.Name = "NUM_PIECE_CLIENT_";
            // 
            // BANQUE_CLIENT_
            // 
            this.BANQUE_CLIENT_.DataPropertyName = "BANQUE_CLIENT";
            this.BANQUE_CLIENT_.FillWeight = 90.7115F;
            this.BANQUE_CLIENT_.HeaderText = "Banque";
            this.BANQUE_CLIENT_.Name = "BANQUE_CLIENT_";
            this.BANQUE_CLIENT_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DATE_REG
            // 
            this.DATE_REG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DATE_REG.FormattingEnabled = true;
            this.DATE_REG.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Decembre"});
            this.DATE_REG.Location = new System.Drawing.Point(601, 57);
            this.DATE_REG.Name = "DATE_REG";
            this.DATE_REG.Size = new System.Drawing.Size(110, 21);
            this.DATE_REG.TabIndex = 36;
            this.DATE_REG.Visible = false;
            this.DATE_REG.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(457, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Règlement pour le mois de :";
            this.label1.Visible = false;
            // 
            // REF_CLIENT
            // 
            this.REF_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.REF_CLIENT.BackColor = System.Drawing.Color.White;
            this.REF_CLIENT.Location = new System.Drawing.Point(78, 57);
            this.REF_CLIENT.Name = "REF_CLIENT";
            this.REF_CLIENT.ReadOnly = true;
            this.REF_CLIENT.Size = new System.Drawing.Size(117, 20);
            this.REF_CLIENT.TabIndex = 38;
            // 
            // RS_CLIENT
            // 
            this.RS_CLIENT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RS_CLIENT.BackColor = System.Drawing.Color.White;
            this.RS_CLIENT.Location = new System.Drawing.Point(267, 57);
            this.RS_CLIENT.Name = "RS_CLIENT";
            this.RS_CLIENT.ReadOnly = true;
            this.RS_CLIENT.Size = new System.Drawing.Size(169, 20);
            this.RS_CLIENT.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ref. Client :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(222, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Client :";
            // 
            // entete_Formulaire_21
            // 
            this.entete_Formulaire_21.BackColor = System.Drawing.Color.Silver;
            this.entete_Formulaire_21.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.entete_Formulaire_21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entete_Formulaire_21.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete_Formulaire_21.Icone = global::CHM_CLIENT_APP.Properties.Resources.daffaires_monnaies_dolar_metal_argent_paiement_icone_3854_481;
            this.entete_Formulaire_21.Location = new System.Drawing.Point(0, 0);
            this.entete_Formulaire_21.Name = "entete_Formulaire_21";
            this.entete_Formulaire_21.Size = new System.Drawing.Size(723, 48);
            this.entete_Formulaire_21.TabIndex = 42;
            // 
            // CHM_SUIVI_REGLEMENT_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 394);
            this.Controls.Add(this.entete_Formulaire_21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RS_CLIENT);
            this.Controls.Add(this.REF_CLIENT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DATE_REG);
            this.Controls.Add(this.dgv_Liste_reglement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CHM_SUIVI_REGLEMENT_CLIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détails des règlements";
            this.Shown += new System.EventHandler(this.CHM_SUIVI_REGLEMENT_CLIENT_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste_reglement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Liste_reglement;
        private System.Windows.Forms.ComboBox DATE_REG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox REF_CLIENT;
        private System.Windows.Forms.TextBox RS_CLIENT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_REGLEMENT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_REGLMENT_CLT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FACTURE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODE_REGLEMENT_CLT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_REG_CLIENT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_PIECE_CLIENT_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANQUE_CLIENT_;
        private CHM_STYLE.Entete_Formulaire_2 entete_Formulaire_21;
    }
}