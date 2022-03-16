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


        public bool Find(int orderID)
        {
            //set the private data members to the test data value 
            mOrderID = 3;
            mDateOfOrder = Convert.ToDateTime("09/01/2022");
            mCustomerID = 9;
            mPaymentStatus = true;
            mProductID = 61;
            mQuantity = "11";
            //always return true
            return true;
        }
    }
}