using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CameraClasses;
using Camera_Testing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Testing
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass to the method
        string StaffID = "21";
        string StaffName = "John ";
        string StaffPhoneNo = "07459317746";
        string StaffDOB = "15/01/2001";
        string StaffPostCode = "LE2 5HB";
        string DateAdded = DateTime.Now.Date.ToString();

        public string StaffHouseNo { get; private set; }
        public string StaffStreet { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            // An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(JavaStaff);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //A n instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            JavaStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //An instance of the class clsStaff   
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "abc";
            //assign the data to the property
            JavaStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffName, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //An instance of the classclsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            JavaStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Today;
            //assign the data to the property
            JavaStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.DOB, TestData);
        }


        /*
        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = "07459317746";
            //assign the data to the property
            JavaStaff.StaffPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffPhoneNo, TestData);
        }
        */

        [TestMethod]
        public void StaffHouseNoPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnAddress.StaffHouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.StaffHouseNo, TestData);
        }

        [TestMethod]
        public void StaffPostCodePropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            JavaStaff.StaffPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffPostCode, TestData);
        }

        [TestMethod]
        public void StaffStreetPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            JavaStaff.StaffStreet = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffStreet, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = JavaStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHouseNoPropertyFound()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = JavaStaff.Find(StaffID);
            //check the property
            if (JavaStaff.StaffStreet != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestStaffIDFound()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = JavaStaff.Find(StaffID);
            //check the address no
            if (JavaStaff.StaffID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestStaffPostCodeFound()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = JavaStaff.Find(StaffID);
            //check the property
            if (JavaStaff.StaffPostCode != "LE2 5HB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffStreetFound()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = JavaStaff.Find(StaffID);
            //check the property
            if (JavaStaff.StaffStreet != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //boolean vriable to store the result of the search
            Boolean Found = false;
            Boolean OK = true;
            //boolean variable to record if data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = JavaStaff.Find(StaffID);
            //check the property 
            if (JavaStaff.DateAdded != Convert.ToDateTime("01/03/2022"))
            {
                OK = false;
            }
            //test to see that teh result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //instance of the class that i need to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoking the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void StaffNameMinLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffNameMin()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "J";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffNameMinPlusOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "jj";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffNameMaxLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "1234512345123451234";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffNameMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "12345123451234512345";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffNameMid()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "1234512345";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffNameExtremeMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'J');
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        public void StaffStreetMinLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet= "";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffStreetMin()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "J";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffStreetMinPlusOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "jj";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffStreetMaxLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "1234512345123451234";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffStreetMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffName = "12345123451234512345";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffStreetMid()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "1234512345";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffStreetExtremeMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "";
            StaffName = StaffName.PadRight(500, 'J');
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        public void StaffPhoneNoMinLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo = "";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffPhoneMin()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "1";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffPhoneNoMinPlusOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffStreet = "12";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffPhoneNoMaxLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo   = "12345123451";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffPhoneNoMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo = "123451234512";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffPhoneNoMid()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo = "123451";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffPhoneNoExtremeMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo = "";
            StaffPhoneNo = StaffName.PadRight(500, '1');
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void StaffHouseNoMinLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffHouseNo = "";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffHouseNoMin()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffHouseNo = "1";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffHouseNoMinPlusOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffHouseNo = "12";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffHouseNoMaxLessOne()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffHouseNo = "12345123451";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffHouseNoMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffHouseNo = "123451234512";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffHouseNoMid()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo = "123451";
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void StaffHouseNoExtremeMax()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //creating some test data to pass to the method 
            string StaffPhoneNo = "";
            StaffPhoneNo = StaffName.PadRight(500, '1');
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //setting the date to todays date
            TestDate = DateTime.Now.Date;
            //chanfing the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //converting the date variable to a string variable
            string DateAdded =TestDate.ToString();
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public  void DateAddedInvalidData()
        {

            //instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //string variable to  store any error message
            String Error = "";
            //set the date added to a non date value
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /// <summary>
        /// ////////DOB
        /// </summary>
        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            //creating an instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //setting the date to todays date
            TestDate = DateTime.Now.Date;
            //chanfing the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //converting the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoking the metho 
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StaffDOB = TestDate.ToString();
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBInvalidData()
        {

            //instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //string variable to  store any error message
            String Error = "";
            //set the date added to a non date value
            string StaffDOB= "This is not a date!";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffPostCode = "";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMin()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPostCode = "a";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPostCode = "aa";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPostCode = "aaaaaaaa";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMax()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPostCode = "aaaaaaaaa";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffPostCode = "aaaaaaaaaa";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMid()
        {
            //create an instance of the class we want to create
            clsStaff JavaStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPostCode = "aaaa";
            //invoke the method
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}

