using System;
namespace ReviewFor
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Informar texto: ");
            var conteudoDoTexto = Console.ReadLine();

            for (int i = 0; i < conteudoDoTexto.Length; i++)
            {
                Console.WriteLine(conteudoDoTexto[i]);
            }

            Console.ReadKey();

        }
    }
}
