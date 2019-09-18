using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListaCervejas
    {

        public static void Cervejas() { 
        List<string> cervejas = new List<string> { "Skol", "Brahma", "Antarctica", "Patagonia", "Stella Artois", "Skol", "Polar" };
        Console.WriteLine("Marcas de Cervejas AMBEV: ");

            foreach (var item in cervejas)

                Console.WriteLine(item);
            Console.WriteLine("--------------------------");
       }
    }
}
