using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Camera_Testing
{
    [TestClass]
    public class tstOrder
    {
        //good data
        string DateOfOrder = "10/03/2021";
        string Quantity = "34";
        string ProductID = "124";
        string CustomerID = "12";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see it exists 
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //craete some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnOrder.OrderID = TestData;
            //test to see the two valuesare the same 
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void DateOfOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //craete some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnOrder.DateOfOrder = TestData;
            //test to see the two valuesare the same 
            Assert.AreEqual(AnOrder.DateOfOrder, TestData);

        }

        [TestMethod]
        public void PaymentStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.PaymentStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentStatus, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //craete some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnOrder.CustomerID = TestData;
            //test to see the two valuesare the same 
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //craete some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property 
            AnOrder.ProductID = TestData;
            //test to see the two valuesare the same 
            Assert.AreEqual(AnOrder.ProductID, TestData);

        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "2";
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }


        [TestMethod]
        public void FindMethodOK()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestOrderIDFound()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //boolean variable to record if data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.OrderID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateOfOrderFound()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //boolean variable to record if data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.DateOfOrder != Convert.ToDateTime("09/01/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerIDFound()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //boolean variable to record if data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CustomerID != 9)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestPaymentStatusFound()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //boolean variable to record if data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.PaymentStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //boolean variable to record if data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.ProductID != 61)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestQuantityFound()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //boolean variable to record if data to use with the method 
            Int32 OrderID = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.Quantity != "11")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]

        public void ValidMethodOK()

        {
            //Create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void DateOfOrderExtemeMin()
        {
            //create an instance of the class we wat to create 
            clsOrder AnOrder = new clsOrder();
            // string variable to any error message 
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever is less than 100 years
            TestDate = TestDate.AddYears(-100);
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void DateOfOrderMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfOrderMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfOrderMinPlusOn()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the date of orderto a non date value
            string DateOfOrder = "please enter the date correctly ";
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "";
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "11";
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "";
            Quantity = Quantity.PadRight(49, '1');
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "";
            Quantity = Quantity.PadRight(50, '6');
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Quantity = "";
            Quantity = Quantity.PadRight(51, '6');                                                  //here         
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Quantity = "";
            Quantity = Quantity.PadRight(25, '6');
            //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "1"; //this should be ok
                                    //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "12"; //this should be ok
                                     //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void ProductIDMaxLessOne()
        //{
        //                              //NA
        //}

        //[TestMethod]
        //public void ProductIDMax()
        //{
        //                              //NA
        //}

        //[TestMethod]
        //public void ProductIDMid()
        //{

        //NA
        // }

        //[TestMethod]
        //public void ProductIDMaxPlusOne()
        //{
        //                               //NA
        //}

        //   [TestMethod]
        // public void ProductIDExtremeMax()
        // {
        //NA
        // }



        [TestMethod]

        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "3"; //this should be ok
                                     //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "33"; //this should be ok
                                      //invoke the method
            Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //[TestMethod]
        //public void CustomerIDMaxLessOne()
        //{
        //            //NA
        //}

        //[TestMethod]
        //public void CustomerIDMax()
        //{
        //                      //NA
        //}

        //[TestMethod]
        //public void CustomerIDMid()
        //{
        //                        //NA
        //}

        //[TestMethod]
        //public void CustomerIDMaxPlusOne()
        //{
        //                        //NA
        //}

        //[TestMethod]
        //public void CustomerIDExtremeMax()
        //{
        //                    //NA
        //}


















    }

}
