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
            // Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            // Execute the Stored Procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // Populate Array List with the data table
            PopulateArray(DB);
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

        public void Delete()
        {
            // Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            // Setting the parameters for the Stored Procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            // Execute the Stored Procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            // Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            // Send Customer Name parameter to the Database
            DB.AddParameter("@CustomerName", CustomerName);
            // Execute the Stored Procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            // Populate Array List with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            // Variable for Index
            Int32 Index = 0;
            // Variable to store Record Count
            Int32 RecordCount = 0;
            // Gets the count of Records
            RecordCount = DB.Count;
            // Clears the private Array List
            mCustomerList = new List<clsCustomer>();
            // While there are records to process then...
            while (Index < RecordCount)
            {
                // Creates a blank address
                clsCustomer ACustomer = new clsCustomer();
                // Read the fiels of the current Record
                ACustomer.AccountChecker = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountChecker"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhoneNo"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerPass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                ACustomer.AccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                // Add record to the private data member
                mCustomerList.Add(ACustomer);
                // Point to the next record available
                Index++;
            }
        }
    }
}