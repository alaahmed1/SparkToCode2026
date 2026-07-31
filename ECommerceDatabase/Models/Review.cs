using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDatabase.Models
{
    public class Review
    {
        public int ReviewId { get; set; } //auto-incremented primary key
        public int OrderId { get; set; } //foreign key
        public string ReviewContent { get; set; }
        public int ReviewRating { get; set; } //1-5 rating
    }
}
