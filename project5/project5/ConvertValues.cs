using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    class ConvertValues
    {
        public void KilometerToMeter()
        {
            int km;
            Console.WriteLine("enter the km value");
            km = int.Parse(Console.ReadLine());

            Console.WriteLine("converted  value is " + (km * 1000)+" meters");
        }
    }
}
