using Inventory_Management_System.Controllers;
using Microsoft.VisualBasic.Devices;
using MySqlConnector;
using System;
using System.Collections;
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

        public Product_(string productLotNum,
            string productCode, string productName, int productQTY,
            string size, string category, int minToReorder, string prodLocation,
            string productType, string productStatus, DateTime dateAdded,
            DateTime lastUpdated, string inventoryStatus)
        {
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
        public int Product_ID { get => product_ID; set => product_ID = value; }

        // CRUD OPERATIONS
        public Product_ get(int product_ID)
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            //con.OpenAsync().Wait();
            con.Open();

            var cmd = new MySqlCommand();

            try
            {
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM product WHERE product_ID = @product_ID";
                cmd.Parameters.AddWithValue("product_id", product_ID);

                using MySqlDataReader rdr = cmd.ExecuteReader();
                Product_ p = new Product_();

                if (rdr.Read())
                {
                    p.Product_ID = rdr.GetInt32("product_ID");
                    p.ProductLotNum = rdr.GetString("productLotNum");
                    p.ProductCode = rdr.GetString("productCode");
                    p.ProductName = rdr.GetString("productName");
                    p.ProductQTY = rdr.GetInt32("productQTY");
                    p.Size = rdr.GetString("size");
                    p.Category = rdr.GetString("category");
                    p.MinToReorder = rdr.GetInt32("minToReorder");
                    string location = (rdr["prodLocation"] == DBNull.Value) ? "NA" : rdr.GetString("prodLocation");
                    p.ProdLocation = location;
                    p.ProductType = rdr.GetString("productType");
                    p.ProductStatus = rdr.GetString("productStatus");
                    p.DateAdded = rdr.GetDateTime("dateAdded");
                    //DateTime? date = (DateTime)((rdr["lastUpdated"] == DBNull.Value) ? (DateTime?)null : rdr.GetDateTime("lastUpdated"));
                    p.LastUpdated = Helper.DateHelper.ConvertFromDBVal<DateTime>(rdr["lastUpdated"]);
                    p.InventoryStatus = rdr.GetString("inventoryStatus");
                    return p;

                }
               
            } catch (Exception e)
            {
                MessageBox.Show("DATABASE ERROR, CANT RETRIEVE PRODUCT DATA");
            }
            finally
            {
                //con.CloseAsync().Wait();
                con.Close();
            }

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
            newProduct.ProductType = type;
            newProduct.ProductStatus= prodStatus;
            newProduct.DateAdded = dateAdded;
            newProduct.InventoryStatus= invetoryStatus;
            return newProduct;
        }

        public List<Product_> searchByName(string keyword)
        {
            if (string.IsNullOrEmpty(keyword)) { return null; }
            MySqlConnection con = Helper.DbHelper.createConnection();
            //con.OpenAsync().Wait();
            con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM product WHERE productName LIKE @productName OR productCode LIKE @productCode";
            cmd.Parameters.AddWithValue("productName", "%" + keyword + "%");
            cmd.Parameters.AddWithValue("productCode", "%" + keyword + "%");
            using MySqlDataReader rdr = cmd.ExecuteReader();
            List<Product_> products = new List<Product_>();
            while (rdr.Read())
            {
                Product_ p = new Product_();
                p.Product_ID = rdr.GetInt32("product_id");
                p.ProductLotNum = rdr.GetString("productLotNum");
                p.ProductCode = rdr.GetString("productCode");
                p.ProductName = rdr.GetString("productName");
                p.ProductQTY = rdr.GetInt32("productQTY");
                p.Size = rdr.GetString("size");
                p.Category = rdr.GetString("category");
                p.MinToReorder = rdr.GetInt32("minToReorder");
                string location = (rdr["prodLocation"] == DBNull.Value) ? "NA" : rdr.GetString("prodLocation");
                p.ProdLocation = location;
                p.ProductType = rdr.GetString("productType");
                p.ProductStatus = rdr.GetString("productStatus");
                p.DateAdded = rdr.GetDateTime("dateAdded");
                p.LastUpdated = Helper.DateHelper.ConvertFromDBVal<DateTime>(rdr["lastUpdated"]);
                p.InventoryStatus = rdr.GetString("inventoryStatus");

                products.Add(p);
            }
            con.Close();
            return products;
        }

        public List<Product_> getAllProducts()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.OpenAsync().Wait();
            //con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM product";
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Product_> products = new List<Product_>();
            while (rdr.Read())
            {
                Product_ p = new Product_();

                p.Product_ID = rdr.GetInt32("product_id");
                p.ProductLotNum = rdr.GetString("productLotNum");
                p.ProductCode = rdr.GetString("productCode");
                p.ProductName = rdr.GetString("productName");
                p.ProductQTY = rdr.GetInt32("productQTY");
                p.Size = rdr.GetString("size");
                p.Category = rdr.GetString("category");
                p.MinToReorder = rdr.GetInt32("minToReorder");
                string location = (rdr["prodLocation"] == DBNull.Value) ? "NA" : rdr.GetString("prodLocation");
                p.ProdLocation = location;
                p.ProductType = rdr.GetString("productType");
                p.ProductStatus = rdr.GetString("productStatus");
                p.DateAdded = rdr.GetDateTime("dateAdded");
                p.LastUpdated = Helper.DateHelper.ConvertFromDBVal<DateTime>(rdr["lastUpdated"]);
                p.InventoryStatus = rdr.GetString("inventoryStatus");

               products.Add(p);
            }
            con.Close();
            return products;
        }

        // GET ALL LOW STOCK
        public List<Product_> getAllLowStocks()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.OpenAsync().Wait();
            //con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM product WHERE productQTY < minToReorder";
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Product_> products = new List<Product_>();
            while (rdr.Read())
            {
                Product_ p = new Product_();

                p.Product_ID = rdr.GetInt32("product_id");
                p.ProductLotNum = rdr.GetString("productLotNum");
                p.ProductCode = rdr.GetString("productCode");
                p.ProductName = rdr.GetString("productName");
                p.ProductQTY = rdr.GetInt32("productQTY");
                p.Size = rdr.GetString("size");
                p.Category = rdr.GetString("category");
                p.MinToReorder = rdr.GetInt32("minToReorder");
                string location = (rdr["prodLocation"] == DBNull.Value) ? "NA" : rdr.GetString("prodLocation");
                p.ProdLocation = location;
                p.ProductType = rdr.GetString("productType");
                p.ProductStatus = rdr.GetString("productStatus");
                p.DateAdded = rdr.GetDateTime("dateAdded");
                p.LastUpdated = Helper.DateHelper.ConvertFromDBVal<DateTime>(rdr["lastUpdated"]);
                p.InventoryStatus = rdr.GetString("inventoryStatus");

                products.Add(p);
            }
            con.Close();
            return products;
        }

        // Update just the quantity
        public bool updateQTY(int qty, int id)
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
          
            try
            {
                con.OpenAsync().Wait();
                var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE product SET productQTY = @productQTY WHERE product_ID = @product_ID ";
                cmd.Parameters.AddWithValue("productQTY", qty);
                cmd.Parameters.AddWithValue("product_ID", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database ERROR: failesd to update ");
            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool update()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();

            //con.OpenAsync().Wait();
            con.Open();
            try
            {

            var cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE product SET productLotNum=@productLotNum, productCode=@productCode, productName=@productName, productQTY=@productQTY, size=@size, category=@category, minToReorder=@minToReorder, prodLocation=@prodLocation," +
                    " productType=@productType, productStatus=@productStatus, dateAdded=@dateAdded, lastUpdated=@lastUpdated, inventoryStatus=@inventoryStatus WHERE product_ID=@product_ID";

                cmd.Parameters.AddWithValue("product_ID", Product_ID);
                cmd.Parameters.AddWithValue("productLotNum", ProductLotNum);
                cmd.Parameters.AddWithValue("productCode", ProductCode);
                cmd.Parameters.AddWithValue("productName", ProductName);
                cmd.Parameters.AddWithValue("productQTY", ProductQTY);
                cmd.Parameters.AddWithValue("size", Size);
                cmd.Parameters.AddWithValue("category", Category);
                cmd.Parameters.AddWithValue("minToReorder", MinToReorder);
                cmd.Parameters.AddWithValue("prodLocation", ProdLocation);
                cmd.Parameters.AddWithValue("productType", ProductType);
                cmd.Parameters.AddWithValue("productStatus", ProductStatus);
                cmd.Parameters.AddWithValue("dateAdded", DateAdded);
                cmd.Parameters.AddWithValue("lastUpdated", LastUpdated);
                cmd.Parameters.AddWithValue("inventoryStatus", InventoryStatus);

                cmd.ExecuteNonQuery();
                return true;

            } catch (Exception e)
            {
                MessageBox.Show("DATABASE ERROR: " + e.Message);
            } finally
            {
                con.Close();
            }

            return false;
        }

        public bool insertToNotif(int product_ID)
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.Open();
            try
            {
                var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO notification(product_ID) VALUES (@product_ID)";
                cmd.Parameters.AddWithValue("product_ID", product_ID);
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception e)
            {
                MessageBox.Show("DATABASE ERROR INSERT NOTIF: " + e);
            }finally
            {
                con.Close();
            }
            return false;
           
        }
        // CHECK IF Notificaton table has products
        public bool checkNotificationTable()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.Open();
            try
            {
                var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT COUNT(*) FROM notification";
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("DATABASE ERROR WHEN CHECKING NOTIF TABLE: " + e);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        // GET ALL PRODUCTS FROM REPORT
        public List<Product_> getAllProductsFromNotif()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.OpenAsync().Wait();
            //con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT product.* from product INNER JOIN notification WHERE product.product_ID = notification.product_ID";
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Product_> products = new List<Product_>();
            while (rdr.Read())
            {
                Product_ p = new Product_();

                p.Product_ID = rdr.GetInt32("product_id");
                p.ProductLotNum = rdr.GetString("productLotNum");
                p.ProductCode = rdr.GetString("productCode");
                p.ProductName = rdr.GetString("productName");
                p.ProductQTY = rdr.GetInt32("productQTY");
                p.Size = rdr.GetString("size");
                p.Category = rdr.GetString("category");
                p.MinToReorder = rdr.GetInt32("minToReorder");
                string location = (rdr["prodLocation"] == DBNull.Value) ? "NA" : rdr.GetString("prodLocation");
                p.ProdLocation = location;
                p.ProductType = rdr.GetString("productType");
                p.ProductStatus = rdr.GetString("productStatus");
                p.DateAdded = rdr.GetDateTime("dateAdded");
                p.LastUpdated = Helper.DateHelper.ConvertFromDBVal<DateTime>(rdr["lastUpdated"]);
                p.InventoryStatus = rdr.GetString("inventoryStatus");

                products.Add(p);
            }
            con.Close();
            return products;
        }

        public async void insert()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();
    
            //con.OpenAsync().Wait();
            con.Open();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO product(productLotNum, productCode, productName, productQTY, size," +
                "category, minToReorder, prodLocation, productType, productStatus, dateAdded, lastUpdated, inventoryStatus)" +
                "VALUES(@productLotNum, @productCode, @productName, @productQTY, @size, @category, @minToReorder, @prodLocation," +
                " @productType, @productStatus, @dateAdded, @lastUpdated, @inventoryStatus)";

            cmd.Parameters.AddWithValue("productLotNum", this.ProductLotNum);
            cmd.Parameters.AddWithValue("productCode", this.ProductCode);
            cmd.Parameters.AddWithValue("productName", this.ProductName);
            cmd.Parameters.AddWithValue("productQTY", this.ProductQTY);
            cmd.Parameters.AddWithValue("size", this.Size);
            cmd.Parameters.AddWithValue("category", this.Category);
            cmd.Parameters.AddWithValue("minToReorder", this.MinToReorder);
            cmd.Parameters.AddWithValue("prodLocation", this.ProdLocation);
            cmd.Parameters.AddWithValue("productType", this.ProductType);
            cmd.Parameters.AddWithValue("productStatus", this.ProductStatus);
            cmd.Parameters.AddWithValue("dateAdded", this.DateAdded);
            cmd.Parameters.AddWithValue("lastUpdated", this.LastUpdated);
            cmd.Parameters.AddWithValue("inventoryStatus", this.InventoryStatus);
          
            int i = await cmd.ExecuteNonQueryAsync();
            con.Close();
        }

        public bool delete(int product_ID)
        {
            MySqlConnection con = Helper.DbHelper.createConnection();

            //con.OpenAsync().Wait();
            try
            {
                con.Open();
                var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM product WHERE product_ID = @product_ID";
                cmd.Parameters.AddWithValue("product_ID", product_ID);
                cmd.ExecuteNonQuery();
                return true;
            } catch(Exception ex)
            {
                MessageBox.Show("DATABASE ERROR, can't delete product");
            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }

    
}
