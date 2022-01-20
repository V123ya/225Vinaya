using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   abstract class absclass
    {
        public int AddTwoNumbers(int Num1,int Num2)
        {
            return Num1 + Num2;
        }

        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }
}
