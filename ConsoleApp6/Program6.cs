using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public decimal CalculateSalaryWithBonus(decimal bonusAmount)
        {
            return BaseSalary + bonusAmount;
        }
        public decimal CalculateSalaryWithOvertime(decimal overtimeHours, decimal overtimeRate)
        {
            decimal overtimePay = overtimeHours * overtimeRate;
            return BaseSalary + overtimePay;
        }
        public decimal CalculateSalaryWithIncrease(decimal percentageIncrease)
        {
            decimal increaseAmount = BaseSalary * (percentageIncrease / 100);
            return BaseSalary + increaseAmount;
        }
    }
    class EmployeeSalary
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeId = 1;
            employee.FirstName = "Satyam Narayan";
            employee.LastName = "Dubey";
            employee.BaseSalary = 50000;

            decimal totalSalary = employee.CalculateSalary();
            decimal bonusSalary = employee.CalculateSalaryWithBonus(2000);
            decimal overtimeSalary = employee.CalculateSalaryWithOvertime(10, 150);
            decimal increasedSalary = employee.CalculateSalaryWithIncrease(5);

            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Salary with Bonus: {bonusSalary}");
            Console.WriteLine($"Salary with Overtime: {overtimeSalary}");
            Console.WriteLine($"Salary with Increase: {increasedSalary}");
            Console.ReadLine();
        }
    }
}