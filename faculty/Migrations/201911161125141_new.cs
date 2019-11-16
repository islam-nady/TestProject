namespace faculty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.instructors", "Photo", c => c.String());
            AddColumn("dbo.AspNetUsers", "userKind", c => c.String());
            AddColumn("dbo.students", "Photo", c => c.String());
            AlterColumn("dbo.instructors", "salary", c => c.String(maxLength: 12));
            AlterColumn("dbo.students", "degree", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.students", "degree", c => c.String(nullable: false));
            AlterColumn("dbo.instructors", "salary", c => c.String(nullable: false, maxLength: 12));
            DropColumn("dbo.students", "Photo");
            DropColumn("dbo.AspNetUsers", "userKind");
            DropColumn("dbo.instructors", "Photo");
        }
    }
}
