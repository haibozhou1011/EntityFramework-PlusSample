namespace EntityFrameworkPlus.QueryCache.Demo
{
    partial class QueryCache
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
            this.btnNoExpirationQueryCache = new System.Windows.Forms.Button();
            this.btnAbsoluteExpirationQueryCache = new System.Windows.Forms.Button();
            this.btnSlidingExpirationQueryCache = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoExpirationQueryCache
            // 
            this.btnNoExpirationQueryCache.Location = new System.Drawing.Point(93, 68);
            this.btnNoExpirationQueryCache.Name = "btnNoExpirationQueryCache";
            this.btnNoExpirationQueryCache.Size = new System.Drawing.Size(195, 75);
            this.btnNoExpirationQueryCache.TabIndex = 0;
            this.btnNoExpirationQueryCache.Text = "为设置缓存过期";
            this.btnNoExpirationQueryCache.UseVisualStyleBackColor = true;
            this.btnNoExpirationQueryCache.Click += new System.EventHandler(this.btnNoExpirationQueryCache_Click);
            // 
            // btnAbsoluteExpirationQueryCache
            // 
            this.btnAbsoluteExpirationQueryCache.Location = new System.Drawing.Point(312, 68);
            this.btnAbsoluteExpirationQueryCache.Name = "btnAbsoluteExpirationQueryCache";
            this.btnAbsoluteExpirationQueryCache.Size = new System.Drawing.Size(203, 74);
            this.btnAbsoluteExpirationQueryCache.TabIndex = 1;
            this.btnAbsoluteExpirationQueryCache.Text = "设置缓存过程时间(s)";
            this.btnAbsoluteExpirationQueryCache.UseVisualStyleBackColor = true;
            this.btnAbsoluteExpirationQueryCache.Click += new System.EventHandler(this.btnAbsoluteExpirationQueryCache_Click);
            // 
            // btnSlidingExpirationQueryCache
            // 
            this.btnSlidingExpirationQueryCache.Location = new System.Drawing.Point(538, 67);
            this.btnSlidingExpirationQueryCache.Name = "btnSlidingExpirationQueryCache";
            this.btnSlidingExpirationQueryCache.Size = new System.Drawing.Size(242, 75);
            this.btnSlidingExpirationQueryCache.TabIndex = 2;
            this.btnSlidingExpirationQueryCache.TabStop = false;
            this.btnSlidingExpirationQueryCache.Text = "最后一次访问时间间隔(s)";
            this.btnSlidingExpirationQueryCache.UseVisualStyleBackColor = true;
            this.btnSlidingExpirationQueryCache.Click += new System.EventHandler(this.btnSlidingExpirationQueryCache_Click);
            // 
            // QueryCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 212);
            this.Controls.Add(this.btnSlidingExpirationQueryCache);
            this.Controls.Add(this.btnAbsoluteExpirationQueryCache);
            this.Controls.Add(this.btnNoExpirationQueryCache);
            this.Name = "QueryCache";
            this.Text = "QueryCache";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoExpirationQueryCache;
        private System.Windows.Forms.Button btnAbsoluteExpirationQueryCache;
        private System.Windows.Forms.Button btnSlidingExpirationQueryCache;

    }
}