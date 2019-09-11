using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Locação de livro");
            Console.WriteLine("Escolha uma biblioteca, digite o seu número: ");
            Console.WriteLine("Biblioteca - 01");
            Console.WriteLine("Biblioteca - 02");
            Console.WriteLine("Biblioteca - 03");

            int biblioteca01 = 01;
            int biblioteca02 = 02;
            string [] livros1 = new string[] { "01 - Matemática", " 02 - Portugûes", "03 - Inglês" };

            int biblioteca = int.Parse(Console.ReadLine());
            if (biblioteca == biblioteca01) {
                Console.WriteLine("Biblioteca 01 selecionada! ");
              //  livros1 = new string[] { "01 - Matemática", " 02 - Portugûes", "03 - Inglês" };

                Console.WriteLine("Livros disponíveis:");


                for (int i = 0; i < livros1.Length; i++) {
                    Console.WriteLine(livros1[i].ToString());
                }

            } else if (biblioteca == biblioteca02) {
                Console.WriteLine("Biblioteca 02 selecionada! ");

            } else if (biblioteca == biblioteca02) {
                Console.WriteLine("Biblioteca 03 selecionada! ");
            } else {
                Console.WriteLine("Biblioteca inválida! ");
            }

            Console.WriteLine("Escolha o livro pelo número: ");

            int escolherlivro = int.Parse(Console.ReadLine());
            for (int i = 0; i < livros1.Length; i++) {

            }
            Console.WriteLine("Livro escolhido foi " + livros1[escolherlivro-1].ToString());
            Console.WriteLine("Você quer locar esse livro? (1)SIM (2)NÃO");
            int locarLivro = int.Parse(Console.ReadLine());

            if(locarLivro == 1 || locarLivro == 2) {
                Console.WriteLine("Livro Locado!");
            }
            else { 
                Console.WriteLine("Digite o número correto!");
                
            }
        }






    }
}

