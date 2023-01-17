using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_S_107
{

    interface IHayvan
    {
        void SesCikar();
    }
    interface IBeslen
    {
        void Beslen();
    }
    public class Kedi : IHayvan, IBeslen
    {

        public void SesCikar()
        {
            Console.WriteLine("kedi:miyavv");

        }
        public void Beslen()
        {
            Console.WriteLine("kedi süt içti");

        }
    }
    public class Kopek: 






    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
