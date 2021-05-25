using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Delegues
{
    public class CompactDisc
    {
        public int[] TimerTrack;

        public CompactDisc(params int[] tracksStartAt)
        {
            TimerTrack = tracksStartAt;
        }
    }
}
