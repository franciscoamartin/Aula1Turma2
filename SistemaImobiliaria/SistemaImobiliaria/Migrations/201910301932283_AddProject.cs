namespace SistemaImobiliaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.String(),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        ProprietarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proprietarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietarios");
            DropTable("dbo.Imovels");
        }
    }
}
