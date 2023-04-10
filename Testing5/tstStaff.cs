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
        [TestMethod]
        public void FindMethodOK()
        {
            // Creates an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the results of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff id
            if (AStaff.StaffID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
       
        [TestMethod]
        public void TestAttendanceFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check attendance
            if (AStaff.Attendance != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShiftConfirmationFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.ShiftConfirmation != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.StaffName != "Leyla Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNoFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.StaffPhoneNo != "+447305085596")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPayrollFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.StaffPayroll != "16.00")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestScheduleFound()
        {
            // Creates an instance of the new class we want to create 
            clsStaff AStaff = new clsStaff();
            // Boolean variable to stroe the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 11;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.Schedule != "Weekdays")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}
