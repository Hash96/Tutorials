using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10
{
    class TestArray
    {
        public void MyArray()
        {
            int[] ab = new int[10];
            for (int x = 0; x <10; x++)
            {
                Console.WriteLine("enter value to the array" + (x + 1));
                ab[x] = int.Parse(Console.ReadLine());
                
            }
            for (int x = 0; x <10; x++)
            {
                Console.WriteLine(ab[x]);
                

            }
        }
    }
}

