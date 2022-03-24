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
    {
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
    }
}
