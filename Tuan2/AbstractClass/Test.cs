﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Test
    {
        static void Main(string[] args)
        {
            Rectangle objRec = new Rectangle();
            objRec.CalculateArea();
            objRec.CalculateCircumference();
            Console.Read();
        }
    }
}
