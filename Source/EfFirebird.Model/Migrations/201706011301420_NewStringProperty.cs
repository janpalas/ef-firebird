namespace EfFirebird.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewStringProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Isbn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Isbn");
        }
    }
}
