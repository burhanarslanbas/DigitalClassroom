using DigitalClassroom.EntityLayer.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class AssignmentConfiguration : EntityTypeConfiguration<Assignment>
    {
        public AssignmentConfiguration() : base()
        {
            // Tablo Adı : Görevler
            ToTable("Assignments");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary Key'in Otomatik Artan Bir Değer Olduğunu Belirtme
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun Adlarını, Maksimum Uzunluklarını ve Zorunluluklarını Belirleme
            Property(x => x.Id)
                .HasColumnName("Id");

            Property(x => x.CourseId)
                .HasColumnName("CourseId");

            Property(x=>x.CreatorId)
                .HasColumnName("CreatorId")
                .IsRequired(); // Zorunlu Alan

            Property(x => x.Title)
                .HasColumnName("Title")
                .HasMaxLength(50) // Maksimum Uzunluk
                .IsRequired(); 

            Property(x => x.Description)
                .HasColumnName("Description")
                .IsRequired();

            Property(x => x.MaxScore)
                .HasColumnName("MaxScore")
                .IsRequired();

            Property(x => x.DueDate)
                .HasColumnName("DueDate")
                .HasColumnType("datetime2")
                .IsRequired();

            Property(x => x.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2")
                .IsRequired();

            // İlişki Tanımlamaları

            // Course Tablosu ile Assignment Tablosu Arasında Bire - Çok İlişki
            HasRequired(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .WillCascadeOnDelete(false);

            // User Tablosu ile Assignment Tablosu Arasında Bire - Çok İlişki
            HasRequired(x => x.Creator)
                .WithMany()
                .HasForeignKey(x => x.CreatorId)
                .WillCascadeOnDelete(false);
        }
    }
}