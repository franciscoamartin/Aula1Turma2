using System;
using static MetodosPublicos.Program;

namespace ConversorMonetario
{
    class Program
    {
        static void Main(string[] args)
        {
            EntradaDeDados(); //chamar classe externa 

            //ao inves de implementar abaixo apenas chamar a classe acima

            //Console.WriteLine("Informe o valor em Reais para conversão: ");
            //var meuValor = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o tipo para conversão: ");
            //Console.WriteLine("EURO, DOLAR, IENE, BTC");

            //var meuAlvo = Console.ReadLine().ToUpper();

            //MetodosPublicos.Program.ConverterMoeda(meuValor, meuAlvo);
            Console.ReadKey();

        }
    }
}
