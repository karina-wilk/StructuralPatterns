using FlyweightPattern.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.FlyweightFactory
{
    public class ShapeFactory
    {
        private static Dictionary<string, ShapeDetails> flyweights = new Dictionary<string, ShapeDetails>();

        public ShapeDetails GetFlyweight(string color, TextureType texture, byte[] textureFile, string textureFilename)
        {
            string key = String.Join("#", color.ToLower(), texture.ToString("G"), textureFile.Length, textureFilename.ToLower());

            if (flyweights.ContainsKey(key))
            {
                Console.WriteLine("Flyweight exists! Returns existing one!");
            }
            else
            {
                var shapeDetails = new ShapeDetails(color, texture, textureFile, textureFilename);
                flyweights.Add(key, shapeDetails);

                Console.WriteLine("Creating a new Flyweight!");
            }
            return flyweights[key];
        }

        public int GetFlyweightsCount()
            => flyweights.Count();
    }
}
