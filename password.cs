using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while
            string yazi;
            do
            {
                Console.WriteLine("Şifreyi giriniz");
                yazi = Console.ReadLine();
            }
            while (yazi != "sifre");
            Console.WriteLine("Şİfreyi bildiniz.");
            Console.ReadLine();
        }
    }
}
