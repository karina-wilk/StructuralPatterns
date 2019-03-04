using System;
using System.Collections.Generic;

namespace FacadePattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Shopping basket mock.
            Dictionary<int, int> basket = new Dictionary<int, int> //[product_code, quantity]
            {
                {2414,  5},
                {124,  5},
                {5432,  11}
            };

            var orderFacade = new OrderFacade();
            bool isOrderSent = orderFacade.AcceptOrder(basket, PaymentType.BankTransferWesternUnion, DeliveryType.ExpressPackage_PHL, "Rzeszów, Sportowa 14A");

            Console.WriteLine("Order accepter (in Facade)");

            Console.Read();
        }
    }
}
