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

            Console.WriteLine("Enter the price and then press Enter");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the quantity and then press Enter");
            quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your price: {price} and quantity {quantity}");

            OrderCalculator.Price = price;
            OrderCalculator.Quantity = quantity;

            var result = OrderCalculator.CalculateOrderTotal();

            Console.WriteLine($"Total: {result}");
            Console.WriteLine();
        }
    }
}
