using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Test to see if it exist
            Assert.IsNotNull(AStock);
        }
    }
}
