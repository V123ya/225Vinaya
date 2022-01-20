﻿using System;

namespace ConsoleApp5
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal Song");
        }

    }
      class Dog : Animal
        {

            public Dog()
            {
                Console.WriteLine("Dog constructor");
            }
            public override void Sing()
            {
                Console.WriteLine("Dog song");
            }
        }

}