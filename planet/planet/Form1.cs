using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planet
{
    public partial class Planet : Form
    {
        private int _planetNo = 0;
        public Planet()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            _planetNo= planetComboBox.SelectedIndex;
            MessageBox.Show("This is "+_planetNo+" number planet");
        }
    }
}
