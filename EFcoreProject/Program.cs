using System;
using EFcoreProject.Models; //importing the models namespace to use the Employee and Department classes in the Program class.

namespace EFcoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext(); //creating an instance of the ProjectContext class to access the database

            //adding an emloyee
            Employee e1 = new Employee();
            e1.EmloyeeName = "Ahmed";
            e1.EmployeeAge = 30;
            e1.EmployeeSalary = 50000.0;
            e1.SSN = 123456789;
            //we dont add the EmployeeId because it is an identity column and will be generated automatically by the database.
            context.employees.Add(e1);
            context.SaveChanges();
        }
    }
}
