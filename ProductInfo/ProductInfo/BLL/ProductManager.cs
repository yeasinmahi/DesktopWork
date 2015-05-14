using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInfo.DAL;
using ProductInfo.Model;

namespace ProductInfo.BLL
{
    class ProductManager
    {
        readonly ProductGatway _gatway= new ProductGatway();

        public bool Insert(Product product)
        {
            if (_gatway.IsCode(product))
            {
                return _gatway.Update(product)>0;
            }
            return _gatway.Insert(product) > 0;
        }

        public List<Product> LoadAllPoduct()
        {
            return _gatway.LoadAllPoduct();
        }

        public int TotalQuantity()
        {
            return _gatway.TotalQuantity();
        }
    }
}
