namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.teachers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        strname = c.String(),
                        tel = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.teachers");
        }
    }
}
