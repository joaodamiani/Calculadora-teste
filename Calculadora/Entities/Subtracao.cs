using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Entities
{
    class Subtracao : Calculo
    {
        public Subtracao(double Numero1, Double Numero2) : base(Numero1, Numero2)
        {

        }

        public override double Calcular()
        {
            return Numero1 - Numero2;
        }
    }
}
