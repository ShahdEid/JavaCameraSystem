using CameraClasses;
using System;

namespace Camera_Testing
{

    public class clsStaff
    {

        private Int32 mStaffID;
        //private data member for the address no property
        public Int32 StaffID
        {
            get
            {
                //code to send data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }
        private DateTime mStaffDOB;
        // dateadded private memeber variable
        public DateTime DOB
        {
            get
            {
                return mStaffDOB;
            }
            set
            {
                mStaffDOB = value;
            }
        }

        private DateTime mDateAdded;
        // dateadded private memeber variable
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        private string mStaffName;
        // dateadded private memeber variable
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        private Int32 mStaffPhoneNo;
        // dateadded private memeber variable
        public Int32 StaffPhoneNo
        {
            get
            {
                return mStaffPhoneNo;
            }
            set
            {
                mStaffPhoneNo = value;
            }
        }

        private string mStreet;
        // dateadded private memeber variable
        public string Street
        {
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }

        private string mPostCode;
        // dateadded private memeber variable
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }

        private string mHouseNo;
        // dateadded private memeber variable
        public string HouseNo
        {
            get
            {
                return mHouseNo;
            }
            set
            {
                mHouseNo = value;
            }
        }



        public bool Find(int StaffID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {



                //copy the data from database to the private data memebers
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mStaffPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNo"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
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
        //adding function for the validation method


        //public string Valid(string StaffId, string StaffName, string StaffPhoneNo, string DOB, string HouseNo, string  Street, string PostCode, string DateAdded)


        public string Valid(string staffID, string staffName, string staffPhoneNo, string houseNo, string street, string dOB, string postCode, string dateAdded)
        {
            return "";
        }
    }
}