using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceDatabase.Models
{
    public class User
    {
        public int UserId { get; set; } //auto-incremented primary key
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
    }
}
