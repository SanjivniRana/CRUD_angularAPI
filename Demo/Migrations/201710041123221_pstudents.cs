namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pstudents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PStudents");
        }
    }
}
