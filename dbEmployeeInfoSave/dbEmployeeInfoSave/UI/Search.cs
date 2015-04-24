using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using dbEmployeeInfoSave.BLL;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave.UI
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        EmpManager manager = new EmpManager();

        private void Search_Load(object sender, EventArgs e)
        {
            List<EmployeeInfo> listEmployee = manager.LoadAllEmp();
            foreach (EmployeeInfo info in listEmployee)
            {
                ListViewItem item = new ListViewItem();
                item.Text = info.id.ToString(CultureInfo.InvariantCulture);
                item.SubItems.Add(info.name);
                item.SubItems.Add(info.email);
                item.SubItems.Add(info.address);
                item.SubItems.Add(info.salary.ToString(CultureInfo.InvariantCulture));

                listView1.Items.Add(item);

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1) this.Parent;
            parent.Show();
            Close();
            Dispose();

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            List<EmployeeInfo> listEmployee = manager.Search(nameTextBox.Text);
            listView1.Items.Clear();

            foreach (EmployeeInfo info in listEmployee)
            {
                ListViewItem item = new ListViewItem {Text = info.id.ToString(CultureInfo.InvariantCulture)};
                item.SubItems.Add(info.name);
                item.SubItems.Add(info.email);
                item.SubItems.Add(info.address);
                item.SubItems.Add(info.salary.ToString(CultureInfo.InvariantCulture));

                listView1.Items.Add(item);

            }
        }
    }
}
