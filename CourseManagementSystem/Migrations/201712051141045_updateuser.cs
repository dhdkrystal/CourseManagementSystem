namespace CourseManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Province = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "School_Id", c => c.Int());
            CreateIndex("dbo.Users", "School_Id");
            AddForeignKey("dbo.Users", "School_Id", "dbo.Schools", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "School_Id", "dbo.Schools");
            DropIndex("dbo.Users", new[] { "School_Id" });
            DropColumn("dbo.Users", "School_Id");
            DropTable("dbo.Schools");
        }
    }
}
