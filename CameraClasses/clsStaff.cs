using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace CameraClasses
{
    public class clsStaff
    {
        public string StaffName { get;  set; }
        public int StaffId { get;  set; }
        public DateTime DOB { get;  set; }
        public DateTime DateAdded { get;  set; }
        public int StaffPhoneNo { get;  set; }
        public string PostCode { get;  set; }
        public string HouseNo { get; set; }
        public string Street { get;  set; }
    }
}