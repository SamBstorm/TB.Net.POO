using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TB.Net.POO.Ctors_01
{
    public class OldComputer
    {
        private string _cpuModel;
        private int _cpuRate;
        private int _ramCapacity;
        private int _ramRate;
        private int _hddCapacity;
        private bool _haveNetwork;
        private bool _haveModem;
        private bool _haveAudioCard;
        private bool _haveUSB;
        private bool _haveGPU;

        public OldComputer()
        {
            Thread.Sleep(500);
            _cpuModel = "i386";
            _cpuRate = 386;
            Console.WriteLine($"CPU : {_cpuModel} - {_cpuRate}Hz");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            this._ramCapacity = 64;
            _ramRate= 128;
            Console.WriteLine($"RAM : {_ramCapacity} - {_ramRate}Hz");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            _hddCapacity = 20 * 1024;
            Console.WriteLine($"HDD : {_hddCapacity} octets");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            _haveGPU = true;
            if (_haveGPU) Console.WriteLine("GPU ready");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            _haveNetwork = false;
            if (_haveNetwork) Console.WriteLine("Network ready");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            _haveModem = true;
            if (_haveModem) Console.WriteLine("Modem ready");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            _haveAudioCard = false;
            if (_haveAudioCard) Console.WriteLine("Audio ready");
            Console.Beep(2000, 200);
            Thread.Sleep(500);
            _haveUSB = false;
            if (_haveUSB) Console.WriteLine("USB ready");
            Console.Beep(2000, 200);
        }
    }
}
