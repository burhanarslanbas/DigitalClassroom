namespace DigitalClassroom.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstitutionContactNumberLengthUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Institutions", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Institutions", "ContactNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Institutions", "Email", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Institutions", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Institutions", "ContactNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Institutions", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
