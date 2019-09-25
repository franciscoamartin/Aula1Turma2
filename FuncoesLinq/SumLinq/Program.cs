using System;
using System.Collections.Generic;
using System.Linq;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteirosPrimitivos();
            SomaDeInteiros();
            SomaBalaListaDeCrianca();
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteirosPrimitivos()
        {
            //a quantidade de memoria que vamos ocupar
            //memoriaOcupadaInt * quantidadeInformada(int*5)
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(colecaoInteiros.Sum());
        }

        /// <summary>
        ///Metodo que soma valores em uma lista
        /// </summary>
        private static void SomaDeInteiros()
        {
            {
                List<int> listaDeInteiros = new List<int>() {

                1,2,3,4,5,6,7
            };

                Console.WriteLine(listaDeInteiros.Sum());
            }
        }

        /// <summary>
        /// Metodo que soma a quantidade de bala das crianças 
        /// </summary>
        private static void SomaBalaListaDeCrianca()
        {

            List<Crianca> criancas = new List<Crianca>()
            {
            new Crianca()
            {
                Nome = "Joaozinho",
                Balas = 9
            },

            new Crianca()
            {
                Nome = "Pedrinho",
                Balas = 68
            }
            };
            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda");
            Console.WriteLine();
            Console.WriteLine(criancas.Sum(x => x.Balas));
        }

    }
}



