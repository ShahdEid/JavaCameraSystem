using CameraClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Camera_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()

        {
            //Create an instance of class we want to createsss
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(ACustomer);
       
        }
    }
}
