using System;
using System.Drawing;
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

        private void SetLabelPosition()
        {
            screenWidth = ClientRectangle.Width;
            screenHeight = ClientRectangle.Height;
            labelHeight = dLabel.Height;
            labelwidth = dLabel.Width;
            dLabel.Location = new Point((screenWidth - labelwidth) / 2, (screenHeight - labelHeight) / 2);
            widthDifference = screenWidth - 40;
            heightDifference = screenHeight - 40;
        }

        private void MenuUi_ClientSizeChanged(object sender, EventArgs e)
        {
            SetLabelPosition();
        }

        private int screenWidth;
        private int screenHeight;
        private int labelHeight;
        private int labelwidth;

        private int widthDifference;
        private int heightDifference;

        private int blueX=500, blueY=500;
        private int blueNewX=5, blueNewY=3;
        private int greenX = 400, greenY = 300;
        private int greenNewX=-5, greenNewY=5;
        private int redX = 800, redY = 100;
        private int redNewX=3, redNewY=-5;


        private void timer1_Tick(object sender, EventArgs e)
        {
            BallMoveBlue();
            BallMoveGreen();
            BallMoveRed();
        }

        private void BallMoveBlue()
        {
            if (blueX > widthDifference)
            {
                blueNewX = -5;
            }
            else if (blueX < 0)
            {
                blueNewX = 5;
            }
            else if (blueY > heightDifference)
            {
                blueNewY = -3;
            }
            else if (blueY < 43)
            {
                blueNewY = 3;
            }
            blueX += blueNewX;
            blueY += blueNewY;
            bluePictureBox.Location = new Point(blueX, blueY);
        }

        private void BallMoveGreen()
        {
            if (greenX > widthDifference)
            {
                greenNewX = -5;
            }
            else if (greenX < 0)
            {
                greenNewX = 5;
            }
            else if (greenY > heightDifference)
            {
                greenNewY = -5;
            }
            else if (greenY < 43)
            {
                greenNewY = 5;
            }
            greenX += greenNewX;
            greenY += greenNewY;
            greenPictureBox.Location = new Point(greenX, greenY);
        }
        private void BallMoveRed()
        {
            if (redX > widthDifference)
            {
                redNewX = -3;
            }
            else if (redX < 0)
            {
                redNewX = 3;
            }
            else if (redY > heightDifference)
            {
                redNewY = -5;
            }
            else if (redY < 43)
            {
                redNewY = 5;
            }
            redX += redNewX;
            redY += redNewY;
            redPictureBox.Location = new Point(redX, redY);
        }
    }
}
