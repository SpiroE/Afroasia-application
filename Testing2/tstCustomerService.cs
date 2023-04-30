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
    }
}
