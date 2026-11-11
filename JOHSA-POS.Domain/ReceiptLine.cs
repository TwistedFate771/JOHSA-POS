using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JOHSA_POS.Domain
{
    public sealed class ReceiptLine
    {
        public string ProductName;
        public int Quantity;
        public decimal Amount;
    }
}

