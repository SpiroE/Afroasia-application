using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        // Set of test data to pass onto the Valid method
        string CustomerName = "Musa ibn Walid";
        string CustomerPhoneNo = "+447305097742";
        string CustomerEmail = "musawalid012@gmail.com";
        string CustomerPass = "password123";
        string AccountCreationDate = DateTime.Now.Date.ToString();

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
            Int32 CustomerID = 1;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.AccountCreationDate != Convert.ToDateTime("13/02/2023"))
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
            Int32 CustomerID = 1;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerName != "Aisha Selcuk")
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
            Int32 CustomerID = 1;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerPhoneNo != "+447305082284")
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
            Int32 CustomerID = 1;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerEmail != "aishaselcuk02@gmail.com")
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
            Int32 CustomerID = 1;
            // Invokes the method
            Found = ACustomer.Find(CustomerID);
            // Checks the property
            if (ACustomer.CustomerPass != "SecretPassword198!!")
            {
                OK = false;
            }
            // Tests to see if output is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        /*
         * CustomerName Testing - Min Mid Max
         */

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "m";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "mu";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(250, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        /*
         * AccountCreationDate Testing - Min Mid Max
         */

        [TestMethod]
        public void AccountCreationDateExtremeMin()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            DateTime TestDate;
            // Set the date to todays
            TestDate = DateTime.Now.Date;
            // Change date to 100 years before the current date
            TestDate = TestDate.AddYears(-100);
            // Converts the DateTime to a string
            string AccountCreationDate = TestDate.ToString();
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMinLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            DateTime TestDate;
            // Set the date to todays
            TestDate = DateTime.Now.Date;
            // Change date to one day before the current date
            TestDate = TestDate.AddDays(-1);
            // Converts the DateTime to a string
            string AccountCreationDate = TestDate.ToString();
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AccountCreationDateMinPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            DateTime TestDate;
            // Set the date to todays
            TestDate = DateTime.Now.Date;
            // Change date to one day after the current date
            TestDate = TestDate.AddDays(1);
            // Converts the DateTime to a string
            string AccountCreationDate = TestDate.ToString();
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateExtremeMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            DateTime TestDate;
            // Set the date to todays
            TestDate = DateTime.Now.Date;
            // Change date to 100 years after the current date
            TestDate = TestDate.AddYears(100);
            // Converts the DateTime to a string
            string AccountCreationDate = TestDate.ToString();
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateInvalidData()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Sets AccountCreationDate to a non-date value
            string AccountCreationDate = "This is not a date";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        /*
         * CustomerPhoneNo Testing - Min Mid Max
         */

        [TestMethod]
        public void CustomerPhoneNoMinLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMin()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "+";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMinPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "+4";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMaxLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "+4483283195038";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "+44832831950382";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMaxPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "+448328319503824";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNoMid()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPhoneNo = "+448328";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        /*
         * CustomerEmail Testing - Min Mid Max
         */

        [TestMethod]
        public void CustomerEmailLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "a";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "aa";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(89, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(90, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(91, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(45, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(250, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        /*
         * CustomerPass Testing - Min Mid Max
         */
        
        [TestMethod]
        public void CustomerPassLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        public void CustomerPassMin()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "a";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMinPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerEmail = "aa";
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMaxLessOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(49, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(50, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMaxPlusOne()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(51, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMid()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(25, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassExtremeMax()
        {
            // Creates an instance of the new Class wanting to be created
            clsCustomer ACustomer = new clsCustomer();
            // String to store any sort of error message
            String Error = "";
            // Creates test data
            string CustomerPass = "";
            CustomerPass = CustomerPass.PadRight(250, 'a');
            // Invokes the method
            Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

    }
}