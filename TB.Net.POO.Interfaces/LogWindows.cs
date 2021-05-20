using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Interfaces
{
    public class LogWindows : ILog
    {
        public void WriteError(string message, string level, DateTime date)
        {
            Console.WriteLine($"{string.Format("HH:MM:SS",date)} Error {level}: {message}");
        }

        public void WriteInformation(string message, string level, DateTime date)
        {
            Console.WriteLine($"{string.Format("HH:MM:SS", date)} Information {level}: {message}");
        }

        public void WriteWarning(string message, string level, DateTime date)
        {
            Console.WriteLine($"{string.Format("HH:MM:SS", date)} Warning {level}: {message}");
        }
    }
}
