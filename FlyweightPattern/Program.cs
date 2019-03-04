using FlyweightPattern.ContextualObjects;
using FlyweightPattern.FlyweightFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mocking reading texture from file.
            byte[] file1Buffer = new byte[1024];
            new Random().NextBytes(file1Buffer);
            byte[] file2Buffer = new byte[256];
            new Random().NextBytes(file2Buffer);
            #endregion

            List<Square> squares = new List<Square>();
            for (int i=0; i< 100; i++)
            {
                squares.Add(new Square
                {
                    BorderLegth = 1,
                    CoordinateX = 0 + 2* i,
                    CoordinateY = 0,
                    Shape = new ShapeFactory().GetFlyweight("red", Flyweight.TextureType.Plain, file1Buffer, @"C:\SomeFile.jpg")
                });
            }

            Square square2 = new Square
            {
                BorderLegth = 230,
                CoordinateX = 10,
                CoordinateY = 230,
                Shape = new ShapeFactory().GetFlyweight("green", Flyweight.TextureType.Plain, file2Buffer, @"C:\SomeFile.jpg")
            };
            squares.Add(square2);

            Triangle traingle = new Triangle
            {
                Border1Legth = 10,
                Border2Legth = 10,
                Border3Legth = 10,
                CoordinateX = 0,
                CoordinateY = 0, 
                Shape = new ShapeFactory().GetFlyweight("red", Flyweight.TextureType.Plain, file1Buffer, @"C:\SomeFile.jpg")
            };
            traingle.Draw();

            foreach(var sq in squares)
            {
                sq.Draw();
            }

            Console.WriteLine($"We produced {squares.Count} squares");
            Console.WriteLine($"We produced {new ShapeFactory().GetFlyweightsCount()} flyweights!");
            Console.Read();
        }
    }
}
