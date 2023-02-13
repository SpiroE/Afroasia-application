using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the new Class specified below
            clsStaff AStaff = new clsStaff();
            // Tests to check existence
            Assert.IsNotNull(AStaff);
        }
    }
}
