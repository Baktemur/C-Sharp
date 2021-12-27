namespace ConsoleApp9
{
    internal class UcgenAlanCevre
    {
        private int h;
        private int taban;
        private int k1;
        private int k2;
        private int k3;


        public UcgenAlanCevre(int x, int y, int z, int a, int b)
        {
            h = x;
            taban = y;
            k1 = z;
            k2 = a;
            k3 = b;


        }
        public void yazdir()
        {
            int alan = h * taban;
            int cevre = k1+k2+k3;
            Console.WriteLine("Üçgen Alan:" + alan);
            Console.WriteLine("Üçgen Çevre: " + cevre);

        }
    }
}
