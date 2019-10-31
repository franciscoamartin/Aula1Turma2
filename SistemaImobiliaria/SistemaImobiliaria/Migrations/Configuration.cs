namespace SistemaImobiliaria.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SistemaImobiliaria.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaImobiliaria.Models.ImobiliariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ImobiliariaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var listProprietarios = new List<Proprietario>()
            {
                new Proprietario()
                {
                    Nome = "Francisco",
                    Email = "teste@teste.com",
                    DataNascimento = "28/02/1991"
                },

                new Proprietario()
                {
                    Nome = "Teste2",
                    Email = "teste2@teste.com",
                    DataNascimento = "20/02/1991"
                }
            };


            listProprietarios.ForEach(s => context.GetProprietarios.AddOrUpdate(x => x.Nome, s)
            );
            context.SaveChanges();

            var listaImoveis = new List<Imovel>()
            {
                new Imovel()
                {
                Cep = "88048301",
                Bairro = "Centro",
                Municipio = "Blumenau",
                Complemento = "casa",
                Numero = 20,
                Logradouro = "Rua teste",
                ProprietarioId = context.GetProprietarios.FirstOrDefault(x => x.Nome == "Francisco").Id

                },
          
                new Imovel()
                {
                Cep = "88048300",
                Bairro = "Centro",
                Municipio = "Blumenau",
                Complemento = "casa",
                Numero = 20,
                Logradouro = "Rua teste2",
                ProprietarioId = context.GetProprietarios.FirstOrDefault(x => x.Nome == "Teste2").Id

                }
            };

            listaImoveis.ForEach(s => context.GetImovels.AddOrUpdate(x => new { x.ProprietarioId, x.Cep }, s)
           );

            context.SaveChanges();

            //context.GetProprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario()
            //{
            //    Nome = "Francisco",
            //    Email = "admin@admin.com.br",
            //    DataNascimento = "28/02/1991"
            //});
            //context.GetImovels.AddOrUpdate(x => x.Cep, new Models.Imovel()
            //{
            //    Cep = "88048301",
            //    Bairro = "Centro",
            //    Municipio = "Blumenau",
            //    Complemento = "casa",
            //    Numero = 20,
            //    Logradouro = "Rua teste"

            //});


            //context.SaveChanges();
        }

    }
}
