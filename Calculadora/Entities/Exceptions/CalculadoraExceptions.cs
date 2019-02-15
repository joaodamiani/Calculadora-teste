using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Entities;

namespace Calculadora.Entities.Exceptions
{
    class CalculadoraExceptions : Exception
    {
        public CalculadoraExceptions(string msg) : base(msg)
        {

        }
    }
}
