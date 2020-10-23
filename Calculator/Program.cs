using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            float price;
            int quantity;
            string country;

            Console.WriteLine("Enter the price and then press Enter");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity and then press Enter");
            quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity and then press Enter");
            country = Console.ReadLine();

            Console.WriteLine($"Your price: {price} and quantity {quantity}");

            OrderCalculator.Price = price;
            OrderCalculator.Quantity = quantity;
            OrderCalculator.CountryCode = country;

            var result = OrderCalculator.CalculateOrderTotal();
            
            var result2 = OrderCalculator.CalculateOrderTotalBasedOnCountryTaxRate(result);

            Console.WriteLine($"Total: {result}");
            Console.WriteLine($"Total Tax: {result2}");
            Console.WriteLine();
        }
    }
}
