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
    }
}
