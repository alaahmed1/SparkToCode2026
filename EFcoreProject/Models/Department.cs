using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; } //will be treated as 1, 2, 3, etc. by default, as the primary key for the Department table.
        public int DepartmentNumber { get; set; } // for example 20, 10, 30, etc.
        public string DepartmentName { get; set; } // for example "Research", "Sales", "Accounting", etc.

    }
}
