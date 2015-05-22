using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagment.BLL;
using EmployeeManagment.DAL;
using EmployeeManagment.model;

namespace EmployeeManagment.UI
{
    public partial class SaveUi : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public SaveUi()
        {
            InitializeComponent();
        }

        private void addMoreButton_Click(object sender, EventArgs e)
        {
            DesignationUi designationUi = new DesignationUi();
            designationUi.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            int desId = Convert.ToInt32(designationComboBox.SelectedValue.ToString());

            if (name=="")
            {
                MessageBox.Show("Name Can not Be Empty");
            }else if (email=="")
            {
                MessageBox.Show("Email Can not Be Empty");
            }else if (address=="")
            {
                MessageBox.Show("Address Can not Be Empty");
            }else if (desId<1)
            {
                MessageBox.Show("You Should Select A Designation");
            }
            else
            {
                Employee employee = new Employee();
                employee.Name = name;
                employee.Email = email;
                employee.Address = address;
                employee.DesId = desId;
                if (employeeManager.Insert(employee))
                {
                    MessageBox.Show("Successfully Inserted");
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }
            }
            
        }

        private void ClearText()
        {
            nameTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            addressTextBox.Text = String.Empty;
        }

        private void SaveUi_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            List<Designation> listDesignations = employeeManager.ComboBoxDesignationsList();
            //foreach (Designation designation in listDesignations)
            //{
            //    designationComboBox.Items.Add(designation.code);
            //}
            designationComboBox.DataSource = null;
            designationComboBox.DisplayMember = "code";
            designationComboBox.ValueMember = "desId";
            designationComboBox.DataSource = listDesignations;
        }
    }
}
