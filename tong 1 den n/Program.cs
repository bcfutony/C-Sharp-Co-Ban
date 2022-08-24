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
            //go bai can chay
            //vi du Bai_100();
            
            Bai_111();         
            
        } //dong ngoac main

        //CHUONG 3 CAU TRUC DIEU KHIEN
        //Bài 111: Viết chương trình in ra tam giác cân có độ cao h
        //Tam giác cân đặc nằm giữa màn hình
        //Tam giác cân rỗng nằm giữa màn hình
        //Tam giác  vuông cân đặc
        //Tam giác vuông cân rỗng
        

        //Bai 111 ve tam giac can dac
        public static int Bai_111()
        {
            //cau a tam giac can dac
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i<=n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            //cau b tam giac can rong            
            Console.Write("\n");
            Console.Write("Ve tam giac sao can trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            //Console.Write("Nhap so hang: ");
            //nb = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++) //chay den hang n-1 hang 1, n-2 hang 2, n-i hang i
                {
                    Console.Write(" ");
                }
                if (i != n)
                {
                    for (int j = 1; j <= 2 * i - 1; j++) //i =1 in 1*; i=2 in 2*; i=3  in 3*...
                    {

                        if (1 < j && j < 2 * i - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                            Console.Write("*");
                    }
                }
                else //dung cho hang cuoi
                {
                    for (int j = 1; j <= 2 * i - 1; j++) //i =1 in 1*; i=2 in 2*; i=3  in 3*...
                    {
                        Console.Write("*");
                    }
                }

                Console.Write("\n");
            }
            //cau c tam giac vuong can dac
            Console.Write("\n\n");
            Console.Write("Tam giac vuong can dac\n");
            Console.Write("----------------------");
            Console.Write("\n");
            for(int i =1; i<=n; i++)
            {
                for(int j =1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            //cau d tam giac vuong can rong
            Console.Write("\n\n");
            Console.Write("Tam giac vuong can rong\n");
            Console.Write("----------------------");
            Console.Write("\n");
            for (int i = 1; i <= n; i++)
            {
                //i<=2 va i=n
                if(i<=2 || i == n)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        //if (i >= 3 && i <= n - i)
                        //  Console.Write(" ");
                        Console.Write("*");
                    }
                }
                else
                {
                    //i>2 va i<n
                    //x x 1trong i-2
                    //x  x 2 trong
                    //x   x 3 trong
                    Console.Write("*");
                    for (int j = 1; j <= i - 2; j++)
                        Console.Write(" ");
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            return 111;

        }

        //Bài 110: Cần có tổng 200000 đồng từ 3 loại giấy bạc 1000 đồng, 2000 đồng, 5000 đồng.
        //Lập chương trình để tìm ra tất cả các phương án có thể
        public static int Bai_110()
        {
            int i, j, k;
            for(i =0; i<=200; i++) //200 * 1000 = 200 000
            {
                for (j=0; j<=100; j++) //100 * 2000 = 200 000
                {
                    for (k=0; k<=50; k++) //40 *5000 = 200 000
                    {
                        if(i*1000 +j*2000 + k*5000 == 200000)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
            return 110;
        }
        //Bài 109: Viết chương trình in bảng cửu chương ra màn hình
        public static int Bai_109()
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
            }
            return 109;
        }

        //Bài 108:  Viết hàm tính S = x^y
        public static int Bai_108()
        {
            Console.Write("nhap x:"); 
            double x = double.Parse(Console.ReadLine());
            Console.Write("nhap y:");
            double y = double.Parse(Console.ReadLine());
            double S = Math.Pow(x, y);
            Console.WriteLine($"{S}");
            return 108;
        }

        //Bài 107: Viết hàm tính S = CanBacN(x)
        public static int Bai_107()
        {
            double S;
            Console.Write("nhap n:"); //n nguyen duong
            double n = double.Parse(Console.ReadLine());
            Console.Write("nhap x:");
            double x = double.Parse(Console.ReadLine());
            //neu x be hon 0 can bac chan thi sao
            S = Math.Pow(x, 1/n);
            Console.WriteLine($" {S}");
            return 107;
        }
        //Bài 106 Viết chương trình nhập 1 số nguyên có 3 chữ số.  Hãy in ra cách đọc của số nguyên này
        //tuong tu xem 105, hang tram n/100

        //Bài 105: Viết chương trình nhập 1 số nguyên có 2 chữ số.  Hãy in ra cách đọc của số nguyên này
        public static int Bai_105()
        {
            //vd 23. hai muoi ba
            Console.WriteLine("nhap n:"); //lon hon 9, be hon 100
            int n = int.Parse(Console.ReadLine());
            int chuc = n / 10;
            int donvi = n % 10;
            if (chuc == 2) { Console.Write("hai "); }
            if (chuc == 3) { Console.Write("ba "); }
            if (chuc == 4) { Console.Write("bon "); }
            if (chuc == 5) { Console.Write("nam "); }
            if (chuc == 6) { Console.Write("sau "); }
            if (chuc == 7) { Console.Write("bay "); }
            if (chuc == 8) { Console.Write("tam "); }
            if (chuc == 9) { Console.Write("chin "); }
            Console.Write("muoi ");
            if (donvi == 1) { Console.WriteLine("mot"); }
            if (donvi == 2) { Console.WriteLine("hai"); }
            if (donvi == 3) { Console.WriteLine("ba"); }
            if (donvi == 4) { Console.WriteLine("bon"); }
            if (donvi == 5) { Console.WriteLine("nam"); }
            if (donvi == 6) { Console.WriteLine("sau"); }
            if (donvi == 7) { Console.WriteLine("bay"); }
            if (donvi == 8) { Console.WriteLine("tam"); }
            if (donvi == 9) { Console.WriteLine("chin"); }
            return 105;

        }
        //Bài 102: Viết chương trình nhập vào 1 ngày ( ngày, tháng, năm).
        //Tìm ngày kế ngày vừa nhập (ngày, tháng, năm)

        public static int Bai_102()
        {
            Console.Write("nhap ngay:");
            int ngay = int.Parse(Console.ReadLine()); //ngay lon hon 0
            if (ngay <= 0) 
            {
                Console.Write("ngay >0, nhap lai nhe:");
                ngay = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("nhap thang:");
                int thang = int.Parse(Console.ReadLine());
                Console.Write("nhap nam:");
                int nam = int.Parse(Console.ReadLine());

                int ngayketiep = 0;
                if ((thang == 4) || (thang == 6) || (thang == 11))
                {
                    //30 ngay
                    if (ngay < 30) { ngayketiep = ngay + 1; }
                    else
                    {
                        ngayketiep = 1;
                        thang = thang + 1;
                    }
                }
                else if (thang == 2)
                {
                    //nam nhuan, 29 ngay
                    if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                    {
                        if (ngay < 29) { ngayketiep = ngay + 1; }
                        else
                        {
                            ngayketiep = 1;
                            thang = thang + 1;
                        }
                    }
                    else
                    {
                        if (ngay < 28) { ngayketiep = ngay + 1; }
                        else
                        {
                            ngayketiep = 1;
                            thang = thang + 1;
                        }
                    }
                }
                else
                {
                    //thang 31 ngay
                    if (ngay < 31) { ngayketiep = ngay + 1; }
                    else
                    {
                        ngayketiep = 1;
                        if (thang != 12)
                        {
                            thang = thang + 1;
                        }
                        else
                        {
                            thang = 1; nam = nam + 1;
                        }
                    }
                }
                Console.WriteLine($"Ngay ke tiep la: {ngayketiep}, thang {thang}, nam {nam}");
            }          

            
            
            return 102;
        }//dong ham
        //Bài 101: Viết chương trình nhập tháng, năm. tháng đó có bao nhiêu ngày?
        public static int Bai_101()
        {
            Console.Write("nhap thang:");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("nhap nam:");
            int nam = int.Parse(Console.ReadLine());
            if(thang == 2)
            {
                //xet nam nhuan
                //nam chia het cho 400 hoac
                //nam chia het cho 4 và ko chia het 100
                if((nam %4 == 0) &&(nam%100 !=0) ||(nam%400==0))
                {
                    Console.WriteLine($"{nam} nam nhuan, thang {thang} có ba mươi 29 ngày");
                }
                else { Console.WriteLine($"thang {thang} co 28 ngay"); }

            }
            else if((thang == 4) || (thang == 6) || (thang == 9) || (thang == 11))
            {
                //30 ngay
                Console.WriteLine($"thang {thang} có ba mươi 30 ngày");
            }
            else
            {
                Console.WriteLine($"thang {thang} co 31 ngay");
            }
            return 101;
        }
        //Bài 100: Viết chương trình giải phương trình bậc 2
        //today start restart
        public static int Bai_100()
        {
            //ax2 +bx +c =0
            Console.Write("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("nhap c:");
            int c = int.Parse(Console.ReadLine());
            if(a == 0)
            {   //bx+c=0
                if (b == 0)
                {
                    if(c == 0) { Console.WriteLine("pt vo so nghiem"); }
                    else { Console.WriteLine("pt VO nghiem"); }
                }
                else { Console.WriteLine($" pt co nghiem x= {-1.0 * c / b}"); }
            }
            else
            {
                int delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("pt VO nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine($"pt co nghiem kep: {-b/(2.0*a)}");
                }
                else
                {
                    Console.WriteLine($"pt co 2 nghiem: {(-b + Math.Sqrt(delta)) / (2.0 * a)}, " +
                        $"{(-b - Math.Sqrt(delta)) / (2.0 * a)}");
                }
            }
            return 100;
        }

        //Bài 99: Viết chương trình nhập vào 3 số thực.
        //Hãy in 3 số ấy ra màn hình theo thứ tự tang dần mà chỉ dùng tối đa 1 biến phụ
        //Giống Interchange sort
        //a so sánh với b và c
        //b so sánh với c
        public static int Bai_99()
        {
            Console.Write("nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap c:");
            double c = double.Parse(Console.ReadLine());
            double tmp;
            if(a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if(a > c)
            {
                tmp = a;
                a = c;
                c = tmp;                
            }
            if(b > c)
            {
                tmp = b;
                b = c;
                c =tmp;
            }
            Console.WriteLine($"3 so a, b, c theo thu tu tang dan {a} {b} {c}");
            return 99;
        }

        //Bài 97: nhập 3 cạnh của 1 tam giác, cho biết đó là tam giác gì
        public static int Bai_97()
        {
            Console.Write("nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap c:");
            double c = double.Parse(Console.ReadLine());
            if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
            {
                Console.WriteLine("tam giac ko hop le");
            }
            else
            {
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("tam giac deu");
                }
                else
                {
                    if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                    {
                        //Console.WriteLine("tam giac vuong");
                        if (a == b || b == c || c == a) { Console.WriteLine("tg vuong can"); }
                        else { Console.WriteLine("tam giac vuong"); }
                    }
                    else if (a == b || b == c || c == a) { Console.WriteLine("tg can"); }
                    else
                    {
                        Console.WriteLine("tam giac thuong");
                    }
                }
            }
            return 97;
        }
        //Bài 95: nhập 3 số thực. Hãy thay tất cả các số âm bằng trị tuyệt đối của nó
        public static int Bai_95()
        {
            Console.WriteLine("nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap c:");
            double c = double.Parse(Console.ReadLine());
            if (a < 0) { a = -a; }
            if (b < 0) { b = -b; }
            if (c < 0) { c = -c; }
            Console.WriteLine($"3 so a, b, c la: {a} , {b} , {c}");
            return 95;

        }
        //Bài 94: Viết chương trình in ra tất cả các số lẻ nhỏ hơn 100 trừ các số 5, 7, 93
        public static int Bai_94()
        {
            for(int i =1; i < 100; i = i + 2)
            {
                //số 5, 7, 93
                if(i !=5 && i != 7 && i != 93)
                {
                    Console.WriteLine($"cac so le la: {i}");
                }
                
            }
            return 94;

        }

        //Bài 92: Tìm ước số chung lớn nhất của 2 số nguyên dương
        //Bài 93: Viết chương trình kiểm tra 1 số có phải là số nguyên tố hay không

        //Bài 91: In tất cả các số nguyên dương lẻ nhỏ hơn 100
        public static int Bai_91()
        {
            for (int i = 1; i <100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            return 91;
        }
        //Bài 89: tổng các giá trị lẻ nguyên dương nhỏ hơn N
        //Bài 90: tìm số nguyên dương m lớn nhất sao cho 1 + 2 + … + m < N. Giong 42

        //Bài 88: Hãy sử dụng vòng lặp for để xuất tất cả các ký tự từ A đến Z
        public static int Bai_88()
        {
            char kytu;
            for(kytu = 'A'; kytu <= 'Z'; kytu++)
            {
                Console.WriteLine(kytu);
            }
            return 88;
        }

        //Bài 87: Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + … + n > 10000
        public static int Bai_87()
        {
            int S = 0;
            
            for (int i = 1; S<=10000; i++)
            {
                S = S + i;
                if(S > 10000)
                {
                    //in i
                    Console.WriteLine($"tong la: {S} gia tri i: {i-1}");
                    break;
                }
            }
            return 87;
        }
        //Bài 86: Tính S(n) = 1^3 + 2^3 + … + N^3. S=S+Math.Pow(i,3)
        //Bài 85: Nhập vào tháng của 1 năm. Cho biết tháng thuộc quý mấy trong năm
        public static int Bai_85()
        {
            Console.WriteLine("vui long nhap thang:");
            int n = int.Parse(Console.ReadLine());
            if(n == 1 || n == 2 || n == 3) { Console.WriteLine($"{n}: quy 1"); }
            else if (n == 4 || n == 5 || n == 6) { Console.WriteLine($"{n}: quy 2"); }
            else if (n == 7 || n == 8 || n == 9) { Console.WriteLine($"{n}: quy 3"); }
            else { Console.WriteLine($" {n}: quy 4");}
            return 85;
        }
        //bai 84 xem bai 64
        //bai 83 dung tich a*b>0. Viết chương trình nhập 2 số thực, kiểm tra xem chúng có cùng dấu hay không
        //Bài 82: Viết chương trình tìm số lớn nhất trong 3 số thực a, b, c
        public static int Bai_82()
        {
            Console.Write("nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap c:");
            double c = double.Parse(Console.ReadLine());
            double max;
            max = a;
            if(b > max) { max = b; }
            if(c > max) { max = c; }
            Console.WriteLine($"so lon nhat la {max}");
            return 82;
        }

        //Bài 77: Viết chương trình tính tổng của dãy số sau: S(n) = 1 + 2 + 3 + … + n
        //Bài 78: Liệt kê tất cả các ước số của số nguyên dương n
        //Bài 79: Hãy đếm số lượng chữ số của số nguyên dương n
        //xem phan tren

        //71, 72, 73, 74 tuong tu
        //Bài 71: Tính S(x, n) = -x + x^2/(1 + 2) – x^3/(1 + 2 + 3) + … + (-1)^n * x^n/(1 + 2 +… + n)
        public static int Bai_71()
        {
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("nhap x:");
            int x = int.Parse(Console.ReadLine());  

            int Stong = 0;
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                Stong = Stong + i; //Stong +=i. tong 1+2+3...
                S = S + Math.Pow(-1,i)*Math.Pow(x,i) / Stong;
            }
            Console.WriteLine($"cac tong la: {S}");
            return 71;
        }

        //Bài 70: Tính S(n) = 1 – 1/(1 + 2) + 1/(1 + 2 + 3)  + … + (-1)^n+1 * 1/(1 + 2 + 3+ … + n)
        public static int Bai_70()
        {
            Console.Write("nhap n:");
            double n = double.Parse(Console.ReadLine());
            int Stong = 0;
            double S = 0;

            for (int i =1; i <= n; i++)
            {
                Stong =Stong + i; //Stong +=i. tong 1+2+3...
                S = S + 1.0*Math.Pow(-1,i+1) / Stong;
            }
            Console.WriteLine($"cac tong la: {S}");
            return 70;
        }
        //Bài 68: Tính S(x, n) = -x^2 + x^4  + … + (-1)^n * x^2n
        public static int Bai_68()
        {
            Console.Write("nhap n:");
            double n = double.Parse(Console.ReadLine());
            Console.Write("nhap x:");
            double x = double.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 1; i <= n; i++)
            {
                S = S + Math.Pow(-1, i) * Math.Pow(x, 2 * i);
            }
            Console.WriteLine($"{S}");
            return 68;
        }
        //Bài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n
        public static int Bai_67()
        {
            Console.Write("nhap n:");
            double n = double.Parse(Console.ReadLine());
            Console.Write("nhap x:");
            double x = double.Parse(Console.ReadLine());

            double S = 0, S2=0;
            double T = 1;
            x = -x;
            for( int i = 1; i <= n; i++)
            {   //cach 1
                S2 = S2 + Math.Pow(-x, i)*Math.Pow((-1),i+1);
                //cach 2
                T = T * x;
                S = S + T;
                
            }
            Console.WriteLine($"tong la: {-S}, T:{T}, x:{x}");
            Console.WriteLine($"tong la: {S2}, T:{T}, x:{x}");
            return 67;
        }

        //Bài 64 + 65 + 66: Giải phương trình bậc 1, 2, 4
        public static int Bai_64()
        {
            //ax+b=0
            Console.WriteLine("nhap: a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap: b");
            int b = int.Parse(Console.ReadLine());
            if( a == 0)
            {
                if (b == 0) { Console.WriteLine("pt vo so nghiem"); }
                else { Console.WriteLine("pt VO nghiem"); }
            }
            else
            {
                Console.WriteLine($"pt co 1 nghiem x ={-b * 1.0 / a}");
            }
            return 64;
        }
        public static int Bai_65()
        {
            //ax2 +bx +c = 0
            Console.Write("nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("nhap c:");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                //bx+c=0
                if(b == 0)
                {
                    if(c==0) { Console.WriteLine("pt vo so nghiem"); }
                    else { Console.WriteLine("pt VO nghiem"); }
                }
                else { Console.WriteLine($"pt co nghiem la {-c * 1.0 / b}"); }
            }
            else //a !=0
            {
                int delta = b * b - 4 * a * c;
                if(delta <0)
                {
                    Console.WriteLine("pt VO nghiem");
                }
                else if(delta == 0)
                {
                    Console.WriteLine($"pt co nghiem kep: {-b / (2.0 * a)}");
                }
                else
                {
                    //pt co 2 nghiem (-b +delta)/2a
                    Console.WriteLine($"pt co 2 nghiem: {(-b + Math.Sqrt(delta)) / (2.0 * a)}, " +
                        $"{(-b - Math.Sqrt(delta)) / (2.0 * a)}");
                }
            }
            return 65;
        }
        
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

        //Bài 60: Hãy kiểm tra các chữ số của số nguyên dương n có tăng dần từ trái sang phải hay không
        //Bài 61: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không
         public static int Bai_60()
        {
            Console.WriteLine("nhap n");
            int n = int.Parse(Console.ReadLine());
            int an = n % 10; //lay so dau tien. vd 143 ->3
            bool sotangdan = false;
            for(int i =n/10; i !=0; i = i / 10)
            {
                int am = i % 10; //so thu 2. vd 143 ->4
                if(am < an)
                {
                    Console.WriteLine($" {n} KHONG la so co chu so tang dan");
                    sotangdan = false;
                    break;
                }
                else
                {
                    an= am;
                    sotangdan = true;
                }
            }
            if (sotangdan)
            {
                Console.WriteLine($" {n} la so tang dan");
            }
            return 56;
        }

        //Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng hay không
        /// <summary>
        /// bai nay chua lam
        /// </summary>
        /// <returns></returns>


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

                S = S + i % 10; //tong cac chu so
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

            for (int i = n; i != 0; i = i / 10)
            {
                //i%10: chu so
                T = T * (i % 10);
                int a = i % 10; //bai 46
                if (a % 2 == 1) //so le
                {
                    demle++; //dem so
                }
                //bai 47
                if (a % 2 == 0) //so chan
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

    }
}
