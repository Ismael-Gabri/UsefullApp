using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CalculadoraFinal.Dto;
using static AplicationStart.MenuPrincipal;

namespace CalculadoraFinal.Menus
{

    //arrumar alguns bugs dessa tela
    public class UserProfile
    {
        static UserInput userInput = new UserInput();
        static MainMenu menuPrincipal = new MainMenu();

        public void UserMenu()
        {
            Console.Clear();

            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("| Olá, bem-vindo Menu do usuário. O que deseja fazer? |");
            Console.WriteLine("|_____________________________________________________|");

            Console.WriteLine();
            Console.WriteLine("[1] Definir usuário");
            Console.WriteLine("[2] Avalie o App");
            Console.WriteLine();

            Console.WriteLine("[3] Sair para o menu principal");


            Console.WriteLine();
            Console.Write("Resposta: ");

            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        RegisterUser();
                        break;
                    case 2:
                        RateApp();
                        break;
                    case 3:
                        menuPrincipal.MainMenuCall();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("[!] Digite uma opcao váldia [!]");
                        System.Threading.Thread.Sleep(5000);
                        UserMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("[!] Digite apenas uma das opcoes fornecidas [!]");
                System.Threading.Thread.Sleep(5000);
                UserMenu();
            }
        }

        public void RegisterUser()
        {
            Console.Clear();

            Console.WriteLine(" __________________");
            Console.WriteLine("|                  |");
            Console.WriteLine("| Tela de registro |");
            Console.WriteLine("|__________________|");

            Console.WriteLine("");

            //register
            Console.Write("Nome: ");
            userInput.firstName = Console.ReadLine();
            Console.Write("Sobrenome: ");
            userInput.secondName = Console.ReadLine();
            Console.Write("Senha: ");
            userInput.password = Console.ReadLine();

            userInput.rate = null;

            //serealizar objeto do usuário
            string jsonString = JsonSerializer.Serialize(userInput);

            Console.WriteLine();
            Console.WriteLine("------------Json------------ ");

            Console.WriteLine("");
            Console.WriteLine(jsonString);
            Console.WriteLine("");
            Console.WriteLine("---------------------------- ");

            Console.WriteLine("");
            Console.WriteLine("Aperte enter para retomar");
            Console.ReadLine();
            UserMenu();
        }

        public void RateApp()
        {
            Console.WriteLine();
            Console.WriteLine("Avalie o app de 0 a 10");
            Console.Write("sua nota: ");
            userInput.rate = (float)double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Comentário: ");
            userInput.comment = Console.ReadLine();

            string jsonString = JsonSerializer.Serialize(userInput);
            Console.WriteLine(jsonString);
        }
    }
}
