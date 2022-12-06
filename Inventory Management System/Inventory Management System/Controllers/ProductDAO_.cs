using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Controllers
{
    public class ProductDAO_ : Controllers.DataAccessObject<Product_>
    {
        public void delete()
        {
            throw new NotImplementedException();
        }

        public Product_ get<A>()
        {
            Models.Product_ product = new Models.Product_();
            product = product.get(1);
            MessageBox.Show(product.ProductName + " " + product.ProdLocation);

            return null;
        }

        public void getAll()
        {
            throw new NotImplementedException();
        }

        public void insert()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
