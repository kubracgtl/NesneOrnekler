using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S115
{
    enum Seviyeler
    {
      cok_dusuk,
      dusuk,
      orta,
      yuksek,
      col_yuksek,

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Seviyeler.cok_dusuk);
            Console.WriteLine((int)Seviyeler.cok_dusuk);
            Console.ReadLine();
        }
    }
}
