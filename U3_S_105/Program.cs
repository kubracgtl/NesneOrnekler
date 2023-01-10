using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_105
{
    
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int Modelyili { get; set; }
        public abstract void calis();
        public abstract void dur();
    }
    public class Otomobil : MotorluArac
    {
        public bool OtomotikVites { get; set; }
        public override void calis()
        {
            Console.WriteLine("otomobil çalıştı");
        }
        public override void dur()
        {
            Console.WriteLine("otomobil durdu");


        }
        class Program
        {
            static void Main(string[] args)
            {
                Otomobil oto = new Otomobil
                {
                    Modelyili = 2007,
                    MotorHacmi = 1600
                };

                oto.calis();
                oto.dur();
                Console.ReadLine();

            }



        }

       
        
        
    }
}
