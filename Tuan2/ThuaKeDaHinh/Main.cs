using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuaKeDaHinh
{
    class Main
    {
        static void main (string [] args)
        {
            MicrosoftSoftware objMS = new MicrosoftSoftware();
            IBMSoftware objBM1 = new IBMSoftware(50);
            IBMSoftware objBM2 = new IBMSoftware("test", 75);
            Console.Read();
        }
    }
}
