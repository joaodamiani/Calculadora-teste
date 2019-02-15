using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Entities
{
    class Potencia : Calculo
    {

        public Potencia(double numero1, double numero2) : base(numero1, numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }


        public override double Calcular()
        {
            return Math.Pow(Numero1, Numero2);
        }
    }
}
