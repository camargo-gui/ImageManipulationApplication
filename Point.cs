using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulationApplication
{
    class Point(int x, int y)
    {
        public int X = x;
        public int Y = y;

        public bool IsMajor(Point point2)
        {
            return (point2.X < this.X && point2.Y < Y);
        }

        public bool IsMinor(Point point2)
        {
            return (point2.X > this.X && point2.Y > this.Y);
        }
    }
}
