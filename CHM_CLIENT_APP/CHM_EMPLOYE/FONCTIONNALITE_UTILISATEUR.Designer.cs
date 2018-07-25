namespace CHM_CLIENT_APP
{
    partial class FONCTIONNALITE_UTILISATEUR
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
            this.dgv_fct_utilisateur = new System.Windows.Forms.DataGridView();
            this.CODE_FONCTION_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIB_FONC_UTIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fct_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_utilisateur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fct_utilisateur)).BeginInit();
            this.fct_cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_fct_utilisateur
            // 
            this.dgv_fct_utilisateur.AllowUserToAddRows = false;
            this.dgv_fct_utilisateur.AllowUserToDeleteRows = false;
            this.dgv_fct_utilisateur.AllowUserToResizeColumns = false;
            this.dgv_fct_utilisateur.AllowUserToResizeRows = false;
            this.dgv_fct_utilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fct_utilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fct_utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fct_utilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_FONCTION_,
            this.LIB_FONC_UTIL});
            this.dgv_fct_utilisateur.ContextMenuStrip = this.fct_cms;
            this.dgv_fct_utilisateur.Location = new System.Drawing.Point(12, 64);
            this.dgv_fct_utilisateur.Name = "dgv_fct_utilisateur";
            this.dgv_fct_utilisateur.ReadOnly = true;
            this.dgv_fct_utilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fct_utilisateur.Size = new System.Drawing.Size(375, 201);
            this.dgv_fct_utilisateur.TabIndex = 0;
            // 
            // CODE_FONCTION_
            // 
            this.CODE_FONCTION_.DataPropertyName = "CODE_FONCTION";
            this.CODE_FONCTION_.FillWeight = 60.24096F;
            this.CODE_FONCTION_.HeaderText = "Code";
            this.CODE_FONCTION_.Name = "CODE_FONCTION_";
            this.CODE_FONCTION_.ReadOnly = true;
            // 
            // LIB_FONC_UTIL
            // 
            this.LIB_FONC_UTIL.DataPropertyName = "LIB_FONCTION";
            this.LIB_FONC_UTIL.FillWeight = 139.759F;
            this.LIB_FONC_UTIL.HeaderText = "Designation";
            this.LIB_FONC_UTIL.Name = "LIB_FONC_UTIL";
            this.LIB_FONC_UTIL.ReadOnly = true;
            // 
            // fct_cms
            // 
            this.fct_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.fct_cms.Name = "fct_cms";
            this.fct_cms.Size = new System.Drawing.Size(158, 70);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // btn_utilisateur
            // 
            this.btn_utilisateur.Location = new System.Drawing.Point(12, 12);
            this.btn_utilisateur.Name = "btn_utilisateur";
            this.btn_utilisateur.Size = new System.Drawing.Size(165, 36);
            this.btn_utilisateur.TabIndex = 1;
            this.btn_utilisateur.Text = "Utilisateurs par fonction";
            this.btn_utilisateur.UseVisualStyleBackColor = true;
            // 
            // FONCTIONNALITE_UTILISATEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 277);
            this.Controls.Add(this.btn_utilisateur);
            this.Controls.Add(this.dgv_fct_utilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FONCTIONNALITE_UTILISATEUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FONCTIONNALITE_UTILISATEUR";
            this.Shown += new System.EventHandler(this.FONCTIONNALITE_UTILISATEUR_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fct_utilisateur)).EndInit();
            this.fct_cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_fct_utilisateur;
        private System.Windows.Forms.Button btn_utilisateur;
        private System.Windows.Forms.ContextMenuStrip fct_cms;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FONCTION_;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIB_FONC_UTIL;
    }
}