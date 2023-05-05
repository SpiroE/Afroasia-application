using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerServiceCollection
    {
       public List<clsCustomerService> CustomerServiceList 
        {
            get
            {
                //return private data
                return mCustomerServiceList;
            }
            set {
                //set private data
                mCustomerServiceList = value;
            }
        }
        public int Count
        {
            get
            {
                //return count of list
                return mCustomerServiceList.Count;
            } 
            set 
            { 
                //later
            }
        }
        public clsCustomerService ThisCustomerService { get; set; }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomerService);
        }
        [TestMethod]
        public void CustomerServiceListOK()
        {
            //create an instance
            // clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Assigns test data to the property
            List<clsCustomerService> TestList = new List<clsCustomerService>();
            //add item to list
            //Create test data to add to the list
            clsCustomerService TestItem = new clsCustomerService();
            //set properties
            TestItem.ReturnEligibility = true;
            TestItem.IssueID = 1;
            TestItem.CustomerID = 1;
            TestItem.ProductID = 1;
            TestItem.Issue = " bad";
            TestItem.IssueDate = DateTime.Now.Date;
            //add item to test list
            AllCustomerService.CustomerServiceList = TestList;
            //test that two values are same
            Assert.AreEqual(AllCustomerService.CustomerServiceList, TestList);
   }
        [TestMethod]
        public void ThisCustomerServiceOK()
        {
            //Creates an instance of the class we want to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Create test data to add to assign to property
            clsCustomerService TestCustomerService = new clsCustomerService();
            //Setting the properties of each item
            TestCustomerService.ProductID = 1;
            TestCustomerService.Issue = "";
            TestCustomerService.ReturnEligibility = true;
            TestCustomerService.IssueID= 1;
            TestCustomerService.IssueDate = DateTime.Now.Date;
            TestCustomerService.CustomerID = 1;
            //Assign test data to the property
            AllCustomerService.ThisCustomerService = TestCustomerService;
            // Tests to see if both values are the same
            Assert.AreEqual(AllCustomerService.ThisCustomerService, TestCustomerService);
        }

        [TestMethod]
        public void CountIssueOK()
        {
            //create instance
            clsCustomerService AllCustomerService = new clsCustomerService();
            //test to assign data to Issue
            AllCustomerService.Count = someCount;
            //test to see valuse are same
            Assert.AreEqual(AllCustomerService.Count, someCount);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //Creates an instance of the class we want to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Assigns test data to the property
            List<clsCustomerService> TestList = new List<clsCustomerService>();
            //Create test data to add to the list
            clsCustomerService TestItem = new clsCustomerService();
            //Setting the properties of each item
            TestItem.ProductID = 1;
            TestItem.Issue = "";
            TestItem.ReturnEligibility = true;
            TestItem.IssueID= 1;
            TestItem.IssueDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //Add the test items to the test list
            TestList.Add(TestItem);
            //Assign test data to the property
            AllCustomerService.CustomerServiceList = TestList;
            //Tests to see if both values are the same
            Assert.AreEqual(AllCustomerService, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create instance of class
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //test to see they are same
            Assert.AreEqual(AllCustomerService.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Creates an instance of the class we want to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Create item to test data 
            clsCustomerService TestItem = new clsCustomerService();
            //Variable to store Primary Key
            Int32 PrimaryKey = 0;
            //Setting the properties of each item
            TestItem.ProductID = 1;
            TestItem.Issue = "";
            TestItem.ReturnEligibility = true;
            TestItem.IssueID= 1;
            TestItem.IssueDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //Setting ThisCustomer to test data
            AllCustomerService.ThisCustomerService = TestItem;
            //Adding the record
            PrimaryKey = AllCustomerService.Add();
            //Setting the Primary Key of the test data
            TestItem.ProductID = PrimaryKey;
            //Find the record
            AllCustomerService.ThisCustomerService.Find(PrimaryKey);
            //Tests to see if both values are the same
            Assert.AreEqual(AllCustomerService.ThisCustomerService, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Creates an instance of the class we want to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Create item to test data 
            clsCustomerService TestItem = new clsCustomerService();
            //Variable to store Primary Key
            Int32 PrimaryKey = 0;
            //Setting the properties of each item
            TestItem.Issue = "";
            TestItem.ReturnEligibility = true;
            TestItem.IssueDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //Setting ThisCustomerService to test data
            AllCustomerService.ThisCustomerService = TestItem;
            //Adding the record
            PrimaryKey = AllCustomerService.Add();
            //Setting the Primary Key of the test data
            TestItem.IssueID = PrimaryKey;
            //Modifying the test data properties
            TestItem.Issue = "";
            TestItem.ReturnEligibility = false;
            TestItem.ProductID= 1;
            TestItem.IssueDate = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            //Setting the record based on the modified test data
            AllCustomerService.ThisCustomerService = TestItem;
            //Update the record
            AllCustomerService.Update();
            //Find the record
            AllCustomerService.ThisCustomerService.Find(PrimaryKey);
            //Tests to see if ThisCustomerService matches specified test data
            Assert.AreEqual(AllCustomerService.ThisCustomerService, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Creates an instance of the class we want to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Create item to test data 
            clsCustomerService TestItem = new clsCustomerService();
            //Variable to store Primary Key
            Int32 PrimaryKey = 0;
            //Setting the properties of each item
            TestItem.Issue = "";
            TestItem.ReturnEligibility = true;
            TestItem.IssueID= 1;
            TestItem.IssueDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //Setting ThisCustomerService to test data
            AllCustomerService.ThisCustomerService = TestItem;
            //Adding the record
            PrimaryKey = AllCustomerService.Add();
            //Setting the Primary Key of the test data
            TestItem.ProductID = PrimaryKey;
            //Find the record
            AllCustomerService.ThisCustomerService.Find(PrimaryKey);
            //Delete the record
            AllCustomerService.Delete();
            //Now find the record
            Boolean Found = AllCustomerService.ThisCustomerService.Find(PrimaryKey);
            //Tests to see that the record wasn't found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByIssueMethodOK()
        {
            //Creates an instance of the class we want to create
            clsCustomerServiceCollection AllCustomerService = new clsCustomerServiceCollection();
            //Create an instance of the filtered data 
            clsCustomerServiceCollection FilteredCustomerService = new clsCustomerServiceCollection();
            //Apply a blank string
            FilteredCustomerService.ReportByIssue("");
            //Tests to see that the record wasn't found
            Assert.AreEqual(AllCustomerService.Count, FilteredCustomerService.Count);
        }

        [TestMethod]
        public void ReportByIssueNoneFound()
        {
            //Create an instance of the filtered data 
            clsCustomerServiceCollection FilteredCustomerService = new clsCustomerServiceCollection();
            //Apply a product name that don't exist 
            FilteredCustomerService.ReportByIssue("XXX XXX");
            //Tests to see that there are no records
            Assert.AreEqual(0, FilteredCustomerService.Count);
        }

        [TestMethod]
        public void ReportByIssueTestDataFound()
        {
            //Create an instance of the filtered data 
            clsCustomerServiceCollection FilteredCustomerService = new clsCustomerServiceCollection();
            //Variable to store outcome
            Boolean OK = true;
            //Apply a product name that don't exist 
            FilteredCustomerService.ReportByIssue("ZZZ ZZZ");
            //Check if the currect number of records are found
            if (FilteredCustomerService.Count == 2)
            {
                //Check that the first record ID is 8
                if (FilteredCustomerService.CustomerServiceList[0].ProductID != 8)
                {
                    OK = false;
                }
                //Check that the first record ID is 9
                if (FilteredCustomerService.CustomerServiceList[1].ProductID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //Tests to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}