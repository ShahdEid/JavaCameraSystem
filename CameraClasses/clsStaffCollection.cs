using System.Collections.Generic;
using System;
using CameraClasses;
using Camera_Testing;


namespace CameraClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStock
        clsStaff mThisStaff = new clsStaff();


        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectALL");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank record
                clsStaff JavaStaff = new clsStaff();
                //read in the fields from the current record
                JavaStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                JavaStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                JavaStaff.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                JavaStaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneno"]);
                JavaStaff.StaffStreet = Convert.ToString(DB.DataTable.Rows[Index]["StaffStreet"]);
                JavaStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStaffList.Add(JavaStaff);
                //point at the next record
                Index++;
            }

            //create items if the test data
            clsStaff TestItem = new clsStaff();

            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffName = "sTAFF ame";
            TestItem.StaffDOB = DateTime.Now.Date; ;
            TestItem.StaffPhoneNo = "12345678901";
            TestItem.StaffPostCode = "LE1 1WE";
            TestItem.StaffHouseNo = "1";
            TestItem.StaffStreet = "DNFDGBV";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            mStaffList.Add(TestItem);

            //re intialise the object for some new data
            TestItem = new clsStaff();
            //set its properties 
            TestItem.StaffID = 1;
            TestItem.StaffName = "sTAFF ame";
            TestItem.StaffDOB = DateTime.Now.Date; ;
            TestItem.StaffPhoneNo = "12345678901";
            TestItem.StaffPostCode = "LE1 1WE";
            TestItem.StaffHouseNo = "1";
            TestItem.StaffStreet = "DNFDGBV";
            TestItem.DateAdded = DateTime.Now.Date;
            //add utem to the test list
            mStaffList.Add(TestItem);
        }

        //public property for the stock list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }



        public int Add()
        {
            //adds a new record to the db based on the values of mThisCustomer
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proc
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffStreet", mThisStaff.StaffStreet);
            DB.AddParameter("@StaffPostCode", mThisStaff.StaffPostCode);
            DB.AddParameter("@StaffHouseNo", mThisStaff.StaffHouseNo);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            //execute query returning the pk value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffName)
        {
            //filters the record based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //SEND THE sTAFFName parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterStaffName");
            //populatr the array ist with the data table
            PopulateArray(DB);
        }




        public void Update()
        {
            //update an existing record based on the values of ThisStock
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@StaffHouseNo", mThisStaff.StaffHouseNo);
            DB.AddParameter("@StaffStreet", mThisStaff.StaffStreet);
            DB.AddParameter("@StaffPostCode", mThisStaff.StaffPostCode);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
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
            mStaffList = new List<clsStaff>();
            //while there r records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff JavaStaff= new clsStaff();
                JavaStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                JavaStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                JavaStaff.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                JavaStaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneno"]);
                JavaStaff.StaffStreet = Convert.ToString(DB.DataTable.Rows[Index]["StaffStreet"]);
                JavaStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add record to the private data member 
                mStaffList.Add(JavaStaff );
                //point at the next record 
                Index++;
            }

        }

    }
}
