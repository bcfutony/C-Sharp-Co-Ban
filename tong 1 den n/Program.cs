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
            //bai 42
            Console.WriteLine("nhap n:");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            int i = 1;
            
            while (S + i < n) //i =0 , 1, 2, ... i lon nhat la k
            {
                i++;         //
                S = S + i;  // tương đương 1 dòng S += ++i;
            }

            Console.WriteLine(i-1);

        } //dong ngoac main
    }
}
