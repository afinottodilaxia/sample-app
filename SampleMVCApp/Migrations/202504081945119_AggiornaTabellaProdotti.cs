namespace SampleMVCApp.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AggiornaTabellaProdotti : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Prodotti", "Note", c => c.String(maxLength: 10000, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prodotti", "Note", c => c.String(unicode: false));
        }
    }
}
