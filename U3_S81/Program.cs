using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S81
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 5;
            ucgen.A = 4;
            ucgen.A = 2;
            Console.WriteLine("ücgenin a kenar uzunlugu:{0}", ucgen.A);
            Console.WriteLine("ücgenin b kenar uzunlugu:{0}", ucgen.B);
            Console.WriteLine("ücgenin c kenar uzunlugu:{0}", ucgen.C);

            Console.ReadLine();

        }
    }
    public class Ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı bilgi");
                }
                else
                {
                    a = value;
                }

            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı bilgi");

                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı bilgi");

                }
                else
                {
                    c = value;
                }
            }

        }

    }
}

