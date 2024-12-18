namespace DigitalClassroom.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Announcements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(),
                        InstitutionId = c.Int(),
                        CreatorId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Message = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeletedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Users", t => t.CreatorId)
                .ForeignKey("dbo.Institutions", t => t.InstitutionId)
                .Index(t => t.CourseId)
                .Index(t => t.InstitutionId)
                .Index(t => t.CreatorId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        InstitutionId = c.Int(),
                        AttendanceCode = c.String(nullable: false, maxLength: 50),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 1000),
                        CourseCapacity = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        DeactivetedDate = c.DateTime(),
                        DeactivetedReason = c.String(maxLength: 500),
                        User_Id = c.Int(),
                        Institution_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Institutions", t => t.Institution_Id)
                .ForeignKey("dbo.Users", t => t.CreatorId)
                .ForeignKey("dbo.Institutions", t => t.InstitutionId)
                .ForeignKey("dbo.Users", t => t.TeacherId)
                .Index(t => t.TeacherId)
                .Index(t => t.CreatorId)
                .Index(t => t.InstitutionId)
                .Index(t => t.User_Id)
                .Index(t => t.Institution_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        InstitutionId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeactivetedDate = c.DateTime(),
                        DeactivetedReason = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institutions", t => t.InstitutionId)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId)
                .Index(t => t.InstitutionId);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        EnrollmentWay = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                        DeactivetedDate = c.DateTime(nullable: false),
                        DeactivetedReason = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Users", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.FileAssociations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileId = c.Int(nullable: false),
                        UserId = c.Int(),
                        AssignmentId = c.Int(),
                        InstitutionId = c.Int(),
                        AnnouncementId = c.Int(),
                        StudentSubmissionId = c.Int(),
                        CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Announcements", t => t.AnnouncementId)
                .ForeignKey("dbo.Assignments", t => t.AssignmentId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Files", t => t.FileId)
                .ForeignKey("dbo.Institutions", t => t.InstitutionId)
                .ForeignKey("dbo.StudentSubmissions", t => t.StudentSubmissionId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.FileId)
                .Index(t => t.UserId)
                .Index(t => t.AssignmentId)
                .Index(t => t.InstitutionId)
                .Index(t => t.AnnouncementId)
                .Index(t => t.StudentSubmissionId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                        MaxScore = c.Double(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Users", t => t.CreatorId)
                .Index(t => t.CourseId)
                .Index(t => t.CreatorId);
            
            CreateTable(
                "dbo.StudentSubmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        AssignmentId = c.Int(nullable: false),
                        Content = c.String(),
                        Status = c.String(nullable: false),
                        Score = c.Double(),
                        SubmittedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Assignments", t => t.AssignmentId)
                .ForeignKey("dbo.Users", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.AssignmentId);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UploaderId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Path = c.String(nullable: false, maxLength: 500),
                        Type = c.String(nullable: false, maxLength: 20),
                        Size = c.Long(nullable: false),
                        UploadedAt = c.DateTime(),
                        Metadata = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UploaderId)
                .Index(t => t.UploaderId);
            
            CreateTable(
                "dbo.Institutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManagerId = c.Int(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 255),
                        ContactNumber = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                        DeactivetedDate = c.DateTime(),
                        DeactivetedReason = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatorId)
                .ForeignKey("dbo.Users", t => t.ManagerId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.ManagerId)
                .Index(t => t.CreatorId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.MailVerifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        VerificationCode = c.String(nullable: false, maxLength: 6),
                        IsActive = c.Boolean(nullable: false),
                        IsVerify = c.Boolean(nullable: false),
                        VerifiedAt = c.DateTime(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Announcements", "InstitutionId", "dbo.Institutions");
            DropForeignKey("dbo.Announcements", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Announcements", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Users");
            DropForeignKey("dbo.Courses", "InstitutionId", "dbo.Institutions");
            DropForeignKey("dbo.Courses", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.MailVerifications", "UserId", "dbo.Users");
            DropForeignKey("dbo.Institutions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "InstitutionId", "dbo.Institutions");
            DropForeignKey("dbo.FileAssociations", "UserId", "dbo.Users");
            DropForeignKey("dbo.FileAssociations", "StudentSubmissionId", "dbo.StudentSubmissions");
            DropForeignKey("dbo.FileAssociations", "InstitutionId", "dbo.Institutions");
            DropForeignKey("dbo.Institutions", "ManagerId", "dbo.Users");
            DropForeignKey("dbo.Institutions", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Courses", "Institution_Id", "dbo.Institutions");
            DropForeignKey("dbo.FileAssociations", "FileId", "dbo.Files");
            DropForeignKey("dbo.Files", "UploaderId", "dbo.Users");
            DropForeignKey("dbo.FileAssociations", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.FileAssociations", "AssignmentId", "dbo.Assignments");
            DropForeignKey("dbo.StudentSubmissions", "StudentId", "dbo.Users");
            DropForeignKey("dbo.StudentSubmissions", "AssignmentId", "dbo.Assignments");
            DropForeignKey("dbo.Assignments", "CreatorId", "dbo.Users");
            DropForeignKey("dbo.Assignments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.FileAssociations", "AnnouncementId", "dbo.Announcements");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Users");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "User_Id", "dbo.Users");
            DropIndex("dbo.MailVerifications", new[] { "UserId" });
            DropIndex("dbo.Institutions", new[] { "User_Id" });
            DropIndex("dbo.Institutions", new[] { "CreatorId" });
            DropIndex("dbo.Institutions", new[] { "ManagerId" });
            DropIndex("dbo.Files", new[] { "UploaderId" });
            DropIndex("dbo.StudentSubmissions", new[] { "AssignmentId" });
            DropIndex("dbo.StudentSubmissions", new[] { "StudentId" });
            DropIndex("dbo.Assignments", new[] { "CreatorId" });
            DropIndex("dbo.Assignments", new[] { "CourseId" });
            DropIndex("dbo.FileAssociations", new[] { "CourseId" });
            DropIndex("dbo.FileAssociations", new[] { "StudentSubmissionId" });
            DropIndex("dbo.FileAssociations", new[] { "AnnouncementId" });
            DropIndex("dbo.FileAssociations", new[] { "InstitutionId" });
            DropIndex("dbo.FileAssociations", new[] { "AssignmentId" });
            DropIndex("dbo.FileAssociations", new[] { "UserId" });
            DropIndex("dbo.FileAssociations", new[] { "FileId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Users", new[] { "InstitutionId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Courses", new[] { "Institution_Id" });
            DropIndex("dbo.Courses", new[] { "User_Id" });
            DropIndex("dbo.Courses", new[] { "InstitutionId" });
            DropIndex("dbo.Courses", new[] { "CreatorId" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Announcements", new[] { "CreatorId" });
            DropIndex("dbo.Announcements", new[] { "InstitutionId" });
            DropIndex("dbo.Announcements", new[] { "CourseId" });
            DropTable("dbo.Roles");
            DropTable("dbo.MailVerifications");
            DropTable("dbo.Institutions");
            DropTable("dbo.Files");
            DropTable("dbo.StudentSubmissions");
            DropTable("dbo.Assignments");
            DropTable("dbo.FileAssociations");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Users");
            DropTable("dbo.Courses");
            DropTable("dbo.Announcements");
        }
    }
}
