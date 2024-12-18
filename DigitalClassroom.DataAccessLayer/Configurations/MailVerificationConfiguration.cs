using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class MailVerificationConfiguration: EntityTypeConfiguration<MailVerification>
    {
        public MailVerificationConfiguration():base()
        {
            // Tablo Adı : Mail Doğrulamaları
            ToTable("MailVerifications");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary key alanının otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun adlarını, maksimum uzunluklarını ve zorunluluklarını belirleme
            Property(x => x.UserId)
                .HasColumnName("UserId")
                .IsRequired();

            Property(x => x.VerificationCode)
                .HasColumnName("VerificationCode")
                .HasMaxLength(6)
                .IsRequired();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .IsRequired();

            Property(x => x.IsVerify)
                .HasColumnName("IsVerify")
                .IsRequired();

            Property(x => x.VerifiedAt)
                .HasColumnName("VerifiedAt")
                .IsOptional();

            Property(x => x.CreatedAt)
                .HasColumnName("CreatedAt")
                .IsRequired();

            Property(x => x.UpdatedAt)
                .HasColumnName("UpdatedAt")
                .IsOptional();

            // İlişki Tanımlamaları
            // User tablosundaki Id ile MailVerification tablosundaki UserId arasında bire - çok ilişki
            HasRequired(x => x.User)
                .WithMany(x => x.MailVerifications)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
