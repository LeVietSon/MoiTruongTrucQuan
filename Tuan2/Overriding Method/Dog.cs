using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Method
{
    class Dog:Animal
    {
        public Dog ()
        {
            Console.WriteLine("Dog Constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Dog Talk");

        }
    }
}
