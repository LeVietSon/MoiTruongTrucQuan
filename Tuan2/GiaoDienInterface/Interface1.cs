using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDienInterface
{
    interface Interface1
    {
        void Print();
    }
    class Base:Interface1
    {
        public void Print ()
        {
            Console.WriteLine("Print method called");
        }
    }
}
