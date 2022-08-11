using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3_23._07._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            int a = 3;
            //int b = 2;
            //Console.WriteLine(a % b);
            
            Console.WriteLine($" gia tri cua a = {a++}");//a=3
            //a=a+1=4
            Console.WriteLine($" gia tri cua a = {++a}"); //a=5
            //Console.WriteLine(++a);

            //int x = 5;
            //int y = 3;
            //Console.WriteLine(x == y);  // returns False because 5 is not equal to 3


            int x = 5;
            Console.WriteLine(!(x > 3 && x < 10)); // returns False because ! (not) is used to reverse the result
            Console.WriteLine(x > 3 || x < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)
            Console.WriteLine(x > 3 && x < 10); // returns True because 5 is greater than 3 AND 5 is less than 10

           
            Console.WriteLine(Math.Max(1, 44));
            Console.WriteLine(Math.Sqrt(121));

            //tim so lon nhat a, b, c
            int b = 7;
            int c = 8;
            int d = 9;
            if((b>c)&&(b>d))
            {
                Console.WriteLine($"  la so lon nhat b= {b}");
            }
            else if ((c > d) && (c > b))
            {
                Console.WriteLine($"so lon nhat la c= {c}");
            }
            else
            {
                Console.WriteLine($"so lon nhat la d= {d}");
            }

            //vd toan tu 3 ngoi
            int time = 20;
            string result2 = (time < 18) ? "ngay tot" : "chao buoi toi";
            //string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result2);

            //vd giai phuong trinh bac 1
            //mx+n=0
            int m, n;
            Console.Write("vui long nhap m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("vui long nhap n: ");
            n = int.Parse(Console.ReadLine());

            if (m == 0)
            {
                if(n == 0)
                {
                    Console.WriteLine($"pt vo so nghiem");
                }
                else
                {
                    Console.WriteLine($"pt vo nghiem");
                }
            }
            else
            {
                double no = -1.0*n / m;
                Console.WriteLine($"phuong trinh co nghiem la: {no}");
            }

        }
    }
}
