using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProductInfo.BLL;
using ProductInfo.Model;

namespace ProductInfo.UI
{
    public partial class ProductFormUi : Form
    {
        readonly Product _product = new Product();
        readonly ProductManager _manager = new ProductManager();

        public ProductFormUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string productCode = codeTextBox.Text;
            string description = descriptionRichTextBox.Text;
            int quantity;
            bool isConvert=int.TryParse(quantityTextBox.Text, out quantity);
            if (productCode=="")
            {
                MessageBox.Show("Input a product code");
            }
            else if (productCode.Length<3)
            {
                MessageBox.Show("Enter minimum 3 lenght product code");
            }
            else if (description=="")
            {
                MessageBox.Show("Input any description about this product");
            }
            else if (isConvert)
            {
                if (quantity<0)
                {
                    MessageBox.Show("Quantity never can negative");
                }
                else
                {
                    _product.Code = productCode;
                    _product.Description = description;
                    _product.Quantity = quantity;
                    if (_manager.Insert(_product))
                    {
                        MessageBox.Show("Saved successfuly");
                        LoadAllProduct();
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Cannot saved");
                    }
                    

                }
            }
            else
            {
                MessageBox.Show("Quntity should be number");
            }
        }

        private void LoadAllProduct()
        {
            productListView.Items.Clear();
            List<Product> productList = _manager.LoadAllPoduct();
            foreach (Product product in productList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = product.Code;
                item.SubItems.Add(product.Description);
                item.SubItems.Add(product.Quantity.ToString());
                productListView.Items.Add(item);
            }
            totalQuantity.Text = _manager.TotalQuantity().ToString();
        }

        private void ProductFormUi_Load(object sender, EventArgs e)
        {
            LoadAllProduct();
        }

        private void ClearText()
        {
            codeTextBox.Text = String.Empty;
            descriptionRichTextBox.Text = String.Empty;
            quantityTextBox.Text = String.Empty;
        }
    }
}
