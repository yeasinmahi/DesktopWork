using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKepper
{
    public partial class Form1 : Form
    {
        private readonly List<string> _addEmaiList= new List<string>();
        private  List<string>  _searchEmaiList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmail();
            ShowEmail();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchEmail();
        }

        private void AddEmail()
        {
            string email = addTextBox.Text;
            addTextBox.Text = String.Empty;
            if (email.Contains('@')&& email.Contains('.'))
            {
                _addEmaiList.Add(email);
            }
            else
            {
                MessageBox.Show("Email Error");
            }
            
        }

        private void ShowEmail()
        {
            addListBox.Items.Clear();
            foreach (string s in _addEmaiList)
            {
                addListBox.Items.Add(s);
            }
        }

        private void SearchEmail()
        {
            searchListBox.Items.Clear();
            string searchEmail = searchTextBox.Text;
            searchTextBox.Text = String.Empty;
            foreach (string s in _addEmaiList)
            {
                if (s.Contains(searchEmail))
                {
                    searchListBox.Items.Add(s);
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //SearchEmail();
        }
    }
}
