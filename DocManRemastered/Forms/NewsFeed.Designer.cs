namespace DocManRemastered
{
    partial class NewsFeed
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
            this.label2 = new System.Windows.Forms.Label();
            this.updead = new System.Windows.Forms.DataGridView();
            this.recent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.updead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Files Added";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upcoming Dead Lines";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // updead
            // 
            this.updead.AllowUserToAddRows = false;
            this.updead.AllowUserToDeleteRows = false;
            this.updead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updead.Location = new System.Drawing.Point(30, 67);
            this.updead.Name = "updead";
            this.updead.ReadOnly = true;
            this.updead.Size = new System.Drawing.Size(633, 151);
            this.updead.TabIndex = 2;
            // 
            // recent
            // 
            this.recent.AllowUserToAddRows = false;
            this.recent.AllowUserToDeleteRows = false;
            this.recent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recent.Location = new System.Drawing.Point(30, 288);
            this.recent.Name = "recent";
            this.recent.ReadOnly = true;
            this.recent.Size = new System.Drawing.Size(633, 151);
            this.recent.TabIndex = 3;
            // 
            // NewsFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 478);
            this.Controls.Add(this.recent);
            this.Controls.Add(this.updead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsFeed";
            this.Text = "NewsFeed";
            this.Load += new System.EventHandler(this.NewsFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView updead;
        private System.Windows.Forms.DataGridView recent;
    }
}