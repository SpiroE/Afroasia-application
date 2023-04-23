using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        // Private data member for the Customer List
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        // Private data member for ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            // Variable for Index
            Int32 Index = 0;
            // Variable to store Record Count
            Int32 RecordCount = 0;
            // Object for SQL Data Connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure tblCustomer_SelectAll
            DB.Execute("sproc_tblCustomer_SelectAll");
            // Gets the count of records
            RecordCount = DB.Count;

            // While there are records to process...
            while (Index < RecordCount)
            {
                // Creates a new blank Customer
                clsCustomer ACustomer = new clsCustomer();
                // Setting the properties of each item
                ACustomer.AccountChecker = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountChecker"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNo"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerPass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                ACustomer.AccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                // Add items to Test List
                mCustomerList.Add(ACustomer);
                // Point to the next record
                Index++;
            }
        }

        // Public property for the Customer List
        public List<clsCustomer> CustomerList
        {
            get
            {
                // Return private data
                return mCustomerList;
            }
            set
            {
                // Set private date
                mCustomerList = value;
            }
        }

        // Public property for the Count method
        public int Count
        {
            get
            {
                // Return count of the list
                return mCustomerList.Count;
            }
            set
            {
                // Incomplete as of now
            }
        }

        // Public property for the ThisCustomer method
        public clsCustomer ThisCustomer {
        get
            {
                // Return private data
                return mThisCustomer;
            }
        set
            {
                // Set private data
                mThisCustomer = value;
            }
        }

        // Public property for the Add method
        public int Add()
        {
            // Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            // Setting the parameters for the Stored Procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerPhoneNo", mThisCustomer.CustomerPhoneNo);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPass", mThisCustomer.CustomerPass);
            DB.AddParameter("@AccountChecker", mThisCustomer.AccountChecker);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            // Execute query that returns the Primary Key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            // Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            // Setting the parameters for the Stored Procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerPhoneNo", mThisCustomer.CustomerPhoneNo);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPass", mThisCustomer.CustomerPass);
            DB.AddParameter("@AccountChecker", mThisCustomer.AccountChecker);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            // Execute the Stored Procedure
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}