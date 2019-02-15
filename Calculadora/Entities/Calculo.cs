using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Entities
{
    abstract class Calculo
    {
        
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculo(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }


        public abstract double Calcular();
        
    }
}
