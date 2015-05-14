namespace EmployeeManagment.UI
{
    partial class MenuUi
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
            this.addButton = new System.Windows.Forms.Button();
            this.findAndEdidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(37, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 71);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findAndEdidButton
            // 
            this.findAndEdidButton.Location = new System.Drawing.Point(187, 105);
            this.findAndEdidButton.Name = "findAndEdidButton";
            this.findAndEdidButton.Size = new System.Drawing.Size(117, 71);
            this.findAndEdidButton.TabIndex = 1;
            this.findAndEdidButton.Text = "Find & Search";
            this.findAndEdidButton.UseVisualStyleBackColor = true;
            this.findAndEdidButton.Click += new System.EventHandler(this.findAndEdidButton_Click);
            // 
            // MenuUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 309);
            this.Controls.Add(this.findAndEdidButton);
            this.Controls.Add(this.addButton);
            this.Name = "MenuUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Employee menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button findAndEdidButton;
    }
}

