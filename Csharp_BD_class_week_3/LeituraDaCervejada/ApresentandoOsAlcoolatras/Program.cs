using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaControler listagemDeCervejas = new CervejaControler();

        static void Main(string[] args)
        {

            listagemDeCervejas.AdicionarCerveja(new Cerveja()
            {
                Id = listagemDeCervejas.ListagemDeCervejas().Count + 1,
                Nome = "Giomar",
                Litros = 0.600,
                Alcool = 7.2,
                Valor = 0.98
            });

            listagemDeCervejas.ListagemDeCervejas().ForEach(x => Console.WriteLine($" ID: {x.Id} Nome: {x.Nome} Valor: {x.Valor} Litro: {x.Litros} Alcool: {x.Alcool}"));

            Console.WriteLine("Total litros " + listagemDeCervejas.VolumeCerveja());
            Console.WriteLine("Total Valor " + listagemDeCervejas.ValorTotalCerveja());

            Console.ReadKey();
        }
    }
}
