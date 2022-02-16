using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Camera_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(MyStock);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            MyStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(MyStock.DateAdded, TestData);
        }

        [TestMethod]
        public void StockIdPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            MyStock.StockId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(MyStock.StockId, TestData);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "abc";
            //assign the data to the property
            MyStock.StockName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(MyStock.StockName, TestData);
        }
        
        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            MyStock.StockQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(MyStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void StockTypePropertyOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "abc";
            //assign the data to the property
            MyStock.StockType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(MyStock.StockType, TestData);
        }
    }
}
