using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // var test = new Calculator() { Quantity = 5, Price = 100, Country = "DE"};
            // test.GetTotal();
            Console.WriteLine("Input price:");
            var price = Console.ReadLine();
            Console.WriteLine("Input quantity:");
            var quantity = Console.ReadLine();
            Console.WriteLine("Input country:");
            var country = Console.ReadLine();
            var calc = new Calculator() { Quantity = int.Parse(quantity), Price = decimal.Parse(price), Country = country};
            Console.WriteLine("Total is: " + calc.GetTotal().ToString());
        }
        
    }
}
