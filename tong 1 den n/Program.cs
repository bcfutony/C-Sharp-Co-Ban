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
            //cac bai giong nhau
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());

            //for (int i = n; i != 0; i = i / 10)
            //{
            //    Console.WriteLine(i%10);
            //}

            //Console.WriteLine(Bai_42(n));
            // Console.WriteLine(Bai_42(n));
            Bai_42(n);
           
            //Bai_43(n);

        } //dong ngoac main

        public static int Bai_42(int n)
        {
            //Console.WriteLine("nhap n:");
            //int n = int.Parse(Console.ReadLine());
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
        //Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n
        public static int Bai_43(int n)
        {
            int i = 1;
            for (i = n; i != 0; i = i / 10)
            {
                Console.WriteLine(i % 10);
               
            }
            return i % 10;
        }
        
    }
}
