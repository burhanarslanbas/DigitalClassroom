using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            // Tablo Adı : Roller
            ToTable("Roles");

            // Primary Key : Id
            HasKey(x => x.Id);

            // Primary key alanının otomatik artan bir değer olduğunu belirtme
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // Sütun adlarını, maksimum uzunluklarını ve zorunluluklarını belirleme
            Property(x => x.Id)
                .HasColumnName("Id");

            Property(x => x.RoleName)
                .HasColumnName("RoleName")
                .HasMaxLength(50)
                .IsRequired();

            // Navigation Property
            //HasMany(x => x.Users)
            //    .WithRequired(x => x.Role)
            //    .HasForeignKey(x => x.RoleId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
