using System;

namespace Vending_Machine
{
    public class OrderHandler
    {
        public static void BuyProduct(Product product, ref double totalAmount)
        {
            Console.WriteLine($"Thanks for buying {product.Name}. Please collect you item");
            Console.WriteLine($"Item:{product.Name} Quatity:{1}");
            totalAmount -= product.Price;
            totalAmount = Math.Round(totalAmount, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Amount left in your wallet: ${totalAmount}");
        }

        public static bool BuyMore()
        {
            Console.WriteLine("Do you want to buy more items? Y/N");
            var input = Console.ReadLine().ToUpperInvariant();
            return input == "Y" || input == "YES"; 
        }
    }
}
