using System;
using System.Windows.Forms;

namespace EmployeeManagment.UI
{
    public partial class MenuUi : Form
    {
        public MenuUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SaveUi saveUi= new SaveUi();
            saveUi.Show();
        }

        private void findAndEdidButton_Click(object sender, EventArgs e)
        {
            searchUi searchUi = new searchUi();
            searchUi.Show();
        }
    }
}
