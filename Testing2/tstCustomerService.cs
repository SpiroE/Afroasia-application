using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerService
    {
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
            Assert.AreNotEqual(ACustomerService.ReturnEligibilty, TestData);
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


    }
}




