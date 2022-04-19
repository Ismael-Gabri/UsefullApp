using System;
using CalculadoraFinal.Services;
using CalculadoraFinal.Menus;
using TemperatureConversor.Menus;

namespace AplicationStart
{
    //Fazer uma parte para converter Cm, M... TODO

    public class MenuPrincipal
    {
        static MainMenu mainMenuCall = new MainMenu();
        static CalculatorsMenu menuCalculadora = new CalculatorsMenu();
        static MenuTemperatura menuTemperatura = new MenuTemperatura();
        static UserProfile userProfile = new UserProfile();
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
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("[3] Perfil");
                Console.WriteLine("[4] Sair do App");

                Console.WriteLine(" ");

                Console.Write("Resposta: ");
                int resposta;
                if (int.TryParse(Console.ReadLine(), out resposta))
                {
                    switch (resposta)
                    {
                        case 1:
                            menuCalculadora.MenuCalculadora();
                            break;
                        case 2:
                            menuTemperatura.TemperatureMenu();
                            break;
                        case 3:
                            userProfile.UserMenu();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("[!] Digite uma opcao válida [!]");
                            System.Threading.Thread.Sleep(3000);
                            MainMenuCall();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("[!] Digite uma opcao válida [!]");
                    System.Threading.Thread.Sleep(3000);
                    MainMenuCall();
                }
            }
        }
    }
}