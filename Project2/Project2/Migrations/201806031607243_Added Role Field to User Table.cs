namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRoleFieldtoUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Role");
        }
    }
}
