using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsStock
    {
        //Private member variables
        private Int32 mProductID;
        private string mProductName;
        private Boolean mProductAvailability;
        private Int32 mStockQuantity;
        private DateTime mStockArrivalDate;
        private Int32 mTrackingID;

        //ProductID public property
        public int ProductID
        {
            get
            {
                //return the private data
                return mProductID;
            }
            set
            {
                //set the private data
                mProductID = value;
            }
        }

        //ProductName public property
        public string ProductName
        {
            get
            {
                //return the private data
                return mProductName;
            }
            set
            {
                //set the private data
                mProductName = value;
            }
        }

        //ProductAvailability public property
        public bool ProductAvailability
        {
            get
            {
                //return the private data
                return mProductAvailability;
            }
            set
            {
                //set the private data
                mProductAvailability = value;
            }
        }

         //StockQuantity public property
        public int StockQuantity
        {
            get
            {
                //return the private data
                return mStockQuantity;
            }
            set
            {
                //set the private data
                mStockQuantity = value;
            }
        }

        //StockArrivalDate public property
        public DateTime StockArrivalDate
        {
            get
            {
                //return the private data
                return mStockArrivalDate;
            }
            set
            {
                //set the private data
                mStockArrivalDate = value;
            }
        }

        //TrackingID public property
        public int TrackingID
        {
            get
            {
                //return the private data
                return mTrackingID;
            }
            set
            {
                //set the private data
                mTrackingID = value;
            }
        }

        //Find method
        public bool Find(int productID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter to search for the ProductID
            DB.AddParameter("@ProductID", productID);
            //Execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByProductID");
            //If one record is found then there should be 1 or 0
            if (DB.Count == 1)
            {
                //Sets the private data to the test data value from the database
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]); 
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQnt"]);
                mStockArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StockArrivDate"]);
                mTrackingID = Convert.ToInt32(DB.DataTable.Rows[0]["TrackingID"]);
                //Always return the value true
                return true;
            }
            else
            {
                //Returns a false value the record wasn't found
                return false;
            }
        }

        public string Valid(string productName, string stockQuantity, string stockArrivalDate, string trackingID)
        {
            // String to store any sort of error message
            String Error = "";
            //Create a temporary variable to store Date value
            DateTime DateTemp;
            //Create a temporary variable to store Int value
            int IntTemp;

            //If the ProductName is blank send an error message
            if (productName.Length == 0)
            {
                Error = Error + "The Product Name cannot be blank";
            }
            //If the ProductName is more than 200 send an error message
            if (productName.Length > 200)
            {
                Error = Error + "The Product Name cannot be more than 200 characters";
            }

            //Use try-catch to make sure the stockArrivalDate has valid data
            try
            {
                //Set the DateTemp variable as the parameter passed in the method
                DateTemp = Convert.ToDateTime(stockArrivalDate);
                //If the date is lower than today's date it sends an error
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be set in the past";
                }
                //If the date is higher than today's date it sends an error
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be set in the past";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date";
            }

            //Set the IntTemp variable as the parameter passed in the method
            IntTemp = Convert.ToInt32(stockQuantity);
            //If the StockQuantity is less than 1 send an error
            if (IntTemp < 1)
            {
                Error = Error + "The stock quantity cannot be less than 1";
            }

            //Set the IntTemp variable as the parameter passed in the method
            IntTemp = Convert.ToInt32(trackingID);
            //If the TrackingID is less than 1 send an error
            if (IntTemp < 1)
            {
                Error = Error + "The tracking ID cannot be less than 1";
            }

            //Return any error message 
            return Error;
        }

    }
}