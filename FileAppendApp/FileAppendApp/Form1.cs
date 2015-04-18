using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAppendApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"E:\ashik\project\FileAppendApp\MyFile\Yeasin.text";
        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aStream= new FileStream(path,FileMode.Append);
            StreamWriter aWriter= new StreamWriter(aStream);
            aWriter.WriteLine(nameTextBox.Text);
            MessageBox.Show("Saved Successfuly");
            nameTextBox.Text = String.Empty;
            aWriter.Close();
            aStream.Close();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            FileStream aStream = new FileStream(path, FileMode.Open);
            StreamReader aReader= new StreamReader(aStream);
            string name = "";
            while (!aReader.EndOfStream)
            {
                name = aReader.ReadLine();
                listBox.Items.Add(name);
            }
            nameTextBox.Text = String.Empty;
            aReader.Close();
            aStream.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(path, FileMode.Truncate);
            aStream.Close();
        }
    }
}
