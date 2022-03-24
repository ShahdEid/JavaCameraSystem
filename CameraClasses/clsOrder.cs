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
        public string Valid(string DateOfOrder, string Quantity, string ProductID, string CustomerID)
        {
            //create a string variable to store the error
            String Error = "";
            ////create a temporary variable to store date values
            //  DateTime DateTemp;

            //try
            //{


            ////    //copy the dateAdded value to the DateTemp variable
            //DateTemp = Convert.ToDateTime(DateOfOrder);
            //if (DateTemp < DateTime.Now.Date)
            //{
            //    //error
            //    Error = Error + "The order cannotbe in the past : ";
            //}

            //    //cjeck to see if the date is greater than today's date
            //    if (DateTemp > DateTime.Now.Date)
            //    {
            //        //error
            //        Error = Error + "The order cannot be in the future : ";
            //    }

            //}
            //catch
            //{
            //    //record the error
            //    Error = Error + "The date was not a valid : ";
            //}


            //is the post code blank
            if (CustomerID.Length == 0)
            {
                //record the error
                Error = Error + "The customer id is be blank : ";
            }

            //is the street blank
            if (Quantity.Length == 0)
            {
                //record the error
                Error = Error + "The quantity is be blank : ";
            }
            //if the street is too long
            if (Quantity.Length > 50)
            {
                //record the error
                Error = Error + "The quantity must be less than 50 characters : ";
            }

            ////if the product is blank
            if (ProductID.Length == 0)
            {
                //record the error
                Error = Error + "The product id  is blank : ";
            }



            //return any error messages
            return Error;
        }
    }

}

