using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Checks existence
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Assigns test data to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            // Creates test data
            clsCustomer TestItem = new clsCustomer();
            // Setting the properties of each item
            TestItem.AccountChecker = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Aisha Selcuk";
            TestItem.CustomerPhoneNo = "+447305082284";
            TestItem.CustomerEmail = "aishaselcuk02@gmail.com";
            TestItem.CustomerPass = "SecretPassword198!!";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            // Add the test items to the test list
            TestList.Add(TestItem);
            // Assigns test data to the propertry
            AllCustomers.CustomerList = TestList;
            // Tests to see if both values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Creates test data to assign to property
            clsCustomer TestCustomer = new clsCustomer();
            // Setting the properties of the test object
            TestCustomer.AccountChecker = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Aisha Selcuk";
            TestCustomer.CustomerPhoneNo = "+447305082284";
            TestCustomer.CustomerEmail = "aishaselcuk02@gmail.com";
            TestCustomer.CustomerPass = "SecretPassword198!!";
            TestCustomer.AccountCreationDate = DateTime.Now.Date;
            // Assigns test data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            // Tests to see if both values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Assigns test data to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            // Creates test data
            clsCustomer TestItem = new clsCustomer();
            // Setting the properties of each item
            TestItem.AccountChecker = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Aisha Selcuk";
            TestItem.CustomerPhoneNo = "+447305082284";
            TestItem.CustomerEmail = "aishaselcuk02@gmail.com";
            TestItem.CustomerPass = "SecretPassword198!!";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            // Add the test items to the test list
            TestList.Add(TestItem);
            // Assigns test data to the propertry
            AllCustomers.CustomerList = TestList;
            // Tests to see if both values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Creates test data to assign to property
            clsCustomer TestItem = new clsCustomer();
            // Variable to store Primary Key
            Int32 PrimaryKey = 0;
            // Setting the properties of each
            TestItem.AccountChecker = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Test User";
            TestItem.CustomerPhoneNo = "+447950475512";
            TestItem.CustomerEmail = "testuserinput@gmail.com";
            TestItem.CustomerPass = "testpassword123!";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            // Setting ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            // Adding the record
            PrimaryKey = AllCustomers.Add();
            // Setting the Primary Key of the test data
            TestItem.CustomerID = PrimaryKey;
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Tests to see if both values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Creates test data to assign to property
            clsCustomer TestItem = new clsCustomer();
            // Variable to store Primary Key
            Int32 PrimaryKey = 0;
            // Setting the properties of each
            TestItem.AccountChecker = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Test User";
            TestItem.CustomerPhoneNo = "+447950475512";
            TestItem.CustomerEmail = "testuserinput@gmail.com";
            TestItem.CustomerPass = "testpassword123!";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            // Setting ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            // Adding the record
            PrimaryKey = AllCustomers.Add();
            // Setting the Primary Key of the test data
            TestItem.CustomerID = PrimaryKey;
            // Modifying the properties
            TestItem.AccountChecker = false;
            TestItem.CustomerID = 10;
            TestItem.CustomerName = "Test User Modified";
            TestItem.CustomerPhoneNo = "+448061586623";
            TestItem.CustomerEmail = "testuserinputmodified@gmail.com";
            TestItem.CustomerPass = "testpassword123modified!";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            // Setting the record based upon the modified test data
            AllCustomers.ThisCustomer = TestItem;
            // Update the record
            AllCustomers.Update();
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Tests to see if ThisCustomer matches specified test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Creates an instance of the Class specified below
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Creates test data to assign to property
            clsCustomer TestItem = new clsCustomer();
            // Variable to store Primary Key
            Int32 PrimaryKey = 0;
            // Setting the properties of each
            TestItem.AccountChecker = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Test User";
            TestItem.CustomerPhoneNo = "+447950475512";
            TestItem.CustomerEmail = "testuserinput@gmail.com";
            TestItem.CustomerPass = "testpassword123!";
            TestItem.AccountCreationDate = DateTime.Now.Date;
            // Setting ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            // Adding the record
            PrimaryKey = AllCustomers.Add();
            // Setting the Primary Key of the test data
            TestItem.CustomerID = PrimaryKey;
            // Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Delete the record
            AllCustomers.Delete();
            // Find the record again
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            // Tests to see if the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            // Creates an instance of the Class specified below containing unfiltered results/data
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // Creates an instance of the Class specified below containing filtered results/data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Apply blank string to return all records
            FilteredCustomers.ReportByCustomerName("");
            // Tests to see if both values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            // Creates an instance of the Class specified below containing filtered results/data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Apply a Customer Name that doesn't exist
            FilteredCustomers.ReportByCustomerName("xxxxx");
            // Tests to see if there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            // Creates an instance of the Class specified below containing filtered results/data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            // Variable to store result
            Boolean OK = true;
            // Apply a Customer Name that doesn't exist
            FilteredCustomers.ReportByCustomerName("xxxxx");
            // Checks if correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                // Check that the first record has the ID 20
                if (FilteredCustomers.CustomerList[0].CustomerID != 20)
                {
                    OK = false;
                }
                // Check that the first record has the ID 22
                if (FilteredCustomers.CustomerList[1].CustomerID != 22)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // Tests to see if there are no records
            Assert.IsTrue(OK);
        }

    }
}
