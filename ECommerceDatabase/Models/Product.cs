using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDatabase.Models
{
    public class Product
    {
        public int ProductId { get; set; } //auto-incremented primary key
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; } //foreign key
    }
}
