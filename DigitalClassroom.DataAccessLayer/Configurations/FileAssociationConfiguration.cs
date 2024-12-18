using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class FileAssociationConfiguration : EntityTypeConfiguration<FileAssociation>
    {
        public FileAssociationConfiguration() : base()
        {
            // Tablo Adı : Dosya İlişkileri
            ToTable("FileAssociations");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary Key'in otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun Adları ve Zorunlulukları
            Property(x => x.FileId)
                .HasColumnName("FileId")
                .IsRequired();

            Property(x => x.UserId)
                .HasColumnName("UserId")
                .IsOptional();

            Property(x => x.AssignmentId)
                .HasColumnName("AssignmentId")
                .IsOptional();

            Property(x => x.InstitutionId)
                .HasColumnName("InstitutionId")
                .IsOptional();

            Property(x => x.AnnouncementId)
                .HasColumnName("AnnouncementId")
                .IsOptional();

            Property(x => x.StudentSubmissionId)
                .HasColumnName("StudentSubmissionId")
                .IsOptional();

            Property(x => x.CourseId)
                .HasColumnName("CourseId")
                .IsOptional();

            // İlişki Tanımlamaları

            // FileAssociation - File arasında 1-N ilişki
            HasRequired(x => x.File)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.FileId)
                .WillCascadeOnDelete(false);

            // User tablosu ile FileAssociation tablosu arasında bire - çok ilişki
            HasOptional(x => x.User)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);

            // Assignment tablosu ile FileAssociation tablosu arasında bire - çok ilişki
            HasOptional(x => x.Assignment)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.AssignmentId)
                .WillCascadeOnDelete(false);

            // Institution tablosu ile FileAssociation tablosu arasında bire - çok ilişki
            HasOptional(x => x.Institution)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.InstitutionId)
                .WillCascadeOnDelete(false);

            // Announcement tablosu ile FileAssociation tablosu arasında bire - çok ilişki
            HasOptional(x => x.Announcement)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.AnnouncementId)
                .WillCascadeOnDelete(false);

            // StudentSubmission tablosu ile FileAssociation tablosu arasında bire - çok ilişki
            HasOptional(x => x.StudentSubmission)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.StudentSubmissionId)
                .WillCascadeOnDelete(false);

            // Course tablosu ile FileAssociation tablosu arasında bire - çok ilişki
            HasOptional(x => x.Course)
                .WithMany(x => x.FileAssociations)
                .HasForeignKey(x => x.CourseId)
                .WillCascadeOnDelete(false);
        }
    }
}
