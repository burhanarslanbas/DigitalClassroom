using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            // Tablo Adı : Kullanıcılar
            ToTable("Users");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary key alanının otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun adlarını, maksimum uzunluklarını ve zorunluluklarını belirleme
            Property(x => x.Id)
                .HasColumnName("Id");

            Property(x => x.RoleId)
                .HasColumnName("RoleId")
                .IsRequired();

            Property(x => x.InstitutionId)
                .HasColumnName("InstitutionId")
                .IsOptional();

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Surname)
                .HasColumnName("Surname")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Email)
                .HasColumnName("Email")
                .IsRequired();

            Property(x => x.Password)
                .HasColumnName("Password")
                .IsRequired();

            Property(x => x.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
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
                .HasColumnType("datetime2")
                .IsOptional();

            Property(x => x.DeactivetedReason)
                .HasColumnName("DeactivetedReason")
                .IsOptional();

            // İlişki Tanımlamaları
            
            // Bu ilişki Role Tablosunda tanımlandı.
            //// Role tablosundaki Id ile User tablosundaki RoleId arasında bire - çok ilişki
            //HasRequired(x => x.Role)
            //    .WithMany(x=>x.Users)
            //    .HasForeignKey(x => x.RoleId)
            //    .WillCascadeOnDelete(false);

            // Institution tablosundaki Id ile User tablosundaki InstitutionId arasında bire - çok ilişki
            HasOptional(x=>x.Institution)
                .WithMany()
                .HasForeignKey(x => x.InstitutionId)
                .WillCascadeOnDelete(false);
        }
    }
}
