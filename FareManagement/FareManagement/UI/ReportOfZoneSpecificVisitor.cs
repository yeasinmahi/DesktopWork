using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FareManagement.BLL;
using FareManagement.Model;

namespace FareManagement.UI
{
    public partial class ReportOfZoneSpecificVisitor : Form
    {
        LoadManager loadManager = new LoadManager();
        ExportManager exportManager = new ExportManager();
        private bool _comboBoxError;
        public ReportOfZoneSpecificVisitor()
        {
            InitializeComponent();
            
        }

        private void ReportOfZoneSpecificVisitor_Load(object sender, EventArgs e)
        {
            List<Zone> listZones = loadManager.LoadAllZone();
            zoneComboBox.DataSource = listZones;
            zoneComboBox.DisplayMember = "zoneName";
            zoneComboBox.ValueMember = "zoneId";
            _comboBoxError = true;
            LoadAllVistorList();
        }

        private void zoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_comboBoxError)
            {
                LoadAllVistorList();
            }
        }

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            int zid = Convert.ToInt32(zoneComboBox.SelectedValue.ToString());
            string zoneName = zoneComboBox.Text;
            saveFileDialog1.FileName = zoneName;
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                if (exportManager.ExportToExcel(zid,name))
                {
                    MessageBox.Show(@"Saved Excel file in "+name);
                }
                else
                {
                    MessageBox.Show(@"Error Occured In Saving File");
                }
                

            }
            
             
        }

        private void LoadAllVistorList()
        {
            int zid = Convert.ToInt32(zoneComboBox.SelectedValue.ToString());
            string total = loadManager.LoadAllVisitorList(zid).Count.ToString(CultureInfo.InvariantCulture);
            totalTextBox.Text = total;
            List<Visitor> visitors = loadManager.LoadAllVisitorList(zid);
            int counter = 0;
            visitorListView.Items.Clear();
            foreach (Visitor visitor in visitors)
            {
                counter++;
                ListViewItem item = new ListViewItem();
                item.Text = counter.ToString(CultureInfo.InvariantCulture);
                item.SubItems.Add(visitor.Name);
                item.SubItems.Add(visitor.Email);
                item.SubItems.Add(visitor.Contact);
                visitorListView.Items.Add(item);
            }
            
            visitorListView.BackColor = Color.White;
            visitorListView.ForeColor = Color.DarkBlue;
        }
    }
}
