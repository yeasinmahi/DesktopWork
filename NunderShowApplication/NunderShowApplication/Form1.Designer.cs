namespace NunderShowApplication
{
    partial class Form1
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
            this.showNumberListBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.showNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showNumberListBox
            // 
            this.showNumberListBox.FormattingEnabled = true;
            this.showNumberListBox.Location = new System.Drawing.Point(227, 36);
            this.showNumberListBox.Name = "showNumberListBox";
            this.showNumberListBox.Size = new System.Drawing.Size(120, 95);
            this.showNumberListBox.TabIndex = 0;
            this.showNumberListBox.SelectedIndexChanged += new System.EventHandler(this.showNumberListBox_SelectedIndexChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(114, 217);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Add";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showNumberTextBox
            // 
            this.showNumberTextBox.Location = new System.Drawing.Point(114, 36);
            this.showNumberTextBox.Name = "showNumberTextBox";
            this.showNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.showNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showNumberTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showNumberListBox);
            this.Name = "Form1";
            this.Text = "ShowNumberUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showNumberListBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox showNumberTextBox;
        private System.Windows.Forms.Label label1;
    }
}

