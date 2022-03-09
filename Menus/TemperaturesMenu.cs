using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConversor.Services;
using AplicationStart;
using static AplicationStart.MenuPrincipal;

namespace TemperatureConversor.Menus
{
    class MenuTemperatura
    {
        static MainMenu menuPrincipal = new MainMenu();
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
            string de = Console.ReadLine();
            Console.Write("Para: ");
            string para = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite o valor a se converter: ");

            var valorAconverter = double.Parse(Console.ReadLine());

            double resultadoConvertido = temperaturaServices.ConversorTemperatura(de, para, valorAconverter);
            Console.WriteLine();
            Console.WriteLine($"{valorAconverter}° {de} é igual a {resultadoConvertido}° {para}");

            Console.WriteLine();
            Console.WriteLine("Retornar ao menu principal? (y/n)");
            var resposta = Console.ReadLine();

            if (resposta == "n" || resposta == "N")
                TemperatureMenu();
            else if (resposta == "y" || resposta == "Y")
                menuPrincipal.MainMenuCall();
        }
    }
}