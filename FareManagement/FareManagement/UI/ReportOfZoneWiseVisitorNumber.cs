using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FareManagement.BLL;
using FareManagement.Model;

namespace FareManagement.UI
{
    public partial class ReportOfZoneWiseVisitorNumber : Form
    {
        LoadManager loadManager = new LoadManager();

        public ReportOfZoneWiseVisitorNumber()
        {
            InitializeComponent();
        }

        private void ReportOfZoneWiseVisitorNumber_Load(object sender, EventArgs e)
        {
            List<ZoneWiseVisitor> zoneWiseVisitors = loadManager.LoadZoneWiseVisitors();
            totalVisitorTextBox.Text = loadManager.TotalVisitor();
            zoneWiseVisitorDataGridView.DataSource = zoneWiseVisitors;
            foreach (DataGridViewRow row in zoneWiseVisitorDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) > (Convert.ToInt32(totalVisitorTextBox.Text) / zoneWiseVisitorDataGridView.Rows.Count))
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
                
            
        }

        private void ReportOfZoneWiseVisitorNumber_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
