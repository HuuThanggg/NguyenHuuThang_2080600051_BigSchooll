namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LucturerId = c.String(nullable: false),
                        Place = c.String(nullable: false, maxLength: 250),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        Lecturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Lecturer_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.Lecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coures", "Lecturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Coures", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Coures", new[] { "Lecturer_Id" });
            DropIndex("dbo.Coures", new[] { "CategoryId" });
            DropTable("dbo.Coures");
            DropTable("dbo.Categories");
        }
    }
}
