using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 01;
            musteri1.MusteriName = "Feyzullah";
            musteri1.MusteriSurname = "BAKTEMUR";
            musteri1.MusteriCity = "Gaziantep";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 02;
            musteri2.MusteriName = "Busra";
            musteri2.MusteriSurname = "POLAT";
            musteri2.MusteriCity = "Angara";

            Musteri[] myMusteri = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine();

            foreach (var yaz in myMusteri)
            {
                Console.WriteLine("-----Custormers------");

                Console.WriteLine("Customers 's ID : " + yaz.MusteriId);
                Console.WriteLine(yaz.MusteriName);
                Console.WriteLine(yaz.MusteriSurname);
                Console.WriteLine(yaz.MusteriCity);
                Console.WriteLine("&&&&&&&&&&&&&&&&\n");

            }
            Console.WriteLine("----------customers-----------");
            for (int i = 0; i < myMusteri.Length; i++)
            {
                Console.WriteLine("Customers 's ID:" + myMusteri[i].MusteriId);
                Console.WriteLine(myMusteri[i].MusteriName);
                Console.WriteLine(myMusteri[i].MusteriSurname);
                Console.WriteLine(myMusteri[i].MusteriCity);

                Console.WriteLine("&&&&&&&&&&&\n");
            }


            // adding customers
            {
                MusteriManager musterimanager2 = new MusteriManager(); 

                musterimanager2.Add(musteri1);
                musterimanager2.Add(musteri2);
            }

            // customers deleted
            {
                MusteriManager musterimanager2 = new MusteriManager();
                musterimanager2.Del(musteri1);
                musterimanager2.Del(musteri2);
                Console.ReadLine();
            }
        
      
       }    
    }
}
