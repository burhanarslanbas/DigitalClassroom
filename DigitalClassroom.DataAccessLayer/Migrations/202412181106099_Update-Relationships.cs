namespace DigitalClassroom.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Courses", "Institution_Id", "dbo.Institutions");
            DropForeignKey("dbo.Institutions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Courses", new[] { "User_Id" });
            DropIndex("dbo.Courses", new[] { "Institution_Id" });
            DropIndex("dbo.Institutions", new[] { "User_Id" });
            AddColumn("dbo.Users", "Role_Id", c => c.Int());
            CreateIndex("dbo.Users", "Role_Id");
            AddForeignKey("dbo.Users", "Role_Id", "dbo.Roles", "Id");
            DropColumn("dbo.Courses", "User_Id");
            DropColumn("dbo.Courses", "Institution_Id");
            DropColumn("dbo.Institutions", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Institutions", "User_Id", c => c.Int());
            AddColumn("dbo.Courses", "Institution_Id", c => c.Int());
            AddColumn("dbo.Courses", "User_Id", c => c.Int());
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Role_Id" });
            DropColumn("dbo.Users", "Role_Id");
            CreateIndex("dbo.Institutions", "User_Id");
            CreateIndex("dbo.Courses", "Institution_Id");
            CreateIndex("dbo.Courses", "User_Id");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id");
            AddForeignKey("dbo.Institutions", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Courses", "Institution_Id", "dbo.Institutions", "Id");
            AddForeignKey("dbo.Courses", "User_Id", "dbo.Users", "Id");
        }
    }
}
