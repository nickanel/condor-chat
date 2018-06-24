namespace Project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHasAvatarfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HasAvatar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "HasAvatar");
        }
    }
}
