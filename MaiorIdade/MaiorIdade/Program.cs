using System;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaNomes();
        }

        private static void ConsultaNomes()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            ListarInformacoes(conteudo);

            Console.ReadKey();
        }

        private static void ListarInformacoes(string conteudo)
        {
            var listaDeInformacoes = conteudo.Split(';');

            foreach (var item in listaDeInformacoes)
            {
                var separandoInformacoes = item.Split(',');
                var nomePessoa = separandoInformacoes[0].Split(':')[1];
                var idade = separandoInformacoes[1].Split(':')[1];
                if (int.Parse(idade) >= 18)

                    Console.WriteLine($"{nomePessoa} com {idade} anos de idade é uma pessoa maior de (+18). "
                        );

            }
        }

    }
}