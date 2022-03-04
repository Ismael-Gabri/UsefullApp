using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraFinal.Interfaces;
using AplicationStart;

namespace CalculadoraFinal.Services 
{
    //Arrumar uma solucao para se caso o usuario nao digitar um numero (CHECK)
    //arrumar uma solucao para podermos lidar com decimais (CHECK)
    internal class OperacoesMatematicas : IOperacoesMatematicas
    {
        public double RealizarSomaPrintarResultado()
        {
            double result = 0;
            double x = 0;
            double y = 0;

            Console.Write("Primeiro número: ");

            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Segundo número: ");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    result = x + y;
                    Console.WriteLine("");
                    Console.WriteLine($"Reultado: {result}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(" _________________________");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("| Digite um número válido |");
                    Console.WriteLine("|_________________________|");

                    Console.WriteLine(" ");

                    RealizarSomaPrintarResultado();
                }
            }
            else
            {
                Console.Write("Digite um número válido\n");
                RealizarSomaPrintarResultado();
            }

            return result;
        }
        public double RealizarSubtracaoPrintarResultado()
        {
            double result = 0;
            double x = 0;
            double y = 0;

            Console.Write("Primeiro número: ");

            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Segundo número: ");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    result = x - y;
                    Console.WriteLine("");
                    Console.WriteLine($"Reultado: {result}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(" _________________________");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("| Digite um número válido |");
                    Console.WriteLine("|_________________________|");

                    Console.WriteLine(" ");

                    RealizarSomaPrintarResultado();
                }
            }
            else
            {
                Console.Write("Digite um número válido\n");
                RealizarSomaPrintarResultado();
            }

            return result;
        }
        public double RealizarMultiplicacaoPrintarResultado()
        {
            double result = 0;
            double x = 0;
            double y = 0;

            Console.Write("Primeiro número: ");

            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Segundo número: ");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    result = x * y;
                    Console.WriteLine("");
                    Console.WriteLine($"Reultado: {result}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(" _________________________");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("| Digite um número válido |");
                    Console.WriteLine("|_________________________|");

                    Console.WriteLine(" ");

                    RealizarSomaPrintarResultado();
                }
            }
            else
            {
                Console.Write("Digite um número válido\n");
                RealizarSomaPrintarResultado();
            }

            return result;
        }
        public double RealizarDivisaoPrintarResultado()
        {
            double result = 0;
            double x = 0;
            double y = 0;

            Console.Write("Primeiro número: ");

            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Segundo número: ");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    result = x / y;
                    Console.WriteLine("");
                    Console.WriteLine($"Reultado: {result}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(" _________________________");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("| Digite um número válido |");
                    Console.WriteLine("|_________________________|");

                    Console.WriteLine(" ");

                    RealizarSomaPrintarResultado();
                }
            }
            else
            {
                Console.Write("Digite um número válido\n");
                RealizarSomaPrintarResultado();
            }

            return result;
        }
    }
}
