using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matran
{
    
    
    internal class XuLyPhanSo
    {
       
       
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
