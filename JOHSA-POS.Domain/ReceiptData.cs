using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOHSA_POS.Domain
{
    public sealed class ReceiptData
    {
        public string BusinessName;
        public string Address;
        public string Phone;
        public string OrderNumber;
        public DateTime Date;
        public string CashierName;

        public List<ReceiptLine> Lines = new List<ReceiptLine>();

        public decimal Subtotal;
        public decimal Tax;
        public decimal Discount;
        public decimal Total;
        public string PaymentMethod;
        public decimal AmountTendered;
        public decimal Change;
    }
}
