using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfo
{
    public partial class Form1 : Form
    {
        private Hashtable _bookHashtable = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void _addBook()
        {
            _bookHashtable.Add(addISBNTextBox.Text,addBookDetailsRichTextBox.Text);
            addISBNTextBox.Text = String.Empty;
            addBookDetailsRichTextBox.Text = String.Empty;
            MessageBox.Show("Succdessfuly Saved");
        }

        private void _search()
        {
            string keyvalue = searchISBNTextBox.Text;
            if (_bookHashtable.ContainsKey(keyvalue))
            {
                searchBookDetailsRichTextBox.Text = _bookHashtable[keyvalue].ToString();
            }
            else
            {
                MessageBox.Show("Cannot Find book");
            }
            
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            _addBook();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            _search();
        }
    }
}
