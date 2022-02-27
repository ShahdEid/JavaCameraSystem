using System;

namespace CameraClasses
{
    public class clsCustomer
    {
        //private dara member for the customer id property
        private Int32 mCustomerID;

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
        public string CustomerLName { get; set; }
        public string CustomerFName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerPostCode { get; set; }
        public string CustomerPaymentInfo { get; set; }
        public DateTime CustomerDOB { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to the test data value
            mCustomerID = 21;
            //always return true
            return true;
        }
    }
}