using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan8_21_08
{
    internal class Program
    {
       
        public static void InCuuChuong()
        {
            for (int i =2; i<=9; i++)
            {
                for (int j=1; j<=10; j++)
                {
                    Console.WriteLine($"{j}*{i}={i * j}");
                }
                Console.WriteLine("-------");
            }
        }
        //kiem tra co phai so nguyen to ko?
        public static bool SoNguyento(int n)
        {
            if (n <= 1)
            {
                return false;
            }
           
            int i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                    return false;
                i++;
            }
            return true;
        }
        //tinh tong cac so nguyen to tu 2 den n
        public static int TongSNT(int n)
        {
            int S = 0;
            for(int i = 2; i < n; i++)
            {
                if (SoNguyento(i))
                {
                    S = S + i; //s++ =i
                    Console.WriteLine($"so NT la: {i}, tong {S}");
                }                   
            }
            return S;
        }

        //bai 43: Hãy đếm số lượng chữ số của số nguyên dương n
        public static int Bai_43(int n)
        {
            //n=123; n%10 = 3; n/10=12 (chia lay nguyen)
            //n=12; n%10=2; n/10=1
            //n=1; n%10=1; n/10=0 dung
            int sochusoN = 0;
            while(n != 0)
            {
                sochusoN = sochusoN + 1; //sochusoN++
                n = n / 10;
            }
            return sochusoN;
        }

        //Bài 44: Hãy tính tổng các chữ số của số nguyên dương n
        public static int Bai_44(int n)
        {
            int tong=0;
            for(int i = n; i !=0; i = i / 10)
            {
                tong = tong + i%10; //i%10  
            }
            return tong;
        }

        //Bài 46: Hãy đếm số lượng chữ số lẻ của số nguyên dương n
        public static int Bai_46(int n)
        {
            int demsole = 0;
            for(int i = n; i!=0; i = i / 10)
            {
                if ((i % 10) % 2 != 0)
                    demsole = demsole + 1;
            }
            return demsole;
        }
        //Bài 50: Hãy tìm số đảo ngược của số nguyên dương n
        public static int Bai_50(int n)
        {
            int sodaonguoc = 0;
            for (int i = n; i!=0; i = i / 10)
            {
                //12 i%10=2 i/10=1; so dao: 2
                //1 i%10=1 i/10=0 ; so dao: 2*10 +1; dung                
                sodaonguoc = sodaonguoc * 10 + i % 10;
            }
            return sodaonguoc;
        }
        static void Main(string[] args)
        {                        
            //InCuuChuong();
            Console.Write("nhap n:");
            int n = int.Parse(Console.ReadLine());
          
            //bai so nguyen to
            if (SoNguyento(n))
                Console.WriteLine($"{n} la so nguyen to");
            else
                Console.WriteLine($"{n} ko la sont");

            //viet ham tong cac so nguyen to <N
            Console.WriteLine($"tong so nguyen to den {n}: {TongSNT(n)}");
            
            //bai 43
            Console.WriteLine($"so luong chu so cua so nguyen duong {n}: {Bai_43(n)}");
            //bai 44
            Console.WriteLine($"tong cac chu so cua so nguyen duong {n}: {Bai_44(n)}");
            //bai 46
            Console.WriteLine($"so luong so le cua so nguyen duong {n}: {Bai_46(n)}");
            //bai 50
            Console.WriteLine($"so dao cua so nguyen duong {n}: {Bai_50(n)}");
        }
    }
}
