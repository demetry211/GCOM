namespace CHM_CLIENT_APP.CHM_BON_DE_LIVRAISON
{
    partial class CHM_SELECTION_CONTROL
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
            this.components = new System.ComponentModel.Container();
            this.selection_state = new System.Windows.Forms.CheckBox();
            this.entete = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LB_TYPE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selection_state
            // 
            this.selection_state.AutoSize = true;
            this.selection_state.Location = new System.Drawing.Point(11, 18);
            this.selection_state.Name = "selection_state";
            this.selection_state.Size = new System.Drawing.Size(15, 14);
            this.selection_state.TabIndex = 0;
            this.selection_state.UseVisualStyleBackColor = true;
            // 
            // entete
            // 
            this.entete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entete.ForeColor = System.Drawing.Color.MediumBlue;
            this.entete.Location = new System.Drawing.Point(45, 2);
            this.entete.Name = "entete";
            this.entete.Size = new System.Drawing.Size(293, 18);
            this.entete.TabIndex = 1;
            this.entete.Text = "label1";
            // 
            // detail
            // 
            this.detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.detail.Location = new System.Drawing.Point(45, 19);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(293, 16);
            this.detail.TabIndex = 2;
            this.detail.Text = "label2";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // LB_TYPE
            // 
            this.LB_TYPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_TYPE.BackColor = System.Drawing.Color.Transparent;
            this.LB_TYPE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TYPE.ForeColor = System.Drawing.Color.DarkRed;
            this.LB_TYPE.Location = new System.Drawing.Point(3, 2);
            this.LB_TYPE.Name = "LB_TYPE";
            this.LB_TYPE.Size = new System.Drawing.Size(36, 18);
            this.LB_TYPE.TabIndex = 1;
            this.LB_TYPE.Text = "label1";
            // 
            // CHM_SELECTION_CONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.selection_state);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.LB_TYPE);
            this.Controls.Add(this.entete);
            this.Name = "CHM_SELECTION_CONTROL";
            this.Size = new System.Drawing.Size(338, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox selection_state;
        public System.Windows.Forms.Label entete;
        public System.Windows.Forms.Label detail;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label LB_TYPE;

    }
}
