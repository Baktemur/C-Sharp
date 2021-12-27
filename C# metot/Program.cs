using System;

namespace GeriyeDegerDondurenMetot
{
    internal class Program
    {


      


            static void Main(string[] args)
            {
                Console.WriteLine(topla(3, 4));
                toplam1(3, 4);
                Console.ReadLine(); // return ile 


            }
          static int topla(int a, int b)//geriye değer döndüren
        {
            int sonuc = a + b;
            return sonuc;



        }
        static void toplam1(int x, int y)//geriye değer döndürmeyen
        {
            int sonuc = x + y;
            Console.WriteLine(sonuc);

        }
    }
}


