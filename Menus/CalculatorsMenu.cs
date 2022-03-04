using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraFinal.Services;
using AplicationStart;
using static AplicationStart.MenuPrincipal;

namespace CalculadoraFinal.Menus
{
    public class CalculatorsMenu
    {
        static MainMenu mainMenuCall = new MainMenu();
        static OperacoesMatematicas operacoesMatematematicas = new OperacoesMatematicas();
        public void MenuCalculadora()
        {
            Console.Clear();

            Console.WriteLine(" ___________________________________________________________");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("| Olá, bem-vindo a calculadora. Qual operacao deseja fazer? |");
            Console.WriteLine("|___________________________________________________________|");

            Console.WriteLine("");

            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtracao");
            Console.WriteLine("[3] Multiplicacao");
            Console.WriteLine("[4] Divisao");
            Console.WriteLine("");
            Console.WriteLine("[5] Sair para o menu principal"); //N funciona ainda
            Console.WriteLine("[6] Sair");
            Console.WriteLine("");
            Console.Write("Opcao: ");
            var respostaOperacao = Double.Parse(Console.ReadLine());

            switch (respostaOperacao)
            {
                case 1:
                    operacoesMatematematicas.RealizarSomaPrintarResultado();
                    break;
                case 2:
                    operacoesMatematematicas.RealizarSubtracaoPrintarResultado();
                    break;
                case 3:
                    operacoesMatematematicas.RealizarMultiplicacaoPrintarResultado();
                    break;
                case 4:
                    operacoesMatematematicas.RealizarDivisaoPrintarResultado();
                    break;
                case 5:
                    mainMenuCall.MainMenuCall();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
