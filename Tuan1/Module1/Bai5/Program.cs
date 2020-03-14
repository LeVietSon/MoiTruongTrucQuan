using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Tinh Phuong Trinh Bac 1");
            float a, b;
            float PtBac1 = 0;
            Console.Write("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
            }
            else if (b == 0)
            {
                if (a !=0)
                {

                    Console.WriteLine("Phuong trinh co nghiem: 0");
                }
                else
                {
                    Console.WriteLine("Phuong Trinh Vo So Nghiem");
                }
            }
            else
            {
                PtBac1 = -b / a;
                Console.WriteLine("Phuong trinh co nghiem: " + PtBac1);
            }
            Console.ReadLine();
           
        }
    }
}
