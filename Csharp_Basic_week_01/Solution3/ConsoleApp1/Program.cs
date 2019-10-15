using System;

namespace ConsoleApp1 {
    class Program {

        const int a = 12345;


        static void Main(string[] args) {
            var teste = string.Empty;
            String outro = string.Empty;
            bool testComp = "123" == "123";
            bool testComp1 = "123" == "123";

            teste = "teste";
            var teste1 = "String";
            var teste2 = 'c';
            var teste3 = 8;
            var teste4 = 8.0;
            var teste5 = 0x0F;

            Console.WriteLine("Teste constante: " + a);
            Console.ReadKey();

        }
    }
}
