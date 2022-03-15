using System.Collections.Generic;
using System;



namespace CameraClasses
{

    public class clsCustomerCollection
    {

        //private data memeber for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //constructor for the class
        public clsCustomerCollection()
        {

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stores proc
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there r records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerFName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFName"]);
                ACustomer.CustomerLName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLName"]);
                ACustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                ACustomer.CustomerPostCode = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPostCode"]);
                ACustomer.CustomerPaymentInfo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPaymentInfo"]);
                ACustomer.CustomerPaymentInfo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPaymentInfo"]);
                //add record to the private data member 
                mCustomerList.Add(ACustomer);
                //point at the next record 
                Index++;

            }


            //create items if the test data
            clsCustomer TestItem = new clsCustomer();

            //set its properties
            TestItem.CustomerID = 1;
            TestItem.CustomerFName = "First name";
            TestItem.CustomerLName = "Last name";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerPostCode = "LE1 1WE";
            TestItem.CustomerPaymentInfo = "Credit";
            TestItem.CustomerPhoneNumber = "1234567891";
            //add the item to the test list
            mCustomerList.Add(TestItem);

            //re intialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties 
            TestItem.CustomerID = 2;
            TestItem.CustomerFName = "a name";
            TestItem.CustomerLName = " a Last name";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerPostCode = "LE1 9II";
            TestItem.CustomerPaymentInfo = "Master";
            TestItem.CustomerPhoneNumber = "7898654321";
            //add utem to the test list
            mCustomerList.Add(TestItem);
        }



        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return priv data
                return mCustomerList;
            }
            set
            {
                //set priv data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;

            }
            set
            {
                //later
            }




        }

    }
}






