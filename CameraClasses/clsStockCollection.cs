using System.Collections.Generic;
using System;
using CameraClasses;

namespace CameraClasses
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        //constructor for the class
        public clsStockCollection()
        {
            //var for the index
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
                Index++;
            }
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
        public clsStock ThisStock { get; set; }
    }
}