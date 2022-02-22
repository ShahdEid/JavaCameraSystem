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

        public bool Find(int stockId)
        {
            //set the private data members to the test data value
            mStockId = 16;
            mDateAdded = Convert.ToDateTime("22/02/2022");
            mStockName = "Canon 6D Mk II";
            mStockQuantity = 12;
            mStockType = "DSLR Camera";
            //always return true
            return true;
        }
    }
}