namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    partial class CHM_FRM_GAIN_DETAIL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_au = new System.Windows.Forms.DateTimePicker();
            this.dtp_du = new System.Windows.Forms.DateTimePicker();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.lb_gain = new LABEL_NUM.LabelNumerique();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_retour = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_vente = new LABEL_NUM.LabelNumerique();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_retour = new LABEL_NUM.LabelNumerique();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.nv_clt_titre = new System.Windows.Forms.Label();
            this._CODE_ARTICLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DESIGNATION_ARTICLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._qtte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PRIX_U_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PRIX_HT_A_ARTICLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total_g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_retour)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Au :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Du :";
            // 
            // dtp_au
            // 
            this.dtp_au.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_au.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_au.Location = new System.Drawing.Point(543, 73);
            this.dtp_au.Name = "dtp_au";
            this.dtp_au.Size = new System.Drawing.Size(114, 20);
            this.dtp_au.TabIndex = 83;
            this.dtp_au.ValueChanged += new System.EventHandler(this.dtp_au_ValueChanged);
            // 
            // dtp_du
            // 
            this.dtp_du.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_du.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_du.Location = new System.Drawing.Point(342, 71);
            this.dtp_du.Name = "dtp_du";
            this.dtp_du.Size = new System.Drawing.Size(103, 20);
            this.dtp_du.TabIndex = 84;
            this.dtp_du.ValueChanged += new System.EventHandler(this.dtp_du_ValueChanged);
            // 
            // dgv_liste
            // 
            this.dgv_liste.AllowUserToAddRows = false;
            this.dgv_liste.AllowUserToDeleteRows = false;
            this.dgv_liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_liste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._CODE_ARTICLE,
            this._DESIGNATION_ARTICLE,
            this._qtte,
            this._PRIX_U_TTC,
            this._PRIX_HT_A_ARTICLE,
            this._total_v,
            this._total_a,
            this._total_g});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_liste.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_liste.Location = new System.Drawing.Point(10, 19);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.ReadOnly = true;
            this.dgv_liste.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste.Size = new System.Drawing.Size(571, 332);
            this.dgv_liste.TabIndex = 87;
            // 
            // lb_gain
            // 
            this.lb_gain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_gain.BackColor = System.Drawing.Color.Silver;
            this.lb_gain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_gain.Clinote = true;
            this.lb_gain.Couleur1 = System.Drawing.Color.Gray;
            this.lb_gain.Couleur2 = System.Drawing.Color.Red;
            this.lb_gain.DecimalPlaces = 3;
            this.lb_gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gain.ForeColor = System.Drawing.Color.Gray;
            this.lb_gain.Location = new System.Drawing.Point(790, 469);
            this.lb_gain.Name = "lb_gain";
            this.lb_gain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_gain.Size = new System.Drawing.Size(129, 30);
            this.lb_gain.TabIndex = 89;
            this.lb_gain.Text = "0.000";
            this.lb_gain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_gain.ThousandsSeparator = true;
            this.lb_gain.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(720, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Bénifice :";
            // 
            // dgv_retour
            // 
            this.dgv_retour.AllowUserToAddRows = false;
            this.dgv_retour.AllowUserToDeleteRows = false;
            this.dgv_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_retour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_retour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_retour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_retour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_retour.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_retour.Location = new System.Drawing.Point(11, 19);
            this.dgv_retour.Name = "dgv_retour";
            this.dgv_retour.ReadOnly = true;
            this.dgv_retour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_retour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_retour.Size = new System.Drawing.Size(342, 332);
            this.dgv_retour.TabIndex = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_retour);
            this.groupBox1.Location = new System.Drawing.Point(596, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 360);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retour";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_liste);
            this.groupBox2.Location = new System.Drawing.Point(2, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 360);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Vente :";
            // 
            // lb_vente
            // 
            this.lb_vente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_vente.BackColor = System.Drawing.Color.Silver;
            this.lb_vente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_vente.Clinote = true;
            this.lb_vente.Couleur1 = System.Drawing.Color.Gray;
            this.lb_vente.Couleur2 = System.Drawing.Color.Lime;
            this.lb_vente.DecimalPlaces = 3;
            this.lb_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vente.ForeColor = System.Drawing.Color.Lime;
            this.lb_vente.Location = new System.Drawing.Point(104, 469);
            this.lb_vente.Name = "lb_vente";
            this.lb_vente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_vente.Size = new System.Drawing.Size(129, 30);
            this.lb_vente.TabIndex = 89;
            this.lb_vente.Text = "0.000";
            this.lb_vente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_vente.ThousandsSeparator = true;
            this.lb_vente.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Retour :";
            // 
            // lb_retour
            // 
            this.lb_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_retour.BackColor = System.Drawing.Color.Silver;
            this.lb_retour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_retour.Clinote = true;
            this.lb_retour.Couleur1 = System.Drawing.Color.Gray;
            this.lb_retour.Couleur2 = System.Drawing.Color.OrangeRed;
            this.lb_retour.DecimalPlaces = 3;
            this.lb_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_retour.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_retour.Location = new System.Drawing.Point(408, 469);
            this.lb_retour.Name = "lb_retour";
            this.lb_retour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_retour.Size = new System.Drawing.Size(129, 30);
            this.lb_retour.TabIndex = 89;
            this.lb_retour.Text = "0.000";
            this.lb_retour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_retour.ThousandsSeparator = true;
            this.lb_retour.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.nv_clt_titre);
            this.groupBox3.Location = new System.Drawing.Point(-2, -9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(982, 63);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.annuler_icone_4608_32;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(911, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 43);
            this.button5.TabIndex = 80;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nv_clt_titre
            // 
            this.nv_clt_titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nv_clt_titre.BackColor = System.Drawing.Color.Transparent;
            this.nv_clt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_clt_titre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nv_clt_titre.Location = new System.Drawing.Point(7, 14);
            this.nv_clt_titre.Name = "nv_clt_titre";
            this.nv_clt_titre.Size = new System.Drawing.Size(902, 44);
            this.nv_clt_titre.TabIndex = 43;
            this.nv_clt_titre.Text = "Tableau de Bord";
            this.nv_clt_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _CODE_ARTICLE
            // 
            this._CODE_ARTICLE.DataPropertyName = "CODE_ARTICLE";
            this._CODE_ARTICLE.FillWeight = 54.05405F;
            this._CODE_ARTICLE.HeaderText = "Code";
            this._CODE_ARTICLE.Name = "_CODE_ARTICLE";
            this._CODE_ARTICLE.ReadOnly = true;
            // 
            // _DESIGNATION_ARTICLE
            // 
            this._DESIGNATION_ARTICLE.DataPropertyName = "DESIGNATION_ARTICLE";
            this._DESIGNATION_ARTICLE.FillWeight = 224.3672F;
            this._DESIGNATION_ARTICLE.HeaderText = "Désignation Article";
            this._DESIGNATION_ARTICLE.Name = "_DESIGNATION_ARTICLE";
            this._DESIGNATION_ARTICLE.ReadOnly = true;
            // 
            // _qtte
            // 
            this._qtte.DataPropertyName = "qtte";
            this._qtte.FillWeight = 46.62191F;
            this._qtte.HeaderText = "Qté";
            this._qtte.Name = "_qtte";
            this._qtte.ReadOnly = true;
            // 
            // _PRIX_U_TTC
            // 
            this._PRIX_U_TTC.DataPropertyName = "PRIX_U_TTC";
            this._PRIX_U_TTC.FillWeight = 98.32364F;
            this._PRIX_U_TTC.HeaderText = "P.U. Vente";
            this._PRIX_U_TTC.Name = "_PRIX_U_TTC";
            this._PRIX_U_TTC.ReadOnly = true;
            this._PRIX_U_TTC.Visible = false;
            // 
            // _PRIX_HT_A_ARTICLE
            // 
            this._PRIX_HT_A_ARTICLE.DataPropertyName = "PRIX_HT_A_ARTICLE";
            this._PRIX_HT_A_ARTICLE.FillWeight = 96.41676F;
            this._PRIX_HT_A_ARTICLE.HeaderText = "P.U Achat";
            this._PRIX_HT_A_ARTICLE.Name = "_PRIX_HT_A_ARTICLE";
            this._PRIX_HT_A_ARTICLE.ReadOnly = true;
            this._PRIX_HT_A_ARTICLE.Visible = false;
            // 
            // _total_v
            // 
            this._total_v.DataPropertyName = "total_v";
            dataGridViewCellStyle12.Format = "N3";
            dataGridViewCellStyle12.NullValue = null;
            this._total_v.DefaultCellStyle = dataGridViewCellStyle12;
            this._total_v.FillWeight = 94.76756F;
            this._total_v.HeaderText = "P.T.Vente";
            this._total_v.Name = "_total_v";
            this._total_v.ReadOnly = true;
            // 
            // _total_a
            // 
            this._total_a.DataPropertyName = "total_a";
            dataGridViewCellStyle13.Format = "N3";
            dataGridViewCellStyle13.NullValue = null;
            this._total_a.DefaultCellStyle = dataGridViewCellStyle13;
            this._total_a.FillWeight = 93.34122F;
            this._total_a.HeaderText = "P.T. Achat";
            this._total_a.Name = "_total_a";
            this._total_a.ReadOnly = true;
            // 
            // _total_g
            // 
            this._total_g.DataPropertyName = "total_g";
            dataGridViewCellStyle14.Format = "N3";
            dataGridViewCellStyle14.NullValue = null;
            this._total_g.DefaultCellStyle = dataGridViewCellStyle14;
            this._total_g.FillWeight = 92.10765F;
            this._total_g.HeaderText = "Gain";
            this._total_g.Name = "_total_g";
            this._total_g.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODE_ARTICLE";
            this.dataGridViewTextBoxColumn1.FillWeight = 54.05405F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESIGNATION_ARTICLE";
            this.dataGridViewTextBoxColumn2.FillWeight = 224.3672F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Désignation Article";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "qtte";
            this.dataGridViewTextBoxColumn3.FillWeight = 46.62191F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Qté";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRIX_U_TTC";
            this.dataGridViewTextBoxColumn4.FillWeight = 98.32364F;
            this.dataGridViewTextBoxColumn4.HeaderText = "P.U. Vente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRIX_HT_A_ARTICLE";
            this.dataGridViewTextBoxColumn5.FillWeight = 96.41676F;
            this.dataGridViewTextBoxColumn5.HeaderText = "P.U. Achat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total_v";
            dataGridViewCellStyle17.Format = "N3";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn6.FillWeight = 94.76756F;
            this.dataGridViewTextBoxColumn6.HeaderText = "P.T. Vente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "total_a";
            dataGridViewCellStyle18.Format = "N3";
            dataGridViewCellStyle18.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn7.FillWeight = 93.34122F;
            this.dataGridViewTextBoxColumn7.HeaderText = "P.T. Achat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "total_g";
            dataGridViewCellStyle19.Format = "N3";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn8.FillWeight = 92.10765F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Gain";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // CHM_FRM_GAIN_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHM_CLIENT_APP.Properties.Resources.interface_interne_clients;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_retour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_vente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_gain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_au);
            this.Controls.Add(this.dtp_du);
            this.Name = "CHM_FRM_GAIN_DETAIL";
            this.Text = "Tableau de Bord";
            this.Load += new System.EventHandler(this.CHM_FRM_GAIN_DETAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_retour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_au;
        private System.Windows.Forms.DateTimePicker dtp_du;
        private System.Windows.Forms.DataGridView dgv_liste;
        private LABEL_NUM.LabelNumerique lb_gain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_retour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private LABEL_NUM.LabelNumerique lb_vente;
        private System.Windows.Forms.Label label4;
        private LABEL_NUM.LabelNumerique lb_retour;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label nv_clt_titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODE_ARTICLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DESIGNATION_ARTICLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _qtte;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PRIX_U_TTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PRIX_HT_A_ARTICLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total_g;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}