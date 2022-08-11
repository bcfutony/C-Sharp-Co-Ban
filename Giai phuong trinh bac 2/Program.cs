using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giai_phuong_trinh_bac_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a=0 bx+c=0
            //b=0 c!=0 vn
            //b=0 c=0 vo so ng
            //b khac = x=-c/b
            //a khac 0
            //delta <0: vn
            //delta =0 nghiem kep
            //delta >0 2 nghiem
            Console.WriteLine("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c:");
            int c = int.Parse(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            
            if (a== 0)
            {
                if (b == 0)
                {
                    if(c == 0)
                    {
                        Console.WriteLine("pt VO SO NG");
                    }
                    else
                    {
                        Console.WriteLine("pt VO NGHIEM");
                    }
                }
                else {
                    Console.WriteLine($"pt co ng la: x = {-c*1.0 / b}");
                }
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
                else if(delta == 0)
                {
                    //pt ng kep
                    Console.WriteLine($"phuong trinh nghiem kep: {-b*1.0/2*a}");
                }
                else
                {
                    //pt 2 nghiem
                    Console.WriteLine($"phuong trinh 2 nghiem x1: {(-b * 1.0 +delta )/ 2 * a}, " +
                        $"x2 = {(-b * 1.0 - delta) / 2 * a}");
                    
                }
            }
        }
    }
}
