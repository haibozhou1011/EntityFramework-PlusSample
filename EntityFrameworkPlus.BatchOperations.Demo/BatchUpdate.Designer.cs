namespace EntityFrameworkPlus.BatchOperations.Demo
{
    partial class BatchUpdate
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
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.btnUpdateWithSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.gbWhere.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWhere
            // 
            this.gbWhere.Controls.Add(this.txtCreator);
            this.gbWhere.Controls.Add(this.label1);
            this.gbWhere.Location = new System.Drawing.Point(12, 12);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Size = new System.Drawing.Size(429, 95);
            this.gbWhere.TabIndex = 0;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "查询字段";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.txtUnitPrice);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.btnUpdateWithSearch);
            this.gbUpdate.Location = new System.Drawing.Point(488, 12);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(474, 95);
            this.gbUpdate.TabIndex = 1;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "修改字段";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "创建人";
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(106, 30);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(170, 27);
            this.txtCreator.TabIndex = 1;
            // 
            // btnUpdateWithSearch
            // 
            this.btnUpdateWithSearch.Location = new System.Drawing.Point(303, 30);
            this.btnUpdateWithSearch.Name = "btnUpdateWithSearch";
            this.btnUpdateWithSearch.Size = new System.Drawing.Size(143, 35);
            this.btnUpdateWithSearch.TabIndex = 0;
            this.btnUpdateWithSearch.Text = "修改后查询";
            this.btnUpdateWithSearch.UseVisualStyleBackColor = true;
            this.btnUpdateWithSearch.Click += new System.EventHandler(this.btnUpdateWithSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "单价";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(91, 32);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 27);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 114);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 29;
            this.dgvList.Size = new System.Drawing.Size(969, 426);
            this.dgvList.TabIndex = 2;
            // 
            // BatchUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 543);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbWhere);
            this.Name = "BatchUpdate";
            this.Text = "BatchUpdate";
            this.gbWhere.ResumeLayout(false);
            this.gbWhere.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateWithSearch;
        private System.Windows.Forms.DataGridView dgvList;
    }
}