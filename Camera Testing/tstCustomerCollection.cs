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


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerFName = "First name";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.CustomerPostCode = "LE1 1WE";
            TestCustomer.CustomerPaymentInfo = "Credit";
            TestCustomer.CustomerPhoneNumber = "1234567891";
            //assign data to the property 
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two  values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //var to store the pk
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.CustomerID = 1;
            TestItem.CustomerFName = "First name";
            TestItem.CustomerLName = "LastName";
            TestItem.CustomerDOB = Convert.ToDateTime("17/09/2000");
            TestItem.CustomerPostCode = "LE1 1WE";
            TestItem.CustomerPaymentInfo = "Credit";
            TestItem.CustomerPhoneNumber = "1234567891";
            //set thiscustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add record 
            PrimaryKey = AllCustomers.Add();
            //set pk of the test data 
            TestItem.CustomerID = PrimaryKey;
            //find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //var to store the pk
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.CustomerID = 1;
            TestItem.CustomerFName = "First name";
            TestItem.CustomerLName = "LastName";
            TestItem.CustomerDOB = Convert.ToDateTime("17/09/2000");
            TestItem.CustomerPostCode = "LE1 1WE";
            TestItem.CustomerPaymentInfo = "Credit";
            TestItem.CustomerPhoneNumber = "1234567891";
            //set thiscustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add record 
            PrimaryKey = AllCustomers.Add();
            //set pk of the test data 
            TestItem.CustomerID = PrimaryKey;
            //find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //var to store the pk
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.CustomerID = 1;
            TestItem.CustomerFName = "First name";
            TestItem.CustomerLName = "LastName";
            TestItem.CustomerDOB = Convert.ToDateTime("17/09/2000");
            TestItem.CustomerPostCode = "LE1 1WE";
            TestItem.CustomerPaymentInfo = "Credit";
            TestItem.CustomerPhoneNumber = "1234567891";
            //set thiscustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add record 
            PrimaryKey = AllCustomers.Add();
            //set pk of the test data 
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 2;
            TestItem.CustomerFName = "Rega";
            TestItem.CustomerLName = "Walters";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerPostCode = "LE2 2WE";
            TestItem.CustomerPaymentInfo = "Master";
            TestItem.CustomerPhoneNumber = "1987654321";
            //find the record 
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete record
            AllCustomers.Update();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {

            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //apply a blank string which should return all records
            FilterCustomers.ReportByPostCode("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, FilterCustomers.Count);
        }

        ////record that does exist
        [TestMethod]
        public void ReportByPostCodeFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //apply a post code that doesnt exist
            FilterCustomers.ReportByPostCode("XXX XXX");
            //test to see that there are no records
            Assert.AreEqual(2, FilterCustomers.Count);

        }

        //Record that doesnt exist
        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //apply a post code that doesnt exist
            FilterCustomers.ReportByPostCode("www www");
            //test to see that there are no records
            Assert.AreEqual(0, FilterCustomers.Count);

        }
       

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code tht doesnt exist
            FilterCustomers.ReportByPostCode("LE3 0IW");
            //check that the correct nio of records are found 
            if (FilterCustomers.Count == 1)
            {
                //check the first record is ID 2
                if (FilterCustomers.CustomerList[0].CustomerID != 2)
                {
                    OK = false;
                }

            }
            ////check the first record is ID 3
            //if (FilterCustomers.CustomerList[1].CustomerID != 32)
            //{
            //    OK = false;
            //}
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void ReportByFNameMethodOK()
        {

            //create instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //apply a blank string which should return all records
            FilterCustomers.ReportByFName("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, FilterCustomers.Count);
        }

        ////record that does exist
        [TestMethod]
        public void ReportByFNameFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //apply a post code that doesnt exist
            FilterCustomers.ReportByFName("Shahd");
            //test to see that there are no records
            Assert.AreEqual(2, FilterCustomers.Count);

        }


        //Record that doesnt exist
        [TestMethod]
        public void ReportByFNameNoneFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //apply a post code that doesnt exist
            FilterCustomers.ReportByFName("www www");
            //test to see that there are no records
            Assert.AreEqual(0, FilterCustomers.Count);

        }


        [TestMethod]
        public void ReportByFNameTestDataFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilterCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code tht doesnt exist
            FilterCustomers.ReportByFName("Shahd");
            //check that the correct nio of records are found 
            if (FilterCustomers.Count == 2)
            {
                //check the first record is ID 2
                if (FilterCustomers.CustomerList[0].CustomerID != 147)
                {
                    OK = false;
                }

            }
            ////check the first record is ID 3
            //if (FilterCustomers.CustomerList[1].CustomerID != 155)
            //{
            //    OK = false;
            //}
            
            else
            {
                OK = false;
            }
                //test to see that there are no records
                Assert.IsTrue(OK);

            } 
     
    
    }
 }

