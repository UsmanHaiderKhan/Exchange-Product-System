namespace EPSClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewConversationProp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Converstions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User1 = c.Int(nullable: false),
                        User2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Messages", "ReadStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "Converstion_Id", c => c.Int());
            CreateIndex("dbo.Messages", "Converstion_Id");
            AddForeignKey("dbo.Messages", "Converstion_Id", "dbo.Converstions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "Converstion_Id", "dbo.Converstions");
            DropIndex("dbo.Messages", new[] { "Converstion_Id" });
            DropColumn("dbo.Messages", "Converstion_Id");
            DropColumn("dbo.Messages", "ReadStatus");
            DropTable("dbo.Converstions");
        }
    }
}
