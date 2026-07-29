using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDatabase.Models
{
    public class Order
    {
        public int OrderId { get; set; } //auto-incremented primary key
        public int UserId { get; set; } //foreign key
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
