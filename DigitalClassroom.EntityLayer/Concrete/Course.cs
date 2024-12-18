using System;
using System.Collections.Generic;

namespace DigitalClassroom.EntityLayer.Concrete
{
    public class Course
    {
        public int Id { get; set; } // Dersin Id'si
        public int TeacherId { get; set; } // Öğretmenin Id'si
        public int CreatorId { get; set; } // Oluşturan kişinin Id'si
        public int? InstitutionId { get; set; } // Kurum Id'si, Eğer bu alan boş ise öğretmen herhangi bir kuruma bağlı değildir.
        public string AttendanceCode { get; set; } // Öğrencilerin derslere katılabilmesi için kullanılacak olan kod
        public string Title { get; set; } // Dersin adı
        public string Description { get; set; } // Dersin açıklaması - opsiyonel
        public int? CourseCapacity { get; set; } // Dersin kapasitesi - opsiyonel
        public bool IsActive { get; set; } // Dersin aktif olup olmama durumu
        public DateTime CreatedAt { get; set; } // Dersin oluşturulma tarihi
        public DateTime? DeactivetedDate { get; set; } // Pasif hale getirilme tarihi - opsiyonel
        public string DeactivetedReason { get; set; } // Pasif hale getirilme sebebi - opsiyonel

        // Navigation Properties
        public virtual User Teacher { get; set; } // Dersi oluşturan öğretmen
        public virtual User Creator { get; set; } // Dersi oluşturan kişi
        public virtual Institution Institution { get; set; } // Dersin bağlı olduğu kurum
        public virtual ICollection<Enrollment> Enrollments { get; set; } // Dersi alan öğrencilerin kayıtları
        public virtual ICollection<Announcement> Announcements { get; set; } // Dersin duyuruları
        public virtual ICollection<FileAssociation> FileAssociations { get; set; } // Dersin dosyaları
    }
}