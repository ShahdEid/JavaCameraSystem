using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Camera_Testing
{
    [TestClass]
    public class tstCustomer
    {                                                                           //Properties
        //good test data
        //create some test data to pass to the method
        string CustomerFName = "Shahd";
        string CustomerLName = "Diab";
        string CustomerDOB = "10/03/2003";
        string CustomerPostCode = "LE1A 6PSR";
        string CustomerPhoneNumber = "07547809434";
        string CustomerPaymentInfo = "Debit";

        [TestMethod]
        public void InstanceOK()

        {
            //Create an instance of class we want to createsss
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(ACustomer);

        }
        [TestMethod]
        public void CustomerIDPropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creare some test data to assign to the property 
            Int32 TestData = 1;
            //assign data to the property
            ACustomer.CustomerID = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerID, TestData);

        }

        [TestMethod]
        public void CustomerLNamePropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creare some test data to assign to the property 
            string TestData = "Eid";
            //assign data to the property
            ACustomer.CustomerLName = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerLName, TestData);

        }


        [TestMethod]
        public void CustomerFNamePropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creare some test data to assign to the property 
            string TestData = "Shahd";
            //assign data to the property
            ACustomer.CustomerFName = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerFName, TestData);

        }
        [TestMethod]
        public void CustomerPhoneNumberPropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creare some test data to assign to the property 
            string TestData = "07652928765";
            //assign data to the property
            ACustomer.CustomerPhoneNumber = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerPhoneNumber, TestData);

        }
        [TestMethod]
        public void CustomerPostCodePropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creare some test data to assign to the property 
            string TestData = "LE1 4AB";
            //assign data to the property
            ACustomer.CustomerPostCode = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerPostCode, TestData);

        }
        [TestMethod]
        public void CustomerPaymentInfoPropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //creare some test data to assign to the property 
            string TestData = "Debit";
            //assign data to the property
            ACustomer.CustomerPaymentInfo = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerPaymentInfo, TestData);

        }
        [TestMethod]
        public void CustomerDOBPropertyOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            ACustomer.CustomerDOB = TestData;
            //test to see that it exists 
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);

        }
        //Find Method
        [TestMethod]
        public void FindMethodOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 4;               //1
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that it exists 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerIDFound()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the id
            if (ACustomer.CustomerID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerDOBFound()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerDOB != Convert.ToDateTime("10/03/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestCustomerFNameFound()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerFName != "Test First Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerLNameFound()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerLName != "Test Last Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerPhoneNumberFound()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerPhoneNumber != "07407415687")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerPaymentInfoFound()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerPaymentInfo != "Visa")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerPostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Validation
        [TestMethod]
        public void ValidMethodOK()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerPostCodeMinLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "";  //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerPostCodeMin()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "L";  //this should be OK
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerPostCodeMinPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "LE";  //this should be OK
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerPostCodeMaxLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "LLLLLLLL";  //this should be OK
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void CustomerPostCodeMax()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "LLLLLLLLL";  //this should be OK
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void CustomerPostCodeMid()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "LLLL";  //this should be OK
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");



        }
        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "LLLLLLLLLL";  //this should FAIL
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeExtremeMax()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string CustomerPostCode = "LE1A";
            CustomerPostCode = CustomerPostCode.PadRight(500, 'L'); //this should be fail
                                                                    //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");



        }


        [TestMethod]
        public void CustomerDOBExtremeMin()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 200 years ago 
            TestDate = TestDate.AddYears(-200);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void CustomerDOBMinLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 99 years ago 
            TestDate = TestDate.AddYears(-99);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerDOBMin()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 100 years ago 
            TestDate = TestDate.AddYears(-100);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerDOBMinPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 99 years ago 
            TestDate = TestDate.AddYears(-101);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerDOBMaxLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is14 years ago 
            TestDate = TestDate.AddYears(-13);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CustomerDOBMaxPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 16 years ago 
            TestDate = TestDate.AddYears(-16);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerDOBMax()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date to today
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 15 years ago 
            TestDate = TestDate.AddYears(-15);
            //convert the date  variable to a string variable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerDOBInvalidData()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the dob to a non date value
            string CustomerDOB = "Invalid data! Please insert a date";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFNameMinLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the dob to a non date value
            string CustomerFName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerLNameMinLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the dob to a non date value
            string CustomerLName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CustomerLNameMin()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set to a non date value
            string CustomerLName = "E";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFNameMin()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set to a non date value
            string CustomerFName = "S";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerLNameMinPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set to a non date value
            string CustomerLName = "EE";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerFNameMinPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set to a non date value
            string CustomerFName = "SS";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void CustomerLNameMaxLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set b to a non date value
            string CustomerLName = "";
            CustomerLName = CustomerLName.PadRight(49, 'E');
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFNameMaxLessOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set b to a non date value
            string CustomerFName = "";
            CustomerFName = CustomerFName.PadRight(49, 'S');
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerLNameMax()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FName to a non date value
            string CustomerLName = "";
            CustomerLName = CustomerLName.PadRight(50, 'E');
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerFNameMax()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the FName to a non date value
            string CustomerFName = "";
            CustomerFName = CustomerFName.PadRight(50, 'S');
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerLNameMaxPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerLName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CustomerFNameMaxPlusOne()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerFName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void CustomerLNameMid()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the dob to a non date value
            string CustomerLName = "";
            CustomerLName = CustomerLName.PadRight(25, 'S');
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerFNameMid()

        {
            //Create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the dob to a non date value
            string CustomerFName = "";
            CustomerFName = CustomerFName.PadRight(25, 'S');
            //invoke the method
            Error = ACustomer.Valid(CustomerDOB, CustomerFName, CustomerLName, CustomerPhoneNumber, CustomerPostCode, CustomerPaymentInfo);
            //test to see that that the result is correct
            Assert.AreEqual(Error, "");

        }





    }

}


