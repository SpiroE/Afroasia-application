using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for list
        private List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);

        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@NoOfCases", mThisOrder.NoOfCases);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Fulfilled", mThisOrder.Fulfilled);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", ThisOrder.OrderNo);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@NoOfCases", mThisOrder.NoOfCases);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Fulfilled", mThisOrder.Fulfilled);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByFulfilled(bool Fulfilled)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Fulfilled", Fulfilled);
            DB.Execute("sproc_tblOrder_FilterByFulfilled");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB) {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]); ;
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]); ;
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]); ;
                AnOrder.NoOfCases = Convert.ToInt32(DB.DataTable.Rows[Index]["NoOfCases"]); ;
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.Fulfilled = Convert.ToBoolean(DB.DataTable.Rows[Index]["Fulfilled"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }
}
}