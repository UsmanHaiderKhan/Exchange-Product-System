namespace EPSClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertConversationUserObjectToID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Converstions", "User1_Id", "dbo.Users");
            DropForeignKey("dbo.Converstions", "User2_Id", "dbo.Users");
            DropIndex("dbo.Converstions", new[] { "User1_Id" });
            DropIndex("dbo.Converstions", new[] { "User2_Id" });
            AddColumn("dbo.Converstions", "User1", c => c.Int(nullable: false));
            AddColumn("dbo.Converstions", "User2", c => c.Int(nullable: false));
            DropColumn("dbo.Converstions", "User1_Id");
            DropColumn("dbo.Converstions", "User2_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Converstions", "User2_Id", c => c.Int());
            AddColumn("dbo.Converstions", "User1_Id", c => c.Int());
            DropColumn("dbo.Converstions", "User2");
            DropColumn("dbo.Converstions", "User1");
            CreateIndex("dbo.Converstions", "User2_Id");
            CreateIndex("dbo.Converstions", "User1_Id");
            AddForeignKey("dbo.Converstions", "User2_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Converstions", "User1_Id", "dbo.Users", "Id");
        }
    }
}
