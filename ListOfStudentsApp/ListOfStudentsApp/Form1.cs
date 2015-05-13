using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfStudentsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> studentList = new List<Student>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (studentList.Count <3)
            {
                Student studentObj = new Student();
                studentObj.regNo = regNoTextBox.Text;
                studentObj.firstName = firstNameTextBox.Text;
                studentObj.lastName = lastNameTextBox.Text;
                studentList.Add(studentObj);
                ClearTextBox(); 
            }
            else
            {
                MessageBox.Show("Not enough memory to save more student . ");
                ClearTextBox();
            }            

        }
        private void ClearTextBox()
        {
            regNoTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }
        string studentsInfo = "Student Info\n\nRegistration No         Student name\n";
        private void showAllButton_Click(object sender, EventArgs e)
        {
          //  string studentsInfo = "Student Info\n\nRegistration No  First Name      Last Name \n ";

            foreach (Student students in studentList)
            {
                studentsInfo = studentsInfo + students.regNo + "\t\t" + students.firstName + " " + students.lastName +
                               "\n";
            }

            MessageBox.Show(studentsInfo);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            studentList = new List<Student>();
            studentsInfo = "No students saved . ";
        }
    }
}
