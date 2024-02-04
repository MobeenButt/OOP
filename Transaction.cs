using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales
{
    class Transaction
    {
        public int TransactionID;
        public string ProductName;
        public int Amount;
        public string Date;
        public string Time;

        public Transaction()
        {

            ///my deafult constructor
        }
        public Transaction(Transaction Copy)
        {
            TransactionID = Copy.TransactionID;
            ProductName = Copy.ProductName;
            Amount = Copy.Amount;
            Date = Copy.Date;
            Time = Copy.Time;

        }

    }
}
