using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JOHSA_POS.Domain
{
    public sealed class CartLine
    {
        public int ProductId;
        public string Sku;
        public string ProductName;
        public int Quantity;
        public decimal UnitPrice;

        public decimal LineTotal
        {
            get { return Quantity * UnitPrice; }
        }
    }
}

