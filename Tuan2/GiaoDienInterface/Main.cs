using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDienInterface
{
    class Main
    {
        static void main(string[] args)
        {
            Base obj = new Base();
            obj.Print();
            Interface1 ib = (Interface1)obj;
            ib.Print();
            Base ojB = (Base)ib;
            ojB.Print();
            Console.Read();
        }
    }
}
