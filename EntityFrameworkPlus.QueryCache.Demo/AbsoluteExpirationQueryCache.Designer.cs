namespace EntityFrameworkPlus.QueryCache.Demo
{
    partial class AbsoluteExpirationQueryCache
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
            this.txtAbsoluteExpiration = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cache过期时间：";
            // 
            // txtAbsoluteExpiration
            // 
            this.txtAbsoluteExpiration.Location = new System.Drawing.Point(159, 17);
            this.txtAbsoluteExpiration.Name = "txtAbsoluteExpiration";
            this.txtAbsoluteExpiration.Size = new System.Drawing.Size(100, 28);
            this.txtAbsoluteExpiration.TabIndex = 1;
            this.txtAbsoluteExpiration.Text = "0";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(276, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(-2, 63);
            this.dgList.Name = "dgList";
            this.dgList.RowTemplate.Height = 30;
            this.dgList.Size = new System.Drawing.Size(994, 373);
            this.dgList.TabIndex = 3;
            // 
            // AbsoluteExpirationQueryCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 437);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAbsoluteExpiration);
            this.Controls.Add(this.label1);
            this.Name = "AbsoluteExpirationQueryCache";
            this.Text = "AbsoluteExpirationQueryCache";
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbsoluteExpiration;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgList;
    }
}