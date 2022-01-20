using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b) && (a > c)
                    {
                Console.WriteLine("The greater number is" + a);
                     }
            else if ( b > a)&&(b > c) 
                    {
                Console.WriteLine("The greater number is" + b);
                     }
             else
            { 
                Console.WriteLine("the greater number is" + c);
            }
           

        }
    }
}