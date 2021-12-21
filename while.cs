using System;

namespace whilee
{
    class Program
{
    static void Main(string[] args)
    {
            int sayac = 0, i = 1;
            while (i <= 100)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                    sayac++;
                }
                i++;
            }
            Console.WriteLine("9'e tam bölünen sayı adeti={0}", sayac);
            Console.ReadKey();

        }
    }
}

