using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matran
{
    struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }
    struct ToaDo
    {
        public int X;
        public int Y;
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            ToaDo a, b, c;

            a = NhapToaDo();
            b = NhapToaDo();
            c = NhapToaDo();

            //tinh tong
            double s1, s2, s3;
            s1 = TinhKhoangCach2Diem(a, b);
            s2 = TinhKhoangCach2Diem(b, c);
            s3 = TinhKhoangCach2Diem(c, a);

            //xuat
            Console.WriteLine($"{s1+s2+s3}");

            //kieu nguyen
            // int[,] a;
            // a = NhapMaTran();
            //Bai_319(a);
            // XuatMaTran(a);
            //  Console.WriteLine($"{kq}");

            //kieu thuc
            //double[,] at;
            //at = NhapMaTranThucTEST();
            //double kqt = Bai_326(at);
            //XuatMaTranThucTEST(at);
            //Console.WriteLine($"{kqt}");

        }
        public static ToaDo NhapToaDo()
        {
            ToaDo kq;
            Console.WriteLine("nhap toa do X: ");
            kq.X = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap toa do Y: ");
            kq.Y = int.Parse(Console.ReadLine());

            return kq;
        }
        public static double TinhKhoangCach2Diem(ToaDo a, ToaDo b)
        {
            double kq;
            kq = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
            return kq;

        }
        //Bài 326: Tính trung bình cộng các số dương trong ma trận các số thực
        public static double Bai_326_test(double[,] a)
        {
            double tong = 0;
            int dem = 0;
            for(int i=0; i<a.GetLength(0); i++)
            {
                for (int j=0; j<a.GetLength(1); j++)
                {
                    tong += a[i,j];
                    dem++;
                }
            }
            return tong / dem;
        }

        public static double[,] NhapMaTranThucTEST()
        {
            Console.Write("nhap so hang: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot: ");
            int m = int.Parse(Console.ReadLine());
            //khai bao ma tran moi
            double[,] a = new double[n, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]: ");
                    a[i, j] = double.Parse(Console.ReadLine());
                }
                //Console.WriteLine();
            }
            return a;
        }
        public static void XuatMaTranThucTEST(double[,] a)
        {
            for(int i =0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
        }





        //327 tong bien
        public static int Bai_327(int[,] a)
        {
            int s = 0; //so luong so nguyen to
            //tong bien dong
            for (int j = 0; j < a.GetLength(1); j++)
            {
                s = s + a[0, j];
                if (a.GetLength(0) >= 2) //neu dong lon hon 2
                {
                    s = s + a[a.GetLength(0) - 1, j];
                }
                
            }
            //tong bien cot
            for (int i = 1; i < a.GetLength(0)-1; i++) //bo cot o hang cuoi cung nen -1
            {
                s = s + a[i, 0];
                if (a.GetLength(1) >= 2) //neu cot lon hon 2
                {
                    s = s + a[i, a.GetLength(1) - 1];
                }
                
            }
            return s;
        }
        //Bài 326: Tính trung bình cộng các số dương trong ma trận các số thực
        public static double Bai_326(double[,] a)
        {
            int dem = 0;
            double tong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    tong += a[i, j];
                    dem++;
                }
            }
            return tong / dem;
        }

        //Bài 325: Tính tích các số chẵn trên 1 cột trong ma trận các số nguyên
        public static int Bai_325(int[,] a)
        {
            Console.Write("nhap so COT can tinh: ");
            int n = int.Parse(Console.ReadLine());
            int tichChanCot = 1;
            //kiem tra cot duong va <a.getlength(1)
            if (n >= 0 && n < a.GetLength(1))
            {
                for (int i =0; i< a.GetLength(0); i++)
                {
                    if (a[i,n]%2 == 0)
                    {
                        tichChanCot *= a[i,n];
                    }
                }
            }
            else
            {
                Console.WriteLine("ban nhap so COT ko hop le");
                return -1;
            }
            return tichChanCot;
        }

        //Bài 324: Tính tổng các giá trị dương trên 1 dòng trong ma trận các số thực
        public static double Bai_324(double[,] a)
        {
            Console.Write("nhap so DONG can tinh:");
            int n = int.Parse(Console.ReadLine());
            double tongDuongDong = 0;
            //kiem tra so dong duong va <a.GetLength(0)
            if(n>=0 && n < a.GetLength(0))
            {
                for (int j = 0; j<a.GetLength(1); j++)
                {
                    if (a[n,j] >= 0)
                    {
                        tongDuongDong+=a[n,j];
                    }
                }
            }
            else
            {
                Console.WriteLine("so DONG ko hop le");
                return -1;
            }
            return tongDuongDong;

        }


        //Bài 323: Tính tích các giá trị dương trên 1 cột trong ma trận các số thực
        public static int Bai_323(int[,] a)
        {
            
            Console.Write($"nhap so COT can tinh:");
            int n = int.Parse(Console.ReadLine());
            int tongCOT = 0;
            int tichCOT = 1;
            //kiem tra so cot duong va be hon a.GetLength(1)
            if (n>=0 && n < a.GetLength(1))
            {            
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    tongCOT += a[i, n];
                    if (a[i,n]>0)
                        tichCOT = tichCOT * a[i,n]; //*=
                }
            }
            else
            {
                Console.WriteLine("so cot ko hop le");
                return -1;
            }
           
            return tichCOT;

        }
        //Bài 322: Tính tổng các giá trị trên 1 dòng trong ma trận các số thực// nguyen
        public static int Bai_322(int[,] a)
        {
            Console.Write($" nhap so dong can tin:");
            int n = int.Parse(Console.ReadLine());
            int tongdong = 0;
            
            for (int j=0; j<a.GetLength(1); j++)
            {
                tongdong += a[n, j];
            }
            return tongdong;
            
        }

        //Bài 321: Tính tích các giá trị lẻ trong ma trận các số nguyên
        public static int Bai_321(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 !=0) //gia tri le
                    {
                        s += a[i, j];
                    }
                }
            }
            return s;
        }
        //Bài 320: Tính tổng các số dương trong ma trận các số thực
        public static double Bai_320(double[,] a)
        {
            double s = 0;
            for (int i=0; i<a.GetLength(0); i++)
            {
                for (int j=0; j<a.GetLength(1); j++)
                {
                    if (a[i,j] > 0)
                    {
                        s += a[i,j];
                    }
                }
            }
            return s;
        }

        //Bài 319: Viết hàm sắp xếp ma trận các số thực tăng dần từ trên xuống dưới và từ trái sang phải
        public static void Bai_319(int[,] a)
        {
            //dua mang 2 chieu vao mang 1 chieu
            int n = a.GetLength(0) * a.GetLength(1);
            int[] b = new int[n];
            int k = 0;
            for (int i=0; i < a.GetLength(0); i++)
            {
                for (int j=0; j < a.GetLength(1); j++)
                {
                    b[k] = a[i,j];
                    k++;
                }
            }
            //sap xep tang mang 1 chieu
            SXMangtang(b);

            //dua vao mang 1 chieu dua vao mang 2 chieu
            k = 0;
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = b[k];
                    k++;
                }
            }
        }
        //sap xep tang dan mang 1 chieu
        public static int[] SXMangtang(int[] a)
        {
            int tmp;

            for(int i=0; i<a.Length; i++)
            {
                for (int j=i+1; j<a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        tmp = a[j];                        
                        a[j] = a[i];
                        a[i] = tmp;
                       
                    }
                }
            }
            for(int i=0; i<a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            return a;
        }

        //318 tong gia am ma tran so thuc
        public static double Bai_318(double[,] a)
        {
            double s = 0; 
            for (int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    if (a[i, j] < 0)
                    {
                        s += a[i, j];
                    }
                }
            }
            return s;
        }
        //317 dem so nguyen to ma tran so nguyen
        public static int Bai_317(int[,] a)
        {
            
            int s = 0; //so luong so nguyen to
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (KTSoNT(a[i, j]))
                    {
                        s = s + 1; 
                    }
                }
            }
            return s;
        }
        //Bài 316: Viết hàm kiểm tra trong ma trận số nguyên
        //có tồn tại giá trị chẵn nhỏ hơn 2015?
        public static bool Bai_316(int[,] a)
        {
            //bool channhohon2015 = false;
            for (int i =0; i< a.GetLength(0); i++)
            {
                for (int j=0; j< a.GetLength(1); j++)
                {
                    if (a[i,j]%2==0 && a[i, j] < 2015)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //315 tim max ma tran thuc
        public static int Bai_315_TimMax(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }
        public static int[,] NhapMaTran()  //nhap gia tra, tra ve mang
        {
            int[,] a;
            Console.Write("nhap so dong:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot:");
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"nhap A({i},{j}): ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        public static double[,] NhapMaTranTHUC()
        {
            Console.Write("nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot: ");
            int m = int.Parse(Console.ReadLine());
            double[,] a = new double[n, m]; //khai bao mang 2 chieu thuc

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"nhap A({i},{j}): ");
                    a[i,j] = double.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        public static int TinhTong(int[,] a)
        {
            //tinh tong
            int s = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s = s + a[i, j];
                }
            }
            return s;
        }
        public static void XuatMaTran(int[,] a) //nhap vao mang, tra ve void
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                //het hang xuong dong
                Console.WriteLine();
            }
            
        }
        public static void XuatMaTranTHUC(Double[,] a)
        {
            for (int i=0; i< a.GetLength(0); i++)
            {
                for (int j=0; j< a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                //het hang xuong dong
                Console.WriteLine();
            }
        }
        public static bool KTSoNT(int n)
        {            
            if (n <= 1)
                return false;
            else
            {
                //luu y i tu 2 -------********----------
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
    }
    
}
