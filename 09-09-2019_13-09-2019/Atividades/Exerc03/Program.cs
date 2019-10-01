using System;

namespace Exerc03
{
    class Atividade
    {
        static void Main(string[] args)
        {
            ShowMessage();
            string nome = string.Empty;
            int idade = 0;

            nome = QualSeuNome();
            idade = QualSuaIdade(nome);

            Console.ReadKey();

        }
        /// <summary>
        /// Metodo para mostrar o texto inicial
        /// </summary>
        private static void ShowMessage()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        /// <summary>
        /// metodo para perguntar o nome
        /// </summary>
        /// <returns>retorna o nome informado</returns>
        private static string QualSeuNome()
        {
            Console.WriteLine("Qual seu nome? ");
            return Console.ReadLine();
        }

        private static int QualSuaIdade(string name)
        {
            Console.WriteLine("Qual é a sua idade? ");
            int resultAge = int.Parse(Console.ReadLine());
            if (resultAge >= 18)
                Console.WriteLine($" Parabéns {name} você já está na fase adulta. ");
            else
                Console.WriteLine($"Calma {name} tudo ao seu tempo logo você terá 18 anos de idade.");
            return resultAge;
        }

    }
}

