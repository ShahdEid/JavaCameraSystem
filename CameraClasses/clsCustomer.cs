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

        public string Valid(string customerDOB, string customerFName, string customerLName, string customerPhoneNumber, string customerPostCode, string customerPaymentInfo)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the customerpostcode is blank
            if (customerPostCode.Length == 0)
            {
                //record the error
                Error = Error + "Post Code Cannot be blank : ";
            }
            //if customer post code is greater than 9 characters
            if (customerPostCode.Length > 9)
            {
                //error
                Error = Error + "Post Code must be less than 9 characters : ";
            }
            try
            {


                //copy the DOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(customerDOB);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {

                    //record the error
                    Error = Error + "Too old to create add  : ";
                }
                //check to see if the date is greater than 
                if (DateTemp > DateTime.Now.Date.AddYears(-14))
                {
                    //record error
                    Error = Error + "Age is too young : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid : ";
            }

            //if (DateTemp >= DateTime.Now.Date.AddYears(15))
            //{
            //    //record error
            //    Error = Error + "The entered DOB is invalid date";
            //}


            //Fname is blank 
            if (customerFName.Length == 0)
            {
                // error
                Error = Error + "First Name cannot be blank";
            }
            //F name is too long 
            if (customerFName.Length > 50)
            {
                // error
                Error = Error + "First Name cannot be more than 50 letters";
            }

            //Lname is blank 
            if (customerLName.Length == 0)
            {
                // error
                Error = Error + "Last Name cannot be blank";
            }
            //L name is too long 
            if (customerLName.Length > 50)
            {
                // error
                Error = Error + "Last Name cannot be more than 50 letters";
            }

         


            //return any error messages
            return Error;
        }
    }
}