﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S86
{
    class Program
    {
        static void Main(string[] args)
        {
            SayiBulucu sb = new SayiBulucu();
            int a = 10;
            int b = 5;
            int sonuc = sb.BuyukOlaniBul(a, b);
            Console.WriteLine("büyüksayi{0}", sonuc);
            Console.ReadLine();

        }
    }
    class SayiBulucu
    {
        public int BuyukOlaniBul(int sayi1, int sayi2)
        {
            int sonuc;
            if (sayi1<sayi2)
            {
                sonuc = sayi2;

            }
            else
            {
                sonuc = sayi1;
            }
            return sonuc;

        }
          


    }
}
