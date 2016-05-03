namespace EntityFrameworkPlus.BatchOperations.Demo
{
    partial class BatchOperations
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
            this.btnBatchUpdate = new System.Windows.Forms.Button();
            this.btnBatchDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBatchUpdate
            // 
            this.btnBatchUpdate.Location = new System.Drawing.Point(53, 96);
            this.btnBatchUpdate.Name = "btnBatchUpdate";
            this.btnBatchUpdate.Size = new System.Drawing.Size(156, 51);
            this.btnBatchUpdate.TabIndex = 0;
            this.btnBatchUpdate.Text = "Batch Update";
            this.btnBatchUpdate.UseVisualStyleBackColor = true;
            this.btnBatchUpdate.Click += new System.EventHandler(this.btnBatchUpdate_Click);
            // 
            // btnBatchDelete
            // 
            this.btnBatchDelete.Location = new System.Drawing.Point(262, 96);
            this.btnBatchDelete.Name = "btnBatchDelete";
            this.btnBatchDelete.Size = new System.Drawing.Size(169, 51);
            this.btnBatchDelete.TabIndex = 1;
            this.btnBatchDelete.Text = "Batch Delete";
            this.btnBatchDelete.UseVisualStyleBackColor = true;
            this.btnBatchDelete.Click += new System.EventHandler(this.btnBatchDelete_Click);
            // 
            // BatchOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 273);
            this.Controls.Add(this.btnBatchDelete);
            this.Controls.Add(this.btnBatchUpdate);
            this.Name = "BatchOperations";
            this.Text = "BatchOperations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBatchUpdate;
        private System.Windows.Forms.Button btnBatchDelete;
    }
}