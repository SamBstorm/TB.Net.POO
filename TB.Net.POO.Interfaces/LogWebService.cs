using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Interfaces
{
    public class LogWebService : ILog
    {
        public void WriteError(string message, string level, DateTime date)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void WriteInformation(string message, string level, DateTime date)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void WriteWarning(string message, string level, DateTime date)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void WriteUrl(string URL)
        {
            Console.WriteLine($"Last request from : {URL}");
        }
    }
}
