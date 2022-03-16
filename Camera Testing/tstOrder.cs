using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Camera_Testing
{
    [TestClass]
    public class tstOrder
    {
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























    }


}
