using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class ListaCarros
    {
        public static void ListarCarros()

        {
            Console.WriteLine("Marca dos principais Carros: ");

            List<string> marcas = new List<string> { "Ford", "Tesla", "Volvo", "Fiat", "Kia", "Honda" };

            foreach (var item in marcas)

                Console.WriteLine(item);
            Console.WriteLine("--------------------------");
        }
    }
}
