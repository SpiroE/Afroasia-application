using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerService
    {
        //private data member for the properties to use
        private int mIssueID;
        private int mCustomerID;
        private string mIssue;
        private int mProductID;
        private DateTime mIssueDate;
        private bool mReturnEligibility;
        //Public property
        public bool ReturnEligibility
        {
            get
            {
                return mReturnEligibility;
            }
            set
            {
                mReturnEligibility = value;
            }
        }

        public string ReturnEligibilityValid(bool testData)
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

        public DateTime IssueDate
        {
            get
            {
                return mIssueDate;
            }
            set
            {
                mIssueDate = value;
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

        public string Issue
        {
            get
            {
                return mIssue;
            }
            set
            {
                mIssue = value;
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

        public int IssueID
        {
            get
            {
                return mIssueID;
            }
            set
            {
                mIssueID = value;
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

        public string Valid(string CustomerID,
                            string ProductID,
                            string Issue,
                            string IssueDate)
        {
            // create string variable to store the error
            String Error = "";
            // create temporary variable to store the error
            int CustomerIDTemp;
            int ProductIDTemp;
            string IssueTemp;
            DateTime IssueDateTemp;
            try
            {
                //copy the customer id into the temporary varible
                CustomerIDTemp = Convert.ToInt32(CustomerID);
                if (CustomerIDTemp < 1)
                {
                    Error = Error + "The CustomerID cannot be smaller than 0 : ";
                }
                if (CustomerIDTemp > Int32.MaxValue)
                {
                    Error = Error + "The CustomerID cannot be bigger than " + Int32.MaxValue + " : ";
                }
            }
            catch
            {
                Error = Error + "The CustomerID wasn't a valid number : ";
            }

            if (Issue.Length == 0)
            {
                Error = Error + "The Issue may not be blank : ";
            }
            if (Issue.Length > 100)
            {
                Error = Error + "The Issue must be less than 100 characters : ";
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
                IssueTemp = Convert.ToString(Issue);
                if (IssueTemp.Length == 0)
                {
                    Error = Error + "The number of cases cannot be blank : ";
                }
                if (IssueTemp.Length>100)
                {
                    Error = Error + "The number of cases cannot be bigger than " + 100 + " : ";
                }
            }
            catch
            {
                Error = Error + "The Issue wasn't a valid number : ";
            }
            try
            {
                //copy the customer id into the temporary varible
                IssueDateTemp = Convert.ToDateTime(IssueDate);
                if (IssueDateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (IssueDateTemp > DateTime.Now.Date)
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
        public bool Find(int IssueID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Issue to search for
            DB.AddParameter("@IssueID", IssueID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerService_FilterByIssueID");
            // 0 means record was found so error comes up, 1 means its not in the database so its added
            if (DB.Count == 1)
            {
                mIssueID = Convert.ToInt32(DB.DataTable.Rows[0]["IssueID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mIssue = Convert.ToString(DB.DataTable.Rows[0]["Issue"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mIssueDate = Convert.ToDateTime(DB.DataTable.Rows[0]["IssueDate"]);
                mReturnEligibility = Convert.ToBoolean(DB.DataTable.Rows[0]["ReturnEligibility"]);
                return true;
            }
            else
            {
                return false;
            }
        } 



    }
}
