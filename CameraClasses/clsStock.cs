using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace CameraClasses
{
    public class clsStock
    {
        public DateTime DateAdded { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }
        public int StockQuantity { get; set; }
        public string StockType { get; set; }
    }
}