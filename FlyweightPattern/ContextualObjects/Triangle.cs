using FlyweightPattern.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.ContextualObjects
{
    public class Triangle
    {
        public ShapeDetails Shape;
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int Border1Legth { get; set; }
        public int Border2Legth { get; set; }
        public int Border3Legth { get; set; }

        public void Draw()
            => Shape.DrawTriangle(CoordinateX, CoordinateY, Border1Legth, Border2Legth, Border3Legth);
    }
}
