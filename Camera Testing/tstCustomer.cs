using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Camera_Testing
{
    [TestClass]
    public class tstCustomer
    {                                                                           //Properties
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
            if (ACustomer.CustomerID !=4)
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

    }
}
