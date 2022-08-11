using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            float a, b, c, delta;
            Console.Write("vui long nhap a: ");
            a =float.Parse(Console.ReadLine());
            Console.Write("vui long nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("vui long nhap c: ");
            c = float.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("pt vo nghiem");
                }
                else
                {
                    Console.WriteLine($"pt co ng la : x = {-c/b}");
                }
            }
            else if (delta < 0)
            {
                //pt vo nghiem
                Console.WriteLine("pt vo ng");
            }
            else if(delta == 0) {
                //pt co nghiem kep
                Console.WriteLine($"pt nghiem kep x1=x2 = {-b/(2*a)}");
                //x1 =x2 =-b/(2*a)
            }
            else
            {
                //pt 2 nghiem
                Console.WriteLine("pt 2 ng");
                //-b+sqrt(delta)/2a
                Console.WriteLine($"pt co 2 nghiem la x1 = {(-b+Math.Sqrt(delta))/(2*a)} va " +
                    $" x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");

            }



        }
    }
}
