namespace DigitalClassroom.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnTypeUpdatedatetime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Announcements", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Announcements", "UpdatedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Announcements", "DeletedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Courses", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Courses", "DeactivetedDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "UpdatedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Users", "DeactivetedDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Enrollments", "EnrollmentDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Enrollments", "DeactivetedDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Assignments", "DueDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Assignments", "CreatedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.StudentSubmissions", "SubmittedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.StudentSubmissions", "UpdatedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Files", "UploadedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Institutions", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Institutions", "UpdatedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.MailVerifications", "VerifiedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.MailVerifications", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.MailVerifications", "UpdatedAt", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MailVerifications", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.MailVerifications", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MailVerifications", "VerifiedAt", c => c.DateTime());
            AlterColumn("dbo.Institutions", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Institutions", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Files", "UploadedAt", c => c.DateTime());
            AlterColumn("dbo.StudentSubmissions", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.StudentSubmissions", "SubmittedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Assignments", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Assignments", "DueDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Enrollments", "DeactivetedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Enrollments", "EnrollmentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "DeactivetedDate", c => c.DateTime());
            AlterColumn("dbo.Users", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "DeactivetedDate", c => c.DateTime());
            AlterColumn("dbo.Courses", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Announcements", "DeletedAt", c => c.DateTime());
            AlterColumn("dbo.Announcements", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Announcements", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
