using System;

namespace ProjectRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği 5 sayıdan 50′ den büyük olanların toplamını gösteren Console programı

            int[] Sayi = new int[10];
            int buyuksayitop = 0 , toplam = 0;
            for (int a = 1; a < 6; a++)
            {


                Console.WriteLine(a + " . Sayıyı Giriniz", Sayi[a]);
                Sayi[a] = Convert.ToInt32(Console.ReadLine());


                if (Sayi[a] < 50)
                {
                    toplam += Sayi[a];

                    continue;
                }
                
                else if (Sayi[a] > 50)
                {
                    buyuksayitop += Sayi[a];
                    continue;
                }
               
                    continue;
                
                
                }
                Console.WriteLine("50 den küçük sayıların toplamı:" + toplam);
                Console.WriteLine("50 den büyük sayıların toplamı:" + buyuksayitop);
                Console.ReadLine();

                // if (Sayi[a] == 50)
                //{
                //    Console.WriteLine("Sayı 50 ye eşittir...");
                //}
                //else if (Sayi[a] == 50)
                //{
                //    toplam += Sayi[a];
                //}
                // else
                //{
                // kucuksayi = Sayi[a];

                //}
                 }        
                  }
                   }
  
