using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaDeCervejas { get; set; }
        public int IDParam { get; set; } = 100;

        //adicionando cervejas na lista
        public SistemaCervejaContext()
        {
            ListaDeCervejas = new List<Cerveja>();

            ListaDeCervejas.Add(new Cerveja { Id = IDParam++, Nome = "Brahma", Litros = 1, Alcool = 5, Valor = 3.5 });
            ListaDeCervejas.Add(new Cerveja { Id = IDParam++, Nome = "Skol", Litros = 0.600, Alcool = 5, Valor = 5 });
            ListaDeCervejas.Add(new Cerveja { Id = IDParam++, Nome = "Corona", Litros = 0.355, Alcool = 5, Valor = 4 });
            ListaDeCervejas.Add(new Cerveja { Id = IDParam++, Nome = "Budweiser", Litros = 0.355, Alcool = 5, Valor = 2.75 });
            ListaDeCervejas.Add(new Cerveja { Id = IDParam++, Nome = "Bohemia", Litros = 0.350, Alcool = 5, Valor = 4.5 });
        }
        public List<Cerveja> ListaVendas { get { return ListaDeCervejas; } }

    }
}
