namespace MvcBoard_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationStoneIsland : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Threads",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        threadId = c.Int(nullable: false),
                        Board_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Boards", t => t.Board_id)
                .Index(t => t.Board_id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        threadId = c.Int(nullable: false),
                        Email = c.String(),
                        Title = c.String(),
                        Time = c.DateTime(nullable: false),
                        Message = c.String(),
                        Ip = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Threads", t => t.threadId, cascadeDelete: true)
                .Index(t => t.threadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Threads", "Board_id", "dbo.Boards");
            DropForeignKey("dbo.Posts", "ThreadId", "dbo.Threads");
            DropIndex("dbo.Posts", new[] { "ThreadId" });
            DropIndex("dbo.Threads", new[] { "Board_id" });
            DropTable("dbo.Posts");
            DropTable("dbo.Threads");
            DropTable("dbo.Boards");
        }
    }
}
