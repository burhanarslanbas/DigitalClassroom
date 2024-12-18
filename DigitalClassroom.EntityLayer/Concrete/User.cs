using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class User
    {
        public int Id { get; set; } // Kullanıcı Id'si
        public int RoleId { get; set; } // Öğrenci, Öğretmen, Kurum Yöneticisi veya Admin
        public int? InstitutionId { get; set; } // Kurum Id'si, Eğer bu alan boş ise öğretmen herhangi bir kuruma bağlı değildir. - opsiyonel
        public string Name { get; set; } // Kullanıcının adı
        public string Surname { get; set; } // Kullanıcının soyadı
        public string Email { get; set; } // Kullanıcının e-posta adresi
        public string Password { get; set; } // Kullanıcının şifresi
        public string PhoneNumber { get; set; } // Kullanıcının telefon numarası - opsiyonel
        public bool IsActive { get; set; } // Kullanıcının aktif olup olmama durumu - opsiyonel
        public DateTime CreatedAt { get; set; } // Kullanıcının oluşturulma tarihi - opsiyonel
        public DateTime? UpdatedAt { get; set; } // Kullanıcının güncellenme tarihi - opsiyonel
        public DateTime? DeactivetedDate { get; set; } // Pasif hale getirilme tarihi - opsiyonel
        public string DeactivetedReason { get; set; } // Pasif hale getirilme sebebi - opsiyonel

        // Navigation Properties
        public virtual Role Role { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual ICollection<MailVerification> MailVerifications { get; set; }
        public virtual ICollection<StudentSubmission> StudentSubmissions { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<FileAssociation> FileAssociations { get; set; }
        public virtual ICollection<File> Files { get; set; }
        // Navigation Property için tanımlama yaparken "virtual" keyword'ünü kullanırsak; Entity Framework, bu property'nin değerini veritabanından çekerken otomatik olarak yükler.
        // Bu sayede veritabanından çekilen verilerin daha performanslı bir şekilde yüklenmesi sağlanır. Bu işlem "Lazy Loading" olarak adlandırılır.
    }
}