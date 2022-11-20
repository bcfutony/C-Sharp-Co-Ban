using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_NMLT_19._11._2022
{
    struct Phanso
    {
        public int tuso;
        public int mauso;
    }
    struct Hocsinh
    {
        public int MaHs;
        public string tenSV;
        public int diemToan;
        public int diemVan;

    }
    struct Lophoc
    {
        public string tenLop;
        public Hocsinh[] dsHocsinh;
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            //GIAI PT BAC 1.   //GIAI PHUONG TRINH BAC 2
            //TIM NGAY GIO
            //UOC CHUNG NN BOI CHUNG LON NHAT
            // so nguyen to, doi xuong, chinh phuong

            //int[,] a = NhapMatran();
            //XuatMatran(a);
            //int kq = Bai_327(a);
            //Console.Write(kq);
            // XuatNgaytruocdo(1, 3, 2020);
            int[] a = Nhapmang();
            int sntmax = Sntmax(a);
            Console.Write(sntmax);

        }
        //tim so nto lon nhat trong mang 1 chieu
        public  static int Sntmax(int[] a)
        {
            //tim so ngto dau tien
            //kiem tra co phai so nt
            //tim so max
            int soNtmax =TimSntDautien(a);
            //for(int i=0; i<a.Length; i++)
            //{
            //    if (KT_Snt(a[i]))  //neu la so nguyen to
            //    {
            //        if(soNtmax < a[i])
            //        {
            //            soNtmax = a[i];
            //        }
            //    }
            //}
            foreach(int i in a)
            {
                if(KT_Snt(i) && soNtmax <i)
                    soNtmax = i;                  
            }
            return soNtmax;
        }
        public static int TimSntDautien(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                if (KT_Snt(a[i]))
                {
                    return a[i];
                }
            }
            return -1; //ko co so nguyen to nao
        }
        public static bool KT_Snt(int a)
        {
            if (a <= 1)
                return false;
            if (a >= 2)
            {
                for(int i=2; i<=a/2; i++)
                {
                    if (a % i == 0)
                        return false;
                }
            }
            return true;
        }
             
        public static void SSPS(Phanso a, Phanso b)
        {
            Phanso kq;
            kq.tuso = a.tuso*b.mauso -a.mauso*b.tuso;
            kq.mauso = a.mauso * b.mauso;
            double hieuso = kq.tuso*1.0 / kq.mauso;
            if (hieuso > 0)
            {
                Console.Write($"phan so {a.tuso}/{a.mauso} lon hon {b.tuso}/{b.mauso}");
            }else if(hieuso == 0)
            {
                Console.Write($"phan so {a.tuso}/{a.mauso} = {b.tuso}/{b.mauso}");
            }
            else
            {
                Console.Write($"phan so {a.tuso}/{a.mauso} < {b.tuso}/{b.mauso}");
            }

        }
        //trung binh cong so nguyen tren bien
        public static double TBC(int[,] a)
        {
            //123 i=0
            //456 i=1
            //589 i=2
            int s = 0;
            int dem = 0;
            for(int j=0; j<a.GetLength(1); j++)
            {
                //hang dau tien
                s = s + a[0, j];
                dem++;
                //hang cuoi cung, dk co 2 hang
                if (a.GetLength(0) >= 2)
                {
                    s = s + a[a.GetLength(0) - 1, j];
                    dem++;
                }        

            }
            for(int i =1; i<a.GetLength(0)-1; i++)
            {
                s = s + a[i, 0];
                dem++;
                //cot cuoi cung, dk co 2 cot 
                if (a.GetLength(1) >= 2)
                {
                    s = s + a[i, a.GetLength(1) - 1];
                    dem++;
                }
                
            }
            return s*1.0/dem;
        }
        public static int NhapTN(int thang, int nam)
        {
            //
            int songaytrongthang = 31; 
            //4,6, 9,11 e0 ngy
            if(thang ==4 || thang == 6 || thang == 9 || thang == 11)
            {
                songaytrongthang = 30;
            }
            else if(thang == 2)
            {
                if(nam%400==0 || (nam%100!=0 && nam % 4 == 0))
                {
                    songaytrongthang = 29;
                }
                else
                {
                    songaytrongthang = 28;
                }

            }
            return songaytrongthang;
        }
        //so cha n nho nhat mang 1 chieu so nguye
        public static int Sochannhonhat()
        {
            //nhap mang
            Console.Write("nhap so pt mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i =0; i<n; i++)
            {
                Console.Write($"nhap pt a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            //so chan dau tien
            int scnn = SochanDT(a);
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] < scnn)
                {
                    scnn = a[i];
                }
            }
            return scnn;
        }
        public static int SochanDT(int[] a)
        {

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    return a[i];
                }
                
            }
            return -1;
        }
        public static Lophoc Nhaplop()
        {
            Lophoc lop;
            lop.tenLop = "lop 10";
            Console.Write("nhap so hoc sinh: ");
            int n = int.Parse(Console.ReadLine());
            lop.dsHocsinh = new Hocsinh[n];
            for(int i=0;  i<n; i++)
            {
                lop.dsHocsinh[i] = NhapHS();
                
            }
            
            return lop;
        }
        public static Hocsinh NhapHS()
        {
            Hocsinh hs;
           
            Console.Write("nhap MaHS: ");
            hs.MaHs = int.Parse(Console.ReadLine());
            Console.Write("nhap Tenhs: ");
            hs.tenSV = Console.ReadLine();
            Console.Write("nhap diem toan: ");
            hs.diemToan = int.Parse(Console.ReadLine());
            Console.Write("nhap diem van: ");
            hs.diemVan = int.Parse(Console.ReadLine());

            return hs;
        }
        public static double DiemTB(Hocsinh hs)
        {
            return (hs.diemToan + hs.diemVan) / 2.0;
        }
        public static Hocsinh TimHSdiemcaonhat(Lophoc lop)
        {
            double maxdiem = 0;
            int vitri = 0;
            for(int i=0; i<lop.dsHocsinh.Length; i++)
            {
                double dtb = DiemTB(lop.dsHocsinh[i]);
                if (dtb > maxdiem)
                {
                    maxdiem = dtb;
                    vitri = i;
                }
            }

            return lop.dsHocsinh[vitri];
        }
        public static Phanso NhapPS()
        {
            Phanso kq;
            Console.WriteLine("nhap tu: ");
            kq.tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau: ");
            kq.mauso = int.Parse(Console.ReadLine());
           
            return kq;
        }
        public static void CongPS(Phanso a, Phanso b)
        {
            Phanso kq;
            kq.tuso = a.tuso * b.mauso + a.mauso * b.tuso;
            kq.mauso = a.mauso * b.mauso;
            Console.WriteLine($"ket qua la: {kq.tuso}/{kq.mauso}");
            Phanso kqrutgon = RutgonPS(kq);
            Console.WriteLine($"ket qua la: {kqrutgon.tuso}/{kqrutgon.mauso}");

        }
        public static Phanso RutgonPS(Phanso a)
        {
            int uocchung = UCLN(a.tuso, a.mauso);
            Phanso b;
            b.tuso = a.tuso / uocchung;
            b.mauso = a.mauso / uocchung;
            return b;

        }
        public static int UCLN(int a, int b)
        {
            while (a != 0 && b!=0 &&a!=b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                if(b > a)
                {
                    b = b - a;
                }
            }           
            return a;                
            
        }
        

        
        //MANG 2 CHIEU 
        //MA TRAN
        //
        //Bài 327: Tính tổng các giá trị nằm trên biên của ma trận
        //ss
        public static int Bai_327(int[,] a)
        {
            int s = 0; //so luong so nguyen to
            //tong bien dong
            for (int j = 0; j < a.GetLength(1); j++)
            {
                s = s + a[0, j]; //tong gia tri hang dau
                if (a.GetLength(0) >= 2) //neu dong lon hon 2
                {
                    s = s + a[a.GetLength(0) - 1, j]; //tong cac gia tri hang cuoi
                }

            }
            //tong bien cot
            for (int i = 1; i < a.GetLength(0) - 1; i++) //bo cot o hang cuoi cung nen -1
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
        public static double Bai_326Trungbinhcong(int[,] a)
        {
            int dem = 0;
            int tong = 0;
            for(int i =0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    tong = tong + a[i, j];
                    dem++;
                }
            }
            return 1.0*tong / dem;
        }


        //Bài 319: Viết hàm sắp xếp ma trận các số thực tăng dần từ trên xuống dưới và từ trái sang phải
        public static void Bai_319(int[,] a)
        {
            int n = a.GetLength(0)*a.GetLength(1);
            int[] b = new int[n];
            int k = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[k] = a[i,j];
                    k++;
                }
            }
            XuatMatran(a);
            SXmang(b);
            k = 0;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = b[k];
                    k++;
                }
            }
            XuatMatran(a);
        }
        //sap xep mang theo thu tu tang dan
        public static int[] SXmang(int[] a)
        {
            int tmp;
            for(int i=0; i<a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            return a;
        }
        //Bài 317: Viết hàm đếm số lượng số nguyên tố trong ma trận số nguyên
        public static int Bai_317(int[,] a)
        {
            int dem = 0;
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    if (KT_soNT2(a[i, j]))
                    {
                        Console.WriteLine(a[i, j]);
                        dem++;
                    }
                }
            }
            return dem;
        }
        //kiem tra so nguyen to
        public static bool KT_soNT2(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for(int i=2; i<=n/2; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
             

        //Bài 315: Viết hàm tìm giá trị lớn nhất trong ma trận số thực
        public static int Bai_315(int[,] a)
        {
            int max = a[0, 0];
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    if(a[i, j] > max)
                        max = a[i, j];
                }
            }
            return max;
        }
        //nhap mang 2 chieu
        public static int[,] NhapMatran()
        {
            Console.Write("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("nhap m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for(int i =0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    Console.Write($"nhap pt mang a[{i},{j}]: ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return a;

        }
        //xuat mang 2 chieu
        public static void XuatMatran(int[,] a)
        {
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        //tim so chan nho nhat mang 1 chieu so nguyen
        public static int Baithi(int[] a)
        {
            //tim so chan dau tien
            int scmin = Sochandautien(a);

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    if (scmin > a[i])
                        scmin = a[i];
                }
            }
            return scmin;
        }
        public static int Sochandautien(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    return a[i];
            }
            return -1;
        }
        //Bài 151: Hãy tìm số nguyên tố lớn nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về -1
        //Bài 152: Hãy tìm số hoàn thiện nhỏ nhất trong mảng 1 chiều các số nguyên.Nếu mảng không có số hoàn thiện thì trả về -1
        public static int Bai_151_soNTLonnhat(int[] a)
        {
            int soNTMAX = -1;
            for(int i=0; i<a.Length; i++)
            {
                if (KT_soNguyento(a[i]))
                {
                    if (soNTMAX < a[i])
                        soNTMAX = a[i];
                }
                
            }
            return soNTMAX;
        }

        //Bài 139: Tìm vị trí số hoàn thiện cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có số hoàn thiện thì trả về giá trị  -1
        //so hoan thien tong cac uoc so == chinh no
        //vd: 6 co uoc 1, 2, 3 la so hoan thien
        public static int Bai_139_vitriSoHTcuoi(int[] a)
        {
            for(int i = a.Length - 1; i >= 0; i--)
            {

                if (KT_SoHoanthien(a[i]))
                {
                    return i;
                }
                
            }
            return -1;
        }

        //127.Viết hàm sắp xếp mảng một chiều các số thực tăng dần.
        //dang lam cho so nguyen
        public static int[] Bai_127(int[] arr)
        {
            int i, j, tmp;
            Console.Write("\nSap xep mang theo thu tu tang dan\n");
            Console.Write("-----------------------------------\n");

            //int[] arr = Nhapmang();
            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i]) //muon i nho nhat
                    {
                        //doi gia tri
                        //tmp = arr[j];
                        //arr[j] = arr[i];
                        //arr[i] = tmp;

                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;


                    }
                }
            }
            //Xuatmang(arr);
            return arr;
        }

        //Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực
        public static int Bai_122_TimPTlonnhat()
        {
            int[] a = Nhapmang();
            int max = a[0];
            for(int i =0; i<a.Length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            Xuatmang(a);
            return max;
        }
        //nhap mang
        public static int[] Nhapmang()
        {
            Console.WriteLine("nhap so pt mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine($"do dai mang a.Length: {a.Length}");
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write($"nhap gia tri a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        //xuat mang
        public static void Xuatmang(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }



        //Bài 101: Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày
        //chua//--//Bài 102: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày kế ngày vừa nhập (ngày, tháng, năm)
        //Bài 103: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày trước ngày vừa nhập (ngày, tháng, năm)
        //Bài 104: Viết chương trình nhập ngày, tháng, năm. Tính xem ngày đó là ngày thứ bao nhiêu trong năm
        public static void XuatNgaytruocdo(int ngay, int thang, int nam)
        {
            //nhap ngay thang nam, xuat ngay ke tiep
            //int ngaytrongthang = 31;
            int ngayketiep = 0;
            int thangketiep = 0;
            int namketiep = 0;
           
            //ngay cuoi nam

            if (ngay > 1)
            {
                
                thangketiep = thang;
                namketiep = nam;
                ngayketiep = ngay - 1;
            }
            else if (ngay == 1 && thang != 1)
            {
               // ngayketiep = ngaytrongthang;//sai

                thangketiep = thang - 1; //da biet thang
                namketiep = nam; //da biet nam
                ngayketiep = NhapNgaythangnam(thangketiep, namketiep);
            }
            else if (ngay == 1 && thang == 1)
            {
                ngayketiep = 31;
                thangketiep = 12;
                namketiep = nam - 1;
            }
            Console.WriteLine($"ngay {ngayketiep}, thang {thangketiep}, nam {namketiep}");
        }



        public static void XuatNgayKeTiep(int ngay, int thang, int nam)
        {
            //nhap ngay thang nam, xuat ngay ke tiep
            int ngaytrongthang = 31;
            int ngayketiep = 0;
            int thangketiep = 0;
            int namketiep = 0;
            if((thang== 4) || (thang == 6) || (thang == 9) || (thang == 11))
            {
                ngaytrongthang = 30;
               
            }
            if (thang == 2)
            {
                if((nam%400==0) || (nam%100!=0 && nam % 4 == 0))
                {
                    ngaytrongthang = 29;
                    
                }
                else
                {
                    ngaytrongthang = 28;
                }

            }
            //ngay cuoi nam
            
            if (ngay < ngaytrongthang)
            {
                ngayketiep = ngay + 1;
                thangketiep = thang;
                namketiep = nam;
            }
            else if (ngay == ngaytrongthang && thang !=12)  {
                ngayketiep = 1;
                thangketiep = thang + 1;
                namketiep = nam;
            }
            else if (ngay ==ngaytrongthang && thang == 12)
            {
                ngayketiep = 1;
                thangketiep = 1;
                namketiep = nam+1;
            }
            Console.WriteLine($"ngay {ngayketiep}, thang {thangketiep}, nam {namketiep}");

        }
        public static int NhapNgaythangnam(int thang, int nam)
        {
            //thang 2: 28 hay 29 ngay2 tuy thuoc nam
            //1357-81012 thang co 31 ngay
            //46911
            int ngaytrongthang = 31; 
            if((thang==4)|| (thang == 6)||(thang == 9) || (thang == 11))
            {
                ngaytrongthang = 30;
            }
            if (thang == 2)
            {
                if ((nam % 400 == 0) || (nam % 100 != 0 && nam % 4 == 0))
                {
                    ngaytrongthang = 29;
                }
                else
                    ngaytrongthang = 28;
            }
            return ngaytrongthang;
        }



        //Số hoàn hảo (hay còn gọi là số hoàn chỉnh, số hoàn thiện hoặc số hoàn thành) là một số nguyên dương mà
        //tổng các ước nguyên dương thực sự của nó (các số nguyên dương bị nó chia hết ngoại trừ nó) bằng chính nó
        //6=s(6)=1+2+3
        //28=s(28)=1+2+4+7+14
        public static bool KT_SoHoanthien(int n)
        {
            int tonguocso = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    tonguocso += i;//tong cac uoc
                }
            }
            return tonguocso == n;
        }
        public static bool KT_soNguyento(int n)
        {
            //n =1, 2 ko tinh
            //n tu 2 tro len
            //
            if(n <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            
            return true;
        }
        public static bool KT_soChinhphuong(int n)
        {
            //so binh phuong so tu nhien
            //Math.Sqr(4)=2. Math.Sqr(5)=2
            //binh phuong len bang n thi chinh phuong
            int cbhai = (int)Math.Sqrt(n);
            // Console.Write(cbhai);
            return cbhai * cbhai == n;
        }
        //kiem tra so doi xung
        public static bool KT_sodx(int n)
        {

            //vd 12321
            //tim so dx - chinh no =0 : dx
            //tim so dxung: 12321/10 = 1232 du 1. Lay so 1 nhan 10^4 (dem-1)
            //1232/10 = 123 du 2. lay so 2 nhan 10^3 (dem-1)
            //...
            int demcs = DemSoCS(n);
            double songhichdao = 0;
            for(int i=n; i!=0; i = i / 10)
            {
                int cs = i % 10;
                songhichdao = songhichdao+ cs*Math.Pow(10, demcs-1);
                demcs = demcs - 1;
            }
            Console.WriteLine(songhichdao);
            //if (songhichdao == n)
            //    return true;
            //return false;
            return songhichdao == n;

        }
        public static int DemSoCS(int n)
        {
            int dem = 0;
            for(int i=n; i!=0; i = i / 10)
            {
                dem++;
                //123. khac 0. dem = 1. i=12
                //12. khac 0. dem =2. i=1
                //1. khac 0. dem 3. i = 0. ket thuc vong

            }
            return dem;
        }
        //Bài 53: Hãy đếm số lượng chữ số lớn nhất của số nguyên dương n
        //HAY Bài 54: Hãy đếm số lượng chữ số nhỏ nhất của số nguyên dương n
        public static int Bai_53(int n)
        {
            int dem = 0;
            int max = TimCSmax(n);
            for (int i = n; i != 0; i = i / 10)
            {
                int cs = i % 10;
                if (cs == max)
                    dem++;

            }
            return dem;
        }
        public static int TimCSmax(int n)
        {
            int max = 0;
            for (int i = n; i !=0; i = i / 10)
            {
                int cs = i % 10;
                if(max<cs)
                    max = cs;
            }
            return max;
        }
        //Bài 47: Hãy tính tổng các chữ số chẵn của số nguyên dương n
        //Bài 48: Hãy tính tích các chữ số lẻ của số nguyên dương n
        public static int Bai_47(int n)
        {
            int tong = 0;
            int csdau = 0;
            for(int i=n; i!=0; i = i / 10)
            {
                
               
                int cs = i % 10;
                if (cs % 2 == 0)
                    tong = tong + cs;
            }
            return tong;
        }
        //Bài 46: Hãy đếm số lượng chữ số lẻ của số nguyên dương n

        public static int Bai_46(int n)
        {
            int dem = 0;
            for (int i = n; i != 0; i = i / 10)
            {
                int a = i % 10; //
                
                if (a % 2 != 0) 
                { 
                    dem = dem + a; 
                }
            }
            return dem;
        }

        //Bài 44: Hãy tính tổng các chữ số của số nguyên dương n
        //Bài 45: Hãy tính tích các chữ số của số nguyên dương n

        public static int Bai_44(int n)
        {
            int tong = 0;
            int tich = 1;
            for(int i = n; i!=0; i = i / 10)
            {
                tich = tich * (i % 10);
                tong = tong + i%10;

            }
            Console.WriteLine($"tich: {tich}");
            return tong;
        }
        //Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n
        public static int Bai_43(int n)
        {
            //201/10=20 du 1
            //20/10 =2 du 0
            //2/10 =0 du 0
            int dem = 0;
            for(int i=n; i!=0; i = i / 10)
            {
                
                dem++;
            }
            
            return dem;
        }

        //Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25
        public static int Bai_29(int n)
        {
            int uocleMax = 1;
            for(int i=1; i<=n; i++)
            {
                if(n%i==0 && i % 2 != 0)
                {
                   // Console.WriteLine(i);
                    if (uocleMax < i)
                        uocleMax = i;
                }
            }
            return uocleMax; 
        }
        ////Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
        //Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n
        //Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n
        public static int Bai_20(int n)
        {
            int dem = 0;
            int S = 0;
            for (int i=1; i<=n; i++)
            {
                if (n % i == 0)
                {
                    S = S + i;
                    if (S < n)
                    {
                        Console.WriteLine($"uoc so cua n la: {i}");
                    }
                    else
                    {
                        S = S - i;
                    }
                    dem++;
                    
                }
            }
            return S;
        }

        //hay Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!
        public static double Bai_18(int n, int x)
        {
            double S = 1;            
            //s0 = 1
            //s1 = 1 + x2*1/2*1!
            //s2 = 1 + x(2*1)/2*1! + x(2*2)/2*2! = s1 + x2*2/2*2!
            for (int i=1; i<=n; i++)
            {
                S = S + Math.Pow(x, 2*i) / (2 * i);
            }
            return S;
            
        }

        //Bài 16: Tính S(n) = x + x^2/1 + 2 + x^3/1 + 2 + 3 + … + x^n/1 + 2 + 3 + …. + N
        public static double Bai_16(int n, int x)
        {
            int tongn = 0;
            double S = 0;
            for(int i=1; i<=n; i++)
            {
                tongn = tongn + i;
                //s1 = x
                //s2 = x + x2/tong2
                //s3 = x + x2/tong2 + x3/tong3 = s2+x3/tong3
                S = S + Math.Pow(x, i) / tongn;
                Console.WriteLine($" xmu i {Math.Pow(x, i)}");
            }

            return S;
        }        
        public static void Tinhtong16()
        {
            Console.WriteLine($"vui long nhap nhap n: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            int tong = 0;
            for (int i = 1; i<=n; i++)
            {
                tong = tong + i;
                s = s + 1.0 / tong;
            }
            Console.WriteLine(tong); Console.WriteLine(s);
        }
        //GIAI PT BAC 1 ax+b=0
        public static void PTB1()
        {
            Console.Write("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            int b = int.Parse(Console.ReadLine());
            if(a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("PT VO SO NGHIEM");
                }
                else
                    Console.WriteLine("PT VO N0");
            }
            else
            {
                Console.WriteLine($"pt co nghiem: {-b / (1.0 * a)}");
            }
        }
        public static void PTB2(int a, int b, int c)
        {
            //ax2 + bx + c =0
            double delta = b * b - 4 * a * c;
            if(a == 0)
            {
                if(b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine($"PT vo so nghiem");
                    }
                    else
                        Console.WriteLine("pt vo n0");
                }
                else
                {
                    Console.WriteLine($"pt co nghiem: {-c * 1.0 / b}");
                }
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("PT VO NGHIEM");
                }
                else if(delta == 0)
                {
                    Console.WriteLine($"pt co nghiem kep: {-b / (2 * a)}");
                }
                else
                {
                    Console.WriteLine($"pt co nghiem x1= {(-b + Math.Sqrt(delta)) / (2.0 * a)} " +
                        $"x2= {(-b - Math.Sqrt(delta)) / (2.0 * a)}");
                }
            }

        }
        //Bài 15: Tính S(n) = 1 + 1/1 + 2 + 1/ 1 + 2 + 3 + ….. + 1/ 1 + 2 + 3 + …. + N
       



    }
}
