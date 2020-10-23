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

       public int Quantity;
       public decimal Price;
    }
}
