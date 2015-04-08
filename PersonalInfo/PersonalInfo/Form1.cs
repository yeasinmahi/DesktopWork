using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfo
{
    
    public partial class personalInfo : Form
    {
        private string firstName = "";
        private string lastName = "";
        private string fatherName = "";
        private string motherName = "";
        private string address = "";

        private string nameMessage = "";
        private string parentMessage = "";
        private string addressMessage = "";
        public personalInfo()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SetInfo();
            DoClear();
        }

        private void showAllInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameMessage+parentMessage+addressMessage);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameMessage);
        }

        private void parentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(parentMessage);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(addressMessage);
        }

        private void SetInfo()
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            address = addressTextBox.Text;
            nameMessage = "First Name: " + firstName + "\nLast Name: " + lastName + "\n";
            parentMessage = "Father Name: " + fatherName + "\nMother Name: " + motherName + "\n";
            addressMessage = "Address : " + address;
            MessageBox.Show("Successfully Saved");
        }

        private void DoClear()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            addressTextBox.Text = "";
        }

    }
}
