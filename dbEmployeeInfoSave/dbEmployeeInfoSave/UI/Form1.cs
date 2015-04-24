using System;
using System.Windows.Forms;
using dbEmployeeInfoSave.BLL;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmployeeInfo employee = new EmployeeInfo();
        EmpManager manager = new EmpManager();

        private void ClearText()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            addressRichTextBox.Text = "";
            salaryTextBox.Text = "";
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressRichTextBox.Text;
            double salary;
            bool isConvert = double.TryParse(salaryTextBox.Text, out salary);
            if (name == "")
            {
                MessageBox.Show(@"Name can not be blanked");
            }
            else if (email == "")
            {
                MessageBox.Show(@"Email can not be blanked");
            }
            else if (address == "")
            {
                MessageBox.Show(@"Address box can not be blanked");
            }
            else if (!isConvert)
            {
                MessageBox.Show(@"Give a correct salary");
            }
            else
            {
                employee.SetValue(name, email, address, salary);
                MessageBox.Show(manager.Insert(employee));
            }
            ClearText();
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Show();
            Hide();
        }
    }
}
