using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVM.Codes
{
    public class ServerToClient
    {
        public DataSet DS { get; set; }
        public DataTable DT { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        public int Category { get; set; }
        public string SubCategory { get; set; }
        public string Company { get; set; }
        public string ProductName { get; set; }
        public string PackageSize { get; set; }
        public double BuyingValue { get; set; }
        public double SellingValue { get; set; }
        public string MfgDate { get; set; }
        public string ExpDate { get; set; }
        public int Quantity { get; set; }
        public string BarCode { get; set; }
        public int SupplierID { get; set; }
    }
}
