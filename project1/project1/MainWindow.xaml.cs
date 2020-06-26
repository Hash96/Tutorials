using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project1
{
    static void main(string [] args)
    {
        int a,b,c,max,min;
        
        Console.WriteLine("enter the value for a");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the value for b");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the value for c");
        c = int.Parse(Console.ReadLine());

        if(a>b&&a>c)
        {
            max = a;
            Console.WriteLine("maximum value is "+max);
        }
        if(b>a&&b>c)
        {
            max=b;
            Console.WriteLine("maximum value is " + max);
        }
        if(c>a&&c>b)
        {
            max = c;
            Console.WriteLine("maximum value is " + max);
        }

        if (a<b&&a<c)
        {
            min = a;
            Console.WriteLine("maximum value is " + min);
        }
        if (b<a&&b<c)
        {
            min=b;
            Console.WriteLine("maximum value is " + min);
        }
        if (c<a&&c<b)
        {
            min=c;
            Console.WriteLine("maximum value is " + min);
        }

    }
}
