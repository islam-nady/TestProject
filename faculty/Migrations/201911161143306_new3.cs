namespace faculty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.instructors", "DeptID", "dbo.Departments");
            DropIndex("dbo.instructors", new[] { "DeptID" });
            AlterColumn("dbo.instructors", "DeptID", c => c.Int());
            CreateIndex("dbo.instructors", "DeptID");
            AddForeignKey("dbo.instructors", "DeptID", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.instructors", "DeptID", "dbo.Departments");
            DropIndex("dbo.instructors", new[] { "DeptID" });
            AlterColumn("dbo.instructors", "DeptID", c => c.Int(nullable: false));
            CreateIndex("dbo.instructors", "DeptID");
            AddForeignKey("dbo.instructors", "DeptID", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
