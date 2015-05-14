using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyAndDataBase.BLL;
using PropertyAndDataBase.Model;

namespace PropertyAndDataBase
{
    public partial class StudentUi : Form
    {
        public StudentUi()
        {
            InitializeComponent();

        }

        private bool isUpdateMode = false;
        Student aStudent = new Student();
        Student updateableStudent=new Student();
        StudentManager manager = new StudentManager();

        public void Save()
        {
            string name = studentNameTextBox.Text;
            string email = studentEmailTextBox.Text;
            double cgpa;
            bool isConvertCgpa = Double.TryParse(studentCgpaTextBox.Text, out cgpa);
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Student Name Field Can Not Be Blanked");
            }
            else if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Student Email Field Can Not Be Blanked");
            }
            else if (!isConvertCgpa)
            {
                MessageBox.Show("Input correct Cgpa");
            }
            else
            {
                aStudent.Name = name;
                aStudent.Email = email;
                aStudent.Cgpa = cgpa;

                bool isInsert = manager.Insert(aStudent);
                if (isInsert)
                {
                    MessageBox.Show("Saved Succesfully");
                }
                else
                {
                    MessageBox.Show("Unknown Error Occured");
                }
            }

            ListViewAll();
            ClearText();
        }

        public void Updat()
        {
            string name = studentNameTextBox.Text;
            string email = studentEmailTextBox.Text;
            double cgpa;
            bool isConvertCgpa = Double.TryParse(studentCgpaTextBox.Text, out cgpa);
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Student Name Field Can Not Be Blanked");
            }
            else if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Student Email Field Can Not Be Blanked");
            }
            else if (!isConvertCgpa)
            {
                MessageBox.Show("Input correct Cgpa");
            }
            else
            {
                aStudent.Name = name;
                aStudent.Email = email;
                aStudent.Cgpa = cgpa;

                bool isUpdate = manager.Update(aStudent,updateableStudent);
                if (isUpdate)
                {
                    MessageBox.Show("Update Succesfully");
                }
                else
                {
                    MessageBox.Show("Unknown Error Occured");
                }
            }

            ListViewAll();
            ClearText();
        }
        public void Delete()
        {
            string name = studentNameTextBox.Text;
            string email = studentEmailTextBox.Text;
            double cgpa;
            bool isConvertCgpa = Double.TryParse(studentCgpaTextBox.Text, out cgpa);
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Student Name Field Can Not Be Blanked");
            }
            else if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Student Email Field Can Not Be Blanked");
            }
            else if (!isConvertCgpa)
            {
                MessageBox.Show("Input correct Cgpa");
            }
            else
            {
                aStudent.Name = name;
                aStudent.Email = email;
                aStudent.Cgpa = cgpa;

                bool isUpdate = manager.Delete(aStudent);
                if (isUpdate)
                {
                    MessageBox.Show("Delete Succesfully");
                }
                else
                {
                    MessageBox.Show("Unknown Error Occured");
                }
            }

            ListViewAll();
            ClearText();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isUpdateMode)
            {
                Updat();
                saveButton.Text = "Save";
            }
            else
            {
                Save();
            }
            isUpdateMode = false;
        }

        private void ListViewAll()
        {
            
            List < Student > listStudents= manager.ListViewAll();
            int serial = 1;
            studentInfoListView.Items.Clear();
            foreach (Student student in listStudents)
            {
                
                ListViewItem item= new ListViewItem();
                item.Text = serial++.ToString();
                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.Email);
                item.SubItems.Add(student.Cgpa.ToString());
                studentInfoListView.Items.Add(item);
            }
        }

        private void ClearText()
        {
            studentNameTextBox.Text = "";
            studentEmailTextBox.Text = "";
            studentCgpaTextBox.Text = "";
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            ListViewAll();
        }

        private void studentInfoListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem= new ListViewItem();
            selectedItem = studentInfoListView.SelectedItems[0];
            string name = selectedItem.SubItems[1].Text;
            string email = selectedItem.SubItems[2].Text;
            string cgpa = selectedItem.SubItems[3].Text;
            studentNameTextBox.Text = name;
            studentEmailTextBox.Text = email;
            studentCgpaTextBox.Text = cgpa;
            updateableStudent.Name = name;
            updateableStudent.Email = email;
            updateableStudent.Cgpa = Convert.ToDouble(cgpa);
            isUpdateMode = true;
            saveButton.Text = "Update";

        }

        

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ResetForeColor();
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.ForeColor = Color.LightGray;
                searchTextBox.Text = "Search by Name";
            }
                
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            studentInfoListView.Items.Clear();
            string name = searchTextBox.Text;
            if (!String.IsNullOrWhiteSpace(name))
            {
                if (name!="Search by Name")
                {
                    List<Student> listStudents = manager.SearchStudents(name);
                    int serial = 1;
                    foreach (Student student in listStudents)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = serial++.ToString();
                        item.SubItems.Add(student.Name);
                        item.SubItems.Add(student.Email);
                        item.SubItems.Add(student.Cgpa.ToString());
                        studentInfoListView.Items.Add(item);
                    }
                }
                else
                {
                    ListViewAll();
                }
                
            }
            else
            {
                ListViewAll();
            }

            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();

            isUpdateMode = false;
            saveButton.Text = "Save";
        }
    }
}
