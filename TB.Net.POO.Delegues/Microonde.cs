using System;

namespace TB.Net.POO.Delegues
{
    public delegate void MicroondeProgram();
    public class Microonde
    {
        public MicroondeProgram Program = null;
        private int Power { get; set; }
        private int Time { get; set; }
        private int Rotation { get; set; }
        public Microonde()
        {
        }

        public void Defrost()
        {
            Power = 50;
            Time = 900;
            Rotation = 20;
            Console.WriteLine($"Le micro-onde tourne à {Power}% de puissance, pendant {Time} secondes, et la plaque tourne à {Rotation}° par seconde.");
            Console.Beep(25000,500);
        }

        public void Grill()
        {
            Power = 100;
            Time = 1200;
            Rotation = 10;
            Console.WriteLine($"Le micro-onde tourne à {Power}% de puissance, pendant {Time} secondes, et la plaque tourne à {Rotation}° par seconde.");
            Console.Beep(25000, 500);
        }

        public void Reheat()
        {
            Power = 100;
            Time = 120;
            Rotation = 30;
            Console.WriteLine($"Le micro-onde tourne à {Power}% de puissance, pendant {Time} secondes, et la plaque tourne à {Rotation}° par seconde.");
            Console.Beep(25000, 500);
        }
    }
}