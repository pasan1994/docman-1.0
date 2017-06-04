namespace DocManRemastered
{
    partial class Categories
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
            this.cats = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.newMain = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updateDoc = new System.Windows.Forms.Button();
            this.categoryGrid = new System.Windows.Forms.DataGridView();
            this.newSub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cats
            // 
            this.cats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cats.Location = new System.Drawing.Point(56, 105);
            this.cats.Margin = new System.Windows.Forms.Padding(2);
            this.cats.Name = "cats";
            this.cats.Size = new System.Drawing.Size(249, 385);
            this.cats.TabIndex = 0;
            this.cats.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cats_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category List";
            // 
            // newMain
            // 
            this.newMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMain.Location = new System.Drawing.Point(721, 144);
            this.newMain.Margin = new System.Windows.Forms.Padding(2);
            this.newMain.Name = "newMain";
            this.newMain.Size = new System.Drawing.Size(139, 27);
            this.newMain.TabIndex = 3;
            this.newMain.Text = "Create New Main Category";
            this.newMain.UseVisualStyleBackColor = true;
            this.newMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(721, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // updateDoc
            // 
            this.updateDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDoc.Location = new System.Drawing.Point(721, 265);
            this.updateDoc.Margin = new System.Windows.Forms.Padding(2);
            this.updateDoc.Name = "updateDoc";
            this.updateDoc.Size = new System.Drawing.Size(139, 27);
            this.updateDoc.TabIndex = 3;
            this.updateDoc.Text = "Update Document";
            this.updateDoc.UseVisualStyleBackColor = true;
            this.updateDoc.Click += new System.EventHandler(this.button3_Click);
            // 
            // categoryGrid
            // 
            this.categoryGrid.AllowUserToAddRows = false;
            this.categoryGrid.AllowUserToDeleteRows = false;
            this.categoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGrid.Location = new System.Drawing.Point(333, 105);
            this.categoryGrid.Name = "categoryGrid";
            this.categoryGrid.ReadOnly = true;
            this.categoryGrid.Size = new System.Drawing.Size(369, 385);
            this.categoryGrid.TabIndex = 4;
            this.categoryGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryGrid_RowHeaderMouseClick);
            // 
            // newSub
            // 
            this.newSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSub.Location = new System.Drawing.Point(721, 184);
            this.newSub.Margin = new System.Windows.Forms.Padding(2);
            this.newSub.Name = "newSub";
            this.newSub.Size = new System.Drawing.Size(139, 27);
            this.newSub.TabIndex = 5;
            this.newSub.Text = "Create New Sub Category";
            this.newSub.UseVisualStyleBackColor = true;
            this.newSub.Click += new System.EventHandler(this.newSub_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Assign StaffMember";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newSub);
            this.Controls.Add(this.categoryGrid);
            this.Controls.Add(this.updateDoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categories";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView cats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newMain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateDoc;
        private System.Windows.Forms.DataGridView categoryGrid;
        private System.Windows.Forms.Button newSub;
        private System.Windows.Forms.Button button1;
    }
}