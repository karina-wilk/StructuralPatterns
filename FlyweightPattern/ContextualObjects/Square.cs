using FlyweightPattern.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.ContextualObjects
{
    public class Square
    {
        public ShapeDetails Shape;
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int BorderLegth { get; set; }

        public void Draw()
            => Shape.DrawSquare(CoordinateX, CoordinateY, BorderLegth);
    }
}
