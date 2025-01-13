using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class InstitutionConfiguration : EntityTypeConfiguration<Institution>
    {
        public InstitutionConfiguration() : base()
        {
            // Tablo Adı
            ToTable("Institutions");
            // Primary Key Tanımlama
            HasKey(x => x.Id);
            // Id kolonunun otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun Adları ve Zorunlulukları
            Property(x => x.ManagerId)
                .HasColumnName("ManagerId")
                .IsRequired();

            Property(x => x.CreatorId)
                .HasColumnName("CreatorId")
                .IsRequired();

            Property(x => x.Name)
                .HasColumnName("Name").HasMaxLength(100)
                .IsRequired();

            Property(x => x.Address)
                .HasColumnName("Address")
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.ContactNumber)
                .HasColumnName("ContactNumber")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .IsConcurrencyToken()
                .IsRequired();

            Property(x => x.CreatedAt)
                .HasColumnName("CreatedAt")
                .HasColumnType("datetime2")
                .IsRequired();

            Property(x => x.UpdatedAt)
                .HasColumnName("UpdatedAt")
                .HasColumnType("datetime2")
                .IsOptional();

            Property(x => x.DeactivetedDate)
                .HasColumnName("DeactivetedDate")
                .IsOptional();

            Property(x => x.DeactivetedReason)
                .HasColumnName("DeactivetedReason")
                .IsOptional();

            // İlişki tanımlamaları

            // ManagerId ile User tablosunun Id alanı arasında bire - çok ilişki
            HasRequired(x => x.Manager)
                .WithMany()
                .HasForeignKey(x => x.ManagerId)
                .WillCascadeOnDelete(false);

            // CreatorId ile User tablosunun Id alanı arasında bire - çok ilişki
            HasRequired(x => x.Creator)
                .WithMany()
                .HasForeignKey(x => x.CreatorId)
                .WillCascadeOnDelete(false);
        }
    }
}