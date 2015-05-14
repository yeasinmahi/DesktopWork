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
using EmployeeManagment.model;

namespace EmployeeManagment.UI
{
    public partial class DesignationUi : Form
    {
        public DesignationUi()
        {
            InitializeComponent();
        }
        DesignationManager designationManager = new DesignationManager();
        Designation designation = new Designation();
        private void saveButton_Click(object sender, EventArgs e)
        {
            string code = codeTextbox.Text;
            string title = titleTextbox.Text;
            if (code=="")
            {
                MessageBox.Show("Code Can not be Empty");
            }
            else if (title=="")
            {
                MessageBox.Show("Title Can not be Empty");
            }
            else
            {
                designation.code = code;
                designation.title = title;
                if (designationManager.Insert(designation))
                {
                    MessageBox.Show("Successfully inserted");
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                }
            }
        }

        private void ClearText()
        {
            codeTextbox.Text = String.Empty;
            titleTextbox.Text = "";
        }
    }
}
