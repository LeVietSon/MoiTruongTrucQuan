using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Shape
    {
        protected float m_Height = 5;
        protected float m_Width = 10;
        public abstract void CalculateArea();
        public abstract void CalculateCircumference();
        public void PrintHeight()
        {
            Console.WriteLine("Height ={0}", m_Height);
        }
        public void PrintWidth()
        {
            Console.WriteLine("Witdh ={0}", m_Width);
        }
    }
}
