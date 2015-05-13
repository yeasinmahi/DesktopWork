namespace AccountCalculationApps
{
    partial class AcountOperationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(153, 47);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(221, 24);
            this.accountNumberTextBox.TabIndex = 2;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(153, 77);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(221, 24);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(279, 107);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(95, 37);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportButton);
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(76, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(99, 42);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(207, 24);
            this.amountTextBox.TabIndex = 1;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(99, 82);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 35);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(200, 82);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(83, 35);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(99, 149);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(184, 36);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // AcountOperationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AcountOperationUI";
            this.Text = "Account Operation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
    }
}

