using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhap_thang_nam_tim_ngay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nam");
            int nam = int.Parse(Console.ReadLine());

            // 1, 3, 5, 7, 8, 10, 12: 31 ngay
            //4, 6, 9, 11: 30 ngay
            //2 co 28 ngay nam thuong, 29 ngay nam nhuan
            //if((thang == 1)|| (thang == 3) || (thang == 5) || 
            //    (thang == 7)||(thang == 8) || (thang == 10) || (thang == 12) )
            //{
            //    Console.WriteLine($"thang {thang} co 31 ngay nhe");
            //}
            if((thang == 4) || (thang == 6) || (thang == 9) ||
                (thang == 11))
            {
                Console.WriteLine($"thang {thang} co 30 ngay nhe");
            }
            else if (thang ==2)
            {
                //nam tron the ky (tan cung..00) thi chia het 400
                //nam ko trong the ky thi chia het cho 4, ko chia het 100
                //1700%4= so du 0. 1700%100 so du 0
                //if ((nam % 400 == 0)||(nam%4==0 && nam%100!=0))
                if((nam%400==0) || (nam%100!=0 && nam%4==0))
                {
                    //nam nhuan
                    Console.WriteLine($"nam {nam} NHUAN, thang {thang} co 29 ngay");
                }
                else
                {
                    Console.WriteLine($"nam {nam} THUONG, thang {thang} co 28 ngay");
                }
            }
            else
            {
                Console.WriteLine($"thang {thang} co 31 ngay nhe");
            }
            //day la bai mau
        //    Console.Write("Nhap thang : ");
        //    string Sthang = Console.ReadLine();
        //    Console.Write("Nhap nam : ");
        //    string Snam = Console.ReadLine();

        //    int th = int.Parse(Sthang);
        //    int nm = int.Parse(Snam);
        //    int songay = 0;

        //    if (th >= 1 && th <= 12)
        //    {
        //        switch (th)
        //        {
        //            case 1:
        //            case 3:
        //            case 5:
        //            case 7:
        //            case 8:
        //            case 10:
        //            case 12: songay = 31; break;
        //            case 4:
        //            case 6:
        //            case 9:
        //            case 11: songay = 30; break;

        //            case 2:
        //                if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
        //                    songay = 29;
        //                else
        //                    songay = 28;
        //                break;
        //        }

        //        Console.Write("=> Thang " + th + "/" + nm + " co " + songay + " ngay\n");
        //    }
        //    else
        //        Console.Write("=> Thang khong hop le!\n");
        //    Console.ReadLine();
        }
    }
}
