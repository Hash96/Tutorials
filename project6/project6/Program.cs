using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1,no2,no3,max,min;
            Console.WriteLine("enter value to the no1");
            no1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter value to the no2");
            no2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter value to the no3");
            no3 = int.Parse(Console.ReadLine());

            if (no1 > no2 && no1 > no3)
            {
                max = no1;
                Console.WriteLine("maximum number is " + no1);
                Console.ReadLine();
            }
            if (no2 > no1 && no2 > no3)
            {
                max = no2;
                Console.WriteLine("maximum number is " + no2);
                Console.ReadLine();
            }
            if (no3> no1 && no3 > no2)
            {
                max = no3;
                Console.WriteLine("maximum number is " + no3);
                Console.ReadLine();
            }
            if (no1 < no2 && no1 < no3)
            {
                min = no1;
                Console.WriteLine("minimum number is " + no1);
                Console.ReadLine();
            }
            if (no2 < no1 && no2 < no3)
            {
                min = no2;
                Console.WriteLine("minimum number is " + no2);
                Console.ReadLine();
            }
            if (no3< no1 && no3 < no2)
            {
                min = no3;
                Console.WriteLine("minimum number is " + no3);
                Console.ReadLine();
            }
        }
    }
}
