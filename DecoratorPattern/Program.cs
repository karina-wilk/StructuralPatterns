using DecoratorPattern.Beverages;
using DecoratorPattern.Beverages.Decorators;
using System;


namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage coffee = new Coffee
            {
                Temperatore = 99,
                Volume = 120
            };
            var component = new CoffeeManager();
            Console.WriteLine("Component with no decorators: ");
            Console.WriteLine(component.Prepare(coffee));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Component with 2 decorators: ");
            var coffeDeluxDecorators = new MilkDecorator(new SyrupDecorator(component));
            Console.WriteLine(coffeDeluxDecorators.Prepare(coffee));
            Console.Read();
        }
    }
}
