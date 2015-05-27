using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FareManagement.BLL;
using FareManagement.Model;

namespace FareManagement.UI
{
    public partial class ZoneTypeUi : Form
    {
        LoadManager loadManager = new LoadManager();
        ZoneTypeManager zoneTypeManager = new ZoneTypeManager();
        public ZoneTypeUi()
        {
            InitializeComponent();
        }

        private void ZoneTypeUi_Load(object sender, EventArgs e)
        {
            List<Zone> listzZones = loadManager.LoadAllZone();
            zoneNameDataGridView.DataSource = listzZones;
            zoneNameDataGridView.Columns.Remove("zoneId");
            bool color = true;
            foreach (DataGridViewRow row in zoneNameDataGridView.Rows)
            {
                if (color)
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    color = false;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    color = true;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string zoneName = zoneNameTextBox.Text;
            if (zoneName.Equals(""))
            {
                MessageBox.Show(@"Enter A Zone Name");
            }
            else
            {
                if (zoneTypeManager.InsertZone(zoneName))
                {
                    MessageBox.Show(@"Insert Successfully");
                }
                else
                {
                    MessageBox.Show(@"Insert Failed");
                }
            }
        }
    }
}
