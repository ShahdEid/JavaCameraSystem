using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Camera_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockId = 1;
            TestItem.StockName = "Canon";
            TestItem.StockType = "DSLR Camera";
            TestItem.StockQuantity = 2;
            TestItem.StockPrice = 1000;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the class clsStock
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.StockId = 1;
            TestStock.StockName = "Canon";
            TestStock.StockType = "DSLR Camera";
            TestStock.StockQuantity = 2;
            TestStock.StockPrice = 1000;
            TestStock.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //creater the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockId = 1;
            TestItem.StockName = "Canon";
            TestItem.StockType = "DSLR Camera";
            TestItem.StockQuantity = 2;
            TestItem.StockPrice = 1000;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to property
            AllStock.StockList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create an item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "Canon 1DX";
            TestItem.StockType = "DSLR Camera";
            TestItem.StockQuantity = 2;
            TestItem.StockPrice = 1000;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create an item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockId = 6;
            TestItem.StockName = "Canon";
            TestItem.StockType = "DSLR Camera";
            TestItem.StockQuantity = 2;
            TestItem.StockPrice = 1000;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class clsStockCollection
            clsStockCollection AllStock = new clsStockCollection();
            //create an item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "Canon 5D Mark IV";
            TestItem.StockType = "DSLR Camera";
            TestItem.StockQuantity = 2;
            TestItem.StockPrice = 1000;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //modify the test data
            TestItem.StockName = "Canon 5D Mark III";
            TestItem.StockType = "DSLR Camera";
            TestItem.StockQuantity = 6;
            TestItem.StockPrice = 890;
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        /*[TestMethod]
        public void ReportByTypeMethodOK()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a stock type that doesn't exist
            FilteredStock.ReportByType("xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByTypeTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a stock type that doesn't exist
            FilteredStock.ReportByType("xxx");
            //check that the correct number of records are found
            if(FilteredStock.Count == 2)
            {
                //check that the first records is ID 3
                if(FilteredStock.StockList[0].StockId != 3)
                {
                    OK = false;
                }
                //check that the first record is ID 4
                if(FilteredStock.StockList[0].StockId != 4)
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
        }*/
    }
}
