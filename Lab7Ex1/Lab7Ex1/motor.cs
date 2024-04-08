using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex1
{
    //am facut o clasa separata "motor" cu urmatoarele caracteristici
    // capacitate cilindrica
    // putere
    // tipul combustibilului
    internal class Motor
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
        
    }
}
