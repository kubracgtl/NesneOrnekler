using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEVV7
{
    class TrueFalse
    {
        public bool dogruyanlis(int sayi1)
        {            
            if (sayi1 % 2 == 0)
                return false;
            else
                return true;
           
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            TrueFalse tr = new TrueFalse();


            Console.WriteLine("Sayı: {0}", tr.dogruyanlis(11));

            Console.ReadLine();

        }

    }   
}
