using System;
using System.Threading;

namespace TB.Net.POO.Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Kamikaze ka;
            using (Kamikaze k = new Kamikaze())
            {
                k.Location = "Lune";
                ka = k;
            }
            Console.WriteLine( ka.Location );
            ka = null;
            Thread.Sleep(5000);
            Console.WriteLine("Fin");
        }
    }
}
