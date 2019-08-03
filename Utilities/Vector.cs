using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class Vector
    {
        public Vector() { }
        public Vector( int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector Zero()
        {
            return new Vector(0, 0, 0);
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
