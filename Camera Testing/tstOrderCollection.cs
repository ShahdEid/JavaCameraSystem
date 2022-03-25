using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Camera_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //craete an instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            // test to see if it is correct 
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //craete an instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list 
            // create an item to test 
            clsOrder TestItem = new clsOrder();
            // set the properties 
            TestItem.PaymentStatus = true;
            TestItem.OrderID = 1;
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Quantity = "4";
            TestItem.ProductID = 2;
            TestItem.CustomerID = 3;
            // add order to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
            
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //craete an instance 
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    // create some test data to assign the property 
        //    Int32 SomeCount = 2;
        //    //assign the data to the property 
        //    AllOrders.Count = SomeCount;
        //    Assert.AreEqual(AllOrders.Count, SomeCount);  
         
        //        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //craete an instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some tests 
            clsOrder TestOrder = new clsOrder();
            // set the properties
            // set the properties 
            TestOrder.PaymentStatus = true;
            TestOrder.OrderID = 1;
            TestOrder.DateOfOrder = DateTime.Now.Date;
            TestOrder.Quantity = "4";
            TestOrder.ProductID = 2;
            TestOrder.CustomerID = 3;
            // assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);


        }

        [TestMethod]
        public void ListAndCountOK()
        {
            
                //craete an instance 
                clsOrderCollection AllOrders = new clsOrderCollection();
                List<clsOrder> TestList = new List<clsOrder>();
                // add an item to the list 
                // create an item to test 
                clsOrder TestItem = new clsOrder();
                // set the properties 
                TestItem.PaymentStatus = true;
                TestItem.OrderID = 1;
                TestItem.DateOfOrder = DateTime.Now.Date;
                TestItem.Quantity = "4";
                TestItem.ProductID = 2;
                TestItem.CustomerID = 3;
                // add order to the list
                TestList.Add(TestItem);
                //assign the data to the property
                AllOrders.OrderList = TestList;
                Assert.AreEqual(AllOrders.OrderList, TestList);

            }


        //[TestMethod]

        //public void TwoRecordsPresent()


        //{

        //    //craete an instance 
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    Assert.AreEqual(AllOrders.Count, 2);

        //}


        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the pk
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderID = 1;
            TestItem.Quantity = "22";
            TestItem.ProductID = 1;
            TestItem.DateOfOrder = Convert.ToDateTime("10/03/2022");
            TestItem.CustomerID = 1;
            TestItem.PaymentStatus = true;
            //set this orderr to the test data 
            AllOrders.ThisOrder = TestItem;
            //add record 
            PrimaryKey = AllOrders.Add();
            //set pk of the test data 
            TestItem.OrderID = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }




        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //var to store the pk
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderID = 1;
            TestItem.Quantity = "22";
            TestItem.ProductID = 1;
            TestItem.DateOfOrder = Convert.ToDateTime("10/03/2022");
            TestItem.CustomerID = 1;
            TestItem.PaymentStatus = true;
            //set this orderr to the test data 
            AllOrders.ThisOrder = TestItem;
            //add record 
            PrimaryKey = AllOrders.Delete();
            //set pk of the test data 
            TestItem.OrderID = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }








    }





    }

