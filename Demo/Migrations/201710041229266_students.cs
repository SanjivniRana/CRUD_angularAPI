namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class students : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PStudents", newName: "Students");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Students", newName: "PStudents");
        }
    }
}
