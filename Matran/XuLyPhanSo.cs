using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matran
{
    
    
    internal class XuLyPhanSo
    {
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
        public static PhanSo NhapPhanSo()
        {
            PhanSo kq;
            Console.WriteLine("nhap tu su: ");
            kq.TuSo = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap mau so: ");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }

        public static PhanSo TinhTong2PhanSo(PhanSo a, PhanSo b)
        {
            PhanSo kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
    }
}
