namespace EPSClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMessageEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "TimeOfMsg", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "TimeOfMsg");
        }
    }
}
