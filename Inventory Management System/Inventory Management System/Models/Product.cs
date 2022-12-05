using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class Product
    {
        private int product_ID;
        private String productLotNum;
        private String productCode;
        private String productName;
        private int productQTY;
        private String size;
        private String category;
        private int minToReorder;
        private String prodLocation;
        private String productType;
        private String productStatus;
        private DateTime dateAdded;
        private DateTime lastUpdated;
        private String inventoryStatus;
    }
}
