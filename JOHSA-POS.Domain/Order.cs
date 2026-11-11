using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOHSA_POS.Domain
{
    public sealed class Order
    {
        public int Id;
        public string OrderNumber;
        public int UserId;
        public DateTime OrderDate;
        public decimal Subtotal;
        public decimal Tax;
        public decimal Discount;
        public decimal Total;
    }
}
