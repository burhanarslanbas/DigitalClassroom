using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class AnnouncementConfiguration : EntityTypeConfiguration<Announcement>
    {
        public AnnouncementConfiguration() : base()
        {
            // Tablo Adı : Duyurular
            ToTable("Announcements");

            // Primary key alanını belirleme
            HasKey(x => x.Id);

            // Primary key alanının otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun adlarını, maksimum uzunluklarını ve zorunluluklarını belirleme
            Property(x => x.Id)
                .HasColumnName("Id");

            Property(x => x.CourseId)
                .HasColumnName("CourseId")
                .IsOptional();

            Property(x => x.InstitutionId)
                .HasColumnName("InstitutionId")
                .IsOptional();

            Property(x => x.CreatorId)
                .HasColumnName("CreatorId")
                .IsRequired();

            Property(x => x.Title)
                .HasColumnName("Title")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Message)
                .HasColumnName("Message")
                .IsRequired();

            Property(x => x.IsDeleted)
                .HasColumnName("IsDeleted")
                .IsRequired();

            Property(x => x.CreatedAt)
                .HasColumnName("CreatedAt")
                .HasColumnType("datetime2")
                .IsRequired();

            Property(x => x.UpdatedAt)
                .HasColumnName("UpdatedAt")
                .HasColumnType("datetime2")
                .IsOptional();

            Property(x => x.DeletedAt)
                .HasColumnName("DeletedAt")
                .HasColumnType("datetime2")
                .IsOptional();

            // İlişki Tanımlamaları

            // Course tablosu ile Announcement tablosu arasında bire - çok ilişki
            HasOptional(x => x.Course)
                .WithMany(x => x.Announcements)
                .HasForeignKey(x => x.CourseId)
                .WillCascadeOnDelete(false);

            // User tablosu ile Announcement tablosu arasında bire - çok ilişki
            HasRequired(x => x.Creator)
                .WithMany(x => x.Announcements)
                .HasForeignKey(x => x.CreatorId)
                .WillCascadeOnDelete(false);

            // Institution tablosu ile Announcement tablosu arasında bire - çok ilişki
            HasOptional(x => x.Institution)
                .WithMany(x => x.Announcements)
                .HasForeignKey(x => x.InstitutionId)
                .WillCascadeOnDelete(false);

        }
    }
}
