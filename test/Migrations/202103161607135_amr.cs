namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class amr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Address", c => c.String());
            AddColumn("dbo.Employees", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "Address");
        }
    }
}
