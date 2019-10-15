using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaPrimeiraClass.Model;

namespace MinhaPrimeiraClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeBicicletas = new List<Bicicleta>();

            listaDeBicicletas.Add(new Bicicleta()
            {
             Marca = "Monark"

            });

            listaDeBicicletas.Add(new Bicicleta()
            {
                Marca = "Caloi"

            });

            listaDeBicicletas.ForEach(i => Console.WriteLine($"BikeOn > Marca: {i.Marca} Pneus: {i.Pneus}"));
         



            Console.ReadKey();
        }
    }
}
