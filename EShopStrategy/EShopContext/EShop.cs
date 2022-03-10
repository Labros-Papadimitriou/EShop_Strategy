using EShopStrategy.Models;
using EShopStrategy.PaymentMethodStrategy;
using EShopStrategy.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopStrategy.EShopContext
{
    public class EShop
    {
        //Fields
        private IEnumerable<IVariationStrategy> variations;
        private IPaymentMethodStrategy paymentMethod;

        public void SetPaymentMethod (IPaymentMethodStrategy method)
        {
            paymentMethod = method;
        }


        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {
            variations = variationStrategies;
        }

        public void CalculateCost(TShirt shirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(shirt);
            }
            Console.WriteLine($"T-Shirt final price is {shirt.Price} euros");
        }


        public void PayTShirt(decimal price)
        {
            if (paymentMethod.Pay(price))
            {
                Console.WriteLine("Transaction was successfull");
            }
            else
            {
                Console.WriteLine("Transaction aborted");
            }
        }

        public void Discount(TShirt shirt, decimal? percentage)
        {
            paymentMethod.Discount(shirt, percentage);
        }





    }
}
