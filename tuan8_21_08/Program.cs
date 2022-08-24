using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan8_21_08
{
    internal class Program
    {
        public static void Hello()
        {
            Console.WriteLine("chao bao");
        }
        public static void Ptbac1(int a, int b)
        { //ax+b =0
            if(a== 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("pt vo so nghie");
                }
                else
                {
                    Console.WriteLine("pt vo nghiem");
                }
            }
            else
            {
                Console.WriteLine($"pt co nghiem {-b*1.0/a}");
            }

        }
        public static int Tinhgiaithua(int n)
        {
            int giaithua = 1;
            for(int i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
            return giaithua;
        }
        public static int TinhTongTich(int n)
        {
            int tong = 0;
            //int tich = 1;
            for (int i =1; i<=n; i++)            
                tong = tong + Tinhgiaithua(i);           
            return tong;
        }
        static void Main(string[] args)
        {           
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine()); 
            Console.WriteLine($" tong tich la: {TinhTongTich(n)}");
        }
    }
}
