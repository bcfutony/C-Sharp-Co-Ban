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
            Bai_127();
            //double kq = Bai_142();
            //Console.WriteLine(kq);
            

        }
        //Bài 147: Tìm số dương cuối cùng trong mảng số thực.
        //Nếu mảng không có giá trị dương thì trả về  -1
        public static int Bai_147()
        {
            int[] a = NhapMang();
            for (int i =a.Length-1; i >=0; i--) //chay nguoc
            {
                if (a[i] > 0)
                    return a[i];
            }
            return -1;
        }
        //Bài 146: Tìm giá trị âm đầu tiên trong mảng 1 chiều các số thực.
        //Nếu mảng không có giá trị âm thì trả về -1
        public static int Bai_146()
        {
            int[] arr = NhapMang();
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < 0)
                    return arr[i];
            }
            return -1;
        }

        //Bài 145: Tìm số hoàn thiện đầu tiên trong mảng 1 chiều số nguyên.
        //Nếu mảng không có số hoàn thiện thì trả về  -1
        public static int Bai_145()
        {
            int[] a = NhapMang();
            for(int i=0; i<a.Length; i++)
            {
                if (KTSoHoanthien(a[i]))
                {
                    return a[i];
                }
            }
            return -1;
        }
        //Số hoàn hảo (hay còn gọi là số hoàn chỉnh, số hoàn thiện hoặc số hoàn thành) là một số nguyên dương mà
        //tổng các ước nguyên dương thực sự của nó (các số nguyên dương bị nó chia hết ngoại trừ nó) bằng chính nó
        //6=s(6)=1+2+3
        //28=s(28)=1+2+4+7+14
        public static bool KTSoHoanthien(int n)
        {
            int s = 0;
            for(int i=1; i<=n/2; i++)
            {
                if (n % i == 0)
                {
                    s = s + i;//tong cac uoc
                }
            }
            return s == n;
        }

        //Bài 144: Tìm số nguyên tố đầu tiên trong mảng 1 chiều các số nguyên.
        //Nếu mảng không có số nguyên tố thì trả về  – 1
        public static int Bai_144()
        {
            int[] arr = NhapMang();
            for( int i = 0; i < arr.Length; i++)
            {
                if (KTSoNT(arr[i]))
                {
                    return arr[i];
                }
            }
            return -1;

        }
        public static bool KTSoNT(int n)
        {

            //Console.Write($"nhap so: ");
            //int n = int.Parse(Console.ReadLine());
            if (n <= 1)
                return false;
            else
            {
                for(int i = 2; i<=n/2; i++)
                {
                    if(n%i==0)
                        return false;
                }
            }
            return true;
        }
        //Bài 143: Viết hàm tìm số chẵn đầu tiên trong mảng các số nguyên.
        //Nếu mảng không có giá trị chẵn thì trả về  -1
        public static int Bai_143()
        {
            //nhap mang
            Console.Write($"nhap so pt mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n]; //khai bao mang co n phan tu
            for(int i=0; i<a.Length; i++)
            {
                Console.Write($"nhap gia tri a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<a.Length; i++)
            {
                if (a[i]%2 == 0)
                {
                    return a[i];
                }
            }
            return -1;
        }
        //Bài 142: Tìm giá trị nhỏ nhất trong mảng 1 chiều số thực
        public static double Bai_142()
        {
            double[] a = NhapMangThuc();
            double min = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
           
            
            
        }
        
        //127.Viết hàm sắp xếp mảng một chiều các số thực tăng dần.
        //dang lam cho so nguyen
        public static int Bai_127()
        {
            int i, j, tmp;
            Console.Write("\nSap xep mang theo thu tu tang dan\n");
            Console.Write("-----------------------------------\n");

            int[] arr = NhapMang();
            for (i=0; i<arr.Length; i++)
            {
                for (j=i+1; j<arr.Length; j++)
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
            XuatMang(arr);            
            return 127;
        }
        
        //Bài 126: Viết hàm tính tổng các giá trị âm trong mảng 1 chiều các số thực
        public static void Bai_126()
        {
           // Console.Write("nhap so pt: ");
           // int n = int.Parse(Console.ReadLine());
           //// int[] arr = new int[n];
           // double[] arr1 = new double[n];
           // //nhap gia tri mang
           // for(int i=0; i<n; i++)
           // {
           //     Console.Write($"nhap gia tri a[{i}]: ");
           //     arr1[i] = double.Parse(Console.ReadLine());
           // }

            double[] arr1 = NhapMangThuc();
            //xuat mang
            double tongAm = 0;
            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i]<0)
                    tongAm= tongAm + arr1[i];
                //Console.WriteLine($"cac gia tri mang arr[{i}]: {arr1[i]}");
            }
            Console.WriteLine($"tong am {tongAm}");
            XuatMangThuc(arr1);

        }
        //125.Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng        
       


        //124.Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ
        //hơn 2004 hay không?
        public static int Bai_124()
        {
            //chan, nho hon 2004            
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
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
        public static int[] NhapMang()
        {
            Console.Write($"nhap so pt cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write($"nhap gia tria a[{i}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        public static double[] NhapMangThuc()
        {
            Console.Write($"nhap so pt cua mang: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap gia tria a[{i}]: ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            return arr;
        }
        public static void XuatMang(int[] a)
        {
            for (int i=0; i<a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            
        }
        public static void XuatMangThuc(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }

        }

    }
}
