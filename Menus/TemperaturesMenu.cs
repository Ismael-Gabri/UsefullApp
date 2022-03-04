using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConversor.Services;

namespace TemperatureConversor.Menus
{
    class MenuTemperatura
    {
        static TemperaturaServices temperaturaServices = new TemperaturaServices();
        public void TemperatureMenu()
        {
            Console.Clear();

            Console.WriteLine(" __________________________________________________________________________");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Olá, bem-vindo ao conversor de temperatura. Qual conversão deseja fazer? |");
            Console.WriteLine("|__________________________________________________________________________|");

            Console.WriteLine("");

            Console.Write("Converter de: ");
            var de = Console.ReadLine();
            Console.Write("Para: ");
            var para = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite o valor a se converter: ");

            var valorAconverter = double.Parse(Console.ReadLine());

            double resultadoConvertido = temperaturaServices.ConversorTemperatura(de, para, valorAconverter);
            Console.WriteLine($"{valorAconverter}° {de} é igual a {resultadoConvertido}° {para}");
        }
    }
}