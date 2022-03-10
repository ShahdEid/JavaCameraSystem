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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockId = 2;
            //invoke the method
            Found = MyStock.Find(StockId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 2;
            //invoke the method
            Found = MyStock.Find(StockId);
            //check the stock id
            if(MyStock.StockId != 2)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 2;
            //invoke the method
            Found = MyStock.Find(StockId);
            //check the property
            if (MyStock.DateAdded != Convert.ToDateTime("03/02/2022"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = MyStock.Find(StockId);
            //check the property
            if (MyStock.StockName != "Canon EOS R")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 3;
            //invoke the method
            Found = MyStock.Find(StockId);
            //check the property
            if (MyStock.StockQuantity != 3)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockTypeFound()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 3;
            //invoke the method
            Found = MyStock.Find(StockId);
            //check the property
            if (MyStock.StockType != "Lens")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
