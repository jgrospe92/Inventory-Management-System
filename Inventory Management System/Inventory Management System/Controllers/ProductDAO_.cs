using Inventory_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Controllers
{
    public class ProductDAO_ : Controllers.DataAccessObject<Product_>
    {

        Product_ product_;

        public ProductDAO_() { this.product_ = new Product_(); }

        public ProductDAO_(Product_ product_) { this.product_ = product_; }

        public bool delete(int product_ID)
        {
            Models.Product_ productHelper = new Models.Product_();
            if (productHelper.delete(product_ID))
            {
                return true;
            }
            return false;
          
        }

        public Product_ get(int id)
        {
            // Use this to get a specific product
            Models.Product_ product = new Models.Product_();
            product = product.get(id);
            return product;
        }

        public List<Product_> getAll()
        {
            Models.Product_ product = new Models.Product_();
            List<Product_> proudcts = new List<Product_>();
            proudcts = product.getAllProducts(); ;
            return proudcts;
        }
        public List<Product_> getAllFromNotification()
        {
            Product_ product = new Product_();
            List<Product_> proudcts = product.getAllProductsFromNotif();
            return proudcts;
        }

        public List<Product_> getAllLowStocks()
        {
            Product_ product = new Product_();
            List<Product_> proudcts = product.getAllLowStocks();
            return proudcts;
        }

        public List<Product_> searchByKeyWord(string name) 
        {
            Models.Product_ product = new Models.Product_();
            List<Product_> proudcts = new List<Product_>();
            proudcts = product.searchByName(name);
            return proudcts;
        }

        public void insert()
        {

            product_.insert();
        }

        public bool update(int product_ID)
        {
            return false;
        }

        // UPDATE JUST THE QTY
        public bool updateProdQTY(Models.Product_ product)
        {
           
            if (product.updateQTY(product.ProductQTY, product.Product_ID))
            {
                return true;
            }
            return false;
        }

        // NOTIFICATION TABLE
        public bool checkLowStock()
        {
            Product_ product = new Product_();
            if (product.checkNotificationTable())
            {
                return true;
            }
            return false;
        }
    }


}
