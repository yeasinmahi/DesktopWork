namespace problemSet01
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
            this.qsn = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ans = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ok = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperAndLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisorOf3And5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qsn
            // 
            this.qsn.AutoSize = true;
            this.qsn.Font = new System.Drawing.Font("Nauert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qsn.Location = new System.Drawing.Point(45, 44);
            this.qsn.Name = "qsn";
            this.qsn.Size = new System.Drawing.Size(71, 17);
            this.qsn.TabIndex = 0;
            this.qsn.Text = "Answers";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Nauert", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select--",
            "Upper and Lower",
            "Even Number",
            "Divisor of 3 and 5",
            "Natural Number Different",
            "Exit"});
            this.comboBox1.Location = new System.Drawing.Point(136, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(44, 154);
            this.ans.MaximumSize = new System.Drawing.Size(350, 0);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(0, 20);
            this.ans.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(48, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 46);
            this.panel1.TabIndex = 3;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(278, 10);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(44, 23);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upper";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upperAndLowerToolStripMenuItem,
            this.evenNumberToolStripMenuItem,
            this.divisorOf3And5ToolStripMenuItem,
            this.naturalNumberToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questionToolStripMenuItem.Text = "Question?";
            // 
            // upperAndLowerToolStripMenuItem
            // 
            this.upperAndLowerToolStripMenuItem.Name = "upperAndLowerToolStripMenuItem";
            this.upperAndLowerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.upperAndLowerToolStripMenuItem.Text = "Upper and Lower";
            this.upperAndLowerToolStripMenuItem.Click += new System.EventHandler(this.upperAndLowerToolStripMenuItem_Click);
            // 
            // evenNumberToolStripMenuItem
            // 
            this.evenNumberToolStripMenuItem.Name = "evenNumberToolStripMenuItem";
            this.evenNumberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.evenNumberToolStripMenuItem.Text = "Even Number";
            this.evenNumberToolStripMenuItem.Click += new System.EventHandler(this.evenNumberToolStripMenuItem_Click);
            // 
            // divisorOf3And5ToolStripMenuItem
            // 
            this.divisorOf3And5ToolStripMenuItem.Name = "divisorOf3And5ToolStripMenuItem";
            this.divisorOf3And5ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.divisorOf3And5ToolStripMenuItem.Text = "Divisor of 3 and 5";
            this.divisorOf3And5ToolStripMenuItem.Click += new System.EventHandler(this.divisorOf3And5ToolStripMenuItem_Click);
            // 
            // naturalNumberToolStripMenuItem
            // 
            this.naturalNumberToolStripMenuItem.Name = "naturalNumberToolStripMenuItem";
            this.naturalNumberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.naturalNumberToolStripMenuItem.Text = "Natural Number";
            this.naturalNumberToolStripMenuItem.Click += new System.EventHandler(this.naturalNumberToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.qsn);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Problem Set 01";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qsn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperAndLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisorOf3And5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

