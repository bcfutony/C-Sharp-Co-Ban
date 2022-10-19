using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructStudy
{
  
    struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }
    struct Diem
    {
        public int X; //khai bao toa do X
        public int Y;

    }
    struct TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;
    }
    internal class Program
    {               
        static void Main(string[] args)
        {
            //Diem A, B;
            //A = NhapDiem();
            //B = NhapDiem();
            //double kq =TinhKhoangCach(A, B);
            //Console.Write(kq);

            //TamGiac tg;
            //tg = NhapTamGiac();
            //if (KTTamGiac(tg))
            //{
            //    double kq = TinhChuVi(tg);
            //    Console.Write(kq);
            //}
            //else
            //{
            //    Console.WriteLine("tam giac ko hop le");
            //}

            //PhanSo a, b;
            //a = NhapPhanSo();
            //b = NhapPhanSo();
            //SoSanhPhanSo(a, b);
            PhanSo a, b;
            a = NhapPhanSo();
            b = NhapPhanSo();
            CongPS(a, b);
        }
        public static PhanSo NhapPhanSo()
        {
            PhanSo kq;
            Console.Write("nhap tu so: ");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.Write("nhap mau su: ");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }
        
        public static void CongPS(PhanSo a, PhanSo b)
        {
            Console.Write($"{a.TuSo*b.MauSo+a.MauSo*b.TuSo}/{a.MauSo*b.MauSo}");
        }



        public static void SoSanhPhanSo(PhanSo a, PhanSo b)
        {
            if (a.TuSo * b.MauSo - a.MauSo * b.TuSo > 0)
            {
                Console.Write($"{a.TuSo}/{a.MauSo}>{b.TuSo}/{b.MauSo}");
            }
            else if (a.TuSo * b.MauSo - a.MauSo * b.TuSo == 0)
            {
                Console.Write($"{a.TuSo} / {a.MauSo} = {b.TuSo} / {b.MauSo}");
            }
            else
            {
                Console.Write($"{a.TuSo} / {a.MauSo} < {b.TuSo} / {b.MauSo}");
            }
        }
        public static TamGiac NhapTamGiac()
        {
            TamGiac kq;
            Console.WriteLine("nhap diem A: ");
            kq.A = NhapDiem();
            Console.WriteLine("nhap diem B: ");
            kq.B = NhapDiem();
            Console.WriteLine("nhap diem C: ");
            kq.C = NhapDiem();
           
            return kq;
        }
        public static double TinhChuVi(TamGiac t)
        {
            double a, b, c;
            a = TinhKhoangCach(t.B, t.C);
            b = TinhKhoangCach(t.A, t.C);
            c = TinhKhoangCach(t.A, t.B);
            return a + b + c;
        }
        //kiem tra tinh hop le cua tam giac
        public static bool KTTamGiac(TamGiac t)
        {
            double a, b, c;
            a = TinhKhoangCach(t.B, t.C);
            b = TinhKhoangCach(t.A, t.C);
            c = TinhKhoangCach(t.A, t.B);
            return a + b > c && b + c > a && a + c > b;
        }
        public static Diem NhapDiem()
        {
            Diem kq;
            Console.Write("nhap toa do X: ");
            kq.X = int.Parse(Console.ReadLine());

            Console.Write("nhap toa do Y: ");
            kq.Y = int.Parse(Console.ReadLine());
            return kq;
        }

        public static double TinhKhoangCach(Diem A, Diem B)
        {           
            return Math.Sqrt((A.X -B.X)* (A.X - B.X) + (A.Y - B.Y)* (A.Y - B.Y));            
        }
    }
}
