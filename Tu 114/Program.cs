using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu_114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai_122();
            PhantuMang();
        }
        //CHUONG MANG 1 CHIEU
        //122.Tìm giá trị lớn nhất trong mảng một chiều các số thực
        public static int Bai_122()
        {

            return 122;
        }
        //NHAP n phan tu trong mang
        public static int PhantuMang()
        {
            int[] arr = new int[10]; //nhap 10 phan tu
            int i;
            Console.Write("nhap 10 phan tu mang \n");
            for (i = 0; i < 5; i++)
            {
                //Console.Write("phan tu {0}: ", i);
                Console.Write($"phan tu {i}:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\n In cac phan tu mang");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n");
            
            //in dao nguoc
            Console.Write("phan tu dao nguoc: ");
            for(i=4; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            return 1;
        }
    }
}
