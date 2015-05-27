namespace FareManagement.UI
{
    partial class ReportOfZoneWiseVisitorNumber
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
            this.zoneWiseVisitorDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.totalVisitorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneWiseVisitorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zoneWiseVisitorDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // zoneWiseVisitorDataGridView
            // 
            this.zoneWiseVisitorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zoneWiseVisitorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.zoneWiseVisitorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.zoneWiseVisitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zoneWiseVisitorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoneWiseVisitorDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoneWiseVisitorDataGridView.Location = new System.Drawing.Point(3, 28);
            this.zoneWiseVisitorDataGridView.Name = "zoneWiseVisitorDataGridView";
            this.zoneWiseVisitorDataGridView.Size = new System.Drawing.Size(606, 205);
            this.zoneWiseVisitorDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Visitors";
            // 
            // totalVisitorTextBox
            // 
            this.totalVisitorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVisitorTextBox.Location = new System.Drawing.Point(531, 294);
            this.totalVisitorTextBox.Name = "totalVisitorTextBox";
            this.totalVisitorTextBox.Size = new System.Drawing.Size(90, 35);
            this.totalVisitorTextBox.TabIndex = 2;
            this.totalVisitorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReportOfZoneWiseVisitorNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 381);
            this.ControlBox = false;
            this.Controls.Add(this.totalVisitorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportOfZoneWiseVisitorNumber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.ReportOfZoneWiseVisitorNumber_Deactivate);
            this.Load += new System.EventHandler(this.ReportOfZoneWiseVisitorNumber_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoneWiseVisitorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView zoneWiseVisitorDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalVisitorTextBox;
    }
}