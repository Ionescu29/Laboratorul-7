using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex2
{
    //Motorul este caracterizate de:
    //capacitate cilindrica
    //putere 
    //tip de combustibil
    //motorul are functii pentru:
    //Pornirea Motorului (la apelul acestei functii motorul va afisa in consola “brr”)
    //Oprirea Motorului (la apelul acestei functii motorul va afisa in consola “"par poc pac"")
    internal class motor
    {
        private int capacitateCilindrica;
        private int putere;
        private string tipulCombustibilului;
        public Motor(int capacitateCilindrica, int putere, string tipulCombustibilului)
        {
            capaciateCilindrica = 2000;
            putere = 150;
            tipulCombustibilului = "motorina";
        }
        public void PornireaMasina()
        {
            Console.WriteLine("BRR");
        }
        public void OprireaMasina()
        {
            Console.WriteLine("par poc pac");
        }
    }
}
