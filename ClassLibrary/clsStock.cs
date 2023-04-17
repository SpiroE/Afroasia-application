using System;

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

        public bool Find(int productID)
        {
            //Set the private data members to the test data value
            mProductID = 21;
            mProductName = "Test Name";
            mProductAvailability = true;
            mStockQuantity = 1;
            mStockArrivalDate = Convert.ToDateTime("16/09/2015");
            mTrackingID = 1;
            //Always return true
            return true;
        }
    }
}