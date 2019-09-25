using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Joao",
                "Maria",
                "Carlos"
            };

            //no aggregate temos o nome atual que estamos lendo e o proximo nome da lista.
            var texto = listaDeNomes.Aggregate((nome1, nome2) => nome1 + ";\r\n" + nome2);
            //no passo sequinte temos o nome proximo vira o atual
            //e pega o proximo da lista apos o atual
            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
