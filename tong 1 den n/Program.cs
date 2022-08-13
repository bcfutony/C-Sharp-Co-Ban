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
           
            Bai_43();           
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

    }
}
