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
            // Creates an instance of a new class
            clsStaff AStaff = new clsStaff();
            // checks existence
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ShiftConfirmationPropertyOK()
        {
            // Creates an instance of a new Class
            clsStaff AStaff = new clsStaff();
            // Creates test data
            Boolean TestData = true;
            // Assign data to the property 
            AStaff.ShiftConfirmation = TestData;
            //Checks if both values are the same
            Assert.AreEqual(AStaff.ShiftConfirmation, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // Creates an instance of a new Class
            clsStaff AStaff = new clsStaff();
            // Creates test data
            Int32 TestData = 1;
            // Assign data to the property 
            AStaff.StaffID = TestData;
            //Checks if both values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // Creates an instance of a new Class
            clsStaff AStaff = new clsStaff();
            // Creates test data
            String TestData = "Phil Smith";
            // Assign data to the property 
            AStaff.StaffName = TestData;
            //Checks if both values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }
        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {
            // Creates an instance of a new Class
            clsStaff AStaff = new clsStaff();
            // Creates test data
            String TestData = "+446441347562";
            // Assign data to the property 
            AStaff.StaffPhoneNo = TestData;
            //Checks if both values are the same
            Assert.AreEqual(AStaff.StaffPhoneNo, TestData);
        }
        [TestMethod]
        public void StaffPayrollPropertyOK()
        {
            // Creates an instance of a new Class
            clsStaff AStaff = new clsStaff();
            // Creates test data
            String  TestData = "16.00";
            // Assign data to the property 
            AStaff.StaffPayroll = TestData;
            //Checks if both values are the same
            Assert.AreEqual(AStaff.StaffPayroll, TestData);
        }
        [TestMethod]
        public void AttendancePropertyOK()
        {
            // Creates an instance of the new Class specificed below
            clsStaff AStaff = new clsStaff();
            // Creates test data
            DateTime TestData = DateTime.Now.Date;
            // Assigns the data to the property
            AStaff.Attendance = TestData;
            // Tests to see if both values are the same
            Assert.AreEqual(AStaff.Attendance, TestData);
        }
        [TestMethod]
        public void SchedulePropertyOK()
        {
            // Creates an instance of a new Class
            clsStaff AStaff = new clsStaff();
            // Creates test data
            String TestData = "Monday-Friday";
            // Assign data to the property 
            AStaff.Schedule = TestData;
            //Checks if both values are the same
            Assert.AreEqual(AStaff.Schedule, TestData);
        }

    }

}
