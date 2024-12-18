using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class EnrollmentConfiguration : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentConfiguration() : base()
        {
            // Tablo Adı : Kayıtlar
            ToTable("Enrollments");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Otomatik Artan Bir Değer Olduğunu Belirtme
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun Adlarını, Maksimum Uzunluklarını ve Zorunluluklarını Belirleme
            Property(x => x.StudentId)
                .HasColumnName("StudentId")
                .IsRequired();

            Property(x => x.CourseId)
                .HasColumnName("CourseId")
                .IsRequired();

            Property(x => x.EnrollmentWay)
                .HasColumnName("EnrollmentWay")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .IsRequired();

            Property(x => x.EnrollmentDate)
                .HasColumnName("EnrollmentDate")
                .IsRequired();

            Property(x => x.DeactivetedDate)
                .HasColumnName("DeactivetedDate");

            Property(x => x.DeactivetedReason)
                .HasColumnName("DeactivetedReason")
                .HasMaxLength(500);

            // İlişki Tanımlamaları

            // User tablosundaki Id ile Enrollment tablosundaki StudentId arasında bire - çok ilişki
            HasRequired(x => x.Student) // HasRequired: Enrollment tablosunda StudentId alanı zorunlu bir alandır.
                .WithMany(x => x.Enrollments) // WithMany: Student tablosunda bir öğrencinin birden fazla kaydı olabilir.
                .HasForeignKey(x => x.StudentId) // ForeignKey: Student tablosundaki Id ile Enrollment tablosundaki StudentId arasında ilişki kurulması
                .WillCascadeOnDelete(false);

            // Course tablosundaki Id ile Enrollment tablosundaki CourseId arasında ilişki kurulması
            HasRequired(x => x.Course) // Enrollment tablosunda CourseId alanı zorunlu bir alandır.
                .WithMany(x => x.Enrollments) // Course tablosunda bir dersin birden fazla kaydı olabilir.
                .HasForeignKey(x => x.CourseId)
                .WillCascadeOnDelete(false);
        }
    }
}
