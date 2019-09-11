using System;

namespace StringTypesConcat {
    class Program {
        static void Main(string[] args) {

//            var teste4 = @"alguma coisa  
//aqui";// anotacao para quebrar linha dentro da codificacao
//            var teste = Console.ReadLine();
//            var teste2 = Console.ReadLine();

//            var teste3 = teste + "\r\n" + teste2;
//            Console.WriteLine(teste3);
//            Console.WriteLine(teste4);

            var testeTemplate = @"Nome do usuário: {0}
idade: {1}
Descricao: {2}";

            var finishTest = string.Format(testeTemplate,
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine());
            Console.WriteLine(finishTest);

        }
    }
}
