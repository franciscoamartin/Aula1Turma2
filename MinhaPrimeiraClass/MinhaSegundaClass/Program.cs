using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaSegundaClass.Model;

namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var minhaCestaFrutas = new List<Frutas>();

            minhaCestaFrutas.Add(new Frutas
            {
                NomeFruta = "Laranja",
                QuantidadeFruta = 20
            }); ;

            minhaCestaFrutas.Add(new Frutas
            {
                NomeFruta = "Maça",
                QuantidadeFruta = 10

            }); ;

            minhaCestaFrutas.ForEach(i => Console.WriteLine($"Cesta de Frutas > Fruta: {i.NomeFruta} Quantidade: {i.QuantidadeFruta}"));

            Console.ReadKey();
        }
    }
}
