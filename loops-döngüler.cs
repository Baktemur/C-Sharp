using System;

namespace Loopss
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] krediler = new string[7];
            krediler[0] = "Hızlı Kredi";
            krediler[1] = " Kredi2";
            krediler[2] = " Kredi3";
            krediler[3] = " Kredi4";
            krediler[4] = " Kredi5";
            krediler[5] = " Kredi6";
            krediler[6] = " Kredi7";


            for (int i = 0;i<krediler.Length; i++)//burada krediler.lenght i sayının sınırını bilemeyceğimiz zamanlarda i<7 yerine kullanabiliriz 
            {
                Console.WriteLine(krediler[i]);
            }
            Console.WriteLine("for döngüsü bitti");
            foreach (string kredi in krediler)
            {
                Console.WriteLine(kredi);
            }
            // infinite loops
            int sayac = 0;
            while (sayac<krediler.Length)// dinamizm
            
            
            {
                Console.WriteLine(krediler[sayac]);

                sayac++;
                    }
            int sayac2 = 0;
            do
            {

            } while (sayac2 < 7);
            Console.WriteLine(krediler[sayac]);
            sayac2++;
        }
        
    }
}
