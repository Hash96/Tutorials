using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-addition");
            Console.WriteLine("2-subtraction");
            Console.WriteLine("3-multiplication");
            Console.WriteLine("4-division");

            Console.WriteLine("enter your choice ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("enter no1");
            int no1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter no2");
            int no2 = int.Parse(Console.ReadLine());

            CalculateValues cv = new CalculateValues();
            if (choice == 1)
            {
                int ans = cv.addition(no1, no2);
                Console.WriteLine("your answer is " + ans);
            }

            else if (choice == 2)
            {
                int ans = cv.subtraction(no1, no2);
                Console.WriteLine("your answer is " + ans);
            }

            else if (choice == 3)
            {
                int ans = cv.multiplication(no1, no2);
                Console.WriteLine("your answer is " + ans);
            }

            else if (choice == 4)
            {
                int ans = cv.division(no1,no2);
                Console.WriteLine("your answer is " + ans);
            }
        }
    }
}
