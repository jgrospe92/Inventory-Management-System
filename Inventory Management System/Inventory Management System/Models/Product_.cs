using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Management_System.Models
{
    public class Product_
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

        public Product_() { }

        public Product_(int product_ID, string productLotNum,
            string productCode, string productName, int productQTY,
            string size, string category, int minToReorder, string prodLocation,
            string productType, string productStatus, DateTime dateAdded,
            DateTime lastUpdated, string inventoryStatus)
        {
            this.Product_ID = product_ID;
            this.ProductLotNum = productLotNum;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.ProductQTY = productQTY;
            this.Size = size;
            this.Category = category;
            this.MinToReorder = minToReorder;
            this.ProdLocation = prodLocation;
            this.ProductType = productType;
            this.ProductStatus = productStatus;
            this.DateAdded = dateAdded;
            this.LastUpdated = lastUpdated;
            this.InventoryStatus = inventoryStatus;
        }

        public int Product_ID { get => product_ID; set => product_ID = value; }
        public string ProductLotNum { get => productLotNum; set => productLotNum = value; }
        public string ProductCode { get => productCode; set => productCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductQTY { get => productQTY; set => productQTY = value; }
        public string Size { get => size; set => size = value; }
        public string Category { get => category; set => category = value; }
        public int MinToReorder { get => minToReorder; set => minToReorder = value; }
        public string ProdLocation { get => prodLocation; set => prodLocation = value; }
        public string ProductType { get => productType; set => productType = value; }
        public string ProductStatus { get => productStatus; set => productStatus = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }
        public string InventoryStatus { get => inventoryStatus; set => inventoryStatus = value; }

        // CRUD OPERATIONS
        public Product_ get(int product_ID)
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.OpenAsync().Wait();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM product WHERE product_ID = @product_ID";
            cmd.Parameters.AddWithValue("product_ID", product_ID);

            using MySqlDataReader rdr = cmd.ExecuteReader();
            Product_ p = new Product_();
            if (rdr.Read())
            {
                p.ProductLotNum = rdr.GetString("productLotNum");
                p.ProductCode = rdr.GetString("productCode");
                p.ProductName = rdr.GetString("productName");
                p.ProductQTY = rdr.GetInt32("productQTY");
                p.Size = rdr.GetString("size");
                p.Category = rdr.GetString("category");
                p.MinToReorder = rdr.GetInt32("minToReorder");
                string location = (rdr["prodLocation"] == DBNull.Value) ? "" : rdr.GetString("prodLocation");
                p.ProdLocation = location;
                p.ProductType = rdr.GetString("productType");
                p.ProductStatus = rdr.GetString("productStatus");
                p.DateAdded = rdr.GetDateTime("dateAdded");
                p.LastUpdated = (DateTime)((rdr["lastUpdated"] == DBNull.Value) ? (DateTime?)null : rdr.GetDateTime("lastUpdated"));

                //p.InventoryStatus = rdr.GetString("inventoryStatus");

                return p;

            }
            con.CloseAsync().Wait();

            return null;
         
        }

        private Product_ create(string lotNum, string code, string name, int qty, string size,
            string? category, int minToOrder, string location, string type, string prodStatus, DateTime dateAdded,
            string invetoryStatus)
        {
            Product_ newProduct = new Product_();
            newProduct.ProductLotNum= lotNum;
            newProduct.ProductCode = code;
            newProduct.ProductName = name;
            newProduct.ProductQTY = qty;
            newProduct.Size= size;
            newProduct.Category = category;
            newProduct.MinToReorder= minToOrder;
            newProduct.ProdLocation = location;
            newProduct.ProductType= type;
            newProduct.ProductStatus= prodStatus;
            newProduct.DateAdded = dateAdded;
            newProduct.InventoryStatus= invetoryStatus;
            return newProduct;
        }
    }
}
