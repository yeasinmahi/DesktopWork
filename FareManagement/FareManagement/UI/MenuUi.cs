using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareManagement.UI
{
    public partial class MenuUi : Form
    {
        public MenuUi()
        {
            InitializeComponent();
        }

        private void MenuUi_Load(object sender, EventArgs e)
        {
            SetLabelPosition();  
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUi visitorEntryUi = new VisitorEntryUi();
            visitorEntryUi.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeUi zoneTypeUi = new ZoneTypeUi();
            zoneTypeUi.Show();
        }

        private void zoneSpecificDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOfZoneSpecificVisitor reportOfZoneSpecificVisitor = new ReportOfZoneSpecificVisitor();
            reportOfZoneSpecificVisitor.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOfZoneWiseVisitorNumber reportOfZoneWiseVisitorNumber = new ReportOfZoneWiseVisitorNumber();
            reportOfZoneWiseVisitorNumber.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuUi_ResizeEnd(object sender, EventArgs e)
        {
            SetLabelPosition();
        }

        private void SetLabelPosition()
        {
            int screenWidth = ClientRectangle.Width;
            int screenHeight = ClientRectangle.Height;
            int labelHeight = dLabel.Height;
            int labelwidth = dLabel.Width;
            dLabel.Location = new Point((screenWidth - labelwidth) / 2, (screenHeight - labelHeight) / 2);
        }

        private void MenuUi_ClientSizeChanged(object sender, EventArgs e)
        {
            SetLabelPosition();
        }
    }
}
