﻿namespace DocManRemastered
{
    partial class uploadDoc
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
            this.topic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAnySpecialNotes = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.LblDeadline = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblFrom = new System.Windows.Forms.Label();
            this.LblDateRecieved = new System.Windows.Forms.Label();
            this.RecievedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.custom = new System.Windows.Forms.CheckedListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifications = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.senderdoc = new System.Windows.Forms.TextBox();
            this.keywords = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // topic
            // 
            this.topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic.Location = new System.Drawing.Point(137, 95);
            this.topic.Margin = new System.Windows.Forms.Padding(2);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(214, 26);
            this.topic.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "Topic";
            // 
            // LblAnySpecialNotes
            // 
            this.LblAnySpecialNotes.AutoSize = true;
            this.LblAnySpecialNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnySpecialNotes.Location = new System.Drawing.Point(19, 248);
            this.LblAnySpecialNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnySpecialNotes.Name = "LblAnySpecialNotes";
            this.LblAnySpecialNotes.Size = new System.Drawing.Size(118, 20);
            this.LblAnySpecialNotes.TabIndex = 102;
            this.LblAnySpecialNotes.Text = "Key Word Entry";
            // 
            // deadline
            // 
            this.deadline.Checked = false;
            this.deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadline.Location = new System.Drawing.Point(137, 198);
            this.deadline.Margin = new System.Windows.Forms.Padding(2);
            this.deadline.Name = "deadline";
            this.deadline.ShowCheckBox = true;
            this.deadline.Size = new System.Drawing.Size(214, 26);
            this.deadline.TabIndex = 101;
            // 
            // LblDeadline
            // 
            this.LblDeadline.AutoSize = true;
            this.LblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeadline.Location = new System.Drawing.Point(21, 202);
            this.LblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeadline.Name = "LblDeadline";
            this.LblDeadline.Size = new System.Drawing.Size(72, 20);
            this.LblDeadline.TabIndex = 100;
            this.LblDeadline.Text = "Deadline";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(21, 169);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(56, 20);
            this.LblStatus.TabIndex = 99;
            this.LblStatus.Text = "Status";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Very Urgent",
            "Urgent",
            "Moderate",
            "Not at all"});
            this.status.Location = new System.Drawing.Point(137, 162);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(91, 28);
            this.status.TabIndex = 97;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(137, 129);
            this.category.Margin = new System.Windows.Forms.Padding(2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(220, 28);
            this.category.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Category";
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFrom.Location = new System.Drawing.Point(24, 59);
            this.LblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(46, 20);
            this.LblFrom.TabIndex = 94;
            this.LblFrom.Text = "From";
            // 
            // LblDateRecieved
            // 
            this.LblDateRecieved.AutoSize = true;
            this.LblDateRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateRecieved.Location = new System.Drawing.Point(21, 26);
            this.LblDateRecieved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDateRecieved.Name = "LblDateRecieved";
            this.LblDateRecieved.Size = new System.Drawing.Size(114, 20);
            this.LblDateRecieved.TabIndex = 92;
            this.LblDateRecieved.Text = "Date Recieved";
            // 
            // RecievedDatePicker
            // 
            this.RecievedDatePicker.Checked = false;
            this.RecievedDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievedDatePicker.Location = new System.Drawing.Point(137, 22);
            this.RecievedDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.RecievedDatePicker.Name = "RecievedDatePicker";
            this.RecievedDatePicker.ShowCheckBox = true;
            this.RecievedDatePicker.Size = new System.Drawing.Size(214, 26);
            this.RecievedDatePicker.TabIndex = 93;
            // 
            // custom
            // 
            this.custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom.FormattingEnabled = true;
            this.custom.Location = new System.Drawing.Point(263, 29);
            this.custom.Margin = new System.Windows.Forms.Padding(2);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(213, 130);
            this.custom.TabIndex = 117;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(355, 66);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 27);
            this.button5.TabIndex = 116;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Search Results";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 125);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 105);
            this.textBox2.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Type a keyword here";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(31, 66);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 26);
            this.textBox3.TabIndex = 112;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 11);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 24);
            this.checkBox1.TabIndex = 111;
            this.checkBox1.Text = "Tag to";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 110;
            this.label3.Text = "Custom Notification";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(817, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 109;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 108;
            this.button1.Text = "Attach the file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // notifications
            // 
            this.notifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifications.FormattingEnabled = true;
            this.notifications.Items.AddRange(new object[] {
            "Related to Category",
            "Only HOD",
            "All Senior Lecturer Staff",
            "All Junior Lecturer Staff",
            "All Temporary Staff",
            "All",
            "Custom"});
            this.notifications.Location = new System.Drawing.Point(29, 29);
            this.notifications.Margin = new System.Windows.Forms.Padding(2);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(215, 147);
            this.notifications.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Notify to";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.notifications);
            this.panel1.Controls.Add(this.custom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(418, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 206);
            this.panel1.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(418, 233);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 252);
            this.panel2.TabIndex = 119;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.keywords);
            this.panel3.Controls.Add(this.senderdoc);
            this.panel3.Controls.Add(this.RecievedDatePicker);
            this.panel3.Controls.Add(this.LblDateRecieved);
            this.panel3.Controls.Add(this.LblFrom);
            this.panel3.Controls.Add(this.topic);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.category);
            this.panel3.Controls.Add(this.status);
            this.panel3.Controls.Add(this.LblAnySpecialNotes);
            this.panel3.Controls.Add(this.LblStatus);
            this.panel3.Controls.Add(this.deadline);
            this.panel3.Controls.Add(this.LblDeadline);
            this.panel3.Location = new System.Drawing.Point(24, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 465);
            this.panel3.TabIndex = 120;
            // 
            // senderdoc
            // 
            this.senderdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderdoc.Location = new System.Drawing.Point(137, 59);
            this.senderdoc.Margin = new System.Windows.Forms.Padding(2);
            this.senderdoc.Name = "senderdoc";
            this.senderdoc.Size = new System.Drawing.Size(214, 26);
            this.senderdoc.TabIndex = 106;
            // 
            // keywords
            // 
            this.keywords.Location = new System.Drawing.Point(23, 281);
            this.keywords.Name = "keywords";
            this.keywords.Size = new System.Drawing.Size(328, 159);
            this.keywords.TabIndex = 107;
            this.keywords.Text = "";
            // 
            // uploadDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uploadDoc";
            this.Text = "uploadDoc";
            this.Load += new System.EventHandler(this.uploadDoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox topic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAnySpecialNotes;
        private System.Windows.Forms.DateTimePicker deadline;
        private System.Windows.Forms.Label LblDeadline;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.Label LblDateRecieved;
        private System.Windows.Forms.DateTimePicker RecievedDatePicker;
        private System.Windows.Forms.CheckedListBox custom;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox notifications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox senderdoc;
        private System.Windows.Forms.RichTextBox keywords;
    }
}