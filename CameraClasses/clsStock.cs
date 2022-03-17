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

        //StockPrice private member variable
        private decimal mStockPrice;
        //StockPrice public property
        public decimal StockPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mStockPrice;
            }
            set
            {
                //this line of code allows data into the property
                mStockPrice = value;
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
                mStockPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["StockPrice"]);
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

        public string Valid(string stockName, string stockType, string stockPrice, string stockQuantity, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the StockName is blank
            if(stockName.Length == 0)
            {
                //record the error
                Error = Error + "The stock name may not be blank : ";
            }
            //if the StockName is greater than 50 characters
            if(stockName.Length > 50)
            {
                //record the error
                Error = Error + "The stock name must be less than 50 characters : ";
            }
            //if the StockType is blank
            if (stockType.Length == 0)
            {
                //record the error
                Error = Error + "The stock type may not be blank : ";
            }
            //if the StockType is greater than 30 characters
            if (stockType.Length > 30)
            {
                //record the error
                Error = Error + "The stock type must be less than 50 characters : ";
            }
            //if the StockQuantity is less than 1
            if (stockQuantity.Length == 0)
            {
                //record the error
                Error = Error + "The stock quantity may not be blank : ";
            }
            //if the StockQuantity is greater than 9999
            if (stockQuantity.Length > 4)
            {
                //record the error
                Error = Error + "The stock quantity must be less than 9 999 : ";
            }
            //if the StockPrice is blank
            if (stockPrice.Length == 0)
            {
                //record the error
                Error = Error + "The stock price may not be blank : ";
            }
            //if the StockPrice is greater than 99 999
            if (stockPrice.Length > 5)
            {
                //record the error
                Error = Error + "The stock price must be less than 100 000 : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            
            //return any error messages
            return Error;
        }
    }

   
}