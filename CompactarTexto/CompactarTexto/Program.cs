using System;

namespace CompactarTexto {
    class Program {
        static void Main(string[] args) {

            var primeiroTexto = "Lorem ipsun Lorem ipsunLorem ipsun Lorem ipsun Lorem ipsun Lorem ipsun Lorem ipsun ";

            Console.WriteLine($"Texto ontem: {primeiroTexto.Length} caracteres.");
            Console.WriteLine(primeiroTexto);

            primeiroTexto = primeiroTexto
                .Replace("Lorem", "1")
                .Replace("ipsun", "2")
                .Replace("2","eu")
                .Replace(" ", "");

            Console.WriteLine($"Texto hoje: {primeiroTexto.Length} caracteres.");
            Console.WriteLine(primeiroTexto);

            Console.ReadKey();
        }

    }
}
