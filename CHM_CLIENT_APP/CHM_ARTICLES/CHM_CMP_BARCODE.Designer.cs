namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    partial class CHM_CMP_BARCODE
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.CODE_BARRE_ARTICLE = new BARRE_CODE.BarCodeCtrl();
            this.CODE_BARRE_NV_ARTICLE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CODE_BARRE_ARTICLE
            // 
            this.CODE_BARRE_ARTICLE.BarCode = "";
            this.CODE_BARRE_ARTICLE.BarCodeHeight = 40;
            this.CODE_BARRE_ARTICLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_BARRE_ARTICLE.ChargerImage = true;
            this.CODE_BARRE_ARTICLE.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CODE_BARRE_ARTICLE.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CODE_BARRE_ARTICLE.HeaderText = "BarCode Demo";
            this.CODE_BARRE_ARTICLE.LeftMargin = 10;
            this.CODE_BARRE_ARTICLE.Location = new System.Drawing.Point(27, 28);
            this.CODE_BARRE_ARTICLE.Name = "CODE_BARRE_ARTICLE";
            this.CODE_BARRE_ARTICLE.ShowFooter = false;
            this.CODE_BARRE_ARTICLE.ShowHeader = false;
            this.CODE_BARRE_ARTICLE.Size = new System.Drawing.Size(236, 62);
            this.CODE_BARRE_ARTICLE.TabIndex = 81;
            this.CODE_BARRE_ARTICLE.TopMargin = 10;
            this.CODE_BARRE_ARTICLE.VertAlign = BARRE_CODE.BarCodeCtrl.AlignType.Center;
            this.CODE_BARRE_ARTICLE.Weight = BARRE_CODE.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // CODE_BARRE_NV_ARTICLE
            // 
            this.CODE_BARRE_NV_ARTICLE.Location = new System.Drawing.Point(115, 3);
            this.CODE_BARRE_NV_ARTICLE.Name = "CODE_BARRE_NV_ARTICLE";
            this.CODE_BARRE_NV_ARTICLE.Size = new System.Drawing.Size(148, 20);
            this.CODE_BARRE_NV_ARTICLE.TabIndex = 79;
            this.CODE_BARRE_NV_ARTICLE.TextChanged += new System.EventHandler(this.CODE_BARRE_NV_ARTICLE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Code à barre :";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Image = global::CHM_CLIENT_APP.Properties.Resources.supprimer_icone_6859_32;
            this.btn_supprimer.Location = new System.Drawing.Point(0, 1);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(24, 23);
            this.btn_supprimer.TabIndex = 82;
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_ajouter_codebarre_Click);
            // 
            // CHM_CMP_BARCODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.CODE_BARRE_ARTICLE);
            this.Controls.Add(this.CODE_BARRE_NV_ARTICLE);
            this.Controls.Add(this.label5);
            this.Name = "CHM_CMP_BARCODE";
            this.Size = new System.Drawing.Size(268, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BARRE_CODE.BarCodeCtrl CODE_BARRE_ARTICLE;
        private System.Windows.Forms.TextBox CODE_BARRE_NV_ARTICLE;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_supprimer;
    }
}
