using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CalculadoraFinal.Dto;

namespace CalculadoraFinal.Menus
{

    //arrumar alguns bugs dessa tela
    public class UserProfile
    {
        static UserInput userInput = new UserInput();

        public void UserMenu()
        {
            Console.Clear();

            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("| Olá, bem-vindo Menu do usuário. O que deseja fazer? |");
            Console.WriteLine("|_____________________________________________________|");

        
            Console.WriteLine("[1] Definir usuário");
            Console.WriteLine("[2] Avalie o App");

            int resposta = Int32.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    RegisterUser();
                    break;
                case 2:
                    RateApp();
                    break;
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

            Console.WriteLine(jsonString);

            Console.ReadLine();
            UserMenu();
        }

        public void RateApp()
        {
            Console.WriteLine("Avalie o app de 0 a 10");
            userInput.rate = (float)double.Parse(Console.ReadLine());

            Console.WriteLine("Comentário: ");
            userInput.comment = Console.ReadLine();

            string jsonString = JsonSerializer.Serialize(userInput);

            Console.WriteLine(jsonString);
        }
    }
}
