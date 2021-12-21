using System;

namespace cders18
{
    class Program
    {
        static int hkre(int  a)//kare hacim
        {

            int hka = (int)Math.Pow(a, 3);
            return hka;
        }
        static void hdaire()//daire hacim
        {
            double r,hda;
            Console.WriteLine("yarı çap..:");
            r = Convert.ToDouble(Console.ReadLine());
            hda = Math.PI * (4 / 3) * Math.Pow(r, 2);
            Console.WriteLine(hda);
        }
        static void hsilin(double r,double u)//silibdir hacim
        {
            double hsild;
            hsild = Math.PI * Math.Pow(r, 2) * u;
            Console.WriteLine("hacim " + hsild);
            Console.ReadLine();
            
        }

        static double Hesap(int islem2,double s1,double s2)//hesaplam islemi
        {
            double top = 0;
            if (islem2 == 1)//toplama
            {
                top = s1 + s2;

            }
            else if (islem2 == 2)//çıkarma
            {
                top = s1 - s2;
            }
            else if (islem2 == 3)//çarp
            {
                top = s1 * s2;
            }
            else if (islem2 == 4)//bolme
            { 
                top = s1 / s2;  
            }
            else
            {
                Console.WriteLine("1 le 4 arasında rakam giriniz...");
            }
            Console.WriteLine("isleminizin sonucu ... " + top);
            Console.ReadLine();
            return top;
        }
        static void ishesap()//hesap makinesi seçim
        {
            int islem2,s1,s2;
            Console.WriteLine("1 sayıyı giriniz..:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 sayıyı giriniz...:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 - toplam 2 - çıkarma 3 - çarpma 4 - bolme");
            islem2 = Convert.ToInt32(Console.ReadLine());
            Hesap(islem2,s1,s2);
        }
        static void hacim()//küre daire  silindir hesaplama
        {
            int sec3;
            Console.WriteLine("1 - küre hacmi ,2 - daire hacmi , 3 - silindir hacmi");
            sec3 = Convert.ToInt32(Console.ReadLine());
            if (sec3==1)
            {
                int a;
                Console.WriteLine("kenarlar..:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(hkre(a));
                
            }
            else if (sec3 == 2)
            {
                hdaire();
            }
            else if(sec3 == 3)
            {
                double r, u;
                Console.WriteLine("yarı çapı giriniz..:");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("uzunluk giriniz..:");
                u = Convert.ToDouble(Console.ReadLine());
                hsilin(r, u);
            }
            else
            {
                Console.WriteLine("1 -3 arasında rakam giriniz");
            }
        }
        static void giris()//hesap hacim seçim
        {
            int sec;
            Console.WriteLine("1 - hesap makinesi 2 - hacim...");
            Console.WriteLine("seçim..:");
            sec = Convert.ToInt32(Console.ReadLine());
            switch (sec)
            {
                case 1:
                    ishesap();
                    break;
                case 2:
                    hacim();
                    break;
            }
        }
        static string düzkul(string gkul)//kulanıcı sifre degisme
        {
            Console.WriteLine("yeni kulanıcı isminiz..:");
            gkul = Convert.ToString(Console.ReadLine());
            return gkul;
        }
        static int düzpar(int gpar)//parola sifre degisme
        {
            int kulpar;
            Console.WriteLine("yeni parolanız..:");
            kulpar = Convert.ToInt32(Console.ReadLine());
            gpar = kulpar;
            return gpar;
        }
        static int ypar(int dpar, string gkul, int gpar)//parola doğrulama kodu
        {
            int gdpar;
            Console.WriteLine("doğrulama kodunuz..:");
            gdpar = Convert.ToInt32(Console.ReadLine());
            if (gdpar == dpar)
            {
                Console.WriteLine("doğrulama kodunuz doğrudur...");
                gpar = düzpar(gpar);
            }
            else
            {
                Console.WriteLine("doğrulama kodunuz yantıstır...");
                Console.WriteLine("sistemden atıldınız");
            }
            return gpar;
        }
        static string ykul(int dpar, string gkul, int gpar)//kulanıcı doğrulama kodu
        {
            int gdpar;
            Console.WriteLine("doğrulama kodunuz..:");
            gdpar = Convert.ToInt32(Console.ReadLine());
            if (gdpar == dpar)
            {

                gkul = düzkul(gkul);


            }
            else
            {

                Console.WriteLine("doğrulama kodunuz hatalıdır");

            }



            return gkul;
        }
        static void kulanıcı()//kulanıcı ve parola giris islemleri
        {
            string gkul = "qwe";
            string[] kul = new string[4];
            int gpar = 123;
            int[] par = new int[4];
            int dpar = 321;

            while (true)
            {
                int i = 0;
                i++;
                Console.WriteLine("kulanıcı adınız..:");
                kul[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("parolanız...");
                par[i] = Convert.ToInt32(Console.ReadLine());
                if (gkul.Equals(kul[i]) && gpar == par[i])
                {
                    Console.WriteLine("sisteme girilmistir...");
                    giris();

                }
                else if (gkul.Equals(kul[i]) && gpar != par[i])
                {
                    Console.WriteLine("parolanız hatalıdır...");
                    gpar = ypar(dpar, gkul, gpar);
                }
                else if (!gkul.Equals(kul[i]) && gpar == par[i])
                {
                    Console.WriteLine("kulanıcı adınız hatalıdır...");
                    gkul = ykul(dpar, gkul, gpar);
                }
                else
                {
                    Console.WriteLine("parola ve sifeniz hatalıdır");
                    Console.WriteLine("kulanıcı doğrulama kodu..");
                    gkul = ykul(dpar, gkul, gpar);
                    Console.WriteLine("sifreniz doğrulama kodu...");
                    gpar = ypar(dpar, gkul, gpar);
                }
    }
}

static void Main(string[] args)//islemi seçim fonksiyon içinde  döngüler
        {
            kulanıcı();
        }
    }
}
