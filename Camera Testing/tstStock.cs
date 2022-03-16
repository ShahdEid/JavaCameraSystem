using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Camera_Testing
{
    [TestClass]
    public class tstStock
    {

        //good test data
        //create some test data to pass to the method
        string StockName = "Canon EOS R";
        string StockType = "Mirrorless Camera";
        string StockPrice = "1500";
        string StockQuantity = "6";
        string DateAdded = DateTime.Now.Date.ToString();

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
        public void StockPricePropertyOK()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 100;
            //assign the data to the property
            MyStock.StockPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(MyStock.StockPrice, TestData);
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
        public void TestStockPriceFound()
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
            if (MyStock.StockPrice != 100)
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
        
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMin()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "a";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "aa";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "1234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "";
            StockName = StockName.PadRight(50, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "";
            StockName = StockName.PadRight(51, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "";
            StockName = StockName.PadRight(500, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMid()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockName = "1234567890123456789012345";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMin()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "a";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "aa";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "";
            StockType = StockType.PadRight(29, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMax()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "";
            StockType = StockType.PadRight(30, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "";
            StockType = StockType.PadRight(31, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "";
            StockType = StockType.PadRight(500, 'a');
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockTypeMid()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StockType = "123456789012345";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 150 years
            TestDate = TestDate.AddYears(-150);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class clsStock
            clsStock MyStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date";
            //invoke the method
            Error = MyStock.Valid(StockName, StockType, StockPrice, StockQuantity, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
