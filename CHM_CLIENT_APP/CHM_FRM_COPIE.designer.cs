namespace CHM_CLIENT_APP
{
    partial class CHM_FRM_COPIE
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsCopy = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.copyListقائمةالنسخDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.copyListقائمةالنسخDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Copie";
            this.dataGridView1.DataSource = this.dsCopy;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsCopy
            // 
            this.dsCopy.DataSetName = "NewDataSet";
            this.dsCopy.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.TableName = "Copie";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Copy list قائمة النسخ";
            this.dataColumn1.ColumnName = "Copy list قائمة النسخ";
            // 
            // copyListقائمةالنسخDataGridViewTextBoxColumn
            // 
            this.copyListقائمةالنسخDataGridViewTextBoxColumn.DataPropertyName = "Copy list قائمة النسخ";
            this.copyListقائمةالنسخDataGridViewTextBoxColumn.HeaderText = "Copy list قائمة النسخ";
            this.copyListقائمةالنسخDataGridViewTextBoxColumn.Name = "copyListقائمةالنسخDataGridViewTextBoxColumn";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(2, 273);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(265, 32);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close خروج";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // CHM_FRM_COPIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 306);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHM_FRM_COPIE";
            this.Text = "Copy list قائمة النسخ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Data.DataSet dsCopy;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyListقائمةالنسخDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_close;
    }
}