using System.Collections.Generic;
using System;
using CameraClasses;


namespace CameraClasses
{
    public class clsOrderCollection
    {
        //private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            mThisOrder.OrderID = 123;
            return mThisOrder.OrderID;
        }

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                //set the private data 
                mOrderList = value;
            }


        }

        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // execute the procedure
            DB.Execute("sproc_tblOder_SelectAll");
            // the count of records
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                // create a blank order
                {
                    clsOrder AnOrder = new clsOrder();
                    AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                    AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);
                    AnOrder.PaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentStatus"]);
                    AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                    AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                    AnOrder.Quantity = Convert.ToString(DB.DataTable.Rows[Index]["Quantity"]);
                    // add a record to the private data 
                    mOrderList.Add(AnOrder);
                    Index++;
                }
                   
                }
            }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");

        }

        public void Update()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter(OrderID, mThisOrder, OrderID);

        }
    }






        //public int Count
        //{
        //    get
        //    {
        //        //return thecount of the list 
        //        return mOrderList.Count;
        //    }
        //    set
        //    {

        //    }


        }
      

