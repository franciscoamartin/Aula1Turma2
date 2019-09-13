using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto: ");
            var content = Console.ReadLine();

            while (content != "banana")
            {
                Console.WriteLine("Digite outra palavra");
                content = Console.ReadLine();
            }
            Console.WriteLine(content.Replace("banana", "laranja "));
            Console.ReadKey();

        }
    }
}
    

