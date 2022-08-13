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
           
            Bai_45();           
            //Bai_43(n);
        } //dong ngoac main

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

    }
}
