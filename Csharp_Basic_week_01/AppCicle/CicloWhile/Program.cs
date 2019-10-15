using System;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();
            string nome = string.Empty;
            int idade = 0;
            char sexo = char.MinValue;
            string description = string.Empty;

            while (AskToContinue() == 1)
            {
                nome = AskToName();
                idade = AskYourAge(nome);
                sexo = AskGenger(sexo);
                description = Description(description);


            }
            Console.WriteLine($"Suas informações são:{nome} com {idade} idade e seu genêro é {sexo} sua descrição é {description}");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        /// <summary>
        /// metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido.</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? (1)SIM (2)NÃO");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

        private static int AskYourAge(string name)
        {
            Console.WriteLine("Qual é a sua idade? ");
            int resultAge = int.Parse(Console.ReadLine());
            if (resultAge >= 18)
                Console.WriteLine($"{name} Você pode beber!");
            else
                Console.WriteLine("Você NÃO pode beber!");
            return resultAge;
        }
        /// <summary>
        /// metodo para perguntar o nome
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string AskToName()
        {
            Console.WriteLine("Qual seu nome? ");
            return Console.ReadLine();
        }

        private static char AskGenger(char sexo)
        {
            Console.WriteLine("Qual seu Sexo? ");
            return char.Parse(Console.ReadKey().KeyChar.ToString());
        }

        private static string Description(string description)
        {
            Console.WriteLine("Faça uma descrição: ");
            return Console.ReadLine();
        }
    }
}
