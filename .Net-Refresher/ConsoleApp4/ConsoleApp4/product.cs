using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
        public class product : IProduct
        {
            public string GetProductName()
            {
                return " Mobile Phone ";
            }
            public string GetProductPrice()

            {
                return " 20000 ";

            }
        }
    }