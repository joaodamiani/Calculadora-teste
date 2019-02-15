using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Entities;
using Calculadora.Entities.Exceptions;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = ' ';
            char[] operacoes = { '+', '-', '*', '/', '^', '%' };

            try
            {
                do
                {
                    Menu(ref op);

                    if (op == '.')
                    {
                        throw new CalculadoraExceptions("Fechar programa");
                    }
                    else if (!(Array.Exists(operacoes, argumento => argumento == op)))
                    {
                        throw new CalculadoraExceptions("Operacao invalida");
                    }

                    double num1 = LerNumero();
                    double num2 = LerNumero();
                    Console.Clear();


                    if (op == '+')
                    {
                        Soma resul = new Soma(num1, num2);
                        Resultado(resul.Calcular());
                    }

                    else if (op == '-')
                    {
                        Subtracao resul = new Subtracao(num1, num2);
                        Resultado(resul.Calcular());
                    }

                    else if (op == '*')
                    {
                        Multiplicacao resul = new Multiplicacao(num1, num2);
                        Resultado(resul.Calcular());
                    }

                    else if (op == '/')
                    {
                        try
                        {
                            Divisao resul = new Divisao(num1, num2);
                            Resultado(resul.Calcular());
                        }
                        catch (CalculadoraExceptions e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                        }
                    }

                    else if (op == '^')
                    {
                        try
                        {
                            Potencia resul = new Potencia(num1, num2);
                            Resultado(resul.Calcular());
                        }
                        catch (CalculadoraExceptions e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                        }
                    }

                    else if (op == '%')
                    {
                        RestoDivisao resul = new RestoDivisao(num1, num2);
                        Resultado(resul.Calcular());
                    }


                } while (op != '.');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }

        static void Menu(ref char op)
        {
            Console.WriteLine("OPERAÇÕES");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("^");
            Console.WriteLine("%");
            Console.WriteLine(". PARA SAIR DO PROGRAMA");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("INFORME QUAL TIPO DE OPERACAO PRETENDE FAZER: ");

            op = Convert.ToChar(Console.ReadLine());


            Console.Clear();

        }

        static double LerNumero()
        {
            Console.WriteLine("Digite o numero:");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Resultado(double resul)
        {
            Console.WriteLine("RESULTADO: ");
            Console.WriteLine(resul);
            Console.WriteLine("-------------------------------------------");
            Console.Write("tecle para voltar");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
