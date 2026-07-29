using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDatabase.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //auto-incremented primary key
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
