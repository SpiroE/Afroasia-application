using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        //function for the public validation method
        string Schedule = "Weekdays";
        string StaffName = "Baran";
        string StaffPhoneNo = "0719460456";
        string StaffPayroll = "16.00";
        string Attendance = DateTime.Now.Date.ToString();


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
            String TestData = "16.00";
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
            Int32 StaffID = 1;
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
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff id
            if (AStaff.StaffID != 1)
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
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check attendance
            if (AStaff.Attendance != Convert.ToDateTime("06/04/2023 00:00:00"))
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
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 1;
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
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.StaffName != "Baran")
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
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check staff name
            if (AStaff.StaffPhoneNo != "0719460456")
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
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 1;
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
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to recoed if the data is ok 
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 1;
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //creates an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "B";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "Ba";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMinLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMin()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "0";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMinPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "07";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMaxLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "07859473827492";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "078594738274921";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMaxPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "0785947382749212";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMid()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "0785947";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoExtremeMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPhoneNo = "";
            StaffPhoneNo = StaffPhoneNo.PadRight(100, '1');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMinLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMin()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "1";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMinPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "12";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMaxLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "10000000000000";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "100000000000000";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMaxPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "1000000000000000";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollMid()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "1000000";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPayrollExtremeMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string StaffPayroll = "";
            StaffPayroll = StaffPayroll.PadRight(120, '1'); //triggers the error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMinLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = ""; //triggers the error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMin()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = "W";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMinPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = "We";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMaxLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = "Weekdayssssssssssss";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = "Weekdaysssssssssssss";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMid()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = "Weekdaysss";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleMaxPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = "Weekdayssssssssssssss"; //triggers the error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ScheduleExtremeMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            string Schedule = ""; //triggers the error
            Schedule = Schedule.PadRight(120, 'a'); //triggers the error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AttendanceExtremeMin()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            DateTime TestDate;
            //set date to todays
            TestDate = DateTime.Now.Date;
            //change date to 100 years prior
            TestDate = TestDate.AddYears(-100);
            //convert date to string
            string Attendance = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AttendanceMinLessOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            DateTime TestDate;
            //set date to todays
            TestDate = DateTime.Now.Date;
            //change date to 100 years prior
            TestDate = TestDate.AddYears(-1);
            //convert date to string
            string Attendance = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AttendanceMin()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            DateTime TestDate;
            //set date to todays
            TestDate = DateTime.Now.Date;
            //convert date to string
            string Attendance = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AttendanceMinPlusOne()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            DateTime TestDate;
            //set date to todays
            TestDate = DateTime.Now.Date;
            //change date to tomorrow
            TestDate = TestDate.AddDays(1);
            //convert date to string
            string Attendance = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AttendanceExtremeMax()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method
            DateTime TestDate;
            //set date to todays
            TestDate = DateTime.Now.Date;
            //change date to 100 years after
            TestDate = TestDate.AddYears(100);
            //convert date to string
            string Attendance = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AttendanceInvalidData()
        {
            //create an instance of the new class to be created
            clsStaff AStaff = new clsStaff();
            //string to store an error message
            String Error = "";
            //creates test data to pass to method using a non-date value
            string Attendance = "This isn't a valid date!";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
            //test to see if output is true
            Assert.AreNotEqual(Error, "");
        }

    }
}