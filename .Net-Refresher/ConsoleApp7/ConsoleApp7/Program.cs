﻿using System;
using System.Collections;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()

        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("vikku");
            al.Add(8);
            al.Add(4.6);

            int FirstElement = (int)al[0];
            string SecondElement = (string)al[1];
            int ThirdElement = (int)al[3];
            double FourthElement = (double)al[4];

            Console.WriteLine(FirstElement);
            Console.WriteLine(SecondElement);
            Console.WriteLine(ThirdElement);
            Console.WriteLine(FourthElement);
        }
            
    }

}
