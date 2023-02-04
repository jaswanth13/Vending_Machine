using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    public class WalletHandler
    {
        public static void DisplayCoins()
        {
            Console.WriteLine("Insert coins of below denominations");
            Console.WriteLine("1. Nickel");
            Console.WriteLine("2. Dime");
            Console.WriteLine("3. Quarter");
            Console.WriteLine("INSERT COIN.....");
        }

        public static bool AcceptCoin(ref double TotalAmount)
        {
            var coin = int.Parse(Console.ReadLine());
            bool invalidInsert = false;
            switch (coin)
            {
                case (int)Coins.Nickel:
                    TotalAmount += CoinValue.Nickels;
                    break;
                case (int)Coins.Dime:
                    TotalAmount +=CoinValue.Dimes;
                    break;
                case (int)Coins.Quarter:
                    TotalAmount += CoinValue.Quarters;
                    break;
                default:
                    invalidInsert = true;
                    break;
            }

            TotalAmount = Math.Round(TotalAmount, 2, MidpointRounding.AwayFromZero);

            if (invalidInsert)
                Console.WriteLine("INVALID COIN...please insert valid coins");
            else
                Console.WriteLine($"Amount in your wallet: ${TotalAmount}");

            return invalidInsert;
        }

        public static bool Continue()
        {
            bool proceed = false;
            Console.WriteLine("Do you want insert more coins? Y/N");
            var response = Console.ReadLine().ToUpper();

            switch (response)
            {
                case "Y":
                case "YES":
                    proceed = true;
                    break;
                case "N":
                case "NO":
                    break;
                default:
                    break;
            }

            return proceed;
        }
    }
}
