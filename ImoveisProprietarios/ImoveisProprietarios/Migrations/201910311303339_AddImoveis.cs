namespace ImoveisProprietarios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImoveis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imoveis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.String(),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        ProprietarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Imoveis");
        }
    }
}
