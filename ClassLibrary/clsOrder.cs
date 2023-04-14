using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the properties to use
        private int mOrderNo;
        private int mCustomerID;
        private string mAddress;
        private int mProductID;
        private int mNoOfCases;
        private DateTime mDateAdded;
        private bool mFulfilled;
        //Public property
        public bool Fulfilled
        {
            get
            {
                return mFulfilled;
            }
            set
            {
                mFulfilled = value;
            }
        }

        public string FulfilledValid(bool testData)
        {
            if (testData != true && testData != false)
            {
                return "Please select true or false";
            }
            else
            {
                return "";
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public string DateAddedValid(DateTime testData)
        {
            DateTime TestDate = DateTime.Now.Date.AddYears(-1);
            DateTime TestDate2 = DateTime.Now.Date;
            if (testData < TestDate)
            {
                return "Date is more than 1 year old";
            }
            if (testData > TestDate2)
            {
                return "Date cannot be after today";
            }
            else
            {
                return "";
            }
        }

        public int NoOfCases
        {
            get
            {
                return mNoOfCases;
            }
            set
            {
                mNoOfCases = value;
            }
        }
        public string NoOfCasesValid(int testData)
        {

            if (testData < 1)
            {
                return "The number must be between 0 and " + int.MaxValue + ".";
            }
            if (testData > int.MaxValue)
            {
                return "The number must not exceed " + int.MaxValue + ".";
            }
            else
            {
                return "";
            }
        }

        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public string ProductIDValid(int testData)
        {
            if (testData < 1)
            {
                return "The number must be between 0 and " + int.MaxValue + ".";
            }
            if (testData > int.MaxValue)
            {
                return "The number must not exceed " + int.MaxValue + ".";
            }
            else
            {
                return "";
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string AddressValid(string testData)
        {
            if (testData.Length < 1)
            {
                return "The address cannot be blank";
            }
            if(testData.Length > 100)
            {
                return "The address cannot be bigger than 100 characters";
            }
            else
            {
                return "";
            }
        }

        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public string CustomerIDValid(int testData)
        {
            if (testData < 1)
            {
                return "The number must be between 0 and " + int.MaxValue + ".";
            }
            if (testData > int.MaxValue)
            {
                return "The number must not exceed " + int.MaxValue + ".";
            }
            else
            {
                return "";
            }
        }

        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        public string OrderIDValid(int testData)
        {
            if (testData < 1)
            {
                return "The number must be between 0 and " + int.MaxValue + ".";
            }
            if (testData > int.MaxValue)
            {
                return "The number must not exceed " + int.MaxValue + ".";
            }
            else
            {
                return "";
            }
        }
        public bool Find(int OrderNo)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            // 0 means record was found so error comes up, 1 means its not in the database so its added
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]); ;
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]); ;
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]); ;
                mNoOfCases = Convert.ToInt32(DB.DataTable.Rows[0]["NoOfCases"]); ;
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mFulfilled = Convert.ToBoolean(DB.DataTable.Rows[0]["Fulfilled"]);
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
