namespace EntityFrameworkPlus.QueryCache.Demo
{
    partial class SlidingExpirationQueryCache
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSlidingExpiration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(311, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSlidingExpiration
            // 
            this.txtSlidingExpiration.Location = new System.Drawing.Point(205, 18);
            this.txtSlidingExpiration.Name = "txtSlidingExpiration";
            this.txtSlidingExpiration.Size = new System.Drawing.Size(100, 28);
            this.txtSlidingExpiration.TabIndex = 4;
            this.txtSlidingExpiration.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "最后一次访问时间间隔：";
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(0, 52);
            this.dgList.Name = "dgList";
            this.dgList.RowTemplate.Height = 30;
            this.dgList.Size = new System.Drawing.Size(997, 371);
            this.dgList.TabIndex = 6;
            // 
            // SlidingExpirationQueryCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 423);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSlidingExpiration);
            this.Controls.Add(this.label1);
            this.Name = "SlidingExpirationQueryCache";
            this.Text = "SlidingExpirationQueryCache";
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSlidingExpiration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgList;
    }
}