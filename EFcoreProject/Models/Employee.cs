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

        

        [ForeignKey("D")] //specifies that the DepartmentId property is a foreign key that references the primary key of the Department table. The string "D" refers to the navigation property D, which represents the relationship between Employee and Department.
        public int DepartmentId { get; set; }
        public Department D { get; set; } //An employee belongs to one department, so we use a single Department object to hold the reference to the associated department.

    }
}
