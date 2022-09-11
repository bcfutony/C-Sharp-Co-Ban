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
            Bai_124();
            
            //Bai 122
            //Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng

            ////nhap gia tri cua mang            
            //int[] arr = Xulymang.NhapMang();
            //int soNt = 0;                                    
            ////kiem tra so nguyen to va <100
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int giatri = arr[i];                
            //    //soNt = soNt + ((giatri < 100 && Bai_31_KTSoNT(giatri)) ? 1 : 0);
            //    if (giatri < 100 && Bai_31_KTSoNT(giatri))
            //    {
            //        soNt = soNt + 1;
            //        Console.WriteLine($"so nguyen to la: {giatri}, sothu: {soNt}");
            //    }
            //}
            //Console.WriteLine($"Dem so nguyen to <100 la {soNt}  ");
            
            ////xuat mang
            //Xulymang.XuatMang(arr);
          
        }
        //CHUONG MANG 1 CHIEU
        public static bool Bai_31_KTSoNT(int n)
        {
            //Bài 31: Cho số nguyên dương n.
            //Kiểm tra xem n có phải là số nguyên tố hay không        
            //Một số tự nhiên (1, 2, 3, 4, 5, 6,...) được gọi là số nguyên tố nếu nó lớn hơn 1 và không thể được biểu diễn thành tích của hai số tự nhiên nhỏ hơn khác 1    
            //Console.WriteLine("nhap n:");
            //int n = int.Parse(Console.ReadLine());          
            //neu n<3 n 1, 2
            if (n <= 1) // hoac <2
            {
                //Console.WriteLine($"so {n} KHONG la so nguyento");
                return false;
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
            //return 31;
        }
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
        //125.Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng
        public static int Bai_125()
        {
            int[] arr = NhapMang();

            int soNt = 0;            
            
            //kiem tra so nguyen to va <100
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] < 100 && Bai_31_KTSoNT(arr[i]))
                {
                    soNt++;
                    Console.Write($"so Nt la: {arr[i]}. ");
                    Console.WriteLine($"vi tri: {i}");
                }
            }
            Console.Write($"Dem so nguyen to la {soNt}  ");
            return 125;
        }
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
        public static int Bai_123()
        {
            //viet phan nhap mang ben trong
            //Console.Write("nhap so phan tu cua mang: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];//khai bao mang co n phan tu          
            ////nhap gia tri cac phan tu
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Nhap gia tri pt arr[{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //cach khac. Nhap mang bang ham
            int[] arr = NhapMang();

            int min = arr[0];
            int vitrimin = 0;

            for (int i = 1; i<arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                    vitrimin = i;
                }
            }

            //xuat ra vi tri min
            Console.WriteLine($"phan tu nho nhat {min} vi tri arr[{vitrimin}]");            
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
        // nhap n phan tu mang
        public static int[] NhapMang()
        {
            Console.Write("nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"nhap gia tri arr[{i}]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());                
            }
            return arr;
        }
    }
}
