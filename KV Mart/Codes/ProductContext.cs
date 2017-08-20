using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVM.Codes
{
    public class ProductContext
    {
        MySqlConnection cm = new MySqlConnection(KVM_Settings.cs);

        public ServerToClient GetProducts()
        {
            ServerToClient sc = new ServerToClient();
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Category, SubCategory, Company, ProductName, PackageSize, BuyingValue, SellingValue, MfgDate, ExpDate, Quantity, BarCode, SupplierID FROM product", cm);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sc.DT = ds.Tables[0];
            sc.Count = ds.Tables[0].Rows.Count;
            return sc;
        }

        public Product GetProduct(int ID)
        {
            Product p = new Product();
            MySqlCommand cmd = new MySqlCommand("SELECT Category, SubCategory, Company, ProductName, PackageSize, BuyingValue, SellingValue, MfgDate, ExpDate, Quantity, BarCode, SupplierID FROM product WHERE ID=" + ID, cm);
            try
            {
                cm.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    p.Category = Convert.ToInt32(rd[0]);
                    p.SubCategory = rd[1].ToString();
                    p.Company = rd[2].ToString();
                    p.ProductName = rd[3].ToString();
                    p.PackageSize = rd[4].ToString();
                    p.BuyingValue = Convert.ToDouble(rd[5]);
                    p.SellingValue = Convert.ToDouble(rd[6]);
                    p.MfgDate = rd[7].ToString();
                    p.ExpDate = rd[8].ToString();
                    p.Quantity = Convert.ToInt32(rd[9]);
                    p.BarCode = rd[10].ToString();
                    p.SupplierID = Convert.ToInt32(rd[11]);
                }
            }
            catch {; }
            finally { cm.Close(); }
            return p;
        }
    }
}
