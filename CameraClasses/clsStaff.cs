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

        private string mStaffPhoneNo;
        // dateadded private memeber variable
        public string StaffPhoneNo
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


       

        private string mStaffPostCode;
        // dateadded private memeber variable
        public string StaffPostCode
        {
            get
            {
                return mStaffPostCode;
            }
            set
            {
                mStaffPostCode = value;
            }
        }

        private string mStaffHouseNo;
        public string StaffHouseNo
        {
            get
            {
                return mStaffHouseNo;
            }
            set
            {
                mStaffHouseNo = value;
            }
        }
        private string mStaffStreet;
        // dateadded private memeber variable
        public string StaffStreet
        {
            get
            {
                return mStaffStreet;
            }
            set
            {
                mStaffStreet = value;
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
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mStaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["StaffPostCode"]);
                mStaffPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["StaffStaffPhoneNo"]);
                mStaffHouseNo = Convert.ToString(DB.DataTable.Rows[0]["StaffHouseNo"]);
                mStaffStreet = Convert.ToString(DB.DataTable.Rows[0]["StaffStreet"]);
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
        /*

        public string Valid(string staffID, string staffName, string staffPhoneNo, string staffHouseNo, string staffStreet, string staffDOB, string staffPostCode, string dateAdded)
        {
            //creating a string variable to store the error
            String Error = "";
            //if the Staff Name is blank
            if (StaffName.Length == 0)
            {
                //record the error
                Error = Error + " The Staff Name may not be blank : "; 
            }
            if (StaffName.Length >20)
            {
                //record the error
                Error = Error + "The StaffName must be less than 20 characters : ";
            }
            //return any relevent error messages

            //copying the date added value to the DateTemp variable
            DateAdded = Convert.ToDateTime(dateAdded);
            if(DateAdded < DateTime.Now.Date)
            {
                //record the error 
                Error = Error + "The date cannot be in past : ";
            }
            //return any error messages
            return Error;
        }
        */
        public string Valid(string staffID, string staffName, string staffPhoneNo, string staffHouseNo, string staffStreet, string staffDOB, string staffPostCode, string dateAdded)
        {
            //creating a string variable to store the error
            String Error = "";
            //if the Staff Name is blank
            if (StaffName.Length == 0)
            {
                //record the error
                Error = Error + " The Staff Name may not be blank : ";
            }
            if (StaffName.Length > 20)
            {
                //record the error
                Error = Error + "The StaffName must be less than 20 characters : ";
            }
            //return any relevent error messages
            try
            {


                //copying the date added value to the DateTemp variable
                DateAdded = Convert.ToDateTime(DateAdded);
                if (DateAdded < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in past : ";
                }
                //check to see if the date is greater than today's date
                if (DateAdded > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            //return any error messages
            return Error;
        }

    }
}