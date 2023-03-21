namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taikhoan : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Coures", name: "Lecturer_Id", newName: "LecturerId");
            RenameIndex(table: "dbo.Coures", name: "IX_Lecturer_Id", newName: "IX_LecturerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Coures", name: "IX_LecturerId", newName: "IX_Lecturer_Id");
            RenameColumn(table: "dbo.Coures", name: "LecturerId", newName: "Lecturer_Id");
        }
    }
}
