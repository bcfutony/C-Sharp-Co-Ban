using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_1_den_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Bai_62();           
            //Bai_43(n);
        } //dong ngoac main

        //Bài 62: Cho 2 số nguyên dương a và b. Hãy tìm ước chung lớn nhất của 2 số này.
        //Bài 63: Cho 2 số nguyên dương a và b.Hãy tìm bội chung nhỏ nhất của 2 số này
        public static int Bai_62()
        {
            Console.Write("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            int b = int.Parse(Console.ReadLine());
            int soUCLN = UCLN(a, b);
            int soBCNN = BCNN(a, b);

            Console.WriteLine($"Uuoc chung lon nhat cua {a},{b} la {soUCLN}");
            Console.WriteLine($"Boi chung nho nhat cua {a},{b} la {soBCNN}");
            return a; //hoac b
        }
        //UCLN
        public static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        public static int BCNN(int a, int b)
        {
            int soBCNN = a * b / UCLN(a, b);
            return soBCNN;
        }

        //Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng hay không

        //Bài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không
        //Bài 57: Hãy kiểm tra số nguyên dương n có toàn chữ số chẵn hay không
        public static int Bai_56()
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            bool sole = false;
            for (int i = n; i != 0; i = i / 10)
            {
                int cs = i % 10;
                if (cs % 2 == 0) //so chan               
                {
                    Console.WriteLine($" so {n} ko phai toan chu so le");
                    sole = false;
                    break;
                }
                else
                {
                    //Console.WriteLine($" so {n} bao gom cac so le {cs}");
                    sole = true;
                }
            }
            if (sole)
            {
                Console.WriteLine($" so {n} la gom cac so le");
            }            
            return 56;
        }
        public static int Bai_57()
        {
            Console.WriteLine("nhap n");
            int n = int.Parse(Console.ReadLine());
            bool sochan = false;

            for (int i = n; i !=0; i = i / 10)
            {
                int cs = i % 10;
                if(cs % 2 == 0) //so chan
                {
                    sochan = true;
                }
                else
                {
                    //so le
                    Console.WriteLine($" so {n} KHONG toan chu so chan");
                    sochan = false;
                    break;
                }                
            }
            if (sochan)
            {
                Console.WriteLine($" so {n} la toan chu so chan");
            }
            return 57;
        }
        //bai 42
        public static int Bai_42()
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            int i = 1;

            while (S + i < n) //i =0 , 1, 2, ... i lon nhat la k
            {                        
                S = S + i;  //0+1+2+3+...
                i++;
            }
            Console.WriteLine(i - 1);
            return 1000; //dua  vao main bo di
        }

        //bai 43: Hãy đếm số lượng chữ số của số nguyên dương n
        public static int Bai_43()
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            
            for (int i = n; i != 0; i = i / 10)
            {
                dem++;
            }
            Console.WriteLine($"tong cac chu su cua {n} la {dem}");
            return 43; //cai gi cung dc
        }
        //Bài 44: Hãy tính tổng các chữ số của số nguyên dương n
        public static int Bai_44()
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());

            int S = 0;
            for (int i = n; i != 0; i = i / 10)
            {
                
                S = S + i%10; //tong cac chu so
            }
            Console.WriteLine($"tong cac so cua {n} la {S}");
            return 1000;
        }

        //Bài 45: Hãy tính tích các chữ số của số nguyên dương n
        //Bài 46: Hãy đếm số lượng chữ số lẻ của số nguyên dương n
        //Bài 47: Hãy tính tổng các chữ số chẵn của số nguyên dương n
        //Bài 48: Hãy tính tích các chữ số lẻ của số nguyên dương n
        //bai 49
        public static int Bai_45()
        {
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());

            int T = 1;
            int demle = 0;
            int Schan = 0;

            for(int i = n; i !=0; i = i / 10)
            {
                //i%10: chu so
                T = T * (i % 10);
                int a = i % 10; //bai 46
                if (a % 2 == 1) //so le
                { 
                    demle++; //dem so
                } 
                //bai 47
                if(a%2==0) //so chan
                {
                    Schan = Schan + a; //tong
                }
                //bai 49
                if (i < 10)
                {
                    Console.WriteLine($"chu so dau tien cua {n} la {i}");
                }

            }
            Console.WriteLine($"Tich cac so cua {n} la: {T}");
            Console.WriteLine($"So luong so le cua {n} la: {demle}");
            Console.WriteLine($"Tong so luong so chan cua {n} la: {Schan}");
            return 45;
        }
        
        //bai 50 51 52 
        //Bài 50: Hãy tìm số đảo ngược của số nguyên dương n
        //Bài 51: Tìm chữ số lớn nhất của số nguyên dương n
        //Bài 52: Tìm chữ số nhỏ nhất của số nguyên dương n
        public static int Bai_50()
        {
            
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            int soluongchuso = 0;
            int tong = 0;
            int tich = 1, tongle = 0, tongchan = 0;
            int sodautien = 0, sothu2 = 0;
            int min = 9, max = 0;
            //int demsomin = 0, demsomax = 0;
            //bien dem nguoc giam 1
            //j = j -1
            for (int i = n; i != 0; i = i / 10)
            {
                soluongchuso++;
                tong = tong + i % 10;
                tich = tich * (i % 10);
                //min = i % 10;
                if ((i % 10) <= min)  //tim so nho nhat
                {
                    min = i % 10;
                }
                if ((i % 10) >= max)  //tim so max
                {
                    max = i % 10;
                }
                //so nghich dao
                Console.WriteLine($"so nghich dao: {i % 10}");

                if ((i % 10) % 2 != 0)  //so le
                {
                    tongle = tongle + (i % 10);
                }
                else //so chan
                {
                    tongchan = tongchan + (i % 10);
                }
                if (i < 10)
                {
                    sodautien = i;
                }
                else if (i < 100)
                {
                    sothu2 = i % 10;
                }
            }
            Console.WriteLine($"So luong chu so: {soluongchuso}");
            Console.WriteLine($"tong chu so: {tong}");
            Console.WriteLine($"tich chu so: {tich}");
            Console.WriteLine($"tong le chu so: {tongle}");
            Console.WriteLine($"tong chan chu so: {tongchan}");

            Console.WriteLine($"so dau tien: {sodautien}");
            Console.WriteLine($"so thu hai: {sothu2}");
            Console.WriteLine($"min: {min}");
            Console.WriteLine($"max: {max}");

            return 50;
        } //ngoai ham

        //Bài 53: Hãy đếm số lượng chữ số lớn nhất của số nguyên dương n
        //HAY Bài 54: Hãy đếm số lượng chữ số nhỏ nhất của số nguyên dương n
        public static int Bai_53()
        {
            
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            //tim min
            int dem = 0, demmax = 0;
            int giatriMin = Timmin(n);
            int giatriMax = Timmax(n);

            for (int i = n; i != 0; i = i / 10)
            {
                if (giatriMin == i % 10)
                {
                    dem++;
                }
            }
            Console.WriteLine($"gia tri min la: {giatriMin}");
            Console.WriteLine($"so gia tri min la: {dem}");

            for (int i = n; i != 0; i = i / 10)
            {
                if (giatriMax == i % 10)
                {
                    demmax++;
                }
            }
            Console.WriteLine($"gia tri max la: {giatriMax}");
            Console.WriteLine($"so gia tri max la: {demmax}");
            return 53;

        } //dong ham Main
        public static int Timmin(int n)
        {
            int min = 9;
            for (int i = n; i != 0; i = i / 10)
            {
                if (i % 10 < min)
                {
                    min = i % 10;
                }
            }
            return min;
        }
        public static int Timmax(int n)
        {
            int max = 0;
            for (int i = n; i != 0; i = i / 10)
            {
                if (i % 10 > max)
                {
                    max = i % 10;
                }
            }
            return max;
        }



    }
}
