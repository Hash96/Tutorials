using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your age");          
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("hello " + name + " welcome and you are" + age +" old");
            Console.ReadKey();
        }
    }
}
