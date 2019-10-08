using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {

        // 1 - setar a aplicacao visual para startar o projeto
        // 2 - adicionar EntityFramework ao nosso projeto console. nuget
        // 3 - adicionar using System.Data.Entity;
        // 4 - adicionar a refrencia da nossa ClassLibrary

        //static CervejaContextDb Cerveja = new CervejaContextDb();
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {

            //Cerveja.Cervejas.Add(new Cerveja() { Nome = "Golimar" });
            //Cerveja.SaveChanges();
            //Cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            cerveja.AddCerveja(new Cerveja()
            {
                Nome = "Cerveja Skol"
            });

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
               
        }
    }
}
