using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your age is " + age);

            Console.ReadLine();
        }
    }
}
