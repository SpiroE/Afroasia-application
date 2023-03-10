using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data members for each of their respective properties
        private bool mAccountChecker;
        private DateTime mAccountCreationDate;
        private Int32 mCustomerID;
        private string mCustomerName;
        private string mCustomerPhoneNo;
        private string mCustomerEmail;
        private string mCustomerPass;

        /*
         * Public properties 
         */
        public bool AccountChecker
        {
            get
            {
                // Sends data out the property
                return mAccountChecker;
            }
            set
            {
                // Allows data into the property
                mAccountChecker = value;
            }
        }

        public DateTime AccountCreationDate
        {
            get
            {
                // Sends data out the property
                return mAccountCreationDate;
            }
            set
            {
                // Allows data into the property
                mAccountCreationDate = value;
            }
        }

        public Int32 CustomerID 
        {
            get
            {
                // Sends data out the property
                return mCustomerID;
            }
            set
            {
                // Allows data into the property
                mCustomerID = value;
            }
        }

        public string CustomerName
        {
            get
            {
                // Sends data out the property
                return mCustomerName;
            }
            set
            {
                // Allows data into the property
                mCustomerName = value;
            }
        }

        public string CustomerPhoneNo
        {
            get
            {
                // Sends data out the property
                return mCustomerPhoneNo;
            }
            set
            {
                // Allows data into the property
                mCustomerPhoneNo = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                // Sends data out the property
                return mCustomerEmail;
            }
            set
            {
                // Allows data into the property
                mCustomerEmail = value;
            }
        }

        public string CustomerPass
        {
            get
            {
                // Sends data out the property
                return mCustomerPass;
            }
            set
            {
                // Allows data into the property
                mCustomerPass = value;
            }
        }

        public bool Find(int CustomerID)
        {
            // Creates an instance of the data connection with SQL Server
            clsDataConnection DB = new clsDataConnection();
            // Adds the parameter for the CustomerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // Executes the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // If one record is found then there should be 1 or 0
            if (DB.Count == 1)
            {
                // Sets the private data to the test data value
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]); ;
                mAccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreationDate"]);
                mAccountChecker = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountChecker"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNo"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPass = Convert.ToString(DB.DataTable.Rows[0]["CustomerPass"]);
                // Always return the value true
                return true;
            }
            else 
            {
                // Returns a false value (issue present)
                return false;
            }
        }
    }
}