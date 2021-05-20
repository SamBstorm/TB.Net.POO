using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Interfaces
{
    public interface ILog : ILogError
    {
        void WriteWarning(string message, string level, DateTime date);
        void WriteInformation(string message, string level, DateTime date);
    }
}
