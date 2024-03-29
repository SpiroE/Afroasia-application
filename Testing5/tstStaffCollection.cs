﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists 
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            List<clsStaff> TestList = new List<clsStaff>();
            //add the item to the list
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //setting the properties
            TestItem.ShiftConfirmation = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Baran";
            TestItem.StaffPhoneNo = "0719460456";
            TestItem.StaffPayroll = "16.00";
            TestItem.Schedule = "Weekdays";
            TestItem.Attendance = DateTime.Now;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to the property
            AllStaff.StaffList = TestList;
            //test to see that both values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            clsStaff TestStaff = new clsStaff();
            //setting the properties
            TestStaff.ShiftConfirmation = true;
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Baran";
            TestStaff.StaffPhoneNo = "0719460456";
            TestStaff.StaffPayroll = "16.00";
            TestStaff.Schedule = "Weekdays";
            TestStaff.Attendance = DateTime.Now;
            //assign data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that both values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            List<clsStaff> TestList = new List<clsStaff>();
            //add the item to the list
            //create item of test data
            clsStaff TestItem = new clsStaff();
            //setting the properties
            TestItem.ShiftConfirmation = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Baran";
            TestItem.StaffPhoneNo = "0719460456";
            TestItem.StaffPayroll = "16.00";
            TestItem.Schedule = "Weekdays";
            TestItem.Attendance = DateTime.Now;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to the property
            AllStaff.StaffList = TestList;
            //test to see that both values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //setting the properties
            TestItem.ShiftConfirmation = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Test Add";
            TestItem.StaffPhoneNo = "0719464469";
            TestItem.StaffPayroll = "17.50";
            TestItem.Schedule = "Weekdays";
            TestItem.Attendance = DateTime.Now.Date;
            //setting ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set primary key of test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //tests to see that both values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //setting the properties
            TestItem.ShiftConfirmation = true;
            TestItem.StaffID = 8;
            TestItem.StaffName = "Test Add";
            TestItem.StaffPhoneNo = "0719464469";
            TestItem.StaffPayroll = "17.50";
            TestItem.Schedule = "Weekdays";
            TestItem.Attendance = DateTime.Now.Date;
            //setting ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set primary key of test data
            TestItem.StaffID = PrimaryKey;
            //modifying the test data
            TestItem.ShiftConfirmation = false;
            TestItem.StaffID = 9;
            TestItem.StaffName = "Test Modify";
            TestItem.StaffPhoneNo = "0791664496";
            TestItem.StaffPayroll = "19.50";
            TestItem.Schedule = "Weekends";
            TestItem.Attendance = DateTime.Now.Date;
            //set record based on new data
            AllStaff.ThisStaff = TestItem;
            //update record
            AllStaff.Update();
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //tests to see if ThisStaff matches test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //setting the properties
            TestItem.ShiftConfirmation = true;
            TestItem.StaffID = 8;
            TestItem.StaffName = "Test Add";
            TestItem.StaffPhoneNo = "0719464469";
            TestItem.StaffPayroll = "17.50";
            TestItem.Schedule = "Weekdays";
            TestItem.Attendance = DateTime.Now.Date;
            //setting ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set primary key of test data
            TestItem.StaffID = PrimaryKey;
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete record
            AllStaff.Delete();
            //find the record again
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //tests to see if the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStaffNameMethodOK()
        {
            //create an instance of the class we want to create with unfiltered data
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply blank string to return all records
            FilteredStaff.ReportByStaffName("");
            //tests to see if both values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply blank string to return all records
            FilteredStaff.ReportByStaffName("xxxxxxx");
            //tests to see if both values are the same
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply staff name that doesn't exist
            FilteredStaff.ReportByStaffName("yyyyyyy");
            //check that the correct number of records have been found
            if (FilteredStaff.Count == 2)
            {
                //check if first record is 25
                if (FilteredStaff.StaffList[0].StaffID != 25)
                {
                    OK = false;
                }
                //check if second record is 27
                if (FilteredStaff.StaffList[1].StaffID != 27)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //tests to see if there are no record
            Assert.IsTrue(OK);
        }

    }
}
