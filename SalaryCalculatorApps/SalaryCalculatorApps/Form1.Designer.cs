namespace SalaryCalculatorApps
{
    partial class SalaryCalculatorUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.basicAmoutTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.medicalTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(178, 60);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.employeeNameTextBox.TabIndex = 4;
            // 
            // basicAmoutTextBox
            // 
            this.basicAmoutTextBox.Location = new System.Drawing.Point(178, 121);
            this.basicAmoutTextBox.Name = "basicAmoutTextBox";
            this.basicAmoutTextBox.Size = new System.Drawing.Size(218, 20);
            this.basicAmoutTextBox.TabIndex = 5;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(178, 156);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(188, 20);
            this.houseRentTextBox.TabIndex = 6;
            // 
            // medicalTextBox
            // 
            this.medicalTextBox.Location = new System.Drawing.Point(178, 195);
            this.medicalTextBox.Name = "medicalTextBox";
            this.medicalTextBox.Size = new System.Drawing.Size(176, 20);
            this.medicalTextBox.TabIndex = 7;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(194, 257);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(172, 29);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show Me Salary";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "%  of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "% of Basic";
            // 
            // SalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 391);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.medicalTextBox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.basicAmoutTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorUI";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox basicAmoutTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox medicalTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

