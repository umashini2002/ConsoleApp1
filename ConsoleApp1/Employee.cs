using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }
        public Employee(string afirstname, string alastname, double abasicsalary)
        {
            FirstName = afirstname;
            LastName = alastname;
            BasicSalary = abasicsalary;


        }
        public void print(string afirstname, string alastname, double abasicsalary)

        {

        Console.WriteLine($"Name = {FirstName}{LastName},Salary ={BasicSalary}");

        }
    }
    
    
}
