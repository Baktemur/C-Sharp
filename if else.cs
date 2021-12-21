using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarBugun = 7.55;
            double dolarDun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


        }
        
	

	
    }
}
