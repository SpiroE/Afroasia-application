using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the new Class specified below
            clsCustomer ACustomer = new clsCustomer();
            // Tests to check existence
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void AccountCheckerPropertyOK()
        {
            // Creates an instance of the new Class specified below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            Boolean TestData = true;
            // Assigns the data to the property
            ACustomer.AccountChecker = TestData;
            // Tests to see if both values are the same#
            Assert.AreEqual(ACustomer.AccountChecker, TestData);
        }

        [TestMethod]
        public void AccountCreationDatePropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            DateTime TestData = DateTime.Now.Date;
            // Assigns the data to the property
            ACustomer.AccountCreationDate = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(ACustomer.AccountCreationDate, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            Int32 TestData = 1;
            // Assigns the data to the property
            ACustomer.CustomerID = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            string TestData = "Musa ibn Walid";
            // Assigns the data to the property
            ACustomer.CustomerName = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNoPropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            string TestData = "+447305097742";
            // Assigns the data to the property
            ACustomer.CustomerPhoneNo = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(ACustomer.CustomerPhoneNo, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            string TestData = "musawalid012@gmail.com";
            // Assigns the data to the property
            ACustomer.CustomerEmail = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPassPropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsCustomer ACustomer = new clsCustomer();
            // Creates test data
            string TestData = "password123";
            // Assigns the data to the property
            ACustomer.CustomerPass = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(ACustomer.CustomerPass, TestData);
        }

    }
}
