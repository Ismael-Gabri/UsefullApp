using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraFinal.Services;
using AplicationStart;
using static AplicationStart.MenuPrincipal;

//resolver o problema da resposta inválida para o menu temperatura;
//trocar de branch;
//Fazer conversor de centimetros, metros, mm;
//trocar de branch;
//montar interface de opcoes para o menu temperatura mostrando as opcoes disponíveis;
//trocar de branch
//montar uma interface colorida e mais agradável (Ver na NET como faz)

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
            Console.WriteLine("[5] Sair para o menu principal");
            Console.WriteLine("[6] Sair");
            Console.WriteLine("");
            Console.Write("Opcao: ");
            bool ehInt = int.TryParse(Console.ReadLine(), out var x);

            if(ehInt == true)
            {
                switch (x)
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
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Essa opcao nao está disponível");
                        Console.WriteLine(" ");
                        Console.WriteLine("Retornando ao menu...");
                        System.Threading.Thread.Sleep(7000);
                        MenuCalculadora();
                        break;
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Atenção: Digite apenas números.");
                Console.WriteLine(" ");
                Console.WriteLine("Retornando ao menu...");
                System.Threading.Thread.Sleep(7000);
                MenuCalculadora();
            }
        }
    }
}
