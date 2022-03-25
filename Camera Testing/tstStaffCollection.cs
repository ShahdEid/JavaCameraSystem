using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CameraClasses;

namespace Camera_Testing
{
    [TestClass]
    public class tstStaffCollection
    {  //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of the class that need to be created
            clsStaffCollection AllStaff = new clsStaffCollection();
            //testing to see if that exist
            Assert.IsNotNull(AllStaff);
        }


        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class clsStockCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffName = "Canon";
            TestItem.StaffDOB = DateTime.Now.Date;
            TestItem.StaffPhoneNo = "12345678901";
            TestItem.StaffHouseNo = "1";
            TestItem.StaffPostCode = "LE25HB";
            TestItem.StaffStreet = "Brabazon";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class clsStockCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaffkPropertyOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStaff = new clsStockCollection();
            //create an instance of the class clsStock
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "John";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffPhoneNo = "12345678901";
            TestStaff.StaffHouseNo = "1";
            TestStaff.StaffPostCode = "LE25HB";
            TestStaff.StaffStreet = "Brabazon";
            TestStaff.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //creater the item of test data
            clsStaff TestStaff = new clsStaff();
            //set its properties
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Canon";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffPhoneNo = "12345678901";
            TestStaff.StaffHouseNo = "1";
            TestStaff.StaffPostCode = "LE25HB";
            TestStaff.StaffStreet = "Brabazon";
            TestStaff.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestStaff);
            //assign the data to property
            AllStaff.StaffList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
        [TestMethod]

        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.AreEqual(AllStaff.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class clsStockCollection
            clsStaffCollection JavaStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestStaff = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Canon";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffPhoneNo = "12345678901";
            TestStaff.StaffHouseNo = "1";
            TestStaff.StaffPostCode = "LE25HB";
            TestStaff.StaffStreet = "Brabazon";
            TestStaff.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            JavaStaff.ThisStaff = TestStaff;
            //add the record
            PrimaryKey = JavaStaff.Add();
            //set the primary key of the test data
            TestStaff.StaffID = PrimaryKey;
            //find the record
            JavaStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the values are the same
            Assert.AreEqual(JavaStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class clsStockCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestStaff = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Canon";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffPhoneNo = "12345678901";
            TestStaff.StaffHouseNo = "1";
            TestStaff.StaffPostCode = "LE25HB";
            TestStaff.StaffStreet = "Brabazon";
            TestStaff.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class clsStockCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestStaff = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Canon";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffPhoneNo = "12345678901";
            TestStaff.StaffHouseNo = "1";
            TestStaff.StaffPostCode = "LE25HB";
            TestStaff.StaffStreet = "Brabazon";
            TestStaff.DateAdded = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestStaff.StaffID = PrimaryKey;
            //modify the test data
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Canon";
            TestStaff.StaffDOB = DateTime.Now.Date;
            TestStaff.StaffPhoneNo = "12345678901";
            TestStaff.StaffHouseNo = "1";
            TestStaff.StaffPostCode = "LE25HB";
            TestStaff.StaffStreet = "Brabazon";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestStaff;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ReportByStaffNameMethodOK()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a stock type that doesn't exist
            FilteredStaff.ReportByStaffName("xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a stock type that doesn't exist
            FilteredStaff.ReportByType("xxx");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first records is ID 3
                if (FilteredStaff.StaffList[0].StaffID != 3)
                {
                    OK = false;
                }
                //check that the first record is ID 4
                if (FilteredStaff.StaffList[0].StaffID != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

