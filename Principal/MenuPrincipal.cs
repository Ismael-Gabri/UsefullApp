using System;
using CalculadoraFinal.Services;
using CalculadoraFinal.Menus;
using TemperatureConversor.Menus;

namespace AplicationStart
{
    //Arrumar uma solucao para se caso o usuario nao digitar um numero (CHECK)
    //arrumar uma solucao para podermos lidar com decimais (CHECK)
    //Fazer a parte da Calculadora (CHECK)
    //Fazer o menu principal (CHECK)
    //Fazer uma parte para Calculo de celcius, Fareheints... (DOING)
    //Fazer uma parte para converter Cm, M... TODO
    public class MenuPrincipal
    {
        static MainMenu mainMenuCall = new MainMenu();
        static CalculatorsMenu menuCalculadora = new CalculatorsMenu();
        static MenuTemperatura menuTemperatura = new MenuTemperatura();
        static void Main(string[] args)
        {
            mainMenuCall.MainMenuCall();
        }

        public class MainMenu
        {
            public void MainMenuCall()
            {
                Console.Clear();

                Console.WriteLine(" ______________________________________________________");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("| Olá, bem-vindo ao UsefullApp. O que deseja fazer?    |");
                Console.WriteLine("|______________________________________________________|");

                Console.WriteLine(" ");

                Console.WriteLine("[1] Calculadora");
                Console.WriteLine("[2] Conversor de temperatura");

                Console.WriteLine();

                Console.WriteLine("[3] Sair do App");

                Console.WriteLine(" ");

                Console.Write("Resposta: ");
                var resposta = Console.ReadLine();

                bool ehInt = int.TryParse(resposta, out int respostaParse);

                if (ehInt)
                {
                    switch (respostaParse)
                    {
                        case 1:
                            menuCalculadora.MenuCalculadora();
                            break;
                        case 2:
                            menuTemperatura.TemperatureMenu();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine(" ");
                            Console.WriteLine("Digite uma opção válida");
                            Console.WriteLine(" ");
                            Console.WriteLine("Retornando ao menu principal...");
                            System.Threading.Thread.Sleep(7000);
                            MainMenuCall();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Atenção: Digite apenas números. Sua resposta foi: {resposta}");
                    Console.WriteLine(" ");
                    Console.WriteLine("Retornando ao menu principal...");
                    System.Threading.Thread.Sleep(7000);
                    MainMenuCall();
                }
            }
        }
    }
}