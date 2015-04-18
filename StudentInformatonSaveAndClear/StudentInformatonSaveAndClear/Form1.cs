using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformatonSaveAndClear
{
    public partial class StudentForm : Form
    {
        //private string regNo = "";
        //private string fname = "";
        //private string lname = "";
        private int counter=0;
        List<student> Students = new List<student>();
         
        public StudentForm()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            counter++;
            if (counter<=3)
            {
                student aStudent = new student();
                aStudent.regNo = regNoTextBox.Text;
                aStudent.fname = firstNameTextBox.Text;
                aStudent.lname = lastNameTextBox.Text;
                Students.Add(aStudent);
                MessageBox.Show("Successfuly Saved");
            }
            else
            {
                MessageBox.Show("Can not add more than 3 student information");
            }
            
        }
        private void ClearText()
        {
            regNoTextBox.Text = String.Empty;
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
        }
        private void ClearValue()
        {
            counter = 0;
            Students.Clear();
        }

        private void ShowToAll()
        {
            string studentInfo = "";
            foreach (student student in Students)
            {
                studentInfo += "\nRegistration No: ";
                studentInfo += student.regNo;
                studentInfo += "\nName: ";
                studentInfo += student.GetFullName();
                studentInfo += "\n\n";

            }
            MessageBox.Show(studentInfo);
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            SetValue();
            
            ClearText();
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            ShowToAll();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearText();
            ClearValue();
        }
    }
}
