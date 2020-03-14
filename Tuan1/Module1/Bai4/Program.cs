using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int nCanh1, nCanh2, nDienTich =0, nChuVi;
            Console.Clear();
            Console.WriteLine("Tinh Chu Vi va Dien Tich Tu Giac");
            Console.Write("Nhap canh 1: ");
            nCanh1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh 2: ");
            nCanh2 = Convert.ToInt32(Console.ReadLine());
            nDienTich = (nCanh1 * nCanh2);
            nChuVi = (nCanh1 + nCanh2) * 2;
            Console.WriteLine("Dien Tich Tu Giac: " + nDienTich +"\nChu Vi Tu Giac: " +nChuVi);
            Console.ReadLine();
        }
    }
}
