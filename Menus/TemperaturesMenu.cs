using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversor.Menus
{
    class MenuTemperatura
    {
        public void TemperatureMenu()
        {
            Console.Clear();

            Console.WriteLine(" __________________________________________________________________________");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Olá, bem-vindo ao conversor de temperatura. Qual conversão deseja fazer? |");
            Console.WriteLine("|__________________________________________________________________________|");

            Console.WriteLine("");

            Console.Write("Converter de: ");
            var De = Console.ReadLine();
            Console.Write("Para: ");
            var Para = Console.ReadLine();
        }
    }
}