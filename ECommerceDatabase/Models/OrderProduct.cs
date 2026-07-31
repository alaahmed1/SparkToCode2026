using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDatabase.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; } //auto-incremented primary key
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
