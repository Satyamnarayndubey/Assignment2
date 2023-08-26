using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }

    sealed class Car : Vehicle
    {
    }

    class AnotherClass : Car
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();
            Console.ReadLine();
        }
    }

}