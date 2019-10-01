using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Informe o livro a ser consultado: ");
            var consulta = Console.ReadLine();
            if (consulta == "123456") {
                Console.WriteLine("Não disponível");
                Console.ReadKey();

                return;
            } else {
                Console.WriteLine("Deseja alocar o livro (1)Sim (2)Não");
                var resposta = Console.ReadLine();
                if (resposta == "1") {
                    Console.WriteLine("Livro alocado");
                    Console.ReadKey();
                    //finaliza o metodo.
                    return;


                }
            }
        }

    }
}