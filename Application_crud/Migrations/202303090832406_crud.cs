namespace Application_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crud : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "PageNumber");
            DropColumn("dbo.Employees", "ItemsPerPage");
            DropColumn("dbo.Employees", "TotalItems");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "TotalItems", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "ItemsPerPage", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "PageNumber", c => c.Int(nullable: false));
        }
    }
}
