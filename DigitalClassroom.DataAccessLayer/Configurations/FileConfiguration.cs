using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class FileConfiguration:EntityTypeConfiguration<File>
    {
        
        public FileConfiguration() : base()
        {
            // Tablo Adı : Dosyalar
            ToTable("Files");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Id kolonunun otomatik artan bir değer olduğunu belirtme
            Property(x=>x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun Adları ve Zorunlulukları
            Property(x =>x.UploaderId)
                .HasColumnName("UploaderId")
                .IsRequired();

            Property(x =>x.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.Path)
                .HasColumnName("Path")
                .HasMaxLength(500)
                .IsRequired();

            Property(x => x.Type)
                .HasColumnName("Type")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Size)
                .HasColumnName("Size")
                .IsRequired();

            Property(x => x.UploadedAt)
                .HasColumnName("UploadedAt")
                .IsOptional();

            Property(x => x.Metadata)
                .HasColumnName("Metadata")
                .IsOptional();

            // İlişki Tanımlamaları

            // User tablosundaki Id ile File tablosundaki UploaderId arasında bire - çok ilişki
            HasRequired(x => x.Uploader)
                .WithMany(x=>x.Files)
                .HasForeignKey(x => x.UploaderId)
                .WillCascadeOnDelete(false);
        }
    }
}
