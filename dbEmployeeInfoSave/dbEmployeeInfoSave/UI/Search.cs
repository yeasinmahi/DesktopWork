using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbEmployeeInfoSave.BLL;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        EmpManager manager = new EmpManager();
        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            List<EmployeeInfo> listEmployee = new List<EmployeeInfo>();
            listEmployee=manager.LoadAllEmp();
            foreach (EmployeeInfo info in listEmployee)
            {
                ListViewItem item = new ListViewItem();
                item.Text = info.id.ToString();
                item.SubItems.Add(info.name);
                item.SubItems.Add(info.email);
                item.SubItems.Add(info.address);
                item.SubItems.Add(info.salary.ToString());

                listView1.Items.Add(item);

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            this.Dispose();

        }
    }
}
