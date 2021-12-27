using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSilindirAlanHcm
{
   //class
    internal class silindir
    {

        private int yaricap;
        private int pi;
        private int h;

        // burası constructer
        public silindir(int x,int y,int z)
        {
            yaricap = x;
            pi = y; 
            h = z;

        }
        // metot
        public void yazdir()
        {
            int hacim = pi * (yaricap * yaricap)*h;
            int alan = pi * (yaricap * yaricap);
            Console.WriteLine("Hacim : " + hacim);
            Console.WriteLine("Alan :" + alan);
        }




    
}

}
