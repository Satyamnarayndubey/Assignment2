using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] - {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("Starting the application...");
            Logger.LogMessage("Application finished.");
            Console.ReadLine();
        }
    }
}
