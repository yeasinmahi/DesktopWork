using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagment.BLL;
using EmployeeManagment.model;

namespace EmployeeManagment.UI
{
    public partial class searchUi : Form
    {
        SearchManager _searchManager= new SearchManager();
        public searchUi()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void searchUi_Load(object sender, EventArgs e)
        {
            loadAllDataToListView();
        }

        
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SeachEmployee();
        }

        private void loadAllDataToListView()
        {
            List<Employee> listEmployees = _searchManager.LoadAllEmployees();
            employeeListView.Items.Clear();
            if (listEmployees != null)
            {
                int counter = 1;
                foreach (Employee employee in listEmployees)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = counter++.ToString();
                    item.SubItems.Add(employee.Name);
                    item.SubItems.Add(employee.Email);
                    employeeListView.Items.Add(item);
                }


            }
            else
            {
                MessageBox.Show("No data available right now");
            }
        }

        private void SeachEmployee()
        {
            string name = searchTextBox.Text;
            if (name != "")
            {
                List<Employee> listEmployees = _searchManager.SearchEmployees(name);
                employeeListView.Items.Clear();
                if (listEmployees != null)
                {
                    int counter = 1;
                    foreach (Employee employee in listEmployees)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = counter++.ToString();
                        item.SubItems.Add(employee.Name);
                        item.SubItems.Add(employee.Email);
                        employeeListView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No data available");
                }
            }
            else
            {
                loadAllDataToListView();
            }
            
        }

        private void editContextMenu_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection item = employeeListView.SelectedItems;
            MessageBox.Show(employeeListView.SelectedItems[0].SubItems[0].);
        }

        private void deleteContextMenu_Click(object sender, EventArgs e)
        {

        }

    }
}
