using System;


namespace rastgele_sayı
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next();
            Console.WriteLine(sayi);


            Random rastgele = new Random();
            for (int i = 0; i < 5; i++)
            {
                int sayi = rastgele.Next(1, 50);
                Console.WriteLine(sayi.ToString());
            }

        }
    }
}
