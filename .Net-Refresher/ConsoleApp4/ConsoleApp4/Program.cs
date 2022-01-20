using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            product P = new product();
            string name = P.GetProductName();
            string price = P.GetProductPrice();
            Console.WriteLine(name + " and the price is "+ price);
        }
    }
}
