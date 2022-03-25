using System.Collections.Generic;
using System;
using CameraClasses;



namespace CameraClasses
{

    public class clsCustomerCollection
    {

        //private data memeber for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data memeber ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //constructor for the class
        public clsCustomerCollection()
        {
            /*
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
                ACustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
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
            */

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proc
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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

        public clsCustomer ThisCustomer
        {
            get
            {
                //return priv data
                return mThisCustomer;
            }
            set
            {
                //set priv data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the db based on the values of mThisCustomer
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proc
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@CustomerFName", mThisCustomer.CustomerFName);
            DB.AddParameter("@CustomerLName", mThisCustomer.CustomerLName);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerPaymentInfo", mThisCustomer.CustomerPaymentInfo);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            //execute query returning the pk value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connects to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proc
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored proc
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the sproc

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@CustomerFName", mThisCustomer.CustomerFName);
            DB.AddParameter("@CustomerLName", mThisCustomer.CustomerLName);
            DB.AddParameter("@CustomerPhoneNumber", mThisCustomer.CustomerPhoneNumber);
            DB.AddParameter("@CustomerPaymentInfo", mThisCustomer.CustomerPaymentInfo);
            DB.AddParameter("@CustomerPostCode", mThisCustomer.CustomerPostCode);
            //execute the sproc
            DB.Execute("sproc_tblCustomer_Update");
        }


      

        public void ReportByPostCode(string CustomerPostCode)
        {
            //filters records based on a full ot partial post code
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send thepostcode parameter to the db 
            DB.AddParameter("@CustomerPostCode", CustomerPostCode);
            //execute the sproc
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
            //populate the array list with the data tavle
            PopulateArray(DB);
        }

        public void ReportByFName(string CustomerFName)
        {
            //filters records based on a full ot partial post code
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send thepostcode parameter to the db 
            DB.AddParameter("@CustomerFName", CustomerFName);
            //execute the sproc
            DB.Execute("sproc_tblCustomer_FilterByFName");
            //populate the array list with the data tavle
            PopulateArray(DB);
        }




        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the param DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
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
                ACustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNumber"]);
                ACustomer.CustomerPaymentInfo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPaymentInfo"]);
                //add record to the private data member 
                mCustomerList.Add(ACustomer);
                //point at the next record 
                Index++;
            }

        }
    }
}






