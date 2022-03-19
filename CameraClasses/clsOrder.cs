using System;

namespace CameraClasses
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        //OrderId private member variable
        private Int32 mOrderID;
        //addressNo  public property 
        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property 
                return mOrderID;

            }
            set
            {
                // this line of code allows data into the property 
                mOrderID = value;
            }
        }
        private DateTime mDateOfOrder;
        //DataAdded Public property 
        public DateTime DateOfOrder
        {
            get
            {
                return mDateOfOrder;

            }
            set
            {
                mDateOfOrder = value;
            }
        }
        //private data member for payment status
        private Boolean mPaymentStatus;
        //public property for PaymentStatus
        public bool PaymentStatus
        {
            get
            {
                //return the private data
                return mPaymentStatus;
            }
            set
            {
                //set the private data
                mPaymentStatus = value;
            }
        }

        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                //return the private data 
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private Int32 mProductID;
        public int ProductID
        {
            get
            {
                //return the private data 
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        //private data member for Quantity
        private string mQuantity;
        //public data member for Quantity
        public string Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the private data
                mQuantity = value;
            }
        }


        public bool Find(int OrderID)
        {
            //craete an intance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the order id to find it
            DB.AddParameter("OrderID", OrderID);
            //execute the sored procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            // if one record is found (there should be either one or zero )
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mDateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfOrder"]);
                mPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentStatus"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);
                // return that everything worked ok 
                return true;
            }
            else
            {
                //return false indicating a problem 
                return false;
            }


        }
    }
}
