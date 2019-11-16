namespace faculty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.students", "DeptID", "dbo.Departments");
            DropIndex("dbo.students", new[] { "DeptID" });
            AlterColumn("dbo.students", "DeptID", c => c.Int());
            CreateIndex("dbo.students", "DeptID");
            AddForeignKey("dbo.students", "DeptID", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.students", "DeptID", "dbo.Departments");
            DropIndex("dbo.students", new[] { "DeptID" });
            AlterColumn("dbo.students", "DeptID", c => c.Int(nullable: false));
            CreateIndex("dbo.students", "DeptID");
            AddForeignKey("dbo.students", "DeptID", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
