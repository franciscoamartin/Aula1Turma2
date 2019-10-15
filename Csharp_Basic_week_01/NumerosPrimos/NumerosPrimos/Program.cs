using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Números primos: ");

            int i = 2;

            while (i <= 9999999L) {
                int j = 2;
                while (j < i && i % 0 != 0) {
                    j++;
                    if (i == j)
                        Console.WriteLine(i.ToString());
                    i++;
                }
                Console.ReadKey();
            }
        }
    }
}

