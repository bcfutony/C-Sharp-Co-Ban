using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_1_den_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 62: Cho 2 số nguyên dương a và b. Hãy tìm ước chung lớn nhất của 2 số này.
            //Bài 63: Cho 2 số nguyên dương a và b. Hãy tìm bội chung nhỏ nhất của 2 số này
            Console.WriteLine("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = int.Parse(Console.ReadLine());
            int ucln = UCLN(a, b);
            
            Console.WriteLine($" uoc so chung LN cua {a} va {b} la: {ucln}");
            Console.WriteLine($" uoc so chung LN cua {a} va {b} la: {BCNN(a,b)}");
            Console.WriteLine($"hello world");


        } //dong ham Main
        public static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        public static int BCNN(int a, int b)
        {
            int ketqua = UCLN(a, b);
            int bcnn = a * b / ketqua;
            return bcnn;
        }
    }
}
