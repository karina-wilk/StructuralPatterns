using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Flyweight
{
    public class ShapeDetails
    {
        private string Color { get; }
        private TextureType Texture { get; }
        private byte[] TextureFileContent { get; }
        private string TextureFilePath { get; }

        public ShapeDetails(string color, TextureType type, byte[] textureFileContent, string textureFilePath)
        {
            Color = color;
            Texture = type;
            TextureFileContent = textureFileContent;
            TextureFilePath = textureFilePath;
        }

        public string GetShapeDetails()
            => $" in color {Color} and with texture: {Texture}";
        
        public void DrawSquare(int x, int y, int borderLength)
            => Console.WriteLine($"Drawing square {GetShapeDetails()}, in\t [{x},{y}] with the following border lenght:\t {borderLength}");

        public void DrawTriangle(int x, int y, int border1Legth, int border2Legth, int border3Legth)
            => Console.WriteLine($"Drawing triangle {GetShapeDetails()}, in\t [{x},{y}]  with the following border lenghts:\t {border1Legth}, {border2Legth} and {border3Legth}");
    }
}
