using System;
using System.Collections.Generic;
using System.Text;
namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {

            Console.WriteLine("customers is added :" + musteri.MusteriName);
        }
        public void Del(Musteri musteri)
        {

            Console.WriteLine("customer is Deleted" + musteri.MusteriName);
        }
    }
}
