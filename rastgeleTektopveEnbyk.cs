using System;

namespace cders17
{

    class Program
    {
        static void metod1(int[] dizi)
        {

            int top = 0;
            for (int x = 0; x < 10; x++)
            {

                if (dizi[x] % 2 == 1)
                {
                    top += dizi[x];
                }

            }

            Console.WriteLine(".....................................................toplamları " + top);
        }
        static void metod2(int[] dizi)
        {
            Array.Sort(dizi);
            Console.WriteLine(dizi[9]);




        }

        static void Main(string[] args)//random olarak girilen 10 elemanlı bir dizini içindeki tek olanların toplanmı 
        {//metod1 de dizi elemanlarından en büyük olanı metod2  de bulan geriye değer dondürmeyen paremetre alan programı yazınız..
            Random ras = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = ras.Next(1, 20);
                Console.WriteLine(dizi[i]);
            }
            metod1(dizi);
            metod2(dizi);

            Console.ReadLine();
        }
    }
}