using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Increment(ref int i)
        {
            i = 1 + 1;
        }
        static void Main()
        {
            int x = 1;
            Increment(ref x);
            Console.WriteLine("The value of x is:" + x); //x=1
            Console.Read();
            
        }
    }
}
