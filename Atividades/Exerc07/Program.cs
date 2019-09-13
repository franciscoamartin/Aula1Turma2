using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();

            string[] contadorDePalavras = new string[] { "a", "e", "i", "o", "u" };
            int i = 0;
            string a = "a";
            int buscar = BuscaPor(texto, a);

            for (i = 0; i < contadorDePalavras.Length; i++)
            {
                string contador = contadorDePalavras[i];
               Console.WriteLine($"números de palavras '{contadorDePalavras[i]}' é {buscar}");
            }


            Console.ReadKey();
        }

        

        private static int BuscaPor(string text,string textb)
        {
            var contentToFind = text;
            var wordFindCountLength = textb.Length;
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

                if (textb == compareWord)
                    contWordFind++;
                i++;

            }
            return contWordFind;
        }
    }
}

