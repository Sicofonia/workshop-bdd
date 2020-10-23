using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Calculator
{
    public static class OrderCalculator
    {
        public static int Quantity { get; set; }
        public static float Price { get; set; }

        

        public static bool ProjectSetup() => true;

        public static float CalculateOrderTotal()
        {
            return Quantity * Price;
        }


    }
}
