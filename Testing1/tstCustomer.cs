using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
       
        /*
         * PropertyOK methods are listed below
         */

        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the new Class wanting to be created
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
            // Tests to see if both values are the same
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
        
        /*
         * Found methods are listed below
         */

        [TestMethod]
        public void FindMethodOK()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store results of the validation process
            Boolean Found = false;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Tests to see if output is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerID != 3)
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountCheckerFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.AccountChecker != true)
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountCreationDateFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.AccountCreationDate != Convert.ToDateTime(DateTime.Now))
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerName != "Musa ibn Walid")
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNoFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerPhoneNo != "+447305097742")
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerEmail != "musawalid012@gmail.com")
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPassFound()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // Boolean used to store result of the search
            Boolean Found = false;
            // Boolean used to record
            Boolean OK = true;
            // Creates test data
            Int32 CustomerID = 3;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerPass != "password123")
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

    }
}
