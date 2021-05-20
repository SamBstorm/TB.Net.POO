using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Interfaces
{
    public interface ILogError
    {
        void WriteError(string message, string level, DateTime date);
    }
}
