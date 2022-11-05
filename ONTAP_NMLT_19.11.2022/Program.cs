using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONTAP_NMLT_19._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GIAI PT BAC 1.   //GIAI PHUONG TRINH BAC 2
            //TIM NGAY GIO
            //UOC CHUNG NN BOI CHUNG LON NHAT
            // so nguyen to, doi xuong, chinh phuong

            int[] a = Nhapmang();
            int kq = Bai_151_soNTLonnhat(a);
            Console.Write(kq);
            //Xuatmang(b);
          
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
                Console.Write($"gia tri a[{i}]: {a[i]} \n");
            }
        }



        //Bài 101: Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày
        //chua//--//Bài 102: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày kế ngày vừa nhập (ngày, tháng, năm)
        //Bài 103: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm). Tìm ngày trước ngày vừa nhập (ngày, tháng, năm)
        //Bài 104: Viết chương trình nhập ngày, tháng, năm. Tính xem ngày đó là ngày thứ bao nhiêu trong năm
        public static void XuatNgaytruocdo(int ngay, int thang, int nam)
        {

            //nhap ngay thang nam, xuat ngay ke tiep
            int ngaytrongthang = 31;
            int ngayketiep = 0;
            int thangketiep = 0;
            int namketiep = 0;
            if ((thang == 4) || (thang == 6) || (thang == 9) || (thang == 11))
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
                {
                    ngaytrongthang = 28;
                }

            }
            //ngay cuoi nam

            if (ngay > 1)
            {
                ngayketiep = ngay -1;
                thangketiep = thang;
                namketiep = nam;
            }
            else if (ngay == 1 && thang != 1)
            {
                ngayketiep = ngaytrongthang;
                thangketiep = thang - 1;
                namketiep = nam;
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
