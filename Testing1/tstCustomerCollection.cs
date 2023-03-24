using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
