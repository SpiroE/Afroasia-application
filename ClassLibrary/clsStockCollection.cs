using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //Private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        //Public property for StockList
        public List<clsStock> StockList
        {
            get
            {
                //Return private data
                return mStockList;
            }
            set
            {
                //Set private data
                mStockList = value;
            }
        }

        //Public property for Count
        public int Count
        {
            get
            {
                //Return the count on the list
                return mStockList.Count;
            }
            set
            {
                //Set private data
            }
        }

        //Constructor for the class
        public clsStockCollection()
        {
            //Variable for Index
            Int32 Index = 0;
            //Variable to store Record Count
            Int32 RecordCount = 0;
            //Object for SQL Data Connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //Gets the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank stock
                clsStock AStock = new clsStock();
                //Read in the properties from the database record
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AStock.ProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQnt"]);
                AStock.StockArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockArrivDate"]);
                AStock.TrackingID = Convert.ToInt32(DB.DataTable.Rows[Index]["TrackingID"]); 
                //Add the record to the private data member
                mStockList.Add(AStock);
                //Increase the index to point at the next record
                Index++;
            }
        }

        public clsStock ThisStock { get; set; }
    }
}