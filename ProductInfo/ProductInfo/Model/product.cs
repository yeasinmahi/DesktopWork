using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfo.Model
{
    class Product
    {
        private string code;
        private string description;
        private int quantity;


        public string Code
        {
            get { return code; }
            set
            {
                if (value.Length>=3)
                {
                    code = value;
                }
                
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
