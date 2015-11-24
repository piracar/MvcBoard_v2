namespace MvcBoard_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hui2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Posts", new[] { "threadId" });
            CreateIndex("dbo.Posts", "ThreadId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "ThreadId" });
            CreateIndex("dbo.Posts", "threadId");
        }
    }
}
