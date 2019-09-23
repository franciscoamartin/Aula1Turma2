using CestoDeFrutas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruta> cestaDeFrutas = new List<Fruta>();

            //vamos no mercado

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 3,
                Nome = "Manga",
                Cor = "Amarela",
                Peso = 380
            });

            #region lista 1
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));
            Console.WriteLine("----------------------Nome");
            #endregion
            #region lista 2

            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));
            Console.WriteLine("----------------------Peso");
            #endregion
            #region lista 3

            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>().ForEach(x => Console.WriteLine($"Id: {x.Id} - Nome: {x.Nome} - Peso: {x.Peso}"));
            #endregion
            Console.WriteLine("----------------------Peso");

            #region lista 4

            (from frutinhas in cestaDeFrutas
             where frutinhas.Peso > 100
             select frutinhas).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));
            //percorre lista, filtra por peso e imprime por nome 
            #endregion


            Console.WriteLine("---------filtro por cor Amarelo/Vermelho - Find------------");

            //busca com find
            var mostrandoFind = cestaDeFrutas.Find(x => x.Cor == "Amarela" || x.Cor == "Vermelho");
            Console.WriteLine($"ID {mostrandoFind.Id} Nome {mostrandoFind.Nome}");

            Console.WriteLine("---------filtro por cor Amarelo/Vermelho- FindAll-----------");

            //busca com findall
            var mostrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amarela" || x.Cor == "Vermelho");
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} cor {i.Cor}"));


            Console.WriteLine("---------filtro ordenada------------");

            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");

            Console.WriteLine("--------Filtro amarela-------------");

            (from frutinhas in cestaDeFrutas
             where frutinhas.Cor == "Amarela"
             select frutinhas).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida {i.Cor}"));

            Console.WriteLine("--------Find com orderBy-------------");

            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome)
                .ToList<Fruta>()
                .Find(x => x.Cor == "Amarela" || x.Cor == "Vermelho");

            Console.WriteLine($"ID {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");

           
        }
    }
}
