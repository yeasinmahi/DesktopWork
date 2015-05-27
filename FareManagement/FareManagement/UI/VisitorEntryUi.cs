using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FareManagement.BLL;
using FareManagement.Model;

namespace FareManagement.UI
{
    public partial class VisitorEntryUi : Form
    {
        LoadManager loadManager = new LoadManager();
        VisitorEntryManager visitorEntryManager = new VisitorEntryManager();
        List<CheckBox> listCheckBoxs = new List<CheckBox>();

        public VisitorEntryUi()
        {
            InitializeComponent();
        }

        private void VisitorEntryUi_Load(object sender, EventArgs e)
        {
            List<Zone> listZones = loadManager.LoadAllZone();
            int checkBoxPositionY = 280;
            foreach (Zone zone in listZones)
            {
                checkBoxPositionY += 30;
               DrawCheckBox(zone.ZoneName,zone.ZoneId,checkBoxPositionY);
            }

        }

        private void DrawCheckBox(string name,int zid, int checkBoxPositionY)
        {
            CheckBox checkBox= new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new Point(50, checkBoxPositionY);
            checkBox.Name = zid.ToString();
            checkBox.Size = new Size(150, 30);
            checkBox.TabIndex = 0;
            checkBox.Text = name;
            checkBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Checked = true;
            listCheckBoxs.Add(checkBox);
            Controls.Add(checkBox);
            Controls.SetChildIndex(checkBox,0);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<int> checkedList= new List<int>();
            foreach (CheckBox checkBox in listCheckBoxs)
            {
                if (checkBox.Checked)
                {
                    checkedList.Add(Convert.ToInt32(checkBox.Name));
                }
            }
            
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string contact = contactTextBox.Text;

            if (name.Equals(""))
            {
                MessageBox.Show(@"Name Can not be Blanked");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show(@"Email Can not be Blanked");
            }
            else if(contact.Equals(""))
            {
                MessageBox.Show(@"Contact Can not be Blanked");
            }
            else if (checkedList.Count<=0)
            {
                MessageBox.Show(@"You must have to select minimum 1 Zone");
            }
            else
            {
                Visitor visitor = new Visitor();
                visitor.Name = name;
                visitor.Email = email;
                visitor.Contact = contact;

                MessageBox.Show(visitorEntryManager.InsertVisitor(visitor));
                if (visitorEntryManager.IsInsertVisitor)
                {
                    int vid = visitorEntryManager.GetVisitorIdByEmail(visitor);
                    foreach (int zid in checkedList)
                    {
                        VisitorAndZone visitorAndZone = new VisitorAndZone();
                        visitorAndZone.VisitorId = vid;
                        visitorAndZone.ZoneId = zid;
                        visitorEntryManager.InsertVisitorAndZone(visitorAndZone);
                    }
                }
            }
        }
    }
}
