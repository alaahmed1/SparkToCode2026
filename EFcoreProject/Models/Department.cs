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


        public List<Employee> Employees { get; set; } //navigation property to represent the one-to-many relationship between Department and Employee. A department can have multiple employees, so we use a List<Employee> to hold the collection of employees associated with a department.

    }
}
