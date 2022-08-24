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
            //PhantuMang();
        }
        //CHUONG MANG 1 CHIEU
        //122.Tìm giá trị lớn nhất trong mảng một chiều các số thực
        public static int Bai_122()
        {
            int[] arr1 = new int[10]; //khoi tao mang 10 phan tu
            Console.Write("nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap gia tri phan tu {i}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            //in ra 
            int max=0;
            for(int i=0; i < n; i++)
            {
                max = arr1[0];
                if(arr1[i] > max) { max = arr1[i]; }

                
            }
            Console.Write($"{max}");
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
