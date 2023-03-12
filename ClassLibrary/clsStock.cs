using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public DateTime StockArrivalDate { get; set; }
        public int TrackingID { get; set; }
        public bool ProductAvailability { get; set; }
    }
}