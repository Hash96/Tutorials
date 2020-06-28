using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    class Class1
    {
        private string name;
        private int age;

        public Class1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Userinput()
        {
            Class1 user = new Class1(name, age);
            user.Userinput();
            Console.ReadKey();
            
        }
    }
}
