using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Satyam Narayan";
            person.LastName = "Dubey";
            person.PrintFullName();
            Console.ReadLine();
        }
    }
}