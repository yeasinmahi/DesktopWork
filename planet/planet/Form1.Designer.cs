namespace planet
{
    partial class Planet
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
            this.planetComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetComboBox
            // 
            this.planetComboBox.FormattingEnabled = true;
            this.planetComboBox.Items.AddRange(new object[] {
            "Select",
            "The Sun",
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"});
            this.planetComboBox.Location = new System.Drawing.Point(135, 28);
            this.planetComboBox.Name = "planetComboBox";
            this.planetComboBox.Size = new System.Drawing.Size(121, 21);
            this.planetComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(48, 98);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(208, 44);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Me the Position Of Planet";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 174);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planetComboBox);
            this.Name = "Planet";
            this.Text = "Planets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox planetComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
    }
}

