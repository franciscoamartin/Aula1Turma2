namespace ImoveisProprietarios.Migrations
{
    using ImoveisProprietarios.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ImoveisProprietarios.Models.ImobiliariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ImoveisProprietarios.Models.ImobiliariaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var listProprietarios = new List<Proprietarios>()
            {
                new Proprietarios()
                {
                    Nome = "Francisco",
                    Email = "teste@teste.com",
                    DataNascimento = DateTime.Now
                },

                new Proprietarios()
                {
                    Nome = "Teste2",
                    Email = "teste2@teste.com",
                    DataNascimento = DateTime.Now
                }
            };


            listProprietarios.ForEach(s => context.Proprietarios.AddOrUpdate(x => x.Nome, s)
            );
            context.SaveChanges();

            var listaImoveis = new List<Imoveis>()
            {
                new Imoveis()
                {
                Cep = "88048301",
                Bairro = "Centro",
                Municipio = "Blumenau",
                Complemento = "casa",
                Numero = "200",
                Logradouro = "Rua teste",
                ProprietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Francisco").Id

                },

                new Imoveis()
                {
                Cep = "88048300",
                Bairro = "Centro",
                Municipio = "Blumenau",
                Complemento = "casa",
                Numero = "20",
                Logradouro = "Rua teste2",
                ProprietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Teste2").Id

                }
            };

            listaImoveis.ForEach(s => context.Imoveis.AddOrUpdate(x => new { x.ProprietarioId, x.Cep }, s)
           );

            context.SaveChanges();
        }
    }
}
