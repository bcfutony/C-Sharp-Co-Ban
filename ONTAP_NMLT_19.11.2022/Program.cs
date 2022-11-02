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
            // PTB2(0, 0, 0);
            Console.WriteLine("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int uoclemax = Bai_29(n);
            Console.WriteLine(uoclemax);
        }
        //Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25
        public static int Bai_29(int n)
        {
            int uocleMax = 1;
            for(int i=1; i<=n; i++)
            {
                if(n%i==0 && i % 2 != 0)
                {
                   // Console.WriteLine(i);
                    if (uocleMax < i)
                        uocleMax = i;
                }
            }
            return uocleMax; 
        }
        ////Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
        //Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n
        //Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n
        public static int Bai_20(int n)
        {
            int dem = 0;
            int S = 0;
            for (int i=1; i<=n; i++)
            {
                if (n % i == 0)
                {
                    S = S + i;
                    if (S < n)
                    {
                        Console.WriteLine($"uoc so cua n la: {i}");
                    }
                    else
                    {
                        S = S - i;
                    }
                    dem++;
                    
                }
            }
            return S;
        }

        //hay Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!
        public static double Bai_18(int n, int x)
        {
            double S = 1;            
            //s0 = 1
            //s1 = 1 + x2*1/2*1!
            //s2 = 1 + x(2*1)/2*1! + x(2*2)/2*2! = s1 + x2*2/2*2!
            for (int i=1; i<=n; i++)
            {
                S = S + Math.Pow(x, 2*i) / (2 * i);
            }
            return S;
            
        }

        //Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N
        public static double Bai_16(int n, int x)
        {
            int tongn = 0;
            double S = 0;
            for(int i=1; i<=n; i++)
            {
                tongn = tongn + i;
                //s1 = x
                //s2 = x + x2/tong2
                //s3 = x + x2/tong2 + x3/tong3 = s2+x3/tong3
                S = S + Math.Pow(x, i) / tongn;
                Console.WriteLine($" xmu i {Math.Pow(x, i)}");
            }

            return S;
        }        
        public static void Tinhtong16()
        {
            Console.WriteLine($"vui long nhap nhap n: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            int tong = 0;
            for (int i = 1; i<=n; i++)
            {
                tong = tong + i;
                s = s + 1.0 / tong;
            }
            Console.WriteLine(tong); Console.WriteLine(s);
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
        //Bài 15: Tính S(n) = 1 + 1/1 + 2 + 1/ 1 + 2 + 3 + ….. + 1/ 1 + 2 + 3 + …. + N
        public static void Tinhtong15(int n)
        {
            double S = 0;
            int tong = 0;
            for(int i=1; i<=n; i++)
            {
                tong = tong + i;
                S = S + 1.0 /tong;              
            }
            Console.WriteLine($"\ntong lasdafs : {S}");

        }       



    }
}
