using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array must contain at least one element.", nameof(numbers));
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = (double)sum / numbers.Length;
            return average;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            double average = MathHelper.CalculateAverage(numbers);
            Console.WriteLine($"The average is: {average}");
            Console.ReadLine();
        }
    }
}