using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input price:");
            var price = Console.ReadLine();
            Console.WriteLine("Input quantity:");
            var quantity = Console.ReadLine();
            var calc = new Calculator() { Quantity = int.Parse(quantity), Price = decimal.Parse(price)};
            Console.WriteLine("Total is: " + calc.CalculateQuantityPrice().ToString());
        }
        
    }
}
