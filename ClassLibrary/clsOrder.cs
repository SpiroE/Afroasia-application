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

        public string FulfilledValid(bool testData)
        {
            if (testData != true && testData != false)
            {
                return "Please select true or false";
            }
            else
            {
                return "";
            }
        }

        public DateTime DateAdded { get; set; }
        public int NoOfCases { get; set; }
        public int ProductID { get; set; }
        public string Address { get; set; }

        public string AddressValid(string testData)
        {
            if (testData.Length < 1)
            {
                return "The address cannot be blank";
            }
            if(testData.Length > 100)
            {
                return "The address cannot be bigger than 100 characters";
            }
            else
            {
                return "";
            }
        }

        public int CustomerID { get; set; }
        public int OrderNo { get; set; }

        public string DateAddedValid(DateTime testData)
        {
            DateTime TestDate = DateTime.Now.Date.AddYears(-1);
            DateTime TestDate2 = DateTime.Now.Date;
            if (testData < TestDate)
            {
                return "Date is more than 1 year old";
            }
            if(testData > TestDate2)
            {
                return "Date cannot be after today";
            }
            else
            {
                return "";
            }
        }

        public string NoOfCasesValid(int testData)
        {
           
            if (testData < 1)
            {
                return "The number must be between 0 and " + int.MaxValue + ".";
            }
            if (testData > int.MaxValue)
            {
                return "The number must not exceed " + int.MaxValue + ".";
            }
            else
            {
                return "";
            }
        }

        public string ProductIDValid(int testData)
        {
            if (testData < 1)
            {
                return "The number must be between 0 and " + int.MaxValue + ".";
            }
            if (testData > int.MaxValue)
            {
                return "The number must not exceed " + int.MaxValue + ".";
            }
            else
            {
                return "";
            }
        }
    }
}
