using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex2
{
    // am facut o clasa separata pe care am numit-o usi
    //Usa va detina doua metode:
    //Deschide (La apelul acestei metode usa va afisa in consola “click”)
    //Inchide (La apelul acestei metode usa va afisa in consola “clack”)
    internal class Usi
    {
        private int numarDeusi;
        public Usi(int numarDeusi)
        {
            numarDeusi = 4;
        }
        public void Deschide()
        {
            Console.WriteLine("click");
        }
        public void Inchide()
        {
            Console.WriteLine("clack");
        }
    }
}
