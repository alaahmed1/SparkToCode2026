using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreProject.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; } //all tables should have a primary key, and by convention, EF Core will treat a property named "Id" or "<ClassName>Id" as the primary key.
        public int SSN { get; set; } //Social Security Number, it differs from EmployeeId, which is a unique identifier for the employee in the database, while SSN is a government-issued identifier that may not be unique across different countries or regions.
        public string EmloyeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }

    }
}
