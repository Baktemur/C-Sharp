using System;

namespace cders16
{
    class Program
    {
        static void silindir(double r, double h)//v=pi* r*r* h;
        {
            double hac;
            hac = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("silindirin hacmi " + hac);
            Console.ReadLine();



        }
        static void küre(double r1)//küre v = pi * 4 / 3r* r*r;
        {
            double hac2;
            hac2 = Math.PI * (4 / 3) * Math.Pow(r1, 3);
            Console.WriteLine("kürenin hacmi " + hac2);
            Console.ReadLine();


        }
        static void küp(double a)
        {

            double hac1;
            hac1 = Math.Pow(a, 3);
            Console.WriteLine("küpün hacmi " + hac1);
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            //silindir küre ve küp haimlerini bulan kendi isimlerind meteodlar
            int sec;
            Console.WriteLine("seçiminiz.1 - silindir ,2 - küre,3 - küp ");
            Console.WriteLine("seçiminiz..:");
            sec = Convert.ToInt32(Console.ReadLine());
            if (sec == 1)//silindir
            {
                //v=pi*r*r*h;
                double r, h;
                Console.WriteLine("yarı çapı..:");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("yükseklik..:");
                h = Convert.ToDouble(Console.ReadLine());
                silindir(r, h);

            }
            else if (sec == 2)//küre v=pi*4/3r*r*r;
            {
                double r1;//hocaya sor
                Console.WriteLine("yarı çapı..:");
                r1 = Convert.ToDouble(Console.ReadLine());
                küre(r1);


            }
            else if (sec == 3)//küp v=a*a*a
            {
                double a;//hocaya sor
                Console.WriteLine("kenar çapı..:");
                a = Convert.ToDouble(Console.ReadLine());
                küp(a);

            }
            else
            {

                Console.WriteLine("1 - 3 arasında sayı giriniz...");

            }


        }
    }
}