using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration() : base()
        {
            // Tablo Adı : Kurslar
            ToTable("Courses");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary key alanının otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun adlarını, maksimum uzunluklarını ve zorunluluklarını belirleme
            Property(x => x.Id)
                .HasColumnName("Id");

            Property(x => x.TeacherId)
                .HasColumnName("TeacherId")
                .IsRequired();

            Property(x => x.CreatorId)
                .HasColumnName("CreatorId")
                .IsRequired();

            Property(x => x.InstitutionId)
                .HasColumnName("InstitutionId")
                .IsOptional();

            Property(x => x.AttendanceCode)
                .HasColumnName("AttendanceCode")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Title)
                .HasColumnName("Title")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(1000)
                .IsOptional();

            Property(x => x.CourseCapacity)
                .HasColumnName("CourseCapacity")
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .IsRequired();

            Property(x => x.CreatedAt)
                .HasColumnName("CreatedAt")
                .IsRequired();

            Property(x => x.DeactivetedDate)
                .HasColumnName("DeactivetedDate")
                .IsOptional();

            Property(x => x.DeactivetedReason)
                .HasColumnName("DeactivetedReason")
                .HasMaxLength(500)
                .IsOptional();

            // Foreign key ilişkilerini ve ilişkili tabloları belirleme
            // HasRequired() metodu ile ilişkili tablonun zorunlu olup olmadığını belirleriz. Eğer ilişkili tablo zorunlu ise HasRequired() metodu kullanılır. Eğer ilişkili tablo zorunlu değilse HasOptional() metodu kullanılır.
            // WithMany() metodu ile ilişkili tablonun ilişkili tablodan kaç tane kaydı olabileceğini belirleriz. Eğer ilişkili tablodan birden fazla kayıt olabilirse WithMany() metodu kullanılır. Eğer ilişkili tablodan sadece bir tane kayıt olabilirse WithRequired() metodu kullanılır.
            // HasForeignKey() metodu ile ilişkili tablonun hangi alanı ile ilişkilendirileceğini belirleriz.

            // User tablosundaki Id ile Course tablosundaki TeacherId arasında bire - çok ilişki
            HasRequired(x => x.Teacher)
                .WithMany() // Bir öğretmenin birden fazla dersi olabilir.
                .HasForeignKey(x => x.TeacherId)
                .WillCascadeOnDelete(false);

            // User tablosundaki Id ile Course tablosundaki CreatorId arasında bire - çok ilişki
            HasRequired(x => x.Creator)
                .WithMany()
                .HasForeignKey(x => x.CreatorId)
                .WillCascadeOnDelete(false);

            // Institution tablosundaki Id ile Course tablosundaki InstitutionId arasında bire - çok ilişki
            HasOptional(x => x.Institution)
                .WithMany() // Bir kurumun birden fazla dersi olabilir.
                .HasForeignKey(x => x.InstitutionId)
                .WillCascadeOnDelete(false);
        }
    }
}
