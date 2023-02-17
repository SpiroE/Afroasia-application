using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Fulfilled { get; set; }
        public DateTime DateAdded { get; set; }
        public int NoOfCases { get; set; }
        public int ProductID { get; set; }
        public string Address { get; set; }
        public int CustomerID { get; set; }
        public int OrderNo { get; set; }
    }
}
