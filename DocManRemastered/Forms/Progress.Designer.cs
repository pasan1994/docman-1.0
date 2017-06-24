namespace DocManRemastered.Forms
{
    partial class Progress
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
            this.progressView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progresstxt = new System.Windows.Forms.RichTextBox();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressView)).BeginInit();
            this.SuspendLayout();
            // 
            // progressView
            // 
            this.progressView.AllowUserToAddRows = false;
            this.progressView.AllowUserToDeleteRows = false;
            this.progressView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progressView.Location = new System.Drawing.Point(21, 26);
            this.progressView.Name = "progressView";
            this.progressView.ReadOnly = true;
            this.progressView.Size = new System.Drawing.Size(511, 214);
            this.progressView.TabIndex = 0;
            this.progressView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.progressView_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Progress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modify Progress";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Progress";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // progresstxt
            // 
            this.progresstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progresstxt.Location = new System.Drawing.Point(21, 317);
            this.progresstxt.Name = "progresstxt";
            this.progresstxt.Size = new System.Drawing.Size(228, 127);
            this.progresstxt.TabIndex = 4;
            this.progresstxt.Text = "";
            // 
            // deadline
            // 
            this.deadline.Checked = false;
            this.deadline.Location = new System.Drawing.Point(302, 317);
            this.deadline.Name = "deadline";
            this.deadline.ShowCheckBox = true;
            this.deadline.Size = new System.Drawing.Size(214, 20);
            this.deadline.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Deadline (If applicable)";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(302, 392);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(71, 17);
            this.status.TabIndex = 8;
            this.status.Text = "Resolved";
            this.status.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.progresstxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressView);
            this.Name = "Progress";
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.Progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView progressView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox progresstxt;
        private System.Windows.Forms.DateTimePicker deadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.Label label3;
    }
}