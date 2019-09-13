using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07Version01
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra: ");
            var wordCount = Console.ReadLine();
            for (int i = 0; i <= 5; i++)
            {


                var result = FindByFor(wordCount);
                Console.WriteLine($"Número de palavras: {result}");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Metodo de busca dentro da aplicacao
        /// </summary>
        /// <param name="wordFind">Paramentro de ate 3 caracteres </param>
        /// <returns>Retorna a quantidade encontrada da expressao</returns>
        private static int FindByFor(string wordFind)
        {
            var contentToFind = TextContent();
            var wordFindCountLength = wordFind.Length;
            var lengthText = contentToFind.Length - (wordFindCountLength - 1);
            var contWordFind = 0;

            for (int i = 0; i < lengthText; i++)
            {
                var compareWord = string.Empty;
                var b = 0;
                while (b < wordFindCountLength)
                {
                    compareWord += contentToFind[i + b].ToString();
                    b++;
                }

                if (wordFind == compareWord)
                    contWordFind++;
            }
            return contWordFind;
        }

        private static int FindByWhile(string wordFind)
        {

            var contentToFind = TextContent();
            var wordFindCountLength = wordFind.Length;
            var lengthText = contentToFind.Length - (wordFindCountLength - 1);
            var i = 0;
            var contWordFind = 0;


            while (i < lengthText)
            {
                var compareWord = string.Empty;
                var b = 0;
                while (b < wordFindCountLength)
                {
                    compareWord += contentToFind[i + b].ToString();
                    b++;
                }

                if (wordFind == compareWord)
                    contWordFind++;
                i++;

            }
            return contWordFind;
        }

        /// <summary>
        /// esse metodo retorna um texto para analisar
        /// </summary>
        /// <returns> conteudo do texto em string</returns>
        private static void  TextContent()
        {
            string[] contadorDePalavras = { "a", "e", "i", "o", "u" };
            int i = 0;

            for (i = 0; i < contadorDePalavras.Length; i++)
            {
                string contador = contadorDePalavras[i];
                 Console.WriteLine($"números de palavras '{contadorDePalavras[i]}'");



            }
        }

    }
}

