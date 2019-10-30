namespace SistemaImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovel", "Teste", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Imovel", "Teste");
        }
    }
}
