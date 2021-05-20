using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Disposable
{
    public class Kamikaze : IDisposable
    {
        public string Location { get; set; }

        public Kamikaze()
        {
            Console.WriteLine("Prêt!");
        }
        public void Dispose()
        {
            Console.WriteLine($"Je suis arrivé à {Location}, Boum!");
        }

        ~Kamikaze()
        { Console.WriteLine("Je vais tout faire pêter!"); }
    }
}
