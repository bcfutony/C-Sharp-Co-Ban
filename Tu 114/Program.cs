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
            //Bai_127();
            Bai_125();
            //PhantuMang();
        }
        //CHUONG MANG 1 CHIEU
        //127.Viết hàm sắp xếp mảng một chiều các số thực tăng dần.

        
        public static int Bai_127()
        {
            int i, j, tmp;
            Console.Write("\nSap xep mang theo thu tu tang dan\n");
            Console.Write("-------------------------------------");

            int[] arr = new int[10];
            Console.Write("\nnhap n:");
            int n = int.Parse(Console.ReadLine());

            //nhap gia tri mang
            for (i = 0; i<n; i++)
            {
                Console.Write($"gia tri {i}:");
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (i=0; i<n; i++)
            {
                for (j=i+1; j<n; j++)
                {
                    if (arr[j] < arr[i]) //muon i nho nhat
                    {
                        //doi gia tri
                        tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
            for(i=0; i<n; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            return 127;
        }
        //124.Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ
        //hơn 2004 hay không?

        //125.Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng
        public static int Bai_125()
        {
            int[] arr = new int[100];
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine());
            int soNt = 0;
            bool isSoNt = false;
            //nhap gia tri cua mang
            for (int i = 0;i<n; i++)
            {
                Console.Write($"nhap gia tri {i}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //kiem tra so nguyen to va <100
            for(int i=0; i<n; i++)
            {
                int giatri = arr[i];
                for(int j =2; j<giatri; j++)
                {
                    if (giatri % j == 0) // ko so nguyen to
                    {
                        isSoNt = false;
                        break;
                    }
                    else
                        isSoNt = true;
                }
                if (isSoNt)
                    soNt = soNt + 1;
            }
            Console.Write($"so nguyen to la {soNt}  ");
            return 125;
        }
        public static int Bai_124()
        {
            //chan, nho hon 2004
            int[] arr = new int[100];
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine());
            //nhap gia tri vao mang
            for (int i=0; i<n; i++)
            {
                Console.Write($"nhap phan tu thu {i}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //in ra va so sanh
            bool isTontai=false;
            for (int i=0; i < n; i++)
            {
                if (arr[i] < 2004 && arr[i] % 2 == 0)
                {
                    Console.Write("có ton tai so nguyen chan va be hon 2004");
                    isTontai = true;
                    break;
                }
                
            }
            if (!isTontai)
                Console.WriteLine("ko ton tai nhe");
            return 124;

        }
        //123.Viết hàm tìm một vị trí mà giá trị tại vị trí đó là một giá trị nhỏ nhất 
        //trong mảng một chiều các số nguyên.
        public static int Bai_123()
        {
            int[] arr = new int[10];
            Console.Write("nhap so phan tu mang:");
            int n = int.Parse(Console.ReadLine());
            int min;
            int vitrimin;

            for(int i = 0; i < n; i++)
            {
                //nhap cac gia tri vao mang
                Console.Write($"nhap gia tri {i}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            min = arr[0];
            vitrimin = 0;
            for(int i = 0; i < n; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    vitrimin = i;
                }
            }
            Console.WriteLine($"vi tri min: {vitrimin}. Gia tri: {min}");
            return 123;
        }
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
                if(arr1[i] > max) { 
                    max = arr1[i]; 
                //    vitri = i;
                }

                
            }
            Console.Write($" gia tri lon nhat phan tu: {max}");
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
