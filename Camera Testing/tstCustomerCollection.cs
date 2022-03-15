using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CameraClasses;
using System.Collections.Generic;


namespace Camera_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //creater the item of test data
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
            TestList.Add(TestItem);
            //assign the data to property
            AllCustomers.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create instance of the class we want to create
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign data
        //    AllCustomers.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}

        [TestMethod]
        public void ListAndCountPropertyOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //creater the item of test data
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
            TestList.Add(TestItem);
            //assign the data to property
            AllCustomers.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        ////This test assumes that there are always 2 records in all customers object upon instanation 
        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create instance of the class we want to create
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //test ro see that the 2 values are the same
        //    Assert.AreEqual(AllCustomers.Count, 2);
        //}

    }
}
