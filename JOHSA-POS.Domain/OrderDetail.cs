using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JOHSA_POS.Domain
{
    public sealed class OrderDetail
    {
        public int Id;
        public int OrderId;
        public int ProductId;
        public string ProductName;
        public int Quantity;
        public decimal UnitPrice;
        public decimal LineTotal;
    }
}

