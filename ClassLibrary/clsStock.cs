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
    }
}