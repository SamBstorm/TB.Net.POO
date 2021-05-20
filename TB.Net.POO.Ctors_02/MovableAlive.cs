using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.Ctors_02
{
    public class MovableAlive : Alive
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MovableAlive(int position_x, int position_y) : this ("Random",position_x,position_y, 20)
        {
        }

        public MovableAlive(string name, int position_x, int position_y, ushort health_point = 50) : base(name, health_point)
        {
            this.X = position_x;
            this.Y = position_y;
        }

        public void move(int x, int y) {
            X += x;
            Y += y;
        }
    }
}
