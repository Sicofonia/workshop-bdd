using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public decimal CalculateQuantityPrice()
        {
            return Price * Quantity;
        }

        public decimal GetCountryTax()
        {
            var dict = new Dictionary<string, decimal>();
            dict.Add("DE", decimal.Parse("6.25"));
            dict.Add("FR", decimal.Parse("8.00"));
            dict.Add("PT", decimal.Parse("6.85"));
            return dict[Country];
        }

        public decimal GetTotal() {
            var subtotal = Price * Quantity;
            var total = (subtotal * GetCountryTax() / 100) + subtotal;
            return total;
        }

        public string Country;
        public int Quantity;
        public decimal Price;
    }
}
