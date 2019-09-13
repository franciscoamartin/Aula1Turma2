using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03
{
    class Atividade
    {

        static void Main(string[] args)
        {
            ShowMessage();
            string nome = string.Empty;
            int idade = 0;

            while (PerguntaInicial() == 1)
            {
                nome = QualSeuNome();
                idade = QualSuaIdade(nome);


            }
            Console.WriteLine($"Suas informações são: Seu nome é {nome} com {idade} idade");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowMessage()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        /// <summary>
        /// metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido.</returns>
        private static int PerguntaInicial()
        {
            Console.WriteLine("Você quer cadastrar? (1)SIM (2)NÃO");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

        private static int QualSuaIdade(string name)
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
        private static string QualSeuNome()
        {
            Console.WriteLine("Qual seu nome? ");
            return Console.ReadLine();
        }

       
    }
}

