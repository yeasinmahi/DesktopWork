namespace EmailSearchApplication
{
    partial class EmailF
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
            this.emailAddTextBox = new System.Windows.Forms.TextBox();
            this.emailSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailAddButton = new System.Windows.Forms.Button();
            this.emailSearchButton = new System.Windows.Forms.Button();
            this.emailAddListBox = new System.Windows.Forms.ListBox();
            this.emailSearchListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // emailAddTextBox
            // 
            this.emailAddTextBox.Location = new System.Drawing.Point(119, 31);
            this.emailAddTextBox.Name = "emailAddTextBox";
            this.emailAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailAddTextBox.TabIndex = 0;
            // 
            // emailSearchTextBox
            // 
            this.emailSearchTextBox.Location = new System.Drawing.Point(427, 31);
            this.emailSearchTextBox.Name = "emailSearchTextBox";
            this.emailSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailSearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email to search";
            // 
            // emailAddButton
            // 
            this.emailAddButton.Location = new System.Drawing.Point(144, 70);
            this.emailAddButton.Name = "emailAddButton";
            this.emailAddButton.Size = new System.Drawing.Size(75, 23);
            this.emailAddButton.TabIndex = 4;
            this.emailAddButton.Text = "Add";
            this.emailAddButton.UseVisualStyleBackColor = true;
            this.emailAddButton.Click += new System.EventHandler(this.emailAddButton_Click);
            // 
            // emailSearchButton
            // 
            this.emailSearchButton.Location = new System.Drawing.Point(452, 70);
            this.emailSearchButton.Name = "emailSearchButton";
            this.emailSearchButton.Size = new System.Drawing.Size(75, 23);
            this.emailSearchButton.TabIndex = 5;
            this.emailSearchButton.Text = "Search";
            this.emailSearchButton.UseVisualStyleBackColor = true;
            this.emailSearchButton.Click += new System.EventHandler(this.emailSearchButton_Click);
            // 
            // emailAddListBox
            // 
            this.emailAddListBox.FormattingEnabled = true;
            this.emailAddListBox.Location = new System.Drawing.Point(99, 125);
            this.emailAddListBox.Name = "emailAddListBox";
            this.emailAddListBox.Size = new System.Drawing.Size(120, 95);
            this.emailAddListBox.TabIndex = 6;
            // 
            // emailSearchListBox
            // 
            this.emailSearchListBox.FormattingEnabled = true;
            this.emailSearchListBox.Location = new System.Drawing.Point(407, 125);
            this.emailSearchListBox.Name = "emailSearchListBox";
            this.emailSearchListBox.Size = new System.Drawing.Size(120, 95);
            this.emailSearchListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 300);
            this.Controls.Add(this.emailSearchListBox);
            this.Controls.Add(this.emailAddListBox);
            this.Controls.Add(this.emailSearchButton);
            this.Controls.Add(this.emailAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailSearchTextBox);
            this.Controls.Add(this.emailAddTextBox);
            this.Name = "Form1";
            this.Text = "Email Keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailAddTextBox;
        private System.Windows.Forms.TextBox emailSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button emailAddButton;
        private System.Windows.Forms.Button emailSearchButton;
        private System.Windows.Forms.ListBox emailAddListBox;
        private System.Windows.Forms.ListBox emailSearchListBox;
    }
}

