using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        var dbContext = new MyDbContext();

        
        List<Employee> employees = dbContext.Employees.ToList();

        
        employees.Sort((a, b) => a.Salary.CompareTo(b.Salary));

        
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}");
        }

        
        dbContext.Dispose();
    }
}
