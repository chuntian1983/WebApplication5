namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Annotation_Name_Major : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.teachers", "creattime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.teachers", "strname", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.teachers", "tel", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.teachers", "tel", c => c.String());
            AlterColumn("dbo.teachers", "strname", c => c.String());
            DropColumn("dbo.teachers", "creattime");
        }
    }
}
