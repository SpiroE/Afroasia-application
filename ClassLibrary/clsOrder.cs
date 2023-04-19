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

        public string Valid(string CustomerID, string Address, string ProductID, string NoOfCases, string DateAdded)
        {
            // create string variable to store the error
            String Error = "";
            // create temporary variable to store the error
            int CustomerIDTemp;
            int ProductIDTemp;
            int NoOfCasesTemp;
            DateTime DateAddedTemp;
            try
            {
                //copy the customer id into the temporary varible
                CustomerIDTemp = Convert.ToInt32(CustomerID);
                if(CustomerIDTemp < 1)
                {
                    Error = Error + "The CustomerID cannot be smaller than 0 : ";
                }
                if(CustomerIDTemp > Int32.MaxValue)
                {
                    Error = Error + "The CustomerID cannot be bigger than " + Int32.MaxValue + " : ";
                }
            }
            catch
            {
                Error = Error + "The CustomerID wasn't a valid number : ";
            }

            if (Address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }
            if (Address.Length > 100)
            {
                Error = Error + "The address must be less than 100 characters : ";
            }

            try
            {
                //copy the customer id into the temporary varible
                ProductIDTemp = Convert.ToInt32(ProductID);
                if (ProductIDTemp < 1)
                {
                    Error = Error + "The ProductID cannot be smaller than 0 : ";
                }
                if (ProductIDTemp > Int32.MaxValue)
                {
                    Error = Error + "The ProductID cannot be bigger than " + Int32.MaxValue + " : ";
                }
            }
            catch
            {
                Error = Error + "The ProductID wasn't a valid number : ";
            }

            try
            {
                //copy the customer id into the temporary varible
                NoOfCasesTemp = Convert.ToInt32(NoOfCases);
                if (NoOfCasesTemp < 1)
                {
                    Error = Error + "The number of cases cannot be smaller than 0 : ";
                }
                if (NoOfCasesTemp > Int32.MaxValue)
                {
                    Error = Error + "The number of cases cannot be bigger than " + Int32.MaxValue + " : ";
                }
            }
            catch
            {
                Error = Error + "The NoOfCases wasn't a valid number : ";
            }

            try
            {
                //copy the customer id into the temporary varible
                DateAddedTemp = Convert.ToDateTime(DateAdded);
                if (DateAddedTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateAddedTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date added wasn't a valid date : ";
            }

            return Error;
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
