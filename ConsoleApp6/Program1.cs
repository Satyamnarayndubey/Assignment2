using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: {Name}");
            Console.WriteLine("Age: {Age}");
            Console.WriteLine("Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Satyam Narayan Dubey";
            employee.Age = 23;
            employee.Salary = 50000.00;

            Console.WriteLine("Employee Details:");
            employee.DisplayDetails();
            Console.ReadLine();
        }
    }
}
