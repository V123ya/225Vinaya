using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface If1
    {
        void method1();
    }
    interface B : If1
    {
        void method2();
    }
    class MyClass : B
    {
        public void method1()
        {
            Console.WriteLine("Hii");
        }
        public void method2()
        {
            Console.WriteLine("Hello");
        }
       
    }
}
        
       