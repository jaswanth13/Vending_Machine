using System;
using System.Collections.Generic;

namespace Vending_Machine
{
    public class ProductHandler
    {
        private static readonly IReadOnlyList<Product> _products;
        static ProductHandler()
        {
            var dao = new ProductList();
            _products = dao.GetProducts();
        }
        public static void DisplayProducts()
        {
            Console.WriteLine("Select products from below list...");
            foreach (var item in _products)
            {
                Console.WriteLine($"{item.Id}. {item.Name} (${item.Price})");
            }
        }

        public static bool ValidateProductInput(Product product)
        {
            if (product == default)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateProductPrice(Product product, double totalAmount)
        {
            if (product.Price > totalAmount)
            {
                return false;
            }
            return true;
        }
    }
}
