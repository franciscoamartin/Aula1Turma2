using System.Collections.Generic;
using System;
using System.Threading;

namespace AprendendoOList
{
    class Program
    {
        static List<string> list = new List<string>() {

                "francisco",
                "Irineu",
                "Serilope"
             };

        static void Main(string[] args)
        {
            AdicionarItensALista();
            ListaInformacoes();
            Console.ReadKey();
        }
        /// <summary>
        /// metodo que adiciona um item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome");
            var nome = Console.ReadLine();
            list.Add(nome);
            Console.WriteLine(nome + " adicionado na lista");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Deseja informar mais um nome? (s)SIM (n)NÃO ");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
            {
                AdicionarItensALista();

            }
        }
        /// <summary>
        /// metodo que mostra a lista
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.WriteLine("Nomes Adicionados na Lista");

            foreach (var minhaLista in list)
            {
                Console.WriteLine(minhaLista);
            }
        }

    }
}
