using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace JOHSA_POS.Domain
{
    public sealed class Product
    {
        public int Id { 
            get; 
            set;
        }
        public string Sku { 
            get; 
            set; 
        }
        public string Barcode {
            get; 
            set;
        }
        public string Name { 
            get; 
            set;
        }
        public int CategoryId {
            get; 
            set; 
        }
        public decimal CostPrice {
            get; 
            set; 
        }
        public decimal SellingPrice { 
            get;
            set; 
        }
        public int StockQuantity {
            get; 
            set;
        }
        public int ReorderLevel { 
            get; 
            set;
        }
        public string ImagePath { 
            get; 
            set; 
        }
        public bool IsActive { 
            get; 
            set; 
        }
    }
}


