using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // An instance of the class clsStaff
            clsStaff MyStock = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(MyStock);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //A n instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            JavaStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //An instance of the class clsStaff   
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "abc";
            //assign the data to the property
            JavaStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffName, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //An instance of the classclsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            JavaStaff.DateAdded = TestData;   
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.DateAdded, TestData);
        }
         
        [TestMethod]
        public void DOBPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Today;
            //assign the data to the property
            JavaStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.DOB, TestData);
        }



        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 0345678901;
            //assign the data to the property
           JavaStaff.StaffPhoneNo= TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.StaffPhoneNo, TestData);
        }


        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            JavaStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //An instance of the class clsStaff
            clsStaff JavaStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            JavaStaff.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(JavaStaff.Street, TestData);
        }


    }
}
