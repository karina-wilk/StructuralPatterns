using FacadePattern.PaymentExternalSystems;
using FacadePattern.ProductsProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacadePattern.Program;

namespace FacadePattern
{
    public class OrderFacade
    {
        public bool AcceptOrder(Dictionary<int, int> basket, PaymentType paymentType, DeliveryType deliveryType, string deliveryAddress)
        {
            var warehouse = new LocalWarehouse();
            var paymentSystem = new EKardSystem();
            var enveloDelivery = new DeliveryExternalSystems.EnveloDelivery();
            var PHLDelivery = new DeliveryExternalSystems.PHLDelivery();

            decimal summaryPrice = 0;
            foreach (var basketPosition in basket)
            {
                //Orders with code numer > 10'000 are stored in another warehouse.
                if(basketPosition.Key < 10_000)
                {
                    if(warehouse.IsProductAvailable(basketPosition.Key))
                    {
                        summaryPrice = basketPosition.Value * warehouse.GetPrice(basketPosition.Key);
                        if(!warehouse.Reserve(basketPosition.Key))
                        {
                            throw new Exception("Error while reserving product!");
                        }
                    }
                    else
                    {
                        throw new Exception("Product unavailable!");
                    }
                }
            }

            switch (paymentType)
            {
                case PaymentType.BankTransferPolishBank:
                    if(!paymentSystem.PayInPolishBank(summaryPrice))
                    {
                        throw new Exception("Error in payment system!");
                    }
                    break;
                case PaymentType.BankTransferWesternUnion:
                    if (!paymentSystem.PayInWesternUnion(summaryPrice))
                    {
                        throw new Exception("Error in payment system!");
                    }
                    break;
                case PaymentType.BankTransferZantander:
                    if (!paymentSystem.PayInZantanderBank(summaryPrice))
                    {
                        throw new Exception("Error in payment system!");
                    }
                    break;
                case PaymentType.CreditCard:
                    if (!paymentSystem.CardPayment(summaryPrice))
                    {
                        throw new Exception("Error in payment system!");
                    }
                    break;
            }

            int orderWeight = basket.Count * 10;
            switch (deliveryType)
            {
                case DeliveryType.BigPackage_PHL:
                    PHLDelivery.OrderBigPackage(deliveryAddress, orderWeight);
                    break;
                case DeliveryType.CheapMail_PolishPost:
                    enveloDelivery.SendCheapMail(deliveryAddress);
                    break;
                case DeliveryType.ExpressPackage_PHL:
                    PHLDelivery.OrderExpressPackage(deliveryAddress);
                    break;
            }

            return true;
        }
    }
}
