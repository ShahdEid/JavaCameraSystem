using System;

namespace CameraClasses
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerID;
        //public property for CustomerID
        public int CustomerID
        {
            get
            {
                //this sends data out of the property
                return mCustomerID;
            }

            set
            {
                //this allows data into the property
                mCustomerID = value;
            }
        }
        //private data member for CustomerLName
        private string mCustomerLName;
        //public property for CustomerLName
        public string CustomerLName 
        {
			get
			{
                //return private data
                return mCustomerLName;
            }
			set
			{
                //set the private data
                mCustomerLName = value;
            }
        }

        //private data member for CustomerFName
        private string mCustomerFName;
        //public property for CustomerFName
        public string CustomerFName
        {
            get
            {
                //return private data
                return mCustomerFName;
            }
            set
            {
                //set the private data
                mCustomerFName = value;
            }
        }

        //private data member for CustomerPhoneNumber
        private string mCustomerPhoneNumber;
        //public property for CustomerPhoneNumber
        public string CustomerPhoneNumber
        {
            get
            {
                //return private data
                return mCustomerPhoneNumber;
            }
            set
            {
                //set the private data
                mCustomerPhoneNumber = value;
            }
        }

        //private data member for CustomerPostCode
        private string mCustomerPostCode;
        //public property for CustomerPostCode
        public string CustomerPostCode
        {
            get
            {
                //return private data
                return mCustomerPostCode;
            }
            set
            {
                //set the private data
                mCustomerPostCode = value;
            }
        }

        //private data member for CustomerPaymentInfo
        private string mCustomerPaymentInfo;
        //public property for CustomerPaymentInfo
        public string CustomerPaymentInfo
        {
            get
            {
                //return private data
                return mCustomerPaymentInfo;
            }
            set
            {
                //set the private data
                mCustomerPaymentInfo = value;
            }
        }

        //CustomerDOB private member variable
        private DateTime mCustomerDOB;
        //CustomerDOB public property
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;

            }


            set
            {
                mCustomerDOB = value;
            }
        }

		

		public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {



                //copy the data from database to the private data memebers
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerPostCode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostCode"]);
                mCustomerPaymentInfo = Convert.ToString(DB.DataTable.Rows[0]["CustomerPaymentInfo"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                mCustomerLName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLName"]);
                mCustomerFName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFName"]);
                //return that everything worked ok
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