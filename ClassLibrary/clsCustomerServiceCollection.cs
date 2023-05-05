using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerServiceCollection
    {
        //Private data member for the list
        List<clsCustomerService> mCustomerServiceList = new List<clsCustomerService>();
        //Private data member ThisStock
        clsCustomerService mThisCustomerService = new clsCustomerService();

        //Public property for StockList
        public List<clsCustomerService> StockList
        {
            get
            {
                //Return private data
                return mCustomerServiceList;
            }
            set
            {
                //Set private data
                mCustomerServiceList = value;
            }
        }

        //Public property for This  Customerseervice
        public clsCustomerService ThisCustomerService
        {
            get
            {
                //Return the data
                return mThisCustomerService;
            }
            set
            {
                //Set private data
               mThisCustomerService = value;
            }
        }

        //Public property for Count
        public int Count
        {
            get
            {
                //Return the count on the list
                return mCustomerServiceList.Count;
            }
            set
            {
                //Set private data
            }
        }

        //Constructor for the class
        public clsCustomerServiceCollection()
        {
            //Object for SQL Data Connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomerService_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        //Add method
        public int Add()
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@Issue",mThisCustomerService.Issue);
            DB.AddParameter("@ReturnEligibility",mThisCustomerService.ReturnEligibility);
            DB.AddParameter("@ProductID",mThisCustomerService.ProductID);
            DB.AddParameter("@IssueDate",mThisCustomerService.IssueDate);
            DB.AddParameter("@CustomerID",mThisCustomerService.CustomerID);
            //Execute query that returns the Primary Key value
            return DB.Execute("sproc_tblCustomerService_Insert");
        }

        //Update method
        public int Update()
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@ProductID",mThisCustomerService.ProductID);
            DB.AddParameter("@Issue",mThisCustomerService.Issue);
            DB.AddParameter("@ReturnEligibility",mThisCustomerService.ReturnEligibility);
            DB.AddParameter("@ProductID",mThisCustomerService.ProductID);
            DB.AddParameter("@IssueDate",mThisCustomerService.IssueDate);
            DB.AddParameter("@CustomerID",mThisCustomerService.CustomerID);
            //Execute query that returns the Primary Key value
            return DB.Execute("sproc_tblCustomerService_Update");
        }

        //Delete method
        public void Delete()
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@ProductID",mThisCustomerService.ProductID);
            //Execute stored procedure
            DB.Execute("sproc_tblCustomerService_Delete");
        }

        //Filter method
        public void ReportByIssue(string Issue)
        {
            //Connecting to the Database
            clsDataConnection DB = new clsDataConnection();
            //Setting the parameters for the Stored Procedure
            DB.AddParameter("@Issue", Issue);
            //Execute stored procedure
            DB.Execute("sproc_tblCustomerService_FilterByIssue");
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
            mCustomerServiceList = new List<clsCustomerService>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank stock
                clsCustomerService AStock = new clsCustomerService();
                //Read in the fields from the current record
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.Issue = Convert.ToString(DB.DataTable.Rows[Index]["Issue"]);
                AStock.ReturnEligibility = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReturnEligibility"]);
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.IssueDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["IssueDate"]);
                AStock.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                //Add the record to the private data member
                mCustomerServiceList.Add(AStock);
                //Point at the next record
                Index++;
            }

        }
    }
}