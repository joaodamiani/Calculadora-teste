using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Entities.Exceptions;

namespace Calculadora.Entities
{
    class RestoDivisao : Calculo
    {
        public RestoDivisao(double numero1, double numero2) : base(numero1, numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public override double Calcular()
        {
            if (Numero2 == 0)
                throw new CalculadoraExceptions("Impossivel dividir por 0");

            return Numero1 % Numero2;
        }
    }
}
