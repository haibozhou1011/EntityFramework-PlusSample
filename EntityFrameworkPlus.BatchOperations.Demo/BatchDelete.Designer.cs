namespace EntityFrameworkPlus.BatchOperations.Demo
{
    partial class BatchDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOperation = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnDeleteWithSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价";
            // 
            // cbxOperation
            // 
            this.cbxOperation.FormattingEnabled = true;
            this.cbxOperation.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.cbxOperation.Location = new System.Drawing.Point(130, 30);
            this.cbxOperation.Name = "cbxOperation";
            this.cbxOperation.Size = new System.Drawing.Size(121, 25);
            this.cbxOperation.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(257, 28);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 27);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // btnDeleteWithSearch
            // 
            this.btnDeleteWithSearch.Location = new System.Drawing.Point(391, 23);
            this.btnDeleteWithSearch.Name = "btnDeleteWithSearch";
            this.btnDeleteWithSearch.Size = new System.Drawing.Size(119, 33);
            this.btnDeleteWithSearch.TabIndex = 3;
            this.btnDeleteWithSearch.Text = "删除后查询";
            this.btnDeleteWithSearch.UseVisualStyleBackColor = true;
            this.btnDeleteWithSearch.Click += new System.EventHandler(this.btnDeleteWithSearch_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 69);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 29;
            this.dgvList.Size = new System.Drawing.Size(1026, 514);
            this.dgvList.TabIndex = 4;
            // 
            // BatchDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 585);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnDeleteWithSearch);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.cbxOperation);
            this.Controls.Add(this.label1);
            this.Name = "BatchDelete";
            this.Text = "BatchDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOperation;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnDeleteWithSearch;
        private System.Windows.Forms.DataGridView dgvList;

    }
}