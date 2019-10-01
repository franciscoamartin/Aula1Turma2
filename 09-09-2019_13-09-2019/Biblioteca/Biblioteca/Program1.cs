using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Locação de livro");
            Console.WriteLine("Escolha uma biblioteca, digite o seu número: ");
            Console.WriteLine("Biblioteca - 01");
            Console.WriteLine("Biblioteca - 02");
            Console.WriteLine("Biblioteca - 03");

            string[] livros1 = new string[] { "01 - Matemática", " 02 - Portugûes", "03 - Inglês" };
            string[] livros2 = new string[] { "01 - História", " 02 - Portugûes", "03 - Inglês" };
            string[] livros3 = new string[] { "01 - Inglês", " 02 - Portugûes", "03 - Inglês" };

            int biblioteca = int.Parse(Console.ReadLine());

            switch (biblioteca)
            {
                case 1:
                    Console.WriteLine("Biblioteca 01 selecionada! ");
                    Console.WriteLine("Livros disponíveis:");


                    for (int i = 0; i < livros1.Length; i++)
                    {
                        Console.WriteLine(livros1[i].ToString());
                    }

                    break;
                case 2:
                    Console.WriteLine("Biblioteca 02 selecionada! ");
                    Console.WriteLine("Livros disponíveis:");


                    for (int i = 0; i < livros2.Length; i++)
                    {
                        Console.WriteLine(livros2[i].ToString());
                    }
                    break;
                case 3:
                    Console.WriteLine("Biblioteca 03 selecionada! ");
                    Console.WriteLine("Livros disponíveis:");


                    for (int i = 0; i < livros3.Length; i++)
                    {
                        Console.WriteLine(livros3[i].ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Biblioteca inválida! ");

                    break;
            }

            Console.WriteLine("Escolha o livro pelo número: ");

            int escolherlivro = int.Parse(Console.ReadLine());
            for (int i = 0; i < livros1.Length; i++)
            {
            }
            Console.WriteLine("Livro escolhido foi " + livros1[escolherlivro - 1].ToString());
            Console.WriteLine("Você quer locar esse livro? (1)SIM (2)NÃO");
            int locarLivro = int.Parse(Console.ReadLine());

            if (locarLivro == 1 || locarLivro == 2)
            {
                Console.WriteLine("Livro Locado!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite o número correto!");
            }
        }

    }
}
