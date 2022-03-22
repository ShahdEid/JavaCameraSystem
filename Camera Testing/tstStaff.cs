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
        string DOB = "15/01/2001";
        string PostCode = "LE2 5HB";
        string DateAdded = DateTime.Now.Date.ToString();

        public string StaffHouseNo { get; private set; }
        public string Street { get; private set; }
        public string HouseNo { get; private set; }

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
        public void DOBPropertyOK()
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



        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 0345678901;
            //assign the data to the property
            JavaStaff.StaffPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffPhoneNo, TestData);
        }


        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            JavaStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            JavaStaff.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.Street, TestData);
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
            if (JavaStaff.Street != "Test Street")
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
        public void TestPostCodeFound()
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
            if (JavaStaff.PostCode != "LE2 5HB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStreetFound()
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
            if (JavaStaff.Street != "Test Street")
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
            Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, HouseNo, Street, DOB, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

