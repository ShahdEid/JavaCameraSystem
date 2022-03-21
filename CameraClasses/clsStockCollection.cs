using System.Collections.Generic;
using System;
using CameraClasses;

namespace CameraClasses
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            /*//var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectALL");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank record
                clsStock MyStock = new clsStock();
                //read in the fields from the current record
                MyStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                MyStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                MyStock.StockType = Convert.ToString(DB.DataTable.Rows[Index]["StockType"]);
                MyStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                MyStock.StockPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["StockPrice"]);
                MyStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStockList.Add(MyStock);
                //point at the next record
                Index++;*/
            }
        
        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        public int Count 
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set 
            { 
                //
            } 
        }
        public clsStock ThisStock 
        { 
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@StockType", mThisStock.StockType);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStock
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@StockType", mThisStock.StockType);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByType(string StockType)
        {
            //filters the records based on a stock type
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the StockType parameter to the database
            DB.AddParameter("@StockType", StockType);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockType");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank address
                clsStock MyStock = new clsStock();
                //read in the fields from the current record
                MyStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                MyStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                MyStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                MyStock.StockPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["StockPrice"]);
                MyStock.StockType = Convert.ToString(DB.DataTable.Rows[Index]["StockType"]);
                MyStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStockList.Add(MyStock);
                //point at the next record
                Index++;
            }
        }
    }
}