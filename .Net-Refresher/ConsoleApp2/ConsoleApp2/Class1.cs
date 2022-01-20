using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Employee
    {
        public Employee()
        {

        }
            
        public void GetName()
        {
            Console.WriteLine("Enter your name :");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            String age = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is" + age);
            

        }
    }
}
