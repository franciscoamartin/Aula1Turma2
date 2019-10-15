using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxogramaPneu {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Troca de pneu");
            Console.WriteLine("Você tem step? Sim(1) Não(2) ");
            int pergunta = int.Parse(Console.ReadLine());

            if(pergunta == 1) {
                Console.WriteLine("Siga os passos abaixo");
                if () {

                }
            } else if(pergunta == 2) {
                Console.WriteLine("Chame o socorro - guincho");

            } else {
                Console.WriteLine("Digite o valor válido!");
            }
        }
    }
}
