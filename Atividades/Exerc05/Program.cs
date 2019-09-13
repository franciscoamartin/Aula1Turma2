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
            int resultado = palavra.IndexOf(palavra, 2);
            
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
