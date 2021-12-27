namespace ConsoleApp8
{
    internal class dikdortgen
    {
        private int kk;
        private int uk;
        public dikdortgen(int x, int y)
        {
            kk = x;
            uk = y;


        }
        public void yazdir()
        {

            int alan = kk * uk;
            int cevre = (kk + uk) * 2;
            Console.WriteLine("Alan:" + alan);
            Console.WriteLine("Çevre:" + cevre);

        }

    }
}
