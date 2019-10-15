using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            var quantidade = palavra.Length;

            var inicio = palavra.Substring(0, 1);
            var final = palavra.Substring(quantidade - 1, 1);

            Console.WriteLine("Primeiro caractere é ' " + inicio + " '");
            Console.WriteLine("Último caractere é ' " + final + " '");
            Console.ReadKey();
        }
    }
}
