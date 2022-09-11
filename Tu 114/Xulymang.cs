using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu_114
{
    internal class Xulymang
    {
               
        public static int[] NhapMang()
        {
            Console.Write("nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];//tao mang co n phan tu
            //nhap gia tri cac phan tu
            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap gia tri cua arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        public static int TinhTongMang(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s = s + a[i];
            }
            return s;
        }

        public static void XuatMang(int[] a)
        {
            //Console.WriteLine($"ket qua la {s}");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"cac phan tu mang a[{i}]: {a[i]} \n");
            }

        }
        public static int TimMax(int[] arr1)
        {
            int max = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            //  Console.Write($" gia tri lon nhat phan tu: {max} \n");
            return max;
        }
    }
}
