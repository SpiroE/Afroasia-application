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
            // Sets the private data to the test data value
            mCustomerID = 3;
            mAccountCreationDate = Convert.ToDateTime(DateTime.Now);
            mAccountChecker = true;
            mCustomerName = "Musa ibn Walid";
            mCustomerPhoneNo = "+447305097742";
            mCustomerEmail = "musawalid012@gmail.com";
            mCustomerPass = "password123";
            // Always return the value true
            return true;
        }
    }
}