namespace SistemaImobiliaria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaImobiliaria.Models.ImobiliariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SistemaImobiliaria.Models.ImobiliariaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.GetProprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietario()
            {
                Nome = "Francisco",
                Email = "admin@admin.com.br",
                DataNascimento = "28/02/1991"
            });
            context.GetImovels.AddOrUpdate(x => x.Cep, new Models.Imovel()
            {
                Cep = "88048301",
                Bairro = "Centro",
                Municipio = "Blumenau",
                Complemento = "casa",
                Numero = 20,
                Logradouro = "Rua teste"
            });

            context.SaveChanges();
        }

    }
}
