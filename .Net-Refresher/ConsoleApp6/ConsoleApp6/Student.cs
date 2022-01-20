using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public class Student
    {
        void Studentname(string n)
        {
            Console.WriteLine("student name is " + n);
        }
        void StudentID(int x)
        {
            Console.WriteLine("student Id is " + x);
        }
        static void Main()
        {
            Student std = new Student();
            string n = Console.ReadLine();
            int x = Convert.ToInt32(Console.ReadLine());
            std.Studentname(n);
            std.StudentID(x);

        }
    }
}
