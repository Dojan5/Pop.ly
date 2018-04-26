namespace Pop.ly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Letsgiveitashot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MobilePhone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MobilePhone");
        }
    }
}
