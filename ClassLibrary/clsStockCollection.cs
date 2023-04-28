using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //Private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //Private data member ThisStock
        clsStock mThisStock = new clsStock();

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

        //Public property for ThisStock
        public clsStock ThisStock
        {
            get
            {
                //Return the data
                return mThisStock;
            }
            set
            {
                //Set private data
                mThisStock = value;
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
            //Object for SQL Data Connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        //Add method
        public int Add()
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@Availability", mThisStock.ProductAvailability);
            DB.AddParameter("@StockQnt", mThisStock.StockQuantity);
            DB.AddParameter("@StockArrivDate", mThisStock.StockArrivalDate);
            DB.AddParameter("@TrackingID", mThisStock.TrackingID);
            //Execute query that returns the Primary Key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        //Update method
        public int Update()
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@Availability", mThisStock.ProductAvailability);
            DB.AddParameter("@StockQnt", mThisStock.StockQuantity);
            DB.AddParameter("@StockArrivDate", mThisStock.StockArrivalDate);
            DB.AddParameter("@TrackingID", mThisStock.TrackingID);
            //Execute query that returns the Primary Key value
            return DB.Execute("sproc_tblSupplier_Update");
        }

        //Delete method
        public void Delete()
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            //Execute stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        //Filter method
        public void ReportByProductName(string productName)
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@ProductName", productName);
            //Execute stored procedure
            DB.Execute("sproc_tblSupplier_FilterByProductName");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        //Populate the array list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            //Variable for the index
            Int32 Index = 0;
            //Variable to store the record count
            Int32 RecordCount;
            //Get the record count
            RecordCount = DB.Count;
            //Clear the private array list
            mStockList = new List<clsStock>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank stock
                clsStock AStock = new clsStock();
                //Read in the fields from the current record
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AStock.ProductAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQnt"]);
                AStock.StockArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockArrivDate"]);
                AStock.TrackingID = Convert.ToInt32(DB.DataTable.Rows[Index]["TrackingID"]);
                //Add the record to the private data member
                mStockList.Add(AStock);
                //Point at the next record
                Index++;
            }

        }
    }
}