using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class StudentSubmissionConfiguration : EntityTypeConfiguration<StudentSubmission>
    {
        public StudentSubmissionConfiguration() : base()
        {
            // Tablo Adı : Öğrenci Teslimleri
            ToTable("StudentSubmissions");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary key alanının otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun adlarını, maksimum uzunluklarını ve zorunluluklarını belirleme
            Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            Property(x => x.StudentId)
                .HasColumnName("StudentId")
                .IsRequired();

            Property(x => x.AssignmentId)
                .HasColumnName("AssignmentId")
                .IsRequired();

            Property(x => x.Content)
                .HasColumnName("Content")
                .IsOptional();

            Property(x => x.Status)
                .HasColumnName("Status")
                .IsRequired();

            Property(x => x.Score)
                .HasColumnName("Score")
                .IsOptional();

            Property(x => x.SubmittedAt)
                .HasColumnName("SubmittedAt")
                .IsRequired();

            Property(x => x.UpdatedAt)
                .HasColumnName("UpdatedAt")
                .IsOptional();

            // İlişki Tanımlamaları

            // User tablosundaki Id ile StudentSubmission tablosundaki StudentId arasında bire - çok ilişki
            HasRequired(x=>x.Student)
                .WithMany(x=>x.StudentSubmissions)
                .HasForeignKey(x => x.StudentId)
                .WillCascadeOnDelete(false);

            // Assignment tablosundaki Id ile StudentSubmission tablosundaki AssignmentId arasında bire - çok ilişki
            HasRequired(x => x.Assignment)
                .WithMany(x => x.StudentSubmissions)
                .HasForeignKey(x => x.AssignmentId)
                .WillCascadeOnDelete(false);
        }
    }
}
