using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_NMLT_19._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GIAI PT BAC 1

            //GIAI PHUONG TRINH BAC 2
            //TIM NGAY GIO
            //UOC CHUNG NN BOI CHUNG LON NHAT
            PTB2(0, 0, 0);
        }
        //GIAI PT BAC 1 ax+b=0
        public static void PTB1()
        {
            Console.Write("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            int b = int.Parse(Console.ReadLine());
            if(a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("PT VO SO NGHIEM");
                }
                else
                    Console.WriteLine("PT VO N0");
            }
            else
            {
                Console.WriteLine($"pt co nghiem: {-b / (1.0 * a)}");
            }
        }
        public static void PTB2(int a, int b, int c)
        {
            //ax2 + bx + c =0
            double delta = b * b - 4 * a * c;
            if(a == 0)
            {
                if(b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine($"PT vo so nghiem");
                    }
                    else
                        Console.WriteLine("pt vo n0");
                }
                else
                {
                    Console.WriteLine($"pt co nghiem: {-c * 1.0 / b}");
                }
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("PT VO NGHIEM");
                }
                else if(delta == 0)
                {
                    Console.WriteLine($"pt co nghiem kep: {-b / (2 * a)}");
                }
                else
                {
                    Console.WriteLine($"pt co nghiem x1= {(-b + Math.Sqrt(delta)) / (2.0 * a)} " +
                        $"x2= {(-b - Math.Sqrt(delta)) / (2.0 * a)}");
                }
            }
        }



    }
}
