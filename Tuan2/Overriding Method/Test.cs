using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Method
{
    class Test
    {
        static void main (string [] args)
        {
            Animal a1 = new Animal();
            a1.Talk();
            Dog d1 = new Dog();
            d1.Talk();
            Console.Read();
        }
    }
}
