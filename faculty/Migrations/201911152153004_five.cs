namespace faculty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class five : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Departmentcourses",
                c => new
                    {
                        dept_id = c.Int(nullable: false),
                        course_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.dept_id, t.course_id })
                .ForeignKey("dbo.Courses", t => t.course_id, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.dept_id, cascadeDelete: true)
                .Index(t => t.dept_id)
                .Index(t => t.course_id);
            
            CreateTable(
                "dbo.instructors",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        salary = c.String(nullable: false, maxLength: 12),
                        DeptID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.id)
                .ForeignKey("dbo.Departments", t => t.DeptID, cascadeDelete: true)
                .Index(t => t.id)
                .Index(t => t.DeptID);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        degree = c.String(nullable: false),
                        DeptID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.id)
                .ForeignKey("dbo.Departments", t => t.DeptID, cascadeDelete: true)
                .Index(t => t.id)
                .Index(t => t.DeptID);
            
            CreateTable(
                "dbo.studentCourses",
                c => new
                    {
                        course_id = c.Int(nullable: false),
                        student_id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.course_id, t.student_id })
                .ForeignKey("dbo.Courses", t => t.course_id, cascadeDelete: true)
                .ForeignKey("dbo.students", t => t.student_id, cascadeDelete: true)
                .Index(t => t.course_id)
                .Index(t => t.student_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departmentcourses", "dept_id", "dbo.Departments");
            DropForeignKey("dbo.studentCourses", "student_id", "dbo.students");
            DropForeignKey("dbo.studentCourses", "course_id", "dbo.Courses");
            DropForeignKey("dbo.students", "DeptID", "dbo.Departments");
            DropForeignKey("dbo.students", "id", "dbo.AspNetUsers");
            DropForeignKey("dbo.instructors", "DeptID", "dbo.Departments");
            DropForeignKey("dbo.instructors", "id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Departmentcourses", "course_id", "dbo.Courses");
            DropIndex("dbo.studentCourses", new[] { "student_id" });
            DropIndex("dbo.studentCourses", new[] { "course_id" });
            DropIndex("dbo.students", new[] { "DeptID" });
            DropIndex("dbo.students", new[] { "id" });
            DropIndex("dbo.instructors", new[] { "DeptID" });
            DropIndex("dbo.instructors", new[] { "id" });
            DropIndex("dbo.Departmentcourses", new[] { "course_id" });
            DropIndex("dbo.Departmentcourses", new[] { "dept_id" });
            DropTable("dbo.studentCourses");
            DropTable("dbo.students");
            DropTable("dbo.instructors");
            DropTable("dbo.Departmentcourses");
            DropTable("dbo.Courses");
        }
    }
}
