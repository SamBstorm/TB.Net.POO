using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Delegues
{
    public delegate void CDPlayerProgram();
    public class CompactDiscPlayer
    {
        private CDPlayerProgram Program = null;
        public CompactDisc CurrentDisk { get; set; }

        public CDPlayerProgram SelectTrack(int number)
        {
            return delegate () {
                Console.WriteLine($"La musique commence à être lue à {CurrentDisk.TimerTrack[number]}");
            };
        }

        public void AddTrack(CDPlayerProgram program)
        {
            Program += program;
        }

        public void Play()
        {
            Program();
        }
    }
}
