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
        //StockId private member variable
        private Int32 mStockId;
        //StockId public property
        public Int32 StockId 
        {
            get
            {
                //this line of code sends data out of the property
                return mStockId;
            }
            set
            {
                //this line of code allows data into the property
                mStockId = value;
            }
        }

        //DateAdded private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //StockName private member variable
        private string mStockName;
        //StockName public property
        public string StockName
        {
            get
            {
                //this line of code sends data out of the property
                return mStockName;
            }
            set
            {
                //this line of code allows data into the property
                mStockName = value;
            }
        }

        //StockQuantity private member variable
        private Int32 mStockQuantity;
        //StockQuantity public property
        public Int32 StockQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mStockQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mStockQuantity = value;
            }
        }

        //StockType private member variable
        private string mStockType;
        //StockType public property
        public string StockType
        {
            get
            {
                //this line of code sends data out of the property
                return mStockType;
            }
            set
            {
                //this line of code allows data into the property
                mStockType = value;
            }
        }

        public bool Find(int StockId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockId", StockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mStockType = Convert.ToString(DB.DataTable.Rows[0]["StockType"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating problem
                return false;
            }
        }
    }

   
}