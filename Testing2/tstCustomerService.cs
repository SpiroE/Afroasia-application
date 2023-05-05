using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerService
    {
        //good test data 
        //create some test data to pass to the method
        string CustomerID = "1";
        string ProductID = "1";
        string Issue = "bad package";
        string IssueDate = DateTime.Now.Date.ToString();
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the new class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //test to see that it exists
            Assert.IsNotNull(ACustomerService);
        }

        [TestMethod]
        public void ReturnEligibilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomerService.ReturnEligibility = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerService.ReturnEligibility, TestData);
        }
        public void IssueDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomerService.IssueDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerService.IssueDate, TestData);
        }
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomerService.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerService.CustomerID, TestData);
        }
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomerService.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerService.ProductID, TestData);
        }
        public void IssueIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomerService.IssueID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerService.IssueID, TestData);

        }
        public void IssuePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //create some test data to assign to the property
            string TestData = "broken case";
            //assign the data to the property
            ACustomerService.Issue = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomerService.Issue, TestData);
        }
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 IssueID = 1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        public void TestIssueIDFound()
        {
            //create an instance of the class we want to create 
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueID =1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //check the Issue ID
            if (ACustomerService.IssueID !=1)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]        
        public void TestCustomerIDFound()
      {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueID =1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //check the property
            if (ACustomerService.CustomerID !=1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueID =1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //check the property
            if (ACustomerService.ProductID !=1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIssueFound()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueID =1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //check the property
            if (ACustomerService.Issue != " Issue ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReturnEligibilityFound()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueID =1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //check the property
            if (ACustomerService.ReturnEligibility != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIssueDateFound()
        {
            //create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IssueID =1;
            //invoke the method
            Found = ACustomerService.Find(IssueID);
            //check the property
            if (ACustomerService.IssueDate !=Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsCustomerService ACustomerService = new clsCustomerService();
            //string variable to store any error message
            string Error = "";
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //test to see result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "a";
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "aa";
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(199, 'a');
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(200, 'a');
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(100, 'a');
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(201, 'a'); //Should Fail
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, 'a'); //Should Fail
            //invoke the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueExtremeMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change date to 100 years before the current date
            TestDate = TestDate.AddYears(-100);
            //Converts the DateTime to a string
            string Issue = TestDate.ToString();
            //Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueMinLessOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //Converts the DateTime to a string
            string Issue = TestDate.ToString();
            //Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Converts the DateTime to a string
            string Issue = TestDate.ToString();
            //Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssueMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //Converts the DateTime to a string
            string Issue = TestDate.ToString();
            //Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueExtremeMax()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change date to 100 years after the current date
            TestDate = TestDate.AddYears(100);
            //Converts the DateTime to a string
            string Issue = TestDate.ToString();
            //Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueInvalidData()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Sets Issue to a non-date value
            string Issue = "This is not a date";
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MinValue;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 0;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 1;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 2;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue - 1;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue / 2;
            //Convert Test Data to string
            string ProductID = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateExtremeMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MinValue;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 0;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateMin()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 1;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 2;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateMax()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue - 1;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssueDateMid()
        {
            //Create an instance of the class we want to create
            clsCustomerService ACustomerService = new clsCustomerService();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue / 2;
            //Convert Test Data to string
            string IssueDate = TestData.ToString();
            // Invokes the method
            Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

    }
}

  





