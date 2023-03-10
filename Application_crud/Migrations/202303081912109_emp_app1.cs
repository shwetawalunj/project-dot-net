namespace Application_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp_app1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PageNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "ItemsPerPage", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "TotalItems", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "TotalItems");
            DropColumn("dbo.Employees", "ItemsPerPage");
            DropColumn("dbo.Employees", "PageNumber");
        }
    }
}
