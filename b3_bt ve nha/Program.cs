using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3_bt_ve_nha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("vui long nhap a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("vui long nhap b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("vui long nhap c");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("vui long nhap d");
            d = int.Parse(Console.ReadLine());

            if ((a<b) && (a < c) && (a<d))
            {
                Console.WriteLine($"a = {a} la so nho nhat");
            }
            else if((b<a) && (b<c) && (b<d))
            {
                Console.WriteLine($"b = {b} la so nho nhat");
            }
            else if ((c < a) && (c < b) && (c < d))
            {
                Console.WriteLine($"c = {c} la so nho nhat");
            }
            else //if ((d < a) && (d < c) && (d < b))
            {
                Console.WriteLine($"d = {d} la so nho nhat");
            }

            // Console.WriteLine($"a la {a} ; b la {b}");

        }
    }
}
