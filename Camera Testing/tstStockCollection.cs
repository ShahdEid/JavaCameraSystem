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
    }
}
