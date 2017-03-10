namespace PizzaMore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Neshto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Recipe = c.String(),
                        ImageUrl = c.String(),
                        UpVotes = c.Int(nullable: false),
                        DownVotes = c.Int(nullable: false),
                        OwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Pizzas", "OwnerId", "dbo.Users");
            DropIndex("dbo.Sessions", new[] { "UserId" });
            DropIndex("dbo.Pizzas", new[] { "OwnerId" });
            DropTable("dbo.Sessions");
            DropTable("dbo.Users");
            DropTable("dbo.Pizzas");
        }
    }
}
