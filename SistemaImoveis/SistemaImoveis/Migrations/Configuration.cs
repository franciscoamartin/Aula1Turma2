namespace SistemaImoveis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaImoveis.Models.ImobiliariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SistemaImoveis.Models.ImobiliariaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.GetProprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietarios()
            {
                Nome = "Francisco",
                Email = "admin@admin.com.br",
                DataNascimento = "28/02/1991"
            });

            context.Imovels.AddOrUpdate(x => x.Cep, new Models.Imovel()
            {
                Cep = "88048301",
                Logradouro = "Rua Teste",
                Municipio = "Blumenau",
                Bairro = "Centro",
                Complemento = "Casa",
                Numero = 20
            });

            context.SaveChanges();
        }

    }
}

