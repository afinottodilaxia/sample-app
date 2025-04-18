namespace SampleMVCApp.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AggiungiTabellaProdotti : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prodotti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeProdotto = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Quantita = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prodotti");
        }
    }
}
